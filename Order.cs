namespace MainPackage {
    using SubPackage;
    public class Order {
        public string Id { get; set; }
        public Order()
        {
            Sub sub = new Sub();
            sub.Id = "123";
        }        
    }
}
