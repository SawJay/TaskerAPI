using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskerAPI.Models;

namespace TaskerAPI.Controllers
{
    [Route("api/[controller]")] // /api/taskeritems
    [ApiController]
    public class TaskerItemsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<TaskerItem> GetTaskerItem() 
        {
            TaskerItem item = new TaskerItem(); 

            item.Id = Guid.NewGuid();
            item.Name = "Take a nap";
            item.IsComplete = false;

            return Ok(item);
        }
    }
}
