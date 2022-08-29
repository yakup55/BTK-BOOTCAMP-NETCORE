﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.ErrorModel
{
    public class ErorrDetails
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }

        public override string ToString()=>
           JsonSerializer.Serialize(this);
    }
}
