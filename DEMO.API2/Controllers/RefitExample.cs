using DEMO.API2.DataAccess;
using DEMO.API2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMO.API2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RefitExampleController : ControllerBase
    {
        private readonly IGuestData _guestData;

        public RefitExampleController(IGuestData guestData)
        {
            _guestData = guestData;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _guestData.GetGuests());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok(await _guestData.GetGuestById(id));
        }
        [HttpPost()]
        public async Task<IActionResult> AddGuest([FromBody] GuestModel model)
        {
            await _guestData.AddGuest(model);
            return Ok();
        }
    }
}
