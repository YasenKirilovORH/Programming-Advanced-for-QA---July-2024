using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class CargoManagementSystemTests
{
    private CargoManagementSystem _cargoManagementSystem = new CargoManagementSystem();
    [SetUp]
    public void SetUp()
    {
        this._cargoManagementSystem = new();
    }

    [Test]
    public void Test_Constructor_CheckInitialEmptyCargoCollectionAndCount()
    {
        // Arrange
        List<string> expectedCargos = new List<string>();

        // Act
        List<string> actualCargos = _cargoManagementSystem.GetAllCargos();
        int actualCargosCount = -_cargoManagementSystem.CargoCount;

        // Assert
        CollectionAssert.AreEqual(actualCargos, expectedCargos);
        Assert.AreEqual(0, actualCargosCount);
    }

    [Test]
    public void Test_AddCargo_ValidCargoName_AddNewCargo()
    {
        // Arrange
        string cargo = "fruits";
        _cargoManagementSystem.AddCargo(cargo);
        int cargoCount = 1;
        List<string> expectedCargos = new List<string>()
        {
            "fruits"
        };

        // Act
        List<string> actualCargos = _cargoManagementSystem.GetAllCargos();
        int actualCargosCount = _cargoManagementSystem.CargoCount;

        // Assert
        CollectionAssert.AreEqual(expectedCargos, actualCargos);
        Assert.AreEqual(1, actualCargosCount);
    }

    [Test]
    public void Test_AddCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange
        string cargo = "";
        int cargoCount = 1;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => _cargoManagementSystem.AddCargo(cargo));
    }

    [Test]
    public void Test_RemoveCargo_ValidCargoName_RemoveFirstCargoName()
    {
        // Arrange
        string cargo = "cars";
        _cargoManagementSystem.AddCargo(cargo);
        int cargoCount = 1;
        _cargoManagementSystem.RemoveCargo(cargo);
        List<string> expectedCargo = new List<string>();

        // Act
        List<string> actualCargos = _cargoManagementSystem.GetAllCargos();
        int actualCargosCount = _cargoManagementSystem.CargoCount;

        // Assert
        CollectionAssert.AreEqual(expectedCargo, actualCargos);
        Assert.AreEqual(0, actualCargosCount);
    }

    [Test]
    public void Test_RemoveCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange
        string cargo = "";
        int cargoCount = 1;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => _cargoManagementSystem.RemoveCargo(cargo));
    }

    [Test]
    public void Test_GetAllCargos_AddedAndRemovedCargos_ReturnsExpectedCargoCollection()
    {
        // Arrange
        string firstCargo = "items";
        string secondCargo = "tools";
        string thirdCargo = "cars";
        _cargoManagementSystem.AddCargo(firstCargo);
        _cargoManagementSystem.AddCargo(secondCargo);
        _cargoManagementSystem.AddCargo(thirdCargo);

        _cargoManagementSystem.RemoveCargo(secondCargo);


        List<string> expectedCargos = new List<string>()
        {
            "items", "cars"
        };

        // Act
        List<string> actualCargos = _cargoManagementSystem.GetAllCargos();
        int actualCargosCount = _cargoManagementSystem.CargoCount;

        // Assert
        CollectionAssert.AreEqual(expectedCargos, actualCargos);
        Assert.AreEqual(2, actualCargosCount);
    }
}

    