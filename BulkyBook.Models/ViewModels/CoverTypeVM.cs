using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Models.ViewModels
{
    public class CoverTypeVM
    {
        public IEnumerable<CoverType> CoverTypes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
