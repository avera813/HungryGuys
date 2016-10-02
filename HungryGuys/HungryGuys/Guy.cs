using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryGuys
{
    class Guy
    {
        private string name;
        private List<FoodItem> plate = new List<FoodItem>();

        // Return text string for items on plate or 'an empty plate'
        // Setting as readonly property
        public string Plate
        {
            get
            {
                if (plate != null && plate.Count() > 0)
                {
                    string itemsInPlate = "";
                    for (int i = 0; i < plate.Count(); i++)
                    {
                        if (i != 0)
                        {
                            itemsInPlate += " and ";
                        }
                        itemsInPlate += plate.ElementAt(i).Description;
                    }
                    return itemsInPlate;
                }
                return "an empty plate";
            }
        }

        // Set and get name of Guy object
        public string Name
        {
            set { name = value; }
            get { return this.name; }
        }

        // Add new sandwich to array
        public void ReceiveSandwich(string sandwich)
        {
            if (!String.IsNullOrEmpty(sandwich))
            {
                plate.Add(new FoodItem { Description = sandwich });
            }
        }

        // Remove sandwich based on index
        public void EatSandwich(int index)
        {
            if (plate.Count() > index && index > -1)
            {
                plate.RemoveAt(index);
            }
        }

        // Return number of items on plate
        public int NumberOfPlateItems()
        {
            return plate.Count();
        }
    }
}
