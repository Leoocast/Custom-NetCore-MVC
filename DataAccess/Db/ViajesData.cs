using DataAccess.Entities;
using ORM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Db
{
	public class ViajesData : DataSource<Viaje>
	{
		public ViajesData(string strCnn) : base(strCnn) { }

		public IEnumerable<Viaje> GetViajes()
		{
			const string sql = "Select * from viajes";

			return GetEnumerable<Viaje>(sql);
		}

		//public IEnumerable<UsuariosAccesos> GetUsuariosAccesos(int idUsuario)
		//{
		//	return
		//		GetEnumerable<UsuariosAccesos>(
		//			"SELECT * " +
		//			"FROM UsuariosAccesos " +
		//			"WHERE IdUsuario = @idUsuario"
		//			, new ParameterList { { "idUsuario", idUsuario } }
		//			);
		//}

	}
}
