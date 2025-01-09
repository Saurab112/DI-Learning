namespace ScopedService.ServiceContracts
{
	public interface IShoppingCartService
	{
		void AddItem(string itemName, int quantity);
		List<string> GetItems();
	}
}
