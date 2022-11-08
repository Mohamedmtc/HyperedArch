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
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SaStfMember"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlSaStfMemberProvider : SqlSaStfMemberProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlSaStfMemberProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlSaStfMemberProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Updated Procedures
        /*
        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMember entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SA_STF_MEMBER_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, entity.SaStfMemberId);
            database.AddInParameter(commandWrapper, "@StfCode", DbType.String, entity.StfCode);
            database.AddInParameter(commandWrapper, "@StfFullNameAr", DbType.String, entity.StfFullNameAr);
            database.AddInParameter(commandWrapper, "@StfFullNameEn", DbType.String, entity.StfFullNameEn);
            database.AddInParameter(commandWrapper, "@AsNodeId", DbType.Decimal, (entity.AsNodeId.HasValue ? (object)entity.AsNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCodeJobStatusId", DbType.Decimal, (entity.SaCodeJobStatusId.HasValue ? (object)entity.SaCodeJobStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCodeScDegId", DbType.Decimal, (entity.SaCodeScDegId.HasValue ? (object)entity.SaCodeScDegId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfNameAr", DbType.String, entity.StfNameAr);
            database.AddInParameter(commandWrapper, "@StfClFullNameAr", DbType.String, entity.StfClFullNameAr);
            database.AddInParameter(commandWrapper, "@StfClNameAr", DbType.String, entity.StfClNameAr);
            database.AddInParameter(commandWrapper, "@StfLnameAr", DbType.String, entity.StfLnameAr);
            database.AddInParameter(commandWrapper, "@StfClLnameAr", DbType.String, entity.StfClLnameAr);
            database.AddInParameter(commandWrapper, "@StfFnameEn", DbType.String, entity.StfFnameEn);
            database.AddInParameter(commandWrapper, "@StfLnameEn", DbType.String, entity.StfLnameEn);
            database.AddInParameter(commandWrapper, "@StfIsAzhary", DbType.Decimal, entity.StfIsAzhary);
            database.AddInParameter(commandWrapper, "@FileNum", DbType.String, entity.FileNum);
            database.AddInParameter(commandWrapper, "@StfStatusNum", DbType.String, entity.StfStatusNum);
            database.AddInParameter(commandWrapper, "@StfNationalIdNum", DbType.String, entity.StfNationalIdNum);
            database.AddInParameter(commandWrapper, "@StfDob", DbType.DateTime, (entity.StfDob.HasValue ? (object)entity.StfDob : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfRegNum", DbType.String, entity.StfRegNum);
            database.AddInParameter(commandWrapper, "@StfRegDate", DbType.DateTime, (entity.StfRegDate.HasValue ? (object)entity.StfRegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfMname", DbType.String, entity.StfMname);
            database.AddInParameter(commandWrapper, "@StfPermAdd", DbType.String, entity.StfPermAdd);
            database.AddInParameter(commandWrapper, "@StfCurrAdd", DbType.String, entity.StfCurrAdd);
            database.AddInParameter(commandWrapper, "@StfEmpDate", DbType.DateTime, (entity.StfEmpDate.HasValue ? (object)entity.StfEmpDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeMaritalStateId", DbType.Decimal, (entity.GsCodeMaritalStateId.HasValue ? (object)entity.GsCodeMaritalStateId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, (entity.GsCountryInfoId.HasValue ? (object)entity.GsCountryInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId2", DbType.Decimal, (entity.GsCountryNodeId2.HasValue ? (object)entity.GsCountryNodeId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId3", DbType.Decimal, (entity.GsCountryNodeId3.HasValue ? (object)entity.GsCountryNodeId3 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsContactMethodHId", DbType.Decimal, (entity.GsContactMethodHId.HasValue ? (object)entity.GsContactMethodHId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfPhoto", DbType.String, entity.StfPhoto);
            database.AddInParameter(commandWrapper, "@BasicSalary", DbType.Decimal, (entity.BasicSalary.HasValue ? (object)entity.BasicSalary : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisGeneralSpecId", DbType.Decimal, (entity.PgThesisGeneralSpecId.HasValue ? (object)entity.PgThesisGeneralSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisDetailedSpecId", DbType.Decimal, (entity.PgThesisDetailedSpecId.HasValue ? (object)entity.PgThesisDetailedSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DelFlag", DbType.Decimal, entity.DelFlag);
            database.AddInParameter(commandWrapper, "@RetirmentAge", DbType.Decimal, entity.RetirmentAge);
            database.AddInParameter(commandWrapper, "@OldStfMemberId", DbType.Decimal, (entity.OldStfMemberId.HasValue ? (object)entity.OldStfMemberId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EmailPassword", DbType.String, entity.EmailPassword);
            database.AddInParameter(commandWrapper, "@TelNum", DbType.String, entity.TelNum);
            database.AddInParameter(commandWrapper, "@MobNum", DbType.String, entity.MobNum);
            database.AddInParameter(commandWrapper, "@EMail", DbType.String, entity.EMail);
            database.AddInParameter(commandWrapper, "@GsCodeIdentTypeId", DbType.Decimal, (entity.GsCodeIdentTypeId.HasValue ? (object)entity.GsCodeIdentTypeId : System.DBNull.Value));

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


            entity.OriginalSaStfMemberId = entity.SaStfMemberId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }
        */
        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMember entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SA_STF_MEMBER_Update", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, entity.SaStfMemberId);
            database.AddInParameter(commandWrapper, "@OriginalSaStfMemberId", DbType.Decimal, entity.OriginalSaStfMemberId);
            database.AddInParameter(commandWrapper, "@StfCode", DbType.String, entity.StfCode);
            database.AddInParameter(commandWrapper, "@StfFullNameAr", DbType.String, entity.StfFullNameAr);
            database.AddInParameter(commandWrapper, "@StfFullNameEn", DbType.String, entity.StfFullNameEn);
            database.AddInParameter(commandWrapper, "@AsNodeId", DbType.Decimal, (entity.AsNodeId.HasValue ? (object)entity.AsNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCodeJobStatusId", DbType.Decimal, (entity.SaCodeJobStatusId.HasValue ? (object)entity.SaCodeJobStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCodeScDegId", DbType.Decimal, (entity.SaCodeScDegId.HasValue ? (object)entity.SaCodeScDegId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfNameAr", DbType.String, entity.StfNameAr);
            database.AddInParameter(commandWrapper, "@StfClFullNameAr", DbType.String, entity.StfClFullNameAr);
            database.AddInParameter(commandWrapper, "@StfClNameAr", DbType.String, entity.StfClNameAr);
            database.AddInParameter(commandWrapper, "@StfLnameAr", DbType.String, entity.StfLnameAr);
            database.AddInParameter(commandWrapper, "@StfClLnameAr", DbType.String, entity.StfClLnameAr);
            database.AddInParameter(commandWrapper, "@StfFnameEn", DbType.String, entity.StfFnameEn);
            database.AddInParameter(commandWrapper, "@StfLnameEn", DbType.String, entity.StfLnameEn);
            database.AddInParameter(commandWrapper, "@StfIsAzhary", DbType.Decimal, entity.StfIsAzhary);
            database.AddInParameter(commandWrapper, "@FileNum", DbType.String, entity.FileNum);
            database.AddInParameter(commandWrapper, "@StfStatusNum", DbType.String, entity.StfStatusNum);
            database.AddInParameter(commandWrapper, "@StfNationalIdNum", DbType.String, entity.StfNationalIdNum);
            database.AddInParameter(commandWrapper, "@StfDob", DbType.DateTime, (entity.StfDob.HasValue ? (object)entity.StfDob : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfRegNum", DbType.String, entity.StfRegNum);
            database.AddInParameter(commandWrapper, "@StfRegDate", DbType.DateTime, (entity.StfRegDate.HasValue ? (object)entity.StfRegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfMname", DbType.String, entity.StfMname);
            database.AddInParameter(commandWrapper, "@StfPermAdd", DbType.String, entity.StfPermAdd);
            database.AddInParameter(commandWrapper, "@StfCurrAdd", DbType.String, entity.StfCurrAdd);
            database.AddInParameter(commandWrapper, "@StfEmpDate", DbType.DateTime, (entity.StfEmpDate.HasValue ? (object)entity.StfEmpDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeMaritalStateId", DbType.Decimal, (entity.GsCodeMaritalStateId.HasValue ? (object)entity.GsCodeMaritalStateId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, (entity.GsCountryInfoId.HasValue ? (object)entity.GsCountryInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId2", DbType.Decimal, (entity.GsCountryNodeId2.HasValue ? (object)entity.GsCountryNodeId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId3", DbType.Decimal, (entity.GsCountryNodeId3.HasValue ? (object)entity.GsCountryNodeId3 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsContactMethodHId", DbType.Decimal, (entity.GsContactMethodHId.HasValue ? (object)entity.GsContactMethodHId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfPhoto", DbType.String, entity.StfPhoto);
            database.AddInParameter(commandWrapper, "@BasicSalary", DbType.Decimal, (entity.BasicSalary.HasValue ? (object)entity.BasicSalary : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisGeneralSpecId", DbType.Decimal, (entity.PgThesisGeneralSpecId.HasValue ? (object)entity.PgThesisGeneralSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisDetailedSpecId", DbType.Decimal, (entity.PgThesisDetailedSpecId.HasValue ? (object)entity.PgThesisDetailedSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DelFlag", DbType.Decimal, entity.DelFlag);
            database.AddInParameter(commandWrapper, "@RetirmentAge", DbType.Decimal, entity.RetirmentAge);
            database.AddInParameter(commandWrapper, "@OldStfMemberId", DbType.Decimal, (entity.OldStfMemberId.HasValue ? (object)entity.OldStfMemberId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EmailPassword", DbType.String, entity.EmailPassword);
            database.AddInParameter(commandWrapper, "@TelNum", DbType.String, entity.TelNum);
            database.AddInParameter(commandWrapper, "@MobNum", DbType.String, entity.MobNum);
            database.AddInParameter(commandWrapper, "@EMail", DbType.String, entity.EMail);
            database.AddInParameter(commandWrapper, "@GsCodeIdentTypeId", DbType.Decimal, (entity.GsCodeIdentTypeId.HasValue ? (object)entity.GsCodeIdentTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdminJobFlg", DbType.Boolean, (entity.AdminJobFlg.HasValue ? (object)entity.AdminJobFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCdeAdminJobId", DbType.Int32, (entity.SaCdeAdminJobId.HasValue ? (object)entity.SaCdeAdminJobId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdminJobLoad", DbType.Decimal, (entity.AdminJobLoad.HasValue ? (object)entity.AdminJobLoad : System.DBNull.Value));

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

            entity.OriginalSaStfMemberId = entity.SaStfMemberId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }

        #endregion

        #region Custom Methods
        public override TList<SaStfMember> GetByAsFacultyInfoIdAndEntMainId(TransactionManager transactionManager, System.Decimal _asFacultyInfoId, System.Decimal _entMainId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_MEMBER_GetByAsFacultyInfoIdAndEntMainId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _entMainId);

            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByAsFacultyInfoIdAndEntMainId", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByAsFacultyInfoIdAndEntMainId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            if (rows.Count == 0)
                rows.Add(new SaStfMember());
            return rows;
        }

        public override TList<SaStfMember> GetSpecificDepartmentStaff(TransactionManager transactionManager, System.Decimal _DeptEntMainId, System.String _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSpecificDepartmentStaff", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, _DeptEntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.String, _Lang);

            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSpecificDepartmentStaff", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetSpecificDepartmentStaff", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<SaStfMember> GetDepartmentStaff(TransactionManager transactionManager, System.Decimal _DeptEntMainId, System.String _Lang)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetDepartmentStaff", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@DeptEntMainId", DbType.Decimal, _DeptEntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.String, _Lang);

            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetDepartmentStaff", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetDepartmentStaff", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override TList<SaStfMember> GetStudentInstructor(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudentInstructor", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStudentInstructor", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStudentInstructor", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override decimal InsertWithStfMemIdOut(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMember entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Sa_Stf_Mem_InsertWithIdOut", this.UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@StfCode", DbType.String, entity.StfCode);
            database.AddInParameter(commandWrapper, "@StfFullNameAr", DbType.String, entity.StfFullNameAr);
            database.AddInParameter(commandWrapper, "@StfFullNameEn", DbType.String, entity.StfFullNameEn);
            database.AddInParameter(commandWrapper, "@AsNodeId", DbType.Decimal, (entity.AsNodeId.HasValue ? (object)entity.AsNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@SaCodeJobStatusId", DbType.Decimal, (entity.SaCodeJobStatusId.HasValue ? (object)entity.SaCodeJobStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCodeScDegId", DbType.Decimal, (entity.SaCodeScDegId.HasValue ? (object)entity.SaCodeScDegId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfNameAr", DbType.String, entity.StfNameAr);
            database.AddInParameter(commandWrapper, "@StfClFullNameAr", DbType.String, entity.StfClFullNameAr);
            database.AddInParameter(commandWrapper, "@StfClNameAr", DbType.String, entity.StfClNameAr);
            database.AddInParameter(commandWrapper, "@StfLnameAr", DbType.String, entity.StfLnameAr);
            database.AddInParameter(commandWrapper, "@StfClLnameAr", DbType.String, entity.StfClLnameAr);
            database.AddInParameter(commandWrapper, "@StfFnameEn", DbType.String, entity.StfFnameEn);
            database.AddInParameter(commandWrapper, "@StfLnameEn", DbType.String, entity.StfLnameEn);
            database.AddInParameter(commandWrapper, "@StfIsAzhary", DbType.Decimal, entity.StfIsAzhary);
            database.AddInParameter(commandWrapper, "@FileNum", DbType.String, entity.FileNum);
            database.AddInParameter(commandWrapper, "@StfStatusNum", DbType.String, entity.StfStatusNum);
            database.AddInParameter(commandWrapper, "@StfNationalIdNum", DbType.String, entity.StfNationalIdNum);
            database.AddInParameter(commandWrapper, "@StfDob", DbType.DateTime, (entity.StfDob.HasValue ? (object)entity.StfDob : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfRegNum", DbType.String, entity.StfRegNum);
            database.AddInParameter(commandWrapper, "@StfRegDate", DbType.DateTime, (entity.StfRegDate.HasValue ? (object)entity.StfRegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfMname", DbType.String, entity.StfMname);
            database.AddInParameter(commandWrapper, "@StfPermAdd", DbType.String, entity.StfPermAdd);
            database.AddInParameter(commandWrapper, "@StfCurrAdd", DbType.String, entity.StfCurrAdd);
            database.AddInParameter(commandWrapper, "@StfEmpDate", DbType.DateTime, (entity.StfEmpDate.HasValue ? (object)entity.StfEmpDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeMaritalStateId", DbType.Decimal, (entity.GsCodeMaritalStateId.HasValue ? (object)entity.GsCodeMaritalStateId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, (entity.GsCountryInfoId.HasValue ? (object)entity.GsCountryInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId2", DbType.Decimal, (entity.GsCountryNodeId2.HasValue ? (object)entity.GsCountryNodeId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId3", DbType.Decimal, (entity.GsCountryNodeId3.HasValue ? (object)entity.GsCountryNodeId3 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsContactMethodHId", DbType.Decimal, (entity.GsContactMethodHId.HasValue ? (object)entity.GsContactMethodHId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfPhoto", DbType.String, entity.StfPhoto);
            database.AddInParameter(commandWrapper, "@BasicSalary", DbType.Decimal, (entity.BasicSalary.HasValue ? (object)entity.BasicSalary : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisGeneralSpecId", DbType.Decimal, (entity.PgThesisGeneralSpecId.HasValue ? (object)entity.PgThesisGeneralSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisDetailedSpecId", DbType.Decimal, (entity.PgThesisDetailedSpecId.HasValue ? (object)entity.PgThesisDetailedSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DelFlag", DbType.Decimal, entity.DelFlag);
            database.AddInParameter(commandWrapper, "@RetirmentAge", DbType.Decimal, entity.RetirmentAge);
            database.AddInParameter(commandWrapper, "@OldStfMemberId", DbType.Decimal, (entity.OldStfMemberId.HasValue ? (object)entity.OldStfMemberId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EmailPassword", DbType.String, entity.EmailPassword);

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Sa_Stf_Mem_InsertWithIdOut", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }


            entity.OriginalSaStfMemberId = entity.SaStfMemberId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Sa_Stf_Mem_InsertWithIdOut", entity));

            return Convert.ToDecimal(commandWrapper.Parameters["@SaStfMemberId"].Value);
        }
        public override TList<SaStfMember> GetForAdviseView(TransactionManager transactionManager, System.Decimal? _EdAcadYear, System.Decimal? _EdCodeSem, System.Decimal? _AsFacultyInfo, System.Decimal? _entityMainId, System.Decimal? _lang, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetForAdviseView", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYear", DbType.Decimal, _EdAcadYear);
            database.AddInParameter(commandWrapper, "@EdCodeSem", DbType.Decimal, _EdCodeSem);
            database.AddInParameter(commandWrapper, "@AsFacultyInfo", DbType.Decimal, _AsFacultyInfo);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _entityMainId);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, _lang);

            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetForAdviseView", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetForAdviseView", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override TList<SaStfMember> GetByOfferingId(TransactionManager transactionManager, System.Decimal? _EdOfferingId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SaStaffMember_getByOfferingId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, _EdOfferingId);


            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByOfferingId", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByOfferingId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        public override DataTable StufCoursesTimeTable(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _SaStufMemberID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.StufCoursesTimeTable", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStufMemberID", DbType.Decimal, _SaStufMemberID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("SC_TCHNG_SLOT_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("SC_BUILDING_DESCR_AR");
            table.Columns.Add("SC_BUILDING_DESCR_EN");
            table.Columns.Add("SC_HALL_DESCR_AR");
            table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString() };
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
        public override DataTable GetStufTeachingCourses(TransactionManager transactionManager, System.Decimal _SaStfMemberID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaff_TeachingCourses", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, _SaStfMemberID);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
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
        public override DataTable GetStufCourseGroups(TransactionManager transactionManager, System.Decimal _SaStfMemberID, System.Decimal _EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaff_CourseGroup", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMamberId", DbType.Decimal, _SaStfMemberID);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SC_SCHEDULE_DTL_ID");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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
        public override DataTable GetStaffsForStudent(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdStudID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaffsForStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudID", DbType.Decimal, _EdStudID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SA_STF_MEMBER_ID");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("SC_DEG_DESCR_AR");
            table.Columns.Add("SC_DEG_DESCR_EN");
            table.Columns.Add("NOTES");                    //fayrouz 4/5/2020 tfs 13223

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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
        public override SaStfMember GetBySchedule(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal EdCourseID, decimal ScScheduleDtlID, decimal GsCodeWeekID, decimal ScTchngSlotID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SA_STF_MEMBER_GetBySchedule", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, EdCourseID);
            database.AddInParameter(commandWrapper, "@ScScheduleDtlID", DbType.Decimal, ScScheduleDtlID);
            database.AddInParameter(commandWrapper, "@GsCodeWeekID", DbType.Decimal, GsCodeWeekID);
            database.AddInParameter(commandWrapper, "@ScTchngSlotID", DbType.Decimal, ScTchngSlotID);

            IDataReader reader = null;
            TList<SaStfMember> tmp = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetBySchedule", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetBySchedule", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (tmp.Count == 0)
                return null;

            return tmp[0];
        }

        public override bool InsertStf(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SaStfMember entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_SA_STF_MEMBER_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@StfCode", DbType.String, entity.StfCode);
            database.AddInParameter(commandWrapper, "@StfFullNameAr", DbType.String, entity.StfFullNameAr);
            database.AddInParameter(commandWrapper, "@StfFullNameEn", DbType.String, entity.StfFullNameEn);
            database.AddInParameter(commandWrapper, "@AsNodeId", DbType.Decimal, (entity.AsNodeId.HasValue ? (object)entity.AsNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, entity.AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@SaCodeJobStatusId", DbType.Decimal, (entity.SaCodeJobStatusId.HasValue ? (object)entity.SaCodeJobStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCodeScDegId", DbType.Decimal, (entity.SaCodeScDegId.HasValue ? (object)entity.SaCodeScDegId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfNameAr", DbType.String, entity.StfNameAr);
            database.AddInParameter(commandWrapper, "@StfClFullNameAr", DbType.String, entity.StfClFullNameAr);
            database.AddInParameter(commandWrapper, "@StfClNameAr", DbType.String, entity.StfClNameAr);
            database.AddInParameter(commandWrapper, "@StfLnameAr", DbType.String, entity.StfLnameAr);
            database.AddInParameter(commandWrapper, "@StfClLnameAr", DbType.String, entity.StfClLnameAr);
            database.AddInParameter(commandWrapper, "@StfFnameEn", DbType.String, entity.StfFnameEn);
            database.AddInParameter(commandWrapper, "@StfLnameEn", DbType.String, entity.StfLnameEn);
            database.AddInParameter(commandWrapper, "@StfIsAzhary", DbType.Decimal, entity.StfIsAzhary);
            database.AddInParameter(commandWrapper, "@FileNum", DbType.String, entity.FileNum);
            database.AddInParameter(commandWrapper, "@StfStatusNum", DbType.String, entity.StfStatusNum);
            database.AddInParameter(commandWrapper, "@StfNationalIdNum", DbType.String, entity.StfNationalIdNum);
            database.AddInParameter(commandWrapper, "@StfDob", DbType.DateTime, (entity.StfDob.HasValue ? (object)entity.StfDob : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfRegNum", DbType.String, entity.StfRegNum);
            database.AddInParameter(commandWrapper, "@StfRegDate", DbType.DateTime, (entity.StfRegDate.HasValue ? (object)entity.StfRegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfMname", DbType.String, entity.StfMname);
            database.AddInParameter(commandWrapper, "@StfPermAdd", DbType.String, entity.StfPermAdd);
            database.AddInParameter(commandWrapper, "@StfCurrAdd", DbType.String, entity.StfCurrAdd);
            database.AddInParameter(commandWrapper, "@StfEmpDate", DbType.DateTime, (entity.StfEmpDate.HasValue ? (object)entity.StfEmpDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeMaritalStateId", DbType.Decimal, (entity.GsCodeMaritalStateId.HasValue ? (object)entity.GsCodeMaritalStateId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, (entity.GsCountryInfoId.HasValue ? (object)entity.GsCountryInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryInfoId2", DbType.Decimal, (entity.GsCountryInfoId2.HasValue ? (object)entity.GsCountryInfoId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId2", DbType.Decimal, (entity.GsCountryNodeId2.HasValue ? (object)entity.GsCountryNodeId2 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId3", DbType.Decimal, (entity.GsCountryNodeId3.HasValue ? (object)entity.GsCountryNodeId3 : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsContactMethodHId", DbType.Decimal, (entity.GsContactMethodHId.HasValue ? (object)entity.GsContactMethodHId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StfPhoto", DbType.String, entity.StfPhoto);
            database.AddInParameter(commandWrapper, "@BasicSalary", DbType.Decimal, (entity.BasicSalary.HasValue ? (object)entity.BasicSalary : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisGeneralSpecId", DbType.Decimal, (entity.PgThesisGeneralSpecId.HasValue ? (object)entity.PgThesisGeneralSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PgThesisDetailedSpecId", DbType.Decimal, (entity.PgThesisDetailedSpecId.HasValue ? (object)entity.PgThesisDetailedSpecId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DelFlag", DbType.Decimal, entity.DelFlag);
            database.AddInParameter(commandWrapper, "@RetirmentAge", DbType.Decimal, entity.RetirmentAge);
            database.AddInParameter(commandWrapper, "@OldStfMemberId", DbType.Decimal, (entity.OldStfMemberId.HasValue ? (object)entity.OldStfMemberId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EmailPassword", DbType.String, entity.EmailPassword);
            database.AddInParameter(commandWrapper, "@TelNum", DbType.String, entity.TelNum);
            database.AddInParameter(commandWrapper, "@MobNum", DbType.String, entity.MobNum);
            database.AddInParameter(commandWrapper, "@EMail", DbType.String, entity.EMail);
            database.AddInParameter(commandWrapper, "@GsCodeIdentTypeId", DbType.Decimal, (entity.GsCodeIdentTypeId.HasValue ? (object)entity.GsCodeIdentTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdminJobFlg", DbType.Boolean, (entity.AdminJobFlg.HasValue ? (object)entity.AdminJobFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaCdeAdminJobId", DbType.Int32, (entity.SaCdeAdminJobId.HasValue ? (object)entity.SaCdeAdminJobId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AdminJobLoad", DbType.Decimal, (entity.AdminJobLoad.HasValue ? (object)entity.AdminJobLoad : System.DBNull.Value));

            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "InsertStf", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.SaStfMemberId = Convert.ToDecimal(commandWrapper.Parameters["@SaStfMemberId"].Value.ToString());
            entity.OriginalSaStfMemberId = entity.SaStfMemberId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "InsertStf", entity));

            return Convert.ToBoolean(results);
        }
        public override DataTable GetStaffCreditHours(TransactionManager transactionManager, decimal EdAcadYearID, decimal EdCodeSemesterID, decimal AsFacultyInfoID, decimal GsCodeWeekID, decimal AsNodeID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaffMemberOfficeHours", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AsFacultyInfoID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, EdCodeSemesterID);
            database.AddInParameter(commandWrapper, "@WeekDay", DbType.Decimal, GsCodeWeekID);
            database.AddInParameter(commandWrapper, "@AS_NODE_ID", DbType.Decimal, AsNodeID);
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("STF_FULL_NAME_AR");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable SearchStaffMemOfficeHours(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.String _StfName, System.Decimal _GsCodeWeekDayId, System.Decimal _NumHoursFrom, System.Decimal _NumHoursTo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchStaffMemOfficeHours", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@StfName", DbType.String, _StfName);
            database.AddInParameter(commandWrapper, "@GsCodeWeekDayId", DbType.Decimal, _GsCodeWeekDayId);
            database.AddInParameter(commandWrapper, "@NumHouresFrom", DbType.Decimal, _NumHoursFrom);
            database.AddInParameter(commandWrapper, "@NumHouresTo", DbType.Decimal, _NumHoursTo);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SA_STF_MEMBER_ID");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("SC_DEG_DESCR_AR");
            table.Columns.Add("SC_DEG_DESCR_EN");
            table.Columns.Add("NOTES");            //added by eman moustafa  date:24-3-2020  Task:13178

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        //Esraa Ali         8-7-2019           10194
        public override TList<SaStfMember> GetStfByEdStudSemIDandCrsID(TransactionManager transactionManager, System.Decimal _EdStudSemesterId, System.Decimal _EdCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStfByEdStudSemIDandCrsID", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, _EdStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);

            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStfByEdStudSemIDandCrsID", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStfByEdStudSemIDandCrsID", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        //Esraa Ali     27-5-2020     13648
        //Start
        public override DataTable INTEG_GetTeachers(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INTEG_GetTeachers", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);
            database.AddInParameter(commandWrapper, "@YearID", DbType.Decimal, _YearID);
            database.AddInParameter(commandWrapper, "@SemID", DbType.Decimal, _SemID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SIS ID");
            table.Columns.Add("School SIS ID");
            table.Columns.Add("Username");

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

        public override DataTable INTEG_GetTeacherRoster(System.Decimal _FacID, System.Decimal _YearID, System.Decimal _SemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.INTEG_GetTeacherRoster", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@FacID", DbType.Decimal, _FacID);
            database.AddInParameter(commandWrapper, "@YearID", DbType.Decimal, _YearID);
            database.AddInParameter(commandWrapper, "@SemID", DbType.Decimal, _SemID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("Section SIS ID");
            table.Columns.Add("SIS ID");

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
        //End

        //Angham 25/11/2020
        public override TList<SaStfMember> GetStaffAvailable(System.Decimal? StfMemberId, System.Decimal AcadYearID, System.Decimal SemsterID, System.String StfName, string XMLData)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStaffAvailable", this.UseStoredProcedure);
            if (StfMemberId != null)
                database.AddInParameter(commandWrapper, "@StfMemberId", DbType.Decimal, StfMemberId);

            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, AcadYearID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, SemsterID);
            if (StfName != "")
                database.AddInParameter(commandWrapper, "@StfName", DbType.String, "%" + StfName + "%");
            database.AddInParameter(commandWrapper, "@xmlDates", DbType.String, XMLData);
            IDataReader reader = null;
            TList<SaStfMember> rows = new TList<SaStfMember>();
            try
            {
                reader = Utility.ExecuteReader(database, commandWrapper);
                //Create Collection
                Fill(reader, rows, 0, int.MaxValue);
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetDepartmentStaff", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }
        //End Angham 25/11/2020


        #endregion
    }
}