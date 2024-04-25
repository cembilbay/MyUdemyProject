using HotelProject.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Businesslayer.Abstract
{
    public interface IContactService:IGenericService<Contact>
    {
        public int TGetContactCount();
    }
}
