﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestFinal.Models;

namespace TestFinal.ViewModels
{
    public class GroupClassViewModel
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String RoomNumber { get; set; }
        public int ReviewId { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual GroupClass GroupClass { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int AverageRating { get; set; }
    }
}
