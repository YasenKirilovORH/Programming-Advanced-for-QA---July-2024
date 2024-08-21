using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class HotelGuestSystemTests
    {
        private HotelGuestSystem _hotelGuestSystem;

        [SetUp]

        public void SetUp()
        {
            _hotelGuestSystem = new HotelGuestSystem();
        }

        [Test]
        public void Test_Constructor_CheckInitialEmptyGuestCollectionAndCount()
        {
            // Act
            List<string> guestsList = _hotelGuestSystem.GetAllGuests();
            int guestsCount = _hotelGuestSystem.GuestsCount;

            // Assert
            Assert.That(guestsList, Is.Empty);
            Assert.That(guestsCount, Is.EqualTo(0));
        }

        [Test]
        public void Test_RegisterGuest_ValidGuestName_AddNewGuest()
        {
            // Arrange
            string guestName = "Yasen Kirilov";
            List<string> expectedGuestList = new List<string>()
            {
                { "Yasen Kirilov" }
            };

            // Act
            _hotelGuestSystem.RegisterGuest(guestName);
            List<string> actualGuestList = _hotelGuestSystem.GetAllGuests();

            // Assert
            Assert.That(actualGuestList, Is.EqualTo(expectedGuestList));
            Assert.That(actualGuestList.Count, Is.EqualTo(1));
        }

        [TestCase(null)]
        [TestCase(" ")]
        public void Test_RegisterGuest_NullOrEmptyGuestName_ThrowsArgumentException(string name)
        {
            // Act and Assert
            Assert.Throws<ArgumentException>(() => _hotelGuestSystem.RegisterGuest(name));
        }

        [Test]
        public void Test_RemoveGuest_ValidGuestName_RemoveFirstGuestName()
        {
            // Arrange
            List<string> guestsList = new List<string>()
            {
                { "Yasen Kirilov" },
                { "Ivan Ivanov" },
                { "Militsa Stoilova" },
                { "Gergana Valkova" }
            };
            foreach(string guestName in guestsList)
            {
                _hotelGuestSystem.RegisterGuest(guestName);
            }

            string guestToBeRemoved = "Yasen Kirilov";

            List<String> expectedGuestsList = new List<String>()
                {
                { "Ivan Ivanov" },
                { "Militsa Stoilova" },
                { "Gergana Valkova" }
            };

            // Act
            _hotelGuestSystem.RemoveGuest(guestToBeRemoved);
            List<string> actualGuestsList = _hotelGuestSystem.GetAllGuests();
            
            // Assert
            CollectionAssert.AreEqual(expectedGuestsList, actualGuestsList);
        }

        [TestCase(null)]
        [TestCase(" ")]
        public void Test_RemoveGuest_NullOrEmptyGuestName_ThrowsArgumentException(string name)
        {
            // Act and Assert
            Assert.Throws<ArgumentException>(() => _hotelGuestSystem.RemoveGuest(name));
        }
            
        [Test]
        public void Test_GetAllGuests_RegisteredAndRemovedGuests_ReturnsExpectedGuestCollection()
        {
            // Arrange
            List<string> guestsList = new List<string>()
            {
                { "Yasen Kirilov" },
                { "Ivan Ivanov" },
                { "Militsa Stoilova" },
                { "Gergana Valkova" }
            };
            foreach(string guestName in guestsList)
            {
                _hotelGuestSystem.RegisterGuest(guestName);
            }

            string guestToBeRemoved = "Militsa Stoilova";

            List<string> expectedGuestsList = new List<string>()
            {
                { "Yasen Kirilov" },
                { "Ivan Ivanov" },
                { "Gergana Valkova" }
            };

            // Act
            _hotelGuestSystem.RemoveGuest(guestToBeRemoved);
            List<string> actualGuestsList = _hotelGuestSystem.GetAllGuests();

            // Assert
            CollectionAssert.AreEqual(expectedGuestsList, actualGuestsList);
        }
    }
}

