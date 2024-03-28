using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOP.Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> list = new List<string>();
            //list.Add();
            //list.Find();


            #region Nezeri


            //OOP 4 xüsusiyyət
            //Abstraction
            //Inheritance
            //Polymorphism
            //Encapsulation

            //MyClass codelandia = new MyClass();
            //MyClass codelandia1 = new MyClass();
            //MyClass codelandia2 = new MyClass();
            //MyClass codelandia3 = new MyClass();

            //Person person = new Person();
            //person.Age = 10;
            //Console.WriteLine(person.Age);

            //Pocket pocket = new Pocket();
            //pocket.Money = 200;

            //Console.WriteLine(pocket.Money);

            //Person person = new Person()
            //{
            //    Profession = "x",
            //    Num = 1
            //};

            //person.Num = 2;

            ////person.Num = 1;
            //Console.WriteLine(person.Profession);

            //List<Person> list = new List<Person>();
            //list.Where(x => x.Age == 24).ToList();
            #endregion

            #region Praktiki
            /*
             1.Book adlı class yarat propertyleri 
             Name,Author,PageSize,IsStock,Price

            2. Library adlı class yarat
             Kitab Əlavə etmək metodu
             Kitab list Göstərmək metodu
             Kitab Silmək metodu

            İstifadəçidən əməliyyat üçün rəqəm istə
            1=> Kitab listini göstər
            2=> Kitab əlavə et
            3=> kitab Name=yə görə kitabı sil
            4=> Proqramı sonlandır
            
                        
             */
            Library library = new Library();
            bool value = true;

            while (value)
            {
                Console.WriteLine(" 1 2 3 4 Seç");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        var myBookList =library.GetAllBooks();
                        int count = 1;
                        foreach (var item in myBookList)
                        {
                            Console.Write($"Say:{count}. {item.Name} {item.Author} {item.Price} {item.IsStock} {item.PageSize} ");
                            Console.WriteLine();
                            count++;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Kitab adı daxil edin");
                        string bookName = Console.ReadLine();

                        Console.WriteLine("Yazıçı adı daxil edin");
                        string authorName = Console.ReadLine();

                        Console.WriteLine("Səhifə sayı daxil edin");
                        int pageSize = int.Parse(Console.ReadLine());

                        Console.WriteLine("Stokda olub olmadığını daxil edin");
                        bool isStock = Convert.ToBoolean(Console.ReadLine());

                        Console.WriteLine("Qiymət daxil edin");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Book book = new Book()
                        {
                            Name = bookName,
                            Author = authorName,
                            PageSize = pageSize,
                            IsStock = isStock,
                            Price = price
                        };

                        library.AddBook(book);
                        break;

                        case 3:
                        Console.WriteLine("Kitab Adını daxil edin");
                        string name = Console.ReadLine();
                        library.DeleteBook(name);
                        break;
                    case 4:
                        value = false;
                        break;

                    default:
                        Console.WriteLine(" 1 2 3 4 Seç");
                        break;
                }
            }

            #endregion

        }
    }

    #region nezeri


    //class Person
    //{
    //    private string name;
    //    //public string Name => name;

    //    //public string Name
    //    //{
    //    //    get
    //    //    {
    //    //        return name;
    //    //    }
    //    //}
    //    public string Name { get; set; }

    //    public int Age { get; set; }
    //    public required string Profession { get; init; }

    //    public int Num { get; init; }
    //}


    //public class Pocket
    //{
    //   // public double Money { get; set; } 

    //    //private double money;
    //    //public double Money
    //    //{
    //    //    get
    //    //    {
    //    //        return money / 2;
    //    //    }
    //    //    set
    //    //    {
    //    //        money = value * 5;
    //    //    }
    //    //}

    //    //public double get_Money()
    //    //{
    //    //    return Money;
    //    //}

    //    //public void set_Money(double value)
    //    //{
    //    //    money = value;
    //    //}
    //}

    //public class Person
    //{
    //    private int age;
    //    public int Age
    //    {
    //        get
    //        {
    //            return age;
    //        }
    //        set
    //        {
    //            age = value;
    //        }
    //    }
    //}
    #endregion

    #region Praktiki
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageSize { get; set; }
        public double Price { get; set; }
        public bool IsStock { get; set; }
    }

    class Library
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public void DeleteBook(string name)
        {
            var foundedBook = books.Find(x => x.Name == name);

            books.Remove(foundedBook);
        }
    }
    #endregion
}
