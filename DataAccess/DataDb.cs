using DataAccess.Db;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    internal class DataDb
    {
		string strCnn;

		public DataDb() {
			strCnn = new AppSettings().GetConectionString();
		}

		private ViajesData _viajesData;
		public ViajesData ViajesData
			=> _viajesData
			?? (_viajesData = new ViajesData(strCnn));
	}
}
