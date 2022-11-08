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

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
    ///<summary>
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="CoCrsRsltRaise"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlCoCrsRsltRaiseProvider : SqlCoCrsRsltRaiseProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlCoCrsRsltRaiseProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlCoCrsRsltRaiseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }
        #region Custom Methods
        public override DataTable CoCrsRsltRaiseGetSearch(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, decimal _AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CO_CRS_RSLT_RAISE_GetSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.String, _AsCodeDegreeClassId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                table.Load(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                commandWrapper = null;
            }
            return table;
        }
        public override bool ApplyRaise(TransactionManager transactionManager, System.Decimal _CoCrsRsltRaiseId, System.Decimal _DeleteFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.EXEC_CRSRSLTRAISE", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CoCrsRsltRaiseId", DbType.Decimal, _CoCrsRsltRaiseId);
            database.AddInParameter(commandWrapper, "@DeleteFlg", DbType.Decimal, _DeleteFlg);

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            return Convert.ToBoolean(results);
        }
        #endregion

    }
}