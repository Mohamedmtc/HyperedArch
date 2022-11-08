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
	/// This class is the base class for any <see cref="ApplicantRequiredDocumentViewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ApplicantRequiredDocumentViewProviderBaseCore : EntityViewProviderBase<ApplicantRequiredDocumentView>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ApplicantRequiredDocumentView&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ApplicantRequiredDocumentView&gt;"/></returns>
		protected static VList&lt;ApplicantRequiredDocumentView&gt; Fill(DataSet dataSet, VList<ApplicantRequiredDocumentView> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ApplicantRequiredDocumentView>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ApplicantRequiredDocumentView&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ApplicantRequiredDocumentView>"/></returns>
		protected static VList&lt;ApplicantRequiredDocumentView&gt; Fill(DataTable dataTable, VList<ApplicantRequiredDocumentView> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ApplicantRequiredDocumentView c = new ApplicantRequiredDocumentView();
					c.EntMainId = (Convert.IsDBNull(row["ENT_MAIN_ID"]))?0.0m:(System.Decimal)row["ENT_MAIN_ID"];
					c.EntDescrAr = (Convert.IsDBNull(row["ENT_DESCR_AR"]))?string.Empty:(System.String)row["ENT_DESCR_AR"];
					c.EntDescrEn = (Convert.IsDBNull(row["ENT_DESCR_EN"]))?string.Empty:(System.String)row["ENT_DESCR_EN"];
					c.DescrAr = (Convert.IsDBNull(row["DESCR_AR"]))?string.Empty:(System.String)row["DESCR_AR"];
					c.DescrEn = (Convert.IsDBNull(row["DESCR_EN"]))?string.Empty:(System.String)row["DESCR_EN"];
					c.DocTypeFlg = (Convert.IsDBNull(row["DOC_TYPE_FLG"]))?0.0m:(System.Decimal)row["DOC_TYPE_FLG"];
					c.ClassDescrAr = (Convert.IsDBNull(row["CLASS_DESCR_AR"]))?string.Empty:(System.String)row["CLASS_DESCR_AR"];
					c.ClassDescrEn = (Convert.IsDBNull(row["CLASS_DESCR_EN"]))?string.Empty:(System.String)row["CLASS_DESCR_EN"];
					c.AsCodeDegreeClassId = (Convert.IsDBNull(row["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal?)row["AS_CODE_DEGREE_CLASS_ID"];
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
		/// Fill an <see cref="VList&lt;ApplicantRequiredDocumentView&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ApplicantRequiredDocumentView&gt;"/></returns>
		protected VList<ApplicantRequiredDocumentView> Fill(IDataReader reader, VList<ApplicantRequiredDocumentView> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ApplicantRequiredDocumentView entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ApplicantRequiredDocumentView>("ApplicantRequiredDocumentView",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ApplicantRequiredDocumentView();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EntMainId = (System.Decimal)reader[((int)ApplicantRequiredDocumentViewColumn.EntMainId)];
					//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
					entity.EntDescrAr = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.EntDescrAr)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.EntDescrAr)];
					//entity.EntDescrAr = (Convert.IsDBNull(reader["ENT_DESCR_AR"]))?string.Empty:(System.String)reader["ENT_DESCR_AR"];
					entity.EntDescrEn = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.EntDescrEn)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.EntDescrEn)];
					//entity.EntDescrEn = (Convert.IsDBNull(reader["ENT_DESCR_EN"]))?string.Empty:(System.String)reader["ENT_DESCR_EN"];
					entity.DescrAr = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.DescrAr)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.DescrAr)];
					//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
					entity.DescrEn = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.DescrEn)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.DescrEn)];
					//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
					entity.DocTypeFlg = (System.Decimal)reader[((int)ApplicantRequiredDocumentViewColumn.DocTypeFlg)];
					//entity.DocTypeFlg = (Convert.IsDBNull(reader["DOC_TYPE_FLG"]))?0.0m:(System.Decimal)reader["DOC_TYPE_FLG"];
					entity.ClassDescrAr = (System.String)reader[((int)ApplicantRequiredDocumentViewColumn.ClassDescrAr)];
					//entity.ClassDescrAr = (Convert.IsDBNull(reader["CLASS_DESCR_AR"]))?string.Empty:(System.String)reader["CLASS_DESCR_AR"];
					entity.ClassDescrEn = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.ClassDescrEn)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.ClassDescrEn)];
					//entity.ClassDescrEn = (Convert.IsDBNull(reader["CLASS_DESCR_EN"]))?string.Empty:(System.String)reader["CLASS_DESCR_EN"];
					entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.AsCodeDegreeClassId)))?null:(System.Decimal?)reader[((int)ApplicantRequiredDocumentViewColumn.AsCodeDegreeClassId)];
					//entity.AsCodeDegreeClassId = (Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
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
		/// Refreshes the <see cref="ApplicantRequiredDocumentView"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ApplicantRequiredDocumentView"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ApplicantRequiredDocumentView entity)
		{
			reader.Read();
			entity.EntMainId = (System.Decimal)reader[((int)ApplicantRequiredDocumentViewColumn.EntMainId)];
			//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
			entity.EntDescrAr = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.EntDescrAr)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.EntDescrAr)];
			//entity.EntDescrAr = (Convert.IsDBNull(reader["ENT_DESCR_AR"]))?string.Empty:(System.String)reader["ENT_DESCR_AR"];
			entity.EntDescrEn = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.EntDescrEn)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.EntDescrEn)];
			//entity.EntDescrEn = (Convert.IsDBNull(reader["ENT_DESCR_EN"]))?string.Empty:(System.String)reader["ENT_DESCR_EN"];
			entity.DescrAr = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.DescrAr)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.DescrAr)];
			//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
			entity.DescrEn = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.DescrEn)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.DescrEn)];
			//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
			entity.DocTypeFlg = (System.Decimal)reader[((int)ApplicantRequiredDocumentViewColumn.DocTypeFlg)];
			//entity.DocTypeFlg = (Convert.IsDBNull(reader["DOC_TYPE_FLG"]))?0.0m:(System.Decimal)reader["DOC_TYPE_FLG"];
			entity.ClassDescrAr = (System.String)reader[((int)ApplicantRequiredDocumentViewColumn.ClassDescrAr)];
			//entity.ClassDescrAr = (Convert.IsDBNull(reader["CLASS_DESCR_AR"]))?string.Empty:(System.String)reader["CLASS_DESCR_AR"];
			entity.ClassDescrEn = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.ClassDescrEn)))?null:(System.String)reader[((int)ApplicantRequiredDocumentViewColumn.ClassDescrEn)];
			//entity.ClassDescrEn = (Convert.IsDBNull(reader["CLASS_DESCR_EN"]))?string.Empty:(System.String)reader["CLASS_DESCR_EN"];
			entity.AsCodeDegreeClassId = (reader.IsDBNull(((int)ApplicantRequiredDocumentViewColumn.AsCodeDegreeClassId)))?null:(System.Decimal?)reader[((int)ApplicantRequiredDocumentViewColumn.AsCodeDegreeClassId)];
			//entity.AsCodeDegreeClassId = (Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal?)reader["AS_CODE_DEGREE_CLASS_ID"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ApplicantRequiredDocumentView"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ApplicantRequiredDocumentView"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ApplicantRequiredDocumentView entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMainId = (Convert.IsDBNull(dataRow["ENT_MAIN_ID"]))?0.0m:(System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EntDescrAr = (Convert.IsDBNull(dataRow["ENT_DESCR_AR"]))?string.Empty:(System.String)dataRow["ENT_DESCR_AR"];
			entity.EntDescrEn = (Convert.IsDBNull(dataRow["ENT_DESCR_EN"]))?string.Empty:(System.String)dataRow["ENT_DESCR_EN"];
			entity.DescrAr = (Convert.IsDBNull(dataRow["DESCR_AR"]))?string.Empty:(System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (Convert.IsDBNull(dataRow["DESCR_EN"]))?string.Empty:(System.String)dataRow["DESCR_EN"];
			entity.DocTypeFlg = (Convert.IsDBNull(dataRow["DOC_TYPE_FLG"]))?0.0m:(System.Decimal)dataRow["DOC_TYPE_FLG"];
			entity.ClassDescrAr = (Convert.IsDBNull(dataRow["CLASS_DESCR_AR"]))?string.Empty:(System.String)dataRow["CLASS_DESCR_AR"];
			entity.ClassDescrEn = (Convert.IsDBNull(dataRow["CLASS_DESCR_EN"]))?string.Empty:(System.String)dataRow["CLASS_DESCR_EN"];
			entity.AsCodeDegreeClassId = (Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal?)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ApplicantRequiredDocumentViewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantRequiredDocumentView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ApplicantRequiredDocumentViewFilterBuilder : SqlFilterBuilder<ApplicantRequiredDocumentViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewFilterBuilder class.
		/// </summary>
		public ApplicantRequiredDocumentViewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ApplicantRequiredDocumentViewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ApplicantRequiredDocumentViewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ApplicantRequiredDocumentViewFilterBuilder

	#region ApplicantRequiredDocumentViewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantRequiredDocumentView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ApplicantRequiredDocumentViewParameterBuilder : ParameterizedSqlFilterBuilder<ApplicantRequiredDocumentViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewParameterBuilder class.
		/// </summary>
		public ApplicantRequiredDocumentViewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ApplicantRequiredDocumentViewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ApplicantRequiredDocumentViewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ApplicantRequiredDocumentViewParameterBuilder
	
	#region ApplicantRequiredDocumentViewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantRequiredDocumentView"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ApplicantRequiredDocumentViewSortBuilder : SqlSortBuilder<ApplicantRequiredDocumentViewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantRequiredDocumentViewSqlSortBuilder class.
		/// </summary>
		public ApplicantRequiredDocumentViewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ApplicantRequiredDocumentViewSortBuilder

} // end namespace
