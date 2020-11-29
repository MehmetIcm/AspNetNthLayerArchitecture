using AspNetNthLayerArchitecture.Business.Abstract;
using AspNetNthLayerArchitecture.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetNthLayerArchitecture.DataAccess.Concrete.NHiberNate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{Id=1,Name="TV"}
            };
        }
    }
}
