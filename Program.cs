// string subject = "программирование";
// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine(subject.Length);
int m = 0;
int[] grades = { 4, 5, 3, 5, 4 };
foreach (int grade in grades)
{
    Console.WriteLine(grade);
    m += grade;
}
Console.WriteLine(m/grades.Length);

