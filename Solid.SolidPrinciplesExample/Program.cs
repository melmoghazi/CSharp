
namespace Solid.SolidPrinciplesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1, Amount = 1000 };

            // Dependency Injection setup for order processing
            IPaymentProcessor paymentProcessor = new CreditCardPayment(); // Can be switched to PayPalPayment
            IDiscountService discountService = new PercentageDiscount(10); // Can be switched to FixedDiscount
            IOrderLogger orderLogger = new OrderLogger();

            // Order processing with injected dependencies
            OrderService orderService = new OrderService(paymentProcessor, discountService, orderLogger);
            orderService.ProcessOrder(order);
        }
    }
}
