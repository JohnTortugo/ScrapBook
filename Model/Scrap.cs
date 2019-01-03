using System.ComponentModel.DataAnnotations;

namespace ScrapBook
{
    public class Scrap
    {
        public int ScrapId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(500)]
        public string Message { get; set; }
    }
}