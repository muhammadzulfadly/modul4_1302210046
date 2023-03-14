using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static modul4_1302210046.Program.PosisiKarakterGame;

namespace modul4_1302210046
{
    internal class Program
    {
        public class KodeBuah
        {
            public enum namaBuah
            {
                Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
            }

            public static string getKodeBuah(namaBuah kode)
            {
                string[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
                return KodeBuah[(int)kode];
            }

        }

        public class PosisiKarakterGame
        {
            public enum State { Jongkok, Tengkurap, Berdiri, Terbang };
   
        }

        static void Main(string[] args)
        {
            KodeBuah kode1 = new KodeBuah();
            //int kode = KodeBuah.getKodeBuah(KodeBuah.namaBuah.Apel);
            Console.WriteLine(kode1);



                State state = State.Berdiri;
                string[] screenName = { "Jongkok", "Tengkurap", "Berdiri", "Terbang" };
                while (state == State.Berdiri || state == State.Jongkok || state == State.Tengkurap || state == State.Terbang)
                {
                    string command = Console.ReadLine();
                    switch (state)
                    {
                    case State.Berdiri:

                        if (command == "W")
                            state = State.Terbang;
                        else if (command == "S")
                            state = State.Jongkok;
                        break;

                    case State.Tengkurap:

                        if (command == "W")
                            state = State.Jongkok;
                        break;

                    case State.Jongkok:

                        if (command == "S")
                            state = State.Tengkurap;
                            Console.WriteLine("posisi istirahat");
                        break;

                    case State.Terbang:

                        if (command == "X")
                            state = State.Jongkok;
                        else if (command == "S")
                            state = State.Berdiri;
                        Console.WriteLine("posisi standby");
                        break;
                }
                }
                Console.WriteLine("EXIT SCREEN");
        }
    }
}
