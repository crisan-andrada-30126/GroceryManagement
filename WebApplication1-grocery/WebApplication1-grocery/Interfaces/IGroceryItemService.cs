using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grocery.Models;

namespace WebApplication1_grocery.Interfaces
{
    public interface IGroceryItemService
    {
        List<GroceryItem> GetAllGroceryItems();
        GroceryItem? GetGroceryItemById(int id);
        List<GroceryItem> AddGroceryItem(GroceryItem requestGroceryItem);
        List<GroceryItem>? UpdateGroceryItem(int id, GroceryItem requestGroceryItem);
        List<GroceryItem>? DeleteGroceryItem(int id);
    }
}
