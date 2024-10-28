using LibraryMenegmentSistyem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenegmentSistyem.Models;

public class LibrarianService : ILibrarianService
{
    private Librarian[] _librarians;
    public LibrarianService(Librarian[] librarians)
    {
        _librarians = librarians;
    }
    public void CreateLibrarian(Librarian librarian)
    {
         Librarian librarian1 = new Librarian()
        {
            Id = 1,
            Name = "Elekber",
        };
        Librarian librarian2 = new Librarian()
        {
            Id = 2,
            Name = "Murad",
        };
        Librarian librarian3 = new Librarian()
        {
            Id = 3,
            Name = "Zamin",
        };
        Librarian librarian4 = new Librarian()
        {
            Id = 4,
            Name = "Ruslan",
        };

        Librarian[] librarians = { librarian1, librarian2, librarian3, librarian4 };
    }

    public void DeleteLibrarian(Librarian librarian, bool IsSoftDelete)
    {
    }

    public Librarian GetAllLibrarians()
    {
        for (int i = 0; i < _librarians.Length; i++)
        {
            return _librarians[i];
        }
        return default;

    }

    public Librarian GetLibrarianById(int id)
    {
        for (int i = 0; i < _librarians.Length; i++)
        {
            if (_librarians[i].Id == id)
            {
                return _librarians[i];
            }
        }
        return default;
    }

    
}
