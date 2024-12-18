using System;
using System.Collections.Generic;
using System.Linq;

namespace BookPhone
{
    class PhoneBook
    {
        private List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Console.Write("Podaj nazwę: ");
            string name = Console.ReadLine();
            Console.Write("Podaj numer telefonu: ");
            string phoneNumber = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(phoneNumber))
            {
                contacts.Add(new Contact(name, phoneNumber));
                Console.WriteLine("Kontakt został dodany.");
            }
            else
            {
                Console.WriteLine("Nazwa i numer telefonu nie mogą być puste.");
            }
        }

        public void DisplayContactByNumber()
        {
            Console.Write("Podaj numer telefonu: ");
            string phoneNumber = Console.ReadLine();

            var contact = contacts.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
            if (contact != null)
            {
                Console.WriteLine($"Nazwa: {contact.Name}, Numer: {contact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono kontaktu o podanym numerze.");
            }
        }

        public void DisplayAllContacts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("\nLista kontaktów:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Nazwa: {contact.Name}, Numer: {contact.PhoneNumber}");
                }
            }
            else
            {
                Console.WriteLine("Brak kontaktów w książce telefonicznej.");
            }
        }

        public void SearchContactsByName()
        {
            Console.Write("Podaj nazwę lub jej fragment: ");
            string nameFragment = Console.ReadLine()?.ToLower();

            var foundContacts = contacts.Where(c => c.Name.ToLower().Contains(nameFragment)).ToList();

            if (foundContacts.Any())
            {
                Console.WriteLine("Znalezione kontakty:");
                foreach (var contact in foundContacts)
                {
                    Console.WriteLine($"Nazwa: {contact.Name}, Numer: {contact.PhoneNumber}");
                }
            }
            else
            {
                Console.WriteLine("Nie znaleziono żadnych kontaktów dla podanej nazwy.");
            }
        }
    }
}
