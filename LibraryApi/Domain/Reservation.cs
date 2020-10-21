using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Domain
{
<<<<<<< HEAD
=======
    public enum ReservationStatus { Pending, Accepted, Rejected }
>>>>>>> upstream/master
    public class Reservation
    {
        public int Id { get; set; }
        public string For { get; set; }
        public string Items { get; set; }
        public DateTime? AvailableOn { get; set; }
<<<<<<< HEAD
=======
        public ReservationStatus Status { get; set; }
>>>>>>> upstream/master
    }
}
