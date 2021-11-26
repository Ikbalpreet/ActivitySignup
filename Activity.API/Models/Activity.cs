using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity.API.Models
{
    public class Activity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public Int32 Experince { get; set; }
        public string ActivityName { get; set; }
        public string Comments { get; set; }
    }
}
