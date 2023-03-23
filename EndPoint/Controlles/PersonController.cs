using Microsoft.AspNetCore.Mvc;
using SimpleRestfulAPIWithAspNetCore.Models;
using SimpleRestfulAPIWithAspNetCore.Services;

namespace SimpleRestfulAPIWithAspNetCore.Controllers
{
    
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        
        private IPersonService _personService;

        
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personService.Create(person));
        }

        
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            return new ObjectResult(_personService.Update(person));
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}