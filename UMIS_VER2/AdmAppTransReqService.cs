	

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
using System.Data.SqlClient;
using System.Configuration;

#endregion

namespace UMIS_VER2
{		
	/// <summary>
	/// An component type implementation of the 'ADM_APP_TRANS_REQ' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class AdmAppTransReqService : UMIS_VER2.AdmAppTransReqServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the AdmAppTransReqService class.
		/// </summary>
		public AdmAppTransReqService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual decimal InsertWithOutputAdmAppTransReqId(AdmAppTransReq entity)
        {
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("InsertWithOutputAdmAppTransReqId");

            if (!entity.IsValid)
                throw new EntityNotValidException(entity, "InsertWithOutputAdmAppTransReqId", entity.Error);
            #endregion Security and validation check

            #region Initialisation
            decimal AdmAppTransReq = 0;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                AdmAppTransReq = dataProvider.AdmAppTransReqProvider.InsertWithOutputAdmAppTransReqId(transactionManager, entity);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

            return AdmAppTransReq;
        }

         public virtual DataTable GetInternalTransferRequests( decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoFromId, decimal entMainFromId,
            decimal asFacultyInfoToId, decimal entMainToId,decimal admTrnsTypeId,
            DateTime reqFromDate, DateTime reqToDate, string studCode, string studCPR, decimal langNum, decimal namePolicy, string studName, decimal isApplied, decimal? AsCodeDegreeClassId)
         {
            
            #region Security and validation check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetInternalTransferRequests");

         
            #endregion Security and validation check

            #region Initialisation
            DataTable  internalTransferRequests =null;
            bool isBorrowedTransaction = false;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider;
            #endregion Initialisation

            try
            {
                isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                internalTransferRequests = dataProvider.AdmAppTransReqProvider.GetInternalTransferRequests(transactionManager,  edAcadYearID,  edCodeSemesterId,  asFacultyInfoFromId,  entMainFromId,
             asFacultyInfoToId,  entMainToId, admTrnsTypeId,
             reqFromDate, reqToDate, studCode, studCPR, langNum, namePolicy, studName, isApplied, AsCodeDegreeClassId);

                if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                    transactionManager.Commit();
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

            return internalTransferRequests;
         }

         public virtual DataTable GetTransferStuds(decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoFromId, decimal entMainFromId,
          decimal asFacultyInfoToId, decimal entMainToId, decimal AsCodeDegreeFromId,
          decimal AsCodeDegreeToId, string studCode,decimal isApplied)
         {

             #region Security and validation check
             // throws security exception if not authorized
             SecurityContext.IsAuthorized("GetTransferStuds");


             #endregion Security and validation check

             #region Initialisation
             DataTable internalTransferRequests = null;
             bool isBorrowedTransaction = false;
             TransactionManager transactionManager = null;
             NetTiersProvider dataProvider;
             #endregion Initialisation

             try
             {
                 isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                 transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                 dataProvider = ConnectionScope.Current.DataProvider;

                 internalTransferRequests = dataProvider.AdmAppTransReqProvider.GetTransferStuds(transactionManager, edAcadYearID, edCodeSemesterId, asFacultyInfoFromId, entMainFromId,
              asFacultyInfoToId, entMainToId, AsCodeDegreeFromId,
              AsCodeDegreeToId,studCode,isApplied);

                 if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                     transactionManager.Commit();
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

             return internalTransferRequests;
         }
         
        
public virtual DataTable GetExternalTransferRequests( decimal edAcadYearID, decimal edCodeSemesterId, decimal asFacultyInfoId, decimal entMainId,

            DateTime? reqFromDate, DateTime? reqToDate, string admAppCode, string admAppCPR, decimal langNum, decimal namePolicy, string applicantName,decimal isApplied)
         {

             #region Security and validation check
             // throws security exception if not authorized
             SecurityContext.IsAuthorized("GetExternalTransferRequests");


             #endregion Security and validation check

             #region Initialisation
             DataTable externalTransferRequests = null;
             bool isBorrowedTransaction = false;
             TransactionManager transactionManager = null;
             NetTiersProvider dataProvider;
             #endregion Initialisation

             try
             {
                 isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
                 transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                 dataProvider = ConnectionScope.Current.DataProvider;

                 externalTransferRequests = dataProvider.AdmAppTransReqProvider.GetExternalTransferRequests(transactionManager,edAcadYearID, edCodeSemesterId, asFacultyInfoId, entMainId,

             reqFromDate,  reqToDate,  admAppCode,  admAppCPR,  langNum,  namePolicy,  applicantName, isApplied);

                 if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
                     transactionManager.Commit();
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

             return externalTransferRequests;
         }



/// <summary>
/// Mostafa Hussien 
/// </summary>
/// <param name="EDSTUDINTTRNSID"></param>
/// <returns></returns>

public   int DeleteEdStudIntTrns(decimal EDSTUDINTTRNSID)
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UMIS_VER2.AccessLayer.ConnectionString"].ConnectionString);
    SqlTransaction t = null;//
    int returnVal = 0;
    try
    {
        conn.Open();
        t = conn.BeginTransaction();//

        SqlCommand command = new SqlCommand("c_Delete_ED_STUD_INT_TRNS", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add("ED_STUD_INT_TRNS_ID", SqlDbType.Decimal).Value = EDSTUDINTTRNSID;

        command.Transaction = t;//
       returnVal = command.ExecuteNonQuery();
    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message); 
        t.Rollback();//
        returnVal = -1;
    }
    finally
    {
        if (returnVal>0)
            t.Commit();
     
        conn.Close();
    }
    return returnVal;
}

//Added by Menna 06-08-2019 task 10714
public virtual DataTable C_GetByAdmAppRegHistoryId(TransactionManager transactionManager, System.Decimal admAppRegHistoryId)
       
{

    #region Security and validation check
    // throws security exception if not authorized
    SecurityContext.IsAuthorized("C_GetByAdmAppRegHistoryId");


    #endregion Security and validation check

    #region Initialisation
    DataTable AdmAppTransReq = null;
    bool isBorrowedTransaction = false;
    //TransactionManager transactionManager = null;
    NetTiersProvider dataProvider;
    #endregion Initialisation

    try
    {
        isBorrowedTransaction = ConnectionScope.Current.HasTransaction;
        transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
        dataProvider = ConnectionScope.Current.DataProvider;

        AdmAppTransReq = dataProvider.AdmAppTransReqProvider.C_GetByAdmAppRegHistoryId(transactionManager, admAppRegHistoryId);

        if (!isBorrowedTransaction && transactionManager != null && transactionManager.IsOpen)
            transactionManager.Commit();
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

    return AdmAppTransReq;
}

        #endregion

	}//End Class

} // end namespace
