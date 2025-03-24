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
            try
            {
                while (true) // we use while loop to repeat the process and we set true so it will not stop ... 
                {

                    Console.Clear();
                    Console.WriteLine("System Menu \n");
                    Console.WriteLine("Select option: ");
                    Console.WriteLine("1. Adding a New Student");
                    Console.WriteLine("2. Viewing All Students");
                    Console.WriteLine("3. Find Student By Name");
                    Console.WriteLine("4. Calculating the Class Average");
                    Console.WriteLine("5. Find TheTop Pe rForming Student()");
                    Console.WriteLine("6. Sort Students By Marks()");
                    Console.WriteLine("7. Delete A Student Record()");
                    Console.WriteLine("0.  Exit");

                    Console.Write("\nEnter your option: \n");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: addNewStudentRecord(); break;
                        case 2: ViewAllStudents(); break;
                        case 3: FindStudentByName(); break;
                        case 4: CalculateTheClassAverage(); break;
                        case 5: FindTheTopPerFormingStudent(); break;
                        case 6: SortStudentsByMarks(); break;
                        case 7: DeleteAStudentRecord(); break;
                        case 0: Console.WriteLine("Have a nice day ..."); return;
                        default: Console.WriteLine("\n You enter unaccepted option! ... try again"); break;
                    }
                    Console.ReadLine();// we add this line just to stop the program from clear 'Console.Clear();' the screen before the user see the result ...


                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }


            //1.Add a new student record(Name, Age, Marks)
            static void addNewStudentRecord()
            {

                char ChoiceChar = 'y';
                while (count < 10)
                {
                    Console.WriteLine($"Enter the name of student {count + 1}:");
                    studentName[count] = Console.ReadLine();

                    int Mark;
                    do
                    {
                        Console.WriteLine($"Enter the Mark of student {count + 1} (0-100): ");
                    }
                    while (!int.TryParse(Console.ReadLine(), out Mark) || Mark < 0 || Mark > 100);
                    marks[count] = Mark;

                    int Age;
                    do
                    {
                        Console.WriteLine($"Enter the age of student {count + 1}: (>21): ");

                    } while (!int.TryParse(Console.ReadLine(), out Age) || Age <= 21);
                    studentAge[count] = Age;

                    dateTimes[count] = DateTime.Now;
                    Console.WriteLine("Student Add Successfully");
                    count++;

                    Console.WriteLine("Do you want add another student information ? y / n");
                    ChoiceChar = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (ChoiceChar != 'y' && ChoiceChar != 'Y')
                        break;
                }
                if (count == 11)
                    Console.WriteLine("Cannot add more students. Maximum limit reached.");


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
                double TopMark = marks[0];
                string SName = studentName[0];
                for (int i = 1; i < studentAge.Length; i++)
                {
                    if (marks[i] > TopMark)

                    {
                        TopMark = marks[i];
                        SName = studentName[i];

                    }
                   
                }
                Console.WriteLine("student " + SName + "Top Marks :" + TopMark);


            }

            //6. Sort students by marks
            static void SortStudentsByMarks()
            {
                Array.Sort(marks, studentName);
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

            //7. Delete a student record 
            static void DeleteAStudentRecord()
            {
                Console.WriteLine("Enter the student name to delete");
                string deleteName = Console.ReadLine();
                for (int i = 0; i < studentName.Length; i++)
                {
                    if (studentName[i] == deleteName)
                    {
                        studentName[i] = null;
                        studentAge[i] = 0;
                        marks[i] = 0;
                        dateTimes[i] = DateTime.MinValue;
                    }
                }

            }

        }
    }
}