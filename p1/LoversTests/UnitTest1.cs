using Xunit;
using Models;
using BusinessLogic;
using Repository;
using System.Linq;
using System.Collections.Generic;

namespace LoversTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Title_Fact()
        {
            var sut = new Book {
                Title = "Pride and Prejudice"
            };
            var expected = "Pride and Prejudice";

            var actual = sut.Title;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Author_Fact()
        {
            var sut = new Book {
                Author = "Gail Carson Levine"
            };
            var expected = "Gail Carson Levine";

            var actual = sut.Author;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Summary_Fact()
        {
            var sut = new Book {
                Summary = "A collection of short stories."
            };
            var expected = "A collection of short stories.";

            var actual = sut.Summary;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_BookPrice_Fact()
        {
            var sut = new Book {
                Price = 10M
            };
            var expected = 10M;

            var actual = sut.Price;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Amount_Fact()
        {
            var sut = new Book {
                NumberAvailable = 10
            };
            var expected = 10;

            var actual = sut.NumberAvailable;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Fname_Fact()
        {
            var sut = new Customer {
                Fname = "Tristyn"
            };
            var expected = "Tristyn";

            var actual = sut.Fname;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Lname_Fact()
        {
            var sut = new Customer {
                Lname = "Linde"
            };
            var expected = "Linde";

            var actual = sut.Lname;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_FullName_Fact()
        {
            var sut = new Customer {
                Fname = "Tristyn",
                Lname = "Linde"
            };
            var expected = "Tristyn Linde";

            var actual = sut.Fname + " " + sut.Lname;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_UserName_Fact()
        {
            var sut = new Customer {
                UserName = "tris"
            };
            var expected = "tris";

            var actual = sut.UserName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_Store_Fact()
        {
            var sut = new Order {
                Store = "Lovers Ln"
            };
            var expected = "Lovers Ln";

            var actual = sut.Store;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_OrderPrice_Fact()
        {
            var sut = new Order {
                Price = 25M
            };
            var expected = 25M;

            var actual = sut.Price;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_OrderBooks_Fact()
        {
            Book book1 = new Book();
            Book book2 = new Book();

            var sut = new Order {
                Books = new List<Book>() {
                    book1,
                    book2
                }
            };
            var expected = new List<Book>() {
                    book1,
                    book2
                };

            var actual = sut.Books;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_OrderBooks1_Fact()
        {
            Book book1 = new Book();
            Book book2 = new Book();

            var sut = new Order {
                Books = new List<Book>() {
                    book1,
                    book2
                }
            };
            var expected = 2;

            var actual = sut.Books.ToList().Count;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null)]
        public void Test_Title_Theory(string expected)
        {
            var sut = new Book();

            var actual = sut.Title;

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_OrderBooks2_Fact()
        {
            List<Book> books = new List<Book>();

            var sut = new Order() {
                Books = books
            };

            var actual = sut.Books.ToList();

            Assert.IsType<List<Book>>(actual);
        }

        [Theory]
        [InlineData("TrisLindetristynpassword")]
        public void Test_RawCust_Theory(string expected)
        {
            var sut = new RawCust() {
                Fname = "Tris",
                Lname = "Linde",
                Username = "tristyn",
                Password = "password"
            };

            var actual = sut.Fname + sut.Lname + sut.Username + sut.Password;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        public void Test_Order_Theory(decimal expected)
        {
            var sut = new Order();

            var actual = sut.Price;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("TristynLinde")]
        public void Test_CustomerName_Theory(string expected)
        {
            var sut = new Customer() {
                Fname = "Tristyn",
                Lname = "Linde"
            };

            var actual = sut.Fname + sut.Lname;

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(null)]
        public void Test_Fname_Theory(string expected)
        {
            var sut = new Customer();

            var actual = sut.Fname;

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(null)]
        public void Test_Lname_Theory(string expected)
        {
            var sut = new Customer();

            var actual = sut.Lname;

            Assert.Equal(expected, actual);

        }
    }
}
