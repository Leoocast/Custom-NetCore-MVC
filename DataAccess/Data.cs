using DataAccess.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
	public class Data
	{
		public Data() { }

        internal DataDb dataDb = new DataDb();

        private ViajeController _viajes;
        public ViajeController Viajes
            => _viajes
            ?? (_viajes = new ViajeController(dataDb));

    }

}
