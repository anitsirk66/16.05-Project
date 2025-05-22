using Data;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Controller
{
    public class BookshopController
    {
        BookshopContext context;
        public BookshopController()
        {
            context = new BookshopContext();
        }

        public List<string> Query1()  //2 таблици
        {
            return context.Books_Genres
            .Include(bg => bg.Book)
            .Include(bg => bg.Genre)
            .Select(bg=>bg.Book.Title + bg.Genre.GenreName)
            .ToList();
        }
        public List<string> Query2() //1 таблица
        {
           return context.Books
                .Where(b=>b.Price > 25.00)
                .OrderBy(b=>b.Title)
                .Select(b=> b.Title + b.Author)
                .ToList();
        }
        public List<string> Query3() // 3+ таблици
        {
             return context.Books_Orders
                .Include(b=>b.Book)
                .ThenInclude(b=>b.Status)
                .Include(b=>b.Order)
                .Where(bo=>bo.NumberOfBooks > 1)
                .Select(bo=>bo.Book.Title + bo.Book.Author + bo.Book.Status.StatusName + bo.Order.TrackingNumber)
                .ToList();
        }
        public List<string> Query4() // 2 таблици
        {
             return context.Books
                .Include(b=>b.Status)
                .Where(s=>s.Status.StatusName == "in-preorder")
                .Select(b=>b.Title + b.Author + b.Status.StatusName)
                .ToList();
        }
        public List<string> Query5() // 2 таблици
        {
            return context.Books
                .Include(b => b.Publisher)
                .Where(b => b.Publisher.Rating == 5)
                .Select(b => b.Title + b.Author + b.Publisher.Name)
                .ToList();
        }
        public List<string> Query6() // 2 таблици
        {
            return context.Books_Orders
             .Include(bo => bo.Book)
             .Include(bo => bo.Order)
             .GroupBy(a=> a.Book.Title)
             .Select(g => $"First ordered on: {g.Min(bo => bo.Order.Date)}")
             .ToList();
        }
        public List<string> Query7() // 3+ таблици
        {
            return context.Books_Orders
                .Include(o => o.Book)
                .Include(bo => bo.Order)
                .OrderBy(bo => bo.Book.Price)
                .Select(bo => bo.Book.Title + bo.Book.Author + bo.Order.Address + bo.Order.TrackingNumber) 
                .ToList();
        }
        public List<string> Query8(string status) //стандартен вход 1
        {
            return context.Books
                .Include(b=>b.Status)
                .Where(b=>b.Status.StatusName == status)
                .Select(b=>b.Title + b.Author + b.Price)
                .ToList();
        }
        public List<string> Query9(double salary, int expYears) //стандратен вход 2
        {
            return context.Workers
                .Where(w => w.Salary > salary && w.WorkExperience < expYears)
                .Select(w => w.FullName)
                .ToList();
        }
        public List<string> Query10(string publisherName) //стандартен вход 3
        {
            return context.Books
                .Include(b => b.Publisher)
                .Where(b=>b.Publisher.Name == publisherName)
                .Select(b=>b.Title + b.Price)
                .ToList();
        }
        public int Query11(string genre)  //стандартен вход 4
        {
            var list = context.Books_Genres
               .Include(bg => bg.Genre)
               .Where(bg => bg.Genre.GenreName == genre)
               .Select(bg => bg.IdBook)
               .Count();
            return list;
        }
        public List<string> Query12(string workername) //стандартен вход 5
        {
            return context.Books_Orders
               .Include(bo => bo.Worker)
               .Include(bo => bo.Order)
               .Where(bo => bo.Worker.FullName == workername)
               .Select(bo => bo.Order.TrackingNumber)
               .Distinct()
               .ToList();
        }

        public void UpdateBookPrice(int id, double newprice)
        {
            Book book = context.Books.FirstOrDefault(b => b.IdBook == id);
            if (book != null)
            {
                book.Price = newprice;
                context.SaveChanges();
            }
            else { throw new ArgumentException(); }
        }
        public void UpdateOrderAddress(int id, string newaddress)
        {
            Order order = context.Orders.FirstOrDefault(o => o.OrderId == id);
            if (order != null)
            {
                order.Address = newaddress;
                context.SaveChanges();
            }
            else { throw new ArgumentException(); }
        }
        public void DeleteGenre(int id)
        {
            Book_Genre genreToDelete = context.Books_Genres.FirstOrDefault(g => g.IdGenre == id);
            if (genreToDelete != null)
            {
                context.Books_Genres.Remove(genreToDelete);
                context.SaveChanges();
            }
            else { throw new ArgumentException(); }
        }

        public void AddBook(string title, string author, double price, int publisherId, int statusid)
        {
            var book = new Book
            {
                Title = title,
                Author = author,
                Price = price,
                PublisherId = publisherId,
                StatusId = statusid
            };
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void AddPublisher(string name, int rating)
        {
            var publisher = new Publisher { Name = name, Rating = rating };
            context.Publishers.Add(publisher);
            context.SaveChanges();
        }

        public void AddGenre(string name)
        {
            var genre = new Genre { GenreName = name };
            context.Genres.Add(genre);
            context.SaveChanges();
        }

        public void AddWorker(string name, double salary, int experience)
        {
            var worker = new Worker
            {
                FullName = name,
                Salary = salary,
                WorkExperience = experience
            };
            context.Workers.Add(worker);
            context.SaveChanges();
        }

        public void AddOrder(DateTime date,string number, string address)
        {
            var order = new Order
            {
                Date = date,
                TrackingNumber = number,
                Address = address
            };
            context.Orders.Add(order);
            context.SaveChanges();
        }

    }
}
