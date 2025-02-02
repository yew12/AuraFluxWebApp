using System.ComponentModel.DataAnnotations;

namespace AuraFluxWebApp.Frontend.Models;

public class ContactFormDetails
{
    [Required(ErrorMessage = "Please enter your name.")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Please enter a subject." )]
    public string Subject { get; set; } = "";

    [Required(ErrorMessage = "Please enter a valid email address.")]
    [EmailAddress]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Please enter a message.")]
    public string Message { get; set; } = "";
}
