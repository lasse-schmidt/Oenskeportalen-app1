﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oenskeportalen.Models
{
    public class UserBasicDetail
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
