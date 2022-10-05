using AHOY.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AHOY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        #region Variables
        #endregion

        #region Constructor
        public HotelsController()
        {

        }
        #endregion

        #region Action Methods
        public IActionResult GetHotels()
        {
            return Ok(new GenericResponseModel<object>(null));
        }
        #endregion
    }
}
