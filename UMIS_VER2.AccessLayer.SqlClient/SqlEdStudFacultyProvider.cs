#region Using directives

using System;
using System.Data;
using System.Linq;
using System.Collections;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using UMIS_VER2.AccessLayer.Bases;
using System.Configuration;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
    ///<summary>
    /// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdStudFaculty"/> entity.
    ///</summary>
    [DataObject]
    [CLSCompliant(true)]
    public partial class SqlEdStudFacultyProvider : SqlEdStudFacultyProviderBase
    {
        /// <summary>
        /// Creates a new <see cref="SqlEdStudFacultyProvider"/> instance.
        /// Uses connection string to connect to datasource.
        /// </summary>
        /// <param name="connectionString">The connection string to the database.</param>
        /// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
        /// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
        public SqlEdStudFacultyProvider(string connectionString, bool useStoredProcedure, string providerInvariantName) : base(connectionString, useStoredProcedure, providerInvariantName) { }

        #region Custom Methods

        public override DataTable GetStudentEntities(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _asFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_FACULTY_GetStudEntities", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _edStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EntMainId");
            table.Columns.Add("EntCodeEntityTypeId");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }






        public override EdStudFaculty GetByStudFacultyCode(System.String _studFacultyCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_FACULTY_GetByStudFacultyCode", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@StudFacultyCode", DbType.String, _studFacultyCode);
            IDataReader reader = null;
            EdStudFaculty rows = new EdStudFaculty();
            TList<EdStudFaculty> lst = new TList<EdStudFaculty>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "ED_STUD_FACULTY_GetByStudFacultyCode", rows));

                
                    reader = Utility.ExecuteReader(database, commandWrapper);
                
                //Create Collection
                Fill(reader, lst, 0, int.MaxValue);
                if (lst.Count > 0)
                    rows = lst.FirstOrDefault();
                int count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }
                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "StudFilter", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }




        public override DataTable GetHonorDegreeForStudent(TransactionManager transactionManager, System.Decimal _edStudId, System.Decimal _asFacultyInfoId, System.Decimal _cGPA)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetHonorDegreeForStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _edStudId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@CGPA", DbType.Decimal, _cGPA);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EntPolicyAccumHonorId");
            table.Columns.Add("PassFlg");

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
                    object[] items = { reader[0].ToString(), reader[1].ToString() };
                    table.Rows.Add(items);
                }
            }
            finally
            {
                commandWrapper = null;
            }

            return table;
        }

       

        /// <summary>
        /// 	Gets rows from the datasource based on the IX_ED_STUD_ID_1 index.
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_admApplicantId"></param>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">out parameter to get total records for query.</param>
        /// <returns>Returns an instance of the <see cref="TList&lt;EdStudFaculty&gt;"/> class.</returns>
        /// <remarks></remarks>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override TList<EdStudFaculty> GetByAdmApplicantIdModular(TransactionManager transactionManager, System.Decimal _admApplicantId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_STUD_FACULTY_GetByAdmApplicantId_Modular", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@admApplicantId", DbType.Decimal, _admApplicantId);

            IDataReader reader = null;
            TList<EdStudFaculty> tmp = new TList<EdStudFaculty>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByAdmApplicantIdModular", tmp));

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByAdmApplicantIdModular", tmp));
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
    }
}