using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public InputData Input { get; set; }

        public InputData Output { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Suckess");
                Input.PhoneNumber = Input.PhoneNumber ?? "No number";
                Output = Input;
            }
            Console.WriteLine("Return Page");
            return Page();
        }

        public class InputData
        {
            [Required]
            [StringLength(10, ErrorMessage = "Maximum length is {1}")]
            [Display(Name = "Your name")]
            public string FirstName { get; set; }

            [Required]
            [StringLength(10, ErrorMessage = "Maximum length is {1}")]
            [Display(Name = "Last name")]
            public string LastName { get; set; }

            [Required]
            [EmailAddress(ErrorMessage = "Not a valid input")]
            [Display(Name = "Your e-mail adress")]
            public string Mail { get; set; }

            [Phone]
            [Display(Name = "Phone number")]
            public string? PhoneNumber { get; set; }
        }

    }

}