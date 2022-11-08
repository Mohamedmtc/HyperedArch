#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using UMIS_VER2.BusinessLyer;
using UMIS_VER2.AccessLayer;

#endregion

namespace UMIS_VER2.AccessLayer.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="AdmAppFeesProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmAppFeesProviderBase : AdmAppFeesProviderBaseCore
	{
        #region Custom Methods
        public abstract DataTable AdmAppFees_GetAllApplicants(TransactionManager transactionManager, System.Decimal _AdmOpenAcadSemesterId, System.Decimal _AsFacultyInfoId, string _AdmAppCode, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _PayFlg);
      // added by mmq at 24-07-2016
        public abstract DataTable AdmAppFees_GetAllApplicants(TransactionManager transactionManager, System.Decimal _AdmOpenAcadSemesterId, System.Decimal _AsFacultyInfoId, string _AdmAppCode, System.DateTime? _DateFrom, System.DateTime? _DateTo, System.Decimal _PayFlg, System.DateTime? _RegDateFrom, System.DateTime? _RegDateTo, System.Decimal? _ReciptNum);
        public abstract void UpdateAdmAppFees(decimal EdAcadYearId, decimal EdCodeSemesterId, decimal ApplicantID);
        public abstract void DeleteAdmAppFees(decimal AppExamID);
        public abstract int ADM_APP_FEES_Cancel_FOR_ADM_APP_PREF(TransactionManager transactionManager, decimal AdmApplicantID, decimal AsFacultyInfoId);//added by hoda at 14 / 9 / 2022 for merit task 19067
        #endregion
    } // end class
} // end namespace
