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
	/// This class is the base class for any <see cref="GsCountryNodeProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class GsCountryNodeProviderBase : GsCountryNodeProviderBaseCore
	{

        #region Custom Methods

        public abstract string GetCountryNodePath(TransactionManager transactionManager, System.Decimal _gsCountryNodeId, System.Decimal _Lang);
        public abstract void SetIsLocalChilds(TransactionManager transactionManager, System.Decimal isLocal, System.Decimal parentID);
        public abstract void SetIsLocal(TransactionManager transactionManager, System.Decimal isLocal, System.Decimal NodeID);
        public abstract TList<GsCountryNode> SelectByGsCodeCNodeNatureforignkeys(TransactionManager transactionManager, System.Decimal gscodecnodenatureid);
        public abstract TList<GsCountryNode> SelectByGsCountryNodeforignkeys(TransactionManager transactionManager, System.Decimal nodeparentid);
        public abstract TList<GsCountryNode> getDistrictsonCurrentCountry(TransactionManager transactionManager);
        public abstract TList<GsCountryNode> GetAllCountries(TransactionManager transactionManager);
        #endregion

	} // end class
} // end namespace
