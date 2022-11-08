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
	/// This class is the base class for any <see cref="SeUserProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserProviderBase : SeUserProviderBaseCore
	{
        #region Custom Methods

        public DataTable GetUserPages(System.Decimal _SeUserID)
        {
            return GetUserPages(null, _SeUserID);
        }

        //public abstract decimal InsertGetID(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUser entity);

        public abstract DataTable GetUserPages(TransactionManager transactionManager, System.Decimal _SeUserID);

        public abstract DataTable GetUserAccounts(TransactionManager transactionManager,System.Decimal _SeUserId);
        public abstract DataTable GetSystemUsers(TransactionManager transactionManager, System.String UserNameEn, string UserNameAr, string AdUserName, decimal SeCodeUserTypeId, decimal SeCodeUserPlaceId, decimal SeCodeUserJobId, decimal PageIndex, decimal PageSize, decimal? ASFACULTYINFOID,decimal? SysemUserStatus);

        public abstract DataTable GetByUNandPWD(TransactionManager transactionManager, System.String _UserName, System.String _Password);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionManager"></param>
        /// <param name="IsActive"></param>
        /// <returns></returns>
        public abstract DataTable GetUsersByStatus(TransactionManager transactionManager, System.Decimal IsActive);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionManager"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public abstract DataTable GetAccountsByUserID(TransactionManager transactionManager, System.Decimal UserID);


        #endregion
	} // end class
} // end namespace
