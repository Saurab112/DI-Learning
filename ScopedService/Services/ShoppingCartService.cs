using Microsoft.AspNetCore.Http.Features;
using ScopedService.ServiceContracts;

namespace ScopedService.Services
{
	public class ShoppingCartService : IShoppingCartService
	{
		private readonly ILogger<ShoppingCartService> _logger;
		private readonly List<string> _items = new List<string>();
		private readonly List<decimal> _prices = new List<decimal> { 1500, 1000 }; // Example item prices

		public ShoppingCartService(ILogger<ShoppingCartService> logger)
		{
			_logger = logger;
		}
		public void AddItem(string itemName, int quantity)
		{
			for (int i = 0; i < quantity; i++)
			{
				_items.Add(itemName);
			}
			_logger.LogInformation($"Added {quantity} of {itemName} to the cart.");
		}

		public void RemoveItem(string itemName)
		{
			_items.RemoveAll(item => item == itemName);
			_logger.LogInformation($"Removed {itemName} from the cart.");
		}

		public List<string> GetItems()
		{
			return _items;
		}

		public decimal GetTotalPrice()
		{
			// Assuming each item has the same price
			return _prices.Sum();
		}
	}
}
