namespace SharedTrip.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using ViewModel.Trips;
    public class TripsService:ITripsService
    {
        private readonly ApplicationDbContext dbContext;

        public TripsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(TripAddInputModel tripAddInputModel , string id)
        {
            var trip = new Trip()
            {
                Id = Guid.NewGuid().ToString(),
                StartPoint = tripAddInputModel.StartPoint,
                EndPoint = tripAddInputModel.EndPoint,
                DepartureTime = tripAddInputModel.DepartureTime,
                ImagePath = tripAddInputModel.ImagePath,
                Seats = tripAddInputModel.Seats,
                Description = tripAddInputModel.Description,
                

            };
           
            this.dbContext.Trips.Add(trip);
           dbContext.SaveChanges();
        }

        public IEnumerable<Trip> GetAll()
            => this.dbContext.Trips.Select(x => new Trip()
            {
                Id = x.Id,
                StartPoint = x.StartPoint,
                EndPoint = x.EndPoint,
                DepartureTime = x.DepartureTime,
                Seats = x.Seats,
                }).ToArray();

        public Trip GetById(string id)
            => this.dbContext.Trips.FirstOrDefault(x =>x.Id==id);

        public bool AddUserToTrip(string tripId, string userId)
        {
            var existUser = dbContext.UserTrips.FirstOrDefault(x => x.TripId == tripId && x.UserId == userId);
            if (existUser==null)
            {
                var userTrip = new UserTrip()
                {
                    TripId = tripId,
                    UserId = userId
                };
                this.dbContext.UserTrips.Add(userTrip);
                dbContext.SaveChanges();
                return true;
            }

            return false;

        }
    }
}
