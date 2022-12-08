using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyer.Equipments.Armours
{
    public class Chainlink
    {
        private int _armourPoints;

        public int armourPoints
        {
            get { return _armourPoints; }
            set
            {
                if (value>=1)
                {
                    _armourPoints = value;
                }
            }
        }
        public Chainlink()
        {

        }
    }
}
