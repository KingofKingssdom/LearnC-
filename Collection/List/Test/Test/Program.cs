namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         - List là một cấu trúc để lưu trữ dữ liệu có cùng kiểu dữ liệu (collection generic), nó cũng vẫn là mảng
         - Generic nó giúp an toàn kiểu dữ liệu, không phải ép kiểu dữ liệu nhanh hơn ArrayList
         - Dùng List thay vì Array vì kích thước động có thể thêm và xóa phần tử linh động hơn Array
         - Trong List có khái niệm Count cho biết số phần tử đang có trong List
         - Trong List có khái niệm Capacity cho biết dung lượng list đã cấp phát, nếu ban đầu chưa có phần tử thì nó sẽ là 0, khi thêm phần tử đầu tiên nó sẽ cấp phát 4 không gian lưu trữ
           nếu hết tối đa thì không gian lưu trữ nó tự tăng lên thêm gấp đôi dung lượng cũ
         
         */
        static void Main(string[] args)
        {
            /* Phương thức Add(): Thêm phần tử vào cuối danh sách*/

            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);
            foreach (int l in l1)
            {
                Console.WriteLine(l);
            }

            /*Phương thức AddRange(): Thêm một tập hợp (collection) các phần tử vào cuối danh sách*/

            List<int> l2 = new List<int>();
            List<int> l3 = new List<int> { 10, 20, 30 };
            l2.AddRange(l3);
            foreach (int l in l2)
            {
                Console.WriteLine(l);
            }

            /*Phương thức Insert(int index, T item): chèn một phần tử (index) vào vị trí chỉ định được chỉ định*/
            List<int> l4 = new List<int> { 10, 20, 30 };
            l4.Insert(0, 40);
            foreach (int l in l4)
            {
                Console.WriteLine(l);
            }

            /*Phương thức InsertRange(int index, IEnumerable<T> collection): Chèn một tập hợp các phần tử bắt đầu từ vị trí (index) được chỉ định.*/
            List<int> l5 = new List<int> { 10, 20, 30 };
            List<int> l6 = new List<int> { 40, 50, 60 };
            l5.InsertRange(1, l6);
            foreach (int l in l5)
            {
                Console.WriteLine(l);
            }

            /*Phương thức Remove(T item): Xóa phần tử đầu tiên khớp với giá trị truyền vào. Trả về true nếu xóa thành công, false nếu không tìm thấy*/
            List<int> l7 = new List<int> { 10, 20, 30 };
            l7.Remove(10);
            foreach (int l in l7)
            {
                Console.WriteLine(l);
            }

            /*Phương thức RemoveAt(int index): Xóa phần tử tại vị trí chỉ định*/
            List<int> l8 = new List<int> { 10, 20, 30 };
            l8.RemoveAt(1);
            foreach (int l in l8)
            {
                Console.WriteLine(l);
            }

            /*Phương thức RemoveAll(Predicate<T> match): Xóa tất cả các phần tử thỏa mãn một điều kiện (Predicate) cho trước.*/
            List<int> l9 = new List<int> { 1, 2, 3, 4, 5, 6 };
            l9.RemoveAll(n => n % 2 == 0);
            foreach (int l in l9)
            {
                Console.WriteLine(l);
            }

            /*Phương thức RemoveRange(int index, int count): Xóa một số lượng phần tử (count) bắt đầu từ vị trí index*/
            List<int> l10 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            l10.RemoveRange(1, 3);
            foreach (int l in l10)
            {
                Console.WriteLine(l);
            }

            /*Phương thức Clear(): Xóa toàn bộ phần tử trong danh sách*/
            List<int> l11 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            l11.Clear();
            foreach (int l in l11)
            {
                Console.WriteLine();
            }

            /*Phương thức Contains(T item): Kiểm tra xem phần tử có tồn tại trong danh sách hay không.*/
            List<int> l12 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool check12 = l12.Contains(10);
            Console.WriteLine(check12);

            /*Phương thức Exists(Predicate<T> match): Kiểm tra xem có bất kỳ phần tử nào thỏa mãn điều kiện hay không. Chỉ cần một phần tử thỏa mãn sẽ là true*/
            List<int> l13 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool check13 = l13.Exists(n => n % 2 == 0);
            Console.WriteLine(check13);

            /*Phương thức Find(Predicate<T> match): Trả về phần tử đầu tiên thỏa mãn điều kiện (trả về giá trị mặc định của T nếu không thấy)*/
            List<int> l14 = new List<int> { 1, 3, 5, 7, 9, 10 };
            int check14 = l14.Find(n => n % 2 == 0);
            Console.WriteLine(check14);

            /*Phương thức FindLast(Predicate<T> match): Trả về phần tử cuối cùng thỏa mãn điều kiện.*/

            /*Phương thức FindAll(Predicate<T> match): Trả về một List<T> mới chứa tất cả các phần tử thỏa mãn điều kiện.*/
            List<int> l15 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> l16 = l15.FindAll(n => n % 2 == 0);
            foreach (int l in l16)
            {
                Console.WriteLine(l);
            }

            /*Phương thức FindIndex(Predicate<T> match): Trả về index của phần tử đầu tiên thỏa mãn điều kiện.*/
            List<int> l17 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int check17 = l17.FindIndex(n => n % 2 == 0);
            Console.WriteLine(check17);

            /*Phương thức FindLastIndex(Predicate<T> match): Trả về index của phần tử cuối cùng thỏa mãn điều kiện*/
            List<int> l18 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int check18 = l18.FindLastIndex(n => n % 2 == 0);
            Console.WriteLine(check18);

            /*Phương thức IndexOf(T item): Trả về vị trí phần tử cụ thể đầu tiên trong danh sách nếu không có sẽ trả về -1*/

            /*Phương thức LastIndexOf(T item): Trả về vị trí phần tử cự thể cuối cùng trong danh sách nếu không có sẽ trả về -1*/

            /*Phương thức BinarySearch(T item): Tìm kiếm nhị phân phần tử (danh sách phải được sắp xếp)*/
            List<int> l19 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int check19 = l19.BinarySearch(5);
            Console.WriteLine(check19);

            /*Phương thức TrueForAll(Predicate<T> match): Kiểm tra xem tất cả các phần tử trong danh sách có đều thỏa mãn điều kiện hay không.*/
            List<int> l20 = new List<int> { 2, 4, 6, 8 };
            bool check20 = l20.TrueForAll(n => n % 2 == 0);
            Console.WriteLine(check20);

            /*Phương thức Sort(): Sắp xếp các phần tử. Hỗ trợ nhiều overload: dùng bộ so sánh mặc định, truyền vào IComparer<T>, Comparison<T>, hoặc chỉ định phạm vi index*/
            List<int> l21 = new List<int> { 2, 1, 6, 4 };
            l21.Sort();
            foreach (int l in l21)
            {
                Console.WriteLine(l);
            }

            /*Phương thức Reverse(): Đảo ngược thứ tự của các phần tử trong danh sách toàn bộ hoặc trong một phạm vi cụ thể*/
            List<int> l22 = new List<int> { 1, 2, 3, 4, 5 };
            l22.Reverse();
            foreach (int l in l22)
            {
                Console.WriteLine(l);
            }

            /*Phương thức ToArray(): Chuyển đổi List<T> thành một mảng T[]
             - Engine chạy nền, các bước sau
              + Nhìn vào list có bao nhiêu phần tử (count)
              + Khởi tạo mảng mới có độ dài (Length) bằng đúng với count
              + Sao chép toàn bộ dữ liệu từ List sang Array mới
              + Mảng mới không tồn tại độc lập hoàn toàn không liên quan 
             */
            List<int> l23 = new List<int> { 10, 20, 30 };
            int[] array = l23.ToArray();
            Console.WriteLine(array);

            /*Phương thức ToList(): chuyển đổi array thành list*/
            int[] array1 = { 1, 2, 3 };
            List<int> l30 = array1.ToList();
            l30.Add(20);
            l30.Add(30);
            foreach(int l in l30)
            {
                Console.WriteLine(l);
            }

            /*Phương thức CopyTo(): Sao chép các phần tử của List vào một mảng một chiều đã tồn tại (có thể chỉ định vị trí bắt đầu).
             Lưu ý engine: 
              -> Nếu copy phần tử có chỉ định vị trí thì các phần tử trong mảng tồn tại sẽ bị thay thế bởi phần tử list
              -> Nếu các phần tử còn lại trong mảng mà không bị fill thì sẽ được lấp bởi số 0 trong mảng nếu kích thước mảng còn mà phần tử chưa đủ
              -> 
             */
            int[] array2 = { 10, 20, 30 };
            List<int> l24 = new List<int> { 1, 2, 3 };
            l24.CopyTo(array2, 0);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            /*Phương thức GetRange(int index, int count): Trích xuất (cắt) một danh sách con (sub-list) từ danh sách hiện tại.*/
            List<int> l25 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> l26 = l25.GetRange(2, 4);
            foreach (int l in l26)
            {
                Console.WriteLine(l);
            }

            /*Phương thức TrimExcess(): Cắt giảm dung lượng (Capacity) của List cho vừa khít với số lượng phần tử thực tế (Count) để tối ưu hóa bộ nhớ.*/
            List<int> l27 = new List<int> { 1 };
            l27.TrimExcess();
            Console.WriteLine($"So phan tu trong mang {l27.Count}");
            Console.WriteLine($"So dung luong trong mang {l27.Capacity}");

        }
    }
}
