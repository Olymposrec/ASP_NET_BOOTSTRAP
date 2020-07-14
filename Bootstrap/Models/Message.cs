﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrap.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public int Level { get; set; }
        public string Text { get; set; }
    }
}