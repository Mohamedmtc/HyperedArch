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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudQual"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudQualProvider: SqlEdStudQualProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudQualProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudQualProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures
       
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQual entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_STUD_QUAL_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudQualId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeQualId", DbType.Decimal, entity.EdCodeQualId);
            database.AddInParameter(commandWrapper, "@SchoolName", DbType.String, entity.SchoolName);
            database.AddInParameter(commandWrapper, "@QualDate", DbType.DateTime, (entity.QualDate.HasValue ? (object)entity.QualDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualTotMark", DbType.Decimal, (entity.QualTotMark.HasValue ? (object)entity.QualTotMark : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, (entity.TotalDegree.HasValue ? (object)entity.TotalDegree : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, entity.TotalPercent);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualBrnId", DbType.Decimal, (entity.EdCdeQualBrnId.HasValue ? (object)entity.EdCdeQualBrnId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdeSchoolId", DbType.Decimal, (entity.GsCdeSchoolId.HasValue ? (object)entity.GsCdeSchoolId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudSeatNum", DbType.Decimal, (entity.StudSeatNum.HasValue ? (object)entity.StudSeatNum : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, (entity.EnglishPercent.HasValue ? (object)entity.EnglishPercent : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ConvertedPercent", DbType.Decimal, (entity.ConvertedPercent.HasValue ? (object)entity.ConvertedPercent : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualCatId", DbType.Decimal, (entity.EdCdeQualCatId.HasValue ? (object)entity.EdCdeQualCatId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmissionFlg", DbType.Decimal, entity.AdmissionFlg);
            database.AddInParameter(commandWrapper, "@GsCdeUniversitiesId", DbType.Decimal, (entity.GsCdeUniversitiesId.HasValue ? (object)entity.GsCdeUniversitiesId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Tofel", DbType.Decimal, (entity.Tofel.HasValue ? (object)entity.Tofel : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Cgpa", DbType.Decimal, (entity.Cgpa.HasValue ? (object)entity.Cgpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualRank", DbType.Int32, (entity.QualRank.HasValue ? (object)entity.QualRank : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualPhase", DbType.Decimal, (entity.EdCdeQualPhase.HasValue ? (object)entity.EdCdeQualPhase : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualStatusId", DbType.Int32, (entity.EdCdeQualStatusId.HasValue ? (object)entity.EdCdeQualStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualStartDate", DbType.DateTime, (entity.QualStartDate.HasValue ? (object)entity.QualStartDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, (entity.GsCodeLanguageId.HasValue ? (object)entity.GsCodeLanguageId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmAppRegHistoryId", DbType.Decimal, (entity.AdmAppRegHistoryId.HasValue ? (object)entity.AdmAppRegHistoryId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmCdeExamGrdngId", DbType.Decimal, (entity.AdmCdeExamGrdngId.HasValue ? (object)entity.AdmCdeExamGrdngId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualDescEn", DbType.String, entity.QualDescEn);
            database.AddInParameter(commandWrapper, "@QualBrnDescEn", DbType.String, entity.QualBrnDescEn);
            database.AddInParameter(commandWrapper, "@GsCdeSchoolTypeId", DbType.Int32, (entity.GsCdeSchoolTypeId.HasValue ? (object)entity.GsCdeSchoolTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmCdeQualStatusID", DbType.Int32, (entity.AdmCdeQualStatusId.HasValue ? (object)entity.AdmCdeQualStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualRsltUsr", DbType.String, entity.QualRsltUsr); // MElshazly 3/9/2020 [14543]
            database.AddInParameter(commandWrapper, "@QualRsltPwd", DbType.String, entity.QualRsltPwd); // MElshazly 3/9/2020 [14543]
            database.AddInParameter(commandWrapper, "@GsCdeFacultyId", DbType.Decimal, (entity.GsCdeFacultyId.HasValue ? (object)entity.GsCdeFacultyId : System.DBNull.Value)); //added by olivia 15/4/2021 for ejust pg
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);//added by hoda at 8/6/2022 for eue

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            object _edStudQualId = database.GetParameterValue(commandWrapper, "@EdStudQualId");
            entity.EdStudQualId = (System.Decimal)_edStudQualId;

            entity.OriginalEdStudQualId = entity.EdStudQualId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudQual entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_STUD_QUAL_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudQualId", DbType.Decimal, entity.EdStudQualId);
            database.AddInParameter(commandWrapper, "@OriginalEdStudQualId", DbType.Decimal, entity.OriginalEdStudQualId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCodeQualId", DbType.Decimal, entity.EdCodeQualId);
            database.AddInParameter(commandWrapper, "@SchoolName", DbType.String, entity.SchoolName);
            database.AddInParameter(commandWrapper, "@QualDate", DbType.DateTime, (entity.QualDate.HasValue ? (object)entity.QualDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualTotMark", DbType.Decimal, (entity.QualTotMark.HasValue ? (object)entity.QualTotMark : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, (entity.TotalDegree.HasValue ? (object)entity.TotalDegree : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, entity.TotalPercent);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, (entity.AdmApplicantId.HasValue ? (object)entity.AdmApplicantId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualBrnId", DbType.Decimal, (entity.EdCdeQualBrnId.HasValue ? (object)entity.EdCdeQualBrnId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCdeSchoolId", DbType.Decimal, (entity.GsCdeSchoolId.HasValue ? (object)entity.GsCdeSchoolId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StudSeatNum", DbType.Decimal, (entity.StudSeatNum.HasValue ? (object)entity.StudSeatNum : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, (entity.EnglishPercent.HasValue ? (object)entity.EnglishPercent : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ConvertedPercent", DbType.Decimal, (entity.ConvertedPercent.HasValue ? (object)entity.ConvertedPercent : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualCatId", DbType.Decimal, (entity.EdCdeQualCatId.HasValue ? (object)entity.EdCdeQualCatId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmissionFlg", DbType.Decimal, entity.AdmissionFlg);
            database.AddInParameter(commandWrapper, "@GsCdeUniversitiesId", DbType.Decimal, (entity.GsCdeUniversitiesId.HasValue ? (object)entity.GsCdeUniversitiesId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Tofel", DbType.Decimal, (entity.Tofel.HasValue ? (object)entity.Tofel : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Cgpa", DbType.Decimal, (entity.Cgpa.HasValue ? (object)entity.Cgpa : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualRank", DbType.Int32, (entity.QualRank.HasValue ? (object)entity.QualRank : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualPhase", DbType.Decimal, (entity.EdCdeQualPhase.HasValue ? (object)entity.EdCdeQualPhase : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeQualStatusId", DbType.Int32, (entity.EdCdeQualStatusId.HasValue ? (object)entity.EdCdeQualStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualStartDate", DbType.DateTime, (entity.QualStartDate.HasValue ? (object)entity.QualStartDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, (entity.GsCodeLanguageId.HasValue ? (object)entity.GsCodeLanguageId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmAppRegHistoryId", DbType.Decimal, (entity.AdmAppRegHistoryId.HasValue ? (object)entity.AdmAppRegHistoryId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmCdeExamGrdngId", DbType.Decimal, (entity.AdmCdeExamGrdngId.HasValue ? (object)entity.AdmCdeExamGrdngId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualDescEn", DbType.String, entity.QualDescEn);
            database.AddInParameter(commandWrapper, "@QualBrnDescEn", DbType.String, entity.QualBrnDescEn);
            database.AddInParameter(commandWrapper, "@GsCdeSchoolTypeId", DbType.Int32, (entity.GsCdeSchoolTypeId.HasValue ? (object)entity.GsCdeSchoolTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdmCdeQualStatusID", DbType.Int32, (entity.AdmCdeQualStatusId.HasValue ? (object)entity.AdmCdeQualStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@QualRsltUsr", DbType.String, entity.QualRsltUsr); // MElshazly 3/9/2020 [14543]
            database.AddInParameter(commandWrapper, "@QualRsltPwd", DbType.String, entity.QualRsltPwd); // MElshazly 3/9/2020 [14543]
            database.AddInParameter(commandWrapper, "@GsCdeFacultyId", DbType.Decimal, (entity.GsCdeFacultyId.HasValue ? (object)entity.GsCdeFacultyId : System.DBNull.Value)); //added by olivia 15/4/2021 for ejust pg
            database.AddInParameter(commandWrapper, "@EdCdeSchoolGradeId", DbType.Int32, (entity.EdCdeSchoolGradeId.HasValue ? (object)entity.EdCdeSchoolGradeId : System.DBNull.Value)); //added by olivia 2/12/2021
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);//added by hoda at 8/6/2022 for eue

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
                EntityManager.StopTracking(entity.EntityTrackingKey);

            entity.OriginalEdStudQualId = entity.EdStudQualId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        #endregion
    }
}