using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeBase.Models
{
    public class PinCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? GetEmailCode { get; set; }
        public string? EnterPhoneCode { get; private set; }
        public virtual CreateAccount? CreateAccount { get; set; }
    }
}
