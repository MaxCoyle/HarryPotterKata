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
            response.Should().Be(8);
        }

        [Fact]
        public void TwoDifferentBooksShouldHaveFivePercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal) 15.20);
        }

        [Fact]
        public void ThreeDifferentBooksShouldHaveTenPercentDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.TheChamberOfSecrets);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePrisonerOfAzkaban);

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal)21.60);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal)27.20);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal)32.00);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(36);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal) 39.2);
        }

        [Fact]
        public void TwoCopiesOfSameBookHaveNoDiscount()
        {
            // Arrange
            var harryPotterService = new HarryPotterLogic.HarryPotterService();
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);
            harryPotterService.AddBookToBasket(HarryPotterLogic.HarryPotterBooks.ThePhilosophersStone);

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be(16);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal) 39.2);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal) 75.2);
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

            // Act
            var response = harryPotterService.BasketTotal;

            // Assert
            response.Should().Be((decimal) 95.2);
        }
    }
}
