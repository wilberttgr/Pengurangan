using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengurangan
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remacks>class program dapat membuat operasi pengurangan</remacks>
    class Program
    {
        /// <summary>
        /// Operasi Pengurangan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi pengurangan</param>
        /// <param name="b">angka kedua yang akan dikurang dengan angka pertama</param>
        /// <return>hasil dari pengurangan angka pertama dan angka kedua</return>,
        static void Main(string[] args)
        {
            int a, b, kurg;
           
            System.Console.Write("Masukan bilangan I  : ");
            a = int.Parse(System.Console.In.ReadLine());
            System.Console.Write("Masukan bilangan II : ");
            b = int.Parse(System.Console.In.ReadLine());
            
            kurg = a - b;
  
            System.Console.WriteLine("Hasil pengurangan " + kurg);
            System.Console.ReadLine();
        }
    }
}
