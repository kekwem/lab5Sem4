using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem4Lab5
{
    class Wypozyczenie
    {
        private string imie;
        private string nazwisko;
        private double cena_komplet;
        private bool kaska;
        private bool gogle;
        private bool kijki;
        private int liczba_dni;
        public Wypozyczenie(string imie, string nazwisko, double cena_komplet, bool kaska, bool gogle, bool
            kijki, int liczba_dni)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.cena_komplet = cena_komplet;
            this.kaska = kaska;
            this.gogle = gogle;
            this.kijki = kijki;
            this.liczba_dni = liczba_dni;
        }

        double cena_wypozyczenia()
        {
            double caly_koszt = 0;
            caly_koszt += cena_komplet;
            if (kaska)
            {
                caly_koszt += 10;
            }
            if (gogle)
            {
                caly_koszt += 10;
            }
            if (kijki)
            {
                caly_koszt += 10;
            }
            return caly_koszt * liczba_dni;
        }

        public override string ToString()
        {
            return $"{imie} {nazwisko} ==> {cena_wypozyczenia()}";
        }

    }
}
