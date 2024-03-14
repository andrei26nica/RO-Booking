using FluentAssertions.Common;
using RO_BOOKING_Backend.Repositories.LocationRepositories;
using RO_BOOKING_Backend.Repositories;
using RO_BOOKING_Backend.Services;
using RO_BOOKING_Backend.Repositories.DestinationRepositories;
using RO_BOOKING_Backend.Repositories.ReservationRepositories;
using RO_BOOKING_Backend.Repositories.DestinationTypeRepositories;
using Microsoft.AspNetCore.Identity;
using RO_BOOKING_Backend.Data;
using RO_BOOKING_Backend.Entities.Constants;
using RO_BOOKING_Backend.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;




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
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IDestinationTypeRepository, DestinationTypeRepository>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ManagerApp_Backend", Version = "v1" });
            });

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Data Source=LAPTOP-6HI8RGNG;Initial Catalog=Booking;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            services.AddIdentity<User, Role>()
                  .AddEntityFrameworkStores<AppDbContext>()
                  .AddDefaultTokenProviders();

            _ = services.AddControllersWithViews()
               .AddNewtonsoftJson(options =>
               options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole(UserRoleType.Admin));
                options.AddPolicy("User", policy => policy.RequireRole(UserRoleType.User));
            });
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
          .AddJwtBearer(options =>
          {
              options.SaveToken = true;
              options.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuer = false,
                  ValidateAudience = false,
                  ValidateLifetime = true,
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my custom secret key for auth")),
                  ValidateIssuerSigningKey = true
              };
              options.Events = new JwtBearerEvents()
              {
                  OnTokenValidated = Helpers.SessionTokenValidator.ValidateSessionToken
              };
          });
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ManagerApp_Backend v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(SpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
