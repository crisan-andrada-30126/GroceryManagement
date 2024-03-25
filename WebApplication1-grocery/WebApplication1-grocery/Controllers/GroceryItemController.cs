using Grocery.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1_grocery.Interfaces;

namespace WebApplication1_grocery.Controllers
{
    [Route("api/[controller]")]
    public class GroceryItemController : ControllerBase
    {
        private readonly IGroceryItemService _groceryItemService;
        public GroceryItemController(
            IGroceryItemService groceryItemService)
        {
            _groceryItemService = groceryItemService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GroceryItem>>> GetAllGroceryItems()
        {
            return _groceryItemService.GetAllGroceryItems();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GroceryItem>> GetGroceryItemById(int id)
        {
            var result = _groceryItemService.GetGroceryItemById(id);
            if (result == null)
            {
                return BadRequest("Not found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<GroceryItem>>> AddGroceryItem([FromBody] GroceryItem groceryItem)
        {
            var result = _groceryItemService.AddGroceryItem(groceryItem);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<GroceryItem>>> UpdateGroceryItem(int id, [FromBody] GroceryItem requestGroceryItem)
        {

            var result = _groceryItemService.UpdateGroceryItem(id, requestGroceryItem);
            if (result is null)
            {
                return BadRequest("Not found");
            }
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<GroceryItem>>> DeleteGroceryItem(int id)
        {
            var result = _groceryItemService.DeleteGroceryItem(id);
            if (result is null)
            {
                return BadRequest("Not found");
            }
            return Ok(result);

        }
    }
}
