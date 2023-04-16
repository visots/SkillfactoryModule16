using Moq;
using Xunit;

namespace BookRepository.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void FindAllMustReturnCorrectVal()
        {
            List<Book> books = new List<Book>() 
            { 
                new Book(){Title ="Война и мир" },
                new Book(){Title ="Человек-невидимка" },
                new Book(){Title ="Анна Каренина" }
            };

            var mockBookRepository = new Mock<IBookRepository>();
            mockBookRepository.Setup(x => x.FindAll()).Returns(books);

            Assert.Contains(mockBookRepository.Object.FindAll(), b=>b.Title =="Война и мир");


        }
    }
}