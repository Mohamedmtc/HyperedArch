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
    /// This class is the base class for any <see cref="FeeStudVoucherItemProviderBase"/> implementation.
    /// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
    ///</summary>
    public abstract partial class FeeStudVoucherItemProviderBase : FeeStudVoucherItemProviderBaseCore
    {
        #region Custom Methods

        public abstract DataTable GetStudVoucherItem(TransactionManager transactionManager,
            System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId);


        public abstract DataTable GetStudVoucherItemBalance(TransactionManager transactionManager,
            System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
            System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId);

        public abstract DataTable LoadStudVoucherItem(TransactionManager transactionManager,
            System.Decimal _FeeStudVoucherID);
        
        public abstract DataTable GetStuditemsDiscound(TransactionManager transactionManager,
       System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
       System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId,System.Decimal _FeeCdeDiscCatId);


        public abstract DataTable GetStuditemsDiscoundAll(TransactionManager transactionManager,
     System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
     System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _SelectFeesFlag, System.Decimal _FeeCodeTypeId, System.Decimal _GsCodeCurrencyId, System.Decimal _FeeStudDisc, System.Decimal _FeeCdeDiscCatId);
        
        public abstract DataTable LoadStuditemsDiscound(TransactionManager transactionManager,
  System.Decimal _FeeStudDiscId);

        public abstract DataTable GetHistoricalFees(TransactionManager transactionManager,
    System.Decimal _EdStudId, System.Decimal _FacEntityMainId, System.Decimal _AsFacultyInfoId,
    System.Decimal _EdAcadYearId, System.Decimal _CurrEdCodeSemId, System.Decimal _FeeCodeTypeId);

        public abstract decimal GetStudentPayed(System.Decimal FeeStudFeeItemId);
        #endregion

    } // end class
} // end namespace
