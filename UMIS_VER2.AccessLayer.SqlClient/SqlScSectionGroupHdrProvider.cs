#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="ScSectionGroupHdr"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlScSectionGroupHdrProvider: SqlScSectionGroupHdrProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlScSectionGroupHdrProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlScSectionGroupHdrProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Custom Method

        public override DataTable GetSectionGroupHdrList(TransactionManager transactionManager, System.Decimal _AsCodeDegreeClassId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EntMainId, System.Decimal _GrpTypeFlg, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCodeLevelId, System.Decimal? _EdCourseId, string _GroupCode, System.Decimal _IsActive, System.Decimal? _SttafId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSectionGroupHdrList", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@GrpTypeFlg", DbType.Decimal, _GrpTypeFlg);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, _EdCodeLevelId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            database.AddInParameter(commandWrapper, "@GroupCode", DbType.String, _GroupCode);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, _IsActive);
           
            database.AddInParameter(commandWrapper, "@SttafId", DbType.Decimal, _SttafId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SECTION_GROUP_HDR_ID");
            table.Columns.Add("GROUP_CODE");
            table.Columns.Add("GRP_TYPE_FLG");
            table.Columns.Add("LOAD_FLG");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("LANGUAGE_DESCR_AR");
            table.Columns.Add("LANGUAGE_DESCR_EN");
            table.Columns.Add("LEVEL_DESCR_AR");
            table.Columns.Add("LEVEL_DESCR_EN");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("GRP_DESC_AR");
            table.Columns.Add("GRP_DESC_EN");
            table.Columns.Add("STUD_COUNT");
            table.Columns.Add("Teaching_Method_EN");
            table.Columns.Add("Teaching_Method_AR");
            table.Columns.Add("COD_EN");
            table.Columns.Add("COD_AR");
            table.Columns.Add("SerialNO");
            table.Columns.Add("PeriodFROMDATE");
            table.Columns.Add("PeriodTODATE");
          
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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() 
                                     , reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(),
                                      reader[14].ToString(), reader[15].ToString(),reader[16].ToString(), reader[17].ToString(), reader[18].ToString(), reader[19].ToString(), reader[20].ToString(),
                                      reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),reader[24].ToString(),reader[25].ToString()};
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


        public override int GetMinNoAvailForGroupHdrLoad(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMinNoAvailForGroupHdrLoad", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScSectionGroupHdrId", DbType.Decimal, _ScSectionGroupHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("MinAvailNo");
            int count = 0;
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (table.Rows.Count > 0)
                count = int.Parse(table.Rows[0][0].ToString());

            return count;
        }

        /*---task 17578---*/
        public override DataTable GetMinFromToDateForGroupHdrLoad(TransactionManager transactionManager, System.Decimal _ScSectionGroupHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMin_From_To_ForGroupHdrLoad", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ScSectionGroupHdrId", DbType.Decimal, _ScSectionGroupHdrId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("From_Date");
            table.Columns.Add("To_Date");
  
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
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
        public override DataTable Get_SECTION_GROUP_In_Department(TransactionManager transactionManager, System.Decimal _AsCodeDegreeClassId, System.Decimal _AsFacultyInfoId,
           System.Decimal _EntMainId, System.Decimal _GrpTypeFlg, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_SECTION_GROUP_In_Department", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@GrpTypeFlg", DbType.Decimal, _GrpTypeFlg);
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ScSectionGroupHdrId");
            table.Columns.Add("GroupCode");
            table.Columns.Add("GrpTypeFlg");
            table.Columns.Add("EdCodeLevelId");
            table.Columns.Add("EntMainId");
            

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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
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