//Write MyBook class
class MyBook : Book
{
    int Price;
    public MyBook(String title, String author, int price) : base(title, author)
    {
       Price = price;
    }
    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + Price);
    }
}
