using System;
using System.Security.Cryptography.X509Certificates;

namespace QuanLyFileNhiPhan
{
    public class Manager
    {
        public bool isSearch = false;
        public string? id = "0";
        public string sourceFilePath = @"C:\Users\admin\Documents\HocLapTrinh\LapTrinhGameUnity\CongTapCode\C#\BaiTapCodeGym\QuanLyFileNhiPhan\products.csv";
        public void ReadAndPrintProduct()
        {
            int count = 0;
            using (StreamReader reader = File.OpenText(sourceFilePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    string[] parts = line.Split(','); // Cắt chuỗi thành các phần tử dựa trên dấu phẩy
                    string proID = parts[0];
                    string proName = parts[1];
                    string brandName = parts[2];
                    string proPrice = parts[3];
                    string describe = parts[4];
                    if (isSearch)
                    {
                        if (proID == id)
                        {
                            count++;
                            Console.WriteLine($"ProID: {proID}\nProName: {proName}\nBrandName: {brandName}\nProPrice {proPrice}\nDescribe: {describe}");
                            Console.WriteLine("------------------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ProID: {proID}\nProName: {proName}\nBrandName: {brandName}\nProPrice {proPrice}\nDescribe: {describe}");
                        Console.WriteLine("------------------------------------------------------------");
                    }
                }
                if (count == 0 && isSearch == true)
                {
                    Console.WriteLine("Khong co san pham cung ID trong danh sach");
                }
                isSearch = false;
            }
        }
        public void InsertProduct()
        {
            int id;
            string? name;
            string? brandName;
            string? describe;
            double price;
            Console.WriteLine("Nhap thong tin san pham muon them");
            while (true)
            {
                Console.Write("Ma san pham: ");
                if (int.TryParse(Console.ReadLine(), out id))
                { break; }
            }
            Console.Write("Ten san pham: ");
            name = Console.ReadLine();
            Console.Write("Hang san xuat: ");
            brandName = Console.ReadLine();
            while (true)
            {
                Console.Write("Gia: ");
                if (double.TryParse(Console.ReadLine(), out price))
                { break; }
            }
            Console.Write("Mo ta: ");
            describe = Console.ReadLine();
            Product product = new Product(id, name, brandName, price, describe);
            using (StreamWriter writer = new StreamWriter(sourceFilePath, true))
            {
                writer.WriteLine("{0}, {1}, {2}, {3}, {4}", product.ProID, product.ProName, product.BrandName, product.ProPrice, product.Describe);
            }
        }
        public void FindById()
        {
            Console.Write("Nhap ID muon tim kiem: ");
            id = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------");
            if (id != "")
            {
                isSearch = true;
            }
        }
    }
}