namespace FindMongoDb
{
    using MongoDB.Bson.Serialization.Attributes;

    public class OfferFromCollection
    {
        public OfferFromCollection(string shopId,
            string offerId,
            string name)
        {
            this.ObjectId = new OfferObjectId(shopId, offerId);
            this.Name = name;
        }

        [BsonId]
        public OfferObjectId  ObjectId
        {
            get;
            set;

        }

        public string Name { get; set; }
    }
}