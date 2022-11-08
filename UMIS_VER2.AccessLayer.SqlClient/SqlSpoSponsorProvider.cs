#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="SpoSponsor"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlSpoSponsorProvider: SqlSpoSponsorProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlSpoSponsorProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlSpoSponsorProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}

        #region Update Methods

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SpoSponsor entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SPO_SPONSOR_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@SpoSponsorId", DbType.Decimal, 9);
            database.AddInParameter(commandWrapper, "@SpoCode", DbType.String, entity.SpoCode);
            database.AddInParameter(commandWrapper, "@SpoAccountCode", DbType.String, entity.SpoAccountCode);
            database.AddInParameter(commandWrapper, "@NameAr", DbType.String, entity.NameAr);
            database.AddInParameter(commandWrapper, "@NameEn", DbType.String, entity.NameEn);
            database.AddInParameter(commandWrapper, "@Address", DbType.String, entity.Address);
            database.AddInParameter(commandWrapper, "@OfficeTel", DbType.String, entity.OfficeTel);
            database.AddInParameter(commandWrapper, "@Mobile", DbType.String, entity.Mobile);
            database.AddInParameter(commandWrapper, "@Email", DbType.String, entity.Email);
            database.AddInParameter(commandWrapper, "@Website", DbType.String, entity.Website);
            database.AddInParameter(commandWrapper, "@UnvSponsorFlag", DbType.String, entity.UnvSponsorFlag);
            database.AddInParameter(commandWrapper, "@SpoSponserTypeId", DbType.Decimal, (entity.SpoSponserTypeId.HasValue ? (object)entity.SpoSponserTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CoverRepeatedCoursesFlag", DbType.Decimal, (entity.CoverRepeatedCoursesFlag.HasValue ? (object)entity.CoverRepeatedCoursesFlag : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeeSponsorFlag", DbType.Decimal, (entity.FeeSponsorFlag.HasValue ? (object)entity.FeeSponsorFlag : 0));
            database.AddInParameter(commandWrapper, "@isActive", DbType.Decimal, (entity.IsActive.HasValue ? (object)entity.IsActive : 0));
            database.AddInParameter(commandWrapper, "@SpoFeeBalance", DbType.String, entity.SpoFeeBalance);
            database.AddInParameter(commandWrapper, "@EnumId", DbType.Int32, entity.EnumId);
            database.AddInParameter(commandWrapper,"@SeUserId", DbType.String, entity.SeUserId);
            database.AddInParameter(commandWrapper,"@LastDate", DbType.DateTime, entity.LastDate);
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

            entity.SpoSponsorId = decimal.Parse(commandWrapper.Parameters["@SpoSponsorId"].Value.ToString());
            entity.OriginalSpoSponsorId = entity.SpoSponsorId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion

        #region Custom Methods
        public override DataTable SearchSponser(TransactionManager transactionManager, System.String _SponserCode, System.String _NameEn, System.String _NameAr,
            System.Decimal _SponserTypeId, System.Decimal _PageIndex, System.Decimal _PageSize,bool? isActFlg=null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchSponser", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@SpoCode", DbType.String, _SponserCode);
            database.AddInParameter(commandWrapper, "@NameEn", DbType.String, _NameEn);
            database.AddInParameter(commandWrapper, "@NameAr", DbType.String, _NameAr);
            database.AddInParameter(commandWrapper, "@SpoSponserTypeId", DbType.Decimal, _SponserTypeId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, _PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, _PageSize);
            if (isActFlg!=null)
            {
                database.AddInParameter(commandWrapper, "@isActFlg", DbType.Decimal, isActFlg);
            }

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("SpoSponsorId");
            table.Columns.Add("SpoCode");
            table.Columns.Add("NameEn");
            table.Columns.Add("NameAr");
            table.Columns.Add("SpoSponserTypeId");
            table.Columns.Add("SpoSponserTypeNameEn");
            table.Columns.Add("SpoSponserTypeNameAr");
            table.Columns.Add("isActFlg");
            table.Columns.Add("RowsTotCount");


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
                        object[] items = { reader[0].ToString(),
                                             reader[1].ToString(),
                                             reader[2].ToString(),
                                             reader[3].ToString(),
                                             reader[4].ToString(),
                                             reader[5].ToString(),
                                             reader[6].ToString(),
                                             reader[7].ToString(),
                                             reader[8].ToString(),
                                          reader[9].ToString(),
                                         };
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


        #endregion

    }
}