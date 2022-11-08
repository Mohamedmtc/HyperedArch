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
	/// This class is the base class for any <see cref="VwSelectDegreeAfterApplyRepeateRuleProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract class VwSelectDegreeAfterApplyRepeateRuleProviderBaseCore : EntityViewProviderBase<VwSelectDegreeAfterApplyRepeateRule>
	{
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions
		
		/*
		///<summary>
		/// Fill an VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt; From a DataSet
		///</summary>
		/// <param name="dataSet">the DataSet</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt;"/></returns>
		protected static VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt; Fill(DataSet dataSet, VList<VwSelectDegreeAfterApplyRepeateRule> rows, int start, int pagelen)
		{
			if (dataSet.Tables.Count == 1)
			{
				return Fill(dataSet.Tables[0], rows, start, pagelen);
			}
			else
			{
				return new VList<VwSelectDegreeAfterApplyRepeateRule>();
			}	
		}
		
		
		///<summary>
		/// Fill an VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt; From a DataTable
		///</summary>
		/// <param name="dataTable">the DataTable that hold the data.</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pagelen">number of row.</param>
		///<returns><see chref="VList<VwSelectDegreeAfterApplyRepeateRule>"/></returns>
		protected static VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt; Fill(DataTable dataTable, VList<VwSelectDegreeAfterApplyRepeateRule> rows, int start, int pagelen)
		{
			int recordnum = 0;
			
			System.Collections.IEnumerator dataRows =  dataTable.Rows.GetEnumerator();
			
			while (dataRows.MoveNext() && (pagelen != 0))
			{
				if(recordnum >= start)
				{
					DataRow row = (DataRow)dataRows.Current;
				
					VwSelectDegreeAfterApplyRepeateRule c = new VwSelectDegreeAfterApplyRepeateRule();
					c.EdStudId = (Convert.IsDBNull(row["ED_STUD_ID"]))?0.0m:(System.Decimal)row["ED_STUD_ID"];
					c.EdCourseId = (Convert.IsDBNull(row["ED_COURSE_ID"]))?0.0m:(System.Decimal)row["ED_COURSE_ID"];
					c.EdCodeSemesterTypeId = (Convert.IsDBNull(row["ED_CODE_SEMESTER_TYPE_ID"]))?0.0m:(System.Decimal?)row["ED_CODE_SEMESTER_TYPE_ID"];
					c.ExecuseFlg = (Convert.IsDBNull(row["ExecuseFlg"]))?0.0m:(System.Decimal?)row["ExecuseFlg"];
					c.PrevPassFail = (Convert.IsDBNull(row["Prev_passFail"]))?0.0m:(System.Decimal?)row["Prev_passFail"];
					c.CourseDegree = (Convert.IsDBNull(row["COURSE_DEGREE"]))?0.0m:(System.Decimal?)row["COURSE_DEGREE"];
					c.EdBylawId = (Convert.IsDBNull(row["ED_BYLAW_ID"]))?0.0m:(System.Decimal?)row["ED_BYLAW_ID"];
					c.EntPolicyCourseRepeatId = (Convert.IsDBNull(row["ENT_POLICY_COURSE_REPEAT_ID"]))?0.0m:(System.Decimal)row["ENT_POLICY_COURSE_REPEAT_ID"];
					c.EdStudSemesterId = (Convert.IsDBNull(row["ED_STUD_SEMESTER_ID"]))?0.0m:(System.Decimal)row["ED_STUD_SEMESTER_ID"];
					c.Aa = (Convert.IsDBNull(row["aa"]))?0.0m:(System.Decimal?)row["aa"];
					c.CourseMaxDeg = (Convert.IsDBNull(row["COURSE_MAX_DEG"]))?0.0m:(System.Decimal?)row["COURSE_MAX_DEG"];
					c.CrsDegreeFrmByLaw = (Convert.IsDBNull(row["CrsDegreeFrmByLaw"]))?0.0m:(System.Decimal?)row["CrsDegreeFrmByLaw"];
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
		/// Fill an <see cref="VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt;"/> From a DataReader.
		///</summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Start row</param>
		/// <param name="pageLength">number of row.</param>
		///<returns>a <see cref="VList&lt;VwSelectDegreeAfterApplyRepeateRule&gt;"/></returns>
		protected VList<VwSelectDegreeAfterApplyRepeateRule> Fill(IDataReader reader, VList<VwSelectDegreeAfterApplyRepeateRule> rows, int start, int pageLength)
		{
			int recordnum = 0;
			while (reader.Read() && (pageLength != 0))
			{
				if(recordnum >= start)
				{
					VwSelectDegreeAfterApplyRepeateRule entity = null;
					if (DataRepository.Provider.UseEntityFactory)
					{
						entity = EntityManager.CreateViewEntity<VwSelectDegreeAfterApplyRepeateRule>("VwSelectDegreeAfterApplyRepeateRule",  DataRepository.Provider.EntityCreationalFactoryType); 
					}
					else
					{
						entity = new VwSelectDegreeAfterApplyRepeateRule();
					}
					
					entity.SuppressEntityEvents = true;

					entity.EdStudId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdStudId)];
					//entity.EdStudId = (Convert.IsDBNull(reader["ED_STUD_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_ID"];
					entity.EdCourseId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdCourseId)];
					//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal)reader["ED_COURSE_ID"];
					entity.EdCodeSemesterTypeId = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdCodeSemesterTypeId)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdCodeSemesterTypeId)];
					//entity.EdCodeSemesterTypeId = (Convert.IsDBNull(reader["ED_CODE_SEMESTER_TYPE_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_SEMESTER_TYPE_ID"];
					entity.ExecuseFlg = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.ExecuseFlg)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.ExecuseFlg)];
					//entity.ExecuseFlg = (Convert.IsDBNull(reader["ExecuseFlg"]))?0.0m:(System.Decimal?)reader["ExecuseFlg"];
					entity.PrevPassFail = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.PrevPassFail)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.PrevPassFail)];
					//entity.PrevPassFail = (Convert.IsDBNull(reader["Prev_passFail"]))?0.0m:(System.Decimal?)reader["Prev_passFail"];
					entity.CourseDegree = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseDegree)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseDegree)];
					//entity.CourseDegree = (Convert.IsDBNull(reader["COURSE_DEGREE"]))?0.0m:(System.Decimal?)reader["COURSE_DEGREE"];
					entity.EdBylawId = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdBylawId)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdBylawId)];
					//entity.EdBylawId = (Convert.IsDBNull(reader["ED_BYLAW_ID"]))?0.0m:(System.Decimal?)reader["ED_BYLAW_ID"];
					entity.EntPolicyCourseRepeatId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EntPolicyCourseRepeatId)];
					//entity.EntPolicyCourseRepeatId = (Convert.IsDBNull(reader["ENT_POLICY_COURSE_REPEAT_ID"]))?0.0m:(System.Decimal)reader["ENT_POLICY_COURSE_REPEAT_ID"];
					entity.EdStudSemesterId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdStudSemesterId)];
					//entity.EdStudSemesterId = (Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_SEMESTER_ID"];
					entity.Aa = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.Aa)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.Aa)];
					//entity.Aa = (Convert.IsDBNull(reader["aa"]))?0.0m:(System.Decimal?)reader["aa"];
					entity.CourseMaxDeg = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseMaxDeg)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseMaxDeg)];
					//entity.CourseMaxDeg = (Convert.IsDBNull(reader["COURSE_MAX_DEG"]))?0.0m:(System.Decimal?)reader["COURSE_MAX_DEG"];
					entity.CrsDegreeFrmByLaw = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CrsDegreeFrmByLaw)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CrsDegreeFrmByLaw)];
					//entity.CrsDegreeFrmByLaw = (Convert.IsDBNull(reader["CrsDegreeFrmByLaw"]))?0.0m:(System.Decimal?)reader["CrsDegreeFrmByLaw"];
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
		/// Refreshes the <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object to refresh.</param>
		protected void RefreshEntity(IDataReader reader, VwSelectDegreeAfterApplyRepeateRule entity)
		{
			reader.Read();
			entity.EdStudId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdStudId)];
			//entity.EdStudId = (Convert.IsDBNull(reader["ED_STUD_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_ID"];
			entity.EdCourseId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdCourseId)];
			//entity.EdCourseId = (Convert.IsDBNull(reader["ED_COURSE_ID"]))?0.0m:(System.Decimal)reader["ED_COURSE_ID"];
			entity.EdCodeSemesterTypeId = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdCodeSemesterTypeId)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdCodeSemesterTypeId)];
			//entity.EdCodeSemesterTypeId = (Convert.IsDBNull(reader["ED_CODE_SEMESTER_TYPE_ID"]))?0.0m:(System.Decimal?)reader["ED_CODE_SEMESTER_TYPE_ID"];
			entity.ExecuseFlg = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.ExecuseFlg)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.ExecuseFlg)];
			//entity.ExecuseFlg = (Convert.IsDBNull(reader["ExecuseFlg"]))?0.0m:(System.Decimal?)reader["ExecuseFlg"];
			entity.PrevPassFail = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.PrevPassFail)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.PrevPassFail)];
			//entity.PrevPassFail = (Convert.IsDBNull(reader["Prev_passFail"]))?0.0m:(System.Decimal?)reader["Prev_passFail"];
			entity.CourseDegree = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseDegree)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseDegree)];
			//entity.CourseDegree = (Convert.IsDBNull(reader["COURSE_DEGREE"]))?0.0m:(System.Decimal?)reader["COURSE_DEGREE"];
			entity.EdBylawId = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdBylawId)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdBylawId)];
			//entity.EdBylawId = (Convert.IsDBNull(reader["ED_BYLAW_ID"]))?0.0m:(System.Decimal?)reader["ED_BYLAW_ID"];
			entity.EntPolicyCourseRepeatId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EntPolicyCourseRepeatId)];
			//entity.EntPolicyCourseRepeatId = (Convert.IsDBNull(reader["ENT_POLICY_COURSE_REPEAT_ID"]))?0.0m:(System.Decimal)reader["ENT_POLICY_COURSE_REPEAT_ID"];
			entity.EdStudSemesterId = (System.Decimal)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.EdStudSemesterId)];
			//entity.EdStudSemesterId = (Convert.IsDBNull(reader["ED_STUD_SEMESTER_ID"]))?0.0m:(System.Decimal)reader["ED_STUD_SEMESTER_ID"];
			entity.Aa = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.Aa)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.Aa)];
			//entity.Aa = (Convert.IsDBNull(reader["aa"]))?0.0m:(System.Decimal?)reader["aa"];
			entity.CourseMaxDeg = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseMaxDeg)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CourseMaxDeg)];
			//entity.CourseMaxDeg = (Convert.IsDBNull(reader["COURSE_MAX_DEG"]))?0.0m:(System.Decimal?)reader["COURSE_MAX_DEG"];
			entity.CrsDegreeFrmByLaw = (reader.IsDBNull(((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CrsDegreeFrmByLaw)))?null:(System.Decimal?)reader[((int)VwSelectDegreeAfterApplyRepeateRuleColumn.CrsDegreeFrmByLaw)];
			//entity.CrsDegreeFrmByLaw = (Convert.IsDBNull(reader["CrsDegreeFrmByLaw"]))?0.0m:(System.Decimal?)reader["CrsDegreeFrmByLaw"];
			reader.Close();
	
			entity.AcceptChanges();
		}
		
		/*
		/// <summary>
		/// Refreshes the <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object.</param>
		protected static void RefreshEntity(DataSet dataSet, VwSelectDegreeAfterApplyRepeateRule entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.EdStudId = (Convert.IsDBNull(dataRow["ED_STUD_ID"]))?0.0m:(System.Decimal)dataRow["ED_STUD_ID"];
			entity.EdCourseId = (Convert.IsDBNull(dataRow["ED_COURSE_ID"]))?0.0m:(System.Decimal)dataRow["ED_COURSE_ID"];
			entity.EdCodeSemesterTypeId = (Convert.IsDBNull(dataRow["ED_CODE_SEMESTER_TYPE_ID"]))?0.0m:(System.Decimal?)dataRow["ED_CODE_SEMESTER_TYPE_ID"];
			entity.ExecuseFlg = (Convert.IsDBNull(dataRow["ExecuseFlg"]))?0.0m:(System.Decimal?)dataRow["ExecuseFlg"];
			entity.PrevPassFail = (Convert.IsDBNull(dataRow["Prev_passFail"]))?0.0m:(System.Decimal?)dataRow["Prev_passFail"];
			entity.CourseDegree = (Convert.IsDBNull(dataRow["COURSE_DEGREE"]))?0.0m:(System.Decimal?)dataRow["COURSE_DEGREE"];
			entity.EdBylawId = (Convert.IsDBNull(dataRow["ED_BYLAW_ID"]))?0.0m:(System.Decimal?)dataRow["ED_BYLAW_ID"];
			entity.EntPolicyCourseRepeatId = (Convert.IsDBNull(dataRow["ENT_POLICY_COURSE_REPEAT_ID"]))?0.0m:(System.Decimal)dataRow["ENT_POLICY_COURSE_REPEAT_ID"];
			entity.EdStudSemesterId = (Convert.IsDBNull(dataRow["ED_STUD_SEMESTER_ID"]))?0.0m:(System.Decimal)dataRow["ED_STUD_SEMESTER_ID"];
			entity.Aa = (Convert.IsDBNull(dataRow["aa"]))?0.0m:(System.Decimal?)dataRow["aa"];
			entity.CourseMaxDeg = (Convert.IsDBNull(dataRow["COURSE_MAX_DEG"]))?0.0m:(System.Decimal?)dataRow["COURSE_MAX_DEG"];
			entity.CrsDegreeFrmByLaw = (Convert.IsDBNull(dataRow["CrsDegreeFrmByLaw"]))?0.0m:(System.Decimal?)dataRow["CrsDegreeFrmByLaw"];
			entity.AcceptChanges();
		}
		*/
			
		#endregion Helper Functions
	}//end class

	#region VwSelectDegreeAfterApplyRepeateRuleFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSelectDegreeAfterApplyRepeateRuleFilterBuilder : SqlFilterBuilder<VwSelectDegreeAfterApplyRepeateRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleFilterBuilder class.
		/// </summary>
		public VwSelectDegreeAfterApplyRepeateRuleFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSelectDegreeAfterApplyRepeateRuleFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSelectDegreeAfterApplyRepeateRuleFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSelectDegreeAfterApplyRepeateRuleFilterBuilder

	#region VwSelectDegreeAfterApplyRepeateRuleParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VwSelectDegreeAfterApplyRepeateRuleParameterBuilder : ParameterizedSqlFilterBuilder<VwSelectDegreeAfterApplyRepeateRuleColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleParameterBuilder class.
		/// </summary>
		public VwSelectDegreeAfterApplyRepeateRuleParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public VwSelectDegreeAfterApplyRepeateRuleParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public VwSelectDegreeAfterApplyRepeateRuleParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion VwSelectDegreeAfterApplyRepeateRuleParameterBuilder
	
	#region VwSelectDegreeAfterApplyRepeateRuleSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VwSelectDegreeAfterApplyRepeateRule"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class VwSelectDegreeAfterApplyRepeateRuleSortBuilder : SqlSortBuilder<VwSelectDegreeAfterApplyRepeateRuleColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VwSelectDegreeAfterApplyRepeateRuleSqlSortBuilder class.
		/// </summary>
		public VwSelectDegreeAfterApplyRepeateRuleSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion VwSelectDegreeAfterApplyRepeateRuleSortBuilder

} // end namespace
