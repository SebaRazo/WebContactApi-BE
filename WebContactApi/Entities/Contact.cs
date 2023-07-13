using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebContactApi.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CelularNumber { get; set; }
        public int? TelephoneNumber { get; set; }
        public string Description = String.Empty;

    }
}
