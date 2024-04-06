using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Text;

namespace CarProject
{
    internal class Program
    {
        public static CarManager carManager = new CarManager();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //IWebDriver webDriver = new ChromeDriver();
            bool value = true;

            while (value)
            {
                Console.WriteLine("Maşın əlavə etmək üçün 1");
                Console.WriteLine("Maşın silmək üçün 2");
                Console.WriteLine("İd-yə görə maşın görmək üçün 3");
                Console.WriteLine("Maşın brandlarına görə maşın görmək üçün 4");
                Console.WriteLine("Bütün maşınları görmək üçün 5");
                Console.WriteLine("Radio üçün 6");
                Console.WriteLine("Radio söndürmək üçün 7");
                Console.WriteLine("Siqnal vermək üçün 8");
                Console.WriteLine("Proqramı bitirmək üçün 9");

                byte firstChoice = Convert.ToByte(Console.ReadLine());

                if (firstChoice == 1)
                {
                    Console.WriteLine("Brand əlavə et");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Model əlavə et");
                    string model = Console.ReadLine();

                    Console.WriteLine("İl əlavə et");
                    int year = Convert.ToInt32(Console.ReadLine());

                    Car car = new()
                    {
                        Brand = brand,
                        Model = model,
                        Year = year
                    };
                    carManager.Add(car);
                    Console.Clear();
                }
                if (firstChoice == 2)
                {
                    ShowCarList();

                    Console.WriteLine("Silmək istədiyiniz id seçin");
                    byte id = Convert.ToByte(Console.ReadLine());
                    carManager.Delete(id);

                }
                if (firstChoice == 3)
                {
                    Console.Clear();
                    ShowCarList();
                    Console.WriteLine();
                    Console.WriteLine("Silmək istədiyiniz id seçin");
                    byte id = Convert.ToByte(Console.ReadLine());
                    var item = carManager.GetById(id);

                    Console.WriteLine($"Id:{item.Id} \n Brand:{item.Brand} \n Model:{item.Model} \n Year:{item.Year}");

                }
                if (firstChoice == 4)
                {
                    Console.Clear();
                    ShowCarList();

                    Console.WriteLine("Görmək istədiyiniz brand seçin");
                    string brand = Console.ReadLine();

                    var cars = carManager.GetAllCarBrand(brand);
                    ShowCarList(cars);
                }
                if (firstChoice == 5)
                {
                    Console.Clear();
                    ShowCarList();
                }
                if(firstChoice == 6)
                {
                    Console.WriteLine("Oxutmaq istədiyiniz linki daxil edin");
                    string link = Console.ReadLine();

                   // webDriver.Navigate().GoToUrl(link);
                    //Process.Start("cmd", $"/C start {link}");
                }
                if (firstChoice == 7)
                {
                    //webDriver.Quit();
                }
                if(firstChoice == 8){
                    Console.Beep(1000, 500);
                }
                if (firstChoice == 9)
                {
                    value = false;
                }
            }
        }

        static void ShowCarList(List<Car> carList)
        {
            foreach (var item in carList)
            {
                Console.WriteLine($"Id:{item.Id} \n Brand:{item.Brand} \n Model:{item.Model} \n Year:{item.Year}");
            }
        }
        static void ShowCarList()
        {
            var cars = carManager.GetAllCars();

            foreach (var item in cars)
            {
                Console.WriteLine($"Id:{item.Id} \n Brand:{item.Brand} \n Model:{item.Model} \n Year:{item.Year}");
            }
        }
    }
}
