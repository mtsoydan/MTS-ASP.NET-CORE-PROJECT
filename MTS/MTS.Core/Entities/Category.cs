using System;
using System.Collections.Generic;
using System.Text;

namespace MTS.Core.Entities
{
    class Category:IEntity

    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
