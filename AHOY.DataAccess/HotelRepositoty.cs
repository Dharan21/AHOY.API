using AHOY.BusinessEntities;
using AHOY.DataAccess.Interfaces;
using AHOY.DataEntities.Entities;
using AHOY.Infrastructure.Interfaces;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AHOY.Utilities;

namespace AHOY.DataAccess
{
    public class HotelRepositoty : IHotelRepositoty
    {
        #region Variables
        private readonly IUow _uow;
        #endregion

        #region Constructor
        public HotelRepositoty(IUow uow)
        {
            this._uow = uow;
        }
        #endregion

        #region Repository Methods
        public async Task<HotelViewModel?> GetHotelById(int hotelId)
        {
            var hotel = await this._uow.Repository<Hotel>().GetDbSet
                .Include(x => x.HotelImages)
                .Include(x => x.HotelRooms)
                .Include(x => x.HotelFacilities)
                .FirstOrDefaultAsync(x => x.Id == hotelId);
            if (hotel == null) return null;
            return hotel.JsonCast<HotelViewModel>();
        }
        #endregion
    }
}
