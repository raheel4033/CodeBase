using System.ComponentModel.DataAnnotations;

namespace CodeBase.Models
{
    public class CreateAccount
    {
        public string? CustomerName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public long? NicNumber { get;set; }
        public string? MobileNumber { get;set; }

        public virtual PinCode? PinCode { get; set; }

    }
}
