using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Armory
    {
        List<EqItem> armory = new List<EqItem> { };

        public void AddToArmory(EqItem newEq)
        {
            this.armory.Add(newEq);
        }

        public List<EqItem> ShowArmory()
        {
            return this.armory;
        }
    }
}
