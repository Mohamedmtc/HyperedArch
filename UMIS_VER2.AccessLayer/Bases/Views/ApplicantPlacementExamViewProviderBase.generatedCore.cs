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
	/// This class is the base class for any <see cref="ApplicantPlacementExamViewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ApplicantPlacementExamViewProviderBaseCore : EntityViewProviderBase<ApplicantPlacementExamView>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ApplicantPlacementExamView&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ApplicantPlacementExamView&gt;"/></returns>
		protected static VList&lt;ApplicantPlacementExamView&gt; Fill(DataSet dataSet, VList<ApplicantPlacementExamView> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ApplicantPlacementExamView>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ApplicantPlacementExamView&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ApplicantPlacementExamView>"/></returns>
		protected static VList&lt;ApplicantPlacementExamView&gt; Fill(DataTable dataTable, VList<ApplicantPlacementExamView> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ApplicantPlacementExamView c = new ApplicantPlacementExamView();
					c.EntMainId = (Convert.IsDBNull(row["ENT_MAIN_ID"]))?0.0m:(System.Decimal)row["ENT_MAIN_ID"];
					c.EntDescrAr = (Convert.IsDBNull(row["ENT_DESCR_AR"]))?string.Empty:(System.String)row["ENT_DESCR_AR"];
					c.EntDescrEn = (Convert.IsDBNull(row["ENT_DESCR_EN"]))?string.Empty:(System.String)row["ENT_DESCR_EN"];
					c.DescrAr = (Convert.IsDBNull(row["DESCR_AR"]))?string.Empty:(System.String)row["DESCR_AR"];
					c.DescrEn = (Convert.IsDBNull(row["DESCR_EN"]))?string.Empty:(System.String)row["DESCR_EN"];
					c.ExamTypeFlg = (Convert.IsDBNull(row["EXAM_TYPE_FLG"]))?0.0m:(System.Decimal)row["EXAM_TYPE_FLG"];
					c.ClassDescrAr = (Convert.IsDBNull(row["CLASS_DESCR_AR"]))?string.Empty:(System.String)row["CLASS_DESCR_AR"];
					c.ClassDescrEn = (Convert.IsDBNull(row["CLASS_DESCR_EN"]))?string.Empty:(System.String)row["CLASS_DESCR_EN"];
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
		/// Fill an <see cref="VList&lt;ApplicantPlacementExamView&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ApplicantPlacementExamView&gt;"/></returns>
		protected VList<ApplicantPlacementExamView> Fill(IDataReader reader, VList<ApplicantPlacementExamView> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ApplicantPlacementExamView entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ApplicantPlacementExamView>("ApplicantPlacementExamView",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ApplicantPlacementExamView();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EntMainId = (System.Decimal)reader[((int)ApplicantPlacementExamViewColumn.EntMainId)];
					//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
					entity.EntDescrAr = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.EntDescrAr)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.EntDescrAr)];
					//entity.EntDescrAr = (Convert.IsDBNull(reader["ENT_DESCR_AR"]))?string.Empty:(System.String)reader["ENT_DESCR_AR"];
					entity.EntDescrEn = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.EntDescrEn)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.EntDescrEn)];
					//entity.EntDescrEn = (Convert.IsDBNull(reader["ENT_DESCR_EN"]))?string.Empty:(System.String)reader["ENT_DESCR_EN"];
					entity.DescrAr = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.DescrAr)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.DescrAr)];
					//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
					entity.DescrEn = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.DescrEn)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.DescrEn)];
					//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
					entity.ExamTypeFlg = (System.Decimal)reader[((int)ApplicantPlacementExamViewColumn.ExamTypeFlg)];
					//entity.ExamTypeFlg = (Convert.IsDBNull(reader["EXAM_TYPE_FLG"]))?0.0m:(System.Decimal)reader["EXAM_TYPE_FLG"];
					entity.ClassDescrAr = (System.String)reader[((int)ApplicantPlacementExamViewColumn.ClassDescrAr)];
					//entity.ClassDescrAr = (Convert.IsDBNull(reader["CLASS_DESCR_AR"]))?string.Empty:(System.String)reader["CLASS_DESCR_AR"];
					entity.ClassDescrEn = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.ClassDescrEn)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.ClassDescrEn)];
					//entity.ClassDescrEn = (Convert.IsDBNull(reader["CLASS_DESCR_EN"]))?string.Empty:(System.String)reader["CLASS_DESCR_EN"];
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
		/// Refreshes the <see cref="ApplicantPlacementExamView"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ApplicantPlacementExamView"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ApplicantPlacementExamView entity)
		{
			reader.Read();
			entity.EntMainId = (System.Decimal)reader[((int)ApplicantPlacementExamViewColumn.EntMainId)];
			//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
			entity.EntDescrAr = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.EntDescrAr)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.EntDescrAr)];
			//entity.EntDescrAr = (Convert.IsDBNull(reader["ENT_DESCR_AR"]))?string.Empty:(System.String)reader["ENT_DESCR_AR"];
			entity.EntDescrEn = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.EntDescrEn)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.EntDescrEn)];
			//entity.EntDescrEn = (Convert.IsDBNull(reader["ENT_DESCR_EN"]))?string.Empty:(System.String)reader["ENT_DESCR_EN"];
			entity.DescrAr = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.DescrAr)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.DescrAr)];
			//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
			entity.DescrEn = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.DescrEn)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.DescrEn)];
			//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
			entity.ExamTypeFlg = (System.Decimal)reader[((int)ApplicantPlacementExamViewColumn.ExamTypeFlg)];
			//entity.ExamTypeFlg = (Convert.IsDBNull(reader["EXAM_TYPE_FLG"]))?0.0m:(System.Decimal)reader["EXAM_TYPE_FLG"];
			entity.ClassDescrAr = (System.String)reader[((int)ApplicantPlacementExamViewColumn.ClassDescrAr)];
			//entity.ClassDescrAr = (Convert.IsDBNull(reader["CLASS_DESCR_AR"]))?string.Empty:(System.String)reader["CLASS_DESCR_AR"];
			entity.ClassDescrEn = (reader.IsDBNull(((int)ApplicantPlacementExamViewColumn.ClassDescrEn)))?null:(System.String)reader[((int)ApplicantPlacementExamViewColumn.ClassDescrEn)];
			//entity.ClassDescrEn = (Convert.IsDBNull(reader["CLASS_DESCR_EN"]))?string.Empty:(System.String)reader["CLASS_DESCR_EN"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ApplicantPlacementExamView"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ApplicantPlacementExamView"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ApplicantPlacementExamView entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMainId = (Convert.IsDBNull(dataRow["ENT_MAIN_ID"]))?0.0m:(System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EntDescrAr = (Convert.IsDBNull(dataRow["ENT_DESCR_AR"]))?string.Empty:(System.String)dataRow["ENT_DESCR_AR"];
			entity.EntDescrEn = (Convert.IsDBNull(dataRow["ENT_DESCR_EN"]))?string.Empty:(System.String)dataRow["ENT_DESCR_EN"];
			entity.DescrAr = (Convert.IsDBNull(dataRow["DESCR_AR"]))?string.Empty:(System.String)dataRow["DESCR_AR"];
			entity.DescrEn = (Convert.IsDBNull(dataRow["DESCR_EN"]))?string.Empty:(System.String)dataRow["DESCR_EN"];
			entity.ExamTypeFlg = (Convert.IsDBNull(dataRow["EXAM_TYPE_FLG"]))?0.0m:(System.Decimal)dataRow["EXAM_TYPE_FLG"];
			entity.ClassDescrAr = (Convert.IsDBNull(dataRow["CLASS_DESCR_AR"]))?string.Empty:(System.String)dataRow["CLASS_DESCR_AR"];
			entity.ClassDescrEn = (Convert.IsDBNull(dataRow["CLASS_DESCR_EN"]))?string.Empty:(System.String)dataRow["CLASS_DESCR_EN"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ApplicantPlacementExamViewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantPlacementExamView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ApplicantPlacementExamViewFilterBuilder : SqlFilterBuilder<ApplicantPlacementExamViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewFilterBuilder class.
		/// </summary>
		public ApplicantPlacementExamViewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ApplicantPlacementExamViewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ApplicantPlacementExamViewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ApplicantPlacementExamViewFilterBuilder

	#region ApplicantPlacementExamViewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantPlacementExamView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ApplicantPlacementExamViewParameterBuilder : ParameterizedSqlFilterBuilder<ApplicantPlacementExamViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewParameterBuilder class.
		/// </summary>
		public ApplicantPlacementExamViewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ApplicantPlacementExamViewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ApplicantPlacementExamViewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ApplicantPlacementExamViewParameterBuilder
	
	#region ApplicantPlacementExamViewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantPlacementExamView"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ApplicantPlacementExamViewSortBuilder : SqlSortBuilder<ApplicantPlacementExamViewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantPlacementExamViewSqlSortBuilder class.
		/// </summary>
		public ApplicantPlacementExamViewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ApplicantPlacementExamViewSortBuilder

} // end namespace
