﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WHMIS.Models
{
    public class WHMISItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }

    }
}
