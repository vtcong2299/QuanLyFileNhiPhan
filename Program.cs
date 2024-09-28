using System;
using System.Threading.Tasks.Dataflow;

namespace QuanLyFileNhiPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            int luaChon = 0;
            Manager manager = new Manager();
            while (true)
            {
                Console.WriteLine("Ban muon thuc hien cong viec gi?");
                Console.WriteLine("[1]: In ra danh sach");
                Console.WriteLine("[2]: Them san pham vao danh sach");
                Console.WriteLine("[3]: Tim kiem san pham trong danh sach");
                Console.WriteLine("[0]: Thoat he thong");
                while (true)
                {
                    Console.Write("Nhap lua chon cua ban: ");
                    if (int.TryParse(Console.ReadLine(), out luaChon) && (luaChon == 0 || luaChon == 1 || luaChon == 2 || luaChon == 3))
                        break;
                }
                Console.WriteLine("------------------------------------------------------------");
                switch (luaChon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        manager.ReadAndPrintProduct();
                        break;
                    case 2:
                        manager.InsertProduct();
                        break;
                    case 3:
                        {
                            manager.FindById();
                            manager.ReadAndPrintProduct();
                            break;
                        }
                }
            }

        }
    }
}