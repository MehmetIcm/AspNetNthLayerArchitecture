using AspNetNthLayerArchitecture.Business.Abstract;
using AspNetNthLayerArchitecture.Entities.Concrete;
using Core.Aspects.Logging;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetNthLayerArchitecture.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)   //IProductDal bir referans tiptir. Eğer bir class'ı IProductDal'dan implemente ettiysek bellekteki adresini tutabilir.
        {
            _productDal = productDal;
        }

        [LogAspect]
        public List<Product> GetAll()
        {
            //İş kodları
            //EfProductDal efProductDal = new EfProductDal();  //Hatalı kod çünkü Ef'ye bağımlıyız bunun için soyutta somut tutarak ctorda çağırabiliriz

            return _productDal.GetAll();
        }
    }
}
