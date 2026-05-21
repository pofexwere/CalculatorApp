namespace CalculatorApp.Tests_
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Calculator c = new Calculator();
			int result = c.Add(5, 3);
			Assert.Equal(8, result);
		}
	}
}
