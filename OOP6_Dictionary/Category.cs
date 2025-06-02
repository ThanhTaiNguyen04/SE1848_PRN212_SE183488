using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            //Khởi tạo Products là một Dictionary rỗng
            Products = new Dictionary<int, Product>();
        }
        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
        //Khi quản lý mọi đối tượng ta đều phải đáp ứng đẩy đủ tính năng CRUD

        public void AddProduct(Product p)
        {
            //kiểm tra nếu Id của Product chưa tồn tại thì thêm mới
            if (p == null)
            {
                return; //dữ liệu đậu vào null
            }
            if (Products.ContainsKey(p.Id))
            {
                return; //Id đã tồn tại
            }
            //Thêm mới Product vào Dictionary
            Products.Add(p.Id, p);
        }
        //Xuất toàn bộ sản phẩm:
        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> kvp in Products)
            {
                Product p = kvp.Value;
                Console.WriteLine(p);
            }
        }
        //Lọc các sản phẩm có giá từ min tới max
        public Dictionary<int, Product>
            FilterProductByPrice(double min, double max)
        {
            return Products
                .Where(item => item.Value.Price >= min && item.Value.Price <= max)
                .ToDictionary<int, Product>();
        }
        //Sắp xếp sản phẩm theo đơn giá tăng dần:
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }
        //Sắp xếp theo đơn giá Tăng dần, nếu đơn giá trùng nhau sắp xếp theo sô lượng Giảm dần
        public Dictionary<int, Product> SortComplex()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)               
                .ToDictionary<int, Product>();
        }
        //Sửa sản phẩm
        public bool UpdateProduct(Product p)
        {
            if (p == null)
                return false;
            if (Products.ContainsKey(p.Id) == false)
            {
                return false; //Id không tồn tại
            }
            //Cập nhật giá trị tại ô nhớ chưa  p.Id
            Products[p.Id] = p;
            return true; //đánh dấu là thành công
        }
        //Xóa sản phẩm
        public bool RemoveProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
                return false; //Id không tồn tại
            Products.Remove(id);
            return true; 
        }
        //Viết hàm xóa các sản phẩm có giá từ a đến b
        public void RemoveProductsByPriceRange(double min, double max)
        {
            var productsToRemove = Products
                .Where(kvp => kvp.Value.Price >= min && kvp.Value.Price <= max)
                .Select(kvp => kvp.Value)
                .ToList();

            Console.WriteLine($"Các sản phẩm có giá từ {min} đến {max} sẽ bị xóa:");
            foreach (var p in productsToRemove)
            {
                Console.WriteLine(p);
                Products.Remove(p.Id);
            }
        }

    }
}
