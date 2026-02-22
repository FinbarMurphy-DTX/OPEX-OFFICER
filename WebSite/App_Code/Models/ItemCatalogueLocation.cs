using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
    public enum ItemCatalogueLocationDataField
    {

        Rowid,

        ItemCode,

        StiDesc,

        StiGrp1,

        StiGrp1Stg1Grp1Desc,

        StiGrp2,

        StiGrp2Stg2Grp2Desc,

        VatCode,

        StandardPrice,

        AverageCost,

        LastCost,

        StandardCost,

        StiOnStp,

        StiStndOrdQty,

        StiStkLv,

        StiFreStk,

        StiPlNlCd,

        StiCsNlCd,

        StiCiNlCd,

        StiCvNlCd,

        StiDiscCd,

        StiStkTyp,

        StiAltItm,

        StiFifoLow,

        StiFifoHigh,

        OrderUnit,

        StoreUnit,

        PriceUnit,

        OrderPer,

        PricePer,

        StorePer,

        SizeScale,

        LastReceiptDate,

        BudgetInd,

        ItemOncost,

        GroupOncost,

        ContractCode,

        MaxIssueLv,

        MaxOrderQty,

        MaxStkLv,

        TotalIssues,

        FrozenQty,

        FrozenDate,

        InventoryDate,

        SuspenseCode,

        InventoryCode,

        AdjustmentCode,

        OncostCode,

        StiDesc2,

        LastStockTake,

        WhCode,

        WhWhseCode,

        WhWarehouseTypetypeDescription,

        StaffAllowance,

        CertificationControl,

        CertificationCode,

        CertificationName,

        SerialNumbers,

        CostFifo,

        StaffFilter,

        StaffFilterstaffFilter,

        ReviewPeriod,

        ReviewPeriodperiodCode,

        CompanyID,

        CompanyName,

        OldStockID,

        ItemGlCode,

        ItemGlNlaPrt1,

        ItemGenderFilter,

        ArchiveFlag,

        VatID,

        AbcVolume,

        AbcValue,

        AbcTransactions,

        OrderUnitID,

        StoreUnitID,

        StoreUnitDesc,

        LocationCatalogueid,

        LocationCatalogueLocationCatalogue,

        LocationCatalogueDescription,

        Chargeid,

        ChargeCode,

        ChargeCodeDescription,

        StaffLocationCatalogueid,

        Local_OPEXCost,

        Local_Description,

        Local_Groups,
    }

    public partial class ItemCatalogueLocationModel : BusinessRulesObjectModel
    {

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private ulong? _rowid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiGrp1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiGrp1Stg1Grp1Desc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiGrp2;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiGrp2Stg2Grp2Desc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _standardPrice;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _averageCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _lastCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _standardCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiOnStp;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _stiStndOrdQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _stiStkLv;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _stiFreStk;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiPlNlCd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiCsNlCd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiCiNlCd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiCvNlCd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiDiscCd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiStkTyp;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiAltItm;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _stiFifoLow;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private short? _stiFifoHigh;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _orderUnit;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _storeUnit;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _priceUnit;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _orderPer;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _pricePer;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _storePer;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sizeScale;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastReceiptDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _budgetInd;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemOncost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _groupOncost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contractCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _maxIssueLv;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _maxOrderQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _maxStkLv;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _totalIssues;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _frozenQty;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _frozenDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _inventoryDate;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _suspenseCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _inventoryCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adjustmentCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oncostCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stiDesc2;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastStockTake;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whWhseCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _whWarehouseTypetypeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _staffAllowance;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _certificationControl;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _certificationCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _certificationName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _serialNumbers;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _costFifo;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffFilter;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _staffFilterstaffFilter;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reviewPeriod;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reviewPeriodperiodCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _companyID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _companyName;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oldStockID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemGlCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemGlNlaPrt1;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _itemGenderFilter;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _archiveFlag;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vatID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _abcVolume;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _abcValue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _abcTransactions;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _orderUnitID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _storeUnitID;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _storeUnitDesc;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _locationCatalogueid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCatalogueLocationCatalogue;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _locationCatalogueDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _chargeid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chargeCode;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chargeCodeDescription;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private uint? _staffLocationCatalogueid;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _local_OPEXCost;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _local_Description;

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _local_Groups;

        public ItemCatalogueLocationModel()
        {
        }

        public ItemCatalogueLocationModel(BusinessRules r) :
                base(r)
        {
        }

        public ulong? Rowid
        {
            get
            {
                return _rowid;
            }
            set
            {
                _rowid = value;
                UpdateFieldValue("Rowid", value);
            }
        }

        public string ItemCode
        {
            get
            {
                return _itemCode;
            }
            set
            {
                _itemCode = value;
                UpdateFieldValue("ItemCode", value);
            }
        }

        public string StiDesc
        {
            get
            {
                return _stiDesc;
            }
            set
            {
                _stiDesc = value;
                UpdateFieldValue("StiDesc", value);
            }
        }

        public string StiGrp1
        {
            get
            {
                return _stiGrp1;
            }
            set
            {
                _stiGrp1 = value;
                UpdateFieldValue("StiGrp1", value);
            }
        }

        public string StiGrp1Stg1Grp1Desc
        {
            get
            {
                return _stiGrp1Stg1Grp1Desc;
            }
            set
            {
                _stiGrp1Stg1Grp1Desc = value;
                UpdateFieldValue("StiGrp1Stg1Grp1Desc", value);
            }
        }

        public string StiGrp2
        {
            get
            {
                return _stiGrp2;
            }
            set
            {
                _stiGrp2 = value;
                UpdateFieldValue("StiGrp2", value);
            }
        }

        public string StiGrp2Stg2Grp2Desc
        {
            get
            {
                return _stiGrp2Stg2Grp2Desc;
            }
            set
            {
                _stiGrp2Stg2Grp2Desc = value;
                UpdateFieldValue("StiGrp2Stg2Grp2Desc", value);
            }
        }

        public string VatCode
        {
            get
            {
                return _vatCode;
            }
            set
            {
                _vatCode = value;
                UpdateFieldValue("VatCode", value);
            }
        }

        public decimal? StandardPrice
        {
            get
            {
                return _standardPrice;
            }
            set
            {
                _standardPrice = value;
                UpdateFieldValue("StandardPrice", value);
            }
        }

        public decimal? AverageCost
        {
            get
            {
                return _averageCost;
            }
            set
            {
                _averageCost = value;
                UpdateFieldValue("AverageCost", value);
            }
        }

        public decimal? LastCost
        {
            get
            {
                return _lastCost;
            }
            set
            {
                _lastCost = value;
                UpdateFieldValue("LastCost", value);
            }
        }

        public decimal? StandardCost
        {
            get
            {
                return _standardCost;
            }
            set
            {
                _standardCost = value;
                UpdateFieldValue("StandardCost", value);
            }
        }

        public string StiOnStp
        {
            get
            {
                return _stiOnStp;
            }
            set
            {
                _stiOnStp = value;
                UpdateFieldValue("StiOnStp", value);
            }
        }

        public decimal? StiStndOrdQty
        {
            get
            {
                return _stiStndOrdQty;
            }
            set
            {
                _stiStndOrdQty = value;
                UpdateFieldValue("StiStndOrdQty", value);
            }
        }

        public decimal? StiStkLv
        {
            get
            {
                return _stiStkLv;
            }
            set
            {
                _stiStkLv = value;
                UpdateFieldValue("StiStkLv", value);
            }
        }

        public decimal? StiFreStk
        {
            get
            {
                return _stiFreStk;
            }
            set
            {
                _stiFreStk = value;
                UpdateFieldValue("StiFreStk", value);
            }
        }

        public string StiPlNlCd
        {
            get
            {
                return _stiPlNlCd;
            }
            set
            {
                _stiPlNlCd = value;
                UpdateFieldValue("StiPlNlCd", value);
            }
        }

        public string StiCsNlCd
        {
            get
            {
                return _stiCsNlCd;
            }
            set
            {
                _stiCsNlCd = value;
                UpdateFieldValue("StiCsNlCd", value);
            }
        }

        public string StiCiNlCd
        {
            get
            {
                return _stiCiNlCd;
            }
            set
            {
                _stiCiNlCd = value;
                UpdateFieldValue("StiCiNlCd", value);
            }
        }

        public string StiCvNlCd
        {
            get
            {
                return _stiCvNlCd;
            }
            set
            {
                _stiCvNlCd = value;
                UpdateFieldValue("StiCvNlCd", value);
            }
        }

        public string StiDiscCd
        {
            get
            {
                return _stiDiscCd;
            }
            set
            {
                _stiDiscCd = value;
                UpdateFieldValue("StiDiscCd", value);
            }
        }

        public string StiStkTyp
        {
            get
            {
                return _stiStkTyp;
            }
            set
            {
                _stiStkTyp = value;
                UpdateFieldValue("StiStkTyp", value);
            }
        }

        public string StiAltItm
        {
            get
            {
                return _stiAltItm;
            }
            set
            {
                _stiAltItm = value;
                UpdateFieldValue("StiAltItm", value);
            }
        }

        public short? StiFifoLow
        {
            get
            {
                return _stiFifoLow;
            }
            set
            {
                _stiFifoLow = value;
                UpdateFieldValue("StiFifoLow", value);
            }
        }

        public short? StiFifoHigh
        {
            get
            {
                return _stiFifoHigh;
            }
            set
            {
                _stiFifoHigh = value;
                UpdateFieldValue("StiFifoHigh", value);
            }
        }

        public string OrderUnit
        {
            get
            {
                return _orderUnit;
            }
            set
            {
                _orderUnit = value;
                UpdateFieldValue("OrderUnit", value);
            }
        }

        public string StoreUnit
        {
            get
            {
                return _storeUnit;
            }
            set
            {
                _storeUnit = value;
                UpdateFieldValue("StoreUnit", value);
            }
        }

        public string PriceUnit
        {
            get
            {
                return _priceUnit;
            }
            set
            {
                _priceUnit = value;
                UpdateFieldValue("PriceUnit", value);
            }
        }

        public decimal? OrderPer
        {
            get
            {
                return _orderPer;
            }
            set
            {
                _orderPer = value;
                UpdateFieldValue("OrderPer", value);
            }
        }

        public decimal? PricePer
        {
            get
            {
                return _pricePer;
            }
            set
            {
                _pricePer = value;
                UpdateFieldValue("PricePer", value);
            }
        }

        public decimal? StorePer
        {
            get
            {
                return _storePer;
            }
            set
            {
                _storePer = value;
                UpdateFieldValue("StorePer", value);
            }
        }

        public string SizeScale
        {
            get
            {
                return _sizeScale;
            }
            set
            {
                _sizeScale = value;
                UpdateFieldValue("SizeScale", value);
            }
        }

        public DateTime? LastReceiptDate
        {
            get
            {
                return _lastReceiptDate;
            }
            set
            {
                _lastReceiptDate = value;
                UpdateFieldValue("LastReceiptDate", value);
            }
        }

        public string BudgetInd
        {
            get
            {
                return _budgetInd;
            }
            set
            {
                _budgetInd = value;
                UpdateFieldValue("BudgetInd", value);
            }
        }

        public string ItemOncost
        {
            get
            {
                return _itemOncost;
            }
            set
            {
                _itemOncost = value;
                UpdateFieldValue("ItemOncost", value);
            }
        }

        public string GroupOncost
        {
            get
            {
                return _groupOncost;
            }
            set
            {
                _groupOncost = value;
                UpdateFieldValue("GroupOncost", value);
            }
        }

        public string ContractCode
        {
            get
            {
                return _contractCode;
            }
            set
            {
                _contractCode = value;
                UpdateFieldValue("ContractCode", value);
            }
        }

        public decimal? MaxIssueLv
        {
            get
            {
                return _maxIssueLv;
            }
            set
            {
                _maxIssueLv = value;
                UpdateFieldValue("MaxIssueLv", value);
            }
        }

        public decimal? MaxOrderQty
        {
            get
            {
                return _maxOrderQty;
            }
            set
            {
                _maxOrderQty = value;
                UpdateFieldValue("MaxOrderQty", value);
            }
        }

        public decimal? MaxStkLv
        {
            get
            {
                return _maxStkLv;
            }
            set
            {
                _maxStkLv = value;
                UpdateFieldValue("MaxStkLv", value);
            }
        }

        public decimal? TotalIssues
        {
            get
            {
                return _totalIssues;
            }
            set
            {
                _totalIssues = value;
                UpdateFieldValue("TotalIssues", value);
            }
        }

        public decimal? FrozenQty
        {
            get
            {
                return _frozenQty;
            }
            set
            {
                _frozenQty = value;
                UpdateFieldValue("FrozenQty", value);
            }
        }

        public DateTime? FrozenDate
        {
            get
            {
                return _frozenDate;
            }
            set
            {
                _frozenDate = value;
                UpdateFieldValue("FrozenDate", value);
            }
        }

        public DateTime? InventoryDate
        {
            get
            {
                return _inventoryDate;
            }
            set
            {
                _inventoryDate = value;
                UpdateFieldValue("InventoryDate", value);
            }
        }

        public string SuspenseCode
        {
            get
            {
                return _suspenseCode;
            }
            set
            {
                _suspenseCode = value;
                UpdateFieldValue("SuspenseCode", value);
            }
        }

        public string InventoryCode
        {
            get
            {
                return _inventoryCode;
            }
            set
            {
                _inventoryCode = value;
                UpdateFieldValue("InventoryCode", value);
            }
        }

        public string AdjustmentCode
        {
            get
            {
                return _adjustmentCode;
            }
            set
            {
                _adjustmentCode = value;
                UpdateFieldValue("AdjustmentCode", value);
            }
        }

        public string OncostCode
        {
            get
            {
                return _oncostCode;
            }
            set
            {
                _oncostCode = value;
                UpdateFieldValue("OncostCode", value);
            }
        }

        public string StiDesc2
        {
            get
            {
                return _stiDesc2;
            }
            set
            {
                _stiDesc2 = value;
                UpdateFieldValue("StiDesc2", value);
            }
        }

        public DateTime? LastStockTake
        {
            get
            {
                return _lastStockTake;
            }
            set
            {
                _lastStockTake = value;
                UpdateFieldValue("LastStockTake", value);
            }
        }

        public string WhCode
        {
            get
            {
                return _whCode;
            }
            set
            {
                _whCode = value;
                UpdateFieldValue("WhCode", value);
            }
        }

        public string WhWhseCode
        {
            get
            {
                return _whWhseCode;
            }
            set
            {
                _whWhseCode = value;
                UpdateFieldValue("WhWhseCode", value);
            }
        }

        public string WhWarehouseTypetypeDescription
        {
            get
            {
                return _whWarehouseTypetypeDescription;
            }
            set
            {
                _whWarehouseTypetypeDescription = value;
                UpdateFieldValue("WhWarehouseTypetypeDescription", value);
            }
        }

        public int? StaffAllowance
        {
            get
            {
                return _staffAllowance;
            }
            set
            {
                _staffAllowance = value;
                UpdateFieldValue("StaffAllowance", value);
            }
        }

        public string CertificationControl
        {
            get
            {
                return _certificationControl;
            }
            set
            {
                _certificationControl = value;
                UpdateFieldValue("CertificationControl", value);
            }
        }

        public int? CertificationCode
        {
            get
            {
                return _certificationCode;
            }
            set
            {
                _certificationCode = value;
                UpdateFieldValue("CertificationCode", value);
            }
        }

        public string CertificationName
        {
            get
            {
                return _certificationName;
            }
            set
            {
                _certificationName = value;
                UpdateFieldValue("CertificationName", value);
            }
        }

        public string SerialNumbers
        {
            get
            {
                return _serialNumbers;
            }
            set
            {
                _serialNumbers = value;
                UpdateFieldValue("SerialNumbers", value);
            }
        }

        public decimal? CostFifo
        {
            get
            {
                return _costFifo;
            }
            set
            {
                _costFifo = value;
                UpdateFieldValue("CostFifo", value);
            }
        }

        public string StaffFilter
        {
            get
            {
                return _staffFilter;
            }
            set
            {
                _staffFilter = value;
                UpdateFieldValue("StaffFilter", value);
            }
        }

        public string StaffFilterstaffFilter
        {
            get
            {
                return _staffFilterstaffFilter;
            }
            set
            {
                _staffFilterstaffFilter = value;
                UpdateFieldValue("StaffFilterstaffFilter", value);
            }
        }

        public string ReviewPeriod
        {
            get
            {
                return _reviewPeriod;
            }
            set
            {
                _reviewPeriod = value;
                UpdateFieldValue("ReviewPeriod", value);
            }
        }

        public string ReviewPeriodperiodCode
        {
            get
            {
                return _reviewPeriodperiodCode;
            }
            set
            {
                _reviewPeriodperiodCode = value;
                UpdateFieldValue("ReviewPeriodperiodCode", value);
            }
        }

        public uint? CompanyID
        {
            get
            {
                return _companyID;
            }
            set
            {
                _companyID = value;
                UpdateFieldValue("CompanyID", value);
            }
        }

        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                _companyName = value;
                UpdateFieldValue("CompanyName", value);
            }
        }

        public string OldStockID
        {
            get
            {
                return _oldStockID;
            }
            set
            {
                _oldStockID = value;
                UpdateFieldValue("OldStockID", value);
            }
        }

        public string ItemGlCode
        {
            get
            {
                return _itemGlCode;
            }
            set
            {
                _itemGlCode = value;
                UpdateFieldValue("ItemGlCode", value);
            }
        }

        public string ItemGlNlaPrt1
        {
            get
            {
                return _itemGlNlaPrt1;
            }
            set
            {
                _itemGlNlaPrt1 = value;
                UpdateFieldValue("ItemGlNlaPrt1", value);
            }
        }

        public string ItemGenderFilter
        {
            get
            {
                return _itemGenderFilter;
            }
            set
            {
                _itemGenderFilter = value;
                UpdateFieldValue("ItemGenderFilter", value);
            }
        }

        public string ArchiveFlag
        {
            get
            {
                return _archiveFlag;
            }
            set
            {
                _archiveFlag = value;
                UpdateFieldValue("ArchiveFlag", value);
            }
        }

        public int? VatID
        {
            get
            {
                return _vatID;
            }
            set
            {
                _vatID = value;
                UpdateFieldValue("VatID", value);
            }
        }

        public string AbcVolume
        {
            get
            {
                return _abcVolume;
            }
            set
            {
                _abcVolume = value;
                UpdateFieldValue("AbcVolume", value);
            }
        }

        public string AbcValue
        {
            get
            {
                return _abcValue;
            }
            set
            {
                _abcValue = value;
                UpdateFieldValue("AbcValue", value);
            }
        }

        public string AbcTransactions
        {
            get
            {
                return _abcTransactions;
            }
            set
            {
                _abcTransactions = value;
                UpdateFieldValue("AbcTransactions", value);
            }
        }

        public uint? OrderUnitID
        {
            get
            {
                return _orderUnitID;
            }
            set
            {
                _orderUnitID = value;
                UpdateFieldValue("OrderUnitID", value);
            }
        }

        public uint? StoreUnitID
        {
            get
            {
                return _storeUnitID;
            }
            set
            {
                _storeUnitID = value;
                UpdateFieldValue("StoreUnitID", value);
            }
        }

        public string StoreUnitDesc
        {
            get
            {
                return _storeUnitDesc;
            }
            set
            {
                _storeUnitDesc = value;
                UpdateFieldValue("StoreUnitDesc", value);
            }
        }

        public uint? LocationCatalogueid
        {
            get
            {
                return _locationCatalogueid;
            }
            set
            {
                _locationCatalogueid = value;
                UpdateFieldValue("LocationCatalogueid", value);
            }
        }

        public string LocationCatalogueLocationCatalogue
        {
            get
            {
                return _locationCatalogueLocationCatalogue;
            }
            set
            {
                _locationCatalogueLocationCatalogue = value;
                UpdateFieldValue("LocationCatalogueLocationCatalogue", value);
            }
        }

        public string LocationCatalogueDescription
        {
            get
            {
                return _locationCatalogueDescription;
            }
            set
            {
                _locationCatalogueDescription = value;
                UpdateFieldValue("LocationCatalogueDescription", value);
            }
        }

        public uint? Chargeid
        {
            get
            {
                return _chargeid;
            }
            set
            {
                _chargeid = value;
                UpdateFieldValue("Chargeid", value);
            }
        }

        public string ChargeCode
        {
            get
            {
                return _chargeCode;
            }
            set
            {
                _chargeCode = value;
                UpdateFieldValue("ChargeCode", value);
            }
        }

        public string ChargeCodeDescription
        {
            get
            {
                return _chargeCodeDescription;
            }
            set
            {
                _chargeCodeDescription = value;
                UpdateFieldValue("ChargeCodeDescription", value);
            }
        }

        public uint? StaffLocationCatalogueid
        {
            get
            {
                return _staffLocationCatalogueid;
            }
            set
            {
                _staffLocationCatalogueid = value;
                UpdateFieldValue("StaffLocationCatalogueid", value);
            }
        }

        public decimal? Local_OPEXCost
        {
            get
            {
                return _local_OPEXCost;
            }
            set
            {
                _local_OPEXCost = value;
                UpdateFieldValue("Local_OPEXCost", value);
            }
        }

        public string Local_Description
        {
            get
            {
                return _local_Description;
            }
            set
            {
                _local_Description = value;
                UpdateFieldValue("Local_Description", value);
            }
        }

        public string Local_Groups
        {
            get
            {
                return _local_Groups;
            }
            set
            {
                _local_Groups = value;
                UpdateFieldValue("Local_Groups", value);
            }
        }

        public FieldValue this[ItemCatalogueLocationDataField field]
        {
            get
            {
                return this[field.ToString()];
            }
        }
    }
}
