using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekartovoProizvedenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // създаваме масив А като го инициализираме
            // в масива А са елементите на базовото множ-во
            int[] A = { 0, 1 };
            //с вложени цикли for се обхождат елементите на масива
            for (int i1 = 0; i1 < 2; i1++)
                for (int i2 = 0; i2 < 2; i2++)
                    for (int i3 = 0; i3 < 2; i3++)
                    {
                        Console.Write("(" + A[i1] + ","); //образуване на 1 домейн
                        Console.Write(A[i2] + ","); //образуване на 2 домейн
                        Console.Write(A[i3] + ")"); //образуване на 3 домейн
                    }
        }
    }
}
