#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdSemesterAgenda"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdSemesterAgendaProvider: SqlEdSemesterAgendaProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdSemesterAgendaProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdSemesterAgendaProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        public override DataTable GetByEdSemesterOpenId_DataTable(TransactionManager transactionManager, System.Decimal _edSemesterOpenId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_SEMESTER_AGENDA_GetByEdSemesterOpenId_DT", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdSemesterOpenId", DbType.Decimal, _edSemesterOpenId);

            IDataReader reader = null;
            DataTable tmp = new DataTable();
            tmp.Columns.Add("Descr_Ar");
            tmp.Columns.Add("Descr_En");
            tmp.Columns.Add("From_Date");
            tmp.Columns.Add("To_Date");
            tmp.Columns.Add("From_Time");
            tmp.Columns.Add("To_Time");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() != "" ? DateTime.Parse(reader[2].ToString()).ToShortDateString() : "", reader[3].ToString() != "" ? DateTime.Parse(reader[3].ToString()).ToShortDateString() : "", reader[2].ToString() != "" ? DateTime.Parse(reader[2].ToString()).ToShortTimeString() : "", reader[3].ToString() != "" ? DateTime.Parse(reader[3].ToString()).ToShortTimeString() : "" };
                    tmp.Rows.Add(items);
                }

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

        public override DataTable Get_Agenda_Activity(TransactionManager transactionManager, System.Decimal ED_SEMESTER_OPEN_ID, decimal? STUD_FLG, decimal? STF_FLG, decimal? EMP_FLG, System.Decimal AS_CODE_DEGREE_CLASS_ID, decimal? DtlFlg, decimal? ShowFlag)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_Agenda_Activity", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ED_SEMESTER_OPEN_ID", DbType.Decimal, ED_SEMESTER_OPEN_ID);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_CLASS_ID", DbType.Decimal, AS_CODE_DEGREE_CLASS_ID);

          
                database.AddInParameter(commandWrapper, "@STUD_FLG", DbType.Decimal, STUD_FLG.HasValue ? (object)STUD_FLG : DBNull.Value);
       
                database.AddInParameter(commandWrapper, "@STF_FLG", DbType.Decimal, STF_FLG.HasValue ? (object)STF_FLG : DBNull.Value);
           
                database.AddInParameter(commandWrapper, "@EMP_FLG", DbType.Decimal, EMP_FLG.HasValue ? (object)EMP_FLG : DBNull.Value);

          
                database.AddInParameter(commandWrapper, "@DtlFlg", DbType.Decimal, DtlFlg.HasValue ? (object)DtlFlg : DBNull.Value);
                database.AddInParameter(commandWrapper, "@ShowFlag", DbType.Decimal, ShowFlag.HasValue ? (object)ShowFlag : DBNull.Value);

            IDataReader reader = null;
            DataTable tmp = new DataTable();
        

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
                tmp.Load(reader);
                //while (reader.Read())
                //{
                //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() != "" ? DateTime.Parse(reader[2].ToString()).ToShortDateString() : "", reader[3].ToString() != "" ? DateTime.Parse(reader[3].ToString()).ToShortDateString() : "", reader[2].ToString() != "" ? DateTime.Parse(reader[2].ToString()).ToShortTimeString() : "", reader[3].ToString() != "" ? DateTime.Parse(reader[3].ToString()).ToShortTimeString() : "" };
                //    tmp.Rows.Add(items);
                //}

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


        public override TList<EdSemesterAgenda> GetAgendaByOpensemIDClassDegree(TransactionManager transactionManager, decimal _edSemesterOpenId, decimal _AsCodeDegreeClassID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_SEMESTER_AGENDA_GetByOpenSemIDClassDeg", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdSemesterOpenId", DbType.Decimal, _edSemesterOpenId);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_CLASS_ID", DbType.Decimal, _AsCodeDegreeClassID);

            IDataReader reader = null;
            TList<EdSemesterAgenda> tmp = new TList<EdSemesterAgenda>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "dbo.ED_SEMESTER_AGENDA_GetByOpenSemIDClassDeg", tmp)); 

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, 0, 100);
                //count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        //count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdSemesterOpenId", tmp));
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

         

    }
}