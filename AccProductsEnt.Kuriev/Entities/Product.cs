namespace AccProductsEnt.Kuriev.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }


        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public DateTime DateOfManufacture { get; set; }

        public decimal PricePerPiece { get; set; }


        public int WorkshopId { get; set; }
        public int storageId { get; set; }
        public int AccoutingId { get; set; }
        public int ImplementationId { get; set; }

        public Workshop Workshop { get; set;}
        public Storage Storage { get; set; }
        public WriteOff WriteOff { get; set; }
        public Accounting Accounting { get; set; }
        public Implementation Implementation { get; set; }
    }
}
