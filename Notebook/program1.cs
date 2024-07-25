using System.Diagnostics.Metrics;

namespace Notebook
{
    public class Program1
    {
        public static void Main()
        {
            Customer customer = new Customer();
            Restaurant restaurant = new Restaurant();
            customer.Request(restaurant);
            restaurant.Enter();
            restaurant.Enter();
            restaurant.Enter();
            restaurant.Enter();
            restaurant.Enter();
            restaurant.Enter();
        }
       
    }
    public class Customer
    {
        public void Request(Restaurant restaurant)
        {
            restaurant.OnAcceptable = TryEnter;
        }
        public void TryEnter(Restaurant restaurant)
        {
            restaurant.Enter();
        }
    }
    public class Restaurant
    {
        public Action<Restaurant> OnAcceptable;
        int curCustomer=7;
        int maxCustomer=10;

        public bool IsAccecptable()
        {
            return curCustomer < maxCustomer;
        }
        public void CheckCustomerCount()
        {
            if (curCustomer < maxCustomer)
            {
                OnAcceptable(this);
            }
        }
        public void Enter()
        {
            if (IsAccecptable())
            {
                curCustomer++;
                Console.WriteLine("손님이 입장합니다");
            }
            else
            {
                Console.WriteLine("손님이 가득 차서 기다려야 합니다");
            }
        }
    }
}

