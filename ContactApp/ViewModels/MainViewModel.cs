using System.Collections.Generic;

namespace ContactApp.ViewModels
{
    public class MainViewModel
    {
        public string Username { get; set; } = string.Empty;
        public List<ContactViewModel> Contacts { get; set; } = new List<ContactViewModel>();
    }

    public class ContactViewModel
    {
    public int ContactID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Fax { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
    public DateTime LastUpdateDate { get; set; }
    public string LastUpdateUserName { get; set; } = string.Empty;

    }
}
