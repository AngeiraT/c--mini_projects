using Microsoft.AspNetCore.Mvc;
using ContactApp.ViewModels;
using MongoDB.Driver;
using ContactApp.Models;



namespace ContactApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly MongoDBClient _mongoDBClient;

        public ContactController(MongoDBClient mongoDBClient)
        {
            _mongoDBClient = mongoDBClient;
        }

        public IActionResult Index()
        {
            var viewModel = new ContactViewModel();
            viewModel.Name = "Angeira Quiles"; // Set the value for the Name property

            return View(viewModel);
        }


        [HttpGet]
        public IActionResult GetContact(int contactId)
        {
            var contactViewModel = new ContactViewModel();

            // Fetch the contact details from MongoDB using the contactId
            var contact = _mongoDBClient.Contacts.Find(x => x.ContactID == contactId).FirstOrDefault();

            if (contact != null)
            {
                // Populate the contactViewModel with the fetched data
                contactViewModel.Name = contact.Name;
                contactViewModel.Phone = contact.Phone;
                contactViewModel.Fax = contact.Fax;
                contactViewModel.Email = contact.Email;
                contactViewModel.Notes = contact.Notes;
            }

            return View("Contact", contactViewModel);
        }


        [HttpPost]
        public IActionResult Save(ContactViewModel contact)
        {
            // Create a new instance of the Contact model
            var newContact = new Contact
            {
                Name = contact.Name,
                Phone = contact.Phone,
                Fax = contact.Fax,
                Email = contact.Email,
                Notes = contact.Notes
            };

        // Save the contact to the database
        // You can use the _mongoDbClient to access the MongoDB database and collection

            _mongoDBClient.Contacts.InsertOne(newContact);

            return RedirectToAction("Main");
        }
    }
}
