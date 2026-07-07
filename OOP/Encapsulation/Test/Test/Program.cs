namespace Test
{
    internal class Program
    {  /*Lý thuyết
       - Đóng gói là nguyên tắc ẩn dữ liệu bên trong object và chỉ cho phép truy cập thông qua phương thức hoặc giao diện mà class cung cấp
       - Đóng gói giúp bảo vệ dữ liệu, kiểm soát dữ liệu, tránh object ở trạng thái không hợp lệ, dễ bảo trì code
       - Các access modifier giúp đóng  gói dữ liệu
        + public : truy cập được mọi nơi trong class kể cả khác project
        + private: chỉ truy cập được trong cùng class
        + protected: chỉ truy cập trong cùng class và các class con kế thừa từ class đó
        + internal: trong cùng một assembly (nghĩa là chỉ truy cập được trong cùng 1 project)
        => Khi một project bấm build hoặc run nó sẽ tạo ra một file assembly là file .exe hoặc file .dll nằm trên ổ cứng máy tính
       - Kết hợp việc sử dụng properties để tạo ra tính đóng gói
        => Khi thuộc tính mà chỉ có get không có set thì sau khi chạy xong constructor nó kh còn được gán lại giá trị dù cho cùng 1 class

       

       */
        static void Main(string[] args)
        {
            /*Bài tập: Thiết kế class BankAccount với các yêu cầu:
                        AccountNumber: chỉ đọc sau khi khởi tạo.
                        Owner: có thể đọc và sửa, nhưng không được để trống.
                        Balance: chỉ đọc từ bên ngoài.
                        Deposit(decimal amount): chỉ chấp nhận số tiền dương.
                        Withdraw(decimal amount): không cho rút quá số dư và không cho rút số âm. 
            */
            BankAccount b = new BankAccount("079201");
            
            b.Owner = "Chu the Nguyen Van A";
            b.Deposit(10000);
            Console.WriteLine($"So tai khoan {b.AccountNumber} {b.Owner} co so du {b.Balance}");
            b.Withdraw(-5000);
            Console.WriteLine($"So tai khoan {b.AccountNumber} {b.Owner} co so du sau giao dich {b.Balance}");

        }
    }
}
