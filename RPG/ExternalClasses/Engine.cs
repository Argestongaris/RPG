using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.ExternalClasses
{
    class Engine
    {
        Player player;
        EqItem eqItem;
        Monster monster;
        Gold gold;
      //  Potion potion;

        public Engine()
        {
            player = new Player(1, "Bodzio", 11, 12, 3, 3, 3, 3, 3, 3, 3, 3);
            eqItem = new EqItem(100, "miecz", 1, 10, 10, 15, 1, 5);
            monster = new Monster(2, "pchła", 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 10, 5);
            gold = new Gold(20, "gold", 20);
          //  potion = new Potion(200, "small", 10, 1, 5, 2);
        }

        public List<Object> GetObj()
        {
            List<Object> Tlista = new List<Object>
            {
                player, eqItem, monster, gold //potion
            };
            return Tlista;
        }
    }
}
