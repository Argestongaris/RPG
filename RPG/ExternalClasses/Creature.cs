using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Creature:Item
    {
        protected int HP;
        protected int MaxHP;
        protected int AtakMultip;
        protected int DefenseMultip;
        protected int Dexterity;
        protected int Agility;
        protected int Willpower;
        protected int Strength;
        protected int Speed;
        protected int Endurance;
        protected int Stamina;
        protected int Inteligence;
        protected int Knowledge;
        protected int Luck;

        public Creature(int id, string name, int atakm, int defm, int dex, int agil, int will, int str, int speed, int endur,
                        int intel, int know) :base(id,name) 
        {

            this.Dexterity = this.SetAtribute(dex);
            this.Agility = this.SetAtribute(agil);
            this.Willpower = this.SetAtribute(will);
            this.Strength = this.SetAtribute(str);
            this.Speed = this.SetAtribute(speed);
            this.Endurance = this.SetAtribute(endur);
            this.Inteligence = this.SetAtribute(intel);
            this.Knowledge = this.SetAtribute(know);
            this.Stamina = this.SetStamina();
            this.Luck = 1;
            this.MaxHP = SetMaxHP();
            this.HP = this.MaxHP;
            this.AtakMultip = atakm;
            this.DefenseMultip = defm;

        }

        public int SetAtribute(int num)
        {
            if (num<1)
            {
                return 1;
            }
            else
            {
                return num;
            }
        }       //safety measure for settings stats in constructor

        public int GetHP()
        {
            int num = this.HP;
            return num;
        }

        public int GetMaxHP()
        {
            int num = this.MaxHP;
            return num;
        }

        public bool TakeDamage(int num)
        {
            double i = num * 10 / this.DefenseMultip;
            if (this.HP>i)
            {
                this.HP -= Convert.ToInt32(i);
                return false;
            }
            else
            {
                this.HP = 0;
                return true;
            }
        }       //see if died (true) / decrease HP (false)

        public int GetAtakMul()
        {
            int num = this.AtakMultip;
            return num;
        }

        public int GetDefMul()
        {
            int num = this.DefenseMultip;
            return num;
        }       

        public int SetMaxHP()
        {
            double num =(this.Stamina*1.6+this.Endurance*2.5+this.Agility*1.1+this.Speed*1.1+this.Strength*1.4)*1.5+10;
            return Convert.ToInt32(num); 
        }       //calculate from stats

        public int SetStamina()
        {
            double num =((this.Endurance+this.Strength)*0.7+(this.Agility+this.Speed)*0.2+(this.Willpower+this.Dexterity)*0.1)/2;
            return Convert.ToInt32(num); 
        }       //calculate from stats

        public int GetAtak()
        {
            double num = (this.Strength * 2.7 + (this.Agility + this.Speed) * 0.7 + (this.Dexterity) * 0.5 +
                            (this.Stamina+this.Willpower+this.Endurance)*0.2+(this.Inteligence+this.Knowledge)*0.1) *(1+(this.AtakMultip/10));
            return Convert.ToInt32(num);
        }           //calculate from stats

        public int GetDef()
        {
            double num = ((this.Strength+this.Endurance) * 0.6 + (this.Agility + this.Speed) * 1.3 + (this.Dexterity) * 0.4 +
                            (this.Stamina+this.Willpower)*0.2+(this.Inteligence+this.Knowledge)*0.1) *(1+(this.DefenseMultip/10));
            return Convert.ToInt32(num);
        }           //calculate from stats

        public int GetDex()
        {
            int num = this.Dexterity;
            return num;
        }

        public int GetAgi()
        {
            int num = this.Agility;
            return num;
        }

        public int GetWill()
        {
            int num = this.Willpower;
            return num;
        }

        public int GetStr()
        {
            int num = this.Strength;
            return num;
        }

        public int GetSpeed()
        {
            int num = this.Speed;
            return num;
        }

        public int GetEndur()
        {
            int num = this.Endurance;
            return num;
        }

        public int GetStam()
        {
            int num = this.Stamina;
            return num;
        }

        public int GetInt()
        {
            int num = this.Inteligence;
            return num;
        }

        public int GetKnow()
        {
            int num = this.Knowledge;
            return num;
        }

        public int GetLuck()
        {
            int num = this.Luck;
            return num;
        }
    }
}
