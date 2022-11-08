#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;
using System.Data.SqlClient;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="EdCourse"/> entity.
	///</summary>
	[DataObject]
    [CLSCompliant(true)]
	public partial class SqlEdCourseProvider: SqlEdCourseProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlEdCourseProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlEdCourseProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){ }

        #region Updated Procedure

        //public override TList<EdCourse> GetByAsFacultyInfoId(TransactionManager transactionManager, System.Decimal? _asFacultyInfoId, int start, int pageLength, out int count)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_GetByAsFacultyInfoId", UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);

        //    IDataReader reader = null;
        //    TList<EdCourse> tmp = new TList<EdCourse>();
        //    try
        //    {
        //        //Provider Data Requesting Command Event
        //        OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByAsFacultyInfoId", tmp));

        //        if (transactionManager != null)
        //        {
        //            reader = Utility.ExecuteReader(transactionManager, commandWrapper);
        //        }
        //        else
        //        {
        //            reader = Utility.ExecuteReader(database, commandWrapper);
        //        }

        //        //Create collection and fill
        //        Fill(reader, tmp, start, pageLength);
        //        count = -1;
        //        if (reader.NextResult())
        //        {
        //            if (reader.Read())
        //            {
        //                count = reader.GetInt32(0);
        //            }
        //        }

        //        //Provider Data Requested Command Event
        //        OnDataRequested(new CommandEventArgs(commandWrapper, "GetByAsFacultyInfoId", tmp));
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //            reader.Close();

        //        commandWrapper = null;
        //    }

        //    return tmp;

        //    //return rows;
        //}

        //public override TList<EdCourse> Find(TransactionManager transactionManager, string whereClause, int start, int pageLength, out int count)
        //{
        //    count = -1;
        //    if (whereClause.IndexOf(";") > -1)
        //        return new TList<EdCourse>();

        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_Find", UseStoredProcedure);

        //    bool searchUsingOR = false;
        //    if (whereClause.IndexOf(" OR ") > 0) // did they want to do "a=b OR c=d OR..."?
        //        searchUsingOR = true;

        //    database.AddInParameter(commandWrapper, "@SearchUsingOR", DbType.Boolean, searchUsingOR);

        //    database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@CourseDescrAr", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@CourseDescrEn", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@CreditHours", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@CourseContentsAr", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@CourseContentsEn", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@AllPrereqFlg", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@NoPrereq", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@EdCodeCourseCaseId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@PrereqCodeExp", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@PrereqIdExp", DbType.String, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@GsCourseElectTypeId", DbType.Decimal, DBNull.Value);
        //    database.AddInParameter(commandWrapper, "@ElectFlg", DbType.Decimal, DBNull.Value);

        //    // replace all instances of 'AND' and 'OR' because we already set searchUsingOR
        //    whereClause = whereClause.Replace(" AND ", "|").Replace(" OR ", "|");
        //    string[] clauses = whereClause.ToLower().Split('|');

        //    // Here's what's going on below: Find a field, then to get the value we
        //    // drop the field name from the front, trim spaces, drop the '=' sign,
        //    // trim more spaces, and drop any outer single quotes.
        //    // Now handles the case when two fields start off the same way - like "Friendly='Yes' AND Friend='john'"

        //    char[] equalSign = { '=' };
        //    char[] singleQuote = { '\'' };
        //    foreach (string clause in clauses)
        //    {
        //        if (clause.Trim().StartsWith("ed_course_id ") || clause.Trim().StartsWith("ed_course_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@EdCourseId",
        //                clause.Trim().Remove(0, 12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("ed_code_course_id ") || clause.Trim().StartsWith("ed_code_course_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@EdCodeCourseId",
        //                clause.Trim().Remove(0, 17).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("course_code ") || clause.Trim().StartsWith("course_code="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@CourseCode",
        //                clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("course_descr_ar ") || clause.Trim().StartsWith("course_descr_ar="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@CourseDescrAr",
        //                clause.Trim().Remove(0, 15).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("course_descr_en ") || clause.Trim().StartsWith("course_descr_en="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@CourseDescrEn",
        //                clause.Trim().Remove(0, 15).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("credit_hours ") || clause.Trim().StartsWith("credit_hours="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@CreditHours",
        //                clause.Trim().Remove(0, 12).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("course_contents_ar ") || clause.Trim().StartsWith("course_contents_ar="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@CourseContentsAr",
        //                clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("course_contents_en ") || clause.Trim().StartsWith("course_contents_en="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@CourseContentsEn",
        //                clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("ent_main_id ") || clause.Trim().StartsWith("ent_main_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@EntMainId",
        //                clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("all_prereq_flg ") || clause.Trim().StartsWith("all_prereq_flg="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@AllPrereqFlg",
        //                clause.Trim().Remove(0, 14).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("no_prereq ") || clause.Trim().StartsWith("no_prereq="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@NoPrereq",
        //                clause.Trim().Remove(0, 9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("gs_code_language_id ") || clause.Trim().StartsWith("gs_code_language_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@GsCodeLanguageId",
        //                clause.Trim().Remove(0, 19).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("as_faculty_info_id ") || clause.Trim().StartsWith("as_faculty_info_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@AsFacultyInfoId",
        //                clause.Trim().Remove(0, 18).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("is_active ") || clause.Trim().StartsWith("is_active="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@IsActive",
        //                clause.Trim().Remove(0, 9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("ed_code_course_case_id ") || clause.Trim().StartsWith("ed_code_course_case_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@EdCodeCourseCaseId",
        //                clause.Trim().Remove(0, 22).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("ed_bylaw_id ") || clause.Trim().StartsWith("ed_bylaw_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@EdBylawId",
        //                clause.Trim().Remove(0, 11).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("prereq_code_exp ") || clause.Trim().StartsWith("prereq_code_exp="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@PrereqCodeExp",
        //                clause.Trim().Remove(0, 15).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("prereq_id_exp ") || clause.Trim().StartsWith("prereq_id_exp="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@PrereqIdExp",
        //                clause.Trim().Remove(0, 13).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("gs_course_elect_type_id ") || clause.Trim().StartsWith("gs_course_elect_type_id="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@GsCourseElectTypeId",
        //                clause.Trim().Remove(0, 23).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }
        //        if (clause.Trim().StartsWith("elect_flg ") || clause.Trim().StartsWith("elect_flg="))
        //        {
        //            database.SetParameterValue(commandWrapper, "@ElectFlg",
        //                clause.Trim().Remove(0, 9).Trim().TrimStart(equalSign).Trim().Trim(singleQuote));
        //            continue;
        //        }

        //        throw new ArgumentException("Unable to use this part of the where clause in this version of Find: " + clause);
        //    }

        //    IDataReader reader = null;
        //    //Create Collection
        //    TList<EdCourse> rows = new TList<EdCourse>();


        //    try
        //    {
        //        //Provider Data Requesting Command Event
        //        OnDataRequesting(new CommandEventArgs(commandWrapper, "Find", rows));

        //        if (transactionManager != null)
        //        {
        //            reader = Utility.ExecuteReader(transactionManager, commandWrapper);
        //        }
        //        else
        //        {
        //            reader = Utility.ExecuteReader(database, commandWrapper);
        //        }

        //        Fill(reader, rows, start, pageLength);

        //        if (reader.NextResult())
        //        {
        //            if (reader.Read())
        //            {
        //                count = reader.GetInt32(0);
        //            }
        //        }

        //        //Provider Data Requested Command Event
        //        OnDataRequested(new CommandEventArgs(commandWrapper, "Find", rows));
        //    }
        //    finally
        //    {
        //        if (reader != null)
        //            reader.Close();

        //        commandWrapper = null;
        //    }
        //    return rows;
        //}

        //public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourse entity)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_Insert", UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
        //    database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, (entity.EdCodeCourseId.HasValue ? (object)entity.EdCodeCourseId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, entity.CourseCode);
        //    database.AddInParameter(commandWrapper, "@CourseDescrAr", DbType.String, entity.CourseDescrAr);
        //    database.AddInParameter(commandWrapper, "@CourseDescrEn", DbType.String, entity.CourseDescrEn);
        //    database.AddInParameter(commandWrapper, "@CreditHours", DbType.Decimal, entity.CreditHours);
        //    database.AddInParameter(commandWrapper, "@CourseContentsAr", DbType.String, entity.CourseContentsAr);
        //    database.AddInParameter(commandWrapper, "@CourseContentsEn", DbType.String, entity.CourseContentsEn);
        //    database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, (entity.EntMainId.HasValue ? (object)entity.EntMainId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@AllPrereqFlg", DbType.Decimal, (entity.AllPrereqFlg.HasValue ? (object)entity.AllPrereqFlg : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@NoPrereq", DbType.Decimal, (entity.NoPrereq.HasValue ? (object)entity.NoPrereq : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, entity.GsCodeLanguageId);
        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
        //    //updated by dalia 7-11-2012 because courses was entered by 0 not take the default value 1
        //    ////database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
        //    database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, 1);
        //    database.AddInParameter(commandWrapper, "@EdCodeCourseCaseId", DbType.Decimal, entity.EdCodeCourseCaseId);
        //    database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, (entity.EdBylawId.HasValue ? (object)entity.EdBylawId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@PrereqCodeExp", DbType.String, entity.PrereqCodeExp);
        //    database.AddInParameter(commandWrapper, "@PrereqIdExp", DbType.String, entity.PrereqIdExp);
        //    database.AddInParameter(commandWrapper, "@GsCourseElectTypeId", DbType.Decimal, (entity.GsCourseElectTypeId.HasValue ? (object)entity.GsCourseElectTypeId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@ElectFlg", DbType.Decimal, (entity.ElectFlg.HasValue ? (object)entity.ElectFlg : System.DBNull.Value));

        //    int results = 0;

        //    //Provider Data Requesting Command Event
        //    OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

        //    if (transactionManager != null)
        //    {
        //        results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
        //    }
        //    else
        //    {
        //        results = Utility.ExecuteNonQuery(database, commandWrapper);
        //    }


        //    entity.OriginalEdCourseId = entity.EdCourseId;

        //    entity.AcceptChanges();

        //    //Provider Data Requested Command Event
        //    OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

        //    return Convert.ToBoolean(results);
        //}

        //public override bool Update(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourse entity)
        //{
        //    SqlDatabase database = new SqlDatabase(this.ConnectionString);
        //    DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_Update", UseStoredProcedure);

        //    database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, entity.EdCourseId);
        //    database.AddInParameter(commandWrapper, "@OriginalEdCourseId", DbType.Decimal, entity.OriginalEdCourseId);
        //    database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, (entity.EdCodeCourseId.HasValue ? (object)entity.EdCodeCourseId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, entity.CourseCode);
        //    database.AddInParameter(commandWrapper, "@CourseDescrAr", DbType.String, entity.CourseDescrAr);
        //    database.AddInParameter(commandWrapper, "@CourseDescrEn", DbType.String, entity.CourseDescrEn);
        //    database.AddInParameter(commandWrapper, "@CreditHours", DbType.Decimal, entity.CreditHours);
        //    database.AddInParameter(commandWrapper, "@CourseContentsAr", DbType.String, entity.CourseContentsAr);
        //    database.AddInParameter(commandWrapper, "@CourseContentsEn", DbType.String, entity.CourseContentsEn);
        //    database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, (entity.EntMainId.HasValue ? (object)entity.EntMainId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@AllPrereqFlg", DbType.Decimal, (entity.AllPrereqFlg.HasValue ? (object)entity.AllPrereqFlg : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@NoPrereq", DbType.Decimal, (entity.NoPrereq.HasValue ? (object)entity.NoPrereq : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, entity.GsCodeLanguageId);
        //    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
        //    database.AddInParameter(commandWrapper, "@EdCodeCourseCaseId", DbType.Decimal, entity.EdCodeCourseCaseId);
        //    database.AddInParameter(commandWrapper, "@EdBylawId", DbType.Decimal, (entity.EdBylawId.HasValue ? (object)entity.EdBylawId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@PrereqCodeExp", DbType.String, entity.PrereqCodeExp);
        //    database.AddInParameter(commandWrapper, "@PrereqIdExp", DbType.String, entity.PrereqIdExp);
        //    database.AddInParameter(commandWrapper, "@GsCourseElectTypeId", DbType.Decimal, (entity.GsCourseElectTypeId.HasValue ? (object)entity.GsCourseElectTypeId : System.DBNull.Value));
        //    database.AddInParameter(commandWrapper, "@ElectFlg", DbType.Decimal, (entity.ElectFlg.HasValue ? (object)entity.ElectFlg : System.DBNull.Value));

        //    int results = 0;

        //    //Provider Data Requesting Command Event
        //    OnDataRequesting(new CommandEventArgs(commandWrapper, "Update", entity));

        //    if (transactionManager != null)
        //    {
        //        results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
        //    }
        //    else
        //    {
        //        results = Utility.ExecuteNonQuery(database, commandWrapper);
        //    }

        //    //Stop Tracking Now that it has been updated and persisted.
        //    if (DataRepository.Provider.EnableEntityTracking)
        //        EntityManager.StopTracking(entity.EntityTrackingKey);

        //    entity.OriginalEdCourseId = entity.EdCourseId;

        //    entity.AcceptChanges();

        //    //Provider Data Requested Command Event
        //    OnDataRequested(new CommandEventArgs(commandWrapper, "Update", entity));

        //    return Convert.ToBoolean(results);
        //}

        public override decimal Insertcourse(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.EdCourse entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@EdCourseId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, (entity.EdCodeCourseId.HasValue ? (object)entity.EdCodeCourseId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, entity.CourseCode);
            database.AddInParameter(commandWrapper, "@CourseDescrAr", DbType.String, entity.CourseDescrAr);
            database.AddInParameter(commandWrapper, "@CourseDescrEn", DbType.String, entity.CourseDescrEn);
            database.AddInParameter(commandWrapper, "@CreditHours", DbType.Decimal, entity.CreditHours);
            database.AddInParameter(commandWrapper, "@CourseContentsAr", DbType.String, entity.CourseContentsAr);
            database.AddInParameter(commandWrapper, "@CourseContentsEn", DbType.String, entity.CourseContentsEn);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, (entity.EntMainId.HasValue ? (object)entity.EntMainId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, entity.GsCodeLanguageId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, (entity.AsFacultyInfoId.HasValue ? (object)entity.AsFacultyInfoId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, entity.IsActive);
            database.AddInParameter(commandWrapper, "@PrereqCodeExp", DbType.String, entity.PrereqCodeExp);
            database.AddInParameter(commandWrapper, "@PrereqIdExp", DbType.String, entity.PrereqIdExp);
            database.AddInParameter(commandWrapper, "@ElectFlg", DbType.Decimal, (entity.ElectFlg.HasValue ? (object)entity.ElectFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCourseElectTypeId", DbType.Decimal, (entity.GsCourseElectTypeId.HasValue ? (object)entity.GsCourseElectTypeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCoursePrfxId", DbType.Decimal, (entity.EdCoursePrfxId.HasValue ? (object)entity.EdCoursePrfxId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CrsNo", DbType.String, entity.CrsNo);
            database.AddInParameter(commandWrapper, "@PfFlg", DbType.Decimal, (entity.PfFlg.HasValue ? (object)entity.PfFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CrsLvl", DbType.Decimal, (entity.CrsLvl.HasValue ? (object)entity.CrsLvl : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@OnlineFlg", DbType.Decimal, (entity.OnlineFlg.HasValue ? (object)entity.OnlineFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@StopMessage", DbType.String, entity.StopMessage);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, (entity.AsCodeDegreeClassId.HasValue ? (object)entity.AsCodeDegreeClassId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdCourseExpHdrId", DbType.Decimal, (entity.EdCourseExpHdrId.HasValue ? (object)entity.EdCourseExpHdrId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LoadWithTrain", DbType.Decimal, (entity.LoadWithTrain.HasValue ? (object)entity.LoadWithTrain : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ExamFlg", DbType.Decimal, (entity.ExamFlg.HasValue ? (object)entity.ExamFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FreeFlg", DbType.Decimal, (entity.FreeFlg.HasValue ? (object)entity.FreeFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IncmpltFlg", DbType.Decimal, (entity.IncmpltFlg.HasValue ? (object)entity.IncmpltFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@DropFlg", DbType.Decimal, (entity.DropFlg.HasValue ? (object)entity.DropFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@ExamHrs", DbType.Decimal, (entity.ExamHrs.HasValue ? (object)entity.ExamHrs : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CrsWgt", DbType.Decimal, (entity.CrsWgt.HasValue ? (object)entity.CrsWgt : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@CourseDescrFr", DbType.String, entity.CourseDescrFr);
            database.AddInParameter(commandWrapper, "@Ects", DbType.Decimal, (entity.Ects.HasValue ? (object)entity.Ects : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LoadCrsCount", DbType.Decimal, (entity.LoadCrsCount.HasValue ? (object)entity.LoadCrsCount : System.DBNull.Value));
           //Mostafa Hussien Add ExtendFlag
            database.AddInParameter(commandWrapper, "@ExtndFlg", DbType.Decimal, (entity.ExtndFlg.HasValue ? (object)entity.ExtndFlg : System.DBNull.Value));
            //Maha Mahmoud Add CouseMod
            database.AddInParameter(commandWrapper, "@CourseMod", DbType.String, entity.CourseMod);
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insertcourse", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            object _edCourseId = database.GetParameterValue(commandWrapper, "@EdCourseId");
            entity.EdCourseId = (System.Decimal)_edCourseId;

            entity.OriginalEdCourseId = entity.EdCourseId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insertcourse", entity));

            return (System.Decimal)_edCourseId;
        }	

        public override bool Delete(TransactionManager transactionManager, System.Decimal _edCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.U_ED_COURSE_Delete", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _edCourseId);

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            //Stop Tracking Now that it has been updated and persisted.
            if (DataRepository.Provider.EnableEntityTracking)
            {
                string entityKey = EntityLocator.ConstructKeyFromPkItems(typeof(EdCourse)
                    , _edCourseId);
                EntityManager.StopTracking(entityKey);
            }

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);
        }//end Delete

        #endregion


        #region Custom Methods

        public override DataTable SearchCourseCatalog(TransactionManager transactionManager, System.Decimal _EdCodeCourseId, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.Decimal _AsCodeDegreeClassId, System.Decimal _IsActive, System.Decimal _OnlineFlg, System.String _CourseCode, System.String _Coursedescen, System.Decimal? _Lang, System.Decimal? MAjorId = null, System.Decimal? AcadPlanYearId = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SearchCourseCatalog", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeCourseId", DbType.Decimal, _EdCodeCourseId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, _IsActive);
            database.AddInParameter(commandWrapper, "@OnlineFlg", DbType.Decimal, _OnlineFlg);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);
            database.AddInParameter(commandWrapper, "@Coursedescen", DbType.String, _Coursedescen);
            //kamela, to send lang to search with it 
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, _Lang.HasValue ? (object)_Lang : DBNull.Value);
            //end
            //Walaa 31/8/2022
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, MAjorId.HasValue ? (object)MAjorId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AcadPlanYear", DbType.Decimal, AcadPlanYearId.HasValue ? (object)AcadPlanYearId : DBNull.Value);
            //------------------
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("FACULTY_DESCR_AR");
            table.Columns.Add("FACULTY_DESCR_EN");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("Is_Active");

            table.Columns.Add("Degree_Type_CODE");
            table.Columns.Add("Degree_Type_AR");
            table.Columns.Add("Degree_Type_EN");
            table.Columns.Add("Course_Type_AR");
            table.Columns.Add("Course_Type_EN");
            table.Columns.Add("LEVEL_DESCR_AR");
            table.Columns.Add("LEVEL_DESCR_EN");

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

                //read data
                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() 
                                     , reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(),reader[11].ToString()
                                     , reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString()};
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

        public override bool IsCrsResultNotApproved(System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID, int? SC_SECTION_GROUP_HDR_ID=null)
        {

            SqlConnection conn = new SqlConnection(this.ConnectionString);
            SqlCommand command = new SqlCommand("dbo.IsCrsResultNotApproved", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("EdAcadYearId", SqlDbType.NVarChar).Value = _EdAcadYearId;
            command.Parameters.Add("EdCodeSemesterId", SqlDbType.NVarChar).Value = _EdCodeSemesterId;
            command.Parameters.Add("EdCourseID", SqlDbType.NVarChar).Value = _EdCourseID;
            if (SC_SECTION_GROUP_HDR_ID!=null)
                command.Parameters.Add("SC_SECTION_GROUP_HDR_ID", SqlDbType.NVarChar).Value = SC_SECTION_GROUP_HDR_ID;
            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(table);
            conn.Close();
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;

        }

        public override DataTable GetCoursePkgOfStudent(TransactionManager transactionManager, System.Decimal edStudSemesterId, System.Decimal edCourseId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCoursePkgOfStudent", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, edCourseId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ENT_COURSE_PKG_HDR_ID");
            table.Columns.Add("ED_CDE_CRS_REG_TYPE_ID");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetStudCourseRplc(TransactionManager transactionManager, System.Decimal edAcadYearId, System.Decimal edCodeSemesterId, System.Decimal asFacultyInfoId, System.String studCode, Decimal AsCodeDegreeClass, Decimal Major)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudCourseReplc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemesterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, asFacultyInfoId);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, studCode);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClass", DbType.Decimal, AsCodeDegreeClass);
            database.AddInParameter(commandWrapper, "@Major", DbType.Decimal, Major);
            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ED_STUD_COURSE_RPLC_ID");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("STUD_NAME_AR");
            table.Columns.Add("STUD_NAME_EN");
            table.Columns.Add("COURSE_ID_OLD");
            table.Columns.Add("COURSE_CODE_OLD");
            table.Columns.Add("CourseCode_OLd_AR");
            table.Columns.Add("CourseCode_New_AR");
            table.Columns.Add("COURSE_AR_OLD");
            table.Columns.Add("COURSE_EN_OLD");
            table.Columns.Add("COURSE_CH_OLD");
            table.Columns.Add("COURSE_ID_New");
            table.Columns.Add("COURSE_CODE_NEW");
            table.Columns.Add("COURSE_AR_NEW");
            table.Columns.Add("COURSE_EN_NEW");
            table.Columns.Add("COURSE_CH_NEW");
            table.Columns.Add("APPROVE_FLG");
            table.Columns.Add("REQ_DATE");
            table.Columns.Add("MAJOR_EN");
            table.Columns.Add("MAJOR_AR");
            table.Columns.Add("SEMESTER_OLD");
            table.Columns.Add("SEMESTER_NEW");
            

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(), reader[14].ToString(), reader[15].ToString(),
                                             reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString()
                                              ,reader[21].ToString(),reader[22].ToString()
                                         };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(),
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(),
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                             reader[12].ToString(),reader[13].ToString(), reader[14].ToString(), reader[15].ToString(),
                                             reader[16].ToString(),reader[17].ToString(),reader[18].ToString(),reader[19].ToString(),reader[20].ToString()
                                              ,reader[21].ToString(),reader[22].ToString()
                                         };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetCourseRplcOld(TransactionManager transactionManager, System.Decimal edStudSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetCourseRplcOld", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ENT_COURSE_PKG_HDR_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("ED_COURSE_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() , reader[5].ToString() };
                        table.Rows.Add(items);
                    }
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

  
        public override DataTable GetStudElectCourseRplc(TransactionManager transactionManager, System.Decimal edStudSemesterId, System.Decimal entCoursePkgHdrId, System.Decimal edCourseOldId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudElectCourseRplc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EdCourseOldId", DbType.Decimal, edCourseOldId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("ED_COURSE_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
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


        public override DataTable GetCourseRplcNew(TransactionManager transactionManager, System.Decimal edStudSemesterId, System.Decimal entCoursePkgHdrId, System.Decimal edCourseOldId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetCourseRplcNew", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);
            database.AddInParameter(commandWrapper, "@EntCoursePkgHdrId", DbType.Decimal, entCoursePkgHdrId);
            database.AddInParameter(commandWrapper, "@EdCourseOldId", DbType.Decimal, edCourseOldId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("ED_COURSE_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()};
                        table.Rows.Add(items);
                    }
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

        #region GetByOfferingId
        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_COURSE_ED_BYLAW key.
        ///		FK_ED_COURSE_ED_BYLAW Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edBylawId"></param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override TList<EdCourse> GetByOfferingId(TransactionManager transactionManager, System.Decimal _edBylawId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByOfferingId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, _edBylawId);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByOfferingId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByOfferingId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (rows.Count == 0)
            {
                EdCourse Course = new EdCourse();
                Course.CourseDescrAr = "";
                rows.Add(Course);
            }
            return rows;
        }


        public override TList<EdCourse> GetAllByOfferingId(TransactionManager transactionManager, System.Decimal _offeringId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAllByOfferingId", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, _offeringId);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetAllByOfferingId", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAllByOfferingId", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (rows.Count == 0)
            {
                EdCourse Course = new EdCourse();
                Course.CourseDescrAr = "";
                rows.Add(Course);
            }
            return rows;
        }




        public override TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edOfferingId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByOfferingId_InnerJoin", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, _edOfferingId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, "");

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByOfferingId_InnerJoin", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByOfferingId_InnerJoin", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (rows.Count == 0)
            {
                EdCourse Course = new EdCourse();
                Course.CourseDescrAr = "";
                rows.Add(Course);
            }
            return rows;
        }
        public override TList<EdCourse> GetByOfferingId_InnerJoin(TransactionManager transactionManager, System.Decimal _edOfferingId, System.String CourseCode, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetByOfferingId_InnerJoin", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, _edOfferingId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, CourseCode);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByOfferingId_InnerJoin", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByOfferingId_InnerJoin", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (rows.Count == 0)
            {
                EdCourse Course = new EdCourse();
                Course.CourseDescrAr = "";
                rows.Add(Course);
            }
            return rows;
        }

        public override TList<EdCourse> GetSuitableCoursesForStud(TransactionManager transactionManager, System.Decimal _EdOfferingId, System.Decimal _EdStudId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetSuitableCoursesForStud", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdOfferingId", DbType.Decimal, _EdOfferingId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetSuitableCoursesForStud", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetSuitableCoursesForStud", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (rows.Count == 0)
            {
                EdCourse Course = new EdCourse();
                Course.CourseDescrAr = "";
                rows.Add(Course);
            }
            return rows;
        }

        public override EdCourse GetByCourseCode(TransactionManager transactionManager, System.String _CourseCode, System.Decimal _AsFacultyInfoId, bool? isActive, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_GetByCourseCodeAndFaculty", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@IsActive", DbType.Decimal, isActive.HasValue ? (object)(isActive.Value ? 1 : 0) : DBNull.Value);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByCourseCode", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByCourseCode", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            EdCourse course = null;
            if (rows.Count > 0)
                course = rows[0];

            return course;
        }


        #endregion

        public override UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseCode(TransactionManager transactionManager, System.String _edCourseCode, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_GetByCourseCode", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _edCourseCode);

            IDataReader reader = null;
            TList<EdCourse> tmp = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByCourseCode", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCourseId", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            //if (tmp.Count == 1)
            //{
            //    return tmp[0];
            //}
            //else if (tmp.Count == 0)
            //{
            //    return null;
            //}
            //else
            //{
            //    throw new DataException("Cannot find the unique instance of the class.");
            //}
            if (count > 0)
            {
                return tmp[0];
            }
            else
            {
                return null;
            }
        }

        public override UMIS_VER2.BusinessLyer.EdCourse GetByEdCourseDescr(TransactionManager transactionManager, System.String _edCourseDescr, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_GetByCourseDescr", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@COURSE_DESCR", DbType.String, _edCourseDescr);

            IDataReader reader = null;
            TList<EdCourse> tmp = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetByEdCourseDescr", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create collection and fill
                Fill(reader, tmp, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetByEdCourseDescr", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            if (count > 0)
            {
                return tmp[0];
            }
            else
            {
                return null;
            }
        }

        public override TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStfMemAcademicLoad", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetStfMemAcademicLoad", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStfMemAcademicLoad", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        //kamela, 14147 Make same Function for modular to call onther Procedure  ---copy by maha -- task 15508 ---//
        public override TList<EdCourse> GetStfMemAcademicLoad(TransactionManager transactionManager, System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _asFacultyInfoId, System.Decimal _ModularSystem, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStfMemAcademicLoadForModular", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _asFacultyInfoId);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "C_GetStfMemAcademicLoadForModular", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetStfMemAcademicLoad", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        //end
        public override DataTable GetStfMemAcademicLoadHours(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId, System.Decimal _TeachingMethodId, System.Decimal _EdCourseId)
        {
            TransactionManager transactionManager=null;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStfMemAcademicLoadHours", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemId);
            database.AddInParameter(commandWrapper, "@TeachingMethodId", DbType.Decimal, _TeachingMethodId);
            database.AddInParameter(commandWrapper, "@EdCourseId", DbType.Decimal, _EdCourseId);
            

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ED_CDE_TCHNG_MTHD_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("SA_STF_MAMBER_ID");
            table.Columns.Add("SC_SCH_DTL_EXT_STF_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("NO_HOURS");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() 
                                         , reader[8].ToString(), reader[9].ToString(),  reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()
                                         , reader[8].ToString(), reader[9].ToString(), reader[10].ToString(),  reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString()};
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetStfMemAcademicLoadHoursAll(System.Decimal _SaStfMemberId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemId)
        {
            TransactionManager transactionManager = null;
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStfMemAcademicLoadHoursAll", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemId);


            IDataReader reader = null;
            DataTable table = new DataTable();

          
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("Hours");
            table.Columns.Add("ACD_LOAD");
            table.Columns.Add("NO_HOURS");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
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



        public override DataTable CourseTimeTable(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID, System.Decimal _SaStfMemberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CourseTimeTable", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@SaStfMemberId", DbType.Decimal, _SaStfMemberId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            table.Columns.Add("SC_TCHNG_SLOT_ID");
            table.Columns.Add("SC_BUILDING_DESCR_AR");
            table.Columns.Add("SC_BUILDING_DESCR_EN");
            table.Columns.Add("SC_HALL_DESCR_AR");
            table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("Sc_Schedule_Dtl_Id");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
            table.Columns.Add("FROM_TIME");
            table.Columns.Add("TO_TIME");
            table.Columns.Add("GROUP_ORDER");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString(), reader[18].ToString() };
                        table.Rows.Add(items);
                    }
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


        public override DataTable GroupsOnCourse(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EdCourseID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GroupsOnCourse", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            // table.Columns.Add("GS_CODE_WEEK_DAY_ID");
            //table.Columns.Add("SC_TCHNG_SLOT_ID");
            // table.Columns.Add("SC_BUILDING_DESCR_AR");
            // table.Columns.Add("SC_BUILDING_DESCR_EN");
            //table.Columns.Add("SC_HALL_DESCR_AR");
            //table.Columns.Add("SC_HALL_DESCR_EN");
            table.Columns.Add("GROUP_DESCR_AR");
            table.Columns.Add("GROUP_DESCR_EN");
            //table.Columns.Add("STF_FULL_NAME_AR");
            //table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_AR");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_DESCR_EN");
            // table.Columns.Add("COURSE_DESCR_AR");
            // table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("Sc_Schedule_Dtl_Id");
            table.Columns.Add("ED_CODE_COURSE_TEACHING_ID");
            table.Columns.Add("TEACHING_DESCR_AR");
            table.Columns.Add("TEACHING_DESCR_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString()
                                         ,reader[6].ToString(),reader[7].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() 
                                         ,  reader[6].ToString(),reader[7].ToString()};
                        table.Rows.Add(items);
                    }
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

        public override DataTable CourseEvaluation(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_RATING", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@SvCodeEvalItemId", DbType.Decimal, _SvCodeEvalItemId);
            database.AddInParameter(commandWrapper, "@SvCourseEvlID", DbType.Decimal, SvCourseEvlID);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_CODE_RATING_SCHM_DTL_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("EvalItemCount");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
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
        //eman moustafa  TASk:13203 Date 13/4/2020
        public override DataTable CourseEvaluation_Dyn(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID, System.Decimal SvCourseEvlItemID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_SV_COURSE_EVAL_RATING_Dyn", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@SvCodeEvalItemId", DbType.Decimal, _SvCodeEvalItemId);
            database.AddInParameter(commandWrapper, "@SvCourseEvlID", DbType.Decimal, SvCourseEvlID);
            database.AddInParameter(commandWrapper, "@SvCourseEvalItemId", DbType.Decimal, SvCourseEvlItemID);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_CODE_RATING_SCHM_DTL_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("EvalItemCount");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
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
        public override DataTable CourseEvaluation_General(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EdCourseID, System.Decimal SvCourseEvlID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SV_COURSE_EVAL_RATING_General", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);
            database.AddInParameter(commandWrapper, "@SvCodeEvalItemId", DbType.Decimal, _SvCodeEvalItemId);
            database.AddInParameter(commandWrapper, "@SvCourseEvlID", DbType.Decimal, SvCourseEvlID);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_CODE_RATING_SCHM_DTL_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("EvalItemCount");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable StaffEvaluation(TransactionManager transactionManager, System.Decimal _SvCodeEvalItemId, System.Decimal _EntMainID, System.Decimal _SaStfMemberId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Entity_Main_GetEvaluation", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@SvCodeEvalItemId", DbType.Decimal, _SvCodeEvalItemId);
            database.AddInParameter(commandWrapper, "@saStfMemberId", DbType.Decimal, _SaStfMemberId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SV_CODE_RATING_SCHM_DTL_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");
            table.Columns.Add("EvalItemCount");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("StaffCount");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetRegisteredCoursesForDept(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_GetRegisteredCoursesInEntityMain", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdCourseId");
            table.Columns.Add("CourseDescrAr");
            table.Columns.Add("CourseDescrEn");
            table.Columns.Add("CourseCode");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetDeptCourses(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID,Decimal ASCodeDegreeClass,Decimal CourseTypeID , Decimal CatalogFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_GetDeptCourses", this.UseStoredProcedure);
            if (_EntMainID == -1)
            {
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);
                if (_AsFacultyInfoId == 0) {
                    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, -1);
                } else {
                    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
                
                }
            }
            else 
            {
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
                database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            }

            
            
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ASCodeDegreeClass", DbType.Decimal, ASCodeDegreeClass);
            database.AddInParameter(commandWrapper, "@CourseTypeID", DbType.Decimal, CourseTypeID);
            database.AddInParameter(commandWrapper, "@CatalogFlg", DbType.Decimal, CatalogFlg);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdCourseId");
            table.Columns.Add("CourseDescrAr");
            table.Columns.Add("CourseDescrEn");
            table.Columns.Add("CourseCode");
            //edit by nashassan 1/9/2016
            table.Columns.Add("ExamFlag");
            //added by olivia 16/12/2020
            table.Columns.Add("CourseNameAr");
            table.Columns.Add("CourseNameEn");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),            reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(),            reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable ED_COURSE_GetDeptCourses_UserCrs(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID, Decimal CatalogFlg, decimal SeUSerId, decimal? MajorIdPlan = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ED_COURSE_GetDeptCourses_UserCrs", this.UseStoredProcedure);
            if (_EntMainID == -1)
            {
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);
                if (_AsFacultyInfoId == 0)
                {
                    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, -1);
                }
                else
                {
                    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

                }
            }
            else
            {
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
                database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            }


            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ASCodeDegreeClass", DbType.Decimal, ASCodeDegreeClass);
            database.AddInParameter(commandWrapper, "@CourseTypeID", DbType.Decimal, CourseTypeID);
            database.AddInParameter(commandWrapper, "@CatalogFlg", DbType.Decimal, CatalogFlg);

            if (MajorIdPlan.HasValue)
                database.AddInParameter(commandWrapper, "@MajorIdPlan", DbType.Decimal, MajorIdPlan);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SeUSerId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdCourseId");
            table.Columns.Add("CourseDescrAr");
            table.Columns.Add("CourseDescrEn");
            table.Columns.Add("CourseCode");
            table.Columns.Add("ExamFlag");
            table.Columns.Add("CourseNameAr");
            table.Columns.Add("CourseNameEn");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() };
                        table.Rows.Add(items);
                    }
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


        public override DataTable GetActivityHourStuds(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, System.Decimal _EdCourseID, System.String _StudCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_STUD_ACTIVITY_HOUR", this.UseStoredProcedure);

            
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntMainID);

            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@EdCourseID", DbType.Decimal, _EdCourseID);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("Enroll_Type_AR");
            table.Columns.Add("Enroll_Type_EN");
            table.Columns.Add("Mjr_DESCR_AR");
            table.Columns.Add("Mjr_DESCR_EN");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("SEM_GPA");
            table.Columns.Add("MAJOR_CGPA");
            table.Columns.Add("ED_COURSE_ID");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("ED_STUD_ID");
            

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() ,
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() ,
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() ,
                                             reader[12].ToString() ,reader[13].ToString(),reader[14].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() ,
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() ,
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() ,
                                             reader[12].ToString() ,reader[13].ToString(),reader[14].ToString()};

                        table.Rows.Add(items);
                    }
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
        /*---get student  Activity hours new logic add by maha 2-7-2019 ---*/
        public override DataTable GetActivityHourStuds(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, System.Decimal _ActivityHours, System.String _StudCode, System.Decimal _AsCodeDegreeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_StudActiviytHourNewLogic", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntityMainId", DbType.Decimal, _EntMainID);
            database.AddInParameter(commandWrapper, "@StudCode", DbType.String, _StudCode);
            database.AddInParameter(commandWrapper, "@ActivityHours", DbType.Decimal, _ActivityHours);
            database.AddInParameter(commandWrapper, "@AS_CODE_DEGREE_ID", DbType.Decimal, _AsCodeDegreeId);
         

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("Enroll_Type_AR");
            table.Columns.Add("Enroll_Type_EN");
            table.Columns.Add("Mjr_DESCR_AR");
            table.Columns.Add("Mjr_DESCR_EN");
            table.Columns.Add("ACCUM_CH");
            table.Columns.Add("ACCUM_GPA");
            table.Columns.Add("SEM_GPA");
            table.Columns.Add("MAJOR_CGPA");
            table.Columns.Add("ACTVTY_FROM");
            table.Columns.Add("ACTVTY_TO");
            table.Columns.Add("ACTVTY_HOURS");
            table.Columns.Add("ACTVTY_AR");
            table.Columns.Add("ACTVTY_EN");            
            table.Columns.Add("ED_STUD_ID");
            
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() ,
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() ,
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() ,
                                             reader[12].ToString() ,reader[13].ToString(),reader[14].ToString(), reader[15].ToString() ,
                                             reader[16].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() ,
                                             reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() ,
                                             reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() ,
                                             reader[12].ToString() ,reader[13].ToString(),reader[14].ToString(), reader[15].ToString(),
                                             reader[16].ToString() };
                        table.Rows.Add(items);
                    }
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
        public override DataTable GetStudentActivityHours(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdStudId, System.Decimal _AcCodeDegreeID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_Stud_ActivityHours", this.UseStoredProcedure);


            database.AddInParameter(commandWrapper, "@FacultyId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@StudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@ClassDegreeId", DbType.Decimal, _AsFacultyInfoId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("CREDIT_HOURS");


            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()};

                        table.Rows.Add(items);
                    }
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





        /// <summary>
        /// 	Gets rows from the datasource based on the FK_ED_SUBJECT_ED_CODE_SUBJECT key.
        ///		FK_ED_SUBJECT_ED_CODE_SUBJECT Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_edCodeCourseId">مسلسل كود المادة داخل النظام</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.EdCourse objects.</returns>
        /// <exception cref="System.Exception">The command could not be executed.</exception>
        /// <exception cref="System.Data.DataException">The <paramref name="transactionManager"/> is not open.</exception>
        /// <exception cref="System.Data.Common.DbException">The command could not be executed.</exception>
        public override TList<EdCourse> GetCoursesCanStudentRegister(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCoursesCanStudentRegister", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCoursesCanStudentRegister", rows));


                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCoursesCanStudentRegister", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override TList<EdCourse> GetCoursesCanStudentRegisterCurrState(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _entMainId, System.Decimal _AsFacultyInfoId, System.Decimal _EdCodeSemesterId, System.Decimal _EdAcadYearId, System.String _CourseCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCoursesCanStudentRegisterCurrState", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@EntMainID", DbType.Decimal, _entMainId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);

            IDataReader reader = null;
            TList<EdCourse> rows = new TList<EdCourse>();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetCoursesCanStudentRegisterCurrState", rows));


                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }
                int start = 0;
                int pageLength = int.MaxValue;
                int count = int.MaxValue;
                //Create Collection
                Fill(reader, rows, start, pageLength);
                count = -1;
                if (reader.NextResult())
                {
                    if (reader.Read())
                    {
                        count = reader.GetInt32(0);
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetCoursesCanStudentRegisterCurrState", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }


        public override bool DeleteBySearch(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EntMainId, System.String _CourseCode, System.String _CourseName, System.Decimal _FromCh, System.Decimal _ToCh, System.Decimal _lang)
        {


            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ED_COURSE_DeleteBySearch", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@CourseCode", DbType.String, _CourseCode);
            database.AddInParameter(commandWrapper, "@CourseName", DbType.String, _CourseName);
            database.AddInParameter(commandWrapper, "@FromCh", DbType.Decimal, _FromCh);
            database.AddInParameter(commandWrapper, "@ToCh", DbType.Decimal, _ToCh);
            database.AddInParameter(commandWrapper, "@lang", DbType.Decimal, _lang);


            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Delete"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }



            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Delete"));

            commandWrapper = null;

            return Convert.ToBoolean(results);


        }

        //added by dalia 14-6-2012 to fill the form ddropdownlist in screen of auditing report
        public override DataTable GET_AUD_SE_FORM(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "GET_AUD_SE_FORM", this.UseStoredProcedure);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("SE_FORM_ID");
            table.Columns.Add("DESC_AR");
            table.Columns.Add("DESC_EN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString() };
                        table.Rows.Add(items);
                    }
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


        public override bool UpdateEdCourseWhenDeleteGsCourseFlg(TransactionManager transactionManager, System.Decimal _GS_COURSE_ELECT_TYPE_ID)
        {


            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_UpdateEdCourseWhenDeleteGsCourseFlg", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@GS_COURSE_ELECT_TYPE_ID", DbType.Decimal, _GS_COURSE_ELECT_TYPE_ID);


            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Update"));

            int results = 0;

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }



            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Update"));

            commandWrapper = null;

            return Convert.ToBoolean(results);


        }


        //added by dalia 17-10-2012 to get the course register section 
        public override DataTable SP_Get_course_register_section(TransactionManager transactionManager, System.Decimal ED_ACAD_YEAR_ID, System.Decimal ED_CODE_SEMESTER_ID, System.Decimal ED_STUD_ID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.SP_Get_course_register_section", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ED_ACAD_YEAR_ID", DbType.Decimal, ED_ACAD_YEAR_ID);
            database.AddInParameter(commandWrapper, "@ED_CODE_SEMESTER_ID", DbType.Decimal, ED_CODE_SEMESTER_ID);
            database.AddInParameter(commandWrapper, "@ED_STUD_ID", DbType.Decimal, ED_STUD_ID);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EdStudCourseRegId");
            table.Columns.Add("EdCourseId");
            table.Columns.Add("ed_stud_id");
            table.Columns.Add("Section_Ar");
            table.Columns.Add("Section_En");
            table.Columns.Add("TCHNG_MTHD_EN");
            table.Columns.Add("TCHNG_MTHD_AR");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable C_GetCourseRplcOldForNu_KU(TransactionManager transactionManager, System.Decimal edStudSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetCourseRplcOldForNu_KU", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("ENT_COURSE_PKG_HDR_ID");
            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("ED_COURSE_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
                        table.Rows.Add(items);
                    }
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

        public override DataTable GetStudNewCourseRplc(TransactionManager transactionManager, System.Decimal edStudSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_GetStudCourseRplcNew_KuNu", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudSemesterId", DbType.Decimal, edStudSemesterId);


            IDataReader reader = null;
            DataTable table = new DataTable();

            table.Columns.Add("COURSE_CODE");
            table.Columns.Add("COURSE_DESCR_AR");
            table.Columns.Add("COURSE_DESCR_EN");
            table.Columns.Add("CREDIT_HOURS");
            table.Columns.Add("ED_COURSE_ID");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                        table.Rows.Add(items);
                    }
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
        /*-- task 15608 --- maha -- 21-12-2020-----*/
        public override DataTable GetCoursesForMakeupExam(TransactionManager transactionManager, System.Decimal _AsFacultyInfoId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainID, Decimal ASCodeDegreeClass, Decimal CourseTypeID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCoursesForMakeExam", this.UseStoredProcedure);
            if (_EntMainID == -1)
            {
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);
                if (_AsFacultyInfoId == 0)
                {
                    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, -1);
                }
                else
                {
                    database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);

                }
            }
            else
            {
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainID);
                database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, _AsFacultyInfoId);
            }



            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@ASCodeDegreeClass", DbType.Decimal, ASCodeDegreeClass);
            database.AddInParameter(commandWrapper, "@CourseTypeID", DbType.Decimal, CourseTypeID);

            DataSet ds = new DataSet();
            ds = Utility.ExecuteDataSet(database, commandWrapper);
            return ds.Tables[0];

        }
        /*--task 15566 maha --21-12-2020------*/
        public override DataTable GetCoursesForExamSchedual(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal DepartmentID, decimal facId, decimal ExameType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetCoursesForExamSchedual", this.UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.String, EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, EdCodeSemesterId);
            if (DepartmentID != 0)
                database.AddInParameter(commandWrapper, "@DepartmentID", DbType.Decimal, DepartmentID);
            database.AddInParameter(commandWrapper, "@AsfacultyInfo", DbType.Decimal, facId);
            database.AddInParameter(commandWrapper, "@ExameTypeId", DbType.Decimal, ExameType);
            DataSet ds = new DataSet();
            ds = Utility.ExecuteDataSet(database, commandWrapper);
            return ds.Tables[0];
        }
        #endregion

	}
}