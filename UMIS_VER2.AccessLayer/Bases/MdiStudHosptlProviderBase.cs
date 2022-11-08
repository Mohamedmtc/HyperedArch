﻿#region Using directives

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
	/// This class is the base class for any <see cref="MdiStudHosptlProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MdiStudHosptlProviderBase : MdiStudHosptlProviderBaseCore
	{
        public abstract DataTable SearchStudHospitals(TransactionManager transactionManager, System.Decimal _AsFacultyInfoID, System.Decimal _EdAcadYearId, System.Decimal _EdCodeSemesterId, System.String _StudCode, System.Decimal _ObservFlg, string _FromDt, string _ToDt);
	} // end class
} // end namespace
