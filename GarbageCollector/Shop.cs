using System.Net;
using static System.Formats.Asn1.AsnWriter;

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
        public void Dispose()
        {
            Console.WriteLine($"{StoreName} was dispose");
        }
        public void ShowStore()
        {
            Console.WriteLine($"Shop name: {StoreName}\nShop adress: {StoreAdress}\nType of store: {TypeOfStore}");
        }

        //        Реалізуйте у класі методи та властивості, необхідні для функціонування класу.

        //Клас має реалізовувати інтерфейс IDisposable.

        //Напишіть код для тестування функціональності класу.

        //Напишіть код для виклику методу Dispose.
    }
}
