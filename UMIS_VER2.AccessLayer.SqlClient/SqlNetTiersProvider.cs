#region Using directives

using System;
using System.Collections;
using System.Collections.Specialized;


using System.Web.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2.AccessLayer.SqlClient
{
	/// <summary>
	/// This class is the Sql implementation of the NetTiersProvider.
	/// </summary>
	public sealed class SqlNetTiersProvider : UMIS_VER2.AccessLayer.Bases.NetTiersProvider
	{
		private static object syncRoot = new Object();
		private string _applicationName;
        private string _connectionString;
        private bool _useStoredProcedure;
        string _providerInvariantName;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SqlNetTiersProvider"/> class.
		///</summary>
		public SqlNetTiersProvider()
		{	
		}		
		
		/// <summary>
        /// Initializes the provider.
        /// </summary>
        /// <param name="name">The friendly name of the provider.</param>
        /// <param name="config">A collection of the name/value pairs representing the provider-specific attributes specified in the configuration for this provider.</param>
        /// <exception cref="T:System.ArgumentNullException">The name of the provider is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">An attempt is made to call <see cref="M:System.Configuration.Provider.ProviderBase.Initialize(System.String,System.Collections.Specialized.NameValueCollection)"></see> on a provider after the provider has already been initialized.</exception>
        /// <exception cref="T:System.ArgumentException">The name of the provider has a length of zero.</exception>
		public override void Initialize(string name, NameValueCollection config)
        {
            // Verify that config isn't null
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            // Assign the provider a default name if it doesn't have one
            if (String.IsNullOrEmpty(name))
            {
                name = "SqlNetTiersProvider";
            }

            // Add a default "description" attribute to config if the
            // attribute doesn't exist or is empty
            if (string.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "NetTiers Sql provider");
            }

            // Call the base class's Initialize method
            base.Initialize(name, config);

            // Initialize _applicationName
            _applicationName = config["applicationName"];

            if (string.IsNullOrEmpty(_applicationName))
            {
                _applicationName = "/";
            }
            config.Remove("applicationName");


            #region "Initialize UseStoredProcedure"
            string storedProcedure  = config["useStoredProcedure"];
           	if (string.IsNullOrEmpty(storedProcedure))
            {
                throw new ProviderException("Empty or missing useStoredProcedure");
            }
            this._useStoredProcedure = Convert.ToBoolean(config["useStoredProcedure"]);
            config.Remove("useStoredProcedure");
            #endregion

			#region ConnectionString

			// Initialize _connectionString
			_connectionString = config["connectionString"];
			config.Remove("connectionString");

			string connect = config["connectionStringName"];
			config.Remove("connectionStringName");

			if ( String.IsNullOrEmpty(_connectionString) )
			{
				if ( String.IsNullOrEmpty(connect) )
				{
					throw new ProviderException("Empty or missing connectionStringName");
				}

				if ( DataRepository.ConnectionStrings[connect] == null )
				{
					throw new ProviderException("Missing connection string");
				}

				_connectionString = DataRepository.ConnectionStrings[connect].ConnectionString;
			}

            if ( String.IsNullOrEmpty(_connectionString) )
            {
                throw new ProviderException("Empty connection string");
			}

			#endregion
            
             #region "_providerInvariantName"

            // initialize _providerInvariantName
            this._providerInvariantName = config["providerInvariantName"];

            if (String.IsNullOrEmpty(_providerInvariantName))
            {
                throw new ProviderException("Empty or missing providerInvariantName");
            }
            config.Remove("providerInvariantName");

            #endregion

        }
		
		/// <summary>
		/// Creates a new <c cref="TransactionManager"/> instance from the current datasource.
		/// </summary>
		/// <returns></returns>
		public override TransactionManager CreateTransaction()
		{
			return new TransactionManager(this._connectionString);
		}
		
		/// <summary>
		/// Gets a value indicating whether to use stored procedure or not.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this repository use stored procedures; otherwise, <c>false</c>.
		/// </value>
		public bool UseStoredProcedure
		{
			get {return this._useStoredProcedure;}
			set {this._useStoredProcedure = value;}
		}
		
		 /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
		public string ConnectionString
		{
			get {return this._connectionString;}
			set {this._connectionString = value;}
		}
		
		/// <summary>
	    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
	    /// </summary>
	    /// <value>The name of the provider invariant.</value>
	    public string ProviderInvariantName
	    {
	        get { return this._providerInvariantName; }
	        set { this._providerInvariantName = value; }
	    }		
		
		///<summary>
		/// Indicates if the current <c cref="NetTiersProvider"/> implementation supports Transacton.
		///</summary>
		public override bool IsTransactionSupported
		{
			get
			{
				return true;
			}
		}

		
		#region "MilCodeCourseProvider"
			
		private SqlMilCodeCourseProvider innerSqlMilCodeCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MilCodeCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MilCodeCourseProviderBase MilCodeCourseProvider
		{
			get
			{
				if (innerSqlMilCodeCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMilCodeCourseProvider == null)
						{
							this.innerSqlMilCodeCourseProvider = new SqlMilCodeCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMilCodeCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMilCodeCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMilCodeCourseProvider SqlMilCodeCourseProvider
		{
			get {return MilCodeCourseProvider as SqlMilCodeCourseProvider;}
		}
		
		#endregion
		
		
		#region "AccomApartmentProvider"
			
		private SqlAccomApartmentProvider innerSqlAccomApartmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomApartment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomApartmentProviderBase AccomApartmentProvider
		{
			get
			{
				if (innerSqlAccomApartmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomApartmentProvider == null)
						{
							this.innerSqlAccomApartmentProvider = new SqlAccomApartmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomApartmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomApartmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomApartmentProvider SqlAccomApartmentProvider
		{
			get {return AccomApartmentProvider as SqlAccomApartmentProvider;}
		}
		
		#endregion
		
		
		#region "MltCdeBhvrAttndcRltdProvider"
			
		private SqlMltCdeBhvrAttndcRltdProvider innerSqlMltCdeBhvrAttndcRltdProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltCdeBhvrAttndcRltd"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltCdeBhvrAttndcRltdProviderBase MltCdeBhvrAttndcRltdProvider
		{
			get
			{
				if (innerSqlMltCdeBhvrAttndcRltdProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltCdeBhvrAttndcRltdProvider == null)
						{
							this.innerSqlMltCdeBhvrAttndcRltdProvider = new SqlMltCdeBhvrAttndcRltdProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltCdeBhvrAttndcRltdProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltCdeBhvrAttndcRltdProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltCdeBhvrAttndcRltdProvider SqlMltCdeBhvrAttndcRltdProvider
		{
			get {return MltCdeBhvrAttndcRltdProvider as SqlMltCdeBhvrAttndcRltdProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudVaccProvider"
			
		private SqlMdiStudVaccProvider innerSqlMdiStudVaccProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudVacc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudVaccProviderBase MdiStudVaccProvider
		{
			get
			{
				if (innerSqlMdiStudVaccProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudVaccProvider == null)
						{
							this.innerSqlMdiStudVaccProvider = new SqlMdiStudVaccProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudVaccProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudVaccProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudVaccProvider SqlMdiStudVaccProvider
		{
			get {return MdiStudVaccProvider as SqlMdiStudVaccProvider;}
		}
		
		#endregion
		
		
		#region "MltCdeOrgTypeProvider"
			
		private SqlMltCdeOrgTypeProvider innerSqlMltCdeOrgTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltCdeOrgType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltCdeOrgTypeProviderBase MltCdeOrgTypeProvider
		{
			get
			{
				if (innerSqlMltCdeOrgTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltCdeOrgTypeProvider == null)
						{
							this.innerSqlMltCdeOrgTypeProvider = new SqlMltCdeOrgTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltCdeOrgTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltCdeOrgTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltCdeOrgTypeProvider SqlMltCdeOrgTypeProvider
		{
			get {return MltCdeOrgTypeProvider as SqlMltCdeOrgTypeProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudRecordProvider"
			
		private SqlMdiStudRecordProvider innerSqlMdiStudRecordProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudRecord"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudRecordProviderBase MdiStudRecordProvider
		{
			get
			{
				if (innerSqlMdiStudRecordProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudRecordProvider == null)
						{
							this.innerSqlMdiStudRecordProvider = new SqlMdiStudRecordProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudRecordProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudRecordProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudRecordProvider SqlMdiStudRecordProvider
		{
			get {return MdiStudRecordProvider as SqlMdiStudRecordProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudSignProvider"
			
		private SqlMdiStudSignProvider innerSqlMdiStudSignProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudSign"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudSignProviderBase MdiStudSignProvider
		{
			get
			{
				if (innerSqlMdiStudSignProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudSignProvider == null)
						{
							this.innerSqlMdiStudSignProvider = new SqlMdiStudSignProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudSignProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudSignProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudSignProvider SqlMdiStudSignProvider
		{
			get {return MdiStudSignProvider as SqlMdiStudSignProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudHosptlProvider"
			
		private SqlMdiStudHosptlProvider innerSqlMdiStudHosptlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudHosptl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudHosptlProviderBase MdiStudHosptlProvider
		{
			get
			{
				if (innerSqlMdiStudHosptlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudHosptlProvider == null)
						{
							this.innerSqlMdiStudHosptlProvider = new SqlMdiStudHosptlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudHosptlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudHosptlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudHosptlProvider SqlMdiStudHosptlProvider
		{
			get {return MdiStudHosptlProvider as SqlMdiStudHosptlProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudInvstgProvider"
			
		private SqlMdiStudInvstgProvider innerSqlMdiStudInvstgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudInvstg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudInvstgProviderBase MdiStudInvstgProvider
		{
			get
			{
				if (innerSqlMdiStudInvstgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudInvstgProvider == null)
						{
							this.innerSqlMdiStudInvstgProvider = new SqlMdiStudInvstgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudInvstgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudInvstgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudInvstgProvider SqlMdiStudInvstgProvider
		{
			get {return MdiStudInvstgProvider as SqlMdiStudInvstgProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudLifeStyleProvider"
			
		private SqlMdiStudLifeStyleProvider innerSqlMdiStudLifeStyleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudLifeStyle"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudLifeStyleProviderBase MdiStudLifeStyleProvider
		{
			get
			{
				if (innerSqlMdiStudLifeStyleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudLifeStyleProvider == null)
						{
							this.innerSqlMdiStudLifeStyleProvider = new SqlMdiStudLifeStyleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudLifeStyleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudLifeStyleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudLifeStyleProvider SqlMdiStudLifeStyleProvider
		{
			get {return MdiStudLifeStyleProvider as SqlMdiStudLifeStyleProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudProblemProvider"
			
		private SqlMdiStudProblemProvider innerSqlMdiStudProblemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudProblem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudProblemProviderBase MdiStudProblemProvider
		{
			get
			{
				if (innerSqlMdiStudProblemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudProblemProvider == null)
						{
							this.innerSqlMdiStudProblemProvider = new SqlMdiStudProblemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudProblemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudProblemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudProblemProvider SqlMdiStudProblemProvider
		{
			get {return MdiStudProblemProvider as SqlMdiStudProblemProvider;}
		}
		
		#endregion
		
		
		#region "MltCdeOutRsnProvider"
			
		private SqlMltCdeOutRsnProvider innerSqlMltCdeOutRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltCdeOutRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltCdeOutRsnProviderBase MltCdeOutRsnProvider
		{
			get
			{
				if (innerSqlMltCdeOutRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltCdeOutRsnProvider == null)
						{
							this.innerSqlMltCdeOutRsnProvider = new SqlMltCdeOutRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltCdeOutRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltCdeOutRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltCdeOutRsnProvider SqlMltCdeOutRsnProvider
		{
			get {return MltCdeOutRsnProvider as SqlMltCdeOutRsnProvider;}
		}
		
		#endregion
		
		
		#region "MltCdeStudDegreeProvider"
			
		private SqlMltCdeStudDegreeProvider innerSqlMltCdeStudDegreeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltCdeStudDegree"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltCdeStudDegreeProviderBase MltCdeStudDegreeProvider
		{
			get
			{
				if (innerSqlMltCdeStudDegreeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltCdeStudDegreeProvider == null)
						{
							this.innerSqlMltCdeStudDegreeProvider = new SqlMltCdeStudDegreeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltCdeStudDegreeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltCdeStudDegreeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltCdeStudDegreeProvider SqlMltCdeStudDegreeProvider
		{
			get {return MltCdeStudDegreeProvider as SqlMltCdeStudDegreeProvider;}
		}
		
		#endregion
		
		
		#region "MltLvlBhvrAttndcProvider"
			
		private SqlMltLvlBhvrAttndcProvider innerSqlMltLvlBhvrAttndcProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltLvlBhvrAttndc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltLvlBhvrAttndcProviderBase MltLvlBhvrAttndcProvider
		{
			get
			{
				if (innerSqlMltLvlBhvrAttndcProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltLvlBhvrAttndcProvider == null)
						{
							this.innerSqlMltLvlBhvrAttndcProvider = new SqlMltLvlBhvrAttndcProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltLvlBhvrAttndcProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltLvlBhvrAttndcProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltLvlBhvrAttndcProvider SqlMltLvlBhvrAttndcProvider
		{
			get {return MltLvlBhvrAttndcProvider as SqlMltLvlBhvrAttndcProvider;}
		}
		
		#endregion
		
		
		#region "PgCdeConfTypeProvider"
			
		private SqlPgCdeConfTypeProvider innerSqlPgCdeConfTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCdeConfType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCdeConfTypeProviderBase PgCdeConfTypeProvider
		{
			get
			{
				if (innerSqlPgCdeConfTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCdeConfTypeProvider == null)
						{
							this.innerSqlPgCdeConfTypeProvider = new SqlPgCdeConfTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCdeConfTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCdeConfTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCdeConfTypeProvider SqlPgCdeConfTypeProvider
		{
			get {return PgCdeConfTypeProvider as SqlPgCdeConfTypeProvider;}
		}
		
		#endregion
		
		
		#region "PgCdeRptRecommendProvider"
			
		private SqlPgCdeRptRecommendProvider innerSqlPgCdeRptRecommendProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCdeRptRecommend"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCdeRptRecommendProviderBase PgCdeRptRecommendProvider
		{
			get
			{
				if (innerSqlPgCdeRptRecommendProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCdeRptRecommendProvider == null)
						{
							this.innerSqlPgCdeRptRecommendProvider = new SqlPgCdeRptRecommendProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCdeRptRecommendProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCdeRptRecommendProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCdeRptRecommendProvider SqlPgCdeRptRecommendProvider
		{
			get {return PgCdeRptRecommendProvider as SqlPgCdeRptRecommendProvider;}
		}
		
		#endregion
		
		
		#region "PgCdeStfRoleProvider"
			
		private SqlPgCdeStfRoleProvider innerSqlPgCdeStfRoleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCdeStfRole"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCdeStfRoleProviderBase PgCdeStfRoleProvider
		{
			get
			{
				if (innerSqlPgCdeStfRoleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCdeStfRoleProvider == null)
						{
							this.innerSqlPgCdeStfRoleProvider = new SqlPgCdeStfRoleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCdeStfRoleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCdeStfRoleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCdeStfRoleProvider SqlPgCdeStfRoleProvider
		{
			get {return PgCdeStfRoleProvider as SqlPgCdeStfRoleProvider;}
		}
		
		#endregion
		
		
		#region "MltOrgTreeProvider"
			
		private SqlMltOrgTreeProvider innerSqlMltOrgTreeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltOrgTree"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltOrgTreeProviderBase MltOrgTreeProvider
		{
			get
			{
				if (innerSqlMltOrgTreeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltOrgTreeProvider == null)
						{
							this.innerSqlMltOrgTreeProvider = new SqlMltOrgTreeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltOrgTreeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltOrgTreeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltOrgTreeProvider SqlMltOrgTreeProvider
		{
			get {return MltOrgTreeProvider as SqlMltOrgTreeProvider;}
		}
		
		#endregion
		
		
		#region "PgCdeCommRecommendProvider"
			
		private SqlPgCdeCommRecommendProvider innerSqlPgCdeCommRecommendProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCdeCommRecommend"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCdeCommRecommendProviderBase PgCdeCommRecommendProvider
		{
			get
			{
				if (innerSqlPgCdeCommRecommendProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCdeCommRecommendProvider == null)
						{
							this.innerSqlPgCdeCommRecommendProvider = new SqlPgCdeCommRecommendProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCdeCommRecommendProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCdeCommRecommendProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCdeCommRecommendProvider SqlPgCdeCommRecommendProvider
		{
			get {return PgCdeCommRecommendProvider as SqlPgCdeCommRecommendProvider;}
		}
		
		#endregion
		
		
		#region "MltStudInfoProvider"
			
		private SqlMltStudInfoProvider innerSqlMltStudInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltStudInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltStudInfoProviderBase MltStudInfoProvider
		{
			get
			{
				if (innerSqlMltStudInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltStudInfoProvider == null)
						{
							this.innerSqlMltStudInfoProvider = new SqlMltStudInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltStudInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltStudInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltStudInfoProvider SqlMltStudInfoProvider
		{
			get {return MltStudInfoProvider as SqlMltStudInfoProvider;}
		}
		
		#endregion
		
		
		#region "MltRptDayStudStsProvider"
			
		private SqlMltRptDayStudStsProvider innerSqlMltRptDayStudStsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltRptDayStudSts"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltRptDayStudStsProviderBase MltRptDayStudStsProvider
		{
			get
			{
				if (innerSqlMltRptDayStudStsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltRptDayStudStsProvider == null)
						{
							this.innerSqlMltRptDayStudStsProvider = new SqlMltRptDayStudStsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltRptDayStudStsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltRptDayStudStsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltRptDayStudStsProvider SqlMltRptDayStudStsProvider
		{
			get {return MltRptDayStudStsProvider as SqlMltRptDayStudStsProvider;}
		}
		
		#endregion
		
		
		#region "MltRptDayMissionProvider"
			
		private SqlMltRptDayMissionProvider innerSqlMltRptDayMissionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltRptDayMission"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltRptDayMissionProviderBase MltRptDayMissionProvider
		{
			get
			{
				if (innerSqlMltRptDayMissionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltRptDayMissionProvider == null)
						{
							this.innerSqlMltRptDayMissionProvider = new SqlMltRptDayMissionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltRptDayMissionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltRptDayMissionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltRptDayMissionProvider SqlMltRptDayMissionProvider
		{
			get {return MltRptDayMissionProvider as SqlMltRptDayMissionProvider;}
		}
		
		#endregion
		
		
		#region "MltRptDayOutStudProvider"
			
		private SqlMltRptDayOutStudProvider innerSqlMltRptDayOutStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltRptDayOutStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltRptDayOutStudProviderBase MltRptDayOutStudProvider
		{
			get
			{
				if (innerSqlMltRptDayOutStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltRptDayOutStudProvider == null)
						{
							this.innerSqlMltRptDayOutStudProvider = new SqlMltRptDayOutStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltRptDayOutStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltRptDayOutStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltRptDayOutStudProvider SqlMltRptDayOutStudProvider
		{
			get {return MltRptDayOutStudProvider as SqlMltRptDayOutStudProvider;}
		}
		
		#endregion
		
		
		#region "MltRptDayOutProvider"
			
		private SqlMltRptDayOutProvider innerSqlMltRptDayOutProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltRptDayOut"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltRptDayOutProviderBase MltRptDayOutProvider
		{
			get
			{
				if (innerSqlMltRptDayOutProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltRptDayOutProvider == null)
						{
							this.innerSqlMltRptDayOutProvider = new SqlMltRptDayOutProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltRptDayOutProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltRptDayOutProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltRptDayOutProvider SqlMltRptDayOutProvider
		{
			get {return MltRptDayOutProvider as SqlMltRptDayOutProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudFamHstryProvider"
			
		private SqlMdiStudFamHstryProvider innerSqlMdiStudFamHstryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudFamHstry"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudFamHstryProviderBase MdiStudFamHstryProvider
		{
			get
			{
				if (innerSqlMdiStudFamHstryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudFamHstryProvider == null)
						{
							this.innerSqlMdiStudFamHstryProvider = new SqlMdiStudFamHstryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudFamHstryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudFamHstryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudFamHstryProvider SqlMdiStudFamHstryProvider
		{
			get {return MdiStudFamHstryProvider as SqlMdiStudFamHstryProvider;}
		}
		
		#endregion
		
		
		#region "MdiStudClnqProvider"
			
		private SqlMdiStudClnqProvider innerSqlMdiStudClnqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiStudClnq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiStudClnqProviderBase MdiStudClnqProvider
		{
			get
			{
				if (innerSqlMdiStudClnqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiStudClnqProvider == null)
						{
							this.innerSqlMdiStudClnqProvider = new SqlMdiStudClnqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiStudClnqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiStudClnqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiStudClnqProvider SqlMdiStudClnqProvider
		{
			get {return MdiStudClnqProvider as SqlMdiStudClnqProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeVaccProvider"
			
		private SqlMdiCdeVaccProvider innerSqlMdiCdeVaccProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeVacc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeVaccProviderBase MdiCdeVaccProvider
		{
			get
			{
				if (innerSqlMdiCdeVaccProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeVaccProvider == null)
						{
							this.innerSqlMdiCdeVaccProvider = new SqlMdiCdeVaccProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeVaccProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeVaccProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeVaccProvider SqlMdiCdeVaccProvider
		{
			get {return MdiCdeVaccProvider as SqlMdiCdeVaccProvider;}
		}
		
		#endregion
		
		
		#region "IntegFpStaffAbsenceDtlProvider"
			
		private SqlIntegFpStaffAbsenceDtlProvider innerSqlIntegFpStaffAbsenceDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegFpStaffAbsenceDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegFpStaffAbsenceDtlProviderBase IntegFpStaffAbsenceDtlProvider
		{
			get
			{
				if (innerSqlIntegFpStaffAbsenceDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegFpStaffAbsenceDtlProvider == null)
						{
							this.innerSqlIntegFpStaffAbsenceDtlProvider = new SqlIntegFpStaffAbsenceDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegFpStaffAbsenceDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegFpStaffAbsenceDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegFpStaffAbsenceDtlProvider SqlIntegFpStaffAbsenceDtlProvider
		{
			get {return IntegFpStaffAbsenceDtlProvider as SqlIntegFpStaffAbsenceDtlProvider;}
		}
		
		#endregion
		
		
		#region "IntegLogProvider"
			
		private SqlIntegLogProvider innerSqlIntegLogProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegLog"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegLogProviderBase IntegLogProvider
		{
			get
			{
				if (innerSqlIntegLogProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegLogProvider == null)
						{
							this.innerSqlIntegLogProvider = new SqlIntegLogProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegLogProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegLogProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegLogProvider SqlIntegLogProvider
		{
			get {return IntegLogProvider as SqlIntegLogProvider;}
		}
		
		#endregion
		
		
		#region "IntegMoodleEnrolProvider"
			
		private SqlIntegMoodleEnrolProvider innerSqlIntegMoodleEnrolProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegMoodleEnrol"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegMoodleEnrolProviderBase IntegMoodleEnrolProvider
		{
			get
			{
				if (innerSqlIntegMoodleEnrolProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegMoodleEnrolProvider == null)
						{
							this.innerSqlIntegMoodleEnrolProvider = new SqlIntegMoodleEnrolProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegMoodleEnrolProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegMoodleEnrolProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegMoodleEnrolProvider SqlIntegMoodleEnrolProvider
		{
			get {return IntegMoodleEnrolProvider as SqlIntegMoodleEnrolProvider;}
		}
		
		#endregion
		
		
		#region "IntegMoodleUnenrolProvider"
			
		private SqlIntegMoodleUnenrolProvider innerSqlIntegMoodleUnenrolProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegMoodleUnenrol"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegMoodleUnenrolProviderBase IntegMoodleUnenrolProvider
		{
			get
			{
				if (innerSqlIntegMoodleUnenrolProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegMoodleUnenrolProvider == null)
						{
							this.innerSqlIntegMoodleUnenrolProvider = new SqlIntegMoodleUnenrolProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegMoodleUnenrolProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegMoodleUnenrolProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegMoodleUnenrolProvider SqlIntegMoodleUnenrolProvider
		{
			get {return IntegMoodleUnenrolProvider as SqlIntegMoodleUnenrolProvider;}
		}
		
		#endregion
		
		
		#region "IntegFpStaffAbsenceProvider"
			
		private SqlIntegFpStaffAbsenceProvider innerSqlIntegFpStaffAbsenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegFpStaffAbsence"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegFpStaffAbsenceProviderBase IntegFpStaffAbsenceProvider
		{
			get
			{
				if (innerSqlIntegFpStaffAbsenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegFpStaffAbsenceProvider == null)
						{
							this.innerSqlIntegFpStaffAbsenceProvider = new SqlIntegFpStaffAbsenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegFpStaffAbsenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegFpStaffAbsenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegFpStaffAbsenceProvider SqlIntegFpStaffAbsenceProvider
		{
			get {return IntegFpStaffAbsenceProvider as SqlIntegFpStaffAbsenceProvider;}
		}
		
		#endregion
		
		
		#region "MltStudBhvrAttndcProvider"
			
		private SqlMltStudBhvrAttndcProvider innerSqlMltStudBhvrAttndcProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MltStudBhvrAttndc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MltStudBhvrAttndcProviderBase MltStudBhvrAttndcProvider
		{
			get
			{
				if (innerSqlMltStudBhvrAttndcProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMltStudBhvrAttndcProvider == null)
						{
							this.innerSqlMltStudBhvrAttndcProvider = new SqlMltStudBhvrAttndcProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMltStudBhvrAttndcProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMltStudBhvrAttndcProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMltStudBhvrAttndcProvider SqlMltStudBhvrAttndcProvider
		{
			get {return MltStudBhvrAttndcProvider as SqlMltStudBhvrAttndcProvider;}
		}
		
		#endregion
		
		
		#region "IntegFinanceProvider"
			
		private SqlIntegFinanceProvider innerSqlIntegFinanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegFinance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegFinanceProviderBase IntegFinanceProvider
		{
			get
			{
				if (innerSqlIntegFinanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegFinanceProvider == null)
						{
							this.innerSqlIntegFinanceProvider = new SqlIntegFinanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegFinanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegFinanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegFinanceProvider SqlIntegFinanceProvider
		{
			get {return IntegFinanceProvider as SqlIntegFinanceProvider;}
		}
		
		#endregion
		
		
		#region "GsMilitaryRegionProvider"
			
		private SqlGsMilitaryRegionProvider innerSqlGsMilitaryRegionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsMilitaryRegion"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsMilitaryRegionProviderBase GsMilitaryRegionProvider
		{
			get
			{
				if (innerSqlGsMilitaryRegionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsMilitaryRegionProvider == null)
						{
							this.innerSqlGsMilitaryRegionProvider = new SqlGsMilitaryRegionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsMilitaryRegionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsMilitaryRegionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsMilitaryRegionProvider SqlGsMilitaryRegionProvider
		{
			get {return GsMilitaryRegionProvider as SqlGsMilitaryRegionProvider;}
		}
		
		#endregion
		
		
		#region "GsSysPivotProvider"
			
		private SqlGsSysPivotProvider innerSqlGsSysPivotProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsSysPivot"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsSysPivotProviderBase GsSysPivotProvider
		{
			get
			{
				if (innerSqlGsSysPivotProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsSysPivotProvider == null)
						{
							this.innerSqlGsSysPivotProvider = new SqlGsSysPivotProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsSysPivotProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsSysPivotProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsSysPivotProvider SqlGsSysPivotProvider
		{
			get {return GsSysPivotProvider as SqlGsSysPivotProvider;}
		}
		
		#endregion
		
		
		#region "HrDepartmentProvider"
			
		private SqlHrDepartmentProvider innerSqlHrDepartmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HrDepartment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HrDepartmentProviderBase HrDepartmentProvider
		{
			get
			{
				if (innerSqlHrDepartmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHrDepartmentProvider == null)
						{
							this.innerSqlHrDepartmentProvider = new SqlHrDepartmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHrDepartmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlHrDepartmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHrDepartmentProvider SqlHrDepartmentProvider
		{
			get {return HrDepartmentProvider as SqlHrDepartmentProvider;}
		}
		
		#endregion
		
		
		#region "IntegCdeErrorTypeProvider"
			
		private SqlIntegCdeErrorTypeProvider innerSqlIntegCdeErrorTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegCdeErrorType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegCdeErrorTypeProviderBase IntegCdeErrorTypeProvider
		{
			get
			{
				if (innerSqlIntegCdeErrorTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegCdeErrorTypeProvider == null)
						{
							this.innerSqlIntegCdeErrorTypeProvider = new SqlIntegCdeErrorTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegCdeErrorTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegCdeErrorTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegCdeErrorTypeProvider SqlIntegCdeErrorTypeProvider
		{
			get {return IntegCdeErrorTypeProvider as SqlIntegCdeErrorTypeProvider;}
		}
		
		#endregion
		
		
		#region "IntegMoodleUpdateStaffProvider"
			
		private SqlIntegMoodleUpdateStaffProvider innerSqlIntegMoodleUpdateStaffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegMoodleUpdateStaff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegMoodleUpdateStaffProviderBase IntegMoodleUpdateStaffProvider
		{
			get
			{
				if (innerSqlIntegMoodleUpdateStaffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegMoodleUpdateStaffProvider == null)
						{
							this.innerSqlIntegMoodleUpdateStaffProvider = new SqlIntegMoodleUpdateStaffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegMoodleUpdateStaffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegMoodleUpdateStaffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegMoodleUpdateStaffProvider SqlIntegMoodleUpdateStaffProvider
		{
			get {return IntegMoodleUpdateStaffProvider as SqlIntegMoodleUpdateStaffProvider;}
		}
		
		#endregion
		
		
		#region "IntegMoodleUpdateStudProvider"
			
		private SqlIntegMoodleUpdateStudProvider innerSqlIntegMoodleUpdateStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegMoodleUpdateStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegMoodleUpdateStudProviderBase IntegMoodleUpdateStudProvider
		{
			get
			{
				if (innerSqlIntegMoodleUpdateStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegMoodleUpdateStudProvider == null)
						{
							this.innerSqlIntegMoodleUpdateStudProvider = new SqlIntegMoodleUpdateStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegMoodleUpdateStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegMoodleUpdateStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegMoodleUpdateStudProvider SqlIntegMoodleUpdateStudProvider
		{
			get {return IntegMoodleUpdateStudProvider as SqlIntegMoodleUpdateStudProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeSignCatProvider"
			
		private SqlMdiCdeSignCatProvider innerSqlMdiCdeSignCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeSignCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeSignCatProviderBase MdiCdeSignCatProvider
		{
			get
			{
				if (innerSqlMdiCdeSignCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeSignCatProvider == null)
						{
							this.innerSqlMdiCdeSignCatProvider = new SqlMdiCdeSignCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeSignCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeSignCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeSignCatProvider SqlMdiCdeSignCatProvider
		{
			get {return MdiCdeSignCatProvider as SqlMdiCdeSignCatProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeLifeStyleProvider"
			
		private SqlMdiCdeLifeStyleProvider innerSqlMdiCdeLifeStyleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeLifeStyle"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeLifeStyleProviderBase MdiCdeLifeStyleProvider
		{
			get
			{
				if (innerSqlMdiCdeLifeStyleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeLifeStyleProvider == null)
						{
							this.innerSqlMdiCdeLifeStyleProvider = new SqlMdiCdeLifeStyleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeLifeStyleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeLifeStyleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeLifeStyleProvider SqlMdiCdeLifeStyleProvider
		{
			get {return MdiCdeLifeStyleProvider as SqlMdiCdeLifeStyleProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeProblemProvider"
			
		private SqlMdiCdeProblemProvider innerSqlMdiCdeProblemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeProblem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeProblemProviderBase MdiCdeProblemProvider
		{
			get
			{
				if (innerSqlMdiCdeProblemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeProblemProvider == null)
						{
							this.innerSqlMdiCdeProblemProvider = new SqlMdiCdeProblemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeProblemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeProblemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeProblemProvider SqlMdiCdeProblemProvider
		{
			get {return MdiCdeProblemProvider as SqlMdiCdeProblemProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeInvstgProvider"
			
		private SqlMdiCdeInvstgProvider innerSqlMdiCdeInvstgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeInvstg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeInvstgProviderBase MdiCdeInvstgProvider
		{
			get
			{
				if (innerSqlMdiCdeInvstgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeInvstgProvider == null)
						{
							this.innerSqlMdiCdeInvstgProvider = new SqlMdiCdeInvstgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeInvstgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeInvstgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeInvstgProvider SqlMdiCdeInvstgProvider
		{
			get {return MdiCdeInvstgProvider as SqlMdiCdeInvstgProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeSignProvider"
			
		private SqlMdiCdeSignProvider innerSqlMdiCdeSignProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeSign"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeSignProviderBase MdiCdeSignProvider
		{
			get
			{
				if (innerSqlMdiCdeSignProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeSignProvider == null)
						{
							this.innerSqlMdiCdeSignProvider = new SqlMdiCdeSignProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeSignProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeSignProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeSignProvider SqlMdiCdeSignProvider
		{
			get {return MdiCdeSignProvider as SqlMdiCdeSignProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeHosptlProvider"
			
		private SqlMdiCdeHosptlProvider innerSqlMdiCdeHosptlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeHosptl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeHosptlProviderBase MdiCdeHosptlProvider
		{
			get
			{
				if (innerSqlMdiCdeHosptlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeHosptlProvider == null)
						{
							this.innerSqlMdiCdeHosptlProvider = new SqlMdiCdeHosptlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeHosptlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeHosptlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeHosptlProvider SqlMdiCdeHosptlProvider
		{
			get {return MdiCdeHosptlProvider as SqlMdiCdeHosptlProvider;}
		}
		
		#endregion
		
		
		#region "MdiCdeDiseaseProvider"
			
		private SqlMdiCdeDiseaseProvider innerSqlMdiCdeDiseaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MdiCdeDisease"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MdiCdeDiseaseProviderBase MdiCdeDiseaseProvider
		{
			get
			{
				if (innerSqlMdiCdeDiseaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMdiCdeDiseaseProvider == null)
						{
							this.innerSqlMdiCdeDiseaseProvider = new SqlMdiCdeDiseaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMdiCdeDiseaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlMdiCdeDiseaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMdiCdeDiseaseProvider SqlMdiCdeDiseaseProvider
		{
			get {return MdiCdeDiseaseProvider as SqlMdiCdeDiseaseProvider;}
		}
		
		#endregion
		
		
		#region "IntegUserAdLogHdrProvider"
			
		private SqlIntegUserAdLogHdrProvider innerSqlIntegUserAdLogHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegUserAdLogHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegUserAdLogHdrProviderBase IntegUserAdLogHdrProvider
		{
			get
			{
				if (innerSqlIntegUserAdLogHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegUserAdLogHdrProvider == null)
						{
							this.innerSqlIntegUserAdLogHdrProvider = new SqlIntegUserAdLogHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegUserAdLogHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegUserAdLogHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegUserAdLogHdrProvider SqlIntegUserAdLogHdrProvider
		{
			get {return IntegUserAdLogHdrProvider as SqlIntegUserAdLogHdrProvider;}
		}
		
		#endregion
		
		
		#region "IntegPaymentUpayProvider"
			
		private SqlIntegPaymentUpayProvider innerSqlIntegPaymentUpayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegPaymentUpay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegPaymentUpayProviderBase IntegPaymentUpayProvider
		{
			get
			{
				if (innerSqlIntegPaymentUpayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegPaymentUpayProvider == null)
						{
							this.innerSqlIntegPaymentUpayProvider = new SqlIntegPaymentUpayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegPaymentUpayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegPaymentUpayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegPaymentUpayProvider SqlIntegPaymentUpayProvider
		{
			get {return IntegPaymentUpayProvider as SqlIntegPaymentUpayProvider;}
		}
		
		#endregion
		
		
		#region "IntegSemOpenCloseProvider"
			
		private SqlIntegSemOpenCloseProvider innerSqlIntegSemOpenCloseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegSemOpenClose"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegSemOpenCloseProviderBase IntegSemOpenCloseProvider
		{
			get
			{
				if (innerSqlIntegSemOpenCloseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegSemOpenCloseProvider == null)
						{
							this.innerSqlIntegSemOpenCloseProvider = new SqlIntegSemOpenCloseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegSemOpenCloseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegSemOpenCloseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegSemOpenCloseProvider SqlIntegSemOpenCloseProvider
		{
			get {return IntegSemOpenCloseProvider as SqlIntegSemOpenCloseProvider;}
		}
		
		#endregion
		
		
		#region "PgCdeThesisStatusProvider"
			
		private SqlPgCdeThesisStatusProvider innerSqlPgCdeThesisStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCdeThesisStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCdeThesisStatusProviderBase PgCdeThesisStatusProvider
		{
			get
			{
				if (innerSqlPgCdeThesisStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCdeThesisStatusProvider == null)
						{
							this.innerSqlPgCdeThesisStatusProvider = new SqlPgCdeThesisStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCdeThesisStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCdeThesisStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCdeThesisStatusProvider SqlPgCdeThesisStatusProvider
		{
			get {return PgCdeThesisStatusProvider as SqlPgCdeThesisStatusProvider;}
		}
		
		#endregion
		
		
		#region "IntegUserAdLogDtlProvider"
			
		private SqlIntegUserAdLogDtlProvider innerSqlIntegUserAdLogDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="IntegUserAdLogDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override IntegUserAdLogDtlProviderBase IntegUserAdLogDtlProvider
		{
			get
			{
				if (innerSqlIntegUserAdLogDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlIntegUserAdLogDtlProvider == null)
						{
							this.innerSqlIntegUserAdLogDtlProvider = new SqlIntegUserAdLogDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlIntegUserAdLogDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlIntegUserAdLogDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlIntegUserAdLogDtlProvider SqlIntegUserAdLogDtlProvider
		{
			get {return IntegUserAdLogDtlProvider as SqlIntegUserAdLogDtlProvider;}
		}
		
		#endregion
		
		
		#region "RsrchCdeTitleProvider"
			
		private SqlRsrchCdeTitleProvider innerSqlRsrchCdeTitleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="RsrchCdeTitle"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override RsrchCdeTitleProviderBase RsrchCdeTitleProvider
		{
			get
			{
				if (innerSqlRsrchCdeTitleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlRsrchCdeTitleProvider == null)
						{
							this.innerSqlRsrchCdeTitleProvider = new SqlRsrchCdeTitleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlRsrchCdeTitleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlRsrchCdeTitleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlRsrchCdeTitleProvider SqlRsrchCdeTitleProvider
		{
			get {return RsrchCdeTitleProvider as SqlRsrchCdeTitleProvider;}
		}
		
		#endregion
		
		
		#region "PgOfferingProvider"
			
		private SqlPgOfferingProvider innerSqlPgOfferingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgOffering"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgOfferingProviderBase PgOfferingProvider
		{
			get
			{
				if (innerSqlPgOfferingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgOfferingProvider == null)
						{
							this.innerSqlPgOfferingProvider = new SqlPgOfferingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgOfferingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgOfferingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgOfferingProvider SqlPgOfferingProvider
		{
			get {return PgOfferingProvider as SqlPgOfferingProvider;}
		}
		
		#endregion
		
		
		#region "SaCdeAdminJobProvider"
			
		private SqlSaCdeAdminJobProvider innerSqlSaCdeAdminJobProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCdeAdminJob"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCdeAdminJobProviderBase SaCdeAdminJobProvider
		{
			get
			{
				if (innerSqlSaCdeAdminJobProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCdeAdminJobProvider == null)
						{
							this.innerSqlSaCdeAdminJobProvider = new SqlSaCdeAdminJobProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCdeAdminJobProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCdeAdminJobProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCdeAdminJobProvider SqlSaCdeAdminJobProvider
		{
			get {return SaCdeAdminJobProvider as SqlSaCdeAdminJobProvider;}
		}
		
		#endregion
		
		
		#region "PgOfferingTopicProvider"
			
		private SqlPgOfferingTopicProvider innerSqlPgOfferingTopicProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgOfferingTopic"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgOfferingTopicProviderBase PgOfferingTopicProvider
		{
			get
			{
				if (innerSqlPgOfferingTopicProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgOfferingTopicProvider == null)
						{
							this.innerSqlPgOfferingTopicProvider = new SqlPgOfferingTopicProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgOfferingTopicProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgOfferingTopicProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgOfferingTopicProvider SqlPgOfferingTopicProvider
		{
			get {return PgOfferingTopicProvider as SqlPgOfferingTopicProvider;}
		}
		
		#endregion
		
		
		#region "RsrchCdeStatusProvider"
			
		private SqlRsrchCdeStatusProvider innerSqlRsrchCdeStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="RsrchCdeStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override RsrchCdeStatusProviderBase RsrchCdeStatusProvider
		{
			get
			{
				if (innerSqlRsrchCdeStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlRsrchCdeStatusProvider == null)
						{
							this.innerSqlRsrchCdeStatusProvider = new SqlRsrchCdeStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlRsrchCdeStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlRsrchCdeStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlRsrchCdeStatusProvider SqlRsrchCdeStatusProvider
		{
			get {return RsrchCdeStatusProvider as SqlRsrchCdeStatusProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisDetailedSpecProvider"
			
		private SqlPgThesisDetailedSpecProvider innerSqlPgThesisDetailedSpecProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisDetailedSpec"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisDetailedSpecProviderBase PgThesisDetailedSpecProvider
		{
			get
			{
				if (innerSqlPgThesisDetailedSpecProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisDetailedSpecProvider == null)
						{
							this.innerSqlPgThesisDetailedSpecProvider = new SqlPgThesisDetailedSpecProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisDetailedSpecProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisDetailedSpecProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisDetailedSpecProvider SqlPgThesisDetailedSpecProvider
		{
			get {return PgThesisDetailedSpecProvider as SqlPgThesisDetailedSpecProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisGeneralSpecProvider"
			
		private SqlPgThesisGeneralSpecProvider innerSqlPgThesisGeneralSpecProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisGeneralSpec"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisGeneralSpecProviderBase PgThesisGeneralSpecProvider
		{
			get
			{
				if (innerSqlPgThesisGeneralSpecProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisGeneralSpecProvider == null)
						{
							this.innerSqlPgThesisGeneralSpecProvider = new SqlPgThesisGeneralSpecProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisGeneralSpecProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisGeneralSpecProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisGeneralSpecProvider SqlPgThesisGeneralSpecProvider
		{
			get {return PgThesisGeneralSpecProvider as SqlPgThesisGeneralSpecProvider;}
		}
		
		#endregion
		
		
		#region "RsrchStudRegisterProvider"
			
		private SqlRsrchStudRegisterProvider innerSqlRsrchStudRegisterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="RsrchStudRegister"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override RsrchStudRegisterProviderBase RsrchStudRegisterProvider
		{
			get
			{
				if (innerSqlRsrchStudRegisterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlRsrchStudRegisterProvider == null)
						{
							this.innerSqlRsrchStudRegisterProvider = new SqlRsrchStudRegisterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlRsrchStudRegisterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlRsrchStudRegisterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlRsrchStudRegisterProvider SqlRsrchStudRegisterProvider
		{
			get {return RsrchStudRegisterProvider as SqlRsrchStudRegisterProvider;}
		}
		
		#endregion
		
		
		#region "RsrchStudRegisterDtlProvider"
			
		private SqlRsrchStudRegisterDtlProvider innerSqlRsrchStudRegisterDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="RsrchStudRegisterDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override RsrchStudRegisterDtlProviderBase RsrchStudRegisterDtlProvider
		{
			get
			{
				if (innerSqlRsrchStudRegisterDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlRsrchStudRegisterDtlProvider == null)
						{
							this.innerSqlRsrchStudRegisterDtlProvider = new SqlRsrchStudRegisterDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlRsrchStudRegisterDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlRsrchStudRegisterDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlRsrchStudRegisterDtlProvider SqlRsrchStudRegisterDtlProvider
		{
			get {return RsrchStudRegisterDtlProvider as SqlRsrchStudRegisterDtlProvider;}
		}
		
		#endregion
		
		
		#region "RsrchCommStaffRecomProvider"
			
		private SqlRsrchCommStaffRecomProvider innerSqlRsrchCommStaffRecomProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="RsrchCommStaffRecom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override RsrchCommStaffRecomProviderBase RsrchCommStaffRecomProvider
		{
			get
			{
				if (innerSqlRsrchCommStaffRecomProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlRsrchCommStaffRecomProvider == null)
						{
							this.innerSqlRsrchCommStaffRecomProvider = new SqlRsrchCommStaffRecomProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlRsrchCommStaffRecomProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlRsrchCommStaffRecomProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlRsrchCommStaffRecomProvider SqlRsrchCommStaffRecomProvider
		{
			get {return RsrchCommStaffRecomProvider as SqlRsrchCommStaffRecomProvider;}
		}
		
		#endregion
		
		
		#region "SaCandReleaseProvider"
			
		private SqlSaCandReleaseProvider innerSqlSaCandReleaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCandRelease"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCandReleaseProviderBase SaCandReleaseProvider
		{
			get
			{
				if (innerSqlSaCandReleaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCandReleaseProvider == null)
						{
							this.innerSqlSaCandReleaseProvider = new SqlSaCandReleaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCandReleaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCandReleaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCandReleaseProvider SqlSaCandReleaseProvider
		{
			get {return SaCandReleaseProvider as SqlSaCandReleaseProvider;}
		}
		
		#endregion
		
		
		#region "PgCodeChangeTypeProvider"
			
		private SqlPgCodeChangeTypeProvider innerSqlPgCodeChangeTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCodeChangeType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCodeChangeTypeProviderBase PgCodeChangeTypeProvider
		{
			get
			{
				if (innerSqlPgCodeChangeTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCodeChangeTypeProvider == null)
						{
							this.innerSqlPgCodeChangeTypeProvider = new SqlPgCodeChangeTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCodeChangeTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCodeChangeTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCodeChangeTypeProvider SqlPgCodeChangeTypeProvider
		{
			get {return PgCodeChangeTypeProvider as SqlPgCodeChangeTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaCandReleaseDetailProvider"
			
		private SqlSaCandReleaseDetailProvider innerSqlSaCandReleaseDetailProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCandReleaseDetail"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCandReleaseDetailProviderBase SaCandReleaseDetailProvider
		{
			get
			{
				if (innerSqlSaCandReleaseDetailProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCandReleaseDetailProvider == null)
						{
							this.innerSqlSaCandReleaseDetailProvider = new SqlSaCandReleaseDetailProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCandReleaseDetailProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCandReleaseDetailProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCandReleaseDetailProvider SqlSaCandReleaseDetailProvider
		{
			get {return SaCandReleaseDetailProvider as SqlSaCandReleaseDetailProvider;}
		}
		
		#endregion
		
		
		#region "SaCdeAcadLoadProvider"
			
		private SqlSaCdeAcadLoadProvider innerSqlSaCdeAcadLoadProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCdeAcadLoad"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCdeAcadLoadProviderBase SaCdeAcadLoadProvider
		{
			get
			{
				if (innerSqlSaCdeAcadLoadProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCdeAcadLoadProvider == null)
						{
							this.innerSqlSaCdeAcadLoadProvider = new SqlSaCdeAcadLoadProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCdeAcadLoadProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCdeAcadLoadProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCdeAcadLoadProvider SqlSaCdeAcadLoadProvider
		{
			get {return SaCdeAcadLoadProvider as SqlSaCdeAcadLoadProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeDocTypeProvider"
			
		private SqlSaCodeDocTypeProvider innerSqlSaCodeDocTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeDocType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeDocTypeProviderBase SaCodeDocTypeProvider
		{
			get
			{
				if (innerSqlSaCodeDocTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeDocTypeProvider == null)
						{
							this.innerSqlSaCodeDocTypeProvider = new SqlSaCodeDocTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeDocTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeDocTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeDocTypeProvider SqlSaCodeDocTypeProvider
		{
			get {return SaCodeDocTypeProvider as SqlSaCodeDocTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeCourseTypeProvider"
			
		private SqlSaCodeCourseTypeProvider innerSqlSaCodeCourseTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeCourseType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeCourseTypeProviderBase SaCodeCourseTypeProvider
		{
			get
			{
				if (innerSqlSaCodeCourseTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeCourseTypeProvider == null)
						{
							this.innerSqlSaCodeCourseTypeProvider = new SqlSaCodeCourseTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeCourseTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeCourseTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeCourseTypeProvider SqlSaCodeCourseTypeProvider
		{
			get {return SaCodeCourseTypeProvider as SqlSaCodeCourseTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeDocProvider"
			
		private SqlSaCodeDocProvider innerSqlSaCodeDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeDocProviderBase SaCodeDocProvider
		{
			get
			{
				if (innerSqlSaCodeDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeDocProvider == null)
						{
							this.innerSqlSaCodeDocProvider = new SqlSaCodeDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeDocProvider SqlSaCodeDocProvider
		{
			get {return SaCodeDocProvider as SqlSaCodeDocProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeCourseScoreProvider"
			
		private SqlSaCodeCourseScoreProvider innerSqlSaCodeCourseScoreProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeCourseScore"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeCourseScoreProviderBase SaCodeCourseScoreProvider
		{
			get
			{
				if (innerSqlSaCodeCourseScoreProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeCourseScoreProvider == null)
						{
							this.innerSqlSaCodeCourseScoreProvider = new SqlSaCodeCourseScoreProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeCourseScoreProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeCourseScoreProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeCourseScoreProvider SqlSaCodeCourseScoreProvider
		{
			get {return SaCodeCourseScoreProvider as SqlSaCodeCourseScoreProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisStudProvider"
			
		private SqlPgThesisStudProvider innerSqlPgThesisStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisStudProviderBase PgThesisStudProvider
		{
			get
			{
				if (innerSqlPgThesisStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisStudProvider == null)
						{
							this.innerSqlPgThesisStudProvider = new SqlPgThesisStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisStudProvider SqlPgThesisStudProvider
		{
			get {return PgThesisStudProvider as SqlPgThesisStudProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeCourseProvider"
			
		private SqlSaCodeCourseProvider innerSqlSaCodeCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeCourseProviderBase SaCodeCourseProvider
		{
			get
			{
				if (innerSqlSaCodeCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeCourseProvider == null)
						{
							this.innerSqlSaCodeCourseProvider = new SqlSaCodeCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeCourseProvider SqlSaCodeCourseProvider
		{
			get {return SaCodeCourseProvider as SqlSaCodeCourseProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeEmpMethodProvider"
			
		private SqlSaCodeEmpMethodProvider innerSqlSaCodeEmpMethodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeEmpMethod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeEmpMethodProviderBase SaCodeEmpMethodProvider
		{
			get
			{
				if (innerSqlSaCodeEmpMethodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeEmpMethodProvider == null)
						{
							this.innerSqlSaCodeEmpMethodProvider = new SqlSaCodeEmpMethodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeEmpMethodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeEmpMethodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeEmpMethodProvider SqlSaCodeEmpMethodProvider
		{
			get {return SaCodeEmpMethodProvider as SqlSaCodeEmpMethodProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeCommMemberTypeProvider"
			
		private SqlSaCodeCommMemberTypeProvider innerSqlSaCodeCommMemberTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeCommMemberType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeCommMemberTypeProviderBase SaCodeCommMemberTypeProvider
		{
			get
			{
				if (innerSqlSaCodeCommMemberTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeCommMemberTypeProvider == null)
						{
							this.innerSqlSaCodeCommMemberTypeProvider = new SqlSaCodeCommMemberTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeCommMemberTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeCommMemberTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeCommMemberTypeProvider SqlSaCodeCommMemberTypeProvider
		{
			get {return SaCodeCommMemberTypeProvider as SqlSaCodeCommMemberTypeProvider;}
		}
		
		#endregion
		
		
		#region "PgCodeRsrchStrategyProvider"
			
		private SqlPgCodeRsrchStrategyProvider innerSqlPgCodeRsrchStrategyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCodeRsrchStrategy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCodeRsrchStrategyProviderBase PgCodeRsrchStrategyProvider
		{
			get
			{
				if (innerSqlPgCodeRsrchStrategyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCodeRsrchStrategyProvider == null)
						{
							this.innerSqlPgCodeRsrchStrategyProvider = new SqlPgCodeRsrchStrategyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCodeRsrchStrategyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCodeRsrchStrategyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCodeRsrchStrategyProvider SqlPgCodeRsrchStrategyProvider
		{
			get {return PgCodeRsrchStrategyProvider as SqlPgCodeRsrchStrategyProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisCommProvider"
			
		private SqlPgThesisCommProvider innerSqlPgThesisCommProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisComm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisCommProviderBase PgThesisCommProvider
		{
			get
			{
				if (innerSqlPgThesisCommProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisCommProvider == null)
						{
							this.innerSqlPgThesisCommProvider = new SqlPgThesisCommProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisCommProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisCommProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisCommProvider SqlPgThesisCommProvider
		{
			get {return PgThesisCommProvider as SqlPgThesisCommProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisCommApproveProvider"
			
		private SqlPgThesisCommApproveProvider innerSqlPgThesisCommApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisCommApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisCommApproveProviderBase PgThesisCommApproveProvider
		{
			get
			{
				if (innerSqlPgThesisCommApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisCommApproveProvider == null)
						{
							this.innerSqlPgThesisCommApproveProvider = new SqlPgThesisCommApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisCommApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisCommApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisCommApproveProvider SqlPgThesisCommApproveProvider
		{
			get {return PgThesisCommApproveProvider as SqlPgThesisCommApproveProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisCommMemberProvider"
			
		private SqlPgThesisCommMemberProvider innerSqlPgThesisCommMemberProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisCommMember"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisCommMemberProviderBase PgThesisCommMemberProvider
		{
			get
			{
				if (innerSqlPgThesisCommMemberProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisCommMemberProvider == null)
						{
							this.innerSqlPgThesisCommMemberProvider = new SqlPgThesisCommMemberProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisCommMemberProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisCommMemberProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisCommMemberProvider SqlPgThesisCommMemberProvider
		{
			get {return PgThesisCommMemberProvider as SqlPgThesisCommMemberProvider;}
		}
		
		#endregion
		
		
		#region "RsrchStudPostponeReqProvider"
			
		private SqlRsrchStudPostponeReqProvider innerSqlRsrchStudPostponeReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="RsrchStudPostponeReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override RsrchStudPostponeReqProviderBase RsrchStudPostponeReqProvider
		{
			get
			{
				if (innerSqlRsrchStudPostponeReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlRsrchStudPostponeReqProvider == null)
						{
							this.innerSqlRsrchStudPostponeReqProvider = new SqlRsrchStudPostponeReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlRsrchStudPostponeReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlRsrchStudPostponeReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlRsrchStudPostponeReqProvider SqlRsrchStudPostponeReqProvider
		{
			get {return RsrchStudPostponeReqProvider as SqlRsrchStudPostponeReqProvider;}
		}
		
		#endregion
		
		
		#region "PgSubjectDefinitionProvider"
			
		private SqlPgSubjectDefinitionProvider innerSqlPgSubjectDefinitionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgSubjectDefinition"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgSubjectDefinitionProviderBase PgSubjectDefinitionProvider
		{
			get
			{
				if (innerSqlPgSubjectDefinitionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgSubjectDefinitionProvider == null)
						{
							this.innerSqlPgSubjectDefinitionProvider = new SqlPgSubjectDefinitionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgSubjectDefinitionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgSubjectDefinitionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgSubjectDefinitionProvider SqlPgSubjectDefinitionProvider
		{
			get {return PgSubjectDefinitionProvider as SqlPgSubjectDefinitionProvider;}
		}
		
		#endregion
		
		
		#region "PgStudTravelProvider"
			
		private SqlPgStudTravelProvider innerSqlPgStudTravelProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgStudTravel"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgStudTravelProviderBase PgStudTravelProvider
		{
			get
			{
				if (innerSqlPgStudTravelProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgStudTravelProvider == null)
						{
							this.innerSqlPgStudTravelProvider = new SqlPgStudTravelProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgStudTravelProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgStudTravelProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgStudTravelProvider SqlPgStudTravelProvider
		{
			get {return PgStudTravelProvider as SqlPgStudTravelProvider;}
		}
		
		#endregion
		
		
		#region "PgStudTravelExtendProvider"
			
		private SqlPgStudTravelExtendProvider innerSqlPgStudTravelExtendProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgStudTravelExtend"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgStudTravelExtendProviderBase PgStudTravelExtendProvider
		{
			get
			{
				if (innerSqlPgStudTravelExtendProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgStudTravelExtendProvider == null)
						{
							this.innerSqlPgStudTravelExtendProvider = new SqlPgStudTravelExtendProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgStudTravelExtendProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgStudTravelExtendProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgStudTravelExtendProvider SqlPgStudTravelExtendProvider
		{
			get {return PgStudTravelExtendProvider as SqlPgStudTravelExtendProvider;}
		}
		
		#endregion
		
		
		#region "PgCodeSupervisorChgRsnProvider"
			
		private SqlPgCodeSupervisorChgRsnProvider innerSqlPgCodeSupervisorChgRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgCodeSupervisorChgRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgCodeSupervisorChgRsnProviderBase PgCodeSupervisorChgRsnProvider
		{
			get
			{
				if (innerSqlPgCodeSupervisorChgRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgCodeSupervisorChgRsnProvider == null)
						{
							this.innerSqlPgCodeSupervisorChgRsnProvider = new SqlPgCodeSupervisorChgRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgCodeSupervisorChgRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgCodeSupervisorChgRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgCodeSupervisorChgRsnProvider SqlPgCodeSupervisorChgRsnProvider
		{
			get {return PgCodeSupervisorChgRsnProvider as SqlPgCodeSupervisorChgRsnProvider;}
		}
		
		#endregion
		
		
		#region "PgExtMemberProvider"
			
		private SqlPgExtMemberProvider innerSqlPgExtMemberProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgExtMember"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgExtMemberProviderBase PgExtMemberProvider
		{
			get
			{
				if (innerSqlPgExtMemberProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgExtMemberProvider == null)
						{
							this.innerSqlPgExtMemberProvider = new SqlPgExtMemberProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgExtMemberProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgExtMemberProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgExtMemberProvider SqlPgExtMemberProvider
		{
			get {return PgExtMemberProvider as SqlPgExtMemberProvider;}
		}
		
		#endregion
		
		
		#region "PgStfRoleDegProvider"
			
		private SqlPgStfRoleDegProvider innerSqlPgStfRoleDegProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgStfRoleDeg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgStfRoleDegProviderBase PgStfRoleDegProvider
		{
			get
			{
				if (innerSqlPgStfRoleDegProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgStfRoleDegProvider == null)
						{
							this.innerSqlPgStfRoleDegProvider = new SqlPgStfRoleDegProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgStfRoleDegProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgStfRoleDegProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgStfRoleDegProvider SqlPgStfRoleDegProvider
		{
			get {return PgStfRoleDegProvider as SqlPgStfRoleDegProvider;}
		}
		
		#endregion
		
		
		#region "PgStudConferenceProvider"
			
		private SqlPgStudConferenceProvider innerSqlPgStudConferenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgStudConference"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgStudConferenceProviderBase PgStudConferenceProvider
		{
			get
			{
				if (innerSqlPgStudConferenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgStudConferenceProvider == null)
						{
							this.innerSqlPgStudConferenceProvider = new SqlPgStudConferenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgStudConferenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgStudConferenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgStudConferenceProvider SqlPgStudConferenceProvider
		{
			get {return PgStudConferenceProvider as SqlPgStudConferenceProvider;}
		}
		
		#endregion
		
		
		#region "PgStudPublishProvider"
			
		private SqlPgStudPublishProvider innerSqlPgStudPublishProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgStudPublish"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgStudPublishProviderBase PgStudPublishProvider
		{
			get
			{
				if (innerSqlPgStudPublishProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgStudPublishProvider == null)
						{
							this.innerSqlPgStudPublishProvider = new SqlPgStudPublishProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgStudPublishProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgStudPublishProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgStudPublishProvider SqlPgStudPublishProvider
		{
			get {return PgStudPublishProvider as SqlPgStudPublishProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisCommRecommendProvider"
			
		private SqlPgThesisCommRecommendProvider innerSqlPgThesisCommRecommendProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisCommRecommend"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisCommRecommendProviderBase PgThesisCommRecommendProvider
		{
			get
			{
				if (innerSqlPgThesisCommRecommendProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisCommRecommendProvider == null)
						{
							this.innerSqlPgThesisCommRecommendProvider = new SqlPgThesisCommRecommendProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisCommRecommendProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisCommRecommendProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisCommRecommendProvider SqlPgThesisCommRecommendProvider
		{
			get {return PgThesisCommRecommendProvider as SqlPgThesisCommRecommendProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisCommRptProvider"
			
		private SqlPgThesisCommRptProvider innerSqlPgThesisCommRptProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisCommRpt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisCommRptProviderBase PgThesisCommRptProvider
		{
			get
			{
				if (innerSqlPgThesisCommRptProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisCommRptProvider == null)
						{
							this.innerSqlPgThesisCommRptProvider = new SqlPgThesisCommRptProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisCommRptProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisCommRptProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisCommRptProvider SqlPgThesisCommRptProvider
		{
			get {return PgThesisCommRptProvider as SqlPgThesisCommRptProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisDiscussionDateProvider"
			
		private SqlPgThesisDiscussionDateProvider innerSqlPgThesisDiscussionDateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisDiscussionDate"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisDiscussionDateProviderBase PgThesisDiscussionDateProvider
		{
			get
			{
				if (innerSqlPgThesisDiscussionDateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisDiscussionDateProvider == null)
						{
							this.innerSqlPgThesisDiscussionDateProvider = new SqlPgThesisDiscussionDateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisDiscussionDateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisDiscussionDateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisDiscussionDateProvider SqlPgThesisDiscussionDateProvider
		{
			get {return PgThesisDiscussionDateProvider as SqlPgThesisDiscussionDateProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisGrantDegreeProvider"
			
		private SqlPgThesisGrantDegreeProvider innerSqlPgThesisGrantDegreeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisGrantDegree"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisGrantDegreeProviderBase PgThesisGrantDegreeProvider
		{
			get
			{
				if (innerSqlPgThesisGrantDegreeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisGrantDegreeProvider == null)
						{
							this.innerSqlPgThesisGrantDegreeProvider = new SqlPgThesisGrantDegreeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisGrantDegreeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisGrantDegreeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisGrantDegreeProvider SqlPgThesisGrantDegreeProvider
		{
			get {return PgThesisGrantDegreeProvider as SqlPgThesisGrantDegreeProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisStaffProvider"
			
		private SqlPgThesisStaffProvider innerSqlPgThesisStaffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisStaff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisStaffProviderBase PgThesisStaffProvider
		{
			get
			{
				if (innerSqlPgThesisStaffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisStaffProvider == null)
						{
							this.innerSqlPgThesisStaffProvider = new SqlPgThesisStaffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisStaffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisStaffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisStaffProvider SqlPgThesisStaffProvider
		{
			get {return PgThesisStaffProvider as SqlPgThesisStaffProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisSeminarProvider"
			
		private SqlPgThesisSeminarProvider innerSqlPgThesisSeminarProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisSeminar"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisSeminarProviderBase PgThesisSeminarProvider
		{
			get
			{
				if (innerSqlPgThesisSeminarProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisSeminarProvider == null)
						{
							this.innerSqlPgThesisSeminarProvider = new SqlPgThesisSeminarProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisSeminarProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisSeminarProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisSeminarProvider SqlPgThesisSeminarProvider
		{
			get {return PgThesisSeminarProvider as SqlPgThesisSeminarProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisNoteProvider"
			
		private SqlPgThesisNoteProvider innerSqlPgThesisNoteProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisNote"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisNoteProviderBase PgThesisNoteProvider
		{
			get
			{
				if (innerSqlPgThesisNoteProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisNoteProvider == null)
						{
							this.innerSqlPgThesisNoteProvider = new SqlPgThesisNoteProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisNoteProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisNoteProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisNoteProvider SqlPgThesisNoteProvider
		{
			get {return PgThesisNoteProvider as SqlPgThesisNoteProvider;}
		}
		
		#endregion
		
		
		#region "GsMilitaryOfficeProvider"
			
		private SqlGsMilitaryOfficeProvider innerSqlGsMilitaryOfficeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsMilitaryOffice"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsMilitaryOfficeProviderBase GsMilitaryOfficeProvider
		{
			get
			{
				if (innerSqlGsMilitaryOfficeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsMilitaryOfficeProvider == null)
						{
							this.innerSqlGsMilitaryOfficeProvider = new SqlGsMilitaryOfficeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsMilitaryOfficeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsMilitaryOfficeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsMilitaryOfficeProvider SqlGsMilitaryOfficeProvider
		{
			get {return GsMilitaryOfficeProvider as SqlGsMilitaryOfficeProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisStudExtendProvider"
			
		private SqlPgThesisStudExtendProvider innerSqlPgThesisStudExtendProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisStudExtend"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisStudExtendProviderBase PgThesisStudExtendProvider
		{
			get
			{
				if (innerSqlPgThesisStudExtendProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisStudExtendProvider == null)
						{
							this.innerSqlPgThesisStudExtendProvider = new SqlPgThesisStudExtendProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisStudExtendProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisStudExtendProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisStudExtendProvider SqlPgThesisStudExtendProvider
		{
			get {return PgThesisStudExtendProvider as SqlPgThesisStudExtendProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisSupervisorCommApproveProvider"
			
		private SqlPgThesisSupervisorCommApproveProvider innerSqlPgThesisSupervisorCommApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisSupervisorCommApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisSupervisorCommApproveProviderBase PgThesisSupervisorCommApproveProvider
		{
			get
			{
				if (innerSqlPgThesisSupervisorCommApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisSupervisorCommApproveProvider == null)
						{
							this.innerSqlPgThesisSupervisorCommApproveProvider = new SqlPgThesisSupervisorCommApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisSupervisorCommApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisSupervisorCommApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisSupervisorCommApproveProvider SqlPgThesisSupervisorCommApproveProvider
		{
			get {return PgThesisSupervisorCommApproveProvider as SqlPgThesisSupervisorCommApproveProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisValidityRptProvider"
			
		private SqlPgThesisValidityRptProvider innerSqlPgThesisValidityRptProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisValidityRpt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisValidityRptProviderBase PgThesisValidityRptProvider
		{
			get
			{
				if (innerSqlPgThesisValidityRptProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisValidityRptProvider == null)
						{
							this.innerSqlPgThesisValidityRptProvider = new SqlPgThesisValidityRptProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisValidityRptProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisValidityRptProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisValidityRptProvider SqlPgThesisValidityRptProvider
		{
			get {return PgThesisValidityRptProvider as SqlPgThesisValidityRptProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisStudRsrchStrtgyProvider"
			
		private SqlPgThesisStudRsrchStrtgyProvider innerSqlPgThesisStudRsrchStrtgyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisStudRsrchStrtgy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisStudRsrchStrtgyProviderBase PgThesisStudRsrchStrtgyProvider
		{
			get
			{
				if (innerSqlPgThesisStudRsrchStrtgyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisStudRsrchStrtgyProvider == null)
						{
							this.innerSqlPgThesisStudRsrchStrtgyProvider = new SqlPgThesisStudRsrchStrtgyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisStudRsrchStrtgyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisStudRsrchStrtgyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisStudRsrchStrtgyProvider SqlPgThesisStudRsrchStrtgyProvider
		{
			get {return PgThesisStudRsrchStrtgyProvider as SqlPgThesisStudRsrchStrtgyProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisSupervisorRptProvider"
			
		private SqlPgThesisSupervisorRptProvider innerSqlPgThesisSupervisorRptProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisSupervisorRpt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisSupervisorRptProviderBase PgThesisSupervisorRptProvider
		{
			get
			{
				if (innerSqlPgThesisSupervisorRptProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisSupervisorRptProvider == null)
						{
							this.innerSqlPgThesisSupervisorRptProvider = new SqlPgThesisSupervisorRptProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisSupervisorRptProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisSupervisorRptProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisSupervisorRptProvider SqlPgThesisSupervisorRptProvider
		{
			get {return PgThesisSupervisorRptProvider as SqlPgThesisSupervisorRptProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisSupervisorCommProvider"
			
		private SqlPgThesisSupervisorCommProvider innerSqlPgThesisSupervisorCommProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisSupervisorComm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisSupervisorCommProviderBase PgThesisSupervisorCommProvider
		{
			get
			{
				if (innerSqlPgThesisSupervisorCommProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisSupervisorCommProvider == null)
						{
							this.innerSqlPgThesisSupervisorCommProvider = new SqlPgThesisSupervisorCommProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisSupervisorCommProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisSupervisorCommProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisSupervisorCommProvider SqlPgThesisSupervisorCommProvider
		{
			get {return PgThesisSupervisorCommProvider as SqlPgThesisSupervisorCommProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisStudTopicProvider"
			
		private SqlPgThesisStudTopicProvider innerSqlPgThesisStudTopicProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisStudTopic"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisStudTopicProviderBase PgThesisStudTopicProvider
		{
			get
			{
				if (innerSqlPgThesisStudTopicProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisStudTopicProvider == null)
						{
							this.innerSqlPgThesisStudTopicProvider = new SqlPgThesisStudTopicProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisStudTopicProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisStudTopicProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisStudTopicProvider SqlPgThesisStudTopicProvider
		{
			get {return PgThesisStudTopicProvider as SqlPgThesisStudTopicProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisGrantStudProvider"
			
		private SqlPgThesisGrantStudProvider innerSqlPgThesisGrantStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisGrantStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisGrantStudProviderBase PgThesisGrantStudProvider
		{
			get
			{
				if (innerSqlPgThesisGrantStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisGrantStudProvider == null)
						{
							this.innerSqlPgThesisGrantStudProvider = new SqlPgThesisGrantStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisGrantStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisGrantStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisGrantStudProvider SqlPgThesisGrantStudProvider
		{
			get {return PgThesisGrantStudProvider as SqlPgThesisGrantStudProvider;}
		}
		
		#endregion
		
		
		#region "PgAttchdDocProvider"
			
		private SqlPgAttchdDocProvider innerSqlPgAttchdDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgAttchdDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgAttchdDocProviderBase PgAttchdDocProvider
		{
			get
			{
				if (innerSqlPgAttchdDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgAttchdDocProvider == null)
						{
							this.innerSqlPgAttchdDocProvider = new SqlPgAttchdDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgAttchdDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgAttchdDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgAttchdDocProvider SqlPgAttchdDocProvider
		{
			get {return PgAttchdDocProvider as SqlPgAttchdDocProvider;}
		}
		
		#endregion
		
		
		#region "PgThesisStudApproveProvider"
			
		private SqlPgThesisStudApproveProvider innerSqlPgThesisStudApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PgThesisStudApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PgThesisStudApproveProviderBase PgThesisStudApproveProvider
		{
			get
			{
				if (innerSqlPgThesisStudApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPgThesisStudApproveProvider == null)
						{
							this.innerSqlPgThesisStudApproveProvider = new SqlPgThesisStudApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPgThesisStudApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlPgThesisStudApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPgThesisStudApproveProvider SqlPgThesisStudApproveProvider
		{
			get {return PgThesisStudApproveProvider as SqlPgThesisStudApproveProvider;}
		}
		
		#endregion
		
		
		#region "GsCourseElectTypeProvider"
			
		private SqlGsCourseElectTypeProvider innerSqlGsCourseElectTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCourseElectType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCourseElectTypeProviderBase GsCourseElectTypeProvider
		{
			get
			{
				if (innerSqlGsCourseElectTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCourseElectTypeProvider == null)
						{
							this.innerSqlGsCourseElectTypeProvider = new SqlGsCourseElectTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCourseElectTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCourseElectTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCourseElectTypeProvider SqlGsCourseElectTypeProvider
		{
			get {return GsCourseElectTypeProvider as SqlGsCourseElectTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeDocProvider"
			
		private SqlGsCdeDocProvider innerSqlGsCdeDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeDocProviderBase GsCdeDocProvider
		{
			get
			{
				if (innerSqlGsCdeDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeDocProvider == null)
						{
							this.innerSqlGsCdeDocProvider = new SqlGsCdeDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeDocProvider SqlGsCdeDocProvider
		{
			get {return GsCdeDocProvider as SqlGsCdeDocProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeActvtyTypeProvider"
			
		private SqlGsCdeActvtyTypeProvider innerSqlGsCdeActvtyTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeActvtyType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeActvtyTypeProviderBase GsCdeActvtyTypeProvider
		{
			get
			{
				if (innerSqlGsCdeActvtyTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeActvtyTypeProvider == null)
						{
							this.innerSqlGsCdeActvtyTypeProvider = new SqlGsCdeActvtyTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeActvtyTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeActvtyTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeActvtyTypeProvider SqlGsCdeActvtyTypeProvider
		{
			get {return GsCdeActvtyTypeProvider as SqlGsCdeActvtyTypeProvider;}
		}
		
		#endregion
		
		
		#region "FeeUserFundReqProvider"
			
		private SqlFeeUserFundReqProvider innerSqlFeeUserFundReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeUserFundReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeUserFundReqProviderBase FeeUserFundReqProvider
		{
			get
			{
				if (innerSqlFeeUserFundReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeUserFundReqProvider == null)
						{
							this.innerSqlFeeUserFundReqProvider = new SqlFeeUserFundReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeUserFundReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeUserFundReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeUserFundReqProvider SqlFeeUserFundReqProvider
		{
			get {return FeeUserFundReqProvider as SqlFeeUserFundReqProvider;}
		}
		
		#endregion
		
		
		#region "FeeUserBondReqProvider"
			
		private SqlFeeUserBondReqProvider innerSqlFeeUserBondReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeUserBondReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeUserBondReqProviderBase FeeUserBondReqProvider
		{
			get
			{
				if (innerSqlFeeUserBondReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeUserBondReqProvider == null)
						{
							this.innerSqlFeeUserBondReqProvider = new SqlFeeUserBondReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeUserBondReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeUserBondReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeUserBondReqProvider SqlFeeUserBondReqProvider
		{
			get {return FeeUserBondReqProvider as SqlFeeUserBondReqProvider;}
		}
		
		#endregion
		
		
		#region "FeeTreasuryReqProvider"
			
		private SqlFeeTreasuryReqProvider innerSqlFeeTreasuryReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeTreasuryReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeTreasuryReqProviderBase FeeTreasuryReqProvider
		{
			get
			{
				if (innerSqlFeeTreasuryReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeTreasuryReqProvider == null)
						{
							this.innerSqlFeeTreasuryReqProvider = new SqlFeeTreasuryReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeTreasuryReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeTreasuryReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeTreasuryReqProvider SqlFeeTreasuryReqProvider
		{
			get {return FeeTreasuryReqProvider as SqlFeeTreasuryReqProvider;}
		}
		
		#endregion
		
		
		#region "FeeTreasuryItemProvider"
			
		private SqlFeeTreasuryItemProvider innerSqlFeeTreasuryItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeTreasuryItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeTreasuryItemProviderBase FeeTreasuryItemProvider
		{
			get
			{
				if (innerSqlFeeTreasuryItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeTreasuryItemProvider == null)
						{
							this.innerSqlFeeTreasuryItemProvider = new SqlFeeTreasuryItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeTreasuryItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeTreasuryItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeTreasuryItemProvider SqlFeeTreasuryItemProvider
		{
			get {return FeeTreasuryItemProvider as SqlFeeTreasuryItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeYearPrdBankProvider"
			
		private SqlFeeYearPrdBankProvider innerSqlFeeYearPrdBankProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeYearPrdBank"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeYearPrdBankProviderBase FeeYearPrdBankProvider
		{
			get
			{
				if (innerSqlFeeYearPrdBankProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeYearPrdBankProvider == null)
						{
							this.innerSqlFeeYearPrdBankProvider = new SqlFeeYearPrdBankProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeYearPrdBankProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeYearPrdBankProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeYearPrdBankProvider SqlFeeYearPrdBankProvider
		{
			get {return FeeYearPrdBankProvider as SqlFeeYearPrdBankProvider;}
		}
		
		#endregion
		
		
		#region "GsAgendaHolidayProvider"
			
		private SqlGsAgendaHolidayProvider innerSqlGsAgendaHolidayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsAgendaHoliday"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsAgendaHolidayProviderBase GsAgendaHolidayProvider
		{
			get
			{
				if (innerSqlGsAgendaHolidayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsAgendaHolidayProvider == null)
						{
							this.innerSqlGsAgendaHolidayProvider = new SqlGsAgendaHolidayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsAgendaHolidayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsAgendaHolidayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsAgendaHolidayProvider SqlGsAgendaHolidayProvider
		{
			get {return GsAgendaHolidayProvider as SqlGsAgendaHolidayProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeActvtyProvider"
			
		private SqlGsCdeActvtyProvider innerSqlGsCdeActvtyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeActvty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeActvtyProviderBase GsCdeActvtyProvider
		{
			get
			{
				if (innerSqlGsCdeActvtyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeActvtyProvider == null)
						{
							this.innerSqlGsCdeActvtyProvider = new SqlGsCdeActvtyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeActvtyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeActvtyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeActvtyProvider SqlGsCdeActvtyProvider
		{
			get {return GsCdeActvtyProvider as SqlGsCdeActvtyProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeClrncReasonProvider"
			
		private SqlGsCdeClrncReasonProvider innerSqlGsCdeClrncReasonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeClrncReason"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeClrncReasonProviderBase GsCdeClrncReasonProvider
		{
			get
			{
				if (innerSqlGsCdeClrncReasonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeClrncReasonProvider == null)
						{
							this.innerSqlGsCdeClrncReasonProvider = new SqlGsCdeClrncReasonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeClrncReasonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeClrncReasonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeClrncReasonProvider SqlGsCdeClrncReasonProvider
		{
			get {return GsCdeClrncReasonProvider as SqlGsCdeClrncReasonProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeClrncItemProvider"
			
		private SqlGsCdeClrncItemProvider innerSqlGsCdeClrncItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeClrncItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeClrncItemProviderBase GsCdeClrncItemProvider
		{
			get
			{
				if (innerSqlGsCdeClrncItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeClrncItemProvider == null)
						{
							this.innerSqlGsCdeClrncItemProvider = new SqlGsCdeClrncItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeClrncItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeClrncItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeClrncItemProvider SqlGsCdeClrncItemProvider
		{
			get {return GsCdeClrncItemProvider as SqlGsCdeClrncItemProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeCampusProvider"
			
		private SqlGsCdeCampusProvider innerSqlGsCdeCampusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeCampus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeCampusProviderBase GsCdeCampusProvider
		{
			get
			{
				if (innerSqlGsCdeCampusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeCampusProvider == null)
						{
							this.innerSqlGsCdeCampusProvider = new SqlGsCdeCampusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeCampusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeCampusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeCampusProvider SqlGsCdeCampusProvider
		{
			get {return GsCdeCampusProvider as SqlGsCdeCampusProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeBloodProvider"
			
		private SqlGsCdeBloodProvider innerSqlGsCdeBloodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeBlood"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeBloodProviderBase GsCdeBloodProvider
		{
			get
			{
				if (innerSqlGsCdeBloodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeBloodProvider == null)
						{
							this.innerSqlGsCdeBloodProvider = new SqlGsCdeBloodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeBloodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeBloodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeBloodProvider SqlGsCdeBloodProvider
		{
			get {return GsCdeBloodProvider as SqlGsCdeBloodProvider;}
		}
		
		#endregion
		
		
		#region "GsCountryNodeProvider"
			
		private SqlGsCountryNodeProvider innerSqlGsCountryNodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCountryNode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCountryNodeProviderBase GsCountryNodeProvider
		{
			get
			{
				if (innerSqlGsCountryNodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCountryNodeProvider == null)
						{
							this.innerSqlGsCountryNodeProvider = new SqlGsCountryNodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCountryNodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCountryNodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCountryNodeProvider SqlGsCountryNodeProvider
		{
			get {return GsCountryNodeProvider as SqlGsCountryNodeProvider;}
		}
		
		#endregion
		
		
		#region "GsApprovalHProvider"
			
		private SqlGsApprovalHProvider innerSqlGsApprovalHProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsApprovalH"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsApprovalHProviderBase GsApprovalHProvider
		{
			get
			{
				if (innerSqlGsApprovalHProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsApprovalHProvider == null)
						{
							this.innerSqlGsApprovalHProvider = new SqlGsApprovalHProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsApprovalHProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsApprovalHProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsApprovalHProvider SqlGsApprovalHProvider
		{
			get {return GsApprovalHProvider as SqlGsApprovalHProvider;}
		}
		
		#endregion
		
		
		#region "FeeRefundCodeProvider"
			
		private SqlFeeRefundCodeProvider innerSqlFeeRefundCodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeRefundCode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeRefundCodeProviderBase FeeRefundCodeProvider
		{
			get
			{
				if (innerSqlFeeRefundCodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeRefundCodeProvider == null)
						{
							this.innerSqlFeeRefundCodeProvider = new SqlFeeRefundCodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeRefundCodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeRefundCodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeRefundCodeProvider SqlFeeRefundCodeProvider
		{
			get {return FeeRefundCodeProvider as SqlFeeRefundCodeProvider;}
		}
		
		#endregion
		
		
		#region "GsAttchdDocProvider"
			
		private SqlGsAttchdDocProvider innerSqlGsAttchdDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsAttchdDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsAttchdDocProviderBase GsAttchdDocProvider
		{
			get
			{
				if (innerSqlGsAttchdDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsAttchdDocProvider == null)
						{
							this.innerSqlGsAttchdDocProvider = new SqlGsAttchdDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsAttchdDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsAttchdDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsAttchdDocProvider SqlGsAttchdDocProvider
		{
			get {return GsAttchdDocProvider as SqlGsAttchdDocProvider;}
		}
		
		#endregion
		
		
		#region "GsApprovalDProvider"
			
		private SqlGsApprovalDProvider innerSqlGsApprovalDProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsApprovalD"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsApprovalDProviderBase GsApprovalDProvider
		{
			get
			{
				if (innerSqlGsApprovalDProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsApprovalDProvider == null)
						{
							this.innerSqlGsApprovalDProvider = new SqlGsApprovalDProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsApprovalDProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsApprovalDProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsApprovalDProvider SqlGsApprovalDProvider
		{
			get {return GsApprovalDProvider as SqlGsApprovalDProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudDiscContinueProvider"
			
		private SqlFeeStudDiscContinueProvider innerSqlFeeStudDiscContinueProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudDiscContinue"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudDiscContinueProviderBase FeeStudDiscContinueProvider
		{
			get
			{
				if (innerSqlFeeStudDiscContinueProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudDiscContinueProvider == null)
						{
							this.innerSqlFeeStudDiscContinueProvider = new SqlFeeStudDiscContinueProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudDiscContinueProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudDiscContinueProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudDiscContinueProvider SqlFeeStudDiscContinueProvider
		{
			get {return FeeStudDiscContinueProvider as SqlFeeStudDiscContinueProvider;}
		}
		
		#endregion
		
		
		#region "FeeSemesterAgendaProvider"
			
		private SqlFeeSemesterAgendaProvider innerSqlFeeSemesterAgendaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeSemesterAgenda"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeSemesterAgendaProviderBase FeeSemesterAgendaProvider
		{
			get
			{
				if (innerSqlFeeSemesterAgendaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeSemesterAgendaProvider == null)
						{
							this.innerSqlFeeSemesterAgendaProvider = new SqlFeeSemesterAgendaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeSemesterAgendaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeSemesterAgendaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeSemesterAgendaProvider SqlFeeSemesterAgendaProvider
		{
			get {return FeeSemesterAgendaProvider as SqlFeeSemesterAgendaProvider;}
		}
		
		#endregion
		
		
		#region "FeeRefundCodeDtlProvider"
			
		private SqlFeeRefundCodeDtlProvider innerSqlFeeRefundCodeDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeRefundCodeDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeRefundCodeDtlProviderBase FeeRefundCodeDtlProvider
		{
			get
			{
				if (innerSqlFeeRefundCodeDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeRefundCodeDtlProvider == null)
						{
							this.innerSqlFeeRefundCodeDtlProvider = new SqlFeeRefundCodeDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeRefundCodeDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeRefundCodeDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeRefundCodeDtlProvider SqlFeeRefundCodeDtlProvider
		{
			get {return FeeRefundCodeDtlProvider as SqlFeeRefundCodeDtlProvider;}
		}
		
		#endregion
		
		
		#region "FeeVoucherInvocProvider"
			
		private SqlFeeVoucherInvocProvider innerSqlFeeVoucherInvocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeVoucherInvoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeVoucherInvocProviderBase FeeVoucherInvocProvider
		{
			get
			{
				if (innerSqlFeeVoucherInvocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeVoucherInvocProvider == null)
						{
							this.innerSqlFeeVoucherInvocProvider = new SqlFeeVoucherInvocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeVoucherInvocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeVoucherInvocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeVoucherInvocProvider SqlFeeVoucherInvocProvider
		{
			get {return FeeVoucherInvocProvider as SqlFeeVoucherInvocProvider;}
		}
		
		#endregion
		
		
		#region "GsAddressDtlProvider"
			
		private SqlGsAddressDtlProvider innerSqlGsAddressDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsAddressDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsAddressDtlProviderBase GsAddressDtlProvider
		{
			get
			{
				if (innerSqlGsAddressDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsAddressDtlProvider == null)
						{
							this.innerSqlGsAddressDtlProvider = new SqlGsAddressDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsAddressDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsAddressDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsAddressDtlProvider SqlGsAddressDtlProvider
		{
			get {return GsAddressDtlProvider as SqlGsAddressDtlProvider;}
		}
		
		#endregion
		
		
		#region "FeeRefndStdReqProvider"
			
		private SqlFeeRefndStdReqProvider innerSqlFeeRefndStdReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeRefndStdReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeRefndStdReqProviderBase FeeRefndStdReqProvider
		{
			get
			{
				if (innerSqlFeeRefndStdReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeRefndStdReqProvider == null)
						{
							this.innerSqlFeeRefndStdReqProvider = new SqlFeeRefndStdReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeRefndStdReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeRefndStdReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeRefndStdReqProvider SqlFeeRefndStdReqProvider
		{
			get {return FeeRefndStdReqProvider as SqlFeeRefndStdReqProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeHonorProvider"
			
		private SqlGsCdeHonorProvider innerSqlGsCdeHonorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeHonor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeHonorProviderBase GsCdeHonorProvider
		{
			get
			{
				if (innerSqlGsCdeHonorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeHonorProvider == null)
						{
							this.innerSqlGsCdeHonorProvider = new SqlGsCdeHonorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeHonorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeHonorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeHonorProvider SqlGsCdeHonorProvider
		{
			get {return GsCdeHonorProvider as SqlGsCdeHonorProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeApprovalPnltyProvider"
			
		private SqlGsCdeApprovalPnltyProvider innerSqlGsCdeApprovalPnltyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeApprovalPnlty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeApprovalPnltyProviderBase GsCdeApprovalPnltyProvider
		{
			get
			{
				if (innerSqlGsCdeApprovalPnltyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeApprovalPnltyProvider == null)
						{
							this.innerSqlGsCdeApprovalPnltyProvider = new SqlGsCdeApprovalPnltyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeApprovalPnltyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeApprovalPnltyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeApprovalPnltyProvider SqlGsCdeApprovalPnltyProvider
		{
			get {return GsCdeApprovalPnltyProvider as SqlGsCdeApprovalPnltyProvider;}
		}
		
		#endregion
		
		
		#region "FeeItemSemesterProvider"
			
		private SqlFeeItemSemesterProvider innerSqlFeeItemSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeItemSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeItemSemesterProviderBase FeeItemSemesterProvider
		{
			get
			{
				if (innerSqlFeeItemSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeItemSemesterProvider == null)
						{
							this.innerSqlFeeItemSemesterProvider = new SqlFeeItemSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeItemSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeItemSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeItemSemesterProvider SqlFeeItemSemesterProvider
		{
			get {return FeeItemSemesterProvider as SqlFeeItemSemesterProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeFacultyProvider"
			
		private SqlGsCdeFacultyProvider innerSqlGsCdeFacultyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeFaculty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeFacultyProviderBase GsCdeFacultyProvider
		{
			get
			{
				if (innerSqlGsCdeFacultyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeFacultyProvider == null)
						{
							this.innerSqlGsCdeFacultyProvider = new SqlGsCdeFacultyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeFacultyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeFacultyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeFacultyProvider SqlGsCdeFacultyProvider
		{
			get {return GsCdeFacultyProvider as SqlGsCdeFacultyProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeClrncItemFacProvider"
			
		private SqlGsCdeClrncItemFacProvider innerSqlGsCdeClrncItemFacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeClrncItemFac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeClrncItemFacProviderBase GsCdeClrncItemFacProvider
		{
			get
			{
				if (innerSqlGsCdeClrncItemFacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeClrncItemFacProvider == null)
						{
							this.innerSqlGsCdeClrncItemFacProvider = new SqlGsCdeClrncItemFacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeClrncItemFacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeClrncItemFacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeClrncItemFacProvider SqlGsCdeClrncItemFacProvider
		{
			get {return GsCdeClrncItemFacProvider as SqlGsCdeClrncItemFacProvider;}
		}
		
		#endregion
		
		
		#region "FeeRefndStdDetProvider"
			
		private SqlFeeRefndStdDetProvider innerSqlFeeRefndStdDetProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeRefndStdDet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeRefndStdDetProviderBase FeeRefndStdDetProvider
		{
			get
			{
				if (innerSqlFeeRefndStdDetProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeRefndStdDetProvider == null)
						{
							this.innerSqlFeeRefndStdDetProvider = new SqlFeeRefndStdDetProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeRefndStdDetProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeRefndStdDetProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeRefndStdDetProvider SqlFeeRefndStdDetProvider
		{
			get {return FeeRefndStdDetProvider as SqlFeeRefndStdDetProvider;}
		}
		
		#endregion
		
		
		#region "FeeItemTrnsBlncProvider"
			
		private SqlFeeItemTrnsBlncProvider innerSqlFeeItemTrnsBlncProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeItemTrnsBlnc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeItemTrnsBlncProviderBase FeeItemTrnsBlncProvider
		{
			get
			{
				if (innerSqlFeeItemTrnsBlncProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeItemTrnsBlncProvider == null)
						{
							this.innerSqlFeeItemTrnsBlncProvider = new SqlFeeItemTrnsBlncProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeItemTrnsBlncProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeItemTrnsBlncProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeItemTrnsBlncProvider SqlFeeItemTrnsBlncProvider
		{
			get {return FeeItemTrnsBlncProvider as SqlFeeItemTrnsBlncProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudAllowanceProvider"
			
		private SqlFeeStudAllowanceProvider innerSqlFeeStudAllowanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudAllowance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudAllowanceProviderBase FeeStudAllowanceProvider
		{
			get
			{
				if (innerSqlFeeStudAllowanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudAllowanceProvider == null)
						{
							this.innerSqlFeeStudAllowanceProvider = new SqlFeeStudAllowanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudAllowanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudAllowanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudAllowanceProvider SqlFeeStudAllowanceProvider
		{
			get {return FeeStudAllowanceProvider as SqlFeeStudAllowanceProvider;}
		}
		
		#endregion
		
		
		#region "FeeLimitRuleProvider"
			
		private SqlFeeLimitRuleProvider innerSqlFeeLimitRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeLimitRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeLimitRuleProviderBase FeeLimitRuleProvider
		{
			get
			{
				if (innerSqlFeeLimitRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeLimitRuleProvider == null)
						{
							this.innerSqlFeeLimitRuleProvider = new SqlFeeLimitRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeLimitRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeLimitRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeLimitRuleProvider SqlFeeLimitRuleProvider
		{
			get {return FeeLimitRuleProvider as SqlFeeLimitRuleProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudInstallmentRequestProvider"
			
		private SqlFeeStudInstallmentRequestProvider innerSqlFeeStudInstallmentRequestProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudInstallmentRequest"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudInstallmentRequestProviderBase FeeStudInstallmentRequestProvider
		{
			get
			{
				if (innerSqlFeeStudInstallmentRequestProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudInstallmentRequestProvider == null)
						{
							this.innerSqlFeeStudInstallmentRequestProvider = new SqlFeeStudInstallmentRequestProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudInstallmentRequestProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudInstallmentRequestProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudInstallmentRequestProvider SqlFeeStudInstallmentRequestProvider
		{
			get {return FeeStudInstallmentRequestProvider as SqlFeeStudInstallmentRequestProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudBankProvider"
			
		private SqlFeeStudBankProvider innerSqlFeeStudBankProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudBank"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudBankProviderBase FeeStudBankProvider
		{
			get
			{
				if (innerSqlFeeStudBankProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudBankProvider == null)
						{
							this.innerSqlFeeStudBankProvider = new SqlFeeStudBankProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudBankProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudBankProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudBankProvider SqlFeeStudBankProvider
		{
			get {return FeeStudBankProvider as SqlFeeStudBankProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudInstallmentProvider"
			
		private SqlFeeStudInstallmentProvider innerSqlFeeStudInstallmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudInstallment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudInstallmentProviderBase FeeStudInstallmentProvider
		{
			get
			{
				if (innerSqlFeeStudInstallmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudInstallmentProvider == null)
						{
							this.innerSqlFeeStudInstallmentProvider = new SqlFeeStudInstallmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudInstallmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudInstallmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudInstallmentProvider SqlFeeStudInstallmentProvider
		{
			get {return FeeStudInstallmentProvider as SqlFeeStudInstallmentProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudItemCnclProvider"
			
		private SqlFeeStudItemCnclProvider innerSqlFeeStudItemCnclProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudItemCncl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudItemCnclProviderBase FeeStudItemCnclProvider
		{
			get
			{
				if (innerSqlFeeStudItemCnclProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudItemCnclProvider == null)
						{
							this.innerSqlFeeStudItemCnclProvider = new SqlFeeStudItemCnclProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudItemCnclProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudItemCnclProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudItemCnclProvider SqlFeeStudItemCnclProvider
		{
			get {return FeeStudItemCnclProvider as SqlFeeStudItemCnclProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudFundProvider"
			
		private SqlFeeStudFundProvider innerSqlFeeStudFundProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudFund"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudFundProviderBase FeeStudFundProvider
		{
			get
			{
				if (innerSqlFeeStudFundProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudFundProvider == null)
						{
							this.innerSqlFeeStudFundProvider = new SqlFeeStudFundProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudFundProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudFundProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudFundProvider SqlFeeStudFundProvider
		{
			get {return FeeStudFundProvider as SqlFeeStudFundProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudFeeItemProvider"
			
		private SqlFeeStudFeeItemProvider innerSqlFeeStudFeeItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudFeeItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudFeeItemProviderBase FeeStudFeeItemProvider
		{
			get
			{
				if (innerSqlFeeStudFeeItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudFeeItemProvider == null)
						{
							this.innerSqlFeeStudFeeItemProvider = new SqlFeeStudFeeItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudFeeItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudFeeItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudFeeItemProvider SqlFeeStudFeeItemProvider
		{
			get {return FeeStudFeeItemProvider as SqlFeeStudFeeItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudDiscFeeItemProvider"
			
		private SqlFeeStudDiscFeeItemProvider innerSqlFeeStudDiscFeeItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudDiscFeeItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudDiscFeeItemProviderBase FeeStudDiscFeeItemProvider
		{
			get
			{
				if (innerSqlFeeStudDiscFeeItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudDiscFeeItemProvider == null)
						{
							this.innerSqlFeeStudDiscFeeItemProvider = new SqlFeeStudDiscFeeItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudDiscFeeItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudDiscFeeItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudDiscFeeItemProvider SqlFeeStudDiscFeeItemProvider
		{
			get {return FeeStudDiscFeeItemProvider as SqlFeeStudDiscFeeItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudNatSimilarityRequestProvider"
			
		private SqlFeeStudNatSimilarityRequestProvider innerSqlFeeStudNatSimilarityRequestProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudNatSimilarityRequest"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudNatSimilarityRequestProviderBase FeeStudNatSimilarityRequestProvider
		{
			get
			{
				if (innerSqlFeeStudNatSimilarityRequestProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudNatSimilarityRequestProvider == null)
						{
							this.innerSqlFeeStudNatSimilarityRequestProvider = new SqlFeeStudNatSimilarityRequestProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudNatSimilarityRequestProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudNatSimilarityRequestProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudNatSimilarityRequestProvider SqlFeeStudNatSimilarityRequestProvider
		{
			get {return FeeStudNatSimilarityRequestProvider as SqlFeeStudNatSimilarityRequestProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudDiscSemesterProvider"
			
		private SqlFeeStudDiscSemesterProvider innerSqlFeeStudDiscSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudDiscSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudDiscSemesterProviderBase FeeStudDiscSemesterProvider
		{
			get
			{
				if (innerSqlFeeStudDiscSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudDiscSemesterProvider == null)
						{
							this.innerSqlFeeStudDiscSemesterProvider = new SqlFeeStudDiscSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudDiscSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudDiscSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudDiscSemesterProvider SqlFeeStudDiscSemesterProvider
		{
			get {return FeeStudDiscSemesterProvider as SqlFeeStudDiscSemesterProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudPayPostponeProvider"
			
		private SqlFeeStudPayPostponeProvider innerSqlFeeStudPayPostponeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudPayPostpone"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudPayPostponeProviderBase FeeStudPayPostponeProvider
		{
			get
			{
				if (innerSqlFeeStudPayPostponeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudPayPostponeProvider == null)
						{
							this.innerSqlFeeStudPayPostponeProvider = new SqlFeeStudPayPostponeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudPayPostponeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudPayPostponeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudPayPostponeProvider SqlFeeStudPayPostponeProvider
		{
			get {return FeeStudPayPostponeProvider as SqlFeeStudPayPostponeProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudDiscProvider"
			
		private SqlFeeStudDiscProvider innerSqlFeeStudDiscProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudDisc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudDiscProviderBase FeeStudDiscProvider
		{
			get
			{
				if (innerSqlFeeStudDiscProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudDiscProvider == null)
						{
							this.innerSqlFeeStudDiscProvider = new SqlFeeStudDiscProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudDiscProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudDiscProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudDiscProvider SqlFeeStudDiscProvider
		{
			get {return FeeStudDiscProvider as SqlFeeStudDiscProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudVoucherProvider"
			
		private SqlFeeStudVoucherProvider innerSqlFeeStudVoucherProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudVoucher"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudVoucherProviderBase FeeStudVoucherProvider
		{
			get
			{
				if (innerSqlFeeStudVoucherProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudVoucherProvider == null)
						{
							this.innerSqlFeeStudVoucherProvider = new SqlFeeStudVoucherProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudVoucherProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudVoucherProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudVoucherProvider SqlFeeStudVoucherProvider
		{
			get {return FeeStudVoucherProvider as SqlFeeStudVoucherProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudCoursesItemProvider"
			
		private SqlFeeStudCoursesItemProvider innerSqlFeeStudCoursesItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudCoursesItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudCoursesItemProviderBase FeeStudCoursesItemProvider
		{
			get
			{
				if (innerSqlFeeStudCoursesItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudCoursesItemProvider == null)
						{
							this.innerSqlFeeStudCoursesItemProvider = new SqlFeeStudCoursesItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudCoursesItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudCoursesItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudCoursesItemProvider SqlFeeStudCoursesItemProvider
		{
			get {return FeeStudCoursesItemProvider as SqlFeeStudCoursesItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeTreasuryProvider"
			
		private SqlFeeTreasuryProvider innerSqlFeeTreasuryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeTreasury"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeTreasuryProviderBase FeeTreasuryProvider
		{
			get
			{
				if (innerSqlFeeTreasuryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeTreasuryProvider == null)
						{
							this.innerSqlFeeTreasuryProvider = new SqlFeeTreasuryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeTreasuryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeTreasuryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeTreasuryProvider SqlFeeTreasuryProvider
		{
			get {return FeeTreasuryProvider as SqlFeeTreasuryProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudRetrieveRequestProvider"
			
		private SqlFeeStudRetrieveRequestProvider innerSqlFeeStudRetrieveRequestProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudRetrieveRequest"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudRetrieveRequestProviderBase FeeStudRetrieveRequestProvider
		{
			get
			{
				if (innerSqlFeeStudRetrieveRequestProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudRetrieveRequestProvider == null)
						{
							this.innerSqlFeeStudRetrieveRequestProvider = new SqlFeeStudRetrieveRequestProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudRetrieveRequestProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudRetrieveRequestProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudRetrieveRequestProvider SqlFeeStudRetrieveRequestProvider
		{
			get {return FeeStudRetrieveRequestProvider as SqlFeeStudRetrieveRequestProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudVoucherPayMthodProvider"
			
		private SqlFeeStudVoucherPayMthodProvider innerSqlFeeStudVoucherPayMthodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudVoucherPayMthod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudVoucherPayMthodProviderBase FeeStudVoucherPayMthodProvider
		{
			get
			{
				if (innerSqlFeeStudVoucherPayMthodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudVoucherPayMthodProvider == null)
						{
							this.innerSqlFeeStudVoucherPayMthodProvider = new SqlFeeStudVoucherPayMthodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudVoucherPayMthodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudVoucherPayMthodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudVoucherPayMthodProvider SqlFeeStudVoucherPayMthodProvider
		{
			get {return FeeStudVoucherPayMthodProvider as SqlFeeStudVoucherPayMthodProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudVoucherItemProvider"
			
		private SqlFeeStudVoucherItemProvider innerSqlFeeStudVoucherItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudVoucherItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudVoucherItemProviderBase FeeStudVoucherItemProvider
		{
			get
			{
				if (innerSqlFeeStudVoucherItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudVoucherItemProvider == null)
						{
							this.innerSqlFeeStudVoucherItemProvider = new SqlFeeStudVoucherItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudVoucherItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudVoucherItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudVoucherItemProvider SqlFeeStudVoucherItemProvider
		{
			get {return FeeStudVoucherItemProvider as SqlFeeStudVoucherItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudDiscCodeItemProvider"
			
		private SqlFeeStudDiscCodeItemProvider innerSqlFeeStudDiscCodeItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudDiscCodeItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudDiscCodeItemProviderBase FeeStudDiscCodeItemProvider
		{
			get
			{
				if (innerSqlFeeStudDiscCodeItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudDiscCodeItemProvider == null)
						{
							this.innerSqlFeeStudDiscCodeItemProvider = new SqlFeeStudDiscCodeItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudDiscCodeItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudDiscCodeItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudDiscCodeItemProvider SqlFeeStudDiscCodeItemProvider
		{
			get {return FeeStudDiscCodeItemProvider as SqlFeeStudDiscCodeItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeStudVoucherCrsItemProvider"
			
		private SqlFeeStudVoucherCrsItemProvider innerSqlFeeStudVoucherCrsItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeStudVoucherCrsItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeStudVoucherCrsItemProviderBase FeeStudVoucherCrsItemProvider
		{
			get
			{
				if (innerSqlFeeStudVoucherCrsItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeStudVoucherCrsItemProvider == null)
						{
							this.innerSqlFeeStudVoucherCrsItemProvider = new SqlFeeStudVoucherCrsItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeStudVoucherCrsItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeStudVoucherCrsItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeStudVoucherCrsItemProvider SqlFeeStudVoucherCrsItemProvider
		{
			get {return FeeStudVoucherCrsItemProvider as SqlFeeStudVoucherCrsItemProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeIncomeProvider"
			
		private SqlGsCdeIncomeProvider innerSqlGsCdeIncomeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeIncome"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeIncomeProviderBase GsCdeIncomeProvider
		{
			get
			{
				if (innerSqlGsCdeIncomeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeIncomeProvider == null)
						{
							this.innerSqlGsCdeIncomeProvider = new SqlGsCdeIncomeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeIncomeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeIncomeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeIncomeProvider SqlGsCdeIncomeProvider
		{
			get {return GsCdeIncomeProvider as SqlGsCdeIncomeProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeMaritalStatusProvider"
			
		private SqlGsCdeMaritalStatusProvider innerSqlGsCdeMaritalStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeMaritalStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeMaritalStatusProviderBase GsCdeMaritalStatusProvider
		{
			get
			{
				if (innerSqlGsCdeMaritalStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeMaritalStatusProvider == null)
						{
							this.innerSqlGsCdeMaritalStatusProvider = new SqlGsCdeMaritalStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeMaritalStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeMaritalStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeMaritalStatusProvider SqlGsCdeMaritalStatusProvider
		{
			get {return GsCdeMaritalStatusProvider as SqlGsCdeMaritalStatusProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeMilCourseResProvider"
			
		private SqlGsCodeMilCourseResProvider innerSqlGsCodeMilCourseResProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeMilCourseRes"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeMilCourseResProviderBase GsCodeMilCourseResProvider
		{
			get
			{
				if (innerSqlGsCodeMilCourseResProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeMilCourseResProvider == null)
						{
							this.innerSqlGsCodeMilCourseResProvider = new SqlGsCodeMilCourseResProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeMilCourseResProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeMilCourseResProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeMilCourseResProvider SqlGsCodeMilCourseResProvider
		{
			get {return GsCodeMilCourseResProvider as SqlGsCodeMilCourseResProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeMilitaryStateProvider"
			
		private SqlGsCodeMilitaryStateProvider innerSqlGsCodeMilitaryStateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeMilitaryState"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeMilitaryStateProviderBase GsCodeMilitaryStateProvider
		{
			get
			{
				if (innerSqlGsCodeMilitaryStateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeMilitaryStateProvider == null)
						{
							this.innerSqlGsCodeMilitaryStateProvider = new SqlGsCodeMilitaryStateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeMilitaryStateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeMilitaryStateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeMilitaryStateProvider SqlGsCodeMilitaryStateProvider
		{
			get {return GsCodeMilitaryStateProvider as SqlGsCodeMilitaryStateProvider;}
		}
		
		#endregion
		
		
		#region "GsCodePassFailProvider"
			
		private SqlGsCodePassFailProvider innerSqlGsCodePassFailProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodePassFail"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodePassFailProviderBase GsCodePassFailProvider
		{
			get
			{
				if (innerSqlGsCodePassFailProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodePassFailProvider == null)
						{
							this.innerSqlGsCodePassFailProvider = new SqlGsCodePassFailProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodePassFailProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodePassFailProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodePassFailProvider SqlGsCodePassFailProvider
		{
			get {return GsCodePassFailProvider as SqlGsCodePassFailProvider;}
		}
		
		#endregion
		
		
		#region "GsCodePayMethodProvider"
			
		private SqlGsCodePayMethodProvider innerSqlGsCodePayMethodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodePayMethod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodePayMethodProviderBase GsCodePayMethodProvider
		{
			get
			{
				if (innerSqlGsCodePayMethodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodePayMethodProvider == null)
						{
							this.innerSqlGsCodePayMethodProvider = new SqlGsCodePayMethodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodePayMethodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodePayMethodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodePayMethodProvider SqlGsCodePayMethodProvider
		{
			get {return GsCodePayMethodProvider as SqlGsCodePayMethodProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeLanguageProvider"
			
		private SqlGsCodeLanguageProvider innerSqlGsCodeLanguageProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeLanguage"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeLanguageProviderBase GsCodeLanguageProvider
		{
			get
			{
				if (innerSqlGsCodeLanguageProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeLanguageProvider == null)
						{
							this.innerSqlGsCodeLanguageProvider = new SqlGsCodeLanguageProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeLanguageProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeLanguageProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeLanguageProvider SqlGsCodeLanguageProvider
		{
			get {return GsCodeLanguageProvider as SqlGsCodeLanguageProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeKinshipProvider"
			
		private SqlGsCodeKinshipProvider innerSqlGsCodeKinshipProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeKinship"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeKinshipProviderBase GsCodeKinshipProvider
		{
			get
			{
				if (innerSqlGsCodeKinshipProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeKinshipProvider == null)
						{
							this.innerSqlGsCodeKinshipProvider = new SqlGsCodeKinshipProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeKinshipProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeKinshipProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeKinshipProvider SqlGsCodeKinshipProvider
		{
			get {return GsCodeKinshipProvider as SqlGsCodeKinshipProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeIdentTypeProvider"
			
		private SqlGsCodeIdentTypeProvider innerSqlGsCodeIdentTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeIdentType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeIdentTypeProviderBase GsCodeIdentTypeProvider
		{
			get
			{
				if (innerSqlGsCodeIdentTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeIdentTypeProvider == null)
						{
							this.innerSqlGsCodeIdentTypeProvider = new SqlGsCodeIdentTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeIdentTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeIdentTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeIdentTypeProvider SqlGsCodeIdentTypeProvider
		{
			get {return GsCodeIdentTypeProvider as SqlGsCodeIdentTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeGuardSupportLevelProvider"
			
		private SqlGsCodeGuardSupportLevelProvider innerSqlGsCodeGuardSupportLevelProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeGuardSupportLevel"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeGuardSupportLevelProviderBase GsCodeGuardSupportLevelProvider
		{
			get
			{
				if (innerSqlGsCodeGuardSupportLevelProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeGuardSupportLevelProvider == null)
						{
							this.innerSqlGsCodeGuardSupportLevelProvider = new SqlGsCodeGuardSupportLevelProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeGuardSupportLevelProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeGuardSupportLevelProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeGuardSupportLevelProvider SqlGsCodeGuardSupportLevelProvider
		{
			get {return GsCodeGuardSupportLevelProvider as SqlGsCodeGuardSupportLevelProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeHouseStatProvider"
			
		private SqlGsCodeHouseStatProvider innerSqlGsCodeHouseStatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeHouseStat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeHouseStatProviderBase GsCodeHouseStatProvider
		{
			get
			{
				if (innerSqlGsCodeHouseStatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeHouseStatProvider == null)
						{
							this.innerSqlGsCodeHouseStatProvider = new SqlGsCodeHouseStatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeHouseStatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeHouseStatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeHouseStatProvider SqlGsCodeHouseStatProvider
		{
			get {return GsCodeHouseStatProvider as SqlGsCodeHouseStatProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeHouseTypeProvider"
			
		private SqlGsCodeHouseTypeProvider innerSqlGsCodeHouseTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeHouseType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeHouseTypeProviderBase GsCodeHouseTypeProvider
		{
			get
			{
				if (innerSqlGsCodeHouseTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeHouseTypeProvider == null)
						{
							this.innerSqlGsCodeHouseTypeProvider = new SqlGsCodeHouseTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeHouseTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeHouseTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeHouseTypeProvider SqlGsCodeHouseTypeProvider
		{
			get {return GsCodeHouseTypeProvider as SqlGsCodeHouseTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeIdentKindProvider"
			
		private SqlGsCodeIdentKindProvider innerSqlGsCodeIdentKindProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeIdentKind"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeIdentKindProviderBase GsCodeIdentKindProvider
		{
			get
			{
				if (innerSqlGsCodeIdentKindProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeIdentKindProvider == null)
						{
							this.innerSqlGsCodeIdentKindProvider = new SqlGsCodeIdentKindProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeIdentKindProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeIdentKindProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeIdentKindProvider SqlGsCodeIdentKindProvider
		{
			get {return GsCodeIdentKindProvider as SqlGsCodeIdentKindProvider;}
		}
		
		#endregion
		
		
		#region "GsCodePayMthdTypeProvider"
			
		private SqlGsCodePayMthdTypeProvider innerSqlGsCodePayMthdTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodePayMthdType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodePayMthdTypeProviderBase GsCodePayMthdTypeProvider
		{
			get
			{
				if (innerSqlGsCodePayMthdTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodePayMthdTypeProvider == null)
						{
							this.innerSqlGsCodePayMthdTypeProvider = new SqlGsCodePayMthdTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodePayMthdTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodePayMthdTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodePayMthdTypeProvider SqlGsCodePayMthdTypeProvider
		{
			get {return GsCodePayMthdTypeProvider as SqlGsCodePayMthdTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsContactMethodHProvider"
			
		private SqlGsContactMethodHProvider innerSqlGsContactMethodHProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsContactMethodH"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsContactMethodHProviderBase GsContactMethodHProvider
		{
			get
			{
				if (innerSqlGsContactMethodHProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsContactMethodHProvider == null)
						{
							this.innerSqlGsContactMethodHProvider = new SqlGsContactMethodHProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsContactMethodHProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsContactMethodHProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsContactMethodHProvider SqlGsContactMethodHProvider
		{
			get {return GsContactMethodHProvider as SqlGsContactMethodHProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeGenderProvider"
			
		private SqlGsCodeGenderProvider innerSqlGsCodeGenderProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeGender"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeGenderProviderBase GsCodeGenderProvider
		{
			get
			{
				if (innerSqlGsCodeGenderProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeGenderProvider == null)
						{
							this.innerSqlGsCodeGenderProvider = new SqlGsCodeGenderProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeGenderProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeGenderProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeGenderProvider SqlGsCodeGenderProvider
		{
			get {return GsCodeGenderProvider as SqlGsCodeGenderProvider;}
		}
		
		#endregion
		
		
		#region "GsCommProvider"
			
		private SqlGsCommProvider innerSqlGsCommProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsComm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCommProviderBase GsCommProvider
		{
			get
			{
				if (innerSqlGsCommProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCommProvider == null)
						{
							this.innerSqlGsCommProvider = new SqlGsCommProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCommProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCommProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCommProvider SqlGsCommProvider
		{
			get {return GsCommProvider as SqlGsCommProvider;}
		}
		
		#endregion
		
		
		#region "GsCommRecomProvider"
			
		private SqlGsCommRecomProvider innerSqlGsCommRecomProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCommRecom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCommRecomProviderBase GsCommRecomProvider
		{
			get
			{
				if (innerSqlGsCommRecomProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCommRecomProvider == null)
						{
							this.innerSqlGsCommRecomProvider = new SqlGsCommRecomProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCommRecomProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCommRecomProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCommRecomProvider SqlGsCommRecomProvider
		{
			get {return GsCommRecomProvider as SqlGsCommRecomProvider;}
		}
		
		#endregion
		
		
		#region "GsCommStaffProvider"
			
		private SqlGsCommStaffProvider innerSqlGsCommStaffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCommStaff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCommStaffProviderBase GsCommStaffProvider
		{
			get
			{
				if (innerSqlGsCommStaffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCommStaffProvider == null)
						{
							this.innerSqlGsCommStaffProvider = new SqlGsCommStaffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCommStaffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCommStaffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCommStaffProvider SqlGsCommStaffProvider
		{
			get {return GsCommStaffProvider as SqlGsCommStaffProvider;}
		}
		
		#endregion
		
		
		#region "GsContactMethodDProvider"
			
		private SqlGsContactMethodDProvider innerSqlGsContactMethodDProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsContactMethodD"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsContactMethodDProviderBase GsContactMethodDProvider
		{
			get
			{
				if (innerSqlGsContactMethodDProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsContactMethodDProvider == null)
						{
							this.innerSqlGsContactMethodDProvider = new SqlGsContactMethodDProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsContactMethodDProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsContactMethodDProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsContactMethodDProvider SqlGsContactMethodDProvider
		{
			get {return GsContactMethodDProvider as SqlGsContactMethodDProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeReligionProvider"
			
		private SqlGsCodeReligionProvider innerSqlGsCodeReligionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeReligion"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeReligionProviderBase GsCodeReligionProvider
		{
			get
			{
				if (innerSqlGsCodeReligionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeReligionProvider == null)
						{
							this.innerSqlGsCodeReligionProvider = new SqlGsCodeReligionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeReligionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeReligionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeReligionProvider SqlGsCodeReligionProvider
		{
			get {return GsCodeReligionProvider as SqlGsCodeReligionProvider;}
		}
		
		#endregion
		
		
		#region "GsCommPurposeProvider"
			
		private SqlGsCommPurposeProvider innerSqlGsCommPurposeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCommPurpose"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCommPurposeProviderBase GsCommPurposeProvider
		{
			get
			{
				if (innerSqlGsCommPurposeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCommPurposeProvider == null)
						{
							this.innerSqlGsCommPurposeProvider = new SqlGsCommPurposeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCommPurposeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCommPurposeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCommPurposeProvider SqlGsCommPurposeProvider
		{
			get {return GsCommPurposeProvider as SqlGsCommPurposeProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeRptSignatureProvider"
			
		private SqlGsCodeRptSignatureProvider innerSqlGsCodeRptSignatureProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeRptSignature"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeRptSignatureProviderBase GsCodeRptSignatureProvider
		{
			get
			{
				if (innerSqlGsCodeRptSignatureProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeRptSignatureProvider == null)
						{
							this.innerSqlGsCodeRptSignatureProvider = new SqlGsCodeRptSignatureProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeRptSignatureProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeRptSignatureProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeRptSignatureProvider SqlGsCodeRptSignatureProvider
		{
			get {return GsCodeRptSignatureProvider as SqlGsCodeRptSignatureProvider;}
		}
		
		#endregion
		
		
		#region "GsCommDuttyProvider"
			
		private SqlGsCommDuttyProvider innerSqlGsCommDuttyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCommDutty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCommDuttyProviderBase GsCommDuttyProvider
		{
			get
			{
				if (innerSqlGsCommDuttyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCommDuttyProvider == null)
						{
							this.innerSqlGsCommDuttyProvider = new SqlGsCommDuttyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCommDuttyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCommDuttyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCommDuttyProvider SqlGsCommDuttyProvider
		{
			get {return GsCommDuttyProvider as SqlGsCommDuttyProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeSysProvider"
			
		private SqlGsCodeSysProvider innerSqlGsCodeSysProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeSys"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeSysProviderBase GsCodeSysProvider
		{
			get
			{
				if (innerSqlGsCodeSysProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeSysProvider == null)
						{
							this.innerSqlGsCodeSysProvider = new SqlGsCodeSysProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeSysProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeSysProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeSysProvider SqlGsCodeSysProvider
		{
			get {return GsCodeSysProvider as SqlGsCodeSysProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeReqStatusProvider"
			
		private SqlGsCodeReqStatusProvider innerSqlGsCodeReqStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeReqStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeReqStatusProviderBase GsCodeReqStatusProvider
		{
			get
			{
				if (innerSqlGsCodeReqStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeReqStatusProvider == null)
						{
							this.innerSqlGsCodeReqStatusProvider = new SqlGsCodeReqStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeReqStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeReqStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeReqStatusProvider SqlGsCodeReqStatusProvider
		{
			get {return GsCodeReqStatusProvider as SqlGsCodeReqStatusProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeWeekDayProvider"
			
		private SqlGsCodeWeekDayProvider innerSqlGsCodeWeekDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeWeekDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeWeekDayProviderBase GsCodeWeekDayProvider
		{
			get
			{
				if (innerSqlGsCodeWeekDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeWeekDayProvider == null)
						{
							this.innerSqlGsCodeWeekDayProvider = new SqlGsCodeWeekDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeWeekDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeWeekDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeWeekDayProvider SqlGsCodeWeekDayProvider
		{
			get {return GsCodeWeekDayProvider as SqlGsCodeWeekDayProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeSportTypeProvider"
			
		private SqlGsCdeSportTypeProvider innerSqlGsCdeSportTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeSportType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeSportTypeProviderBase GsCdeSportTypeProvider
		{
			get
			{
				if (innerSqlGsCdeSportTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeSportTypeProvider == null)
						{
							this.innerSqlGsCdeSportTypeProvider = new SqlGsCdeSportTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeSportTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeSportTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeSportTypeProvider SqlGsCdeSportTypeProvider
		{
			get {return GsCdeSportTypeProvider as SqlGsCdeSportTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeEducationLevelProvider"
			
		private SqlGsCodeEducationLevelProvider innerSqlGsCodeEducationLevelProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeEducationLevel"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeEducationLevelProviderBase GsCodeEducationLevelProvider
		{
			get
			{
				if (innerSqlGsCodeEducationLevelProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeEducationLevelProvider == null)
						{
							this.innerSqlGsCodeEducationLevelProvider = new SqlGsCodeEducationLevelProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeEducationLevelProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeEducationLevelProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeEducationLevelProvider SqlGsCodeEducationLevelProvider
		{
			get {return GsCodeEducationLevelProvider as SqlGsCodeEducationLevelProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeTrnSiteActProvider"
			
		private SqlGsCdeTrnSiteActProvider innerSqlGsCdeTrnSiteActProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeTrnSiteAct"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeTrnSiteActProviderBase GsCdeTrnSiteActProvider
		{
			get
			{
				if (innerSqlGsCdeTrnSiteActProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeTrnSiteActProvider == null)
						{
							this.innerSqlGsCdeTrnSiteActProvider = new SqlGsCdeTrnSiteActProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeTrnSiteActProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeTrnSiteActProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeTrnSiteActProvider SqlGsCdeTrnSiteActProvider
		{
			get {return GsCdeTrnSiteActProvider as SqlGsCdeTrnSiteActProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeSpecAreaProvider"
			
		private SqlGsCdeSpecAreaProvider innerSqlGsCdeSpecAreaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeSpecArea"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeSpecAreaProviderBase GsCdeSpecAreaProvider
		{
			get
			{
				if (innerSqlGsCdeSpecAreaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeSpecAreaProvider == null)
						{
							this.innerSqlGsCdeSpecAreaProvider = new SqlGsCdeSpecAreaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeSpecAreaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeSpecAreaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeSpecAreaProvider SqlGsCdeSpecAreaProvider
		{
			get {return GsCdeSpecAreaProvider as SqlGsCdeSpecAreaProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeViolCatProvider"
			
		private SqlGsCdeViolCatProvider innerSqlGsCdeViolCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeViolCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeViolCatProviderBase GsCdeViolCatProvider
		{
			get
			{
				if (innerSqlGsCdeViolCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeViolCatProvider == null)
						{
							this.innerSqlGsCdeViolCatProvider = new SqlGsCdeViolCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeViolCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeViolCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeViolCatProvider SqlGsCdeViolCatProvider
		{
			get {return GsCdeViolCatProvider as SqlGsCdeViolCatProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeSchoolTypeProvider"
			
		private SqlGsCdeSchoolTypeProvider innerSqlGsCdeSchoolTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeSchoolType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeSchoolTypeProviderBase GsCdeSchoolTypeProvider
		{
			get
			{
				if (innerSqlGsCdeSchoolTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeSchoolTypeProvider == null)
						{
							this.innerSqlGsCdeSchoolTypeProvider = new SqlGsCdeSchoolTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeSchoolTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeSchoolTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeSchoolTypeProvider SqlGsCdeSchoolTypeProvider
		{
			get {return GsCdeSchoolTypeProvider as SqlGsCdeSchoolTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeOutcomeProvider"
			
		private SqlGsCdeOutcomeProvider innerSqlGsCdeOutcomeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeOutcome"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeOutcomeProviderBase GsCdeOutcomeProvider
		{
			get
			{
				if (innerSqlGsCdeOutcomeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeOutcomeProvider == null)
						{
							this.innerSqlGsCdeOutcomeProvider = new SqlGsCdeOutcomeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeOutcomeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeOutcomeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeOutcomeProvider SqlGsCdeOutcomeProvider
		{
			get {return GsCdeOutcomeProvider as SqlGsCdeOutcomeProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeTrnSiteTypeProvider"
			
		private SqlGsCdeTrnSiteTypeProvider innerSqlGsCdeTrnSiteTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeTrnSiteType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeTrnSiteTypeProviderBase GsCdeTrnSiteTypeProvider
		{
			get
			{
				if (innerSqlGsCdeTrnSiteTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeTrnSiteTypeProvider == null)
						{
							this.innerSqlGsCdeTrnSiteTypeProvider = new SqlGsCdeTrnSiteTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeTrnSiteTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeTrnSiteTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeTrnSiteTypeProvider SqlGsCdeTrnSiteTypeProvider
		{
			get {return GsCdeTrnSiteTypeProvider as SqlGsCdeTrnSiteTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCdePenaltyProvider"
			
		private SqlGsCdePenaltyProvider innerSqlGsCdePenaltyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdePenalty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdePenaltyProviderBase GsCdePenaltyProvider
		{
			get
			{
				if (innerSqlGsCdePenaltyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdePenaltyProvider == null)
						{
							this.innerSqlGsCdePenaltyProvider = new SqlGsCdePenaltyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdePenaltyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdePenaltyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdePenaltyProvider SqlGsCdePenaltyProvider
		{
			get {return GsCdePenaltyProvider as SqlGsCdePenaltyProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeSchoolProvider"
			
		private SqlGsCdeSchoolProvider innerSqlGsCdeSchoolProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeSchool"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeSchoolProviderBase GsCdeSchoolProvider
		{
			get
			{
				if (innerSqlGsCdeSchoolProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeSchoolProvider == null)
						{
							this.innerSqlGsCdeSchoolProvider = new SqlGsCdeSchoolProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeSchoolProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeSchoolProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeSchoolProvider SqlGsCdeSchoolProvider
		{
			get {return GsCdeSchoolProvider as SqlGsCdeSchoolProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeTrainSiteProvider"
			
		private SqlGsCdeTrainSiteProvider innerSqlGsCdeTrainSiteProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeTrainSite"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeTrainSiteProviderBase GsCdeTrainSiteProvider
		{
			get
			{
				if (innerSqlGsCdeTrainSiteProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeTrainSiteProvider == null)
						{
							this.innerSqlGsCdeTrainSiteProvider = new SqlGsCdeTrainSiteProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeTrainSiteProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeTrainSiteProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeTrainSiteProvider SqlGsCdeTrainSiteProvider
		{
			get {return GsCdeTrainSiteProvider as SqlGsCdeTrainSiteProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeTrainRespProvider"
			
		private SqlGsCdeTrainRespProvider innerSqlGsCdeTrainRespProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeTrainResp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeTrainRespProviderBase GsCdeTrainRespProvider
		{
			get
			{
				if (innerSqlGsCdeTrainRespProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeTrainRespProvider == null)
						{
							this.innerSqlGsCdeTrainRespProvider = new SqlGsCdeTrainRespProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeTrainRespProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeTrainRespProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeTrainRespProvider SqlGsCdeTrainRespProvider
		{
			get {return GsCdeTrainRespProvider as SqlGsCdeTrainRespProvider;}
		}
		
		#endregion
		
		
		#region "GsCdePenaltyRelatedProvider"
			
		private SqlGsCdePenaltyRelatedProvider innerSqlGsCdePenaltyRelatedProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdePenaltyRelated"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdePenaltyRelatedProviderBase GsCdePenaltyRelatedProvider
		{
			get
			{
				if (innerSqlGsCdePenaltyRelatedProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdePenaltyRelatedProvider == null)
						{
							this.innerSqlGsCdePenaltyRelatedProvider = new SqlGsCdePenaltyRelatedProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdePenaltyRelatedProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdePenaltyRelatedProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdePenaltyRelatedProvider SqlGsCdePenaltyRelatedProvider
		{
			get {return GsCdePenaltyRelatedProvider as SqlGsCdePenaltyRelatedProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeUniversitiesProvider"
			
		private SqlGsCdeUniversitiesProvider innerSqlGsCdeUniversitiesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeUniversities"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeUniversitiesProviderBase GsCdeUniversitiesProvider
		{
			get
			{
				if (innerSqlGsCdeUniversitiesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeUniversitiesProvider == null)
						{
							this.innerSqlGsCdeUniversitiesProvider = new SqlGsCdeUniversitiesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeUniversitiesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeUniversitiesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeUniversitiesProvider SqlGsCdeUniversitiesProvider
		{
			get {return GsCdeUniversitiesProvider as SqlGsCdeUniversitiesProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeViolProvider"
			
		private SqlGsCdeViolProvider innerSqlGsCdeViolProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeViol"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeViolProviderBase GsCdeViolProvider
		{
			get
			{
				if (innerSqlGsCdeViolProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeViolProvider == null)
						{
							this.innerSqlGsCdeViolProvider = new SqlGsCdeViolProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeViolProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeViolProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeViolProvider SqlGsCdeViolProvider
		{
			get {return GsCdeViolProvider as SqlGsCdeViolProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeCNodeNatureProvider"
			
		private SqlGsCodeCNodeNatureProvider innerSqlGsCodeCNodeNatureProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeCNodeNature"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeCNodeNatureProviderBase GsCodeCNodeNatureProvider
		{
			get
			{
				if (innerSqlGsCodeCNodeNatureProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeCNodeNatureProvider == null)
						{
							this.innerSqlGsCodeCNodeNatureProvider = new SqlGsCodeCNodeNatureProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeCNodeNatureProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeCNodeNatureProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeCNodeNatureProvider SqlGsCodeCNodeNatureProvider
		{
			get {return GsCodeCNodeNatureProvider as SqlGsCodeCNodeNatureProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeContactMethodProvider"
			
		private SqlGsCodeContactMethodProvider innerSqlGsCodeContactMethodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeContactMethod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeContactMethodProviderBase GsCodeContactMethodProvider
		{
			get
			{
				if (innerSqlGsCodeContactMethodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeContactMethodProvider == null)
						{
							this.innerSqlGsCodeContactMethodProvider = new SqlGsCodeContactMethodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeContactMethodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeContactMethodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeContactMethodProvider SqlGsCodeContactMethodProvider
		{
			get {return GsCodeContactMethodProvider as SqlGsCodeContactMethodProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeCurrencyProvider"
			
		private SqlGsCodeCurrencyProvider innerSqlGsCodeCurrencyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeCurrency"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeCurrencyProviderBase GsCodeCurrencyProvider
		{
			get
			{
				if (innerSqlGsCodeCurrencyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeCurrencyProvider == null)
						{
							this.innerSqlGsCodeCurrencyProvider = new SqlGsCodeCurrencyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeCurrencyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeCurrencyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeCurrencyProvider SqlGsCodeCurrencyProvider
		{
			get {return GsCodeCurrencyProvider as SqlGsCodeCurrencyProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeApprovalProvider"
			
		private SqlGsCodeApprovalProvider innerSqlGsCodeApprovalProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeApproval"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeApprovalProviderBase GsCodeApprovalProvider
		{
			get
			{
				if (innerSqlGsCodeApprovalProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeApprovalProvider == null)
						{
							this.innerSqlGsCodeApprovalProvider = new SqlGsCodeApprovalProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeApprovalProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeApprovalProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeApprovalProvider SqlGsCodeApprovalProvider
		{
			get {return GsCodeApprovalProvider as SqlGsCodeApprovalProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeDocTypeProvider"
			
		private SqlGsCodeDocTypeProvider innerSqlGsCodeDocTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeDocType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeDocTypeProviderBase GsCodeDocTypeProvider
		{
			get
			{
				if (innerSqlGsCodeDocTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeDocTypeProvider == null)
						{
							this.innerSqlGsCodeDocTypeProvider = new SqlGsCodeDocTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeDocTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeDocTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeDocTypeProvider SqlGsCodeDocTypeProvider
		{
			get {return GsCodeDocTypeProvider as SqlGsCodeDocTypeProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeApprovalListHProvider"
			
		private SqlGsCodeApprovalListHProvider innerSqlGsCodeApprovalListHProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeApprovalListH"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeApprovalListHProviderBase GsCodeApprovalListHProvider
		{
			get
			{
				if (innerSqlGsCodeApprovalListHProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeApprovalListHProvider == null)
						{
							this.innerSqlGsCodeApprovalListHProvider = new SqlGsCodeApprovalListHProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeApprovalListHProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeApprovalListHProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeApprovalListHProvider SqlGsCodeApprovalListHProvider
		{
			get {return GsCodeApprovalListHProvider as SqlGsCodeApprovalListHProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeApprovalListDProvider"
			
		private SqlGsCodeApprovalListDProvider innerSqlGsCodeApprovalListDProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeApprovalListD"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeApprovalListDProviderBase GsCodeApprovalListDProvider
		{
			get
			{
				if (innerSqlGsCodeApprovalListDProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeApprovalListDProvider == null)
						{
							this.innerSqlGsCodeApprovalListDProvider = new SqlGsCodeApprovalListDProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeApprovalListDProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeApprovalListDProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeApprovalListDProvider SqlGsCodeApprovalListDProvider
		{
			get {return GsCodeApprovalListDProvider as SqlGsCodeApprovalListDProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeApprovalFuncProvider"
			
		private SqlGsCodeApprovalFuncProvider innerSqlGsCodeApprovalFuncProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeApprovalFunc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeApprovalFuncProviderBase GsCodeApprovalFuncProvider
		{
			get
			{
				if (innerSqlGsCodeApprovalFuncProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeApprovalFuncProvider == null)
						{
							this.innerSqlGsCodeApprovalFuncProvider = new SqlGsCodeApprovalFuncProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeApprovalFuncProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeApprovalFuncProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeApprovalFuncProvider SqlGsCodeApprovalFuncProvider
		{
			get {return GsCodeApprovalFuncProvider as SqlGsCodeApprovalFuncProvider;}
		}
		
		#endregion
		
		
		#region "GsCdeWeekDayGrpProvider"
			
		private SqlGsCdeWeekDayGrpProvider innerSqlGsCdeWeekDayGrpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCdeWeekDayGrp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCdeWeekDayGrpProviderBase GsCdeWeekDayGrpProvider
		{
			get
			{
				if (innerSqlGsCdeWeekDayGrpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCdeWeekDayGrpProvider == null)
						{
							this.innerSqlGsCdeWeekDayGrpProvider = new SqlGsCdeWeekDayGrpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCdeWeekDayGrpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCdeWeekDayGrpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCdeWeekDayGrpProvider SqlGsCdeWeekDayGrpProvider
		{
			get {return GsCdeWeekDayGrpProvider as SqlGsCdeWeekDayGrpProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeExperienceProvider"
			
		private SqlSaCodeExperienceProvider innerSqlSaCodeExperienceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeExperience"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeExperienceProviderBase SaCodeExperienceProvider
		{
			get
			{
				if (innerSqlSaCodeExperienceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeExperienceProvider == null)
						{
							this.innerSqlSaCodeExperienceProvider = new SqlSaCodeExperienceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeExperienceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeExperienceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeExperienceProvider SqlSaCodeExperienceProvider
		{
			get {return SaCodeExperienceProvider as SqlSaCodeExperienceProvider;}
		}
		
		#endregion
		
		
		#region "GsCodeApprovalFacultyProvider"
			
		private SqlGsCodeApprovalFacultyProvider innerSqlGsCodeApprovalFacultyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GsCodeApprovalFaculty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GsCodeApprovalFacultyProviderBase GsCodeApprovalFacultyProvider
		{
			get
			{
				if (innerSqlGsCodeApprovalFacultyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGsCodeApprovalFacultyProvider == null)
						{
							this.innerSqlGsCodeApprovalFacultyProvider = new SqlGsCodeApprovalFacultyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGsCodeApprovalFacultyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlGsCodeApprovalFacultyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGsCodeApprovalFacultyProvider SqlGsCodeApprovalFacultyProvider
		{
			get {return GsCodeApprovalFacultyProvider as SqlGsCodeApprovalFacultyProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeHealthStateProvider"
			
		private SqlSaCodeHealthStateProvider innerSqlSaCodeHealthStateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeHealthState"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeHealthStateProviderBase SaCodeHealthStateProvider
		{
			get
			{
				if (innerSqlSaCodeHealthStateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeHealthStateProvider == null)
						{
							this.innerSqlSaCodeHealthStateProvider = new SqlSaCodeHealthStateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeHealthStateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeHealthStateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeHealthStateProvider SqlSaCodeHealthStateProvider
		{
			get {return SaCodeHealthStateProvider as SqlSaCodeHealthStateProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorTypeProvider"
			
		private SqlSpoSponsorTypeProvider innerSqlSpoSponsorTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsorType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorTypeProviderBase SpoSponsorTypeProvider
		{
			get
			{
				if (innerSqlSpoSponsorTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorTypeProvider == null)
						{
							this.innerSqlSpoSponsorTypeProvider = new SqlSpoSponsorTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorTypeProvider SqlSpoSponsorTypeProvider
		{
			get {return SpoSponsorTypeProvider as SqlSpoSponsorTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeJobActivityProvider"
			
		private SqlSaCodeJobActivityProvider innerSqlSaCodeJobActivityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeJobActivity"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeJobActivityProviderBase SaCodeJobActivityProvider
		{
			get
			{
				if (innerSqlSaCodeJobActivityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeJobActivityProvider == null)
						{
							this.innerSqlSaCodeJobActivityProvider = new SqlSaCodeJobActivityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeJobActivityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeJobActivityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeJobActivityProvider SqlSaCodeJobActivityProvider
		{
			get {return SaCodeJobActivityProvider as SqlSaCodeJobActivityProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorProvider"
			
		private SqlSpoSponsorProvider innerSqlSpoSponsorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorProviderBase SpoSponsorProvider
		{
			get
			{
				if (innerSqlSpoSponsorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorProvider == null)
						{
							this.innerSqlSpoSponsorProvider = new SqlSpoSponsorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorProvider SqlSpoSponsorProvider
		{
			get {return SpoSponsorProvider as SqlSpoSponsorProvider;}
		}
		
		#endregion
		
		
		#region "StaticViNotesProvider"
			
		private SqlStaticViNotesProvider innerSqlStaticViNotesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="StaticViNotes"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override StaticViNotesProviderBase StaticViNotesProvider
		{
			get
			{
				if (innerSqlStaticViNotesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlStaticViNotesProvider == null)
						{
							this.innerSqlStaticViNotesProvider = new SqlStaticViNotesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlStaticViNotesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlStaticViNotesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlStaticViNotesProvider SqlStaticViNotesProvider
		{
			get {return StaticViNotesProvider as SqlStaticViNotesProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorOfferProvider"
			
		private SqlSpoSponsorOfferProvider innerSqlSpoSponsorOfferProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsorOffer"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorOfferProviderBase SpoSponsorOfferProvider
		{
			get
			{
				if (innerSqlSpoSponsorOfferProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorOfferProvider == null)
						{
							this.innerSqlSpoSponsorOfferProvider = new SqlSpoSponsorOfferProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorOfferProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorOfferProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorOfferProvider SqlSpoSponsorOfferProvider
		{
			get {return SpoSponsorOfferProvider as SqlSpoSponsorOfferProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorFeeItemProvider"
			
		private SqlSpoSponsorFeeItemProvider innerSqlSpoSponsorFeeItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsorFeeItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorFeeItemProviderBase SpoSponsorFeeItemProvider
		{
			get
			{
				if (innerSqlSpoSponsorFeeItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorFeeItemProvider == null)
						{
							this.innerSqlSpoSponsorFeeItemProvider = new SqlSpoSponsorFeeItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorFeeItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorFeeItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorFeeItemProvider SqlSpoSponsorFeeItemProvider
		{
			get {return SpoSponsorFeeItemProvider as SqlSpoSponsorFeeItemProvider;}
		}
		
		#endregion
		
		
		#region "SpoOfferContinueProvider"
			
		private SqlSpoOfferContinueProvider innerSqlSpoOfferContinueProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoOfferContinue"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoOfferContinueProviderBase SpoOfferContinueProvider
		{
			get
			{
				if (innerSqlSpoOfferContinueProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoOfferContinueProvider == null)
						{
							this.innerSqlSpoOfferContinueProvider = new SqlSpoOfferContinueProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoOfferContinueProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoOfferContinueProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoOfferContinueProvider SqlSpoOfferContinueProvider
		{
			get {return SpoOfferContinueProvider as SqlSpoOfferContinueProvider;}
		}
		
		#endregion
		
		
		#region "SpoResponsiblePersonProvider"
			
		private SqlSpoResponsiblePersonProvider innerSqlSpoResponsiblePersonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoResponsiblePerson"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoResponsiblePersonProviderBase SpoResponsiblePersonProvider
		{
			get
			{
				if (innerSqlSpoResponsiblePersonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoResponsiblePersonProvider == null)
						{
							this.innerSqlSpoResponsiblePersonProvider = new SqlSpoResponsiblePersonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoResponsiblePersonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoResponsiblePersonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoResponsiblePersonProvider SqlSpoResponsiblePersonProvider
		{
			get {return SpoResponsiblePersonProvider as SqlSpoResponsiblePersonProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorStudSemesterProvider"
			
		private SqlSpoSponsorStudSemesterProvider innerSqlSpoSponsorStudSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsorStudSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorStudSemesterProviderBase SpoSponsorStudSemesterProvider
		{
			get
			{
				if (innerSqlSpoSponsorStudSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorStudSemesterProvider == null)
						{
							this.innerSqlSpoSponsorStudSemesterProvider = new SqlSpoSponsorStudSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorStudSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorStudSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorStudSemesterProvider SqlSpoSponsorStudSemesterProvider
		{
			get {return SpoSponsorStudSemesterProvider as SqlSpoSponsorStudSemesterProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorOfferExtProvider"
			
		private SqlSpoSponsorOfferExtProvider innerSqlSpoSponsorOfferExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsorOfferExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorOfferExtProviderBase SpoSponsorOfferExtProvider
		{
			get
			{
				if (innerSqlSpoSponsorOfferExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorOfferExtProvider == null)
						{
							this.innerSqlSpoSponsorOfferExtProvider = new SqlSpoSponsorOfferExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorOfferExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorOfferExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorOfferExtProvider SqlSpoSponsorOfferExtProvider
		{
			get {return SpoSponsorOfferExtProvider as SqlSpoSponsorOfferExtProvider;}
		}
		
		#endregion
		
		
		#region "SvAutoMsgTmpltProvider"
			
		private SqlSvAutoMsgTmpltProvider innerSqlSvAutoMsgTmpltProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvAutoMsgTmplt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvAutoMsgTmpltProviderBase SvAutoMsgTmpltProvider
		{
			get
			{
				if (innerSqlSvAutoMsgTmpltProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvAutoMsgTmpltProvider == null)
						{
							this.innerSqlSvAutoMsgTmpltProvider = new SqlSvAutoMsgTmpltProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvAutoMsgTmpltProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvAutoMsgTmpltProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvAutoMsgTmpltProvider SqlSvAutoMsgTmpltProvider
		{
			get {return SvAutoMsgTmpltProvider as SqlSvAutoMsgTmpltProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeCompDProvider"
			
		private SqlSvCdeCompDProvider innerSqlSvCdeCompDProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeCompD"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeCompDProviderBase SvCdeCompDProvider
		{
			get
			{
				if (innerSqlSvCdeCompDProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeCompDProvider == null)
						{
							this.innerSqlSvCdeCompDProvider = new SqlSvCdeCompDProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeCompDProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeCompDProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeCompDProvider SqlSvCdeCompDProvider
		{
			get {return SvCdeCompDProvider as SqlSvCdeCompDProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeCompHProvider"
			
		private SqlSvCdeCompHProvider innerSqlSvCdeCompHProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeCompH"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeCompHProviderBase SvCdeCompHProvider
		{
			get
			{
				if (innerSqlSvCdeCompHProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeCompHProvider == null)
						{
							this.innerSqlSvCdeCompHProvider = new SqlSvCdeCompHProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeCompHProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeCompHProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeCompHProvider SqlSvCdeCompHProvider
		{
			get {return SvCdeCompHProvider as SqlSvCdeCompHProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeLockerProvider"
			
		private SqlSvCdeLockerProvider innerSqlSvCdeLockerProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeLocker"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeLockerProviderBase SvCdeLockerProvider
		{
			get
			{
				if (innerSqlSvCdeLockerProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeLockerProvider == null)
						{
							this.innerSqlSvCdeLockerProvider = new SqlSvCdeLockerProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeLockerProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeLockerProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeLockerProvider SqlSvCdeLockerProvider
		{
			get {return SvCdeLockerProvider as SqlSvCdeLockerProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeMsgParamProvider"
			
		private SqlSvCdeMsgParamProvider innerSqlSvCdeMsgParamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeMsgParam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeMsgParamProviderBase SvCdeMsgParamProvider
		{
			get
			{
				if (innerSqlSvCdeMsgParamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeMsgParamProvider == null)
						{
							this.innerSqlSvCdeMsgParamProvider = new SqlSvCdeMsgParamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeMsgParamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeMsgParamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeMsgParamProvider SqlSvCdeMsgParamProvider
		{
			get {return SvCdeMsgParamProvider as SqlSvCdeMsgParamProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeQstnTypeProvider"
			
		private SqlSvCdeQstnTypeProvider innerSqlSvCdeQstnTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeQstnType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeQstnTypeProviderBase SvCdeQstnTypeProvider
		{
			get
			{
				if (innerSqlSvCdeQstnTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeQstnTypeProvider == null)
						{
							this.innerSqlSvCdeQstnTypeProvider = new SqlSvCdeQstnTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeQstnTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeQstnTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeQstnTypeProvider SqlSvCdeQstnTypeProvider
		{
			get {return SvCdeQstnTypeProvider as SqlSvCdeQstnTypeProvider;}
		}
		
		#endregion
		
		
		#region "SpoOfferStudExceptionProvider"
			
		private SqlSpoOfferStudExceptionProvider innerSqlSpoOfferStudExceptionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoOfferStudException"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoOfferStudExceptionProviderBase SpoOfferStudExceptionProvider
		{
			get
			{
				if (innerSqlSpoOfferStudExceptionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoOfferStudExceptionProvider == null)
						{
							this.innerSqlSpoOfferStudExceptionProvider = new SqlSpoOfferStudExceptionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoOfferStudExceptionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoOfferStudExceptionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoOfferStudExceptionProvider SqlSpoOfferStudExceptionProvider
		{
			get {return SpoOfferStudExceptionProvider as SqlSpoOfferStudExceptionProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeReqStatusProvider"
			
		private SqlSvCdeReqStatusProvider innerSqlSvCdeReqStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeReqStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeReqStatusProviderBase SvCdeReqStatusProvider
		{
			get
			{
				if (innerSqlSvCdeReqStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeReqStatusProvider == null)
						{
							this.innerSqlSvCdeReqStatusProvider = new SqlSvCdeReqStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeReqStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeReqStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeReqStatusProvider SqlSvCdeReqStatusProvider
		{
			get {return SvCdeReqStatusProvider as SqlSvCdeReqStatusProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeEvalItemHdrProvider"
			
		private SqlSvCdeEvalItemHdrProvider innerSqlSvCdeEvalItemHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeEvalItemHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeEvalItemHdrProviderBase SvCdeEvalItemHdrProvider
		{
			get
			{
				if (innerSqlSvCdeEvalItemHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeEvalItemHdrProvider == null)
						{
							this.innerSqlSvCdeEvalItemHdrProvider = new SqlSvCdeEvalItemHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeEvalItemHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeEvalItemHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeEvalItemHdrProvider SqlSvCdeEvalItemHdrProvider
		{
			get {return SvCdeEvalItemHdrProvider as SqlSvCdeEvalItemHdrProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeEvalExtProvider"
			
		private SqlSvCdeEvalExtProvider innerSqlSvCdeEvalExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeEvalExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeEvalExtProviderBase SvCdeEvalExtProvider
		{
			get
			{
				if (innerSqlSvCdeEvalExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeEvalExtProvider == null)
						{
							this.innerSqlSvCdeEvalExtProvider = new SqlSvCdeEvalExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeEvalExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeEvalExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeEvalExtProvider SqlSvCdeEvalExtProvider
		{
			get {return SvCdeEvalExtProvider as SqlSvCdeEvalExtProvider;}
		}
		
		#endregion
		
		
		#region "SpoStudFeeItemProvider"
			
		private SqlSpoStudFeeItemProvider innerSqlSpoStudFeeItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoStudFeeItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoStudFeeItemProviderBase SpoStudFeeItemProvider
		{
			get
			{
				if (innerSqlSpoStudFeeItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoStudFeeItemProvider == null)
						{
							this.innerSqlSpoStudFeeItemProvider = new SqlSpoStudFeeItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoStudFeeItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoStudFeeItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoStudFeeItemProvider SqlSpoStudFeeItemProvider
		{
			get {return SpoStudFeeItemProvider as SqlSpoStudFeeItemProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeCompTypeProvider"
			
		private SqlSvCdeCompTypeProvider innerSqlSvCdeCompTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeCompType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeCompTypeProviderBase SvCdeCompTypeProvider
		{
			get
			{
				if (innerSqlSvCdeCompTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeCompTypeProvider == null)
						{
							this.innerSqlSvCdeCompTypeProvider = new SqlSvCdeCompTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeCompTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeCompTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeCompTypeProvider SqlSvCdeCompTypeProvider
		{
			get {return SvCdeCompTypeProvider as SqlSvCdeCompTypeProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeCompReplyProvider"
			
		private SqlSvCdeCompReplyProvider innerSqlSvCdeCompReplyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeCompReply"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeCompReplyProviderBase SvCdeCompReplyProvider
		{
			get
			{
				if (innerSqlSvCdeCompReplyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeCompReplyProvider == null)
						{
							this.innerSqlSvCdeCompReplyProvider = new SqlSvCdeCompReplyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeCompReplyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeCompReplyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeCompReplyProvider SqlSvCdeCompReplyProvider
		{
			get {return SvCdeCompReplyProvider as SqlSvCdeCompReplyProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeDeviceTypeProvider"
			
		private SqlSvCdeDeviceTypeProvider innerSqlSvCdeDeviceTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeDeviceType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeDeviceTypeProviderBase SvCdeDeviceTypeProvider
		{
			get
			{
				if (innerSqlSvCdeDeviceTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeDeviceTypeProvider == null)
						{
							this.innerSqlSvCdeDeviceTypeProvider = new SqlSvCdeDeviceTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeDeviceTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeDeviceTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeDeviceTypeProvider SqlSvCdeDeviceTypeProvider
		{
			get {return SvCdeDeviceTypeProvider as SqlSvCdeDeviceTypeProvider;}
		}
		
		#endregion
		
		
		#region "SpoDepartmentProvider"
			
		private SqlSpoDepartmentProvider innerSqlSpoDepartmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoDepartment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoDepartmentProviderBase SpoDepartmentProvider
		{
			get
			{
				if (innerSqlSpoDepartmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoDepartmentProvider == null)
						{
							this.innerSqlSpoDepartmentProvider = new SqlSpoDepartmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoDepartmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoDepartmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoDepartmentProvider SqlSpoDepartmentProvider
		{
			get {return SpoDepartmentProvider as SqlSpoDepartmentProvider;}
		}
		
		#endregion
		
		
		#region "SpoSponsorStudProvider"
			
		private SqlSpoSponsorStudProvider innerSqlSpoSponsorStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoSponsorStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoSponsorStudProviderBase SpoSponsorStudProvider
		{
			get
			{
				if (innerSqlSpoSponsorStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoSponsorStudProvider == null)
						{
							this.innerSqlSpoSponsorStudProvider = new SqlSpoSponsorStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoSponsorStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoSponsorStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoSponsorStudProvider SqlSpoSponsorStudProvider
		{
			get {return SpoSponsorStudProvider as SqlSpoSponsorStudProvider;}
		}
		
		#endregion
		
		
		#region "SpoContactProvider"
			
		private SqlSpoContactProvider innerSqlSpoContactProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SpoContact"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SpoContactProviderBase SpoContactProvider
		{
			get
			{
				if (innerSqlSpoContactProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSpoContactProvider == null)
						{
							this.innerSqlSpoContactProvider = new SqlSpoContactProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSpoContactProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSpoContactProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSpoContactProvider SqlSpoContactProvider
		{
			get {return SpoContactProvider as SqlSpoContactProvider;}
		}
		
		#endregion
		
		
		#region "SeVersionProvider"
			
		private SqlSeVersionProvider innerSqlSeVersionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeVersion"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeVersionProviderBase SeVersionProvider
		{
			get
			{
				if (innerSqlSeVersionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeVersionProvider == null)
						{
							this.innerSqlSeVersionProvider = new SqlSeVersionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeVersionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeVersionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeVersionProvider SqlSeVersionProvider
		{
			get {return SeVersionProvider as SqlSeVersionProvider;}
		}
		
		#endregion
		
		
		#region "SeCodeUserTypeProvider"
			
		private SqlSeCodeUserTypeProvider innerSqlSeCodeUserTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeCodeUserType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeCodeUserTypeProviderBase SeCodeUserTypeProvider
		{
			get
			{
				if (innerSqlSeCodeUserTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeCodeUserTypeProvider == null)
						{
							this.innerSqlSeCodeUserTypeProvider = new SqlSeCodeUserTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeCodeUserTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeCodeUserTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeCodeUserTypeProvider SqlSeCodeUserTypeProvider
		{
			get {return SeCodeUserTypeProvider as SqlSeCodeUserTypeProvider;}
		}
		
		#endregion
		
		
		#region "SeControlBizTypeProvider"
			
		private SqlSeControlBizTypeProvider innerSqlSeControlBizTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeControlBizType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeControlBizTypeProviderBase SeControlBizTypeProvider
		{
			get
			{
				if (innerSqlSeControlBizTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeControlBizTypeProvider == null)
						{
							this.innerSqlSeControlBizTypeProvider = new SqlSeControlBizTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeControlBizTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeControlBizTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeControlBizTypeProvider SqlSeControlBizTypeProvider
		{
			get {return SeControlBizTypeProvider as SqlSeControlBizTypeProvider;}
		}
		
		#endregion
		
		
		#region "SeModuleProvider"
			
		private SqlSeModuleProvider innerSqlSeModuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeModule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeModuleProviderBase SeModuleProvider
		{
			get
			{
				if (innerSqlSeModuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeModuleProvider == null)
						{
							this.innerSqlSeModuleProvider = new SqlSeModuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeModuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeModuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeModuleProvider SqlSeModuleProvider
		{
			get {return SeModuleProvider as SqlSeModuleProvider;}
		}
		
		#endregion
		
		
		#region "SeControlDisableWayProvider"
			
		private SqlSeControlDisableWayProvider innerSqlSeControlDisableWayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeControlDisableWay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeControlDisableWayProviderBase SeControlDisableWayProvider
		{
			get
			{
				if (innerSqlSeControlDisableWayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeControlDisableWayProvider == null)
						{
							this.innerSqlSeControlDisableWayProvider = new SqlSeControlDisableWayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeControlDisableWayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeControlDisableWayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeControlDisableWayProvider SqlSeControlDisableWayProvider
		{
			get {return SeControlDisableWayProvider as SqlSeControlDisableWayProvider;}
		}
		
		#endregion
		
		
		#region "AsFacultyInfoProvider"
			
		private SqlAsFacultyInfoProvider innerSqlAsFacultyInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AsFacultyInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AsFacultyInfoProviderBase AsFacultyInfoProvider
		{
			get
			{
				if (innerSqlAsFacultyInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAsFacultyInfoProvider == null)
						{
							this.innerSqlAsFacultyInfoProvider = new SqlAsFacultyInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAsFacultyInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAsFacultyInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAsFacultyInfoProvider SqlAsFacultyInfoProvider
		{
			get {return AsFacultyInfoProvider as SqlAsFacultyInfoProvider;}
		}
		
		#endregion
		
		
		#region "AsCodeDegreeClassProvider"
			
		private SqlAsCodeDegreeClassProvider innerSqlAsCodeDegreeClassProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AsCodeDegreeClass"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AsCodeDegreeClassProviderBase AsCodeDegreeClassProvider
		{
			get
			{
				if (innerSqlAsCodeDegreeClassProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAsCodeDegreeClassProvider == null)
						{
							this.innerSqlAsCodeDegreeClassProvider = new SqlAsCodeDegreeClassProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAsCodeDegreeClassProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAsCodeDegreeClassProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAsCodeDegreeClassProvider SqlAsCodeDegreeClassProvider
		{
			get {return AsCodeDegreeClassProvider as SqlAsCodeDegreeClassProvider;}
		}
		
		#endregion
		
		
		#region "SeCodeUserPlaceProvider"
			
		private SqlSeCodeUserPlaceProvider innerSqlSeCodeUserPlaceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeCodeUserPlace"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeCodeUserPlaceProviderBase SeCodeUserPlaceProvider
		{
			get
			{
				if (innerSqlSeCodeUserPlaceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeCodeUserPlaceProvider == null)
						{
							this.innerSqlSeCodeUserPlaceProvider = new SqlSeCodeUserPlaceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeCodeUserPlaceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeCodeUserPlaceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeCodeUserPlaceProvider SqlSeCodeUserPlaceProvider
		{
			get {return SeCodeUserPlaceProvider as SqlSeCodeUserPlaceProvider;}
		}
		
		#endregion
		
		
		#region "SeCdeBlockTypeProvider"
			
		private SqlSeCdeBlockTypeProvider innerSqlSeCdeBlockTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeCdeBlockType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeCdeBlockTypeProviderBase SeCdeBlockTypeProvider
		{
			get
			{
				if (innerSqlSeCdeBlockTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeCdeBlockTypeProvider == null)
						{
							this.innerSqlSeCdeBlockTypeProvider = new SqlSeCdeBlockTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeCdeBlockTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeCdeBlockTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeCdeBlockTypeProvider SqlSeCdeBlockTypeProvider
		{
			get {return SeCdeBlockTypeProvider as SqlSeCdeBlockTypeProvider;}
		}
		
		#endregion
		
		
		#region "SeAccntProvider"
			
		private SqlSeAccntProvider innerSqlSeAccntProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeAccnt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeAccntProviderBase SeAccntProvider
		{
			get
			{
				if (innerSqlSeAccntProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeAccntProvider == null)
						{
							this.innerSqlSeAccntProvider = new SqlSeAccntProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeAccntProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeAccntProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeAccntProvider SqlSeAccntProvider
		{
			get {return SeAccntProvider as SqlSeAccntProvider;}
		}
		
		#endregion
		
		
		#region "SeCodeChangeTypeProvider"
			
		private SqlSeCodeChangeTypeProvider innerSqlSeCodeChangeTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeCodeChangeType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeCodeChangeTypeProviderBase SeCodeChangeTypeProvider
		{
			get
			{
				if (innerSqlSeCodeChangeTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeCodeChangeTypeProvider == null)
						{
							this.innerSqlSeCodeChangeTypeProvider = new SqlSeCodeChangeTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeCodeChangeTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeCodeChangeTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeCodeChangeTypeProvider SqlSeCodeChangeTypeProvider
		{
			get {return SeCodeChangeTypeProvider as SqlSeCodeChangeTypeProvider;}
		}
		
		#endregion
		
		
		#region "SeCodeUserJobProvider"
			
		private SqlSeCodeUserJobProvider innerSqlSeCodeUserJobProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeCodeUserJob"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeCodeUserJobProviderBase SeCodeUserJobProvider
		{
			get
			{
				if (innerSqlSeCodeUserJobProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeCodeUserJobProvider == null)
						{
							this.innerSqlSeCodeUserJobProvider = new SqlSeCodeUserJobProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeCodeUserJobProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeCodeUserJobProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeCodeUserJobProvider SqlSeCodeUserJobProvider
		{
			get {return SeCodeUserJobProvider as SqlSeCodeUserJobProvider;}
		}
		
		#endregion
		
		
		#region "SeControlTechTypeProvider"
			
		private SqlSeControlTechTypeProvider innerSqlSeControlTechTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeControlTechType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeControlTechTypeProviderBase SeControlTechTypeProvider
		{
			get
			{
				if (innerSqlSeControlTechTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeControlTechTypeProvider == null)
						{
							this.innerSqlSeControlTechTypeProvider = new SqlSeControlTechTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeControlTechTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeControlTechTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeControlTechTypeProvider SqlSeControlTechTypeProvider
		{
			get {return SeControlTechTypeProvider as SqlSeControlTechTypeProvider;}
		}
		
		#endregion
		
		
		#region "SeUserAccntProvider"
			
		private SqlSeUserAccntProvider innerSqlSeUserAccntProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUserAccnt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserAccntProviderBase SeUserAccntProvider
		{
			get
			{
				if (innerSqlSeUserAccntProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserAccntProvider == null)
						{
							this.innerSqlSeUserAccntProvider = new SqlSeUserAccntProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserAccntProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserAccntProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserAccntProvider SqlSeUserAccntProvider
		{
			get {return SeUserAccntProvider as SqlSeUserAccntProvider;}
		}
		
		#endregion
		
		
		#region "SeUserPhaseProvider"
			
		private SqlSeUserPhaseProvider innerSqlSeUserPhaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUserPhase"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserPhaseProviderBase SeUserPhaseProvider
		{
			get
			{
				if (innerSqlSeUserPhaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserPhaseProvider == null)
						{
							this.innerSqlSeUserPhaseProvider = new SqlSeUserPhaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserPhaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserPhaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserPhaseProvider SqlSeUserPhaseProvider
		{
			get {return SeUserPhaseProvider as SqlSeUserPhaseProvider;}
		}
		
		#endregion
		
		
		#region "SeFormProvider"
			
		private SqlSeFormProvider innerSqlSeFormProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeForm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeFormProviderBase SeFormProvider
		{
			get
			{
				if (innerSqlSeFormProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeFormProvider == null)
						{
							this.innerSqlSeFormProvider = new SqlSeFormProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeFormProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeFormProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeFormProvider SqlSeFormProvider
		{
			get {return SeFormProvider as SqlSeFormProvider;}
		}
		
		#endregion
		
		
		#region "SeUserCrsAssessProvider"
			
		private SqlSeUserCrsAssessProvider innerSqlSeUserCrsAssessProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUserCrsAssess"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserCrsAssessProviderBase SeUserCrsAssessProvider
		{
			get
			{
				if (innerSqlSeUserCrsAssessProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserCrsAssessProvider == null)
						{
							this.innerSqlSeUserCrsAssessProvider = new SqlSeUserCrsAssessProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserCrsAssessProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserCrsAssessProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserCrsAssessProvider SqlSeUserCrsAssessProvider
		{
			get {return SeUserCrsAssessProvider as SqlSeUserCrsAssessProvider;}
		}
		
		#endregion
		
		
		#region "SeUserAccntDegProvider"
			
		private SqlSeUserAccntDegProvider innerSqlSeUserAccntDegProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUserAccntDeg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserAccntDegProviderBase SeUserAccntDegProvider
		{
			get
			{
				if (innerSqlSeUserAccntDegProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserAccntDegProvider == null)
						{
							this.innerSqlSeUserAccntDegProvider = new SqlSeUserAccntDegProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserAccntDegProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserAccntDegProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserAccntDegProvider SqlSeUserAccntDegProvider
		{
			get {return SeUserAccntDegProvider as SqlSeUserAccntDegProvider;}
		}
		
		#endregion
		
		
		#region "SeUserProvider"
			
		private SqlSeUserProvider innerSqlSeUserProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUser"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserProviderBase SeUserProvider
		{
			get
			{
				if (innerSqlSeUserProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserProvider == null)
						{
							this.innerSqlSeUserProvider = new SqlSeUserProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserProvider SqlSeUserProvider
		{
			get {return SeUserProvider as SqlSeUserProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeSrvyTypeProvider"
			
		private SqlSvCdeSrvyTypeProvider innerSqlSvCdeSrvyTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeSrvyType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeSrvyTypeProviderBase SvCdeSrvyTypeProvider
		{
			get
			{
				if (innerSqlSvCdeSrvyTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeSrvyTypeProvider == null)
						{
							this.innerSqlSvCdeSrvyTypeProvider = new SqlSvCdeSrvyTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeSrvyTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeSrvyTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeSrvyTypeProvider SqlSvCdeSrvyTypeProvider
		{
			get {return SvCdeSrvyTypeProvider as SqlSvCdeSrvyTypeProvider;}
		}
		
		#endregion
		
		
		#region "SeUserAccntFormDiffProvider"
			
		private SqlSeUserAccntFormDiffProvider innerSqlSeUserAccntFormDiffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUserAccntFormDiff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserAccntFormDiffProviderBase SeUserAccntFormDiffProvider
		{
			get
			{
				if (innerSqlSeUserAccntFormDiffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserAccntFormDiffProvider == null)
						{
							this.innerSqlSeUserAccntFormDiffProvider = new SqlSeUserAccntFormDiffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserAccntFormDiffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserAccntFormDiffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserAccntFormDiffProvider SqlSeUserAccntFormDiffProvider
		{
			get {return SeUserAccntFormDiffProvider as SqlSeUserAccntFormDiffProvider;}
		}
		
		#endregion
		
		
		#region "SeFormControlProvider"
			
		private SqlSeFormControlProvider innerSqlSeFormControlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeFormControl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeFormControlProviderBase SeFormControlProvider
		{
			get
			{
				if (innerSqlSeFormControlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeFormControlProvider == null)
						{
							this.innerSqlSeFormControlProvider = new SqlSeFormControlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeFormControlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeFormControlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeFormControlProvider SqlSeFormControlProvider
		{
			get {return SeFormControlProvider as SqlSeFormControlProvider;}
		}
		
		#endregion
		
		
		#region "SeBlockTransProvider"
			
		private SqlSeBlockTransProvider innerSqlSeBlockTransProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeBlockTrans"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeBlockTransProviderBase SeBlockTransProvider
		{
			get
			{
				if (innerSqlSeBlockTransProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeBlockTransProvider == null)
						{
							this.innerSqlSeBlockTransProvider = new SqlSeBlockTransProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeBlockTransProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeBlockTransProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeBlockTransProvider SqlSeBlockTransProvider
		{
			get {return SeBlockTransProvider as SqlSeBlockTransProvider;}
		}
		
		#endregion
		
		
		#region "SeUserAccntControlDiffProvider"
			
		private SqlSeUserAccntControlDiffProvider innerSqlSeUserAccntControlDiffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeUserAccntControlDiff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeUserAccntControlDiffProviderBase SeUserAccntControlDiffProvider
		{
			get
			{
				if (innerSqlSeUserAccntControlDiffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeUserAccntControlDiffProvider == null)
						{
							this.innerSqlSeUserAccntControlDiffProvider = new SqlSeUserAccntControlDiffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeUserAccntControlDiffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeUserAccntControlDiffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeUserAccntControlDiffProvider SqlSeUserAccntControlDiffProvider
		{
			get {return SeUserAccntControlDiffProvider as SqlSeUserAccntControlDiffProvider;}
		}
		
		#endregion
		
		
		#region "SeStudTabControlProvider"
			
		private SqlSeStudTabControlProvider innerSqlSeStudTabControlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeStudTabControl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeStudTabControlProviderBase SeStudTabControlProvider
		{
			get
			{
				if (innerSqlSeStudTabControlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeStudTabControlProvider == null)
						{
							this.innerSqlSeStudTabControlProvider = new SqlSeStudTabControlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeStudTabControlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeStudTabControlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeStudTabControlProvider SqlSeStudTabControlProvider
		{
			get {return SeStudTabControlProvider as SqlSeStudTabControlProvider;}
		}
		
		#endregion
		
		
		#region "SeStudTabUserTypeControlProvider"
			
		private SqlSeStudTabUserTypeControlProvider innerSqlSeStudTabUserTypeControlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeStudTabUserTypeControl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeStudTabUserTypeControlProviderBase SeStudTabUserTypeControlProvider
		{
			get
			{
				if (innerSqlSeStudTabUserTypeControlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeStudTabUserTypeControlProvider == null)
						{
							this.innerSqlSeStudTabUserTypeControlProvider = new SqlSeStudTabUserTypeControlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeStudTabUserTypeControlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeStudTabUserTypeControlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeStudTabUserTypeControlProvider SqlSeStudTabUserTypeControlProvider
		{
			get {return SeStudTabUserTypeControlProvider as SqlSeStudTabUserTypeControlProvider;}
		}
		
		#endregion
		
		
		#region "SvCdeTaskStatusProvider"
			
		private SqlSvCdeTaskStatusProvider innerSqlSvCdeTaskStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCdeTaskStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCdeTaskStatusProviderBase SvCdeTaskStatusProvider
		{
			get
			{
				if (innerSqlSvCdeTaskStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCdeTaskStatusProvider == null)
						{
							this.innerSqlSvCdeTaskStatusProvider = new SqlSvCdeTaskStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCdeTaskStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCdeTaskStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCdeTaskStatusProvider SqlSvCdeTaskStatusProvider
		{
			get {return SvCdeTaskStatusProvider as SqlSvCdeTaskStatusProvider;}
		}
		
		#endregion
		
		
		#region "SvCodeEvalItemProvider"
			
		private SqlSvCodeEvalItemProvider innerSqlSvCodeEvalItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCodeEvalItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCodeEvalItemProviderBase SvCodeEvalItemProvider
		{
			get
			{
				if (innerSqlSvCodeEvalItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCodeEvalItemProvider == null)
						{
							this.innerSqlSvCodeEvalItemProvider = new SqlSvCodeEvalItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCodeEvalItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCodeEvalItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCodeEvalItemProvider SqlSvCodeEvalItemProvider
		{
			get {return SvCodeEvalItemProvider as SqlSvCodeEvalItemProvider;}
		}
		
		#endregion
		
		
		#region "SysFormControlProvider"
			
		private SqlSysFormControlProvider innerSqlSysFormControlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SysFormControl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SysFormControlProviderBase SysFormControlProvider
		{
			get
			{
				if (innerSqlSysFormControlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSysFormControlProvider == null)
						{
							this.innerSqlSysFormControlProvider = new SqlSysFormControlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSysFormControlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSysFormControlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSysFormControlProvider SqlSysFormControlProvider
		{
			get {return SysFormControlProvider as SqlSysFormControlProvider;}
		}
		
		#endregion
		
		
		#region "SysMessagesProvider"
			
		private SqlSysMessagesProvider innerSqlSysMessagesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SysMessages"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SysMessagesProviderBase SysMessagesProvider
		{
			get
			{
				if (innerSqlSysMessagesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSysMessagesProvider == null)
						{
							this.innerSqlSysMessagesProvider = new SqlSysMessagesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSysMessagesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSysMessagesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSysMessagesProvider SqlSysMessagesProvider
		{
			get {return SysMessagesProvider as SqlSysMessagesProvider;}
		}
		
		#endregion
		
		
		#region "SysParamProvider"
			
		private SqlSysParamProvider innerSqlSysParamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SysParam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SysParamProviderBase SysParamProvider
		{
			get
			{
				if (innerSqlSysParamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSysParamProvider == null)
						{
							this.innerSqlSysParamProvider = new SqlSysParamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSysParamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSysParamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSysParamProvider SqlSysParamProvider
		{
			get {return SysParamProvider as SqlSysParamProvider;}
		}
		
		#endregion
		
		
		#region "SysServiceProvider"
			
		private SqlSysServiceProvider innerSqlSysServiceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SysService"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SysServiceProviderBase SysServiceProvider
		{
			get
			{
				if (innerSqlSysServiceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSysServiceProvider == null)
						{
							this.innerSqlSysServiceProvider = new SqlSysServiceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSysServiceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSysServiceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSysServiceProvider SqlSysServiceProvider
		{
			get {return SysServiceProvider as SqlSysServiceProvider;}
		}
		
		#endregion
		
		
		#region "SystemParamProvider"
			
		private SqlSystemParamProvider innerSqlSystemParamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SystemParam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SystemParamProviderBase SystemParamProvider
		{
			get
			{
				if (innerSqlSystemParamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSystemParamProvider == null)
						{
							this.innerSqlSystemParamProvider = new SqlSystemParamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSystemParamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSystemParamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSystemParamProvider SqlSystemParamProvider
		{
			get {return SystemParamProvider as SqlSystemParamProvider;}
		}
		
		#endregion
		
		
		#region "SysFormProvider"
			
		private SqlSysFormProvider innerSqlSysFormProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SysForm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SysFormProviderBase SysFormProvider
		{
			get
			{
				if (innerSqlSysFormProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSysFormProvider == null)
						{
							this.innerSqlSysFormProvider = new SqlSysFormProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSysFormProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSysFormProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSysFormProvider SqlSysFormProvider
		{
			get {return SysFormProvider as SqlSysFormProvider;}
		}
		
		#endregion
		
		
		#region "AdmAdmissionBandProvider"
			
		private SqlAdmAdmissionBandProvider innerSqlAdmAdmissionBandProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAdmissionBand"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAdmissionBandProviderBase AdmAdmissionBandProvider
		{
			get
			{
				if (innerSqlAdmAdmissionBandProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAdmissionBandProvider == null)
						{
							this.innerSqlAdmAdmissionBandProvider = new SqlAdmAdmissionBandProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAdmissionBandProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAdmissionBandProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAdmissionBandProvider SqlAdmAdmissionBandProvider
		{
			get {return AdmAdmissionBandProvider as SqlAdmAdmissionBandProvider;}
		}
		
		#endregion
		
		
		#region "SvUserTaskProvider"
			
		private SqlSvUserTaskProvider innerSqlSvUserTaskProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvUserTask"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvUserTaskProviderBase SvUserTaskProvider
		{
			get
			{
				if (innerSqlSvUserTaskProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvUserTaskProvider == null)
						{
							this.innerSqlSvUserTaskProvider = new SqlSvUserTaskProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvUserTaskProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvUserTaskProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvUserTaskProvider SqlSvUserTaskProvider
		{
			get {return SvUserTaskProvider as SqlSvUserTaskProvider;}
		}
		
		#endregion
		
		
		#region "SvUserMobTokenProvider"
			
		private SqlSvUserMobTokenProvider innerSqlSvUserMobTokenProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvUserMobToken"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvUserMobTokenProviderBase SvUserMobTokenProvider
		{
			get
			{
				if (innerSqlSvUserMobTokenProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvUserMobTokenProvider == null)
						{
							this.innerSqlSvUserMobTokenProvider = new SqlSvUserMobTokenProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvUserMobTokenProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvUserMobTokenProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvUserMobTokenProvider SqlSvUserMobTokenProvider
		{
			get {return SvUserMobTokenProvider as SqlSvUserMobTokenProvider;}
		}
		
		#endregion
		
		
		#region "SvStudStaffEvalExtProvider"
			
		private SqlSvStudStaffEvalExtProvider innerSqlSvStudStaffEvalExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudStaffEvalExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudStaffEvalExtProviderBase SvStudStaffEvalExtProvider
		{
			get
			{
				if (innerSqlSvStudStaffEvalExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudStaffEvalExtProvider == null)
						{
							this.innerSqlSvStudStaffEvalExtProvider = new SqlSvStudStaffEvalExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudStaffEvalExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudStaffEvalExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudStaffEvalExtProvider SqlSvStudStaffEvalExtProvider
		{
			get {return SvStudStaffEvalExtProvider as SqlSvStudStaffEvalExtProvider;}
		}
		
		#endregion
		
		
		#region "SvUserRefreshTokenProvider"
			
		private SqlSvUserRefreshTokenProvider innerSqlSvUserRefreshTokenProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvUserRefreshToken"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvUserRefreshTokenProviderBase SvUserRefreshTokenProvider
		{
			get
			{
				if (innerSqlSvUserRefreshTokenProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvUserRefreshTokenProvider == null)
						{
							this.innerSqlSvUserRefreshTokenProvider = new SqlSvUserRefreshTokenProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvUserRefreshTokenProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvUserRefreshTokenProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvUserRefreshTokenProvider SqlSvUserRefreshTokenProvider
		{
			get {return SvUserRefreshTokenProvider as SqlSvUserRefreshTokenProvider;}
		}
		
		#endregion
		
		
		#region "TrnsCdeBusProvider"
			
		private SqlTrnsCdeBusProvider innerSqlTrnsCdeBusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsCdeBus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsCdeBusProviderBase TrnsCdeBusProvider
		{
			get
			{
				if (innerSqlTrnsCdeBusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsCdeBusProvider == null)
						{
							this.innerSqlTrnsCdeBusProvider = new SqlTrnsCdeBusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsCdeBusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsCdeBusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsCdeBusProvider SqlTrnsCdeBusProvider
		{
			get {return TrnsCdeBusProvider as SqlTrnsCdeBusProvider;}
		}
		
		#endregion
		
		
		#region "SvUserMessageProvider"
			
		private SqlSvUserMessageProvider innerSqlSvUserMessageProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvUserMessage"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvUserMessageProviderBase SvUserMessageProvider
		{
			get
			{
				if (innerSqlSvUserMessageProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvUserMessageProvider == null)
						{
							this.innerSqlSvUserMessageProvider = new SqlSvUserMessageProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvUserMessageProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvUserMessageProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvUserMessageProvider SqlSvUserMessageProvider
		{
			get {return SvUserMessageProvider as SqlSvUserMessageProvider;}
		}
		
		#endregion
		
		
		#region "SvCourseEvalProvider"
			
		private SqlSvCourseEvalProvider innerSqlSvCourseEvalProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCourseEval"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCourseEvalProviderBase SvCourseEvalProvider
		{
			get
			{
				if (innerSqlSvCourseEvalProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCourseEvalProvider == null)
						{
							this.innerSqlSvCourseEvalProvider = new SqlSvCourseEvalProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCourseEvalProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCourseEvalProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCourseEvalProvider SqlSvCourseEvalProvider
		{
			get {return SvCourseEvalProvider as SqlSvCourseEvalProvider;}
		}
		
		#endregion
		
		
		#region "TrnsCdeColorProvider"
			
		private SqlTrnsCdeColorProvider innerSqlTrnsCdeColorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsCdeColor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsCdeColorProviderBase TrnsCdeColorProvider
		{
			get
			{
				if (innerSqlTrnsCdeColorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsCdeColorProvider == null)
						{
							this.innerSqlTrnsCdeColorProvider = new SqlTrnsCdeColorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsCdeColorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsCdeColorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsCdeColorProvider SqlTrnsCdeColorProvider
		{
			get {return TrnsCdeColorProvider as SqlTrnsCdeColorProvider;}
		}
		
		#endregion
		
		
		#region "WfCdeFunctionProvider"
			
		private SqlWfCdeFunctionProvider innerSqlWfCdeFunctionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="WfCdeFunction"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override WfCdeFunctionProviderBase WfCdeFunctionProvider
		{
			get
			{
				if (innerSqlWfCdeFunctionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlWfCdeFunctionProvider == null)
						{
							this.innerSqlWfCdeFunctionProvider = new SqlWfCdeFunctionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlWfCdeFunctionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlWfCdeFunctionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlWfCdeFunctionProvider SqlWfCdeFunctionProvider
		{
			get {return WfCdeFunctionProvider as SqlWfCdeFunctionProvider;}
		}
		
		#endregion
		
		
		#region "TrnsCdeDrvrProvider"
			
		private SqlTrnsCdeDrvrProvider innerSqlTrnsCdeDrvrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsCdeDrvr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsCdeDrvrProviderBase TrnsCdeDrvrProvider
		{
			get
			{
				if (innerSqlTrnsCdeDrvrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsCdeDrvrProvider == null)
						{
							this.innerSqlTrnsCdeDrvrProvider = new SqlTrnsCdeDrvrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsCdeDrvrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsCdeDrvrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsCdeDrvrProvider SqlTrnsCdeDrvrProvider
		{
			get {return TrnsCdeDrvrProvider as SqlTrnsCdeDrvrProvider;}
		}
		
		#endregion
		
		
		#region "SvCodeRatingSchmProvider"
			
		private SqlSvCodeRatingSchmProvider innerSqlSvCodeRatingSchmProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCodeRatingSchm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCodeRatingSchmProviderBase SvCodeRatingSchmProvider
		{
			get
			{
				if (innerSqlSvCodeRatingSchmProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCodeRatingSchmProvider == null)
						{
							this.innerSqlSvCodeRatingSchmProvider = new SqlSvCodeRatingSchmProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCodeRatingSchmProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCodeRatingSchmProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCodeRatingSchmProvider SqlSvCodeRatingSchmProvider
		{
			get {return SvCodeRatingSchmProvider as SqlSvCodeRatingSchmProvider;}
		}
		
		#endregion
		
		
		#region "TrnsLineProvider"
			
		private SqlTrnsLineProvider innerSqlTrnsLineProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsLine"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsLineProviderBase TrnsLineProvider
		{
			get
			{
				if (innerSqlTrnsLineProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsLineProvider == null)
						{
							this.innerSqlTrnsLineProvider = new SqlTrnsLineProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsLineProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsLineProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsLineProvider SqlTrnsLineProvider
		{
			get {return TrnsLineProvider as SqlTrnsLineProvider;}
		}
		
		#endregion
		
		
		#region "TrnsCdeStopProvider"
			
		private SqlTrnsCdeStopProvider innerSqlTrnsCdeStopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsCdeStop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsCdeStopProviderBase TrnsCdeStopProvider
		{
			get
			{
				if (innerSqlTrnsCdeStopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsCdeStopProvider == null)
						{
							this.innerSqlTrnsCdeStopProvider = new SqlTrnsCdeStopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsCdeStopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsCdeStopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsCdeStopProvider SqlTrnsCdeStopProvider
		{
			get {return TrnsCdeStopProvider as SqlTrnsCdeStopProvider;}
		}
		
		#endregion
		
		
		#region "SvCourseEvalExtProvider"
			
		private SqlSvCourseEvalExtProvider innerSqlSvCourseEvalExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCourseEvalExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCourseEvalExtProviderBase SvCourseEvalExtProvider
		{
			get
			{
				if (innerSqlSvCourseEvalExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCourseEvalExtProvider == null)
						{
							this.innerSqlSvCourseEvalExtProvider = new SqlSvCourseEvalExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCourseEvalExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCourseEvalExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCourseEvalExtProvider SqlSvCourseEvalExtProvider
		{
			get {return SvCourseEvalExtProvider as SqlSvCourseEvalExtProvider;}
		}
		
		#endregion
		
		
		#region "WfCdeActionProvider"
			
		private SqlWfCdeActionProvider innerSqlWfCdeActionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="WfCdeAction"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override WfCdeActionProviderBase WfCdeActionProvider
		{
			get
			{
				if (innerSqlWfCdeActionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlWfCdeActionProvider == null)
						{
							this.innerSqlWfCdeActionProvider = new SqlWfCdeActionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlWfCdeActionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlWfCdeActionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlWfCdeActionProvider SqlWfCdeActionProvider
		{
			get {return WfCdeActionProvider as SqlWfCdeActionProvider;}
		}
		
		#endregion
		
		
		#region "TrnsLineStopProvider"
			
		private SqlTrnsLineStopProvider innerSqlTrnsLineStopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsLineStop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsLineStopProviderBase TrnsLineStopProvider
		{
			get
			{
				if (innerSqlTrnsLineStopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsLineStopProvider == null)
						{
							this.innerSqlTrnsLineStopProvider = new SqlTrnsLineStopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsLineStopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsLineStopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsLineStopProvider SqlTrnsLineStopProvider
		{
			get {return TrnsLineStopProvider as SqlTrnsLineStopProvider;}
		}
		
		#endregion
		
		
		#region "UsrTopLinkProvider"
			
		private SqlUsrTopLinkProvider innerSqlUsrTopLinkProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="UsrTopLink"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UsrTopLinkProviderBase UsrTopLinkProvider
		{
			get
			{
				if (innerSqlUsrTopLinkProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUsrTopLinkProvider == null)
						{
							this.innerSqlUsrTopLinkProvider = new SqlUsrTopLinkProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUsrTopLinkProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlUsrTopLinkProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUsrTopLinkProvider SqlUsrTopLinkProvider
		{
			get {return UsrTopLinkProvider as SqlUsrTopLinkProvider;}
		}
		
		#endregion
		
		
		#region "TrnsStudCarStkrProvider"
			
		private SqlTrnsStudCarStkrProvider innerSqlTrnsStudCarStkrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsStudCarStkr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsStudCarStkrProviderBase TrnsStudCarStkrProvider
		{
			get
			{
				if (innerSqlTrnsStudCarStkrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsStudCarStkrProvider == null)
						{
							this.innerSqlTrnsStudCarStkrProvider = new SqlTrnsStudCarStkrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsStudCarStkrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsStudCarStkrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsStudCarStkrProvider SqlTrnsStudCarStkrProvider
		{
			get {return TrnsStudCarStkrProvider as SqlTrnsStudCarStkrProvider;}
		}
		
		#endregion
		
		
		#region "SvStudStaffEvalProvider"
			
		private SqlSvStudStaffEvalProvider innerSqlSvStudStaffEvalProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudStaffEval"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudStaffEvalProviderBase SvStudStaffEvalProvider
		{
			get
			{
				if (innerSqlSvStudStaffEvalProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudStaffEvalProvider == null)
						{
							this.innerSqlSvStudStaffEvalProvider = new SqlSvStudStaffEvalProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudStaffEvalProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudStaffEvalProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudStaffEvalProvider SqlSvStudStaffEvalProvider
		{
			get {return SvStudStaffEvalProvider as SqlSvStudStaffEvalProvider;}
		}
		
		#endregion
		
		
		#region "TrnsStudReqProvider"
			
		private SqlTrnsStudReqProvider innerSqlTrnsStudReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrnsStudReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrnsStudReqProviderBase TrnsStudReqProvider
		{
			get
			{
				if (innerSqlTrnsStudReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrnsStudReqProvider == null)
						{
							this.innerSqlTrnsStudReqProvider = new SqlTrnsStudReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrnsStudReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTrnsStudReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrnsStudReqProvider SqlTrnsStudReqProvider
		{
			get {return TrnsStudReqProvider as SqlTrnsStudReqProvider;}
		}
		
		#endregion
		
		
		#region "SvStudPollProvider"
			
		private SqlSvStudPollProvider innerSqlSvStudPollProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudPoll"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudPollProviderBase SvStudPollProvider
		{
			get
			{
				if (innerSqlSvStudPollProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudPollProvider == null)
						{
							this.innerSqlSvStudPollProvider = new SqlSvStudPollProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudPollProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudPollProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudPollProvider SqlSvStudPollProvider
		{
			get {return SvStudPollProvider as SqlSvStudPollProvider;}
		}
		
		#endregion
		
		
		#region "SvStudLockerReqProvider"
			
		private SqlSvStudLockerReqProvider innerSqlSvStudLockerReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudLockerReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudLockerReqProviderBase SvStudLockerReqProvider
		{
			get
			{
				if (innerSqlSvStudLockerReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudLockerReqProvider == null)
						{
							this.innerSqlSvStudLockerReqProvider = new SqlSvStudLockerReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudLockerReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudLockerReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudLockerReqProvider SqlSvStudLockerReqProvider
		{
			get {return SvStudLockerReqProvider as SqlSvStudLockerReqProvider;}
		}
		
		#endregion
		
		
		#region "SvSrvyHdrProvider"
			
		private SqlSvSrvyHdrProvider innerSqlSvSrvyHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvSrvyHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvSrvyHdrProviderBase SvSrvyHdrProvider
		{
			get
			{
				if (innerSqlSvSrvyHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvSrvyHdrProvider == null)
						{
							this.innerSqlSvSrvyHdrProvider = new SqlSvSrvyHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvSrvyHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvSrvyHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvSrvyHdrProvider SqlSvSrvyHdrProvider
		{
			get {return SvSrvyHdrProvider as SqlSvSrvyHdrProvider;}
		}
		
		#endregion
		
		
		#region "SvPollHdrProvider"
			
		private SqlSvPollHdrProvider innerSqlSvPollHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvPollHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvPollHdrProviderBase SvPollHdrProvider
		{
			get
			{
				if (innerSqlSvPollHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvPollHdrProvider == null)
						{
							this.innerSqlSvPollHdrProvider = new SqlSvPollHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvPollHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvPollHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvPollHdrProvider SqlSvPollHdrProvider
		{
			get {return SvPollHdrProvider as SqlSvPollHdrProvider;}
		}
		
		#endregion
		
		
		#region "SvSrvyAnswrProvider"
			
		private SqlSvSrvyAnswrProvider innerSqlSvSrvyAnswrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvSrvyAnswr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvSrvyAnswrProviderBase SvSrvyAnswrProvider
		{
			get
			{
				if (innerSqlSvSrvyAnswrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvSrvyAnswrProvider == null)
						{
							this.innerSqlSvSrvyAnswrProvider = new SqlSvSrvyAnswrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvSrvyAnswrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvSrvyAnswrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvSrvyAnswrProvider SqlSvSrvyAnswrProvider
		{
			get {return SvSrvyAnswrProvider as SqlSvSrvyAnswrProvider;}
		}
		
		#endregion
		
		
		#region "SvPollDtlProvider"
			
		private SqlSvPollDtlProvider innerSqlSvPollDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvPollDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvPollDtlProviderBase SvPollDtlProvider
		{
			get
			{
				if (innerSqlSvPollDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvPollDtlProvider == null)
						{
							this.innerSqlSvPollDtlProvider = new SqlSvPollDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvPollDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvPollDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvPollDtlProvider SqlSvPollDtlProvider
		{
			get {return SvPollDtlProvider as SqlSvPollDtlProvider;}
		}
		
		#endregion
		
		
		#region "SvSrvyRespondQstnProvider"
			
		private SqlSvSrvyRespondQstnProvider innerSqlSvSrvyRespondQstnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvSrvyRespondQstn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvSrvyRespondQstnProviderBase SvSrvyRespondQstnProvider
		{
			get
			{
				if (innerSqlSvSrvyRespondQstnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvSrvyRespondQstnProvider == null)
						{
							this.innerSqlSvSrvyRespondQstnProvider = new SqlSvSrvyRespondQstnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvSrvyRespondQstnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvSrvyRespondQstnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvSrvyRespondQstnProvider SqlSvSrvyRespondQstnProvider
		{
			get {return SvSrvyRespondQstnProvider as SqlSvSrvyRespondQstnProvider;}
		}
		
		#endregion
		
		
		#region "SvMsgTmpltParamProvider"
			
		private SqlSvMsgTmpltParamProvider innerSqlSvMsgTmpltParamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvMsgTmpltParam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvMsgTmpltParamProviderBase SvMsgTmpltParamProvider
		{
			get
			{
				if (innerSqlSvMsgTmpltParamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvMsgTmpltParamProvider == null)
						{
							this.innerSqlSvMsgTmpltParamProvider = new SqlSvMsgTmpltParamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvMsgTmpltParamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvMsgTmpltParamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvMsgTmpltParamProvider SqlSvMsgTmpltParamProvider
		{
			get {return SvMsgTmpltParamProvider as SqlSvMsgTmpltParamProvider;}
		}
		
		#endregion
		
		
		#region "SvMessageSendPrvProvider"
			
		private SqlSvMessageSendPrvProvider innerSqlSvMessageSendPrvProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvMessageSendPrv"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvMessageSendPrvProviderBase SvMessageSendPrvProvider
		{
			get
			{
				if (innerSqlSvMessageSendPrvProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvMessageSendPrvProvider == null)
						{
							this.innerSqlSvMessageSendPrvProvider = new SqlSvMessageSendPrvProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvMessageSendPrvProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvMessageSendPrvProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvMessageSendPrvProvider SqlSvMessageSendPrvProvider
		{
			get {return SvMessageSendPrvProvider as SqlSvMessageSendPrvProvider;}
		}
		
		#endregion
		
		
		#region "SvCodeRatingSchmDtlProvider"
			
		private SqlSvCodeRatingSchmDtlProvider innerSqlSvCodeRatingSchmDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCodeRatingSchmDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCodeRatingSchmDtlProviderBase SvCodeRatingSchmDtlProvider
		{
			get
			{
				if (innerSqlSvCodeRatingSchmDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCodeRatingSchmDtlProvider == null)
						{
							this.innerSqlSvCodeRatingSchmDtlProvider = new SqlSvCodeRatingSchmDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCodeRatingSchmDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCodeRatingSchmDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCodeRatingSchmDtlProvider SqlSvCodeRatingSchmDtlProvider
		{
			get {return SvCodeRatingSchmDtlProvider as SqlSvCodeRatingSchmDtlProvider;}
		}
		
		#endregion
		
		
		#region "SvCourseEvalItemProvider"
			
		private SqlSvCourseEvalItemProvider innerSqlSvCourseEvalItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvCourseEvalItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvCourseEvalItemProviderBase SvCourseEvalItemProvider
		{
			get
			{
				if (innerSqlSvCourseEvalItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvCourseEvalItemProvider == null)
						{
							this.innerSqlSvCourseEvalItemProvider = new SqlSvCourseEvalItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvCourseEvalItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvCourseEvalItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvCourseEvalItemProvider SqlSvCourseEvalItemProvider
		{
			get {return SvCourseEvalItemProvider as SqlSvCourseEvalItemProvider;}
		}
		
		#endregion
		
		
		#region "SvLecNoteProvider"
			
		private SqlSvLecNoteProvider innerSqlSvLecNoteProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvLecNote"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvLecNoteProviderBase SvLecNoteProvider
		{
			get
			{
				if (innerSqlSvLecNoteProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvLecNoteProvider == null)
						{
							this.innerSqlSvLecNoteProvider = new SqlSvLecNoteProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvLecNoteProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvLecNoteProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvLecNoteProvider SqlSvLecNoteProvider
		{
			get {return SvLecNoteProvider as SqlSvLecNoteProvider;}
		}
		
		#endregion
		
		
		#region "SvMessageProvider"
			
		private SqlSvMessageProvider innerSqlSvMessageProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvMessage"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvMessageProviderBase SvMessageProvider
		{
			get
			{
				if (innerSqlSvMessageProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvMessageProvider == null)
						{
							this.innerSqlSvMessageProvider = new SqlSvMessageProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvMessageProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvMessageProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvMessageProvider SqlSvMessageProvider
		{
			get {return SvMessageProvider as SqlSvMessageProvider;}
		}
		
		#endregion
		
		
		#region "SvSrvyQstnProvider"
			
		private SqlSvSrvyQstnProvider innerSqlSvSrvyQstnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvSrvyQstn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvSrvyQstnProviderBase SvSrvyQstnProvider
		{
			get
			{
				if (innerSqlSvSrvyQstnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvSrvyQstnProvider == null)
						{
							this.innerSqlSvSrvyQstnProvider = new SqlSvSrvyQstnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvSrvyQstnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvSrvyQstnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvSrvyQstnProvider SqlSvSrvyQstnProvider
		{
			get {return SvSrvyQstnProvider as SqlSvSrvyQstnProvider;}
		}
		
		#endregion
		
		
		#region "SvStudCompProvider"
			
		private SqlSvStudCompProvider innerSqlSvStudCompProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudComp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudCompProviderBase SvStudCompProvider
		{
			get
			{
				if (innerSqlSvStudCompProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudCompProvider == null)
						{
							this.innerSqlSvStudCompProvider = new SqlSvStudCompProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudCompProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudCompProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudCompProvider SqlSvStudCompProvider
		{
			get {return SvStudCompProvider as SqlSvStudCompProvider;}
		}
		
		#endregion
		
		
		#region "SvSrvyRespondAnswrProvider"
			
		private SqlSvSrvyRespondAnswrProvider innerSqlSvSrvyRespondAnswrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvSrvyRespondAnswr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvSrvyRespondAnswrProviderBase SvSrvyRespondAnswrProvider
		{
			get
			{
				if (innerSqlSvSrvyRespondAnswrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvSrvyRespondAnswrProvider == null)
						{
							this.innerSqlSvSrvyRespondAnswrProvider = new SqlSvSrvyRespondAnswrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvSrvyRespondAnswrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvSrvyRespondAnswrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvSrvyRespondAnswrProvider SqlSvSrvyRespondAnswrProvider
		{
			get {return SvSrvyRespondAnswrProvider as SqlSvSrvyRespondAnswrProvider;}
		}
		
		#endregion
		
		
		#region "SvStudCourseEvalProvider"
			
		private SqlSvStudCourseEvalProvider innerSqlSvStudCourseEvalProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudCourseEval"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudCourseEvalProviderBase SvStudCourseEvalProvider
		{
			get
			{
				if (innerSqlSvStudCourseEvalProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudCourseEvalProvider == null)
						{
							this.innerSqlSvStudCourseEvalProvider = new SqlSvStudCourseEvalProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudCourseEvalProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudCourseEvalProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudCourseEvalProvider SqlSvStudCourseEvalProvider
		{
			get {return SvStudCourseEvalProvider as SqlSvStudCourseEvalProvider;}
		}
		
		#endregion
		
		
		#region "SvStudAskAdvProvider"
			
		private SqlSvStudAskAdvProvider innerSqlSvStudAskAdvProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudAskAdv"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudAskAdvProviderBase SvStudAskAdvProvider
		{
			get
			{
				if (innerSqlSvStudAskAdvProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudAskAdvProvider == null)
						{
							this.innerSqlSvStudAskAdvProvider = new SqlSvStudAskAdvProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudAskAdvProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudAskAdvProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudAskAdvProvider SqlSvStudAskAdvProvider
		{
			get {return SvStudAskAdvProvider as SqlSvStudAskAdvProvider;}
		}
		
		#endregion
		
		
		#region "SvStudCourseEvalExtProvider"
			
		private SqlSvStudCourseEvalExtProvider innerSqlSvStudCourseEvalExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudCourseEvalExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudCourseEvalExtProviderBase SvStudCourseEvalExtProvider
		{
			get
			{
				if (innerSqlSvStudCourseEvalExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudCourseEvalExtProvider == null)
						{
							this.innerSqlSvStudCourseEvalExtProvider = new SqlSvStudCourseEvalExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudCourseEvalExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudCourseEvalExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudCourseEvalExtProvider SqlSvStudCourseEvalExtProvider
		{
			get {return SvStudCourseEvalExtProvider as SqlSvStudCourseEvalExtProvider;}
		}
		
		#endregion
		
		
		#region "SvStaffEvlProvider"
			
		private SqlSvStaffEvlProvider innerSqlSvStaffEvlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStaffEvl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStaffEvlProviderBase SvStaffEvlProvider
		{
			get
			{
				if (innerSqlSvStaffEvlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStaffEvlProvider == null)
						{
							this.innerSqlSvStaffEvlProvider = new SqlSvStaffEvlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStaffEvlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStaffEvlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStaffEvlProvider SqlSvStaffEvlProvider
		{
			get {return SvStaffEvlProvider as SqlSvStaffEvlProvider;}
		}
		
		#endregion
		
		
		#region "SvStaffPollProvider"
			
		private SqlSvStaffPollProvider innerSqlSvStaffPollProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStaffPoll"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStaffPollProviderBase SvStaffPollProvider
		{
			get
			{
				if (innerSqlSvStaffPollProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStaffPollProvider == null)
						{
							this.innerSqlSvStaffPollProvider = new SqlSvStaffPollProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStaffPollProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStaffPollProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStaffPollProvider SqlSvStaffPollProvider
		{
			get {return SvStaffPollProvider as SqlSvStaffPollProvider;}
		}
		
		#endregion
		
		
		#region "SvStaffEvalExtProvider"
			
		private SqlSvStaffEvalExtProvider innerSqlSvStaffEvalExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStaffEvalExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStaffEvalExtProviderBase SvStaffEvalExtProvider
		{
			get
			{
				if (innerSqlSvStaffEvalExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStaffEvalExtProvider == null)
						{
							this.innerSqlSvStaffEvalExtProvider = new SqlSvStaffEvalExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStaffEvalExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStaffEvalExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStaffEvalExtProvider SqlSvStaffEvalExtProvider
		{
			get {return SvStaffEvalExtProvider as SqlSvStaffEvalExtProvider;}
		}
		
		#endregion
		
		
		#region "SvStudAskAdvReProvider"
			
		private SqlSvStudAskAdvReProvider innerSqlSvStudAskAdvReProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStudAskAdvRe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStudAskAdvReProviderBase SvStudAskAdvReProvider
		{
			get
			{
				if (innerSqlSvStudAskAdvReProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStudAskAdvReProvider == null)
						{
							this.innerSqlSvStudAskAdvReProvider = new SqlSvStudAskAdvReProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStudAskAdvReProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStudAskAdvReProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStudAskAdvReProvider SqlSvStudAskAdvReProvider
		{
			get {return SvStudAskAdvReProvider as SqlSvStudAskAdvReProvider;}
		}
		
		#endregion
		
		
		#region "SeApplicationLogProvider"
			
		private SqlSeApplicationLogProvider innerSqlSeApplicationLogProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeApplicationLog"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeApplicationLogProviderBase SeApplicationLogProvider
		{
			get
			{
				if (innerSqlSeApplicationLogProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeApplicationLogProvider == null)
						{
							this.innerSqlSeApplicationLogProvider = new SqlSeApplicationLogProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeApplicationLogProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeApplicationLogProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeApplicationLogProvider SqlSeApplicationLogProvider
		{
			get {return SeApplicationLogProvider as SqlSeApplicationLogProvider;}
		}
		
		#endregion
		
		
		#region "SvStaffEvalItemProvider"
			
		private SqlSvStaffEvalItemProvider innerSqlSvStaffEvalItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SvStaffEvalItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SvStaffEvalItemProviderBase SvStaffEvalItemProvider
		{
			get
			{
				if (innerSqlSvStaffEvalItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSvStaffEvalItemProvider == null)
						{
							this.innerSqlSvStaffEvalItemProvider = new SqlSvStaffEvalItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSvStaffEvalItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSvStaffEvalItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSvStaffEvalItemProvider SqlSvStaffEvalItemProvider
		{
			get {return SvStaffEvalItemProvider as SqlSvStaffEvalItemProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeScDegProvider"
			
		private SqlSaCodeScDegProvider innerSqlSaCodeScDegProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeScDeg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeScDegProviderBase SaCodeScDegProvider
		{
			get
			{
				if (innerSqlSaCodeScDegProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeScDegProvider == null)
						{
							this.innerSqlSaCodeScDegProvider = new SqlSaCodeScDegProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeScDegProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeScDegProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeScDegProvider SqlSaCodeScDegProvider
		{
			get {return SaCodeScDegProvider as SqlSaCodeScDegProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeJobStatusProvider"
			
		private SqlSaCodeJobStatusProvider innerSqlSaCodeJobStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeJobStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeJobStatusProviderBase SaCodeJobStatusProvider
		{
			get
			{
				if (innerSqlSaCodeJobStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeJobStatusProvider == null)
						{
							this.innerSqlSaCodeJobStatusProvider = new SqlSaCodeJobStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeJobStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeJobStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeJobStatusProvider SqlSaCodeJobStatusProvider
		{
			get {return SaCodeJobStatusProvider as SqlSaCodeJobStatusProvider;}
		}
		
		#endregion
		
		
		#region "SaPromotionCondProvider"
			
		private SqlSaPromotionCondProvider innerSqlSaPromotionCondProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPromotionCond"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPromotionCondProviderBase SaPromotionCondProvider
		{
			get
			{
				if (innerSqlSaPromotionCondProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPromotionCondProvider == null)
						{
							this.innerSqlSaPromotionCondProvider = new SqlSaPromotionCondProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPromotionCondProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPromotionCondProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPromotionCondProvider SqlSaPromotionCondProvider
		{
			get {return SaPromotionCondProvider as SqlSaPromotionCondProvider;}
		}
		
		#endregion
		
		
		#region "AsCodeDegreeProvider"
			
		private SqlAsCodeDegreeProvider innerSqlAsCodeDegreeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AsCodeDegree"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AsCodeDegreeProviderBase AsCodeDegreeProvider
		{
			get
			{
				if (innerSqlAsCodeDegreeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAsCodeDegreeProvider == null)
						{
							this.innerSqlAsCodeDegreeProvider = new SqlAsCodeDegreeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAsCodeDegreeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAsCodeDegreeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAsCodeDegreeProvider SqlAsCodeDegreeProvider
		{
			get {return AsCodeDegreeProvider as SqlAsCodeDegreeProvider;}
		}
		
		#endregion
		
		
		#region "SaStfMemberProvider"
			
		private SqlSaStfMemberProvider innerSqlSaStfMemberProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaStfMember"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaStfMemberProviderBase SaStfMemberProvider
		{
			get
			{
				if (innerSqlSaStfMemberProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaStfMemberProvider == null)
						{
							this.innerSqlSaStfMemberProvider = new SqlSaStfMemberProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaStfMemberProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaStfMemberProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaStfMemberProvider SqlSaStfMemberProvider
		{
			get {return SaStfMemberProvider as SqlSaStfMemberProvider;}
		}
		
		#endregion
		
		
		#region "SaPersonIdProvider"
			
		private SqlSaPersonIdProvider innerSqlSaPersonIdProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPersonId"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPersonIdProviderBase SaPersonIdProvider
		{
			get
			{
				if (innerSqlSaPersonIdProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPersonIdProvider == null)
						{
							this.innerSqlSaPersonIdProvider = new SqlSaPersonIdProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPersonIdProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPersonIdProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPersonIdProvider SqlSaPersonIdProvider
		{
			get {return SaPersonIdProvider as SqlSaPersonIdProvider;}
		}
		
		#endregion
		
		
		#region "SaPromotionProvider"
			
		private SqlSaPromotionProvider innerSqlSaPromotionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPromotion"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPromotionProviderBase SaPromotionProvider
		{
			get
			{
				if (innerSqlSaPromotionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPromotionProvider == null)
						{
							this.innerSqlSaPromotionProvider = new SqlSaPromotionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPromotionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPromotionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPromotionProvider SqlSaPromotionProvider
		{
			get {return SaPromotionProvider as SqlSaPromotionProvider;}
		}
		
		#endregion
		
		
		#region "SaOfficeHourProvider"
			
		private SqlSaOfficeHourProvider innerSqlSaOfficeHourProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaOfficeHour"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaOfficeHourProviderBase SaOfficeHourProvider
		{
			get
			{
				if (innerSqlSaOfficeHourProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaOfficeHourProvider == null)
						{
							this.innerSqlSaOfficeHourProvider = new SqlSaOfficeHourProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaOfficeHourProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaOfficeHourProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaOfficeHourProvider SqlSaOfficeHourProvider
		{
			get {return SaOfficeHourProvider as SqlSaOfficeHourProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeSummeryProvider"
			
		private SqlSaCodeSummeryProvider innerSqlSaCodeSummeryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeSummery"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeSummeryProviderBase SaCodeSummeryProvider
		{
			get
			{
				if (innerSqlSaCodeSummeryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeSummeryProvider == null)
						{
							this.innerSqlSaCodeSummeryProvider = new SqlSaCodeSummeryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeSummeryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeSummeryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeSummeryProvider SqlSaCodeSummeryProvider
		{
			get {return SaCodeSummeryProvider as SqlSaCodeSummeryProvider;}
		}
		
		#endregion
		
		
		#region "SaMilitaryStatusProvider"
			
		private SqlSaMilitaryStatusProvider innerSqlSaMilitaryStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaMilitaryStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaMilitaryStatusProviderBase SaMilitaryStatusProvider
		{
			get
			{
				if (innerSqlSaMilitaryStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaMilitaryStatusProvider == null)
						{
							this.innerSqlSaMilitaryStatusProvider = new SqlSaMilitaryStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaMilitaryStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaMilitaryStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaMilitaryStatusProvider SqlSaMilitaryStatusProvider
		{
			get {return SaMilitaryStatusProvider as SqlSaMilitaryStatusProvider;}
		}
		
		#endregion
		
		
		#region "SaMiltaryProvider"
			
		private SqlSaMiltaryProvider innerSqlSaMiltaryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaMiltary"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaMiltaryProviderBase SaMiltaryProvider
		{
			get
			{
				if (innerSqlSaMiltaryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaMiltaryProvider == null)
						{
							this.innerSqlSaMiltaryProvider = new SqlSaMiltaryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaMiltaryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaMiltaryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaMiltaryProvider SqlSaMiltaryProvider
		{
			get {return SaMiltaryProvider as SqlSaMiltaryProvider;}
		}
		
		#endregion
		
		
		#region "SaJobStartStatmentProvider"
			
		private SqlSaJobStartStatmentProvider innerSqlSaJobStartStatmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaJobStartStatment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaJobStartStatmentProviderBase SaJobStartStatmentProvider
		{
			get
			{
				if (innerSqlSaJobStartStatmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaJobStartStatmentProvider == null)
						{
							this.innerSqlSaJobStartStatmentProvider = new SqlSaJobStartStatmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaJobStartStatmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaJobStartStatmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaJobStartStatmentProvider SqlSaJobStartStatmentProvider
		{
			get {return SaJobStartStatmentProvider as SqlSaJobStartStatmentProvider;}
		}
		
		#endregion
		
		
		#region "SaJobStoppageProvider"
			
		private SqlSaJobStoppageProvider innerSqlSaJobStoppageProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaJobStoppage"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaJobStoppageProviderBase SaJobStoppageProvider
		{
			get
			{
				if (innerSqlSaJobStoppageProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaJobStoppageProvider == null)
						{
							this.innerSqlSaJobStoppageProvider = new SqlSaJobStoppageProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaJobStoppageProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaJobStoppageProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaJobStoppageProvider SqlSaJobStoppageProvider
		{
			get {return SaJobStoppageProvider as SqlSaJobStoppageProvider;}
		}
		
		#endregion
		
		
		#region "SaKeywordListProvider"
			
		private SqlSaKeywordListProvider innerSqlSaKeywordListProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaKeywordList"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaKeywordListProviderBase SaKeywordListProvider
		{
			get
			{
				if (innerSqlSaKeywordListProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaKeywordListProvider == null)
						{
							this.innerSqlSaKeywordListProvider = new SqlSaKeywordListProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaKeywordListProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaKeywordListProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaKeywordListProvider SqlSaKeywordListProvider
		{
			get {return SaKeywordListProvider as SqlSaKeywordListProvider;}
		}
		
		#endregion
		
		
		#region "SaPromotionCondStsfProvider"
			
		private SqlSaPromotionCondStsfProvider innerSqlSaPromotionCondStsfProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPromotionCondStsf"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPromotionCondStsfProviderBase SaPromotionCondStsfProvider
		{
			get
			{
				if (innerSqlSaPromotionCondStsfProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPromotionCondStsfProvider == null)
						{
							this.innerSqlSaPromotionCondStsfProvider = new SqlSaPromotionCondStsfProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPromotionCondStsfProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPromotionCondStsfProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPromotionCondStsfProvider SqlSaPromotionCondStsfProvider
		{
			get {return SaPromotionCondStsfProvider as SqlSaPromotionCondStsfProvider;}
		}
		
		#endregion
		
		
		#region "SeApplicationAuditProvider"
			
		private SqlSeApplicationAuditProvider innerSqlSeApplicationAuditProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeApplicationAudit"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeApplicationAuditProviderBase SeApplicationAuditProvider
		{
			get
			{
				if (innerSqlSeApplicationAuditProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeApplicationAuditProvider == null)
						{
							this.innerSqlSeApplicationAuditProvider = new SqlSeApplicationAuditProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeApplicationAuditProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeApplicationAuditProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeApplicationAuditProvider SqlSeApplicationAuditProvider
		{
			get {return SeApplicationAuditProvider as SqlSeApplicationAuditProvider;}
		}
		
		#endregion
		
		
		#region "SaPromotionRequestProvider"
			
		private SqlSaPromotionRequestProvider innerSqlSaPromotionRequestProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPromotionRequest"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPromotionRequestProviderBase SaPromotionRequestProvider
		{
			get
			{
				if (innerSqlSaPromotionRequestProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPromotionRequestProvider == null)
						{
							this.innerSqlSaPromotionRequestProvider = new SqlSaPromotionRequestProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPromotionRequestProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPromotionRequestProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPromotionRequestProvider SqlSaPromotionRequestProvider
		{
			get {return SaPromotionRequestProvider as SqlSaPromotionRequestProvider;}
		}
		
		#endregion
		
		
		#region "SaPublicationProvider"
			
		private SqlSaPublicationProvider innerSqlSaPublicationProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPublication"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPublicationProviderBase SaPublicationProvider
		{
			get
			{
				if (innerSqlSaPublicationProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPublicationProvider == null)
						{
							this.innerSqlSaPublicationProvider = new SqlSaPublicationProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPublicationProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPublicationProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPublicationProvider SqlSaPublicationProvider
		{
			get {return SaPublicationProvider as SqlSaPublicationProvider;}
		}
		
		#endregion
		
		
		#region "EdAcadYearProvider"
			
		private SqlEdAcadYearProvider innerSqlEdAcadYearProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAcadYear"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAcadYearProviderBase EdAcadYearProvider
		{
			get
			{
				if (innerSqlEdAcadYearProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAcadYearProvider == null)
						{
							this.innerSqlEdAcadYearProvider = new SqlEdAcadYearProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAcadYearProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAcadYearProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAcadYearProvider SqlEdAcadYearProvider
		{
			get {return EdAcadYearProvider as SqlEdAcadYearProvider;}
		}
		
		#endregion
		
		
		#region "SaPunishBylawAuthProvider"
			
		private SqlSaPunishBylawAuthProvider innerSqlSaPunishBylawAuthProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPunishBylawAuth"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPunishBylawAuthProviderBase SaPunishBylawAuthProvider
		{
			get
			{
				if (innerSqlSaPunishBylawAuthProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPunishBylawAuthProvider == null)
						{
							this.innerSqlSaPunishBylawAuthProvider = new SqlSaPunishBylawAuthProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPunishBylawAuthProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPunishBylawAuthProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPunishBylawAuthProvider SqlSaPunishBylawAuthProvider
		{
			get {return SaPunishBylawAuthProvider as SqlSaPunishBylawAuthProvider;}
		}
		
		#endregion
		
		
		#region "SaRaiseProvider"
			
		private SqlSaRaiseProvider innerSqlSaRaiseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaRaise"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaRaiseProviderBase SaRaiseProvider
		{
			get
			{
				if (innerSqlSaRaiseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaRaiseProvider == null)
						{
							this.innerSqlSaRaiseProvider = new SqlSaRaiseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaRaiseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaRaiseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaRaiseProvider SqlSaRaiseProvider
		{
			get {return SaRaiseProvider as SqlSaRaiseProvider;}
		}
		
		#endregion
		
		
		#region "SaRelativeProvider"
			
		private SqlSaRelativeProvider innerSqlSaRelativeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaRelative"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaRelativeProviderBase SaRelativeProvider
		{
			get
			{
				if (innerSqlSaRelativeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaRelativeProvider == null)
						{
							this.innerSqlSaRelativeProvider = new SqlSaRelativeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaRelativeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaRelativeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaRelativeProvider SqlSaRelativeProvider
		{
			get {return SaRelativeProvider as SqlSaRelativeProvider;}
		}
		
		#endregion
		
		
		#region "SaResearchTeamProvider"
			
		private SqlSaResearchTeamProvider innerSqlSaResearchTeamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaResearchTeam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaResearchTeamProviderBase SaResearchTeamProvider
		{
			get
			{
				if (innerSqlSaResearchTeamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaResearchTeamProvider == null)
						{
							this.innerSqlSaResearchTeamProvider = new SqlSaResearchTeamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaResearchTeamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaResearchTeamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaResearchTeamProvider SqlSaResearchTeamProvider
		{
			get {return SaResearchTeamProvider as SqlSaResearchTeamProvider;}
		}
		
		#endregion
		
		
		#region "SaPunishmentBylawsProvider"
			
		private SqlSaPunishmentBylawsProvider innerSqlSaPunishmentBylawsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPunishmentBylaws"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPunishmentBylawsProviderBase SaPunishmentBylawsProvider
		{
			get
			{
				if (innerSqlSaPunishmentBylawsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPunishmentBylawsProvider == null)
						{
							this.innerSqlSaPunishmentBylawsProvider = new SqlSaPunishmentBylawsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPunishmentBylawsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPunishmentBylawsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPunishmentBylawsProvider SqlSaPunishmentBylawsProvider
		{
			get {return SaPunishmentBylawsProvider as SqlSaPunishmentBylawsProvider;}
		}
		
		#endregion
		
		
		#region "SaJobActivityProvider"
			
		private SqlSaJobActivityProvider innerSqlSaJobActivityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaJobActivity"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaJobActivityProviderBase SaJobActivityProvider
		{
			get
			{
				if (innerSqlSaJobActivityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaJobActivityProvider == null)
						{
							this.innerSqlSaJobActivityProvider = new SqlSaJobActivityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaJobActivityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaJobActivityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaJobActivityProvider SqlSaJobActivityProvider
		{
			get {return SaJobActivityProvider as SqlSaJobActivityProvider;}
		}
		
		#endregion
		
		
		#region "SaPunishmentProvider"
			
		private SqlSaPunishmentProvider innerSqlSaPunishmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaPunishment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaPunishmentProviderBase SaPunishmentProvider
		{
			get
			{
				if (innerSqlSaPunishmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaPunishmentProvider == null)
						{
							this.innerSqlSaPunishmentProvider = new SqlSaPunishmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaPunishmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaPunishmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaPunishmentProvider SqlSaPunishmentProvider
		{
			get {return SaPunishmentProvider as SqlSaPunishmentProvider;}
		}
		
		#endregion
		
		
		#region "SaTransferProvider"
			
		private SqlSaTransferProvider innerSqlSaTransferProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaTransfer"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaTransferProviderBase SaTransferProvider
		{
			get
			{
				if (innerSqlSaTransferProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaTransferProvider == null)
						{
							this.innerSqlSaTransferProvider = new SqlSaTransferProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaTransferProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaTransferProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaTransferProvider SqlSaTransferProvider
		{
			get {return SaTransferProvider as SqlSaTransferProvider;}
		}
		
		#endregion
		
		
		#region "SaScCommProvider"
			
		private SqlSaScCommProvider innerSqlSaScCommProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaScComm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaScCommProviderBase SaScCommProvider
		{
			get
			{
				if (innerSqlSaScCommProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaScCommProvider == null)
						{
							this.innerSqlSaScCommProvider = new SqlSaScCommProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaScCommProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaScCommProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaScCommProvider SqlSaScCommProvider
		{
			get {return SaScCommProvider as SqlSaScCommProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeRatingProvider"
			
		private SqlSaCodeRatingProvider innerSqlSaCodeRatingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeRating"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeRatingProviderBase SaCodeRatingProvider
		{
			get
			{
				if (innerSqlSaCodeRatingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeRatingProvider == null)
						{
							this.innerSqlSaCodeRatingProvider = new SqlSaCodeRatingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeRatingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeRatingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeRatingProvider SqlSaCodeRatingProvider
		{
			get {return SaCodeRatingProvider as SqlSaCodeRatingProvider;}
		}
		
		#endregion
		
		
		#region "SaFinStatmentProvider"
			
		private SqlSaFinStatmentProvider innerSqlSaFinStatmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaFinStatment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaFinStatmentProviderBase SaFinStatmentProvider
		{
			get
			{
				if (innerSqlSaFinStatmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaFinStatmentProvider == null)
						{
							this.innerSqlSaFinStatmentProvider = new SqlSaFinStatmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaFinStatmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaFinStatmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaFinStatmentProvider SqlSaFinStatmentProvider
		{
			get {return SaFinStatmentProvider as SqlSaFinStatmentProvider;}
		}
		
		#endregion
		
		
		#region "SaCodePunishRsnProvider"
			
		private SqlSaCodePunishRsnProvider innerSqlSaCodePunishRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodePunishRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodePunishRsnProviderBase SaCodePunishRsnProvider
		{
			get
			{
				if (innerSqlSaCodePunishRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodePunishRsnProvider == null)
						{
							this.innerSqlSaCodePunishRsnProvider = new SqlSaCodePunishRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodePunishRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodePunishRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodePunishRsnProvider SqlSaCodePunishRsnProvider
		{
			get {return SaCodePunishRsnProvider as SqlSaCodePunishRsnProvider;}
		}
		
		#endregion
		
		
		#region "SaExtDelProvider"
			
		private SqlSaExtDelProvider innerSqlSaExtDelProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaExtDel"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaExtDelProviderBase SaExtDelProvider
		{
			get
			{
				if (innerSqlSaExtDelProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaExtDelProvider == null)
						{
							this.innerSqlSaExtDelProvider = new SqlSaExtDelProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaExtDelProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaExtDelProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaExtDelProvider SqlSaExtDelProvider
		{
			get {return SaExtDelProvider as SqlSaExtDelProvider;}
		}
		
		#endregion
		
		
		#region "SaCodePunishingAuthorityProvider"
			
		private SqlSaCodePunishingAuthorityProvider innerSqlSaCodePunishingAuthorityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodePunishingAuthority"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodePunishingAuthorityProviderBase SaCodePunishingAuthorityProvider
		{
			get
			{
				if (innerSqlSaCodePunishingAuthorityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodePunishingAuthorityProvider == null)
						{
							this.innerSqlSaCodePunishingAuthorityProvider = new SqlSaCodePunishingAuthorityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodePunishingAuthorityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodePunishingAuthorityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodePunishingAuthorityProvider SqlSaCodePunishingAuthorityProvider
		{
			get {return SaCodePunishingAuthorityProvider as SqlSaCodePunishingAuthorityProvider;}
		}
		
		#endregion
		
		
		#region "SaCodePunishProvider"
			
		private SqlSaCodePunishProvider innerSqlSaCodePunishProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodePunish"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodePunishProviderBase SaCodePunishProvider
		{
			get
			{
				if (innerSqlSaCodePunishProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodePunishProvider == null)
						{
							this.innerSqlSaCodePunishProvider = new SqlSaCodePunishProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodePunishProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodePunishProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodePunishProvider SqlSaCodePunishProvider
		{
			get {return SaCodePunishProvider as SqlSaCodePunishProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeResearchCoopProvider"
			
		private SqlSaCodeResearchCoopProvider innerSqlSaCodeResearchCoopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeResearchCoop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeResearchCoopProviderBase SaCodeResearchCoopProvider
		{
			get
			{
				if (innerSqlSaCodeResearchCoopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeResearchCoopProvider == null)
						{
							this.innerSqlSaCodeResearchCoopProvider = new SqlSaCodeResearchCoopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeResearchCoopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeResearchCoopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeResearchCoopProvider SqlSaCodeResearchCoopProvider
		{
			get {return SaCodeResearchCoopProvider as SqlSaCodeResearchCoopProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeSemesterTypeProvider"
			
		private SqlEdCodeSemesterTypeProvider innerSqlEdCodeSemesterTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeSemesterType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeSemesterTypeProviderBase EdCodeSemesterTypeProvider
		{
			get
			{
				if (innerSqlEdCodeSemesterTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeSemesterTypeProvider == null)
						{
							this.innerSqlEdCodeSemesterTypeProvider = new SqlEdCodeSemesterTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeSemesterTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeSemesterTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeSemesterTypeProvider SqlEdCodeSemesterTypeProvider
		{
			get {return EdCodeSemesterTypeProvider as SqlEdCodeSemesterTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeSemesterProvider"
			
		private SqlEdCodeSemesterProvider innerSqlEdCodeSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeSemesterProviderBase EdCodeSemesterProvider
		{
			get
			{
				if (innerSqlEdCodeSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeSemesterProvider == null)
						{
							this.innerSqlEdCodeSemesterProvider = new SqlEdCodeSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeSemesterProvider SqlEdCodeSemesterProvider
		{
			get {return EdCodeSemesterProvider as SqlEdCodeSemesterProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeJobActivityPlaceProvider"
			
		private SqlSaCodeJobActivityPlaceProvider innerSqlSaCodeJobActivityPlaceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeJobActivityPlace"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeJobActivityPlaceProviderBase SaCodeJobActivityPlaceProvider
		{
			get
			{
				if (innerSqlSaCodeJobActivityPlaceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeJobActivityPlaceProvider == null)
						{
							this.innerSqlSaCodeJobActivityPlaceProvider = new SqlSaCodeJobActivityPlaceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeJobActivityPlaceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeJobActivityPlaceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeJobActivityPlaceProvider SqlSaCodeJobActivityPlaceProvider
		{
			get {return SaCodeJobActivityPlaceProvider as SqlSaCodeJobActivityPlaceProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeJobBeforeStatusProvider"
			
		private SqlSaCodeJobBeforeStatusProvider innerSqlSaCodeJobBeforeStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeJobBeforeStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeJobBeforeStatusProviderBase SaCodeJobBeforeStatusProvider
		{
			get
			{
				if (innerSqlSaCodeJobBeforeStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeJobBeforeStatusProvider == null)
						{
							this.innerSqlSaCodeJobBeforeStatusProvider = new SqlSaCodeJobBeforeStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeJobBeforeStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeJobBeforeStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeJobBeforeStatusProvider SqlSaCodeJobBeforeStatusProvider
		{
			get {return SaCodeJobBeforeStatusProvider as SqlSaCodeJobBeforeStatusProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeOrgProvider"
			
		private SqlSaCodeOrgProvider innerSqlSaCodeOrgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeOrg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeOrgProviderBase SaCodeOrgProvider
		{
			get
			{
				if (innerSqlSaCodeOrgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeOrgProvider == null)
						{
							this.innerSqlSaCodeOrgProvider = new SqlSaCodeOrgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeOrgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeOrgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeOrgProvider SqlSaCodeOrgProvider
		{
			get {return SaCodeOrgProvider as SqlSaCodeOrgProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeParDelNatureProvider"
			
		private SqlSaCodeParDelNatureProvider innerSqlSaCodeParDelNatureProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeParDelNature"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeParDelNatureProviderBase SaCodeParDelNatureProvider
		{
			get
			{
				if (innerSqlSaCodeParDelNatureProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeParDelNatureProvider == null)
						{
							this.innerSqlSaCodeParDelNatureProvider = new SqlSaCodeParDelNatureProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeParDelNatureProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeParDelNatureProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeParDelNatureProvider SqlSaCodeParDelNatureProvider
		{
			get {return SaCodeParDelNatureProvider as SqlSaCodeParDelNatureProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeServTerminRsnProvider"
			
		private SqlSaCodeServTerminRsnProvider innerSqlSaCodeServTerminRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeServTerminRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeServTerminRsnProviderBase SaCodeServTerminRsnProvider
		{
			get
			{
				if (innerSqlSaCodeServTerminRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeServTerminRsnProvider == null)
						{
							this.innerSqlSaCodeServTerminRsnProvider = new SqlSaCodeServTerminRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeServTerminRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeServTerminRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeServTerminRsnProvider SqlSaCodeServTerminRsnProvider
		{
			get {return SaCodeServTerminRsnProvider as SqlSaCodeServTerminRsnProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeStaffTypeProvider"
			
		private SqlSaCodeStaffTypeProvider innerSqlSaCodeStaffTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeStaffType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeStaffTypeProviderBase SaCodeStaffTypeProvider
		{
			get
			{
				if (innerSqlSaCodeStaffTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeStaffTypeProvider == null)
						{
							this.innerSqlSaCodeStaffTypeProvider = new SqlSaCodeStaffTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeStaffTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeStaffTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeStaffTypeProvider SqlSaCodeStaffTypeProvider
		{
			get {return SaCodeStaffTypeProvider as SqlSaCodeStaffTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaDocOfFileProvider"
			
		private SqlSaDocOfFileProvider innerSqlSaDocOfFileProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaDocOfFile"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaDocOfFileProviderBase SaDocOfFileProvider
		{
			get
			{
				if (innerSqlSaDocOfFileProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaDocOfFileProvider == null)
						{
							this.innerSqlSaDocOfFileProvider = new SqlSaDocOfFileProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaDocOfFileProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaDocOfFileProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaDocOfFileProvider SqlSaDocOfFileProvider
		{
			get {return SaDocOfFileProvider as SqlSaDocOfFileProvider;}
		}
		
		#endregion
		
		
		#region "SaEmpHierarchyProvider"
			
		private SqlSaEmpHierarchyProvider innerSqlSaEmpHierarchyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaEmpHierarchy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaEmpHierarchyProviderBase SaEmpHierarchyProvider
		{
			get
			{
				if (innerSqlSaEmpHierarchyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaEmpHierarchyProvider == null)
						{
							this.innerSqlSaEmpHierarchyProvider = new SqlSaEmpHierarchyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaEmpHierarchyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaEmpHierarchyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaEmpHierarchyProvider SqlSaEmpHierarchyProvider
		{
			get {return SaEmpHierarchyProvider as SqlSaEmpHierarchyProvider;}
		}
		
		#endregion
		
		
		#region "SaEmploymentProvider"
			
		private SqlSaEmploymentProvider innerSqlSaEmploymentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaEmployment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaEmploymentProviderBase SaEmploymentProvider
		{
			get
			{
				if (innerSqlSaEmploymentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaEmploymentProvider == null)
						{
							this.innerSqlSaEmploymentProvider = new SqlSaEmploymentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaEmploymentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaEmploymentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaEmploymentProvider SqlSaEmploymentProvider
		{
			get {return SaEmploymentProvider as SqlSaEmploymentProvider;}
		}
		
		#endregion
		
		
		#region "SaExperienceProvider"
			
		private SqlSaExperienceProvider innerSqlSaExperienceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaExperience"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaExperienceProviderBase SaExperienceProvider
		{
			get
			{
				if (innerSqlSaExperienceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaExperienceProvider == null)
						{
							this.innerSqlSaExperienceProvider = new SqlSaExperienceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaExperienceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaExperienceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaExperienceProvider SqlSaExperienceProvider
		{
			get {return SaExperienceProvider as SqlSaExperienceProvider;}
		}
		
		#endregion
		
		
		#region "SaCommMemberProvider"
			
		private SqlSaCommMemberProvider innerSqlSaCommMemberProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCommMember"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCommMemberProviderBase SaCommMemberProvider
		{
			get
			{
				if (innerSqlSaCommMemberProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCommMemberProvider == null)
						{
							this.innerSqlSaCommMemberProvider = new SqlSaCommMemberProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCommMemberProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCommMemberProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCommMemberProvider SqlSaCommMemberProvider
		{
			get {return SaCommMemberProvider as SqlSaCommMemberProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeVacationTypeProvider"
			
		private SqlSaCodeVacationTypeProvider innerSqlSaCodeVacationTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeVacationType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeVacationTypeProviderBase SaCodeVacationTypeProvider
		{
			get
			{
				if (innerSqlSaCodeVacationTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeVacationTypeProvider == null)
						{
							this.innerSqlSaCodeVacationTypeProvider = new SqlSaCodeVacationTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeVacationTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeVacationTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeVacationTypeProvider SqlSaCodeVacationTypeProvider
		{
			get {return SaCodeVacationTypeProvider as SqlSaCodeVacationTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeStfFlgProvider"
			
		private SqlSaCodeStfFlgProvider innerSqlSaCodeStfFlgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeStfFlg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeStfFlgProviderBase SaCodeStfFlgProvider
		{
			get
			{
				if (innerSqlSaCodeStfFlgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeStfFlgProvider == null)
						{
							this.innerSqlSaCodeStfFlgProvider = new SqlSaCodeStfFlgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeStfFlgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeStfFlgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeStfFlgProvider SqlSaCodeStfFlgProvider
		{
			get {return SaCodeStfFlgProvider as SqlSaCodeStfFlgProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeSuperviseJobProvider"
			
		private SqlSaCodeSuperviseJobProvider innerSqlSaCodeSuperviseJobProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeSuperviseJob"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeSuperviseJobProviderBase SaCodeSuperviseJobProvider
		{
			get
			{
				if (innerSqlSaCodeSuperviseJobProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeSuperviseJobProvider == null)
						{
							this.innerSqlSaCodeSuperviseJobProvider = new SqlSaCodeSuperviseJobProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeSuperviseJobProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeSuperviseJobProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeSuperviseJobProvider SqlSaCodeSuperviseJobProvider
		{
			get {return SaCodeSuperviseJobProvider as SqlSaCodeSuperviseJobProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeTrainingFlgProvider"
			
		private SqlSaCodeTrainingFlgProvider innerSqlSaCodeTrainingFlgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeTrainingFlg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeTrainingFlgProviderBase SaCodeTrainingFlgProvider
		{
			get
			{
				if (innerSqlSaCodeTrainingFlgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeTrainingFlgProvider == null)
						{
							this.innerSqlSaCodeTrainingFlgProvider = new SqlSaCodeTrainingFlgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeTrainingFlgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeTrainingFlgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeTrainingFlgProvider SqlSaCodeTrainingFlgProvider
		{
			get {return SaCodeTrainingFlgProvider as SqlSaCodeTrainingFlgProvider;}
		}
		
		#endregion
		
		
		#region "SaCodeTrainingOrgProvider"
			
		private SqlSaCodeTrainingOrgProvider innerSqlSaCodeTrainingOrgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaCodeTrainingOrg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaCodeTrainingOrgProviderBase SaCodeTrainingOrgProvider
		{
			get
			{
				if (innerSqlSaCodeTrainingOrgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaCodeTrainingOrgProvider == null)
						{
							this.innerSqlSaCodeTrainingOrgProvider = new SqlSaCodeTrainingOrgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaCodeTrainingOrgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaCodeTrainingOrgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaCodeTrainingOrgProvider SqlSaCodeTrainingOrgProvider
		{
			get {return SaCodeTrainingOrgProvider as SqlSaCodeTrainingOrgProvider;}
		}
		
		#endregion
		
		
		#region "SaScCommDecisionProvider"
			
		private SqlSaScCommDecisionProvider innerSqlSaScCommDecisionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaScCommDecision"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaScCommDecisionProviderBase SaScCommDecisionProvider
		{
			get
			{
				if (innerSqlSaScCommDecisionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaScCommDecisionProvider == null)
						{
							this.innerSqlSaScCommDecisionProvider = new SqlSaScCommDecisionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaScCommDecisionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaScCommDecisionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaScCommDecisionProvider SqlSaScCommDecisionProvider
		{
			get {return SaScCommDecisionProvider as SqlSaScCommDecisionProvider;}
		}
		
		#endregion
		
		
		#region "ScCdeHallTypeProvider"
			
		private SqlScCdeHallTypeProvider innerSqlScCdeHallTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScCdeHallType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScCdeHallTypeProviderBase ScCdeHallTypeProvider
		{
			get
			{
				if (innerSqlScCdeHallTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScCdeHallTypeProvider == null)
						{
							this.innerSqlScCdeHallTypeProvider = new SqlScCdeHallTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScCdeHallTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScCdeHallTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScCdeHallTypeProvider SqlScCdeHallTypeProvider
		{
			get {return ScCdeHallTypeProvider as SqlScCdeHallTypeProvider;}
		}
		
		#endregion
		
		
		#region "ScCdeGrpTypeProvider"
			
		private SqlScCdeGrpTypeProvider innerSqlScCdeGrpTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScCdeGrpType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScCdeGrpTypeProviderBase ScCdeGrpTypeProvider
		{
			get
			{
				if (innerSqlScCdeGrpTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScCdeGrpTypeProvider == null)
						{
							this.innerSqlScCdeGrpTypeProvider = new SqlScCdeGrpTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScCdeGrpTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScCdeGrpTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScCdeGrpTypeProvider SqlScCdeGrpTypeProvider
		{
			get {return ScCdeGrpTypeProvider as SqlScCdeGrpTypeProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleHdrProvider"
			
		private SqlScScheduleHdrProvider innerSqlScScheduleHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleHdrProviderBase ScScheduleHdrProvider
		{
			get
			{
				if (innerSqlScScheduleHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleHdrProvider == null)
						{
							this.innerSqlScScheduleHdrProvider = new SqlScScheduleHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleHdrProvider SqlScScheduleHdrProvider
		{
			get {return ScScheduleHdrProvider as SqlScScheduleHdrProvider;}
		}
		
		#endregion
		
		
		#region "SaScQualProvider"
			
		private SqlSaScQualProvider innerSqlSaScQualProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaScQual"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaScQualProviderBase SaScQualProvider
		{
			get
			{
				if (innerSqlSaScQualProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaScQualProvider == null)
						{
							this.innerSqlSaScQualProvider = new SqlSaScQualProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaScQualProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaScQualProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaScQualProvider SqlSaScQualProvider
		{
			get {return SaScQualProvider as SqlSaScQualProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleDtlProvider"
			
		private SqlScScheduleDtlProvider innerSqlScScheduleDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleDtlProviderBase ScScheduleDtlProvider
		{
			get
			{
				if (innerSqlScScheduleDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleDtlProvider == null)
						{
							this.innerSqlScScheduleDtlProvider = new SqlScScheduleDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleDtlProvider SqlScScheduleDtlProvider
		{
			get {return ScScheduleDtlProvider as SqlScScheduleDtlProvider;}
		}
		
		#endregion
		
		
		#region "ScBuildingProvider"
			
		private SqlScBuildingProvider innerSqlScBuildingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScBuilding"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScBuildingProviderBase ScBuildingProvider
		{
			get
			{
				if (innerSqlScBuildingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScBuildingProvider == null)
						{
							this.innerSqlScBuildingProvider = new SqlScBuildingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScBuildingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScBuildingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScBuildingProvider SqlScBuildingProvider
		{
			get {return ScBuildingProvider as SqlScBuildingProvider;}
		}
		
		#endregion
		
		
		#region "ScSchdlPeriodProvider"
			
		private SqlScSchdlPeriodProvider innerSqlScSchdlPeriodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScSchdlPeriod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScSchdlPeriodProviderBase ScSchdlPeriodProvider
		{
			get
			{
				if (innerSqlScSchdlPeriodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScSchdlPeriodProvider == null)
						{
							this.innerSqlScSchdlPeriodProvider = new SqlScSchdlPeriodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScSchdlPeriodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScSchdlPeriodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScSchdlPeriodProvider SqlScSchdlPeriodProvider
		{
			get {return ScSchdlPeriodProvider as SqlScSchdlPeriodProvider;}
		}
		
		#endregion
		
		
		#region "ScGroupInfoProvider"
			
		private SqlScGroupInfoProvider innerSqlScGroupInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScGroupInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScGroupInfoProviderBase ScGroupInfoProvider
		{
			get
			{
				if (innerSqlScGroupInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScGroupInfoProvider == null)
						{
							this.innerSqlScGroupInfoProvider = new SqlScGroupInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScGroupInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScGroupInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScGroupInfoProvider SqlScGroupInfoProvider
		{
			get {return ScGroupInfoProvider as SqlScGroupInfoProvider;}
		}
		
		#endregion
		
		
		#region "ScHallProvider"
			
		private SqlScHallProvider innerSqlScHallProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScHall"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScHallProviderBase ScHallProvider
		{
			get
			{
				if (innerSqlScHallProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScHallProvider == null)
						{
							this.innerSqlScHallProvider = new SqlScHallProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScHallProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScHallProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScHallProvider SqlScHallProvider
		{
			get {return ScHallProvider as SqlScHallProvider;}
		}
		
		#endregion
		
		
		#region "ScTchngSlotProvider"
			
		private SqlScTchngSlotProvider innerSqlScTchngSlotProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScTchngSlot"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScTchngSlotProviderBase ScTchngSlotProvider
		{
			get
			{
				if (innerSqlScTchngSlotProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScTchngSlotProvider == null)
						{
							this.innerSqlScTchngSlotProvider = new SqlScTchngSlotProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScTchngSlotProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScTchngSlotProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScTchngSlotProvider SqlScTchngSlotProvider
		{
			get {return ScTchngSlotProvider as SqlScTchngSlotProvider;}
		}
		
		#endregion
		
		
		#region "ScSchdlSlotProvider"
			
		private SqlScSchdlSlotProvider innerSqlScSchdlSlotProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScSchdlSlot"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScSchdlSlotProviderBase ScSchdlSlotProvider
		{
			get
			{
				if (innerSqlScSchdlSlotProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScSchdlSlotProvider == null)
						{
							this.innerSqlScSchdlSlotProvider = new SqlScSchdlSlotProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScSchdlSlotProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScSchdlSlotProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScSchdlSlotProvider SqlScSchdlSlotProvider
		{
			get {return ScSchdlSlotProvider as SqlScSchdlSlotProvider;}
		}
		
		#endregion
		
		
		#region "ScGroupDayProvider"
			
		private SqlScGroupDayProvider innerSqlScGroupDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScGroupDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScGroupDayProviderBase ScGroupDayProvider
		{
			get
			{
				if (innerSqlScGroupDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScGroupDayProvider == null)
						{
							this.innerSqlScGroupDayProvider = new SqlScGroupDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScGroupDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScGroupDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScGroupDayProvider SqlScGroupDayProvider
		{
			get {return ScGroupDayProvider as SqlScGroupDayProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleCrossListProvider"
			
		private SqlScScheduleCrossListProvider innerSqlScScheduleCrossListProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleCrossList"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleCrossListProviderBase ScScheduleCrossListProvider
		{
			get
			{
				if (innerSqlScScheduleCrossListProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleCrossListProvider == null)
						{
							this.innerSqlScScheduleCrossListProvider = new SqlScScheduleCrossListProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleCrossListProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleCrossListProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleCrossListProvider SqlScScheduleCrossListProvider
		{
			get {return ScScheduleCrossListProvider as SqlScScheduleCrossListProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleDtlDayProvider"
			
		private SqlScScheduleDtlDayProvider innerSqlScScheduleDtlDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleDtlDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleDtlDayProviderBase ScScheduleDtlDayProvider
		{
			get
			{
				if (innerSqlScScheduleDtlDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleDtlDayProvider == null)
						{
							this.innerSqlScScheduleDtlDayProvider = new SqlScScheduleDtlDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleDtlDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleDtlDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleDtlDayProvider SqlScScheduleDtlDayProvider
		{
			get {return ScScheduleDtlDayProvider as SqlScScheduleDtlDayProvider;}
		}
		
		#endregion
		
		
		#region "ScSchdlSlotStaffProvider"
			
		private SqlScSchdlSlotStaffProvider innerSqlScSchdlSlotStaffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScSchdlSlotStaff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScSchdlSlotStaffProviderBase ScSchdlSlotStaffProvider
		{
			get
			{
				if (innerSqlScSchdlSlotStaffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScSchdlSlotStaffProvider == null)
						{
							this.innerSqlScSchdlSlotStaffProvider = new SqlScSchdlSlotStaffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScSchdlSlotStaffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScSchdlSlotStaffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScSchdlSlotStaffProvider SqlScSchdlSlotStaffProvider
		{
			get {return ScSchdlSlotStaffProvider as SqlScSchdlSlotStaffProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleDtlDateProvider"
			
		private SqlScScheduleDtlDateProvider innerSqlScScheduleDtlDateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleDtlDate"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleDtlDateProviderBase ScScheduleDtlDateProvider
		{
			get
			{
				if (innerSqlScScheduleDtlDateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleDtlDateProvider == null)
						{
							this.innerSqlScScheduleDtlDateProvider = new SqlScScheduleDtlDateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleDtlDateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleDtlDateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleDtlDateProvider SqlScScheduleDtlDateProvider
		{
			get {return ScScheduleDtlDateProvider as SqlScScheduleDtlDateProvider;}
		}
		
		#endregion
		
		
		#region "ScTchngDayProvider"
			
		private SqlScTchngDayProvider innerSqlScTchngDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScTchngDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScTchngDayProviderBase ScTchngDayProvider
		{
			get
			{
				if (innerSqlScTchngDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScTchngDayProvider == null)
						{
							this.innerSqlScTchngDayProvider = new SqlScTchngDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScTchngDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScTchngDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScTchngDayProvider SqlScTchngDayProvider
		{
			get {return ScTchngDayProvider as SqlScTchngDayProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleDtlDayExceptionProvider"
			
		private SqlScScheduleDtlDayExceptionProvider innerSqlScScheduleDtlDayExceptionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleDtlDayException"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleDtlDayExceptionProviderBase ScScheduleDtlDayExceptionProvider
		{
			get
			{
				if (innerSqlScScheduleDtlDayExceptionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleDtlDayExceptionProvider == null)
						{
							this.innerSqlScScheduleDtlDayExceptionProvider = new SqlScScheduleDtlDayExceptionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleDtlDayExceptionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleDtlDayExceptionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleDtlDayExceptionProvider SqlScScheduleDtlDayExceptionProvider
		{
			get {return ScScheduleDtlDayExceptionProvider as SqlScScheduleDtlDayExceptionProvider;}
		}
		
		#endregion
		
		
		#region "SeAccntControlDiffProvider"
			
		private SqlSeAccntControlDiffProvider innerSqlSeAccntControlDiffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeAccntControlDiff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeAccntControlDiffProviderBase SeAccntControlDiffProvider
		{
			get
			{
				if (innerSqlSeAccntControlDiffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeAccntControlDiffProvider == null)
						{
							this.innerSqlSeAccntControlDiffProvider = new SqlSeAccntControlDiffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeAccntControlDiffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeAccntControlDiffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeAccntControlDiffProvider SqlSeAccntControlDiffProvider
		{
			get {return SeAccntControlDiffProvider as SqlSeAccntControlDiffProvider;}
		}
		
		#endregion
		
		
		#region "ScTchngAgendaProvider"
			
		private SqlScTchngAgendaProvider innerSqlScTchngAgendaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScTchngAgenda"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScTchngAgendaProviderBase ScTchngAgendaProvider
		{
			get
			{
				if (innerSqlScTchngAgendaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScTchngAgendaProvider == null)
						{
							this.innerSqlScTchngAgendaProvider = new SqlScTchngAgendaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScTchngAgendaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScTchngAgendaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScTchngAgendaProvider SqlScTchngAgendaProvider
		{
			get {return ScTchngAgendaProvider as SqlScTchngAgendaProvider;}
		}
		
		#endregion
		
		
		#region "SeAccntFormDiffProvider"
			
		private SqlSeAccntFormDiffProvider innerSqlSeAccntFormDiffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SeAccntFormDiff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SeAccntFormDiffProviderBase SeAccntFormDiffProvider
		{
			get
			{
				if (innerSqlSeAccntFormDiffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSeAccntFormDiffProvider == null)
						{
							this.innerSqlSeAccntFormDiffProvider = new SqlSeAccntFormDiffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSeAccntFormDiffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSeAccntFormDiffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSeAccntFormDiffProvider SqlSeAccntFormDiffProvider
		{
			get {return SeAccntFormDiffProvider as SqlSeAccntFormDiffProvider;}
		}
		
		#endregion
		
		
		#region "ScSectionGroupHdrProvider"
			
		private SqlScSectionGroupHdrProvider innerSqlScSectionGroupHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScSectionGroupHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScSectionGroupHdrProviderBase ScSectionGroupHdrProvider
		{
			get
			{
				if (innerSqlScSectionGroupHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScSectionGroupHdrProvider == null)
						{
							this.innerSqlScSectionGroupHdrProvider = new SqlScSectionGroupHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScSectionGroupHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScSectionGroupHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScSectionGroupHdrProvider SqlScSectionGroupHdrProvider
		{
			get {return ScSectionGroupHdrProvider as SqlScSectionGroupHdrProvider;}
		}
		
		#endregion
		
		
		#region "ScStudGroupProvider"
			
		private SqlScStudGroupProvider innerSqlScStudGroupProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScStudGroup"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScStudGroupProviderBase ScStudGroupProvider
		{
			get
			{
				if (innerSqlScStudGroupProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScStudGroupProvider == null)
						{
							this.innerSqlScStudGroupProvider = new SqlScStudGroupProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScStudGroupProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScStudGroupProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScStudGroupProvider SqlScStudGroupProvider
		{
			get {return ScStudGroupProvider as SqlScStudGroupProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleDtlExtStfProvider"
			
		private SqlScScheduleDtlExtStfProvider innerSqlScScheduleDtlExtStfProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleDtlExtStf"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleDtlExtStfProviderBase ScScheduleDtlExtStfProvider
		{
			get
			{
				if (innerSqlScScheduleDtlExtStfProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleDtlExtStfProvider == null)
						{
							this.innerSqlScScheduleDtlExtStfProvider = new SqlScScheduleDtlExtStfProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleDtlExtStfProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleDtlExtStfProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleDtlExtStfProvider SqlScScheduleDtlExtStfProvider
		{
			get {return ScScheduleDtlExtStfProvider as SqlScScheduleDtlExtStfProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleHdrDefaultProvider"
			
		private SqlScScheduleHdrDefaultProvider innerSqlScScheduleHdrDefaultProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleHdrDefault"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleHdrDefaultProviderBase ScScheduleHdrDefaultProvider
		{
			get
			{
				if (innerSqlScScheduleHdrDefaultProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleHdrDefaultProvider == null)
						{
							this.innerSqlScScheduleHdrDefaultProvider = new SqlScScheduleHdrDefaultProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleHdrDefaultProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleHdrDefaultProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleHdrDefaultProvider SqlScScheduleHdrDefaultProvider
		{
			get {return ScScheduleHdrDefaultProvider as SqlScScheduleHdrDefaultProvider;}
		}
		
		#endregion
		
		
		#region "ScScheduleRsrvProvider"
			
		private SqlScScheduleRsrvProvider innerSqlScScheduleRsrvProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScScheduleRsrv"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScScheduleRsrvProviderBase ScScheduleRsrvProvider
		{
			get
			{
				if (innerSqlScScheduleRsrvProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScScheduleRsrvProvider == null)
						{
							this.innerSqlScScheduleRsrvProvider = new SqlScScheduleRsrvProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScScheduleRsrvProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScScheduleRsrvProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScScheduleRsrvProvider SqlScScheduleRsrvProvider
		{
			get {return ScScheduleRsrvProvider as SqlScScheduleRsrvProvider;}
		}
		
		#endregion
		
		
		#region "ScSectionGroupDtlProvider"
			
		private SqlScSectionGroupDtlProvider innerSqlScSectionGroupDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScSectionGroupDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScSectionGroupDtlProviderBase ScSectionGroupDtlProvider
		{
			get
			{
				if (innerSqlScSectionGroupDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScSectionGroupDtlProvider == null)
						{
							this.innerSqlScSectionGroupDtlProvider = new SqlScSectionGroupDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScSectionGroupDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScSectionGroupDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScSectionGroupDtlProvider SqlScSectionGroupDtlProvider
		{
			get {return ScSectionGroupDtlProvider as SqlScSectionGroupDtlProvider;}
		}
		
		#endregion
		
		
		#region "ScSchdlHdrProvider"
			
		private SqlScSchdlHdrProvider innerSqlScSchdlHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScSchdlHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScSchdlHdrProviderBase ScSchdlHdrProvider
		{
			get
			{
				if (innerSqlScSchdlHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScSchdlHdrProvider == null)
						{
							this.innerSqlScSchdlHdrProvider = new SqlScSchdlHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScSchdlHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScSchdlHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScSchdlHdrProvider SqlScSchdlHdrProvider
		{
			get {return ScSchdlHdrProvider as SqlScSchdlHdrProvider;}
		}
		
		#endregion
		
		
		#region "SaSupervisingJobsProvider"
			
		private SqlSaSupervisingJobsProvider innerSqlSaSupervisingJobsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaSupervisingJobs"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaSupervisingJobsProviderBase SaSupervisingJobsProvider
		{
			get
			{
				if (innerSqlSaSupervisingJobsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaSupervisingJobsProvider == null)
						{
							this.innerSqlSaSupervisingJobsProvider = new SqlSaSupervisingJobsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaSupervisingJobsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaSupervisingJobsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaSupervisingJobsProvider SqlSaSupervisingJobsProvider
		{
			get {return SaSupervisingJobsProvider as SqlSaSupervisingJobsProvider;}
		}
		
		#endregion
		
		
		#region "ScHallRsrvProvider"
			
		private SqlScHallRsrvProvider innerSqlScHallRsrvProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScHallRsrv"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScHallRsrvProviderBase ScHallRsrvProvider
		{
			get
			{
				if (innerSqlScHallRsrvProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScHallRsrvProvider == null)
						{
							this.innerSqlScHallRsrvProvider = new SqlScHallRsrvProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScHallRsrvProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScHallRsrvProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScHallRsrvProvider SqlScHallRsrvProvider
		{
			get {return ScHallRsrvProvider as SqlScHallRsrvProvider;}
		}
		
		#endregion
		
		
		#region "SaStfSummeryTransProvider"
			
		private SqlSaStfSummeryTransProvider innerSqlSaStfSummeryTransProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaStfSummeryTrans"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaStfSummeryTransProviderBase SaStfSummeryTransProvider
		{
			get
			{
				if (innerSqlSaStfSummeryTransProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaStfSummeryTransProvider == null)
						{
							this.innerSqlSaStfSummeryTransProvider = new SqlSaStfSummeryTransProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaStfSummeryTransProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaStfSummeryTransProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaStfSummeryTransProvider SqlSaStfSummeryTransProvider
		{
			get {return SaStfSummeryTransProvider as SqlSaStfSummeryTransProvider;}
		}
		
		#endregion
		
		
		#region "SaTrainingCourseProvider"
			
		private SqlSaTrainingCourseProvider innerSqlSaTrainingCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaTrainingCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaTrainingCourseProviderBase SaTrainingCourseProvider
		{
			get
			{
				if (innerSqlSaTrainingCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaTrainingCourseProvider == null)
						{
							this.innerSqlSaTrainingCourseProvider = new SqlSaTrainingCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaTrainingCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaTrainingCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaTrainingCourseProvider SqlSaTrainingCourseProvider
		{
			get {return SaTrainingCourseProvider as SqlSaTrainingCourseProvider;}
		}
		
		#endregion
		
		
		#region "SaStfDocProvider"
			
		private SqlSaStfDocProvider innerSqlSaStfDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaStfDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaStfDocProviderBase SaStfDocProvider
		{
			get
			{
				if (innerSqlSaStfDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaStfDocProvider == null)
						{
							this.innerSqlSaStfDocProvider = new SqlSaStfDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaStfDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaStfDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaStfDocProvider SqlSaStfDocProvider
		{
			get {return SaStfDocProvider as SqlSaStfDocProvider;}
		}
		
		#endregion
		
		
		#region "SaScResearchProvider"
			
		private SqlSaScResearchProvider innerSqlSaScResearchProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaScResearch"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaScResearchProviderBase SaScResearchProvider
		{
			get
			{
				if (innerSqlSaScResearchProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaScResearchProvider == null)
						{
							this.innerSqlSaScResearchProvider = new SqlSaScResearchProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaScResearchProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaScResearchProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaScResearchProvider SqlSaScResearchProvider
		{
			get {return SaScResearchProvider as SqlSaScResearchProvider;}
		}
		
		#endregion
		
		
		#region "SaStfAttendProvider"
			
		private SqlSaStfAttendProvider innerSqlSaStfAttendProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaStfAttend"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaStfAttendProviderBase SaStfAttendProvider
		{
			get
			{
				if (innerSqlSaStfAttendProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaStfAttendProvider == null)
						{
							this.innerSqlSaStfAttendProvider = new SqlSaStfAttendProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaStfAttendProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaStfAttendProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaStfAttendProvider SqlSaStfAttendProvider
		{
			get {return SaStfAttendProvider as SqlSaStfAttendProvider;}
		}
		
		#endregion
		
		
		#region "SaVacationBylawsProvider"
			
		private SqlSaVacationBylawsProvider innerSqlSaVacationBylawsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaVacationBylaws"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaVacationBylawsProviderBase SaVacationBylawsProvider
		{
			get
			{
				if (innerSqlSaVacationBylawsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaVacationBylawsProvider == null)
						{
							this.innerSqlSaVacationBylawsProvider = new SqlSaVacationBylawsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaVacationBylawsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaVacationBylawsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaVacationBylawsProvider SqlSaVacationBylawsProvider
		{
			get {return SaVacationBylawsProvider as SqlSaVacationBylawsProvider;}
		}
		
		#endregion
		
		
		#region "SaServTerminProvider"
			
		private SqlSaServTerminProvider innerSqlSaServTerminProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaServTermin"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaServTerminProviderBase SaServTerminProvider
		{
			get
			{
				if (innerSqlSaServTerminProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaServTerminProvider == null)
						{
							this.innerSqlSaServTerminProvider = new SqlSaServTerminProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaServTerminProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaServTerminProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaServTerminProvider SqlSaServTerminProvider
		{
			get {return SaServTerminProvider as SqlSaServTerminProvider;}
		}
		
		#endregion
		
		
		#region "SaVacationRenewProvider"
			
		private SqlSaVacationRenewProvider innerSqlSaVacationRenewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaVacationRenew"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaVacationRenewProviderBase SaVacationRenewProvider
		{
			get
			{
				if (innerSqlSaVacationRenewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaVacationRenewProvider == null)
						{
							this.innerSqlSaVacationRenewProvider = new SqlSaVacationRenewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaVacationRenewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaVacationRenewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaVacationRenewProvider SqlSaVacationRenewProvider
		{
			get {return SaVacationRenewProvider as SqlSaVacationRenewProvider;}
		}
		
		#endregion
		
		
		#region "ScCdeHallEquipProvider"
			
		private SqlScCdeHallEquipProvider innerSqlScCdeHallEquipProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScCdeHallEquip"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScCdeHallEquipProviderBase ScCdeHallEquipProvider
		{
			get
			{
				if (innerSqlScCdeHallEquipProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScCdeHallEquipProvider == null)
						{
							this.innerSqlScCdeHallEquipProvider = new SqlScCdeHallEquipProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScCdeHallEquipProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScCdeHallEquipProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScCdeHallEquipProvider SqlScCdeHallEquipProvider
		{
			get {return ScCdeHallEquipProvider as SqlScCdeHallEquipProvider;}
		}
		
		#endregion
		
		
		#region "ScDaySlotProvider"
			
		private SqlScDaySlotProvider innerSqlScDaySlotProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScDaySlot"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScDaySlotProviderBase ScDaySlotProvider
		{
			get
			{
				if (innerSqlScDaySlotProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScDaySlotProvider == null)
						{
							this.innerSqlScDaySlotProvider = new SqlScDaySlotProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScDaySlotProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScDaySlotProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScDaySlotProvider SqlScDaySlotProvider
		{
			get {return ScDaySlotProvider as SqlScDaySlotProvider;}
		}
		
		#endregion
		
		
		#region "ScGroupStaffProvider"
			
		private SqlScGroupStaffProvider innerSqlScGroupStaffProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScGroupStaff"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScGroupStaffProviderBase ScGroupStaffProvider
		{
			get
			{
				if (innerSqlScGroupStaffProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScGroupStaffProvider == null)
						{
							this.innerSqlScGroupStaffProvider = new SqlScGroupStaffProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScGroupStaffProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScGroupStaffProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScGroupStaffProvider SqlScGroupStaffProvider
		{
			get {return ScGroupStaffProvider as SqlScGroupStaffProvider;}
		}
		
		#endregion
		
		
		#region "ScHallEquipProvider"
			
		private SqlScHallEquipProvider innerSqlScHallEquipProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScHallEquip"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScHallEquipProviderBase ScHallEquipProvider
		{
			get
			{
				if (innerSqlScHallEquipProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScHallEquipProvider == null)
						{
							this.innerSqlScHallEquipProvider = new SqlScHallEquipProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScHallEquipProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScHallEquipProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScHallEquipProvider SqlScHallEquipProvider
		{
			get {return ScHallEquipProvider as SqlScHallEquipProvider;}
		}
		
		#endregion
		
		
		#region "ScCdeActvtyProvider"
			
		private SqlScCdeActvtyProvider innerSqlScCdeActvtyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ScCdeActvty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ScCdeActvtyProviderBase ScCdeActvtyProvider
		{
			get
			{
				if (innerSqlScCdeActvtyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlScCdeActvtyProvider == null)
						{
							this.innerSqlScCdeActvtyProvider = new SqlScCdeActvtyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlScCdeActvtyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlScCdeActvtyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlScCdeActvtyProvider SqlScCdeActvtyProvider
		{
			get {return ScCdeActvtyProvider as SqlScCdeActvtyProvider;}
		}
		
		#endregion
		
		
		#region "SaWarningAddTypeProvider"
			
		private SqlSaWarningAddTypeProvider innerSqlSaWarningAddTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaWarningAddType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaWarningAddTypeProviderBase SaWarningAddTypeProvider
		{
			get
			{
				if (innerSqlSaWarningAddTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaWarningAddTypeProvider == null)
						{
							this.innerSqlSaWarningAddTypeProvider = new SqlSaWarningAddTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaWarningAddTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaWarningAddTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaWarningAddTypeProvider SqlSaWarningAddTypeProvider
		{
			get {return SaWarningAddTypeProvider as SqlSaWarningAddTypeProvider;}
		}
		
		#endregion
		
		
		#region "SaWarningProvider"
			
		private SqlSaWarningProvider innerSqlSaWarningProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaWarning"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaWarningProviderBase SaWarningProvider
		{
			get
			{
				if (innerSqlSaWarningProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaWarningProvider == null)
						{
							this.innerSqlSaWarningProvider = new SqlSaWarningProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaWarningProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaWarningProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaWarningProvider SqlSaWarningProvider
		{
			get {return SaWarningProvider as SqlSaWarningProvider;}
		}
		
		#endregion
		
		
		#region "SaVacationRuleProvider"
			
		private SqlSaVacationRuleProvider innerSqlSaVacationRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaVacationRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaVacationRuleProviderBase SaVacationRuleProvider
		{
			get
			{
				if (innerSqlSaVacationRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaVacationRuleProvider == null)
						{
							this.innerSqlSaVacationRuleProvider = new SqlSaVacationRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaVacationRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaVacationRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaVacationRuleProvider SqlSaVacationRuleProvider
		{
			get {return SaVacationRuleProvider as SqlSaVacationRuleProvider;}
		}
		
		#endregion
		
		
		#region "SaVacationBalanceHProvider"
			
		private SqlSaVacationBalanceHProvider innerSqlSaVacationBalanceHProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaVacationBalanceH"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaVacationBalanceHProviderBase SaVacationBalanceHProvider
		{
			get
			{
				if (innerSqlSaVacationBalanceHProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaVacationBalanceHProvider == null)
						{
							this.innerSqlSaVacationBalanceHProvider = new SqlSaVacationBalanceHProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaVacationBalanceHProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaVacationBalanceHProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaVacationBalanceHProvider SqlSaVacationBalanceHProvider
		{
			get {return SaVacationBalanceHProvider as SqlSaVacationBalanceHProvider;}
		}
		
		#endregion
		
		
		#region "SaVacationBalanceProvider"
			
		private SqlSaVacationBalanceProvider innerSqlSaVacationBalanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaVacationBalance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaVacationBalanceProviderBase SaVacationBalanceProvider
		{
			get
			{
				if (innerSqlSaVacationBalanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaVacationBalanceProvider == null)
						{
							this.innerSqlSaVacationBalanceProvider = new SqlSaVacationBalanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaVacationBalanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaVacationBalanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaVacationBalanceProvider SqlSaVacationBalanceProvider
		{
			get {return SaVacationBalanceProvider as SqlSaVacationBalanceProvider;}
		}
		
		#endregion
		
		
		#region "SaVacationProvider"
			
		private SqlSaVacationProvider innerSqlSaVacationProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SaVacation"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SaVacationProviderBase SaVacationProvider
		{
			get
			{
				if (innerSqlSaVacationProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSaVacationProvider == null)
						{
							this.innerSqlSaVacationProvider = new SqlSaVacationProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSaVacationProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlSaVacationProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSaVacationProvider SqlSaVacationProvider
		{
			get {return SaVacationProvider as SqlSaVacationProvider;}
		}
		
		#endregion
		
		
		#region "FeeItemPaymentWaysProvider"
			
		private SqlFeeItemPaymentWaysProvider innerSqlFeeItemPaymentWaysProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeItemPaymentWays"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeItemPaymentWaysProviderBase FeeItemPaymentWaysProvider
		{
			get
			{
				if (innerSqlFeeItemPaymentWaysProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeItemPaymentWaysProvider == null)
						{
							this.innerSqlFeeItemPaymentWaysProvider = new SqlFeeItemPaymentWaysProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeItemPaymentWaysProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeItemPaymentWaysProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeItemPaymentWaysProvider SqlFeeItemPaymentWaysProvider
		{
			get {return FeeItemPaymentWaysProvider as SqlFeeItemPaymentWaysProvider;}
		}
		
		#endregion
		
		
		#region "FeeInvoiceItemProvider"
			
		private SqlFeeInvoiceItemProvider innerSqlFeeInvoiceItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeInvoiceItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeInvoiceItemProviderBase FeeInvoiceItemProvider
		{
			get
			{
				if (innerSqlFeeInvoiceItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeInvoiceItemProvider == null)
						{
							this.innerSqlFeeInvoiceItemProvider = new SqlFeeInvoiceItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeInvoiceItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeInvoiceItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeInvoiceItemProvider SqlFeeInvoiceItemProvider
		{
			get {return FeeInvoiceItemProvider as SqlFeeInvoiceItemProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeUnitProvider"
			
		private SqlCtrCdeUnitProvider innerSqlCtrCdeUnitProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeUnit"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeUnitProviderBase CtrCdeUnitProvider
		{
			get
			{
				if (innerSqlCtrCdeUnitProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeUnitProvider == null)
						{
							this.innerSqlCtrCdeUnitProvider = new SqlCtrCdeUnitProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeUnitProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeUnitProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeUnitProvider SqlCtrCdeUnitProvider
		{
			get {return CtrCdeUnitProvider as SqlCtrCdeUnitProvider;}
		}
		
		#endregion
		
		
		#region "FeeInvoiceProvider"
			
		private SqlFeeInvoiceProvider innerSqlFeeInvoiceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeInvoice"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeInvoiceProviderBase FeeInvoiceProvider
		{
			get
			{
				if (innerSqlFeeInvoiceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeInvoiceProvider == null)
						{
							this.innerSqlFeeInvoiceProvider = new SqlFeeInvoiceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeInvoiceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeInvoiceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeInvoiceProvider SqlFeeInvoiceProvider
		{
			get {return FeeInvoiceProvider as SqlFeeInvoiceProvider;}
		}
		
		#endregion
		
		
		#region "CtrKtchnStfCrtfProvider"
			
		private SqlCtrKtchnStfCrtfProvider innerSqlCtrKtchnStfCrtfProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrKtchnStfCrtf"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrKtchnStfCrtfProviderBase CtrKtchnStfCrtfProvider
		{
			get
			{
				if (innerSqlCtrKtchnStfCrtfProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrKtchnStfCrtfProvider == null)
						{
							this.innerSqlCtrKtchnStfCrtfProvider = new SqlCtrKtchnStfCrtfProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrKtchnStfCrtfProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrKtchnStfCrtfProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrKtchnStfCrtfProvider SqlCtrKtchnStfCrtfProvider
		{
			get {return CtrKtchnStfCrtfProvider as SqlCtrKtchnStfCrtfProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeSrvcJobProvider"
			
		private SqlCtrCdeSrvcJobProvider innerSqlCtrCdeSrvcJobProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeSrvcJob"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeSrvcJobProviderBase CtrCdeSrvcJobProvider
		{
			get
			{
				if (innerSqlCtrCdeSrvcJobProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeSrvcJobProvider == null)
						{
							this.innerSqlCtrCdeSrvcJobProvider = new SqlCtrCdeSrvcJobProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeSrvcJobProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeSrvcJobProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeSrvcJobProvider SqlCtrCdeSrvcJobProvider
		{
			get {return CtrCdeSrvcJobProvider as SqlCtrCdeSrvcJobProvider;}
		}
		
		#endregion
		
		
		#region "CtrSrvcCrewProvider"
			
		private SqlCtrSrvcCrewProvider innerSqlCtrSrvcCrewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrSrvcCrew"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrSrvcCrewProviderBase CtrSrvcCrewProvider
		{
			get
			{
				if (innerSqlCtrSrvcCrewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrSrvcCrewProvider == null)
						{
							this.innerSqlCtrSrvcCrewProvider = new SqlCtrSrvcCrewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrSrvcCrewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrSrvcCrewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrSrvcCrewProvider SqlCtrSrvcCrewProvider
		{
			get {return CtrSrvcCrewProvider as SqlCtrSrvcCrewProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeSrvMthdProvider"
			
		private SqlCtrCdeSrvMthdProvider innerSqlCtrCdeSrvMthdProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeSrvMthd"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeSrvMthdProviderBase CtrCdeSrvMthdProvider
		{
			get
			{
				if (innerSqlCtrCdeSrvMthdProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeSrvMthdProvider == null)
						{
							this.innerSqlCtrCdeSrvMthdProvider = new SqlCtrCdeSrvMthdProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeSrvMthdProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeSrvMthdProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeSrvMthdProvider SqlCtrCdeSrvMthdProvider
		{
			get {return CtrCdeSrvMthdProvider as SqlCtrCdeSrvMthdProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeMealProvider"
			
		private SqlCtrCdeMealProvider innerSqlCtrCdeMealProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeMeal"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeMealProviderBase CtrCdeMealProvider
		{
			get
			{
				if (innerSqlCtrCdeMealProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeMealProvider == null)
						{
							this.innerSqlCtrCdeMealProvider = new SqlCtrCdeMealProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeMealProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeMealProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeMealProvider SqlCtrCdeMealProvider
		{
			get {return CtrCdeMealProvider as SqlCtrCdeMealProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeSpclMealProvider"
			
		private SqlCtrCdeSpclMealProvider innerSqlCtrCdeSpclMealProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeSpclMeal"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeSpclMealProviderBase CtrCdeSpclMealProvider
		{
			get
			{
				if (innerSqlCtrCdeSpclMealProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeSpclMealProvider == null)
						{
							this.innerSqlCtrCdeSpclMealProvider = new SqlCtrCdeSpclMealProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeSpclMealProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeSpclMealProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeSpclMealProvider SqlCtrCdeSpclMealProvider
		{
			get {return CtrCdeSpclMealProvider as SqlCtrCdeSpclMealProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeMealItemProvider"
			
		private SqlCtrCdeMealItemProvider innerSqlCtrCdeMealItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeMealItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeMealItemProviderBase CtrCdeMealItemProvider
		{
			get
			{
				if (innerSqlCtrCdeMealItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeMealItemProvider == null)
						{
							this.innerSqlCtrCdeMealItemProvider = new SqlCtrCdeMealItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeMealItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeMealItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeMealItemProvider SqlCtrCdeMealItemProvider
		{
			get {return CtrCdeMealItemProvider as SqlCtrCdeMealItemProvider;}
		}
		
		#endregion
		
		
		#region "CtrStudExpProvider"
			
		private SqlCtrStudExpProvider innerSqlCtrStudExpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrStudExp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrStudExpProviderBase CtrStudExpProvider
		{
			get
			{
				if (innerSqlCtrStudExpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrStudExpProvider == null)
						{
							this.innerSqlCtrStudExpProvider = new SqlCtrStudExpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrStudExpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrStudExpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrStudExpProvider SqlCtrStudExpProvider
		{
			get {return CtrStudExpProvider as SqlCtrStudExpProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeOutRsnProvider"
			
		private SqlCtrCdeOutRsnProvider innerSqlCtrCdeOutRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeOutRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeOutRsnProviderBase CtrCdeOutRsnProvider
		{
			get
			{
				if (innerSqlCtrCdeOutRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeOutRsnProvider == null)
						{
							this.innerSqlCtrCdeOutRsnProvider = new SqlCtrCdeOutRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeOutRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeOutRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeOutRsnProvider SqlCtrCdeOutRsnProvider
		{
			get {return CtrCdeOutRsnProvider as SqlCtrCdeOutRsnProvider;}
		}
		
		#endregion
		
		
		#region "EdBranchRuleProvider"
			
		private SqlEdBranchRuleProvider innerSqlEdBranchRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdBranchRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdBranchRuleProviderBase EdBranchRuleProvider
		{
			get
			{
				if (innerSqlEdBranchRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdBranchRuleProvider == null)
						{
							this.innerSqlEdBranchRuleProvider = new SqlEdBranchRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdBranchRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdBranchRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdBranchRuleProvider SqlEdBranchRuleProvider
		{
			get {return EdBranchRuleProvider as SqlEdBranchRuleProvider;}
		}
		
		#endregion
		
		
		#region "CtrStudOutProvider"
			
		private SqlCtrStudOutProvider innerSqlCtrStudOutProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrStudOut"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrStudOutProviderBase CtrStudOutProvider
		{
			get
			{
				if (innerSqlCtrStudOutProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrStudOutProvider == null)
						{
							this.innerSqlCtrStudOutProvider = new SqlCtrStudOutProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrStudOutProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrStudOutProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrStudOutProvider SqlCtrStudOutProvider
		{
			get {return CtrStudOutProvider as SqlCtrStudOutProvider;}
		}
		
		#endregion
		
		
		#region "EdBylawProvider"
			
		private SqlEdBylawProvider innerSqlEdBylawProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdBylaw"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdBylawProviderBase EdBylawProvider
		{
			get
			{
				if (innerSqlEdBylawProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdBylawProvider == null)
						{
							this.innerSqlEdBylawProvider = new SqlEdBylawProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdBylawProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdBylawProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdBylawProvider SqlEdBylawProvider
		{
			get {return EdBylawProvider as SqlEdBylawProvider;}
		}
		
		#endregion
		
		
		#region "EdBranchCrsProvider"
			
		private SqlEdBranchCrsProvider innerSqlEdBranchCrsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdBranchCrs"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdBranchCrsProviderBase EdBranchCrsProvider
		{
			get
			{
				if (innerSqlEdBranchCrsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdBranchCrsProvider == null)
						{
							this.innerSqlEdBranchCrsProvider = new SqlEdBranchCrsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdBranchCrsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdBranchCrsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdBranchCrsProvider SqlEdBranchCrsProvider
		{
			get {return EdBranchCrsProvider as SqlEdBranchCrsProvider;}
		}
		
		#endregion
		
		
		#region "EdAcdadvRmkProvider"
			
		private SqlEdAcdadvRmkProvider innerSqlEdAcdadvRmkProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAcdadvRmk"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAcdadvRmkProviderBase EdAcdadvRmkProvider
		{
			get
			{
				if (innerSqlEdAcdadvRmkProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAcdadvRmkProvider == null)
						{
							this.innerSqlEdAcdadvRmkProvider = new SqlEdAcdadvRmkProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAcdadvRmkProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAcdadvRmkProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAcdadvRmkProvider SqlEdAcdadvRmkProvider
		{
			get {return EdAcdadvRmkProvider as SqlEdAcdadvRmkProvider;}
		}
		
		#endregion
		
		
		#region "EdAcadYearFacultyProvider"
			
		private SqlEdAcadYearFacultyProvider innerSqlEdAcadYearFacultyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAcadYearFaculty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAcadYearFacultyProviderBase EdAcadYearFacultyProvider
		{
			get
			{
				if (innerSqlEdAcadYearFacultyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAcadYearFacultyProvider == null)
						{
							this.innerSqlEdAcadYearFacultyProvider = new SqlEdAcadYearFacultyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAcadYearFacultyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAcadYearFacultyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAcadYearFacultyProvider SqlEdAcadYearFacultyProvider
		{
			get {return EdAcadYearFacultyProvider as SqlEdAcadYearFacultyProvider;}
		}
		
		#endregion
		
		
		#region "EdAcadPlanProvider"
			
		private SqlEdAcadPlanProvider innerSqlEdAcadPlanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAcadPlan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAcadPlanProviderBase EdAcadPlanProvider
		{
			get
			{
				if (innerSqlEdAcadPlanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAcadPlanProvider == null)
						{
							this.innerSqlEdAcadPlanProvider = new SqlEdAcadPlanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAcadPlanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAcadPlanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAcadPlanProvider SqlEdAcadPlanProvider
		{
			get {return EdAcadPlanProvider as SqlEdAcadPlanProvider;}
		}
		
		#endregion
		
		
		#region "EdAbsenceApproveProvider"
			
		private SqlEdAbsenceApproveProvider innerSqlEdAbsenceApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAbsenceApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAbsenceApproveProviderBase EdAbsenceApproveProvider
		{
			get
			{
				if (innerSqlEdAbsenceApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAbsenceApproveProvider == null)
						{
							this.innerSqlEdAbsenceApproveProvider = new SqlEdAbsenceApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAbsenceApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAbsenceApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAbsenceApproveProvider SqlEdAbsenceApproveProvider
		{
			get {return EdAbsenceApproveProvider as SqlEdAbsenceApproveProvider;}
		}
		
		#endregion
		
		
		#region "EdAcadPlanDtlProvider"
			
		private SqlEdAcadPlanDtlProvider innerSqlEdAcadPlanDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAcadPlanDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAcadPlanDtlProviderBase EdAcadPlanDtlProvider
		{
			get
			{
				if (innerSqlEdAcadPlanDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAcadPlanDtlProvider == null)
						{
							this.innerSqlEdAcadPlanDtlProvider = new SqlEdAcadPlanDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAcadPlanDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAcadPlanDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAcadPlanDtlProvider SqlEdAcadPlanDtlProvider
		{
			get {return EdAcadPlanDtlProvider as SqlEdAcadPlanDtlProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeKtchnJobProvider"
			
		private SqlCtrCdeKtchnJobProvider innerSqlCtrCdeKtchnJobProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeKtchnJob"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeKtchnJobProviderBase CtrCdeKtchnJobProvider
		{
			get
			{
				if (innerSqlCtrCdeKtchnJobProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeKtchnJobProvider == null)
						{
							this.innerSqlCtrCdeKtchnJobProvider = new SqlCtrCdeKtchnJobProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeKtchnJobProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeKtchnJobProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeKtchnJobProvider SqlCtrCdeKtchnJobProvider
		{
			get {return CtrCdeKtchnJobProvider as SqlCtrCdeKtchnJobProvider;}
		}
		
		#endregion
		
		
		#region "EdAcadPlanHdrProvider"
			
		private SqlEdAcadPlanHdrProvider innerSqlEdAcadPlanHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdAcadPlanHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdAcadPlanHdrProviderBase EdAcadPlanHdrProvider
		{
			get
			{
				if (innerSqlEdAcadPlanHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdAcadPlanHdrProvider == null)
						{
							this.innerSqlEdAcadPlanHdrProvider = new SqlEdAcadPlanHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdAcadPlanHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdAcadPlanHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdAcadPlanHdrProvider SqlEdAcadPlanHdrProvider
		{
			get {return EdAcadPlanHdrProvider as SqlEdAcadPlanHdrProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeItemTypeProvider"
			
		private SqlCtrCdeItemTypeProvider innerSqlCtrCdeItemTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeItemType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeItemTypeProviderBase CtrCdeItemTypeProvider
		{
			get
			{
				if (innerSqlCtrCdeItemTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeItemTypeProvider == null)
						{
							this.innerSqlCtrCdeItemTypeProvider = new SqlCtrCdeItemTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeItemTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeItemTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeItemTypeProvider SqlCtrCdeItemTypeProvider
		{
			get {return CtrCdeItemTypeProvider as SqlCtrCdeItemTypeProvider;}
		}
		
		#endregion
		
		
		#region "CtrCdeExpRsnProvider"
			
		private SqlCtrCdeExpRsnProvider innerSqlCtrCdeExpRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrCdeExpRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrCdeExpRsnProviderBase CtrCdeExpRsnProvider
		{
			get
			{
				if (innerSqlCtrCdeExpRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrCdeExpRsnProvider == null)
						{
							this.innerSqlCtrCdeExpRsnProvider = new SqlCtrCdeExpRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrCdeExpRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrCdeExpRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrCdeExpRsnProvider SqlCtrCdeExpRsnProvider
		{
			get {return CtrCdeExpRsnProvider as SqlCtrCdeExpRsnProvider;}
		}
		
		#endregion
		
		
		#region "CoControlProvider"
			
		private SqlCoControlProvider innerSqlCoControlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoControl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoControlProviderBase CoControlProvider
		{
			get
			{
				if (innerSqlCoControlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoControlProvider == null)
						{
							this.innerSqlCoControlProvider = new SqlCoControlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoControlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoControlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoControlProvider SqlCoControlProvider
		{
			get {return CoControlProvider as SqlCoControlProvider;}
		}
		
		#endregion
		
		
		#region "CoControlMemberProvider"
			
		private SqlCoControlMemberProvider innerSqlCoControlMemberProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoControlMember"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoControlMemberProviderBase CoControlMemberProvider
		{
			get
			{
				if (innerSqlCoControlMemberProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoControlMemberProvider == null)
						{
							this.innerSqlCoControlMemberProvider = new SqlCoControlMemberProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoControlMemberProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoControlMemberProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoControlMemberProvider SqlCoControlMemberProvider
		{
			get {return CoControlMemberProvider as SqlCoControlMemberProvider;}
		}
		
		#endregion
		
		
		#region "CtrMenuProvider"
			
		private SqlCtrMenuProvider innerSqlCtrMenuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrMenu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrMenuProviderBase CtrMenuProvider
		{
			get
			{
				if (innerSqlCtrMenuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrMenuProvider == null)
						{
							this.innerSqlCtrMenuProvider = new SqlCtrMenuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrMenuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrMenuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrMenuProvider SqlCtrMenuProvider
		{
			get {return CtrMenuProvider as SqlCtrMenuProvider;}
		}
		
		#endregion
		
		
		#region "CoControlRoomProvider"
			
		private SqlCoControlRoomProvider innerSqlCoControlRoomProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoControlRoom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoControlRoomProviderBase CoControlRoomProvider
		{
			get
			{
				if (innerSqlCoControlRoomProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoControlRoomProvider == null)
						{
							this.innerSqlCoControlRoomProvider = new SqlCoControlRoomProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoControlRoomProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoControlRoomProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoControlRoomProvider SqlCoControlRoomProvider
		{
			get {return CoControlRoomProvider as SqlCoControlRoomProvider;}
		}
		
		#endregion
		
		
		#region "CoCourseResultProvider"
			
		private SqlCoCourseResultProvider innerSqlCoCourseResultProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoCourseResult"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoCourseResultProviderBase CoCourseResultProvider
		{
			get
			{
				if (innerSqlCoCourseResultProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoCourseResultProvider == null)
						{
							this.innerSqlCoCourseResultProvider = new SqlCoCourseResultProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoCourseResultProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoCourseResultProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoCourseResultProvider SqlCoCourseResultProvider
		{
			get {return CoCourseResultProvider as SqlCoCourseResultProvider;}
		}
		
		#endregion
		
		
		#region "CoContRoomMemberProvider"
			
		private SqlCoContRoomMemberProvider innerSqlCoContRoomMemberProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoContRoomMember"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoContRoomMemberProviderBase CoContRoomMemberProvider
		{
			get
			{
				if (innerSqlCoContRoomMemberProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoContRoomMemberProvider == null)
						{
							this.innerSqlCoContRoomMemberProvider = new SqlCoContRoomMemberProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoContRoomMemberProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoContRoomMemberProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoContRoomMemberProvider SqlCoContRoomMemberProvider
		{
			get {return CoContRoomMemberProvider as SqlCoContRoomMemberProvider;}
		}
		
		#endregion
		
		
		#region "CoContRmMemCourseProvider"
			
		private SqlCoContRmMemCourseProvider innerSqlCoContRmMemCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoContRmMemCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoContRmMemCourseProviderBase CoContRmMemCourseProvider
		{
			get
			{
				if (innerSqlCoContRmMemCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoContRmMemCourseProvider == null)
						{
							this.innerSqlCoContRmMemCourseProvider = new SqlCoContRmMemCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoContRmMemCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoContRmMemCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoContRmMemCourseProvider SqlCoContRmMemCourseProvider
		{
			get {return CoContRmMemCourseProvider as SqlCoContRmMemCourseProvider;}
		}
		
		#endregion
		
		
		#region "AdmTransferAcceptanceProvider"
			
		private SqlAdmTransferAcceptanceProvider innerSqlAdmTransferAcceptanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmTransferAcceptance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmTransferAcceptanceProviderBase AdmTransferAcceptanceProvider
		{
			get
			{
				if (innerSqlAdmTransferAcceptanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmTransferAcceptanceProvider == null)
						{
							this.innerSqlAdmTransferAcceptanceProvider = new SqlAdmTransferAcceptanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmTransferAcceptanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmTransferAcceptanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmTransferAcceptanceProvider SqlAdmTransferAcceptanceProvider
		{
			get {return AdmTransferAcceptanceProvider as SqlAdmTransferAcceptanceProvider;}
		}
		
		#endregion
		
		
		#region "AlmJobProvider"
			
		private SqlAlmJobProvider innerSqlAlmJobProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AlmJob"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AlmJobProviderBase AlmJobProvider
		{
			get
			{
				if (innerSqlAlmJobProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAlmJobProvider == null)
						{
							this.innerSqlAlmJobProvider = new SqlAlmJobProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAlmJobProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAlmJobProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAlmJobProvider SqlAlmJobProvider
		{
			get {return AlmJobProvider as SqlAlmJobProvider;}
		}
		
		#endregion
		
		
		#region "AlmPrintRequestProvider"
			
		private SqlAlmPrintRequestProvider innerSqlAlmPrintRequestProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AlmPrintRequest"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AlmPrintRequestProviderBase AlmPrintRequestProvider
		{
			get
			{
				if (innerSqlAlmPrintRequestProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAlmPrintRequestProvider == null)
						{
							this.innerSqlAlmPrintRequestProvider = new SqlAlmPrintRequestProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAlmPrintRequestProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAlmPrintRequestProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAlmPrintRequestProvider SqlAlmPrintRequestProvider
		{
			get {return AlmPrintRequestProvider as SqlAlmPrintRequestProvider;}
		}
		
		#endregion
		
		
		#region "AppTypeRegStepsProvider"
			
		private SqlAppTypeRegStepsProvider innerSqlAppTypeRegStepsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AppTypeRegSteps"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AppTypeRegStepsProviderBase AppTypeRegStepsProvider
		{
			get
			{
				if (innerSqlAppTypeRegStepsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAppTypeRegStepsProvider == null)
						{
							this.innerSqlAppTypeRegStepsProvider = new SqlAppTypeRegStepsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAppTypeRegStepsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAppTypeRegStepsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAppTypeRegStepsProvider SqlAppTypeRegStepsProvider
		{
			get {return AppTypeRegStepsProvider as SqlAppTypeRegStepsProvider;}
		}
		
		#endregion
		
		
		#region "CoClemRuleFacProvider"
			
		private SqlCoClemRuleFacProvider innerSqlCoClemRuleFacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoClemRuleFac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoClemRuleFacProviderBase CoClemRuleFacProvider
		{
			get
			{
				if (innerSqlCoClemRuleFacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoClemRuleFacProvider == null)
						{
							this.innerSqlCoClemRuleFacProvider = new SqlCoClemRuleFacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoClemRuleFacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoClemRuleFacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoClemRuleFacProvider SqlCoClemRuleFacProvider
		{
			get {return CoClemRuleFacProvider as SqlCoClemRuleFacProvider;}
		}
		
		#endregion
		
		
		#region "CoCrsRsltRaiseProvider"
			
		private SqlCoCrsRsltRaiseProvider innerSqlCoCrsRsltRaiseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoCrsRsltRaise"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoCrsRsltRaiseProviderBase CoCrsRsltRaiseProvider
		{
			get
			{
				if (innerSqlCoCrsRsltRaiseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoCrsRsltRaiseProvider == null)
						{
							this.innerSqlCoCrsRsltRaiseProvider = new SqlCoCrsRsltRaiseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoCrsRsltRaiseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoCrsRsltRaiseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoCrsRsltRaiseProvider SqlCoCrsRsltRaiseProvider
		{
			get {return CoCrsRsltRaiseProvider as SqlCoCrsRsltRaiseProvider;}
		}
		
		#endregion
		
		
		#region "CtrMenuItemProvider"
			
		private SqlCtrMenuItemProvider innerSqlCtrMenuItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrMenuItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrMenuItemProviderBase CtrMenuItemProvider
		{
			get
			{
				if (innerSqlCtrMenuItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrMenuItemProvider == null)
						{
							this.innerSqlCtrMenuItemProvider = new SqlCtrMenuItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrMenuItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrMenuItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrMenuItemProvider SqlCtrMenuItemProvider
		{
			get {return CtrMenuItemProvider as SqlCtrMenuItemProvider;}
		}
		
		#endregion
		
		
		#region "CoExamPaperProvider"
			
		private SqlCoExamPaperProvider innerSqlCoExamPaperProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExamPaper"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExamPaperProviderBase CoExamPaperProvider
		{
			get
			{
				if (innerSqlCoExamPaperProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExamPaperProvider == null)
						{
							this.innerSqlCoExamPaperProvider = new SqlCoExamPaperProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExamPaperProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExamPaperProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExamPaperProvider SqlCoExamPaperProvider
		{
			get {return CoExamPaperProvider as SqlCoExamPaperProvider;}
		}
		
		#endregion
		
		
		#region "CoExaminerCorectorProvider"
			
		private SqlCoExaminerCorectorProvider innerSqlCoExaminerCorectorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExaminerCorector"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExaminerCorectorProviderBase CoExaminerCorectorProvider
		{
			get
			{
				if (innerSqlCoExaminerCorectorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExaminerCorectorProvider == null)
						{
							this.innerSqlCoExaminerCorectorProvider = new SqlCoExaminerCorectorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExaminerCorectorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExaminerCorectorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExaminerCorectorProvider SqlCoExaminerCorectorProvider
		{
			get {return CoExaminerCorectorProvider as SqlCoExaminerCorectorProvider;}
		}
		
		#endregion
		
		
		#region "CoScheduleDetailProvider"
			
		private SqlCoScheduleDetailProvider innerSqlCoScheduleDetailProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoScheduleDetail"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoScheduleDetailProviderBase CoScheduleDetailProvider
		{
			get
			{
				if (innerSqlCoScheduleDetailProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoScheduleDetailProvider == null)
						{
							this.innerSqlCoScheduleDetailProvider = new SqlCoScheduleDetailProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoScheduleDetailProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoScheduleDetailProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoScheduleDetailProvider SqlCoScheduleDetailProvider
		{
			get {return CoScheduleDetailProvider as SqlCoScheduleDetailProvider;}
		}
		
		#endregion
		
		
		#region "CoSupervisorStudCountProvider"
			
		private SqlCoSupervisorStudCountProvider innerSqlCoSupervisorStudCountProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoSupervisorStudCount"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoSupervisorStudCountProviderBase CoSupervisorStudCountProvider
		{
			get
			{
				if (innerSqlCoSupervisorStudCountProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoSupervisorStudCountProvider == null)
						{
							this.innerSqlCoSupervisorStudCountProvider = new SqlCoSupervisorStudCountProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoSupervisorStudCountProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoSupervisorStudCountProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoSupervisorStudCountProvider SqlCoSupervisorStudCountProvider
		{
			get {return CoSupervisorStudCountProvider as SqlCoSupervisorStudCountProvider;}
		}
		
		#endregion
		
		
		#region "CoExamCommitteeProvider"
			
		private SqlCoExamCommitteeProvider innerSqlCoExamCommitteeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExamCommittee"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExamCommitteeProviderBase CoExamCommitteeProvider
		{
			get
			{
				if (innerSqlCoExamCommitteeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExamCommitteeProvider == null)
						{
							this.innerSqlCoExamCommitteeProvider = new SqlCoExamCommitteeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExamCommitteeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExamCommitteeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExamCommitteeProvider SqlCoExamCommitteeProvider
		{
			get {return CoExamCommitteeProvider as SqlCoExamCommitteeProvider;}
		}
		
		#endregion
		
		
		#region "CoExamCommSupervisorAltProvider"
			
		private SqlCoExamCommSupervisorAltProvider innerSqlCoExamCommSupervisorAltProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExamCommSupervisorAlt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExamCommSupervisorAltProviderBase CoExamCommSupervisorAltProvider
		{
			get
			{
				if (innerSqlCoExamCommSupervisorAltProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExamCommSupervisorAltProvider == null)
						{
							this.innerSqlCoExamCommSupervisorAltProvider = new SqlCoExamCommSupervisorAltProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExamCommSupervisorAltProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExamCommSupervisorAltProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExamCommSupervisorAltProvider SqlCoExamCommSupervisorAltProvider
		{
			get {return CoExamCommSupervisorAltProvider as SqlCoExamCommSupervisorAltProvider;}
		}
		
		#endregion
		
		
		#region "CtrMenuActProvider"
			
		private SqlCtrMenuActProvider innerSqlCtrMenuActProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrMenuAct"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrMenuActProviderBase CtrMenuActProvider
		{
			get
			{
				if (innerSqlCtrMenuActProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrMenuActProvider == null)
						{
							this.innerSqlCtrMenuActProvider = new SqlCtrMenuActProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrMenuActProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrMenuActProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrMenuActProvider SqlCtrMenuActProvider
		{
			get {return CtrMenuActProvider as SqlCtrMenuActProvider;}
		}
		
		#endregion
		
		
		#region "CtrMenuActItemProvider"
			
		private SqlCtrMenuActItemProvider innerSqlCtrMenuActItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrMenuActItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrMenuActItemProviderBase CtrMenuActItemProvider
		{
			get
			{
				if (innerSqlCtrMenuActItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrMenuActItemProvider == null)
						{
							this.innerSqlCtrMenuActItemProvider = new SqlCtrMenuActItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrMenuActItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrMenuActItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrMenuActItemProvider SqlCtrMenuActItemProvider
		{
			get {return CtrMenuActItemProvider as SqlCtrMenuActItemProvider;}
		}
		
		#endregion
		
		
		#region "CtrMealItemProvider"
			
		private SqlCtrMealItemProvider innerSqlCtrMealItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CtrMealItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CtrMealItemProviderBase CtrMealItemProvider
		{
			get
			{
				if (innerSqlCtrMealItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCtrMealItemProvider == null)
						{
							this.innerSqlCtrMealItemProvider = new SqlCtrMealItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCtrMealItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCtrMealItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCtrMealItemProvider SqlCtrMealItemProvider
		{
			get {return CtrMealItemProvider as SqlCtrMealItemProvider;}
		}
		
		#endregion
		
		
		#region "CoExamSchdlPlaceProvider"
			
		private SqlCoExamSchdlPlaceProvider innerSqlCoExamSchdlPlaceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExamSchdlPlace"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExamSchdlPlaceProviderBase CoExamSchdlPlaceProvider
		{
			get
			{
				if (innerSqlCoExamSchdlPlaceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExamSchdlPlaceProvider == null)
						{
							this.innerSqlCoExamSchdlPlaceProvider = new SqlCoExamSchdlPlaceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExamSchdlPlaceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExamSchdlPlaceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExamSchdlPlaceProvider SqlCoExamSchdlPlaceProvider
		{
			get {return CoExamSchdlPlaceProvider as SqlCoExamSchdlPlaceProvider;}
		}
		
		#endregion
		
		
		#region "CoExamCommSupervisorProvider"
			
		private SqlCoExamCommSupervisorProvider innerSqlCoExamCommSupervisorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExamCommSupervisor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExamCommSupervisorProviderBase CoExamCommSupervisorProvider
		{
			get
			{
				if (innerSqlCoExamCommSupervisorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExamCommSupervisorProvider == null)
						{
							this.innerSqlCoExamCommSupervisorProvider = new SqlCoExamCommSupervisorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExamCommSupervisorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExamCommSupervisorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExamCommSupervisorProvider SqlCoExamCommSupervisorProvider
		{
			get {return CoExamCommSupervisorProvider as SqlCoExamCommSupervisorProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeAcadWarnTypeProvider"
			
		private SqlEdCdeAcadWarnTypeProvider innerSqlEdCdeAcadWarnTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeAcadWarnType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeAcadWarnTypeProviderBase EdCdeAcadWarnTypeProvider
		{
			get
			{
				if (innerSqlEdCdeAcadWarnTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeAcadWarnTypeProvider == null)
						{
							this.innerSqlEdCdeAcadWarnTypeProvider = new SqlEdCdeAcadWarnTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeAcadWarnTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeAcadWarnTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeAcadWarnTypeProvider SqlEdCdeAcadWarnTypeProvider
		{
			get {return EdCdeAcadWarnTypeProvider as SqlEdCdeAcadWarnTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeCourseChngRsnProvider"
			
		private SqlEdCdeCourseChngRsnProvider innerSqlEdCdeCourseChngRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeCourseChngRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeCourseChngRsnProviderBase EdCdeCourseChngRsnProvider
		{
			get
			{
				if (innerSqlEdCdeCourseChngRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeCourseChngRsnProvider == null)
						{
							this.innerSqlEdCdeCourseChngRsnProvider = new SqlEdCdeCourseChngRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeCourseChngRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeCourseChngRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeCourseChngRsnProvider SqlEdCdeCourseChngRsnProvider
		{
			get {return EdCdeCourseChngRsnProvider as SqlEdCdeCourseChngRsnProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeCrsRegTypeProvider"
			
		private SqlEdCdeCrsRegTypeProvider innerSqlEdCdeCrsRegTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeCrsRegType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeCrsRegTypeProviderBase EdCdeCrsRegTypeProvider
		{
			get
			{
				if (innerSqlEdCdeCrsRegTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeCrsRegTypeProvider == null)
						{
							this.innerSqlEdCdeCrsRegTypeProvider = new SqlEdCdeCrsRegTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeCrsRegTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeCrsRegTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeCrsRegTypeProvider SqlEdCdeCrsRegTypeProvider
		{
			get {return EdCdeCrsRegTypeProvider as SqlEdCdeCrsRegTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeGradingTypeProvider"
			
		private SqlEdCodeGradingTypeProvider innerSqlEdCodeGradingTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeGradingType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeGradingTypeProviderBase EdCodeGradingTypeProvider
		{
			get
			{
				if (innerSqlEdCodeGradingTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeGradingTypeProvider == null)
						{
							this.innerSqlEdCodeGradingTypeProvider = new SqlEdCodeGradingTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeGradingTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeGradingTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeGradingTypeProvider SqlEdCodeGradingTypeProvider
		{
			get {return EdCodeGradingTypeProvider as SqlEdCodeGradingTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeLevelProvider"
			
		private SqlEdCodeLevelProvider innerSqlEdCodeLevelProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeLevel"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeLevelProviderBase EdCodeLevelProvider
		{
			get
			{
				if (innerSqlEdCodeLevelProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeLevelProvider == null)
						{
							this.innerSqlEdCodeLevelProvider = new SqlEdCodeLevelProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeLevelProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeLevelProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeLevelProvider SqlEdCodeLevelProvider
		{
			get {return EdCodeLevelProvider as SqlEdCodeLevelProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeLoadTypeProvider"
			
		private SqlEdCodeLoadTypeProvider innerSqlEdCodeLoadTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeLoadType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeLoadTypeProviderBase EdCodeLoadTypeProvider
		{
			get
			{
				if (innerSqlEdCodeLoadTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeLoadTypeProvider == null)
						{
							this.innerSqlEdCodeLoadTypeProvider = new SqlEdCodeLoadTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeLoadTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeLoadTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeLoadTypeProvider SqlEdCodeLoadTypeProvider
		{
			get {return EdCodeLoadTypeProvider as SqlEdCodeLoadTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeQualProvider"
			
		private SqlEdCodeQualProvider innerSqlEdCodeQualProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeQual"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeQualProviderBase EdCodeQualProvider
		{
			get
			{
				if (innerSqlEdCodeQualProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeQualProvider == null)
						{
							this.innerSqlEdCodeQualProvider = new SqlEdCodeQualProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeQualProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeQualProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeQualProvider SqlEdCodeQualProvider
		{
			get {return EdCodeQualProvider as SqlEdCodeQualProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeStudyMethodProvider"
			
		private SqlEdCodeStudyMethodProvider innerSqlEdCodeStudyMethodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeStudyMethod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeStudyMethodProviderBase EdCodeStudyMethodProvider
		{
			get
			{
				if (innerSqlEdCodeStudyMethodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeStudyMethodProvider == null)
						{
							this.innerSqlEdCodeStudyMethodProvider = new SqlEdCodeStudyMethodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeStudyMethodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeStudyMethodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeStudyMethodProvider SqlEdCodeStudyMethodProvider
		{
			get {return EdCodeStudyMethodProvider as SqlEdCodeStudyMethodProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeGradingProvider"
			
		private SqlEdCodeGradingProvider innerSqlEdCodeGradingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeGrading"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeGradingProviderBase EdCodeGradingProvider
		{
			get
			{
				if (innerSqlEdCodeGradingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeGradingProvider == null)
						{
							this.innerSqlEdCodeGradingProvider = new SqlEdCodeGradingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeGradingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeGradingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeGradingProvider SqlEdCodeGradingProvider
		{
			get {return EdCodeGradingProvider as SqlEdCodeGradingProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeExamPeriodTypeProvider"
			
		private SqlEdCodeExamPeriodTypeProvider innerSqlEdCodeExamPeriodTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeExamPeriodType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeExamPeriodTypeProviderBase EdCodeExamPeriodTypeProvider
		{
			get
			{
				if (innerSqlEdCodeExamPeriodTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeExamPeriodTypeProvider == null)
						{
							this.innerSqlEdCodeExamPeriodTypeProvider = new SqlEdCodeExamPeriodTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeExamPeriodTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeExamPeriodTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeExamPeriodTypeProvider SqlEdCodeExamPeriodTypeProvider
		{
			get {return EdCodeExamPeriodTypeProvider as SqlEdCodeExamPeriodTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeExcuseTypeProvider"
			
		private SqlEdCodeExcuseTypeProvider innerSqlEdCodeExcuseTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeExcuseType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeExcuseTypeProviderBase EdCodeExcuseTypeProvider
		{
			get
			{
				if (innerSqlEdCodeExcuseTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeExcuseTypeProvider == null)
						{
							this.innerSqlEdCodeExcuseTypeProvider = new SqlEdCodeExcuseTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeExcuseTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeExcuseTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeExcuseTypeProvider SqlEdCodeExcuseTypeProvider
		{
			get {return EdCodeExcuseTypeProvider as SqlEdCodeExcuseTypeProvider;}
		}
		
		#endregion
		
		
		#region "CoExamPlaceStudProvider"
			
		private SqlCoExamPlaceStudProvider innerSqlCoExamPlaceStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoExamPlaceStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoExamPlaceStudProviderBase CoExamPlaceStudProvider
		{
			get
			{
				if (innerSqlCoExamPlaceStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoExamPlaceStudProvider == null)
						{
							this.innerSqlCoExamPlaceStudProvider = new SqlCoExamPlaceStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoExamPlaceStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoExamPlaceStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoExamPlaceStudProvider SqlCoExamPlaceStudProvider
		{
			get {return CoExamPlaceStudProvider as SqlCoExamPlaceStudProvider;}
		}
		
		#endregion
		
		
		#region "CoStudSecretNumProvider"
			
		private SqlCoStudSecretNumProvider innerSqlCoStudSecretNumProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoStudSecretNum"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoStudSecretNumProviderBase CoStudSecretNumProvider
		{
			get
			{
				if (innerSqlCoStudSecretNumProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoStudSecretNumProvider == null)
						{
							this.innerSqlCoStudSecretNumProvider = new SqlCoStudSecretNumProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoStudSecretNumProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoStudSecretNumProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoStudSecretNumProvider SqlCoStudSecretNumProvider
		{
			get {return CoStudSecretNumProvider as SqlCoStudSecretNumProvider;}
		}
		
		#endregion
		
		
		#region "CoStudCheatProvider"
			
		private SqlCoStudCheatProvider innerSqlCoStudCheatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoStudCheat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoStudCheatProviderBase CoStudCheatProvider
		{
			get
			{
				if (innerSqlCoStudCheatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoStudCheatProvider == null)
						{
							this.innerSqlCoStudCheatProvider = new SqlCoStudCheatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoStudCheatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlCoStudCheatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoStudCheatProvider SqlCoStudCheatProvider
		{
			get {return CoStudCheatProvider as SqlCoStudCheatProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeQualGroupProvider"
			
		private SqlEdCodeQualGroupProvider innerSqlEdCodeQualGroupProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeQualGroup"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeQualGroupProviderBase EdCodeQualGroupProvider
		{
			get
			{
				if (innerSqlEdCodeQualGroupProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeQualGroupProvider == null)
						{
							this.innerSqlEdCodeQualGroupProvider = new SqlEdCodeQualGroupProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeQualGroupProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeQualGroupProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeQualGroupProvider SqlEdCodeQualGroupProvider
		{
			get {return EdCodeQualGroupProvider as SqlEdCodeQualGroupProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeQualSubjectProvider"
			
		private SqlEdCodeQualSubjectProvider innerSqlEdCodeQualSubjectProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeQualSubject"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeQualSubjectProviderBase EdCodeQualSubjectProvider
		{
			get
			{
				if (innerSqlEdCodeQualSubjectProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeQualSubjectProvider == null)
						{
							this.innerSqlEdCodeQualSubjectProvider = new SqlEdCodeQualSubjectProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeQualSubjectProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeQualSubjectProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeQualSubjectProvider SqlEdCodeQualSubjectProvider
		{
			get {return EdCodeQualSubjectProvider as SqlEdCodeQualSubjectProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeRatingProvider"
			
		private SqlEdCodeRatingProvider innerSqlEdCodeRatingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeRating"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeRatingProviderBase EdCodeRatingProvider
		{
			get
			{
				if (innerSqlEdCodeRatingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeRatingProvider == null)
						{
							this.innerSqlEdCodeRatingProvider = new SqlEdCodeRatingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeRatingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeRatingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeRatingProvider SqlEdCodeRatingProvider
		{
			get {return EdCodeRatingProvider as SqlEdCodeRatingProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeTrainEvalProvider"
			
		private SqlEdCodeTrainEvalProvider innerSqlEdCodeTrainEvalProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeTrainEval"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeTrainEvalProviderBase EdCodeTrainEvalProvider
		{
			get
			{
				if (innerSqlEdCodeTrainEvalProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeTrainEvalProvider == null)
						{
							this.innerSqlEdCodeTrainEvalProvider = new SqlEdCodeTrainEvalProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeTrainEvalProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeTrainEvalProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeTrainEvalProvider SqlEdCodeTrainEvalProvider
		{
			get {return EdCodeTrainEvalProvider as SqlEdCodeTrainEvalProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseExpHdrProvider"
			
		private SqlEdCourseExpHdrProvider innerSqlEdCourseExpHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseExpHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseExpHdrProviderBase EdCourseExpHdrProvider
		{
			get
			{
				if (innerSqlEdCourseExpHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseExpHdrProvider == null)
						{
							this.innerSqlEdCourseExpHdrProvider = new SqlEdCourseExpHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseExpHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseExpHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseExpHdrProvider SqlEdCourseExpHdrProvider
		{
			get {return EdCourseExpHdrProvider as SqlEdCourseExpHdrProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeTransCourseTypeProvider"
			
		private SqlEdCodeTransCourseTypeProvider innerSqlEdCodeTransCourseTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeTransCourseType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeTransCourseTypeProviderBase EdCodeTransCourseTypeProvider
		{
			get
			{
				if (innerSqlEdCodeTransCourseTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeTransCourseTypeProvider == null)
						{
							this.innerSqlEdCodeTransCourseTypeProvider = new SqlEdCodeTransCourseTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeTransCourseTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeTransCourseTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeTransCourseTypeProvider SqlEdCodeTransCourseTypeProvider
		{
			get {return EdCodeTransCourseTypeProvider as SqlEdCodeTransCourseTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseProvider"
			
		private SqlEdCourseProvider innerSqlEdCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseProviderBase EdCourseProvider
		{
			get
			{
				if (innerSqlEdCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseProvider == null)
						{
							this.innerSqlEdCourseProvider = new SqlEdCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseProvider SqlEdCourseProvider
		{
			get {return EdCourseProvider as SqlEdCourseProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeSubjectProvider"
			
		private SqlEdCodeSubjectProvider innerSqlEdCodeSubjectProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeSubject"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeSubjectProviderBase EdCodeSubjectProvider
		{
			get
			{
				if (innerSqlEdCodeSubjectProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeSubjectProvider == null)
						{
							this.innerSqlEdCodeSubjectProvider = new SqlEdCodeSubjectProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeSubjectProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeSubjectProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeSubjectProvider SqlEdCodeSubjectProvider
		{
			get {return EdCodeSubjectProvider as SqlEdCodeSubjectProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeStudCaseProvider"
			
		private SqlEdCodeStudCaseProvider innerSqlEdCodeStudCaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeStudCase"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeStudCaseProviderBase EdCodeStudCaseProvider
		{
			get
			{
				if (innerSqlEdCodeStudCaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeStudCaseProvider == null)
						{
							this.innerSqlEdCodeStudCaseProvider = new SqlEdCodeStudCaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeStudCaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeStudCaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeStudCaseProvider SqlEdCodeStudCaseProvider
		{
			get {return EdCodeStudCaseProvider as SqlEdCodeStudCaseProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeRepeatRuleProvider"
			
		private SqlEdCodeRepeatRuleProvider innerSqlEdCodeRepeatRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeRepeatRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeRepeatRuleProviderBase EdCodeRepeatRuleProvider
		{
			get
			{
				if (innerSqlEdCodeRepeatRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeRepeatRuleProvider == null)
						{
							this.innerSqlEdCodeRepeatRuleProvider = new SqlEdCodeRepeatRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeRepeatRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeRepeatRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeRepeatRuleProvider SqlEdCodeRepeatRuleProvider
		{
			get {return EdCodeRepeatRuleProvider as SqlEdCodeRepeatRuleProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeSemActvityProvider"
			
		private SqlEdCodeSemActvityProvider innerSqlEdCodeSemActvityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeSemActvity"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeSemActvityProviderBase EdCodeSemActvityProvider
		{
			get
			{
				if (innerSqlEdCodeSemActvityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeSemActvityProvider == null)
						{
							this.innerSqlEdCodeSemActvityProvider = new SqlEdCodeSemActvityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeSemActvityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeSemActvityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeSemActvityProvider SqlEdCodeSemActvityProvider
		{
			get {return EdCodeSemActvityProvider as SqlEdCodeSemActvityProvider;}
		}
		
		#endregion
		
		
		#region "EdCoursePrfxProvider"
			
		private SqlEdCoursePrfxProvider innerSqlEdCoursePrfxProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCoursePrfx"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCoursePrfxProviderBase EdCoursePrfxProvider
		{
			get
			{
				if (innerSqlEdCoursePrfxProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCoursePrfxProvider == null)
						{
							this.innerSqlEdCoursePrfxProvider = new SqlEdCoursePrfxProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCoursePrfxProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCoursePrfxProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCoursePrfxProvider SqlEdCoursePrfxProvider
		{
			get {return EdCoursePrfxProvider as SqlEdCoursePrfxProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeStateStatusProvider"
			
		private SqlEdCodeStateStatusProvider innerSqlEdCodeStateStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeStateStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeStateStatusProviderBase EdCodeStateStatusProvider
		{
			get
			{
				if (innerSqlEdCodeStateStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeStateStatusProvider == null)
						{
							this.innerSqlEdCodeStateStatusProvider = new SqlEdCodeStateStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeStateStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeStateStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeStateStatusProvider SqlEdCodeStateStatusProvider
		{
			get {return EdCodeStateStatusProvider as SqlEdCodeStateStatusProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeEnrollTypeProvider"
			
		private SqlEdCodeEnrollTypeProvider innerSqlEdCodeEnrollTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeEnrollType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeEnrollTypeProviderBase EdCodeEnrollTypeProvider
		{
			get
			{
				if (innerSqlEdCodeEnrollTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeEnrollTypeProvider == null)
						{
							this.innerSqlEdCodeEnrollTypeProvider = new SqlEdCodeEnrollTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeEnrollTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeEnrollTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeEnrollTypeProvider SqlEdCodeEnrollTypeProvider
		{
			get {return EdCodeEnrollTypeProvider as SqlEdCodeEnrollTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeDischargeReasonsProvider"
			
		private SqlEdCodeDischargeReasonsProvider innerSqlEdCodeDischargeReasonsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeDischargeReasons"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeDischargeReasonsProviderBase EdCodeDischargeReasonsProvider
		{
			get
			{
				if (innerSqlEdCodeDischargeReasonsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeDischargeReasonsProvider == null)
						{
							this.innerSqlEdCodeDischargeReasonsProvider = new SqlEdCodeDischargeReasonsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeDischargeReasonsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeDischargeReasonsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeDischargeReasonsProvider SqlEdCodeDischargeReasonsProvider
		{
			get {return EdCodeDischargeReasonsProvider as SqlEdCodeDischargeReasonsProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeOutcomeCatProvider"
			
		private SqlEdCdeOutcomeCatProvider innerSqlEdCdeOutcomeCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeOutcomeCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeOutcomeCatProviderBase EdCdeOutcomeCatProvider
		{
			get
			{
				if (innerSqlEdCdeOutcomeCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeOutcomeCatProvider == null)
						{
							this.innerSqlEdCdeOutcomeCatProvider = new SqlEdCdeOutcomeCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeOutcomeCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeOutcomeCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeOutcomeCatProvider SqlEdCdeOutcomeCatProvider
		{
			get {return EdCdeOutcomeCatProvider as SqlEdCdeOutcomeCatProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeDischargeHProvider"
			
		private SqlEdCodeDischargeHProvider innerSqlEdCodeDischargeHProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeDischargeH"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeDischargeHProviderBase EdCodeDischargeHProvider
		{
			get
			{
				if (innerSqlEdCodeDischargeHProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeDischargeHProvider == null)
						{
							this.innerSqlEdCodeDischargeHProvider = new SqlEdCodeDischargeHProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeDischargeHProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeDischargeHProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeDischargeHProvider SqlEdCodeDischargeHProvider
		{
			get {return EdCodeDischargeHProvider as SqlEdCodeDischargeHProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeQualCatProvider"
			
		private SqlEdCdeQualCatProvider innerSqlEdCdeQualCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeQualCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeQualCatProviderBase EdCdeQualCatProvider
		{
			get
			{
				if (innerSqlEdCdeQualCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeQualCatProvider == null)
						{
							this.innerSqlEdCdeQualCatProvider = new SqlEdCdeQualCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeQualCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeQualCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeQualCatProvider SqlEdCdeQualCatProvider
		{
			get {return EdCdeQualCatProvider as SqlEdCdeQualCatProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeQualBrnProvider"
			
		private SqlEdCdeQualBrnProvider innerSqlEdCdeQualBrnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeQualBrn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeQualBrnProviderBase EdCdeQualBrnProvider
		{
			get
			{
				if (innerSqlEdCdeQualBrnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeQualBrnProvider == null)
						{
							this.innerSqlEdCdeQualBrnProvider = new SqlEdCdeQualBrnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeQualBrnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeQualBrnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeQualBrnProvider SqlEdCdeQualBrnProvider
		{
			get {return EdCdeQualBrnProvider as SqlEdCdeQualBrnProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeQualPhaseProvider"
			
		private SqlEdCdeQualPhaseProvider innerSqlEdCdeQualPhaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeQualPhase"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeQualPhaseProviderBase EdCdeQualPhaseProvider
		{
			get
			{
				if (innerSqlEdCdeQualPhaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeQualPhaseProvider == null)
						{
							this.innerSqlEdCdeQualPhaseProvider = new SqlEdCdeQualPhaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeQualPhaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeQualPhaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeQualPhaseProvider SqlEdCdeQualPhaseProvider
		{
			get {return EdCdeQualPhaseProvider as SqlEdCdeQualPhaseProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeGrdChngRsnProvider"
			
		private SqlEdCdeGrdChngRsnProvider innerSqlEdCdeGrdChngRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeGrdChngRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeGrdChngRsnProviderBase EdCdeGrdChngRsnProvider
		{
			get
			{
				if (innerSqlEdCdeGrdChngRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeGrdChngRsnProvider == null)
						{
							this.innerSqlEdCdeGrdChngRsnProvider = new SqlEdCdeGrdChngRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeGrdChngRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeGrdChngRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeGrdChngRsnProvider SqlEdCdeGrdChngRsnProvider
		{
			get {return EdCdeGrdChngRsnProvider as SqlEdCdeGrdChngRsnProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeExmptProvider"
			
		private SqlEdCdeExmptProvider innerSqlEdCdeExmptProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeExmpt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeExmptProviderBase EdCdeExmptProvider
		{
			get
			{
				if (innerSqlEdCdeExmptProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeExmptProvider == null)
						{
							this.innerSqlEdCdeExmptProvider = new SqlEdCdeExmptProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeExmptProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeExmptProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeExmptProvider SqlEdCdeExmptProvider
		{
			get {return EdCdeExmptProvider as SqlEdCdeExmptProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeExecuseRsnProvider"
			
		private SqlEdCdeExecuseRsnProvider innerSqlEdCdeExecuseRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeExecuseRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeExecuseRsnProviderBase EdCdeExecuseRsnProvider
		{
			get
			{
				if (innerSqlEdCdeExecuseRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeExecuseRsnProvider == null)
						{
							this.innerSqlEdCdeExecuseRsnProvider = new SqlEdCdeExecuseRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeExecuseRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeExecuseRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeExecuseRsnProvider SqlEdCdeExecuseRsnProvider
		{
			get {return EdCdeExecuseRsnProvider as SqlEdCdeExecuseRsnProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeEmpQualProvider"
			
		private SqlEdCdeEmpQualProvider innerSqlEdCdeEmpQualProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeEmpQual"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeEmpQualProviderBase EdCdeEmpQualProvider
		{
			get
			{
				if (innerSqlEdCdeEmpQualProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeEmpQualProvider == null)
						{
							this.innerSqlEdCdeEmpQualProvider = new SqlEdCdeEmpQualProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeEmpQualProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeEmpQualProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeEmpQualProvider SqlEdCdeEmpQualProvider
		{
			get {return EdCdeEmpQualProvider as SqlEdCdeEmpQualProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeEnrollChngRsnProvider"
			
		private SqlEdCdeEnrollChngRsnProvider innerSqlEdCdeEnrollChngRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeEnrollChngRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeEnrollChngRsnProviderBase EdCdeEnrollChngRsnProvider
		{
			get
			{
				if (innerSqlEdCdeEnrollChngRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeEnrollChngRsnProvider == null)
						{
							this.innerSqlEdCdeEnrollChngRsnProvider = new SqlEdCdeEnrollChngRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeEnrollChngRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeEnrollChngRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeEnrollChngRsnProvider SqlEdCdeEnrollChngRsnProvider
		{
			get {return EdCdeEnrollChngRsnProvider as SqlEdCdeEnrollChngRsnProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeExamSchdlTypeProvider"
			
		private SqlEdCdeExamSchdlTypeProvider innerSqlEdCdeExamSchdlTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeExamSchdlType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeExamSchdlTypeProviderBase EdCdeExamSchdlTypeProvider
		{
			get
			{
				if (innerSqlEdCdeExamSchdlTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeExamSchdlTypeProvider == null)
						{
							this.innerSqlEdCdeExamSchdlTypeProvider = new SqlEdCdeExamSchdlTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeExamSchdlTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeExamSchdlTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeExamSchdlTypeProvider SqlEdCdeExamSchdlTypeProvider
		{
			get {return EdCdeExamSchdlTypeProvider as SqlEdCdeExamSchdlTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeExamTypeProvider"
			
		private SqlEdCdeExamTypeProvider innerSqlEdCdeExamTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeExamType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeExamTypeProviderBase EdCdeExamTypeProvider
		{
			get
			{
				if (innerSqlEdCdeExamTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeExamTypeProvider == null)
						{
							this.innerSqlEdCdeExamTypeProvider = new SqlEdCdeExamTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeExamTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeExamTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeExamTypeProvider SqlEdCdeExamTypeProvider
		{
			get {return EdCdeExamTypeProvider as SqlEdCdeExamTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeQualStatusProvider"
			
		private SqlEdCdeQualStatusProvider innerSqlEdCdeQualStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeQualStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeQualStatusProviderBase EdCdeQualStatusProvider
		{
			get
			{
				if (innerSqlEdCdeQualStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeQualStatusProvider == null)
						{
							this.innerSqlEdCdeQualStatusProvider = new SqlEdCdeQualStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeQualStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeQualStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeQualStatusProvider SqlEdCdeQualStatusProvider
		{
			get {return EdCdeQualStatusProvider as SqlEdCdeQualStatusProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeSchoolGradeProvider"
			
		private SqlEdCdeSchoolGradeProvider innerSqlEdCdeSchoolGradeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeSchoolGrade"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeSchoolGradeProviderBase EdCdeSchoolGradeProvider
		{
			get
			{
				if (innerSqlEdCdeSchoolGradeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeSchoolGradeProvider == null)
						{
							this.innerSqlEdCdeSchoolGradeProvider = new SqlEdCdeSchoolGradeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeSchoolGradeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeSchoolGradeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeSchoolGradeProvider SqlEdCdeSchoolGradeProvider
		{
			get {return EdCdeSchoolGradeProvider as SqlEdCdeSchoolGradeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseChngProvider"
			
		private SqlEdCodeCourseChngProvider innerSqlEdCodeCourseChngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourseChng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseChngProviderBase EdCodeCourseChngProvider
		{
			get
			{
				if (innerSqlEdCodeCourseChngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseChngProvider == null)
						{
							this.innerSqlEdCodeCourseChngProvider = new SqlEdCodeCourseChngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseChngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseChngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseChngProvider SqlEdCodeCourseChngProvider
		{
			get {return EdCodeCourseChngProvider as SqlEdCodeCourseChngProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseStatusProvider"
			
		private SqlEdCodeCourseStatusProvider innerSqlEdCodeCourseStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourseStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseStatusProviderBase EdCodeCourseStatusProvider
		{
			get
			{
				if (innerSqlEdCodeCourseStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseStatusProvider == null)
						{
							this.innerSqlEdCodeCourseStatusProvider = new SqlEdCodeCourseStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseStatusProvider SqlEdCodeCourseStatusProvider
		{
			get {return EdCodeCourseStatusProvider as SqlEdCodeCourseStatusProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseTeachingProvider"
			
		private SqlEdCodeCourseTeachingProvider innerSqlEdCodeCourseTeachingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourseTeaching"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseTeachingProviderBase EdCodeCourseTeachingProvider
		{
			get
			{
				if (innerSqlEdCodeCourseTeachingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseTeachingProvider == null)
						{
							this.innerSqlEdCodeCourseTeachingProvider = new SqlEdCodeCourseTeachingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseTeachingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseTeachingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseTeachingProvider SqlEdCodeCourseTeachingProvider
		{
			get {return EdCodeCourseTeachingProvider as SqlEdCodeCourseTeachingProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseTypeProvider"
			
		private SqlEdCodeCourseTypeProvider innerSqlEdCodeCourseTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourseType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseTypeProviderBase EdCodeCourseTypeProvider
		{
			get
			{
				if (innerSqlEdCodeCourseTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseTypeProvider == null)
						{
							this.innerSqlEdCodeCourseTypeProvider = new SqlEdCodeCourseTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseTypeProvider SqlEdCodeCourseTypeProvider
		{
			get {return EdCodeCourseTypeProvider as SqlEdCodeCourseTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseCaseProvider"
			
		private SqlEdCodeCourseCaseProvider innerSqlEdCodeCourseCaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourseCase"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseCaseProviderBase EdCodeCourseCaseProvider
		{
			get
			{
				if (innerSqlEdCodeCourseCaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseCaseProvider == null)
						{
							this.innerSqlEdCodeCourseCaseProvider = new SqlEdCodeCourseCaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseCaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseCaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseCaseProvider SqlEdCodeCourseCaseProvider
		{
			get {return EdCodeCourseCaseProvider as SqlEdCodeCourseCaseProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseAssessProvider"
			
		private SqlEdCodeCourseAssessProvider innerSqlEdCodeCourseAssessProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourseAssess"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseAssessProviderBase EdCodeCourseAssessProvider
		{
			get
			{
				if (innerSqlEdCodeCourseAssessProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseAssessProvider == null)
						{
							this.innerSqlEdCodeCourseAssessProvider = new SqlEdCodeCourseAssessProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseAssessProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseAssessProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseAssessProvider SqlEdCodeCourseAssessProvider
		{
			get {return EdCodeCourseAssessProvider as SqlEdCodeCourseAssessProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCourseProvider"
			
		private SqlEdCodeCourseProvider innerSqlEdCodeCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCourseProviderBase EdCodeCourseProvider
		{
			get
			{
				if (innerSqlEdCodeCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCourseProvider == null)
						{
							this.innerSqlEdCodeCourseProvider = new SqlEdCodeCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCourseProvider SqlEdCodeCourseProvider
		{
			get {return EdCodeCourseProvider as SqlEdCodeCourseProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeSocialAffairProvider"
			
		private SqlEdCdeSocialAffairProvider innerSqlEdCdeSocialAffairProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeSocialAffair"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeSocialAffairProviderBase EdCdeSocialAffairProvider
		{
			get
			{
				if (innerSqlEdCdeSocialAffairProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeSocialAffairProvider == null)
						{
							this.innerSqlEdCdeSocialAffairProvider = new SqlEdCdeSocialAffairProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeSocialAffairProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeSocialAffairProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeSocialAffairProvider SqlEdCdeSocialAffairProvider
		{
			get {return EdCdeSocialAffairProvider as SqlEdCdeSocialAffairProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeStudTypeProvider"
			
		private SqlEdCdeStudTypeProvider innerSqlEdCdeStudTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeStudType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeStudTypeProviderBase EdCdeStudTypeProvider
		{
			get
			{
				if (innerSqlEdCdeStudTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeStudTypeProvider == null)
						{
							this.innerSqlEdCdeStudTypeProvider = new SqlEdCdeStudTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeStudTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeStudTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeStudTypeProvider SqlEdCdeStudTypeProvider
		{
			get {return EdCdeStudTypeProvider as SqlEdCdeStudTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdCdeTchngMthdProvider"
			
		private SqlEdCdeTchngMthdProvider innerSqlEdCdeTchngMthdProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCdeTchngMthd"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCdeTchngMthdProviderBase EdCdeTchngMthdProvider
		{
			get
			{
				if (innerSqlEdCdeTchngMthdProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCdeTchngMthdProvider == null)
						{
							this.innerSqlEdCdeTchngMthdProvider = new SqlEdCdeTchngMthdProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCdeTchngMthdProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCdeTchngMthdProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCdeTchngMthdProvider SqlEdCdeTchngMthdProvider
		{
			get {return EdCdeTchngMthdProvider as SqlEdCdeTchngMthdProvider;}
		}
		
		#endregion
		
		
		#region "EdCodeCheatRsltProvider"
			
		private SqlEdCodeCheatRsltProvider innerSqlEdCodeCheatRsltProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCodeCheatRslt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCodeCheatRsltProviderBase EdCodeCheatRsltProvider
		{
			get
			{
				if (innerSqlEdCodeCheatRsltProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCodeCheatRsltProvider == null)
						{
							this.innerSqlEdCodeCheatRsltProvider = new SqlEdCodeCheatRsltProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCodeCheatRsltProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCodeCheatRsltProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCodeCheatRsltProvider SqlEdCodeCheatRsltProvider
		{
			get {return EdCodeCheatRsltProvider as SqlEdCodeCheatRsltProvider;}
		}
		
		#endregion
		
		
		#region "AdmTransAcceptanceCategoryProvider"
			
		private SqlAdmTransAcceptanceCategoryProvider innerSqlAdmTransAcceptanceCategoryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmTransAcceptanceCategory"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmTransAcceptanceCategoryProviderBase AdmTransAcceptanceCategoryProvider
		{
			get
			{
				if (innerSqlAdmTransAcceptanceCategoryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmTransAcceptanceCategoryProvider == null)
						{
							this.innerSqlAdmTransAcceptanceCategoryProvider = new SqlAdmTransAcceptanceCategoryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmTransAcceptanceCategoryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmTransAcceptanceCategoryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmTransAcceptanceCategoryProvider SqlAdmTransAcceptanceCategoryProvider
		{
			get {return AdmTransAcceptanceCategoryProvider as SqlAdmTransAcceptanceCategoryProvider;}
		}
		
		#endregion
		
		
		#region "AdmTansikCodesProvider"
			
		private SqlAdmTansikCodesProvider innerSqlAdmTansikCodesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmTansikCodes"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmTansikCodesProviderBase AdmTansikCodesProvider
		{
			get
			{
				if (innerSqlAdmTansikCodesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmTansikCodesProvider == null)
						{
							this.innerSqlAdmTansikCodesProvider = new SqlAdmTansikCodesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmTansikCodesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmTansikCodesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmTansikCodesProvider SqlAdmTansikCodesProvider
		{
			get {return AdmTansikCodesProvider as SqlAdmTansikCodesProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeExamGrdngProvider"
			
		private SqlAdmCdeExamGrdngProvider innerSqlAdmCdeExamGrdngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeExamGrdng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeExamGrdngProviderBase AdmCdeExamGrdngProvider
		{
			get
			{
				if (innerSqlAdmCdeExamGrdngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeExamGrdngProvider == null)
						{
							this.innerSqlAdmCdeExamGrdngProvider = new SqlAdmCdeExamGrdngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeExamGrdngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeExamGrdngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeExamGrdngProvider SqlAdmCdeExamGrdngProvider
		{
			get {return AdmCdeExamGrdngProvider as SqlAdmCdeExamGrdngProvider;}
		}
		
		#endregion
		
		
		#region "EntityMainProvider"
			
		private SqlEntityMainProvider innerSqlEntityMainProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntityMain"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntityMainProviderBase EntityMainProvider
		{
			get
			{
				if (innerSqlEntityMainProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntityMainProvider == null)
						{
							this.innerSqlEntityMainProvider = new SqlEntityMainProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntityMainProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntityMainProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntityMainProvider SqlEntityMainProvider
		{
			get {return EntityMainProvider as SqlEntityMainProvider;}
		}
		
		#endregion
		
		
		#region "AdmApplicantProvider"
			
		private SqlAdmApplicantProvider innerSqlAdmApplicantProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmApplicant"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmApplicantProviderBase AdmApplicantProvider
		{
			get
			{
				if (innerSqlAdmApplicantProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmApplicantProvider == null)
						{
							this.innerSqlAdmApplicantProvider = new SqlAdmApplicantProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmApplicantProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmApplicantProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmApplicantProvider SqlAdmApplicantProvider
		{
			get {return AdmApplicantProvider as SqlAdmApplicantProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeStatusProvider"
			
		private SqlAdmCdeStatusProvider innerSqlAdmCdeStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeStatusProviderBase AdmCdeStatusProvider
		{
			get
			{
				if (innerSqlAdmCdeStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeStatusProvider == null)
						{
							this.innerSqlAdmCdeStatusProvider = new SqlAdmCdeStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeStatusProvider SqlAdmCdeStatusProvider
		{
			get {return AdmCdeStatusProvider as SqlAdmCdeStatusProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdePlacementExamProvider"
			
		private SqlAdmCdePlacementExamProvider innerSqlAdmCdePlacementExamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdePlacementExam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdePlacementExamProviderBase AdmCdePlacementExamProvider
		{
			get
			{
				if (innerSqlAdmCdePlacementExamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdePlacementExamProvider == null)
						{
							this.innerSqlAdmCdePlacementExamProvider = new SqlAdmCdePlacementExamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdePlacementExamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdePlacementExamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdePlacementExamProvider SqlAdmCdePlacementExamProvider
		{
			get {return AdmCdePlacementExamProvider as SqlAdmCdePlacementExamProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeFeeProvider"
			
		private SqlAdmCdeFeeProvider innerSqlAdmCdeFeeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeFee"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeFeeProviderBase AdmCdeFeeProvider
		{
			get
			{
				if (innerSqlAdmCdeFeeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeFeeProvider == null)
						{
							this.innerSqlAdmCdeFeeProvider = new SqlAdmCdeFeeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeFeeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeFeeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeFeeProvider SqlAdmCdeFeeProvider
		{
			get {return AdmCdeFeeProvider as SqlAdmCdeFeeProvider;}
		}
		
		#endregion
		
		
		#region "AdmTansikMajorsCodesProvider"
			
		private SqlAdmTansikMajorsCodesProvider innerSqlAdmTansikMajorsCodesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmTansikMajorsCodes"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmTansikMajorsCodesProviderBase AdmTansikMajorsCodesProvider
		{
			get
			{
				if (innerSqlAdmTansikMajorsCodesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmTansikMajorsCodesProvider == null)
						{
							this.innerSqlAdmTansikMajorsCodesProvider = new SqlAdmTansikMajorsCodesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmTansikMajorsCodesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmTansikMajorsCodesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmTansikMajorsCodesProvider SqlAdmTansikMajorsCodesProvider
		{
			get {return AdmTansikMajorsCodesProvider as SqlAdmTansikMajorsCodesProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppCourseCompProvider"
			
		private SqlAdmAppCourseCompProvider innerSqlAdmAppCourseCompProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppCourseComp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppCourseCompProviderBase AdmAppCourseCompProvider
		{
			get
			{
				if (innerSqlAdmAppCourseCompProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppCourseCompProvider == null)
						{
							this.innerSqlAdmAppCourseCompProvider = new SqlAdmAppCourseCompProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppCourseCompProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppCourseCompProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppCourseCompProvider SqlAdmAppCourseCompProvider
		{
			get {return AdmAppCourseCompProvider as SqlAdmAppCourseCompProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeAppStatusProvider"
			
		private SqlAdmCdeAppStatusProvider innerSqlAdmCdeAppStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeAppStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeAppStatusProviderBase AdmCdeAppStatusProvider
		{
			get
			{
				if (innerSqlAdmCdeAppStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeAppStatusProvider == null)
						{
							this.innerSqlAdmCdeAppStatusProvider = new SqlAdmCdeAppStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeAppStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeAppStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeAppStatusProvider SqlAdmCdeAppStatusProvider
		{
			get {return AdmCdeAppStatusProvider as SqlAdmCdeAppStatusProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeAppTypeProvider"
			
		private SqlAdmCdeAppTypeProvider innerSqlAdmCdeAppTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeAppType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeAppTypeProviderBase AdmCdeAppTypeProvider
		{
			get
			{
				if (innerSqlAdmCdeAppTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeAppTypeProvider == null)
						{
							this.innerSqlAdmCdeAppTypeProvider = new SqlAdmCdeAppTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeAppTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeAppTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeAppTypeProvider SqlAdmCdeAppTypeProvider
		{
			get {return AdmCdeAppTypeProvider as SqlAdmCdeAppTypeProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeStatusRsnProvider"
			
		private SqlAdmCdeStatusRsnProvider innerSqlAdmCdeStatusRsnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeStatusRsn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeStatusRsnProviderBase AdmCdeStatusRsnProvider
		{
			get
			{
				if (innerSqlAdmCdeStatusRsnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeStatusRsnProvider == null)
						{
							this.innerSqlAdmCdeStatusRsnProvider = new SqlAdmCdeStatusRsnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeStatusRsnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeStatusRsnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeStatusRsnProvider SqlAdmCdeStatusRsnProvider
		{
			get {return AdmCdeStatusRsnProvider as SqlAdmCdeStatusRsnProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppRegHistoryProvider"
			
		private SqlAdmAppRegHistoryProvider innerSqlAdmAppRegHistoryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppRegHistory"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppRegHistoryProviderBase AdmAppRegHistoryProvider
		{
			get
			{
				if (innerSqlAdmAppRegHistoryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppRegHistoryProvider == null)
						{
							this.innerSqlAdmAppRegHistoryProvider = new SqlAdmAppRegHistoryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppRegHistoryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppRegHistoryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppRegHistoryProvider SqlAdmAppRegHistoryProvider
		{
			get {return AdmAppRegHistoryProvider as SqlAdmAppRegHistoryProvider;}
		}
		
		#endregion
		
		
		#region "AdmAcceptanceCategoryProvider"
			
		private SqlAdmAcceptanceCategoryProvider innerSqlAdmAcceptanceCategoryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAcceptanceCategory"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAcceptanceCategoryProviderBase AdmAcceptanceCategoryProvider
		{
			get
			{
				if (innerSqlAdmAcceptanceCategoryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAcceptanceCategoryProvider == null)
						{
							this.innerSqlAdmAcceptanceCategoryProvider = new SqlAdmAcceptanceCategoryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAcceptanceCategoryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAcceptanceCategoryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAcceptanceCategoryProvider SqlAdmAcceptanceCategoryProvider
		{
			get {return AdmAcceptanceCategoryProvider as SqlAdmAcceptanceCategoryProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppCountProvider"
			
		private SqlAdmAppCountProvider innerSqlAdmAppCountProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppCount"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppCountProviderBase AdmAppCountProvider
		{
			get
			{
				if (innerSqlAdmAppCountProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppCountProvider == null)
						{
							this.innerSqlAdmAppCountProvider = new SqlAdmAppCountProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppCountProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppCountProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppCountProvider SqlAdmAppCountProvider
		{
			get {return AdmAppCountProvider as SqlAdmAppCountProvider;}
		}
		
		#endregion
		
		
		#region "AccomWfCdeFunctionProvider"
			
		private SqlAccomWfCdeFunctionProvider innerSqlAccomWfCdeFunctionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomWfCdeFunction"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomWfCdeFunctionProviderBase AccomWfCdeFunctionProvider
		{
			get
			{
				if (innerSqlAccomWfCdeFunctionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomWfCdeFunctionProvider == null)
						{
							this.innerSqlAccomWfCdeFunctionProvider = new SqlAccomWfCdeFunctionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomWfCdeFunctionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomWfCdeFunctionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomWfCdeFunctionProvider SqlAccomWfCdeFunctionProvider
		{
			get {return AccomWfCdeFunctionProvider as SqlAccomWfCdeFunctionProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppAlumniPrefProvider"
			
		private SqlAdmAppAlumniPrefProvider innerSqlAdmAppAlumniPrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppAlumniPref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppAlumniPrefProviderBase AdmAppAlumniPrefProvider
		{
			get
			{
				if (innerSqlAdmAppAlumniPrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppAlumniPrefProvider == null)
						{
							this.innerSqlAdmAppAlumniPrefProvider = new SqlAdmAppAlumniPrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppAlumniPrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppAlumniPrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppAlumniPrefProvider SqlAdmAppAlumniPrefProvider
		{
			get {return AdmAppAlumniPrefProvider as SqlAdmAppAlumniPrefProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppDisabilityProvider"
			
		private SqlAdmAppDisabilityProvider innerSqlAdmAppDisabilityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppDisability"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppDisabilityProviderBase AdmAppDisabilityProvider
		{
			get
			{
				if (innerSqlAdmAppDisabilityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppDisabilityProvider == null)
						{
							this.innerSqlAdmAppDisabilityProvider = new SqlAdmAppDisabilityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppDisabilityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppDisabilityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppDisabilityProvider SqlAdmAppDisabilityProvider
		{
			get {return AdmAppDisabilityProvider as SqlAdmAppDisabilityProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppInfoProvider"
			
		private SqlAdmAppInfoProvider innerSqlAdmAppInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppInfoProviderBase AdmAppInfoProvider
		{
			get
			{
				if (innerSqlAdmAppInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppInfoProvider == null)
						{
							this.innerSqlAdmAppInfoProvider = new SqlAdmAppInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppInfoProvider SqlAdmAppInfoProvider
		{
			get {return AdmAppInfoProvider as SqlAdmAppInfoProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppInterviewExamProvider"
			
		private SqlAdmAppInterviewExamProvider innerSqlAdmAppInterviewExamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppInterviewExam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppInterviewExamProviderBase AdmAppInterviewExamProvider
		{
			get
			{
				if (innerSqlAdmAppInterviewExamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppInterviewExamProvider == null)
						{
							this.innerSqlAdmAppInterviewExamProvider = new SqlAdmAppInterviewExamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppInterviewExamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppInterviewExamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppInterviewExamProvider SqlAdmAppInterviewExamProvider
		{
			get {return AdmAppInterviewExamProvider as SqlAdmAppInterviewExamProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppLanguagesProvider"
			
		private SqlAdmAppLanguagesProvider innerSqlAdmAppLanguagesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppLanguages"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppLanguagesProviderBase AdmAppLanguagesProvider
		{
			get
			{
				if (innerSqlAdmAppLanguagesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppLanguagesProvider == null)
						{
							this.innerSqlAdmAppLanguagesProvider = new SqlAdmAppLanguagesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppLanguagesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppLanguagesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppLanguagesProvider SqlAdmAppLanguagesProvider
		{
			get {return AdmAppLanguagesProvider as SqlAdmAppLanguagesProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppLanguagesDtlProvider"
			
		private SqlAdmAppLanguagesDtlProvider innerSqlAdmAppLanguagesDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppLanguagesDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppLanguagesDtlProviderBase AdmAppLanguagesDtlProvider
		{
			get
			{
				if (innerSqlAdmAppLanguagesDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppLanguagesDtlProvider == null)
						{
							this.innerSqlAdmAppLanguagesDtlProvider = new SqlAdmAppLanguagesDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppLanguagesDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppLanguagesDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppLanguagesDtlProvider SqlAdmAppLanguagesDtlProvider
		{
			get {return AdmAppLanguagesDtlProvider as SqlAdmAppLanguagesDtlProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppHonorProvider"
			
		private SqlAdmAppHonorProvider innerSqlAdmAppHonorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppHonor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppHonorProviderBase AdmAppHonorProvider
		{
			get
			{
				if (innerSqlAdmAppHonorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppHonorProvider == null)
						{
							this.innerSqlAdmAppHonorProvider = new SqlAdmAppHonorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppHonorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppHonorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppHonorProvider SqlAdmAppHonorProvider
		{
			get {return AdmAppHonorProvider as SqlAdmAppHonorProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppGuardianProvider"
			
		private SqlAdmAppGuardianProvider innerSqlAdmAppGuardianProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppGuardian"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppGuardianProviderBase AdmAppGuardianProvider
		{
			get
			{
				if (innerSqlAdmAppGuardianProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppGuardianProvider == null)
						{
							this.innerSqlAdmAppGuardianProvider = new SqlAdmAppGuardianProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppGuardianProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppGuardianProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppGuardianProvider SqlAdmAppGuardianProvider
		{
			get {return AdmAppGuardianProvider as SqlAdmAppGuardianProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppFeesProvider"
			
		private SqlAdmAppFeesProvider innerSqlAdmAppFeesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppFees"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppFeesProviderBase AdmAppFeesProvider
		{
			get
			{
				if (innerSqlAdmAppFeesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppFeesProvider == null)
						{
							this.innerSqlAdmAppFeesProvider = new SqlAdmAppFeesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppFeesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppFeesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppFeesProvider SqlAdmAppFeesProvider
		{
			get {return AdmAppFeesProvider as SqlAdmAppFeesProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppDocProvider"
			
		private SqlAdmAppDocProvider innerSqlAdmAppDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppDocProviderBase AdmAppDocProvider
		{
			get
			{
				if (innerSqlAdmAppDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppDocProvider == null)
						{
							this.innerSqlAdmAppDocProvider = new SqlAdmAppDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppDocProvider SqlAdmAppDocProvider
		{
			get {return AdmAppDocProvider as SqlAdmAppDocProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppEssayProvider"
			
		private SqlAdmAppEssayProvider innerSqlAdmAppEssayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppEssay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppEssayProviderBase AdmAppEssayProvider
		{
			get
			{
				if (innerSqlAdmAppEssayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppEssayProvider == null)
						{
							this.innerSqlAdmAppEssayProvider = new SqlAdmAppEssayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppEssayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppEssayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppEssayProvider SqlAdmAppEssayProvider
		{
			get {return AdmAppEssayProvider as SqlAdmAppEssayProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppExmptCourseProvider"
			
		private SqlAdmAppExmptCourseProvider innerSqlAdmAppExmptCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppExmptCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppExmptCourseProviderBase AdmAppExmptCourseProvider
		{
			get
			{
				if (innerSqlAdmAppExmptCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppExmptCourseProvider == null)
						{
							this.innerSqlAdmAppExmptCourseProvider = new SqlAdmAppExmptCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppExmptCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppExmptCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppExmptCourseProvider SqlAdmAppExmptCourseProvider
		{
			get {return AdmAppExmptCourseProvider as SqlAdmAppExmptCourseProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppFeePromocodeProvider"
			
		private SqlAdmAppFeePromocodeProvider innerSqlAdmAppFeePromocodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppFeePromocode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppFeePromocodeProviderBase AdmAppFeePromocodeProvider
		{
			get
			{
				if (innerSqlAdmAppFeePromocodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppFeePromocodeProvider == null)
						{
							this.innerSqlAdmAppFeePromocodeProvider = new SqlAdmAppFeePromocodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppFeePromocodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppFeePromocodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppFeePromocodeProvider SqlAdmAppFeePromocodeProvider
		{
			get {return AdmAppFeePromocodeProvider as SqlAdmAppFeePromocodeProvider;}
		}
		
		#endregion
		
		
		#region "AccomWfCdeActionProvider"
			
		private SqlAccomWfCdeActionProvider innerSqlAccomWfCdeActionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomWfCdeAction"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomWfCdeActionProviderBase AccomWfCdeActionProvider
		{
			get
			{
				if (innerSqlAccomWfCdeActionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomWfCdeActionProvider == null)
						{
							this.innerSqlAccomWfCdeActionProvider = new SqlAccomWfCdeActionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomWfCdeActionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomWfCdeActionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomWfCdeActionProvider SqlAccomWfCdeActionProvider
		{
			get {return AccomWfCdeActionProvider as SqlAccomWfCdeActionProvider;}
		}
		
		#endregion
		
		
		#region "AccomPolcyAbsenceProvider"
			
		private SqlAccomPolcyAbsenceProvider innerSqlAccomPolcyAbsenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomPolcyAbsence"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomPolcyAbsenceProviderBase AccomPolcyAbsenceProvider
		{
			get
			{
				if (innerSqlAccomPolcyAbsenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomPolcyAbsenceProvider == null)
						{
							this.innerSqlAccomPolcyAbsenceProvider = new SqlAccomPolcyAbsenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomPolcyAbsenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomPolcyAbsenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomPolcyAbsenceProvider SqlAccomPolcyAbsenceProvider
		{
			get {return AccomPolcyAbsenceProvider as SqlAccomPolcyAbsenceProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudResponsibleProvider"
			
		private SqlAccomStudResponsibleProvider innerSqlAccomStudResponsibleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudResponsible"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudResponsibleProviderBase AccomStudResponsibleProvider
		{
			get
			{
				if (innerSqlAccomStudResponsibleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudResponsibleProvider == null)
						{
							this.innerSqlAccomStudResponsibleProvider = new SqlAccomStudResponsibleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudResponsibleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudResponsibleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudResponsibleProvider SqlAccomStudResponsibleProvider
		{
			get {return AccomStudResponsibleProvider as SqlAccomStudResponsibleProvider;}
		}
		
		#endregion
		
		
		#region "EntCodeEntityTypeProvider"
			
		private SqlEntCodeEntityTypeProvider innerSqlEntCodeEntityTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodeEntityType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodeEntityTypeProviderBase EntCodeEntityTypeProvider
		{
			get
			{
				if (innerSqlEntCodeEntityTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodeEntityTypeProvider == null)
						{
							this.innerSqlEntCodeEntityTypeProvider = new SqlEntCodeEntityTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodeEntityTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodeEntityTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodeEntityTypeProvider SqlEntCodeEntityTypeProvider
		{
			get {return EntCodeEntityTypeProvider as SqlEntCodeEntityTypeProvider;}
		}
		
		#endregion
		
		
		#region "AccomFloorProvider"
			
		private SqlAccomFloorProvider innerSqlAccomFloorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomFloor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomFloorProviderBase AccomFloorProvider
		{
			get
			{
				if (innerSqlAccomFloorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomFloorProvider == null)
						{
							this.innerSqlAccomFloorProvider = new SqlAccomFloorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomFloorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomFloorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomFloorProvider SqlAccomFloorProvider
		{
			get {return AccomFloorProvider as SqlAccomFloorProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudAbsenceWarnProvider"
			
		private SqlAccomStudAbsenceWarnProvider innerSqlAccomStudAbsenceWarnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudAbsenceWarn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudAbsenceWarnProviderBase AccomStudAbsenceWarnProvider
		{
			get
			{
				if (innerSqlAccomStudAbsenceWarnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudAbsenceWarnProvider == null)
						{
							this.innerSqlAccomStudAbsenceWarnProvider = new SqlAccomStudAbsenceWarnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudAbsenceWarnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudAbsenceWarnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudAbsenceWarnProvider SqlAccomStudAbsenceWarnProvider
		{
			get {return AccomStudAbsenceWarnProvider as SqlAccomStudAbsenceWarnProvider;}
		}
		
		#endregion
		
		
		#region "AccomRoomProvider"
			
		private SqlAccomRoomProvider innerSqlAccomRoomProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomRoom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomRoomProviderBase AccomRoomProvider
		{
			get
			{
				if (innerSqlAccomRoomProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomRoomProvider == null)
						{
							this.innerSqlAccomRoomProvider = new SqlAccomRoomProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomRoomProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomRoomProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomRoomProvider SqlAccomRoomProvider
		{
			get {return AccomRoomProvider as SqlAccomRoomProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudAbsenceProvider"
			
		private SqlAccomStudAbsenceProvider innerSqlAccomStudAbsenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudAbsence"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudAbsenceProviderBase AccomStudAbsenceProvider
		{
			get
			{
				if (innerSqlAccomStudAbsenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudAbsenceProvider == null)
						{
							this.innerSqlAccomStudAbsenceProvider = new SqlAccomStudAbsenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudAbsenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudAbsenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudAbsenceProvider SqlAccomStudAbsenceProvider
		{
			get {return AccomStudAbsenceProvider as SqlAccomStudAbsenceProvider;}
		}
		
		#endregion
		
		
		#region "AccomCdeWarnProvider"
			
		private SqlAccomCdeWarnProvider innerSqlAccomCdeWarnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomCdeWarn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomCdeWarnProviderBase AccomCdeWarnProvider
		{
			get
			{
				if (innerSqlAccomCdeWarnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomCdeWarnProvider == null)
						{
							this.innerSqlAccomCdeWarnProvider = new SqlAccomCdeWarnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomCdeWarnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomCdeWarnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomCdeWarnProvider SqlAccomCdeWarnProvider
		{
			get {return AccomCdeWarnProvider as SqlAccomCdeWarnProvider;}
		}
		
		#endregion
		
		
		#region "AccomBuildingProvider"
			
		private SqlAccomBuildingProvider innerSqlAccomBuildingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomBuilding"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomBuildingProviderBase AccomBuildingProvider
		{
			get
			{
				if (innerSqlAccomBuildingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomBuildingProvider == null)
						{
							this.innerSqlAccomBuildingProvider = new SqlAccomBuildingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomBuildingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomBuildingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomBuildingProvider SqlAccomBuildingProvider
		{
			get {return AccomBuildingProvider as SqlAccomBuildingProvider;}
		}
		
		#endregion
		
		
		#region "AdmRegStepsProvider"
			
		private SqlAdmRegStepsProvider innerSqlAdmRegStepsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmRegSteps"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmRegStepsProviderBase AdmRegStepsProvider
		{
			get
			{
				if (innerSqlAdmRegStepsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmRegStepsProvider == null)
						{
							this.innerSqlAdmRegStepsProvider = new SqlAdmRegStepsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmRegStepsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmRegStepsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmRegStepsProvider SqlAdmRegStepsProvider
		{
			get {return AdmRegStepsProvider as SqlAdmRegStepsProvider;}
		}
		
		#endregion
		
		
		#region "AccomCdeBookStatusProvider"
			
		private SqlAccomCdeBookStatusProvider innerSqlAccomCdeBookStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomCdeBookStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomCdeBookStatusProviderBase AccomCdeBookStatusProvider
		{
			get
			{
				if (innerSqlAccomCdeBookStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomCdeBookStatusProvider == null)
						{
							this.innerSqlAccomCdeBookStatusProvider = new SqlAccomCdeBookStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomCdeBookStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomCdeBookStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomCdeBookStatusProvider SqlAccomCdeBookStatusProvider
		{
			get {return AccomCdeBookStatusProvider as SqlAccomCdeBookStatusProvider;}
		}
		
		#endregion
		
		
		#region "AccomBedProvider"
			
		private SqlAccomBedProvider innerSqlAccomBedProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomBed"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomBedProviderBase AccomBedProvider
		{
			get
			{
				if (innerSqlAccomBedProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomBedProvider == null)
						{
							this.innerSqlAccomBedProvider = new SqlAccomBedProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomBedProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomBedProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomBedProvider SqlAccomBedProvider
		{
			get {return AccomBedProvider as SqlAccomBedProvider;}
		}
		
		#endregion
		
		
		#region "AccomCdeRoomTypeProvider"
			
		private SqlAccomCdeRoomTypeProvider innerSqlAccomCdeRoomTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomCdeRoomType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomCdeRoomTypeProviderBase AccomCdeRoomTypeProvider
		{
			get
			{
				if (innerSqlAccomCdeRoomTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomCdeRoomTypeProvider == null)
						{
							this.innerSqlAccomCdeRoomTypeProvider = new SqlAccomCdeRoomTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomCdeRoomTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomCdeRoomTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomCdeRoomTypeProvider SqlAccomCdeRoomTypeProvider
		{
			get {return AccomCdeRoomTypeProvider as SqlAccomCdeRoomTypeProvider;}
		}
		
		#endregion
		
		
		#region "AccomCdePermtTypeProvider"
			
		private SqlAccomCdePermtTypeProvider innerSqlAccomCdePermtTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomCdePermtType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomCdePermtTypeProviderBase AccomCdePermtTypeProvider
		{
			get
			{
				if (innerSqlAccomCdePermtTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomCdePermtTypeProvider == null)
						{
							this.innerSqlAccomCdePermtTypeProvider = new SqlAccomCdePermtTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomCdePermtTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomCdePermtTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomCdePermtTypeProvider SqlAccomCdePermtTypeProvider
		{
			get {return AccomCdePermtTypeProvider as SqlAccomCdePermtTypeProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudBookProvider"
			
		private SqlAccomStudBookProvider innerSqlAccomStudBookProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudBook"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudBookProviderBase AccomStudBookProvider
		{
			get
			{
				if (innerSqlAccomStudBookProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudBookProvider == null)
						{
							this.innerSqlAccomStudBookProvider = new SqlAccomStudBookProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudBookProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudBookProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudBookProvider SqlAccomStudBookProvider
		{
			get {return AccomStudBookProvider as SqlAccomStudBookProvider;}
		}
		
		#endregion
		
		
		#region "AccomCdePrecondProvider"
			
		private SqlAccomCdePrecondProvider innerSqlAccomCdePrecondProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomCdePrecond"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomCdePrecondProviderBase AccomCdePrecondProvider
		{
			get
			{
				if (innerSqlAccomCdePrecondProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomCdePrecondProvider == null)
						{
							this.innerSqlAccomCdePrecondProvider = new SqlAccomCdePrecondProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomCdePrecondProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomCdePrecondProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomCdePrecondProvider SqlAccomCdePrecondProvider
		{
			get {return AccomCdePrecondProvider as SqlAccomCdePrecondProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudDismissProvider"
			
		private SqlAccomStudDismissProvider innerSqlAccomStudDismissProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudDismiss"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudDismissProviderBase AccomStudDismissProvider
		{
			get
			{
				if (innerSqlAccomStudDismissProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudDismissProvider == null)
						{
							this.innerSqlAccomStudDismissProvider = new SqlAccomStudDismissProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudDismissProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudDismissProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudDismissProvider SqlAccomStudDismissProvider
		{
			get {return AccomStudDismissProvider as SqlAccomStudDismissProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudPermtReqProvider"
			
		private SqlAccomStudPermtReqProvider innerSqlAccomStudPermtReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudPermtReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudPermtReqProviderBase AccomStudPermtReqProvider
		{
			get
			{
				if (innerSqlAccomStudPermtReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudPermtReqProvider == null)
						{
							this.innerSqlAccomStudPermtReqProvider = new SqlAccomStudPermtReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudPermtReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudPermtReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudPermtReqProvider SqlAccomStudPermtReqProvider
		{
			get {return AccomStudPermtReqProvider as SqlAccomStudPermtReqProvider;}
		}
		
		#endregion
		
		
		#region "AdmExamGrdngPkgProvider"
			
		private SqlAdmExamGrdngPkgProvider innerSqlAdmExamGrdngPkgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmExamGrdngPkg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmExamGrdngPkgProviderBase AdmExamGrdngPkgProvider
		{
			get
			{
				if (innerSqlAdmExamGrdngPkgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmExamGrdngPkgProvider == null)
						{
							this.innerSqlAdmExamGrdngPkgProvider = new SqlAdmExamGrdngPkgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmExamGrdngPkgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmExamGrdngPkgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmExamGrdngPkgProvider SqlAdmExamGrdngPkgProvider
		{
			get {return AdmExamGrdngPkgProvider as SqlAdmExamGrdngPkgProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudReqProvider"
			
		private SqlAccomStudReqProvider innerSqlAccomStudReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudReqProviderBase AccomStudReqProvider
		{
			get
			{
				if (innerSqlAccomStudReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudReqProvider == null)
						{
							this.innerSqlAccomStudReqProvider = new SqlAccomStudReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudReqProvider SqlAccomStudReqProvider
		{
			get {return AccomStudReqProvider as SqlAccomStudReqProvider;}
		}
		
		#endregion
		
		
		#region "AccomWfRequestApproveProvider"
			
		private SqlAccomWfRequestApproveProvider innerSqlAccomWfRequestApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomWfRequestApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomWfRequestApproveProviderBase AccomWfRequestApproveProvider
		{
			get
			{
				if (innerSqlAccomWfRequestApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomWfRequestApproveProvider == null)
						{
							this.innerSqlAccomWfRequestApproveProvider = new SqlAccomWfRequestApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomWfRequestApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomWfRequestApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomWfRequestApproveProvider SqlAccomWfRequestApproveProvider
		{
			get {return AccomWfRequestApproveProvider as SqlAccomWfRequestApproveProvider;}
		}
		
		#endregion
		
		
		#region "AdmDecisionStatusProvider"
			
		private SqlAdmDecisionStatusProvider innerSqlAdmDecisionStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmDecisionStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmDecisionStatusProviderBase AdmDecisionStatusProvider
		{
			get
			{
				if (innerSqlAdmDecisionStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmDecisionStatusProvider == null)
						{
							this.innerSqlAdmDecisionStatusProvider = new SqlAdmDecisionStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmDecisionStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmDecisionStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmDecisionStatusProvider SqlAdmDecisionStatusProvider
		{
			get {return AdmDecisionStatusProvider as SqlAdmDecisionStatusProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudLeaveReqProvider"
			
		private SqlAccomStudLeaveReqProvider innerSqlAccomStudLeaveReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudLeaveReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudLeaveReqProviderBase AccomStudLeaveReqProvider
		{
			get
			{
				if (innerSqlAccomStudLeaveReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudLeaveReqProvider == null)
						{
							this.innerSqlAccomStudLeaveReqProvider = new SqlAccomStudLeaveReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudLeaveReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudLeaveReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudLeaveReqProvider SqlAccomStudLeaveReqProvider
		{
			get {return AccomStudLeaveReqProvider as SqlAccomStudLeaveReqProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudFeedReqProvider"
			
		private SqlAccomStudFeedReqProvider innerSqlAccomStudFeedReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudFeedReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudFeedReqProviderBase AccomStudFeedReqProvider
		{
			get
			{
				if (innerSqlAccomStudFeedReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudFeedReqProvider == null)
						{
							this.innerSqlAccomStudFeedReqProvider = new SqlAccomStudFeedReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudFeedReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudFeedReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudFeedReqProvider SqlAccomStudFeedReqProvider
		{
			get {return AccomStudFeedReqProvider as SqlAccomStudFeedReqProvider;}
		}
		
		#endregion
		
		
		#region "AdmOpenAcadSemesterProvider"
			
		private SqlAdmOpenAcadSemesterProvider innerSqlAdmOpenAcadSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmOpenAcadSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmOpenAcadSemesterProviderBase AdmOpenAcadSemesterProvider
		{
			get
			{
				if (innerSqlAdmOpenAcadSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmOpenAcadSemesterProvider == null)
						{
							this.innerSqlAdmOpenAcadSemesterProvider = new SqlAdmOpenAcadSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmOpenAcadSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmOpenAcadSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmOpenAcadSemesterProvider SqlAdmOpenAcadSemesterProvider
		{
			get {return AdmOpenAcadSemesterProvider as SqlAdmOpenAcadSemesterProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudFeedReqDtlProvider"
			
		private SqlAccomStudFeedReqDtlProvider innerSqlAccomStudFeedReqDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudFeedReqDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudFeedReqDtlProviderBase AccomStudFeedReqDtlProvider
		{
			get
			{
				if (innerSqlAccomStudFeedReqDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudFeedReqDtlProvider == null)
						{
							this.innerSqlAccomStudFeedReqDtlProvider = new SqlAccomStudFeedReqDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudFeedReqDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudFeedReqDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudFeedReqDtlProvider SqlAccomStudFeedReqDtlProvider
		{
			get {return AccomStudFeedReqDtlProvider as SqlAccomStudFeedReqDtlProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudLateProvider"
			
		private SqlAccomStudLateProvider innerSqlAccomStudLateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudLate"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudLateProviderBase AccomStudLateProvider
		{
			get
			{
				if (innerSqlAccomStudLateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudLateProvider == null)
						{
							this.innerSqlAccomStudLateProvider = new SqlAccomStudLateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudLateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudLateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudLateProvider SqlAccomStudLateProvider
		{
			get {return AccomStudLateProvider as SqlAccomStudLateProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppLtrRecomProvider"
			
		private SqlAdmAppLtrRecomProvider innerSqlAdmAppLtrRecomProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppLtrRecom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppLtrRecomProviderBase AdmAppLtrRecomProvider
		{
			get
			{
				if (innerSqlAdmAppLtrRecomProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppLtrRecomProvider == null)
						{
							this.innerSqlAdmAppLtrRecomProvider = new SqlAdmAppLtrRecomProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppLtrRecomProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppLtrRecomProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppLtrRecomProvider SqlAdmAppLtrRecomProvider
		{
			get {return AdmAppLtrRecomProvider as SqlAdmAppLtrRecomProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudGuestReqProvider"
			
		private SqlAccomStudGuestReqProvider innerSqlAccomStudGuestReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudGuestReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudGuestReqProviderBase AccomStudGuestReqProvider
		{
			get
			{
				if (innerSqlAccomStudGuestReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudGuestReqProvider == null)
						{
							this.innerSqlAccomStudGuestReqProvider = new SqlAccomStudGuestReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudGuestReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudGuestReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudGuestReqProvider SqlAccomStudGuestReqProvider
		{
			get {return AccomStudGuestReqProvider as SqlAccomStudGuestReqProvider;}
		}
		
		#endregion
		
		
		#region "AccomStudGuestReqDtlProvider"
			
		private SqlAccomStudGuestReqDtlProvider innerSqlAccomStudGuestReqDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AccomStudGuestReqDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AccomStudGuestReqDtlProviderBase AccomStudGuestReqDtlProvider
		{
			get
			{
				if (innerSqlAccomStudGuestReqDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAccomStudGuestReqDtlProvider == null)
						{
							this.innerSqlAccomStudGuestReqDtlProvider = new SqlAccomStudGuestReqDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAccomStudGuestReqDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAccomStudGuestReqDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAccomStudGuestReqDtlProvider SqlAccomStudGuestReqDtlProvider
		{
			get {return AccomStudGuestReqDtlProvider as SqlAccomStudGuestReqDtlProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppMediaProvider"
			
		private SqlAdmAppMediaProvider innerSqlAdmAppMediaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppMedia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppMediaProviderBase AdmAppMediaProvider
		{
			get
			{
				if (innerSqlAdmAppMediaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppMediaProvider == null)
						{
							this.innerSqlAdmAppMediaProvider = new SqlAdmAppMediaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppMediaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppMediaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppMediaProvider SqlAdmAppMediaProvider
		{
			get {return AdmAppMediaProvider as SqlAdmAppMediaProvider;}
		}
		
		#endregion
		
		
		#region "AdmParamProvider"
			
		private SqlAdmParamProvider innerSqlAdmParamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmParam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmParamProviderBase AdmParamProvider
		{
			get
			{
				if (innerSqlAdmParamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmParamProvider == null)
						{
							this.innerSqlAdmParamProvider = new SqlAdmParamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmParamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmParamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmParamProvider SqlAdmParamProvider
		{
			get {return AdmParamProvider as SqlAdmParamProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppMessageProvider"
			
		private SqlAdmAppMessageProvider innerSqlAdmAppMessageProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppMessage"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppMessageProviderBase AdmAppMessageProvider
		{
			get
			{
				if (innerSqlAdmAppMessageProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppMessageProvider == null)
						{
							this.innerSqlAdmAppMessageProvider = new SqlAdmAppMessageProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppMessageProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppMessageProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppMessageProvider SqlAdmAppMessageProvider
		{
			get {return AdmAppMessageProvider as SqlAdmAppMessageProvider;}
		}
		
		#endregion
		
		
		#region "AdmParamMajorPhaseProvider"
			
		private SqlAdmParamMajorPhaseProvider innerSqlAdmParamMajorPhaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmParamMajorPhase"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmParamMajorPhaseProviderBase AdmParamMajorPhaseProvider
		{
			get
			{
				if (innerSqlAdmParamMajorPhaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmParamMajorPhaseProvider == null)
						{
							this.innerSqlAdmParamMajorPhaseProvider = new SqlAdmParamMajorPhaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmParamMajorPhaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmParamMajorPhaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmParamMajorPhaseProvider SqlAdmParamMajorPhaseProvider
		{
			get {return AdmParamMajorPhaseProvider as SqlAdmParamMajorPhaseProvider;}
		}
		
		#endregion
		
		
		#region "AdmOutboxProvider"
			
		private SqlAdmOutboxProvider innerSqlAdmOutboxProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmOutbox"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmOutboxProviderBase AdmOutboxProvider
		{
			get
			{
				if (innerSqlAdmOutboxProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmOutboxProvider == null)
						{
							this.innerSqlAdmOutboxProvider = new SqlAdmOutboxProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmOutboxProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmOutboxProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmOutboxProvider SqlAdmOutboxProvider
		{
			get {return AdmOutboxProvider as SqlAdmOutboxProvider;}
		}
		
		#endregion
		
		
		#region "AdmPlaceExamCourseProvider"
			
		private SqlAdmPlaceExamCourseProvider innerSqlAdmPlaceExamCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmPlaceExamCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmPlaceExamCourseProviderBase AdmPlaceExamCourseProvider
		{
			get
			{
				if (innerSqlAdmPlaceExamCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmPlaceExamCourseProvider == null)
						{
							this.innerSqlAdmPlaceExamCourseProvider = new SqlAdmPlaceExamCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmPlaceExamCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmPlaceExamCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmPlaceExamCourseProvider SqlAdmPlaceExamCourseProvider
		{
			get {return AdmPlaceExamCourseProvider as SqlAdmPlaceExamCourseProvider;}
		}
		
		#endregion
		
		
		#region "AdmIntTransferAcceptanceProvider"
			
		private SqlAdmIntTransferAcceptanceProvider innerSqlAdmIntTransferAcceptanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmIntTransferAcceptance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmIntTransferAcceptanceProviderBase AdmIntTransferAcceptanceProvider
		{
			get
			{
				if (innerSqlAdmIntTransferAcceptanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmIntTransferAcceptanceProvider == null)
						{
							this.innerSqlAdmIntTransferAcceptanceProvider = new SqlAdmIntTransferAcceptanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmIntTransferAcceptanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmIntTransferAcceptanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmIntTransferAcceptanceProvider SqlAdmIntTransferAcceptanceProvider
		{
			get {return AdmIntTransferAcceptanceProvider as SqlAdmIntTransferAcceptanceProvider;}
		}
		
		#endregion
		
		
		#region "AdmFeePromocodeProvider"
			
		private SqlAdmFeePromocodeProvider innerSqlAdmFeePromocodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmFeePromocode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmFeePromocodeProviderBase AdmFeePromocodeProvider
		{
			get
			{
				if (innerSqlAdmFeePromocodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmFeePromocodeProvider == null)
						{
							this.innerSqlAdmFeePromocodeProvider = new SqlAdmFeePromocodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmFeePromocodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmFeePromocodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmFeePromocodeProvider SqlAdmFeePromocodeProvider
		{
			get {return AdmFeePromocodeProvider as SqlAdmFeePromocodeProvider;}
		}
		
		#endregion
		
		
		#region "AdmCodeEngTestProvider"
			
		private SqlAdmCodeEngTestProvider innerSqlAdmCodeEngTestProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCodeEngTest"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCodeEngTestProviderBase AdmCodeEngTestProvider
		{
			get
			{
				if (innerSqlAdmCodeEngTestProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCodeEngTestProvider == null)
						{
							this.innerSqlAdmCodeEngTestProvider = new SqlAdmCodeEngTestProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCodeEngTestProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCodeEngTestProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCodeEngTestProvider SqlAdmCodeEngTestProvider
		{
			get {return AdmCodeEngTestProvider as SqlAdmCodeEngTestProvider;}
		}
		
		#endregion
		
		
		#region "AdmFeeQualCatProvider"
			
		private SqlAdmFeeQualCatProvider innerSqlAdmFeeQualCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmFeeQualCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmFeeQualCatProviderBase AdmFeeQualCatProvider
		{
			get
			{
				if (innerSqlAdmFeeQualCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmFeeQualCatProvider == null)
						{
							this.innerSqlAdmFeeQualCatProvider = new SqlAdmFeeQualCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmFeeQualCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmFeeQualCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmFeeQualCatProvider SqlAdmFeeQualCatProvider
		{
			get {return AdmFeeQualCatProvider as SqlAdmFeeQualCatProvider;}
		}
		
		#endregion
		
		
		#region "AdmPlaceExamDatetimeProvider"
			
		private SqlAdmPlaceExamDatetimeProvider innerSqlAdmPlaceExamDatetimeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmPlaceExamDatetime"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmPlaceExamDatetimeProviderBase AdmPlaceExamDatetimeProvider
		{
			get
			{
				if (innerSqlAdmPlaceExamDatetimeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmPlaceExamDatetimeProvider == null)
						{
							this.innerSqlAdmPlaceExamDatetimeProvider = new SqlAdmPlaceExamDatetimeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmPlaceExamDatetimeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmPlaceExamDatetimeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmPlaceExamDatetimeProvider SqlAdmPlaceExamDatetimeProvider
		{
			get {return AdmPlaceExamDatetimeProvider as SqlAdmPlaceExamDatetimeProvider;}
		}
		
		#endregion
		
		
		#region "AdmInboxProvider"
			
		private SqlAdmInboxProvider innerSqlAdmInboxProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmInbox"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmInboxProviderBase AdmInboxProvider
		{
			get
			{
				if (innerSqlAdmInboxProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmInboxProvider == null)
						{
							this.innerSqlAdmInboxProvider = new SqlAdmInboxProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmInboxProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmInboxProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmInboxProvider SqlAdmInboxProvider
		{
			get {return AdmInboxProvider as SqlAdmInboxProvider;}
		}
		
		#endregion
		
		
		#region "AdmPlaceExamLocProvider"
			
		private SqlAdmPlaceExamLocProvider innerSqlAdmPlaceExamLocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmPlaceExamLoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmPlaceExamLocProviderBase AdmPlaceExamLocProvider
		{
			get
			{
				if (innerSqlAdmPlaceExamLocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmPlaceExamLocProvider == null)
						{
							this.innerSqlAdmPlaceExamLocProvider = new SqlAdmPlaceExamLocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmPlaceExamLocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmPlaceExamLocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmPlaceExamLocProvider SqlAdmPlaceExamLocProvider
		{
			get {return AdmPlaceExamLocProvider as SqlAdmPlaceExamLocProvider;}
		}
		
		#endregion
		
		
		#region "AdmSkillTypeProvider"
			
		private SqlAdmSkillTypeProvider innerSqlAdmSkillTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmSkillType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmSkillTypeProviderBase AdmSkillTypeProvider
		{
			get
			{
				if (innerSqlAdmSkillTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmSkillTypeProvider == null)
						{
							this.innerSqlAdmSkillTypeProvider = new SqlAdmSkillTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmSkillTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmSkillTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmSkillTypeProvider SqlAdmSkillTypeProvider
		{
			get {return AdmSkillTypeProvider as SqlAdmSkillTypeProvider;}
		}
		
		#endregion
		
		
		#region "AdmPrecondQualProvider"
			
		private SqlAdmPrecondQualProvider innerSqlAdmPrecondQualProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmPrecondQual"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmPrecondQualProviderBase AdmPrecondQualProvider
		{
			get
			{
				if (innerSqlAdmPrecondQualProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmPrecondQualProvider == null)
						{
							this.innerSqlAdmPrecondQualProvider = new SqlAdmPrecondQualProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmPrecondQualProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmPrecondQualProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmPrecondQualProvider SqlAdmPrecondQualProvider
		{
			get {return AdmPrecondQualProvider as SqlAdmPrecondQualProvider;}
		}
		
		#endregion
		
		
		#region "AdmStaticScholarshipProvider"
			
		private SqlAdmStaticScholarshipProvider innerSqlAdmStaticScholarshipProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmStaticScholarship"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmStaticScholarshipProviderBase AdmStaticScholarshipProvider
		{
			get
			{
				if (innerSqlAdmStaticScholarshipProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmStaticScholarshipProvider == null)
						{
							this.innerSqlAdmStaticScholarshipProvider = new SqlAdmStaticScholarshipProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmStaticScholarshipProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmStaticScholarshipProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmStaticScholarshipProvider SqlAdmStaticScholarshipProvider
		{
			get {return AdmStaticScholarshipProvider as SqlAdmStaticScholarshipProvider;}
		}
		
		#endregion
		
		
		#region "AdmScholorshipProvider"
			
		private SqlAdmScholorshipProvider innerSqlAdmScholorshipProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmScholorship"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmScholorshipProviderBase AdmScholorshipProvider
		{
			get
			{
				if (innerSqlAdmScholorshipProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmScholorshipProvider == null)
						{
							this.innerSqlAdmScholorshipProvider = new SqlAdmScholorshipProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmScholorshipProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmScholorshipProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmScholorshipProvider SqlAdmScholorshipProvider
		{
			get {return AdmScholorshipProvider as SqlAdmScholorshipProvider;}
		}
		
		#endregion
		
		
		#region "AdmTansikAppCodesProvider"
			
		private SqlAdmTansikAppCodesProvider innerSqlAdmTansikAppCodesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmTansikAppCodes"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmTansikAppCodesProviderBase AdmTansikAppCodesProvider
		{
			get
			{
				if (innerSqlAdmTansikAppCodesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmTansikAppCodesProvider == null)
						{
							this.innerSqlAdmTansikAppCodesProvider = new SqlAdmTansikAppCodesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmTansikAppCodesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmTansikAppCodesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmTansikAppCodesProvider SqlAdmTansikAppCodesProvider
		{
			get {return AdmTansikAppCodesProvider as SqlAdmTansikAppCodesProvider;}
		}
		
		#endregion
		
		
		#region "AdmRsrvdCodeProvider"
			
		private SqlAdmRsrvdCodeProvider innerSqlAdmRsrvdCodeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmRsrvdCode"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmRsrvdCodeProviderBase AdmRsrvdCodeProvider
		{
			get
			{
				if (innerSqlAdmRsrvdCodeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmRsrvdCodeProvider == null)
						{
							this.innerSqlAdmRsrvdCodeProvider = new SqlAdmRsrvdCodeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmRsrvdCodeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmRsrvdCodeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmRsrvdCodeProvider SqlAdmRsrvdCodeProvider
		{
			get {return AdmRsrvdCodeProvider as SqlAdmRsrvdCodeProvider;}
		}
		
		#endregion
		
		
		#region "AdmRatingParametersMajorsProvider"
			
		private SqlAdmRatingParametersMajorsProvider innerSqlAdmRatingParametersMajorsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmRatingParametersMajors"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmRatingParametersMajorsProviderBase AdmRatingParametersMajorsProvider
		{
			get
			{
				if (innerSqlAdmRatingParametersMajorsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmRatingParametersMajorsProvider == null)
						{
							this.innerSqlAdmRatingParametersMajorsProvider = new SqlAdmRatingParametersMajorsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmRatingParametersMajorsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmRatingParametersMajorsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmRatingParametersMajorsProvider SqlAdmRatingParametersMajorsProvider
		{
			get {return AdmRatingParametersMajorsProvider as SqlAdmRatingParametersMajorsProvider;}
		}
		
		#endregion
		
		
		#region "AdmReqDocProvider"
			
		private SqlAdmReqDocProvider innerSqlAdmReqDocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmReqDoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmReqDocProviderBase AdmReqDocProvider
		{
			get
			{
				if (innerSqlAdmReqDocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmReqDocProvider == null)
						{
							this.innerSqlAdmReqDocProvider = new SqlAdmReqDocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmReqDocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmReqDocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmReqDocProvider SqlAdmReqDocProvider
		{
			get {return AdmReqDocProvider as SqlAdmReqDocProvider;}
		}
		
		#endregion
		
		
		#region "AdmRegStepPayOnlineProvider"
			
		private SqlAdmRegStepPayOnlineProvider innerSqlAdmRegStepPayOnlineProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmRegStepPayOnline"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmRegStepPayOnlineProviderBase AdmRegStepPayOnlineProvider
		{
			get
			{
				if (innerSqlAdmRegStepPayOnlineProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmRegStepPayOnlineProvider == null)
						{
							this.innerSqlAdmRegStepPayOnlineProvider = new SqlAdmRegStepPayOnlineProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmRegStepPayOnlineProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmRegStepPayOnlineProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmRegStepPayOnlineProvider SqlAdmRegStepPayOnlineProvider
		{
			get {return AdmRegStepPayOnlineProvider as SqlAdmRegStepPayOnlineProvider;}
		}
		
		#endregion
		
		
		#region "AdmRatingParamMajorTypeProvider"
			
		private SqlAdmRatingParamMajorTypeProvider innerSqlAdmRatingParamMajorTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmRatingParamMajorType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmRatingParamMajorTypeProviderBase AdmRatingParamMajorTypeProvider
		{
			get
			{
				if (innerSqlAdmRatingParamMajorTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmRatingParamMajorTypeProvider == null)
						{
							this.innerSqlAdmRatingParamMajorTypeProvider = new SqlAdmRatingParamMajorTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmRatingParamMajorTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmRatingParamMajorTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmRatingParamMajorTypeProvider SqlAdmRatingParamMajorTypeProvider
		{
			get {return AdmRatingParamMajorTypeProvider as SqlAdmRatingParamMajorTypeProvider;}
		}
		
		#endregion
		
		
		#region "AdmExamGrdngPkgDtlProvider"
			
		private SqlAdmExamGrdngPkgDtlProvider innerSqlAdmExamGrdngPkgDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmExamGrdngPkgDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmExamGrdngPkgDtlProviderBase AdmExamGrdngPkgDtlProvider
		{
			get
			{
				if (innerSqlAdmExamGrdngPkgDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmExamGrdngPkgDtlProvider == null)
						{
							this.innerSqlAdmExamGrdngPkgDtlProvider = new SqlAdmExamGrdngPkgDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmExamGrdngPkgDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmExamGrdngPkgDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmExamGrdngPkgDtlProvider SqlAdmExamGrdngPkgDtlProvider
		{
			get {return AdmExamGrdngPkgDtlProvider as SqlAdmExamGrdngPkgDtlProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppTransReqProvider"
			
		private SqlAdmAppTransReqProvider innerSqlAdmAppTransReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppTransReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppTransReqProviderBase AdmAppTransReqProvider
		{
			get
			{
				if (innerSqlAdmAppTransReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppTransReqProvider == null)
						{
							this.innerSqlAdmAppTransReqProvider = new SqlAdmAppTransReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppTransReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppTransReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppTransReqProvider SqlAdmAppTransReqProvider
		{
			get {return AdmAppTransReqProvider as SqlAdmAppTransReqProvider;}
		}
		
		#endregion
		
		
		#region "AdmEnglishProficiencyProvider"
			
		private SqlAdmEnglishProficiencyProvider innerSqlAdmEnglishProficiencyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmEnglishProficiency"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmEnglishProficiencyProviderBase AdmEnglishProficiencyProvider
		{
			get
			{
				if (innerSqlAdmEnglishProficiencyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmEnglishProficiencyProvider == null)
						{
							this.innerSqlAdmEnglishProficiencyProvider = new SqlAdmEnglishProficiencyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmEnglishProficiencyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmEnglishProficiencyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmEnglishProficiencyProvider SqlAdmEnglishProficiencyProvider
		{
			get {return AdmEnglishProficiencyProvider as SqlAdmEnglishProficiencyProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppTransFromCourseProvider"
			
		private SqlAdmAppTransFromCourseProvider innerSqlAdmAppTransFromCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppTransFromCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppTransFromCourseProviderBase AdmAppTransFromCourseProvider
		{
			get
			{
				if (innerSqlAdmAppTransFromCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppTransFromCourseProvider == null)
						{
							this.innerSqlAdmAppTransFromCourseProvider = new SqlAdmAppTransFromCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppTransFromCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppTransFromCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppTransFromCourseProvider SqlAdmAppTransFromCourseProvider
		{
			get {return AdmAppTransFromCourseProvider as SqlAdmAppTransFromCourseProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppTopicProvider"
			
		private SqlAdmAppTopicProvider innerSqlAdmAppTopicProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppTopic"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppTopicProviderBase AdmAppTopicProvider
		{
			get
			{
				if (innerSqlAdmAppTopicProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppTopicProvider == null)
						{
							this.innerSqlAdmAppTopicProvider = new SqlAdmAppTopicProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppTopicProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppTopicProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppTopicProvider SqlAdmAppTopicProvider
		{
			get {return AdmAppTopicProvider as SqlAdmAppTopicProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppTransBalanceProvider"
			
		private SqlAdmAppTransBalanceProvider innerSqlAdmAppTransBalanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppTransBalance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppTransBalanceProviderBase AdmAppTransBalanceProvider
		{
			get
			{
				if (innerSqlAdmAppTransBalanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppTransBalanceProvider == null)
						{
							this.innerSqlAdmAppTransBalanceProvider = new SqlAdmAppTransBalanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppTransBalanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppTransBalanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppTransBalanceProvider SqlAdmAppTransBalanceProvider
		{
			get {return AdmAppTransBalanceProvider as SqlAdmAppTransBalanceProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppSponsorProvider"
			
		private SqlAdmAppSponsorProvider innerSqlAdmAppSponsorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppSponsor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppSponsorProviderBase AdmAppSponsorProvider
		{
			get
			{
				if (innerSqlAdmAppSponsorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppSponsorProvider == null)
						{
							this.innerSqlAdmAppSponsorProvider = new SqlAdmAppSponsorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppSponsorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppSponsorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppSponsorProvider SqlAdmAppSponsorProvider
		{
			get {return AdmAppSponsorProvider as SqlAdmAppSponsorProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppPlaceExamCourseProvider"
			
		private SqlAdmAppPlaceExamCourseProvider innerSqlAdmAppPlaceExamCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppPlaceExamCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppPlaceExamCourseProviderBase AdmAppPlaceExamCourseProvider
		{
			get
			{
				if (innerSqlAdmAppPlaceExamCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppPlaceExamCourseProvider == null)
						{
							this.innerSqlAdmAppPlaceExamCourseProvider = new SqlAdmAppPlaceExamCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppPlaceExamCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppPlaceExamCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppPlaceExamCourseProvider SqlAdmAppPlaceExamCourseProvider
		{
			get {return AdmAppPlaceExamCourseProvider as SqlAdmAppPlaceExamCourseProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppProcStepsProvider"
			
		private SqlAdmAppProcStepsProvider innerSqlAdmAppProcStepsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppProcSteps"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppProcStepsProviderBase AdmAppProcStepsProvider
		{
			get
			{
				if (innerSqlAdmAppProcStepsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppProcStepsProvider == null)
						{
							this.innerSqlAdmAppProcStepsProvider = new SqlAdmAppProcStepsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppProcStepsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppProcStepsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppProcStepsProvider SqlAdmAppProcStepsProvider
		{
			get {return AdmAppProcStepsProvider as SqlAdmAppProcStepsProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppPlacementExamProvider"
			
		private SqlAdmAppPlacementExamProvider innerSqlAdmAppPlacementExamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppPlacementExam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppPlacementExamProviderBase AdmAppPlacementExamProvider
		{
			get
			{
				if (innerSqlAdmAppPlacementExamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppPlacementExamProvider == null)
						{
							this.innerSqlAdmAppPlacementExamProvider = new SqlAdmAppPlacementExamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppPlacementExamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppPlacementExamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppPlacementExamProvider SqlAdmAppPlacementExamProvider
		{
			get {return AdmAppPlacementExamProvider as SqlAdmAppPlacementExamProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppTransToCourseProvider"
			
		private SqlAdmAppTransToCourseProvider innerSqlAdmAppTransToCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppTransToCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppTransToCourseProviderBase AdmAppTransToCourseProvider
		{
			get
			{
				if (innerSqlAdmAppTransToCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppTransToCourseProvider == null)
						{
							this.innerSqlAdmAppTransToCourseProvider = new SqlAdmAppTransToCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppTransToCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppTransToCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppTransToCourseProvider SqlAdmAppTransToCourseProvider
		{
			get {return AdmAppTransToCourseProvider as SqlAdmAppTransToCourseProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppPrefProvider"
			
		private SqlAdmAppPrefProvider innerSqlAdmAppPrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppPref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppPrefProviderBase AdmAppPrefProvider
		{
			get
			{
				if (innerSqlAdmAppPrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppPrefProvider == null)
						{
							this.innerSqlAdmAppPrefProvider = new SqlAdmAppPrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppPrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppPrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppPrefProvider SqlAdmAppPrefProvider
		{
			get {return AdmAppPrefProvider as SqlAdmAppPrefProvider;}
		}
		
		#endregion
		
		
		#region "AdmCodeMasteryProvider"
			
		private SqlAdmCodeMasteryProvider innerSqlAdmCodeMasteryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCodeMastery"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCodeMasteryProviderBase AdmCodeMasteryProvider
		{
			get
			{
				if (innerSqlAdmCodeMasteryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCodeMasteryProvider == null)
						{
							this.innerSqlAdmCodeMasteryProvider = new SqlAdmCodeMasteryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCodeMasteryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCodeMasteryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCodeMasteryProvider SqlAdmCodeMasteryProvider
		{
			get {return AdmCodeMasteryProvider as SqlAdmCodeMasteryProvider;}
		}
		
		#endregion
		
		
		#region "AdmAppWorkExperProvider"
			
		private SqlAdmAppWorkExperProvider innerSqlAdmAppWorkExperProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmAppWorkExper"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmAppWorkExperProviderBase AdmAppWorkExperProvider
		{
			get
			{
				if (innerSqlAdmAppWorkExperProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmAppWorkExperProvider == null)
						{
							this.innerSqlAdmAppWorkExperProvider = new SqlAdmAppWorkExperProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmAppWorkExperProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmAppWorkExperProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmAppWorkExperProvider SqlAdmAppWorkExperProvider
		{
			get {return AdmAppWorkExperProvider as SqlAdmAppWorkExperProvider;}
		}
		
		#endregion
		
		
		#region "AdmCodeTransferTypeProvider"
			
		private SqlAdmCodeTransferTypeProvider innerSqlAdmCodeTransferTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCodeTransferType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCodeTransferTypeProviderBase AdmCodeTransferTypeProvider
		{
			get
			{
				if (innerSqlAdmCodeTransferTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCodeTransferTypeProvider == null)
						{
							this.innerSqlAdmCodeTransferTypeProvider = new SqlAdmCodeTransferTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCodeTransferTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCodeTransferTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCodeTransferTypeProvider SqlAdmCodeTransferTypeProvider
		{
			get {return AdmCodeTransferTypeProvider as SqlAdmCodeTransferTypeProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeQualStatusProvider"
			
		private SqlAdmCdeQualStatusProvider innerSqlAdmCdeQualStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeQualStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeQualStatusProviderBase AdmCdeQualStatusProvider
		{
			get
			{
				if (innerSqlAdmCdeQualStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeQualStatusProvider == null)
						{
							this.innerSqlAdmCdeQualStatusProvider = new SqlAdmCdeQualStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeQualStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeQualStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeQualStatusProvider SqlAdmCdeQualStatusProvider
		{
			get {return AdmCdeQualStatusProvider as SqlAdmCdeQualStatusProvider;}
		}
		
		#endregion
		
		
		#region "AdmCompetitiveAvgProvider"
			
		private SqlAdmCompetitiveAvgProvider innerSqlAdmCompetitiveAvgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCompetitiveAvg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCompetitiveAvgProviderBase AdmCompetitiveAvgProvider
		{
			get
			{
				if (innerSqlAdmCompetitiveAvgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCompetitiveAvgProvider == null)
						{
							this.innerSqlAdmCompetitiveAvgProvider = new SqlAdmCompetitiveAvgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCompetitiveAvgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCompetitiveAvgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCompetitiveAvgProvider SqlAdmCompetitiveAvgProvider
		{
			get {return AdmCompetitiveAvgProvider as SqlAdmCompetitiveAvgProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeMediaProvider"
			
		private SqlAdmCdeMediaProvider innerSqlAdmCdeMediaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeMedia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeMediaProviderBase AdmCdeMediaProvider
		{
			get
			{
				if (innerSqlAdmCdeMediaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeMediaProvider == null)
						{
							this.innerSqlAdmCdeMediaProvider = new SqlAdmCdeMediaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeMediaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeMediaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeMediaProvider SqlAdmCdeMediaProvider
		{
			get {return AdmCdeMediaProvider as SqlAdmCdeMediaProvider;}
		}
		
		#endregion
		
		
		#region "AdmApplicantAcceptanceProvider"
			
		private SqlAdmApplicantAcceptanceProvider innerSqlAdmApplicantAcceptanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmApplicantAcceptance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmApplicantAcceptanceProviderBase AdmApplicantAcceptanceProvider
		{
			get
			{
				if (innerSqlAdmApplicantAcceptanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmApplicantAcceptanceProvider == null)
						{
							this.innerSqlAdmApplicantAcceptanceProvider = new SqlAdmApplicantAcceptanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmApplicantAcceptanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmApplicantAcceptanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmApplicantAcceptanceProvider SqlAdmApplicantAcceptanceProvider
		{
			get {return AdmApplicantAcceptanceProvider as SqlAdmApplicantAcceptanceProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeEssayOptionProvider"
			
		private SqlAdmCdeEssayOptionProvider innerSqlAdmCdeEssayOptionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeEssayOption"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeEssayOptionProviderBase AdmCdeEssayOptionProvider
		{
			get
			{
				if (innerSqlAdmCdeEssayOptionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeEssayOptionProvider == null)
						{
							this.innerSqlAdmCdeEssayOptionProvider = new SqlAdmCdeEssayOptionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeEssayOptionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeEssayOptionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeEssayOptionProvider SqlAdmCdeEssayOptionProvider
		{
			get {return AdmCdeEssayOptionProvider as SqlAdmCdeEssayOptionProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeAlumniPrefProvider"
			
		private SqlAdmCdeAlumniPrefProvider innerSqlAdmCdeAlumniPrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeAlumniPref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeAlumniPrefProviderBase AdmCdeAlumniPrefProvider
		{
			get
			{
				if (innerSqlAdmCdeAlumniPrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeAlumniPrefProvider == null)
						{
							this.innerSqlAdmCdeAlumniPrefProvider = new SqlAdmCdeAlumniPrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeAlumniPrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeAlumniPrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeAlumniPrefProvider SqlAdmCdeAlumniPrefProvider
		{
			get {return AdmCdeAlumniPrefProvider as SqlAdmCdeAlumniPrefProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseBarredProvider"
			
		private SqlEdCourseBarredProvider innerSqlEdCourseBarredProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseBarred"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseBarredProviderBase EdCourseBarredProvider
		{
			get
			{
				if (innerSqlEdCourseBarredProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseBarredProvider == null)
						{
							this.innerSqlEdCourseBarredProvider = new SqlEdCourseBarredProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseBarredProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseBarredProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseBarredProvider SqlEdCourseBarredProvider
		{
			get {return EdCourseBarredProvider as SqlEdCourseBarredProvider;}
		}
		
		#endregion
		
		
		#region "AdmCdeCourseCompProvider"
			
		private SqlAdmCdeCourseCompProvider innerSqlAdmCdeCourseCompProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AdmCdeCourseComp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AdmCdeCourseCompProviderBase AdmCdeCourseCompProvider
		{
			get
			{
				if (innerSqlAdmCdeCourseCompProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAdmCdeCourseCompProvider == null)
						{
							this.innerSqlAdmCdeCourseCompProvider = new SqlAdmCdeCourseCompProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAdmCdeCourseCompProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAdmCdeCourseCompProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAdmCdeCourseCompProvider SqlAdmCdeCourseCompProvider
		{
			get {return AdmCdeCourseCompProvider as SqlAdmCdeCourseCompProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseCoreqProvider"
			
		private SqlEdCourseCoreqProvider innerSqlEdCourseCoreqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseCoreq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseCoreqProviderBase EdCourseCoreqProvider
		{
			get
			{
				if (innerSqlEdCourseCoreqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseCoreqProvider == null)
						{
							this.innerSqlEdCourseCoreqProvider = new SqlEdCourseCoreqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseCoreqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseCoreqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseCoreqProvider SqlEdCourseCoreqProvider
		{
			get {return EdCourseCoreqProvider as SqlEdCourseCoreqProvider;}
		}
		
		#endregion
		
		
		#region "EntCodeMdTypeProvider"
			
		private SqlEntCodeMdTypeProvider innerSqlEntCodeMdTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodeMdType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodeMdTypeProviderBase EntCodeMdTypeProvider
		{
			get
			{
				if (innerSqlEntCodeMdTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodeMdTypeProvider == null)
						{
							this.innerSqlEntCodeMdTypeProvider = new SqlEntCodeMdTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodeMdTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodeMdTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodeMdTypeProvider SqlEntCodeMdTypeProvider
		{
			get {return EntCodeMdTypeProvider as SqlEntCodeMdTypeProvider;}
		}
		
		#endregion
		
		
		#region "EntCodeFullfillMetadataProvider"
			
		private SqlEntCodeFullfillMetadataProvider innerSqlEntCodeFullfillMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodeFullfillMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodeFullfillMetadataProviderBase EntCodeFullfillMetadataProvider
		{
			get
			{
				if (innerSqlEntCodeFullfillMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodeFullfillMetadataProvider == null)
						{
							this.innerSqlEntCodeFullfillMetadataProvider = new SqlEntCodeFullfillMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodeFullfillMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodeFullfillMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodeFullfillMetadataProvider SqlEntCodeFullfillMetadataProvider
		{
			get {return EntCodeFullfillMetadataProvider as SqlEntCodeFullfillMetadataProvider;}
		}
		
		#endregion
		
		
		#region "ErpOrgTreeProvider"
			
		private SqlErpOrgTreeProvider innerSqlErpOrgTreeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ErpOrgTree"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ErpOrgTreeProviderBase ErpOrgTreeProvider
		{
			get
			{
				if (innerSqlErpOrgTreeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlErpOrgTreeProvider == null)
						{
							this.innerSqlErpOrgTreeProvider = new SqlErpOrgTreeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlErpOrgTreeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlErpOrgTreeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlErpOrgTreeProvider SqlErpOrgTreeProvider
		{
			get {return ErpOrgTreeProvider as SqlErpOrgTreeProvider;}
		}
		
		#endregion
		
		
		#region "EntIntroducMetadataProvider"
			
		private SqlEntIntroducMetadataProvider innerSqlEntIntroducMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntIntroducMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntIntroducMetadataProviderBase EntIntroducMetadataProvider
		{
			get
			{
				if (innerSqlEntIntroducMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntIntroducMetadataProvider == null)
						{
							this.innerSqlEntIntroducMetadataProvider = new SqlEntIntroducMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntIntroducMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntIntroducMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntIntroducMetadataProvider SqlEntIntroducMetadataProvider
		{
			get {return EntIntroducMetadataProvider as SqlEntIntroducMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntIntroducMdDataProvider"
			
		private SqlEntIntroducMdDataProvider innerSqlEntIntroducMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntIntroducMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntIntroducMdDataProviderBase EntIntroducMdDataProvider
		{
			get
			{
				if (innerSqlEntIntroducMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntIntroducMdDataProvider == null)
						{
							this.innerSqlEntIntroducMdDataProvider = new SqlEntIntroducMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntIntroducMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntIntroducMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntIntroducMdDataProvider SqlEntIntroducMdDataProvider
		{
			get {return EntIntroducMdDataProvider as SqlEntIntroducMdDataProvider;}
		}
		
		#endregion
		
		
		#region "EntGraduationReqProvider"
			
		private SqlEntGraduationReqProvider innerSqlEntGraduationReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntGraduationReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntGraduationReqProviderBase EntGraduationReqProvider
		{
			get
			{
				if (innerSqlEntGraduationReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntGraduationReqProvider == null)
						{
							this.innerSqlEntGraduationReqProvider = new SqlEntGraduationReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntGraduationReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntGraduationReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntGraduationReqProvider SqlEntGraduationReqProvider
		{
			get {return EntGraduationReqProvider as SqlEntGraduationReqProvider;}
		}
		
		#endregion
		
		
		#region "EntCodePrecondMetadataProvider"
			
		private SqlEntCodePrecondMetadataProvider innerSqlEntCodePrecondMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodePrecondMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodePrecondMetadataProviderBase EntCodePrecondMetadataProvider
		{
			get
			{
				if (innerSqlEntCodePrecondMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodePrecondMetadataProvider == null)
						{
							this.innerSqlEntCodePrecondMetadataProvider = new SqlEntCodePrecondMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodePrecondMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodePrecondMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodePrecondMetadataProvider SqlEntCodePrecondMetadataProvider
		{
			get {return EntCodePrecondMetadataProvider as SqlEntCodePrecondMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntGradingMetadataProvider"
			
		private SqlEntGradingMetadataProvider innerSqlEntGradingMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntGradingMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntGradingMetadataProviderBase EntGradingMetadataProvider
		{
			get
			{
				if (innerSqlEntGradingMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntGradingMetadataProvider == null)
						{
							this.innerSqlEntGradingMetadataProvider = new SqlEntGradingMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntGradingMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntGradingMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntGradingMetadataProvider SqlEntGradingMetadataProvider
		{
			get {return EntGradingMetadataProvider as SqlEntGradingMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntFullfillMetadataProvider"
			
		private SqlEntFullfillMetadataProvider innerSqlEntFullfillMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntFullfillMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntFullfillMetadataProviderBase EntFullfillMetadataProvider
		{
			get
			{
				if (innerSqlEntFullfillMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntFullfillMetadataProvider == null)
						{
							this.innerSqlEntFullfillMetadataProvider = new SqlEntFullfillMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntFullfillMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntFullfillMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntFullfillMetadataProvider SqlEntFullfillMetadataProvider
		{
			get {return EntFullfillMetadataProvider as SqlEntFullfillMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntGradingMdDataProvider"
			
		private SqlEntGradingMdDataProvider innerSqlEntGradingMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntGradingMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntGradingMdDataProviderBase EntGradingMdDataProvider
		{
			get
			{
				if (innerSqlEntGradingMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntGradingMdDataProvider == null)
						{
							this.innerSqlEntGradingMdDataProvider = new SqlEntGradingMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntGradingMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntGradingMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntGradingMdDataProvider SqlEntGradingMdDataProvider
		{
			get {return EntGradingMdDataProvider as SqlEntGradingMdDataProvider;}
		}
		
		#endregion
		
		
		#region "EntFullfillMdDataProvider"
			
		private SqlEntFullfillMdDataProvider innerSqlEntFullfillMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntFullfillMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntFullfillMdDataProviderBase EntFullfillMdDataProvider
		{
			get
			{
				if (innerSqlEntFullfillMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntFullfillMdDataProvider == null)
						{
							this.innerSqlEntFullfillMdDataProvider = new SqlEntFullfillMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntFullfillMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntFullfillMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntFullfillMdDataProvider SqlEntFullfillMdDataProvider
		{
			get {return EntFullfillMdDataProvider as SqlEntFullfillMdDataProvider;}
		}
		
		#endregion
		
		
		#region "EntMainMatrixProvider"
			
		private SqlEntMainMatrixProvider innerSqlEntMainMatrixProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntMainMatrix"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntMainMatrixProviderBase EntMainMatrixProvider
		{
			get
			{
				if (innerSqlEntMainMatrixProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntMainMatrixProvider == null)
						{
							this.innerSqlEntMainMatrixProvider = new SqlEntMainMatrixProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntMainMatrixProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntMainMatrixProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntMainMatrixProvider SqlEntMainMatrixProvider
		{
			get {return EntMainMatrixProvider as SqlEntMainMatrixProvider;}
		}
		
		#endregion
		
		
		#region "EntMajorPhaseProvider"
			
		private SqlEntMajorPhaseProvider innerSqlEntMajorPhaseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntMajorPhase"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntMajorPhaseProviderBase EntMajorPhaseProvider
		{
			get
			{
				if (innerSqlEntMajorPhaseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntMajorPhaseProvider == null)
						{
							this.innerSqlEntMajorPhaseProvider = new SqlEntMajorPhaseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntMajorPhaseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntMajorPhaseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntMajorPhaseProvider SqlEntMajorPhaseProvider
		{
			get {return EntMajorPhaseProvider as SqlEntMajorPhaseProvider;}
		}
		
		#endregion
		
		
		#region "EntMajorPhaseCrsExpProvider"
			
		private SqlEntMajorPhaseCrsExpProvider innerSqlEntMajorPhaseCrsExpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntMajorPhaseCrsExp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntMajorPhaseCrsExpProviderBase EntMajorPhaseCrsExpProvider
		{
			get
			{
				if (innerSqlEntMajorPhaseCrsExpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntMajorPhaseCrsExpProvider == null)
						{
							this.innerSqlEntMajorPhaseCrsExpProvider = new SqlEntMajorPhaseCrsExpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntMajorPhaseCrsExpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntMajorPhaseCrsExpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntMajorPhaseCrsExpProvider SqlEntMajorPhaseCrsExpProvider
		{
			get {return EntMajorPhaseCrsExpProvider as SqlEntMajorPhaseCrsExpProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAccumHonorProvider"
			
		private SqlEntPolicyAccumHonorProvider innerSqlEntPolicyAccumHonorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAccumHonor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAccumHonorProviderBase EntPolicyAccumHonorProvider
		{
			get
			{
				if (innerSqlEntPolicyAccumHonorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAccumHonorProvider == null)
						{
							this.innerSqlEntPolicyAccumHonorProvider = new SqlEntPolicyAccumHonorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAccumHonorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAccumHonorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAccumHonorProvider SqlEntPolicyAccumHonorProvider
		{
			get {return EntPolicyAccumHonorProvider as SqlEntPolicyAccumHonorProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAssessCourseProvider"
			
		private SqlEntPolicyAssessCourseProvider innerSqlEntPolicyAssessCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAssessCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAssessCourseProviderBase EntPolicyAssessCourseProvider
		{
			get
			{
				if (innerSqlEntPolicyAssessCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAssessCourseProvider == null)
						{
							this.innerSqlEntPolicyAssessCourseProvider = new SqlEntPolicyAssessCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAssessCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAssessCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAssessCourseProvider SqlEntPolicyAssessCourseProvider
		{
			get {return EntPolicyAssessCourseProvider as SqlEntPolicyAssessCourseProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAssessDtlProvider"
			
		private SqlEntPolicyAssessDtlProvider innerSqlEntPolicyAssessDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAssessDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAssessDtlProviderBase EntPolicyAssessDtlProvider
		{
			get
			{
				if (innerSqlEntPolicyAssessDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAssessDtlProvider == null)
						{
							this.innerSqlEntPolicyAssessDtlProvider = new SqlEntPolicyAssessDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAssessDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAssessDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAssessDtlProvider SqlEntPolicyAssessDtlProvider
		{
			get {return EntPolicyAssessDtlProvider as SqlEntPolicyAssessDtlProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAssessGrpDtlProvider"
			
		private SqlEntPolicyAssessGrpDtlProvider innerSqlEntPolicyAssessGrpDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAssessGrpDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAssessGrpDtlProviderBase EntPolicyAssessGrpDtlProvider
		{
			get
			{
				if (innerSqlEntPolicyAssessGrpDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAssessGrpDtlProvider == null)
						{
							this.innerSqlEntPolicyAssessGrpDtlProvider = new SqlEntPolicyAssessGrpDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAssessGrpDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAssessGrpDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAssessGrpDtlProvider SqlEntPolicyAssessGrpDtlProvider
		{
			get {return EntPolicyAssessGrpDtlProvider as SqlEntPolicyAssessGrpDtlProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAbsenceProvider"
			
		private SqlEntPolicyAbsenceProvider innerSqlEntPolicyAbsenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAbsence"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAbsenceProviderBase EntPolicyAbsenceProvider
		{
			get
			{
				if (innerSqlEntPolicyAbsenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAbsenceProvider == null)
						{
							this.innerSqlEntPolicyAbsenceProvider = new SqlEntPolicyAbsenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAbsenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAbsenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAbsenceProvider SqlEntPolicyAbsenceProvider
		{
			get {return EntPolicyAbsenceProvider as SqlEntPolicyAbsenceProvider;}
		}
		
		#endregion
		
		
		#region "EntPolcyGrdngHdrProvider"
			
		private SqlEntPolcyGrdngHdrProvider innerSqlEntPolcyGrdngHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolcyGrdngHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolcyGrdngHdrProviderBase EntPolcyGrdngHdrProvider
		{
			get
			{
				if (innerSqlEntPolcyGrdngHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolcyGrdngHdrProvider == null)
						{
							this.innerSqlEntPolcyGrdngHdrProvider = new SqlEntPolcyGrdngHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolcyGrdngHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolcyGrdngHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolcyGrdngHdrProvider SqlEntPolcyGrdngHdrProvider
		{
			get {return EntPolcyGrdngHdrProvider as SqlEntPolcyGrdngHdrProvider;}
		}
		
		#endregion
		
		
		#region "EntPolcyGrdngCourseProvider"
			
		private SqlEntPolcyGrdngCourseProvider innerSqlEntPolcyGrdngCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolcyGrdngCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolcyGrdngCourseProviderBase EntPolcyGrdngCourseProvider
		{
			get
			{
				if (innerSqlEntPolcyGrdngCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolcyGrdngCourseProvider == null)
						{
							this.innerSqlEntPolcyGrdngCourseProvider = new SqlEntPolcyGrdngCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolcyGrdngCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolcyGrdngCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolcyGrdngCourseProvider SqlEntPolcyGrdngCourseProvider
		{
			get {return EntPolcyGrdngCourseProvider as SqlEntPolcyGrdngCourseProvider;}
		}
		
		#endregion
		
		
		#region "EntPlcyAcadWarnProvider"
			
		private SqlEntPlcyAcadWarnProvider innerSqlEntPlcyAcadWarnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPlcyAcadWarn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPlcyAcadWarnProviderBase EntPlcyAcadWarnProvider
		{
			get
			{
				if (innerSqlEntPlcyAcadWarnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPlcyAcadWarnProvider == null)
						{
							this.innerSqlEntPlcyAcadWarnProvider = new SqlEntPlcyAcadWarnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPlcyAcadWarnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPlcyAcadWarnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPlcyAcadWarnProvider SqlEntPlcyAcadWarnProvider
		{
			get {return EntPlcyAcadWarnProvider as SqlEntPlcyAcadWarnProvider;}
		}
		
		#endregion
		
		
		#region "EntPlcyAcadWarnDtlProvider"
			
		private SqlEntPlcyAcadWarnDtlProvider innerSqlEntPlcyAcadWarnDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPlcyAcadWarnDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPlcyAcadWarnDtlProviderBase EntPlcyAcadWarnDtlProvider
		{
			get
			{
				if (innerSqlEntPlcyAcadWarnDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPlcyAcadWarnDtlProvider == null)
						{
							this.innerSqlEntPlcyAcadWarnDtlProvider = new SqlEntPlcyAcadWarnDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPlcyAcadWarnDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPlcyAcadWarnDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPlcyAcadWarnDtlProvider SqlEntPlcyAcadWarnDtlProvider
		{
			get {return EntPlcyAcadWarnDtlProvider as SqlEntPlcyAcadWarnDtlProvider;}
		}
		
		#endregion
		
		
		#region "EntPolcyCrsRetakeProvider"
			
		private SqlEntPolcyCrsRetakeProvider innerSqlEntPolcyCrsRetakeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolcyCrsRetake"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolcyCrsRetakeProviderBase EntPolcyCrsRetakeProvider
		{
			get
			{
				if (innerSqlEntPolcyCrsRetakeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolcyCrsRetakeProvider == null)
						{
							this.innerSqlEntPolcyCrsRetakeProvider = new SqlEntPolcyCrsRetakeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolcyCrsRetakeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolcyCrsRetakeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolcyCrsRetakeProvider SqlEntPolcyCrsRetakeProvider
		{
			get {return EntPolcyCrsRetakeProvider as SqlEntPolcyCrsRetakeProvider;}
		}
		
		#endregion
		
		
		#region "EntPolcyGpaProvider"
			
		private SqlEntPolcyGpaProvider innerSqlEntPolcyGpaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolcyGpa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolcyGpaProviderBase EntPolcyGpaProvider
		{
			get
			{
				if (innerSqlEntPolcyGpaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolcyGpaProvider == null)
						{
							this.innerSqlEntPolcyGpaProvider = new SqlEntPolcyGpaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolcyGpaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolcyGpaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolcyGpaProvider SqlEntPolcyGpaProvider
		{
			get {return EntPolcyGpaProvider as SqlEntPolcyGpaProvider;}
		}
		
		#endregion
		
		
		#region "EntCoursePkgMdDataProvider"
			
		private SqlEntCoursePkgMdDataProvider innerSqlEntCoursePkgMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCoursePkgMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCoursePkgMdDataProviderBase EntCoursePkgMdDataProvider
		{
			get
			{
				if (innerSqlEntCoursePkgMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCoursePkgMdDataProvider == null)
						{
							this.innerSqlEntCoursePkgMdDataProvider = new SqlEntCoursePkgMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCoursePkgMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCoursePkgMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCoursePkgMdDataProvider SqlEntCoursePkgMdDataProvider
		{
			get {return EntCoursePkgMdDataProvider as SqlEntCoursePkgMdDataProvider;}
		}
		
		#endregion
		
		
		#region "EntCoursePkgHdrProvider"
			
		private SqlEntCoursePkgHdrProvider innerSqlEntCoursePkgHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCoursePkgHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCoursePkgHdrProviderBase EntCoursePkgHdrProvider
		{
			get
			{
				if (innerSqlEntCoursePkgHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCoursePkgHdrProvider == null)
						{
							this.innerSqlEntCoursePkgHdrProvider = new SqlEntCoursePkgHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCoursePkgHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCoursePkgHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCoursePkgHdrProvider SqlEntCoursePkgHdrProvider
		{
			get {return EntCoursePkgHdrProvider as SqlEntCoursePkgHdrProvider;}
		}
		
		#endregion
		
		
		#region "EntCoursePkgDtlProvider"
			
		private SqlEntCoursePkgDtlProvider innerSqlEntCoursePkgDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCoursePkgDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCoursePkgDtlProviderBase EntCoursePkgDtlProvider
		{
			get
			{
				if (innerSqlEntCoursePkgDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCoursePkgDtlProvider == null)
						{
							this.innerSqlEntCoursePkgDtlProvider = new SqlEntCoursePkgDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCoursePkgDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCoursePkgDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCoursePkgDtlProvider SqlEntCoursePkgDtlProvider
		{
			get {return EntCoursePkgDtlProvider as SqlEntCoursePkgDtlProvider;}
		}
		
		#endregion
		
		
		#region "EdStudStateTempProvider"
			
		private SqlEdStudStateTempProvider innerSqlEdStudStateTempProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudStateTemp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudStateTempProviderBase EdStudStateTempProvider
		{
			get
			{
				if (innerSqlEdStudStateTempProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudStateTempProvider == null)
						{
							this.innerSqlEdStudStateTempProvider = new SqlEdStudStateTempProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudStateTempProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudStateTempProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudStateTempProvider SqlEdStudStateTempProvider
		{
			get {return EdStudStateTempProvider as SqlEdStudStateTempProvider;}
		}
		
		#endregion
		
		
		#region "EdStudTransProvider"
			
		private SqlEdStudTransProvider innerSqlEdStudTransProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudTrans"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudTransProviderBase EdStudTransProvider
		{
			get
			{
				if (innerSqlEdStudTransProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudTransProvider == null)
						{
							this.innerSqlEdStudTransProvider = new SqlEdStudTransProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudTransProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudTransProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudTransProvider SqlEdStudTransProvider
		{
			get {return EdStudTransProvider as SqlEdStudTransProvider;}
		}
		
		#endregion
		
		
		#region "EdStudTransFromReqProvider"
			
		private SqlEdStudTransFromReqProvider innerSqlEdStudTransFromReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudTransFromReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudTransFromReqProviderBase EdStudTransFromReqProvider
		{
			get
			{
				if (innerSqlEdStudTransFromReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudTransFromReqProvider == null)
						{
							this.innerSqlEdStudTransFromReqProvider = new SqlEdStudTransFromReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudTransFromReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudTransFromReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudTransFromReqProvider SqlEdStudTransFromReqProvider
		{
			get {return EdStudTransFromReqProvider as SqlEdStudTransFromReqProvider;}
		}
		
		#endregion
		
		
		#region "EdStudViolProvider"
			
		private SqlEdStudViolProvider innerSqlEdStudViolProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudViol"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudViolProviderBase EdStudViolProvider
		{
			get
			{
				if (innerSqlEdStudViolProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudViolProvider == null)
						{
							this.innerSqlEdStudViolProvider = new SqlEdStudViolProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudViolProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudViolProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudViolProvider SqlEdStudViolProvider
		{
			get {return EdStudViolProvider as SqlEdStudViolProvider;}
		}
		
		#endregion
		
		
		#region "EdStudStateProvider"
			
		private SqlEdStudStateProvider innerSqlEdStudStateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudState"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudStateProviderBase EdStudStateProvider
		{
			get
			{
				if (innerSqlEdStudStateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudStateProvider == null)
						{
							this.innerSqlEdStudStateProvider = new SqlEdStudStateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudStateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudStateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudStateProvider SqlEdStudStateProvider
		{
			get {return EdStudStateProvider as SqlEdStudStateProvider;}
		}
		
		#endregion
		
		
		#region "EdStudSportProvider"
			
		private SqlEdStudSportProvider innerSqlEdStudSportProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudSport"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudSportProviderBase EdStudSportProvider
		{
			get
			{
				if (innerSqlEdStudSportProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudSportProvider == null)
						{
							this.innerSqlEdStudSportProvider = new SqlEdStudSportProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudSportProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudSportProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudSportProvider SqlEdStudSportProvider
		{
			get {return EdStudSportProvider as SqlEdStudSportProvider;}
		}
		
		#endregion
		
		
		#region "EdStudSemesterProvider"
			
		private SqlEdStudSemesterProvider innerSqlEdStudSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudSemesterProviderBase EdStudSemesterProvider
		{
			get
			{
				if (innerSqlEdStudSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudSemesterProvider == null)
						{
							this.innerSqlEdStudSemesterProvider = new SqlEdStudSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudSemesterProvider SqlEdStudSemesterProvider
		{
			get {return EdStudSemesterProvider as SqlEdStudSemesterProvider;}
		}
		
		#endregion
		
		
		#region "EdStudSemesterExtProvider"
			
		private SqlEdStudSemesterExtProvider innerSqlEdStudSemesterExtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudSemesterExt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudSemesterExtProviderBase EdStudSemesterExtProvider
		{
			get
			{
				if (innerSqlEdStudSemesterExtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudSemesterExtProvider == null)
						{
							this.innerSqlEdStudSemesterExtProvider = new SqlEdStudSemesterExtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudSemesterExtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudSemesterExtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudSemesterExtProvider SqlEdStudSemesterExtProvider
		{
			get {return EdStudSemesterExtProvider as SqlEdStudSemesterExtProvider;}
		}
		
		#endregion
		
		
		#region "EdStudQualProvider"
			
		private SqlEdStudQualProvider innerSqlEdStudQualProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudQual"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudQualProviderBase EdStudQualProvider
		{
			get
			{
				if (innerSqlEdStudQualProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudQualProvider == null)
						{
							this.innerSqlEdStudQualProvider = new SqlEdStudQualProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudQualProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudQualProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudQualProvider SqlEdStudQualProvider
		{
			get {return EdStudQualProvider as SqlEdStudQualProvider;}
		}
		
		#endregion
		
		
		#region "EdStudSemesterTempProvider"
			
		private SqlEdStudSemesterTempProvider innerSqlEdStudSemesterTempProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudSemesterTemp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudSemesterTempProviderBase EdStudSemesterTempProvider
		{
			get
			{
				if (innerSqlEdStudSemesterTempProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudSemesterTempProvider == null)
						{
							this.innerSqlEdStudSemesterTempProvider = new SqlEdStudSemesterTempProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudSemesterTempProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudSemesterTempProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudSemesterTempProvider SqlEdStudSemesterTempProvider
		{
			get {return EdStudSemesterTempProvider as SqlEdStudSemesterTempProvider;}
		}
		
		#endregion
		
		
		#region "EdStudViolAppealProvider"
			
		private SqlEdStudViolAppealProvider innerSqlEdStudViolAppealProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudViolAppeal"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudViolAppealProviderBase EdStudViolAppealProvider
		{
			get
			{
				if (innerSqlEdStudViolAppealProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudViolAppealProvider == null)
						{
							this.innerSqlEdStudViolAppealProvider = new SqlEdStudViolAppealProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudViolAppealProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudViolAppealProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudViolAppealProvider SqlEdStudViolAppealProvider
		{
			get {return EdStudViolAppealProvider as SqlEdStudViolAppealProvider;}
		}
		
		#endregion
		
		
		#region "EdTopicTchngProvider"
			
		private SqlEdTopicTchngProvider innerSqlEdTopicTchngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdTopicTchng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdTopicTchngProviderBase EdTopicTchngProvider
		{
			get
			{
				if (innerSqlEdTopicTchngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdTopicTchngProvider == null)
						{
							this.innerSqlEdTopicTchngProvider = new SqlEdTopicTchngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdTopicTchngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdTopicTchngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdTopicTchngProvider SqlEdTopicTchngProvider
		{
			get {return EdTopicTchngProvider as SqlEdTopicTchngProvider;}
		}
		
		#endregion
		
		
		#region "EntCodeIntroMetadataProvider"
			
		private SqlEntCodeIntroMetadataProvider innerSqlEntCodeIntroMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodeIntroMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodeIntroMetadataProviderBase EntCodeIntroMetadataProvider
		{
			get
			{
				if (innerSqlEntCodeIntroMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodeIntroMetadataProvider == null)
						{
							this.innerSqlEntCodeIntroMetadataProvider = new SqlEntCodeIntroMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodeIntroMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodeIntroMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodeIntroMetadataProvider SqlEntCodeIntroMetadataProvider
		{
			get {return EntCodeIntroMetadataProvider as SqlEntCodeIntroMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntCodePolicyCatProvider"
			
		private SqlEntCodePolicyCatProvider innerSqlEntCodePolicyCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodePolicyCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodePolicyCatProviderBase EntCodePolicyCatProvider
		{
			get
			{
				if (innerSqlEntCodePolicyCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodePolicyCatProvider == null)
						{
							this.innerSqlEntCodePolicyCatProvider = new SqlEntCodePolicyCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodePolicyCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodePolicyCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodePolicyCatProvider SqlEntCodePolicyCatProvider
		{
			get {return EntCodePolicyCatProvider as SqlEntCodePolicyCatProvider;}
		}
		
		#endregion
		
		
		#region "EntCodePolicyMetadataProvider"
			
		private SqlEntCodePolicyMetadataProvider innerSqlEntCodePolicyMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodePolicyMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodePolicyMetadataProviderBase EntCodePolicyMetadataProvider
		{
			get
			{
				if (innerSqlEntCodePolicyMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodePolicyMetadataProvider == null)
						{
							this.innerSqlEntCodePolicyMetadataProvider = new SqlEntCodePolicyMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodePolicyMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodePolicyMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodePolicyMetadataProvider SqlEntCodePolicyMetadataProvider
		{
			get {return EntCodePolicyMetadataProvider as SqlEntCodePolicyMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntCourseMdDataProvider"
			
		private SqlEntCourseMdDataProvider innerSqlEntCourseMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCourseMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCourseMdDataProviderBase EntCourseMdDataProvider
		{
			get
			{
				if (innerSqlEntCourseMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCourseMdDataProvider == null)
						{
							this.innerSqlEntCourseMdDataProvider = new SqlEntCourseMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCourseMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCourseMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCourseMdDataProvider SqlEntCourseMdDataProvider
		{
			get {return EntCourseMdDataProvider as SqlEntCourseMdDataProvider;}
		}
		
		#endregion
		
		
		#region "EntCodeGradingMetadataProvider"
			
		private SqlEntCodeGradingMetadataProvider innerSqlEntCodeGradingMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCodeGradingMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCodeGradingMetadataProviderBase EntCodeGradingMetadataProvider
		{
			get
			{
				if (innerSqlEntCodeGradingMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCodeGradingMetadataProvider == null)
						{
							this.innerSqlEntCodeGradingMetadataProvider = new SqlEntCodeGradingMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCodeGradingMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCodeGradingMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCodeGradingMetadataProvider SqlEntCodeGradingMetadataProvider
		{
			get {return EntCodeGradingMetadataProvider as SqlEntCodeGradingMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EdTrainingProvider"
			
		private SqlEdTrainingProvider innerSqlEdTrainingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdTraining"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdTrainingProviderBase EdTrainingProvider
		{
			get
			{
				if (innerSqlEdTrainingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdTrainingProvider == null)
						{
							this.innerSqlEdTrainingProvider = new SqlEdTrainingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdTrainingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdTrainingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdTrainingProvider SqlEdTrainingProvider
		{
			get {return EdTrainingProvider as SqlEdTrainingProvider;}
		}
		
		#endregion
		
		
		#region "EntCdePkgTypeProvider"
			
		private SqlEntCdePkgTypeProvider innerSqlEntCdePkgTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntCdePkgType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntCdePkgTypeProviderBase EntCdePkgTypeProvider
		{
			get
			{
				if (innerSqlEntCdePkgTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntCdePkgTypeProvider == null)
						{
							this.innerSqlEntCdePkgTypeProvider = new SqlEntCdePkgTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntCdePkgTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntCdePkgTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntCdePkgTypeProvider SqlEntCdePkgTypeProvider
		{
			get {return EntCdePkgTypeProvider as SqlEntCdePkgTypeProvider;}
		}
		
		#endregion
		
		
		#region "EdTrainStudProvider"
			
		private SqlEdTrainStudProvider innerSqlEdTrainStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdTrainStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdTrainStudProviderBase EdTrainStudProvider
		{
			get
			{
				if (innerSqlEdTrainStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdTrainStudProvider == null)
						{
							this.innerSqlEdTrainStudProvider = new SqlEdTrainStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdTrainStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdTrainStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdTrainStudProvider SqlEdTrainStudProvider
		{
			get {return EdTrainStudProvider as SqlEdTrainStudProvider;}
		}
		
		#endregion
		
		
		#region "EntAvailPrntTypeProvider"
			
		private SqlEntAvailPrntTypeProvider innerSqlEntAvailPrntTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntAvailPrntType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntAvailPrntTypeProviderBase EntAvailPrntTypeProvider
		{
			get
			{
				if (innerSqlEntAvailPrntTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntAvailPrntTypeProvider == null)
						{
							this.innerSqlEntAvailPrntTypeProvider = new SqlEntAvailPrntTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntAvailPrntTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntAvailPrntTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntAvailPrntTypeProvider SqlEntAvailPrntTypeProvider
		{
			get {return EntAvailPrntTypeProvider as SqlEntAvailPrntTypeProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAssessGrpHdrProvider"
			
		private SqlEntPolicyAssessGrpHdrProvider innerSqlEntPolicyAssessGrpHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAssessGrpHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAssessGrpHdrProviderBase EntPolicyAssessGrpHdrProvider
		{
			get
			{
				if (innerSqlEntPolicyAssessGrpHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAssessGrpHdrProvider == null)
						{
							this.innerSqlEntPolicyAssessGrpHdrProvider = new SqlEntPolicyAssessGrpHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAssessGrpHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAssessGrpHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAssessGrpHdrProvider SqlEntPolicyAssessGrpHdrProvider
		{
			get {return EntPolicyAssessGrpHdrProvider as SqlEntPolicyAssessGrpHdrProvider;}
		}
		
		#endregion
		
		
		#region "EdTrainSupervisorProvider"
			
		private SqlEdTrainSupervisorProvider innerSqlEdTrainSupervisorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdTrainSupervisor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdTrainSupervisorProviderBase EdTrainSupervisorProvider
		{
			get
			{
				if (innerSqlEdTrainSupervisorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdTrainSupervisorProvider == null)
						{
							this.innerSqlEdTrainSupervisorProvider = new SqlEdTrainSupervisorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdTrainSupervisorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdTrainSupervisorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdTrainSupervisorProvider SqlEdTrainSupervisorProvider
		{
			get {return EdTrainSupervisorProvider as SqlEdTrainSupervisorProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyAssessHdrProvider"
			
		private SqlEntPolicyAssessHdrProvider innerSqlEntPolicyAssessHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyAssessHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyAssessHdrProviderBase EntPolicyAssessHdrProvider
		{
			get
			{
				if (innerSqlEntPolicyAssessHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyAssessHdrProvider == null)
						{
							this.innerSqlEntPolicyAssessHdrProvider = new SqlEntPolicyAssessHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyAssessHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyAssessHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyAssessHdrProvider SqlEntPolicyAssessHdrProvider
		{
			get {return EntPolicyAssessHdrProvider as SqlEntPolicyAssessHdrProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyCourseChngProvider"
			
		private SqlEntPolicyCourseChngProvider innerSqlEntPolicyCourseChngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyCourseChng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyCourseChngProviderBase EntPolicyCourseChngProvider
		{
			get
			{
				if (innerSqlEntPolicyCourseChngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyCourseChngProvider == null)
						{
							this.innerSqlEntPolicyCourseChngProvider = new SqlEntPolicyCourseChngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyCourseChngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyCourseChngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyCourseChngProvider SqlEntPolicyCourseChngProvider
		{
			get {return EntPolicyCourseChngProvider as SqlEntPolicyCourseChngProvider;}
		}
		
		#endregion
		
		
		#region "FeeFacultyRuleProvider"
			
		private SqlFeeFacultyRuleProvider innerSqlFeeFacultyRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFacultyRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFacultyRuleProviderBase FeeFacultyRuleProvider
		{
			get
			{
				if (innerSqlFeeFacultyRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFacultyRuleProvider == null)
						{
							this.innerSqlFeeFacultyRuleProvider = new SqlFeeFacultyRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFacultyRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFacultyRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFacultyRuleProvider SqlFeeFacultyRuleProvider
		{
			get {return FeeFacultyRuleProvider as SqlFeeFacultyRuleProvider;}
		}
		
		#endregion
		
		
		#region "FeeFacultyItemProvider"
			
		private SqlFeeFacultyItemProvider innerSqlFeeFacultyItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFacultyItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFacultyItemProviderBase FeeFacultyItemProvider
		{
			get
			{
				if (innerSqlFeeFacultyItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFacultyItemProvider == null)
						{
							this.innerSqlFeeFacultyItemProvider = new SqlFeeFacultyItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFacultyItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFacultyItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFacultyItemProvider SqlFeeFacultyItemProvider
		{
			get {return FeeFacultyItemProvider as SqlFeeFacultyItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeCodeBanksProvider"
			
		private SqlFeeCodeBanksProvider innerSqlFeeCodeBanksProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCodeBanks"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCodeBanksProviderBase FeeCodeBanksProvider
		{
			get
			{
				if (innerSqlFeeCodeBanksProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCodeBanksProvider == null)
						{
							this.innerSqlFeeCodeBanksProvider = new SqlFeeCodeBanksProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCodeBanksProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCodeBanksProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCodeBanksProvider SqlFeeCodeBanksProvider
		{
			get {return FeeCodeBanksProvider as SqlFeeCodeBanksProvider;}
		}
		
		#endregion
		
		
		#region "FeeCodeItemProvider"
			
		private SqlFeeCodeItemProvider innerSqlFeeCodeItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCodeItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCodeItemProviderBase FeeCodeItemProvider
		{
			get
			{
				if (innerSqlFeeCodeItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCodeItemProvider == null)
						{
							this.innerSqlFeeCodeItemProvider = new SqlFeeCodeItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCodeItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCodeItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCodeItemProvider SqlFeeCodeItemProvider
		{
			get {return FeeCodeItemProvider as SqlFeeCodeItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeCodeReasonsProvider"
			
		private SqlFeeCodeReasonsProvider innerSqlFeeCodeReasonsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCodeReasons"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCodeReasonsProviderBase FeeCodeReasonsProvider
		{
			get
			{
				if (innerSqlFeeCodeReasonsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCodeReasonsProvider == null)
						{
							this.innerSqlFeeCodeReasonsProvider = new SqlFeeCodeReasonsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCodeReasonsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCodeReasonsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCodeReasonsProvider SqlFeeCodeReasonsProvider
		{
			get {return FeeCodeReasonsProvider as SqlFeeCodeReasonsProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeTrsryProvider"
			
		private SqlFeeCdeTrsryProvider innerSqlFeeCdeTrsryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeTrsry"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeTrsryProviderBase FeeCdeTrsryProvider
		{
			get
			{
				if (innerSqlFeeCdeTrsryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeTrsryProvider == null)
						{
							this.innerSqlFeeCdeTrsryProvider = new SqlFeeCdeTrsryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeTrsryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeTrsryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeTrsryProvider SqlFeeCdeTrsryProvider
		{
			get {return FeeCdeTrsryProvider as SqlFeeCdeTrsryProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeTrnsProvider"
			
		private SqlFeeCdeTrnsProvider innerSqlFeeCdeTrnsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeTrns"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeTrnsProviderBase FeeCdeTrnsProvider
		{
			get
			{
				if (innerSqlFeeCdeTrnsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeTrnsProvider == null)
						{
							this.innerSqlFeeCdeTrnsProvider = new SqlFeeCdeTrnsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeTrnsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeTrnsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeTrnsProvider SqlFeeCdeTrnsProvider
		{
			get {return FeeCdeTrnsProvider as SqlFeeCdeTrnsProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeFundProvider"
			
		private SqlFeeCdeFundProvider innerSqlFeeCdeFundProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeFund"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeFundProviderBase FeeCdeFundProvider
		{
			get
			{
				if (innerSqlFeeCdeFundProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeFundProvider == null)
						{
							this.innerSqlFeeCdeFundProvider = new SqlFeeCdeFundProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeFundProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeFundProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeFundProvider SqlFeeCdeFundProvider
		{
			get {return FeeCdeFundProvider as SqlFeeCdeFundProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeInvocStatusProvider"
			
		private SqlFeeCdeInvocStatusProvider innerSqlFeeCdeInvocStatusProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeInvocStatus"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeInvocStatusProviderBase FeeCdeInvocStatusProvider
		{
			get
			{
				if (innerSqlFeeCdeInvocStatusProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeInvocStatusProvider == null)
						{
							this.innerSqlFeeCdeInvocStatusProvider = new SqlFeeCdeInvocStatusProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeInvocStatusProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeInvocStatusProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeInvocStatusProvider SqlFeeCdeInvocStatusProvider
		{
			get {return FeeCdeInvocStatusProvider as SqlFeeCdeInvocStatusProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeLimitTypeProvider"
			
		private SqlFeeCdeLimitTypeProvider innerSqlFeeCdeLimitTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeLimitType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeLimitTypeProviderBase FeeCdeLimitTypeProvider
		{
			get
			{
				if (innerSqlFeeCdeLimitTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeLimitTypeProvider == null)
						{
							this.innerSqlFeeCdeLimitTypeProvider = new SqlFeeCdeLimitTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeLimitTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeLimitTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeLimitTypeProvider SqlFeeCdeLimitTypeProvider
		{
			get {return FeeCdeLimitTypeProvider as SqlFeeCdeLimitTypeProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeSchshipCatProvider"
			
		private SqlFeeCdeSchshipCatProvider innerSqlFeeCdeSchshipCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeSchshipCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeSchshipCatProviderBase FeeCdeSchshipCatProvider
		{
			get
			{
				if (innerSqlFeeCdeSchshipCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeSchshipCatProvider == null)
						{
							this.innerSqlFeeCdeSchshipCatProvider = new SqlFeeCdeSchshipCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeSchshipCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeSchshipCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeSchshipCatProvider SqlFeeCdeSchshipCatProvider
		{
			get {return FeeCdeSchshipCatProvider as SqlFeeCdeSchshipCatProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeSchshipTypeProvider"
			
		private SqlFeeCdeSchshipTypeProvider innerSqlFeeCdeSchshipTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeSchshipType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeSchshipTypeProviderBase FeeCdeSchshipTypeProvider
		{
			get
			{
				if (innerSqlFeeCdeSchshipTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeSchshipTypeProvider == null)
						{
							this.innerSqlFeeCdeSchshipTypeProvider = new SqlFeeCdeSchshipTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeSchshipTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeSchshipTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeSchshipTypeProvider SqlFeeCdeSchshipTypeProvider
		{
			get {return FeeCdeSchshipTypeProvider as SqlFeeCdeSchshipTypeProvider;}
		}
		
		#endregion
		
		
		#region "FeeCodeTypeProvider"
			
		private SqlFeeCodeTypeProvider innerSqlFeeCodeTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCodeType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCodeTypeProviderBase FeeCodeTypeProvider
		{
			get
			{
				if (innerSqlFeeCodeTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCodeTypeProvider == null)
						{
							this.innerSqlFeeCodeTypeProvider = new SqlFeeCodeTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCodeTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCodeTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCodeTypeProvider SqlFeeCodeTypeProvider
		{
			get {return FeeCodeTypeProvider as SqlFeeCodeTypeProvider;}
		}
		
		#endregion
		
		
		#region "FeeInstlmntRuleProvider"
			
		private SqlFeeInstlmntRuleProvider innerSqlFeeInstlmntRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeInstlmntRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeInstlmntRuleProviderBase FeeInstlmntRuleProvider
		{
			get
			{
				if (innerSqlFeeInstlmntRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeInstlmntRuleProvider == null)
						{
							this.innerSqlFeeInstlmntRuleProvider = new SqlFeeInstlmntRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeInstlmntRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeInstlmntRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeInstlmntRuleProvider SqlFeeInstlmntRuleProvider
		{
			get {return FeeInstlmntRuleProvider as SqlFeeInstlmntRuleProvider;}
		}
		
		#endregion
		
		
		#region "FeeCourseExpProvider"
			
		private SqlFeeCourseExpProvider innerSqlFeeCourseExpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCourseExp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCourseExpProviderBase FeeCourseExpProvider
		{
			get
			{
				if (innerSqlFeeCourseExpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCourseExpProvider == null)
						{
							this.innerSqlFeeCourseExpProvider = new SqlFeeCourseExpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCourseExpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCourseExpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCourseExpProvider SqlFeeCourseExpProvider
		{
			get {return FeeCourseExpProvider as SqlFeeCourseExpProvider;}
		}
		
		#endregion
		
		
		#region "FeeInstlmntStudProvider"
			
		private SqlFeeInstlmntStudProvider innerSqlFeeInstlmntStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeInstlmntStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeInstlmntStudProviderBase FeeInstlmntStudProvider
		{
			get
			{
				if (innerSqlFeeInstlmntStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeInstlmntStudProvider == null)
						{
							this.innerSqlFeeInstlmntStudProvider = new SqlFeeInstlmntStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeInstlmntStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeInstlmntStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeInstlmntStudProvider SqlFeeInstlmntStudProvider
		{
			get {return FeeInstlmntStudProvider as SqlFeeInstlmntStudProvider;}
		}
		
		#endregion
		
		
		#region "FeeInstlmntDtlProvider"
			
		private SqlFeeInstlmntDtlProvider innerSqlFeeInstlmntDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeInstlmntDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeInstlmntDtlProviderBase FeeInstlmntDtlProvider
		{
			get
			{
				if (innerSqlFeeInstlmntDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeInstlmntDtlProvider == null)
						{
							this.innerSqlFeeInstlmntDtlProvider = new SqlFeeInstlmntDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeInstlmntDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeInstlmntDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeInstlmntDtlProvider SqlFeeInstlmntDtlProvider
		{
			get {return FeeInstlmntDtlProvider as SqlFeeInstlmntDtlProvider;}
		}
		
		#endregion
		
		
		#region "FeeIntegrationLedgerProvider"
			
		private SqlFeeIntegrationLedgerProvider innerSqlFeeIntegrationLedgerProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeIntegrationLedger"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeIntegrationLedgerProviderBase FeeIntegrationLedgerProvider
		{
			get
			{
				if (innerSqlFeeIntegrationLedgerProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeIntegrationLedgerProvider == null)
						{
							this.innerSqlFeeIntegrationLedgerProvider = new SqlFeeIntegrationLedgerProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeIntegrationLedgerProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeIntegrationLedgerProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeIntegrationLedgerProvider SqlFeeIntegrationLedgerProvider
		{
			get {return FeeIntegrationLedgerProvider as SqlFeeIntegrationLedgerProvider;}
		}
		
		#endregion
		
		
		#region "FeeFundRuleProvider"
			
		private SqlFeeFundRuleProvider innerSqlFeeFundRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFundRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFundRuleProviderBase FeeFundRuleProvider
		{
			get
			{
				if (innerSqlFeeFundRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFundRuleProvider == null)
						{
							this.innerSqlFeeFundRuleProvider = new SqlFeeFundRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFundRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFundRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFundRuleProvider SqlFeeFundRuleProvider
		{
			get {return FeeFundRuleProvider as SqlFeeFundRuleProvider;}
		}
		
		#endregion
		
		
		#region "FeeFacItemAdmYearProvider"
			
		private SqlFeeFacItemAdmYearProvider innerSqlFeeFacItemAdmYearProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFacItemAdmYear"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFacItemAdmYearProviderBase FeeFacItemAdmYearProvider
		{
			get
			{
				if (innerSqlFeeFacItemAdmYearProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFacItemAdmYearProvider == null)
						{
							this.innerSqlFeeFacItemAdmYearProvider = new SqlFeeFacItemAdmYearProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFacItemAdmYearProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFacItemAdmYearProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFacItemAdmYearProvider SqlFeeFacItemAdmYearProvider
		{
			get {return FeeFacItemAdmYearProvider as SqlFeeFacItemAdmYearProvider;}
		}
		
		#endregion
		
		
		#region "FeeFineDtlProvider"
			
		private SqlFeeFineDtlProvider innerSqlFeeFineDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFineDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFineDtlProviderBase FeeFineDtlProvider
		{
			get
			{
				if (innerSqlFeeFineDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFineDtlProvider == null)
						{
							this.innerSqlFeeFineDtlProvider = new SqlFeeFineDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFineDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFineDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFineDtlProvider SqlFeeFineDtlProvider
		{
			get {return FeeFineDtlProvider as SqlFeeFineDtlProvider;}
		}
		
		#endregion
		
		
		#region "FeeFacultyInstallmentProvider"
			
		private SqlFeeFacultyInstallmentProvider innerSqlFeeFacultyInstallmentProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFacultyInstallment"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFacultyInstallmentProviderBase FeeFacultyInstallmentProvider
		{
			get
			{
				if (innerSqlFeeFacultyInstallmentProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFacultyInstallmentProvider == null)
						{
							this.innerSqlFeeFacultyInstallmentProvider = new SqlFeeFacultyInstallmentProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFacultyInstallmentProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFacultyInstallmentProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFacultyInstallmentProvider SqlFeeFacultyInstallmentProvider
		{
			get {return FeeFacultyInstallmentProvider as SqlFeeFacultyInstallmentProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeDiscCatProvider"
			
		private SqlFeeCdeDiscCatProvider innerSqlFeeCdeDiscCatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeDiscCat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeDiscCatProviderBase FeeCdeDiscCatProvider
		{
			get
			{
				if (innerSqlFeeCdeDiscCatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeDiscCatProvider == null)
						{
							this.innerSqlFeeCdeDiscCatProvider = new SqlFeeCdeDiscCatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeDiscCatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeDiscCatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeDiscCatProvider SqlFeeCdeDiscCatProvider
		{
			get {return FeeCdeDiscCatProvider as SqlFeeCdeDiscCatProvider;}
		}
		
		#endregion
		
		
		#region "FeeFineProvider"
			
		private SqlFeeFineProvider innerSqlFeeFineProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeFine"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeFineProviderBase FeeFineProvider
		{
			get
			{
				if (innerSqlFeeFineProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeFineProvider == null)
						{
							this.innerSqlFeeFineProvider = new SqlFeeFineProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeFineProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeFineProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeFineProvider SqlFeeFineProvider
		{
			get {return FeeFineProvider as SqlFeeFineProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyLoadProvider"
			
		private SqlEntPolicyLoadProvider innerSqlEntPolicyLoadProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyLoad"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyLoadProviderBase EntPolicyLoadProvider
		{
			get
			{
				if (innerSqlEntPolicyLoadProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyLoadProvider == null)
						{
							this.innerSqlEntPolicyLoadProvider = new SqlEntPolicyLoadProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyLoadProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyLoadProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyLoadProvider SqlEntPolicyLoadProvider
		{
			get {return EntPolicyLoadProvider as SqlEntPolicyLoadProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeBondItemProvider"
			
		private SqlFeeCdeBondItemProvider innerSqlFeeCdeBondItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeBondItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeBondItemProviderBase FeeCdeBondItemProvider
		{
			get
			{
				if (innerSqlFeeCdeBondItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeBondItemProvider == null)
						{
							this.innerSqlFeeCdeBondItemProvider = new SqlFeeCdeBondItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeBondItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeBondItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeBondItemProvider SqlFeeCdeBondItemProvider
		{
			get {return FeeCdeBondItemProvider as SqlFeeCdeBondItemProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyMetadataProvider"
			
		private SqlEntPolicyMetadataProvider innerSqlEntPolicyMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyMetadataProviderBase EntPolicyMetadataProvider
		{
			get
			{
				if (innerSqlEntPolicyMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyMetadataProvider == null)
						{
							this.innerSqlEntPolicyMetadataProvider = new SqlEntPolicyMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyMetadataProvider SqlEntPolicyMetadataProvider
		{
			get {return EntPolicyMetadataProvider as SqlEntPolicyMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyMdDataProvider"
			
		private SqlEntPolicyMdDataProvider innerSqlEntPolicyMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyMdDataProviderBase EntPolicyMdDataProvider
		{
			get
			{
				if (innerSqlEntPolicyMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyMdDataProvider == null)
						{
							this.innerSqlEntPolicyMdDataProvider = new SqlEntPolicyMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyMdDataProvider SqlEntPolicyMdDataProvider
		{
			get {return EntPolicyMdDataProvider as SqlEntPolicyMdDataProvider;}
		}
		
		#endregion
		
		
		#region "EdStudProvider"
			
		private SqlEdStudProvider innerSqlEdStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudProviderBase EdStudProvider
		{
			get
			{
				if (innerSqlEdStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudProvider == null)
						{
							this.innerSqlEdStudProvider = new SqlEdStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudProvider SqlEdStudProvider
		{
			get {return EdStudProvider as SqlEdStudProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyGradingLevelProvider"
			
		private SqlEntPolicyGradingLevelProvider innerSqlEntPolicyGradingLevelProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyGradingLevel"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyGradingLevelProviderBase EntPolicyGradingLevelProvider
		{
			get
			{
				if (innerSqlEntPolicyGradingLevelProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyGradingLevelProvider == null)
						{
							this.innerSqlEntPolicyGradingLevelProvider = new SqlEntPolicyGradingLevelProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyGradingLevelProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyGradingLevelProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyGradingLevelProvider SqlEntPolicyGradingLevelProvider
		{
			get {return EntPolicyGradingLevelProvider as SqlEntPolicyGradingLevelProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyGradingHdrProvider"
			
		private SqlEntPolicyGradingHdrProvider innerSqlEntPolicyGradingHdrProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyGradingHdr"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyGradingHdrProviderBase EntPolicyGradingHdrProvider
		{
			get
			{
				if (innerSqlEntPolicyGradingHdrProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyGradingHdrProvider == null)
						{
							this.innerSqlEntPolicyGradingHdrProvider = new SqlEntPolicyGradingHdrProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyGradingHdrProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyGradingHdrProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyGradingHdrProvider SqlEntPolicyGradingHdrProvider
		{
			get {return EntPolicyGradingHdrProvider as SqlEntPolicyGradingHdrProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyExcuseProvider"
			
		private SqlEntPolicyExcuseProvider innerSqlEntPolicyExcuseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyExcuse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyExcuseProviderBase EntPolicyExcuseProvider
		{
			get
			{
				if (innerSqlEntPolicyExcuseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyExcuseProvider == null)
						{
							this.innerSqlEntPolicyExcuseProvider = new SqlEntPolicyExcuseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyExcuseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyExcuseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyExcuseProvider SqlEntPolicyExcuseProvider
		{
			get {return EntPolicyExcuseProvider as SqlEntPolicyExcuseProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyCourseRepeatProvider"
			
		private SqlEntPolicyCourseRepeatProvider innerSqlEntPolicyCourseRepeatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyCourseRepeat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyCourseRepeatProviderBase EntPolicyCourseRepeatProvider
		{
			get
			{
				if (innerSqlEntPolicyCourseRepeatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyCourseRepeatProvider == null)
						{
							this.innerSqlEntPolicyCourseRepeatProvider = new SqlEntPolicyCourseRepeatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyCourseRepeatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyCourseRepeatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyCourseRepeatProvider SqlEntPolicyCourseRepeatProvider
		{
			get {return EntPolicyCourseRepeatProvider as SqlEntPolicyCourseRepeatProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyGradingDtlProvider"
			
		private SqlEntPolicyGradingDtlProvider innerSqlEntPolicyGradingDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyGradingDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyGradingDtlProviderBase EntPolicyGradingDtlProvider
		{
			get
			{
				if (innerSqlEntPolicyGradingDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyGradingDtlProvider == null)
						{
							this.innerSqlEntPolicyGradingDtlProvider = new SqlEntPolicyGradingDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyGradingDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyGradingDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyGradingDtlProvider SqlEntPolicyGradingDtlProvider
		{
			get {return EntPolicyGradingDtlProvider as SqlEntPolicyGradingDtlProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyObservedProvider"
			
		private SqlEntPolicyObservedProvider innerSqlEntPolicyObservedProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyObserved"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyObservedProviderBase EntPolicyObservedProvider
		{
			get
			{
				if (innerSqlEntPolicyObservedProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyObservedProvider == null)
						{
							this.innerSqlEntPolicyObservedProvider = new SqlEntPolicyObservedProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyObservedProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyObservedProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyObservedProvider SqlEntPolicyObservedProvider
		{
			get {return EntPolicyObservedProvider as SqlEntPolicyObservedProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyGradingCourseProvider"
			
		private SqlEntPolicyGradingCourseProvider innerSqlEntPolicyGradingCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyGradingCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyGradingCourseProviderBase EntPolicyGradingCourseProvider
		{
			get
			{
				if (innerSqlEntPolicyGradingCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyGradingCourseProvider == null)
						{
							this.innerSqlEntPolicyGradingCourseProvider = new SqlEntPolicyGradingCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyGradingCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyGradingCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyGradingCourseProvider SqlEntPolicyGradingCourseProvider
		{
			get {return EntPolicyGradingCourseProvider as SqlEntPolicyGradingCourseProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicyGradingLevelCoursesProvider"
			
		private SqlEntPolicyGradingLevelCoursesProvider innerSqlEntPolicyGradingLevelCoursesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicyGradingLevelCourses"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicyGradingLevelCoursesProviderBase EntPolicyGradingLevelCoursesProvider
		{
			get
			{
				if (innerSqlEntPolicyGradingLevelCoursesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicyGradingLevelCoursesProvider == null)
						{
							this.innerSqlEntPolicyGradingLevelCoursesProvider = new SqlEntPolicyGradingLevelCoursesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicyGradingLevelCoursesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicyGradingLevelCoursesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicyGradingLevelCoursesProvider SqlEntPolicyGradingLevelCoursesProvider
		{
			get {return EntPolicyGradingLevelCoursesProvider as SqlEntPolicyGradingLevelCoursesProvider;}
		}
		
		#endregion
		
		
		#region "EntPolicySemHonorProvider"
			
		private SqlEntPolicySemHonorProvider innerSqlEntPolicySemHonorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPolicySemHonor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPolicySemHonorProviderBase EntPolicySemHonorProvider
		{
			get
			{
				if (innerSqlEntPolicySemHonorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPolicySemHonorProvider == null)
						{
							this.innerSqlEntPolicySemHonorProvider = new SqlEntPolicySemHonorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPolicySemHonorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPolicySemHonorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPolicySemHonorProvider SqlEntPolicySemHonorProvider
		{
			get {return EntPolicySemHonorProvider as SqlEntPolicySemHonorProvider;}
		}
		
		#endregion
		
		
		#region "FeeBusLineItemProvider"
			
		private SqlFeeBusLineItemProvider innerSqlFeeBusLineItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeBusLineItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeBusLineItemProviderBase FeeBusLineItemProvider
		{
			get
			{
				if (innerSqlFeeBusLineItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeBusLineItemProvider == null)
						{
							this.innerSqlFeeBusLineItemProvider = new SqlFeeBusLineItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeBusLineItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeBusLineItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeBusLineItemProvider SqlFeeBusLineItemProvider
		{
			get {return FeeBusLineItemProvider as SqlFeeBusLineItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeAllowanceProvider"
			
		private SqlFeeCdeAllowanceProvider innerSqlFeeCdeAllowanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeAllowance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeAllowanceProviderBase FeeCdeAllowanceProvider
		{
			get
			{
				if (innerSqlFeeCdeAllowanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeAllowanceProvider == null)
						{
							this.innerSqlFeeCdeAllowanceProvider = new SqlFeeCdeAllowanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeAllowanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeAllowanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeAllowanceProvider SqlFeeCdeAllowanceProvider
		{
			get {return FeeCdeAllowanceProvider as SqlFeeCdeAllowanceProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeBankAccntProvider"
			
		private SqlFeeCdeBankAccntProvider innerSqlFeeCdeBankAccntProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeBankAccnt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeBankAccntProviderBase FeeCdeBankAccntProvider
		{
			get
			{
				if (innerSqlFeeCdeBankAccntProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeBankAccntProvider == null)
						{
							this.innerSqlFeeCdeBankAccntProvider = new SqlFeeCdeBankAccntProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeBankAccntProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeBankAccntProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeBankAccntProvider SqlFeeCdeBankAccntProvider
		{
			get {return FeeCdeBankAccntProvider as SqlFeeCdeBankAccntProvider;}
		}
		
		#endregion
		
		
		#region "FeeCdeDiscTypeProvider"
			
		private SqlFeeCdeDiscTypeProvider innerSqlFeeCdeDiscTypeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeCdeDiscType"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeCdeDiscTypeProviderBase FeeCdeDiscTypeProvider
		{
			get
			{
				if (innerSqlFeeCdeDiscTypeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeCdeDiscTypeProvider == null)
						{
							this.innerSqlFeeCdeDiscTypeProvider = new SqlFeeCdeDiscTypeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeCdeDiscTypeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeCdeDiscTypeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeCdeDiscTypeProvider SqlFeeCdeDiscTypeProvider
		{
			get {return FeeCdeDiscTypeProvider as SqlFeeCdeDiscTypeProvider;}
		}
		
		#endregion
		
		
		#region "FeeAllowanceRuleProvider"
			
		private SqlFeeAllowanceRuleProvider innerSqlFeeAllowanceRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeAllowanceRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeAllowanceRuleProviderBase FeeAllowanceRuleProvider
		{
			get
			{
				if (innerSqlFeeAllowanceRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeAllowanceRuleProvider == null)
						{
							this.innerSqlFeeAllowanceRuleProvider = new SqlFeeAllowanceRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeAllowanceRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeAllowanceRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeAllowanceRuleProvider SqlFeeAllowanceRuleProvider
		{
			get {return FeeAllowanceRuleProvider as SqlFeeAllowanceRuleProvider;}
		}
		
		#endregion
		
		
		#region "FeeAccomItemProvider"
			
		private SqlFeeAccomItemProvider innerSqlFeeAccomItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeAccomItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeAccomItemProviderBase FeeAccomItemProvider
		{
			get
			{
				if (innerSqlFeeAccomItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeAccomItemProvider == null)
						{
							this.innerSqlFeeAccomItemProvider = new SqlFeeAccomItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeAccomItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeAccomItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeAccomItemProvider SqlFeeAccomItemProvider
		{
			get {return FeeAccomItemProvider as SqlFeeAccomItemProvider;}
		}
		
		#endregion
		
		
		#region "FeeAccntYearPeriodProvider"
			
		private SqlFeeAccntYearPeriodProvider innerSqlFeeAccntYearPeriodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeAccntYearPeriod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeAccntYearPeriodProviderBase FeeAccntYearPeriodProvider
		{
			get
			{
				if (innerSqlFeeAccntYearPeriodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeAccntYearPeriodProvider == null)
						{
							this.innerSqlFeeAccntYearPeriodProvider = new SqlFeeAccntYearPeriodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeAccntYearPeriodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeAccntYearPeriodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeAccntYearPeriodProvider SqlFeeAccntYearPeriodProvider
		{
			get {return FeeAccntYearPeriodProvider as SqlFeeAccntYearPeriodProvider;}
		}
		
		#endregion
		
		
		#region "EntPrecondMetadataProvider"
			
		private SqlEntPrecondMetadataProvider innerSqlEntPrecondMetadataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPrecondMetadata"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPrecondMetadataProviderBase EntPrecondMetadataProvider
		{
			get
			{
				if (innerSqlEntPrecondMetadataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPrecondMetadataProvider == null)
						{
							this.innerSqlEntPrecondMetadataProvider = new SqlEntPrecondMetadataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPrecondMetadataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPrecondMetadataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPrecondMetadataProvider SqlEntPrecondMetadataProvider
		{
			get {return EntPrecondMetadataProvider as SqlEntPrecondMetadataProvider;}
		}
		
		#endregion
		
		
		#region "EntPrecondMdDataProvider"
			
		private SqlEntPrecondMdDataProvider innerSqlEntPrecondMdDataProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EntPrecondMdData"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EntPrecondMdDataProviderBase EntPrecondMdDataProvider
		{
			get
			{
				if (innerSqlEntPrecondMdDataProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEntPrecondMdDataProvider == null)
						{
							this.innerSqlEntPrecondMdDataProvider = new SqlEntPrecondMdDataProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEntPrecondMdDataProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEntPrecondMdDataProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEntPrecondMdDataProvider SqlEntPrecondMdDataProvider
		{
			get {return EntPrecondMdDataProvider as SqlEntPrecondMdDataProvider;}
		}
		
		#endregion
		
		
		#region "ErpEmpProvider"
			
		private SqlErpEmpProvider innerSqlErpEmpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ErpEmp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ErpEmpProviderBase ErpEmpProvider
		{
			get
			{
				if (innerSqlErpEmpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlErpEmpProvider == null)
						{
							this.innerSqlErpEmpProvider = new SqlErpEmpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlErpEmpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlErpEmpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlErpEmpProvider SqlErpEmpProvider
		{
			get {return ErpEmpProvider as SqlErpEmpProvider;}
		}
		
		#endregion
		
		
		#region "FeeAccntYearProvider"
			
		private SqlFeeAccntYearProvider innerSqlFeeAccntYearProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="FeeAccntYear"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override FeeAccntYearProviderBase FeeAccntYearProvider
		{
			get
			{
				if (innerSqlFeeAccntYearProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlFeeAccntYearProvider == null)
						{
							this.innerSqlFeeAccntYearProvider = new SqlFeeAccntYearProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlFeeAccntYearProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlFeeAccntYearProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlFeeAccntYearProvider SqlFeeAccntYearProvider
		{
			get {return FeeAccntYearProvider as SqlFeeAccntYearProvider;}
		}
		
		#endregion
		
		
		#region "EdStudRsrvRegTimeProvider"
			
		private SqlEdStudRsrvRegTimeProvider innerSqlEdStudRsrvRegTimeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudRsrvRegTime"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudRsrvRegTimeProviderBase EdStudRsrvRegTimeProvider
		{
			get
			{
				if (innerSqlEdStudRsrvRegTimeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudRsrvRegTimeProvider == null)
						{
							this.innerSqlEdStudRsrvRegTimeProvider = new SqlEdStudRsrvRegTimeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudRsrvRegTimeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudRsrvRegTimeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudRsrvRegTimeProvider SqlEdStudRsrvRegTimeProvider
		{
			get {return EdStudRsrvRegTimeProvider as SqlEdStudRsrvRegTimeProvider;}
		}
		
		#endregion
		
		
		#region "EdSemAgendaTimeProvider"
			
		private SqlEdSemAgendaTimeProvider innerSqlEdSemAgendaTimeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdSemAgendaTime"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdSemAgendaTimeProviderBase EdSemAgendaTimeProvider
		{
			get
			{
				if (innerSqlEdSemAgendaTimeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdSemAgendaTimeProvider == null)
						{
							this.innerSqlEdSemAgendaTimeProvider = new SqlEdSemAgendaTimeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdSemAgendaTimeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdSemAgendaTimeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdSemAgendaTimeProvider SqlEdSemAgendaTimeProvider
		{
			get {return EdSemAgendaTimeProvider as SqlEdSemAgendaTimeProvider;}
		}
		
		#endregion
		
		
		#region "EdSemesterOpenProvider"
			
		private SqlEdSemesterOpenProvider innerSqlEdSemesterOpenProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdSemesterOpen"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdSemesterOpenProviderBase EdSemesterOpenProvider
		{
			get
			{
				if (innerSqlEdSemesterOpenProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdSemesterOpenProvider == null)
						{
							this.innerSqlEdSemesterOpenProvider = new SqlEdSemesterOpenProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdSemesterOpenProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdSemesterOpenProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdSemesterOpenProvider SqlEdSemesterOpenProvider
		{
			get {return EdSemesterOpenProvider as SqlEdSemesterOpenProvider;}
		}
		
		#endregion
		
		
		#region "EdSemesterAgendaProvider"
			
		private SqlEdSemesterAgendaProvider innerSqlEdSemesterAgendaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdSemesterAgenda"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdSemesterAgendaProviderBase EdSemesterAgendaProvider
		{
			get
			{
				if (innerSqlEdSemesterAgendaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdSemesterAgendaProvider == null)
						{
							this.innerSqlEdSemesterAgendaProvider = new SqlEdSemesterAgendaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdSemesterAgendaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdSemesterAgendaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdSemesterAgendaProvider SqlEdSemesterAgendaProvider
		{
			get {return EdSemesterAgendaProvider as SqlEdSemesterAgendaProvider;}
		}
		
		#endregion
		
		
		#region "EdStudRsdncyProvider"
			
		private SqlEdStudRsdncyProvider innerSqlEdStudRsdncyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudRsdncy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudRsdncyProviderBase EdStudRsdncyProvider
		{
			get
			{
				if (innerSqlEdStudRsdncyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudRsdncyProvider == null)
						{
							this.innerSqlEdStudRsdncyProvider = new SqlEdStudRsdncyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudRsdncyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudRsdncyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudRsdncyProvider SqlEdStudRsdncyProvider
		{
			get {return EdStudRsdncyProvider as SqlEdStudRsdncyProvider;}
		}
		
		#endregion
		
		
		#region "EdStaffCoursePrefProvider"
			
		private SqlEdStaffCoursePrefProvider innerSqlEdStaffCoursePrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStaffCoursePref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStaffCoursePrefProviderBase EdStaffCoursePrefProvider
		{
			get
			{
				if (innerSqlEdStaffCoursePrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStaffCoursePrefProvider == null)
						{
							this.innerSqlEdStaffCoursePrefProvider = new SqlEdStaffCoursePrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStaffCoursePrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStaffCoursePrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStaffCoursePrefProvider SqlEdStaffCoursePrefProvider
		{
			get {return EdStaffCoursePrefProvider as SqlEdStaffCoursePrefProvider;}
		}
		
		#endregion
		
		
		#region "EdSemAgendaFormProvider"
			
		private SqlEdSemAgendaFormProvider innerSqlEdSemAgendaFormProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdSemAgendaForm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdSemAgendaFormProviderBase EdSemAgendaFormProvider
		{
			get
			{
				if (innerSqlEdSemAgendaFormProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdSemAgendaFormProvider == null)
						{
							this.innerSqlEdSemAgendaFormProvider = new SqlEdSemAgendaFormProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdSemAgendaFormProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdSemAgendaFormProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdSemAgendaFormProvider SqlEdSemAgendaFormProvider
		{
			get {return EdSemAgendaFormProvider as SqlEdSemAgendaFormProvider;}
		}
		
		#endregion
		
		
		#region "EdSemAgendaDtlProvider"
			
		private SqlEdSemAgendaDtlProvider innerSqlEdSemAgendaDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdSemAgendaDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdSemAgendaDtlProviderBase EdSemAgendaDtlProvider
		{
			get
			{
				if (innerSqlEdSemAgendaDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdSemAgendaDtlProvider == null)
						{
							this.innerSqlEdSemAgendaDtlProvider = new SqlEdSemAgendaDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdSemAgendaDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdSemAgendaDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdSemAgendaDtlProvider SqlEdSemAgendaDtlProvider
		{
			get {return EdSemAgendaDtlProvider as SqlEdSemAgendaDtlProvider;}
		}
		
		#endregion
		
		
		#region "EdProjectProvider"
			
		private SqlEdProjectProvider innerSqlEdProjectProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdProject"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdProjectProviderBase EdProjectProvider
		{
			get
			{
				if (innerSqlEdProjectProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdProjectProvider == null)
						{
							this.innerSqlEdProjectProvider = new SqlEdProjectProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdProjectProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdProjectProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdProjectProvider SqlEdProjectProvider
		{
			get {return EdProjectProvider as SqlEdProjectProvider;}
		}
		
		#endregion
		
		
		#region "EdProjSupervisorProvider"
			
		private SqlEdProjSupervisorProvider innerSqlEdProjSupervisorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdProjSupervisor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdProjSupervisorProviderBase EdProjSupervisorProvider
		{
			get
			{
				if (innerSqlEdProjSupervisorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdProjSupervisorProvider == null)
						{
							this.innerSqlEdProjSupervisorProvider = new SqlEdProjSupervisorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdProjSupervisorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdProjSupervisorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdProjSupervisorProvider SqlEdProjSupervisorProvider
		{
			get {return EdProjSupervisorProvider as SqlEdProjSupervisorProvider;}
		}
		
		#endregion
		
		
		#region "EdResidencyStudProvider"
			
		private SqlEdResidencyStudProvider innerSqlEdResidencyStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdResidencyStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdResidencyStudProviderBase EdResidencyStudProvider
		{
			get
			{
				if (innerSqlEdResidencyStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdResidencyStudProvider == null)
						{
							this.innerSqlEdResidencyStudProvider = new SqlEdResidencyStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdResidencyStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdResidencyStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdResidencyStudProvider SqlEdResidencyStudProvider
		{
			get {return EdResidencyStudProvider as SqlEdResidencyStudProvider;}
		}
		
		#endregion
		
		
		#region "EdResultApproveProvider"
			
		private SqlEdResultApproveProvider innerSqlEdResultApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdResultApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdResultApproveProviderBase EdResultApproveProvider
		{
			get
			{
				if (innerSqlEdResultApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdResultApproveProvider == null)
						{
							this.innerSqlEdResultApproveProvider = new SqlEdResultApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdResultApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdResultApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdResultApproveProvider SqlEdResultApproveProvider
		{
			get {return EdResultApproveProvider as SqlEdResultApproveProvider;}
		}
		
		#endregion
		
		
		#region "EdStaffDayPrefProvider"
			
		private SqlEdStaffDayPrefProvider innerSqlEdStaffDayPrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStaffDayPref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStaffDayPrefProviderBase EdStaffDayPrefProvider
		{
			get
			{
				if (innerSqlEdStaffDayPrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStaffDayPrefProvider == null)
						{
							this.innerSqlEdStaffDayPrefProvider = new SqlEdStaffDayPrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStaffDayPrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStaffDayPrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStaffDayPrefProvider SqlEdStaffDayPrefProvider
		{
			get {return EdStaffDayPrefProvider as SqlEdStaffDayPrefProvider;}
		}
		
		#endregion
		
		
		#region "EdStdCrsExamProvider"
			
		private SqlEdStdCrsExamProvider innerSqlEdStdCrsExamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStdCrsExam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStdCrsExamProviderBase EdStdCrsExamProvider
		{
			get
			{
				if (innerSqlEdStdCrsExamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStdCrsExamProvider == null)
						{
							this.innerSqlEdStdCrsExamProvider = new SqlEdStdCrsExamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStdCrsExamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStdCrsExamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStdCrsExamProvider SqlEdStdCrsExamProvider
		{
			get {return EdStdCrsExamProvider as SqlEdStdCrsExamProvider;}
		}
		
		#endregion
		
		
		#region "EdStdCrsExamAssessProvider"
			
		private SqlEdStdCrsExamAssessProvider innerSqlEdStdCrsExamAssessProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStdCrsExamAssess"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStdCrsExamAssessProviderBase EdStdCrsExamAssessProvider
		{
			get
			{
				if (innerSqlEdStdCrsExamAssessProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStdCrsExamAssessProvider == null)
						{
							this.innerSqlEdStdCrsExamAssessProvider = new SqlEdStdCrsExamAssessProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStdCrsExamAssessProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStdCrsExamAssessProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStdCrsExamAssessProvider SqlEdStdCrsExamAssessProvider
		{
			get {return EdStdCrsExamAssessProvider as SqlEdStdCrsExamAssessProvider;}
		}
		
		#endregion
		
		
		#region "EdStudActvtyRegProvider"
			
		private SqlEdStudActvtyRegProvider innerSqlEdStudActvtyRegProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudActvtyReg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudActvtyRegProviderBase EdStudActvtyRegProvider
		{
			get
			{
				if (innerSqlEdStudActvtyRegProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudActvtyRegProvider == null)
						{
							this.innerSqlEdStudActvtyRegProvider = new SqlEdStudActvtyRegProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudActvtyRegProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudActvtyRegProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudActvtyRegProvider SqlEdStudActvtyRegProvider
		{
			get {return EdStudActvtyRegProvider as SqlEdStudActvtyRegProvider;}
		}
		
		#endregion
		
		
		#region "EdStudBranchPrefProvider"
			
		private SqlEdStudBranchPrefProvider innerSqlEdStudBranchPrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudBranchPref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudBranchPrefProviderBase EdStudBranchPrefProvider
		{
			get
			{
				if (innerSqlEdStudBranchPrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudBranchPrefProvider == null)
						{
							this.innerSqlEdStudBranchPrefProvider = new SqlEdStudBranchPrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudBranchPrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudBranchPrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudBranchPrefProvider SqlEdStudBranchPrefProvider
		{
			get {return EdStudBranchPrefProvider as SqlEdStudBranchPrefProvider;}
		}
		
		#endregion
		
		
		#region "EdStudBranchTempProvider"
			
		private SqlEdStudBranchTempProvider innerSqlEdStudBranchTempProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudBranchTemp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudBranchTempProviderBase EdStudBranchTempProvider
		{
			get
			{
				if (innerSqlEdStudBranchTempProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudBranchTempProvider == null)
						{
							this.innerSqlEdStudBranchTempProvider = new SqlEdStudBranchTempProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudBranchTempProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudBranchTempProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudBranchTempProvider SqlEdStudBranchTempProvider
		{
			get {return EdStudBranchTempProvider as SqlEdStudBranchTempProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCheatProvider"
			
		private SqlEdStudCheatProvider innerSqlEdStudCheatProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCheat"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCheatProviderBase EdStudCheatProvider
		{
			get
			{
				if (innerSqlEdStudCheatProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCheatProvider == null)
						{
							this.innerSqlEdStudCheatProvider = new SqlEdStudCheatProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCheatProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCheatProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCheatProvider SqlEdStudCheatProvider
		{
			get {return EdStudCheatProvider as SqlEdStudCheatProvider;}
		}
		
		#endregion
		
		
		#region "EdStudActivityProvider"
			
		private SqlEdStudActivityProvider innerSqlEdStudActivityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudActivity"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudActivityProviderBase EdStudActivityProvider
		{
			get
			{
				if (innerSqlEdStudActivityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudActivityProvider == null)
						{
							this.innerSqlEdStudActivityProvider = new SqlEdStudActivityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudActivityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudActivityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudActivityProvider SqlEdStudActivityProvider
		{
			get {return EdStudActivityProvider as SqlEdStudActivityProvider;}
		}
		
		#endregion
		
		
		#region "EdStudAcadmicAdvProvider"
			
		private SqlEdStudAcadmicAdvProvider innerSqlEdStudAcadmicAdvProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudAcadmicAdv"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudAcadmicAdvProviderBase EdStudAcadmicAdvProvider
		{
			get
			{
				if (innerSqlEdStudAcadmicAdvProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudAcadmicAdvProvider == null)
						{
							this.innerSqlEdStudAcadmicAdvProvider = new SqlEdStudAcadmicAdvProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudAcadmicAdvProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudAcadmicAdvProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudAcadmicAdvProvider SqlEdStudAcadmicAdvProvider
		{
			get {return EdStudAcadmicAdvProvider as SqlEdStudAcadmicAdvProvider;}
		}
		
		#endregion
		
		
		#region "EdStdExamSemesterProvider"
			
		private SqlEdStdExamSemesterProvider innerSqlEdStdExamSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStdExamSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStdExamSemesterProviderBase EdStdExamSemesterProvider
		{
			get
			{
				if (innerSqlEdStdExamSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStdExamSemesterProvider == null)
						{
							this.innerSqlEdStdExamSemesterProvider = new SqlEdStdExamSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStdExamSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStdExamSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStdExamSemesterProvider SqlEdStdExamSemesterProvider
		{
			get {return EdStdExamSemesterProvider as SqlEdStdExamSemesterProvider;}
		}
		
		#endregion
		
		
		#region "EdStudAbsFwProvider"
			
		private SqlEdStudAbsFwProvider innerSqlEdStudAbsFwProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudAbsFw"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudAbsFwProviderBase EdStudAbsFwProvider
		{
			get
			{
				if (innerSqlEdStudAbsFwProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudAbsFwProvider == null)
						{
							this.innerSqlEdStudAbsFwProvider = new SqlEdStudAbsFwProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudAbsFwProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudAbsFwProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudAbsFwProvider SqlEdStudAbsFwProvider
		{
			get {return EdStudAbsFwProvider as SqlEdStudAbsFwProvider;}
		}
		
		#endregion
		
		
		#region "EdStudAbsenceProvider"
			
		private SqlEdStudAbsenceProvider innerSqlEdStudAbsenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudAbsence"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudAbsenceProviderBase EdStudAbsenceProvider
		{
			get
			{
				if (innerSqlEdStudAbsenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudAbsenceProvider == null)
						{
							this.innerSqlEdStudAbsenceProvider = new SqlEdStudAbsenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudAbsenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudAbsenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudAbsenceProvider SqlEdStudAbsenceProvider
		{
			get {return EdStudAbsenceProvider as SqlEdStudAbsenceProvider;}
		}
		
		#endregion
		
		
		#region "EdStudAcadWarnProvider"
			
		private SqlEdStudAcadWarnProvider innerSqlEdStudAcadWarnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudAcadWarn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudAcadWarnProviderBase EdStudAcadWarnProvider
		{
			get
			{
				if (innerSqlEdStudAcadWarnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudAcadWarnProvider == null)
						{
							this.innerSqlEdStudAcadWarnProvider = new SqlEdStudAcadWarnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudAcadWarnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudAcadWarnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudAcadWarnProvider SqlEdStudAcadWarnProvider
		{
			get {return EdStudAcadWarnProvider as SqlEdStudAcadWarnProvider;}
		}
		
		#endregion
		
		
		#region "EdProjStudProvider"
			
		private SqlEdProjStudProvider innerSqlEdProjStudProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdProjStud"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdProjStudProviderBase EdProjStudProvider
		{
			get
			{
				if (innerSqlEdProjStudProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdProjStudProvider == null)
						{
							this.innerSqlEdProjStudProvider = new SqlEdProjStudProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdProjStudProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdProjStudProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdProjStudProvider SqlEdProjStudProvider
		{
			get {return EdProjStudProvider as SqlEdProjStudProvider;}
		}
		
		#endregion
		
		
		#region "EdPrintReqProvider"
			
		private SqlEdPrintReqProvider innerSqlEdPrintReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdPrintReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdPrintReqProviderBase EdPrintReqProvider
		{
			get
			{
				if (innerSqlEdPrintReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdPrintReqProvider == null)
						{
							this.innerSqlEdPrintReqProvider = new SqlEdPrintReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdPrintReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdPrintReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdPrintReqProvider SqlEdPrintReqProvider
		{
			get {return EdPrintReqProvider as SqlEdPrintReqProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseOutcomesTopicsProvider"
			
		private SqlEdCourseOutcomesTopicsProvider innerSqlEdCourseOutcomesTopicsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseOutcomesTopics"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseOutcomesTopicsProviderBase EdCourseOutcomesTopicsProvider
		{
			get
			{
				if (innerSqlEdCourseOutcomesTopicsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseOutcomesTopicsProvider == null)
						{
							this.innerSqlEdCourseOutcomesTopicsProvider = new SqlEdCourseOutcomesTopicsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseOutcomesTopicsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseOutcomesTopicsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseOutcomesTopicsProvider SqlEdCourseOutcomesTopicsProvider
		{
			get {return EdCourseOutcomesTopicsProvider as SqlEdCourseOutcomesTopicsProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseRltdProvider"
			
		private SqlEdCourseRltdProvider innerSqlEdCourseRltdProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseRltd"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseRltdProviderBase EdCourseRltdProvider
		{
			get
			{
				if (innerSqlEdCourseRltdProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseRltdProvider == null)
						{
							this.innerSqlEdCourseRltdProvider = new SqlEdCourseRltdProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseRltdProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseRltdProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseRltdProvider SqlEdCourseRltdProvider
		{
			get {return EdCourseRltdProvider as SqlEdCourseRltdProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseTchngProvider"
			
		private SqlEdCourseTchngProvider innerSqlEdCourseTchngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseTchng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseTchngProviderBase EdCourseTchngProvider
		{
			get
			{
				if (innerSqlEdCourseTchngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseTchngProvider == null)
						{
							this.innerSqlEdCourseTchngProvider = new SqlEdCourseTchngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseTchngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseTchngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseTchngProvider SqlEdCourseTchngProvider
		{
			get {return EdCourseTchngProvider as SqlEdCourseTchngProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseTopicProvider"
			
		private SqlEdCourseTopicProvider innerSqlEdCourseTopicProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseTopic"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseTopicProviderBase EdCourseTopicProvider
		{
			get
			{
				if (innerSqlEdCourseTopicProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseTopicProvider == null)
						{
							this.innerSqlEdCourseTopicProvider = new SqlEdCourseTopicProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseTopicProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseTopicProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseTopicProvider SqlEdCourseTopicProvider
		{
			get {return EdCourseTopicProvider as SqlEdCourseTopicProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseOutcomesDtlProvider"
			
		private SqlEdCourseOutcomesDtlProvider innerSqlEdCourseOutcomesDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseOutcomesDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseOutcomesDtlProviderBase EdCourseOutcomesDtlProvider
		{
			get
			{
				if (innerSqlEdCourseOutcomesDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseOutcomesDtlProvider == null)
						{
							this.innerSqlEdCourseOutcomesDtlProvider = new SqlEdCourseOutcomesDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseOutcomesDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseOutcomesDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseOutcomesDtlProvider SqlEdCourseOutcomesDtlProvider
		{
			get {return EdCourseOutcomesDtlProvider as SqlEdCourseOutcomesDtlProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseOrientProvider"
			
		private SqlEdCourseOrientProvider innerSqlEdCourseOrientProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseOrient"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseOrientProviderBase EdCourseOrientProvider
		{
			get
			{
				if (innerSqlEdCourseOrientProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseOrientProvider == null)
						{
							this.innerSqlEdCourseOrientProvider = new SqlEdCourseOrientProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseOrientProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseOrientProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseOrientProvider SqlEdCourseOrientProvider
		{
			get {return EdCourseOrientProvider as SqlEdCourseOrientProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseEquivProvider"
			
		private SqlEdCourseEquivProvider innerSqlEdCourseEquivProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseEquiv"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseEquivProviderBase EdCourseEquivProvider
		{
			get
			{
				if (innerSqlEdCourseEquivProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseEquivProvider == null)
						{
							this.innerSqlEdCourseEquivProvider = new SqlEdCourseEquivProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseEquivProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseEquivProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseEquivProvider SqlEdCourseEquivProvider
		{
			get {return EdCourseEquivProvider as SqlEdCourseEquivProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseExpDtlProvider"
			
		private SqlEdCourseExpDtlProvider innerSqlEdCourseExpDtlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseExpDtl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseExpDtlProviderBase EdCourseExpDtlProvider
		{
			get
			{
				if (innerSqlEdCourseExpDtlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseExpDtlProvider == null)
						{
							this.innerSqlEdCourseExpDtlProvider = new SqlEdCourseExpDtlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseExpDtlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseExpDtlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseExpDtlProvider SqlEdCourseExpDtlProvider
		{
			get {return EdCourseExpDtlProvider as SqlEdCourseExpDtlProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseInfoProvider"
			
		private SqlEdCourseInfoProvider innerSqlEdCourseInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseInfoProviderBase EdCourseInfoProvider
		{
			get
			{
				if (innerSqlEdCourseInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseInfoProvider == null)
						{
							this.innerSqlEdCourseInfoProvider = new SqlEdCourseInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseInfoProvider SqlEdCourseInfoProvider
		{
			get {return EdCourseInfoProvider as SqlEdCourseInfoProvider;}
		}
		
		#endregion
		
		
		#region "EdCourseInstanceProvider"
			
		private SqlEdCourseInstanceProvider innerSqlEdCourseInstanceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCourseInstance"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCourseInstanceProviderBase EdCourseInstanceProvider
		{
			get
			{
				if (innerSqlEdCourseInstanceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCourseInstanceProvider == null)
						{
							this.innerSqlEdCourseInstanceProvider = new SqlEdCourseInstanceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCourseInstanceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCourseInstanceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCourseInstanceProvider SqlEdCourseInstanceProvider
		{
			get {return EdCourseInstanceProvider as SqlEdCourseInstanceProvider;}
		}
		
		#endregion
		
		
		#region "EdCrsFreeRstrctdProvider"
			
		private SqlEdCrsFreeRstrctdProvider innerSqlEdCrsFreeRstrctdProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdCrsFreeRstrctd"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdCrsFreeRstrctdProviderBase EdCrsFreeRstrctdProvider
		{
			get
			{
				if (innerSqlEdCrsFreeRstrctdProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdCrsFreeRstrctdProvider == null)
						{
							this.innerSqlEdCrsFreeRstrctdProvider = new SqlEdCrsFreeRstrctdProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdCrsFreeRstrctdProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdCrsFreeRstrctdProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdCrsFreeRstrctdProvider SqlEdCrsFreeRstrctdProvider
		{
			get {return EdCrsFreeRstrctdProvider as SqlEdCrsFreeRstrctdProvider;}
		}
		
		#endregion
		
		
		#region "EdEmployeeQualProvider"
			
		private SqlEdEmployeeQualProvider innerSqlEdEmployeeQualProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdEmployeeQual"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdEmployeeQualProviderBase EdEmployeeQualProvider
		{
			get
			{
				if (innerSqlEdEmployeeQualProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdEmployeeQualProvider == null)
						{
							this.innerSqlEdEmployeeQualProvider = new SqlEdEmployeeQualProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdEmployeeQualProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdEmployeeQualProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdEmployeeQualProvider SqlEdEmployeeQualProvider
		{
			get {return EdEmployeeQualProvider as SqlEdEmployeeQualProvider;}
		}
		
		#endregion
		
		
		#region "EdExamCrsOrderProvider"
			
		private SqlEdExamCrsOrderProvider innerSqlEdExamCrsOrderProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdExamCrsOrder"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdExamCrsOrderProviderBase EdExamCrsOrderProvider
		{
			get
			{
				if (innerSqlEdExamCrsOrderProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdExamCrsOrderProvider == null)
						{
							this.innerSqlEdExamCrsOrderProvider = new SqlEdExamCrsOrderProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdExamCrsOrderProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdExamCrsOrderProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdExamCrsOrderProvider SqlEdExamCrsOrderProvider
		{
			get {return EdExamCrsOrderProvider as SqlEdExamCrsOrderProvider;}
		}
		
		#endregion
		
		
		#region "EdOfferingProvider"
			
		private SqlEdOfferingProvider innerSqlEdOfferingProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdOffering"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdOfferingProviderBase EdOfferingProvider
		{
			get
			{
				if (innerSqlEdOfferingProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdOfferingProvider == null)
						{
							this.innerSqlEdOfferingProvider = new SqlEdOfferingProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdOfferingProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdOfferingProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdOfferingProvider SqlEdOfferingProvider
		{
			get {return EdOfferingProvider as SqlEdOfferingProvider;}
		}
		
		#endregion
		
		
		#region "EdOfferingCourseProvider"
			
		private SqlEdOfferingCourseProvider innerSqlEdOfferingCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdOfferingCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdOfferingCourseProviderBase EdOfferingCourseProvider
		{
			get
			{
				if (innerSqlEdOfferingCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdOfferingCourseProvider == null)
						{
							this.innerSqlEdOfferingCourseProvider = new SqlEdOfferingCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdOfferingCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdOfferingCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdOfferingCourseProvider SqlEdOfferingCourseProvider
		{
			get {return EdOfferingCourseProvider as SqlEdOfferingCourseProvider;}
		}
		
		#endregion
		
		
		#region "EdOutcomeProvider"
			
		private SqlEdOutcomeProvider innerSqlEdOutcomeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdOutcome"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdOutcomeProviderBase EdOutcomeProvider
		{
			get
			{
				if (innerSqlEdOutcomeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdOutcomeProvider == null)
						{
							this.innerSqlEdOutcomeProvider = new SqlEdOutcomeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdOutcomeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdOutcomeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdOutcomeProvider SqlEdOutcomeProvider
		{
			get {return EdOutcomeProvider as SqlEdOutcomeProvider;}
		}
		
		#endregion
		
		
		#region "EdOutcomesTopicsProvider"
			
		private SqlEdOutcomesTopicsProvider innerSqlEdOutcomesTopicsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdOutcomesTopics"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdOutcomesTopicsProviderBase EdOutcomesTopicsProvider
		{
			get
			{
				if (innerSqlEdOutcomesTopicsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdOutcomesTopicsProvider == null)
						{
							this.innerSqlEdOutcomesTopicsProvider = new SqlEdOutcomesTopicsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdOutcomesTopicsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdOutcomesTopicsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdOutcomesTopicsProvider SqlEdOutcomesTopicsProvider
		{
			get {return EdOutcomesTopicsProvider as SqlEdOutcomesTopicsProvider;}
		}
		
		#endregion
		
		
		#region "EdInttransRuleProvider"
			
		private SqlEdInttransRuleProvider innerSqlEdInttransRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdInttransRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdInttransRuleProviderBase EdInttransRuleProvider
		{
			get
			{
				if (innerSqlEdInttransRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdInttransRuleProvider == null)
						{
							this.innerSqlEdInttransRuleProvider = new SqlEdInttransRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdInttransRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdInttransRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdInttransRuleProvider SqlEdInttransRuleProvider
		{
			get {return EdInttransRuleProvider as SqlEdInttransRuleProvider;}
		}
		
		#endregion
		
		
		#region "EdGuardProvider"
			
		private SqlEdGuardProvider innerSqlEdGuardProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdGuard"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdGuardProviderBase EdGuardProvider
		{
			get
			{
				if (innerSqlEdGuardProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdGuardProvider == null)
						{
							this.innerSqlEdGuardProvider = new SqlEdGuardProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdGuardProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdGuardProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdGuardProvider SqlEdGuardProvider
		{
			get {return EdGuardProvider as SqlEdGuardProvider;}
		}
		
		#endregion
		
		
		#region "EdExamSchdlProvider"
			
		private SqlEdExamSchdlProvider innerSqlEdExamSchdlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdExamSchdl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdExamSchdlProviderBase EdExamSchdlProvider
		{
			get
			{
				if (innerSqlEdExamSchdlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdExamSchdlProvider == null)
						{
							this.innerSqlEdExamSchdlProvider = new SqlEdExamSchdlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdExamSchdlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdExamSchdlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdExamSchdlProvider SqlEdExamSchdlProvider
		{
			get {return EdExamSchdlProvider as SqlEdExamSchdlProvider;}
		}
		
		#endregion
		
		
		#region "EdExamStudAbsenceProvider"
			
		private SqlEdExamStudAbsenceProvider innerSqlEdExamStudAbsenceProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdExamStudAbsence"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdExamStudAbsenceProviderBase EdExamStudAbsenceProvider
		{
			get
			{
				if (innerSqlEdExamStudAbsenceProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdExamStudAbsenceProvider == null)
						{
							this.innerSqlEdExamStudAbsenceProvider = new SqlEdExamStudAbsenceProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdExamStudAbsenceProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdExamStudAbsenceProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdExamStudAbsenceProvider SqlEdExamStudAbsenceProvider
		{
			get {return EdExamStudAbsenceProvider as SqlEdExamStudAbsenceProvider;}
		}
		
		#endregion
		
		
		#region "EdExamSuprvsorProvider"
			
		private SqlEdExamSuprvsorProvider innerSqlEdExamSuprvsorProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdExamSuprvsor"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdExamSuprvsorProviderBase EdExamSuprvsorProvider
		{
			get
			{
				if (innerSqlEdExamSuprvsorProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdExamSuprvsorProvider == null)
						{
							this.innerSqlEdExamSuprvsorProvider = new SqlEdExamSuprvsorProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdExamSuprvsorProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdExamSuprvsorProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdExamSuprvsorProvider SqlEdExamSuprvsorProvider
		{
			get {return EdExamSuprvsorProvider as SqlEdExamSuprvsorProvider;}
		}
		
		#endregion
		
		
		#region "EdGraduationAwardProvider"
			
		private SqlEdGraduationAwardProvider innerSqlEdGraduationAwardProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdGraduationAward"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdGraduationAwardProviderBase EdGraduationAwardProvider
		{
			get
			{
				if (innerSqlEdGraduationAwardProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdGraduationAwardProvider == null)
						{
							this.innerSqlEdGraduationAwardProvider = new SqlEdGraduationAwardProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdGraduationAwardProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdGraduationAwardProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdGraduationAwardProvider SqlEdGraduationAwardProvider
		{
			get {return EdGraduationAwardProvider as SqlEdGraduationAwardProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCheatExecProvider"
			
		private SqlEdStudCheatExecProvider innerSqlEdStudCheatExecProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCheatExec"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCheatExecProviderBase EdStudCheatExecProvider
		{
			get
			{
				if (innerSqlEdStudCheatExecProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCheatExecProvider == null)
						{
							this.innerSqlEdStudCheatExecProvider = new SqlEdStudCheatExecProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCheatExecProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCheatExecProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCheatExecProvider SqlEdStudCheatExecProvider
		{
			get {return EdStudCheatExecProvider as SqlEdStudCheatExecProvider;}
		}
		
		#endregion
		
		
		#region "EdStudClrncReqProvider"
			
		private SqlEdStudClrncReqProvider innerSqlEdStudClrncReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudClrncReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudClrncReqProviderBase EdStudClrncReqProvider
		{
			get
			{
				if (innerSqlEdStudClrncReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudClrncReqProvider == null)
						{
							this.innerSqlEdStudClrncReqProvider = new SqlEdStudClrncReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudClrncReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudClrncReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudClrncReqProvider SqlEdStudClrncReqProvider
		{
			get {return EdStudClrncReqProvider as SqlEdStudClrncReqProvider;}
		}
		
		#endregion
		
		
		#region "EdStudIntTrnsProvider"
			
		private SqlEdStudIntTrnsProvider innerSqlEdStudIntTrnsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudIntTrns"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudIntTrnsProviderBase EdStudIntTrnsProvider
		{
			get
			{
				if (innerSqlEdStudIntTrnsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudIntTrnsProvider == null)
						{
							this.innerSqlEdStudIntTrnsProvider = new SqlEdStudIntTrnsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudIntTrnsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudIntTrnsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudIntTrnsProvider SqlEdStudIntTrnsProvider
		{
			get {return EdStudIntTrnsProvider as SqlEdStudIntTrnsProvider;}
		}
		
		#endregion
		
		
		#region "EdStudClrncItemProvider"
			
		private SqlEdStudClrncItemProvider innerSqlEdStudClrncItemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudClrncItem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudClrncItemProviderBase EdStudClrncItemProvider
		{
			get
			{
				if (innerSqlEdStudClrncItemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudClrncItemProvider == null)
						{
							this.innerSqlEdStudClrncItemProvider = new SqlEdStudClrncItemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudClrncItemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudClrncItemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudClrncItemProvider SqlEdStudClrncItemProvider
		{
			get {return EdStudClrncItemProvider as SqlEdStudClrncItemProvider;}
		}
		
		#endregion
		
		
		#region "EdStudIntTrnsCourseFromProvider"
			
		private SqlEdStudIntTrnsCourseFromProvider innerSqlEdStudIntTrnsCourseFromProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudIntTrnsCourseFrom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudIntTrnsCourseFromProviderBase EdStudIntTrnsCourseFromProvider
		{
			get
			{
				if (innerSqlEdStudIntTrnsCourseFromProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudIntTrnsCourseFromProvider == null)
						{
							this.innerSqlEdStudIntTrnsCourseFromProvider = new SqlEdStudIntTrnsCourseFromProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudIntTrnsCourseFromProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudIntTrnsCourseFromProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudIntTrnsCourseFromProvider SqlEdStudIntTrnsCourseFromProvider
		{
			get {return EdStudIntTrnsCourseFromProvider as SqlEdStudIntTrnsCourseFromProvider;}
		}
		
		#endregion
		
		
		#region "EdStudIntTrnsCourseToProvider"
			
		private SqlEdStudIntTrnsCourseToProvider innerSqlEdStudIntTrnsCourseToProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudIntTrnsCourseTo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudIntTrnsCourseToProviderBase EdStudIntTrnsCourseToProvider
		{
			get
			{
				if (innerSqlEdStudIntTrnsCourseToProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudIntTrnsCourseToProvider == null)
						{
							this.innerSqlEdStudIntTrnsCourseToProvider = new SqlEdStudIntTrnsCourseToProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudIntTrnsCourseToProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudIntTrnsCourseToProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudIntTrnsCourseToProvider SqlEdStudIntTrnsCourseToProvider
		{
			get {return EdStudIntTrnsCourseToProvider as SqlEdStudIntTrnsCourseToProvider;}
		}
		
		#endregion
		
		
		#region "EdStudIntTrnsStateToProvider"
			
		private SqlEdStudIntTrnsStateToProvider innerSqlEdStudIntTrnsStateToProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudIntTrnsStateTo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudIntTrnsStateToProviderBase EdStudIntTrnsStateToProvider
		{
			get
			{
				if (innerSqlEdStudIntTrnsStateToProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudIntTrnsStateToProvider == null)
						{
							this.innerSqlEdStudIntTrnsStateToProvider = new SqlEdStudIntTrnsStateToProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudIntTrnsStateToProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudIntTrnsStateToProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudIntTrnsStateToProvider SqlEdStudIntTrnsStateToProvider
		{
			get {return EdStudIntTrnsStateToProvider as SqlEdStudIntTrnsStateToProvider;}
		}
		
		#endregion
		
		
		#region "EdStudIntTrnsStateFromProvider"
			
		private SqlEdStudIntTrnsStateFromProvider innerSqlEdStudIntTrnsStateFromProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudIntTrnsStateFrom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudIntTrnsStateFromProviderBase EdStudIntTrnsStateFromProvider
		{
			get
			{
				if (innerSqlEdStudIntTrnsStateFromProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudIntTrnsStateFromProvider == null)
						{
							this.innerSqlEdStudIntTrnsStateFromProvider = new SqlEdStudIntTrnsStateFromProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudIntTrnsStateFromProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudIntTrnsStateFromProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudIntTrnsStateFromProvider SqlEdStudIntTrnsStateFromProvider
		{
			get {return EdStudIntTrnsStateFromProvider as SqlEdStudIntTrnsStateFromProvider;}
		}
		
		#endregion
		
		
		#region "EdStudGuardProvider"
			
		private SqlEdStudGuardProvider innerSqlEdStudGuardProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudGuard"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudGuardProviderBase EdStudGuardProvider
		{
			get
			{
				if (innerSqlEdStudGuardProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudGuardProvider == null)
						{
							this.innerSqlEdStudGuardProvider = new SqlEdStudGuardProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudGuardProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudGuardProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudGuardProvider SqlEdStudGuardProvider
		{
			get {return EdStudGuardProvider as SqlEdStudGuardProvider;}
		}
		
		#endregion
		
		
		#region "EdStudGrantDegreeProvider"
			
		private SqlEdStudGrantDegreeProvider innerSqlEdStudGrantDegreeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudGrantDegree"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudGrantDegreeProviderBase EdStudGrantDegreeProvider
		{
			get
			{
				if (innerSqlEdStudGrantDegreeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudGrantDegreeProvider == null)
						{
							this.innerSqlEdStudGrantDegreeProvider = new SqlEdStudGrantDegreeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudGrantDegreeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudGrantDegreeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudGrantDegreeProvider SqlEdStudGrantDegreeProvider
		{
			get {return EdStudGrantDegreeProvider as SqlEdStudGrantDegreeProvider;}
		}
		
		#endregion
		
		
		#region "EdStudGrantTempProvider"
			
		private SqlEdStudGrantTempProvider innerSqlEdStudGrantTempProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudGrantTemp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudGrantTempProviderBase EdStudGrantTempProvider
		{
			get
			{
				if (innerSqlEdStudGrantTempProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudGrantTempProvider == null)
						{
							this.innerSqlEdStudGrantTempProvider = new SqlEdStudGrantTempProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudGrantTempProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudGrantTempProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudGrantTempProvider SqlEdStudGrantTempProvider
		{
			get {return EdStudGrantTempProvider as SqlEdStudGrantTempProvider;}
		}
		
		#endregion
		
		
		#region "EdStudGroupProvider"
			
		private SqlEdStudGroupProvider innerSqlEdStudGroupProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudGroup"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudGroupProviderBase EdStudGroupProvider
		{
			get
			{
				if (innerSqlEdStudGroupProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudGroupProvider == null)
						{
							this.innerSqlEdStudGroupProvider = new SqlEdStudGroupProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudGroupProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudGroupProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudGroupProvider SqlEdStudGroupProvider
		{
			get {return EdStudGroupProvider as SqlEdStudGroupProvider;}
		}
		
		#endregion
		
		
		#region "EdStudGroupPreProvider"
			
		private SqlEdStudGroupPreProvider innerSqlEdStudGroupPreProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudGroupPre"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudGroupPreProviderBase EdStudGroupPreProvider
		{
			get
			{
				if (innerSqlEdStudGroupPreProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudGroupPreProvider == null)
						{
							this.innerSqlEdStudGroupPreProvider = new SqlEdStudGroupPreProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudGroupPreProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudGroupPreProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudGroupPreProvider SqlEdStudGroupPreProvider
		{
			get {return EdStudGroupPreProvider as SqlEdStudGroupPreProvider;}
		}
		
		#endregion
		
		
		#region "EdStudIntTransPrefProvider"
			
		private SqlEdStudIntTransPrefProvider innerSqlEdStudIntTransPrefProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudIntTransPref"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudIntTransPrefProviderBase EdStudIntTransPrefProvider
		{
			get
			{
				if (innerSqlEdStudIntTransPrefProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudIntTransPrefProvider == null)
						{
							this.innerSqlEdStudIntTransPrefProvider = new SqlEdStudIntTransPrefProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudIntTransPrefProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudIntTransPrefProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudIntTransPrefProvider SqlEdStudIntTransPrefProvider
		{
			get {return EdStudIntTransPrefProvider as SqlEdStudIntTransPrefProvider;}
		}
		
		#endregion
		
		
		#region "EdStudInttransTempProvider"
			
		private SqlEdStudInttransTempProvider innerSqlEdStudInttransTempProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudInttransTemp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudInttransTempProviderBase EdStudInttransTempProvider
		{
			get
			{
				if (innerSqlEdStudInttransTempProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudInttransTempProvider == null)
						{
							this.innerSqlEdStudInttransTempProvider = new SqlEdStudInttransTempProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudInttransTempProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudInttransTempProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudInttransTempProvider SqlEdStudInttransTempProvider
		{
			get {return EdStudInttransTempProvider as SqlEdStudInttransTempProvider;}
		}
		
		#endregion
		
		
		#region "EdStudLangProvider"
			
		private SqlEdStudLangProvider innerSqlEdStudLangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudLang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudLangProviderBase EdStudLangProvider
		{
			get
			{
				if (innerSqlEdStudLangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudLangProvider == null)
						{
							this.innerSqlEdStudLangProvider = new SqlEdStudLangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudLangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudLangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudLangProvider SqlEdStudLangProvider
		{
			get {return EdStudLangProvider as SqlEdStudLangProvider;}
		}
		
		#endregion
		
		
		#region "EdStudPnltyCourseProvider"
			
		private SqlEdStudPnltyCourseProvider innerSqlEdStudPnltyCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudPnltyCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudPnltyCourseProviderBase EdStudPnltyCourseProvider
		{
			get
			{
				if (innerSqlEdStudPnltyCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudPnltyCourseProvider == null)
						{
							this.innerSqlEdStudPnltyCourseProvider = new SqlEdStudPnltyCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudPnltyCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudPnltyCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudPnltyCourseProvider SqlEdStudPnltyCourseProvider
		{
			get {return EdStudPnltyCourseProvider as SqlEdStudPnltyCourseProvider;}
		}
		
		#endregion
		
		
		#region "EdStudProblemProvider"
			
		private SqlEdStudProblemProvider innerSqlEdStudProblemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudProblem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudProblemProviderBase EdStudProblemProvider
		{
			get
			{
				if (innerSqlEdStudProblemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudProblemProvider == null)
						{
							this.innerSqlEdStudProblemProvider = new SqlEdStudProblemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudProblemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudProblemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudProblemProvider SqlEdStudProblemProvider
		{
			get {return EdStudProblemProvider as SqlEdStudProblemProvider;}
		}
		
		#endregion
		
		
		#region "EdStudQualGroupProvider"
			
		private SqlEdStudQualGroupProvider innerSqlEdStudQualGroupProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudQualGroup"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudQualGroupProviderBase EdStudQualGroupProvider
		{
			get
			{
				if (innerSqlEdStudQualGroupProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudQualGroupProvider == null)
						{
							this.innerSqlEdStudQualGroupProvider = new SqlEdStudQualGroupProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudQualGroupProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudQualGroupProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudQualGroupProvider SqlEdStudQualGroupProvider
		{
			get {return EdStudQualGroupProvider as SqlEdStudQualGroupProvider;}
		}
		
		#endregion
		
		
		#region "EdStudQualSubjectProvider"
			
		private SqlEdStudQualSubjectProvider innerSqlEdStudQualSubjectProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudQualSubject"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudQualSubjectProviderBase EdStudQualSubjectProvider
		{
			get
			{
				if (innerSqlEdStudQualSubjectProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudQualSubjectProvider == null)
						{
							this.innerSqlEdStudQualSubjectProvider = new SqlEdStudQualSubjectProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudQualSubjectProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudQualSubjectProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudQualSubjectProvider SqlEdStudQualSubjectProvider
		{
			get {return EdStudQualSubjectProvider as SqlEdStudQualSubjectProvider;}
		}
		
		#endregion
		
		
		#region "EdStudNoteProvider"
			
		private SqlEdStudNoteProvider innerSqlEdStudNoteProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudNote"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudNoteProviderBase EdStudNoteProvider
		{
			get
			{
				if (innerSqlEdStudNoteProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudNoteProvider == null)
						{
							this.innerSqlEdStudNoteProvider = new SqlEdStudNoteProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudNoteProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudNoteProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudNoteProvider SqlEdStudNoteProvider
		{
			get {return EdStudNoteProvider as SqlEdStudNoteProvider;}
		}
		
		#endregion
		
		
		#region "EdStudMltryCrsProvider"
			
		private SqlEdStudMltryCrsProvider innerSqlEdStudMltryCrsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudMltryCrs"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudMltryCrsProviderBase EdStudMltryCrsProvider
		{
			get
			{
				if (innerSqlEdStudMltryCrsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudMltryCrsProvider == null)
						{
							this.innerSqlEdStudMltryCrsProvider = new SqlEdStudMltryCrsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudMltryCrsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudMltryCrsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudMltryCrsProvider SqlEdStudMltryCrsProvider
		{
			get {return EdStudMltryCrsProvider as SqlEdStudMltryCrsProvider;}
		}
		
		#endregion
		
		
		#region "EdStudLatenessProvider"
			
		private SqlEdStudLatenessProvider innerSqlEdStudLatenessProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudLateness"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudLatenessProviderBase EdStudLatenessProvider
		{
			get
			{
				if (innerSqlEdStudLatenessProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudLatenessProvider == null)
						{
							this.innerSqlEdStudLatenessProvider = new SqlEdStudLatenessProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudLatenessProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudLatenessProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudLatenessProvider SqlEdStudLatenessProvider
		{
			get {return EdStudLatenessProvider as SqlEdStudLatenessProvider;}
		}
		
		#endregion
		
		
		#region "EdStudMilitaryInfoProvider"
			
		private SqlEdStudMilitaryInfoProvider innerSqlEdStudMilitaryInfoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudMilitaryInfo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudMilitaryInfoProviderBase EdStudMilitaryInfoProvider
		{
			get
			{
				if (innerSqlEdStudMilitaryInfoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudMilitaryInfoProvider == null)
						{
							this.innerSqlEdStudMilitaryInfoProvider = new SqlEdStudMilitaryInfoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudMilitaryInfoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudMilitaryInfoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudMilitaryInfoProvider SqlEdStudMilitaryInfoProvider
		{
			get {return EdStudMilitaryInfoProvider as SqlEdStudMilitaryInfoProvider;}
		}
		
		#endregion
		
		
		#region "EdStudMilitaryStateProvider"
			
		private SqlEdStudMilitaryStateProvider innerSqlEdStudMilitaryStateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudMilitaryState"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudMilitaryStateProviderBase EdStudMilitaryStateProvider
		{
			get
			{
				if (innerSqlEdStudMilitaryStateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudMilitaryStateProvider == null)
						{
							this.innerSqlEdStudMilitaryStateProvider = new SqlEdStudMilitaryStateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudMilitaryStateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudMilitaryStateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudMilitaryStateProvider SqlEdStudMilitaryStateProvider
		{
			get {return EdStudMilitaryStateProvider as SqlEdStudMilitaryStateProvider;}
		}
		
		#endregion
		
		
		#region "EdStudMissionProvider"
			
		private SqlEdStudMissionProvider innerSqlEdStudMissionProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudMission"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudMissionProviderBase EdStudMissionProvider
		{
			get
			{
				if (innerSqlEdStudMissionProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudMissionProvider == null)
						{
							this.innerSqlEdStudMissionProvider = new SqlEdStudMissionProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudMissionProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudMissionProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudMissionProvider SqlEdStudMissionProvider
		{
			get {return EdStudMissionProvider as SqlEdStudMissionProvider;}
		}
		
		#endregion
		
		
		#region "EdStudGraduationAwardProvider"
			
		private SqlEdStudGraduationAwardProvider innerSqlEdStudGraduationAwardProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudGraduationAward"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudGraduationAwardProviderBase EdStudGraduationAwardProvider
		{
			get
			{
				if (innerSqlEdStudGraduationAwardProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudGraduationAwardProvider == null)
						{
							this.innerSqlEdStudGraduationAwardProvider = new SqlEdStudGraduationAwardProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudGraduationAwardProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudGraduationAwardProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudGraduationAwardProvider SqlEdStudGraduationAwardProvider
		{
			get {return EdStudGraduationAwardProvider as SqlEdStudGraduationAwardProvider;}
		}
		
		#endregion
		
		
		#region "EdStudFacultyProvider"
			
		private SqlEdStudFacultyProvider innerSqlEdStudFacultyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudFaculty"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudFacultyProviderBase EdStudFacultyProvider
		{
			get
			{
				if (innerSqlEdStudFacultyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudFacultyProvider == null)
						{
							this.innerSqlEdStudFacultyProvider = new SqlEdStudFacultyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudFacultyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudFacultyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudFacultyProvider SqlEdStudFacultyProvider
		{
			get {return EdStudFacultyProvider as SqlEdStudFacultyProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegProvider"
			
		private SqlEdStudCourseRegProvider innerSqlEdStudCourseRegProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseReg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegProviderBase EdStudCourseRegProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegProvider == null)
						{
							this.innerSqlEdStudCourseRegProvider = new SqlEdStudCourseRegProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegProvider SqlEdStudCourseRegProvider
		{
			get {return EdStudCourseRegProvider as SqlEdStudCourseRegProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExmptReqAttchProvider"
			
		private SqlEdStudExmptReqAttchProvider innerSqlEdStudExmptReqAttchProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExmptReqAttch"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExmptReqAttchProviderBase EdStudExmptReqAttchProvider
		{
			get
			{
				if (innerSqlEdStudExmptReqAttchProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExmptReqAttchProvider == null)
						{
							this.innerSqlEdStudExmptReqAttchProvider = new SqlEdStudExmptReqAttchProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExmptReqAttchProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExmptReqAttchProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExmptReqAttchProvider SqlEdStudExmptReqAttchProvider
		{
			get {return EdStudExmptReqAttchProvider as SqlEdStudExmptReqAttchProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegAddProvider"
			
		private SqlEdStudCourseRegAddProvider innerSqlEdStudCourseRegAddProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegAdd"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegAddProviderBase EdStudCourseRegAddProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegAddProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegAddProvider == null)
						{
							this.innerSqlEdStudCourseRegAddProvider = new SqlEdStudCourseRegAddProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegAddProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegAddProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegAddProvider SqlEdStudCourseRegAddProvider
		{
			get {return EdStudCourseRegAddProvider as SqlEdStudCourseRegAddProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegAssessProvider"
			
		private SqlEdStudCourseRegAssessProvider innerSqlEdStudCourseRegAssessProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegAssess"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegAssessProviderBase EdStudCourseRegAssessProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegAssessProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegAssessProvider == null)
						{
							this.innerSqlEdStudCourseRegAssessProvider = new SqlEdStudCourseRegAssessProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegAssessProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegAssessProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegAssessProvider SqlEdStudCourseRegAssessProvider
		{
			get {return EdStudCourseRegAssessProvider as SqlEdStudCourseRegAssessProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegPolcyProvider"
			
		private SqlEdStudCourseRegPolcyProvider innerSqlEdStudCourseRegPolcyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegPolcy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegPolcyProviderBase EdStudCourseRegPolcyProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegPolcyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegPolcyProvider == null)
						{
							this.innerSqlEdStudCourseRegPolcyProvider = new SqlEdStudCourseRegPolcyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegPolcyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegPolcyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegPolcyProvider SqlEdStudCourseRegPolcyProvider
		{
			get {return EdStudCourseRegPolcyProvider as SqlEdStudCourseRegPolcyProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegAssessSubProvider"
			
		private SqlEdStudCourseRegAssessSubProvider innerSqlEdStudCourseRegAssessSubProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegAssessSub"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegAssessSubProviderBase EdStudCourseRegAssessSubProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegAssessSubProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegAssessSubProvider == null)
						{
							this.innerSqlEdStudCourseRegAssessSubProvider = new SqlEdStudCourseRegAssessSubProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegAssessSubProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegAssessSubProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegAssessSubProvider SqlEdStudCourseRegAssessSubProvider
		{
			get {return EdStudCourseRegAssessSubProvider as SqlEdStudCourseRegAssessSubProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseGrdChngProvider"
			
		private SqlEdStudCourseGrdChngProvider innerSqlEdStudCourseGrdChngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseGrdChng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseGrdChngProviderBase EdStudCourseGrdChngProvider
		{
			get
			{
				if (innerSqlEdStudCourseGrdChngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseGrdChngProvider == null)
						{
							this.innerSqlEdStudCourseGrdChngProvider = new SqlEdStudCourseGrdChngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseGrdChngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseGrdChngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseGrdChngProvider SqlEdStudCourseGrdChngProvider
		{
			get {return EdStudCourseGrdChngProvider as SqlEdStudCourseGrdChngProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCodeChngProvider"
			
		private SqlEdStudCodeChngProvider innerSqlEdStudCodeChngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCodeChng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCodeChngProviderBase EdStudCodeChngProvider
		{
			get
			{
				if (innerSqlEdStudCodeChngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCodeChngProvider == null)
						{
							this.innerSqlEdStudCodeChngProvider = new SqlEdStudCodeChngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCodeChngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCodeChngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCodeChngProvider SqlEdStudCodeChngProvider
		{
			get {return EdStudCodeChngProvider as SqlEdStudCodeChngProvider;}
		}
		
		#endregion
		
		
		#region "EdStudContactMethodProvider"
			
		private SqlEdStudContactMethodProvider innerSqlEdStudContactMethodProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudContactMethod"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudContactMethodProviderBase EdStudContactMethodProvider
		{
			get
			{
				if (innerSqlEdStudContactMethodProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudContactMethodProvider == null)
						{
							this.innerSqlEdStudContactMethodProvider = new SqlEdStudContactMethodProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudContactMethodProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudContactMethodProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudContactMethodProvider SqlEdStudContactMethodProvider
		{
			get {return EdStudContactMethodProvider as SqlEdStudContactMethodProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseChngProvider"
			
		private SqlEdStudCourseChngProvider innerSqlEdStudCourseChngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseChng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseChngProviderBase EdStudCourseChngProvider
		{
			get
			{
				if (innerSqlEdStudCourseChngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseChngProvider == null)
						{
							this.innerSqlEdStudCourseChngProvider = new SqlEdStudCourseChngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseChngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseChngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseChngProvider SqlEdStudCourseChngProvider
		{
			get {return EdStudCourseChngProvider as SqlEdStudCourseChngProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseCompProvider"
			
		private SqlEdStudCourseCompProvider innerSqlEdStudCourseCompProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseComp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseCompProviderBase EdStudCourseCompProvider
		{
			get
			{
				if (innerSqlEdStudCourseCompProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseCompProvider == null)
						{
							this.innerSqlEdStudCourseCompProvider = new SqlEdStudCourseCompProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseCompProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseCompProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseCompProvider SqlEdStudCourseCompProvider
		{
			get {return EdStudCourseCompProvider as SqlEdStudCourseCompProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegPreProvider"
			
		private SqlEdStudCourseRegPreProvider innerSqlEdStudCourseRegPreProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegPre"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegPreProviderBase EdStudCourseRegPreProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegPreProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegPreProvider == null)
						{
							this.innerSqlEdStudCourseRegPreProvider = new SqlEdStudCourseRegPreProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegPreProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegPreProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegPreProvider SqlEdStudCourseRegPreProvider
		{
			get {return EdStudCourseRegPreProvider as SqlEdStudCourseRegPreProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegTempProvider"
			
		private SqlEdStudCourseRegTempProvider innerSqlEdStudCourseRegTempProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegTemp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegTempProviderBase EdStudCourseRegTempProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegTempProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegTempProvider == null)
						{
							this.innerSqlEdStudCourseRegTempProvider = new SqlEdStudCourseRegTempProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegTempProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegTempProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegTempProvider SqlEdStudCourseRegTempProvider
		{
			get {return EdStudCourseRegTempProvider as SqlEdStudCourseRegTempProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRegTopicProvider"
			
		private SqlEdStudCourseRegTopicProvider innerSqlEdStudCourseRegTopicProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRegTopic"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRegTopicProviderBase EdStudCourseRegTopicProvider
		{
			get
			{
				if (innerSqlEdStudCourseRegTopicProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRegTopicProvider == null)
						{
							this.innerSqlEdStudCourseRegTopicProvider = new SqlEdStudCourseRegTopicProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRegTopicProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRegTopicProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRegTopicProvider SqlEdStudCourseRegTopicProvider
		{
			get {return EdStudCourseRegTopicProvider as SqlEdStudCourseRegTopicProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExmptReqProvider"
			
		private SqlEdStudExmptReqProvider innerSqlEdStudExmptReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExmptReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExmptReqProviderBase EdStudExmptReqProvider
		{
			get
			{
				if (innerSqlEdStudExmptReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExmptReqProvider == null)
						{
							this.innerSqlEdStudExmptReqProvider = new SqlEdStudExmptReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExmptReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExmptReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExmptReqProvider SqlEdStudExmptReqProvider
		{
			get {return EdStudExmptReqProvider as SqlEdStudExmptReqProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExmptCrsFromProvider"
			
		private SqlEdStudExmptCrsFromProvider innerSqlEdStudExmptCrsFromProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExmptCrsFrom"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExmptCrsFromProviderBase EdStudExmptCrsFromProvider
		{
			get
			{
				if (innerSqlEdStudExmptCrsFromProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExmptCrsFromProvider == null)
						{
							this.innerSqlEdStudExmptCrsFromProvider = new SqlEdStudExmptCrsFromProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExmptCrsFromProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExmptCrsFromProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExmptCrsFromProvider SqlEdStudExmptCrsFromProvider
		{
			get {return EdStudExmptCrsFromProvider as SqlEdStudExmptCrsFromProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExecuseReqProvider"
			
		private SqlEdStudExecuseReqProvider innerSqlEdStudExecuseReqProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExecuseReq"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExecuseReqProviderBase EdStudExecuseReqProvider
		{
			get
			{
				if (innerSqlEdStudExecuseReqProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExecuseReqProvider == null)
						{
							this.innerSqlEdStudExecuseReqProvider = new SqlEdStudExecuseReqProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExecuseReqProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExecuseReqProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExecuseReqProvider SqlEdStudExecuseReqProvider
		{
			get {return EdStudExecuseReqProvider as SqlEdStudExecuseReqProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExmptCrsToProvider"
			
		private SqlEdStudExmptCrsToProvider innerSqlEdStudExmptCrsToProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExmptCrsTo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExmptCrsToProviderBase EdStudExmptCrsToProvider
		{
			get
			{
				if (innerSqlEdStudExmptCrsToProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExmptCrsToProvider == null)
						{
							this.innerSqlEdStudExmptCrsToProvider = new SqlEdStudExmptCrsToProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExmptCrsToProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExmptCrsToProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExmptCrsToProvider SqlEdStudExmptCrsToProvider
		{
			get {return EdStudExmptCrsToProvider as SqlEdStudExmptCrsToProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExcuseProvider"
			
		private SqlEdStudExcuseProvider innerSqlEdStudExcuseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExcuse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExcuseProviderBase EdStudExcuseProvider
		{
			get
			{
				if (innerSqlEdStudExcuseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExcuseProvider == null)
						{
							this.innerSqlEdStudExcuseProvider = new SqlEdStudExcuseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExcuseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExcuseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExcuseProvider SqlEdStudExcuseProvider
		{
			get {return EdStudExcuseProvider as SqlEdStudExcuseProvider;}
		}
		
		#endregion
		
		
		#region "EdStudExcuseCourseProvider"
			
		private SqlEdStudExcuseCourseProvider innerSqlEdStudExcuseCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudExcuseCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudExcuseCourseProviderBase EdStudExcuseCourseProvider
		{
			get
			{
				if (innerSqlEdStudExcuseCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudExcuseCourseProvider == null)
						{
							this.innerSqlEdStudExcuseCourseProvider = new SqlEdStudExcuseCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudExcuseCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudExcuseCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudExcuseCourseProvider SqlEdStudExcuseCourseProvider
		{
			get {return EdStudExcuseCourseProvider as SqlEdStudExcuseCourseProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseRplcProvider"
			
		private SqlEdStudCourseRplcProvider innerSqlEdStudCourseRplcProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseRplc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseRplcProviderBase EdStudCourseRplcProvider
		{
			get
			{
				if (innerSqlEdStudCourseRplcProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseRplcProvider == null)
						{
							this.innerSqlEdStudCourseRplcProvider = new SqlEdStudCourseRplcProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseRplcProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseRplcProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseRplcProvider SqlEdStudCourseRplcProvider
		{
			get {return EdStudCourseRplcProvider as SqlEdStudCourseRplcProvider;}
		}
		
		#endregion
		
		
		#region "EdStudCourseWaitProvider"
			
		private SqlEdStudCourseWaitProvider innerSqlEdStudCourseWaitProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudCourseWait"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudCourseWaitProviderBase EdStudCourseWaitProvider
		{
			get
			{
				if (innerSqlEdStudCourseWaitProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudCourseWaitProvider == null)
						{
							this.innerSqlEdStudCourseWaitProvider = new SqlEdStudCourseWaitProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudCourseWaitProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudCourseWaitProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudCourseWaitProvider SqlEdStudCourseWaitProvider
		{
			get {return EdStudCourseWaitProvider as SqlEdStudCourseWaitProvider;}
		}
		
		#endregion
		
		
		#region "EdStudDisabilityProvider"
			
		private SqlEdStudDisabilityProvider innerSqlEdStudDisabilityProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudDisability"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudDisabilityProviderBase EdStudDisabilityProvider
		{
			get
			{
				if (innerSqlEdStudDisabilityProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudDisabilityProvider == null)
						{
							this.innerSqlEdStudDisabilityProvider = new SqlEdStudDisabilityProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudDisabilityProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudDisabilityProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudDisabilityProvider SqlEdStudDisabilityProvider
		{
			get {return EdStudDisabilityProvider as SqlEdStudDisabilityProvider;}
		}
		
		#endregion
		
		
		#region "EdStudEnrollChangeProvider"
			
		private SqlEdStudEnrollChangeProvider innerSqlEdStudEnrollChangeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="EdStudEnrollChange"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override EdStudEnrollChangeProviderBase EdStudEnrollChangeProvider
		{
			get
			{
				if (innerSqlEdStudEnrollChangeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlEdStudEnrollChangeProvider == null)
						{
							this.innerSqlEdStudEnrollChangeProvider = new SqlEdStudEnrollChangeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlEdStudEnrollChangeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlEdStudEnrollChangeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlEdStudEnrollChangeProvider SqlEdStudEnrollChangeProvider
		{
			get {return EdStudEnrollChangeProvider as SqlEdStudEnrollChangeProvider;}
		}
		
		#endregion
		
		
		#region "WfCrsRsltApproveProvider"
			
		private SqlWfCrsRsltApproveProvider innerSqlWfCrsRsltApproveProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="WfCrsRsltApprove"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override WfCrsRsltApproveProviderBase WfCrsRsltApproveProvider
		{
			get
			{
				if (innerSqlWfCrsRsltApproveProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlWfCrsRsltApproveProvider == null)
						{
							this.innerSqlWfCrsRsltApproveProvider = new SqlWfCrsRsltApproveProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlWfCrsRsltApproveProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlWfCrsRsltApproveProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlWfCrsRsltApproveProvider SqlWfCrsRsltApproveProvider
		{
			get {return WfCrsRsltApproveProvider as SqlWfCrsRsltApproveProvider;}
		}
		
		#endregion
		
		
		
		#region "AppFeeViewProvider"
		
		private SqlAppFeeViewProvider innerSqlAppFeeViewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="AppFeeView"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override AppFeeViewProviderBase AppFeeViewProvider
		{
			get
			{
				if (innerSqlAppFeeViewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlAppFeeViewProvider == null)
						{
							this.innerSqlAppFeeViewProvider = new SqlAppFeeViewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlAppFeeViewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlAppFeeViewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlAppFeeViewProvider SqlAppFeeViewProvider
		{
			get {return AppFeeViewProvider as SqlAppFeeViewProvider;}
		}
		
		#endregion
		
		
		#region "ApplicantPlacementExamViewProvider"
		
		private SqlApplicantPlacementExamViewProvider innerSqlApplicantPlacementExamViewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ApplicantPlacementExamView"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ApplicantPlacementExamViewProviderBase ApplicantPlacementExamViewProvider
		{
			get
			{
				if (innerSqlApplicantPlacementExamViewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlApplicantPlacementExamViewProvider == null)
						{
							this.innerSqlApplicantPlacementExamViewProvider = new SqlApplicantPlacementExamViewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlApplicantPlacementExamViewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlApplicantPlacementExamViewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlApplicantPlacementExamViewProvider SqlApplicantPlacementExamViewProvider
		{
			get {return ApplicantPlacementExamViewProvider as SqlApplicantPlacementExamViewProvider;}
		}
		
		#endregion
		
		
		#region "ApplicantRequiredDocumentViewProvider"
		
		private SqlApplicantRequiredDocumentViewProvider innerSqlApplicantRequiredDocumentViewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ApplicantRequiredDocumentView"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ApplicantRequiredDocumentViewProviderBase ApplicantRequiredDocumentViewProvider
		{
			get
			{
				if (innerSqlApplicantRequiredDocumentViewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlApplicantRequiredDocumentViewProvider == null)
						{
							this.innerSqlApplicantRequiredDocumentViewProvider = new SqlApplicantRequiredDocumentViewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlApplicantRequiredDocumentViewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlApplicantRequiredDocumentViewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlApplicantRequiredDocumentViewProvider SqlApplicantRequiredDocumentViewProvider
		{
			get {return ApplicantRequiredDocumentViewProvider as SqlApplicantRequiredDocumentViewProvider;}
		}
		
		#endregion
		
		
		#region "ApplicantStepsViewProvider"
		
		private SqlApplicantStepsViewProvider innerSqlApplicantStepsViewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ApplicantStepsView"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ApplicantStepsViewProviderBase ApplicantStepsViewProvider
		{
			get
			{
				if (innerSqlApplicantStepsViewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlApplicantStepsViewProvider == null)
						{
							this.innerSqlApplicantStepsViewProvider = new SqlApplicantStepsViewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlApplicantStepsViewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlApplicantStepsViewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlApplicantStepsViewProvider SqlApplicantStepsViewProvider
		{
			get {return ApplicantStepsViewProvider as SqlApplicantStepsViewProvider;}
		}
		
		#endregion
		
		
		#region "ModulesTreeViewProvider"
		
		private SqlModulesTreeViewProvider innerSqlModulesTreeViewProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ModulesTreeView"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ModulesTreeViewProviderBase ModulesTreeViewProvider
		{
			get
			{
				if (innerSqlModulesTreeViewProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlModulesTreeViewProvider == null)
						{
							this.innerSqlModulesTreeViewProvider = new SqlModulesTreeViewProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlModulesTreeViewProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlModulesTreeViewProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlModulesTreeViewProvider SqlModulesTreeViewProvider
		{
			get {return ModulesTreeViewProvider as SqlModulesTreeViewProvider;}
		}
		
		#endregion
		
		
		#region "StaffAcademicLoadsProvider"
		
		private SqlStaffAcademicLoadsProvider innerSqlStaffAcademicLoadsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="StaffAcademicLoads"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override StaffAcademicLoadsProviderBase StaffAcademicLoadsProvider
		{
			get
			{
				if (innerSqlStaffAcademicLoadsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlStaffAcademicLoadsProvider == null)
						{
							this.innerSqlStaffAcademicLoadsProvider = new SqlStaffAcademicLoadsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlStaffAcademicLoadsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlStaffAcademicLoadsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlStaffAcademicLoadsProvider SqlStaffAcademicLoadsProvider
		{
			get {return StaffAcademicLoadsProvider as SqlStaffAcademicLoadsProvider;}
		}
		
		#endregion
		
		
		#region "TeachingLoadDistributionPerProgramProvider"
		
		private SqlTeachingLoadDistributionPerProgramProvider innerSqlTeachingLoadDistributionPerProgramProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TeachingLoadDistributionPerProgram"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TeachingLoadDistributionPerProgramProviderBase TeachingLoadDistributionPerProgramProvider
		{
			get
			{
				if (innerSqlTeachingLoadDistributionPerProgramProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTeachingLoadDistributionPerProgramProvider == null)
						{
							this.innerSqlTeachingLoadDistributionPerProgramProvider = new SqlTeachingLoadDistributionPerProgramProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTeachingLoadDistributionPerProgramProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlTeachingLoadDistributionPerProgramProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTeachingLoadDistributionPerProgramProvider SqlTeachingLoadDistributionPerProgramProvider
		{
			get {return TeachingLoadDistributionPerProgramProvider as SqlTeachingLoadDistributionPerProgramProvider;}
		}
		
		#endregion
		
		
		#region "VmGetOfferingInCurrentAcadYearSemesterProvider"
		
		private SqlVmGetOfferingInCurrentAcadYearSemesterProvider innerSqlVmGetOfferingInCurrentAcadYearSemesterProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VmGetOfferingInCurrentAcadYearSemester"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VmGetOfferingInCurrentAcadYearSemesterProviderBase VmGetOfferingInCurrentAcadYearSemesterProvider
		{
			get
			{
				if (innerSqlVmGetOfferingInCurrentAcadYearSemesterProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVmGetOfferingInCurrentAcadYearSemesterProvider == null)
						{
							this.innerSqlVmGetOfferingInCurrentAcadYearSemesterProvider = new SqlVmGetOfferingInCurrentAcadYearSemesterProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVmGetOfferingInCurrentAcadYearSemesterProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVmGetOfferingInCurrentAcadYearSemesterProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVmGetOfferingInCurrentAcadYearSemesterProvider SqlVmGetOfferingInCurrentAcadYearSemesterProvider
		{
			get {return VmGetOfferingInCurrentAcadYearSemesterProvider as SqlVmGetOfferingInCurrentAcadYearSemesterProvider;}
		}
		
		#endregion
		
		
		#region "VscheduleCoursesProvider"
		
		private SqlVscheduleCoursesProvider innerSqlVscheduleCoursesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VscheduleCourses"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VscheduleCoursesProviderBase VscheduleCoursesProvider
		{
			get
			{
				if (innerSqlVscheduleCoursesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVscheduleCoursesProvider == null)
						{
							this.innerSqlVscheduleCoursesProvider = new SqlVscheduleCoursesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVscheduleCoursesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVscheduleCoursesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVscheduleCoursesProvider SqlVscheduleCoursesProvider
		{
			get {return VscheduleCoursesProvider as SqlVscheduleCoursesProvider;}
		}
		
		#endregion
		
		
		#region "VwGetAcadmicPlanCoursesProvider"
		
		private SqlVwGetAcadmicPlanCoursesProvider innerSqlVwGetAcadmicPlanCoursesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VwGetAcadmicPlanCourses"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VwGetAcadmicPlanCoursesProviderBase VwGetAcadmicPlanCoursesProvider
		{
			get
			{
				if (innerSqlVwGetAcadmicPlanCoursesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVwGetAcadmicPlanCoursesProvider == null)
						{
							this.innerSqlVwGetAcadmicPlanCoursesProvider = new SqlVwGetAcadmicPlanCoursesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVwGetAcadmicPlanCoursesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVwGetAcadmicPlanCoursesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVwGetAcadmicPlanCoursesProvider SqlVwGetAcadmicPlanCoursesProvider
		{
			get {return VwGetAcadmicPlanCoursesProvider as SqlVwGetAcadmicPlanCoursesProvider;}
		}
		
		#endregion
		
		
		#region "VwGetUniversityRequirementsCoursesProvider"
		
		private SqlVwGetUniversityRequirementsCoursesProvider innerSqlVwGetUniversityRequirementsCoursesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VwGetUniversityRequirementsCourses"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VwGetUniversityRequirementsCoursesProviderBase VwGetUniversityRequirementsCoursesProvider
		{
			get
			{
				if (innerSqlVwGetUniversityRequirementsCoursesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVwGetUniversityRequirementsCoursesProvider == null)
						{
							this.innerSqlVwGetUniversityRequirementsCoursesProvider = new SqlVwGetUniversityRequirementsCoursesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVwGetUniversityRequirementsCoursesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVwGetUniversityRequirementsCoursesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVwGetUniversityRequirementsCoursesProvider SqlVwGetUniversityRequirementsCoursesProvider
		{
			get {return VwGetUniversityRequirementsCoursesProvider as SqlVwGetUniversityRequirementsCoursesProvider;}
		}
		
		#endregion
		
		
		#region "VwSelectDegreeAfterApplyRepeateRuleProvider"
		
		private SqlVwSelectDegreeAfterApplyRepeateRuleProvider innerSqlVwSelectDegreeAfterApplyRepeateRuleProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VwSelectDegreeAfterApplyRepeateRule"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VwSelectDegreeAfterApplyRepeateRuleProviderBase VwSelectDegreeAfterApplyRepeateRuleProvider
		{
			get
			{
				if (innerSqlVwSelectDegreeAfterApplyRepeateRuleProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVwSelectDegreeAfterApplyRepeateRuleProvider == null)
						{
							this.innerSqlVwSelectDegreeAfterApplyRepeateRuleProvider = new SqlVwSelectDegreeAfterApplyRepeateRuleProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVwSelectDegreeAfterApplyRepeateRuleProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVwSelectDegreeAfterApplyRepeateRuleProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVwSelectDegreeAfterApplyRepeateRuleProvider SqlVwSelectDegreeAfterApplyRepeateRuleProvider
		{
			get {return VwSelectDegreeAfterApplyRepeateRuleProvider as SqlVwSelectDegreeAfterApplyRepeateRuleProvider;}
		}
		
		#endregion
		
		
		#region "VwSelectStudRemainCourseProvider"
		
		private SqlVwSelectStudRemainCourseProvider innerSqlVwSelectStudRemainCourseProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VwSelectStudRemainCourse"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VwSelectStudRemainCourseProviderBase VwSelectStudRemainCourseProvider
		{
			get
			{
				if (innerSqlVwSelectStudRemainCourseProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVwSelectStudRemainCourseProvider == null)
						{
							this.innerSqlVwSelectStudRemainCourseProvider = new SqlVwSelectStudRemainCourseProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVwSelectStudRemainCourseProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVwSelectStudRemainCourseProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVwSelectStudRemainCourseProvider SqlVwSelectStudRemainCourseProvider
		{
			get {return VwSelectStudRemainCourseProvider as SqlVwSelectStudRemainCourseProvider;}
		}
		
		#endregion
		
		
		#region "VwSelectTotalCrsHrsRegProvider"
		
		private SqlVwSelectTotalCrsHrsRegProvider innerSqlVwSelectTotalCrsHrsRegProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VwSelectTotalCrsHrsReg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VwSelectTotalCrsHrsRegProviderBase VwSelectTotalCrsHrsRegProvider
		{
			get
			{
				if (innerSqlVwSelectTotalCrsHrsRegProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVwSelectTotalCrsHrsRegProvider == null)
						{
							this.innerSqlVwSelectTotalCrsHrsRegProvider = new SqlVwSelectTotalCrsHrsRegProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVwSelectTotalCrsHrsRegProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <c cref="SqlVwSelectTotalCrsHrsRegProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVwSelectTotalCrsHrsRegProvider SqlVwSelectTotalCrsHrsRegProvider
		{
			get {return VwSelectTotalCrsHrsRegProvider as SqlVwSelectTotalCrsHrsRegProvider;}
		}
		
		#endregion
		
		
		#region "General data access methods"

		#region "ExecuteNonQuery"
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		public override void ExecuteNonQuery(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			database.ExecuteNonQuery(commandWrapper);	
			
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		public override void ExecuteNonQuery(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			database.ExecuteNonQuery(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(commandType, commandText);	
		}
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteNonQuery(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteDataReader"
		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteReader(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteReader(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteReader(commandWrapper);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteReader(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteReader(commandType, commandText);	
		}
		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteReader(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteDataSet"
		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteDataSet(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteDataSet(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteDataSet(commandWrapper);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteDataSet(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteDataSet(commandType, commandText);	
		}
		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteDataSet(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteScalar"
		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override object ExecuteScalar(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteScalar(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteScalar(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override object ExecuteScalar(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteScalar(commandWrapper);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteScalar(commandWrapper, transactionManager.TransactionObject);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override object ExecuteScalar(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteScalar(commandType, commandText);	
		}
		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteScalar(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#endregion


	}
}
