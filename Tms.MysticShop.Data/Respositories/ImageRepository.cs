using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tms.MysticShop.Data.Infrastructure;
using Tms.MysticShop.Model.Models;

namespace Tms.MysticShop.Data.Respositories
{
    public interface IImageRepository : IRepository<Image>
    {

    }
    public class ImageRepository : RepositoryBase<Image>, IImageRepository
    {
        public ImageRepository(DbFactory dbFactory)
           : base(dbFactory)
        {

        }
    }
}
