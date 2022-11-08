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
	/// This class is the base class for any <see cref="SvStudAskAdvProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvStudAskAdvProviderBase : SvStudAskAdvProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable GetAllForView(TransactionManager transactionManager, System.Decimal _EdStudID);

        public abstract DataTable GetTopOneAnswer(TransactionManager transactionManager, System.Decimal _SvStudAskAdvId);

        public abstract DataTable GetAllQuestionsForStaff(TransactionManager transactionManager, System.Decimal _SaStfMemberId);

        #endregion
	} // end class
} // end namespace
