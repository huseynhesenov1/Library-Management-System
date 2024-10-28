using LibraryMenegmentSistyem.Interface;
using LibraryMenegmentSistyem.Models;

namespace LibraryMenegmentSistyem
{
    public class Program
    {
        static void Main(string[] args)
        {

            // indexer ucundu
            //LibraryCatalog.Books();





            LibrarianService librarianService = new LibrarianService();
            Console.WriteLine("Axtarmaq istediyiniz telebenin ID-sini daxil edin");
            int searchId = int.Parse(Console.ReadLine());
            Librarian librarianObj = librarianService.GetLibrarianById(searchId);
            Console.WriteLine($"Id:{librarianObj.Id} \nAdi:{librarianObj.Name}");










        }
    }
}