using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAll();


            Console.WriteLine(result.Success);

            Console.ReadLine();
        }
    }
}
