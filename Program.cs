using System;

namespace git_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("hero");

            
            int a;
            //Console.Read();
            try{
                str = Console.ReadLine();
                a = int.Parse(str);

            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                str = "error";
            }


            Console.WriteLine(str);
        }
    }
}
