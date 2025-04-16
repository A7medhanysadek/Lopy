using LopyBackendWebApp.Data;
using LopyBackendWebApp.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LopyBackendWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class FlightsController : ControllerBase
{

    private readonly Context _dbcontext;
    public FlightsController(Context context)
    {
        _dbcontext = context;
    }

    [HttpPost]
    [Route("BookFlight")]
    public ActionResult BookFlight(string source, string destination, DateOnly date, string paymentInfo)
    {
        var try_booking = new flightbookingfacade();
        return try_booking.BookFlight(source, destination, date, paymentInfo,_dbcontext) ? Ok() : NotFound();
    }
}
