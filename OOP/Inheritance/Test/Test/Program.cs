namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         - Là một class có thể nhận đầy đủ các thuộc tính và phương thức của class khác mà nó đang kế thừa, ngoài ra có thể thêm các thuộc tính và phương thức riêng
         - Muốn kế thừa phải có mối quan hệ Is-A nghĩa là lớp con là phiên bản cụ thể hơn của lớp Cha
         Vd Con mèo, con chó là mối quan hệ Is-A trong lớp Animal
         - Mối quan hệ Has-A đại diện cho mối quan hệ sở hữu hoặc chứa trong nên không thể là kế thừa 
         Vd Car Has a engine (nghĩa là chiếc xe có một động cơ, chứ không thể nói chiếc xe là một động cơ)
         - Nếu class cha có constructor thì class con bắt buộc phải gọi là constructor của Cha qua từ khóa base(thuộc tính cha)
         - Có thể gọi phương thức của Class Cha thông qua base.PhuongThucCha()
         - Không có đa kế thừa, nghĩa là vừa kế thừa từ class này mà lại vừa kế thừa từ class khác
         
         */
        static void Main(string[] args)
        {
            /*Bài 1: Tạo class Animal có 2 thuộc tính Name, Age. Sau đó tạo class Dog kế thừa từ Animal và thử truy cập Name*/
            //Dog d = new Dog();
            //d.Name = "Lucky";
            //Console.WriteLine(d.Name);

            /*Bài 2: Tạo class Cat kế thừa Animal và thêm thuộc tính color vào cat, in thông tin*/
            //Cat c = new Cat();
            //c.Color = "Yellow";
            //Console.WriteLine(c.Color);

            /*Bài 3: Thêm phương thức Eat(), Run() vào lớp Animal và dùng lớp Dog gọi*/
            //Dog d2 = new Dog();
            //d2.Eat();
            //d2.Run();

            /*Bài 4: Thêm phương thức Sleep() vào lớp Animal và dung class Cat gọi*/
            //Cat c2 = new Cat();
            //c2.Sleep();

            /*Bài 5: Tạo class Person có thuộc tính name, class Student kế thừa Person có thêm School, class Teacher kế thừa từ Person có thêm Subject*/
            //Student s1 = new Student();
            //s1.Name = "Hung";
            //s1.School = "Dai hoc A";
            //Console.WriteLine($"Hoc sinh {s1.Name} hoc tai {s1.School}");

            //Teacher t1 = new Teacher();
            //t1.Name = "Lan";
            //t1.Subject = "Tieng Anh";
            //Console.WriteLine($"Giao vien {t1.Name} day mon {t1.Subject}");

            /*Bài 6: Trong lớp Animal đổi thuộc tính Age thành protected và dùng lại class dog truy cập thử */
            //Dog d2 = new Dog();
            //Console.WriteLine(d2.Age); // => Không truy cập được thuộc tính với protected

            /*Bài 7: Trong class Person tạo constructor có tham số name và để lớp student gọi lại bằng base*/
            Person p7 = new Person("Nam");
            Student s7 = new Student("Huy");

        }
    }
}
