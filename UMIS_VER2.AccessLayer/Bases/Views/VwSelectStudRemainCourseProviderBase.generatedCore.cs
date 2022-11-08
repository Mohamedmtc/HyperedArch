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
	/// This class is the base class for any <see cref="VwSelectStudRemainCourseProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwSelectStudRemainCourseProviderBaseCore : EntityViewProviderBase<VwSelectStudRemainCourse>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwSelectStudRemainCourse&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwSelectStudRemainCourse&gt;"/></returns>
		protected static VList&lt;VwSelectStudRemainCourse&gt; Fill(DataSet dataSet, VList<VwSelectStudRemainCourse> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwSelectStudRemainCourse>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwSelectStudRemainCourse&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwSelectStudRemainCourse>"/></returns>
		protected static VList&lt;VwSelectStudRemainCourse&gt; Fill(DataTable dataTable, VList<VwSelectStudRemainCourse> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwSelectStudRemainCourse c = new VwSelectStudRemainCourse();
					c.CourseDescrAr = (Convert.IsDBNull(row["COURSE_DESCR_AR"]))?string.Empty:(System.String)row["COURSE_DESCR_AR"];
					c.CourseDescrEn = (Convert.IsDBNull(row["COURSE_DESCR_EN"]))?string.Empty:(System.String)row["COURSE_DESCR_EN"];
					c.EdStudId = (Convert.IsDBNull(row["ED_STUD_ID"]))?0.0m:(System.Decimal)row["ED_STUD_ID"];
					c.EntMainId = (Convert.IsDBNull(row["ENT_MAIN_ID"]))?0.0m:(System.Decimal)row["ENT_MAIN_ID"];
					c.EdAcadYearId = (Convert.IsDBNull(row["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)row["ED_ACAD_YEAR_ID"];
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
		/// Fill an <see cref="VList&lt;VwSelectStudRemainCourse&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwSelectStudRemainCourse&gt;"/></returns>
		protected VList<VwSelectStudRemainCourse> Fill(IDataReader reader, VList<VwSelectStudRemainCourse> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwSelectStudRemainCourse entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwSelectStudRemainCourse>("VwSelectStudRemainCourse",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwSelectStudRemainCourse();
					}
					
					entity.SuppressEntityEvents = true;

					entity.CourseDescrAr = (System.String)reader[((int)VwSelectStudRemainCourseColumn.CourseDescrAr)];
					//entity.CourseDescrAr = (Convert.IsDBNull(reader["COURSE_DESCR_AR"]))?string.Empty:(System.String)reader["COURSE_DESCR_AR"];
					entity.CourseDescrEn = (reader.IsDBNull(((int)VwSelectStudRemainCourseColumn.CourseDescrEn)))?null:(System.String)reader[((int)VwSelectStudRemainCourseColumn.CourseDescrEn)];
					//entity.CourseDescrEn = (Convert.IsDBNull(reader["COURSE_DESCR_EN"]))?string.Empty:(System.String)reader["COURSE_DESCR_EN"];
					entity.EdStudId = (System.Decimal)reader[((int)VwSelectStudRemainCourseColumn.EdStudId)];
					//entity.EdStudId = (Convert.IsDBNull(reader["ED_STUD_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_ID"];
					entity.EntMainId = (System.Decimal)reader[((int)VwSelectStudRemainCourseColumn.EntMainId)];
					//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
					entity.EdAcadYearId = (reader.IsDBNull(((int)VwSelectStudRemainCourseColumn.EdAcadYearId)))?null:(System.Decimal?)reader[((int)VwSelectStudRemainCourseColumn.EdAcadYearId)];
					//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)reader["ED_ACAD_YEAR_ID"];
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
		/// Refreshes the <see cref="VwSelectStudRemainCourse"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSelectStudRemainCourse"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwSelectStudRemainCourse entity)
		{
			reader.Read();
			entity.CourseDescrAr = (System.String)reader[((int)VwSelectStudRemainCourseColumn.CourseDescrAr)];
			//entity.CourseDescrAr = (Convert.IsDBNull(reader["COURSE_DESCR_AR"]))?string.Empty:(System.String)reader["COURSE_DESCR_AR"];
			entity.CourseDescrEn = (reader.IsDBNull(((int)VwSelectStudRemainCourseColumn.CourseDescrEn)))?null:(System.String)reader[((int)VwSelectStudRemainCourseColumn.CourseDescrEn)];
			//entity.CourseDescrEn = (Convert.IsDBNull(reader["COURSE_DESCR_EN"]))?string.Empty:(System.String)reader["COURSE_DESCR_EN"];
			entity.EdStudId = (System.Decimal)reader[((int)VwSelectStudRemainCourseColumn.EdStudId)];
			//entity.EdStudId = (Convert.IsDBNull(reader["ED_STUD_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_ID"];
			entity.EntMainId = (System.Decimal)reader[((int)VwSelectStudRemainCourseColumn.EntMainId)];
			//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)VwSelectStudRemainCourseColumn.EdAcadYearId)))?null:(System.Decimal?)reader[((int)VwSelectStudRemainCourseColumn.EdAcadYearId)];
			//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)reader["ED_ACAD_YEAR_ID"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwSelectStudRemainCourse"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSelectStudRemainCourse"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwSelectStudRemainCourse entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.CourseDescrAr = (Convert.IsDBNull(dataRow["COURSE_DESCR_AR"]))?string.Empty:(System.String)dataRow["COURSE_DESCR_AR"];
			entity.CourseDescrEn = (Convert.IsDBNull(dataRow["COURSE_DESCR_EN"]))?string.Empty:(System.String)dataRow["COURSE_DESCR_EN"];
			entity.EdStudId = (Convert.IsDBNull(dataRow["ED_STUD_ID"]))?0.0m:(System.Decimal)dataRow["ED_STUD_ID"];
			entity.EntMainId = (Convert.IsDBNull(dataRow["ENT_MAIN_ID"]))?0.0m:(System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = (Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwSelectStudRemainCourseFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectStudRemainCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSelectStudRemainCourseFilterBuilder : SqlFilterBuilder<VwSelectStudRemainCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseFilterBuilder class.
		/// </summary>
		public VwSelectStudRemainCourseFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSelectStudRemainCourseFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSelectStudRemainCourseFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSelectStudRemainCourseFilterBuilder

	#region VwSelectStudRemainCourseParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectStudRemainCourse"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSelectStudRemainCourseParameterBuilder : ParameterizedSqlFilterBuilder<VwSelectStudRemainCourseColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseParameterBuilder class.
		/// </summary>
		public VwSelectStudRemainCourseParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSelectStudRemainCourseParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSelectStudRemainCourseParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSelectStudRemainCourseParameterBuilder
	
	#region VwSelectStudRemainCourseSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectStudRemainCourse"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwSelectStudRemainCourseSortBuilder : SqlSortBuilder<VwSelectStudRemainCourseColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectStudRemainCourseSqlSortBuilder class.
		/// </summary>
		public VwSelectStudRemainCourseSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwSelectStudRemainCourseSortBuilder

} // end namespace
