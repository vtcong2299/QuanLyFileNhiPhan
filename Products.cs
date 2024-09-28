using System;
using System.Security.AccessControl;

namespace QuanLyFileNhiPhan
{
    public class Product
    {
        private int proID;
        private string? proName;
        private string? brandName;
        private double proPrice;
        private string? describe;
        public Product(){}
        public Product(int proID, string proName, string brandName, double proPrice, string describe)
        {
            this.proID = proID;
            this.proName = proName;
            this.proPrice = proPrice;
            this.brandName = brandName;
            this.describe = describe;
        }
        public int ProID { get => proID; set => proID = value; }
        public string? ProName { get => proName; set => proName = value; }
        public string? BrandName { get => brandName; set => brandName = value; }
        public double ProPrice { get => proPrice; set => proPrice = value; }
        public string? Describe { get => describe; set => describe = value; }
    }
    
}