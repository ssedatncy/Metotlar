using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi");
        }


        //void ile belirtilen metotlar git ekle git güncelle git sil
        //emir kipinde çağırıyoruz işlem sonucuyla ilgilenmiyor.


        public void Update(Product product)
        {

            Console.WriteLine(product.ProductName + " Güncellendi");

        }

    }
}
