﻿using System;
using System.Collections.Generic;

namespace BestPrice.Models
{
    public partial class SearchHistories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
