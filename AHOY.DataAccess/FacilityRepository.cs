using AHOY.BusinessEntities;
using AHOY.DataAccess.Interfaces;
using AHOY.DataEntities.Entities;
using AHOY.Infrastructure.Interfaces;
using AHOY.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHOY.DataAccess
{
    public class FacilityRepository : IFacilityRepository
    {
        #region Variables
        private readonly IUow _uow;
        #endregion

        #region Constructor
        public FacilityRepository(IUow uow)
        {
            this._uow = uow;
        }
        #endregion

        #region Repository Methods
        public async Task<FacilityMasterViewModel?> GetFacilityById(int facilityId)
        {
            var facility = await this._uow.Repository<FacilityMaster>().GetById(facilityId);
            if (facility == null) return null;
            return facility.JsonCast<FacilityMasterViewModel>();
        }
        #endregion
    }
}
