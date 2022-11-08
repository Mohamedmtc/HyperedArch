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
	/// This class is the base class for any <see cref="SvPollHdrProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SvPollHdrProviderBase : SvPollHdrProviderBaseCore
    {
        #region Custom Methods

        public bool DeleteAllRelatedData(System.Decimal _svPollHdrId)
        {
            return DeleteAllRelatedData(null, _svPollHdrId);
        }

        public abstract bool DeleteAllRelatedData(TransactionManager transactionManager, System.Decimal _svPollHdrId);

        public abstract decimal GetLastOne(TransactionManager transactionManager);

        public DataTable GetForView(TransactionManager transactionManager, System.Decimal _SeUserId)
        {
            return GetForView(transactionManager, _SeUserId, 0);
        }

        public abstract DataTable GetForView(TransactionManager transactionManager, System.Decimal _SeUserId, decimal studStaffFlg);

        public abstract DataTable GetForStudView(TransactionManager transactionManager,System.Decimal EdStudId);

        public abstract DataTable GetForStaffView(TransactionManager transactionManager, System.Decimal StaffId, System.Decimal AcadYearId, System.Decimal SemesterId);

        public abstract DataTable GetStudOptionForPoll(TransactionManager transactionManager, System.Decimal _EdStudId, System.Decimal _SvPollHdrId);

        public abstract DataTable GetStaffOptionForPoll(TransactionManager transactionManager, System.Decimal StfMemberId, System.Decimal _SvPollHdrId);

        public abstract DataTable GetUserPoll(TransactionManager transactionManager, System.Decimal _SeUserId, System.Decimal _SvPollHdrId);

        #endregion
    } // end class
} // end namespace
