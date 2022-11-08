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
	/// This class is the base class for any <see cref="SpoSponsorProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoSponsorProviderBase : SpoSponsorProviderBaseCore
	{

        public abstract DataTable SearchSponser(TransactionManager transactionManager, System.String _SponserCode, 
            System.String _NameEn, System.String _NameAr, System.Decimal _SponserTypeId, System.Decimal _PageIndex, 
            System.Decimal _PageSize,bool? isActFlg);
       
	} // end class
} // end namespace
