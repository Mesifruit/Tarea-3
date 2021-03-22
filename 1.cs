using System;
					
public class Program
{
	public static void Main()
	{
		int num1;
            int num2;
            int r;

            do
            {

                Console.Write("Deme un numero positivo : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Deme otro numero positivo : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                r = num1 + num2;
                if (num1 <= 0 || num2 <= 0)
                    break;
                if (num1 != 0 || num2 != 0)
                    Console.WriteLine("El resultado es : " + r);
            } while (num1 <= 0 || num2 <= 0);
            Console.WriteLine("Termino");
	}
}