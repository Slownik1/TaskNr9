using System;
using System.Collections.Generic;
using System.Text;

namespace TabNr9
{
    public struct KandydatNaStudia
    {

        public String nazwiskoKandydata;
        public String imieKandydata;
        public int procMatematyka;
        public int procInformatyka;
        public int procJezykObcy;

        KandydatNaStudia(String nazwiskoKandydata, String imieKandydata, int procMatematyka, int procInformatyka, int procJezykObcy)
        {
            this.nazwiskoKandydata = nazwiskoKandydata;
            this.imieKandydata = imieKandydata;
            this.procMatematyka = procMatematyka;
            this.procInformatyka = procInformatyka;
            this.procJezykObcy = procJezykObcy;
        }

        public double Oblicz()
        {

            double punktyMatematyka = procMatematyka*0.6;
            double punktyInformatyka = procInformatyka*0.5;
            double punktyJezykObcy = procJezykObcy*0.2;

            return procInformatyka + procJezykObcy + punktyMatematyka;

        }

    }
}
