using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace EssentialTraining2App
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("Program Started");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            // CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        //private static int CrazyMathProblem()
        //{
        //    var income = 1000;
        //    for(var i = 10; i > 0; i--)
        //    {
        //        income = income = (income / i);
        //    }
        //}

        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new System.IO.StreamReader(@"C:\tem\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }


             }

            catch
            {
                Console.WriteLine("Could not find the directory.");
                logger.Error("The directory was not found.");
            }

            //catch
            //{
            //    Console.WriteLine("Could not find the file");

            //}
            finally
            {
                Console.WriteLine("finally runs all the time");
            }
        
        }
    }
}
