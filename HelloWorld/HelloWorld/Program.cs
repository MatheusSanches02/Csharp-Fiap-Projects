using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloModel model = new HelloModel(); //f9 - breakpoint 
                                                 //f10 - avança a linha
            Console.WriteLine(model.Mensagem);

            Console.Read();
        }
    }
}
