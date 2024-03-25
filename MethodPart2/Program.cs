using System.Collections;

namespace MethodPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mail adresini ayırıb ekrana yazdırmaq
            //Mən info@codelandia.edu.az adresindən mail aldım
            // Cümləsindən mail adresini ayırıb ekrana yazdırmaq.
            //string text = Console.ReadLine();
            //string[] words = text.Split(' ');
            //foreach (var item in words)
            //{
            //    /*
            //     for (int i = 0; i < item.Length; i++) 
            //     {
            //         if (item[i] == '@')
            //         {
            //             Console.WriteLine(item);
            //         }
            //     }*/

            //    if (item.Contains("@"))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion Mail adresini ayırıb ekrana yazdırmaq

            #region verilmiş sözün bütün hərflərini böyüdün. 
            //verilmiş sözün ToUpper metodu istifadə etmədən
            //bütün hərflərini böyüdün. 
            #region version 1
            /*char[] lowerCase = { 'a', 'b', 'c' };
            char[] upperCase = { 'A', 'B', 'C' };

            string text = "abC";
            string newText = "";
            bool isRepeat = false;
            foreach (var simvol in text)
            {
                for (int i = 0; i < lowerCase.Length; i++)
                {
                    if (lowerCase[i] == simvol)
                    {
                        newText += upperCase[i];
                        isRepeat = true;
                        break;
                    }

                }
                if (!isRepeat)
                {
                    newText += simvol;
                }
                isRepeat = false;
            }
            Console.WriteLine(newText);*/
            #endregion version 1

            #region version 2
            //string text = Console.ReadLine();
            //string newText = "";
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] >= 'a' && text[i] <= 'z')
            //    {
            //        newText += (char)(text[i] - 32);
            //    }
            //    else
            //    {
            //        newText += text[i];
            //    }
            //}
            //Console.WriteLine(newText);
            #endregion version 2

            #endregion verilmiş sözün  bütün hərflərini böyüdün. 

            #region Verilmiş massivdən təkrarlanan elementləri silin.  
            //Verilmiş massivdən təkrarlanan elementləri silin.  
            //int[] arr = { 1, 2, 3, 5, 6, 8, 3, 99, 45, 22, 1, 108, 99 };
            //ArrayList newArr = new ArrayList();
            //bool isRepeat = false;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //start loop
            //    foreach (int item in newArr)
            //    {
            //        if (arr[i] == item)
            //        {
            //            isRepeat = true;
            //            break;
            //        }
            //    }
            //    if (!isRepeat)
            //    {
            //        newArr.Add(arr[i]);
            //    }
            //    isRepeat = false;

            //    //end loop
            //}

            //foreach (var item in newArr)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion Verilmiş massivdən təkrarlanan elementləri silin.  

            #region Login and password
            // Statik olaraq username və parol saxlayın.
            // Və istifadəçidən bir username parol istəyin
            // əgər username və parol eyni olarsa "Sistemə girişiniz uğurludur" yazılsın.
            // Əgər 3 dəfə yanlış cəhd edərsə "Sistemə girişiniz bloklandı" yazılsın.
            string dataLogin = "admin";
            string dataPassword = "admin123";
            string login, password;
            int count = 3;

            while (count > 0)
            {
                count--;
                Console.Write("Login: ");
                login = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (login == dataLogin && password == dataPassword)
                {
                    Console.WriteLine("Success!");
                    break;
                }
                else
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Blocked!");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("{0} cəhdiniz qaldı!",count);
                }
            }
            
            #endregion Login and password
        }
    }
}
