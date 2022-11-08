#region Using directives

using System;
using System.Data;

using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

using System.Collections.Specialized;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AccomBuilding"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAccomBuildingProvider: SqlAccomBuildingProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAccomBuildingProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAccomBuildingProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
       
        #region Custom Methods
        public override DataTable GetBuildingData(decimal? BuildingPlaceInOutFlg, decimal BuildingId, decimal? GenderType = null)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("GetBuildingData", conn);
            command.CommandType = CommandType.StoredProcedure;

            if (BuildingPlaceInOutFlg.HasValue)
                command.Parameters.Add("BuildingPlaceInOut", SqlDbType.Decimal).Value = BuildingPlaceInOutFlg;
            command.Parameters.Add("BuildingId", SqlDbType.Decimal).Value = BuildingId;
            if(GenderType.HasValue)
                command.Parameters.Add("@GenderId", SqlDbType.Decimal).Value = GenderType;
           
            conn.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);

            conn.Close();

            return table;
        }
        #endregion
    }
}