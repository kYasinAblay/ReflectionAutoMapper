using System;

namespace ReflectionAutoMapVS2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DTOProducts dto = new DTOProducts();
            dto.Stok = 1;
            dto.ProductName = "i5 Bilgisayar";
            dto.Discount = 2500;
            Products NewProduct = ObjectConvert.Convert<DTOProducts, Products>(dto);

            Products products = new Products();
            products.Id = 009;
            products.Stok = 1;
            products.ProductName = "i7 Bilgisayar";
            products.Discount = 2500;
            DTOProducts NewDtoProducts =
            ObjectConvert.Convert<Products, DTOProducts>(products);

            Console.WriteLine("Hello New Tactic!");
            Console.ReadKey();
        }
    }
}
