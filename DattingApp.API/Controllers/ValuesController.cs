using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DattingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebAPIOnly.Controllers
{
    
    [Route("api/[controller]")]
    // ControllerBase instead of Controller
    public class ValuesController : ControllerBase 
    {
        private readonly DataContext _context;  
        public ValuesController(DataContext context){
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);

        }
 
        // GET api/values/5
        [HttpGet("{id}")]
       public async Task<IActionResult> GetValue(int id)
        {
             var value = await _context.Values.FirstOrDefaultAsync(x=> x.Id == id);   
             return Ok(value);
        }
 
        // POST api/values
        [HttpPost]
        public IActionResult PostValues(int id)
        {
             var value = _context.Values.FirstOrDefault(x=> x.Id == id);   
             return Ok(value);
        }
 
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
 
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}