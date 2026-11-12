namespace MyCalculator.Tests;

public class UnitTest1
{
	[Fact]
	public void Add_TwoNumbers_ReturnSum()
	{
		//Arrange
		Calculator calculator = new();

		//Act
		var result = calculator.Add(1, 2);
		//Assert
		Assert.Equal(3, result);
	}
}
