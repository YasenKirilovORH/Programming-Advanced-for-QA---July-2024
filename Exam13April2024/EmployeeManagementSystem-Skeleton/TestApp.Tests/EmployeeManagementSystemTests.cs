using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]


public class EmployeeManagementSystemTests
{
    private EmployeeManagementSystem _employeeManagementSystem;

    [SetUp]
    public void SetUp()
    {
        _employeeManagementSystem = new EmployeeManagementSystem();
    }

    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        // Act
        List<string> employees = _employeeManagementSystem.GetAllEmployees();
        int employeesCount = _employeeManagementSystem.EmployeeCount;

        // Assert
        Assert.That(employees, Is.Empty);
        Assert.That(employeesCount, Is.EqualTo(0));
    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        // Arrange
        string employee = "Ivan Petrov"; 

        // Act
        _employeeManagementSystem.AddEmployee(employee);
        List<string> actualEployeesList = _employeeManagementSystem.GetAllEmployees();
        int employeesCount = _employeeManagementSystem.EmployeeCount;



        // Assert
        Assert.That(actualEployeesList.Contains(employee));
        Assert.That(employeesCount, Is.EqualTo(1));
    }

    [TestCase(" ")]
    [TestCase(null)]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string input)
    {

        // Act and Assert
        Assert.Throws<ArgumentException>(() => _employeeManagementSystem.AddEmployee(input));

        List<string> actualEployeesList = _employeeManagementSystem.GetAllEmployees();
        int employeesCount = _employeeManagementSystem.EmployeeCount;

        Assert.That(actualEployeesList, Is.Empty);
        Assert.That(employeesCount, Is.EqualTo(0));
    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        // Arrange
        List<string> employeesList = new List<string>() { "Ivan Petrov", "Georgi Todorov", "Ivana Stoyanova" };
        string employeeToBeRemoved = "Ivan Petrov";
        List<string> employeesListExpected = new List<string>() { "Georgi Todorov", "Ivana Stoyanova" };

        foreach(string employee in employeesList)
        {
            _employeeManagementSystem.AddEmployee(employee);
        }

        // Act
        _employeeManagementSystem.RemoveEmployee(employeeToBeRemoved);
        List<string> actualEployeesList = _employeeManagementSystem.GetAllEmployees();
        int employeesCount = _employeeManagementSystem.EmployeeCount;

        // Assert
        Assert.That(employeesListExpected, Is.EqualTo(actualEployeesList));
        Assert.That(employeesCount, Is.EqualTo(2));

    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string employeeToBeRemoved)
    {
        // Arrange
        List<string> employeesList = new List<string>() { "Ivan Petrov", "Georgi Todorov", "Ivana Stoyanova" };

        foreach(string employee in employeesList)
        {
            _employeeManagementSystem.AddEmployee(employee);
        }

        // Act and Assert
        Assert.Throws<ArgumentException>(() => _employeeManagementSystem.RemoveEmployee(employeeToBeRemoved));

        List<string> ActualEployeesList = _employeeManagementSystem.GetAllEmployees();
        int employeesCount = _employeeManagementSystem.EmployeeCount;

        Assert.That(ActualEployeesList, Is.EqualTo(employeesList));
        Assert.That(employeesCount, Is.EqualTo(3));
    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        // Arrange
        List<string> employeesList = new List<string>() { "Ivan Petrov", "Georgi Todorov", "Ivana Stoyanova", "Vanya Gerasimova" };
        string employeeToBeRemoved = "Georgi Todorov";
        List<string> expectedEmployeesList = new List<string>() { "Ivan Petrov", "Ivana Stoyanova", "Vanya Gerasimova" };

        foreach (string employee in employeesList)
        {
            _employeeManagementSystem.AddEmployee(employee);
        }
        
        // Act
        _employeeManagementSystem.RemoveEmployee(employeeToBeRemoved);
        List<string> ActualEployeesList = _employeeManagementSystem.GetAllEmployees();
        int employeesCount = _employeeManagementSystem.EmployeeCount;

        // Assert
        CollectionAssert.AreEqual(expectedEmployeesList, ActualEployeesList);
        Assert.That(employeesCount, Is.EqualTo(3));
    }   
}

