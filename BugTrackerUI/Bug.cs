using System.ComponentModel.DataAnnotations;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        [Range(minimum:1, maximum:5)]
        public int Priority { get; set; }
    }
}
