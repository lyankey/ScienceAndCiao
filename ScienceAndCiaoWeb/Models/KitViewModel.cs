﻿using ScienceAndCiao.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScienceAndCiaoWeb.Models
{
    public class KitViewModel
    {
        public IEnumerable<Branch> Branch { get; set; }
        public Kit Kit { get; set; }
    }
}