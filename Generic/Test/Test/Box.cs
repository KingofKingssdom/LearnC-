using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class Box<T>
    {
        public T Value { set; get; }
        // Chưa xác định kiểu dữ liệu khi tạo đối tượng thì nó mới xác định kiểu dữ liệu

    }
}
