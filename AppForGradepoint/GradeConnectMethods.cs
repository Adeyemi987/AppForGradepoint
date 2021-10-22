using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GradePointApp
{
    public class GradeConnectMethods
    {

        List<GradeHistory> Outcome = new List<GradeHistory>();

        int TotalGradeUnitRegistered = 0;
        int TotalGradeUnitPassed     = 0;
        int TotalWeightPoint         = 0;
        float gpa;

        public void Connect()
        {
            Console.Clear();
            Console.WriteLine("input\"Hi\"to start and\"Done\" to exit: ");
            string start = Console.ReadLine().ToLower();


            while(start=="Hi")
            {
                Console.WriteLine();
                Console.WriteLine("Input\"1\" to add result");
                Console.WriteLine("Input\"2\"to end the process");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Input the number of courses registered");
                    int numberOfCourses = Convert.ToInt32(Console.ReadLine());

                    while (numberOfCourses > 0)
                    {
                        Add();
                        Console.Clear();
                        Console.WriteLine("input received!");
                        numberOfCourses--;
                    }
                }

                else if (option == "2")
                {
                    PrintTable();
                }
            }
        }


     
       
    }
}
