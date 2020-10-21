<<<<<<< HEAD
﻿using System;
=======
﻿using AutoMapper;
using LibraryApi.Domain;
using LibraryApi.Models.Reservations;
using System;
>>>>>>> upstream/master
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Profiles
{
<<<<<<< HEAD
    public class ReservationsProfile
    {
=======
    public class ReservationsProfile : Profile
    {
        public ReservationsProfile()
        {
            CreateMap<Reservation, ReservationDetailsResponse>();
            CreateMap<PostReservationRequest, Reservation>();
        }
>>>>>>> upstream/master
    }
}
