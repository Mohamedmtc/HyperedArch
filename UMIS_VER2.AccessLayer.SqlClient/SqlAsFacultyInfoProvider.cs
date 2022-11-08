#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AsFacultyInfo"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAsFacultyInfoProvider: SqlAsFacultyInfoProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAsFacultyInfoProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAsFacultyInfoProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override decimal GetAsFacultyInfo_for_User(TransactionManager transactionManager, System.Decimal _SeUserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAsFacultyInfo_for_User", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, _SeUserId);

            IDataReader reader = null;
            decimal _AsFacultyInfoId = 0;

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        _AsFacultyInfoId = decimal.Parse(reader[0].ToString());
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        _AsFacultyInfoId = decimal.Parse(reader[0].ToString());
                    }
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return _AsFacultyInfoId;

        }



        public  override DataTable GetAcadPlanState(TransactionManager transactionManager, string AsFacultyInfoID, string DgrCode, string DgrNameEn, string DgrNameAr,decimal PageIndex,decimal PageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetDegreeStateMap", this.UseStoredProcedure);
          
            database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, decimal.Parse(AsFacultyInfoID));
            database.AddInParameter(commandWrapper, "@DgrCode", DbType.String,DgrCode);
            database.AddInParameter(commandWrapper, "@DgrNameAr", DbType.String, DgrNameAr);
            database.AddInParameter(commandWrapper, "@DgrNameEn", DbType.String, DgrNameEn);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            IDataReader reader = null;
            DataTable table = new DataTable();

       //     MIG_DEGREE_MAJOR.AS_FACULTY_INFO_ID,
       //MIG_DEGREE_MAJOR.ID,
       //AS_FACULTY_INFO.FACULTY_DESCR_AR,
       //AS_FACULTY_INFO.FACULTY_DESCR_EN,
       //RDGRCDET.DGRCDE,RDGRCDET.DGRARBDSC,RDGRCDET.DGRENGDSC,
       //Major.ENT_DESCR_AR Major_Ar,Major.ENT_DESCR_EN Major_En,
       //MJR_ACAD_YEAR.YEAR_CODE,

       //Minor.ENT_DESCR_AR Minor_Ar,Minor.ENT_DESCR_EN Minor_En,
       //MNR_ACAD_YEAR.YEAR_CODE
            table.Columns.Add("sn");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("MIG_DEGREE_MAJOR_ID");
            table.Columns.Add("STUD_JOIN_YEAR_FROM");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("DGRCDE");
            table.Columns.Add("DGRARBDSC");
            table.Columns.Add("DGRENGDSC");
            table.Columns.Add("Major_Ar");
            table.Columns.Add("Major_En");
            table.Columns.Add("MJr_Acad_year");
            table.Columns.Add("Minor_Ar");
            table.Columns.Add("Minor_En");
            table.Columns.Add("Min_Acad_year");
            table.Columns.Add("Stud_Count");
            table.Columns.Add("Min_Year");
            table.Columns.Add("Min_Sem");
            table.Columns.Add("Max_Year");
            table.Columns.Add("Max_Sem");
            table.Columns.Add("MJR_ACAD_PLAN");
            table.Columns.Add("MNR_ACAD_PLAN");
            table.Columns.Add("MJOR_TOT_CH");
            table.Columns.Add("SPC_ENT_MAIN_ID");
            table.Columns.Add("SPC_ACAD_PLAN_ID");
            table.Columns.Add("MJOR_PLAN_CH");
            table.Columns.Add("RowsTotCount");
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

                //Create Collection
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), 
                                       reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(),
                                       reader[18].ToString(), reader[19].ToString(), reader[20].ToString(), reader[21].ToString() , reader[22].ToString()  , reader[23].ToString(), reader[24].ToString(), reader[25].ToString(), reader[26].ToString() };
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

        //Esraa Ali     27-5-2020     13648
        public override DataTable INTEG_GetSchool(System.Decimal _FacID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INTEG_GetSchool", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SIS ID");
            table.Columns.Add("Name");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
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

       //  walaa
        public override DataTable GetMajorOfFaculty(System.Decimal _FacID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetMajorOfFacultyInfo", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EntMainId");
            table.Columns.Add("EntDescrAr");
            table.Columns.Add("EntDescrEn");

            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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