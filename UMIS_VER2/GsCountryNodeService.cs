	

#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using UMIS_VER2.BusinessLyer;
using UMIS_VER2.BusinessLyer.Validation;

using UMIS_VER2.AccessLayer;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using UMIS_VER2.AccessLayer.Bases;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'GS_COUNTRY_NODE' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class GsCountryNodeService : UMIS_VER2.GsCountryNodeServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the GsCountryNodeService class.
		/// </summary>
		public GsCountryNodeService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual string GetCountryNodePath(System.Decimal _GsCountryNodeId, System.Decimal _Lang)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCountryNodePath");
            #endregion Security check

            #region Initialisation
            //TList<GsCountryNode> list = null;
            string path = "";
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                path = dataProvider.GsCountryNodeProvider.GetCountryNodePath(transactionManager, _GsCountryNodeId, _Lang) as string;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return path;
        }
           public virtual TList<GsCountryNode> getDistrictsonCurrentCountry()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("getDistrictsonCurrentCountry");
            #endregion Security check
            #region Initialisation
            TList<GsCountryNode> newObjDB = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                newObjDB = dataProvider.GsCountryNodeProvider.getDistrictsonCurrentCountry(transactionManager);
                return newObjDB;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return newObjDB;
        }
        public virtual TList<GsCountryNode> SelectByGsCodeCNodeNatureforignkeys(decimal gscodecnodenatureid)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetCountryNodePath");
            #endregion Security check
            #region Initialisation
            TList<GsCountryNode> newObjDB = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                newObjDB = dataProvider.GsCountryNodeProvider.SelectByGsCodeCNodeNatureforignkeys(transactionManager, gscodecnodenatureid);
                return newObjDB;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return newObjDB;
        }
        public virtual TList<GsCountryNode> SelectByGsCountryNodeforignkeys(decimal nodeparentid)
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SelectByGsCountryNodeforignkeys");
            #endregion Security check
            #region Initialisation
            TList<GsCountryNode> newObjDB = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                newObjDB = dataProvider.GsCountryNodeProvider.SelectByGsCountryNodeforignkeys(transactionManager, nodeparentid);
                return newObjDB;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return newObjDB;
        }
        public virtual void SetIsLocalChilds(System.Decimal isLocal, System.Decimal parentID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SetIsLocalChilds");
            #endregion Security check

            #region Initialisation
            //TList<GsCountryNode> list = null;
            string path = "";
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.GsCountryNodeProvider.SetIsLocalChilds(transactionManager, isLocal, parentID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
        }
        public virtual void SetIsLocal(System.Decimal isLocal, System.Decimal NodeID)
        {

            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("SetIsLocal");
            #endregion Security check

            #region Initialisation
            //TList<GsCountryNode> list = null;
            string path = "";
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                dataProvider.GsCountryNodeProvider.SetIsLocal(transactionManager, isLocal, NodeID);
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
        }
        public virtual TList<GsCountryNode> GetAllCountries()
        {
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllCountries");
            #endregion Security check
            #region Initialisation
            TList<GsCountryNode> newObjDB = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;
                newObjDB = dataProvider.GsCountryNodeProvider.GetAllCountries(transactionManager);
                return newObjDB;
            }
            catch (Exception exc)
            {
                #region Handle transaction rollback and exception
                if (transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Rollback();

                //Handle exception based on policy
                if (DomainUtil.HandleException(exc, layerExceptionPolicy))
                    throw;
                #endregion Handle transaction rollback and exception
            }
            return newObjDB;
        }

        #endregion

	}//End Class

} // end namespace
