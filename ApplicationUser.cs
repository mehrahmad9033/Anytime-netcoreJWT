using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTaskManager.Identity
{
	public class ApplicationUser:IdentityUser<string>
	{
		[NotMapped]
		public string Token { get; set; }
	}
}
