using System;

namespace ContactApp.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty; // Add the missing get;set;
        public string Fax { get; set; } = string.Empty; // Add the missing get;set;
        public string Email { get; set; } = string.Empty; // Add the missing get;set;
        public string Notes { get; set; } = string.Empty; // Add the missing get;set;
        public DateTime LastUpdateDate { get; set; } 
        public string LastUpdateUserName { get; set; } = string.Empty; // Add the missing get;set;
    }
}