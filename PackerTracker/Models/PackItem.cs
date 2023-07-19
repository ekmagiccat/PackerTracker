namespace PackerTracker
{
    class PackItem
    {
        string name { get; set; }
        string brand { get; set; }
        double price { get; set; }
        double weight { get; set; }
        bool isPurchase { get; set; }
        bool isPacked { get; set; }
    }
}