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
	/// This class is the base class for any <see cref="SeUserAccntProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SeUserAccntProviderBase : SeUserAccntProviderBaseCore
	{
        #region Custom Methods

        public abstract decimal insertDateTimeforUserAccunt(TransactionManager transactionManager, UMIS_VER2.BusinessLyer.SeUserAccnt objSeUserAccnt);
        public abstract TList<SeUserAccnt> GetSeUserAccountIdByUserTypeAndUserTableId(TransactionManager transactionManager, System.Decimal _UserType, System.Decimal _SeUserId, System.Decimal _UserTableId);
        
        #endregion
	} // end class
} // end namespace
