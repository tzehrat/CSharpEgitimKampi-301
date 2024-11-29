using CSharpEgitimKampi.DataAccesLayer.Abstract;
using CSharpEgitimKampi.DataAccesLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.DataAccesLayer.EntityFramework
{
    public class EFOrderDal:GenericRepository<Order>,IOrderDal
    {
    }
}
