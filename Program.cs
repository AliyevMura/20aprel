using _20aprilTasks.utilities.Exceptions;
using System.Xml.Linq;

namespace _20aprilTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    throw new  AgeException("Sorry, Age must be greater than 0");
                }
            }
            catch (AgeException ex)
            {

                Console.WriteLine(ex.Message); ;
            }

            
        }
    } 
    
}