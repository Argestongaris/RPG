using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Potion:Item
    {
        protected int Strength;
        protected int PotType;
        protected int SellValue;
        protected int Count;

        public Potion(int id, string name, int str, int potType, int sellVal, int count) :base(id, name)
        {
            if ((str<1) || (potType<=0) || (potType>5) || (count<0))
            {
                //wywal błąd
                this.Strength = 0;
                this.PotType = 0;
                this.SellValue = 0;
                this.Count = 0;
            } 
            else
            {
                this.Strength = str;
                this.PotType = potType;
                this.SellValue = sellVal;
                this.Count = count;
            }
        }

        public bool Drink(Player player)
        {
            switch (this.PotType)
            {
                case 1:
                    if (this.Count>0)
                    {
                        player.AddHP(this.Strength);
                        --this.Count;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case 2:
                   if (this.Count>0)
                    {
                        player.AddMP(this.Strength);
                        --this.Count;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case 3:
                   if (this.Count>0)
                    {
                        player.AddMP(this.Strength);
                        player.AddHP(this.Strength);
                        --this.Count;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case 4:
                   if (this.Count>0)
                    {
                        player.IncMaxHP(this.Strength);
                        --this.Count;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                case 5:
                   if (this.Count>0)
                    {
                        player.IncMaxMP(this.Strength);
                        --this.Count;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;
                default: return false;
                    break;
            }

            
        }

        public bool SellPotion(Gold gold, int num)
        {
            if (num==0)
            {
                return false;
            }
            if (this.Count>=num)
            {
                this.Count -= num;
                gold.AddGold(num*this.SellValue);
                return true;
            } 
            else
            {
                gold.AddGold(this.Count * this.SellValue);
                this.Count = 0;
                return true;
            }
        }

        public void AddPotion()
        {
            ++this.Count;
        }

       // public bool
    }
}
