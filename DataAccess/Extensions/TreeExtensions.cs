using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Extensions
{
	internal static class TreeExtensions
	{
		public static void ForEachHoja<T>(
			this List<T> Hojas
			, Action<T> action
		) where T : IHoja
		{
			Hojas.ForEachHoja(
				(nivel, hoja) => action(hoja)
			);
		}

		public static void ForEachHoja<T>(
			this List<T> Hojas
			, Action<int, T> action
		) where T : IHoja
		{
			var cola = new Queue<(int Nivel, T Item)>();

			Hojas.ForEach(h => cola.Enqueue((0, h)));

			while (cola.Count != 0)
			{
				var (Nivel, Hoja) = cola.Dequeue();

				action(Nivel, Hoja);

				Hoja.ListaHojas
					.ForEach(h => cola.Enqueue((Nivel + 1, (T)h)));
			}
		}

		public static IEnumerable<TR> SelectHoja<T, TR>(
			this List<T> Hojas
			, Func<T, TR> function
		) where T : IHoja
		{
			var cola = new Queue<T>();

			Hojas.ForEach(cola.Enqueue);

			while (cola.Count != 0)
			{
				var np = cola.Dequeue();

				yield return function(np);

				np.ListaHojas
					.ForEach(h => cola.Enqueue((T)h));
			}
		}
	}

}
