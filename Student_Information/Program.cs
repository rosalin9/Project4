// See https://aka.ms/new-console-template for more information
using Student_Information;

Console.WriteLine("Welcome to Student Information");
Console.WriteLine();
Console.Write("Enter the number of students: ");
int StuNum = Convert.ToInt32(Console.ReadLine());
ListOfStudents Obj = new ListOfStudents();
for (int i = 0; i < StuNum; i++)
{
    Obj.AddRecord();
}
Obj.ViewRecord();

Console.Read();
