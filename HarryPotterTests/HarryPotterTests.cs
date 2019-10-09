using FluentAssertions;
using Xunit;

namespace HarryPotterTests
{
    public class UnitTests
    {
        [Fact]
        public void OneBookShouldHaveNoDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(HarryPotterLogic.HarryPotterService.SingleBookPrice);
        }

        [Fact]
        public void TwoDifferentBooksShouldHaveFivePercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 2 * 95 / 100;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void ThreeDifferentBooksShouldHaveTenPercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 3 * 90 / 100;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void FourDifferentBooksShouldHaveFifteenPercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 4 * 85 / 100;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void FiveDifferentBooksShouldHaveTwentyPercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheOrderOfThePhoenix);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 5 * 80 / 100;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void SixDifferentBooksShouldHaveTwentyFivePercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheOrderOfThePhoenix);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheHalfBloodPrince);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 6 * 75 / 100;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void SevenDifferentBooksShouldHaveThirtyPercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheOrderOfThePhoenix);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheHalfBloodPrince);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheDeathlyHallows);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 7 * 70 / 100;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void TwoCopiesOfSameBookHaveNoDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            const decimal expected = HarryPotterLogic.HarryPotterService.SingleBookPrice * 2;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void KataTest1()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            const decimal discountedBooksTotal = HarryPotterLogic.HarryPotterService.SingleBookPrice * 2 * 95 / 100;
            const decimal nonDiscountedBooksTotal = HarryPotterLogic.HarryPotterService.SingleBookPrice * 3;
            const decimal expected = discountedBooksTotal + nonDiscountedBooksTotal;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void KataTest2()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            const decimal discountedBooksTotal = HarryPotterLogic.HarryPotterService.SingleBookPrice * 4 * 85 / 100;
            const decimal nonDiscountedBooksTotal = HarryPotterLogic.HarryPotterService.SingleBookPrice * 6;
            const decimal expected = discountedBooksTotal + nonDiscountedBooksTotal;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }

        [Fact]
        public void KataTest3()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheGobletOfFire);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheOrderOfThePhoenix);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheHalfBloodPrince);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheHalfBloodPrince);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheDeathlyHallows);
            const decimal discountedBooksTotal = HarryPotterLogic.HarryPotterService.SingleBookPrice * 7 * 70 / 100;
            const decimal nonDiscountedBooksTotal = HarryPotterLogic.HarryPotterService.SingleBookPrice * 7;
            const decimal expected = discountedBooksTotal + nonDiscountedBooksTotal;

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(expected);
        }
    }
}
