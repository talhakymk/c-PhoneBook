namespace Phonebook;
using System;

class Menu{

    public static void WriteMenu(){
        Console.WriteLine(" *******************************************");
        Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");
        Console.WriteLine(" *******************************************");
        Console.WriteLine("(0) Programdan Çıkış");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");

    }

    public static int MakeChoice(){
        string? result = "";
        while(true){
            result = Console.ReadLine();
            if (result == null || result == ""){
                Console.WriteLine("Gecersiz giris");
                continue;
            }
            if(result.Length == 1 && result[0] - 48 >= 0 && result[0] - 48 < 6 )
                return int.Parse(result);
             Console.WriteLine("Gecersiz giris");
        }
    }
   
}