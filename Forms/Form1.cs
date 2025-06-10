using Controller;
using Data;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            query8comboBox.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label5.Visible = false;
            query10comboBox.Visible = false;
            label6.Visible = false;
            query11comboBox.Visible = false;
            label7.Visible = false;
            query12comboBox.Visible = false;
            label9.Visible = false;
            textBox3.Visible = false;
            label8.Visible = false;
            textBox4.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            label12.Visible = false;
            label13.Visible = false;

        }
        BookshopController bookshopController = new BookshopController();

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "1":
                    var results1 = bookshopController.Query1();
                    listBoxResults.Items.AddRange(results1.ToArray());
                    break;
                case "2":
                    var results2 = bookshopController.Query2();
                    listBoxResults.Items.Add(results2.ToArray());
                    break;
                case "3":
                    var results3 = bookshopController.Query3();
                    listBoxResults.Items.Add(results3.ToArray());
                    break;
                case "4":
                    var results4 = bookshopController.Query4();
                    listBoxResults.Items.Add(results4.ToArray());
                    break;
                case "5":
                    var results5 = bookshopController.Query5();
                    listBoxResults.Items.Add(results5.ToArray());
                    break;
                case "6":
                    var results6 = bookshopController.Query6();
                    listBoxResults.Items.Add(results6.ToArray());
                    break;
                case "7":
                    var results7 = bookshopController.Query7();
                    listBoxResults.Items.Add(results7.ToArray());
                    break;
                case "8":
                    string status = query8comboBox.Text;
                    var results8 = bookshopController.Query8(status);
                    listBoxResults.Items.Add(results8.ToArray());
                    break;
                case "9":
                    double salary = double.Parse(textBox1.Text);
                    int years = int.Parse(textBox2.Text);
                    var results9 = bookshopController.Query9(salary, years);
                    listBoxResults.Items.Add(results9.ToArray());
                    break;
                case "10":
                    string publisherName = query10comboBox.Text;
                    var results10 = bookshopController.Query10(publisherName);
                    listBoxResults.Items.Add(results10.ToArray());
                    break;
                case "11":
                    string genre = query11comboBox.Text;
                    var results11 = bookshopController.Query11(genre);
                    listBoxResults.Items.Add(results11);
                    break;
                case "12":
                    string workerName = query12comboBox.Text;
                    var results12 = bookshopController.Query12(workerName);
                    listBoxResults.Items.Add(results12);
                    break;
                case "13":
                    int idUpdateBook = int.Parse(textBox3.Text);
                    double newPrice = double.Parse(textBox4.Text);
                    bookshopController.UpdateBookPrice(idUpdateBook,newPrice);
                    break;
                case "14":
                    int idUpdateAddress = int.Parse(textBox5.Text);
                    string newAddress = textBox6.Text;
                    bookshopController.UpdateOrderAddress(idUpdateAddress, newAddress);
                    break;
                case "15":
                    int idDeleteGenre = int.Parse(textBox7.Text);
                    bookshopController.DeleteGenre(idDeleteGenre);
                    break;

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "8")
            {
                label2.Visible = true;
                query8comboBox.Visible = true;
            }
            if (comboBox1.Text == "9")
            {
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;

                label2.Visible = false;
                query8comboBox.Visible = false;
            }
            if (comboBox1.Text == "10")
            {
                label5.Visible = true;
                query10comboBox.Visible = true;

                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                query8comboBox.Visible = false;
            }
            if (comboBox1.Text == "11")
            {
                label6.Visible = true;
                query11comboBox.Visible = true;

                label5.Visible = false;
                query10comboBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                query8comboBox.Visible = false;
            }
            if (comboBox1.Text == "12")
            {
                label7.Visible = true;
                query12comboBox.Visible = true;

                label6.Visible = false;
                query11comboBox.Visible = false;
                label5.Visible = false;
                query10comboBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                query8comboBox.Visible = false;
            }
            if (comboBox1.Text == "13")
            {
                label9.Visible = true;
                textBox3.Visible = true;
                label8.Visible = true;
                textBox4.Visible = true;

                label7.Visible = false;
                query12comboBox.Visible = false;
                label6.Visible = false;
                query11comboBox.Visible = false;
                label5.Visible = false;
                query10comboBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                query8comboBox.Visible = false;
            }
            if (comboBox1.Text == "14")
            {
                label10.Visible = true;
                label11.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;

                label9.Visible = false;
                textBox3.Visible = false;
                label8.Visible = false;
                textBox4.Visible = false;
                label7.Visible = false;
                query12comboBox.Visible = false;
                label6.Visible = false;
                query11comboBox.Visible = false;
                label5.Visible = false;
                query10comboBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                query8comboBox.Visible = false;
            }
            if(comboBox1.Text == "15")
            {
                textBox7.Visible = true;
                label12.Visible = true;

                label10.Visible = false;
                label11.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                label9.Visible = false;
                textBox3.Visible = false;
                label8.Visible = false;
                textBox4.Visible = false;
                label7.Visible = false;
                query12comboBox.Visible = false;
                label6.Visible = false;
                query11comboBox.Visible = false;
                label5.Visible = false;
                query10comboBox.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                query8comboBox.Visible = false;
            }
    }

    private void button2_Click(object sender, EventArgs e)
        {
            List<string> input = new List<string>();
            BookshopContext context = new BookshopContext();

            //if (!context.Publishers.Any())
            //{
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
            //}
            //if (!context.Statuses.Any())
            //{
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
            //}
            //if (!context.Workers.Any())
            //{
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
            //}
            //if (!context.Genres.Any())
            //{
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
            //}
            //if (!context.Orders.Any())
            //{
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
            //}
            //if (!context.Books.Any())
            //{
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
            //}
            //if (!context.Books_Genres.Any())
           // {
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
            //}
            //if (!context.Books_Orders.Any())
            //{
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
            //}
            button2.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

