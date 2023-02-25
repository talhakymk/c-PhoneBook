namespace Phonebook;
using System;
using System.Collections;

class App {
     private List<Book> records = new List<Book>();

public void Run(){
    DefaultList def = new DefaultList();
    this.records.AddRange(def.Defaultlist);
    int choice = -1;
    do{
        Menu.WriteMenu();
        choice = Menu.MakeChoice();
        ReflectionOfYourChoice(choice);
    }while(choice != 0);
}


    public void AddToBook(){  // rehbere kişiyi bu fonksiyonda kaydediyoruz
    Console.Write(" Lütfen isim giriniz\t\t:");
    string name = TakeInput();
    Console.Write(" Lütfen soyisim giriniz\t\t:");
    string surname = TakeInput();
    Console.Write(" Lütfen telefon numarası giriniz:");
    string number = TakeInput();
    records.Add(new Book(name ,surname ,number) );

}

    public void DeleteFromBook(){ // rehberden kişi silmek için bu fonksiyonu kullanıyoruz
        string? DeleteName = "";
    while(true){
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        DeleteName = TakeInput();
        foreach (Book item in records)
        {
            if(DeleteName == item.Name || DeleteName == item.Surname){
                records.Remove(item);
                Console.WriteLine("İstediğiniz numara silindi ");
                return;
            }
        }
        
            string? ask = "";
            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için      : (2)");
            while(true){
                ask = TakeInput();
                if(ask != "1" && ask != "2"){
                    Console.WriteLine("Lutfen 1 veya 2 giriniz");
                    continue;
                }
                break;
            }
            switch(ask){
                case "1":
                    return;
                case "2":
                    break;
        }
    }

    }

public void ChangeNumber(){ // rehber güncellemesi
    string? ChangedNumber = "";
         while(true){
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        ChangedNumber = TakeInput();
        foreach (Book item in records)
        {
            if(ChangedNumber == item.Name || ChangedNumber == item.Surname){
                 Console.WriteLine(" Lütfen yeni isimi giriniz\t\t:");
                item.Name = TakeInput();
                Console.WriteLine(" Lütfen yeni soyisimi giriniz\t\t:");
                item.Surname = TakeInput();
                Console.WriteLine(" Lütfen yeni telefon numarasını giriniz:");
                item.Number = TakeInput();
                Console.WriteLine("İstediğiniz numara Güncellendi ");
                return;
            }
        }
        
            string? ask = "";
            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için      : (2)");
            while(true){
                ask = TakeInput();
                if(ask != "1" && ask != "2"){
                    Console.WriteLine("Lutfen 1 veya 2 giriniz");
                    continue;
                }
                break;
            }
            switch(ask){
                case "1":
                    return;
                case "2":
                    break;
        }
    }

}

public void WriteAllBook(){ // tüm rehberi yazma
    Console.WriteLine("Telefon Rehberi");
    Console.WriteLine("**********************************************");
        foreach (var item in records)
        {
            Console.WriteLine("isim : " + item.Name);
            Console.WriteLine("Soyisim : " + item.Surname);
            Console.WriteLine("Numara : " + item.Number);
            Console.WriteLine("-");
        }
}

public void SearchInBook(){ // aratılan şeye göre rehberi yazma
    string? ask = "";
    string? searchName = "";
    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
    Console.WriteLine("**********************************************");
    Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
    Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
    while(true){
                ask = TakeInput();
                if(ask != "1" && ask != "2"){
                    Console.WriteLine("Please enter 1 or 2");
                    continue;
                }
                break;
            }
    switch(ask){
        case "1":
            Console.WriteLine("Lütfen arama yapmak istediğiniz ismi veya soyismi giriniz");
            searchName = TakeInput();
            foreach (var item in records)
            {
                if(searchName == item.Name || searchName == item.Surname){
                    Console.WriteLine("İsim: " + item.Name);
                    Console.WriteLine("Soyisim: " + item.Surname);
                    Console.WriteLine("Numara: " + item.Number);
                    Console.WriteLine("-");
                }
            }
            break;
        case "2":
            Console.WriteLine("Lütfen arama yapmak istediğiniz numarayı giriniz");
            searchName = TakeInput();
            foreach (var item in records)
            {
                if(searchName == item.Number){
                    Console.WriteLine("İsim: " + item.Name);
                    Console.WriteLine("Soyisim: " + item.Surname);
                    Console.WriteLine("Numara: " + item.Number);
                    Console.WriteLine("-");
                }
            }
            break;
    }
}

public string TakeInput(){
string? word = "";
while(true){
    word = Console.ReadLine();
    if(word == "" || word == null){
        Console.WriteLine("gecersiz giris");
        continue;
    }
    else
        return word;
}
}
 public void ReflectionOfYourChoice(int choice){
        switch(choice){
            case 1:
                AddToBook();
                break;
            case 2:
                DeleteFromBook();
                break;
            case 3:
                ChangeNumber();
                break;
            case 4:
                WriteAllBook();
                break;
            case 5:
                SearchInBook();
                break;
            
                

              
             
        }
    }
}