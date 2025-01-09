using Microsoft.AspNetCore.Http.Features;
using ScopedService.ServiceContracts;

namespace ScopedService.Services
{
	public class ShoppingCartService : IShoppingCartService
	{
		private readonly List<string> _items = new List<string>();
		public void AddItem(string itemName, int quantity)
		{
			_items.Add($"{itemName} ({quantity}pics)");
		}

		public List<string> GetItems()
		{
			return _items;
		}
	}
}
