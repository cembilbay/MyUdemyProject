﻿using HotelProject.DataAcessLayer.Abstract;
using HotelProject.DataAcessLayer.Concrate;
using HotelProject.DataAcessLayer.Repositories;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAcessLayer.EntityFramework
{
    public class EfWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
    {
        public EfWorkLocationDal(Context context) : base(context)
        {

        }
    }
}
