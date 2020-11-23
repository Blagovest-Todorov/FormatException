using System;

namespace _01.exceptionsHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                decimal a = decimal.Parse(Console.ReadLine());
                decimal reault = 10m / a;
                //if we deviode int or decimal on 0, it will throw am Arithmetic exception ->DiveideByZeroException

            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not a digit nubmer");

            }
            //Console.WriteLine("Hi we continue here :");
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please, dear user, please dont enter a zero number ");
            }//DeivideByZeroException is a part of ArithmeticException class 
            //most of all Exceptions are to be found in System ! 

        }
    }
}
