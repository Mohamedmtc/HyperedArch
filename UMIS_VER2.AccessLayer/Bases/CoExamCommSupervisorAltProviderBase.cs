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
	/// This class is the base class for any <see cref="CoExamCommSupervisorAltProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class CoExamCommSupervisorAltProviderBase : CoExamCommSupervisorAltProviderBaseCore
	{
        #region Custom Methods

        public abstract DataTable SearchCoExamSupAltMembers(TransactionManager transactionManager, System.DateTime? _Date, System.DateTime? _FromTime
            , System.DateTime? _ToTime, System.Decimal? _MemberFlg, System.String _MemberName, System.Decimal _Lang,System.Decimal _CoControlId);

        #endregion
	} // end class
} // end namespace
