using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Program

        {

            public static void Main()

            {

                Box box = new Box();



                box.width = 2;

                box.height = 3;

                box.length = 5;



                box.Show();



                float v = box.Volume();

                Console.WriteLine($"Объем коробки = {v}");



                Console.ReadKey();

            }

        }



        class Box

        {

            // поля

            public float height;

            public float width;

            public float length;



            // метод - показать данные о коробке

            public void Show()

            {

                Console.WriteLine($"Коробка: высота = {height}, ширина = {width}, длина = {length}");

            }



            // метод - рассчитать объем коробки

            public float Volume()

            {

                float v = height * width * length;

                return v;

            }

        }

}
