﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Wrox.ProCSharp.WPF
{
   public class BookFactory
   {
      private ObservableCollection<Book> books = new ObservableCollection<Book>();

      public BookFactory()
      {
         books.Add(new Book("Professional C# 2008", "Wrox Press",
               "978-0470191378", "Christian Nagel", "Bill Evjen",
               "Jay Glynn", "Karli Watson", "Morgan Skinner"));
         books.Add(new Book("Professional C# 2005 with .NET 3.0",
               "Wrox Press", "978-0-470-12472-7", "Christian Nagel",
               "Bill Evjen", "Jay Glynn", "Karli Watson", "Morgan Skinner"));
         books.Add(new Book("Professional C# 2005",
               "Wrox Press", "978-0-7645-7534-1", "Christian Nagel",
               "Bill Evjen", "Jay Glynn", "Karli Watson", "Morgan Skinner",
               "Allen Jones"));
         books.Add(new Book("Beginning Visual C#",
               "Wrox Press", "978-0-7645-4382-1", "Karli Watson",
               "David Espinosa", "Zach Greenvoss", "Jacob Hammer Pedersen",
               "Christian Nagel", "John D. Reid", "Matthew Reynolds",
               "Morgan Skinner", "Eric White"));
         books.Add(new Book("ASP.NET Professional Secrets",
               "Wiley", "978-0-7645-2628-2", "Bill Evjen",
               "Thiru Thangarathinam", "Bill Hatfield", "Doug Seven",
               "S. Srinivasa Sivakumar", "Dave Wanta", "Jason T. Roff"));
         books.Add(new Book("Design and Analysis of Distributed Algorithms",
               "Wiley", "978-0-471-71997-7", "Nicolo Santoro"));
      }

      public void AddBook(Book b)
      {
         books.Add(b);
      }


      public IEnumerable<Book> GetBooks()
      {
         return books;
      }
   }

}
