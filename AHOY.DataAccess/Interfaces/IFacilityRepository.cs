using AHOY.BusinessEntities;

namespace AHOY.DataAccess.Interfaces
{
    public interface IFacilityRepository
    {
        Task<FacilityMasterViewModel?> GetFacilityById(int facilityId);
    }
}