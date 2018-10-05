using System;

namespace suma_de_multiplos_de_3_y_5_SofiBerumen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame numero");
            String tam=Console.ReadLine();
            int n;
            if(Int32.TryParse (tam, out n)){
                Console.WriteLine("El numero es entero");
                int sum=0;

                for(int x=1; x<=n; x++){
                    if(x%3==0 || x%5==0){
                        sum= sum+x;
                        Console.Write("MULTIPLOS: "+x+"\n");
                    }
                    
                }
                Console.WriteLine("** SUMA: ** " + sum);
            
            } else {
                Console.WriteLine("El numero es entero");
            }




        }
    }
}
