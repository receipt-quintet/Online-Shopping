// ShoppingCart.cs
using System;
using System.Collections.Generic;

public class ShoppingCart {
    private List<Product> cartItems;
    private Customer customer;

    public ShoppingCart(Customer customer) {
        this.customer = customer;
        cartItems = new List<Product>();
    }

    public void AddToCart(Product product) {
        cartItems.Add(product);
    }

    public void DisplayCart() {
        Console.WriteLine($"Shopping Cart for {customer.Name}:");
        foreach (var item in cartItems) {
            Console.WriteLine($"Product: {item.Name}, Price: {item.Price:C}");
        }
    }

    // Other shopping cart methods
    // ...
}
