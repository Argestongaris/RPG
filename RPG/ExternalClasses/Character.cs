using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Player:Creature
    {

        protected int MP;
        protected int MaxMP;
        protected int SkillPoints;
        protected double SkillDexterity;
        protected double SkillAgility;
        protected double SkillWillpower;
        protected double SkillStrength;
        protected double SkillSpeed;
        protected double SkillEndurance;
        protected double SkillStamina;
        protected double SkillInteligence;
        protected double SkillKnowledge;
        protected double SkillLuck;
        protected int Lvl;
        protected int Exp;
        protected int MaxExp;

        public Player(int id, string name, int atakm, int defm, int dex, int agil, int will, int str, int speed, int endur, int intel,
                        int know) 
                        : base(id, name,  atakm,  defm,  dex,  agil,  will,  str,  speed,  endur, intel,  know)
        {
            this.SkillPoints=0;
            this.SkillDexterity=0;
            this.SkillAgility=0;
            this.SkillWillpower=0;
            this.SkillStrength=0;
            this.SkillSpeed=0;
            this.SkillEndurance=0;
            this.SkillStamina=0;
            this.SkillInteligence=0;
            this.SkillKnowledge=0;
            this.SkillLuck=0;
            this.SkillPoints = 9;
            this.Lvl = 0;
            this.Exp = 0;
            this.MaxExp = 10;
            this.MaxMP = this.SetMaxMP();
            this.MP = this.MaxMP;
    }

        public void AddHP(int num)
        {
            if (this.HP+num > this.MaxHP)
            {
                this.HP = this.MaxHP;
            }
            else
            {
                this.HP += num;
            }
        }

        public void AddMP(int num)
        {
            if (this.MP+num > this.MaxMP)
            {
                this.MP = this.MaxMP;
            }
            else
            {
                this.MP += num;
            }
        }

        public void IncMaxHP(int num)
        {
            this.MaxHP += num;
        }

        public void IncMaxMP(int num)
        {
            this.MaxMP += num;
        }


        public int GetMP()
        {
            int num = this.MP;
            return num;
        }

        public int GetMaxMP()
        {
            int num = this.MaxMP;
            return num;
        }

        public int GetExp()
        {
            int num = this.Exp;
            return num;
        }

        public int GetMaxExp()
        {
            return this.MaxExp;
        }

        public int GetSkillPoints()
        {
            int num = this.SkillPoints;
            return num;
        }   //getproperties

        public void Rest()
        {
            this.HP = this.MaxHP;
            this.MP = this.MaxMP;
        }

        public bool LvlUp(int exp)
        {
            if (this.Exp + exp >= this.MaxExp)
            {
                this.Exp = this.Exp + exp - this.MaxExp;
                this.SkillPoints += 7;
                if (this.Lvl==0)
                {
                    this.MaxExp = 50;
                    ++this.Lvl;
                    this.MaxMP=this.SetMaxMP();
                    this.MaxHP = SetMaxHP();
                    this.Rest();
                    return true;
                }
                if (this.Lvl==1)
                {
                    this.MaxExp = 0;
                }
                ++this.Lvl;
                this.MaxExp = this.MaxExp + 150*this.Lvl-100*(this.Lvl-1)-100;
                this.MaxMP=this.SetMaxMP();
                this.MaxHP = SetMaxHP();
                this.Rest();
                return true;
            }
            else
            {
                this.Exp+=exp;
                return false;
            }

        }       //działa


        public double GetSkillDex()
        {
            double num = this.SkillDexterity;
            return num;
        }

        public double GetSkillAgi()
        {
            double num = this.SkillAgility;
            return num;
        }

        public double GetSkillWill()
        {
            double num = this.SkillWillpower;
            return num;
        }

        public double GetSkillStr()
        {
            double num = this.SkillStrength;
            return num;
        }

        public double GetSkillspeed()
        {
            double num = this.SkillSpeed;
            return num;
        }

        public double GetSkillEndu()
        {
            double num = this.SkillEndurance;
            return num;
        }

        public double GetSkillStami()
        {
            double num = this.SkillStamina;
            return num;
        }

        public double GetSkillIntel()
        {
            double num = this.SkillInteligence;
            return num;
        }

        public double GetSkillKnow()
        {
            double num = this.SkillKnowledge;
            return num;
        }

        public double GetSkillLuck()
        {
            double num = this.SkillLuck;
            return num;
        }   //getskills

        public int GetLvl()
        {
            int num = this.Lvl;
            return num;
        }

        public void DistributeSkillPoint(string skill)
        {
            --this.SkillPoints;
            switch (skill)
            {   
                case "Dex":
                    ++this.Dexterity;
                    break;
                case "Agi":
                    ++this.Agility;
                    break;
                case "Will":
                    ++this.Willpower;
                    break;
                case "Str":
                    ++this.Strength;
                    break;
                case "Speed":
                    ++this.Speed;
                    break;
                case "Endu":
                    ++this.Endurance;
                    break;
                case "Intel":
                    ++this.Inteligence;
                    break;
                case "Know":
                    ++this.Knowledge;
                    break;
                case "Luck":
                    ++this.Luck;
                    break;
                    //stamina cannot be increased via skillpoints distribute
                default:
                    break;
                    
            }
            this.MaxHP = this.SetMaxHP();
            this.MaxMP = this.SetMaxMP();
            this.Stamina = this.SetStamina();
        }

        public void AddToSkillPercentage(string skill, double percentage)
        {
            switch (skill)
            {
                case "Dex":
                    this.SkillDexterity+=percentage;
                    if (this.SkillDexterity>1)
                    {
                        this.SkillDexterity -=1;
                        ++this.Dexterity;
                    }
                    break;
                case "Agi":
                    this.SkillAgility += percentage;
                    if (this.SkillAgility > 1)
                    {
                        this.SkillAgility -= 1;
                        ++this.Agility;
                    }
                    break;
                case "Will":
                    this.SkillWillpower += percentage;
                    if (this.SkillWillpower > 1)
                    {
                        this.SkillWillpower -= 1;
                        ++this.Willpower;
                    }
                    break;
                case "Str":
                    this.SkillStrength += percentage;
                    if (this.SkillStrength > 1)
                    {
                        this.SkillStrength -= 1;
                        ++this.Strength;
                    }
                    break;
                case "Speed":
                    this.SkillSpeed += percentage;
                    if (this.SkillSpeed > 1)
                    {
                        this.SkillSpeed -= 1;
                        ++this.Speed;
                    }
                    break;
                case "Endu":
                    this.SkillEndurance += percentage;
                    if (this.SkillEndurance > 1)
                    {
                        this.SkillEndurance -= 1;
                        ++this.Endurance;
                    }
                    break;
                case "Intel":
                    this.SkillInteligence += percentage;
                    if (this.SkillInteligence > 1)
                    {
                        this.SkillInteligence -= 1;
                        ++this.Inteligence;
                    }
                    break;
                case "Know":
                    this.SkillKnowledge += percentage;
                    if (this.SkillKnowledge > 1)
                    {
                        this.SkillKnowledge -= 1;
                        ++this.Knowledge;
                    }
                    break;
                //Luck and stamina cannot be incremented by experience
                default:
                    break;
            }
        }

        public void DecMana(int num)
        {
            this.MP -=num;
        }

        new public int SetMaxHP()
        {
            double num = (this.Stamina * 1.6 + this.Endurance * 2.5 + this.Agility * 1.1 + this.Speed * 1.1 + this.Strength * 1.4) * 1.5 + 10*this.Lvl;
            return Convert.ToInt32(num);
        }       //calculate from stats

        public int SetMaxMP()
        {
            double num = (this.Inteligence*2.5 + (this.Knowledge+this.Willpower)*1.5) * 5 + 10*this.Lvl;
            return Convert.ToInt32(num);
        }       //calculate from stats
    }
}
