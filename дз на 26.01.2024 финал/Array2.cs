﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_на_26._01._2024_финал
{
    class Array2
    {
        private int stroki, stolbiki;
        private int[,] arr;
        private bool _AvtoInput = false;

        static Random rnd = new Random();

        public Array2(int Str, int Stl, bool AvtoInput)
        {
            CreateInner(Str, Stl, AvtoInput);
        }

        public void Create(int Str, int Stl, int AvtoInput)
        {
            CreateInner(Str, Stl, AvtoInput);
        }

        private void CreateInner(int Str, int Stl, int AvtoInput)
        {
            stroki = Str;
            stolbiki = Stl;
            arr = new int[stroki, stolbiki];
            _AvtoInput = AvtoInput;
            if (_AvtoInput)
            {
                Avto_Input();
            }
            else
            {
                ArrayInput();
            }
        }

        private void Avto_Input()
        {
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i, j] = rnd.Next(1, 33);
                }
            }
        }

        public  void ArrayInput()
        {
            Console.WriteLine("Введите матрицу");
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void ArrayOutput()
        {
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void Changed_ArrayOutput()
        {
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    int index = (i % 2 != 0)
                        ? arr[i, stolbiki - j - 1]
                        : arr[i, j];
                    Console.Write(index + " ");
                }
                Console.WriteLine();
            }
        }

        public void Average()
        {
            int sum = 0;
            for (int i = 0; i < stroki; i++)
            {
                for (int j = 0; j < stolbiki; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(sum / (stroki * stolbiki));
        }
    }
}
