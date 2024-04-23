using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Data
{
    public class ApiContext : DbContext
    {

        public DbSet<TableBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {

        }

    }
}
