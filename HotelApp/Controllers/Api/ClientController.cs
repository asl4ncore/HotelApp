using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApp.Models;
using HotelApp.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        HotelContext _db;
        public ClientController(HotelContext context)
        {
            this._db = context;
            if (!_db.Clients.Any())
            {
                _db.Clients.Add(new Client {IIN="980521300541",Name="Aray",Surname="Kaysar",Email="kaysar_a@gmail.com",Patronymic="Kaysarkuzu",PhoneNumber="87051252151" });
                _db.SaveChanges();
            }
        }
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _db.Clients.ToList();
        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Client client = _db.Clients.FirstOrDefault(x => x.Id == id);
            if (client == null)
                return NotFound();
            return new ObjectResult(client);
        }

        // POST: api/Client
        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            { return BadRequest(ModelState); }
            _db.Clients.Add(client);
            _db.SaveChanges();
            return Ok(client);
        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }
            if (!_db.Clients.Any(x => x.Id == client.Id))
            {
                return NotFound();
            }
            _db.Update(client);
            _db.SaveChanges();
            return Ok(client);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Client client = _db.Clients.FirstOrDefault(x => x.Id == id);
            if (client == null)
            {
                return NotFound();
            }
            _db.Clients.Remove(client);
            _db.SaveChanges();
            return Ok(client);
        }
    }
}
