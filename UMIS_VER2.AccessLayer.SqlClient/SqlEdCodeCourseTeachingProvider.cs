#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using System.Data.SqlClient;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCodeCourseTeaching"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCodeCourseTeachingProvider: SqlEdCodeCourseTeachingProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCodeCourseTeachingProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCodeCourseTeachingProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCodeCourseTeaching entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_CODE_COURSE_TEACHING_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeCourseTeachingId", DbType.Decimal, entity.EdCodeCourseTeachingId);
            //database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            //database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@MethodOrder", DbType.Decimal, entity.MethodOrder);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCdeTchngMthdId", DbType.Decimal, (entity.EdCdeTchngMthdId.HasValue ? (object)entity.EdCdeTchngMthdId : System.DBNull.Value));

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


            entity.OriginalEdCodeCourseTeachingId = entity.EdCodeCourseTeachingId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override TList<EdCodeCourseTeaching> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_CODE_COURSE_TEACHING_GetByAsFacultyInfoId", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);

            IDataReader reader = null;
            TList<EdCodeCourseTeaching> tmp = new TList<EdCodeCourseTeaching>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByAsFacultyInfoId", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByAsFacultyInfoId", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;

            //return rows;
        }

        #endregion

        #region Custom Methods


        public override TList<EdCodeCourseTeaching> GetByUniversity(TransactionManager transactionManager, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_CODE_COURSE_TEACHING_GetByUniversity", this.UseStoredProcedure);


            IDataReader reader = null;
            TList<EdCodeCourseTeaching> rows = new TList<EdCodeCourseTeaching>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByUniversity", rows));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByUniversity", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override TList<EdCodeCourseTeaching> SP_GetCODE_COURSE_TEACHINGBy_courseID(TransactionManager transactionManager,decimal _edCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "SP_GetCODE_COURSE_TEACHINGBy_courseID", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseID);

            IDataReader reader = null;
            TList<EdCodeCourseTeaching> rows = new TList<EdCodeCourseTeaching>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "SP_GetCODE_COURSE_TEACHINGBy_courseID", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int start = 0;
                int pageLength = int.MaxValue;
                int count = int.MaxValue;
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
                OnDataRequested(new CommandEventArgs(commandWrapper, "SP_GetCODE_COURSE_TEACHINGBy_courseID", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        //Angham 25/11/2020
        public override DataTable GetEdCourseTchng(decimal course_Topic_Id, int? type, decimal AcadYearID, decimal CodeSemesterID, decimal GroupInfoID)
        {
            SqlConnection conn = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand("GetEdCourseTchngbycourse_TopicMod", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("course_Topic_Id", SqlDbType.Decimal).Value = course_Topic_Id;
            if (type != null)
                command.Parameters.Add("Type", SqlDbType.Int).Value = type;
            command.Parameters.Add("AcadYearID", SqlDbType.Decimal).Value = AcadYearID;
            command.Parameters.Add("CodeSemsterID", SqlDbType.Decimal).Value = CodeSemesterID;
            command.Parameters.Add("GroupID", SqlDbType.Decimal).Value = GroupInfoID;

            conn.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();

            return table;

        }
        //End Angham 25/11/2020
        #endregion

	}
}