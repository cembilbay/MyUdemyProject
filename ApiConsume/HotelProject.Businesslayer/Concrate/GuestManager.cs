﻿using HotelProject.Businesslayer.Abstract;
using HotelProject.DataAcessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Businesslayer.Concrate
{
    public class GuestManager:IGuestService
    {
        private readonly IGuestDal _guestDal;
        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void TDelete(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest TGetById(int id)
        {
            return _guestDal.GetById(id);
        }

        public List<Guest> TGetList()
        {
            return _guestDal.GetList();
        }

        public void TInsert(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void TUpdate(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
