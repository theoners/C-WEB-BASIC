namespace SharedTrip.Services
{
    using System.Collections.Generic;
    using Models;
    using ViewModel.Trips;
    public interface ITripsService
    {
        void Add(TripAddInputModel tripAddInputModel, string id);

        IEnumerable<Trip> GetAll();

        Trip GetById(string id);

       bool AddUserToTrip(string tripId,string userId );
    }
}
