internal class Program
{
    static void Main(string[] args)
    {
        Inven NewInven = new Inven(5, 3);

        NewInven.ItemIn(new Item("철검", 100));
        NewInven.ItemIn(new Item("갑옷", 200));
        NewInven.ItemIn(new Item("갑옷", 200), 6);
        while (true)
        {
            Console.Clear();
            NewInven.Render();
        }
    }
}
