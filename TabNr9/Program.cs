using System;

namespace TabNr9
{
    class Program
    {
        static void Main(string[] args)
        {

            KandydatNaStudia[] kandydat = new KandydatNaStudia[11];

            kandydat[0].nazwiskoKandydata ="Krawczyk";
            kandydat[1].imieKandydata = "Adrian";
            kandydat[2].procMatematyka = 71;
            kandydat[3].procInformatyka = 89;
            kandydat[5].procJezykObcy = 90;

            kandydat[6].nazwiskoKandydata = "Stenacel";
            kandydat[7].imieKandydata = "Zuzanna";
            kandydat[8].procMatematyka = 95;
            kandydat[9].procInformatyka = 70;
            kandydat[10].procJezykObcy = 85;

            for (int i = 0; i < 11; i++)
            {

                if (i % 4 == 0)
                    Console.WriteLine();
                else
                    Console.Write(kandydat[i]);

            }

        }
    }
}
