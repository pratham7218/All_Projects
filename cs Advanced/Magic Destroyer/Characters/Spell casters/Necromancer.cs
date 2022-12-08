using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_Destroyer.Equipments.Armours;
using Magic_Destroyer.Equipments.Weapons;

namespace Magic_Destroyer.Characters.Spell_casters
{
    public class Necromancer
    {
        private int _abilityPoints;
        private string _faction = string.Empty;
        private int _healthPoints;
        private int _level;
        private string _name = string.Empty;

        private LightLeatherVest _bodyArmour;
        private Sword _weapon;


        public Necromancer()
            :this("Necromancer-1",12)
        {

        }

        public Necromancer(string name,int level)
            :this(name,level,54)
        {

        }

        public Necromancer(string name,int level,int healthpts)
        {

                this.faction = "Spellcaster";
                this.abilityPoints = 50;
                this.bodyArmour = new LightLeatherVest();
                this.weapon = new Sword();
        }
        public int abilityPoints
        {
            get { return _abilityPoints; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new Exception("Enter a value between 0 and 100");
                }
            }
        }

        public int healthpoints
        {
            get { return _healthPoints; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new Exception("Enter a value between 0 and 100");
                }
            }
        }

        public int level
        {
            get { return _level; }
            set
            {
                if (value >= 0)
                {
                    _level = value;
                }
                else
                {
                    throw new Exception("Enter a value between 0 and 100");
                }
            }
        }

        public string faction
        {
            get
            {
                return _faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcasters")
                {
                    _faction = value;
                }
                else
                {
                    throw new Exception("Provide valid input between \"Melee\" and \"Spellcasters\"");
                }
            }
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Provide name having characters more than 3");
                }
                else
                {
                    _name = value;
                }
            }
        }


        public LightLeatherVest bodyArmour
        {
            get
            {
                return _bodyArmour;
            }
            set
            {
                _bodyArmour = value;
            }
        }

        public Sword weapon { get { return _weapon; } set { _weapon = value; } }
        public void ShadowRage()
        {

        }

        public void VampireTouch()
        {

        }

        public void BoneShield()
        {

        }
    }
}
