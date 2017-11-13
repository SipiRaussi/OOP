using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDConsoleApplication
{
    class MusicBox
    {
        Notes notes = new Notes(247, 294, 311, 349, 370, 415, 466, 494);
        private const int thirdOfSecond = 300;
        private const int oneSecond = 1000;

        public void PlayDramaticSound()
        {
            Console.Beep(notes.Gb, thirdOfSecond / 2);
            Console.Beep(notes.Gb, thirdOfSecond / 2);
            Console.Beep(notes.Gb, thirdOfSecond / 2);
            Console.Beep(notes.Eb, oneSecond * 3 / 2);

            Console.Beep(notes.F, thirdOfSecond / 2);
            Console.Beep(notes.F, thirdOfSecond / 2);
            Console.Beep(notes.F, thirdOfSecond / 2);
            Console.Beep(notes.D, oneSecond * 3);
        }

        public void PlayUpNDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int y = 2000; y < 4000; y += 100)
                {
                    Console.Beep(y, 100);
                }
                for (int y = 4000; y > 2000; y -= 100)
                {
                    Console.Beep(y, 100);
                }
            }
        }

        public void PlayAllNotes()
        {
            Console.Beep(notes.Cb1, thirdOfSecond / 2);
            Console.Beep(notes.D, thirdOfSecond / 2);
            Console.Beep(notes.Eb, thirdOfSecond / 2);
            Console.Beep(notes.F, thirdOfSecond / 2);
            Console.Beep(notes.Gb, thirdOfSecond / 2);
            Console.Beep(notes.Ab, thirdOfSecond / 2);
            Console.Beep(notes.Bb, thirdOfSecond / 2);
            Console.Beep(notes.Cb2, thirdOfSecond / 2);
            Console.Beep(notes.Bb, thirdOfSecond / 2);
            Console.Beep(notes.Ab, thirdOfSecond / 2);
            Console.Beep(notes.Gb, thirdOfSecond / 2);
            Console.Beep(notes.F, thirdOfSecond / 2);
            Console.Beep(notes.Eb, thirdOfSecond / 2);
            Console.Beep(notes.D, thirdOfSecond / 2);
            Console.Beep(notes.Cb1, thirdOfSecond / 2);
        }
    }

    struct Notes
    {
        public int Cb1;
        public int D;
        public int Eb;
        public int F;
        public int Gb;
        public int Ab;
        public int Bb;
        public int Cb2;

        public Notes(int cb1, int d, int eb, int f, int gb, int ab, int bb, int cb2)
        {
            Cb1 = cb1;
            D = d;
            Eb = eb;
            F = f;
            Gb = gb;
            Ab = ab;
            Bb = bb;
            Cb2 = cb2;
        }
    }
}
