using FluentAssertions.Common;
using RO_BOOKING_Backend.Repositories.LocationRepositories;
using RO_BOOKING_Backend.Repositories;
using RO_BOOKING_Backend.Services;
using RO_BOOKING_Backend.Repositories.DestinationRepositories;
using RO_BOOKING_Backend.Repositories.ReservationRepositories;
using RO_BOOKING_Backend.Repositories.DestinationTypeRepositories;



namespace RO_BOOKING_Backend
{
    public class Startup
    {
        public string SpecificOrigins = "_allowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //CORS
            services.AddCors(options =>
            {
                options.AddPolicy(name: SpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("localhost:4200", "http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
                                  });
            });

            //Repositories stuff
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IDestinationTypeRepository, DestinationTypeRepository>();


            services.AddControllers();
            
        }
    }
}
