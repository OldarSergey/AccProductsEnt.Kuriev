namespace AccProductsEnt.Kuriev.Entities
{
    public class PriceList
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Name { get; set; }

        public decimal PricePerPiece { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

    }
}
