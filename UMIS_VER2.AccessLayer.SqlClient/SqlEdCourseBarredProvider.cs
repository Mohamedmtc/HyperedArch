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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCourseBarred"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdCourseBarredProvider: SqlEdCourseBarredProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCourseBarredProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCourseBarredProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedures

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourseBarred entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_BARRED_Insert", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseBarredId", DbType.Decimal, entity.EdCourseBarredId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
            database.AddInParameter(commandWrapper, "@EdBarredCourseId", DbType.Decimal, entity.EdBarredCourseId);

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


            entity.OriginalEdCourseBarredId = entity.EdCourseBarredId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }

        public override TList<EdCourseBarred> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
        {
            count = -1;
            if (whereClause.IndexOf(";") > -1)
                return new TList<EdCourseBarred>();

            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_BARRED_Find", UseStoredProcedure);

            bool searchUsingOR = false;
            if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
                searchUsingOR = true;

            database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);

            database.AddInParameter(commandWrapper, "@EdCourseBarredId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, DBNull.Value);
            database.AddInParameter(commandWrapper, "@EdBarredCourseId", DbType.Decimal, DBNull.Value);

            // replace all instances of 'AND' and 'OR' because we already set searchUsingOR
            whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|");
            string[] clauses = whereClause.ToLower().Split('|');

            // Here's what's going on below: Find a field, then to get the value we
            // drop the field name from the front, trim spaces, drop the '=' sign,
            // trim more spaces, and drop any outer single quotes.
            // Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"

            char[] equalSign = { '=' };
            char[] singleQuote = { '\'' };
            foreach (string clause in clauses)
            {
                if (clause.Trim().StartsWith("ed_course_barred_id ") || clause.Trim().StartsWith("ed_course_barred_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EdCourseBarredId",
                        clause.Trim().Remove(0, 19).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ed_course_id ") || clause.Trim().StartsWith("ed_course_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EdCourseId",
                        clause.Trim().Remove(0, 12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }
                if (clause.Trim().StartsWith("ed_barred_course_id ") || clause.Trim().StartsWith("ed_barred_course_id="))
                {
                    database.SetParameterValue(commandWrapper, "@EdBarredCourseId",
                        clause.Trim().Remove(0, 19).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
                    continue;
                }

                throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
            }

            IDataReader reader = null;
            //Create Collection
            TList<EdCourseBarred> rows = new TList<EdCourseBarred>();


            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                Fill(reader, rows, start, pageLength);

                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows));
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