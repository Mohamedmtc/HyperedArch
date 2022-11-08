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
	/// This class is the base class for any <see cref="GetAllTransactionFeesViewB415102017ProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class GetAllTransactionFeesViewB415102017ProviderBaseCore : EntityViewProviderBase<GetAllTransactionFeesViewB415102017>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;GetAllTransactionFeesViewB415102017&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;GetAllTransactionFeesViewB415102017&gt;"/></returns>
		protected static VList&lt;GetAllTransactionFeesViewB415102017&gt; Fill(DataSet dataSet, VList<GetAllTransactionFeesViewB415102017> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<GetAllTransactionFeesViewB415102017>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;GetAllTransactionFeesViewB415102017&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<GetAllTransactionFeesViewB415102017>"/></returns>
		protected static VList&lt;GetAllTransactionFeesViewB415102017&gt; Fill(DataTable dataTable, VList<GetAllTransactionFeesViewB415102017> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					GetAllTransactionFeesViewB415102017 c = new GetAllTransactionFeesViewB415102017();
					c.EdStudId = (Convert.IsDBNull(row["EdStudId"]))?0.0m:(System.Decimal?)row["EdStudId"];
					c.FeesId = (Convert.IsDBNull(row["FeesId"]))?0.0m:(System.Decimal?)row["FeesId"];
					c.FeeCodeItemId = (Convert.IsDBNull(row["FeeCodeItemId"]))?0.0m:(System.Decimal)row["FeeCodeItemId"];
					c.TransactionDate = (Convert.IsDBNull(row["TransactionDate"]))?DateTime.MinValue:(System.DateTime?)row["TransactionDate"];
					c.YearId = (Convert.IsDBNull(row["YearId"]))?0.0m:(System.Decimal)row["YearId"];
					c.Semester = (Convert.IsDBNull(row["Semester"]))?0.0m:(System.Decimal?)row["Semester"];
					c.Depit = (Convert.IsDBNull(row["Depit"]))?0.0m:(System.Decimal?)row["Depit"];
					c.Credit = (Convert.IsDBNull(row["Credit"]))?0.0m:(System.Decimal?)row["Credit"];
					c.Credit2 = (Convert.IsDBNull(row["Credit2"]))?0.0m:(System.Decimal?)row["Credit2"];
					c.TransactionType = (Convert.IsDBNull(row["TransactionType"]))?(int)0:(System.Int32)row["TransactionType"];
					c.DiscType = (Convert.IsDBNull(row["DiscType"]))?0.0m:(System.Decimal?)row["DiscType"];
					c.DiscountStatus = (Convert.IsDBNull(row["DiscountStatus"]))?0.0m:(System.Decimal?)row["DiscountStatus"];
					c.DiscCat = (Convert.IsDBNull(row["DiscCat"]))?(int)0:(System.Int32?)row["DiscCat"];
					c.RefundType = (Convert.IsDBNull(row["RefundType"]))?(int)0:(System.Int32?)row["RefundType"];
					c.YearOfLoad = (Convert.IsDBNull(row["YearOfLoad"]))?0.0m:(System.Decimal?)row["YearOfLoad"];
					c.SemOfLoad = (Convert.IsDBNull(row["SemOfLoad"]))?0.0m:(System.Decimal?)row["SemOfLoad"];
					c.PayMethod = (Convert.IsDBNull(row["PayMethod"]))?0.0m:(System.Decimal?)row["PayMethod"];
					c.Credit3 = (Convert.IsDBNull(row["credit3"]))?0.0m:(System.Decimal?)row["credit3"];
					c.RefundValue = (Convert.IsDBNull(row["refundValue"]))?0.0m:(System.Decimal?)row["refundValue"];
					c.VouchearId = (Convert.IsDBNull(row["VouchearId"]))?0.0m:(System.Decimal?)row["VouchearId"];
					c.RecieptNum = (Convert.IsDBNull(row["recieptNum"]))?string.Empty:(System.String)row["recieptNum"];
					c.ApplicantId = (Convert.IsDBNull(row["ApplicantId"]))?0.0m:(System.Decimal?)row["ApplicantId"];
					c.FeeStudFeeItemId = (Convert.IsDBNull(row["FeeStudFeeItemId"]))?0.0m:(System.Decimal?)row["FeeStudFeeItemId"];
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
		/// Fill an <see cref="VList&lt;GetAllTransactionFeesViewB415102017&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;GetAllTransactionFeesViewB415102017&gt;"/></returns>
		protected VList<GetAllTransactionFeesViewB415102017> Fill(IDataReader reader, VList<GetAllTransactionFeesViewB415102017> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					GetAllTransactionFeesViewB415102017 entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<GetAllTransactionFeesViewB415102017>("GetAllTransactionFeesViewB415102017",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new GetAllTransactionFeesViewB415102017();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EdStudId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.EdStudId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.EdStudId)];
					//entity.EdStudId = (Convert.IsDBNull(reader["EdStudId"]))?0.0m:(System.Decimal?)reader["EdStudId"];
					entity.FeesId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.FeesId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.FeesId)];
					//entity.FeesId = (Convert.IsDBNull(reader["FeesId"]))?0.0m:(System.Decimal?)reader["FeesId"];
					entity.FeeCodeItemId = (System.Decimal)reader[((int)GetAllTransactionFeesViewB415102017Column.FeeCodeItemId)];
					//entity.FeeCodeItemId = (Convert.IsDBNull(reader["FeeCodeItemId"]))?0.0m:(System.Decimal)reader["FeeCodeItemId"];
					entity.TransactionDate = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.TransactionDate)))?null:(System.DateTime?)reader[((int)GetAllTransactionFeesViewB415102017Column.TransactionDate)];
					//entity.TransactionDate = (Convert.IsDBNull(reader["TransactionDate"]))?DateTime.MinValue:(System.DateTime?)reader["TransactionDate"];
					entity.YearId = (System.Decimal)reader[((int)GetAllTransactionFeesViewB415102017Column.YearId)];
					//entity.YearId = (Convert.IsDBNull(reader["YearId"]))?0.0m:(System.Decimal)reader["YearId"];
					entity.Semester = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Semester)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Semester)];
					//entity.Semester = (Convert.IsDBNull(reader["Semester"]))?0.0m:(System.Decimal?)reader["Semester"];
					entity.Depit = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Depit)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Depit)];
					//entity.Depit = (Convert.IsDBNull(reader["Depit"]))?0.0m:(System.Decimal?)reader["Depit"];
					entity.Credit = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Credit)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Credit)];
					//entity.Credit = (Convert.IsDBNull(reader["Credit"]))?0.0m:(System.Decimal?)reader["Credit"];
					entity.Credit2 = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Credit2)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Credit2)];
					//entity.Credit2 = (Convert.IsDBNull(reader["Credit2"]))?0.0m:(System.Decimal?)reader["Credit2"];
					entity.TransactionType = (System.Int32)reader[((int)GetAllTransactionFeesViewB415102017Column.TransactionType)];
					//entity.TransactionType = (Convert.IsDBNull(reader["TransactionType"]))?(int)0:(System.Int32)reader["TransactionType"];
					entity.DiscType = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.DiscType)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.DiscType)];
					//entity.DiscType = (Convert.IsDBNull(reader["DiscType"]))?0.0m:(System.Decimal?)reader["DiscType"];
					entity.DiscountStatus = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.DiscountStatus)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.DiscountStatus)];
					//entity.DiscountStatus = (Convert.IsDBNull(reader["DiscountStatus"]))?0.0m:(System.Decimal?)reader["DiscountStatus"];
					entity.DiscCat = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.DiscCat)))?null:(System.Int32?)reader[((int)GetAllTransactionFeesViewB415102017Column.DiscCat)];
					//entity.DiscCat = (Convert.IsDBNull(reader["DiscCat"]))?(int)0:(System.Int32?)reader["DiscCat"];
					entity.RefundType = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.RefundType)))?null:(System.Int32?)reader[((int)GetAllTransactionFeesViewB415102017Column.RefundType)];
					//entity.RefundType = (Convert.IsDBNull(reader["RefundType"]))?(int)0:(System.Int32?)reader["RefundType"];
					entity.YearOfLoad = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.YearOfLoad)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.YearOfLoad)];
					//entity.YearOfLoad = (Convert.IsDBNull(reader["YearOfLoad"]))?0.0m:(System.Decimal?)reader["YearOfLoad"];
					entity.SemOfLoad = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.SemOfLoad)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.SemOfLoad)];
					//entity.SemOfLoad = (Convert.IsDBNull(reader["SemOfLoad"]))?0.0m:(System.Decimal?)reader["SemOfLoad"];
					entity.PayMethod = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.PayMethod)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.PayMethod)];
					//entity.PayMethod = (Convert.IsDBNull(reader["PayMethod"]))?0.0m:(System.Decimal?)reader["PayMethod"];
					entity.Credit3 = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Credit3)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Credit3)];
					//entity.Credit3 = (Convert.IsDBNull(reader["credit3"]))?0.0m:(System.Decimal?)reader["credit3"];
					entity.RefundValue = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.RefundValue)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.RefundValue)];
					//entity.RefundValue = (Convert.IsDBNull(reader["refundValue"]))?0.0m:(System.Decimal?)reader["refundValue"];
					entity.VouchearId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.VouchearId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.VouchearId)];
					//entity.VouchearId = (Convert.IsDBNull(reader["VouchearId"]))?0.0m:(System.Decimal?)reader["VouchearId"];
					entity.RecieptNum = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.RecieptNum)))?null:(System.String)reader[((int)GetAllTransactionFeesViewB415102017Column.RecieptNum)];
					//entity.RecieptNum = (Convert.IsDBNull(reader["recieptNum"]))?string.Empty:(System.String)reader["recieptNum"];
					entity.ApplicantId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.ApplicantId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.ApplicantId)];
					//entity.ApplicantId = (Convert.IsDBNull(reader["ApplicantId"]))?0.0m:(System.Decimal?)reader["ApplicantId"];
					entity.FeeStudFeeItemId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.FeeStudFeeItemId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.FeeStudFeeItemId)];
					//entity.FeeStudFeeItemId = (Convert.IsDBNull(reader["FeeStudFeeItemId"]))?0.0m:(System.Decimal?)reader["FeeStudFeeItemId"];
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
		/// Refreshes the <see cref="GetAllTransactionFeesViewB415102017"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="GetAllTransactionFeesViewB415102017"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, GetAllTransactionFeesViewB415102017 entity)
		{
			reader.Read();
			entity.EdStudId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.EdStudId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.EdStudId)];
			//entity.EdStudId = (Convert.IsDBNull(reader["EdStudId"]))?0.0m:(System.Decimal?)reader["EdStudId"];
			entity.FeesId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.FeesId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.FeesId)];
			//entity.FeesId = (Convert.IsDBNull(reader["FeesId"]))?0.0m:(System.Decimal?)reader["FeesId"];
			entity.FeeCodeItemId = (System.Decimal)reader[((int)GetAllTransactionFeesViewB415102017Column.FeeCodeItemId)];
			//entity.FeeCodeItemId = (Convert.IsDBNull(reader["FeeCodeItemId"]))?0.0m:(System.Decimal)reader["FeeCodeItemId"];
			entity.TransactionDate = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.TransactionDate)))?null:(System.DateTime?)reader[((int)GetAllTransactionFeesViewB415102017Column.TransactionDate)];
			//entity.TransactionDate = (Convert.IsDBNull(reader["TransactionDate"]))?DateTime.MinValue:(System.DateTime?)reader["TransactionDate"];
			entity.YearId = (System.Decimal)reader[((int)GetAllTransactionFeesViewB415102017Column.YearId)];
			//entity.YearId = (Convert.IsDBNull(reader["YearId"]))?0.0m:(System.Decimal)reader["YearId"];
			entity.Semester = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Semester)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Semester)];
			//entity.Semester = (Convert.IsDBNull(reader["Semester"]))?0.0m:(System.Decimal?)reader["Semester"];
			entity.Depit = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Depit)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Depit)];
			//entity.Depit = (Convert.IsDBNull(reader["Depit"]))?0.0m:(System.Decimal?)reader["Depit"];
			entity.Credit = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Credit)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Credit)];
			//entity.Credit = (Convert.IsDBNull(reader["Credit"]))?0.0m:(System.Decimal?)reader["Credit"];
			entity.Credit2 = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Credit2)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Credit2)];
			//entity.Credit2 = (Convert.IsDBNull(reader["Credit2"]))?0.0m:(System.Decimal?)reader["Credit2"];
			entity.TransactionType = (System.Int32)reader[((int)GetAllTransactionFeesViewB415102017Column.TransactionType)];
			//entity.TransactionType = (Convert.IsDBNull(reader["TransactionType"]))?(int)0:(System.Int32)reader["TransactionType"];
			entity.DiscType = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.DiscType)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.DiscType)];
			//entity.DiscType = (Convert.IsDBNull(reader["DiscType"]))?0.0m:(System.Decimal?)reader["DiscType"];
			entity.DiscountStatus = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.DiscountStatus)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.DiscountStatus)];
			//entity.DiscountStatus = (Convert.IsDBNull(reader["DiscountStatus"]))?0.0m:(System.Decimal?)reader["DiscountStatus"];
			entity.DiscCat = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.DiscCat)))?null:(System.Int32?)reader[((int)GetAllTransactionFeesViewB415102017Column.DiscCat)];
			//entity.DiscCat = (Convert.IsDBNull(reader["DiscCat"]))?(int)0:(System.Int32?)reader["DiscCat"];
			entity.RefundType = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.RefundType)))?null:(System.Int32?)reader[((int)GetAllTransactionFeesViewB415102017Column.RefundType)];
			//entity.RefundType = (Convert.IsDBNull(reader["RefundType"]))?(int)0:(System.Int32?)reader["RefundType"];
			entity.YearOfLoad = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.YearOfLoad)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.YearOfLoad)];
			//entity.YearOfLoad = (Convert.IsDBNull(reader["YearOfLoad"]))?0.0m:(System.Decimal?)reader["YearOfLoad"];
			entity.SemOfLoad = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.SemOfLoad)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.SemOfLoad)];
			//entity.SemOfLoad = (Convert.IsDBNull(reader["SemOfLoad"]))?0.0m:(System.Decimal?)reader["SemOfLoad"];
			entity.PayMethod = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.PayMethod)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.PayMethod)];
			//entity.PayMethod = (Convert.IsDBNull(reader["PayMethod"]))?0.0m:(System.Decimal?)reader["PayMethod"];
			entity.Credit3 = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.Credit3)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.Credit3)];
			//entity.Credit3 = (Convert.IsDBNull(reader["credit3"]))?0.0m:(System.Decimal?)reader["credit3"];
			entity.RefundValue = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.RefundValue)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.RefundValue)];
			//entity.RefundValue = (Convert.IsDBNull(reader["refundValue"]))?0.0m:(System.Decimal?)reader["refundValue"];
			entity.VouchearId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.VouchearId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.VouchearId)];
			//entity.VouchearId = (Convert.IsDBNull(reader["VouchearId"]))?0.0m:(System.Decimal?)reader["VouchearId"];
			entity.RecieptNum = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.RecieptNum)))?null:(System.String)reader[((int)GetAllTransactionFeesViewB415102017Column.RecieptNum)];
			//entity.RecieptNum = (Convert.IsDBNull(reader["recieptNum"]))?string.Empty:(System.String)reader["recieptNum"];
			entity.ApplicantId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.ApplicantId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.ApplicantId)];
			//entity.ApplicantId = (Convert.IsDBNull(reader["ApplicantId"]))?0.0m:(System.Decimal?)reader["ApplicantId"];
			entity.FeeStudFeeItemId = (reader.IsDBNull(((int)GetAllTransactionFeesViewB415102017Column.FeeStudFeeItemId)))?null:(System.Decimal?)reader[((int)GetAllTransactionFeesViewB415102017Column.FeeStudFeeItemId)];
			//entity.FeeStudFeeItemId = (Convert.IsDBNull(reader["FeeStudFeeItemId"]))?0.0m:(System.Decimal?)reader["FeeStudFeeItemId"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="GetAllTransactionFeesViewB415102017"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="GetAllTransactionFeesViewB415102017"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, GetAllTransactionFeesViewB415102017 entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudId = (Convert.IsDBNull(dataRow["EdStudId"]))?0.0m:(System.Decimal?)dataRow["EdStudId"];
			entity.FeesId = (Convert.IsDBNull(dataRow["FeesId"]))?0.0m:(System.Decimal?)dataRow["FeesId"];
			entity.FeeCodeItemId = (Convert.IsDBNull(dataRow["FeeCodeItemId"]))?0.0m:(System.Decimal)dataRow["FeeCodeItemId"];
			entity.TransactionDate = (Convert.IsDBNull(dataRow["TransactionDate"]))?DateTime.MinValue:(System.DateTime?)dataRow["TransactionDate"];
			entity.YearId = (Convert.IsDBNull(dataRow["YearId"]))?0.0m:(System.Decimal)dataRow["YearId"];
			entity.Semester = (Convert.IsDBNull(dataRow["Semester"]))?0.0m:(System.Decimal?)dataRow["Semester"];
			entity.Depit = (Convert.IsDBNull(dataRow["Depit"]))?0.0m:(System.Decimal?)dataRow["Depit"];
			entity.Credit = (Convert.IsDBNull(dataRow["Credit"]))?0.0m:(System.Decimal?)dataRow["Credit"];
			entity.Credit2 = (Convert.IsDBNull(dataRow["Credit2"]))?0.0m:(System.Decimal?)dataRow["Credit2"];
			entity.TransactionType = (Convert.IsDBNull(dataRow["TransactionType"]))?(int)0:(System.Int32)dataRow["TransactionType"];
			entity.DiscType = (Convert.IsDBNull(dataRow["DiscType"]))?0.0m:(System.Decimal?)dataRow["DiscType"];
			entity.DiscountStatus = (Convert.IsDBNull(dataRow["DiscountStatus"]))?0.0m:(System.Decimal?)dataRow["DiscountStatus"];
			entity.DiscCat = (Convert.IsDBNull(dataRow["DiscCat"]))?(int)0:(System.Int32?)dataRow["DiscCat"];
			entity.RefundType = (Convert.IsDBNull(dataRow["RefundType"]))?(int)0:(System.Int32?)dataRow["RefundType"];
			entity.YearOfLoad = (Convert.IsDBNull(dataRow["YearOfLoad"]))?0.0m:(System.Decimal?)dataRow["YearOfLoad"];
			entity.SemOfLoad = (Convert.IsDBNull(dataRow["SemOfLoad"]))?0.0m:(System.Decimal?)dataRow["SemOfLoad"];
			entity.PayMethod = (Convert.IsDBNull(dataRow["PayMethod"]))?0.0m:(System.Decimal?)dataRow["PayMethod"];
			entity.Credit3 = (Convert.IsDBNull(dataRow["credit3"]))?0.0m:(System.Decimal?)dataRow["credit3"];
			entity.RefundValue = (Convert.IsDBNull(dataRow["refundValue"]))?0.0m:(System.Decimal?)dataRow["refundValue"];
			entity.VouchearId = (Convert.IsDBNull(dataRow["VouchearId"]))?0.0m:(System.Decimal?)dataRow["VouchearId"];
			entity.RecieptNum = (Convert.IsDBNull(dataRow["recieptNum"]))?string.Empty:(System.String)dataRow["recieptNum"];
			entity.ApplicantId = (Convert.IsDBNull(dataRow["ApplicantId"]))?0.0m:(System.Decimal?)dataRow["ApplicantId"];
			entity.FeeStudFeeItemId = (Convert.IsDBNull(dataRow["FeeStudFeeItemId"]))?0.0m:(System.Decimal?)dataRow["FeeStudFeeItemId"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region GetAllTransactionFeesViewB415102017FilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GetAllTransactionFeesViewB415102017"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GetAllTransactionFeesViewB415102017FilterBuilder : SqlFilterBuilder<GetAllTransactionFeesViewB415102017Column>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017FilterBuilder class.
		/// </summary>
		public GetAllTransactionFeesViewB415102017FilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017FilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GetAllTransactionFeesViewB415102017FilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017FilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GetAllTransactionFeesViewB415102017FilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GetAllTransactionFeesViewB415102017FilterBuilder

	#region GetAllTransactionFeesViewB415102017ParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GetAllTransactionFeesViewB415102017"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GetAllTransactionFeesViewB415102017ParameterBuilder : ParameterizedSqlFilterBuilder<GetAllTransactionFeesViewB415102017Column>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017ParameterBuilder class.
		/// </summary>
		public GetAllTransactionFeesViewB415102017ParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017ParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public GetAllTransactionFeesViewB415102017ParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017ParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public GetAllTransactionFeesViewB415102017ParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion GetAllTransactionFeesViewB415102017ParameterBuilder
	
	#region GetAllTransactionFeesViewB415102017SortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GetAllTransactionFeesViewB415102017"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class GetAllTransactionFeesViewB415102017SortBuilder : SqlSortBuilder<GetAllTransactionFeesViewB415102017Column>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GetAllTransactionFeesViewB415102017SqlSortBuilder class.
		/// </summary>
		public GetAllTransactionFeesViewB415102017SortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion GetAllTransactionFeesViewB415102017SortBuilder

} // end namespace
