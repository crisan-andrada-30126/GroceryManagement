using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grocery.Models;
using WebApplication1_grocery.Interfaces;

namespace Grocery.Services.GroceryItemsServices
{
    public class GroceryItemService: IGroceryItemService
    {
        private static List<GroceryItem> items = new List<GroceryItem> {
                new GroceryItem {Id =1, ItemName= "Tomatoe", Availability = true, ItemPrice = 1.4},
                 new GroceryItem {Id =2, ItemName= "Apple", Availability = true, ItemPrice = 2}
            };
        public List<GroceryItem> GetAllGroceryItems()
        {
            return items;
        }
        public GroceryItem GetGroceryItemById(int id)
        {
            var item = items.Find(x => x.Id == id);
            if (item == null)
            {
                return null;
            }
            return item;
        }
        public List<GroceryItem> AddGroceryItem(GroceryItem requestGroceryItem)
        {
            items.Add(requestGroceryItem);
            return items;
        }
        public List<GroceryItem> UpdateGroceryItem(int id, GroceryItem requestGroceryItem)
        {
            var item = items.Find(x => x.Id == id);
            if (item == null)
            {
                return null;
            }
            item.ItemName = requestGroceryItem.ItemName;
            item.ItemPrice = requestGroceryItem.ItemPrice;
            item.Availability = requestGroceryItem.Availability;

            return items;
        }
        public List<GroceryItem> DeleteGroceryItem(int id)
        {
            var item = items.Find(x => x.Id == id);
            if (item == null)
            {
                return null;
            }
            items.Remove(item);
            return items;
        }

        
}
}
