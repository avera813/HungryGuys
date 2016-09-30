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
        private string[] plate = new string[0];

        public string Plate
        {
            get
            {
                if (plate != null && plate.Length > 0)
                {
                    string itemsInPlate = "";
                    for (int i = 0; i < plate.Length; i++)
                    {
                        if (i != 0)
                        {
                            itemsInPlate += " and ";
                        }
                        itemsInPlate += plate[i];
                    }
                    return itemsInPlate;
                }
                return "an empty plate";
            }
        }

        public string Name
        {
            set { name = value; }
            get { return this.name; }
        }

        public void ReceiveSandwich(string sandwich)
        {
            if (!String.IsNullOrEmpty(sandwich))
            {
                string[] tempPlate = new String[plate.Length + 1];
                for (int i = 0; i < plate.Length; ++i)
                {
                    tempPlate[i] = plate[i];
                }
                tempPlate[tempPlate.Length - 1] = sandwich;
                plate = tempPlate;
            }
        }

        public void EatSandwich(int index)
        {
            if (plate.Length > index && index > -1)
            {
                string[] revisedPlate = new string[plate.Length - 1];
                int i = 0;
                for (int j = 0; j < plate.Length; ++j)
                {
                    if (j != index)
                    {
                        revisedPlate[i] = plate[j];
                        i++;
                    }
                }
                plate = revisedPlate;
            }
        }

        public int NumberOfPlateItems()
        {
            return plate.Length;
        }
    }
}
