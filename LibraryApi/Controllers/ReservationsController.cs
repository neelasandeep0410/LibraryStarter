using LibraryApi.Models.Reservations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    public class ReservationsController : ControllerBase
    {

        [HttpPost("reservations")]
        public async Task<ActionResult> AddReservation([FromBody] PostReservationRequest request)
        {
            return Ok();
        }


        [HttpGet("reservations/{id}")]
        public async Task<ActionResult> GetReservationById(int id)
        {
            return Ok();
        }
    }
}
