namespace Primitive
{
    internal class Program
    {
        /*Lý thuyết 
         - Tất cả các kiểu dữ liệu nguyên thủy đều là bí danh (alias) của các cấu trúc (struct) trong hệ thống .NET Core (System). 
         ví dụ khi khai báo int thực chất là đang dùng System.Int32 trong .net core và mình đang dùng int để đại diện cho ngắn gọn
         - Kiểu dữ liệu nguyên thủy giá trị và biến được lưu trữ trên bộ nhớ stack
         - Khi gán biến này cho biến mới thực chất ta đang tạo ra một vùng lưu trữ mới nên việc thay đổi biến này không làm thay đổi biến cũ
         - Kiểu dữ liệu nguyên thủy này có vùng chưa giới hạn, nếu cố cộng thêm mà vượt quá giới hạn nó sẽ quay về từ lại giá trị nhỏ nhất 
         */
        static void Main(string[] args)
        {
            /*Bài 1: Khai báo các kiểu dữ liệu int, long gán các giá trị thích hợp và in ra màn hình*/
            int a = 10;
            Console.WriteLine("Kieu du lieu int " + a);
            long a1 = 100000;
            Console.WriteLine("Kieu du lieu long " + a1);

            /*Bài 2: Khai báo kiểu float, double, decimal và gán giá trị 12.5 và in ra màn hình */
            // decimal d = 12.5; => Lỗi biên dịch
            // double d1 = 12.5; => gán được bình thường
            // float d2 = 12.5; =>  Lỗi biên dịch, phải gán thêm 12.5f mới lưu được

            /*Bài 3: Cho biết kích thước (byte) của các kiểu dữ liệu nguyên thủy*/
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(bool));

            
        }
    }
}
