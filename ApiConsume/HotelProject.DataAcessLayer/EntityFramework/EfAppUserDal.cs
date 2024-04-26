using HotelProject.DataAcessLayer.Abstract;
using HotelProject.DataAcessLayer.Concrate;
using HotelProject.DataAcessLayer.Repositories;
using HotelProject.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAcessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {

        }

        public int AppUserCount()
        {
            var context = new Context();
            var value = context.Users.Count();
            return value;
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            var context = new Context();
            return context.Users.Include(x => x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorkLocations()
        {
            var context = new Context();
            //var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWithWorkLocationDto
            //{
            //    Name = y.Name,
            //    Surname = y.Surname,
            //    WorkLocationID = y.WorkLocationID,
            //    WorkLocationName = y.WorkLocation.WorkLocationName
            //});
            var values = context.Users.ToList();
            return values.ToList();
        }
    }
}
