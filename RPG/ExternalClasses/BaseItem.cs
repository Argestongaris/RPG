using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Item
    {
        protected int ID;
        protected string Name;

        public Item(int id, string name)
        {
            this.ID = id;
            if (name != null)
            {
                this.Name = name;
            }   
            else
            {
                this.Name = "NoName";
                this.ID = 0;
            }
        }

        public int GetID()
        {
            Int32 id = this.ID;
            return id;
        }

        public string GetName()
        {
            String name = this.Name;
            return name;
        }
    }

 
