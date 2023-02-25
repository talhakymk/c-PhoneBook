namespace Phonebook;

 class DefaultList{
    private List<Book> defaultlist = new List<Book>();

    public DefaultList(){
        Book book1 = new Book("talha" , "kaymak" , "5454");
        Book book2 = new Book("ali" , "kaya" , "2454");
        Book book3 = new Book("taha" , "kaymaz" , "7854");
        Book book4 = new Book("zeyno" , "gürbüs" , "666");
        Book book5 = new Book("sultan" , "mehmet" , "1453");
        defaultlist.Add(book1);
        defaultlist.Add(book2);
        defaultlist.Add(book3);
        defaultlist.Add(book4);
        defaultlist.Add(book5);
    }

    public List<Book> Defaultlist{ get {return defaultlist ;}}
}