// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

public class Student
{
    private int[] grades;

    public int[] Grades
    {
        get { return grades; }
        set { grades = value.Where(x => x % 2 == 0).ToArray(); }
    }
}

class Program
{
    static void Main()
    {
        Student st = new Student();
        st.Grades = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        Console.WriteLine(string.Join(", ", st.Grades)); 
    }
}