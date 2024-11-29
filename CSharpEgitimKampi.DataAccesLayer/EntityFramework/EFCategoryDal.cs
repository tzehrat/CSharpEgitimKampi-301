using CSharpEgitimKampi.DataAccesLayer.Abstract;
using CSharpEgitimKampi.DataAccesLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.DataAccesLayer.EntityFramework
{
    public class EFCategoryDal:GenericRepository<Category>, ICategoryDal
    {
    }
}
