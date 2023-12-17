using DEMO.API2.Models;
using Refit;

namespace DEMO.API2.DataAccess
{
    public interface IGuestData
    {
        //[HttpGet]
        //[HttpGet("{id}")]
        //[HttpPost]
        //[HttpPut("{id}")]
        //[HttpDelete("{id}")]


        [Get("/guests")]
        Task<List<GuestModel>> GetGuests();

        [Get("/guests/{id}")]
        Task<GuestModel> GetGuestById(int id);

        [Post("/guests")]
        Task AddGuest([Body]GuestModel guest);

        [Put("/guests/{id}")]
        Task UpdateGuest(int id, [Body]GuestModel guest);

        [Delete("/guests/{id}")]
        Task<GuestModel> DeleteGuest(int id);
    }
}
