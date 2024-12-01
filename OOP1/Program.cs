// See https://aka.ms/new-console-template for more information

using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitInStok = 3;



Product product2 = new Product { Id=2, CategoryId=5, UnitInStok=5,
    ProductName="Kalem",UnitPrice=35};   

//Class ismi   //degisken ismi genelde class isminin kucuk harfle baslayan(camel case) versiyonu
//PascalCase   //camelCase
ProductManager productManager = new ProductManager();

productManager.Add(product1);
productManager.Add(product2);