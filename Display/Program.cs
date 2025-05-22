using Data;
using Controller;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

List<string> input = new List<string>(); 
BookshopContext context = new BookshopContext();


if (!context.Publishers.Any())
{
    using (StreamReader reader = new StreamReader("PublisherInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(' ').ToList();
            string name = input[0];
            int rating = int.Parse(input[1]);
            Publisher publisher = new Publisher() { Name = name, Rating = rating };
            context.Publishers.Add(publisher);
        }
        context.SaveChanges();
    }
}
if (!context.Statuses.Any())
{
    using (StreamReader reader = new StreamReader("StatusInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(' ').ToList();
            string statusname = input[0];
            int bookcount = int.Parse(input[1]);
            Status status = new Status() { StatusName = statusname, BookCount = bookcount };
            context.Statuses.Add(status);
        }
        context.SaveChanges();
    }
}
if (!context.Workers.Any())
{
    using (StreamReader reader = new StreamReader("WorkerInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(", ").ToList();
            string fullname = input[0];
            double salary = double.Parse(input[1]);
            int experience = int.Parse(input[2]);
            Worker worker = new Worker() { FullName = fullname, Salary = salary, WorkExperience = experience };
            context.Workers.Add(worker);
        }
        context.SaveChanges();
    }
}
if (!context.Genres.Any())
{
    using (StreamReader reader = new StreamReader("GenreInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(' ').ToList();
            string name = input[0];
            Genre genre = new Genre() { GenreName = name };
            context.Genres.Add(genre);
            //  await context.SaveChangesAsync();
        }
        context.SaveChanges();
    }
}
if (!context.Orders.Any())
{
    using (StreamReader reader = new StreamReader("OrderInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(", ").ToList();
            DateTime dateplaced = DateTime.Parse(input[0]);
            string trackingnum = input[1];
            string address = input[2];
            Order order = new Order() { Date = dateplaced, TrackingNumber = trackingnum, Address = address };
            context.Orders.Add(order);
        }
        context.SaveChanges();
    }
}
if (!context.Books.Any())
{
    using (StreamReader reader = new StreamReader("BookInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(", ").ToList();
            string title = input[0];
            string author = input[1];
            double price = double.Parse(input[2]);
            int publisher = int.Parse(input[3]);
            int status = int.Parse(input[4]);
            Book book = new Book() { Title = title, Author = author, Price = price, PublisherId = publisher, StatusId = status };
        }
        context.SaveChanges();
    }
}
if (!context.Books_Genres.Any())
{
    using (StreamReader reader = new StreamReader("BookGenreInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(' ').ToList();
            int book = int.Parse(input[0]);
            int genre = int.Parse(input[1]);
            Book_Genre bookgenre = new Book_Genre() { IdBook = book, IdGenre = genre };
        }
        context.SaveChanges();
    }
}
if (!context.Books_Orders.Any())
{
    using (StreamReader reader = new StreamReader("BookOrderInsert.txt", System.Text.Encoding.UTF8))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            input = line.Split(' ').ToList();
            int book = int.Parse(input[0]);
            int order = int.Parse(input[1]);
            int worker = int.Parse(input[2]);
            int num = int.Parse(input[3]);
            Book_Order bookorder = new Book_Order() { IdBook = book, IdOrder = order, IdWorker = worker, NumberOfBooks = num };
        }
        context.SaveChanges();
    }
}


static void MenuForQueries()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;

    Console.WriteLine("1.Изведи заглавията на книгите и имената на жанровете им.");
    Console.WriteLine("2.Изведи заглавието и автора на книгите, по-скъпи от 25 лева и ги подреди в азбучен ред.");
    Console.WriteLine("3.Изведи заглавието, автора и статуса на книгите и номерата на поръчките с над 1 книга.");
    Console.WriteLine("4.Изведи заглавието, автора и статуса на книгите, със статус 'in preorder'.");
    Console.WriteLine("5.Изведи заглавието, автора и издателя на книгите с издател с рейтинг 5 звезди.");
    Console.WriteLine("6.Изведи заглавието на книгата и датата на първата поръчка, в която е участвала.");
    Console.WriteLine("7.Изведи номера и адреса на поръчките, както и заглавието и автора на книгите, групирани по цена.");
    Console.WriteLine("8.При въведен статус на книга изведи заглавието, автора и цената на книгите с този статус.");
    Console.WriteLine("9.При въведени заплата и години опит изведи имената на работниците с по-голяма заплата от въведената, но с по-малко години опит от въведените.");
    Console.WriteLine("10.При въведено име на издател изведи заглавието и цената на всички книги на този издател.");
    Console.WriteLine("11.При въвеждане на жанр да се изведе брoят на книгите с този жанр.");
    Console.WriteLine("12.При въвеждане на име на работник да се изведат номерата на всички поръчки, които е направил.");
    Console.WriteLine("13.Смяна на цената на книга.");
    Console.WriteLine("14.Смяна на адреса на поръчка.");
    Console.WriteLine("15.Изтриване на жанр.");
    Console.WriteLine();
    Console.WriteLine("16. Добавяне на книга. ");
    Console.WriteLine("17. Добавяне на издателство. ");
    Console.WriteLine("18. Добавяне на жанр. ");
    Console.WriteLine("19. Добавяне на работник. ");
    Console.WriteLine("20. Добавяне на поръчка. ");
    Console.WriteLine("Изберете команда: ");
}

