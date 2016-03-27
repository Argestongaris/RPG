using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class PotionKit
    {
        List<Potion> Potions = new List<Potion> { };

        public void AddPotion(Potion potion)
        {
            Potions.Add(potion);
        }

        public List<Potion> ShowPotions()
        {
            return this.Potions;
        }
    }
}
