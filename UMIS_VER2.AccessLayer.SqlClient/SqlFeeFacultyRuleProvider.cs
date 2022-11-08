#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using System.Collections.Generic;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="FeeFacultyRule"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlFeeFacultyRuleProvider: SqlFeeFacultyRuleProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlFeeFacultyRuleProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlFeeFacultyRuleProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Methods
        //added by nashassn  12/7/2016
        public override TList<FeeFacultyRule> GetAllCustom(TransactionManager transactionManager,int lang)
        {


            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.FEE_FACULTY_RULE_Get_ListCustom", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@lang", DbType.Int32, lang);

            IDataReader reader = null;

         
            TList<FeeFacultyRule> rows =  new TList<FeeFacultyRule>();

         

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllCustom", rows));

                
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }


                int start = 0, pageLength = int.MaxValue;
                Fill(reader, rows, start, pageLength);
                
             
               
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                
                commandWrapper = null;
            }

            return rows;
        }//end getall
		
        #endregion
    }
}