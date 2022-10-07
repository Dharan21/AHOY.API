using AHOY.BusinessEntities;

namespace AHOY.BusinessLogic.Interfaces
{
    public interface IHotelManager
    {
        Task<HotelViewModel?> GetHotelById(int hotelId);
    }
}