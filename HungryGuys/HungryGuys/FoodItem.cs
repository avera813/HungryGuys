using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGuys
{
    class FoodItem
    {
        private string description;
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
    }
}
