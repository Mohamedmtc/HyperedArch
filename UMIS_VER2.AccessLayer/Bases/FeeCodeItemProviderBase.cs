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
	/// This class is the base class for any <see cref="FeeCodeItemProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class FeeCodeItemProviderBase : FeeCodeItemProviderBaseCore
    {
        #region Custom Methods
        public abstract TList<FeeCodeItem> GetByFeeCodeTypeId_DegreeType(TransactionManager transactionManager, decimal _FeeCodeTypeId, decimal _AsCodeDegreeID, decimal _AsDegreeClassID, int start, int pageLength, out int count);
        public TList<FeeCodeItem> GetByFeeCodeTypeId_DegreeType(TransactionManager transactionManager, decimal _FeeCodeTypeId, decimal _AsCodeDegreeID ,decimal _AsDegreeClassID )
        {
            int count = -1;
            return GetByFeeCodeTypeId_DegreeType(transactionManager, _FeeCodeTypeId, _AsCodeDegreeID,_AsDegreeClassID , 0, int.MaxValue, out count);
        }
        #endregion
        /*
        #region

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 key.
        ///		FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 Description: 
        /// </summary>
        /// <param name="_pgFlag">مؤشر بند مصروف دراسات عليا</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
        public TList<FeeCodeItem> GetByPgFlag(System.Decimal _pgFlag)
        {
            int count = -1;
            return GetByPgFlag(_pgFlag, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 key.
        ///		FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_pgFlag">مؤشر بند مصروف دراسات عليا</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
        /// <remarks></remarks>
        public TList<FeeCodeItem> GetByPgFlag(TransactionManager transactionManager, System.Decimal _pgFlag)
        {
            int count = -1;
            return GetByPgFlag(transactionManager, _pgFlag, 0, int.MaxValue, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 key.
        ///		FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_pgFlag">مؤشر بند مصروف دراسات عليا</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        ///  <param name="pageLength">Number of rows to return.</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
        public TList<FeeCodeItem> GetByPgFlag(TransactionManager transactionManager, System.Decimal _pgFlag, int start, int pageLength)
        {
            int count = -1;
            return GetByPgFlag(transactionManager, _pgFlag, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 key.
        ///		fkFeeCodeItemFeeCodeType1 Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_pgFlag">مؤشر بند مصروف دراسات عليا</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
        public TList<FeeCodeItem> GetByPgFlag(System.Decimal _pgFlag, int start, int pageLength)
        {
            int count = -1;
            return GetByPgFlag(null, _pgFlag, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 key.
        ///		fkFeeCodeItemFeeCodeType1 Description: 
        /// </summary>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="_pgFlag">مؤشر بند مصروف دراسات عليا</param>
        /// <param name="count">out parameter to get total records for query</param>
        /// <remarks></remarks>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
        public TList<FeeCodeItem> GetByPgFlag(System.Decimal _pgFlag, int start, int pageLength, out int count)
        {
            return GetByPgFlag(null, _pgFlag, start, pageLength, out count);
        }

        /// <summary>
        /// 	Gets rows from the datasource based on the FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 key.
        ///		FK_FEE_CODE_ITEM_FEE_CODE_TYPE1 Description: 
        /// </summary>
        /// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
        /// <param name="_pgFlag">مؤشر بند مصروف دراسات عليا</param>
        /// <param name="start">Row number at which to start reading, the first row is 0.</param>
        /// <param name="pageLength">Number of rows to return.</param>
        /// <param name="count">The total number of records.</param>
        /// <returns>Returns a typed collection of UMIS_VER2.BusinessLyer.FeeCodeItem objects.</returns>
        public abstract TList<FeeCodeItem> GetByPgFlag(TransactionManager transactionManager, System.Decimal _pgFlag, int start, int pageLength, out int count);
		
        #endregion
        */


    } // end class
} // end namespace
