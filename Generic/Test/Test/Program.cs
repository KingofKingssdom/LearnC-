namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         - Generic là một cơ chế trong C# cho phép tạo các lớp, phương thức, interface hoặc delegate có thể làm việc 
        với nhiều kiểu dữ liệu khác nhau mà vẫn đảm bảo an toàn kiểu dữ liệu (Type Safety).
        => nói đơn giản Generic cho phép viết một lần, dùng cho nhiều kiểu dữ liệu khác nhau.
         - Thường được nhận diện qua cặp ngoặc nhọn <T>) là cơ chế cho phép bạn định nghĩa các Class, Method (Phương thức), hoặc Interface như một "bản mẫu" (template) mà không cần phải chỉ định ngay kiểu dữ liệu cụ thể
         */

        /*Lý thuyết về Generic class
         - Generic Class là một lớp (class) được định nghĩa với một hoặc nhiều tham số kiểu dữ liệu (Type Parameters), cho phép cùng một lớp làm việc với nhiều kiểu dữ liệu khác nhau mà không cần viết lại mã.
         - 
         */
        static void Main(string[] args)
        {
            Box<int> b = new Box<int>();
            b.Value = 10;
            Console.WriteLine(b.Value);
            Box<string> b2 = new Box<string>();
            b2.Value = "Xin chào";
            Console.WriteLine(b2.Value);

        }
    }
}
