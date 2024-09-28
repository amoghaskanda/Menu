using FluentAssertions;
using Menu.Components;
using System.Collections;

namespace Tests
{
    public class HomeTests
    {
        private readonly Home _homePage;
        public HomeTests()
        {
            _homePage = new Home();
        }

        [Theory]
        [ClassData(typeof(HomeTestCasesValid))]
        public void GetTotal_ValidTests(List<Item> items, int expected)
        {
            var total = _homePage.GetTotal(items);
            total.Should().BePositive().And.Be(expected);
        }

        [Theory]
        [ClassData(typeof(HomeTestCasesInvalid))]
        public void GetTotal_WrongTotals(List<Item> items, int expected)
        {
            var total = _homePage.GetTotal(items);
            total.Should().NotBe(expected);
        }

        [Fact]
        public void GetTotal_NegativeValues_ThrowsException()
        {
            var items = new List<Item>()
            {
                new("1", -1 ,1),
                new("2", 1 ,-10),
            };

            _homePage.Invoking(h => h.GetTotal(items)).Should().Throw<InvalidOperationException>().WithMessage("Price and number of items cannot be negative");
        }

        public class HomeTestCasesValid : IEnumerable<object[]>
        {
            public static readonly List<object[]> data = new()
        {
            new object[] { new List<Item>() {new Item("Item1", 1, 5), new Item("Item2", 2, 10) }, 25 },
            new object[] { new List<Item>() {new Item("Item3", 2, 1), new Item("Item4", 4, 10) }, 42 }
        };
            public IEnumerator<object[]> GetEnumerator()
            {
                return data.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

        public class HomeTestCasesInvalid : IEnumerable<object[]>
        {
            public static readonly List<object[]> data = new()
        {
            new object[] { new List<Item>() {new Item("Item1", 1, 5), new Item("Item2", 2, 10) }, 1 },
            new object[] { new List<Item>() {new Item("Item3", 2, 1), new Item("Item4", 4, 10) }, 11 }
        };
            public IEnumerator<object[]> GetEnumerator()
            {
                return data.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return this.GetEnumerator();
            }
        }

    }
}