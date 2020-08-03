using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ORM
{
	internal static class Extensions
	{
		public static IEnumerable<string> GetColumnNames(this SqlDataReader source)
		{
			for (var i = 0; i < source.FieldCount; i++)
				yield return source.GetName(i);
		}
	}
}
