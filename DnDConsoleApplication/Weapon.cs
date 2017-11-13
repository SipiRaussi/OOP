using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDConsoleApplication
{
    class Weapon
    {
        private string name;
        private int attack;
        private bool isBroken;

        public string Name { get { return name; } }
        public int Attack { get { return attack; } }
        public bool IsBroken { get { return isBroken; } }

        public void Init()
        {
            name = "Dragon Slayer";
            attack = 10;
            isBroken = false;
        }
    }
}
