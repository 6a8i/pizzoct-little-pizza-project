using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models.Client;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIzza.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        /// <summary>
        /// Add a new client
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClient.Request request)
        {
            return Created(string.Empty, string.Empty);
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        // GET 
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        // GET 
        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            return Ok();
        }


        // PUT 
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}
