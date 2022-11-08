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
	/// This class is the base class for any <see cref="CoursePkgProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class CoursePkgProviderBaseCore : EntityViewProviderBase<CoursePkg>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;CoursePkg&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;CoursePkg&gt;"/></returns>
		protected static VList&lt;CoursePkg&gt; Fill(DataSet dataSet, VList<CoursePkg> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<CoursePkg>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;CoursePkg&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<CoursePkg>"/></returns>
		protected static VList&lt;CoursePkg&gt; Fill(DataTable dataTable, VList<CoursePkg> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					CoursePkg c = new CoursePkg();
					c.EntMainId = (Convert.IsDBNull(row["ENT_MAIN_ID"]))?0.0m:(System.Decimal)row["ENT_MAIN_ID"];
					c.EdAcadYearId = (Convert.IsDBNull(row["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)row["ED_ACAD_YEAR_ID"];
					c.EdCourseId = (Convert.IsDBNull(row["ED_COURSE_ID"]))?0.0m:(System.Decimal?)row["ED_COURSE_ID"];
					c.EdCourseExpPrereqHdrId = (Convert.IsDBNull(row["ED_COURSE_EXP_PREREQ_HDR_ID"]))?0.0m:(System.Decimal?)row["ED_COURSE_EXP_PREREQ_HDR_ID"];
					c.AddGpaFlg = (Convert.IsDBNull(row["ADD_GPA_FLG"]))?0.0m:(System.Decimal)row["ADD_GPA_FLG"];
					c.AddMjrgpaFlg = (Convert.IsDBNull(row["ADD_MJRGPA_FLG"]))?0.0m:(System.Decimal?)row["ADD_MJRGPA_FLG"];
					c.EntCoursePkgHdrId = (Convert.IsDBNull(row["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)row["ENT_COURSE_PKG_HDR_ID"];
					c.DescrEn = (Convert.IsDBNull(row["DESCR_EN"]))?string.Empty:(System.String)row["DESCR_EN"];
					c.DescrAr = (Convert.IsDBNull(row["DESCR_AR"]))?string.Empty:(System.String)row["DESCR_AR"];
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
		/// Fill an <see cref="VList&lt;CoursePkg&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;CoursePkg&gt;"/></returns>
		protected VList<CoursePkg> Fill(IDataReader reader, VList<CoursePkg> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					CoursePkg entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<CoursePkg>("CoursePkg",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new CoursePkg();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EntMainId = (System.Decimal)reader[((int)CoursePkgColumn.EntMainId)];
					//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
					entity.EdAcadYearId = (reader.IsDBNull(((int)CoursePkgColumn.EdAcadYearId)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.EdAcadYearId)];
					//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)reader["ED_ACAD_YEAR_ID"];
					entity.EdCourseId = (reader.IsDBNull(((int)CoursePkgColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.EdCourseId)];
					//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
					entity.EdCourseExpPrereqHdrId = (reader.IsDBNull(((int)CoursePkgColumn.EdCourseExpPrereqHdrId)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.EdCourseExpPrereqHdrId)];
					//entity.EdCourseExpPrereqHdrId = (Convert.IsDBNull(reader["ED_COURSE_EXP_PREREQ_HDR_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_EXP_PREREQ_HDR_ID"];
					entity.AddGpaFlg = (System.Decimal)reader[((int)CoursePkgColumn.AddGpaFlg)];
					//entity.AddGpaFlg = (Convert.IsDBNull(reader["ADD_GPA_FLG"]))?0.0m:(System.Decimal)reader["ADD_GPA_FLG"];
					entity.AddMjrgpaFlg = (reader.IsDBNull(((int)CoursePkgColumn.AddMjrgpaFlg)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.AddMjrgpaFlg)];
					//entity.AddMjrgpaFlg = (Convert.IsDBNull(reader["ADD_MJRGPA_FLG"]))?0.0m:(System.Decimal?)reader["ADD_MJRGPA_FLG"];
					entity.EntCoursePkgHdrId = (System.Decimal)reader[((int)CoursePkgColumn.EntCoursePkgHdrId)];
					//entity.EntCoursePkgHdrId = (Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
					entity.DescrEn = (reader.IsDBNull(((int)CoursePkgColumn.DescrEn)))?null:(System.String)reader[((int)CoursePkgColumn.DescrEn)];
					//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
					entity.DescrAr = (System.String)reader[((int)CoursePkgColumn.DescrAr)];
					//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
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
		/// Refreshes the <see cref="CoursePkg"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="CoursePkg"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, CoursePkg entity)
		{
			reader.Read();
			entity.EntMainId = (System.Decimal)reader[((int)CoursePkgColumn.EntMainId)];
			//entity.EntMainId = (Convert.IsDBNull(reader["ENT_MAIN_ID"]))?0.0m:(System.Decimal)reader["ENT_MAIN_ID"];
			entity.EdAcadYearId = (reader.IsDBNull(((int)CoursePkgColumn.EdAcadYearId)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.EdAcadYearId)];
			//entity.EdAcadYearId = (Convert.IsDBNull(reader["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)reader["ED_ACAD_YEAR_ID"];
			entity.EdCourseId = (reader.IsDBNull(((int)CoursePkgColumn.EdCourseId)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.EdCourseId)];
			//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_ID"];
			entity.EdCourseExpPrereqHdrId = (reader.IsDBNull(((int)CoursePkgColumn.EdCourseExpPrereqHdrId)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.EdCourseExpPrereqHdrId)];
			//entity.EdCourseExpPrereqHdrId = (Convert.IsDBNull(reader["ED_COURSE_EXP_PREREQ_HDR_ID"]))?0.0m:(System.Decimal?)reader["ED_COURSE_EXP_PREREQ_HDR_ID"];
			entity.AddGpaFlg = (System.Decimal)reader[((int)CoursePkgColumn.AddGpaFlg)];
			//entity.AddGpaFlg = (Convert.IsDBNull(reader["ADD_GPA_FLG"]))?0.0m:(System.Decimal)reader["ADD_GPA_FLG"];
			entity.AddMjrgpaFlg = (reader.IsDBNull(((int)CoursePkgColumn.AddMjrgpaFlg)))?null:(System.Decimal?)reader[((int)CoursePkgColumn.AddMjrgpaFlg)];
			//entity.AddMjrgpaFlg = (Convert.IsDBNull(reader["ADD_MJRGPA_FLG"]))?0.0m:(System.Decimal?)reader["ADD_MJRGPA_FLG"];
			entity.EntCoursePkgHdrId = (System.Decimal)reader[((int)CoursePkgColumn.EntCoursePkgHdrId)];
			//entity.EntCoursePkgHdrId = (Convert.IsDBNull(reader["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)reader["ENT_COURSE_PKG_HDR_ID"];
			entity.DescrEn = (reader.IsDBNull(((int)CoursePkgColumn.DescrEn)))?null:(System.String)reader[((int)CoursePkgColumn.DescrEn)];
			//entity.DescrEn = (Convert.IsDBNull(reader["DESCR_EN"]))?string.Empty:(System.String)reader["DESCR_EN"];
			entity.DescrAr = (System.String)reader[((int)CoursePkgColumn.DescrAr)];
			//entity.DescrAr = (Convert.IsDBNull(reader["DESCR_AR"]))?string.Empty:(System.String)reader["DESCR_AR"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="CoursePkg"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="CoursePkg"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, CoursePkg entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EntMainId = (Convert.IsDBNull(dataRow["ENT_MAIN_ID"]))?0.0m:(System.Decimal)dataRow["ENT_MAIN_ID"];
			entity.EdAcadYearId = (Convert.IsDBNull(dataRow["ED_ACAD_YEAR_ID"]))?0.0m:(System.Decimal?)dataRow["ED_ACAD_YEAR_ID"];
			entity.EdCourseId = (Convert.IsDBNull(dataRow["ED_COURSE_ID"]))?0.0m:(System.Decimal?)dataRow["ED_COURSE_ID"];
			entity.EdCourseExpPrereqHdrId = (Convert.IsDBNull(dataRow["ED_COURSE_EXP_PREREQ_HDR_ID"]))?0.0m:(System.Decimal?)dataRow["ED_COURSE_EXP_PREREQ_HDR_ID"];
			entity.AddGpaFlg = (Convert.IsDBNull(dataRow["ADD_GPA_FLG"]))?0.0m:(System.Decimal)dataRow["ADD_GPA_FLG"];
			entity.AddMjrgpaFlg = (Convert.IsDBNull(dataRow["ADD_MJRGPA_FLG"]))?0.0m:(System.Decimal?)dataRow["ADD_MJRGPA_FLG"];
			entity.EntCoursePkgHdrId = (Convert.IsDBNull(dataRow["ENT_COURSE_PKG_HDR_ID"]))?0.0m:(System.Decimal)dataRow["ENT_COURSE_PKG_HDR_ID"];
			entity.DescrEn = (Convert.IsDBNull(dataRow["DESCR_EN"]))?string.Empty:(System.String)dataRow["DESCR_EN"];
			entity.DescrAr = (Convert.IsDBNull(dataRow["DESCR_AR"]))?string.Empty:(System.String)dataRow["DESCR_AR"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region CoursePkgFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoursePkg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoursePkgFilterBuilder : SqlFilterBuilder<CoursePkgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoursePkgFilterBuilder class.
		/// </summary>
		public CoursePkgFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoursePkgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoursePkgFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoursePkgFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoursePkgFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoursePkgFilterBuilder

	#region CoursePkgParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoursePkg"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoursePkgParameterBuilder : ParameterizedSqlFilterBuilder<CoursePkgColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoursePkgParameterBuilder class.
		/// </summary>
		public CoursePkgParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the CoursePkgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public CoursePkgParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the CoursePkgParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public CoursePkgParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion CoursePkgParameterBuilder
	
	#region CoursePkgSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoursePkg"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class CoursePkgSortBuilder : SqlSortBuilder<CoursePkgColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoursePkgSqlSortBuilder class.
		/// </summary>
		public CoursePkgSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion CoursePkgSortBuilder

} // end namespace
