using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
	[TestClass]
	public class DamageReductionTest
	{
		[TestMethod]
		public void TestDamageReduction()
		{
			int damage = 100;
			int protectionValue = 10;
			int actual = SimpleGame.Logic.Combat.ApplyDamageReduction(damage, protectionValue);
			int expected = 25;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void TestRandomDamageReduction()
		{
			int damage = 1;
			int protectionValue = 20;
			int count = 0;
			for (int i = 0; i < 1000; i++)
			{
				count += SimpleGame.Logic.Combat.ApplyDamageReduction(damage, protectionValue);
			}
			int upperBound = 515;
			int lowerBound = 485;

			Assert.IsTrue(count >= lowerBound && count <= upperBound);
		}
	}
}
