using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDConsoleApplication
{
    class MusicBox
    {
        Notes notes = new Notes(247, 
                                294, 
                                311, 
                                349, 
                                370, 
                                415, 
                                466, 
                                494,
                                587,
                                622,
                                698,
                                740,
                                831,
                                932,
                                988);

        private const int thirdOfSecond = 300;
        private const int oneSecond = 1000;

        public void PlayMajorChord()
        {
            Console.Beep(notes.Gb1, thirdOfSecond / 2);
            Console.Beep(notes.Bb1, thirdOfSecond / 2);
            Console.Beep(notes.D2, (int)(thirdOfSecond * 1.5d));
        }

        public void PlayGameOver()
        {
            Console.Beep(notes.Bb1, thirdOfSecond / 2);
            Console.Beep(notes.Gb1, thirdOfSecond / 2);
            Console.Beep(notes.Eb1, (int)(thirdOfSecond * 1.5d));
        }

        public void PlayAttack()
        {
            Console.Beep(notes.D1, 100);
            Console.Beep(notes.D1, 100);
            Console.Beep(notes.Eb1, 100);
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

        /*public void PlayAllNotes()
        {
            Console.Beep(notes.Cb1, thirdOfSecond / 2);
            Console.Beep(notes.D1, thirdOfSecond / 2);
            Console.Beep(notes.Eb1, thirdOfSecond / 2);
            Console.Beep(notes.F1, thirdOfSecond / 2);
            Console.Beep(notes.Gb1, thirdOfSecond / 2);
            Console.Beep(notes.Ab1, thirdOfSecond / 2);
            Console.Beep(notes.Bb1, thirdOfSecond / 2);

            Console.Beep(notes.Cb2, thirdOfSecond / 2);
            Console.Beep(notes.D2, thirdOfSecond / 2);
            Console.Beep(notes.Eb2, thirdOfSecond / 2);
            Console.Beep(notes.F2, thirdOfSecond / 2);
            Console.Beep(notes.Gb2, thirdOfSecond / 2);
            Console.Beep(notes.Ab2, thirdOfSecond / 2);
            Console.Beep(notes.Bb2, thirdOfSecond / 2);

            Console.Beep(notes.Cb3, thirdOfSecond / 2);
            Console.Beep(notes.Bb2, thirdOfSecond / 2);
            Console.Beep(notes.Ab2, thirdOfSecond / 2);
            Console.Beep(notes.Gb2, thirdOfSecond / 2);
            Console.Beep(notes.F2, thirdOfSecond / 2);
            Console.Beep(notes.Eb2, thirdOfSecond / 2);
            Console.Beep(notes.D2, thirdOfSecond / 2);

            Console.Beep(notes.Cb2, thirdOfSecond / 2);
            Console.Beep(notes.Bb1, thirdOfSecond / 2);
            Console.Beep(notes.Ab1, thirdOfSecond / 2);
            Console.Beep(notes.Gb1, thirdOfSecond / 2);
            Console.Beep(notes.F1, thirdOfSecond / 2);
            Console.Beep(notes.Eb1, thirdOfSecond / 2);
            Console.Beep(notes.D1, thirdOfSecond / 2);

            Console.Beep(notes.Cb1, thirdOfSecond / 2);

        }*/
    }

    struct Notes
    {
        public int Cb1;
        public int D1;
        public int Eb1;
        public int F1;
        public int Gb1;
        public int Ab1;
        public int Bb1;
        public int Cb2;
        public int D2;
        public int Eb2;
        public int F2;
        public int Gb2;
        public int Ab2;
        public int Bb2;
        public int Cb3;

        public Notes(int cb1, 
                     int d1, 
                     int eb1, 
                     int f1, 
                     int gb1, 
                     int ab1, 
                     int bb1, 
                     int cb2,
                     int d2,
                     int eb2,
                     int f2,
                     int gb2,
                     int ab2,
                     int bb2,
                     int cb3)
        {
            Cb1 = cb1;
            D1 = d1;
            Eb1 = eb1;
            F1 = f1;
            Gb1 = gb1;
            Ab1 = ab1;
            Bb1 = bb1;

            Cb2 = cb2;
            D2 = d2;
            Eb2 = eb2;
            F2 = f2;
            Gb2 = gb2;
            Ab2 = ab2;
            Bb2 = bb2;

            Cb3 = cb3;
        }
    }
}
