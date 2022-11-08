﻿#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudContactMethod"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudContactMethodProvider: SqlEdStudContactMethodProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudContactMethodProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudContactMethodProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
	}
}