using AHOY.BusinessEntities;

namespace AHOY.DataAccess.Interfaces
{
    public interface IHotelRepositoty
    {
        Task<HotelViewModel?> GetHotelById(int hotelId);
    }
}