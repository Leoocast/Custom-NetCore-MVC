using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Controllers
{
    public class ViajeController
    {
		private Data Data { get; set; }

		public ViajeController(Data data)
		{
			Data = data;
		}

		public IEnumerable<Viaje> GetViajes()
		{
			var viajes = Data.ViajesData.GetViajes();

			return viajes;
		}
	}
}
