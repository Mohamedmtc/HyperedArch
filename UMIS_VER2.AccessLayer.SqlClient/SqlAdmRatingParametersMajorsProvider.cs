#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmRatingParametersMajors"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmRatingParametersMajorsProvider: SqlAdmRatingParametersMajorsProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmRatingParametersMajorsProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmRatingParametersMajorsProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Custom Events

        public override DataTable GetAdmissionRatingMajors(TransactionManager transactionManager, decimal admOpenAcadSemId, decimal? asFacultyInfoId, decimal? asCodeDegreeClassId,
            decimal? asCodeDegreeId, decimal? entityMainId, decimal? admAdmissionBandId, decimal? ADM_CDE_APP_TYPE_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmissionRatingMajors", this.UseStoredProcedure);
            if (entityMainId == 0) entityMainId = null;

            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemId", DbType.Decimal, admOpenAcadSemId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId.HasValue ? (object)asFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId.HasValue ? (object)asCodeDegreeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, entityMainId.HasValue ? (object)entityMainId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmAdmissionBandId", DbType.Decimal, admAdmissionBandId.HasValue ? (object)admAdmissionBandId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ADM_CDE_APP_TYPE_ID", DbType.Decimal, ADM_CDE_APP_TYPE_ID.HasValue ? (object)ADM_CDE_APP_TYPE_ID : DBNull.Value);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_RATING_PARAMETERS_MAJORS_ID");
            table.Columns.Add("ADM_OPEN_ACAD_SEMESTER_ID");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("AS_CODE_DEGREE_CLASS_ID");
            table.Columns.Add("ALL_REQUIRED_NUMBERS");
            table.Columns.Add("MALE_NUMBERS");
            table.Columns.Add("FEMALE_NUMBERS");
            table.Columns.Add("ADM_ADMISSION_BAND_ID");
            table.Columns.Add("TRANS_MALE_NUMBERS");
            table.Columns.Add("TRANS_FEMALE_NUMBERS");
            table.Columns.Add("TRANS_ALL_NUMBERS");
            table.Columns.Add("ALL_REQUIRED_NUMBERS_PROV");
            table.Columns.Add("GS_CDE_OPERATOR");
            table.Columns.Add("QUAL_PRCNT");
            table.Columns.Add("EXEMPT_FLG");
          //  table.Columns.Add("MIN_COMPTATIVE_RATE");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("DEGREE_DESCR_AR");
            table.Columns.Add("DEGREE_DESCR_EN");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("bandDescrAr");
            table.Columns.Add("bandDescrEn");
            
           

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
                    object[] items = { 
                                         reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                         reader[4].ToString() , reader[5].ToString() , reader[6].ToString(), reader[7].ToString(),
                                         reader[8].ToString() , reader[9].ToString() , reader[10].ToString(), reader[11].ToString(),
                                         reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(),
                                         reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString(),reader[21].ToString(),reader[22].ToString(),reader[23].ToString(),reader[24].ToString()
                                     };
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