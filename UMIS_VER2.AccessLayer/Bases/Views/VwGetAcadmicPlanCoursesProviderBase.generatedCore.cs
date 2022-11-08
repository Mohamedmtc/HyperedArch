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
	/// This class is the base class for any <see cref="VwGetAcadmicPlanCoursesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwGetAcadmicPlanCoursesProviderBaseCore : EntityViewProviderBase<VwGetAcadmicPlanCourses>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwGetAcadmicPlanCourses&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwGetAcadmicPlanCourses&gt;"/></returns>
		protected static VList&lt;VwGetAcadmicPlanCourses&gt; Fill(DataSet dataSet, VList<VwGetAcadmicPlanCourses> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwGetAcadmicPlanCourses>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwGetAcadmicPlanCourses&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwGetAcadmicPlanCourses>"/></returns>
		protected static VList&lt;VwGetAcadmicPlanCourses&gt; Fill(DataTable dataTable, VList<VwGetAcadmicPlanCourses> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwGetAcadmicPlanCourses c = new VwGetAcadmicPlanCourses();
					c.EdCourseId = (Convert.IsDBNull(row["ED_COURSE_ID"]))?0.0m:(System.Decimal?)row["ED_COURSE_ID"];
					c.AcadPlanEntityMainId = (Convert.IsDBNull(row["AcadPlanEntityMainID"]))?0.0m:(System.Decimal)row["AcadPlanEntityMainID"];
					c.AcadPalnYearId = (Convert.IsDBNull(row["AcadPalnYearID"]))?0.0m:(System.Decimal?)row["AcadPalnYearID"];
					c.PlanHdrEdCodesemesterId = (Convert.IsDBNull(row["PlanHdr_EdCodesemesterID"]))?0.0m:(System.Decimal)row["PlanHdr_EdCodesemesterID"];
					c.PlanHdrCodeLevelId = (Convert.IsDBNull(row["PlanHdr_CodeLevelID"]))?0.0m:(System.Decimal)row["PlanHdr_CodeLevelID"];
					c.PlanHdrLevelOrder = (Convert.IsDBNull(row["PlanHdr_LevelOrder"]))?0.0m:(System.Decimal?)row["PlanHdr_LevelOrder"];
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
		/// Fill an <see cref="VList&lt;VwGetAcadmicPlanCourses&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwGetAcadmicPlanCourses&gt;"/></returns>
		protected VList<VwGetAcadmicPlanCourses> Fill(IDataReader reader, VList<VwGetAcadmicPlanCourses> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwGetAcadmicPlanCourses entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwGetAcadmicPlanCourses>("VwGetAcadmicPlanCourses",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwGetAcadmicPlanCourses();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EdCourseId = (reader.IsDBNull(((int)VwGetAcadmicPlanCoursesColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)VwGetAcadmicPlanCoursesColumn.EdCourseId)];
					//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
					entity.AcadPlanEntityMainId = (System.Decimal)reader[((int)VwGetAcadmicPlanCoursesColumn.AcadPlanEntityMainId)];
					//entity.AcadPlanEntityMainId = (Convert.IsDBNull(reader["AcadPlanEntityMainID"]))?0.0m:(System.Decimal)reader["AcadPlanEntityMainID"];
					entity.AcadPalnYearId = (reader.IsDBNull(((int)VwGetAcadmicPlanCoursesColumn.AcadPalnYearId)))?null:(System.Decimal?)reader[((int)VwGetAcadmicPlanCoursesColumn.AcadPalnYearId)];
					//entity.AcadPalnYearId = (Convert.IsDBNull(reader["AcadPalnYearID"]))?0.0m:(System.Decimal?)reader["AcadPalnYearID"];
					entity.PlanHdrEdCodesemesterId = (System.Decimal)reader[((int)VwGetAcadmicPlanCoursesColumn.PlanHdrEdCodesemesterId)];
					//entity.PlanHdrEdCodesemesterId = (Convert.IsDBNull(reader["PlanHdr_EdCodesemesterID"]))?0.0m:(System.Decimal)reader["PlanHdr_EdCodesemesterID"];
					entity.PlanHdrCodeLevelId = (System.Decimal)reader[((int)VwGetAcadmicPlanCoursesColumn.PlanHdrCodeLevelId)];
					//entity.PlanHdrCodeLevelId = (Convert.IsDBNull(reader["PlanHdr_CodeLevelID"]))?0.0m:(System.Decimal)reader["PlanHdr_CodeLevelID"];
					entity.PlanHdrLevelOrder = (reader.IsDBNull(((int)VwGetAcadmicPlanCoursesColumn.PlanHdrLevelOrder)))?null:(System.Decimal?)reader[((int)VwGetAcadmicPlanCoursesColumn.PlanHdrLevelOrder)];
					//entity.PlanHdrLevelOrder = (Convert.IsDBNull(reader["PlanHdr_LevelOrder"]))?0.0m:(System.Decimal?)reader["PlanHdr_LevelOrder"];
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
		/// Refreshes the <see cref="VwGetAcadmicPlanCourses"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwGetAcadmicPlanCourses"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwGetAcadmicPlanCourses entity)
		{
			reader.Read();
			entity.EdCourseId = (reader.IsDBNull(((int)VwGetAcadmicPlanCoursesColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)VwGetAcadmicPlanCoursesColumn.EdCourseId)];
			//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
			entity.AcadPlanEntityMainId = (System.Decimal)reader[((int)VwGetAcadmicPlanCoursesColumn.AcadPlanEntityMainId)];
			//entity.AcadPlanEntityMainId = (Convert.IsDBNull(reader["AcadPlanEntityMainID"]))?0.0m:(System.Decimal)reader["AcadPlanEntityMainID"];
			entity.AcadPalnYearId = (reader.IsDBNull(((int)VwGetAcadmicPlanCoursesColumn.AcadPalnYearId)))?null:(System.Decimal?)reader[((int)VwGetAcadmicPlanCoursesColumn.AcadPalnYearId)];
			//entity.AcadPalnYearId = (Convert.IsDBNull(reader["AcadPalnYearID"]))?0.0m:(System.Decimal?)reader["AcadPalnYearID"];
			entity.PlanHdrEdCodesemesterId = (System.Decimal)reader[((int)VwGetAcadmicPlanCoursesColumn.PlanHdrEdCodesemesterId)];
			//entity.PlanHdrEdCodesemesterId = (Convert.IsDBNull(reader["PlanHdr_EdCodesemesterID"]))?0.0m:(System.Decimal)reader["PlanHdr_EdCodesemesterID"];
			entity.PlanHdrCodeLevelId = (System.Decimal)reader[((int)VwGetAcadmicPlanCoursesColumn.PlanHdrCodeLevelId)];
			//entity.PlanHdrCodeLevelId = (Convert.IsDBNull(reader["PlanHdr_CodeLevelID"]))?0.0m:(System.Decimal)reader["PlanHdr_CodeLevelID"];
			entity.PlanHdrLevelOrder = (reader.IsDBNull(((int)VwGetAcadmicPlanCoursesColumn.PlanHdrLevelOrder)))?null:(System.Decimal?)reader[((int)VwGetAcadmicPlanCoursesColumn.PlanHdrLevelOrder)];
			//entity.PlanHdrLevelOrder = (Convert.IsDBNull(reader["PlanHdr_LevelOrder"]))?0.0m:(System.Decimal?)reader["PlanHdr_LevelOrder"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwGetAcadmicPlanCourses"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwGetAcadmicPlanCourses"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwGetAcadmicPlanCourses entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdCourseId = (Convert.IsDBNull(dataRow["ED_COURSE_ID"]))?0.0m:(System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.AcadPlanEntityMainId = (Convert.IsDBNull(dataRow["AcadPlanEntityMainID"]))?0.0m:(System.Decimal)dataRow["AcadPlanEntityMainID"];
			entity.AcadPalnYearId = (Convert.IsDBNull(dataRow["AcadPalnYearID"]))?0.0m:(System.Decimal?)dataRow["AcadPalnYearID"];
			entity.PlanHdrEdCodesemesterId = (Convert.IsDBNull(dataRow["PlanHdr_EdCodesemesterID"]))?0.0m:(System.Decimal)dataRow["PlanHdr_EdCodesemesterID"];
			entity.PlanHdrCodeLevelId = (Convert.IsDBNull(dataRow["PlanHdr_CodeLevelID"]))?0.0m:(System.Decimal)dataRow["PlanHdr_CodeLevelID"];
			entity.PlanHdrLevelOrder = (Convert.IsDBNull(dataRow["PlanHdr_LevelOrder"]))?0.0m:(System.Decimal?)dataRow["PlanHdr_LevelOrder"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwGetAcadmicPlanCoursesFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwGetAcadmicPlanCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwGetAcadmicPlanCoursesFilterBuilder : SqlFilterBuilder<VwGetAcadmicPlanCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesFilterBuilder class.
		/// </summary>
		public VwGetAcadmicPlanCoursesFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwGetAcadmicPlanCoursesFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwGetAcadmicPlanCoursesFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwGetAcadmicPlanCoursesFilterBuilder

	#region VwGetAcadmicPlanCoursesParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwGetAcadmicPlanCourses"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwGetAcadmicPlanCoursesParameterBuilder : ParameterizedSqlFilterBuilder<VwGetAcadmicPlanCoursesColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesParameterBuilder class.
		/// </summary>
		public VwGetAcadmicPlanCoursesParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwGetAcadmicPlanCoursesParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwGetAcadmicPlanCoursesParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwGetAcadmicPlanCoursesParameterBuilder
	
	#region VwGetAcadmicPlanCoursesSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwGetAcadmicPlanCourses"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwGetAcadmicPlanCoursesSortBuilder : SqlSortBuilder<VwGetAcadmicPlanCoursesColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwGetAcadmicPlanCoursesSqlSortBuilder class.
		/// </summary>
		public VwGetAcadmicPlanCoursesSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwGetAcadmicPlanCoursesSortBuilder

} // end namespace
