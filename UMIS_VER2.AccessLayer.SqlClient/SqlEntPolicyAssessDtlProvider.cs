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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntPolicyAssessDtl"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntPolicyAssessDtlProvider: SqlEntPolicyAssessDtlProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntPolicyAssessDtlProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntPolicyAssessDtlProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }
        public override DataTable EntPolicyAssessDtlGetbyEntPolicyAssessHdrId(TransactionManager transactionManager, System.Decimal _EntPolicyAssessHdrId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ENT_POLICY_ASSESS_DTL_GetAllByEntPolicyAssessHdrId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, _EntPolicyAssessHdrId);

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
        //added by esraa yousef 23-3-2021 for suez to display export and import fro staff member according call from eng /mohamed tarek  to get only assess that can access on it 
        public override TList<EntPolicyAssessDtl> GetEntPolicyAssessDtlForStaffMember(TransactionManager trans, System.Decimal _FacultyId, System.Decimal _AssessHdrId, System.Decimal _CourseId, System.Decimal _EdCodeSemeterId, System.Decimal _AcadYearId , System.Decimal _UserId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetEntPolicyAssessDtlForStaffMember",this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AssessHdrId", DbType.Decimal, _AssessHdrId);
            database.AddInParameter(commandWrapper, "@CourseId", DbType.Decimal, _CourseId);
            database.AddInParameter(commandWrapper, "@EdCodeSemeterId", DbType.Decimal, _EdCodeSemeterId);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _AcadYearId);
            database.AddInParameter(commandWrapper, "@FacultyId", DbType.Decimal, _FacultyId);
            database.AddInParameter(commandWrapper, "@UserId", DbType.Decimal, _UserId);
            IDataReader reader = null;
            TList<EntPolicyAssessDtl> tmp = new TList<EntPolicyAssessDtl>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetEntPolicyAssessDtlForStaffMember", tmp));

                if (trans != null)
                {
                    reader = Utility.ExecuteReader(trans, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int count = 0;
                //Create collection and fill
                Fill(reader, tmp, 0, int.MaxValue);
         

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetEntPolicyAssessDtlForStaffMember", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;
			
        }
    
    }
}