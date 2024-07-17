using AngularApp1.Server.Data;
using AngularApp1.Server.Models;
using AngularApp1.Server.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ContactDbContext _contactDbContext;
        public ContactsController(ContactDbContext contactDbContext) 
        {
            this._contactDbContext = contactDbContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDTO>>> GetContacts()
        {
            var contacts = await _contactDbContext.ContactDetails
                .Select(c => new ContactDTO
                {
                    ContactID = c.ContactID,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Category = c.Category,
                    SubCategory = c.SubCategory,
                    PhoneNumber = c.PhoneNumber,
                    BirthDate = c.BirthDate
                })
                .ToListAsync();

            return contacts;
        }
        // get api/<valuescontroller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDTO>> GetContactById(int id)
        {
            var contact = await _contactDbContext.ContactDetails.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            var contactDto = new ContactDTO
            {
                ContactID = contact.ContactID,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,
                Category = contact.Category,
                SubCategory = contact.SubCategory,
                PhoneNumber = contact.PhoneNumber,
                BirthDate = contact.BirthDate
            };

            return contactDto;
        }

        [HttpPost]
        public async Task<ActionResult<ContactDTO>> PostContact(CreateContactRequestDto contactDto)
        {
            var contact = new ContactDetails
            {
                FirstName = contactDto.FirstName,
                LastName = contactDto.LastName,
                Email = contactDto.Email,
                Password = contactDto.Password,
                Category = contactDto.Category,
                SubCategory = contactDto.SubCategory,
                PhoneNumber = contactDto.PhoneNumber,
                BirthDate = contactDto.BirthDate
            };

            _contactDbContext.ContactDetails.Add(contact);
            await _contactDbContext.SaveChangesAsync();


            return CreatedAtAction(nameof(GetContactById), new { id = contact.ContactID }, contactDto);
        }

        // PUT: api/Contacts/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, ContactDTO contactDto)
        {
            var contact = _contactDbContext.ContactDetails.FirstOrDefault(x => x.ContactID == id);

            if(contact == null)
            {
                return NotFound();
            }

            contact.FirstName = contactDto.FirstName;
            contact.LastName = contactDto.LastName;
            contact.Email = contactDto.Email;   
            contact.Category = contactDto.Category;
            contact.SubCategory = contactDto.SubCategory;
            contact.PhoneNumber = contactDto.PhoneNumber;    
            contact.BirthDate = contactDto.BirthDate;

            await _contactDbContext.SaveChangesAsync();


            return NoContent();
        }

        // DELETE: api/Contacts/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _contactDbContext.ContactDetails.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            _contactDbContext.ContactDetails.Remove(contact);
            await _contactDbContext.SaveChangesAsync();

            return NoContent();
        }

        
    }
}
