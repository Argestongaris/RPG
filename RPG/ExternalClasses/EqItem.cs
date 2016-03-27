namespace RPG.ExternalClasses
{
    public class EqItem : Item
    {
        protected int Lvl;
        protected int Durability;
        protected int MaxDurability;
        protected int SellValue;
        protected int Value;
        protected int ItemType;     //1-helmet, 2-cheastplate, 3-pants, 4-boots, 5-melee, 6-shield, 7-ranged, 8-arrows, 9-spears, 0-junk

        public EqItem(int id, string name,int lvl, int dur, int maxDur, int sellVal, int val, int type) : base(id,name)
        {
            this.Lvl = lvl;
            if (dur > maxDur)
            {
                this.Durability = maxDur;
                this.MaxDurability = maxDur;
            }
            else
            {
                this.Durability = dur;
                this.MaxDurability = maxDur;
            }
            this.SellValue = sellVal;
            this.Value = val;
            if ((type>0) || (type<10))
            {
                ItemType = type;
            }
            else
            {
                ItemType = 0;
            }
        }

        public int GetLvl()
        {
            int num = this.Lvl;
            return num;
        }

        public int GetDurability()
        {
            int num = this.Durability;
            return num;
        }

        public int GetMaxDurability()
        {
            int num = this.MaxDurability;
            return num;
        }

        public int GetSellValue()
        {
            int num = this.SellValue;
            return num;
        }

        public int GetValue()
        {
            int num = this.Value;
            return num;
        }

        public void IncLvl()
        {
            if (this.Lvl!=0)
            {
                ++this.Lvl;
            }
        }

        public bool Repair(int repairValue)
        {
            if ((this.Durability==this.MaxDurability) || (this.MaxDurability<2))
            {
                return false;
            }
            else
            {
                --this.MaxDurability;
                this.Durability = this.MaxDurability;
                if (this.SellValue>1)
                {
                    --this.SellValue;
                }
                return true;
            }
        }

        public bool Stroke()
        {
            if (this.Durability<2)
            {
                return false;
            }
            else
            {
                --this.Durability;
                return true;
            }
            
        }

    }
}
