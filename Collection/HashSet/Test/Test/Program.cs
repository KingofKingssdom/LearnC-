namespace Test
{
    internal class Program
    {
        /*Lý thuyết 
         - HashSet<T> là một Collection Generic dùng để lưu trữ các phần tử duy nhất (không trùng lặp).
         - Được thiết kế dựa trên cấu trúc dữ liệu Bảng băm (Hash Table). Nó có 2 nguyên tắc tối thượng:
          + Tuyệt đối không chứa phần tử trùng lặp (Unique): Mỗi giá trị chỉ được xuất hiện đúng một lần duy nhất.
          + Không có thứ tự (Unordered): Các phần tử bên trong không được sắp xếp theo thứ tự bạn thêm vào. Không thể truy cập phần tử bằng chỉ số (index) như hashSet[0] hay hashSet[1].
         - HashSet nó được hoạt động dựa trên HashTable tìm hiểu kĩ HashTable là hiểu rõ
         - Tốc độ tra cứu nhanh nhờ thuật toán băm hashing
         */
        static void Main(string[] args)
        {
            /*Thêm phần từ trùng lặp HashSet kiểm tra nếu đã tồn tại thì nó bỏ qua*/
            HashSet<int> h = new HashSet<int>();
            h.Add(10);
            h.Add(20);
            h.Add(10);
            foreach(var item in h)
            {
                Console.WriteLine(item);
            }


        }
    }
}
