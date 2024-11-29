using System;
using System.Collections.Generic;

namespace Solid.SolidPrinciplesExample
{
    // 1. Single Responsibility Principle (SRP)
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
    }

    // Open/Closed Principle (OCP) and Liskov Substitution Principle (LSP)
    // Base Interface for Payment
    public interface IPaymentProcessor
    {
        void ProcessPayment(Order order);
    }

    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing credit card payment for Order Id: {order.Id}");
        }
    }

    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing PayPal payment for Order Id: {order.Id}");
        }
    }

    // Open/Closed Principle (OCP) and Liskov Substitution Principle (LSP)
    // Base Interface for Discount
    public interface IDiscountService
    {
        decimal ApplyDiscount(Order order);
    }

    public class PercentageDiscount : IDiscountService
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public decimal ApplyDiscount(Order order)
        {
            return order.Amount * _percentage / 100;
        }
    }

    public class FixedDiscount : IDiscountService
    {
        private readonly decimal _fixedAmount;

        public FixedDiscount(decimal fixedAmount)
        {
            _fixedAmount = fixedAmount;
        }

        public decimal ApplyDiscount(Order order)
        {
            return _fixedAmount;
        }
    }

    // 3. Interface Segregation Principle (ISP)
    public interface IOrderLogger
    {
        void LogOrder(Order order);
    }

    public class OrderLogger : IOrderLogger
    {
        public void LogOrder(Order order)
        {
            Console.WriteLine($"Order {order.Id} logged with total amount: {order.Amount - order.Discount}");
        }
    }

    // Dependency Inversion Principle (DIP)
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IDiscountService _discountService;
        private readonly IOrderLogger _orderLogger;

        public OrderService(IPaymentProcessor paymentProcessor, IDiscountService discountService, IOrderLogger orderLogger)
        {
            _paymentProcessor = paymentProcessor;
            _discountService = discountService;
            _orderLogger = orderLogger;
        }

        public void ProcessOrder(Order order)
        {
            // Apply discount
            order.Discount = _discountService.ApplyDiscount(order);

            // Process payment
            _paymentProcessor.ProcessPayment(order);

            // Log the order
            _orderLogger.LogOrder(order);
        }
    }




}
