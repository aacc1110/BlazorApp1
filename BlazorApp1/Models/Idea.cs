using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Model
{
    public class Idea
    {
        public int Id { get; set; }
        [Required]
        public string Note { get; set; }
    }
}
