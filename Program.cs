// string subject = "программирование";
// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);
// int m = 0;
// int[] grades = { 4, 5, 3, 5, 4 };
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     m += grade;
// }
// Console.WriteLine(m/grades.Length);

// using System.Runtime.InteropServices.Marshalling;

// string[] students = { "Аня", "Ярослав", "Вика" };
// int g = 0;
// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     g += 1;
// }
// Console.WriteLine(g);
int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}
foreach (int point in points)
{
    Console.WriteLine(point);
}

