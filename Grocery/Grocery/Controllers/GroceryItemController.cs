using Grocery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grocery.Controllers
{
    [Route("api/[controller]")]
    public class GroceryItemController : ControllerBase
    {
        private static List<GroceryItem> items = new List<GroceryItem> {
                new GroceryItem {Id =1, ItemName= "Tomatoe", Availability = true, ItemPrice = 1.4},
                 new GroceryItem {Id =2, ItemName= "Apple", Availability = true, ItemPrice = 2}
            };
        [HttpGet]
        public async Task<ActionResult<List<GroceryItem>>> GetAllGroceryItems()
        {          
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<GroceryItem>>> GetAllGroceryItemById(int id)
        {
            var item = items.Find(x => x.Id == id);
            if(item == null)
            {
                return BadRequest("Not found");
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<List<GroceryItem>>> AddGroceryItem([FromBody]GroceryItem groceryItem)
        {
           items.Add(groceryItem);
            return Ok(items);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<GroceryItem>>> UpdateGroceryItem(int id, [FromBody] GroceryItem requestGroceryItem)
        {
            var item = items.Find(x => x.Id == id);
            if (item == null)
            {
                return BadRequest("Not found");
            }
            item.ItemName = requestGroceryItem.ItemName;
            item.ItemPrice = requestGroceryItem.ItemPrice;
            item.Availability = requestGroceryItem.Availability;
            return Ok(items);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<GroceryItem>>> DeleteGroceryItem(int id)
        {
            var item = items.Find(x => x.Id == id);
            if (item == null)
            {
                return BadRequest("Not found");
            }
          items.Remove(item);
            return Ok(items);
        }
    }
}
