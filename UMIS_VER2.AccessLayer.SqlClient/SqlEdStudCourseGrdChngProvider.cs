#region Using directives

using System;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;


#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudCourseGrdChng"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdStudCourseGrdChngProvider: SqlEdStudCourseGrdChngProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdStudCourseGrdChngProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdStudCourseGrdChngProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Updated Methods

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdStudCourseGrdChng entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_COURSE_GRD_CHNG_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdStudCourseGrdChngId", DbType.Decimal, 9);
            //Kamela, 13239, Added
            database.AddInParameter(commandWrapper, "@SeCodeUserTypeId", DbType.Decimal, entity.SeCodeUserTypeId);

            database.AddInParameter(commandWrapper, "@EdStudCourseRegId", DbType.Decimal, entity.EdStudCourseRegId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStsOldId", DbType.Decimal, entity.EdCodeCourseStsOldId);
            database.AddInParameter(commandWrapper, "@EdCodeCourseStsNewId", DbType.Decimal, entity.EdCodeCourseStsNewId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingOldId", DbType.Decimal, entity.EdCodeGradingOldId);
            database.AddInParameter(commandWrapper, "@EdCodeGradingNewId", DbType.Decimal, entity.EdCodeGradingNewId);
            database.AddInParameter(commandWrapper, "@EdCdeGrdChngRsnId", DbType.Decimal, entity.EdCdeGrdChngRsnId);
            database.AddInParameter(commandWrapper, "@ReqDate", DbType.Date, (entity.ReqDate.HasValue ? (object)entity.ReqDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DecisionNo", DbType.String, entity.DecisionNo);
            database.AddInParameter(commandWrapper, "@DecisionDate", DbType.DateTime, (entity.DecisionDate.HasValue ? (object)entity.DecisionDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, (entity.ApproveFlg.HasValue ? (object)entity.ApproveFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SaStfMemApprovedById", DbType.Decimal, (entity.SaStfMemApprovedById.HasValue ? (object)entity.SaStfMemApprovedById : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsLast", DbType.Decimal, entity.IsLast);
            database.AddInParameter(commandWrapper, "@Notes", DbType.String, entity.Notes);
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeFormId", DbType.Decimal, (entity.SeFormId.HasValue ? (object)entity.SeFormId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeeStudFeeItemId", DbType.Decimal, (entity.FeeStudFeeItemId.HasValue ? (object)entity.FeeStudFeeItemId : System.DBNull.Value));
            //Kamela, 13239, Added
            database.AddInParameter(commandWrapper, "@CommFlg", DbType.Decimal, entity.CommFlg);
            database.AddInParameter(commandWrapper, "@StaffFlg", DbType.Decimal, entity.StaffFlg);

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

            entity.EdStudCourseGrdChngId = decimal.Parse(commandWrapper.Parameters["@EdStudCourseGrdChngId"].Value.ToString());
            entity.OriginalEdStudCourseGrdChngId = entity.EdStudCourseGrdChngId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion

        #region Custom Methods

        public override DataTable SearchStudCourseChange(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId
            , System.DateTime? _FromDate, System.DateTime? _ToDate, System.Decimal _EdCodeCourseChangeIdFrom, System.Decimal _EdCodeCourseChangeIdTo, System.Decimal _EdCodeGradingIdFrom, System.Decimal _EdCodeGradingIdTo, System.Decimal? _ApproveFlg, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchStudCourseChange", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);
            database.AddInParameter(commandWrapper, "@EdCodeCourseChangeIdFrom", DbType.Decimal, _EdCodeCourseChangeIdFrom);
            database.AddInParameter(commandWrapper, "@EdCodeCourseChangeIdTo", DbType.Decimal, _EdCodeCourseChangeIdTo);
            database.AddInParameter(commandWrapper, "@EdCodeGradingIdFrom", DbType.Decimal, _EdCodeGradingIdFrom);
            database.AddInParameter(commandWrapper, "@EdCodeGradingIdTo", DbType.Decimal, _EdCodeGradingIdTo);
            if (_ApproveFlg.HasValue)
              database.AddInParameter(commandWrapper, "@ApproveFlg", DbType.Decimal, _ApproveFlg);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);



            IDataReader reader = null;
            DataTable table = new DataTable();
         

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                    //                     reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                    //    table.Rows.Add(items);
                    //}

                    table.Load(reader);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(),
                    //                     reader[7].ToString(),reader[8].ToString(),reader[9].ToString(),reader[10].ToString()};
                    //    table.Rows.Add(items);
                    //}
                    table.Load(reader);
                }

                ////Create Collection
                //Fill(reader, rows, start, pageLength);
                //count = -1;
                //if (reader.NextResult())
                //{
                //    if (reader.Read())
                //    {
                //        count = reader.GetInt32(0);
                //    }
                //}

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "SearchStudEnrollChange", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return table;
        }


        //Kamela, 13239
        public override DataTable SearchAllsentChngResultReq(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal? _ApproveFlg, System.Decimal _EdStudId, System.Decimal? _Staff_Know_Flg = null
            , System.DateTime? _FromDate = null, System.DateTime? _ToDate = null, System.Decimal? _CourseId = null, System.Decimal? _SectionId = null, System.Decimal? _RequestType = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SearchAllsentChngResultReq", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYear_Id", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@Codesemester_Id", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFaculty_Id", DbType.Decimal, _AsFacultyInfoId);
            if (_ApproveFlg.HasValue)
                database.AddInParameter(commandWrapper, "@Approve_Flg", DbType.Decimal, _ApproveFlg);
            database.AddInParameter(commandWrapper, "@EdStud_Id", DbType.Decimal, _EdStudId);

            if (_Staff_Know_Flg.HasValue)
                database.AddInParameter(commandWrapper, "@staff_Know_flg", DbType.Decimal, _Staff_Know_Flg);
            if(_FromDate.HasValue)
                database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            if (_ToDate.HasValue)
                database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);
            if (_CourseId.HasValue)
                database.AddInParameter(commandWrapper, "@course_Id", DbType.Decimal, _CourseId);
            if (_SectionId.HasValue)
                database.AddInParameter(commandWrapper, "@section_Id", DbType.Decimal, _SectionId);

            if (_RequestType.HasValue)
                database.AddInParameter(commandWrapper, "@ReqeustType", DbType.Decimal, _RequestType);
           

            IDataReader reader = null;
            DataTable table = new DataTable();


            try
            {
               
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                   
                    table.Load(reader);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                   
                    table.Load(reader);
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

        public override DataTable CheckAllReqForApproveAcceptReject(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _AsFacultyInfoId, System.Decimal? _ApproveFlg, System.Decimal _EdStudId, System.Decimal _CodeUserType,
           System.DateTime? _FromDate = null, System.DateTime? _ToDate = null, System.Decimal? _CourseId = null, System.Decimal? _RequestType = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "CheckAllReqForApproveAcceptReject", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AcadYear_Id", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@Codesemester_Id", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFaculty_Id", DbType.Decimal, _AsFacultyInfoId);
            if (_ApproveFlg.HasValue)
                database.AddInParameter(commandWrapper, "@Approve_Flg", DbType.Decimal, _ApproveFlg);
            database.AddInParameter(commandWrapper, "@EdStud_Id", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@CodeUserType", DbType.Decimal, _CodeUserType);

            if (_FromDate.HasValue)
                database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            if (_ToDate.HasValue)
                database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);
            if (_CourseId.HasValue)
                database.AddInParameter(commandWrapper, "@course_Id", DbType.Decimal, _CourseId);
           
            if (_RequestType.HasValue)
                database.AddInParameter(commandWrapper, "@ReqeustType", DbType.Decimal, _RequestType);


            IDataReader reader = null;
            DataTable table = new DataTable();


            try
            {

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    table.Load(reader);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    table.Load(reader);
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

        public override DataTable GetAllActionHappentOnGrdChngReq(TransactionManager transactionManager, System.Decimal _GrdChngReqId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GetAllActionHappentOnGrdChngReq", this.UseStoredProcedure);
            //database.AddInParameter(commandWrapper, "@AcadYear_Id", DbType.Decimal, _EdAcadYearId);
            //database.AddInParameter(commandWrapper, "@Codesemester_Id", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ChngGrdReq_Id", DbType.Decimal, _GrdChngReqId);
          
            IDataReader reader = null;
            DataTable table = new DataTable();
            try
            {

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    table.Load(reader);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    table.Load(reader);
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