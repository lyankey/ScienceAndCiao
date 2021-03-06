﻿using ScienceAndCiao.Models.Kit;
using ScienceAndCiaoWeb.Data;
using ScienceAndCiaoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScienceAndCiaoWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string search = null)
        //the search string will be passed if there is value, to the index action - see the partial view for the thumbnail, and also need search in the thumbnail extension 
        {
            var thumbnails = new List<KitThumbnail>().GetBookThumbnail(ApplicationDbContext.Create(), search);
            //get the thumbnails you want and then divide by 4 for four per page
            var count = thumbnails.Count() / 3;

            var model = new List<KitThumbnailViewModel>();
            //should iterate two times with the five kits I entered so far
            for (int i = 0; i <= count; i++)
            {
                model.Add(new KitThumbnailViewModel
                {
                    //take a count of 4, add to thumbnails, then add to model. Will have a list of 4 4 thumbnais, then pass it into view
                    Thumbnails = thumbnails.Skip(i * 3).Take(3)
                });
            }


            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}