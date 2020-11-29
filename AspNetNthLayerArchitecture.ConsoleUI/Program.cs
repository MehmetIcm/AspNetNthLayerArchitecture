using AspNetNthLayerArchitecture.Business.Abstract;
using AspNetNthLayerArchitecture.Business.Concrete;
using AspNetNthLayerArchitecture.DataAccess.Concrete.EntityFramework;
using AspNetNthLayerArchitecture.DataAccess.Concrete.NHiberNate;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetNthLayerArchitecture.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //IoC Container
            IProductService productService = new ProductManager(new EfProductDal());
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}
