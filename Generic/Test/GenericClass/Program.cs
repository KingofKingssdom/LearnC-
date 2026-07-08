namespace GenericClass
{
    internal class Program
    {
        /*Lý thuyết về Generic class
         - Generic Class là một lớp (class) được định nghĩa với một hoặc nhiều tham số kiểu dữ liệu (Type Parameters), cho phép cùng một lớp làm việc với nhiều kiểu dữ liệu khác nhau mà không cần viết lại mã.
         - T là Type parameter nó là một "ký hiệu đại diện" cho kiểu dữ liệu sẽ được truyền vào sau này.
        */
        public static void InMaSo<T>(T doiTuong) where T : IThucThe
        {
            // THÀNH CÔNG: Vì đã có 'where', C# biết chắc chắn T có thuộc tính Id.
            Console.WriteLine($"Mã số là: {doiTuong.Id}");
        }
        static void Main(string[] args)
        {
            

        Box<int> b = new Box<int>();
            b.Value = 10;
            Console.WriteLine(b.Value);
            Box<string> b2 = new Box<string>();
            b2.Value = "Xin chào";
            Console.WriteLine(b2.Value);

            /*Generic Constraint giúp kiểm tra xem kiểu dữ liệu chuyền vào T có thỏa mãn các tiêu chuẩn không*/
            /*Cú pháp ràng buộc Where T : class nghĩa là truyền kiểu dữ liệu vào T phải là kiểu tham chiếu*/
            // Ví dụ
            // 1. Tạo một quy tắc (Interface) bắt buộc phải có thuộc tính Id
            // 2. Các class thực tế tuân theo quy tắc Nhân viên, Sản phẩm kế thừa IThucThe còn Động Vật thì không
            // 3. Hàm Generic CÓ RÀNG BUỘC (Ép T phải là IThucThe)

            NhanVien nv = new NhanVien { Id = 101 };
            SanPham sp = new SanPham { Id = 202 };
            DongVat dv = new DongVat { Name = "Mèo" };

            InMaSo<NhanVien>(nv); // Hợp lệ, in ra 101
            InMaSo<SanPham>(sp);  // Hợp lệ, in ra 202

            // InMaSo<DongVat>(dv); => NẾU BỎ COMMENT DÒNG NÀY SẼ BỊ LỖI GẠCH ĐỎ NGAY LẬP TỨC!
        }
    }
}
