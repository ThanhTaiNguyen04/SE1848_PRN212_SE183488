using System.Text;
using OOP2;
using OOP4_Reuse_OOP2;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee fe = new FulltimeEmployee();
fe.Id = 1;
fe.Name = "Putin";
fe.IdCard = "12345";
fe.Birthday = new DateTime(1952, 5, 7);
Console.WriteLine(fe);
Console.WriteLine("=> AGE = " + fe.Tuoi());
Console.WriteLine("=> Sinh nhật tháng này? " + (fe.SinhNhatThangNay() ? "Có" : "Không"));