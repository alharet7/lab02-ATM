using ATM;

namespace ATM_TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ViewingBalance()
        {
            //Arrange
            Program.Balance = 100;
            //Act
            decimal actual = Program.ViewBalance();
            //Asserte
            Assert.Equal(100, actual);
        }
        [Fact]
        public void TestingBalanceIfItsLessThanZero()
        {
            //Arrange
            Program.Balance = -10;
            //Act
            decimal actual = Program.ViewBalance();
            //Asserte
            Assert.Equal(0, actual);

        }
        [Fact]
        public void TestingBalanceIfItsZero()
        {
            //Arrange
            Program.Balance = 0;
            //Act
            decimal actual = Program.ViewBalance();
            //Asserte
            Assert.Equal(0, actual);

        }
        [Fact]
        public void TestingDrawIfItsLessThanZero() 
        {
            //Arrange
            Program.Balance = 100;
            decimal draw = -50;
            //Act
            decimal actual = Program.WithDraw(draw);
            //Asserte
            Assert.Equal(50, actual);
        }
        [Fact]
        public void TestingDrawIfItsMoreThanBalance()
        {
            //Arrange
            Program.Balance = 100;
            decimal draw = 150;
            //Act
            decimal actual = Program.WithDraw(draw);
            //Asserte
            Assert.Equal(0, actual);
        }
        [Fact]
        public void TestingBalanceIfItsMoreThanOrEqualDraw()
        {
            //Arrange
            Program.Balance = 100;
            decimal draw = 90;
            //Act
            decimal actual = Program.WithDraw(draw);
            //Asserte
            Assert.Equal(10, actual);
        }
        [Fact]
        public void TestingDeposit()
        {
            //Arrange
            Program.Balance = 100;
            decimal deposit = 90;
            //Act
            decimal actual = Program.Deposit(deposit);
            //Asserte
            Assert.Equal(190, actual);
        }
    }
}