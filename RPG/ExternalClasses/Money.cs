using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Gold:Item
    {
        private int Count;

        public Gold(int id, string name, int count) : base(id, name)
        {
            if (count>0)
            {
                this.Count = count;
            }
            else
            {
                this.Count = 0;
            }
        }

        public int GetCount()
        {
            int num = this.Count;
            return num;
        }

        public void AddGold(int num)
        {
            if (this.Count+num <= int.MaxValue)
            {
                this.Count += num;
            }
        }

        public bool TakeGold(int num)
        {
            if (this.Count >= num)
            {
                this.Count -= num;
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }
}
