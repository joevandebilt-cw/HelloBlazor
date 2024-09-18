using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace CoffeeBrowser.Maui.Auth;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
	private ClaimsPrincipal currentUser = new ClaimsPrincipal(new ClaimsIdentity());
	public override Task<AuthenticationState> GetAuthenticationStateAsync() => Task.FromResult(new AuthenticationState(currentUser));

	public Task LogInAsync()
	{
		var loginTask = LogInAsyncCore();
		NotifyAuthenticationStateChanged(loginTask);
		return loginTask;

		async Task<AuthenticationState> LogInAsyncCore()
		{
			var user = await LoginWithExternalProviderAsync();
			currentUser = user;

			return new AuthenticationState(currentUser);
		}
	}

	private Task<ClaimsPrincipal> LoginWithExternalProviderAsync()
	{
		Claim[] claims = [
			new Claim(ClaimTypes.Name, "Joe"),
			new Claim(ClaimTypes.Role, "Admin")
		];
		var identity = new ClaimsIdentity(claims, "Custom");
		var authenticatedUser = new ClaimsPrincipal(identity);
		return Task.FromResult(authenticatedUser);
	}

	public void Logout()
	{
		currentUser = new ClaimsPrincipal(new ClaimsIdentity());
		NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(currentUser)));
	}
}
