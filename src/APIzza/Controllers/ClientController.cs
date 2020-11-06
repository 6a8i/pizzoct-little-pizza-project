using System;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Entities;
using API.Models.Client;
using Microsoft.AspNetCore.Mvc;

namespace APIzza.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly DBContext _db;
        public ClientController(DBContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Add a new client
        /// </summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CreateClient.Request request)
        {
            Client entity = request;

            if (!(entity is null))
            {
                _db.Client.Add(entity);
                await _db.SaveChangesAsync();
            }

            return Created(string.Empty, entity.Id.ToString());
        }

        /// <summary>
        /// Gets all the clients 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            SearchClient.Response response = new SearchClient.Response();
            response.Clients = _db.Client.ToList().Select<Client, SearchClient.Client>(e => e).ToList();
            return Ok(response);
        }

        /// <summary>
        /// Gets a client by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            SearchClient.Response response = new SearchClient.Response();
            response.Clients = _db.Client.Where(e => e.Id == id).ToList().Select<Client, SearchClient.Client>(e => e).ToList();
            return Ok(response);
        }

        /// <summary>
        /// Gets a client by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            SearchClient.Response response = new SearchClient.Response();
            response.Clients = _db.Client.Where(e => e.Name == name).ToList().Select<Client, SearchClient.Client>(e => e).ToList();
            return Ok(response);
        }


        /// <summary>
        /// Updates the client`s data
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateClient.Request request)
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
