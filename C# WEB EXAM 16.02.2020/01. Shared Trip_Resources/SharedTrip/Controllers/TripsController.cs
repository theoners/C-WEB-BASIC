namespace SharedTrip.Controllers
{
    using SIS.HTTP;
    using Models;
    using Services;
    using ViewModel.Trips;
    using SIS.MvcFramework;

    using static Data.Constant.TripConstant;
    public class TripsController: Controller
    {
        private readonly ITripsService tripService;
       

        public TripsController(ITripsService tripService)
        {
            this.tripService = tripService;
           
        }
        public HttpResponse Add()
        {
            return this.View();
        }

       
        [HttpPost]
        public HttpResponse Add(TripAddInputModel inputModel, User user)
        {
           
            if (!this.IsUserLoggedIn())
            {
                return this.Redirect($"/Users/Login");
            }

            if (inputModel.Seats < SeatsMinLength || inputModel.Seats > SeatsMaxLength)
            {
                return this.View($"/Trips/Add");
            }

            if (inputModel.Description.Length>DescriptionMaxLength)
            {
                return this.View($"/Trips/Add");
            }

          


            tripService.Add(inputModel, this.User);

            return this.Redirect($"/Trips/All");
        }

        public HttpResponse All()
        {
            if (this.IsUserLoggedIn())
            {
                var allTrips= tripService.GetAll();

                return this.View(allTrips);
            }

            return this.View($"/");
        }

        public HttpResponse Details(string tripId)
        {
            if (this.IsUserLoggedIn())
            {
                var trip = tripService.GetById(tripId);

                return this.View(trip);
            }

            return this.View($"/");
        }

        public HttpResponse AddUserToTrip(string tripId)
        {
            if (this.IsUserLoggedIn())
            {
                var added = tripService.AddUserToTrip(tripId,this.User);
                if (added)
                {
                    return this.Redirect($"/Trips/All");
                }

                return this.Details(tripId);

            }

            return this.Redirect($"/");
        }
    }
}
