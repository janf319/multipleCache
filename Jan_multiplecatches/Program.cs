using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Jan_multiplecatches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0;
            int countOfScores = 0;
            string inValue;
            double averageTestScores;

            try
            {
                WriteLine("How many scores will you enter");
                inValue = ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int index = 0; index < examScore.Length; index++)
                {
                    Write("Enter exam scores {0}:", index + 1);

                    inValue = ReadLine();
                    examScore[index] = int.Parse(inValue);
                    totalScores += examScore[index];
                }
                averageTestScores = totalScores / countOfScores;
                WriteLine("The average is {0}", averageTestScores);

            }
            catch (FormatException e)
            {
                Error.WriteLine("Problem with one of the operands. Cannot compute average");
                Error.WriteLine("Exception type {0}", e.Message);
                
            }
            catch (DivideByZeroException e) 
            {
                Error.WriteLine("Divide by zero error {0}", e.Message);
                
            }
            catch (Exception e) when (countOfScores == 0)
            {
                Error.WriteLine("No scores entered Division by zero avoided");
                Error.WriteLine("Exception type {0}", e.Message);
            }
            finally
            {
                Error.WriteLine("....Finally Ran");
                
            }
            ReadKey();
        }
    }
}
