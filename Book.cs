namespace Phonebook;
using System;
using System.Collections;

class Book{
    private string? name;
    private string? surname;
    private string? number;

    public Book(){}
    public Book(string name , string surname , string number){
        this.name = name;
        this.surname = surname;
        this.number = number;

    }

    public string? Name {
        get { return name ;}
        set { this.name = value ;}
    }

    public string? Surname {
        get { return surname ;}
        set { this.surname = value ;}
    }

     public string? Number {
        get { return number ;}
        set { this.number = value ;}
    }


}