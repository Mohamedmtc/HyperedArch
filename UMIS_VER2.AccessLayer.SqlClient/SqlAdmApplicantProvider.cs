#region Using directives

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using UMIS_VER2.AccessLayer.Bases;
using UMIS_VER2.BusinessLyer;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	///<summary>
	/// This class is the SqlClient Data Access Logic Component implementation for the <see cref="AdmApplicant"/> entity.
	///</summary>
	[DataObject]
	[CLSCompliant(true)]
	public partial class SqlAdmApplicantProvider: SqlAdmApplicantProviderBase
	{
		/// <summary>
		/// Creates a new <see cref="SqlAdmApplicantProvider"/> instance.
		/// Uses connection string to connect to datasource.
		/// </summary>
		/// <param name="connectionString">The connection string to the database.</param>
		/// <param name="useStoredProcedure">A boolean value that indicates if we use the stored procedures or embedded queries.</param>
		/// <param name="providerInvariantName">Name of the invariant provider use by the DbProviderFactory.</param>
		public SqlAdmApplicantProvider(string connectionString, bool useStoredProcedure, string providerInvariantName): base(connectionString, useStoredProcedure, providerInvariantName){}
        #region Custom Methods

        public override TList<AdmApplicant> GetApplicantsForDistribution(TransactionManager transactionManager,System.Decimal? _admOpenAcadSemesterId, int start, int pageLength, out int count)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetApplicantsForDistribution", UseStoredProcedure);
            database.AddInParameter(commandWrapper, "@ADM_OPEN_ACAD_SEMESTER_ID", DbType.Decimal, _admOpenAcadSemesterId);
            IDataReader reader = null;

            //Create Collection
            TList<AdmApplicant> rows = new TList<AdmApplicant>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetApplicantsForDistribution", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

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
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetApplicantsForDistribution", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }//end getall

        public override UMIS_VER2.BusinessLyer.AdmApplicant Login(TransactionManager transactionManager, System.String _Email, System.String _Password)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_REG_Login", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EMail", DbType.String, _Email);
            database.AddInParameter(commandWrapper, "@Password", DbType.String, _Password);

            IDataReader reader = null;
            AdmApplicant tmp = new AdmApplicant();
            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "Login", tmp));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    while (reader.Read())
                    {
                        tmp.AdmApplicantId = decimal.Parse(reader[0].ToString());
                        tmp.AdmAppCode = reader[1].ToString();
                        tmp.Username = reader[2].ToString();
                        tmp.PasswordSalt = reader[4].ToString();
                        tmp.PasswordHash =reader[4].ToString();
                        tmp.SecurityQs = reader[5].ToString();
                        tmp.SecurityQsAnsSalt = reader[6].ToString();
                        tmp.SecurityQsAnsHash = reader[7].ToString();
                        tmp.ActivationCode = reader[8].ToString();
                        tmp.ActivationFlg =  decimal.Parse(reader[9].ToString());
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    while (reader.Read())
                    {
                        tmp.AdmApplicantId = decimal.Parse(reader[0].ToString());
                        tmp.AdmAppCode = reader[1].ToString();
                        tmp.Username = reader[2].ToString();
                        tmp.PasswordSalt = reader[4].ToString();
                        tmp.PasswordHash = reader[4].ToString();
                        tmp.SecurityQs = reader[5].ToString();
                        tmp.SecurityQsAnsSalt = reader[6].ToString();
                        tmp.SecurityQsAnsHash = reader[7].ToString();
                        tmp.ActivationCode = reader[8].ToString();
                        tmp.ActivationFlg = decimal.Parse(reader[9].ToString());
                    }
                }

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "Login", tmp));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }

            return tmp;
        }

        public override bool ADM_APPLICANT_History_Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicant entity, decimal as_Code_degree, decimal? AcadYear, decimal? SemId, decimal ADM_CDE_STATUS_ID, decimal? SE_USER_ID)
		{
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_History_Insert", UseStoredProcedure);
			
			database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, entity.AdmApplicantId );
			database.AddInParameter(commandWrapper, "@AdmAppCode", DbType.AnsiString, entity.AdmAppCode );
			database.AddInParameter(commandWrapper, "@Username", DbType.AnsiString, entity.Username );
			database.AddInParameter(commandWrapper, "@PasswordSalt", DbType.String, entity.PasswordSalt );
			database.AddInParameter(commandWrapper, "@PasswordHash", DbType.String, entity.PasswordHash );
			database.AddInParameter(commandWrapper, "@SecurityQs", DbType.String, entity.SecurityQs );
			database.AddInParameter(commandWrapper, "@SecurityQsAnsSalt", DbType.String, entity.SecurityQsAnsSalt );
			database.AddInParameter(commandWrapper, "@SecurityQsAnsHash", DbType.String, entity.SecurityQsAnsHash );
			database.AddInParameter(commandWrapper, "@ActivationCode", DbType.String, entity.ActivationCode );
			database.AddInParameter(commandWrapper, "@ActivationFlg", DbType.Decimal, (entity.ActivationFlg.HasValue ? (object) entity.ActivationFlg  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@RegDate", DbType.DateTime, (entity.RegDate.HasValue ? (object) entity.RegDate  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@FnameAr", DbType.String, entity.FnameAr );
			database.AddInParameter(commandWrapper, "@FnameEn", DbType.String, entity.FnameEn );
			database.AddInParameter(commandWrapper, "@MnameAr", DbType.String, entity.MnameAr );
			database.AddInParameter(commandWrapper, "@MnameEn", DbType.String, entity.MnameEn );
			database.AddInParameter(commandWrapper, "@LnameAr", DbType.String, entity.LnameAr );
			database.AddInParameter(commandWrapper, "@LnameEn", DbType.String, entity.LnameEn );
			database.AddInParameter(commandWrapper, "@FamilyAr", DbType.String, entity.FamilyAr );
			database.AddInParameter(commandWrapper, "@FamilyEn", DbType.String, entity.FamilyEn );
			database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object) entity.GsCodeReligionId  : System.DBNull.Value));
			//database.AddInParameter(commandWrapper, "@Cpr", DbType.Decimal, (entity.Cpr.HasValue ? (object) entity.Cpr  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Cpr", DbType.String, entity.Cpr);
			//database.AddInParameter(commandWrapper, "@PassporNo", DbType.Decimal, (entity.PassporNo.HasValue ? (object) entity.PassporNo  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PassporNo", DbType.String, entity.PassporNo);
			database.AddInParameter(commandWrapper, "@PassporExpireDate", DbType.Date, (entity.PassporExpireDate.HasValue ? (object) entity.PassporExpireDate  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@Birthdate", DbType.Date, (entity.Birthdate.HasValue ? (object) entity.Birthdate  : System.DBNull.Value));
			//database.AddInParameter(commandWrapper, "@GsBirthCountryNodeId", DbType.Decimal, (entity.GsBirthCountryNodeId.HasValue ? (object) entity.GsBirthCountryNodeId  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@PhotoPath", DbType.String, entity.PhotoPath );
			database.AddInParameter(commandWrapper, "@GsCdeMaritalStatusId", DbType.Decimal, (entity.GsCdeMaritalStatusId.HasValue ? (object) entity.GsCdeMaritalStatusId  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object) entity.GsCodeGenderId  : System.DBNull.Value));
			database.AddInParameter(commandWrapper, "@WorkFlg", DbType.Decimal, (entity.WorkFlg.HasValue ? (object) entity.WorkFlg  : System.DBNull.Value));
		//commented by dalia because database changed by eng khaled
            //	database.AddInParameter(commandWrapper, "@GsCountryInfoId", DbType.Decimal, (entity.GsCountryInfoId.HasValue ? (object) entity.GsCountryInfoId  : System.DBNull.Value));
		//	database.AddInParameter(commandWrapper, "@PermFullAddressAr", DbType.String, entity.PermFullAddressAr );
			//database.AddInParameter(commandWrapper, "@PermFullAddressEn", DbType.String, entity.PermFullAddressEn );
			//database.AddInParameter(commandWrapper, "@Region", DbType.String, entity.Region );
			//database.AddInParameter(commandWrapper, "@Road", DbType.String, entity.Road );
			//database.AddInParameter(commandWrapper, "@Block", DbType.String, entity.Block );
			//database.AddInParameter(commandWrapper, "@House", DbType.String, entity.House );
			//database.AddInParameter(commandWrapper, "@Appartment", DbType.String, entity.Appartment );
			database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object) entity.GsCountryNodeId  : System.DBNull.Value));
			//database.AddInParameter(commandWrapper, "@GsCountryNodeId1", DbType.Decimal, (entity.GsCountryNodeId1.HasValue ? (object) entity.GsCountryNodeId1  : System.DBNull.Value));
			//database.AddInParameter(commandWrapper, "@AdmAppMessageId", DbType.Decimal, (entity.AdmAppMessageId.HasValue ? (object) entity.AdmAppMessageId  : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal,as_Code_degree);
            //database.AddInParameter(commandWrapper, "@CurrFlg", DbType.Decimal, CurrFlg);
            database.AddInParameter(commandWrapper, "@AcadYear", DbType.Decimal, AcadYear);
            database.AddInParameter(commandWrapper, "@SemId", DbType.Decimal, SemId);
            database.AddInParameter(commandWrapper, "@AdmCdeStatusId", DbType.Decimal, ADM_CDE_STATUS_ID);
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, SE_USER_ID);
			
			int results = 0;
			
			//Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "ADM_APPLICANT_History_Insert", entity));
				
			if (transactionManager != null)
			{
				results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
			}
			else
			{
				results = Utility.ExecuteNonQuery(database,commandWrapper);
			}
					
			
			entity.OriginalAdmApplicantId = entity.AdmApplicantId;
			
			entity.AcceptChanges();
	
			//Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "ADM_APPLICANT_History_Insert", entity));

			return Convert.ToBoolean(results);
		}	
        public override DataTable GetFacultyPreferences(TransactionManager transactionManager, System.Decimal _AppplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_Faculty_Preferences", UseStoredProcedure);
            
            database.AddInParameter(commandWrapper, "@ADM_APPLICANT_ID", DbType.Decimal, _AppplicantId);            

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");           
            table.Columns.Add("AS_FACULTY_INFO_ID");
                       

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() 
                                         , reader[3].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString()
                                         , reader[3].ToString()};
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

        //added by mmq at 14-07/2016
        public override DataTable GetApplicantsToActivateByID(TransactionManager transactionManager, System.Decimal EdAcadYearID, System.Decimal EdCodeSemesterID, System.String AdmAppCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAdmAppToActivate", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearID", DbType.Decimal, EdAcadYearID);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterID", DbType.Decimal, EdCodeSemesterID);
            if (AdmAppCode != "")
            {
                database.AddInParameter(commandWrapper, "@AdmAppCode", DbType.String, AdmAppCode);
            }
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ED_STUD_FACULTY_ID");
            table.Columns.Add("STUD_FACULTY_CODE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("IS_ACTIVE");
            table.Columns.Add("APP_DATE");
            table.Columns.Add("NATIONAL_NUMBER");
           

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() 
                                         , reader[3].ToString() , reader[4].ToString() , reader[5].ToString() , reader[6].ToString() , reader[7].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() 
                                         , reader[3].ToString() , reader[4].ToString() , reader[5].ToString() , reader[6].ToString() , reader[7].ToString()};
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


        public override DataTable GetAppProgramAndFaculty(TransactionManager transactionManager, System.Decimal _AppplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetAppProgramAndFaculty", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("EnrolledFlg");
            table.Columns.Add("AS_FACULTY_INFO_ID");
            table.Columns.Add("ENT_MAIN_ID");
            
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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetStudAppData(TransactionManager transactionManager, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetStudAppData", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("ADM_CDE_APP_TYPE_ID");
            table.Columns.Add("AS_CODE_DEGREE_CLASS_ID");
            table.Columns.Add("AS_CODE_DEGREE_ID");
            table.Columns.Add("ADM_CDE_STATUS_ID");
            table.Columns.Add("ED_STUD_ID");


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
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() };
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

        public override DataTable CheckForSubmit(TransactionManager transactionManager, System.Decimal _AppplicantId, System.Decimal _userType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.CheckForSubmit", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);
            database.AddInParameter(commandWrapper, "@userType", DbType.Decimal, _userType);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TabDescr");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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


        public override DataTable GetMajorPreferences(TransactionManager transactionManager, System.Decimal _AppplicantId, System.Decimal? _AsFacultyInfoId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_Major_Preferences", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ADM_APPLICANT_ID", DbType.Decimal, _AppplicantId);
            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, _AsFacultyInfoId.HasValue ? (object)_AsFacultyInfoId : DBNull.Value);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ENT_MAIN_ID");
            table.Columns.Add("ENT_DESCR_AR");
            table.Columns.Add("ENT_DESCR_EN");
           

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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable AdvancedSearchDistribution(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId,
     decimal? asCodeDegreeClassId, decimal? asCodeDegreeId, string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
     decimal? gsCodeGenderId, decimal lang, decimal CompRateFrom, decimal CompRateTo, decimal EdcodeQualId, decimal EdCodeQualCatId, decimal EdcodeQualBrnId, int PageIndex, int PageSize,
           decimal AdmissionOfficer, decimal IsPublicSchool, decimal DistributionFlg, decimal DistributedCollege, decimal DistributedProgram)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ADM_APPLICANT_ADVANCED_Distributed", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId.HasValue ? (object)asCodeDegreeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, string.IsNullOrEmpty(applicantCode) ? DBNull.Value : (object)applicantCode);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@ApplicantName", DbType.String, string.IsNullOrEmpty(applicantName) ? DBNull.Value : (object)applicantName);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId.HasValue ? (object)gsCoutryNodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmAdmissionBandId", DbType.Decimal, admAdmissionBandId.HasValue ? (object)admAdmissionBandId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId.HasValue ? (object)gsCodeGenderId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, lang);
            database.AddInParameter(commandWrapper, "@CompRateTo", DbType.Decimal, CompRateTo);
            database.AddInParameter(commandWrapper, "@CompRateFrom", DbType.Decimal, CompRateFrom);
            database.AddInParameter(commandWrapper, "@EdCodequalId", DbType.Decimal, EdcodeQualId);
            database.AddInParameter(commandWrapper, "@edQualCatId", DbType.Decimal, EdCodeQualCatId);
            database.AddInParameter(commandWrapper, "@edcodeQualBRNId", DbType.Decimal, EdcodeQualBrnId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer != 0 ? (object)AdmissionOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);
            database.AddInParameter(commandWrapper, "@DistributionFlg", DbType.Decimal, DistributionFlg);
            database.AddInParameter(commandWrapper, "@DistributedCollege", DbType.Decimal, DistributedCollege);
            database.AddInParameter(commandWrapper, "@DistributedProgram", DbType.Decimal, DistributedProgram);
            DataSet ds = null;

            try
            {

                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }

            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }


        public override DataTable Statistics(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_Statistics", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AppReq");
            table.Columns.Add("RejAppReq");
            table.Columns.Add("AccepAppReq");
            table.Columns.Add("TransAppReq");
            table.Columns.Add("NewAppReq");
            table.Columns.Add("BindingAppReq");

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

        public override DataTable Search(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, string _SearchText, System.Decimal _Gender, System.Decimal _Age, string _AgeOperator, System.Decimal _Nationality, string _ID, System.Decimal _AdmStatus, System.Decimal _AdmCdeAppType,
            System.Decimal _AsCodeDegreeClassId, decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_Search", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);

            if (_EntMainId != 0)
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            else
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);
            if (_SearchText != "")
                database.AddInParameter(commandWrapper, "@SearchText", DbType.String, _SearchText);
            else
                database.AddInParameter(commandWrapper, "@SearchText", DbType.String, DBNull.Value);
            if (_Gender != 0)
                database.AddInParameter(commandWrapper, "@Gender", DbType.Decimal, _Gender);
            else
                database.AddInParameter(commandWrapper, "@Gender", DbType.Decimal, DBNull.Value);
            if (_Age != 0)
                database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, _Age);
            else
                database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, DBNull.Value);
            if (_AgeOperator != "")
                database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, _AgeOperator);
            else
                database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, DBNull.Value);
            if (_Nationality != 0)
                database.AddInParameter(commandWrapper, "@Nationality", DbType.Decimal, _Nationality);
            else
                database.AddInParameter(commandWrapper, "@Nationality", DbType.Decimal, DBNull.Value);
            if (_ID != "")
                database.AddInParameter(commandWrapper, "@ID", DbType.String, _ID);
            else
                database.AddInParameter(commandWrapper, "@ID", DbType.String, DBNull.Value);
            if (_AdmStatus != 0)
                database.AddInParameter(commandWrapper, "@AdmStatus", DbType.Decimal, _AdmStatus);
            else
                database.AddInParameter(commandWrapper, "@AdmStatus", DbType.Decimal, DBNull.Value);


            if (_AdmCdeAppType != 0)
                database.AddInParameter(commandWrapper, "@AdmCdeAppType", DbType.Decimal, _AdmCdeAppType);
            else
                database.AddInParameter(commandWrapper, "@AdmCdeAppType", DbType.Decimal, DBNull.Value);

            if (_AsCodeDegreeClassId != 0)
                database.AddInParameter(commandWrapper, "@ASCODEDEGREECLASSID", DbType.Decimal, _AsCodeDegreeClassId);
            else
                database.AddInParameter(commandWrapper, "@ASCODEDEGREECLASSID", DbType.Decimal, DBNull.Value);

            // new search critria added 20-4-2014 -adel

            database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer != 0 ? (object)AdmissionOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualCatId", DbType.Decimal, QualCodeCatId != 0 ? (object)QualCodeCatId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualId", DbType.Decimal, QualCodeId != 0 ? (object)QualCodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualBrnId", DbType.Decimal, QualSpecializtion != 0 ? (object)QualSpecializtion : DBNull.Value);
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, TotalPercent);
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, EnglishPercent);
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);
           

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("FULL_NAME");
            table.Columns.Add("BIRTH_DATE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ENT_DESCR");
            table.Columns.Add("ADM_STATUS_DESCR");
            table.Columns.Add("IDENT_NUM");
            table.Columns.Add("ACAD_YEAR_DESCR");
            table.Columns.Add("ADM_APP_CODE");
            table.Columns.Add("GS_COUNTRY_INFO_ID_1");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable SearchForExamDate(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, string _SearchText, System.Decimal _Gender, System.Decimal _Age, string _AgeOperator, System.Decimal _Nationality, string _ID, System.Decimal _AdmStatus, System.Decimal _AdmCdeAppType, System.Decimal _AdmCdePlacementExamId, System.DateTime _AppDateFrom, System.DateTime _AppDateTo)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_SearchForExamDate", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            if (_AdmCdePlacementExamId != 0) database.AddInParameter(commandWrapper, "@AdmCdePlacementExamId", DbType.Decimal, _AdmCdePlacementExamId);
            else database.AddInParameter(commandWrapper, "@AdmCdePlacementExamId", DbType.Decimal, null);

            database.AddInParameter(commandWrapper, "@AppDateFrom", DbType.DateTime, _AppDateFrom);
            database.AddInParameter(commandWrapper, "@AppDateTo", DbType.DateTime, _AppDateTo);

            if (_EntMainId != 0)
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            else
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, null);
            if (_SearchText != "")
                database.AddInParameter(commandWrapper, "@SearchText", DbType.String, _SearchText);
            else
                database.AddInParameter(commandWrapper, "@SearchText", DbType.String, null);
            if (_Gender != 0)
                database.AddInParameter(commandWrapper, "@Gender", DbType.Decimal, _Gender);
            else
                database.AddInParameter(commandWrapper, "@Gender", DbType.Decimal, null);
            if (_Age != 0)
                database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, _Age);
            else
                database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, null);
            if (_AgeOperator != "")
                database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, _AgeOperator);
            else
                database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, null);
            if (_Nationality != 0)
                database.AddInParameter(commandWrapper, "@Nationality", DbType.Decimal, _Nationality);
            else
                database.AddInParameter(commandWrapper, "@Nationality", DbType.Decimal, null);
            if (_ID != "")
                database.AddInParameter(commandWrapper, "@ID", DbType.String, _ID);
            else
                database.AddInParameter(commandWrapper, "@ID", DbType.String, null);
            if (_AdmStatus != 0)
                database.AddInParameter(commandWrapper, "@AdmStatus", DbType.Decimal, _AdmStatus);
            else
                database.AddInParameter(commandWrapper, "@AdmStatus", DbType.Decimal, null);

            if (_AdmCdeAppType != 0)
                database.AddInParameter(commandWrapper, "@AdmCdeAppType", DbType.Decimal, _AdmCdeAppType);
            else
                database.AddInParameter(commandWrapper, "@AdmCdeAppType", DbType.Decimal, null);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("FULL_NAME");
            table.Columns.Add("BIRTH_DATE");
            table.Columns.Add("ED_STUD_ID");
            table.Columns.Add("ENT_DESCR");
            table.Columns.Add("ADM_STATUS_DESCR");
            table.Columns.Add("IDENT_NUM");
            table.Columns.Add("ACAD_YEAR_DESCR");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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

        public override DataTable SearchWithTransferedData(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _Lang, System.Decimal _EntMainId, System.Decimal _AdmStatus, System.String _FromDate, System.String _ToDate)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_WithTranser_Search", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);

            if (_EntMainId != 0)
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            else
                database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, DBNull.Value);




            if (_AdmStatus != 0)
                database.AddInParameter(commandWrapper, "@AdmStatus", DbType.Decimal, _AdmStatus);
            else
                database.AddInParameter(commandWrapper, "@AdmStatus", DbType.Decimal, DBNull.Value);


            if (_FromDate != "")
                database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, _FromDate);
            else
                database.AddInParameter(commandWrapper, "@FromDate", DbType.DateTime, DBNull.Value);



            if (_ToDate != "")
                database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, _ToDate);
            else
                database.AddInParameter(commandWrapper, "@ToDate", DbType.DateTime, DBNull.Value);






            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_APPLICANT_ID");
            table.Columns.Add("FULL_NAME");
            table.Columns.Add("BIRTHDATE");
            table.Columns.Add("ENT_DESCR");
            table.Columns.Add("ADM_STATUS_DESCR");
            table.Columns.Add("CPR");
            table.Columns.Add("ACAD_YEAR_DESCR");
            table.Columns.Add("REQ_DATE");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        string ReqDate = "";
                        if (reader[7].ToString() != "")
                        {
                            ReqDate = ((DateTime)reader[7]).ToShortDateString();
                        }

                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), ReqDate };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        string ReqDate = "";
                        if (reader[7].ToString() != "")
                        {
                            ReqDate = ((DateTime)reader[7]).ToShortDateString();
                        }

                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), ReqDate };
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

        public override DataTable GetReqDocs(TransactionManager transactionManager, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetReqDocs", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_REQ_DOC_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");

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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override bool TransferStudentData(TransactionManager transactionManager, System.Decimal _EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_TransferStudentData", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);

            bool found = false;
            try
            {
                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                    found = true;
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                    found = true;
                }
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;

        }

        public override bool TransferApplicantData(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_TransferDataToStudent", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            bool found = false;
            try
            {
                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                    found = true;
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                    found = true;
                }
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;

        }
        public override bool CancelTransferApplicantData(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_CancelTransferDataToStudent", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            bool found = false;
            try
            {
                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                    found = true;
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                    found = true;
                }
            }
            catch(Exception ex)
            {
                found = false;
                throw ex;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;

        }

        public override bool CancelTransferStudAppData(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_CancelManualEnrollment", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, _EdStudId);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            bool found = false;
            try
            {
                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                    found = true;
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                    found = true;
                }
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;

        }

        public override bool LoadApplicantDocFees(TransactionManager transactionManager, System.Decimal _AsCodeDegreeId, System.Decimal _AsCodeDegreeClassId, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.LoadApplicantDocFees", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, _AsCodeDegreeId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, _AsCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            bool found = false;
            try
            {
                if (transactionManager != null)
                {
                    Utility.ExecuteNonQuery(transactionManager, commandWrapper);
                    found = true;
                }
                else
                {
                    Utility.ExecuteNonQuery(database, commandWrapper);
                    found = true;
                }
            }
            catch
            {
                found = false;
            }
            finally
            {
                commandWrapper = null;
            }
            return found;

        }

        public override DataTable GetPlacementExam(TransactionManager transactionManager, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetPlacementExam", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");

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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetTransferedApplicantStudId(TransactionManager transactionManager, System.Decimal _AdmApplicantId, System.Decimal? AsFacultyInfoId, System.Decimal EntMainId, System.String SecurtityAnswer, System.String SecurtityParentAnswer, System.Decimal UserCreatorId, System.String ADUSERGUID, System.String ADUSERParentGUID)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APP_ManualEnrollment", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);
            database.AddInParameter(commandWrapper, "@AsFacultuInfoId", DbType.Decimal, AsFacultyInfoId);
            database.AddInParameter(commandWrapper, "@entMainId", DbType.Decimal, EntMainId);
            database.AddInParameter(commandWrapper, "@SecurtityAnswer", DbType.String, SecurtityAnswer);
            database.AddInParameter(commandWrapper, "@SecurtityParentAnswer", DbType.String, SecurtityParentAnswer);
            database.AddInParameter(commandWrapper, "@UserCreatorId", DbType.Decimal, UserCreatorId);
            database.AddInParameter(commandWrapper, "@ADUSERGUID", DbType.String, ADUSERGUID);
            database.AddInParameter(commandWrapper, "@ADUSERParentGUID", DbType.String, ADUSERParentGUID);
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("StudentCode");
            //commented by eman moustafa :Desc:bug in enroll applicant  Date:19/9/2019
            //table.Columns.Add("StudFacultyInfoId");
            //table.Columns.Add("EdStudSemId");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString()
                                         //commented by eman moustafa , Desc:bug in enroll applicant , Date:19/9/2019
                                         //, reader[1].ToString(), reader[2].ToString()
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
                        object[] items = { reader[0].ToString()
                                             //commented by eman moustafa :Desc:bug in enroll applicant  Date:19/9/2019
                                            // , reader[1].ToString(), reader[2].ToString()
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

        public override DataTable QueryAppExamData(TransactionManager transactionManager, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_QueryAppExamData", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AppId");
            table.Columns.Add("NameAr");
            table.Columns.Add("NameEn");

            table.Columns.Add("ExamAr");
            table.Columns.Add("ExamEn");
            table.Columns.Add("MaxMark");

            table.Columns.Add("MinMark");
            table.Columns.Add("ExamDate");
            table.Columns.Add("ExamTime");

            table.Columns.Add("Location");
            table.Columns.Add("AppDegree");
            table.Columns.Add("Pass");
            table.Columns.Add("ABSC");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                                            reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                            reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),
                                            reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                            reader[12].ToString()};
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),
                                            reader[3].ToString(), reader[4].ToString(), reader[5].ToString(),
                                            reader[6].ToString(), reader[7].ToString(), reader[8].ToString(),
                                            reader[9].ToString(), reader[10].ToString(), reader[11].ToString(),
                                            reader[12].ToString()};
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


        public override DataTable GetRemainReqDocs(TransactionManager transactionManager, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetRemainReqDocs", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_REQ_DOC_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");

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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetRemainPlacementExam(TransactionManager transactionManager, System.Decimal _AdmApplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetRemainPlacementExam", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AdmApplicantId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("ADM_CDE_PLACEMENT_EXAM_ID");
            table.Columns.Add("DESCR_AR");
            table.Columns.Add("DESCR_EN");

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
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
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

        public override DataTable GetAllSuccessForApprove(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetAllSuccessForApprove", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("IdentNum");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("EntDescrAr");
            table.Columns.Add("EntDescrEn");

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

        public override DataTable GetAllNewForReject(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetAllNewForReject", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("IdentNum");
            table.Columns.Add("EntDescrAr");
            table.Columns.Add("EntDescrEn");

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

        public override DataTable GetForReject(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCode, System.Decimal _New,System.Decimal _AppType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetForReject", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AppName", DbType.String, _AppName);
            database.AddInParameter(commandWrapper, "@AppCode", DbType.String, _AppCode);
            database.AddInParameter(commandWrapper, "@New", DbType.Decimal, _New);
            database.AddInParameter(commandWrapper, "@AppType", DbType.Decimal, _AppType);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullName");
            table.Columns.Add("Docs_Flg");
            table.Columns.Add("Exam_Flg");
            table.Columns.Add("Fees_Flg");
            table.Columns.Add("RefuseNotes");

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

        public override DataTable GetForApprove(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeClassID, System.Decimal _Enrolled)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetForApprove", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AppName", DbType.String, _AppName);
            database.AddInParameter(commandWrapper, "@AppCodefrom", DbType.String, _AppCodefrom);
            database.AddInParameter(commandWrapper, "@AppCodeto", DbType.String, _AppCodeto);
            database.AddInParameter(commandWrapper, "@Sort1", DbType.Decimal, _Sort1);
            database.AddInParameter(commandWrapper, "@SortAsc", DbType.Decimal, _SortAsc);
            database.AddInParameter(commandWrapper, "@New", DbType.Decimal, New);
            database.AddInParameter(commandWrapper, "@AppType", DbType.Decimal, _AppType);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, _AsCodeDegreeClassID);
            database.AddInParameter(commandWrapper, "@Enrolled", DbType.Decimal, _Enrolled);
            
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullName");
            table.Columns.Add("NationalityName");
            table.Columns.Add("BirthDate");
            table.Columns.Add("AppDate");
            table.Columns.Add("CertfPercent");
            table.Columns.Add("COMPTATIVERATE");
            table.Columns.Add("FACULTYDESCRAR");
            table.Columns.Add("FACULTYDESCREN");
            table.Columns.Add("ADM_APP_REG_HISTORY_ID");
            table.Columns.Add("Fees_Payed");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString() };
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

        public override DataTable GetApplicantForEnroll(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeClassID, System.Decimal _Enrolled, System.Decimal _AsCodeDegreeID, System.Decimal _AdmAppTypeID, bool? _AwkafEmployee, decimal? PayFlg = null)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.Get_APPLICANT_ForEnroll", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AppName", DbType.String, _AppName);
            database.AddInParameter(commandWrapper, "@AppCodefrom", DbType.String, _AppCodefrom);
            database.AddInParameter(commandWrapper, "@AppCodeto", DbType.String, _AppCodeto);
            database.AddInParameter(commandWrapper, "@Sort1", DbType.Decimal, _Sort1);
            database.AddInParameter(commandWrapper, "@SortAsc", DbType.Decimal, _SortAsc);
            database.AddInParameter(commandWrapper, "@New", DbType.Decimal, New);
            database.AddInParameter(commandWrapper, "@AppType", DbType.Decimal, _AppType);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassID", DbType.Decimal, _AsCodeDegreeClassID);
            database.AddInParameter(commandWrapper, "@Enrolled", DbType.Decimal, _Enrolled);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, _AsCodeDegreeID);
            database.AddInParameter(commandWrapper, "@AdmAppTypeID", DbType.Decimal, _AdmAppTypeID);
            database.AddInParameter(commandWrapper, "@AwkafEmployee", DbType.Boolean, _AwkafEmployee.HasValue ? (object)_AwkafEmployee : DBNull.Value);
            if(PayFlg.HasValue)
                database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, PayFlg);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullName");
            table.Columns.Add("NationalityName");
            table.Columns.Add("BirthDate");
            table.Columns.Add("AppDate");
            table.Columns.Add("CertfPercent");
            table.Columns.Add("COMPTATIVERATE");
            table.Columns.Add("FACULTYDESCRAR");
            table.Columns.Add("FACULTYDESCREN");
            table.Columns.Add("ADM_APP_REG_HISTORY_ID");
            table.Columns.Add("ED_ACAD_YEAR_ID");
            table.Columns.Add("ED_CODE_SEMESTER_ID");
            table.Columns.Add("IS_PAYED");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString() };
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

        public override DataTable GetForApproveNU(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New, System.Decimal _AsCodeDegreeID, System.Decimal AdmCdeStatusId, System.Decimal EdCdeQualStatus)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetForApprove", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AppName", DbType.String, _AppName);
            database.AddInParameter(commandWrapper, "@AppCodefrom", DbType.String, _AppCodefrom);
            database.AddInParameter(commandWrapper, "@AppCodeto", DbType.String, _AppCodeto);
            database.AddInParameter(commandWrapper, "@Sort1", DbType.Decimal, _Sort1);
            database.AddInParameter(commandWrapper, "@SortAsc", DbType.Decimal, _SortAsc);
            database.AddInParameter(commandWrapper, "@New", DbType.Decimal, New);
            database.AddInParameter(commandWrapper, "@AppType", DbType.Decimal, _AppType);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeID", DbType.Decimal, _AsCodeDegreeID);

            database.AddInParameter(commandWrapper, "@AdmCdeStatusId", DbType.Decimal, AdmCdeStatusId);
            database.AddInParameter(commandWrapper, "@EdCdeQualStatus", DbType.Decimal, EdCdeQualStatus);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullName");
            table.Columns.Add("NationalityName");
            table.Columns.Add("BirthDate");
            table.Columns.Add("AppDate");
            table.Columns.Add("CertfPercent");
            table.Columns.Add("COMPTATIVERATE");
            table.Columns.Add("FACULTYDESCRAR");
            table.Columns.Add("FACULTYDESCREN");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable GetApproved(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _AppName, System.String _AppCodefrom, System.String _AppCodeto, System.Decimal _Sort1, System.Decimal _SortAsc, System.Decimal _AppType, System.Decimal New)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetApproved", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AppName", DbType.String, _AppName);
            database.AddInParameter(commandWrapper, "@AppCodefrom", DbType.String, _AppCodefrom);
            database.AddInParameter(commandWrapper, "@AppCodeto", DbType.String, _AppCodeto);
            database.AddInParameter(commandWrapper, "@Sort1", DbType.Decimal, _Sort1);
            database.AddInParameter(commandWrapper, "@SortAsc", DbType.Decimal, _SortAsc);
            database.AddInParameter(commandWrapper, "@New", DbType.Decimal, New);
            database.AddInParameter(commandWrapper, "@AppType", DbType.Decimal, _AppType);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullName");
            table.Columns.Add("NationalityName");
            table.Columns.Add("BirthDate");
            table.Columns.Add("AppDate");
            table.Columns.Add("CertfPercent");
            table.Columns.Add("COMPTATIVERATE");
            table.Columns.Add("FACULTYDESCRAR");
            table.Columns.Add("FACULTYDESCREN");
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString() };
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

        public override DataTable GetAllApproved(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetAllApproved", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("IdentNum");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("EntDescrAr");
            table.Columns.Add("EntDescrEn");

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

        public override DataTable GetAllApprovedForTransfer(TransactionManager transactionManager, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.Decimal _EntMainId, System.Decimal _Lang, System.String _StudName, System.String _AppCode, System.Decimal _AppType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetAllApprovedForTransfer", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, _EdAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, _EdCodeSemesterId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@Lang", DbType.Decimal, _Lang);
            database.AddInParameter(commandWrapper, "@AppCode", DbType.String, _AppCode);
            database.AddInParameter(commandWrapper, "@StudName", DbType.String, _StudName);
            database.AddInParameter(commandWrapper, "@AppType", DbType.String, _AppType);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("BirthDate");
            table.Columns.Add("AppDate");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("NationalityDescrAr");
            table.Columns.Add("NationalityDescrEn");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() };
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

        public override DataTable GetForPlacementExam(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _AdmCdePlacementExamId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetForPlacementExam", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AdmCdePlacementExamId", DbType.Decimal, _AdmCdePlacementExamId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmCdeStatusId");
            table.Columns.Add("EntMainId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");

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

        public override DataTable GetForReqDoc(TransactionManager transactionManager, System.Decimal _EntMainId, System.Decimal _AdmReqDocId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_GetForReqDoc", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EntMainId", DbType.Decimal, _EntMainId);
            database.AddInParameter(commandWrapper, "@AdmReqDocId", DbType.Decimal, _AdmReqDocId);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmCdeStatusId");
            table.Columns.Add("EntMainId");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");

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
           //added by mmq at 07/06/2016
        public override DataTable AdvancedSearch_2(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId,decimal? AsFacultyInfoId,
            decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
            string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
            decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
            decimal? enrolledFlg, decimal lang, int PageIndex, int PageSize , decimal AdmissionOfficer ,decimal QualCodeCatId ,decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, int onlineFlag, decimal edCdeQualStatusId, decimal? rcvdFlg, decimal? busFlg, decimal? IsAcceptedInSCU,
            DateTime? FromDate, DateTime? ToDate, DateTime? SubmitDateFrom, DateTime? SubmitDateTo, decimal? Major, string PassportNo, string Email, decimal? FeeStatus, decimal? AwkafFlg, decimal? MaritalStatusID, decimal? SocialAffairsID, decimal? SpecialNeedFlg, int PaymentStatus,
            decimal? EntDepartmentID, decimal? SrcOfFund, decimal? EnglishReq, decimal? GsCountryNodeId, decimal? SponsorID, decimal? SponsorOfferID,
            decimal? SeUserID, decimal? SchoolnameId, string txtSchoolName, decimal? AdmCdeAppStatusID, decimal? TansikFlg, decimal? Adm_Decision_Status_Id, string Student_Code, string tansiqCodes)
            

        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_ADVANCED_SEARCH", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, admCdeAppTypeId.HasValue ? (object)admCdeAppTypeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmCdeStatusId", DbType.Decimal, admCdeStatusId.HasValue ? (object)admCdeStatusId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId.HasValue ? (object)asCodeDegreeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, string.IsNullOrEmpty(applicantCode) ? DBNull.Value : (object)applicantCode);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@ApplicantName", DbType.String, string.IsNullOrEmpty(applicantName) ? DBNull.Value : (object)applicantName);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId.HasValue ? (object)gsCoutryNodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmAdmissionBandId", DbType.Decimal, admAdmissionBandId.HasValue ? (object)admAdmissionBandId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId.HasValue ? (object)gsCodeGenderId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeMaritalStatus", DbType.Decimal, GsCdeMaritalStatusId.HasValue ? (object)GsCdeMaritalStatusId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OrientationFlg", DbType.Decimal, orientationFlg.HasValue ? (object)orientationFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AcceptedFlg", DbType.Decimal, acceptedFlg.HasValue ? (object)acceptedFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@DistributionFlg", DbType.Decimal, distributionFlg.HasValue ? (object)distributionFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EnrolledFlg", DbType.Decimal, enrolledFlg.HasValue ? (object)enrolledFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, lang);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);

            //modified by olivia 29/12/2020 Task: 15866
            //if (onlineFlag == true)
            //{
            database.AddInParameter(commandWrapper, "@onlineFlag", DbType.Decimal, onlineFlag);
            //}
            //else 
            //{
            //    database.AddInParameter(commandWrapper, "@onlineFlag", DbType.Decimal, 0); 
            //}
            // new search critria added 20-4-2014 -adel

            database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer!=0 ? (object)AdmissionOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualCatId", DbType.Decimal, QualCodeCatId!=0 ? (object)QualCodeCatId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualId", DbType.Decimal, QualCodeId!=0 ? (object)QualCodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualBrnId", DbType.Decimal, QualSpecializtion!=0 ? (object)QualSpecializtion : DBNull.Value);
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, TotalDegree  );
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, TotalPercent );
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, EnglishPercent );
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, PayFlg);
            database.AddInParameter(commandWrapper, "@EdCdeQualStatusId", DbType.Decimal, edCdeQualStatusId);
            database.AddInParameter(commandWrapper, "@RcvdFlg", DbType.Decimal, rcvdFlg.HasValue ? (rcvdFlg.Value == -1 ? ((object)DBNull.Value) : (rcvdFlg.Value)) : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@BusFlg", DbType.Decimal, busFlg.HasValue ? (busFlg.Value == -1 ? ((object)DBNull.Value) : (busFlg.Value)) : (object)DBNull.Value);
            database.AddInParameter(commandWrapper, "@IsAcceptedInSCU", DbType.Decimal, IsAcceptedInSCU.HasValue ? (IsAcceptedInSCU.Value == -1 ? ((object)DBNull.Value) : (IsAcceptedInSCU.Value)) : (object)DBNull.Value);
            // New Search critria added 17-12-2014 -Mohamed Yousif
            database.AddInParameter(commandWrapper, "@FromDate", DbType.Date, FromDate.HasValue ? FromDate.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@ToDate", DbType.Date, ToDate.HasValue ? ToDate.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@SubmitDateFrom", DbType.Date, SubmitDateFrom.HasValue ? SubmitDateFrom.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@SubmitDateTo", DbType.Date, SubmitDateTo.HasValue ? SubmitDateTo.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@MajorID", DbType.Decimal, Major.HasValue ? Major.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@PassportNo", DbType.String, PassportNo != "" ? PassportNo : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@Email", DbType.String, Email != "" ? Email : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@FeeStatus", DbType.Decimal, FeeStatus.HasValue ? FeeStatus.Value : ((object)DBNull.Value));

            //New Search critria added by eman moustfa 29/7/2019  
            database.AddInParameter(commandWrapper, "@AwkafFlg", DbType.Decimal, AwkafFlg.HasValue ? AwkafFlg.Value : ((object)DBNull.Value));
            //New Search critria added by eman moustfa 6/8/2019  
            database.AddInParameter(commandWrapper, "@MaritalStatusID", DbType.Decimal, MaritalStatusID.HasValue ? MaritalStatusID.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@SocialAffairsID", DbType.Decimal, SocialAffairsID.HasValue ? SocialAffairsID.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@SpecialNeedFlg", DbType.Decimal, SpecialNeedFlg.HasValue ? SpecialNeedFlg.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@PaymentStatus", DbType.Int32, PaymentStatus);
            database.AddInParameter(commandWrapper, "@EntDepartmentID", DbType.Decimal, EntDepartmentID);
            database.AddInParameter(commandWrapper, "@SrcOfFund", DbType.Decimal, SrcOfFund);
            database.AddInParameter(commandWrapper, "@EnglishReq", DbType.Decimal, EnglishReq);
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, GsCountryNodeId); //esraa yousef 26-7-2020 
            //added by olivia 27/12/2020 Task: 15866
            database.AddInParameter(commandWrapper, "@SponsorID", DbType.Decimal, SponsorID);
            database.AddInParameter(commandWrapper, "@SponsorOfferID", DbType.Decimal, SponsorOfferID);
            //added by olivia 29/12/2020 Task: 15866
            database.AddInParameter(commandWrapper, "@SeUserID", DbType.Decimal, SeUserID);
            database.AddInParameter(commandWrapper, "@txtSchoolName", DbType.String, txtSchoolName);
            database.AddInParameter(commandWrapper, "@SchoolNameId", DbType.Decimal, SchoolnameId);
            //Added By M-Hassan 13-02-2018 (NU Request need to add search if applicant is accepted by SCU or not)
            //database.AddInParameter(commandWrapper, "@EdCdeQualStatusId", DbType.Decimal, IsAcceptedBySCU);
            database.AddInParameter(commandWrapper, "@AdmCdeAppStatusId", DbType.Decimal, AdmCdeAppStatusID);
            //added by olivia 23/9/2021 'TansikFlg'
            database.AddInParameter(commandWrapper, "@TansikFlg", DbType.Decimal, TansikFlg.HasValue ? TansikFlg.Value : ((object)DBNull.Value));
            database.AddInParameter(commandWrapper, "@Adm_Decision_Status_Id", DbType.Decimal, Adm_Decision_Status_Id.HasValue ? Adm_Decision_Status_Id.Value : ((object)DBNull.Value));//added by hoda at 1/12/2021 to add DecisionStatus for "EUE" Task 17493
            database.AddInParameter(commandWrapper, "@Student_Code", DbType.String, Student_Code);//added by hoda at 23/3/2022 to add student code for eue            
            database.AddInParameter(commandWrapper, "@TansiqCodes", DbType.String, string.IsNullOrEmpty(tansiqCodes) ? DBNull.Value : (object)tansiqCodes); //added by hoda at 18/5/2022 for BU task 18364 

            DataSet ds = null;

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }


        public override DataTable AdvancedSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, decimal? AsFacultyInfoId,
           decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
           string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
           decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
           decimal? enrolledFlg, decimal lang, int PageIndex, int PageSize, decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
           decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_ADVANCED_SEARCH", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId.HasValue ? (object)AsFacultyInfoId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, admCdeAppTypeId.HasValue ? (object)admCdeAppTypeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmCdeStatusId", DbType.Decimal, admCdeStatusId.HasValue ? (object)admCdeStatusId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId.HasValue ? (object)asCodeDegreeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, string.IsNullOrEmpty(applicantCode) ? DBNull.Value : (object)applicantCode);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@ApplicantName", DbType.String, string.IsNullOrEmpty(applicantName) ? DBNull.Value : (object)applicantName);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId.HasValue ? (object)gsCoutryNodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmAdmissionBandId", DbType.Decimal, admAdmissionBandId.HasValue ? (object)admAdmissionBandId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId.HasValue ? (object)gsCodeGenderId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeMaritalStatus", DbType.Decimal, GsCdeMaritalStatusId.HasValue ? (object)GsCdeMaritalStatusId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OrientationFlg", DbType.Decimal, orientationFlg.HasValue ? (object)orientationFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AcceptedFlg", DbType.Decimal, acceptedFlg.HasValue ? (object)acceptedFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@DistributionFlg", DbType.Decimal, distributionFlg.HasValue ? (object)distributionFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EnrolledFlg", DbType.Decimal, enrolledFlg.HasValue ? (object)enrolledFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, lang);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
          
            
            // new search critria added 20-4-2014 -adel

            database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer != 0 ? (object)AdmissionOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualCatId", DbType.Decimal, QualCodeCatId != 0 ? (object)QualCodeCatId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualId", DbType.Decimal, QualCodeId != 0 ? (object)QualCodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualBrnId", DbType.Decimal, QualSpecializtion != 0 ? (object)QualSpecializtion : DBNull.Value);
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, TotalPercent);
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, EnglishPercent);
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, PayFlg);
            DataSet ds = null;

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public override DataTable AdvancedSearchCntrl(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, decimal AsFacultyInfoId,
          string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal gsCoutryNodeId,
          decimal gsCodeGenderId, decimal lang, int PageIndex, int PageSize, decimal PayFlg, decimal MajorId, decimal AsCodeDegreeClass,decimal? SponsorId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ADM_APPLICANT_SEARCH_CNTR", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@AsFacultyInfoId", DbType.Decimal, AsFacultyInfoId);

            database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, string.IsNullOrEmpty(applicantCode) ? DBNull.Value : (object)applicantCode);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@ApplicantName", DbType.String, string.IsNullOrEmpty(applicantName) ? DBNull.Value : (object)applicantName);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId);
    
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, lang);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, PayFlg);
            database.AddInParameter(commandWrapper, "@MajorId", DbType.Decimal, MajorId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClass", DbType.Decimal, AsCodeDegreeClass);
            database.AddInParameter(commandWrapper, "@SpoSponsorID", DbType.Decimal, SponsorId.HasValue ? (object) SponsorId.Value : DBNull.Value);
            DataSet ds = null;

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public override DataTable AdvancedSearchEnrollment(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId,
       decimal? admCdeAppTypeId, decimal? admCdeStatusId, decimal? asCodeDegreeClassId, decimal? asCodeDegreeId,
       string applicantCode, string cpr, decimal namePolicy, string applicantName, decimal? gsCoutryNodeId, decimal? admAdmissionBandId,
       decimal? gsCodeGenderId, decimal? GsCdeMaritalStatusId, decimal? orientationFlg, decimal? acceptedFlg, decimal? distributionFlg,
       decimal? enrolledFlg, decimal lang, decimal CompRateFrom, decimal CompRateTo, decimal EdcodeQualId, decimal EdCodeQualCatId, decimal EdcodeQualBrnId, int PageIndex, int PageSize,
             decimal AdmissionOfficer, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal EnrolledCollege, decimal EnrolledProgram)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_ADM_APPLICANT_ADVANCED_Enrollment", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, admCdeAppTypeId.HasValue ? (object)admCdeAppTypeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmCdeStatusId", DbType.Decimal, admCdeStatusId.HasValue ? (object)admCdeStatusId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId.HasValue ? (object)asCodeDegreeClassId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId.HasValue ? (object)asCodeDegreeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, string.IsNullOrEmpty(applicantCode) ? DBNull.Value : (object)applicantCode);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@NamePolicy", DbType.Decimal, namePolicy);
            database.AddInParameter(commandWrapper, "@ApplicantName", DbType.String, string.IsNullOrEmpty(applicantName) ? DBNull.Value : (object)applicantName);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId.HasValue ? (object)gsCoutryNodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmAdmissionBandId", DbType.Decimal, admAdmissionBandId.HasValue ? (object)admAdmissionBandId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId.HasValue ? (object)gsCodeGenderId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@GsCdeMaritalStatus", DbType.Decimal, GsCdeMaritalStatusId.HasValue ? (object)GsCdeMaritalStatusId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@OrientationFlg", DbType.Decimal, orientationFlg.HasValue ? (object)orientationFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AcceptedFlg", DbType.Decimal, acceptedFlg.HasValue ? (object)acceptedFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@DistributionFlg", DbType.Decimal, distributionFlg.HasValue ? (object)distributionFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@EnrolledFlg", DbType.Decimal, enrolledFlg.HasValue ? (object)enrolledFlg : DBNull.Value);
            database.AddInParameter(commandWrapper, "@LangNum", DbType.Decimal, lang);
            database.AddInParameter(commandWrapper, "@CompRateTo", DbType.Decimal, CompRateTo);
            database.AddInParameter(commandWrapper, "@CompRateFrom", DbType.Decimal, CompRateFrom);
            database.AddInParameter(commandWrapper, "@EdCodequalId", DbType.Decimal, EdcodeQualId);
            database.AddInParameter(commandWrapper, "@edQualCatId", DbType.Decimal, EdCodeQualCatId);
            database.AddInParameter(commandWrapper, "@edcodeQualBRNId", DbType.Decimal, EdcodeQualBrnId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, PageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, PageSize);
           

             database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer != 0 ? (object)AdmissionOfficer : DBNull.Value);
           
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, TotalPercent);
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, EnglishPercent);
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);
            database.AddInParameter(commandWrapper, "@EnrolledCollege", DbType.Decimal, EnrolledCollege);
            database.AddInParameter(commandWrapper, "@EnrolledProgram", DbType.Decimal, EnrolledProgram);
            DataSet ds = null;

            try
            {
                //Provider Data Requesting Command Event
                //OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    ds = Utility.ExecuteDataSet(transactionManager, commandWrapper);
                }
                else
                {
                    ds = Utility.ExecuteDataSet(database, commandWrapper);
                }

                //Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                commandWrapper = null;
            }
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public override DataTable ApplicantSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
            decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
            decimal? admCdeFeeId, decimal? hasFees, decimal? DocId, decimal? hasExam, decimal? AdmPlaceExamDateTimeId, decimal? hasOfficer,
            decimal? AdmOpenAcadSemesterId, string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
             decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
            decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? gsCdeSchoolId, decimal? SponsorID, decimal? GsCdeMaritalStatusId
            , decimal LoadFeesPage, string email, decimal AppStatus
            )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApplicantSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@SearchText", DbType.String, string.IsNullOrEmpty(searchText) ? DBNull.Value : (object)searchText);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, age.HasValue ? (object)age : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, ageOperation == "0" ? DBNull.Value : (object)ageOperation);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, admCdeAppTypeId);
            database.AddInParameter(commandWrapper, "@AdmCdeFeeId", DbType.Decimal, admCdeFeeId.HasValue ? (object)admCdeFeeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@HasFees", DbType.Decimal, hasFees.HasValue ? (object)hasFees : DBNull.Value);
            database.AddInParameter(commandWrapper, "@DocId", DbType.Decimal, DocId.HasValue ? (object)DocId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@HasExams", DbType.Decimal, hasExam.HasValue ? (object)hasExam : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmPlaceExamDateTimeId", DbType.Decimal, AdmPlaceExamDateTimeId.HasValue ? (object)AdmPlaceExamDateTimeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@HasOfficer", DbType.Decimal, hasOfficer.HasValue ? (object)hasOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, AdmOpenAcadSemesterId.HasValue ? (object)AdmOpenAcadSemesterId : DBNull.Value);

            database.AddInParameter(commandWrapper, "@FromCode", DbType.String, string.IsNullOrEmpty(fromCode) ? DBNull.Value : (object)fromCode);
            database.AddInParameter(commandWrapper, "@ToCode", DbType.String, string.IsNullOrEmpty(toCode) ? DBNull.Value : (object)toCode);
            database.AddInParameter(commandWrapper, "@AllowPaging", DbType.Decimal, allowPaging);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);


            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, PayFlg);
            database.AddInParameter(commandWrapper, "@gsCdeSchoolId", DbType.Decimal, gsCdeSchoolId);
            // new search critria added 20-4-2014 -adel

            database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer != 0 ? (object)AdmissionOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualCatId", DbType.Decimal, QualCodeCatId != 0 ? (object)QualCodeCatId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualId", DbType.Decimal, QualCodeId != 0 ? (object)QualCodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualBrnId", DbType.Decimal, QualSpecializtion != 0 ? (object)QualSpecializtion : DBNull.Value);
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, TotalPercent);
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, EnglishPercent);
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);
            database.AddInParameter(commandWrapper, "@SponsorID", DbType.Decimal, SponsorID);
            database.AddInParameter(commandWrapper, "@GsCdeMaritalStatusId", DbType.Decimal, GsCdeMaritalStatusId);//Added by Menna 01-09-2019 task 10272
            database.AddInParameter(commandWrapper, "@LoadFeesPage", DbType.Decimal, LoadFeesPage);
            database.AddInParameter(commandWrapper, "@Email", DbType.String, email);
            database.AddInParameter(commandWrapper, "@AppStatus", DbType.Decimal, AppStatus);
            IDataReader reader = null;

            //Create Collection
            //  TList<AdmApplicant> rows = new TList<AdmApplicant>();

            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("Username");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("CPR");
            table.Columns.Add("otherExams");
            table.Columns.Add("RowsTotCount");

            try
            {
                //Provider Data Requesting Command Event
                //   OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //int start = 0, pageLength = int.MaxValue;
                //Fill(reader, rows, start, pageLength);

                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));


                while (reader.Read())
                {
                    //Edit by Menna 10-04-2019 Bug 9512
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
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

        public override DataTable ApplicantSearch_ejust(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
           decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId,
           decimal? admCdeFeeId, decimal? hasFees, decimal? DocId, decimal? hasExam, decimal? AdmPlaceExamDateTimeId, decimal? hasOfficer,
           decimal? AdmOpenAcadSemesterId, string fromCode, string toCode, decimal allowPaging, decimal pageIndex, decimal pageSize,
            decimal AdmissionOfficer, decimal QualCodeCatId, decimal QualCodeId,
           decimal QualSpecializtion, decimal TotalDegree, decimal TotalPercent, decimal EnglishPercent, decimal IsPublicSchool, decimal PayFlg, decimal? gsCdeSchoolId,
            decimal? FromDegree, decimal? ToDegree, bool IsInterview, decimal? Gender_Type_ID, decimal? App_Type_ID,
            decimal? AS_FACULTY_INFO_ID, decimal ApplicantStatus, decimal FailAbsent

           )
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ApplicantSearch_ejust", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@SearchText", DbType.String, string.IsNullOrEmpty(searchText) ? DBNull.Value : (object)searchText);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, age.HasValue ? (object)age : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, ageOperation == "0" ? DBNull.Value : (object)ageOperation);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, admCdeAppTypeId);
            database.AddInParameter(commandWrapper, "@AdmCdeFeeId", DbType.Decimal, admCdeFeeId.HasValue ? (object)admCdeFeeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@HasFees", DbType.Decimal, hasFees.HasValue ? (object)hasFees : DBNull.Value);
            database.AddInParameter(commandWrapper, "@DocId", DbType.Decimal, DocId.HasValue ? (object)DocId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@HasExams", DbType.Decimal, hasExam.HasValue ? (object)hasExam : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmPlaceExamDateTimeId", DbType.Decimal, AdmPlaceExamDateTimeId.HasValue ? (object)AdmPlaceExamDateTimeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@HasOfficer", DbType.Decimal, hasOfficer.HasValue ? (object)hasOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, AdmOpenAcadSemesterId.HasValue ? (object)AdmOpenAcadSemesterId : DBNull.Value);

            database.AddInParameter(commandWrapper, "@FromCode", DbType.String, string.IsNullOrEmpty(fromCode) ? DBNull.Value : (object)fromCode);
            database.AddInParameter(commandWrapper, "@ToCode", DbType.String, string.IsNullOrEmpty(toCode) ? DBNull.Value : (object)toCode);
            database.AddInParameter(commandWrapper, "@AllowPaging", DbType.Decimal, allowPaging);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);


            database.AddInParameter(commandWrapper, "@PayFlg", DbType.Decimal, PayFlg);
            database.AddInParameter(commandWrapper, "@gsCdeSchoolId", DbType.Decimal, gsCdeSchoolId);
            // new search critria added 20-4-2014 -adel

            database.AddInParameter(commandWrapper, "@AdmissionOfficer", DbType.Decimal, AdmissionOfficer != 0 ? (object)AdmissionOfficer : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualCatId", DbType.Decimal, QualCodeCatId != 0 ? (object)QualCodeCatId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualId", DbType.Decimal, QualCodeId != 0 ? (object)QualCodeId : DBNull.Value);
            database.AddInParameter(commandWrapper, "@QualBrnId", DbType.Decimal, QualSpecializtion != 0 ? (object)QualSpecializtion : DBNull.Value);
            database.AddInParameter(commandWrapper, "@TotalDegree", DbType.Decimal, TotalDegree);
            database.AddInParameter(commandWrapper, "@TotalPercent", DbType.Decimal, TotalPercent);
            database.AddInParameter(commandWrapper, "@EnglishPercent", DbType.Decimal, EnglishPercent);
            database.AddInParameter(commandWrapper, "@IsPublicSchool", DbType.Decimal, IsPublicSchool);

            database.AddInParameter(commandWrapper, "@FromDegree", DbType.Decimal, FromDegree);
            database.AddInParameter(commandWrapper, "@ToDegree", DbType.Decimal, ToDegree);


            database.AddInParameter(commandWrapper, "@IsInterview", DbType.Decimal, IsInterview);
            //added by eman moustafa 17-7-2019 task:10147
            database.AddInParameter(commandWrapper, "@Gender_Type_ID", DbType.Decimal, Gender_Type_ID);
            database.AddInParameter(commandWrapper, "@App_Type_ID", DbType.Decimal, App_Type_ID);

            database.AddInParameter(commandWrapper, "@AS_FACULTY_INFO_ID", DbType.Decimal, AS_FACULTY_INFO_ID);
            database.AddInParameter(commandWrapper, "@ApplicantStatus", DbType.Decimal, ApplicantStatus);
            database.AddInParameter(commandWrapper, "@FailAbsent", DbType.Decimal, FailAbsent);

            IDataReader reader = null;

            //Create Collection
            //  TList<AdmApplicant> rows = new TList<AdmApplicant>();

            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("Username");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("CPR");
            table.Columns.Add("otherExams");
            table.Columns.Add("isParentExamExempted");
            table.Columns.Add("RowsTotCount");

            try
            {
                //Provider Data Requesting Command Event
                //   OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //int start = 0, pageLength = int.MaxValue;
                //Fill(reader, rows, start, pageLength);

                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));


                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() };
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

        public override DataTable AdmAppDocApplicants(TransactionManager transactionManager, decimal AdmReqDocId, decimal pageIndex, decimal pageSize, decimal? AdmCdeAppTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AdmAppDocApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmReqDocId", DbType.Decimal, AdmReqDocId);            
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, AdmCdeAppTypeId);
            IDataReader reader = null;

            //Create Collection
            //  TList<AdmApplicant> rows = new TList<AdmApplicant>();

            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AdmAppDocId");
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("CPR");
            table.Columns.Add("GsCountryNodeId");
            table.Columns.Add("NationDescrEn");
            table.Columns.Add("NationDescrAr");
            table.Columns.Add("RowsTotCount");

            try
            {
                //Provider Data Requesting Command Event
                //   OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //int start = 0, pageLength = int.MaxValue;
                //Fill(reader, rows, start, pageLength);

                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));


                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), 
                                         reader[2].ToString(), reader[3].ToString(),
                                         reader[4].ToString(), reader[5].ToString(),
                                         reader[6].ToString(), reader[7].ToString()
                                     , reader[8].ToString(), reader[9].ToString(), reader[10].ToString()
                                     
                                     };
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

        public override DataTable AdmAppFeesApplicants(TransactionManager transactionManager, decimal AdmCdeFeeId, decimal AdmOpenAcadSemesterId, decimal pageIndex, decimal pageSize, string ApplicantCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.AdmAppFeesApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmCdeFeeId", DbType.Decimal, AdmCdeFeeId);
            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, AdmOpenAcadSemesterId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);
            database.AddInParameter(commandWrapper, "@ApplicantCode", DbType.String, ApplicantCode);

            IDataReader reader = null;

            //Create Collection
            //  TList<AdmApplicant> rows = new TList<AdmApplicant>();

            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AdmAppFeesId");
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            table.Columns.Add("FullNameEn");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("CPR");
            table.Columns.Add("GsCountryNodeId");
            table.Columns.Add("NationDescrEn");
            table.Columns.Add("NationDescrAr");
            table.Columns.Add("IsPayed");
            table.Columns.Add("RowsTotCount");

            try
            {
                //Provider Data Requesting Command Event
                //   OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //int start = 0, pageLength = int.MaxValue;
                //Fill(reader, rows, start, pageLength);

                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));


                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), 
                                         reader[2].ToString(), reader[3].ToString(),
                                         reader[4].ToString(), reader[5].ToString(),
                                         reader[6].ToString(), reader[7].ToString()
                                     , reader[8].ToString(), reader[9].ToString(), reader[10].ToString(),reader[11].ToString()
                                     
                                     };
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

        public override DataTable GetOfficerApplicants(TransactionManager transactionManager, decimal seUserId,decimal admOpenAcadSemesterId, decimal pageIndex, decimal pageSize)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetOfficerApplicants", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, seUserId);
            database.AddInParameter(commandWrapper, "@AdmOpenAcadSemesterId", DbType.Decimal, admOpenAcadSemesterId);
            database.AddInParameter(commandWrapper, "@PageIndex", DbType.Decimal, pageIndex);
            database.AddInParameter(commandWrapper, "@PageSize", DbType.Decimal, pageSize);
            IDataReader reader = null;

            //Create Collection
            //  TList<AdmApplicant> rows = new TList<AdmApplicant>();

            DataTable table = new DataTable();
            table.Columns.Add("sn");
            table.Columns.Add("AdmApplicantId");
            table.Columns.Add("AdmAppCode");
            
            table.Columns.Add("FullNameEn");
            table.Columns.Add("FullNameAr");
            table.Columns.Add("CPR");
            
            table.Columns.Add("RowsTotCount");

            try
            {
                //Provider Data Requesting Command Event
                //   OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                //int start = 0, pageLength = int.MaxValue;
                //Fill(reader, rows, start, pageLength);

                ////Provider Data Requested Command Event
                //OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));


                while (reader.Read())
                {
                    object[] items = { reader[0].ToString(), reader[1].ToString(), 
                                         reader[2].ToString(), reader[3].ToString(),
                                         reader[4].ToString(), reader[5].ToString(),
                                         reader[6].ToString()
                                     
                                     };
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


        public override TList<AdmApplicant> SeApplicantSearch(TransactionManager transactionManager, decimal edAcadYearId, decimal edCodeSemsterId, string searchText, string cpr,
           decimal asCodeDegreeClassId, decimal asCodeDegreeId, int? age, string ageOperation, decimal seUserId, decimal gsCodeGenderId, decimal gsCoutryNodeId, decimal admCdeAppTypeId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_SeUserApplicantSearch", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@EdCodeSemesterId", DbType.Decimal, edCodeSemsterId);
            database.AddInParameter(commandWrapper, "@EdAcadYearId", DbType.Decimal, edAcadYearId);
            database.AddInParameter(commandWrapper, "@SearchText", DbType.String, string.IsNullOrEmpty(searchText) ? DBNull.Value : (object)searchText);
            database.AddInParameter(commandWrapper, "@CPR", DbType.String, string.IsNullOrEmpty(cpr) ? DBNull.Value : (object)cpr);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeClassId", DbType.Decimal, asCodeDegreeClassId);
            database.AddInParameter(commandWrapper, "@AsCodeDegreeId", DbType.Decimal, asCodeDegreeId);
            database.AddInParameter(commandWrapper, "@Age", DbType.Decimal, age.HasValue ? (object)age : DBNull.Value);
            database.AddInParameter(commandWrapper, "@AgeOperator", DbType.String, ageOperation == null ? DBNull.Value : (object)ageOperation);
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, gsCodeGenderId);
            database.AddInParameter(commandWrapper, "@GsCoutryNodeId", DbType.Decimal, gsCoutryNodeId);
            database.AddInParameter(commandWrapper, "@AdmCdeAppTypeId", DbType.Decimal, admCdeAppTypeId);
            database.AddInParameter(commandWrapper, "@seUserId", DbType.Decimal, seUserId);
            
             

            IDataReader reader = null;

            //Create Collection
            TList<AdmApplicant> rows = new TList<AdmApplicant>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "AdvancedSearch", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                int start = 0, pageLength = int.MaxValue;
                Fill(reader, rows, start, pageLength);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetAll", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override DataTable AutoEnrollment(TransactionManager transactionManager)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_AutoEnrollment", this.UseStoredProcedure);

           
            IDataReader reader = null;
            DataTable table = new DataTable();
          

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                    //    table.Rows.Add(items);
                    //}
                    table.Load(reader);

                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    table.Load(reader);
                    
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
        public override DataTable BulkCancelEnrollment(TransactionManager transactionManager, string AdmApplicantId, string EdStudId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_CancelBulkEnrollment", this.UseStoredProcedure);


            IDataReader reader = null;
            DataTable table = new DataTable();

            database.AddInParameter(commandWrapper, "@ADM_APPLICANT_ID", DbType.String, AdmApplicantId);
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.String, EdStudId);
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                    //    table.Rows.Add(items);
                    //}
                    table.Load(reader);

                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    table.Load(reader);

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
        public override DataTable BulkEnrollment(TransactionManager transactionManager, string AdmApplicantId, string EntMainId, System.String SecurtityAnswer, System.String SecurtityParentAnswer, System.Decimal UserCreatorId, System.String ADUSERGUID, System.String ADUSERParentGUID, System.String SessionId, String ServiceUrl, String ServiceKey)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_BulkEnrollment", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@ADM_APPLICANT_ID", DbType.String, AdmApplicantId);
            database.AddInParameter(commandWrapper, "@EntMainId", DbType.String, EntMainId);
            database.AddInParameter(commandWrapper, "@SecurtityAnswer", DbType.String, SecurtityAnswer);
            database.AddInParameter(commandWrapper, "@SecurtityParentAnswer", DbType.String, SecurtityParentAnswer);
            database.AddInParameter(commandWrapper, "@UserCreatorId", DbType.Decimal, UserCreatorId);
            database.AddInParameter(commandWrapper, "@ADUSERGUID", DbType.String, ADUSERGUID);
            database.AddInParameter(commandWrapper, "@ADUSERParentGUID", DbType.String, ADUSERParentGUID);

            database.AddInParameter(commandWrapper, "@SessionID", DbType.String, SessionId);
            database.AddInParameter(commandWrapper, "@sUrl", DbType.String, ServiceUrl);
            database.AddInParameter(commandWrapper, "@sKey", DbType.String, ServiceKey);
            IDataReader reader = null;
            DataTable table = new DataTable();
         
           
            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    //while (reader.Read())
                    //{
                    //    object[] items = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() };
                    //    table.Rows.Add(items);
                    //}
                    table.Load(reader);

                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    table.Load(reader);

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
        public override TList<AdmApplicant> GetApplicantByCode(TransactionManager transactionManager, string AppCode)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.GetApplicantByCode", this.UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AppCode", DbType.String, AppCode);
            
            IDataReader reader = null;

            //Create Collection
            TList<AdmApplicant> rows = new TList<AdmApplicant>();

            try
            {
                //Provider Data Requesting Command Event
                OnDataRequesting(new CommandEventArgs(commandWrapper, "GetApplicantByCode", rows));

                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                }

                int start = 0, pageLength = int.MaxValue;
                Fill(reader, rows, start, pageLength);

                //Provider Data Requested Command Event
                OnDataRequested(new CommandEventArgs(commandWrapper, "GetApplicantByCode", rows));
            }
            finally
            {
                if (reader != null)
                    reader.Close();

                commandWrapper = null;
            }
            return rows;
        }

        public override DataTable CheckForSubmitForKU(TransactionManager transactionManager, System.Decimal _AppplicantId, System.Decimal _userType)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_CheckForSubmit_KU", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);
            database.AddInParameter(commandWrapper, "@userType", DbType.Decimal, _userType);

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TabDescr");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        public override DataTable CheckForReview1(TransactionManager transactionManager, System.Decimal _AppplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.C_CheckForReview1", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);
            
            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TabDescr");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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
        // Task No:6905,Made By:eman moustafa,Desc:  check on qwualification ,Date:17/4/2019
        public override DataTable CheckForApplicant_QualKU(TransactionManager transactionManager, System.Decimal _AppplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_Chk_Applicant_Qual", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);
           

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TabDescr");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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

        #endregion

        // Task No:9777,Made By:eman moustafa,Desc:  check on Load_Docment ,Date:25/4/2019
        public override DataTable chk_App_Load_Doc(TransactionManager transactionManager, System.Decimal _AppplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_Chk_App_Load_Doc", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);


            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TabDescr");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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
        // Task No:9809,Made By:eman moustafa,Desc:  check on allowing studNum in Faculty ,Date:6/5/2019
        public override DataTable Check_NumStud(TransactionManager transactionManager, System.Decimal _AppplicantId)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "Chek_On_STDNum_InFucalty", UseStoredProcedure);

            database.AddInParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, _AppplicantId);
            

            IDataReader reader = null;
            DataTable table = new DataTable();
            table.Columns.Add("TabDescr");

            try
            {
                if (transactionManager != null)
                {
                    reader = Utility.ExecuteReader(transactionManager, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
                        table.Rows.Add(items);
                    }
                }
                else
                {
                    reader = Utility.ExecuteReader(database, commandWrapper);
                    //read data
                    while (reader.Read())
                    {
                        object[] items = { reader[0].ToString() };
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
        #region Updated Methods

        public override bool Insert(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.AdmApplicant entity)
        {
            SqlDatabase database = new SqlDatabase(this.ConnectionString);
            DbCommand commandWrapper = StoredProcedureProvider.GetCommandWrapper(database, "dbo.ADM_APPLICANT_Insert", UseStoredProcedure);

            database.AddOutParameter(commandWrapper, "@AdmApplicantId", DbType.Decimal, 5);
            database.AddInParameter(commandWrapper, "@AdmAppCode", DbType.String, entity.AdmAppCode);
            database.AddInParameter(commandWrapper, "@Username", DbType.AnsiString, entity.Username);
            database.AddInParameter(commandWrapper, "@PasswordSalt", DbType.String, entity.PasswordSalt);
            database.AddInParameter(commandWrapper, "@PasswordHash", DbType.String, entity.PasswordHash);
            database.AddInParameter(commandWrapper, "@SecurityQs", DbType.String, entity.SecurityQs);
            database.AddInParameter(commandWrapper, "@SecurityQsAnsSalt", DbType.String, entity.SecurityQsAnsSalt);
            database.AddInParameter(commandWrapper, "@SecurityQsAnsHash", DbType.String, entity.SecurityQsAnsHash);
            database.AddInParameter(commandWrapper, "@ActivationCode", DbType.String, entity.ActivationCode);
            database.AddInParameter(commandWrapper, "@ActivationFlg", DbType.Decimal, (entity.ActivationFlg.HasValue ? (object)entity.ActivationFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@RegDate", DbType.DateTime, (entity.RegDate.HasValue ? (object)entity.RegDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FnameAr", DbType.String, entity.FnameAr);
            database.AddInParameter(commandWrapper, "@FnameEn", DbType.String, entity.FnameEn);
            database.AddInParameter(commandWrapper, "@MnameAr", DbType.String, entity.MnameAr);
            database.AddInParameter(commandWrapper, "@MnameEn", DbType.String, entity.MnameEn);
            database.AddInParameter(commandWrapper, "@LnameAr", DbType.String, entity.LnameAr);
            database.AddInParameter(commandWrapper, "@LnameEn", DbType.String, entity.LnameEn);
            database.AddInParameter(commandWrapper, "@FamilyAr", DbType.String, entity.FamilyAr);
            database.AddInParameter(commandWrapper, "@FamilyEn", DbType.String, entity.FamilyEn);
            database.AddInParameter(commandWrapper, "@GsCodeReligionId", DbType.Decimal, (entity.GsCodeReligionId.HasValue ? (object)entity.GsCodeReligionId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Cpr", DbType.String, entity.Cpr);
            database.AddInParameter(commandWrapper, "@PassporNo", DbType.String, entity.PassporNo);
            database.AddInParameter(commandWrapper, "@PassporExpireDate", DbType.Date, (entity.PassporExpireDate.HasValue ? (object)entity.PassporExpireDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@Birthdate", DbType.Date, (entity.Birthdate.HasValue ? (object)entity.Birthdate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PhotoPath", DbType.String, entity.PhotoPath);
            database.AddInParameter(commandWrapper, "@GsCdeMaritalStatusId", DbType.Decimal, (entity.GsCdeMaritalStatusId.HasValue ? (object)entity.GsCdeMaritalStatusId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeGenderId", DbType.Decimal, (entity.GsCodeGenderId.HasValue ? (object)entity.GsCodeGenderId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@WorkFlg", DbType.Decimal, (entity.WorkFlg.HasValue ? (object)entity.WorkFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCountryNodeId", DbType.Decimal, (entity.GsCountryNodeId.HasValue ? (object)entity.GsCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@FullNameAr", DbType.String, entity.FullNameAr);
            database.AddInParameter(commandWrapper, "@FullNameEn", DbType.String, entity.FullNameEn);
            database.AddInParameter(commandWrapper, "@ResidentId", DbType.String, entity.ResidentId);
            database.AddInParameter(commandWrapper, "@ResidentExpireDate", DbType.Date, (entity.ResidentExpireDate.HasValue ? (object)entity.ResidentExpireDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsBirthCountryNodeId", DbType.Decimal, (entity.GsBirthCountryNodeId.HasValue ? (object)entity.GsBirthCountryNodeId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@EdStudId", DbType.Decimal, (entity.EdStudId.HasValue ? (object)entity.EdStudId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@LoyaltyFlg", DbType.Decimal, (entity.LoyaltyFlg.HasValue ? (object)entity.LoyaltyFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@GsCodeLanguageId", DbType.Decimal, (entity.GsCodeLanguageId.HasValue ? (object)entity.GsCodeLanguageId : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@PassporIssueDate", DbType.Date, (entity.PassporIssueDate.HasValue ? (object)entity.PassporIssueDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SpecialNeedFlg", DbType.Boolean, (entity.SpecialNeedFlg.HasValue ? (object)entity.SpecialNeedFlg : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IdentIssueDate", DbType.Date, (entity.IdentIssueDate.HasValue ? (object)entity.IdentIssueDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IdentExpireDate", DbType.Date, (entity.IdentExpireDate.HasValue ? (object)entity.IdentExpireDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@IdentIssuePlc", DbType.String, entity.IdentIssuePlc);
            database.AddInParameter(commandWrapper, "@LastDate", DbType.DateTime, (entity.LastDate.HasValue ? (object)entity.LastDate : System.DBNull.Value));
            database.AddInParameter(commandWrapper, "@SeUserId", DbType.Decimal, (entity.SeUserId.HasValue ? (object)entity.SeUserId : System.DBNull.Value));
			
            int results = 0;

            //Provider Data Requesting Command Event
            OnDataRequesting(new CommandEventArgs(commandWrapper, "Insert", entity));

            if (transactionManager != null)
            {
                results = Utility.ExecuteNonQuery(transactionManager, commandWrapper);
            }
            else
            {
                results = Utility.ExecuteNonQuery(database, commandWrapper);
            }

            entity.AdmApplicantId = decimal.Parse(commandWrapper.Parameters["@AdmApplicantId"].Value.ToString());
            entity.OriginalAdmApplicantId = entity.AdmApplicantId;

            entity.AcceptChanges();

            //Provider Data Requested Command Event
            OnDataRequested(new CommandEventArgs(commandWrapper, "Insert", entity));

            return Convert.ToBoolean(results);
        }	

        #endregion
    }
}