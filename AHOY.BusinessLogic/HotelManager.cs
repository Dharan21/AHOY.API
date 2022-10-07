using AHOY.BusinessEntities;
using AHOY.BusinessLogic.Interfaces;
using AHOY.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.BusinessLogic
{
    public class HotelManager : IHotelManager
    {
        #region Variables
        private readonly IHotelRepositoty _hotelRepositoty;
        private readonly IFacilityRepository _facilityRepository;
        #endregion

        #region Constructor
        public HotelManager(IHotelRepositoty hotelRepositoty, IFacilityRepository facilityRepository)
        {
            this._hotelRepositoty = hotelRepositoty;
            this._facilityRepository = facilityRepository;
        }
        #endregion

        #region Manager Method
        public async Task<HotelViewModel?> GetHotelById(int hotelId)
        {
            var hotel = await this._hotelRepositoty.GetHotelById(hotelId);
            if (hotel == null) return null;
            if (hotel.HotelFacilities == null) return hotel; 
            foreach (var hotelFacility in hotel.HotelFacilities)
            {
                var facility = await this._facilityRepository.GetFacilityById(hotelFacility.FacilityId);
                hotelFacility.FacilityName = facility?.Name ?? string.Empty;
            }
            return hotel;
        }
        #endregion
    }
}
