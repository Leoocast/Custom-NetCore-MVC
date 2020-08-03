using DataAccess.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class DataDb
    {
		private const string strCnn =
		   @"Server=.\SQLEXPRESS
		   ;Database=Prueba
		   ;User Id=sa
		   ;Password=123
		   ;";

		private ViajesData _viajesData;
		public ViajesData ViajesData
			=> _viajesData
			?? (_viajesData = new ViajesData(strCnn));

	}
}
