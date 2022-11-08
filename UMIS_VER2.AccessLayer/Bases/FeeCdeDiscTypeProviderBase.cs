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
	/// This class is the base class for any <see cref="FeeCdeDiscTypeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCdeDiscTypeProviderBase : FeeCdeDiscTypeProviderBaseCore
	{
        #region Custom Methods
        public abstract TList<FeeCdeDiscType> GetStudValidCodes(TransactionManager transactionManager, System.Decimal _EdStudId);
        public abstract TList<FeeCdeDiscType> GetByFeeCdeDiscCatIdAsfacultyInfoId(TransactionManager transactionManager, System.Decimal _FeeCdeDiscCatId, System.Decimal _AsfacultyInfoId);


        #endregion
	} // end class
} // end namespace
