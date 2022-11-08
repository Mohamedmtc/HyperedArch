#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudCourseReg"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudCourseRegProvider: SqlEdStudCourseRegProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudCourseRegProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudCourseRegProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override DataTable GetCourseForCompleteGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, decimal ExamType, decimal Result, decimal ApproveFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "C_GetStdCrsExamForGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolicyAssessHdrId == 0 ? System.DBNull.Value : (object)EntPolicyAssessHdrId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, EdCodeCourseStatusId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.String, EdStudId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@Sort", DbType.Decimal, Sort);
            database.AddInParameter(commandWrapper, "@pageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, SaStfMemberId);
            database.AddInParameter(commandWrapper, "@ExamType", DbType.Decimal, ExamType);
            database.AddInParameter(commandWrapper, "@Result", DbType.Decimal, Result);
            database.AddInParameter(commandWrapper, "@Approved", DbType.Decimal, ApproveFlg);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "C_GetCompleteCourseForGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "C_GetCompleteCourseForGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override bool LoadAcademicPlan(TransactionManager transactionManager,decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadAcademicPlan", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            

            int results = 0;

            //Provider Data Requesting Command Event
          
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
        public override bool Insert_Check(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_Insert_Check", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, entity.EdStudCourseRegId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@RegDate", DbType.DateTime, (entity.RegDate.HasValue ? (object)entity.RegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AuditFlg", DbType.Decimal, entity.AuditFlg);
            database.AddInParameter(commandWrapper, "@RepeatFlg", DbType.Decimal, entity.RepeatFlg);
            database.AddInParameter(commandWrapper, "@IsLast", DbType.Decimal, entity.IsLast);
            //commented by dalia "remove after generation"
            // database.AddInParameter(commandWrapper, "@IsApproved", DbType.Decimal, entity.IsApproved);
           // database.AddInParameter(commandWrapper, "@ApproveDate", DbType.DateTime, (entity.ApproveDate.HasValue ? (object)entity.ApproveDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, (entity.EdCodeCourseStatusId.HasValue ? (object)entity.EdCodeCourseStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseDegree", DbType.Decimal, (entity.CourseDegree.HasValue ? (object)entity.CourseDegree : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CoursePoint", DbType.Decimal, (entity.CoursePoint.HasValue ? (object)entity.CoursePoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntPolicyGradingHdrId", DbType.Decimal, (entity.EntPolicyGradingHdrId.HasValue ? (object)entity.EntPolicyGradingHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodePassFailId", DbType.Decimal, (entity.GsCodePassFailId.HasValue ? (object)entity.GsCodePassFailId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, entity.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@AddGpaFlg", DbType.Decimal, entity.AddGpaFlg);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, (entity.EntPolicyAssessHdrId.HasValue ? (object)entity.EntPolicyAssessHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IncompFlg", DbType.Decimal, entity.IncompFlg);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert_IfFull", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalEdStudCourseRegId = entity.EdStudCourseRegId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert_IfFull", entity));

            return Convert.ToBoolean(results);
        }
        public override bool Insert_JustAddNewRowGroupReg(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity, UMIS_VER2.BusinessLyer.EdStudGroup entityGroup)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_OriginalInsert_GroupReg", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@RegDate", DbType.DateTime, (entity.RegDate.HasValue ? (object)entity.RegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AuditFlg", DbType.Decimal, entity.AuditFlg);
            database.AddInParameter(commandWrapper, "@RepeatFlg", DbType.Decimal, entity.RepeatFlg);
            database.AddInParameter(commandWrapper, "@IsLast", DbType.Decimal, entity.IsLast);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, (entity.EdCodeCourseStatusId.HasValue ? (object)entity.EdCodeCourseStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseDegree", DbType.Decimal, (entity.CourseDegree.HasValue ? (object)entity.CourseDegree : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CoursePoint", DbType.Decimal, (entity.CoursePoint.HasValue ? (object)entity.CoursePoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntPolicyGradingHdrId", DbType.Decimal, (entity.EntPolicyGradingHdrId.HasValue ? (object)entity.EntPolicyGradingHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodePassFailId", DbType.Decimal, (entity.GsCodePassFailId.HasValue ? (object)entity.GsCodePassFailId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, entity.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@AddGpaFlg", DbType.Decimal, entity.AddGpaFlg);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, (entity.EntPolicyAssessHdrId.HasValue ? (object)entity.EntPolicyAssessHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IncompFlg", DbType.Decimal, entity.IncompFlg);
            database.AddInParameter(commandWrapper, "@HideFlg", DbType.Decimal, entity.HideFlg);
            database.AddInParameter(commandWrapper, "@HideReason", DbType.String, entity.HideReason);
            database.AddInParameter(commandWrapper, "@EdCourseSubId", DbType.Decimal, (entity.EdCourseSubId.HasValue ? (object)entity.EdCourseSubId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsResultApproved", DbType.Decimal, (entity.IsResultApproved.HasValue ? (object)entity.IsResultApproved : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@RepeatNo", DbType.Decimal, (entity.RepeatNo.HasValue ? (object)entity.RepeatNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, (entity.PayFlg.HasValue ? (object)entity.PayFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayAmount", DbType.Decimal, (entity.PayAmount.HasValue ? (object)entity.PayAmount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AbsFlg", DbType.Decimal, (entity.AbsFlg.HasValue ? (object)entity.AbsFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ReceiptNo", DbType.String, entity.ReceiptNo);
            database.AddInParameter(commandWrapper, "@ReceiptDate", DbType.DateTime, (entity.ReceiptDate.HasValue ? (object)entity.ReceiptDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ByforceFlg", DbType.Decimal, (entity.ByforceFlg.HasValue ? (object)entity.ByforceFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeCrsRegTypeId", DbType.Decimal, (entity.EdCdeCrsRegTypeId.HasValue ? (object)entity.EdCdeCrsRegTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCoursePkgDtlId", DbType.Decimal, (entity.EntCoursePkgDtlId.HasValue ? (object)entity.EntCoursePkgDtlId : System.DBNull.Value));
            database.AddOutParameter(commandWrapper, "@EdStudGroupId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, entityGroup.ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyId", DbType.Decimal, (entityGroup.AsFacultyInfoId.HasValue ? (object)entityGroup.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemId", DbType.Decimal, entityGroup.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseRegId", DbType.Decimal, entityGroup.EdStudCourseRegId);
            database.AddInParameter(commandWrapper, "@WaitNo", DbType.Decimal, (entityGroup.WaitNo.HasValue ? (object)entityGroup.WaitNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@WaitReqDate", DbType.DateTime, (entityGroup.WaitReqDate.HasValue ? (object)entityGroup.WaitReqDate : System.DBNull.Value));
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert_JustAddNewRowGroupReg", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.EdStudCourseRegId = decimal.Parse(commandWrapper.Parameters["@EdStudCourseRegId"].Value.ToString());
            entity.OriginalEdStudCourseRegId = entity.EdStudCourseRegId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert_JustAddNewRowGroupReg", entity));

            return Convert.ToBoolean(results);
        }

        //Esraa Ali         8-7-2019           10194
        public override bool UpdateStudentCourseFA(TransactionManager transactionManager, decimal AsFacultyInfoId, decimal EdAcadYearId, decimal EdCodeSemesterId, decimal EdCourseId, decimal StudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.UpdateStudentCourseFA", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId",  DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@StudID", DbType.Decimal, StudID);
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

        public override bool INSERT_STD_CRS_REG_PLN_SEC(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudGroup entityGroup)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INSERT_STD_CRS_REG_PLN_SEC", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudGroupId", DbType.Decimal,9);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, entityGroup.ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyId", DbType.Decimal, (entityGroup.AsFacultyInfoId.HasValue ? (object)entityGroup.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemId", DbType.Decimal, entityGroup.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, entityGroup.EdStudCourseRegId);
            database.AddInParameter(commandWrapper, "@WaitNo", DbType.Decimal, (entityGroup.WaitNo.HasValue ? (object)entityGroup.WaitNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@WaitReqDate", DbType.DateTime, (entityGroup.WaitReqDate.HasValue ? (object)entityGroup.WaitReqDate : System.DBNull.Value));
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "INSERT_STD_CRS_REG_PLN_SEC", entityGroup));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //entityGroup.EdStudGroupId = decimal.Parse(commandWrapper.Parameters["@EdStudGroupId"].Value.ToString());
            entityGroup.OriginalEdStudGroupId = entityGroup.EdStudCourseRegId;

            entityGroup.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "INSERT_STD_CRS_REG_PLN_SEC", entityGroup));

            return Convert.ToBoolean(results);
        }
        public override bool Insert_JustAddNewRow(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_OriginalInsert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@RegDate", DbType.DateTime, (entity.RegDate.HasValue ? (object)entity.RegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AuditFlg", DbType.Decimal, entity.AuditFlg);
            database.AddInParameter(commandWrapper, "@RepeatFlg", DbType.Decimal, entity.RepeatFlg);
            database.AddInParameter(commandWrapper, "@IsLast", DbType.Decimal, entity.IsLast);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, (entity.EdCodeCourseStatusId.HasValue ? (object)entity.EdCodeCourseStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseDegree", DbType.Decimal, (entity.CourseDegree.HasValue ? (object)entity.CourseDegree : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CoursePoint", DbType.Decimal, (entity.CoursePoint.HasValue ? (object)entity.CoursePoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntPolicyGradingHdrId", DbType.Decimal, (entity.EntPolicyGradingHdrId.HasValue ? (object)entity.EntPolicyGradingHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodePassFailId", DbType.Decimal, (entity.GsCodePassFailId.HasValue ? (object)entity.GsCodePassFailId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, entity.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@AddGpaFlg", DbType.Decimal, entity.AddGpaFlg);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, (entity.EntPolicyAssessHdrId.HasValue ? (object)entity.EntPolicyAssessHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IncompFlg", DbType.Decimal, entity.IncompFlg);
            database.AddInParameter(commandWrapper, "@HideFlg", DbType.Decimal, entity.HideFlg);
            database.AddInParameter(commandWrapper, "@HideReason", DbType.String, entity.HideReason);
            database.AddInParameter(commandWrapper, "@EdCourseSubId", DbType.Decimal, (entity.EdCourseSubId.HasValue ? (object)entity.EdCourseSubId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsResultApproved", DbType.Decimal, (entity.IsResultApproved.HasValue ? (object)entity.IsResultApproved : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@RepeatNo", DbType.Decimal, (entity.RepeatNo.HasValue ? (object)entity.RepeatNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, (entity.PayFlg.HasValue ? (object)entity.PayFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayAmount", DbType.Decimal, (entity.PayAmount.HasValue ? (object)entity.PayAmount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AbsFlg", DbType.Decimal, (entity.AbsFlg.HasValue ? (object)entity.AbsFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ReceiptNo", DbType.String, entity.ReceiptNo);
            database.AddInParameter(commandWrapper, "@ReceiptDate", DbType.DateTime, (entity.ReceiptDate.HasValue ? (object)entity.ReceiptDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ByforceFlg", DbType.Decimal, (entity.ByforceFlg.HasValue ? (object)entity.ByforceFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeCrsRegTypeId", DbType.Decimal, (entity.EdCdeCrsRegTypeId.HasValue ? (object)entity.EdCdeCrsRegTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCoursePkgDtlId", DbType.Decimal, (entity.EntCoursePkgDtlId.HasValue ? (object)entity.EntCoursePkgDtlId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
			
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert_JustAddNewRow", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.EdStudCourseRegId = decimal.Parse(commandWrapper.Parameters["@EdStudCourseRegId"].Value.ToString());
            entity.OriginalEdStudCourseRegId = entity.EdStudCourseRegId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert_JustAddNewRow", entity));

            return Convert.ToBoolean(results);
        }

        // added by ashwaa bug 1935
        public override decimal InsertEdStudCourseReg(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseReg entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_OriginalInsert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@RegDate", DbType.DateTime, (entity.RegDate.HasValue ? (object)entity.RegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AuditFlg", DbType.Decimal, entity.AuditFlg);
            database.AddInParameter(commandWrapper, "@RepeatFlg", DbType.Decimal, entity.RepeatFlg);
            database.AddInParameter(commandWrapper, "@IsLast", DbType.Decimal, entity.IsLast);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, (entity.EdCodeCourseStatusId.HasValue ? (object)entity.EdCodeCourseStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeGradingId", DbType.Decimal, (entity.EdCodeGradingId.HasValue ? (object)entity.EdCodeGradingId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseDegree", DbType.Decimal, (entity.CourseDegree.HasValue ? (object)entity.CourseDegree : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CoursePoint", DbType.Decimal, (entity.CoursePoint.HasValue ? (object)entity.CoursePoint : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntPolicyGradingHdrId", DbType.Decimal, (entity.EntPolicyGradingHdrId.HasValue ? (object)entity.EntPolicyGradingHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodePassFailId", DbType.Decimal, (entity.GsCodePassFailId.HasValue ? (object)entity.GsCodePassFailId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, entity.EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@AddGpaFlg", DbType.Decimal, entity.AddGpaFlg);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, (entity.EntPolicyAssessHdrId.HasValue ? (object)entity.EntPolicyAssessHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IncompFlg", DbType.Decimal, entity.IncompFlg);
            database.AddInParameter(commandWrapper, "@HideFlg", DbType.Decimal, entity.HideFlg);
            database.AddInParameter(commandWrapper, "@HideReason", DbType.String, entity.HideReason);
            database.AddInParameter(commandWrapper, "@EdCourseSubId", DbType.Decimal, (entity.EdCourseSubId.HasValue ? (object)entity.EdCourseSubId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsResultApproved", DbType.Decimal, (entity.IsResultApproved.HasValue ? (object)entity.IsResultApproved : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@RepeatNo", DbType.Decimal, (entity.RepeatNo.HasValue ? (object)entity.RepeatNo : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, (entity.PayFlg.HasValue ? (object)entity.PayFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PayAmount", DbType.Decimal, (entity.PayAmount.HasValue ? (object)entity.PayAmount : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AbsFlg", DbType.Decimal, (entity.AbsFlg.HasValue ? (object)entity.AbsFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ReceiptNo", DbType.String, entity.ReceiptNo);
            database.AddInParameter(commandWrapper, "@ReceiptDate", DbType.DateTime, (entity.ReceiptDate.HasValue ? (object)entity.ReceiptDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ByforceFlg", DbType.Decimal, (entity.ByforceFlg.HasValue ? (object)entity.ByforceFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeCrsRegTypeId", DbType.Decimal, (entity.EdCdeCrsRegTypeId.HasValue ? (object)entity.EdCdeCrsRegTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EntCoursePkgDtlId", DbType.Decimal, (entity.EntCoursePkgDtlId.HasValue ? (object)entity.EntCoursePkgDtlId : System.DBNull.Value));
			
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert_JustAddNewRow", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.EdStudCourseRegId = decimal.Parse(commandWrapper.Parameters["@EdStudCourseRegId"].Value.ToString());
            entity.OriginalEdStudCourseRegId = entity.EdStudCourseRegId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert_JustAddNewRow", entity));

            return entity.EdStudCourseRegId;
        }	

        public override decimal GetTotalCrForSem(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, int _DisplayText)
        {
            decimal TotalCrNo = 0;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetTotalCrForSem", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            IDataReader reader = null;
            TList<EntityMain> tmp = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetTotalCrForSem", tmp));

                if (transactionManager != null)
                {
                    if (Utility.ExecuteScalar(transactionManager, commandWrapper) != null)
                        TotalCrNo = (decimal)Utility.ExecuteScalar(transactionManager, commandWrapper);
                }
                else
                {
                    if (Utility.ExecuteScalar(database, commandWrapper) != null)
                        TotalCrNo = (decimal)Utility.ExecuteScalar(database, commandWrapper);
                }


                OnDataRequested(new CommandEventArgs(commandWrapper, "GetTotalCrForSem", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return TotalCrNo;
        }

        public override TList<EdStudCourseReg> GetStudRegisteredCourses(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AsFacultyInfoId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StudRegisteredCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            TList<EdStudCourseReg> rows = new TList<EdStudCourseReg>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "StudRegisteredCourses", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudRegisteredCourses", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }



        public override TList<EdStudCourseReg> GetByEdcourseIDAndEdstudIDRPLC(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _EdCourseId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_GetByEdcourseIDAndEdstudIDRPLC", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);

            IDataReader reader = null;
            TList<EdStudCourseReg> rows = new TList<EdStudCourseReg>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_COURSE_REG_GetByEdcourseIDAndEdstudIDRPLC", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "ED_STUD_COURSE_REG_GetByEdcourseIDAndEdstudIDRPLC", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }



        public override TList<EdStudCourseReg> GetByStudAndCourseString(TransactionManager transactionManager, System.Decimal _EdStudId, System.String _CourseString, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByStudAndCourseString_C_Reg", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@CourseString", DbType.String, _CourseString);

            IDataReader reader = null;
            TList<EdStudCourseReg> rows = new TList<EdStudCourseReg>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByStudAndCourseString_C_Reg", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByStudAndCourseString_C_Reg", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override decimal BatchCourseRegistration(TransactionManager transactionManager, string StudCode, string CourseCode, string YearCalendar, string SemesterDescrEn, string IsRepeated, string CourseStatus, string Grading, string CourseDegree, string Coursepoints,decimal SeUserId,decimal SeFormId,DateTime LastDate)
        {
            decimal TotalCrNo = 0;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.BatchCourseRegistration", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, CourseCode);
            database.AddInParameter(commandWrapper, "@YearCalendar", DbType.String, YearCalendar);
            database.AddInParameter(commandWrapper, "@SemesterDescrEn", DbType.String, SemesterDescrEn);
            database.AddInParameter(commandWrapper, "@IsRepeated", DbType.String, IsRepeated);
            database.AddInParameter(commandWrapper, "@CourseStatus", DbType.String, CourseStatus);
            database.AddInParameter(commandWrapper, "@Grading", DbType.String, Grading);
            if (CourseDegree == "")
                CourseDegree = "0";
            if (Coursepoints == "")
                Coursepoints = "0";
            database.AddInParameter(commandWrapper, "@CourseDegree", DbType.Decimal, CourseDegree);
            database.AddInParameter(commandWrapper, "@Coursepoints", DbType.Decimal, Coursepoints);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, SeFormId);
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, LastDate);
            IDataReader reader = null;
            TList<EntityMain> tmp = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetTotalCrForSem", tmp));

                if (transactionManager != null)
                {
                    if (Utility.ExecuteScalar(transactionManager, commandWrapper) != null)
                        TotalCrNo = (decimal)Utility.ExecuteScalar(transactionManager, commandWrapper);
                }
                else
                {
                    if (Utility.ExecuteScalar(database, commandWrapper) != null)
                        TotalCrNo = (decimal)Utility.ExecuteScalar(database, commandWrapper);
                }


                OnDataRequested(new CommandEventArgs(commandWrapper, "GetTotalCrForSem", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return TotalCrNo;
        }

        public override void SetIncompleteFlg(TransactionManager transactionManager, System.Decimal _EdStudCourseRegId, decimal SeUserId, decimal SeFormId, DateTime LastDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_SetIncomplete", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, _EdStudCourseRegId);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, SeFormId);
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, LastDate);
            IDataReader reader = null;
            TList<EntityMain> tmp = new TList<EntityMain>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SetIncompleteFlg", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }


                OnDataRequested(new CommandEventArgs(commandWrapper, "SetIncompleteFlg", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
        }
        // Updated by Hsabry for Paging
        public override DataTable GetCourseForGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.String StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null, System.Decimal? EdCodeLevelId = null, decimal? EntDeptId = null, decimal? AsCodeDegreeClassID = 0, decimal? GenderId = null,string MotherID =null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseForGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolicyAssessHdrId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, EdCodeCourseStatusId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.String, EdStudId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@Sort", DbType.Decimal, Sort);
            database.AddInParameter(commandWrapper, "@pageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CurrentRecordFlg", DbType.Decimal, CurrentRecordFlg);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);
            //Bug4041
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, MajorID);
            if (GroupID != null)
                database.AddInParameter(commandWrapper, "@GroupID", DbType.Decimal, GroupID);

            if (MinorId.HasValue)
                database.AddInParameter(commandWrapper, "@MinorId", DbType.Decimal, MinorId);
            if (EdCodeLevelId.HasValue) // Added by MElshazly 19/6/2021 [16751]
                database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId); // Added by MElshazly 19/6/2021 [16751]
            if (EntDeptId.HasValue) // 16366, send dept 
                database.AddInParameter(commandWrapper, "@EntDeptId", DbType.Decimal, EntDeptId);
            if (AsCodeDegreeClassID.HasValue)
                database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, AsCodeDegreeClassID);
            if(GenderId.HasValue)
                database.AddInParameter(commandWrapper, "@GenderId", DbType.Decimal, GenderId);
         

            database.AddInParameter(commandWrapper, "@MotherID", DbType.String, MotherID);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetCourseForGradingSecretNo(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.Decimal Lang, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal SeUserId, System.Decimal SecretNoFrom, System.Decimal SecretNoTo, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null, System.Decimal? EdCodeLevelId = null, decimal? AsCodeDegreeClassID = 0)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseForGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolicyAssessHdrId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, EdCodeCourseStatusId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@pageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, SaStfMemberId);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);
            //Bug4041
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, MajorID);
            if (GroupID != null)
                database.AddInParameter(commandWrapper, "@GroupID", DbType.Decimal, GroupID);
            if (MinorId.HasValue)
                database.AddInParameter(commandWrapper, "@MinorId", DbType.Decimal, MinorId);
            database.AddInParameter(commandWrapper, "@SecretNoFrom", DbType.Decimal, SecretNoFrom);
            database.AddInParameter(commandWrapper, "@SecretNoTo", DbType.Decimal, SecretNoTo);
            if (EdCodeLevelId.HasValue) // Added by MElshazly 19/6/2021 [16751]
                database.AddInParameter(commandWrapper, "@EdCodeLevelId", DbType.Decimal, EdCodeLevelId); // Added by MElshazly 19/6/2021 [16751]
            if (AsCodeDegreeClassID.HasValue)
                database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, AsCodeDegreeClassID);


            DataTable dt = null;
            try
            {
                if (transactionManager != null)
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                else
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseForGradingSecretNo"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetCourseForGradingBarCode(TransactionManager transactionManager, System.Decimal EdCodeSemesterId,   System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String BarCodeId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseForGradingBarCode", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolicyAssessHdrId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, EdCodeCourseStatusId);
            database.AddInParameter(commandWrapper, "@BarCodeId", DbType.String, BarCodeId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@Sort", DbType.Decimal, Sort);
            database.AddInParameter(commandWrapper, "@pageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CurrentRecordFlg", DbType.Decimal, CurrentRecordFlg);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);
            //Bug4041
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, MajorID);
           
            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }



        public override DataTable GetStudCourseForGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdStudId, System.Decimal CoControlRoomId, System.Decimal AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudCourseForGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, EdStudId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@CoControlRoomId", DbType.Decimal, CoControlRoomId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudCourseForGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudCourseForGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetCourseRegStatistics(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID,
                                    System.Decimal EdCourseId, System.Decimal EdCourseSubId, decimal AsCodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCourseRegStatistics", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCourseSubId", DbType.Decimal, EdCourseSubId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override int GetMaxRegCourses(TransactionManager transactionManager, decimal edAcadYearId, decimal asFacultyInfoId, decimal edCodeLevelId, decimal edCodeSemesterId, decimal entMainId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_REG_GetMaxRegCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ED_CODE_LEVEL_ID", DbType.Decimal, edCodeLevelId);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, entMainId);

            int result = 0;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetMaxRegCourses"));

                if (transactionManager != null)
                {
                    result = Convert.ToInt32(Utility.ExecuteScalar(transactionManager, commandWrapper));
                }
                else
                {
                    result = Convert.ToInt32(Utility.ExecuteScalar(database, commandWrapper));
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetMaxRegCourses"));
            }
            finally
            {
                commandWrapper = null;
            }
            return result;
        }
        public override DataTable GetStudsForCourseResultApprove(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal? AsFacultyInfoId, System.Decimal? ScScheduleDtlId, System.Decimal ApproveFlg,decimal? AsCodeDegreeClassId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudsForCourseResultApproveBySection", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? AsFacultyInfoId : 0);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId.HasValue ? ScScheduleDtlId : 0);
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, ApproveFlg);
            if (AsCodeDegreeClassId != null)
                database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);
            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudsForCourseResultApprove"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudsForCourseResultApprove"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override void ApproveCancelStudsCourseResult(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal? AsFacultyInfoId, System.Decimal? ScScheduleDtlId, System.Decimal ApproveFlg, System.Decimal ApproveUsrID, System.DateTime ApproveDate, System.Decimal EdCdeExamTypeId, string APPROVE_DEST, string lang, decimal? AsCodeDegreeClassId=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApproveCancelStudsCourseResultBySection", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? AsFacultyInfoId : 0);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId.HasValue ? ScScheduleDtlId : 0);
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, ApproveFlg);
            database.AddInParameter(commandWrapper, "@ApproveUsrID", DbType.Decimal, ApproveUsrID);
            database.AddInParameter(commandWrapper, "@ApproveDate", DbType.DateTime, ApproveDate);
            if (AsCodeDegreeClassId!=null)
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, AsCodeDegreeClassId);

            //database.AddInParameter(commandWrapper, "@EdCdeExamTypeId", DbType.Decimal, EdCdeExamTypeId);
            //database.AddInParameter(commandWrapper, "@APPROVE_DEST", DbType.String, APPROVE_DEST);
            //database.AddInParameter(commandWrapper, "@lang", DbType.String, lang);


            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "ApproveCancelStudsCourseResult"));

                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "ApproveCancelStudsCourseResult"));
            }
            finally
            {
                commandWrapper = null;
            }
        }

        public override DataTable GetStudentRegisterdCoursesAndSections(TransactionManager transactionManager, System.Decimal EdStudSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentRegisterdCoursesAndSections", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_STUD_SEMESTER_ID", DbType.Decimal, EdStudSemesterId);
            
            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentRegisterdCoursesAndSections"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentRegisterdCoursesAndSections"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetStudentRegisterdCoursesAndSections(TransactionManager transactionManager, System.Decimal EdStudSemesterId, decimal ED_CODE_COURSE_STATUS_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentRegisterdCoursesAndSections", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_STUD_SEMESTER_ID", DbType.Decimal, EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@ED_CODE_COURSE_STATUS_ID", DbType.Decimal, ED_CODE_COURSE_STATUS_ID);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentRegisterdCoursesAndSections"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentRegisterdCoursesAndSections"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }

        public override DataTable GetStudentEarlyRegisterdCoursesAndSections(TransactionManager transactionManager, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentEarlyRegisterdCoursesAndSections", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, EdCodeSemId);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@Ed_Stud_Id", DbType.Decimal, EdStudId);
            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentEarlyRegisterdCoursesAndSections"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentEarlyRegisterdCoursesAndSections"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        public override void DeleteStudentsWaitingList(TransactionManager transactionManager, System.Decimal EdCodeSemId, System.Decimal EdAcadYearId, System.Decimal EdCourseId, System.Decimal EntMainId, System.Decimal AsFacultyInfoId, System.Decimal ScScheduleDtlId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.WaitingListDestroy", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@edCodeSemId", DbType.Decimal, EdCodeSemId);
            database.AddInParameter(commandWrapper, "@edAcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@edCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "DeleteStudentsWaitingList"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "DeleteStudentsWaitingList"));

            commandWrapper = null;
        }//end Delete

        /*-----task 15508 --- maha ---21-12-2020-----*/
        public override TList<EdStudCourseReg> GetStudCourseRegForGrading(TransactionManager transactionManager, System.Decimal EdAcadYearId, System.String StudCode, decimal EdCodeSemesterId, decimal CourseId, int start, int pageLength)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudCourseRegForGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, StudCode);
            database.AddInParameter(commandWrapper, "@CourseId", DbType.Decimal, CourseId);
            database.AddInParameter(commandWrapper, "@AcadYearId", DbType.Decimal, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            //database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolcyAssessHdrId);
            IDataReader reader = null;
            TList<EdStudCourseReg> rows = new TList<EdStudCourseReg>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudCourseRegForGrading", rows));

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
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudCourseRegForGrading", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override DataTable GetStudCoursesReg_byAcadYearSem(TransactionManager transactionManager, decimal EdAcadYear, decimal EdCodeSem, decimal? AsFacultyInfo,
                          decimal? EntMainId, decimal? onlineFlg, decimal? edCodeCourseId, decimal ExamTypeId , decimal CodeDegreeClassId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudCourseRegData", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, EdCodeSem);
            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, EdAcadYear);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, AsFacultyInfo.HasValue ? (object)AsFacultyInfo.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, EntMainId.HasValue ? (object)EntMainId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OnLineFlg", DbType.Decimal, onlineFlg.HasValue ? (object)onlineFlg.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, edCodeCourseId.HasValue ? (object)edCodeCourseId.Value : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ExamTypeId", DbType.Decimal, ExamTypeId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, CodeDegreeClassId);
            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseForGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }
        /*------ task 16788 --  maha ---*/
        public override DataTable GetCourseForMidTermGrading(TransactionManager transactionManager, System.Decimal EdCodeSemesterId, System.String StudName, System.Decimal EdAcadYearID, System.Decimal EdCourseId, System.Decimal EntPolicyAssessHdrId, System.Decimal ScScheduleDtlId, System.Decimal AsFacultyInfoId, System.Decimal EdCodeCourseStatusId, System.String EdStudId, System.Decimal Lang, System.Decimal Sort, System.Decimal PageIndex, System.Decimal PageSize, System.Decimal SaStfMemberId, System.Decimal CurrentRecordFlg, System.Decimal SeUserId, System.Decimal? MajorID = null, int? GroupID = null, System.Decimal? MinorId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetCourseForMidTermGrading", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, EdCourseId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@StudClFullName", DbType.String, StudName);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EntPolicyAssessHdrId", DbType.Decimal, EntPolicyAssessHdrId);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlId", DbType.Decimal, ScScheduleDtlId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStatusId", DbType.Decimal, EdCodeCourseStatusId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.String, EdStudId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, Lang);
            database.AddInParameter(commandWrapper, "@Sort", DbType.Decimal, Sort);
            database.AddInParameter(commandWrapper, "@pageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, SaStfMemberId);
            database.AddInParameter(commandWrapper, "@CurrentRecordFlg", DbType.Decimal, CurrentRecordFlg);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUserId);
            //Bug4041
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, MajorID);
            if (GroupID != null)
                database.AddInParameter(commandWrapper, "@GroupID", DbType.Decimal, GroupID);

            if (MinorId.HasValue)
                database.AddInParameter(commandWrapper, "@MinorId", DbType.Decimal, MinorId);

            DataTable dt = null;
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCourseForMidTermGrading"));

                if (transactionManager != null)
                {
                    dt = Utility.ExecuteDataSet(transactionManager, commandWrapper).Tables[0];
                }
                else
                {
                    dt = Utility.ExecuteDataSet(database, commandWrapper).Tables[0];
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCourseForMidTermGrading"));
            }
            finally
            {
                commandWrapper = null;
            }
            return dt;
        }


        #endregion
	}
}