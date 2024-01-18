namespace GarbageCollector
{
    public class Shop: IDisposable
    {
        public string? StoreName { get; set; }
        public string? StoreAdress { get; set; }
        public string? TypeOfStore { get; set; }

        public Shop(string storeName, string storeAdress, string typeOfStore)
        {
            StoreName = storeName;
            StoreAdress = storeAdress;
            TypeOfStore = typeOfStore;
        }
        ~Shop() => Console.WriteLine($"{StoreName} has deleted");
        public void Dispose() => Console.WriteLine($"{StoreName} was dispose");
        public void ShowStore()
        {
            Console.WriteLine($"Shop name: {StoreName}\nShop adress: {StoreAdress}\nType of store: {TypeOfStore}");
        }
    }
}
