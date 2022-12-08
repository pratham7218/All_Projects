using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Destroyer.Equipments.Weapons
{
    public class Sword
    {
        private int _damage;

        public int Damage { get { return _damage; } set { _damage = value; } }
        public Sword()
        {
            this.Damage = 10;
        }
        public void Bloodthirst()
        {

        }
    }
}
