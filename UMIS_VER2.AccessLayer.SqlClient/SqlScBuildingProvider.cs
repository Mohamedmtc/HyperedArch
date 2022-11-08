#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScBuilding"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScBuildingProvider: SqlScBuildingProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScBuildingProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScBuildingProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override TList<ScBuilding> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
        {
            count = -1;
            if (whereClause.IndexOf(";") > -1)
                return new TList<ScBuilding>();

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SC_BUILDING_Find", UseStoredProcedure);

            bool searchUsingOR = false;
            if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
                searchUsingOR = true;

            database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);

            database.AddInParameter(commandWrapper, "@ScBuildingId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@BuildCode", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeCampusId", DbType.Decimal, DBNull.Value);

            // replace all instances of 'AND' and 'OR' because we already set searchUsingOR
            whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|");
            string[] clauses = whereClause.ToLower().Split('|');

            // Here's what's going on below: Find a field, then to get the value we
            // drop the field name from the front, trim spaces, drop the '=' sign,
            // trim more spaces, and drop any outer single quotes.
            // Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"

            char[] equalSign = { '=' };
            char[] singleQuote = { '\'' };
            foreach (string clause in clauses)
            {
                if (clause.Trim().StartsWith("sc_building_id ") || clause.Trim().StartsWith("sc_building_id="))
                {
                    database.SetParameterValue(commandWrapper, "@ScBuildingId",
                        clause.Trim().Remove(0, 14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("build_code ") || clause.Trim().StartsWith("build_code="))
                {
                    database.SetParameterValue(commandWrapper, "@BuildCode",
                        clause.Trim().Remove(0, 10).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("descr_ar ") || clause.Trim().StartsWith("descr_ar="))
                {
                    database.SetParameterValue(commandWrapper, "@DescrAr",
                        clause.Trim().Remove(0, 8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("descr_en ") || clause.Trim().StartsWith("descr_en="))
                {
                    database.SetParameterValue(commandWrapper, "@DescrEn",
                        clause.Trim().Remove(0, 8).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("as_faculty_info_id ") || clause.Trim().StartsWith("as_faculty_info_id="))
                {
                    database.SetParameterValue(commandWrapper, "@AsFacultyInfoId",
                        clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("gs_cde_campus_id ") || clause.Trim().StartsWith("gs_cde_campus_id="))
                {
                    database.SetParameterValue(commandWrapper, "@GsCdeCampusId",
                        clause.Trim().Remove(0, 16).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }

                throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
            }

            IDataReader reader = null;
            //Create Collection
            TList<ScBuilding> rows = new TList<ScBuilding>();


            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, start, pageLength);

                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }



        #endregion

        #region Custom Methods
        //public override DataTable GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SC_BUILDING_GetByAsFacultyInfoId", this.UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);

        //    IDataReader reader = null;
        //    DataTable table = new DataTable();
        //    table.Columns.Add("ScBuildingId");
        //    table.Columns.Add("BuildCode");
        //    table.Columns.Add("DescrAr");
        //    table.Columns.Add("DescrEn");
        //    table.Columns.Add("AsFacultyInfoId");

        //    try
        //    {
        //        if (transactionManager != null)
        //        {
        //            reader = Utility.ExecuteReader(transactionManager, commandWrapper);
        //        }
        //        else
        //        {
        //            reader = Utility.ExecuteReader(database, commandWrapper);
        //        }

        //        while (reader.Read())
        //        {
        //            object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
        //            table.Rows.Add(items);
        //        }
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //            reader.Close();

        //        commandWrapper = null;
        //    }

        //    return table;
        //}
        #endregion
    }
}