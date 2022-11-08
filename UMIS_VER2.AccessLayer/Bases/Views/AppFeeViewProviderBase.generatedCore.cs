#region Using directives

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="AppFeeViewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class AppFeeViewProviderBaseCore : EntityViewProviderBase<AppFeeView>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;AppFeeView&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;AppFeeView&gt;"/></returns>
		protected static VList&lt;AppFeeView&gt; Fill(DataSet dataSet, VList<AppFeeView> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<AppFeeView>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;AppFeeView&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<AppFeeView>"/></returns>
		protected static VList&lt;AppFeeView&gt; Fill(DataTable dataTable, VList<AppFeeView> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					AppFeeView c = new AppFeeView();
					c.DescrAr = (Convert.IsDBNull(row["DESCR_AR"]))?string.Empty:(System.String)row["DESCR_AR"];
					c.DescrEn = (Convert.IsDBNull(row["DESCR_EN"]))?string.Empty:(System.String)row["DESCR_EN"];
					c.Amount = (Convert.IsDBNull(row["AMOUNT"]))?0.0m:(System.Decimal)row["AMOUNT"];
					c.CurrencyDescrAr = (Convert.IsDBNull(row["CURRENCY_DESCR_AR"]))?string.Empty:(System.String)row["CURRENCY_DESCR_AR"];
					c.CurrencyDescrEn = (Convert.IsDBNull(row["CURRENCY_DESCR_EN"]))?string.Empty:(System.String)row["CURRENCY_DESCR_EN"];
					c.AutoloadFlg = (Convert.IsDBNull(row["AUTOLOAD_FLG"]))?0.0m:(System.Decimal)row["AUTOLOAD_FLG"];
					c.TransAppFlg = (Convert.IsDBNull(row["TRANS_APP_FLG"]))?0.0m:(System.Decimal)row["TRANS_APP_FLG"];
					c.AcceptChanges();
					rows.Add(c);
					pagelen -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		*/	
						
		///<summary>
		/// Fill an <see cref="VList&lt;AppFeeView&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;AppFeeView&gt;"/></returns>
		protected VList<AppFeeView> Fill(IDataReader reader, VList<AppFeeView> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					AppFeeView entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<AppFeeView>("AppFeeView",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new AppFeeView();
					}
					
					entity.SuppressEntityEvents = true;

					entity.DescrAr = (System.String)reader[((int)AppFeeViewColumn.DescrAr)];
					//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
					entity.DescrEn = (System.String)reader[((int)AppFeeViewColumn.DescrEn)];
					//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
					entity.Amount = (System.Decimal)reader[((int)AppFeeViewColumn.Amount)];
					//entity.Amount = (Convert.IsDBNull(reader["AMOUNT"]))?0.0m:(System.Decimal)reader["AMOUNT"];
					entity.CurrencyDescrAr = (System.String)reader[((int)AppFeeViewColumn.CurrencyDescrAr)];
					//entity.CurrencyDescrAr = (Convert.IsDBNull(reader["CURRENCY_DESCR_AR"]))?string.Empty:(System.String)reader["CURRENCY_DESCR_AR"];
					entity.CurrencyDescrEn = (reader.IsDBNull(((int)AppFeeViewColumn.CurrencyDescrEn)))?null:(System.String)reader[((int)AppFeeViewColumn.CurrencyDescrEn)];
					//entity.CurrencyDescrEn = (Convert.IsDBNull(reader["CURRENCY_DESCR_EN"]))?string.Empty:(System.String)reader["CURRENCY_DESCR_EN"];
					entity.AutoloadFlg = (System.Decimal)reader[((int)AppFeeViewColumn.AutoloadFlg)];
					//entity.AutoloadFlg = (Convert.IsDBNull(reader["AUTOLOAD_FLG"]))?0.0m:(System.Decimal)reader["AUTOLOAD_FLG"];
					entity.TransAppFlg = (System.Decimal)reader[((int)AppFeeViewColumn.TransAppFlg)];
					//entity.TransAppFlg = (Convert.IsDBNull(reader["TRANS_APP_FLG"]))?0.0m:(System.Decimal)reader["TRANS_APP_FLG"];
					entity.AcceptChanges();
					entity.SuppressEntityEvents = false;
					
					rows.Add(entity);
					pageLength -= 1;
				}
				recordnum += 1;
			}
			return rows;
		}
		
		
		/// <summary>
		/// Refreshes the <see cref="AppFeeView"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="AppFeeView"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, AppFeeView entity)
		{
			reader.Read();
			entity.DescrAr = (System.String)reader[((int)AppFeeViewColumn.DescrAr)];
			//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
			entity.DescrEn = (System.String)reader[((int)AppFeeViewColumn.DescrEn)];
			//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
			entity.Amount = (System.Decimal)reader[((int)AppFeeViewColumn.Amount)];
			//entity.Amount = (Convert.IsDBNull(reader["AMOUNT"]))?0.0m:(System.Decimal)reader["AMOUNT"];
			entity.CurrencyDescrAr = (System.String)reader[((int)AppFeeViewColumn.CurrencyDescrAr)];
			//entity.CurrencyDescrAr = (Convert.IsDBNull(reader["CURRENCY_DESCR_AR"]))?string.Empty:(System.String)reader["CURRENCY_DESCR_AR"];
			entity.CurrencyDescrEn = (reader.IsDBNull(((int)AppFeeViewColumn.CurrencyDescrEn)))?null:(System.String)reader[((int)AppFeeViewColumn.CurrencyDescrEn)];
			//entity.CurrencyDescrEn = (Convert.IsDBNull(reader["CURRENCY_DESCR_EN"]))?string.Empty:(System.String)reader["CURRENCY_DESCR_EN"];
			entity.AutoloadFlg = (System.Decimal)reader[((int)AppFeeViewColumn.AutoloadFlg)];
			//entity.AutoloadFlg = (Convert.IsDBNull(reader["AUTOLOAD_FLG"]))?0.0m:(System.Decimal)reader["AUTOLOAD_FLG"];
			entity.TransAppFlg = (System.Decimal)reader[((int)AppFeeViewColumn.TransAppFlg)];
			//entity.TransAppFlg = (Convert.IsDBNull(reader["TRANS_APP_FLG"]))?0.0m:(System.Decimal)reader["TRANS_APP_FLG"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="AppFeeView"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="AppFeeView"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, AppFeeView entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.DescrAr = (Convert.IsDBNull(dataRow["DESCR_AR"]))?string.Empty:(System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (Convert.IsDBNull(dataRow["DESCR_EN"]))?string.Empty:(System.String)dataRow["DESCR_EN"];
			entity.Amount = (Convert.IsDBNull(dataRow["AMOUNT"]))?0.0m:(System.Decimal)dataRow["AMOUNT"];
			entity.CurrencyDescrAr = (Convert.IsDBNull(dataRow["CURRENCY_DESCR_AR"]))?string.Empty:(System.String)dataRow["CURRENCY_DESCR_AR"];
			entity.CurrencyDescrEn = (Convert.IsDBNull(dataRow["CURRENCY_DESCR_EN"]))?string.Empty:(System.String)dataRow["CURRENCY_DESCR_EN"];
			entity.AutoloadFlg = (Convert.IsDBNull(dataRow["AUTOLOAD_FLG"]))?0.0m:(System.Decimal)dataRow["AUTOLOAD_FLG"];
			entity.TransAppFlg = (Convert.IsDBNull(dataRow["TRANS_APP_FLG"]))?0.0m:(System.Decimal)dataRow["TRANS_APP_FLG"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region AppFeeViewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AppFeeView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AppFeeViewFilterBuilder : SqlFilterBuilder<AppFeeViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AppFeeViewFilterBuilder class.
		/// </summary>
		public AppFeeViewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AppFeeViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AppFeeViewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AppFeeViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AppFeeViewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AppFeeViewFilterBuilder

	#region AppFeeViewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AppFeeView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class AppFeeViewParameterBuilder : ParameterizedSqlFilterBuilder<AppFeeViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AppFeeViewParameterBuilder class.
		/// </summary>
		public AppFeeViewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the AppFeeViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public AppFeeViewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the AppFeeViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public AppFeeViewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion AppFeeViewParameterBuilder
	
	#region AppFeeViewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="AppFeeView"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class AppFeeViewSortBuilder : SqlSortBuilder<AppFeeViewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the AppFeeViewSqlSortBuilder class.
		/// </summary>
		public AppFeeViewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion AppFeeViewSortBuilder

} // end namespace
