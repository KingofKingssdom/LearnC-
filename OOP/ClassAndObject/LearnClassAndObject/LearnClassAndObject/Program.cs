
namespace LearnClassAndObject
{
    internal class Program
    {
        /*Lý thuyết
         - Class là bản thiết kế của đối tượng
         - Đối tượng là thể hiện của lớp đó
         */
        static void Main(string[] args)
        {
            /*Bài 1: Tạo class Student có 2 thuộc  tính là Name và Age, sau đó gán giá trị và in ra màn hình*/
            Student s1 = new Student();
            s1.Name = "Huy";
            s1.Age = 25;
            Console.WriteLine($"Doi tuong co ten la {s1.Name} co tuoi {s1.Age}");

            /*Bài 2: Tạo class Car có thuộc tính Brand, Color, Year tạo ra 3 object và in ra thông tin*/
            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Color = "Black";
            car1.Year = 1880;
            Console.WriteLine($"Loai xe 1: {car1.Brand} mau {car1.Color} san xuat nam {car1.Year}");

            Car car2 = new Car();
            car2.Brand = "Audi";
            car2.Color = "Yellow";
            car2.Year = 1990;
            Console.WriteLine($"Loai xe 2: {car2.Brand} mau {car2.Color} san xuat nam {car2.Year}");

            Car car3 = new Car();
            car3.Brand = "Mercedes";
            car3.Color = "White";
            car3.Year = 2000;
            Console.WriteLine($"Loai xe 3: {car3.Brand} mau {car3.Color} san xuat nam {car3.Year}");

            /*Bài 3: Tạo class Book có Title, Author, Price và tạo và in ra 2 đối tượng sách*/
            Book b1 = new Book();
            b1.Title = "Truyen Kieu";
            b1.Author = "Nguyen Du";
            b1.Price = 10000;
            Console.WriteLine($"Sach 1: {b1.Title} cua tac gia {b1.Author} co gia {b1.Price}");

            Book b22 = new Book();
            b22.Title = "Lao Hac";
            b22.Author = "Nam Cao";
            b22.Price = 20000;
            Console.WriteLine($"Sach 22: {b22.Title} cua tac gia {b22.Author} co gia {b22.Price}");

            /*Bài 4: Tạo class rectangle và tinh chu vi, diện tích hình chữ nhất đó*/
            Rectangle r1 = new Rectangle();
            r1.Width = 10;
            r1.Height = 20;
            double p = (r1.Width + r1.Height) * 2;
            double s = r1.Width * r1.Height;
            Console.WriteLine("Dien tich hinh chu nhat " + s);
            Console.WriteLine("Chu vi hinh chu nhat " + p);

            /*Bài 5: Tạo class circle tính chu vi và diện tích hình tròn*/
            Circle c1 = new Circle();
            c1.Radius = 2;
            double pc = c1.Radius * 2 * Math.PI;
            double sc = c1.Radius * c1.Radius * Math.PI;
            Console.WriteLine("Chu vi hinh tron " + pc);
            Console.WriteLine("Dien tich hinh tron " + sc);

            /*Bài 6: Tạo class Employee với thuộc tính Name, Salary và tạo đối tượng in ra màn hình*/
            Employee e1 = new Employee();
            e1.Name = "Hai";
            e1.Salary = 20000000;
            Console.WriteLine($"Nhan vien: {e1.Name} co luong {e1.Salary}");

            /*Bài 7: Tạo class Product với thuộc tinh Name và Price, viết tạo ra phương thức PrintInfo*/
            Product p1 = new Product();
            p1.Name = "Dien Thoai";
            p1.Price = 10000;
            p1.PrintInfo();

            /*Bài 8: Từ class Book trên hay tạo ra một list book thêm 5 loại sách và in ra chung*/
            List<Book> books = new List<Book>();
            Book b2 = new Book();
            b2.Title = "Nhà Giả Kim";
            b2.Author = "Paulo Coelho";
            b2.Price = 70000;

            Book b3 = new Book();
            b3.Title = "Đắc Nhân Tâm";
            b3.Author = "Dale Carnegie";
            b3.Price = 80000;

            Book b4 = new Book();
            b4.Title = "Hoàng Tử Bé";
            b4.Author = "Antoine de Saint-Exupéry";
            b4.Price = 46000;

            Book b5 = new Book();
            b5.Title = "Đi Tìm Lẽ Sống";
            b5.Author = "Viktor Frankl";
            b5.Price = 75000;

            Book b6 = new Book();
            b6.Title = "Lược Sử Loài Người";
            b6.Author = "Yuval Noah Harari";
            b6.Price = 179000;

            books.Add(b2);
            books.Add(b3);
            books.Add(b4);
            books.Add(b5);
            books.Add(b6);

            foreach (Book b in books)
            {
                Console.WriteLine($"Sach {b.Title} co tac gia {b.Author} gia {b.Price}");
            }

            /*Bài 9: Viết phương thức PrintStudent và nhận vào đối tượng student và in ra*/
            Student s4 = new Student();
            s4.Name = "Huy";
            s4.Age = 25;

            static void PrintStudent(Student s)
            {
                Console.WriteLine($"Hoc sinh ten {s.Name} {s.Age} tuoi");
            }

            PrintStudent(s4);

            /*Bài 10: Viết hàm IncreaseSalary() tăng thêm 10% lương*/
            Employee e5 = new Employee();
            e5.Name = "Huy";
            e5.Salary = 7000000;
            static double IncreaseSalary(Employee e)
            {
                double increase = e.Salary * 10 / 100;
                double increaseSalary = e.Salary + increase;
                return e.Salary = increaseSalary;

            }
            IncreaseSalary(e5);
            Console.WriteLine($"Luong cua {e5.Name} la {e5.Salary} tang 10% ");

            /*Bài 11: Viết hàm CreateNewStudent() trong hàm tạo mới student gán tên mới sau đó quan sát đối tượng cũ*/
            Student s7 = new Student();
            s7.Name = "Huy";
            s7.Age = 25;
            static string CreateNewStudent(Student s)
            {
                s = new Student();
                return s.Name = "Hoc sinh";
            }
            CreateNewStudent(s7);
            Console.WriteLine(s7.Name);
            // Kết quả đúng là không đổi, nhưng cần tìm hiểu lại kĩ

            /*Bài 12: Tạo đối tượng student1 sau đó tạo đối tượng student2 từ việc gán đối tượng student1, tiếp đó 
             tạo tiếp student2 mới sau đó quan sát 
             */

            Student s11 = new Student();
            s11.Name = "An";

            Student s12 = s11;

            s12 = new Student();
            s12.Name = "Bình";

            Console.WriteLine(s11.Name);
            Console.WriteLine(s12.Name);
            // => Kết quả vấn An Bình vì cần tìm hiểu kĩ lại
            Console.WriteLine();
            Convert.ToInt32(Console.ReadLine());
        }
    }
}
