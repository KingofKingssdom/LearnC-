namespace SortedSet
{
    internal class Program
    {
        /*Lý thuyết
        - SortedSet<T> là một Collection Generic dùng để lưu trữ các phần tử duy nhất (không trùng lặp) và luôn được sắp xếp theo thứ tự tăng dần mặc định.
        - SortedSet không dùng Hash Table mà dùng Nó sử dụng cây tìm kiếm nhị phân cân bằng (Balanced Binary Search Tree), trong .NET hiện nay là Red-Black Tree. 
        - 
         */
        static void Main(string[] args)
        {
            SortedSet<int> s = new SortedSet<int>();
            s.Add(10);
            s.Add(2);
            s.Add(20);
            s.Add(3);
            foreach(var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
