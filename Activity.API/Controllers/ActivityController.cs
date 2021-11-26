using Activity.API.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Activity.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly ActivityDBContext _activityContext;

        public ActivityController(ActivityDBContext context)
        {
            _activityContext = context;
        }
        // GET: api/<ActivityController>
        [HttpGet]
        public IEnumerable<Models.Activity> Get()
        {
            var activities = _activityContext.Activities.ToList();
            return activities;
        }
                

        // POST api/<ActivityController>
        [HttpPost]
        public void Post([FromBody] Models.Activity activity )
        {
            var item = new Models.Activity()
            {
                FirstName = activity.FirstName,
                LastName = activity.LastName,
                Email = activity.Email,
                Date = activity.Date,
                Experince = activity.Experince,
                Comments = activity.Comments,
                ActivityName=activity.ActivityName
            };

            _activityContext.Activities.Add(item);

            _activityContext.SaveChanges();
        }

    }
}
