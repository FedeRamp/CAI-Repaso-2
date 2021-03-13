using System;

namespace Repaso2
{
    class MainClass
    {
        //Crear loop de 0 a 227
        //"Divisible por 3?" ^ "Es primo?"
        //Nunca va a ocurrir ambas cosas al mismo tiempo, si es div por 3, no es primo
        //Truco interesante, si es divisible por 6, tiene un primo arriba o abajo
        public static void Main(string[] args)
        {
            Console.Clear();
            int limit = 227;
            bool esPrimo(int num)
                //boolean para chequear si un int es primo
            {
                if (num == 0) return false;
                for(int i = 2; i < num/2; i++)
                {
                    if(num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }


            for(int index = 1; index < limit; index++)
            {
                string resultado = "";
                if (esPrimo(index))
                {
                    resultado += "Es primo";
                }else if (index % 3 == 0)
                {
                    resultado += "Es divisible por 3";
                }
                Console.WriteLine(index + "  " + resultado);
            }



        }
    }
}
