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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EntPolicyAssessHdr"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEntPolicyAssessHdrProvider: SqlEntPolicyAssessHdrProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEntPolicyAssessHdrProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEntPolicyAssessHdrProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override TList<EntPolicyAssessHdr> GetFORCOURSEId(TransactionManager transactionManager, System.Decimal _entMainId, System.Decimal _edcourseid, System.Decimal _entcoursepkghdrId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.POLICY_ASSESS_HDR_GET_BYCOURSE", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edcourseid);
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, _entcoursepkghdrId);

            IDataReader reader = null;
            TList<EntPolicyAssessHdr> rows = new TList<EntPolicyAssessHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetFORCOURSEId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetFORCOURSEId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntPolicyAssessHdr> Get_byStudeSemester_Course(TransactionManager transactionManager, System.Decimal _edstudsemesterid, System.Decimal _edcourseid, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.PolicyAssess_byStudSem_Course", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _edstudsemesterid);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edcourseid);

            IDataReader reader = null;
            TList<EntPolicyAssessHdr> rows = new TList<EntPolicyAssessHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Get_byStudeSemester_Course", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Get_byStudeSemester_Course", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<EntPolicyAssessHdr> Get_bySemester_Course_AcadYear(TransactionManager transactionManager, System.Decimal _asfacultyinfoId, System.Decimal _acadyearid, System.Decimal _edcourseid, System.Decimal _edcodesemesterid, System.Decimal _Major_Id, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.PolicyAssess_bySem_Course_acad", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, _acadyearid);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edcourseid);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _edcodesemesterid);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asfacultyinfoId);

            //kamela,12279
            database.AddInParameter(commandWrapper, "@major_Id", DbType.Decimal, _Major_Id);
            //end
            IDataReader reader = null;
            TList<EntPolicyAssessHdr> rows = new TList<EntPolicyAssessHdr>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Get_bySemester_Course_AcadYear", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Get_bySemester_Course_AcadYear", rows));
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

	}
}