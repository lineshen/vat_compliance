using Microsoft.AspNet.Identity.EntityFramework;

namespace vat_compliance.Models
{
  public class AppUser : IdentityUser
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
  }
}