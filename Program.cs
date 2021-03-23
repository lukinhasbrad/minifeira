using System;


namespace minifeira
{
    class Program
    {
        static void Main(string[] args)
        {
          
          
          int x = 0; 
          string[] entrada = Console.ReadLine().Split(' ');
          
          
          int a = Convert.ToInt32(entrada[0]);
          int b = Convert.ToInt32(entrada[1]);
          
            

          x = (a + b); 

          Console.WriteLine($"X = {x}");

                 
          /*     
            int a, b, x;
            
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            

            x = a+b; 

            Console.WriteLine("X = {0}", x);
        */
        }
    }
}
