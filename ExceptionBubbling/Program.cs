using System;

namespace ExceptionBubbling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Making Call to Function1()");
                Function1();
                Console.WriteLine("Successfully returned from Function1()");                
            }
            catch(Exception ex)
            {           
                Console.WriteLine("\nFollowing exception occured:\n\n" + ex);                
            }
            finally
            {
                Console.WriteLine("\n\nInside finally block.");
                Console.ReadLine();
            }
        }

        public static void Function1()
        {
            Console.WriteLine("Inside Function1 -> Making Call to Function2()");
            Function2();
            Console.WriteLine("Successfully returned from Function2()");
        }
        public static void Function2()
        {
            Console.WriteLine("Inside Function2 -> Making Call to Function3()");
            Function3();
            Console.WriteLine("Successfully returned from Function3()");
        }
        public static void Function3()
        {
            Console.WriteLine("Inside Function3 -> Making Call to Function4()");
            Function4();
            Console.WriteLine("Successfully returned from Function4()");
        }
        public static void Function4()
        {
            Console.WriteLine("Inside Function4 -> Making Call to Function5()");
            Function5();
            Console.WriteLine("Successfully returned from Function5()");
        }
        public static void Function5()
        {            
            Console.WriteLine("Inside Function5");
            throw new Exception();

            //Exceptio handled
            /*try
            {
                Console.WriteLine("Inside Function5");
                throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nFollowing exception occured:\n\n" + ex);
            }
            finally
            {
                Console.WriteLine("\n\nInside finally block of Function5().");
                Console.ReadLine();
            }*/
        }
    }
}
