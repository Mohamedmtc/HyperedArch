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
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdAcadYear"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlEdAcadYearProvider: SqlEdAcadYearProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdAcadYearProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdAcadYearProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods
        public override DataTable GetNextAcadYear(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.NextAcadYear", this.UseStoredProcedure);

            IDataReader reader = null;

            //Create Collection
            DataTable table = new DataTable();
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("YEAR_CODE");
            table.Columns.Add("YEAR_ORDER");
            table.Columns.Add("YEAR_CALENDER");
            table.Columns.Add("CURRENT_YEAR");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);

                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
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

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYear entity, UMIS_VER2.BusinessLyer.EdAcadYearFaculty objAcadYearFaculty, decimal? _AsFacultyInfoID, decimal? _AsCode_DegreeClassID )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_ACAD_YEAR_Insert_Custom", UseStoredProcedure);

            //database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddOutParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@YearCode", DbType.String, entity.YearCode);
            database.AddInParameter(commandWrapper, "@YearOrder", DbType.Decimal, entity.YearOrder);
            database.AddInParameter(commandWrapper, "@YearCalender", DbType.Decimal, entity.YearCalender);
            database.AddInParameter(commandWrapper, "@CurrentYear", DbType.Decimal, entity.CurrentYear);
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, (entity.IsClosed.HasValue ? (object)entity.IsClosed : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FacultiesStartDate", DbType.DateTime, objAcadYearFaculty.StartDate);
            database.AddInParameter(commandWrapper, "@FacultiesEndDate", DbType.DateTime, objAcadYearFaculty.EndDate);
            if(_AsFacultyInfoID.HasValue)
                database.AddInParameter(commandWrapper, "@AsFacultyInfoID", DbType.Decimal, _AsFacultyInfoID);
            if(_AsCode_DegreeClassID.HasValue)
                database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, _AsCode_DegreeClassID);
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

            decimal id = (decimal)database.GetParameterValue(commandWrapper, "@EdAcadYearId");
            entity.OriginalEdAcadYearId = entity.EdAcadYearId = id;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdAcadYear entity,EdAcadYearFaculty objAcadyearFac)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_ACAD_YEAR_Update_Custom", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, entity.EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdAcadYearFacultyId", DbType.Decimal, objAcadyearFac.EdAcadYearFacultyId);
            database.AddInParameter(commandWrapper, "@DescrAr", DbType.String, entity.DescrAr);
            database.AddInParameter(commandWrapper, "@DescrEn", DbType.String, entity.DescrEn);
            database.AddInParameter(commandWrapper, "@YearCode", DbType.String, entity.YearCode);
            database.AddInParameter(commandWrapper, "@YearOrder", DbType.Decimal, entity.YearOrder);
            database.AddInParameter(commandWrapper, "@YearCalender", DbType.Decimal, entity.YearCalender);
            database.AddInParameter(commandWrapper, "@CurrentYear", DbType.Decimal, objAcadyearFac.CurrentYear);
            database.AddInParameter(commandWrapper, "@IsClosed", DbType.Decimal, (objAcadyearFac.IsClosed.HasValue ? (object)objAcadyearFac.IsClosed : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FacultiesStartDate", DbType.DateTime,  objAcadyearFac.StartDate);
            database.AddInParameter(commandWrapper, "@FacultiesEndDate", DbType.DateTime,  objAcadyearFac.EndDate);

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

            entity.OriginalEdAcadYearId = entity.EdAcadYearId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

            return Convert.ToBoolean(results);
        }
        #endregion
	}
}