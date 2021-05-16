using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
                Singleton fromTeachaer = Singleton.GetInstance;
                fromTeachaer.PrintDetails("From Teacher");
                Singleton fromStudent = Singleton.GetInstance;
                fromStudent.PrintDetails("From Student");
                Console.ReadLine();
        }
    }
}
