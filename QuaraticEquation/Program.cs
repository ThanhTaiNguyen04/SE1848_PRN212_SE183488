﻿using System.Text;

void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        //0x+0=0
        Console.WriteLine("Vô số nghiệm");
    }
    else if (a == 0 && b != 0) 
    {
        Console.WriteLine("Vô nghiệm");
    }
    else
    {
        Console.WriteLine("x={0}", -b / a);
    }
}
void quaratic_equation_solution(double a, double b, double c)
{
    if(a == 0)
    {
        //Phương trình bậc 1: bx+c=0
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
            Console.WriteLine("Vô nghiệm");
        else if (delta == 0)
        {
            Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
        }
        else
        {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("x1 = {0}\nx2 ={1}", x1, x2);
        }
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phương trình bậc 2:");
Console.Write("Nhập hệ số a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Nhập hệ số b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Nhập hệ số c:");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("{0}x^2+{1}x+{2}=0", a, b, c);
quaratic_equation_solution(a, b, c);
Console.ReadLine();