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
// Console.WriteLine((double) m/grades.Length);

// using System.Runtime.InteropServices.Marshalling;

// string[] students = { "Аня", "Ярослав", "Вика" };
// int g = 0;
// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     g += 1;
// }
// Console.WriteLine(g);
// int[] points = { 10, 20, 15 };
// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }
// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }
// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;
// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }
//самостоятельные задания
//Задача А
// using System.Runtime.CompilerServices;

// int[] h = { 5, 6, 8, 9, 14 };
// int r = 0;
// foreach (int y in h)
// {
//     Console.WriteLine(y);
//     r += y;
// }
// Console.WriteLine($"сумма {r}");
//задача Г
// int[] n = { 5, 4, 3, 2, 6, 12, 45, 3, 2, };
// int h = 0;
// foreach (int r in n)
// {
//     if (r > h)
//     {
//         h = r;
//     }
// }
// Console.WriteLine($"максимум {h}");
//2 вариант
// string[] h = { "Ярик", "Ярослав", "Ярославчик", "Ярило" };
// int r = 1;
// foreach (string k in h)
// {
//     Console.WriteLine($"{r}. {k}");
//     r += 1;
// }
// 5 вариант
// string[] h = { "Горе от ума", "Муму", "Колобок" };
// string k = "Муму";
// bool found = false;
// foreach (string r in h)
// {
//     if (k == r)
//     {
//         found = true;
//     }
// }
// if (found == true)
// {
//     Console.WriteLine("Найдено");
// }
// else
// {
//     Console.WriteLine("Не найдено");
// }
// Допзадание
string[] names = { "Ярик", "никитос", "Рита" };
int g = 0;
int n = 0;
int[] grades = { 2, 5, 4 };
for (int i = 0; i <= 2; i++)
{
    Console.WriteLine($"{names[i]} - {grades[i]}");
    g += grades[i];
    n += 1;

}
double j = ((double)g / n);
Console.WriteLine(Math.Round(j, 2));

