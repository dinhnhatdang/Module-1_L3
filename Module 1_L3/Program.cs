using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không.Hiển thị kết quả ra màn hình.

            //Console.WriteLine("Nhập vào số nguyên: ");
            //string a = (Console.ReadLine());
            //int SoThuDuoc;
            //bool kiemtra = int.TryParse(a, out SoThuDuoc);
            //if (kiemtra == false)
            //{
            //    Console.WriteLine("Nhập số nha bạn!");
            //}
            //else
            //{

            //    if (SoThuDuoc % 3 == 0)
            //    {
            //        Console.WriteLine("Số bạn vừa nhập chia hết cho 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Số bạn vừa nhập không chia hết cho 3");
            //    }
            //}
            //Console.ReadKey();

            // Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình.

            /* Console.WriteLine("Nhập vào số nguyên dương: ");
            string a = (Console.ReadLine());
            int SoThuDuoc;
            bool kiemtra = int.TryParse(a, out SoThuDuoc);
            if (kiemtra == false)
            {
                Console.WriteLine("Nhập số nha bạn!");
            }
            else
            {

                if (SoThuDuoc <= 0)
                {
                    Console.WriteLine("Nhập số dương khác 0 đi bạn!");
                }
                else
                {
                    Console.WriteLine("Bảng cửu chương từ 1 đến " + SoThuDuoc);
                    for (int i = 1; i <= SoThuDuoc; i++)
                    {
                        Console.WriteLine("Bảng cửu chương {0}", i);
                        for (int j = 1; j <= 10;j++)
                        {
                            Console.WriteLine("{0}x{1}={2}", i, j, (i * j));
                        }    

                    }
                }
            }
            Console.ReadKey(); */

            // Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển  thị kết quả ra màn hình

            /* Console.WriteLine("Nhập vào số nguyên dương: ");
            string a = (Console.ReadLine());
            int SoThuDuoc;
            bool kiemtra = int.TryParse(a, out SoThuDuoc);
            if (kiemtra == false)
            {
                Console.WriteLine("Nhập số nha bạn!");
            }
            else
            {

                if (SoThuDuoc <= 0)
                {
                    Console.WriteLine("Nhập số dương khác 0 đi bạn!");
                }
                else
                {
                    int TongGiaiThua = 0;
                    for (int i = 1; i <= SoThuDuoc; i++)
                    {
                        int GiaiThua = 1;
                        for (int j = 1; j <= i; j++)
                        {
                           GiaiThua = GiaiThua * j;
                        }
                        TongGiaiThua = TongGiaiThua + GiaiThua;
                    }
                    Console.WriteLine("Tổng giai thừa từ 1 đến {0} là {1}",SoThuDuoc, TongGiaiThua);
                }
            }
            Console.ReadKey();*/


            // Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            // Số chính phương là số bằng bình phương đúng của một số nguyên.

            /* Console.WriteLine("Nhập vào số nguyên để kiểm tra số chính phương: ");
            string a = (Console.ReadLine());
            int SoThuDuoc;
            bool kiemtra = int.TryParse(a, out SoThuDuoc);
            if (kiemtra == false)
            {
                Console.WriteLine("Nhập số bạn gì ơi!");
            }
            else
            {

                if (SoThuDuoc <= 0)
                {
                    Console.WriteLine("{0} nhập không phải số chính phương", SoThuDuoc);
                }
                else
                {
                    double Scp = Math.Sqrt(SoThuDuoc);
                    int n = (int)Scp;
                    
                   if (n == Scp)
                    {
                        Console.WriteLine("{0} là số chính phương", SoThuDuoc);
                    }
                   else
                    {
                        Console.WriteLine("{0} không phải là số chính phương", SoThuDuoc);
                    }
                }
                
            }
            Console.ReadKey();*/

            //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình.


            /* int SoThuDuoc;
            bool kiemtra;
            do
            {
                Console.WriteLine("Nhập vào tháng kiểm tra số ngày có trong tháng đó: ");
                string a = (Console.ReadLine());
                kiemtra = int.TryParse(a, out SoThuDuoc);
            }
            while (!kiemtra);
            if (SoThuDuoc > 12)
                {
                    Console.WriteLine("Có tháng lớn vậy hở");
                }
            else
                {
                    switch (SoThuDuoc)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.WriteLine("thang {0} có 31 ngày", SoThuDuoc);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            Console.WriteLine("thang {0} có 30 ngày", SoThuDuoc);
                            break;
                        case 2:
                            Console.WriteLine("Tháng này thì nhập thêm số năm nha");
                            string Nam = (Console.ReadLine());
                            int NamThuDuoc;
                            bool kiemtraNam = int.TryParse(Nam, out NamThuDuoc);
                            if (kiemtraNam == false)
                            {
                                Console.WriteLine("Nhập năm bạn ơi!");
                            }
                            else
                            {
                                if (NamThuDuoc%4==0)
                                {
                                    Console.WriteLine("Tháng 2 này có 29 ngày");
                                }
                                else
                                {
                                    Console.WriteLine("Tháng 2 này có 28 ngày");
                                }
                                
                            }
                            break;
                    }

                 }
            Console.ReadKey();*/

            //Bài 6: Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình.

            /* int SoThuDuoc;
            bool kiemtra;
            do
            {
                Console.WriteLine("Nhập vào số nguyên dương: ");
                string a = (Console.ReadLine());
                kiemtra = int.TryParse(a, out SoThuDuoc);
            }
            while (!kiemtra);

            if (SoThuDuoc <= 0)
            {
                Console.WriteLine("Nhập số > 0 đi bạn!");
            }
            else
            {
                double Tong = 0;
                for (int i = 1; i <= SoThuDuoc; i++)
                {
                    Tong = Tong + Math.Pow(i, i);
                }
                Console.WriteLine("Tổng là {0}", Tong);
            }
        Console.ReadKey(); */

            // Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình

            /* int SoThuDuoc;
            bool kiemtra;
            do
            {
                Console.WriteLine("Nhập vào số nguyên dương: ");
                string a = (Console.ReadLine());
                kiemtra = int.TryParse(a, out SoThuDuoc);
            }
            while (!kiemtra);

            if (SoThuDuoc <= 0)
            {
                Console.WriteLine("Nhập số > 0 đi bạn!");
            }
            else
            {
                double Tong = 0;
                for (int i = 1; i <= SoThuDuoc; i++)
                {
                    if (i % 2 != 0)
                        Tong = Tong + i;
                }
                Console.WriteLine("Tổng các số lẻ từ 1 đển {0} là {1}",SoThuDuoc, Tong);
            }
            Console.ReadKey(); */

            // Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.

           int SoThuDuoc;
           bool kiemtra;
           do
           {
               Console.WriteLine("Nhập vào số nguyên dương: ");
               string a = (Console.ReadLine());
               kiemtra = int.TryParse(a, out SoThuDuoc);
           }
           while (!kiemtra);

           if (SoThuDuoc <= 2)
           {
               Console.WriteLine("Không có số nguyên tố nào cả");
           }
           else
           {
               for (int i = 1; i <= SoThuDuoc; i++)
               {
                   if (i % 2 != 0)
                       Tong = Tong + i;
               }
               Console.WriteLine("Tổng các số lẻ từ 1 đển {0} là {1}",SoThuDuoc, Tong);
           }
           Console.ReadKey();

        }
    }
}
