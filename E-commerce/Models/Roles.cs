using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace E_commerce.Models
{
	[Table("Roles")]
	public class Roles
	{
		public Roles()
		{
			RoleAccounts = new HashSet<RoleAccount>();
		}

		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public bool Status { get; set; }

		public virtual ICollection<RoleAccount> RoleAccounts { get; set; }
	}
}
