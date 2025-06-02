using OOP3_ExtensionMethod;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine($"Tổng từ 1 đến {n1} = {n1.TongTu1toiN()}");
Console.WriteLine($"Tổng từ 1 đến {n2} = {n2.TongTu1toiN()}");
Console.WriteLine("Tổng từ 1 đến 8 = " + 8.TongTu1toiN());

Console.WriteLine("8 + 7 = " + 8.Cong(7));

int[] M = new int[8];
M.TaoMang();
Console.WriteLine("Mảng sau khi tạo ngẫu nhiên:");
M.XuatMang();
M.SapXepMangTangDan();
Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
M.XuatMang();
M.SapXepMangGiamDan();
Console.WriteLine("Mảng sau khi sắp xếp giảm dần:");
M.XuatMang();