using RO_BOOKING_Backend.Data;
using RO_BOOKING_Backend.Entities;
using RO_BOOKING_Backend.Repositories.DestinationRepositories;
using RO_BOOKING_Backend.Repositories.DestinationTypeRepositories;
using RO_BOOKING_Backend.Repositories.LocationRepositories;
using RO_BOOKING_Backend.Repositories.ReservationRepositories;
using RO_BOOKING_Backend.Repositories.SessionTokenRepositories;
using RO_BOOKING_Backend.Repositories.UserRepositories;

namespace RO_BOOKING_Backend.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly AppDbContext _context;

        private IUserRepository _user;
        private IReservationRepository _reservation;
        private IDestinationRepository _destination;
        private ISessionTokenRepository _sessionToken;
        private IDestinationTypeRepository _destinationType;
        private ILocationRepository _location;


        public RepositoryWrapper(AppDbContext context)
        {
            _context = context;
        }


        public IReservationRepository Reservation
        {
            get
            {
                if (_reservation == null) _reservation = new ReservationRepository(_context);
                return _reservation;
            }
        }

        public ILocationRepository Location
        {
            get
            {
                if (_location == null) _location = new LocationRepository(_context);
                return _location;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_user == null) _user = new UserRepository(_context);
                return _user;
            }
        }
        public IDestinationRepository Destination

        {
            get
            {
                if (_destination == null) _destination = new DestinationRepository(_context);
                return _destination;
            }
        }
        public IDestinationTypeRepository DestinationType
        {
            get
            {
                if (_destinationType == null) _destinationType = new DestinationTypeRepository(_context);
                return _destinationType;
            }
        }
        public ISessionTokenRepository SessionToken
        {
            get
            {
                if (_sessionToken == null) _sessionToken = new SessionTokenRepository(_context);
                return _sessionToken;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
   
}
