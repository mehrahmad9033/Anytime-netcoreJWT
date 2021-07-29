 using System;
 
namespace MVCTaskManager.ServiceContracts
{
	public interface IUserService
	{
		Task<ApplicationUser> Authenticate(LoginViewModel loginViewmodel);
	}
}
