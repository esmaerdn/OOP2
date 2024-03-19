//See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Box<int> number = new Box<int>();
        number.Add(1);
        number.Add(2);
        number.Add(3);


        Box<string> materialBox = new Box<string>();
        materialBox.Add("Kalem");
        materialBox.Add("Defter");
        materialBox.Add("Silgi");

        Console.WriteLine("Sayılar kutusundakiler:");
        number.Display();

        Console.WriteLine("Malzemeler kutusundakiler:");
        materialBox.Display();

    }
}


public class Box<T>  //Generic sınıf
{
    private List<T> items;
    public Box()
    {
        items = new List<T>();
    }
    public void Add(T item)   // kutuya öge eklemek için kullanılır.
    {
        items.Add(item);
    }
    public void Display()    // kutudakileri ekrana yazdırmak için kullanılır.
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

