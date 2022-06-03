using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MudBlazorWASM.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual IEnumerable<GroupClaims> GroupClaims { get; set; }
    }

    public class GroupClaims
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NormalizedName { get; set; }
        public string? ConCurrencyStamp { get; set; }
        public string? ApplicationUserId { get; set; }
        [ForeignKey("WebAppUser")]
        public string? SchoolUserId { get; set; }

    }
}
