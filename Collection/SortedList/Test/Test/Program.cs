using System.Collections;

namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         - SortedList<TKey, TValue> là một Collection Generic dùng để lưu trữ các cặp Key - Value và tự động sắp xếp theo Key.
         - Key là khóa dùng để xác định phần tử, key không được đặt trùng nếu không sẽ báo lỗi
         - Value là giá trị lưu trữ, value được phép đặt trùng
         - Tìm theo Key nhanh.
         */
        static void Main(string[] args)
        {
            /*Thuộc tính Key lấy toàn bộ key trong danh sách*/
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(1, "One");
            s1.Add(3, "Three");
            s1.Add(2, "Two");
            foreach(KeyValuePair<int, string> k in s1)
            {
                Console.WriteLine(k.Key);
            }
            /*Thuộc tính Value lấy toàn bộ value trong danh sách*/
            foreach (KeyValuePair<int, string> k in s1)
            {
                Console.WriteLine(k.Value);
            }

            /*Sử dụng kĩ thuật indexer để ghi đè value nếu key đã tồn tại*/
            SortedList<int, string> s2 = new SortedList<int, string>();
            s2.Add(1, "One");
            s2[1] = "Two"; // => Giá trị two này sẽ ghi đè giá trị one
            foreach(var s in s2)
            {
                Console.WriteLine(s.Key);
                Console.WriteLine(s.Value);
            }

            /*Phương thức TryGetValue(): (Dịch thô: Thử Lấy Giá Trị) kết hợp cả 2 bước kiểm tra và lấy dữ liệu vào làm một, giúp chương trình của bạn vừa không bao giờ bị crash, vừa tối ưu hiệu năng cực nhanh (chỉ tìm kiếm đúng 1 lần).
             Cú pháp của nó đi kèm với từ khóa out (đẩy dữ liệu ra ngoài)
             */
            /*Khi sử dụng dấu ngoặc vuông với key để lấy ra value, nếu key không tồn tại sẽ crash chương trình*/
            SortedList<int, string> tuDien = new SortedList<int, string>();
            tuDien.Add(1, "Quả Táo");
            tuDien.Add(2, "Quả Chuối");

            // Truy cập Key = 1 (Tồn tại)
            string traiCay = tuDien[1]; // Hoạt động tốt, trả về "Quả Táo"

            // Truy cập Key = 99 (KHÔNG tồn tại)
            string traiCayLoi = tuDien[99]; // BÙM!

            /*Để tránh chết chương trình thì trước đây kiếm tra trong hàm như này*/
            if (tuDien.ContainsKey(99))
            {
                string kq1 = tuDien[99]; // Phải tìm kiếm trong danh sách LẦN 2 để lấy dữ liệu
            }

            // Biến kq sẽ chứa giá trị nếu tìm thấy, hoặc chứa null nếu không tìm thấy
            if (tuDien.TryGetValue(99, out string kq2))
            {
                Console.WriteLine($"Tìm thấy rồi, giá trị là: {kq2}");
            }
            else
            {
                Console.WriteLine("Key 99 không tồn tại, chương trình vẫn chạy tiếp bình thường!");
            }

            
        }
    }
}
