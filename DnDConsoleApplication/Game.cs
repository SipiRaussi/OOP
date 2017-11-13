using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDConsoleApplication
{
    class Game
    {
        MusicBox mb = null;
        Character c = null;

        public void Start()
        {
            mb = new MusicBox();
            c = new Character();

            mb.PlayAllNotes();
        }
    }
}
