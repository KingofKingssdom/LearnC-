namespace Test
{
    internal class Program
    {
        /*Lý thuyết
         - Dictionary<TKey,TValue> là Collection Generic lưu dữ liệu dưới dạng cặp Key–Value, trong đó Key phải duy nhất và được tối ưu để tra cứu theo Key rất nhanh.
         - Dictionary không đảm bảo thứ tự phần tử
         - Sử dụng HashTable
         - 
         */
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "One");
            d.Add(3, "Three");
            d.Add(2, "Two");
            foreach(var item in d)
            {
                Console.WriteLine(item);
            }
        }
    }
}
