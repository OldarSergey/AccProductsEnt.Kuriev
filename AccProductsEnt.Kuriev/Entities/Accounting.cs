namespace AccProductsEnt.Kuriev.Entities
{
    public class Accounting
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public  int WaybillId { get; set; }
        public int PriceProduct { get; set; }


        public ICollection<Staff> Staffs { get; set;}
        public ICollection<Product> Products { get; set; }
    }
}
