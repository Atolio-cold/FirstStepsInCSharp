using System;

namespace BookPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            int choice;
            do
            {
                Console.WriteLine("\n--- Książka Telefoniczna ---");
                Console.WriteLine("1. Dodaj kontakt");
                Console.WriteLine("2. Wyświetl kontakt na podstawie numeru");
                Console.WriteLine("3. Wyświetl wszystkie kontakty");
                Console.WriteLine("4. Wyszukaj kontakty dla danej nazwy");
                Console.WriteLine("0. Wyjdź z aplikacji");
                Console.Write("Wybierz opcję: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            phoneBook.AddContact();
                            break;
                        case 2:
                            phoneBook.DisplayContactByNumber();
                            break;
                        case 3:
                            phoneBook.DisplayAllContacts();
                            break;
                        case 4:
                            phoneBook.SearchContactsByName();
                            break;
                        case 0:
                            Console.WriteLine("Zamykanie aplikacji...");
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Podaj prawidłowy numer opcji.");
                }

            } while (choice != 0);
        }
    }
}
