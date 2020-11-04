namespace FindMongoDb
{
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
         Get();
         Console.ReadLine();
        }

        public static void Get()
        {
            MongoClient client  = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("alloffers");
            IMongoCollection<OfferFromCollection> colletion = database.GetCollection<OfferFromCollection>("offers");
            string shopId = "oldshop";
            List<OfferFromCollection> offersFromCol = colletion.Find(offer=>offer.ObjectId.ShopId==shopId).ToList();
            foreach (OfferFromCollection offer in offersFromCol)
            {
                Console.WriteLine(offer.ObjectId.OfferId);
                Console.WriteLine(offer.Name);
            }
        }

        public static void Create()
        {
            MongoClient client  = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("alloffers");
            IMongoCollection<OfferFromCollection> colletion = database.GetCollection<OfferFromCollection>("offers");
            colletion.InsertOne(new OfferFromCollection("oldshop","56468764","Наушники samsung G20"));
            colletion.InsertOne(new OfferFromCollection("oldshop","12365436","Microphone T32"));
        }
    }
    
}