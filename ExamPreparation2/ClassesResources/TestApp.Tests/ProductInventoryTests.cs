using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "Phone";
        double price = 150.50;
        int quantity = 1;
        string expected = "Product Inventory:"
            +Environment.NewLine
            +"Phone - Price: $150.50 - Quantity: 1";

        // Act
        _inventory.AddProduct(name, price, quantity);
        string actual = _inventory.DisplayInventory();
        
        // Assert
        Assert.That(actual,Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = "Product Inventory:";

        // Act
        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange       
        string expected = $"Product Inventory:{Environment.NewLine}" +
                          $"Cars - Price: $2350.45 - Quantity: 3{Environment.NewLine}" +
                          $"Phone - Price: $150.50 - Quantity: 1";


        // Act
        _inventory.AddProduct("Cars", 2350.45, 3);
        _inventory.AddProduct("Phone", 150.50, 1);
        string actual = _inventory.DisplayInventory();

        // Asser
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0;

        // Act
        double actual = _inventory.CalculateTotalValue();

        // Asser
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        double expected = 7202.00;

        // Act
        _inventory.AddProduct("Cars", 2350.50, 3);
        _inventory.AddProduct("Phone", 150.50, 1);
        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That (actual, Is.EqualTo(expected));
    }
}
