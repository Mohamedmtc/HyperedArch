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
	/// This class is the base class for any <see cref="SpoStudFeeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class SpoStudFeeItemProviderBase : SpoStudFeeItemProviderBaseCore
	{
        public abstract DataTable GetStudentSponsorItems(TransactionManager transactionManager, System.Decimal studentid, System.Decimal EdAcadYearId, System.Decimal EdCodeSemesterId, System.Decimal GsCodeCurrencyId, int Lang);
	} // end class
} // end namespace
