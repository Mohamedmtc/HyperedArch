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
	/// This class is the base class for any <see cref="ApplicantStepsViewProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class ApplicantStepsViewProviderBaseCore : EntityViewProviderBase<ApplicantStepsView>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;ApplicantStepsView&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;ApplicantStepsView&gt;"/></returns>
		protected static VList&lt;ApplicantStepsView&gt; Fill(DataSet dataSet, VList<ApplicantStepsView> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<ApplicantStepsView>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;ApplicantStepsView&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<ApplicantStepsView>"/></returns>
		protected static VList&lt;ApplicantStepsView&gt; Fill(DataTable dataTable, VList<ApplicantStepsView> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					ApplicantStepsView c = new ApplicantStepsView();
					c.AdmRegStepsId = (Convert.IsDBNull(row["ADM_REG_STEPS_ID"]))?0.0m:(System.Decimal)row["ADM_REG_STEPS_ID"];
					c.StepNo = (Convert.IsDBNull(row["STEP_NO"]))?0.0m:(System.Decimal?)row["STEP_NO"];
					c.StepTitleAr = (Convert.IsDBNull(row["STEP_TITLE_AR"]))?string.Empty:(System.String)row["STEP_TITLE_AR"];
					c.StepTitleEn = (Convert.IsDBNull(row["STEP_TITLE_EN"]))?string.Empty:(System.String)row["STEP_TITLE_EN"];
					c.AppTypeRegStepsId = (Convert.IsDBNull(row["APP_TYPE_REG_STEPS_ID"]))?0.0m:(System.Decimal)row["APP_TYPE_REG_STEPS_ID"];
					c.MandatoryFlg = (Convert.IsDBNull(row["MANDATORY_FLG"]))?0.0m:(System.Decimal?)row["MANDATORY_FLG"];
					c.StepLastModified = (Convert.IsDBNull(row["STEP_LAST_MODIFIED"]))?DateTime.MinValue:(System.DateTime?)row["STEP_LAST_MODIFIED"];
					c.StepStatusFlg = (Convert.IsDBNull(row["STEP_STATUS_FLG"]))?0.0m:(System.Decimal?)row["STEP_STATUS_FLG"];
					c.AdmAppProcStepsId = (Convert.IsDBNull(row["ADM_APP_PROC_STEPS_ID"]))?0.0m:(System.Decimal)row["ADM_APP_PROC_STEPS_ID"];
					c.AdmApplicantId = (Convert.IsDBNull(row["ADM_APPLICANT_ID"]))?0.0m:(System.Decimal?)row["ADM_APPLICANT_ID"];
					c.AsCodeDegreeClassId = (Convert.IsDBNull(row["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal)row["AS_CODE_DEGREE_CLASS_ID"];
					c.TransFlg = (Convert.IsDBNull(row["TRANS_FLG"]))?0.0m:(System.Decimal?)row["TRANS_FLG"];
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
		/// Fill an <see cref="VList&lt;ApplicantStepsView&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;ApplicantStepsView&gt;"/></returns>
		protected VList<ApplicantStepsView> Fill(IDataReader reader, VList<ApplicantStepsView> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					ApplicantStepsView entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<ApplicantStepsView>("ApplicantStepsView",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new ApplicantStepsView();
					}
					
					entity.SuppressEntityEvents = true;

					entity.AdmRegStepsId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AdmRegStepsId)];
					//entity.AdmRegStepsId = (Convert.IsDBNull(reader["ADM_REG_STEPS_ID"]))?0.0m:(System.Decimal)reader["ADM_REG_STEPS_ID"];
					entity.StepNo = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepNo)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.StepNo)];
					//entity.StepNo = (Convert.IsDBNull(reader["STEP_NO"]))?0.0m:(System.Decimal?)reader["STEP_NO"];
					entity.StepTitleAr = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepTitleAr)))?null:(System.String)reader[((int)ApplicantStepsViewColumn.StepTitleAr)];
					//entity.StepTitleAr = (Convert.IsDBNull(reader["STEP_TITLE_AR"]))?string.Empty:(System.String)reader["STEP_TITLE_AR"];
					entity.StepTitleEn = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepTitleEn)))?null:(System.String)reader[((int)ApplicantStepsViewColumn.StepTitleEn)];
					//entity.StepTitleEn = (Convert.IsDBNull(reader["STEP_TITLE_EN"]))?string.Empty:(System.String)reader["STEP_TITLE_EN"];
					entity.AppTypeRegStepsId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AppTypeRegStepsId)];
					//entity.AppTypeRegStepsId = (Convert.IsDBNull(reader["APP_TYPE_REG_STEPS_ID"]))?0.0m:(System.Decimal)reader["APP_TYPE_REG_STEPS_ID"];
					entity.MandatoryFlg = (reader.IsDBNull(((int)ApplicantStepsViewColumn.MandatoryFlg)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.MandatoryFlg)];
					//entity.MandatoryFlg = (Convert.IsDBNull(reader["MANDATORY_FLG"]))?0.0m:(System.Decimal?)reader["MANDATORY_FLG"];
					entity.StepLastModified = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepLastModified)))?null:(System.DateTime?)reader[((int)ApplicantStepsViewColumn.StepLastModified)];
					//entity.StepLastModified = (Convert.IsDBNull(reader["STEP_LAST_MODIFIED"]))?DateTime.MinValue:(System.DateTime?)reader["STEP_LAST_MODIFIED"];
					entity.StepStatusFlg = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepStatusFlg)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.StepStatusFlg)];
					//entity.StepStatusFlg = (Convert.IsDBNull(reader["STEP_STATUS_FLG"]))?0.0m:(System.Decimal?)reader["STEP_STATUS_FLG"];
					entity.AdmAppProcStepsId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AdmAppProcStepsId)];
					//entity.AdmAppProcStepsId = (Convert.IsDBNull(reader["ADM_APP_PROC_STEPS_ID"]))?0.0m:(System.Decimal)reader["ADM_APP_PROC_STEPS_ID"];
					entity.AdmApplicantId = (reader.IsDBNull(((int)ApplicantStepsViewColumn.AdmApplicantId)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.AdmApplicantId)];
					//entity.AdmApplicantId = (Convert.IsDBNull(reader["ADM_APPLICANT_ID"]))?0.0m:(System.Decimal?)reader["ADM_APPLICANT_ID"];
					entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AsCodeDegreeClassId)];
					//entity.AsCodeDegreeClassId = (Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
					entity.TransFlg = (reader.IsDBNull(((int)ApplicantStepsViewColumn.TransFlg)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.TransFlg)];
					//entity.TransFlg = (Convert.IsDBNull(reader["TRANS_FLG"]))?0.0m:(System.Decimal?)reader["TRANS_FLG"];
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
		/// Refreshes the <see cref="ApplicantStepsView"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="ApplicantStepsView"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, ApplicantStepsView entity)
		{
			reader.Read();
			entity.AdmRegStepsId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AdmRegStepsId)];
			//entity.AdmRegStepsId = (Convert.IsDBNull(reader["ADM_REG_STEPS_ID"]))?0.0m:(System.Decimal)reader["ADM_REG_STEPS_ID"];
			entity.StepNo = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepNo)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.StepNo)];
			//entity.StepNo = (Convert.IsDBNull(reader["STEP_NO"]))?0.0m:(System.Decimal?)reader["STEP_NO"];
			entity.StepTitleAr = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepTitleAr)))?null:(System.String)reader[((int)ApplicantStepsViewColumn.StepTitleAr)];
			//entity.StepTitleAr = (Convert.IsDBNull(reader["STEP_TITLE_AR"]))?string.Empty:(System.String)reader["STEP_TITLE_AR"];
			entity.StepTitleEn = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepTitleEn)))?null:(System.String)reader[((int)ApplicantStepsViewColumn.StepTitleEn)];
			//entity.StepTitleEn = (Convert.IsDBNull(reader["STEP_TITLE_EN"]))?string.Empty:(System.String)reader["STEP_TITLE_EN"];
			entity.AppTypeRegStepsId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AppTypeRegStepsId)];
			//entity.AppTypeRegStepsId = (Convert.IsDBNull(reader["APP_TYPE_REG_STEPS_ID"]))?0.0m:(System.Decimal)reader["APP_TYPE_REG_STEPS_ID"];
			entity.MandatoryFlg = (reader.IsDBNull(((int)ApplicantStepsViewColumn.MandatoryFlg)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.MandatoryFlg)];
			//entity.MandatoryFlg = (Convert.IsDBNull(reader["MANDATORY_FLG"]))?0.0m:(System.Decimal?)reader["MANDATORY_FLG"];
			entity.StepLastModified = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepLastModified)))?null:(System.DateTime?)reader[((int)ApplicantStepsViewColumn.StepLastModified)];
			//entity.StepLastModified = (Convert.IsDBNull(reader["STEP_LAST_MODIFIED"]))?DateTime.MinValue:(System.DateTime?)reader["STEP_LAST_MODIFIED"];
			entity.StepStatusFlg = (reader.IsDBNull(((int)ApplicantStepsViewColumn.StepStatusFlg)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.StepStatusFlg)];
			//entity.StepStatusFlg = (Convert.IsDBNull(reader["STEP_STATUS_FLG"]))?0.0m:(System.Decimal?)reader["STEP_STATUS_FLG"];
			entity.AdmAppProcStepsId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AdmAppProcStepsId)];
			//entity.AdmAppProcStepsId = (Convert.IsDBNull(reader["ADM_APP_PROC_STEPS_ID"]))?0.0m:(System.Decimal)reader["ADM_APP_PROC_STEPS_ID"];
			entity.AdmApplicantId = (reader.IsDBNull(((int)ApplicantStepsViewColumn.AdmApplicantId)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.AdmApplicantId)];
			//entity.AdmApplicantId = (Convert.IsDBNull(reader["ADM_APPLICANT_ID"]))?0.0m:(System.Decimal?)reader["ADM_APPLICANT_ID"];
			entity.AsCodeDegreeClassId = (System.Decimal)reader[((int)ApplicantStepsViewColumn.AsCodeDegreeClassId)];
			//entity.AsCodeDegreeClassId = (Convert.IsDBNull(reader["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal)reader["AS_CODE_DEGREE_CLASS_ID"];
			entity.TransFlg = (reader.IsDBNull(((int)ApplicantStepsViewColumn.TransFlg)))?null:(System.Decimal?)reader[((int)ApplicantStepsViewColumn.TransFlg)];
			//entity.TransFlg = (Convert.IsDBNull(reader["TRANS_FLG"]))?0.0m:(System.Decimal?)reader["TRANS_FLG"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="ApplicantStepsView"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="ApplicantStepsView"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, ApplicantStepsView entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.AdmRegStepsId = (Convert.IsDBNull(dataRow["ADM_REG_STEPS_ID"]))?0.0m:(System.Decimal)dataRow["ADM_REG_STEPS_ID"];
			entity.StepNo = (Convert.IsDBNull(dataRow["STEP_NO"]))?0.0m:(System.Decimal?)dataRow["STEP_NO"];
			entity.StepTitleAr = (Convert.IsDBNull(dataRow["STEP_TITLE_AR"]))?string.Empty:(System.String)dataRow["STEP_TITLE_AR"];
			entity.StepTitleEn = (Convert.IsDBNull(dataRow["STEP_TITLE_EN"]))?string.Empty:(System.String)dataRow["STEP_TITLE_EN"];
			entity.AppTypeRegStepsId = (Convert.IsDBNull(dataRow["APP_TYPE_REG_STEPS_ID"]))?0.0m:(System.Decimal)dataRow["APP_TYPE_REG_STEPS_ID"];
			entity.MandatoryFlg = (Convert.IsDBNull(dataRow["MANDATORY_FLG"]))?0.0m:(System.Decimal?)dataRow["MANDATORY_FLG"];
			entity.StepLastModified = (Convert.IsDBNull(dataRow["STEP_LAST_MODIFIED"]))?DateTime.MinValue:(System.DateTime?)dataRow["STEP_LAST_MODIFIED"];
			entity.StepStatusFlg = (Convert.IsDBNull(dataRow["STEP_STATUS_FLG"]))?0.0m:(System.Decimal?)dataRow["STEP_STATUS_FLG"];
			entity.AdmAppProcStepsId = (Convert.IsDBNull(dataRow["ADM_APP_PROC_STEPS_ID"]))?0.0m:(System.Decimal)dataRow["ADM_APP_PROC_STEPS_ID"];
			entity.AdmApplicantId = (Convert.IsDBNull(dataRow["ADM_APPLICANT_ID"]))?0.0m:(System.Decimal?)dataRow["ADM_APPLICANT_ID"];
			entity.AsCodeDegreeClassId = (Convert.IsDBNull(dataRow["AS_CODE_DEGREE_CLASS_ID"]))?0.0m:(System.Decimal)dataRow["AS_CODE_DEGREE_CLASS_ID"];
			entity.TransFlg = (Convert.IsDBNull(dataRow["TRANS_FLG"]))?0.0m:(System.Decimal?)dataRow["TRANS_FLG"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region ApplicantStepsViewFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantStepsView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ApplicantStepsViewFilterBuilder : SqlFilterBuilder<ApplicantStepsViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewFilterBuilder class.
		/// </summary>
		public ApplicantStepsViewFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ApplicantStepsViewFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ApplicantStepsViewFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ApplicantStepsViewFilterBuilder

	#region ApplicantStepsViewParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantStepsView"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ApplicantStepsViewParameterBuilder : ParameterizedSqlFilterBuilder<ApplicantStepsViewColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewParameterBuilder class.
		/// </summary>
		public ApplicantStepsViewParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public ApplicantStepsViewParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public ApplicantStepsViewParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion ApplicantStepsViewParameterBuilder
	
	#region ApplicantStepsViewSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ApplicantStepsView"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class ApplicantStepsViewSortBuilder : SqlSortBuilder<ApplicantStepsViewColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ApplicantStepsViewSqlSortBuilder class.
		/// </summary>
		public ApplicantStepsViewSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion ApplicantStepsViewSortBuilder

} // end namespace
