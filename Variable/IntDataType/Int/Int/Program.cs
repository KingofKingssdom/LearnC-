namespace Int
{
    internal class Program
    {
        /*
         Lý thuyết 
        - Là từ khóa viết tắt của System.Int32 trong .NET
        - Kích thước 4 bytes (32 bits)
        - Phạm vi lưu trữ nhỏ nhất -2.147.483.648 và lớn nhất 2.147.483.647, có dấu là kiểu lưu trữ số âm và dương, dấu âm cũng chiếm 1 bit
        - Kiểu dữ liệu này biến và giá trị được lưu trữ trên bộ nhớ stack
        - Không thể nhận được kiểu giá trị null trừ khi để là int? (cho phép null)
        - Phép chia 2 số nguyên nó sẽ tự loại bỏ phần thập phân chỉ giữ lại phần nguyên
         */
        static void Main(string[] args)
        {
            /* Bài 1: Khai báo một biến int age có giá trị 20 */
            int a1 = 20;

            /* Bài 2: Khai báo biến int a = 15, int b = 8 và in ra màn hình*/
            int a = 15;
            int b = 8;
            Console.WriteLine("Bài 2 giá trị của biến a và b : " + a + ", " + b);

            /* Bài 3: Nhập một số nguyên từ bàn phím và in ra lại */
            Console.WriteLine("Hãy nhập vào một số ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Số vừa nhập là " + number);

            /* Bài 4: Tính tổng hai số nguyên*/
            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine("Tổng hai số nguyên " + sum);

            /* Bài 5: Tính hiệu hai số nguyên*/
            int x1 = 20;
            int y1 = 10;
            int subtract = x1 - y1;
            Console.WriteLine("Hiệu hai số nguyên " + subtract);

            /*Bài 6: Tính tích hai số nguyên*/
            int x2 = 10;
            int y2 = 10;
            int multiplication = x2 * y2;
            Console.WriteLine("Tích hai số nguyên " + multiplication);

            /*Bài 7: Tính thương hai số nguyên*/
            int x3 = 10;
            int y3 = 3;
            int division = x3 / y3;
            //Console.WriteLine("Thương của 2 số  nguyên " + division); // => Kết quả là ra một số nguyên

            /*Bài 8: Tính phần dư của phép chia 17 chia 5*/
            int x4 = 17;
            int y4 = 5;
            int result = 17 % 5;
            //Console.WriteLine("Kết quả phép chia lấy dư " + result);

            /*Bài 9: Tăng giá trị của biên lên thêm 1 */
            int x5 = 10;
            int x6 = ++x5;
            Console.WriteLine("Giá trị biến  sau khi tăng " + x6);
            // => Lưu ý là đặt ++ trước biến nó sẽ tăng lên rồi mới in ra, còn sau biến thì nó sẽ in ra rồi lần kết quả sau nó mới tăng lên

            /*Bài 10: Khai báo biến có giá trị 2.147.483.647 sau đó dùng phép ++ để tăng giá trị lên và xem kết quả*/
            int x7 = 2147483647;
            x7++;
            Console.WriteLine(x7);
            // => Kết quả là nó quay về giá trị âm nhỏ nhất từ đầu

            /*Bài 11: Khai báo biến có giá trị 2.147.483.648 xem kết quả xảy ra*/
            //int x8 = 2147483648; lỗi biên dịch

            /*Bài 12: In ra int.MaxValue*/
            Console.WriteLine(int.MaxValue); // => in ra giá trị số là 2.147.483.648

            /*Bài 13: In ra int.MinValue*/
            Console.WriteLine(int.MinValue); // => in ra giá trị số là -2.147.483.648

            /*Bài 14: Cho biến có giá trị 5, sau đó thực hiện += 10 */
            int x9 = 5;
            x9 += 10;
            Console.WriteLine(x9);

            /*Bài 15: Ép kiểu double sang kiểu số int*/
            double x10 = 15.8;
            int x11 = (int)x10;
            Console.WriteLine(x11);

            /*Bài 16: Ép kiểu float sang kiểu số int*/
            float x12 = 9.99f;
            int x13 = (int)x12;
            Console.WriteLine(x13);

            /*Bài 17: Ép kiểu long sang kiểu int*/
            long x14 = 1000;
            int x15 = (int)x14;
            Console.WriteLine(x15);

            /*Bài 18: Ép kiểu char sang kiểu int*/
            char c = 'A';
            int x16 = c;
            Console.WriteLine(x16); //=> In ra kết quả là một số trong bảng mã ASCII

            /*Bài 19: Kiểu bool có ép sang kiểu int được không*/
            bool check = true;
            // int x17 = check  // => Ko thể ép sang kiểu int từ bool được vì lý do bool nó có 2 giá trị là true và false, mà trong C# true ko đại diện cho 1 và false cũng vậy, giúp code tường minh hơn

            /*Bài 20: Nhập tuổi, nếu tuổi nhỏ hơn 0 thì báo lỗi */
            Console.WriteLine("Moi nhap vao tuoi");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0)
            {
                Console.WriteLine("Tuoi nhap vao khong hop le");
            }
            else
            {
                Console.WriteLine("Tuoi nhap vao la " + age);
            }

            /*Bài 21: Nhập vào chiều dài và chiều rộng, rồi tính diện tích hình chữ nhật*/
            Console.WriteLine("Nhap vao chieu dai ");
            int cd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong ");
            int cr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dien tich hinh chu nhat " + cd * cr);

            /*Bài 22: Nhập bán kính hình tròn kiểu int và tính đường kính hình tròn*/
            Console.WriteLine("Nhap vao ban kinh hinh tron");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duong kinh hinh tron " + r * 2);

            /*Bài 23: Nhập vào số giây và đổi sang là giờ, phút, giây*/
            Console.WriteLine("Nhap vao so giay ");
            int s = Convert.ToInt32(Console.ReadLine());
            int h = s / 3600;
            int m = (s % 3600) / 60;
            int ss = (s % 3600) % 60;
            Console.WriteLine(h + " gio " + m + " phut " + ss + " giay ");

            /*Bài 24: Viết một chương trình kiểm tra xem cộng hai số int có bị tràn không */
            Console.WriteLine("Moi nhap vao so dau tien ");
            int xI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap vao so thu hai ");
            int xII = Convert.ToInt32(Console.ReadLine());
            if (xI + xII > int.MaxValue)
            {
                Console.WriteLine("Phep cong bi tran so ");
            }
            else
            {
                Console.WriteLine("Phep cong la " + (xI + xII));
            }
        }
    }
}
