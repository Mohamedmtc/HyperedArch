	

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
	/// An component type implementation of the 'SV_STUD_ASK_ADV' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class SvStudAskAdvService : UMIS_VER2.SvStudAskAdvServiceBase
	{
        #region Fields
        private static readonly string layerExceptionPolicy = "ServiceLayerExceptionPolicy";
        private static readonly bool noTranByDefault = false;
        #endregion

        #region Constructors
		/// <summary>
		/// Initializes a new instance of the SvStudAskAdvService class.
		/// </summary>
		public SvStudAskAdvService() : base()
		{
		}
		#endregion Constructors

        #region Custom Methods
        public virtual DataTable GetAllForView(System.Decimal _EdStudID)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllForView");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvStudAskAdvProvider.GetAllForView(transactionManager, _EdStudID);
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
            return list;
        }
        public virtual DataTable GetTopOneAnswer(System.Decimal _SvStudAskAdvId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetTopOneAnswer");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvStudAskAdvProvider.GetTopOneAnswer(transactionManager, _SvStudAskAdvId);
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
            return list;
        }
        public virtual DataTable GetAllQuestionsForStaff(System.Decimal _SaStfMemberId)
        {
            //langId
            //1:arabic
            //else(2):english
            #region Security check
            // throws security exception if not authorized
            SecurityContext.IsAuthorized("GetAllQuestionsForStaff");
            #endregion Security check

            #region Initialisation
            DataTable list = null;
            TransactionManager transactionManager = null;
            NetTiersProvider dataProvider = null;
            #endregion Initialisation

            try
            {
                transactionManager = ConnectionScope.ValidateOrCreateTransaction(noTranByDefault);
                dataProvider = ConnectionScope.Current.DataProvider;

                list = dataProvider.SvStudAskAdvProvider.GetAllQuestionsForStaff(transactionManager, _SaStfMemberId);
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
            return list;
        }
        public DataTable GetQuestionsForView(System.Decimal _EdStudID)
        {
            DataTable table = new DataTable();
            table.Columns.Add("QUEST_DATE");
            table.Columns.Add("QUEST_DTL");
            table.Columns.Add("NoOfReplies");
            table.Columns.Add("FULL_NAME_AR");
            table.Columns.Add("FULL_NAME_EN");
            table.Columns.Add("STF_FULL_NAME_AR");
            table.Columns.Add("STF_FULL_NAME_EN");
            table.Columns.Add("RE_DATE");
            table.Columns.Add("SV_STUD_ASK_ADV_ID");

            object[] items = new object[9];

            DataTable questionsTable = GetAllForView(_EdStudID);
            foreach (DataRow questionRow in questionsTable.Rows)
            {
                decimal _SvStudAskAdvId = decimal.Parse(questionRow["SV_STUD_ASK_ADV_ID"].ToString());

                items[0] = questionRow["QUEST_DATE"].ToString();
                items[1] = questionRow["QUEST_DTL"].ToString();
                items[2] = questionRow["NoOfReplies"].ToString();

                DataTable topOneAnswerTable = GetTopOneAnswer(_SvStudAskAdvId);
                if (topOneAnswerTable.Rows.Count > 0)
                {
                    items[3] = topOneAnswerTable.Rows[0]["FULL_NAME_AR"].ToString();
                    items[4] = topOneAnswerTable.Rows[0]["FULL_NAME_EN"].ToString();
                    items[5] = topOneAnswerTable.Rows[0]["STF_FULL_NAME_AR"].ToString();
                    items[6] = topOneAnswerTable.Rows[0]["STF_FULL_NAME_EN"].ToString();
                    items[7] = topOneAnswerTable.Rows[0]["RE_DATE"].ToString();
                }
                else
                {
                    items[3] = string.Empty;
                    items[4] = string.Empty;
                    items[5] = string.Empty;
                    items[6] = string.Empty;
                    items[7] = string.Empty;
                }

                items[8] = _SvStudAskAdvId;
                table.Rows.Add(items);
            }

            return table;
        }
        #endregion
    }//End Class

} // end namespace
