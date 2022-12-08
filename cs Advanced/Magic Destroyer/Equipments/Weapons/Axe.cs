using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyer.Equipments.Weapons
{
    public class Axe
    {

        private int _damage;
        public int damage {
            get
            {
                return _damage;
            }
            set
            {
                if (value>=1)
                {
                    _damage = value;
                }
            }
        }
        public Axe()
        {

        }
        public void HackNSlash()
        {

        }
    }
}
