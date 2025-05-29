using System.Text;

Console.OutputEncoding = Encoding.UTF8;

void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong hàm ={n}");
}
int n = 5;
Console.WriteLine($"n trước khi vào hàm ={n}");
ham1(n);
Console.WriteLine($"n sau khi vào hàm ={n}");