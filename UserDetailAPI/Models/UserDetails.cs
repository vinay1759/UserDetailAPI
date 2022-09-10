using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserDetailAPI.Models
{
    public class UserDetails
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; } = default!;

        public string UserAddress { get; set; } = default!;

        public int UserPhone { get; set; } = default!;

        public string UserBankname { get; set; } = default!;

        public int UserAccNo { get; set; } = default!;

        public int UserBalance { get; set; } = default!;

        public string UserBranch { get; set; } = default!;

        public string UserPass { get; set; } = default!;

        public bool UserActive { get; set; } = default!;
    }
}
