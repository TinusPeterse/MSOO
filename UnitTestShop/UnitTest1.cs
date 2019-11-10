using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSO;
namespace UnitTestShop
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void checkOrderForQuantityZero()
		{
			//precondition
			int number = 4;
			int amount = 0;
			int expectedListLength = 0;
			int expectedDictLength = 0;
			bool expectedLeegwinkelwagentje = true;
			WinkelWagentje winkelWagentje = new WinkelWagentje();

			//Act
			winkelWagentje.Add(number, amount);

			//Assert
			int actualListLength = winkelWagentje.InDeWagenList.Count;
			int actualDictLength = winkelWagentje.InDeWagenDictionary.Count;
			bool actualLeegwinkelwagentje = winkelWagentje.Leegwinkelwagentje;
			Assert.AreEqual(expectedDictLength, actualDictLength, "Dict not correctly updated");
			Assert.AreEqual(expectedListLength, actualListLength, "List not correctly updated");
			Assert.AreEqual(expectedLeegwinkelwagentje, actualLeegwinkelwagentje, "Leegwinkelwagentje not correctly updated");
		}
	}
}
