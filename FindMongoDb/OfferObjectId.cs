namespace FindMongoDb
{
    public class OfferObjectId
    {
        public OfferObjectId(
            string shopId,
            string offerId)
        {
            this.OfferId = offerId;
            this.ShopId = shopId;
        }

        public string OfferId { get; set; }
        public string ShopId { get; set; }
    }
}