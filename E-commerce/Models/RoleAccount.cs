using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_commerce.Models
{
	[Table("RoleAccounts")]
	public class RoleAccount
	{
		
		public int RoleId { get; set; }

		public int AccountId { get; set; }

		public bool Status { get; set; }

		public virtual Account Account { get; set; }

		public virtual Roles Roles { get; set; }
	}
}
