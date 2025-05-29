using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.UTF8;
//Tạo đối tượng Category
Category c1 = new Category();   
c1.Id = 1;
c1.Name = "Nước mắm";
//Xuất thông tin bằng cách gọi hàm:
c1.PrintInfor();
c1.Name = "Thuốc trị hôi nách";
Console.WriteLine("Sau khi đổi giá trị: ");
c1.PrintInfor();
//Sử dụng lớp Employee
Console.WriteLine("--------EMPLOYEE--------");
Employee e1 = new Employee();
e1.Id = 1; //gọi setter property của Id
e1.IdCard = "001"; //gọi setter property của IdCard
e1.Name = "Tèo"; //gọi setter property của Name
e1.Email = "teo@gmail.com"; //gọi setter property của Email
e1.Phone = "0981234567"; //gọi setter property của Phone
//Xuất thông tin:
e1.PrintInfor();
Employee e2 = new Employee()
{
    Id = 2,
    IdCard = "001",
    Name = "Tý",
    Email = "ty@hotmail.com",
    Phone = "0912352240"
};
Console.WriteLine("=------Employee 2-------=");
e2.PrintInfor();

Employee e3 = new Employee();
Console.WriteLine("=------Employee 3-------=");
e3.PrintInfor();

//Tạo Employee 4:
Console.WriteLine("=------Employee 4-------=");
Employee e4 = new Employee(4, "004", "Tủn", "tun@gmail.com", "0101010101");
e4.PrintInfor();
Console.WriteLine("=------Employee 4 cách 2-------=");
Console.WriteLine(e4); //tự động gọi hàm ToString()

Console.WriteLine("=========CUSTOMER 1=========");
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyễn Thị Lung Linh",
    Email = "lunglinh@gmail.com",
    Phone = "0987654321",
    Address = "Số 1 - Đinh Tiên Hoàng - Quận 1 - HCM"
};
cus1.PrintInfor();
cus1.Address = "Số 2 - Võ Nguyên Giáp - Thủ Đức";
Console.WriteLine("Customer sau khi đổi địa chỉ: ");
cus1.PrintInfor();

