﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Enitty.Paging
{
    public class PagingResult
    {
        public int Take { get; set; }
        public int PageNumber { get; set; }
        public int Total { get; set; }
    }
}
