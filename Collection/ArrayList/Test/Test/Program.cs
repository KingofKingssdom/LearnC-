using System.Collections;

namespace Test
{
    internal class Program
    {
        /*Lý thuyết 
         - ArrayList là một Collection không Generic, dùng để lưu trữ nhiều phần tử với kích thước có thể thay đổi trong quá trình chạy chương trình.
         - Muốn sử dụng phải thêm using System.Collections;
         - Lưu dữ liệu dưới dạng object
         - Khi lưu kiểu giá trị (int, double...) sẽ xảy ra Boxing.
         - Khi lấy dữ liệu phải Unboxing hoặc ép kiểu.
         - Chậm hơn List<T>.
         - Ít được dùng trong các dự án .NET hiện đại. 
         */


        static void Main(string[] args)
        {
            /*Vì sao ArrayList lưu được mọi kiểu dữ liệu?
             - vì bên trong nó lưu tất cả phần tử dưới dạng object
             - Trong thế giới C#, có một quy tắc tối cao: Mọi kiểu dữ liệu đều tự động kế thừa từ lớp System.Object (viết tắt bằng từ khóa object). 
            */
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("ABC");
            list.Add(true);

            /*Cơ chế boxing và unboxing
             - Boxing (Đóng hộp): Khi dùng lệnh arrayList.Add(5), C# sẽ lấy số 5 (vốn là kiểu int), gói nó vào bên trong một chiếc hộp object mới tinh, rồi mới đặt chiếc hộp đó vào ArrayList
             - Unboxing (Mở hộp): Khi muốn lấy số 5 đó ra để làm toán học, ArrayList chỉ trả về cho bạn cái "hộp carton". Nó hoàn toàn không nhớ bên trong chứa gì. Bạn bắt buộc phải "xé hộp" 
            và tự cam kết với máy tính rằng: "Tôi chắc chắn bên trong là số nguyên, hãy ép kiểu (cast) nó về int cho tôi".
             */
            ArrayList danhSachTapNham = new ArrayList();
            danhSachTapNham.Add(100);       // Đóng hộp một số int
            danhSachTapNham.Add("Hello");   // Ép kiểu string về object
            danhSachTapNham.Add(true);      // Đóng hộp một giá trị bool

            int soX = (int)danhSachTapNham[0]; // bắt buộc phải ép kiểu rõ ràng unboxing


            /*Các phương thức thì nó vẫn dùng giống List<T>*/
        }
    }
}
