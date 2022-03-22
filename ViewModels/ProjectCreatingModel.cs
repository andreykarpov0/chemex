using System.ComponentModel.DataAnnotations;

namespace chemex.ViewModels
{
    public class ProjectHandlingModel
    {
        [Required]
        public string Name { get; set; }
    }
}
