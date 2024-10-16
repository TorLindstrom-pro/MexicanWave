using System.Collections.Generic;
using System.Linq;
using static System.Linq.Enumerable;

namespace MexicanWave;

public class Kata
{
	public static List<string> wave(string word)
	{
		return Range(0, word.Length)
			.Where(i => word[i] != ' ')
			.Select(i => word[..i] + char.ToUpper(word[i]) + word[(i + 1)..])
			.ToList();
	}
}