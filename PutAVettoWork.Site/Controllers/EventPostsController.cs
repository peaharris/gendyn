﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PutAVettoWork.Site.Data;
using PutAVettoWork.Site.Models;

namespace PutAVettoWork.Site.Controllers
{
    public class EventPostsController : Controller
    {

        private readonly GenDynContext context;

        public EventPostsController(GenDynContext context)
        {
            this.context = context;
        }

        //GET /events
        public async Task<IActionResult> Index()
        {

            return View(await context.EventPosts.OrderByDescending(x => x.Id).ToListAsync());
        }

        // GET /eventposts/id
        public async Task<IActionResult> Eventpost(int id)
        {
            EventPost eventPost = await context.EventPosts.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);
            if (eventPost == null)
            {
                return NotFound();
            }

            return View(eventPost);
        }
    }
}