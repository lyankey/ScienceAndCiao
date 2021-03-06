﻿using ScienceAndCiao.Data;
using ScienceAndCiao.Models.User;
using ScienceAndCiaoWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScienceAndCiaoWeb.Controllers
{
    public class KitApiController : ApiController
    {
        private ApplicationDbContext db;
        public KitApiController()
        {
            db = ApplicationDbContext.Create();
        }

        //Type could be price or avail
        public IHttpActionResult Get(string query = null)
        {

            var kitQuery = db.Kits.Where(k => k.Title.ToLower().Contains(query.ToLower()));
            return Ok(kitQuery.ToList());
        }

        //price or availability (I tried to use as bool to check if they have base kit but couldn't get it to work
        //find out parameters we want, then something unique about the product
        public IHttpActionResult Get(string type, string title = null, string Duration = null, string email = null)
        {

            if (type.Equals("price"))
            {
                Kit KitQuery = db.Kits.Where(b => b.Title.Equals(title)).SingleOrDefault();
                var chargeRate = from u in db.Users
                                 join m in db.MembershipTypes on u.MembershipTypeId equals m.Id
                                 where u.Email.Equals(email)
                                 select new { m.MonthlyMembershipFee, m.SixMonthMemberShipFee };

                var price = Convert.ToDouble(KitQuery.Price) * Convert.ToDouble(chargeRate.ToList()[0].MonthlyMembershipFee) / 100;

                if (Duration == StaticDetails.SixMonthmemberShipFee)
                {
                    price = Convert.ToDouble(KitQuery.Price) * Convert.ToDouble(chargeRate.ToList()[0].SixMonthMemberShipFee) / 100;
                }
                return Ok(price);
            }
            else
            {
                Kit KitQuery = db.Kits.Where(b => b.Title.Equals(title)).SingleOrDefault();
                return Ok(KitQuery.Stock);
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
