using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCalc
{
    class Fraction
    {
        //attributi
        private int numerator;
        private int denominator;
        //costruttore
        public Fraction(int Num, int Den)
        {
            numerator = Num;
            denominator = Den;
        }
        //metodi
        public Fraction Moltiplication(Fraction otherf)
        {
            int numres = this.numerator * otherf.numerator;
            int denres = this.denominator * otherf.denominator;
            Fraction res = new Fraction(numres, denres);
            res.Reduction();
            return res;
        }

        public Fraction Add(Fraction otherf)
        {
            int denres;
            int numres1;
            int numres2;
            int numres;
            denres = (this.denominator * otherf.denominator);
            numres1 = (denres / this.denominator) * this.numerator;
            numres2 = (denres / otherf.denominator) * otherf.numerator;
            numres = numres1 + numres2;
            Fraction res = new Fraction(numres, denres);
            res.Reduction();
            return res;

        }
        public Fraction Sub(Fraction otherf)
        {
            //int denris = this.denominatore * altraf.denominatore;
            int denres;
            int numres1;
            int numres2;
            int numres;
            denres = (this.denominator * otherf.denominator);
            numres1 = (denres / this.denominator) * this.numerator;
            numres2 = (denres / otherf.denominator) * otherf.numerator;
            numres = numres1 - numres2;
            Fraction ris = new Fraction(numres, denres);
            ris.Reduction();
            return ris;
        }
        public void Reduction()
        {
            int mcd = CalcGCD();
            numerator = numerator / mcd;
            denominator = denominator / mcd;
        }
        public int Extractnumerator()
        {
            return numerator;
        }
        //Estrai Denominatore
        public int Extractdenominator()
        {
            return denominator;
        }
        //MCD
        public int CalcGCD()
        {
            int mcd = 0;
            int numres = numerator;
            int denres = denominator;
            while (numres != denres)
            {
                if (numres > denres)
                {
                    numres = numres - denres;
                }
                else //Numris < Denris
                {
                    //scambio
                    int N1 = numres;
                    numres = denres;
                    denres = N1;
                }
                mcd = numres;
            }
            return mcd;
        }
    }
}
