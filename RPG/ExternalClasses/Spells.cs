using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Spell:Item
    {
        protected int Value; //power of spell
        protected int SpellType;
        protected int ManaCost;
        protected int Count;
        protected int SkillsEfect;
        protected int SellValue;

        public Spell(int id, string name, int value, int spellType, int manaCost, int count, int skillsEfect, int sellValue) : base(id,name)
        {
            if ((manaCost<1) || (spellType<1) || (value<1))
            {
                this.ID = 0;
                this.Value = 0;
                this.Count = 0;
                this.SkillsEfect = 0;
                this.SpellType = 0;
                this.SellValue = 0;
            }
            else
            {
                this.Value = value;
                this.SpellType = spellType;
                this.ManaCost = manaCost;
                this.Count = count;
                this.SkillsEfect = skillsEfect;
                this.SellValue = sellValue;
            }
        }

        public int GetValue()
        {
            int num = this.Value;
            return num;
        }

        public int GetSpellType()
        {
            int num = this.SpellType;
            return num;
        }

        public int GetManaCost()
        {
            int num = this.ManaCost;
            return num;
        }

        public int GetCount()
        {
            int num = this.Count;
            return num;
        }

        public int GetSkillEfect()
        {
            int num = this.SkillsEfect;
            return num;
        }

        public int GetSellValue()
        {
            int num = this.SellValue;
            return num;
        }

      //  public bool CastSpell(Player player)
      //  {
      //      if (this.ManaCost>player.GetMP())
       
    }
}
