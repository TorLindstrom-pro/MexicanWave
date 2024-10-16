using System.Collections.Generic;

namespace MexicanWave;

public class Kata
{
	public static List<string> wave(string s)
	{
		var result = new List<string>();
		for (var i = 0; i < s.Length; i++)
		{
			if (s[i] == ' ') continue;
			
			var standingLetter = char.ToUpper(s[i]);
			var wave = s[..i] + standingLetter + s[(i + 1)..];
			result.Add(wave);
		}
		return result;
	}
}