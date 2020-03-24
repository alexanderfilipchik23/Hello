using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] colishestvo)
        {
            Tovar Rushka = new Tovar();               // вызов 1-ого конструктора без параметров
            Tovar Mesh = new Tovar("Мяч");            //вызов 2-ого конструктора с одним параметром
            Tovar sterka = new Tovar("Стёрка", 25, 3); // вызов 3-его конструктора с тремя параметрами

            Mesh.GetInfo();
            Rushka.GetInfo();
            sterka.GetInfo();


            Console.ReadKey();






        }
    }
   
}


    

