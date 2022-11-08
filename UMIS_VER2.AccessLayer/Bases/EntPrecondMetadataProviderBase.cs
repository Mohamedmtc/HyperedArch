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
	/// This class is the base class for any <see cref="EntPrecondMetadataProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class EntPrecondMetadataProviderBase : EntPrecondMetadataProviderBaseCore
	{

        //-- added by maha 2-8-2021 ---task 17060--//
        public abstract TList<EntPrecondMetadata> GetByEntCodeEntityTypeId_StudyMethodID(TransactionManager transactionManager,decimal EntCodeEntityTypeId, decimal EntityMainID) ;

	} // end class
} // end namespace
