using System.Collections.Generic;
using System.Linq;

namespace TestAPIReqresIn.Extensions
{
	internal static class ListExtension
	{
		/// <summary>
		/// Сравнить списки по содержимому
		/// </summary>
		/// <returns>True, если списки совпадают по содержимомоу, иначе false</returns>
		public static bool ScrambledEquals<T>(this IEnumerable<T> left, IEnumerable<T> right)
		{
			var cnt = new Dictionary<T, int>();

			foreach (T s in left)
			{
				if (cnt.ContainsKey(s))
				{
					cnt[s]++;
				}
				else
				{
					cnt.Add(s, 1);
				}
			}

			foreach (T s in right)
			{
				if (cnt.ContainsKey(s))
				{
					cnt[s]--;
				}
				else
				{
					return false;
				}
			}

			return cnt.Values.All(c => c == 0);
		}
	}
}
