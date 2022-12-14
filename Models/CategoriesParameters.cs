using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPITask.Models
{
    public class CategoriesParameters
    {
        const int maxPageSize = 100;
        public int PageNumber { get; set; } = 1;
        private int _pagesize = 20;
        public int pagesize {
            get {
                return _pagesize;
            }
            set {
                _pagesize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
