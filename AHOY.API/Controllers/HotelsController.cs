using AHOY.BusinessLogic.Interfaces;
using AHOY.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static AHOY.Utilities.RouteConstants;

namespace AHOY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        #region Variables
        private readonly IHotelManager _hotelManager;
        #endregion

        #region Constructor
        public HotelsController(IHotelManager hotelManager)
        {
            this._hotelManager = hotelManager;
        }
        #endregion

        #region Action Methods
        [Route(HotelControllerRoutes.GetHotelById)]
        [HttpGet]
        public async Task<IActionResult> GetHotelById([FromRoute] int hotelId)
        {
            if (hotelId <= 0)
            {
                return BadRequest(new GenericResponseModel<object>()
                {
                    ErrorCount = 1,
                    ErrorMessages = new string[] { Constants.HotelIdNotValid },
                    Data = null
                });
            }
            var hotel = await this._hotelManager.GetHotelById(hotelId);
            if (hotel == null)
            {
                return BadRequest(new GenericResponseModel<object>()
                {
                    ErrorCount = 1,
                    ErrorMessages = new string[] { Constants.HotelIdNotValid },
                    Data = null
                });
            }
            return Ok(new GenericResponseModel<object>(hotel));
        }
        #endregion
    }
}
