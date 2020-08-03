using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
	public interface IHoja
	{
		List<IHoja> ListaHojas { get; set; }
	}
}
