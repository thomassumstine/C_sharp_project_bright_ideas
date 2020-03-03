using System;
using System.Collections.Generic;
using System.Linq;
using BrightIdeas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BrightIdeas.Controllers
{
    public class BrightIdeaController : Controller
    {
        private BrightIdeasContext _db;
        private int? _uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }
        private bool _isLoggedIn
        {
            get
            {
                int? uid = _uid;

                if (uid != null)
                {
                    User loggedInUser =
                        _db.Users.FirstOrDefault(u => u.UserId == uid);

                    HttpContext.Session
                        .SetString("FullName", loggedInUser.FullName());
                }
                return uid != null;
            }
        }

        public BrightIdeaController(BrightIdeasContext context)
        {
            _db = context;
        }

        [HttpGet("brightidea/all")]
        public IActionResult All()
        {
            int? uid = _uid;

            if (!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<BrightIdea> allBrightIdea = _db.BrightIdea
                .Include(brightidea => brightidea.Author)
                .Include(brightidea => brightidea.Likes)
                .ThenInclude(l => l.Liker).ToList();

            // Add ViewBag lines only before return View
            ViewBag.FullName = HttpContext.Session.GetString("FullName");
            ViewBag.Uid = _uid;
            return View(allBrightIdea);
        }

        [HttpGet("brightidea/idforaliasdetails/{idforaliasdetails}")]
        public IActionResult AliasDetails(int idforaliasdetails)
        {
            BrightIdea thisselectedBrightIdea = _db.BrightIdea
                .Include(thisbrightidea => thisbrightidea.Author)
                .FirstOrDefault(b => b.BrightIdeaId == idforaliasdetails);

            // in case user manually types URL
            if (thisselectedBrightIdea == null)
                RedirectToAction("All");

            ViewBag.Uid = _uid;
            return View(thisselectedBrightIdea);
        }

        [HttpGet("brightidea/idforlikersdetails/{idforlikersdetails}")]
        public IActionResult LikersDetails(int idforlikersdetails)
        {
            BrightIdea thatselectedBrightIdea = _db.BrightIdea
                .Include(thatbrightidea => thatbrightidea.Author)
                .Include(thatbrightidea => thatbrightidea.Likes)
                .Include(thatbrightidea => thatbrightidea.Content)
                .FirstOrDefault(b => b.BrightIdeaId == idforlikersdetails);

            // in case user manually types URL
            if (thatselectedBrightIdea == null)
                RedirectToAction("All");

            ViewBag.Uid = _uid;
            return View(thatselectedBrightIdea);
        }

        [HttpGet("brightidea/new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("brightidea/create")]
        public IActionResult Create(BrightIdea newBrightIdea)
        {

            if (ModelState.IsValid)
            {
                if (_uid != null)
                {
                    newBrightIdea.UserId = (int)_uid;

                    _db.BrightIdea.Add(newBrightIdea);
                    _db.SaveChanges();
                    return RedirectToAction("All");
                }
                else // no one in session
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet("BrightIdea/Like/{brightideaId}/{isLike}")]
        public IActionResult Like(int brightideaId, bool isLike)
        {
            if (!_isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            // if the post exists
            if (_db.BrightIdea.Any(brightidea => brightidea.BrightIdeaId == brightideaId))
            {
                Like foundLike = _db.Likes
                    .FirstOrDefault(like => like.UserId == _uid
                        && like.BrightIdeaId == brightideaId);

                if (foundLike == null)
                {
                    Like newLike = new Like
                    {
                        BrightIdeaId = brightideaId,
                        IsLike = isLike,
                        UserId = (int)_uid
                    };
                    _db.Likes.Add(newLike);
                }
                else // vote already exists
                {
                    // if new vote is same as existing vote
                    if (foundLike.IsLike == isLike)
                    {
                        _db.Remove(foundLike);
                    }
                    else // changing vote
                    {
                        foundLike.IsLike = isLike;
                    }
                }
                _db.SaveChanges();
            }
            return RedirectToAction("All");
        }

        // [HttpGet("Posts/Vote/{postId}/{isUpvote}")]
        // public IActionResult Vote(int postId, bool isUpvote)
        // {
        //     if (!_isLoggedIn)
        //     {
        //         return RedirectToAction("Index", "Home");
        //     }

        //     // if the post exists
        //     if (_db.Posts.Any(post => post.PostId == postId))
        //     {

        //         Vote foundVote = _db.Votes
        //             .FirstOrDefault(vote => vote.UserId == _uid 
        //             && vote.PostId == postId);

        //         if (foundVote != null)
        //         {
        //             _db.Votes.Remove(foundVote);
        //         }
        //          // if the first part of the || is true, the second part
                    // is not checked. This is needed because if the
                    // foundVote is null, we will get an error trying
                    // to access a property on it
        //         if (foundVote == null || foundVote.IsUpvote != isUpvote)
        //         {
        // Vote newVote = new Vote
        // {
        //     PostId = postId,
        //     IsUpvote = isUpvote,
        //     UserId = (int)_uid
        // };
        // _db.Votes.Add(newVote);
        //         }
        //         // save changes to save the potentialy
        //         // deletion and the potential new vote
        //         _db.SaveChanges();
        //     }
        // return RedirectToAction("All");
        // }

        [HttpGet("brightidea/delete/{id}")]
        public IActionResult Delete(int id)
        {
            BrightIdea brightideaFromDb = _db.BrightIdea.FirstOrDefault(brightidea => brightidea.BrightIdeaId == id);

            if (brightideaFromDb != null)
            {
                _db.BrightIdea.Remove(brightideaFromDb);
                _db.SaveChanges();
            }

            return RedirectToAction("All");
        }
    }
}