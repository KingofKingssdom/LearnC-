namespace ReferenceDataType
{
    internal class Program
    {
        /*Lý thuyết
         - Khi khai báo một biến kiểu tham chiếu, bộ nhớ sẽ chia làm hai phần:
            + Vùng nhớ Stack: Chỉ lưu trữ một địa chỉ ô nhớ (con trỏ hoặc "địa chỉ nhà").
            + Vùng nhớ Heap: Là nơi thực sự lưu trữ giá trị dữ liệu thực tế. Vùng nhớ này do trình thu gom rác Garbage Collector (GC) của .NET quản lý để tự động giải phóng khi không còn dùng tới.
         - Khi gán giá trị biến có kiểu dữ liệu tham chiếu thực chất sao chép địa chỉ của ô nhớ này sang ô nhớ khác chứ không sao chép giá trị,
            nên khi đổi giá trị biến này cũng làm thay đổi giá trị biến khác.
         - Vì kiểu tham chiếu lưu trữ địa chỉ, nên sẽ có trường hợp một biến tham chiếu chưa trỏ vào đâu cả. Trạng thái này được biểu diễn bằng từ khóa null, 
            nếu cố tình truy cập vào một thuộc tính hoặc hàm của một biến đang bị null, chương trình sẽ lập tức bị sập và ném ra lỗi kinh điển: NullReferenceException.
         */
        static void Main(string[] args)
        {
            /*Bài 1: Khai báo một biến string lưu tên của bạn và in ra màn hình.*/
            //string s = "Huy";
            //Console.WriteLine(s);

            /*Bài 2: Khai báo 2 biến firstName và lastName và ghép lại thành 1 tên đầy đủ*/
            //string lastName = "Nguyen";
            //string firstName = "A";
            //Console.WriteLine($"Ho ten day du {lastName} {firstName}");

            /*Bài 3: Nhập một chuỗi từ bàn phím và in ra độ dài của chuỗi*/
            //Console.WriteLine("Nhap vao mot chuoi tuy thich");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Do dai cua chuoi: " + s1.Length);

            /*Bài 4: Nhập một chuỗi và chuyển toàn bộ sang chữ hoa*/
            //Console.WriteLine("Nhap vao mot chuoi tuy thich");
            //string s2 = Console.ReadLine();
            //Console.WriteLine("Chuoi da duoc chuyen thanh viet hoa " + s2.ToUpper());

            /*Bài 5: Kiểm tra chuỗi có chứa chữ C# hay không*/
            //string s3 = "Xin chào tôi học lập trình C#, hello world";
            //if (s3.Contains("C#"))
            //{
            //    Console.WriteLine("Chuỗi có chứa C#");
            //}
            //else
            //{
            //    Console.WriteLine("Chuỗi không chứa C#");
            //}

            /*Bài 6: Khai báo object có giá trị là 100 và in ra màn hình kiểu dữ liệu của biến*/
            //object value = 10;
            //Console.WriteLine(value.GetType()); // Kết quả in ra là System.Int32 để biết nó thuộc kiểu dữ liệu nào

            /*Bài 7: Lưu lần lượt vào một biến object: int, string, bool Quan sát điều gì xảy ra.*/
            //object value1 = 100;
            //Console.WriteLine(value1);
            //value1 = "Xin chào các bạn";
            //Console.WriteLine(value1);
            //value1 = true;
            //Console.WriteLine(value1);
            // => Nhận xét một biến object có thể gán được nhiều kiểu dữ liệu

            /*Bài 8: Tạo mảng string gồm 5 tên và in ra các phẩn tử trong mảng*/
            //string [] array = { "Cam", "Xoài", "Mít", "Táo", "Ổi" };
            //for(int i = 0; i< array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            /*Bài 9: Nhập một tên kiểm tra tên đó có tồn tại trong mảng không*/
            // Console.WriteLine("Hay nhap vao mot ten trai cay");
            // string sf = Console.ReadLine();
            // string[] food = { "Táo", "Xoài", "Mít", "Cam", "Ổi" };
            //for(int i = 0; i < food.Length; i++)
            // {
            //     if (food[i] == sf)
            //     {
            //         break;

            //     }
            //     else
            //     {
            //         continue;

            //     }
            // }

            /*Bài 10: Tạo class student và in ra đối tượng đó */

            //Student s1 = new Student();
            //s1.Name = "Huy";
            //s1.Age = 25;
            //Console.WriteLine($"Ten doi tuong {s1.Name} co tuoi la {s1.Age}");

            /*Bài 11: Tạo 2 đối tượng student và dùng == để so sánh đánh giá kết quả*/
            //Student s2 = new Student();
            //s2.Name = "Huy";
            //s2.Age = 25;
            //Student s3 = new Student();
            //s3.Name = "Huy";
            //s3.Age = 25;
            //Console.WriteLine(s2 == s3);
            // => Kết quả false vì s1 và s2 là hai đối tượng khác nhau được tạo bởi hai lần gọi new.
            // Mỗi đối tượng có một vùng nhớ riêng trên Heap. Toán tử == của class (mặc định) so sánh địa chỉ
            // tham chiếu, không so sánh dữ liệu bên trong đối tượng. Vì hai tham chiếu trỏ đến hai đối tượng
            // khác nhau nên kết quả là false

            /*Bài 12:  Tạo đối tượng đầu tiên sau đó tạo đối tượng thứ 2 nhưng được gán từ đối tượng 1, rồi gán giá trị lại xem kết quả*/
            //Student s3 = new Student();
            //s3.Name = "Thanh";
            //s3.Age = 25;
            //Student s4 = s3;
            //Console.WriteLine(s4.Name);
            // => gán là cùng s3 và s4 cùng tham chiếu (trỏ) đến cùng một đối tượng trên bộ nhớ heap nên đổi cái này cái kia cũng đổi theo

            /*Bài 13: Tạo class Book và làm các yêu cầu
             * 1. Tạo đối tượng book1.
               2. Gán Book book2 = book1;
               3. Thay đổi giá của book2.
               4. In thông tin của cả book1 và book2.
               5. Giải thích tại sao kết quả như vậy.
               6. Hãy nghĩ cách tạo một đối tượng mới có cùng dữ liệu với book1 nhưng thay đổi book2 không làm ảnh hưởng đến book1
             */
            Book b1 = new Book("Vật lý 12", "Bộ giáo dục", 20000);
            Book b2 = b1;
            b2.Price = 18000;
            Console.WriteLine($"Thông tin sách 1: tên sách {b1.Title} tác giả {b1.Author} giá {b1.Price}");
            Console.WriteLine($"Thông tin sách 2: tên sách {b2.Title} tác giả {b2.Author} giá {b2.Price}");
            // Kết quả giống nhau vì cả 2 cùng tham chiếu đến 1 địa chỉ trên bộ nhớ heap
            Book b3 = new Book();
            b3.Price = b1.Price;
            b3.Author = b1.Author;
            b3.Title = b1.Title;
            b3.Price = 15000;
            Console.WriteLine($"Thông tin sách 1 sau khi đổi sách 3 {b1.Title} tác giả {b1.Author} giá {b1.Price}");
        }
    }
}
