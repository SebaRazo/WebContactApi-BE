using WebContactApi.Entities;
using Microsoft.EntityFrameworkCore;
namespace WebContactApi.Data


{
    public class AgendaContext: DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options): base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; } //un context por cada tabla //Contacts: va a ser el nombre de la tabla
        public DbSet<User> Users { get; set; } //un context por cada tabla //Users: va a ser el nombre de la tabla
    }
}
