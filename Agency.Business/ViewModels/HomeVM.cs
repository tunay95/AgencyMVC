﻿using Agency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Business.ViewModels
{
    public class HomeVM
    {
        public ICollection<Product> products { get; set; }
    }
}
