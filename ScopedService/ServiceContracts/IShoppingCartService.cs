namespace ScopedService.ServiceContracts
{
	public interface IShoppingCartService
	{
		void AddItem(string itemName, int quantity);
		List<string> GetItems();
		void RemoveItem(string itemName);
		decimal GetTotalPrice();


	}
}
