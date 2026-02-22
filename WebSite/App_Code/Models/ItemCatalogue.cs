using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using DatatecnixOfficerII.Data;

namespace DatatecnixOfficerII.Models
{
	public partial class ItemCatalogueModel : BusinessRulesObjectModel
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
        
        public ItemCatalogueModel()
        {
        }
        
        public ItemCatalogueModel(BusinessRules r) : 
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
    }
    
    public partial class ItemCatalogue : ItemCatalogueModel
    {
        
        public static List<DatatecnixOfficerII.Models.ItemCatalogue> Select(string filter, string sort, string dataView, params System.Object[] parameters)
        {
            return new ItemCatalogueFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<DatatecnixOfficerII.Models.ItemCatalogue> Select(string filter, string sort, params System.Object[] parameters)
        {
            return new ItemCatalogueFactory().Select(filter, sort, ItemCatalogueFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<DatatecnixOfficerII.Models.ItemCatalogue> Select(string filter, params System.Object[] parameters)
        {
            return new ItemCatalogueFactory().Select(filter, null, ItemCatalogueFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static DatatecnixOfficerII.Models.ItemCatalogue SelectSingle(string filter, params System.Object[] parameters)
        {
            return new ItemCatalogueFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static DatatecnixOfficerII.Models.ItemCatalogue SelectSingle(ulong? rowid)
        {
            return new ItemCatalogueFactory().SelectSingle(rowid);
        }
        
        public int Insert()
        {
            return new ItemCatalogueFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ItemCatalogueFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ItemCatalogueFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("Rowid: {0}", this.Rowid);
        }
    }
    
    public partial class ItemCatalogueFactory
    {
        
        public ItemCatalogueFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ItemCatalogue");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ItemCatalogue");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ItemCatalogue");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ItemCatalogue");
            }
        }
        
        public static ItemCatalogueFactory Create()
        {
            return new ItemCatalogueFactory();
        }
        
        public List<DatatecnixOfficerII.Models.ItemCatalogue> Select(DatatecnixOfficerII.Models.ItemCatalogue qbe)
        {
            FieldValue[] values = CreateFieldValues(qbe, qbe);
            return Select(String.Empty, new BusinessObjectParameters(values));
        }
        
        public List<DatatecnixOfficerII.Models.ItemCatalogue> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public List<DatatecnixOfficerII.Models.ItemCatalogue> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<DatatecnixOfficerII.Models.ItemCatalogue> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            request.MetadataFilter = new string[] {
                    "fields"};
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ItemCatalogue", dataView, request);
            return page.ToList<DatatecnixOfficerII.Models.ItemCatalogue>();
        }
        
        public DatatecnixOfficerII.Models.ItemCatalogue SelectSingle(ulong? rowid)
        {
            return SelectSingle("Rowid=@p0", new BusinessObjectParameters(rowid));
        }
        
        public DatatecnixOfficerII.Models.ItemCatalogue SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<DatatecnixOfficerII.Models.ItemCatalogue> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(DatatecnixOfficerII.Models.ItemCatalogue theItemCatalogue, DatatecnixOfficerII.Models.ItemCatalogue original_ItemCatalogue)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("Rowid", original_ItemCatalogue.Rowid, theItemCatalogue.Rowid, true));
            values.Add(new FieldValue("ItemCode", original_ItemCatalogue.ItemCode, theItemCatalogue.ItemCode));
            values.Add(new FieldValue("StiDesc", original_ItemCatalogue.StiDesc, theItemCatalogue.StiDesc));
            values.Add(new FieldValue("StiGrp1", original_ItemCatalogue.StiGrp1, theItemCatalogue.StiGrp1));
            values.Add(new FieldValue("StiGrp1Stg1Grp1Desc", original_ItemCatalogue.StiGrp1Stg1Grp1Desc, theItemCatalogue.StiGrp1Stg1Grp1Desc, true));
            values.Add(new FieldValue("StiGrp2", original_ItemCatalogue.StiGrp2, theItemCatalogue.StiGrp2));
            values.Add(new FieldValue("StiGrp2Stg2Grp2Desc", original_ItemCatalogue.StiGrp2Stg2Grp2Desc, theItemCatalogue.StiGrp2Stg2Grp2Desc, true));
            values.Add(new FieldValue("VatCode", original_ItemCatalogue.VatCode, theItemCatalogue.VatCode));
            values.Add(new FieldValue("StandardPrice", original_ItemCatalogue.StandardPrice, theItemCatalogue.StandardPrice));
            values.Add(new FieldValue("AverageCost", original_ItemCatalogue.AverageCost, theItemCatalogue.AverageCost));
            values.Add(new FieldValue("LastCost", original_ItemCatalogue.LastCost, theItemCatalogue.LastCost));
            values.Add(new FieldValue("StandardCost", original_ItemCatalogue.StandardCost, theItemCatalogue.StandardCost));
            values.Add(new FieldValue("StiOnStp", original_ItemCatalogue.StiOnStp, theItemCatalogue.StiOnStp));
            values.Add(new FieldValue("StiStndOrdQty", original_ItemCatalogue.StiStndOrdQty, theItemCatalogue.StiStndOrdQty));
            values.Add(new FieldValue("StiStkLv", original_ItemCatalogue.StiStkLv, theItemCatalogue.StiStkLv));
            values.Add(new FieldValue("StiFreStk", original_ItemCatalogue.StiFreStk, theItemCatalogue.StiFreStk));
            values.Add(new FieldValue("StiPlNlCd", original_ItemCatalogue.StiPlNlCd, theItemCatalogue.StiPlNlCd));
            values.Add(new FieldValue("StiCsNlCd", original_ItemCatalogue.StiCsNlCd, theItemCatalogue.StiCsNlCd));
            values.Add(new FieldValue("StiCiNlCd", original_ItemCatalogue.StiCiNlCd, theItemCatalogue.StiCiNlCd));
            values.Add(new FieldValue("StiCvNlCd", original_ItemCatalogue.StiCvNlCd, theItemCatalogue.StiCvNlCd));
            values.Add(new FieldValue("StiDiscCd", original_ItemCatalogue.StiDiscCd, theItemCatalogue.StiDiscCd));
            values.Add(new FieldValue("StiStkTyp", original_ItemCatalogue.StiStkTyp, theItemCatalogue.StiStkTyp));
            values.Add(new FieldValue("StiAltItm", original_ItemCatalogue.StiAltItm, theItemCatalogue.StiAltItm));
            values.Add(new FieldValue("StiFifoLow", original_ItemCatalogue.StiFifoLow, theItemCatalogue.StiFifoLow));
            values.Add(new FieldValue("StiFifoHigh", original_ItemCatalogue.StiFifoHigh, theItemCatalogue.StiFifoHigh));
            values.Add(new FieldValue("OrderUnit", original_ItemCatalogue.OrderUnit, theItemCatalogue.OrderUnit));
            values.Add(new FieldValue("StoreUnit", original_ItemCatalogue.StoreUnit, theItemCatalogue.StoreUnit));
            values.Add(new FieldValue("PriceUnit", original_ItemCatalogue.PriceUnit, theItemCatalogue.PriceUnit));
            values.Add(new FieldValue("OrderPer", original_ItemCatalogue.OrderPer, theItemCatalogue.OrderPer));
            values.Add(new FieldValue("PricePer", original_ItemCatalogue.PricePer, theItemCatalogue.PricePer));
            values.Add(new FieldValue("StorePer", original_ItemCatalogue.StorePer, theItemCatalogue.StorePer));
            values.Add(new FieldValue("SizeScale", original_ItemCatalogue.SizeScale, theItemCatalogue.SizeScale));
            values.Add(new FieldValue("LastReceiptDate", original_ItemCatalogue.LastReceiptDate, theItemCatalogue.LastReceiptDate));
            values.Add(new FieldValue("BudgetInd", original_ItemCatalogue.BudgetInd, theItemCatalogue.BudgetInd));
            values.Add(new FieldValue("ItemOncost", original_ItemCatalogue.ItemOncost, theItemCatalogue.ItemOncost));
            values.Add(new FieldValue("GroupOncost", original_ItemCatalogue.GroupOncost, theItemCatalogue.GroupOncost));
            values.Add(new FieldValue("ContractCode", original_ItemCatalogue.ContractCode, theItemCatalogue.ContractCode));
            values.Add(new FieldValue("MaxIssueLv", original_ItemCatalogue.MaxIssueLv, theItemCatalogue.MaxIssueLv));
            values.Add(new FieldValue("MaxOrderQty", original_ItemCatalogue.MaxOrderQty, theItemCatalogue.MaxOrderQty));
            values.Add(new FieldValue("MaxStkLv", original_ItemCatalogue.MaxStkLv, theItemCatalogue.MaxStkLv));
            values.Add(new FieldValue("TotalIssues", original_ItemCatalogue.TotalIssues, theItemCatalogue.TotalIssues));
            values.Add(new FieldValue("FrozenQty", original_ItemCatalogue.FrozenQty, theItemCatalogue.FrozenQty));
            values.Add(new FieldValue("FrozenDate", original_ItemCatalogue.FrozenDate, theItemCatalogue.FrozenDate));
            values.Add(new FieldValue("InventoryDate", original_ItemCatalogue.InventoryDate, theItemCatalogue.InventoryDate));
            values.Add(new FieldValue("SuspenseCode", original_ItemCatalogue.SuspenseCode, theItemCatalogue.SuspenseCode));
            values.Add(new FieldValue("InventoryCode", original_ItemCatalogue.InventoryCode, theItemCatalogue.InventoryCode));
            values.Add(new FieldValue("AdjustmentCode", original_ItemCatalogue.AdjustmentCode, theItemCatalogue.AdjustmentCode));
            values.Add(new FieldValue("OncostCode", original_ItemCatalogue.OncostCode, theItemCatalogue.OncostCode));
            values.Add(new FieldValue("StiDesc2", original_ItemCatalogue.StiDesc2, theItemCatalogue.StiDesc2));
            values.Add(new FieldValue("LastStockTake", original_ItemCatalogue.LastStockTake, theItemCatalogue.LastStockTake));
            values.Add(new FieldValue("WhCode", original_ItemCatalogue.WhCode, theItemCatalogue.WhCode));
            values.Add(new FieldValue("WhWhseCode", original_ItemCatalogue.WhWhseCode, theItemCatalogue.WhWhseCode, true));
            values.Add(new FieldValue("WhWarehouseTypetypeDescription", original_ItemCatalogue.WhWarehouseTypetypeDescription, theItemCatalogue.WhWarehouseTypetypeDescription, true));
            values.Add(new FieldValue("StaffAllowance", original_ItemCatalogue.StaffAllowance, theItemCatalogue.StaffAllowance));
            values.Add(new FieldValue("CertificationControl", original_ItemCatalogue.CertificationControl, theItemCatalogue.CertificationControl));
            values.Add(new FieldValue("CertificationCode", original_ItemCatalogue.CertificationCode, theItemCatalogue.CertificationCode));
            values.Add(new FieldValue("CertificationName", original_ItemCatalogue.CertificationName, theItemCatalogue.CertificationName, true));
            values.Add(new FieldValue("SerialNumbers", original_ItemCatalogue.SerialNumbers, theItemCatalogue.SerialNumbers));
            values.Add(new FieldValue("CostFifo", original_ItemCatalogue.CostFifo, theItemCatalogue.CostFifo));
            values.Add(new FieldValue("StaffFilter", original_ItemCatalogue.StaffFilter, theItemCatalogue.StaffFilter));
            values.Add(new FieldValue("StaffFilterstaffFilter", original_ItemCatalogue.StaffFilterstaffFilter, theItemCatalogue.StaffFilterstaffFilter, true));
            values.Add(new FieldValue("ReviewPeriod", original_ItemCatalogue.ReviewPeriod, theItemCatalogue.ReviewPeriod));
            values.Add(new FieldValue("ReviewPeriodperiodCode", original_ItemCatalogue.ReviewPeriodperiodCode, theItemCatalogue.ReviewPeriodperiodCode, true));
            values.Add(new FieldValue("CompanyID", original_ItemCatalogue.CompanyID, theItemCatalogue.CompanyID));
            values.Add(new FieldValue("CompanyName", original_ItemCatalogue.CompanyName, theItemCatalogue.CompanyName, true));
            values.Add(new FieldValue("OldStockID", original_ItemCatalogue.OldStockID, theItemCatalogue.OldStockID));
            values.Add(new FieldValue("ItemGlCode", original_ItemCatalogue.ItemGlCode, theItemCatalogue.ItemGlCode));
            values.Add(new FieldValue("ItemGlNlaPrt1", original_ItemCatalogue.ItemGlNlaPrt1, theItemCatalogue.ItemGlNlaPrt1, true));
            values.Add(new FieldValue("ItemGenderFilter", original_ItemCatalogue.ItemGenderFilter, theItemCatalogue.ItemGenderFilter));
            values.Add(new FieldValue("ArchiveFlag", original_ItemCatalogue.ArchiveFlag, theItemCatalogue.ArchiveFlag));
            values.Add(new FieldValue("VatID", original_ItemCatalogue.VatID, theItemCatalogue.VatID));
            values.Add(new FieldValue("AbcVolume", original_ItemCatalogue.AbcVolume, theItemCatalogue.AbcVolume));
            values.Add(new FieldValue("AbcValue", original_ItemCatalogue.AbcValue, theItemCatalogue.AbcValue));
            values.Add(new FieldValue("AbcTransactions", original_ItemCatalogue.AbcTransactions, theItemCatalogue.AbcTransactions));
            values.Add(new FieldValue("OrderUnitID", original_ItemCatalogue.OrderUnitID, theItemCatalogue.OrderUnitID));
            values.Add(new FieldValue("StoreUnitID", original_ItemCatalogue.StoreUnitID, theItemCatalogue.StoreUnitID));
            values.Add(new FieldValue("StoreUnitDesc", original_ItemCatalogue.StoreUnitDesc, theItemCatalogue.StoreUnitDesc, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(DatatecnixOfficerII.Models.ItemCatalogue theItemCatalogue, DatatecnixOfficerII.Models.ItemCatalogue original_ItemCatalogue, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ItemCatalogue";
            args.View = dataView;
            args.Values = CreateFieldValues(theItemCatalogue, original_ItemCatalogue);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ItemCatalogue", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theItemCatalogue);
            return result.RowsAffected;
        }
        
        public virtual int Update(DatatecnixOfficerII.Models.ItemCatalogue theItemCatalogue, DatatecnixOfficerII.Models.ItemCatalogue original_ItemCatalogue)
        {
            return ExecuteAction(theItemCatalogue, original_ItemCatalogue, "Edit", "Update", UpdateView);
        }
        
        public virtual int Update(DatatecnixOfficerII.Models.ItemCatalogue theItemCatalogue)
        {
            return Update(theItemCatalogue, SelectSingle(theItemCatalogue.Rowid));
        }
        
        public virtual int Insert(DatatecnixOfficerII.Models.ItemCatalogue theItemCatalogue)
        {
            return ExecuteAction(theItemCatalogue, new ItemCatalogue(), "New", "Insert", InsertView);
        }
        
        public virtual int Delete(DatatecnixOfficerII.Models.ItemCatalogue theItemCatalogue)
        {
            return ExecuteAction(theItemCatalogue, theItemCatalogue, "Select", "Delete", DeleteView);
        }
    }
}
