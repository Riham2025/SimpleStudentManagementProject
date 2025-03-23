using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace SimpleStudentManagementProject
{
    internal class Program
    {
        static string[] studentName = new string[10];
        static int[] studentAge = new int[10];
        static double[] marks = new double[10];
        static DateTime[] dateTimes = new DateTime[10];
        static int count = 0;
        static void Main(string[] args)
        {
            //1.Add a new student record(Name, Age, Marks)
            static void addNewStudentRecord()
            {

                for (int i = 0; i < studentName.Length; i++)
                {
                    Console.WriteLine("Enter the Student name :" + count + 1);
                    studentName[i] = Console.ReadLine();
                    count++;

                    Console.WriteLine("Enter the student age");
                    studentAge[i] = int.Parse(Console.ReadLine());

                    if (studentAge[i] < 21)
                    {
                        Console.WriteLine("The age must be greater than 19");
                        break;
                    }

                    Console.WriteLine("Enter the student mark");
                    marks[i] = double.Parse(Console.ReadLine());
                    if (marks[i] < 0 || marks[i] > 100)
                    {
                        Console.WriteLine("The marks must be between 0 and 100");
                        break;
                    }

                    dateTimes[i] = DateTime.Now;
                    count++;

                    if (i > count)
                    {
                        break;

                    }

                    Console.WriteLine("Enter another student");

                }
            }

            //2. ViewAllStudents
            static void ViewAllStudents()
            {

                for (int i = 0; i < studentAge.Length; i++)
                {
                    Console.WriteLine("student record" + i + 1);
                    Console.WriteLine("student name" + studentName[i]);
                    Console.WriteLine("student age" + studentAge[i]);
                    Console.WriteLine("student marks" + marks[i]);
                    Console.WriteLine("date and time" + dateTimes[i]);


                }
                Console.ReadLine();
            }


            //3. Find a student by name
            static void FindStudentByName()
                {
                Console.WriteLine("Enter the student name to search");
                string searchName = Console.ReadLine();

                for (int i = 0; i < studentName.Length; i++)
                {
                    if (studentName[i] == searchName)
                    {
                        Console.WriteLine("student record" + i + 1);
                        Console.WriteLine("student name" + studentName[i]);
                        Console.WriteLine("student age" + studentAge[i]);
                        Console.WriteLine("student marks" + marks[i]);
                        Console.WriteLine("date and time" + dateTimes[i]);

                    }

                    Console.ReadLine();
                }

            }



            //4.Calculate the class average
            static void CalculateTheClassAverage()
            {
                double sum = 0;
                for (int i = 0; i < studentAge.Length; i++)
                {
                    sum += marks[i];
                }
                double AverageMarks = sum / count;
                Console.WriteLine($"Average Marks: {Math.Round(AverageMarks, 2)}");
            }
            
       
            //5.. Find the top-performing student 
            static void FindTheTopPerFormingStudent()
            {
                double TopMark= marks[0];
                string SName = studentName[0];
                for (int i = 0;i < studentAge.Length;i++)
                {
                    if (marks[i] > TopMark)

                    {
                        TopMark = marks[i];
                        SName = studentName[i];

                    }
                    Console.WriteLine("student " + SName+  "Top Marks :" + TopMark);
                }



            }

            //6. Sort students by marks
            static void SortStudentsByMarks()
            {

            }
        } 
    }       
}