BookshopController controller = new BookshopController();
MenuForQueries();

int choice = int.Parse(Console.ReadLine());
while(choice >= 0)
{
    switch(choice)
    {
        case 1:
            var result1 = controller.Query1();
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 2:
            var result2 = controller.Query2();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 3:
            var result3 = controller.Query3();
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 4:
            var result4 = controller.Query4();
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 5:
            var result5 = controller.Query5();
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 6:
            var result6 = controller.Query6();
            foreach (var item in result6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 7:
            var result7 = controller.Query7();
            foreach (var item in result7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 8:
            Console.WriteLine("Моля въведете статус: ");
            string status = Console.ReadLine();
            var result8 = controller.Query8(status);
            foreach (var item in result8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 9:
            Console.WriteLine("Моля въведете заплата (сума): ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter experience years: ");
            int exp = int.Parse(Console.ReadLine());
            var result9 = controller.Query9(salary, exp);
            foreach (var item in result9)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 10:
            Console.WriteLine("Моля въведете име на издателство: ");
            string name = Console.ReadLine();
            var result10 = controller.Query10(name);
            foreach (var item in result10)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 11:
            Console.WriteLine("Моля въведете жанр: ");
            string genre = Console.ReadLine();
            int result11 = controller.Query11(genre);
            Console.WriteLine(result11);
            Console.WriteLine();
            MenuForQueries();
            break;
        case 12:
            Console.WriteLine("Моля въведете име на работник: ");
            string workername = Console.ReadLine();
            var result12 = controller.Query12(workername);
            foreach (var item in result12)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            MenuForQueries();
            break;
        case 13:
            Console.WriteLine("Моля въведете id на книгата, която искате да промените: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете новата цена: ");
            double price = double.Parse(Console.ReadLine());
            controller.UpdateBookPrice(id, price);
            Console.WriteLine();
            MenuForQueries();
            break;
        case 14:
            Console.WriteLine("Моля въведете id на поръчката, която искате да промените: ");
            int idOrder = int.Parse(Console.ReadLine());
            Console.WriteLine("Моля въведете новия адрес: : ");
            string address = Console.ReadLine();
            controller.UpdateOrderAddress(idOrder, address);
            Console.WriteLine();
            MenuForQueries();
            break;
        case 15:
            Console.WriteLine("Моля въвдете id на жанра, който искате да изтриете: ");
            int idWorker = int.Parse(Console.ReadLine());
            controller.DeleteGenre(idWorker);
            Console.WriteLine();
            MenuForQueries();
            break;
        case 16:
            Console.WriteLine("Заглавие на книгата: ");
            string title = Console.ReadLine();
            Console.WriteLine("Година на издаване: ");
            string author = Console.ReadLine();
            Console.WriteLine("Цена: ");
            double price2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ID на издателство: ");
            int pubId = int.Parse(Console.ReadLine());
            Console.WriteLine("ID на статус: ");
            int statusId = int.Parse(Console.ReadLine());
            controller.AddBook(title, author, price2, pubId, statusId);
            Console.WriteLine("Книгата е добавена.");
            MenuForQueries();
            break;
        case 17:
            Console.WriteLine("Име на издателство: ");
            string pubName = Console.ReadLine();
            Console.WriteLine("Рейтинг: ");
            int rating = int.Parse(Console.ReadLine());
            controller.AddPublisher(pubName, rating);
            Console.WriteLine("Издателството е добавено.");
            MenuForQueries();
            break;
        case 18:
            Console.WriteLine("Име на жанр: ");
            string genreName = Console.ReadLine();
            controller.AddGenre(genreName);
            Console.WriteLine("Жанрът е добавен.");
            MenuForQueries();
            break;
        case 19:
            Console.WriteLine("Име на работник: ");
            string workerName = Console.ReadLine();
            Console.WriteLine("Заплата: ");
            double salary2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Опит (години): ");
            int exp2 = int.Parse(Console.ReadLine());
            controller.AddWorker(workerName, salary2, exp2);
            Console.WriteLine("Работникът е добавен.");
            MenuForQueries();
            break;
        case 20:
            Console.WriteLine("Дата на поръчка (mm.dd.yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Номер за проследяване: ");
            string num = Console.ReadLine();
            Console.WriteLine("Адрес за доставка: ");
            string address2 = Console.ReadLine();
            controller.AddOrder(date, num, address2);
            Console.WriteLine("Поръчката е добавена.");
            MenuForQueries();
            break;
        default: Console.WriteLine("Несъществуваща команда."); MenuForQueries(); break;
    }
    choice = int.Parse(Console.ReadLine());
}

