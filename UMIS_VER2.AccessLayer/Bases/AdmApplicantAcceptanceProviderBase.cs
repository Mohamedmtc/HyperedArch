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
	/// This class is the base class for any <see cref="AdmApplicantAcceptanceProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class AdmApplicantAcceptanceProviderBase : AdmApplicantAcceptanceProviderBaseCore
	{
        public abstract int ApplyAcceptanceCriteria(TransactionManager transactionManager, decimal _admApplicantId, decimal _edAcadYearId, decimal _edCodeSemesterId);

        public abstract DataTable GetAppAcceptanceCriteria(TransactionManager transactionManager, System.Decimal _AdmAppRegHistoryId, System.Decimal _CategoryType, System.Decimal _OrientationFlg);

        public abstract DataTable GetApplicantAcceptanceData(TransactionManager transactionManager, System.Decimal _AdmApplicantId, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId);

	} // end class
} // end namespace
