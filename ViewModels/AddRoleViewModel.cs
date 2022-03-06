using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModels
{
    public class AddRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
