namespace CoffeeBrowser.Maui.Data;

public class CoffeeService : ICoffeeService
{
	public async Task<IEnumerable<Coffee>> LoadCoffeeAsync()
	{
		Coffee[] coffees = [
			new Coffee("Cappucino", "Coffee with milk foam"),
			new Coffee("Doppio", "Double Espresso")
		];

		//Simulate server work
		await Task.Delay(50);

		return coffees;
	}
}
