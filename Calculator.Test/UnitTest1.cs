namespace Calculator.Test
{
    public class Tests
    {
        private readonly Calculator_Logic _calculator;
        public Tests()
        {
            _calculator = new Calculator_Logic();
        }

        [Test]
        public void Additional_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expectedResult = 15;

            // Act
            int result = _calculator.Additional(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Additional_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = -5;
            int b = -10;
            int expectedResult = -15;

            // Act
            int result = _calculator.Additional(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Subtraction_NegativeResult_ReturnsCorrectResult()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expectedResult = -1;

            // Act
            int result = _calculator.Subtraction(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Subtraction_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 15;
            int b = 5;
            int expectedResult = 10;

            // Act
            int result = _calculator.Subtraction(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Division_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 15;
            int b = 5;
            int expectedResult = 3;

            // Act
            int result = _calculator.Division(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Division_WithZeroNumber_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 15;
            int b = 0;

            // Act and Assert
            var exception = Assert.Throws<DivideByZeroException>(() => _calculator.Division(a, b));

            Assert.That(exception.Message, Is.EqualTo("Attempted to divide by zero."));
        }

        [Test]
        public void Division_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = -2;
            int b = -1;
            int expectedResult = 2;

            // Act
            int result = _calculator.Division(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Multiplication_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = -2;
            int b = -4;
            int expectedResult = 8;

            // Act
            int result = _calculator.Multiplication(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Multiplication_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 2;
            int b = 4;
            int expectedResult = 8;

            // Act
            int result = _calculator.Multiplication(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Multiplication_NumbersWithDifferentSigns_ReturnsCorrectResult()
        {
            // Arrange
            int a = -3;
            int b = 4;
            int expectedResult = -12;

            // Act
            int result = _calculator.Multiplication(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}