using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace ReadData {
  class Program {
    static void Main(string[] args) {
      using(var db = new AppSellingBooksContext()){

        // @@@ DELETE author by ID
        // var author = db.Author.Single(x => x.AuthorId == 6);
        // if(author != null) {
        //   db.Remove(author);
        //   var transactionResult = db.SaveChanges();
        //   Console.WriteLine($"The transaction result: {transactionResult}");
        // }

        // @@@ UPDATE author by ID
        // var author = db.Author.Single(x => x.Name == "Naranjosidad");
        // if(author != null){
        //   author.Surname = "Chibi";
        //   author.Grade = "Lic";
        //   var transactionResult = db.SaveChanges();
        //   Console.WriteLine($"The transaction result: {transactionResult}");
        // }

        // @@@ CREATE a new author with transaction
        // Author newAuthor = new Author{
        //   Name = "Konnie",
        //   Surname = "Ko",
        //   Grade = "Master"
        // };
        // db.Add(newAuthor);
        // var transactionResult = db.SaveChanges();
        // Console.WriteLine($"Transact state => {transactionResult}");

        // @@@@LIST BOOKS  
        // var books = db.Book.AsNoTracking(); // IQueryable
        // foreach(var book in books){
        //   Console.WriteLine(book.Title + " --- " + book.Description);
        // }


        
        // @@@ LIST BOOKS WITH PRICE (1 to 1)
        // var books = db.Book.Include(x => x.PriceSale).AsNoTracking();
        // foreach (var book in books){
        //   Console.WriteLine($"{book.Title} - ${book.PriceSale!.CurrentPrice}");
        // }


        // @@@ LIST BOOKS WITH COMMENTS (1 to Many)
        // var books = db.Book.Include(x => x.Comments).AsNoTracking();
        // foreach (var book in books){
        //   Console.WriteLine($"{book.Title}");
        //   foreach(var comment in book.Comments!){
        //     Console.WriteLine($" ---- {comment.CommentText}");
        //   }
        // }

        // @@@ GETTING ALL THE BOOKS AND ITS AUTHORS (Many to Many)
        var books = db.Book.Include(x => x.AuthorLink).ThenInclude(xi => xi.Author).AsNoTracking();
        foreach(var book in books){
          Console.WriteLine($"{book.Title} ----");
          foreach(var authorLink in book.AuthorLink){
            Console.WriteLine($"- {authorLink.Author!.Name}");
          }
        }


      }
    }
  }
}