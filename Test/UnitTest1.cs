using MexicanWave;

namespace Test;

public class Tests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void SingleLetter_ReturnsAsUpperCase()
	{
		var result = Kata.wave("a");
		Assert.That(result, Contains.Item("A"));
	}

	[Test]
	public void TwoLetters_EachLetterBecomesUpperCaseInTurns()
	{
		var result = Kata.wave("ab");
		Assert.That(result, Contains.Item("Ab"));
		Assert.That(result, Contains.Item("aB"));
	}

	[Test]
	public void Word_BecomesMexicanWave()
	{
		var result = Kata.wave("abcd");
		Assert.That(result, Contains.Item("Abcd"));
		Assert.That(result, Contains.Item("aBcd"));
		Assert.That(result, Contains.Item("abCd"));
		Assert.That(result, Contains.Item("abcD"));
	}

	[Test]
	public void EmptyString_ReturnsEmptyList()
	{
		var result = Kata.wave("");
		Assert.That(result, Is.Empty);
	}

	[Test]
	public void SpacesInWord_AreSkipped()
	{
		var result = Kata.wave("ab c d");
		var expectedResult = new[] { "Ab c d", "aB c d", "ab C d", "ab c D" };
		Assert.That(result, Is.EquivalentTo(expectedResult));
	}
	
	[Test]
	public void RepeatLetters_AreUpperCasedInTurn()
	{
		var result = Kata.wave("hello");
		var expectedResult = new[] { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
		Assert.That(result, Is.EquivalentTo(expectedResult));
	}
}