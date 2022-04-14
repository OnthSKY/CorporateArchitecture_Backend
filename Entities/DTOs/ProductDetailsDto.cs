﻿using Core;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailsDto : IDto
    {
        public int ProductId { get; set; }
        public string ProcuctName { get; set; }
        public string CategoryName { get; set; }
    }
}
