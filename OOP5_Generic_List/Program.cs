//
//Sử dụng Generic List để quản lý nhân sự với đầy đủ 
// Tính năng CRUD
// C-> Create--> Tạo mới dữ liệu
//R--> Read/Retrieve --> Xem, lọc, tìm kiếm, sắp xếp, thống kê....
//U--> Update -->Sửa dữ liệu
//D--> Delete --> xóa dữ liệu
//

// Câu 1 : tạo 5 nhân viên, 3 nhân viên chính thức, 2 thời vụ
//Lưu vào generic List:
using System.Text;
using OOP2;
Console.OutputEncoding = Encoding.UTF8;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Name 1",
    Birthday = new DateTime(1992, 11, 12),
};
employees.Add(fe1);
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Name 2",
    Birthday = new DateTime(1993, 11, 2),
};
employees.Add(fe2);
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    IdCard = "789",
    Name = "Name 3",
    Birthday = new DateTime(1979, 1, 12),
};
employees.Add(fe3);
  
ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 4,
    IdCard = "234",
    Name = "Name 4",
    Birthday = new DateTime(1999, 3, 22),
    WorkingHours = 2,  
};
employees.Add(pe1);

ParttimeEmployee pe2 = new ParttimeEmployee()
{
    Id = 5,
    IdCard = "5678",
    Name = "Name 5",
    Birthday = new DateTime(1989, 6, 23),
    WorkingHours = 3,   
};
employees.Add(pe2);


//Câu 2 R-->Xuất toàn bộ nhân sự:
Console.WriteLine("Câu 2: R--> Xuất toàn bộ nhân sự:");
//Cách 1 :
employees.ForEach(e => Console.WriteLine(e));

//Câu 3: R-> Lọc ra các nhân sự là chính thức
//cách 1:
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("Câu 3: R-> Lọc ra các nhân sự chính thức: ");
foreach (FulltimeEmployee fe in fe_list)
    Console.WriteLine(fe);

//Câu 4: Tổng lương nhân viên chính thức:
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Câu 4: Tổng lương nhân viên chính thức: ");
Console.WriteLine(fe_sum_salary);

//Câu 5: Tổng lương nhân viên thời vụ:
double pe_sum_salary = employees.OfType<ParttimeEmployee>().Sum(e => e.calSalary());
Console.WriteLine("Câu 5: Tổng lương nhân viên thời vụ: ");
Console.WriteLine(pe_sum_salary);

//Bổ sung thêm các tính năng xóa, sửa dữ liệu nhân viên 
// Câu 6: Delete - Xóa nhân viên theo Id
Console.Write("Câu 6: Nhập ID nhân viên cần xóa: ");
int deleteId = int.Parse(Console.ReadLine());

Employee? employeeToDelete = employees.FirstOrDefault(e => e.Id == deleteId);
if (employeeToDelete != null)
{
    employees.Remove(employeeToDelete);
    Console.WriteLine($"Đã xóa nhân viên có ID = {deleteId}");
}
else
{
    Console.WriteLine("Không tìm thấy nhân viên với ID đã nhập.");
}

Console.WriteLine("Danh sách nhân viên sau khi xóa:");
employees.ForEach(e => Console.WriteLine(e));

// Câu 7: Update - Sửa thông tin nhân viên theo Id
Console.Write("Câu 7: Nhập ID nhân viên cần sửa: ");
int updateId = int.Parse(Console.ReadLine());

Employee? employeeToUpdate = employees.FirstOrDefault(e => e.Id == updateId);
if (employeeToUpdate != null)
{
    Console.Write("Nhập tên mới: ");
    string newName = Console.ReadLine();
    Console.Write("Nhập ID Card mới: ");
    string newIdCard = Console.ReadLine();


    employeeToUpdate.Name = newName;
    employeeToUpdate.IdCard = newIdCard;

    Console.WriteLine("Cập nhật thông tin thành công.");
}
else
{
    Console.WriteLine("Không tìm thấy nhân viên với ID đã nhập.");
}

Console.WriteLine("Danh sách nhân viên sau khi cập nhật:");
employees.ForEach(e => Console.WriteLine(e));
