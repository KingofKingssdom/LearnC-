namespace Test
{
    internal class Program
    {
        /*Lý thuyết 
         - Đa hình là cùng một lời gọi phương thức nhưng có thể tạo ra nhiều hành vi khác nhau tùy theo object thực tế
         - Có 2 loại đa hình
            + Đa hình thời gian biên dịch (hay còn gọi là đa hình tĩnh) đạt được thông qua kĩ thuật nạp chồng phương thức (method overloading)
             -> Kĩ thuật này là kĩ thuật phương thức có cùng tên nhưng khác nhau về số lượng tham số truyền vào hoặc khác kiểu dữ liệu tham số truyền vào
            + Đa hình thời gian chạy (hay còn gọi là đa hình động) đạt được thông qua kĩ thuật ghi đè phương thức (method overriding) đây là cơ chế cho phép C# xác định phương thức (method) nào được gọi khi chương trình đang chạy, dựa trên kiểu của đối tượng thực tế (Actual Object) chứ không dựa trên kiểu của biến tham chiếu
             -> Để thực hiện được đa hình thời gian chạy cần có 3 yếu tố:
                 + Phải có quan hệ kế thừa
                 + Lớp cha sử dụng từ khóa virtual (hoặc abstract) trước phương thức để cho phép ghi đè.
                 + Lớp con sử dụng từ khóa override để định nghĩa lại hành vi của phương thức đó.
         */
        static void Main(string[] args)
        {
            
        }
    }
}
