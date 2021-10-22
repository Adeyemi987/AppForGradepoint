using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppForGradepoint
{
    public class AddMethod
    {
        public void Add()
        { // string remark = failed 
            var inputGrade = GradeLetter.F;
            int gradeUnit = (int)GradeLetter.F;
            string remark = "Fail";
            int gradepoint;


            Console.WriteLine("Input course code");
            string courseCode = Console.ReadLine();
            var regex = new Regex("[A-Z]{3}[0-9]{3}");
            if (regex.IsMatch(courseCode) != true)
            {
                Console.WriteLine("Input correct course code");
            }

            else
            {
                Console.WriteLine("Enter student's score");
                double studentScore = double.Parse(Console.ReadLine());

                if (studentScore.Equals(typeof(string)))
                {
                    Console.WriteLine("Not a valid score");
                }

                else
                {
                    if (studentScore >= 70 && studentScore <= 100)
                    {
                        InputedGrade = GradeLetter.A;
                        gradeUnit = (int)GradeLetter.A;
                        remark = "Excellent";
                    }

                    else if (studentScore >= 60 && studentScore <= 69)
                    {
                        InputedGrade = GradeLetter.B;
                        gradeUnit = (int)GradeLetter.B;
                        remark = "  Very Good";
                    }

                    else if (studentScore >= 50 && studentScore <= 59)
                    {
                        InputedGrade = GradeLetter.C;
                        gradeUnit = (int)GradeLetter.C;
                        remark = "  Very Good";
                    }

                    else if (studentScore >= 45 && studentScore <= 49)
                    {
                        InputedGrade = GradeLetter.D;
                        gradeUnit = (int)GradeLetter.D;
                        remark = "  Very Good";
                    }

                    else if (studentScore >= 40 && studentScore <= 44)
                    {
                        InputedGrade = GradeLetter.E;
                        gradeUnit = (int)GradeLetter.E;
                        remark = "  Very Good";
                    }
                }
                //else
                //{
                //    Console.WriteLine("Input the course unit");

                //    int courseUnit = int.Parse(Console.ReadLine());
                //    if (courseUnit > 5 || courseUnit < 0 || courseUnit.Equals(typeof(string)))
                //    {
                //        Console.WriteLine("Input a valid course unit");
                //    }     
                //}






            }



        }

    }
}
