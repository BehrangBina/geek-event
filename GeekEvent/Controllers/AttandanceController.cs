﻿using System.Web.Http;
using System.Web.ModelBinding;
using GeekEvent.Models;
using Microsoft.AspNet.Identity;

namespace GeekEvent.Controllers
{
    [Authorize]
    public class AttandanceController : ApiController
    {
        public ApplicationDbContext _Context;

        public AttandanceController()
        {
            _Context=new ApplicationDbContext();
        }
       [HttpPost]
        public  IHttpActionResult Attend([FromBody] int gigId)
        {
            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = User.Identity.GetUserName()
            };
            _Context.Attendances.Add(attendance);
            _Context.SaveChanges();
            return Ok();
        }
    }
}
