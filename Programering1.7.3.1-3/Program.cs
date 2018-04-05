using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programering1._7._3._1_3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Är det fint väder idag? j/n: ");
            string answer = Console.ReadLine();
            
            if(answer == "j") {
                Console.WriteLine("Vi går på picknick!");
            }
            else if(answer == "n") {
                Console.WriteLine("Vi stannar inne och läser en bok");
            }
            else {
                Console.WriteLine("Jag förstår inte");
            }
            Console.ReadLine();
        }
    }
}