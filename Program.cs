namespace Module7_HomeWork
{
    abstract class Delivery
    {
        protected string address;
        public string Adress { get { return address; } }
    }


    class HomeDelivery : Delivery {
        public HomeDelivery() { }
        public HomeDelivery(string address)
        {
            this.address = address;
        }
    }

    class PickPointDelivery : Delivery { /* ... */ }

    class ShopDelivery : Delivery { /* ... */ }

    class Order<TDelivery>
    {
        protected TDelivery delivery;
        protected int number;
        protected string description;
        public TDelivery Delivery { get { return delivery; } }
        public Order(TDelivery delivery) {           
            this.delivery = delivery;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            HomeDelivery delivery = new HomeDelivery("MyAdress");
            Order<HomeDelivery> order = new Order<HomeDelivery>(delivery);
            string address = order.Delivery.Adress;
            Order<ShopDelivery> order1 = new Order<ShopDelivery>(new ShopDelivery());
            
        }
    }
}
