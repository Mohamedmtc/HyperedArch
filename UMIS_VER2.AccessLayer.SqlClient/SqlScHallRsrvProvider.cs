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
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScHallRsrv"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlScHallRsrvProvider : SqlScHallRsrvProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlScHallRsrvProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlScHallRsrvProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods
        //added by dalia to get the free hall to reserve it
        public override DataTable Get_Empty_Hall_S(TransactionManager transactionManager, System.Decimal _CourseId,
             System.Decimal _entMainId, System.Decimal _MaxCapacity, System.Decimal _BuildingId, System.Decimal _CampasId, System.Decimal _hallTypeId, System.DateTime? _fromTime, System.DateTime? _toTime, System.String _DayID, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Get_Empty_Hall_S", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CourseId", DbType.Decimal, _CourseId);
            database.AddInParameter(commandWrapper, "@entMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@MaxCapacity", DbType.Decimal, _MaxCapacity);
            database.AddInParameter(commandWrapper, "@BuildingId", DbType.Decimal, _BuildingId);
            database.AddInParameter(commandWrapper, "@CampasId", DbType.Decimal, _CampasId);
            database.AddInParameter(commandWrapper, "@hallTypeId", DbType.Decimal, _hallTypeId);
            database.AddInParameter(commandWrapper, "@fromTime", DbType.DateTime, _fromTime);
            database.AddInParameter(commandWrapper, "@toTime", DbType.DateTime, _toTime);
            database.AddInParameter(commandWrapper, "@DayID", DbType.String, _DayID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_BUILDING_ID");
            table.Columns.Add("BUILD_CODE");
            table.Columns.Add("BuildingAr");
            table.Columns.Add("BuildingEn");
            table.Columns.Add("GS_CDE_CAMPUS_ID");
            table.Columns.Add("CampusAr");
            table.Columns.Add("CampusEn");
            table.Columns.Add("SC_HALL_ID");

            table.Columns.Add("HALL_CODE");
            table.Columns.Add("HallAr");
            table.Columns.Add("CAPACITY");
            table.Columns.Add("IS_SHARED");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("HallEn");
            table.Columns.Add("EXM_CAPCITY");
            table.Columns.Add("CAPACITY_MAX");
            table.Columns.Add("conflictCount");
            
           
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                     , reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString(),
                                     reader[11].ToString(),reader[12].ToString(),reader[13].ToString(),reader[14].ToString(),reader[15].ToString(),reader[16].ToString()};
                    table.Rows.Add(items);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }

        #endregion
    }
}