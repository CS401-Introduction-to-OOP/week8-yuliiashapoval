namespace Week8;
class Program
{
    static void Main(string[] args)
    {
        Letter l1 = new Letter("MP23", 0.3);
        Letter l2 = new Letter("NG54", 0.1);

        Parcel p1 = new Parcel("IO61", 6.0, "30x20x15");
        Parcel p2 = new Parcel("WE39", 12.3, "50x40x60");
        
        l1.PrintInfo();
        p1.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        
        myCargo.AddItem(l1);
        myCargo.AddItem(l2);
        myCargo.AddItem(p1);
        myCargo.AddItem(p2);

        double totalCost = myCargo.GetTotalCost();
        Console.WriteLine($"\nTotal delivery cost: {totalCost}");
    }
}