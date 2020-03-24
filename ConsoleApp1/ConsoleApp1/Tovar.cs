using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tovar
    {
        private string naminovanie;
        private int colishestvo = 0;
        private float stoimosti = 0;

        public Tovar() { naminovanie = "Неизвестно"; colishestvo = 18; stoimosti = 12; }      // 1 конструктор

        public Tovar(string n) { naminovanie = n; colishestvo = 18; stoimosti = 12; }         // 2 конструктор

        public Tovar(string n, int a, float v) { naminovanie = n; colishestvo = a; stoimosti = v; }   // 3 конструктор

        public void GetInfo()

        {
            Console.WriteLine($":Наименование {naminovanie}  Количество: {colishestvo} Стоймость: {stoimosti} ");
        }

    }
}






