namespace IWSProject.Models
{
    using System;
    using System.ComponentModel;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "iws")]
    public partial class IWSDataContext : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void InsertAccount(Account instance);
        partial void UpdateAccount(Account instance);
        partial void DeleteAccount(Account instance);
        partial void InsertVendorInvoice(VendorInvoice instance);
        partial void UpdateVendorInvoice(VendorInvoice instance);
        partial void DeleteVendorInvoice(VendorInvoice instance);
        partial void InsertArticle(Article instance);
        partial void UpdateArticle(Article instance);
        partial void DeleteArticle(Article instance);
        partial void InsertAspNetRole(AspNetRole instance);
        partial void UpdateAspNetRole(AspNetRole instance);
        partial void DeleteAspNetRole(AspNetRole instance);
        partial void InsertAspNetUserClaim(AspNetUserClaim instance);
        partial void UpdateAspNetUserClaim(AspNetUserClaim instance);
        partial void DeleteAspNetUserClaim(AspNetUserClaim instance);
        partial void InsertAspNetUserLogin(AspNetUserLogin instance);
        partial void UpdateAspNetUserLogin(AspNetUserLogin instance);
        partial void DeleteAspNetUserLogin(AspNetUserLogin instance);
        partial void InsertAspNetUserRole(AspNetUserRole instance);
        partial void UpdateAspNetUserRole(AspNetUserRole instance);
        partial void DeleteAspNetUserRole(AspNetUserRole instance);
        partial void InsertAspNetUser(AspNetUser instance);
        partial void UpdateAspNetUser(AspNetUser instance);
        partial void DeleteAspNetUser(AspNetUser instance);
        partial void InsertBank(Bank instance);
        partial void UpdateBank(Bank instance);
        partial void DeleteBank(Bank instance);
        partial void InsertBankAccount(BankAccount instance);
        partial void UpdateBankAccount(BankAccount instance);
        partial void DeleteBankAccount(BankAccount instance);
        partial void InsertBankStatement(BankStatement instance);
        partial void UpdateBankStatement(BankStatement instance);
        partial void DeleteBankStatement(BankStatement instance);
        partial void InsertBillOfDelivery(BillOfDelivery instance);
        partial void UpdateBillOfDelivery(BillOfDelivery instance);
        partial void DeleteBillOfDelivery(BillOfDelivery instance);
        partial void InsertCategory(Category instance);
        partial void UpdateCategory(Category instance);
        partial void DeleteCategory(Category instance);
        partial void InsertCompany(Company instance);
        partial void UpdateCompany(Company instance);
        partial void DeleteCompany(Company instance);
        partial void InsertCostCenter(CostCenter instance);
        partial void UpdateCostCenter(CostCenter instance);
        partial void DeleteCostCenter(CostCenter instance);
        partial void InsertCountry(Country instance);
        partial void UpdateCountry(Country instance);
        partial void DeleteCountry(Country instance);
        partial void InsertCurrency(Currency instance);
        partial void UpdateCurrency(Currency instance);
        partial void DeleteCurrency(Currency instance);
        partial void InsertCustomer(Customer instance);
        partial void UpdateCustomer(Customer instance);
        partial void DeleteCustomer(Customer instance);
        partial void InsertCustomerInvoice(CustomerInvoice instance);
        partial void UpdateCustomerInvoice(CustomerInvoice instance);
        partial void DeleteCustomerInvoice(CustomerInvoice instance);
        partial void InsertGeneralLedger(GeneralLedger instance);
        partial void UpdateGeneralLedger(GeneralLedger instance);
        partial void DeleteGeneralLedger(GeneralLedger instance);
        partial void InsertGoodReceiving(GoodReceiving instance);
        partial void UpdateGoodReceiving(GoodReceiving instance);
        partial void DeleteGoodReceiving(GoodReceiving instance);
        partial void InsertInventoryInvoice(InventoryInvoice instance);
        partial void UpdateInventoryInvoice(InventoryInvoice instance);
        partial void DeleteInventoryInvoice(InventoryInvoice instance);
        partial void InsertJournal(Journal instance);
        partial void UpdateJournal(Journal instance);
        partial void DeleteJournal(Journal instance);
        partial void InsertJournalStock(JournalStock instance);
        partial void UpdateJournalStock(JournalStock instance);
        partial void DeleteJournalStock(JournalStock instance);
        partial void InsertLineBillOfDelivery(LineBillOfDelivery instance);
        partial void UpdateLineBillOfDelivery(LineBillOfDelivery instance);
        partial void DeleteLineBillOfDelivery(LineBillOfDelivery instance);
        partial void InsertLineCustomerInvoice(LineCustomerInvoice instance);
        partial void UpdateLineCustomerInvoice(LineCustomerInvoice instance);
        partial void DeleteLineCustomerInvoice(LineCustomerInvoice instance);
        partial void InsertLineGeneralLedger(LineGeneralLedger instance);
        partial void UpdateLineGeneralLedger(LineGeneralLedger instance);
        partial void DeleteLineGeneralLedger(LineGeneralLedger instance);
        partial void InsertLineGoodReceiving(LineGoodReceiving instance);
        partial void UpdateLineGoodReceiving(LineGoodReceiving instance);
        partial void DeleteLineGoodReceiving(LineGoodReceiving instance);
        partial void InsertLineInventoryInvoice(LineInventoryInvoice instance);
        partial void UpdateLineInventoryInvoice(LineInventoryInvoice instance);
        partial void DeleteLineInventoryInvoice(LineInventoryInvoice instance);
        partial void InsertLinePayment(LinePayment instance);
        partial void UpdateLinePayment(LinePayment instance);
        partial void DeleteLinePayment(LinePayment instance);
        partial void InsertLinePurchaseOrder(LinePurchaseOrder instance);
        partial void UpdateLinePurchaseOrder(LinePurchaseOrder instance);
        partial void DeleteLinePurchaseOrder(LinePurchaseOrder instance);
        partial void InsertLineSalesInvoice(LineSalesInvoice instance);
        partial void UpdateLineSalesInvoice(LineSalesInvoice instance);
        partial void DeleteLineSalesInvoice(LineSalesInvoice instance);
        partial void InsertLineSalesOrder(LineSalesOrder instance);
        partial void UpdateLineSalesOrder(LineSalesOrder instance);
        partial void DeleteLineSalesOrder(LineSalesOrder instance);
        partial void InsertLineSettlement(LineSettlement instance);
        partial void UpdateLineSettlement(LineSettlement instance);
        partial void DeleteLineSettlement(LineSettlement instance);
        partial void InsertLineVendorInvoice(LineVendorInvoice instance);
        partial void UpdateLineVendorInvoice(LineVendorInvoice instance);
        partial void DeleteLineVendorInvoice(LineVendorInvoice instance);
        partial void InsertLocalization(Localization instance);
        partial void UpdateLocalization(Localization instance);
        partial void DeleteLocalization(Localization instance);
        partial void InsertMenu(Menu instance);
        partial void UpdateMenu(Menu instance);
        partial void DeleteMenu(Menu instance);
        partial void InsertPayment(Payment instance);
        partial void UpdatePayment(Payment instance);
        partial void DeletePayment(Payment instance);
        partial void InsertPeriodicAccountBalance(PeriodicAccountBalance instance);
        partial void UpdatePeriodicAccountBalance(PeriodicAccountBalance instance);
        partial void DeletePeriodicAccountBalance(PeriodicAccountBalance instance);
        partial void InsertPurchaseOrder(PurchaseOrder instance);
        partial void UpdatePurchaseOrder(PurchaseOrder instance);
        partial void DeletePurchaseOrder(PurchaseOrder instance);
        partial void InsertQuantityUnit(QuantityUnit instance);
        partial void UpdateQuantityUnit(QuantityUnit instance);
        partial void DeleteQuantityUnit(QuantityUnit instance);
        partial void InsertSalesInvoice(SalesInvoice instance);
        partial void UpdateSalesInvoice(SalesInvoice instance);
        partial void DeleteSalesInvoice(SalesInvoice instance);
        partial void InsertSalesOrder(SalesOrder instance);
        partial void UpdateSalesOrder(SalesOrder instance);
        partial void DeleteSalesOrder(SalesOrder instance);
        partial void InsertSettlement(Settlement instance);
        partial void UpdateSettlement(Settlement instance);
        partial void DeleteSettlement(Settlement instance);
        partial void InsertStock(Stock instance);
        partial void UpdateStock(Stock instance);
        partial void DeleteStock(Stock instance);
        partial void InsertStore(Store instance);
        partial void UpdateStore(Store instance);
        partial void DeleteStore(Store instance);
        partial void InsertSupplier(Supplier instance);
        partial void UpdateSupplier(Supplier instance);
        partial void DeleteSupplier(Supplier instance);
        partial void InsertVat(Vat instance);
        partial void UpdateVat(Vat instance);
        partial void DeleteVat(Vat instance);
        #endregion

        public IWSDataContext() :
                base(global::System.Configuration.ConfigurationManager.ConnectionStrings["IWSConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        public IWSDataContext(string connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public IWSDataContext(System.Data.IDbConnection connection) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public IWSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public IWSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
                base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<Account> Accounts
        {
            get
            {
                return this.GetTable<Account>();
            }
        }

        public System.Data.Linq.Table<VendorInvoice> VendorInvoices
        {
            get
            {
                return this.GetTable<VendorInvoice>();
            }
        }

        public System.Data.Linq.Table<Article> Articles
        {
            get
            {
                return this.GetTable<Article>();
            }
        }

        public System.Data.Linq.Table<AspNetRole> AspNetRoles
        {
            get
            {
                return this.GetTable<AspNetRole>();
            }
        }

        public System.Data.Linq.Table<AspNetUserClaim> AspNetUserClaims
        {
            get
            {
                return this.GetTable<AspNetUserClaim>();
            }
        }

        public System.Data.Linq.Table<AspNetUserLogin> AspNetUserLogins
        {
            get
            {
                return this.GetTable<AspNetUserLogin>();
            }
        }

        public System.Data.Linq.Table<AspNetUserRole> AspNetUserRoles
        {
            get
            {
                return this.GetTable<AspNetUserRole>();
            }
        }

        public System.Data.Linq.Table<AspNetUser> AspNetUsers
        {
            get
            {
                return this.GetTable<AspNetUser>();
            }
        }

        public System.Data.Linq.Table<Bank> Banks
        {
            get
            {
                return this.GetTable<Bank>();
            }
        }

        public System.Data.Linq.Table<BankAccount> BankAccounts
        {
            get
            {
                return this.GetTable<BankAccount>();
            }
        }

        public System.Data.Linq.Table<BankStatement> BankStatements
        {
            get
            {
                return this.GetTable<BankStatement>();
            }
        }

        public System.Data.Linq.Table<BillOfDelivery> BillOfDeliveries
        {
            get
            {
                return this.GetTable<BillOfDelivery>();
            }
        }

        public System.Data.Linq.Table<Category> Categories
        {
            get
            {
                return this.GetTable<Category>();
            }
        }

        public System.Data.Linq.Table<Company> Companies
        {
            get
            {
                return this.GetTable<Company>();
            }
        }

        public System.Data.Linq.Table<CostCenter> CostCenters
        {
            get
            {
                return this.GetTable<CostCenter>();
            }
        }

        public System.Data.Linq.Table<Country> Countries
        {
            get
            {
                return this.GetTable<Country>();
            }
        }

        public System.Data.Linq.Table<Currency> Currencies
        {
            get
            {
                return this.GetTable<Currency>();
            }
        }

        public System.Data.Linq.Table<Customer> Customers
        {
            get
            {
                return this.GetTable<Customer>();
            }
        }

        public System.Data.Linq.Table<CustomerInvoice> CustomerInvoices
        {
            get
            {
                return this.GetTable<CustomerInvoice>();
            }
        }

        public System.Data.Linq.Table<GeneralLedger> GeneralLedgers
        {
            get
            {
                return this.GetTable<GeneralLedger>();
            }
        }

        public System.Data.Linq.Table<GoodReceiving> GoodReceivings
        {
            get
            {
                return this.GetTable<GoodReceiving>();
            }
        }

        public System.Data.Linq.Table<InventoryInvoice> InventoryInvoices
        {
            get
            {
                return this.GetTable<InventoryInvoice>();
            }
        }

        public System.Data.Linq.Table<Journal> Journals
        {
            get
            {
                return this.GetTable<Journal>();
            }
        }

        public System.Data.Linq.Table<JournalStock> JournalStocks
        {
            get
            {
                return this.GetTable<JournalStock>();
            }
        }

        public System.Data.Linq.Table<LineBillOfDelivery> LineBillOfDeliveries
        {
            get
            {
                return this.GetTable<LineBillOfDelivery>();
            }
        }

        public System.Data.Linq.Table<LineCustomerInvoice> LineCustomerInvoices
        {
            get
            {
                return this.GetTable<LineCustomerInvoice>();
            }
        }

        public System.Data.Linq.Table<LineGeneralLedger> LineGeneralLedgers
        {
            get
            {
                return this.GetTable<LineGeneralLedger>();
            }
        }

        public System.Data.Linq.Table<LineGoodReceiving> LineGoodReceivings
        {
            get
            {
                return this.GetTable<LineGoodReceiving>();
            }
        }

        public System.Data.Linq.Table<LineInventoryInvoice> LineInventoryInvoices
        {
            get
            {
                return this.GetTable<LineInventoryInvoice>();
            }
        }

        public System.Data.Linq.Table<LinePayment> LinePayments
        {
            get
            {
                return this.GetTable<LinePayment>();
            }
        }

        public System.Data.Linq.Table<LinePurchaseOrder> LinePurchaseOrders
        {
            get
            {
                return this.GetTable<LinePurchaseOrder>();
            }
        }

        public System.Data.Linq.Table<LineSalesInvoice> LineSalesInvoices
        {
            get
            {
                return this.GetTable<LineSalesInvoice>();
            }
        }

        public System.Data.Linq.Table<LineSalesOrder> LineSalesOrders
        {
            get
            {
                return this.GetTable<LineSalesOrder>();
            }
        }

        public System.Data.Linq.Table<LineSettlement> LineSettlements
        {
            get
            {
                return this.GetTable<LineSettlement>();
            }
        }

        public System.Data.Linq.Table<LineVendorInvoice> LineVendorInvoices
        {
            get
            {
                return this.GetTable<LineVendorInvoice>();
            }
        }

        public System.Data.Linq.Table<Localization> Localizations
        {
            get
            {
                return this.GetTable<Localization>();
            }
        }

        public System.Data.Linq.Table<Menu> Menus
        {
            get
            {
                return this.GetTable<Menu>();
            }
        }

        public System.Data.Linq.Table<Payment> Payments
        {
            get
            {
                return this.GetTable<Payment>();
            }
        }

        public System.Data.Linq.Table<PeriodicAccountBalance> PeriodicAccountBalances
        {
            get
            {
                return this.GetTable<PeriodicAccountBalance>();
            }
        }

        public System.Data.Linq.Table<PurchaseOrder> PurchaseOrders
        {
            get
            {
                return this.GetTable<PurchaseOrder>();
            }
        }

        public System.Data.Linq.Table<QuantityUnit> QuantityUnits
        {
            get
            {
                return this.GetTable<QuantityUnit>();
            }
        }

        public System.Data.Linq.Table<SalesInvoice> SalesInvoices
        {
            get
            {
                return this.GetTable<SalesInvoice>();
            }
        }

        public System.Data.Linq.Table<SalesOrder> SalesOrders
        {
            get
            {
                return this.GetTable<SalesOrder>();
            }
        }

        public System.Data.Linq.Table<Settlement> Settlements
        {
            get
            {
                return this.GetTable<Settlement>();
            }
        }

        public System.Data.Linq.Table<Stock> Stocks
        {
            get
            {
                return this.GetTable<Stock>();
            }
        }

        public System.Data.Linq.Table<Store> Stores
        {
            get
            {
                return this.GetTable<Store>();
            }
        }

        public System.Data.Linq.Table<Supplier> Suppliers
        {
            get
            {
                return this.GetTable<Supplier>();
            }
        }

        public System.Data.Linq.Table<Vat> Vats
        {
            get
            {
                return this.GetTable<Vat>();
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Account")]
    public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _groupid;

        private System.Nullable<System.DateTime> _dateofopen;

        private System.Nullable<System.DateTime> _dateofclose;

        private decimal _balance;

        private string _Currency;

        private string _CompanyID;

        private EntitySet<Journal> _Journals;

        private EntitySet<Journal> _Journals1;

        private EntitySet<PeriodicAccountBalance> _PeriodicAccountBalances;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OngroupidChanging(string value);
        partial void OngroupidChanged();
        partial void OndateofopenChanging(System.Nullable<System.DateTime> value);
        partial void OndateofopenChanged();
        partial void OndateofcloseChanging(System.Nullable<System.DateTime> value);
        partial void OndateofcloseChanged();
        partial void OnbalanceChanging(decimal value);
        partial void OnbalanceChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public Account()
        {
            this._Journals = new EntitySet<Journal>(new Action<Journal>(this.attach_Journals), new Action<Journal>(this.detach_Journals));
            this._Journals1 = new EntitySet<Journal>(new Action<Journal>(this.attach_Journals1), new Action<Journal>(this.detach_Journals1));
            this._PeriodicAccountBalances = new EntitySet<PeriodicAccountBalance>(new Action<PeriodicAccountBalance>(this.attach_PeriodicAccountBalances), new Action<PeriodicAccountBalance>(this.detach_PeriodicAccountBalances));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255)")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_groupid", DbType = "NVarChar(50)")]
        public string groupid
        {
            get
            {
                return this._groupid;
            }
            set
            {
                if ((this._groupid != value))
                {
                    this.OngroupidChanging(value);
                    this.SendPropertyChanging();
                    this._groupid = value;
                    this.SendPropertyChanged("groupid");
                    this.OngroupidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_dateofopen", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> dateofopen
        {
            get
            {
                return this._dateofopen;
            }
            set
            {
                if ((this._dateofopen != value))
                {
                    this.OndateofopenChanging(value);
                    this.SendPropertyChanging();
                    this._dateofopen = value;
                    this.SendPropertyChanged("dateofopen");
                    this.OndateofopenChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_dateofclose", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> dateofclose
        {
            get
            {
                return this._dateofclose;
            }
            set
            {
                if ((this._dateofclose != value))
                {
                    this.OndateofcloseChanging(value);
                    this.SendPropertyChanging();
                    this._dateofclose = value;
                    this.SendPropertyChanged("dateofclose");
                    this.OndateofcloseChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_balance", DbType = "Money NOT NULL")]
        public decimal balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                if ((this._balance != value))
                {
                    this.OnbalanceChanging(value);
                    this.SendPropertyChanging();
                    this._balance = value;
                    this.SendPropertyChanged("balance");
                    this.OnbalanceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Account_Journal", Storage = "_Journals", ThisKey = "id", OtherKey = "Account")]
        public EntitySet<Journal> Journals
        {
            get
            {
                return this._Journals;
            }
            set
            {
                this._Journals.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Account_Journal1", Storage = "_Journals1", ThisKey = "id", OtherKey = "OAccount")]
        public EntitySet<Journal> Journals1
        {
            get
            {
                return this._Journals1;
            }
            set
            {
                this._Journals1.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Account_PeriodicAccountBalance", Storage = "_PeriodicAccountBalances", ThisKey = "id", OtherKey = "AccountId")]
        public EntitySet<PeriodicAccountBalance> PeriodicAccountBalances
        {
            get
            {
                return this._PeriodicAccountBalances;
            }
            set
            {
                this._PeriodicAccountBalances.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_Journals(Journal entity)
        {
            this.SendPropertyChanging();
            entity.Account1 = this;
        }

        private void detach_Journals(Journal entity)
        {
            this.SendPropertyChanging();
            entity.Account1 = null;
        }

        private void attach_Journals1(Journal entity)
        {
            this.SendPropertyChanging();
            entity.Account2 = this;
        }

        private void detach_Journals1(Journal entity)
        {
            this.SendPropertyChanging();
            entity.Account2 = null;
        }

        private void attach_PeriodicAccountBalances(PeriodicAccountBalance entity)
        {
            this.SendPropertyChanging();
            entity.Account = this;
        }

        private void detach_PeriodicAccountBalances(PeriodicAccountBalance entity)
        {
            this.SendPropertyChanging();
            entity.Account = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.VendorInvoice")]
    public partial class VendorInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineVendorInvoice> _LineVendorInvoices;

        private EntityRef<Company> _Company;

        private EntityRef<Store> _Store1;

        private EntityRef<Supplier> _Supplier;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public VendorInvoice()
        {
            this._LineVendorInvoices = new EntitySet<LineVendorInvoice>(new Action<LineVendorInvoice>(this.attach_LineVendorInvoices), new Action<LineVendorInvoice>(this.detach_LineVendorInvoices));
            this._Company = default(EntityRef<Company>);
            this._Store1 = default(EntityRef<Store>);
            this._Supplier = default(EntityRef<Supplier>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    if (this._Store1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Supplier.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "VendorInvoice_LineVendorInvoice", Storage = "_LineVendorInvoices", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineVendorInvoice> LineVendorInvoices
        {
            get
            {
                return this._LineVendorInvoices;
            }
            set
            {
                this._LineVendorInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_VendorInvoice", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.VendorInvoices.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.VendorInvoices.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_VendorInvoice", Storage = "_Store1", ThisKey = "store", OtherKey = "id", IsForeignKey = true)]
        public Store Store1
        {
            get
            {
                return this._Store1.Entity;
            }
            set
            {
                Store previousValue = this._Store1.Entity;
                if (((previousValue != value)
                            || (this._Store1.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Store1.Entity = null;
                        previousValue.VendorInvoices.Remove(this);
                    }
                    this._Store1.Entity = value;
                    if ((value != null))
                    {
                        value.VendorInvoices.Add(this);
                        this._store = value.id;
                    }
                    else
                    {
                        this._store = default(string);
                    }
                    this.SendPropertyChanged("Store1");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_VendorInvoice", Storage = "_Supplier", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Supplier Supplier
        {
            get
            {
                return this._Supplier.Entity;
            }
            set
            {
                Supplier previousValue = this._Supplier.Entity;
                if (((previousValue != value)
                            || (this._Supplier.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Supplier.Entity = null;
                        previousValue.VendorInvoices.Remove(this);
                    }
                    this._Supplier.Entity = value;
                    if ((value != null))
                    {
                        value.VendorInvoices.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Supplier");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineVendorInvoices(LineVendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.VendorInvoice = this;
        }

        private void detach_LineVendorInvoices(LineVendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.VendorInvoice = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Article")]
    public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private decimal _price;

        private decimal _avgprice;

        private decimal _salesprice;

        private string _qttyunit;

        private string _packunit;

        private string _groupid;

        private string _VatCode;

        private bool _IsService;

        private string _CompanyID;

        private string _Currency;

        private EntitySet<LineBillOfDelivery> _LineBillOfDeliveries;

        private EntitySet<LineGoodReceiving> _LineGoodReceivings;

        private EntitySet<LineInventoryInvoice> _LineInventoryInvoices;

        private EntitySet<LinePurchaseOrder> _LinePurchaseOrders;

        private EntitySet<LineSalesInvoice> _LineSalesInvoices;

        private EntitySet<LineSalesOrder> _LineSalesOrders;

        private EntitySet<Stock> _Stocks;

        private EntityRef<Vat> _Vat;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnavgpriceChanging(decimal value);
        partial void OnavgpriceChanged();
        partial void OnsalespriceChanging(decimal value);
        partial void OnsalespriceChanged();
        partial void OnqttyunitChanging(string value);
        partial void OnqttyunitChanged();
        partial void OnpackunitChanging(string value);
        partial void OnpackunitChanged();
        partial void OngroupidChanging(string value);
        partial void OngroupidChanged();
        partial void OnVatCodeChanging(string value);
        partial void OnVatCodeChanged();
        partial void OnIsServiceChanging(bool value);
        partial void OnIsServiceChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public Article()
        {
            this._LineBillOfDeliveries = new EntitySet<LineBillOfDelivery>(new Action<LineBillOfDelivery>(this.attach_LineBillOfDeliveries), new Action<LineBillOfDelivery>(this.detach_LineBillOfDeliveries));
            this._LineGoodReceivings = new EntitySet<LineGoodReceiving>(new Action<LineGoodReceiving>(this.attach_LineGoodReceivings), new Action<LineGoodReceiving>(this.detach_LineGoodReceivings));
            this._LineInventoryInvoices = new EntitySet<LineInventoryInvoice>(new Action<LineInventoryInvoice>(this.attach_LineInventoryInvoices), new Action<LineInventoryInvoice>(this.detach_LineInventoryInvoices));
            this._LinePurchaseOrders = new EntitySet<LinePurchaseOrder>(new Action<LinePurchaseOrder>(this.attach_LinePurchaseOrders), new Action<LinePurchaseOrder>(this.detach_LinePurchaseOrders));
            this._LineSalesInvoices = new EntitySet<LineSalesInvoice>(new Action<LineSalesInvoice>(this.attach_LineSalesInvoices), new Action<LineSalesInvoice>(this.detach_LineSalesInvoices));
            this._LineSalesOrders = new EntitySet<LineSalesOrder>(new Action<LineSalesOrder>(this.attach_LineSalesOrders), new Action<LineSalesOrder>(this.detach_LineSalesOrders));
            this._Stocks = new EntitySet<Stock>(new Action<Stock>(this.attach_Stocks), new Action<Stock>(this.detach_Stocks));
            this._Vat = default(EntityRef<Vat>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_avgprice", DbType = "Money NOT NULL")]
        public decimal avgprice
        {
            get
            {
                return this._avgprice;
            }
            set
            {
                if ((this._avgprice != value))
                {
                    this.OnavgpriceChanging(value);
                    this.SendPropertyChanging();
                    this._avgprice = value;
                    this.SendPropertyChanged("avgprice");
                    this.OnavgpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_salesprice", DbType = "Money NOT NULL")]
        public decimal salesprice
        {
            get
            {
                return this._salesprice;
            }
            set
            {
                if ((this._salesprice != value))
                {
                    this.OnsalespriceChanging(value);
                    this.SendPropertyChanging();
                    this._salesprice = value;
                    this.SendPropertyChanged("salesprice");
                    this.OnsalespriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_qttyunit", DbType = "NVarChar(255)")]
        public string qttyunit
        {
            get
            {
                return this._qttyunit;
            }
            set
            {
                if ((this._qttyunit != value))
                {
                    this.OnqttyunitChanging(value);
                    this.SendPropertyChanging();
                    this._qttyunit = value;
                    this.SendPropertyChanged("qttyunit");
                    this.OnqttyunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_packunit", DbType = "NVarChar(255)")]
        public string packunit
        {
            get
            {
                return this._packunit;
            }
            set
            {
                if ((this._packunit != value))
                {
                    this.OnpackunitChanging(value);
                    this.SendPropertyChanging();
                    this._packunit = value;
                    this.SendPropertyChanged("packunit");
                    this.OnpackunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_groupid", DbType = "NVarChar(255)")]
        public string groupid
        {
            get
            {
                return this._groupid;
            }
            set
            {
                if ((this._groupid != value))
                {
                    this.OngroupidChanging(value);
                    this.SendPropertyChanging();
                    this._groupid = value;
                    this.SendPropertyChanged("groupid");
                    this.OngroupidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VatCode
        {
            get
            {
                return this._VatCode;
            }
            set
            {
                if ((this._VatCode != value))
                {
                    if (this._Vat.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnVatCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VatCode = value;
                    this.SendPropertyChanged("VatCode");
                    this.OnVatCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsService", DbType = "Bit NOT NULL")]
        public bool IsService
        {
            get
            {
                return this._IsService;
            }
            set
            {
                if ((this._IsService != value))
                {
                    this.OnIsServiceChanging(value);
                    this.SendPropertyChanging();
                    this._IsService = value;
                    this.SendPropertyChanged("IsService");
                    this.OnIsServiceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineBillOfDelivery", Storage = "_LineBillOfDeliveries", ThisKey = "id", OtherKey = "item")]
        public EntitySet<LineBillOfDelivery> LineBillOfDeliveries
        {
            get
            {
                return this._LineBillOfDeliveries;
            }
            set
            {
                this._LineBillOfDeliveries.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineGoodReceiving", Storage = "_LineGoodReceivings", ThisKey = "id", OtherKey = "item")]
        public EntitySet<LineGoodReceiving> LineGoodReceivings
        {
            get
            {
                return this._LineGoodReceivings;
            }
            set
            {
                this._LineGoodReceivings.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineInventoryInvoice", Storage = "_LineInventoryInvoices", ThisKey = "id", OtherKey = "item")]
        public EntitySet<LineInventoryInvoice> LineInventoryInvoices
        {
            get
            {
                return this._LineInventoryInvoices;
            }
            set
            {
                this._LineInventoryInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LinePurchaseOrder", Storage = "_LinePurchaseOrders", ThisKey = "id", OtherKey = "item")]
        public EntitySet<LinePurchaseOrder> LinePurchaseOrders
        {
            get
            {
                return this._LinePurchaseOrders;
            }
            set
            {
                this._LinePurchaseOrders.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineSalesInvoice", Storage = "_LineSalesInvoices", ThisKey = "id", OtherKey = "item")]
        public EntitySet<LineSalesInvoice> LineSalesInvoices
        {
            get
            {
                return this._LineSalesInvoices;
            }
            set
            {
                this._LineSalesInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineSalesOrder", Storage = "_LineSalesOrders", ThisKey = "id", OtherKey = "item")]
        public EntitySet<LineSalesOrder> LineSalesOrders
        {
            get
            {
                return this._LineSalesOrders;
            }
            set
            {
                this._LineSalesOrders.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_Stock", Storage = "_Stocks", ThisKey = "id", OtherKey = "itemid")]
        public EntitySet<Stock> Stocks
        {
            get
            {
                return this._Stocks;
            }
            set
            {
                this._Stocks.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Vat_Article", Storage = "_Vat", ThisKey = "VatCode", OtherKey = "id", IsForeignKey = true)]
        public Vat Vat
        {
            get
            {
                return this._Vat.Entity;
            }
            set
            {
                Vat previousValue = this._Vat.Entity;
                if (((previousValue != value)
                            || (this._Vat.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Vat.Entity = null;
                        previousValue.Articles.Remove(this);
                    }
                    this._Vat.Entity = value;
                    if ((value != null))
                    {
                        value.Articles.Add(this);
                        this._VatCode = value.id;
                    }
                    else
                    {
                        this._VatCode = default(string);
                    }
                    this.SendPropertyChanged("Vat");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineBillOfDeliveries(LineBillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_LineBillOfDeliveries(LineBillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }

        private void attach_LineGoodReceivings(LineGoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_LineGoodReceivings(LineGoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }

        private void attach_LineInventoryInvoices(LineInventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_LineInventoryInvoices(LineInventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }

        private void attach_LinePurchaseOrders(LinePurchaseOrder entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_LinePurchaseOrders(LinePurchaseOrder entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }

        private void attach_LineSalesInvoices(LineSalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_LineSalesInvoices(LineSalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }

        private void attach_LineSalesOrders(LineSalesOrder entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_LineSalesOrders(LineSalesOrder entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }

        private void attach_Stocks(Stock entity)
        {
            this.SendPropertyChanging();
            entity.Article = this;
        }

        private void detach_Stocks(Stock entity)
        {
            this.SendPropertyChanging();
            entity.Article = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.AspNetRoles")]
    public partial class AspNetRole : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _Id;

        private string _Name;

        private EntitySet<AspNetUserRole> _AspNetUserRoles;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        #endregion

        public AspNetRole()
        {
            this._AspNetUserRoles = new EntitySet<AspNetUserRole>(new Action<AspNetUserRole>(this.attach_AspNetUserRoles), new Action<AspNetUserRole>(this.detach_AspNetUserRoles));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(256) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetRole_AspNetUserRole", Storage = "_AspNetUserRoles", ThisKey = "Id", OtherKey = "RoleId")]
        public EntitySet<AspNetUserRole> AspNetUserRoles
        {
            get
            {
                return this._AspNetUserRoles;
            }
            set
            {
                this._AspNetUserRoles.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_AspNetUserRoles(AspNetUserRole entity)
        {
            this.SendPropertyChanging();
            entity.AspNetRole = this;
        }

        private void detach_AspNetUserRoles(AspNetUserRole entity)
        {
            this.SendPropertyChanging();
            entity.AspNetRole = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.AspNetUserClaims")]
    public partial class AspNetUserClaim : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _UserId;

        private string _ClaimType;

        private string _ClaimValue;

        private EntityRef<AspNetUser> _AspNetUser;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        partial void OnClaimTypeChanging(string value);
        partial void OnClaimTypeChanged();
        partial void OnClaimValueChanging(string value);
        partial void OnClaimValueChanged();
        #endregion

        public AspNetUserClaim()
        {
            this._AspNetUser = default(EntityRef<AspNetUser>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UserId", DbType = "NVarChar(128) NOT NULL", CanBeNull = false)]
        public string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if ((this._UserId != value))
                {
                    if (this._AspNetUser.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnUserIdChanging(value);
                    this.SendPropertyChanging();
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");
                    this.OnUserIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ClaimType", DbType = "NVarChar(MAX)")]
        public string ClaimType
        {
            get
            {
                return this._ClaimType;
            }
            set
            {
                if ((this._ClaimType != value))
                {
                    this.OnClaimTypeChanging(value);
                    this.SendPropertyChanging();
                    this._ClaimType = value;
                    this.SendPropertyChanged("ClaimType");
                    this.OnClaimTypeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ClaimValue", DbType = "NVarChar(MAX)")]
        public string ClaimValue
        {
            get
            {
                return this._ClaimValue;
            }
            set
            {
                if ((this._ClaimValue != value))
                {
                    this.OnClaimValueChanging(value);
                    this.SendPropertyChanging();
                    this._ClaimValue = value;
                    this.SendPropertyChanged("ClaimValue");
                    this.OnClaimValueChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetUser_AspNetUserClaim", Storage = "_AspNetUser", ThisKey = "UserId", OtherKey = "Id", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
        public AspNetUser AspNetUser
        {
            get
            {
                return this._AspNetUser.Entity;
            }
            set
            {
                AspNetUser previousValue = this._AspNetUser.Entity;
                if (((previousValue != value)
                            || (this._AspNetUser.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._AspNetUser.Entity = null;
                        previousValue.AspNetUserClaims.Remove(this);
                    }
                    this._AspNetUser.Entity = value;
                    if ((value != null))
                    {
                        value.AspNetUserClaims.Add(this);
                        this._UserId = value.Id;
                    }
                    else
                    {
                        this._UserId = default(string);
                    }
                    this.SendPropertyChanged("AspNetUser");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.AspNetUserLogins")]
    public partial class AspNetUserLogin : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _LoginProvider;

        private string _ProviderKey;

        private string _UserId;

        private EntityRef<AspNetUser> _AspNetUser;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnLoginProviderChanging(string value);
        partial void OnLoginProviderChanged();
        partial void OnProviderKeyChanging(string value);
        partial void OnProviderKeyChanged();
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        #endregion

        public AspNetUserLogin()
        {
            this._AspNetUser = default(EntityRef<AspNetUser>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LoginProvider", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string LoginProvider
        {
            get
            {
                return this._LoginProvider;
            }
            set
            {
                if ((this._LoginProvider != value))
                {
                    this.OnLoginProviderChanging(value);
                    this.SendPropertyChanging();
                    this._LoginProvider = value;
                    this.SendPropertyChanged("LoginProvider");
                    this.OnLoginProviderChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ProviderKey", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string ProviderKey
        {
            get
            {
                return this._ProviderKey;
            }
            set
            {
                if ((this._ProviderKey != value))
                {
                    this.OnProviderKeyChanging(value);
                    this.SendPropertyChanging();
                    this._ProviderKey = value;
                    this.SendPropertyChanged("ProviderKey");
                    this.OnProviderKeyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UserId", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if ((this._UserId != value))
                {
                    if (this._AspNetUser.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnUserIdChanging(value);
                    this.SendPropertyChanging();
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");
                    this.OnUserIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetUser_AspNetUserLogin", Storage = "_AspNetUser", ThisKey = "UserId", OtherKey = "Id", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
        public AspNetUser AspNetUser
        {
            get
            {
                return this._AspNetUser.Entity;
            }
            set
            {
                AspNetUser previousValue = this._AspNetUser.Entity;
                if (((previousValue != value)
                            || (this._AspNetUser.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._AspNetUser.Entity = null;
                        previousValue.AspNetUserLogins.Remove(this);
                    }
                    this._AspNetUser.Entity = value;
                    if ((value != null))
                    {
                        value.AspNetUserLogins.Add(this);
                        this._UserId = value.Id;
                    }
                    else
                    {
                        this._UserId = default(string);
                    }
                    this.SendPropertyChanged("AspNetUser");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.AspNetUserRoles")]
    public partial class AspNetUserRole : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _UserId;

        private string _RoleId;

        private EntityRef<AspNetRole> _AspNetRole;

        private EntityRef<AspNetUser> _AspNetUser;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        partial void OnRoleIdChanging(string value);
        partial void OnRoleIdChanged();
        #endregion

        public AspNetUserRole()
        {
            this._AspNetRole = default(EntityRef<AspNetRole>);
            this._AspNetUser = default(EntityRef<AspNetUser>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UserId", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if ((this._UserId != value))
                {
                    if (this._AspNetUser.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnUserIdChanging(value);
                    this.SendPropertyChanging();
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");
                    this.OnUserIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_RoleId", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string RoleId
        {
            get
            {
                return this._RoleId;
            }
            set
            {
                if ((this._RoleId != value))
                {
                    if (this._AspNetRole.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnRoleIdChanging(value);
                    this.SendPropertyChanging();
                    this._RoleId = value;
                    this.SendPropertyChanged("RoleId");
                    this.OnRoleIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetRole_AspNetUserRole", Storage = "_AspNetRole", ThisKey = "RoleId", OtherKey = "Id", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
        public AspNetRole AspNetRole
        {
            get
            {
                return this._AspNetRole.Entity;
            }
            set
            {
                AspNetRole previousValue = this._AspNetRole.Entity;
                if (((previousValue != value)
                            || (this._AspNetRole.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._AspNetRole.Entity = null;
                        previousValue.AspNetUserRoles.Remove(this);
                    }
                    this._AspNetRole.Entity = value;
                    if ((value != null))
                    {
                        value.AspNetUserRoles.Add(this);
                        this._RoleId = value.Id;
                    }
                    else
                    {
                        this._RoleId = default(string);
                    }
                    this.SendPropertyChanged("AspNetRole");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetUser_AspNetUserRole", Storage = "_AspNetUser", ThisKey = "UserId", OtherKey = "Id", IsForeignKey = true, DeleteOnNull = true, DeleteRule = "CASCADE")]
        public AspNetUser AspNetUser
        {
            get
            {
                return this._AspNetUser.Entity;
            }
            set
            {
                AspNetUser previousValue = this._AspNetUser.Entity;
                if (((previousValue != value)
                            || (this._AspNetUser.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._AspNetUser.Entity = null;
                        previousValue.AspNetUserRoles.Remove(this);
                    }
                    this._AspNetUser.Entity = value;
                    if ((value != null))
                    {
                        value.AspNetUserRoles.Add(this);
                        this._UserId = value.Id;
                    }
                    else
                    {
                        this._UserId = default(string);
                    }
                    this.SendPropertyChanged("AspNetUser");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.AspNetUsers")]
    public partial class AspNetUser : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _Id;

        private System.Nullable<System.DateTime> _BirthDate;

        private string _FirstName;

        private string _LastName;

        private string _Company;

        private int _Gender;

        private string _Email;

        private bool _EmailConfirmed;

        private string _PasswordHash;

        private string _SecurityStamp;

        private string _PhoneNumber;

        private bool _PhoneNumberConfirmed;

        private bool _TwoFactorEnabled;

        private System.Nullable<System.DateTime> _LockoutEndDateUtc;

        private bool _LockoutEnabled;

        private int _AccessFailedCount;

        private string _UserName;

        private EntitySet<AspNetUserClaim> _AspNetUserClaims;

        private EntitySet<AspNetUserLogin> _AspNetUserLogins;

        private EntitySet<AspNetUserRole> _AspNetUserRoles;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        partial void OnBirthDateChanging(System.Nullable<System.DateTime> value);
        partial void OnBirthDateChanged();
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        partial void OnCompanyChanging(string value);
        partial void OnCompanyChanged();
        partial void OnGenderChanging(int value);
        partial void OnGenderChanged();
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        partial void OnEmailConfirmedChanging(bool value);
        partial void OnEmailConfirmedChanged();
        partial void OnPasswordHashChanging(string value);
        partial void OnPasswordHashChanged();
        partial void OnSecurityStampChanging(string value);
        partial void OnSecurityStampChanged();
        partial void OnPhoneNumberChanging(string value);
        partial void OnPhoneNumberChanged();
        partial void OnPhoneNumberConfirmedChanging(bool value);
        partial void OnPhoneNumberConfirmedChanged();
        partial void OnTwoFactorEnabledChanging(bool value);
        partial void OnTwoFactorEnabledChanged();
        partial void OnLockoutEndDateUtcChanging(System.Nullable<System.DateTime> value);
        partial void OnLockoutEndDateUtcChanged();
        partial void OnLockoutEnabledChanging(bool value);
        partial void OnLockoutEnabledChanged();
        partial void OnAccessFailedCountChanging(int value);
        partial void OnAccessFailedCountChanged();
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
        #endregion

        public AspNetUser()
        {
            this._AspNetUserClaims = new EntitySet<AspNetUserClaim>(new Action<AspNetUserClaim>(this.attach_AspNetUserClaims), new Action<AspNetUserClaim>(this.detach_AspNetUserClaims));
            this._AspNetUserLogins = new EntitySet<AspNetUserLogin>(new Action<AspNetUserLogin>(this.attach_AspNetUserLogins), new Action<AspNetUserLogin>(this.detach_AspNetUserLogins));
            this._AspNetUserRoles = new EntitySet<AspNetUserRole>(new Action<AspNetUserRole>(this.attach_AspNetUserRoles), new Action<AspNetUserRole>(this.detach_AspNetUserRoles));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "NVarChar(128) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_BirthDate", DbType = "DateTime")]
        public System.Nullable<System.DateTime> BirthDate
        {
            get
            {
                return this._BirthDate;
            }
            set
            {
                if ((this._BirthDate != value))
                {
                    this.OnBirthDateChanging(value);
                    this.SendPropertyChanging();
                    this._BirthDate = value;
                    this.SendPropertyChanged("BirthDate");
                    this.OnBirthDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_FirstName", DbType = "NVarChar(MAX)")]
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                if ((this._FirstName != value))
                {
                    this.OnFirstNameChanging(value);
                    this.SendPropertyChanging();
                    this._FirstName = value;
                    this.SendPropertyChanged("FirstName");
                    this.OnFirstNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LastName", DbType = "NVarChar(MAX)")]
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                if ((this._LastName != value))
                {
                    this.OnLastNameChanging(value);
                    this.SendPropertyChanging();
                    this._LastName = value;
                    this.SendPropertyChanged("LastName");
                    this.OnLastNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Company", DbType = "NVarChar(MAX)")]
        public string Company
        {
            get
            {
                return this._Company;
            }
            set
            {
                if ((this._Company != value))
                {
                    this.OnCompanyChanging(value);
                    this.SendPropertyChanging();
                    this._Company = value;
                    this.SendPropertyChanged("Company");
                    this.OnCompanyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Gender", DbType = "Int NOT NULL")]
        public int Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                if ((this._Gender != value))
                {
                    this.OnGenderChanging(value);
                    this.SendPropertyChanging();
                    this._Gender = value;
                    this.SendPropertyChanged("Gender");
                    this.OnGenderChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Email", DbType = "NVarChar(256)")]
        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                if ((this._Email != value))
                {
                    this.OnEmailChanging(value);
                    this.SendPropertyChanging();
                    this._Email = value;
                    this.SendPropertyChanged("Email");
                    this.OnEmailChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_EmailConfirmed", DbType = "Bit NOT NULL")]
        public bool EmailConfirmed
        {
            get
            {
                return this._EmailConfirmed;
            }
            set
            {
                if ((this._EmailConfirmed != value))
                {
                    this.OnEmailConfirmedChanging(value);
                    this.SendPropertyChanging();
                    this._EmailConfirmed = value;
                    this.SendPropertyChanged("EmailConfirmed");
                    this.OnEmailConfirmedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_PasswordHash", DbType = "NVarChar(MAX)")]
        public string PasswordHash
        {
            get
            {
                return this._PasswordHash;
            }
            set
            {
                if ((this._PasswordHash != value))
                {
                    this.OnPasswordHashChanging(value);
                    this.SendPropertyChanging();
                    this._PasswordHash = value;
                    this.SendPropertyChanged("PasswordHash");
                    this.OnPasswordHashChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_SecurityStamp", DbType = "NVarChar(MAX)")]
        public string SecurityStamp
        {
            get
            {
                return this._SecurityStamp;
            }
            set
            {
                if ((this._SecurityStamp != value))
                {
                    this.OnSecurityStampChanging(value);
                    this.SendPropertyChanging();
                    this._SecurityStamp = value;
                    this.SendPropertyChanged("SecurityStamp");
                    this.OnSecurityStampChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_PhoneNumber", DbType = "NVarChar(MAX)")]
        public string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }
            set
            {
                if ((this._PhoneNumber != value))
                {
                    this.OnPhoneNumberChanging(value);
                    this.SendPropertyChanging();
                    this._PhoneNumber = value;
                    this.SendPropertyChanged("PhoneNumber");
                    this.OnPhoneNumberChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_PhoneNumberConfirmed", DbType = "Bit NOT NULL")]
        public bool PhoneNumberConfirmed
        {
            get
            {
                return this._PhoneNumberConfirmed;
            }
            set
            {
                if ((this._PhoneNumberConfirmed != value))
                {
                    this.OnPhoneNumberConfirmedChanging(value);
                    this.SendPropertyChanging();
                    this._PhoneNumberConfirmed = value;
                    this.SendPropertyChanged("PhoneNumberConfirmed");
                    this.OnPhoneNumberConfirmedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TwoFactorEnabled", DbType = "Bit NOT NULL")]
        public bool TwoFactorEnabled
        {
            get
            {
                return this._TwoFactorEnabled;
            }
            set
            {
                if ((this._TwoFactorEnabled != value))
                {
                    this.OnTwoFactorEnabledChanging(value);
                    this.SendPropertyChanging();
                    this._TwoFactorEnabled = value;
                    this.SendPropertyChanged("TwoFactorEnabled");
                    this.OnTwoFactorEnabledChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LockoutEndDateUtc", DbType = "DateTime")]
        public System.Nullable<System.DateTime> LockoutEndDateUtc
        {
            get
            {
                return this._LockoutEndDateUtc;
            }
            set
            {
                if ((this._LockoutEndDateUtc != value))
                {
                    this.OnLockoutEndDateUtcChanging(value);
                    this.SendPropertyChanging();
                    this._LockoutEndDateUtc = value;
                    this.SendPropertyChanged("LockoutEndDateUtc");
                    this.OnLockoutEndDateUtcChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LockoutEnabled", DbType = "Bit NOT NULL")]
        public bool LockoutEnabled
        {
            get
            {
                return this._LockoutEnabled;
            }
            set
            {
                if ((this._LockoutEnabled != value))
                {
                    this.OnLockoutEnabledChanging(value);
                    this.SendPropertyChanging();
                    this._LockoutEnabled = value;
                    this.SendPropertyChanged("LockoutEnabled");
                    this.OnLockoutEnabledChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_AccessFailedCount", DbType = "Int NOT NULL")]
        public int AccessFailedCount
        {
            get
            {
                return this._AccessFailedCount;
            }
            set
            {
                if ((this._AccessFailedCount != value))
                {
                    this.OnAccessFailedCountChanging(value);
                    this.SendPropertyChanging();
                    this._AccessFailedCount = value;
                    this.SendPropertyChanged("AccessFailedCount");
                    this.OnAccessFailedCountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UserName", DbType = "NVarChar(256) NOT NULL", CanBeNull = false)]
        public string UserName
        {
            get
            {
                return this._UserName;
            }
            set
            {
                if ((this._UserName != value))
                {
                    this.OnUserNameChanging(value);
                    this.SendPropertyChanging();
                    this._UserName = value;
                    this.SendPropertyChanged("UserName");
                    this.OnUserNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetUser_AspNetUserClaim", Storage = "_AspNetUserClaims", ThisKey = "Id", OtherKey = "UserId")]
        public EntitySet<AspNetUserClaim> AspNetUserClaims
        {
            get
            {
                return this._AspNetUserClaims;
            }
            set
            {
                this._AspNetUserClaims.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetUser_AspNetUserLogin", Storage = "_AspNetUserLogins", ThisKey = "Id", OtherKey = "UserId")]
        public EntitySet<AspNetUserLogin> AspNetUserLogins
        {
            get
            {
                return this._AspNetUserLogins;
            }
            set
            {
                this._AspNetUserLogins.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "AspNetUser_AspNetUserRole", Storage = "_AspNetUserRoles", ThisKey = "Id", OtherKey = "UserId")]
        public EntitySet<AspNetUserRole> AspNetUserRoles
        {
            get
            {
                return this._AspNetUserRoles;
            }
            set
            {
                this._AspNetUserRoles.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_AspNetUserClaims(AspNetUserClaim entity)
        {
            this.SendPropertyChanging();
            entity.AspNetUser = this;
        }

        private void detach_AspNetUserClaims(AspNetUserClaim entity)
        {
            this.SendPropertyChanging();
            entity.AspNetUser = null;
        }

        private void attach_AspNetUserLogins(AspNetUserLogin entity)
        {
            this.SendPropertyChanging();
            entity.AspNetUser = this;
        }

        private void detach_AspNetUserLogins(AspNetUserLogin entity)
        {
            this.SendPropertyChanging();
            entity.AspNetUser = null;
        }

        private void attach_AspNetUserRoles(AspNetUserRole entity)
        {
            this.SendPropertyChanging();
            entity.AspNetUser = this;
        }

        private void detach_AspNetUserRoles(AspNetUserRole entity)
        {
            this.SendPropertyChanging();
            entity.AspNetUser = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Bank")]
    public partial class Bank : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _CompanyID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public Bank()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(50)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.BankAccount")]
    public partial class BankAccount : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _bic;

        private decimal _debit;

        private decimal _credit;

        private string _Currency;

        private string _CompanyID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnbicChanging(string value);
        partial void OnbicChanged();
        partial void OndebitChanging(decimal value);
        partial void OndebitChanged();
        partial void OncreditChanging(decimal value);
        partial void OncreditChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public BankAccount()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_bic", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string bic
        {
            get
            {
                return this._bic;
            }
            set
            {
                if ((this._bic != value))
                {
                    this.OnbicChanging(value);
                    this.SendPropertyChanging();
                    this._bic = value;
                    this.SendPropertyChanged("bic");
                    this.OnbicChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_debit", DbType = "Money NOT NULL")]
        public decimal debit
        {
            get
            {
                return this._debit;
            }
            set
            {
                if ((this._debit != value))
                {
                    this.OndebitChanging(value);
                    this.SendPropertyChanging();
                    this._debit = value;
                    this.SendPropertyChanged("debit");
                    this.OndebitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_credit", DbType = "Money NOT NULL")]
        public decimal credit
        {
            get
            {
                return this._credit;
            }
            set
            {
                if ((this._credit != value))
                {
                    this.OncreditChanging(value);
                    this.SendPropertyChanging();
                    this._credit = value;
                    this.SendPropertyChanged("credit");
                    this.OncreditChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.BankStatement")]
    public partial class BankStatement : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private string _Auftragskonto;

        private System.Nullable<System.DateTime> _Buchungstag;

        private System.Nullable<System.DateTime> _Valutadatum;

        private string _Buchungstext;

        private string _Verwendungszweck;

        private string _BeguenstigterZahlungspflichtiger;

        private string _Kontonummer;

        private string _BLZ;

        private System.Nullable<decimal> _Betrag;

        private string _Waehrung;

        private string _Info;

        private string _CompanyID;

        private int _modelid;

        private System.Nullable<bool> _IsValidated;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnAuftragskontoChanging(string value);
        partial void OnAuftragskontoChanged();
        partial void OnBuchungstagChanging(System.Nullable<System.DateTime> value);
        partial void OnBuchungstagChanged();
        partial void OnValutadatumChanging(System.Nullable<System.DateTime> value);
        partial void OnValutadatumChanged();
        partial void OnBuchungstextChanging(string value);
        partial void OnBuchungstextChanged();
        partial void OnVerwendungszweckChanging(string value);
        partial void OnVerwendungszweckChanged();
        partial void OnBeguenstigterZahlungspflichtigerChanging(string value);
        partial void OnBeguenstigterZahlungspflichtigerChanged();
        partial void OnKontonummerChanging(string value);
        partial void OnKontonummerChanged();
        partial void OnBLZChanging(string value);
        partial void OnBLZChanged();
        partial void OnBetragChanging(System.Nullable<decimal> value);
        partial void OnBetragChanged();
        partial void OnWaehrungChanging(string value);
        partial void OnWaehrungChanged();
        partial void OnInfoChanging(string value);
        partial void OnInfoChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public BankStatement()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Auftragskonto", DbType = "NVarChar(50)")]
        public string Auftragskonto
        {
            get
            {
                return this._Auftragskonto;
            }
            set
            {
                if ((this._Auftragskonto != value))
                {
                    this.OnAuftragskontoChanging(value);
                    this.SendPropertyChanging();
                    this._Auftragskonto = value;
                    this.SendPropertyChanged("Auftragskonto");
                    this.OnAuftragskontoChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Buchungstag", DbType = "Date")]
        public System.Nullable<System.DateTime> Buchungstag
        {
            get
            {
                return this._Buchungstag;
            }
            set
            {
                if ((this._Buchungstag != value))
                {
                    this.OnBuchungstagChanging(value);
                    this.SendPropertyChanging();
                    this._Buchungstag = value;
                    this.SendPropertyChanged("Buchungstag");
                    this.OnBuchungstagChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Valutadatum", DbType = "Date")]
        public System.Nullable<System.DateTime> Valutadatum
        {
            get
            {
                return this._Valutadatum;
            }
            set
            {
                if ((this._Valutadatum != value))
                {
                    this.OnValutadatumChanging(value);
                    this.SendPropertyChanging();
                    this._Valutadatum = value;
                    this.SendPropertyChanged("Valutadatum");
                    this.OnValutadatumChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Buchungstext", DbType = "NVarChar(200)")]
        public string Buchungstext
        {
            get
            {
                return this._Buchungstext;
            }
            set
            {
                if ((this._Buchungstext != value))
                {
                    this.OnBuchungstextChanging(value);
                    this.SendPropertyChanging();
                    this._Buchungstext = value;
                    this.SendPropertyChanged("Buchungstext");
                    this.OnBuchungstextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Verwendungszweck", DbType = "NVarChar(250)")]
        public string Verwendungszweck
        {
            get
            {
                return this._Verwendungszweck;
            }
            set
            {
                if ((this._Verwendungszweck != value))
                {
                    this.OnVerwendungszweckChanging(value);
                    this.SendPropertyChanging();
                    this._Verwendungszweck = value;
                    this.SendPropertyChanged("Verwendungszweck");
                    this.OnVerwendungszweckChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_BeguenstigterZahlungspflichtiger", DbType = "NVarChar(250)")]
        public string BeguenstigterZahlungspflichtiger
        {
            get
            {
                return this._BeguenstigterZahlungspflichtiger;
            }
            set
            {
                if ((this._BeguenstigterZahlungspflichtiger != value))
                {
                    this.OnBeguenstigterZahlungspflichtigerChanging(value);
                    this.SendPropertyChanging();
                    this._BeguenstigterZahlungspflichtiger = value;
                    this.SendPropertyChanged("BeguenstigterZahlungspflichtiger");
                    this.OnBeguenstigterZahlungspflichtigerChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Kontonummer", DbType = "NVarChar(50)")]
        public string Kontonummer
        {
            get
            {
                return this._Kontonummer;
            }
            set
            {
                if ((this._Kontonummer != value))
                {
                    this.OnKontonummerChanging(value);
                    this.SendPropertyChanging();
                    this._Kontonummer = value;
                    this.SendPropertyChanged("Kontonummer");
                    this.OnKontonummerChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_BLZ", DbType = "NVarChar(50)")]
        public string BLZ
        {
            get
            {
                return this._BLZ;
            }
            set
            {
                if ((this._BLZ != value))
                {
                    this.OnBLZChanging(value);
                    this.SendPropertyChanging();
                    this._BLZ = value;
                    this.SendPropertyChanged("BLZ");
                    this.OnBLZChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Betrag", DbType = "Money")]
        public System.Nullable<decimal> Betrag
        {
            get
            {
                return this._Betrag;
            }
            set
            {
                if ((this._Betrag != value))
                {
                    this.OnBetragChanging(value);
                    this.SendPropertyChanging();
                    this._Betrag = value;
                    this.SendPropertyChanged("Betrag");
                    this.OnBetragChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Waehrung", DbType = "NVarChar(200)")]
        public string Waehrung
        {
            get
            {
                return this._Waehrung;
            }
            set
            {
                if ((this._Waehrung != value))
                {
                    this.OnWaehrungChanging(value);
                    this.SendPropertyChanging();
                    this._Waehrung = value;
                    this.SendPropertyChanged("Waehrung");
                    this.OnWaehrungChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Info", DbType = "NVarChar(250)")]
        public string Info
        {
            get
            {
                return this._Info;
            }
            set
            {
                if ((this._Info != value))
                {
                    this.OnInfoChanging(value);
                    this.SendPropertyChanging();
                    this._Info = value;
                    this.SendPropertyChanged("Info");
                    this.OnInfoChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50)")]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.BillOfDelivery")]
    public partial class BillOfDelivery : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineBillOfDelivery> _LineBillOfDeliveries;

        private EntityRef<Company> _Company;

        private EntityRef<Customer> _Customer;

        private EntityRef<Store> _Store1;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public BillOfDelivery()
        {
            this._LineBillOfDeliveries = new EntitySet<LineBillOfDelivery>(new Action<LineBillOfDelivery>(this.attach_LineBillOfDeliveries), new Action<LineBillOfDelivery>(this.detach_LineBillOfDeliveries));
            this._Company = default(EntityRef<Company>);
            this._Customer = default(EntityRef<Customer>);
            this._Store1 = default(EntityRef<Store>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    if (this._Store1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Customer.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "BillOfDelivery_LineBillOfDelivery", Storage = "_LineBillOfDeliveries", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineBillOfDelivery> LineBillOfDeliveries
        {
            get
            {
                return this._LineBillOfDeliveries;
            }
            set
            {
                this._LineBillOfDeliveries.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_BillOfDelivery", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.BillOfDeliveries.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.BillOfDeliveries.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_BillOfDelivery", Storage = "_Customer", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Customer Customer
        {
            get
            {
                return this._Customer.Entity;
            }
            set
            {
                Customer previousValue = this._Customer.Entity;
                if (((previousValue != value)
                            || (this._Customer.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Customer.Entity = null;
                        previousValue.BillOfDeliveries.Remove(this);
                    }
                    this._Customer.Entity = value;
                    if ((value != null))
                    {
                        value.BillOfDeliveries.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Customer");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_BillOfDelivery", Storage = "_Store1", ThisKey = "store", OtherKey = "id", IsForeignKey = true)]
        public Store Store1
        {
            get
            {
                return this._Store1.Entity;
            }
            set
            {
                Store previousValue = this._Store1.Entity;
                if (((previousValue != value)
                            || (this._Store1.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Store1.Entity = null;
                        previousValue.BillOfDeliveries.Remove(this);
                    }
                    this._Store1.Entity = value;
                    if ((value != null))
                    {
                        value.BillOfDeliveries.Add(this);
                        this._store = value.id;
                    }
                    else
                    {
                        this._store = default(string);
                    }
                    this.SendPropertyChanged("Store1");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineBillOfDeliveries(LineBillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.BillOfDelivery = this;
        }

        private void detach_LineBillOfDeliveries(LineBillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.BillOfDelivery = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Category")]
    public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _CompanyID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public Category()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Company")]
    public partial class Company : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _street;

        private string _city;

        private string _state;

        private string _zip;

        private string _bankaccountid;

        private string _purchasingclearingaccountid;

        private string _salesclearingaccountid;

        private string _paymentclearingaccountid;

        private string _settlementclearingaccountid;

        private int _periode;

        private System.Nullable<int> _nextperiode;

        private string _taxcode;

        private string _vatcode;

        private string _Currency;

        private EntitySet<VendorInvoice> _VendorInvoices;

        private EntitySet<BillOfDelivery> _BillOfDeliveries;

        private EntitySet<CustomerInvoice> _CustomerInvoices;

        private EntitySet<GeneralLedger> _GeneralLedgers;

        private EntitySet<GoodReceiving> _GoodReceivings;

        private EntitySet<InventoryInvoice> _InventoryInvoices;

        private EntitySet<Payment> _Payments;

        private EntitySet<PurchaseOrder> _PurchaseOrders;

        private EntitySet<SalesInvoice> _SalesInvoices;

        private EntitySet<SalesOrder> _SalesOrders;

        private EntitySet<Settlement> _Settlements;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstreetChanging(string value);
        partial void OnstreetChanged();
        partial void OncityChanging(string value);
        partial void OncityChanged();
        partial void OnstateChanging(string value);
        partial void OnstateChanged();
        partial void OnzipChanging(string value);
        partial void OnzipChanged();
        partial void OnbankaccountidChanging(string value);
        partial void OnbankaccountidChanged();
        partial void OnpurchasingclearingaccountidChanging(string value);
        partial void OnpurchasingclearingaccountidChanged();
        partial void OnsalesclearingaccountidChanging(string value);
        partial void OnsalesclearingaccountidChanged();
        partial void OnpaymentclearingaccountidChanging(string value);
        partial void OnpaymentclearingaccountidChanged();
        partial void OnsettlementclearingaccountidChanging(string value);
        partial void OnsettlementclearingaccountidChanged();
        partial void OnperiodeChanging(int value);
        partial void OnperiodeChanged();
        partial void OnnextperiodeChanging(System.Nullable<int> value);
        partial void OnnextperiodeChanged();
        partial void OntaxcodeChanging(string value);
        partial void OntaxcodeChanged();
        partial void OnvatcodeChanging(string value);
        partial void OnvatcodeChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public Company()
        {
            this._VendorInvoices = new EntitySet<VendorInvoice>(new Action<VendorInvoice>(this.attach_VendorInvoices), new Action<VendorInvoice>(this.detach_VendorInvoices));
            this._BillOfDeliveries = new EntitySet<BillOfDelivery>(new Action<BillOfDelivery>(this.attach_BillOfDeliveries), new Action<BillOfDelivery>(this.detach_BillOfDeliveries));
            this._CustomerInvoices = new EntitySet<CustomerInvoice>(new Action<CustomerInvoice>(this.attach_CustomerInvoices), new Action<CustomerInvoice>(this.detach_CustomerInvoices));
            this._GeneralLedgers = new EntitySet<GeneralLedger>(new Action<GeneralLedger>(this.attach_GeneralLedgers), new Action<GeneralLedger>(this.detach_GeneralLedgers));
            this._GoodReceivings = new EntitySet<GoodReceiving>(new Action<GoodReceiving>(this.attach_GoodReceivings), new Action<GoodReceiving>(this.detach_GoodReceivings));
            this._InventoryInvoices = new EntitySet<InventoryInvoice>(new Action<InventoryInvoice>(this.attach_InventoryInvoices), new Action<InventoryInvoice>(this.detach_InventoryInvoices));
            this._Payments = new EntitySet<Payment>(new Action<Payment>(this.attach_Payments), new Action<Payment>(this.detach_Payments));
            this._PurchaseOrders = new EntitySet<PurchaseOrder>(new Action<PurchaseOrder>(this.attach_PurchaseOrders), new Action<PurchaseOrder>(this.detach_PurchaseOrders));
            this._SalesInvoices = new EntitySet<SalesInvoice>(new Action<SalesInvoice>(this.attach_SalesInvoices), new Action<SalesInvoice>(this.detach_SalesInvoices));
            this._SalesOrders = new EntitySet<SalesOrder>(new Action<SalesOrder>(this.attach_SalesOrders), new Action<SalesOrder>(this.detach_SalesOrders));
            this._Settlements = new EntitySet<Settlement>(new Action<Settlement>(this.attach_Settlements), new Action<Settlement>(this.detach_Settlements));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_street", DbType = "NVarChar(255)")]
        public string street
        {
            get
            {
                return this._street;
            }
            set
            {
                if ((this._street != value))
                {
                    this.OnstreetChanging(value);
                    this.SendPropertyChanging();
                    this._street = value;
                    this.SendPropertyChanged("street");
                    this.OnstreetChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_city", DbType = "NVarChar(255)")]
        public string city
        {
            get
            {
                return this._city;
            }
            set
            {
                if ((this._city != value))
                {
                    this.OncityChanging(value);
                    this.SendPropertyChanging();
                    this._city = value;
                    this.SendPropertyChanged("city");
                    this.OncityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_state", DbType = "NVarChar(255)")]
        public string state
        {
            get
            {
                return this._state;
            }
            set
            {
                if ((this._state != value))
                {
                    this.OnstateChanging(value);
                    this.SendPropertyChanging();
                    this._state = value;
                    this.SendPropertyChanged("state");
                    this.OnstateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_zip", DbType = "NVarChar(255)")]
        public string zip
        {
            get
            {
                return this._zip;
            }
            set
            {
                if ((this._zip != value))
                {
                    this.OnzipChanging(value);
                    this.SendPropertyChanging();
                    this._zip = value;
                    this.SendPropertyChanged("zip");
                    this.OnzipChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_bankaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string bankaccountid
        {
            get
            {
                return this._bankaccountid;
            }
            set
            {
                if ((this._bankaccountid != value))
                {
                    this.OnbankaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._bankaccountid = value;
                    this.SendPropertyChanged("bankaccountid");
                    this.OnbankaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_purchasingclearingaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string purchasingclearingaccountid
        {
            get
            {
                return this._purchasingclearingaccountid;
            }
            set
            {
                if ((this._purchasingclearingaccountid != value))
                {
                    this.OnpurchasingclearingaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._purchasingclearingaccountid = value;
                    this.SendPropertyChanged("purchasingclearingaccountid");
                    this.OnpurchasingclearingaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_salesclearingaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string salesclearingaccountid
        {
            get
            {
                return this._salesclearingaccountid;
            }
            set
            {
                if ((this._salesclearingaccountid != value))
                {
                    this.OnsalesclearingaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._salesclearingaccountid = value;
                    this.SendPropertyChanged("salesclearingaccountid");
                    this.OnsalesclearingaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_paymentclearingaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string paymentclearingaccountid
        {
            get
            {
                return this._paymentclearingaccountid;
            }
            set
            {
                if ((this._paymentclearingaccountid != value))
                {
                    this.OnpaymentclearingaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._paymentclearingaccountid = value;
                    this.SendPropertyChanged("paymentclearingaccountid");
                    this.OnpaymentclearingaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_settlementclearingaccountid", DbType = "NVarChar(255)")]
        public string settlementclearingaccountid
        {
            get
            {
                return this._settlementclearingaccountid;
            }
            set
            {
                if ((this._settlementclearingaccountid != value))
                {
                    this.OnsettlementclearingaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._settlementclearingaccountid = value;
                    this.SendPropertyChanged("settlementclearingaccountid");
                    this.OnsettlementclearingaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_periode", DbType = "Int NOT NULL")]
        public int periode
        {
            get
            {
                return this._periode;
            }
            set
            {
                if ((this._periode != value))
                {
                    this.OnperiodeChanging(value);
                    this.SendPropertyChanging();
                    this._periode = value;
                    this.SendPropertyChanged("periode");
                    this.OnperiodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_nextperiode", DbType = "Int")]
        public System.Nullable<int> nextperiode
        {
            get
            {
                return this._nextperiode;
            }
            set
            {
                if ((this._nextperiode != value))
                {
                    this.OnnextperiodeChanging(value);
                    this.SendPropertyChanging();
                    this._nextperiode = value;
                    this.SendPropertyChanged("nextperiode");
                    this.OnnextperiodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_taxcode", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string taxcode
        {
            get
            {
                return this._taxcode;
            }
            set
            {
                if ((this._taxcode != value))
                {
                    this.OntaxcodeChanging(value);
                    this.SendPropertyChanging();
                    this._taxcode = value;
                    this.SendPropertyChanged("taxcode");
                    this.OntaxcodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_vatcode", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string vatcode
        {
            get
            {
                return this._vatcode;
            }
            set
            {
                if ((this._vatcode != value))
                {
                    this.OnvatcodeChanging(value);
                    this.SendPropertyChanging();
                    this._vatcode = value;
                    this.SendPropertyChanged("vatcode");
                    this.OnvatcodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_VendorInvoice", Storage = "_VendorInvoices", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<VendorInvoice> VendorInvoices
        {
            get
            {
                return this._VendorInvoices;
            }
            set
            {
                this._VendorInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_BillOfDelivery", Storage = "_BillOfDeliveries", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<BillOfDelivery> BillOfDeliveries
        {
            get
            {
                return this._BillOfDeliveries;
            }
            set
            {
                this._BillOfDeliveries.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_CustomerInvoice", Storage = "_CustomerInvoices", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<CustomerInvoice> CustomerInvoices
        {
            get
            {
                return this._CustomerInvoices;
            }
            set
            {
                this._CustomerInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_GeneralLedger", Storage = "_GeneralLedgers", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<GeneralLedger> GeneralLedgers
        {
            get
            {
                return this._GeneralLedgers;
            }
            set
            {
                this._GeneralLedgers.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_GoodReceiving", Storage = "_GoodReceivings", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<GoodReceiving> GoodReceivings
        {
            get
            {
                return this._GoodReceivings;
            }
            set
            {
                this._GoodReceivings.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_InventoryInvoice", Storage = "_InventoryInvoices", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<InventoryInvoice> InventoryInvoices
        {
            get
            {
                return this._InventoryInvoices;
            }
            set
            {
                this._InventoryInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_Payment", Storage = "_Payments", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<Payment> Payments
        {
            get
            {
                return this._Payments;
            }
            set
            {
                this._Payments.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_PurchaseOrder", Storage = "_PurchaseOrders", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<PurchaseOrder> PurchaseOrders
        {
            get
            {
                return this._PurchaseOrders;
            }
            set
            {
                this._PurchaseOrders.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_SalesInvoice", Storage = "_SalesInvoices", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<SalesInvoice> SalesInvoices
        {
            get
            {
                return this._SalesInvoices;
            }
            set
            {
                this._SalesInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_SalesOrder", Storage = "_SalesOrders", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<SalesOrder> SalesOrders
        {
            get
            {
                return this._SalesOrders;
            }
            set
            {
                this._SalesOrders.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_Settlement", Storage = "_Settlements", ThisKey = "id", OtherKey = "CompanyId")]
        public EntitySet<Settlement> Settlements
        {
            get
            {
                return this._Settlements;
            }
            set
            {
                this._Settlements.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_VendorInvoices(VendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_VendorInvoices(VendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_BillOfDeliveries(BillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_BillOfDeliveries(BillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_CustomerInvoices(CustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_CustomerInvoices(CustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_GeneralLedgers(GeneralLedger entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_GeneralLedgers(GeneralLedger entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_GoodReceivings(GoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_GoodReceivings(GoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_InventoryInvoices(InventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_InventoryInvoices(InventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_Payments(Payment entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_Payments(Payment entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_PurchaseOrders(PurchaseOrder entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_PurchaseOrders(PurchaseOrder entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_SalesInvoices(SalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_SalesInvoices(SalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_SalesOrders(SalesOrder entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_SalesOrders(SalesOrder entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }

        private void attach_Settlements(Settlement entity)
        {
            this.SendPropertyChanging();
            entity.Company = this;
        }

        private void detach_Settlements(Settlement entity)
        {
            this.SendPropertyChanging();
            entity.Company = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.CostCenter")]
    public partial class CostCenter : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _CompanyID;

        private EntitySet<CustomerInvoice> _CustomerInvoices;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public CostCenter()
        {
            this._CustomerInvoices = new EntitySet<CustomerInvoice>(new Action<CustomerInvoice>(this.attach_CustomerInvoices), new Action<CustomerInvoice>(this.detach_CustomerInvoices));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "CostCenter_CustomerInvoice", Storage = "_CustomerInvoices", ThisKey = "id", OtherKey = "store")]
        public EntitySet<CustomerInvoice> CustomerInvoices
        {
            get
            {
                return this._CustomerInvoices;
            }
            set
            {
                this._CustomerInvoices.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_CustomerInvoices(CustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.CostCenter = this;
        }

        private void detach_CustomerInvoices(CustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.CostCenter = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Country")]
    public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _code;

        private string _name;

        private int _population;

        private decimal _gnp;

        private string _CompanyID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OncodeChanging(string value);
        partial void OncodeChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnpopulationChanging(int value);
        partial void OnpopulationChanged();
        partial void OngnpChanging(decimal value);
        partial void OngnpChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public Country()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_code", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string code
        {
            get
            {
                return this._code;
            }
            set
            {
                if ((this._code != value))
                {
                    this.OncodeChanging(value);
                    this.SendPropertyChanging();
                    this._code = value;
                    this.SendPropertyChanged("code");
                    this.OncodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_population", DbType = "Int NOT NULL")]
        public int population
        {
            get
            {
                return this._population;
            }
            set
            {
                if ((this._population != value))
                {
                    this.OnpopulationChanging(value);
                    this.SendPropertyChanging();
                    this._population = value;
                    this.SendPropertyChanged("population");
                    this.OnpopulationChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_gnp", DbType = "Money NOT NULL")]
        public decimal gnp
        {
            get
            {
                return this._gnp;
            }
            set
            {
                if ((this._gnp != value))
                {
                    this.OngnpChanging(value);
                    this.SendPropertyChanging();
                    this._gnp = value;
                    this.SendPropertyChanged("gnp");
                    this.OngnpChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50)")]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Currency")]
    public partial class Currency : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _Id;

        private string _Name;

        private string _CompanyID;

        private int _ModelId;

        private string _Description;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnModelIdChanging(int value);
        partial void OnModelIdChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        #endregion

        public Currency()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "NVarChar(10) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(10) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ModelId", DbType = "Int NOT NULL")]
        public int ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                if ((this._ModelId != value))
                {
                    this.OnModelIdChanging(value);
                    this.SendPropertyChanging();
                    this._ModelId = value;
                    this.SendPropertyChanged("ModelId");
                    this.OnModelIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Description", DbType = "NVarChar(255)")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Customer")]
    public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _street;

        private string _city;

        private string _state;

        private string _zip;

        private string _accountid;

        private string _CompanyID;

        private string _IBAN;

        private EntitySet<BillOfDelivery> _BillOfDeliveries;

        private EntitySet<CustomerInvoice> _CustomerInvoices;

        private EntitySet<SalesInvoice> _SalesInvoices;

        private EntitySet<Settlement> _Settlements;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstreetChanging(string value);
        partial void OnstreetChanged();
        partial void OncityChanging(string value);
        partial void OncityChanged();
        partial void OnstateChanging(string value);
        partial void OnstateChanged();
        partial void OnzipChanging(string value);
        partial void OnzipChanged();
        partial void OnaccountidChanging(string value);
        partial void OnaccountidChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnIBANChanging(string value);
        partial void OnIBANChanged();
        #endregion

        public Customer()
        {
            this._BillOfDeliveries = new EntitySet<BillOfDelivery>(new Action<BillOfDelivery>(this.attach_BillOfDeliveries), new Action<BillOfDelivery>(this.detach_BillOfDeliveries));
            this._CustomerInvoices = new EntitySet<CustomerInvoice>(new Action<CustomerInvoice>(this.attach_CustomerInvoices), new Action<CustomerInvoice>(this.detach_CustomerInvoices));
            this._SalesInvoices = new EntitySet<SalesInvoice>(new Action<SalesInvoice>(this.attach_SalesInvoices), new Action<SalesInvoice>(this.detach_SalesInvoices));
            this._Settlements = new EntitySet<Settlement>(new Action<Settlement>(this.attach_Settlements), new Action<Settlement>(this.detach_Settlements));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_street", DbType = "NVarChar(255)")]
        public string street
        {
            get
            {
                return this._street;
            }
            set
            {
                if ((this._street != value))
                {
                    this.OnstreetChanging(value);
                    this.SendPropertyChanging();
                    this._street = value;
                    this.SendPropertyChanged("street");
                    this.OnstreetChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_city", DbType = "NVarChar(255)")]
        public string city
        {
            get
            {
                return this._city;
            }
            set
            {
                if ((this._city != value))
                {
                    this.OncityChanging(value);
                    this.SendPropertyChanging();
                    this._city = value;
                    this.SendPropertyChanged("city");
                    this.OncityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_state", DbType = "NVarChar(255)")]
        public string state
        {
            get
            {
                return this._state;
            }
            set
            {
                if ((this._state != value))
                {
                    this.OnstateChanging(value);
                    this.SendPropertyChanging();
                    this._state = value;
                    this.SendPropertyChanged("state");
                    this.OnstateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_zip", DbType = "NVarChar(255)")]
        public string zip
        {
            get
            {
                return this._zip;
            }
            set
            {
                if ((this._zip != value))
                {
                    this.OnzipChanging(value);
                    this.SendPropertyChanging();
                    this._zip = value;
                    this.SendPropertyChanged("zip");
                    this.OnzipChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_accountid", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string accountid
        {
            get
            {
                return this._accountid;
            }
            set
            {
                if ((this._accountid != value))
                {
                    this.OnaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._accountid = value;
                    this.SendPropertyChanged("accountid");
                    this.OnaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IBAN", DbType = "NVarChar(50)")]
        public string IBAN
        {
            get
            {
                return this._IBAN;
            }
            set
            {
                if ((this._IBAN != value))
                {
                    this.OnIBANChanging(value);
                    this.SendPropertyChanging();
                    this._IBAN = value;
                    this.SendPropertyChanged("IBAN");
                    this.OnIBANChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_BillOfDelivery", Storage = "_BillOfDeliveries", ThisKey = "id", OtherKey = "account")]
        public EntitySet<BillOfDelivery> BillOfDeliveries
        {
            get
            {
                return this._BillOfDeliveries;
            }
            set
            {
                this._BillOfDeliveries.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_CustomerInvoice", Storage = "_CustomerInvoices", ThisKey = "id", OtherKey = "account")]
        public EntitySet<CustomerInvoice> CustomerInvoices
        {
            get
            {
                return this._CustomerInvoices;
            }
            set
            {
                this._CustomerInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_SalesInvoice", Storage = "_SalesInvoices", ThisKey = "id", OtherKey = "account")]
        public EntitySet<SalesInvoice> SalesInvoices
        {
            get
            {
                return this._SalesInvoices;
            }
            set
            {
                this._SalesInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_Settlement", Storage = "_Settlements", ThisKey = "id", OtherKey = "account")]
        public EntitySet<Settlement> Settlements
        {
            get
            {
                return this._Settlements;
            }
            set
            {
                this._Settlements.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_BillOfDeliveries(BillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Customer = this;
        }

        private void detach_BillOfDeliveries(BillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Customer = null;
        }

        private void attach_CustomerInvoices(CustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Customer = this;
        }

        private void detach_CustomerInvoices(CustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Customer = null;
        }

        private void attach_SalesInvoices(SalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Customer = this;
        }

        private void detach_SalesInvoices(SalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Customer = null;
        }

        private void attach_Settlements(Settlement entity)
        {
            this.SendPropertyChanging();
            entity.Customer = this;
        }

        private void detach_Settlements(Settlement entity)
        {
            this.SendPropertyChanging();
            entity.Customer = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.CustomerInvoice")]
    public partial class CustomerInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineCustomerInvoice> _LineCustomerInvoices;

        private EntityRef<Company> _Company;

        private EntityRef<CostCenter> _CostCenter;

        private EntityRef<Customer> _Customer;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public CustomerInvoice()
        {
            this._LineCustomerInvoices = new EntitySet<LineCustomerInvoice>(new Action<LineCustomerInvoice>(this.attach_LineCustomerInvoices), new Action<LineCustomerInvoice>(this.detach_LineCustomerInvoices));
            this._Company = default(EntityRef<Company>);
            this._CostCenter = default(EntityRef<CostCenter>);
            this._Customer = default(EntityRef<Customer>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    if (this._CostCenter.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Customer.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "CustomerInvoice_LineCustomerInvoice", Storage = "_LineCustomerInvoices", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineCustomerInvoice> LineCustomerInvoices
        {
            get
            {
                return this._LineCustomerInvoices;
            }
            set
            {
                this._LineCustomerInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_CustomerInvoice", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.CustomerInvoices.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.CustomerInvoices.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "CostCenter_CustomerInvoice", Storage = "_CostCenter", ThisKey = "store", OtherKey = "id", IsForeignKey = true)]
        public CostCenter CostCenter
        {
            get
            {
                return this._CostCenter.Entity;
            }
            set
            {
                CostCenter previousValue = this._CostCenter.Entity;
                if (((previousValue != value)
                            || (this._CostCenter.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._CostCenter.Entity = null;
                        previousValue.CustomerInvoices.Remove(this);
                    }
                    this._CostCenter.Entity = value;
                    if ((value != null))
                    {
                        value.CustomerInvoices.Add(this);
                        this._store = value.id;
                    }
                    else
                    {
                        this._store = default(string);
                    }
                    this.SendPropertyChanged("CostCenter");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_CustomerInvoice", Storage = "_Customer", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Customer Customer
        {
            get
            {
                return this._Customer.Entity;
            }
            set
            {
                Customer previousValue = this._Customer.Entity;
                if (((previousValue != value)
                            || (this._Customer.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Customer.Entity = null;
                        previousValue.CustomerInvoices.Remove(this);
                    }
                    this._Customer.Entity = value;
                    if ((value != null))
                    {
                        value.CustomerInvoices.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Customer");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineCustomerInvoices(LineCustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.CustomerInvoice = this;
        }

        private void detach_LineCustomerInvoices(LineCustomerInvoice entity)
        {
            this.SendPropertyChanging();
            entity.CustomerInvoice = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.GeneralLedger")]
    public partial class GeneralLedger : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _CostCenter;

        private string _Area;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineGeneralLedger> _LineGeneralLedgers;

        private EntityRef<Company> _Company;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnCostCenterChanging(string value);
        partial void OnCostCenterChanged();
        partial void OnAreaChanging(string value);
        partial void OnAreaChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public GeneralLedger()
        {
            this._LineGeneralLedgers = new EntitySet<LineGeneralLedger>(new Action<LineGeneralLedger>(this.attach_LineGeneralLedgers), new Action<LineGeneralLedger>(this.detach_LineGeneralLedgers));
            this._Company = default(EntityRef<Company>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CostCenter", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CostCenter
        {
            get
            {
                return this._CostCenter;
            }
            set
            {
                if ((this._CostCenter != value))
                {
                    this.OnCostCenterChanging(value);
                    this.SendPropertyChanging();
                    this._CostCenter = value;
                    this.SendPropertyChanged("CostCenter");
                    this.OnCostCenterChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Area", DbType = "NVarChar(15) NOT NULL", CanBeNull = false)]
        public string Area
        {
            get
            {
                return this._Area;
            }
            set
            {
                if ((this._Area != value))
                {
                    this.OnAreaChanging(value);
                    this.SendPropertyChanging();
                    this._Area = value;
                    this.SendPropertyChanged("Area");
                    this.OnAreaChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "GeneralLedger_LineGeneralLedger", Storage = "_LineGeneralLedgers", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineGeneralLedger> LineGeneralLedgers
        {
            get
            {
                return this._LineGeneralLedgers;
            }
            set
            {
                this._LineGeneralLedgers.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_GeneralLedger", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.GeneralLedgers.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.GeneralLedgers.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineGeneralLedgers(LineGeneralLedger entity)
        {
            this.SendPropertyChanging();
            entity.GeneralLedger = this;
        }

        private void detach_LineGeneralLedgers(LineGeneralLedger entity)
        {
            this.SendPropertyChanging();
            entity.GeneralLedger = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.GoodReceiving")]
    public partial class GoodReceiving : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineGoodReceiving> _LineGoodReceivings;

        private EntityRef<Company> _Company;

        private EntityRef<Store> _Store1;

        private EntityRef<Supplier> _Supplier;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public GoodReceiving()
        {
            this._LineGoodReceivings = new EntitySet<LineGoodReceiving>(new Action<LineGoodReceiving>(this.attach_LineGoodReceivings), new Action<LineGoodReceiving>(this.detach_LineGoodReceivings));
            this._Company = default(EntityRef<Company>);
            this._Store1 = default(EntityRef<Store>);
            this._Supplier = default(EntityRef<Supplier>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    if (this._Store1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Supplier.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "GoodReceiving_LineGoodReceiving", Storage = "_LineGoodReceivings", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineGoodReceiving> LineGoodReceivings
        {
            get
            {
                return this._LineGoodReceivings;
            }
            set
            {
                this._LineGoodReceivings.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_GoodReceiving", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.GoodReceivings.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.GoodReceivings.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_GoodReceiving", Storage = "_Store1", ThisKey = "store", OtherKey = "id", IsForeignKey = true)]
        public Store Store1
        {
            get
            {
                return this._Store1.Entity;
            }
            set
            {
                Store previousValue = this._Store1.Entity;
                if (((previousValue != value)
                            || (this._Store1.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Store1.Entity = null;
                        previousValue.GoodReceivings.Remove(this);
                    }
                    this._Store1.Entity = value;
                    if ((value != null))
                    {
                        value.GoodReceivings.Add(this);
                        this._store = value.id;
                    }
                    else
                    {
                        this._store = default(string);
                    }
                    this.SendPropertyChanged("Store1");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_GoodReceiving", Storage = "_Supplier", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Supplier Supplier
        {
            get
            {
                return this._Supplier.Entity;
            }
            set
            {
                Supplier previousValue = this._Supplier.Entity;
                if (((previousValue != value)
                            || (this._Supplier.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Supplier.Entity = null;
                        previousValue.GoodReceivings.Remove(this);
                    }
                    this._Supplier.Entity = value;
                    if ((value != null))
                    {
                        value.GoodReceivings.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Supplier");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineGoodReceivings(LineGoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.GoodReceiving = this;
        }

        private void detach_LineGoodReceivings(LineGoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.GoodReceiving = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.InventoryInvoice")]
    public partial class InventoryInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineInventoryInvoice> _LineInventoryInvoices;

        private EntityRef<Company> _Company;

        private EntityRef<Store> _Store1;

        private EntityRef<Supplier> _Supplier;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public InventoryInvoice()
        {
            this._LineInventoryInvoices = new EntitySet<LineInventoryInvoice>(new Action<LineInventoryInvoice>(this.attach_LineInventoryInvoices), new Action<LineInventoryInvoice>(this.detach_LineInventoryInvoices));
            this._Company = default(EntityRef<Company>);
            this._Store1 = default(EntityRef<Store>);
            this._Supplier = default(EntityRef<Supplier>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    if (this._Store1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Supplier.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "InventoryInvoice_LineInventoryInvoice", Storage = "_LineInventoryInvoices", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineInventoryInvoice> LineInventoryInvoices
        {
            get
            {
                return this._LineInventoryInvoices;
            }
            set
            {
                this._LineInventoryInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_InventoryInvoice", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.InventoryInvoices.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.InventoryInvoices.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_InventoryInvoice", Storage = "_Store1", ThisKey = "store", OtherKey = "id", IsForeignKey = true)]
        public Store Store1
        {
            get
            {
                return this._Store1.Entity;
            }
            set
            {
                Store previousValue = this._Store1.Entity;
                if (((previousValue != value)
                            || (this._Store1.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Store1.Entity = null;
                        previousValue.InventoryInvoices.Remove(this);
                    }
                    this._Store1.Entity = value;
                    if ((value != null))
                    {
                        value.InventoryInvoices.Add(this);
                        this._store = value.id;
                    }
                    else
                    {
                        this._store = default(string);
                    }
                    this.SendPropertyChanged("Store1");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_InventoryInvoice", Storage = "_Supplier", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Supplier Supplier
        {
            get
            {
                return this._Supplier.Entity;
            }
            set
            {
                Supplier previousValue = this._Supplier.Entity;
                if (((previousValue != value)
                            || (this._Supplier.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Supplier.Entity = null;
                        previousValue.InventoryInvoices.Remove(this);
                    }
                    this._Supplier.Entity = value;
                    if ((value != null))
                    {
                        value.InventoryInvoices.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Supplier");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineInventoryInvoices(LineInventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.InventoryInvoice = this;
        }

        private void detach_LineInventoryInvoices(LineInventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.InventoryInvoice = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Journal")]
    public partial class Journal : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private int _ItemID;

        private int _OID;

        private int _ModelID;

        private string _ItemType;

        private string _CustSupplierID;

        private string _StoreID;

        private System.DateTime _TransDate;

        private string _Periode;

        private string _Account;

        private string _OAccount;

        private decimal _Amount;

        private string _Side;

        private string _CompanyID;

        private string _Currency;

        private EntityRef<Account> _Account1;

        private EntityRef<Account> _Account2;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnItemIDChanging(int value);
        partial void OnItemIDChanged();
        partial void OnOIDChanging(int value);
        partial void OnOIDChanged();
        partial void OnModelIDChanging(int value);
        partial void OnModelIDChanged();
        partial void OnItemTypeChanging(string value);
        partial void OnItemTypeChanged();
        partial void OnCustSupplierIDChanging(string value);
        partial void OnCustSupplierIDChanged();
        partial void OnStoreIDChanging(string value);
        partial void OnStoreIDChanged();
        partial void OnTransDateChanging(System.DateTime value);
        partial void OnTransDateChanged();
        partial void OnPeriodeChanging(string value);
        partial void OnPeriodeChanged();
        partial void OnAccountChanging(string value);
        partial void OnAccountChanged();
        partial void OnOAccountChanging(string value);
        partial void OnOAccountChanged();
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        partial void OnSideChanging(string value);
        partial void OnSideChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public Journal()
        {
            this._Account1 = default(EntityRef<Account>);
            this._Account2 = default(EntityRef<Account>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemID", DbType = "Int NOT NULL")]
        public int ItemID
        {
            get
            {
                return this._ItemID;
            }
            set
            {
                if ((this._ItemID != value))
                {
                    this.OnItemIDChanging(value);
                    this.SendPropertyChanging();
                    this._ItemID = value;
                    this.SendPropertyChanged("ItemID");
                    this.OnItemIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_OID", DbType = "Int NOT NULL")]
        public int OID
        {
            get
            {
                return this._OID;
            }
            set
            {
                if ((this._OID != value))
                {
                    this.OnOIDChanging(value);
                    this.SendPropertyChanging();
                    this._OID = value;
                    this.SendPropertyChanged("OID");
                    this.OnOIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ModelID", DbType = "Int NOT NULL")]
        public int ModelID
        {
            get
            {
                return this._ModelID;
            }
            set
            {
                if ((this._ModelID != value))
                {
                    this.OnModelIDChanging(value);
                    this.SendPropertyChanging();
                    this._ModelID = value;
                    this.SendPropertyChanged("ModelID");
                    this.OnModelIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemType", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string ItemType
        {
            get
            {
                return this._ItemType;
            }
            set
            {
                if ((this._ItemType != value))
                {
                    this.OnItemTypeChanging(value);
                    this.SendPropertyChanging();
                    this._ItemType = value;
                    this.SendPropertyChanged("ItemType");
                    this.OnItemTypeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CustSupplierID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CustSupplierID
        {
            get
            {
                return this._CustSupplierID;
            }
            set
            {
                if ((this._CustSupplierID != value))
                {
                    this.OnCustSupplierIDChanging(value);
                    this.SendPropertyChanging();
                    this._CustSupplierID = value;
                    this.SendPropertyChanged("CustSupplierID");
                    this.OnCustSupplierIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StoreID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string StoreID
        {
            get
            {
                return this._StoreID;
            }
            set
            {
                if ((this._StoreID != value))
                {
                    this.OnStoreIDChanging(value);
                    this.SendPropertyChanging();
                    this._StoreID = value;
                    this.SendPropertyChanged("StoreID");
                    this.OnStoreIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TransDate", DbType = "DateTime NOT NULL")]
        public System.DateTime TransDate
        {
            get
            {
                return this._TransDate;
            }
            set
            {
                if ((this._TransDate != value))
                {
                    this.OnTransDateChanging(value);
                    this.SendPropertyChanging();
                    this._TransDate = value;
                    this.SendPropertyChanged("TransDate");
                    this.OnTransDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Periode", DbType = "NChar(6) NOT NULL", CanBeNull = false)]
        public string Periode
        {
            get
            {
                return this._Periode;
            }
            set
            {
                if ((this._Periode != value))
                {
                    this.OnPeriodeChanging(value);
                    this.SendPropertyChanging();
                    this._Periode = value;
                    this.SendPropertyChanged("Periode");
                    this.OnPeriodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string Account
        {
            get
            {
                return this._Account;
            }
            set
            {
                if ((this._Account != value))
                {
                    if (this._Account1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnAccountChanging(value);
                    this.SendPropertyChanging();
                    this._Account = value;
                    this.SendPropertyChanged("Account");
                    this.OnAccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_OAccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string OAccount
        {
            get
            {
                return this._OAccount;
            }
            set
            {
                if ((this._OAccount != value))
                {
                    if (this._Account2.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnOAccountChanging(value);
                    this.SendPropertyChanging();
                    this._OAccount = value;
                    this.SendPropertyChanged("OAccount");
                    this.OnOAccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Amount", DbType = "Money NOT NULL")]
        public decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                if ((this._Amount != value))
                {
                    this.OnAmountChanging(value);
                    this.SendPropertyChanging();
                    this._Amount = value;
                    this.SendPropertyChanged("Amount");
                    this.OnAmountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Side", DbType = "NVarChar(6) NOT NULL", CanBeNull = false)]
        public string Side
        {
            get
            {
                return this._Side;
            }
            set
            {
                if ((this._Side != value))
                {
                    this.OnSideChanging(value);
                    this.SendPropertyChanging();
                    this._Side = value;
                    this.SendPropertyChanged("Side");
                    this.OnSideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Account_Journal", Storage = "_Account1", ThisKey = "Account", OtherKey = "id", IsForeignKey = true)]
        public Account Account1
        {
            get
            {
                return this._Account1.Entity;
            }
            set
            {
                Account previousValue = this._Account1.Entity;
                if (((previousValue != value)
                            || (this._Account1.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Account1.Entity = null;
                        previousValue.Journals.Remove(this);
                    }
                    this._Account1.Entity = value;
                    if ((value != null))
                    {
                        value.Journals.Add(this);
                        this._Account = value.id;
                    }
                    else
                    {
                        this._Account = default(string);
                    }
                    this.SendPropertyChanged("Account1");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Account_Journal1", Storage = "_Account2", ThisKey = "OAccount", OtherKey = "id", IsForeignKey = true)]
        public Account Account2
        {
            get
            {
                return this._Account2.Entity;
            }
            set
            {
                Account previousValue = this._Account2.Entity;
                if (((previousValue != value)
                            || (this._Account2.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Account2.Entity = null;
                        previousValue.Journals1.Remove(this);
                    }
                    this._Account2.Entity = value;
                    if ((value != null))
                    {
                        value.Journals1.Add(this);
                        this._OAccount = value.id;
                    }
                    else
                    {
                        this._OAccount = default(string);
                    }
                    this.SendPropertyChanged("Account2");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.JournalStock")]
    public partial class JournalStock : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private int _ItemID;

        private int _OID;

        private int _ModelID;

        private string _ItemType;

        private string _CustSupplierID;

        private string _StoreID;

        private string _ArticleID;

        private string _ArticleName;

        private System.Nullable<decimal> _Quantity;

        private System.Nullable<decimal> _Price;

        private System.Nullable<decimal> _AvgPrice;

        private System.DateTime _TransDate;

        private string _Periode;

        private string _Account;

        private string _OAccount;

        private System.Nullable<decimal> _Amount;

        private string _Side;

        private string _CompanyID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnItemIDChanging(int value);
        partial void OnItemIDChanged();
        partial void OnOIDChanging(int value);
        partial void OnOIDChanged();
        partial void OnModelIDChanging(int value);
        partial void OnModelIDChanged();
        partial void OnItemTypeChanging(string value);
        partial void OnItemTypeChanged();
        partial void OnCustSupplierIDChanging(string value);
        partial void OnCustSupplierIDChanged();
        partial void OnStoreIDChanging(string value);
        partial void OnStoreIDChanged();
        partial void OnArticleIDChanging(string value);
        partial void OnArticleIDChanged();
        partial void OnArticleNameChanging(string value);
        partial void OnArticleNameChanged();
        partial void OnQuantityChanging(System.Nullable<decimal> value);
        partial void OnQuantityChanged();
        partial void OnPriceChanging(System.Nullable<decimal> value);
        partial void OnPriceChanged();
        partial void OnAvgPriceChanging(System.Nullable<decimal> value);
        partial void OnAvgPriceChanged();
        partial void OnTransDateChanging(System.DateTime value);
        partial void OnTransDateChanged();
        partial void OnPeriodeChanging(string value);
        partial void OnPeriodeChanged();
        partial void OnAccountChanging(string value);
        partial void OnAccountChanged();
        partial void OnOAccountChanging(string value);
        partial void OnOAccountChanged();
        partial void OnAmountChanging(System.Nullable<decimal> value);
        partial void OnAmountChanged();
        partial void OnSideChanging(string value);
        partial void OnSideChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public JournalStock()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemID", DbType = "Int NOT NULL")]
        public int ItemID
        {
            get
            {
                return this._ItemID;
            }
            set
            {
                if ((this._ItemID != value))
                {
                    this.OnItemIDChanging(value);
                    this.SendPropertyChanging();
                    this._ItemID = value;
                    this.SendPropertyChanged("ItemID");
                    this.OnItemIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_OID", DbType = "Int NOT NULL")]
        public int OID
        {
            get
            {
                return this._OID;
            }
            set
            {
                if ((this._OID != value))
                {
                    this.OnOIDChanging(value);
                    this.SendPropertyChanging();
                    this._OID = value;
                    this.SendPropertyChanged("OID");
                    this.OnOIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ModelID", DbType = "Int NOT NULL")]
        public int ModelID
        {
            get
            {
                return this._ModelID;
            }
            set
            {
                if ((this._ModelID != value))
                {
                    this.OnModelIDChanging(value);
                    this.SendPropertyChanging();
                    this._ModelID = value;
                    this.SendPropertyChanged("ModelID");
                    this.OnModelIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemType", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string ItemType
        {
            get
            {
                return this._ItemType;
            }
            set
            {
                if ((this._ItemType != value))
                {
                    this.OnItemTypeChanging(value);
                    this.SendPropertyChanging();
                    this._ItemType = value;
                    this.SendPropertyChanged("ItemType");
                    this.OnItemTypeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CustSupplierID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CustSupplierID
        {
            get
            {
                return this._CustSupplierID;
            }
            set
            {
                if ((this._CustSupplierID != value))
                {
                    this.OnCustSupplierIDChanging(value);
                    this.SendPropertyChanging();
                    this._CustSupplierID = value;
                    this.SendPropertyChanged("CustSupplierID");
                    this.OnCustSupplierIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_StoreID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string StoreID
        {
            get
            {
                return this._StoreID;
            }
            set
            {
                if ((this._StoreID != value))
                {
                    this.OnStoreIDChanging(value);
                    this.SendPropertyChanging();
                    this._StoreID = value;
                    this.SendPropertyChanged("StoreID");
                    this.OnStoreIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ArticleID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string ArticleID
        {
            get
            {
                return this._ArticleID;
            }
            set
            {
                if ((this._ArticleID != value))
                {
                    this.OnArticleIDChanging(value);
                    this.SendPropertyChanging();
                    this._ArticleID = value;
                    this.SendPropertyChanged("ArticleID");
                    this.OnArticleIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ArticleName", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string ArticleName
        {
            get
            {
                return this._ArticleName;
            }
            set
            {
                if ((this._ArticleName != value))
                {
                    this.OnArticleNameChanging(value);
                    this.SendPropertyChanging();
                    this._ArticleName = value;
                    this.SendPropertyChanged("ArticleName");
                    this.OnArticleNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Quantity", DbType = "Decimal(16,2)")]
        public System.Nullable<decimal> Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                if ((this._Quantity != value))
                {
                    this.OnQuantityChanging(value);
                    this.SendPropertyChanging();
                    this._Quantity = value;
                    this.SendPropertyChanged("Quantity");
                    this.OnQuantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Price", DbType = "Decimal(16,2)")]
        public System.Nullable<decimal> Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                if ((this._Price != value))
                {
                    this.OnPriceChanging(value);
                    this.SendPropertyChanging();
                    this._Price = value;
                    this.SendPropertyChanged("Price");
                    this.OnPriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_AvgPrice", DbType = "Decimal(16,2)")]
        public System.Nullable<decimal> AvgPrice
        {
            get
            {
                return this._AvgPrice;
            }
            set
            {
                if ((this._AvgPrice != value))
                {
                    this.OnAvgPriceChanging(value);
                    this.SendPropertyChanging();
                    this._AvgPrice = value;
                    this.SendPropertyChanged("AvgPrice");
                    this.OnAvgPriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_TransDate", DbType = "DateTime NOT NULL")]
        public System.DateTime TransDate
        {
            get
            {
                return this._TransDate;
            }
            set
            {
                if ((this._TransDate != value))
                {
                    this.OnTransDateChanging(value);
                    this.SendPropertyChanging();
                    this._TransDate = value;
                    this.SendPropertyChanged("TransDate");
                    this.OnTransDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Periode", DbType = "NChar(6) NOT NULL", CanBeNull = false)]
        public string Periode
        {
            get
            {
                return this._Periode;
            }
            set
            {
                if ((this._Periode != value))
                {
                    this.OnPeriodeChanging(value);
                    this.SendPropertyChanging();
                    this._Periode = value;
                    this.SendPropertyChanged("Periode");
                    this.OnPeriodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string Account
        {
            get
            {
                return this._Account;
            }
            set
            {
                if ((this._Account != value))
                {
                    this.OnAccountChanging(value);
                    this.SendPropertyChanging();
                    this._Account = value;
                    this.SendPropertyChanged("Account");
                    this.OnAccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_OAccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string OAccount
        {
            get
            {
                return this._OAccount;
            }
            set
            {
                if ((this._OAccount != value))
                {
                    this.OnOAccountChanging(value);
                    this.SendPropertyChanging();
                    this._OAccount = value;
                    this.SendPropertyChanged("OAccount");
                    this.OnOAccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Amount", DbType = "Decimal(16,2)")]
        public System.Nullable<decimal> Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                if ((this._Amount != value))
                {
                    this.OnAmountChanging(value);
                    this.SendPropertyChanging();
                    this._Amount = value;
                    this.SendPropertyChanged("Amount");
                    this.OnAmountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Side", DbType = "NVarChar(6) NOT NULL", CanBeNull = false)]
        public string Side
        {
            get
            {
                return this._Side;
            }
            set
            {
                if ((this._Side != value))
                {
                    this.OnSideChanging(value);
                    this.SendPropertyChanging();
                    this._Side = value;
                    this.SendPropertyChanged("Side");
                    this.OnSideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50)")]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineBillOfDelivery")]
    public partial class LineBillOfDelivery : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private decimal _price;

        private decimal _quantity;

        private string _VatCode;

        private System.DateTime _duedate;

        private string _text;

        private string _CompanyID;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<BillOfDelivery> _BillOfDelivery;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(decimal value);
        partial void OnquantityChanged();
        partial void OnVatCodeChanging(string value);
        partial void OnVatCodeChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineBillOfDelivery()
        {
            this._Article = default(EntityRef<Article>);
            this._BillOfDelivery = default(EntityRef<BillOfDelivery>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._BillOfDelivery.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string item
        {
            get
            {
                return this._item;
            }
            set
            {
                if ((this._item != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    this.OnunitChanging(value);
                    this.SendPropertyChanging();
                    this._unit = value;
                    this.SendPropertyChanged("unit");
                    this.OnunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Decimal(10,2) NOT NULL")]
        public decimal quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VatCode
        {
            get
            {
                return this._VatCode;
            }
            set
            {
                if ((this._VatCode != value))
                {
                    this.OnVatCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VatCode = value;
                    this.SendPropertyChanged("VatCode");
                    this.OnVatCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(255)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50)")]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineBillOfDelivery", Storage = "_Article", ThisKey = "item", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.LineBillOfDeliveries.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.LineBillOfDeliveries.Add(this);
                        this._item = value.id;
                    }
                    else
                    {
                        this._item = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "BillOfDelivery_LineBillOfDelivery", Storage = "_BillOfDelivery", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public BillOfDelivery BillOfDelivery
        {
            get
            {
                return this._BillOfDelivery.Entity;
            }
            set
            {
                BillOfDelivery previousValue = this._BillOfDelivery.Entity;
                if (((previousValue != value)
                            || (this._BillOfDelivery.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._BillOfDelivery.Entity = null;
                        previousValue.LineBillOfDeliveries.Remove(this);
                    }
                    this._BillOfDelivery.Entity = value;
                    if ((value != null))
                    {
                        value.LineBillOfDeliveries.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("BillOfDelivery");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineCustomerInvoice")]
    public partial class LineCustomerInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _account;

        private bool _side;

        private string _oaccount;

        private decimal _amount;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<CustomerInvoice> _CustomerInvoice;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(bool value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(decimal value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineCustomerInvoice()
        {
            this._CustomerInvoice = default(EntityRef<CustomerInvoice>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._CustomerInvoice.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "Bit NOT NULL")]
        public bool side
        {
            get
            {
                return this._side;
            }
            set
            {
                if ((this._side != value))
                {
                    this.OnsideChanging(value);
                    this.SendPropertyChanging();
                    this._side = value;
                    this.SendPropertyChanged("side");
                    this.OnsideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string oaccount
        {
            get
            {
                return this._oaccount;
            }
            set
            {
                if ((this._oaccount != value))
                {
                    this.OnoaccountChanging(value);
                    this.SendPropertyChanging();
                    this._oaccount = value;
                    this.SendPropertyChanged("oaccount");
                    this.OnoaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money NOT NULL")]
        public decimal amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if ((this._amount != value))
                {
                    this.OnamountChanging(value);
                    this.SendPropertyChanging();
                    this._amount = value;
                    this.SendPropertyChanged("amount");
                    this.OnamountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "CustomerInvoice_LineCustomerInvoice", Storage = "_CustomerInvoice", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public CustomerInvoice CustomerInvoice
        {
            get
            {
                return this._CustomerInvoice.Entity;
            }
            set
            {
                CustomerInvoice previousValue = this._CustomerInvoice.Entity;
                if (((previousValue != value)
                            || (this._CustomerInvoice.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._CustomerInvoice.Entity = null;
                        previousValue.LineCustomerInvoices.Remove(this);
                    }
                    this._CustomerInvoice.Entity = value;
                    if ((value != null))
                    {
                        value.LineCustomerInvoices.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("CustomerInvoice");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineGeneralLedger")]
    public partial class LineGeneralLedger : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _account;

        private bool _side;

        private string _oaccount;

        private decimal _amount;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<GeneralLedger> _GeneralLedger;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(bool value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(decimal value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineGeneralLedger()
        {
            this._GeneralLedger = default(EntityRef<GeneralLedger>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._GeneralLedger.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "Bit NOT NULL")]
        public bool side
        {
            get
            {
                return this._side;
            }
            set
            {
                if ((this._side != value))
                {
                    this.OnsideChanging(value);
                    this.SendPropertyChanging();
                    this._side = value;
                    this.SendPropertyChanged("side");
                    this.OnsideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string oaccount
        {
            get
            {
                return this._oaccount;
            }
            set
            {
                if ((this._oaccount != value))
                {
                    this.OnoaccountChanging(value);
                    this.SendPropertyChanging();
                    this._oaccount = value;
                    this.SendPropertyChanged("oaccount");
                    this.OnoaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money NOT NULL")]
        public decimal amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if ((this._amount != value))
                {
                    this.OnamountChanging(value);
                    this.SendPropertyChanging();
                    this._amount = value;
                    this.SendPropertyChanged("amount");
                    this.OnamountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "GeneralLedger_LineGeneralLedger", Storage = "_GeneralLedger", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public GeneralLedger GeneralLedger
        {
            get
            {
                return this._GeneralLedger.Entity;
            }
            set
            {
                GeneralLedger previousValue = this._GeneralLedger.Entity;
                if (((previousValue != value)
                            || (this._GeneralLedger.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._GeneralLedger.Entity = null;
                        previousValue.LineGeneralLedgers.Remove(this);
                    }
                    this._GeneralLedger.Entity = value;
                    if ((value != null))
                    {
                        value.LineGeneralLedgers.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("GeneralLedger");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineGoodReceiving")]
    public partial class LineGoodReceiving : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private decimal _price;

        private decimal _quantity;

        private string _VatCode;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<GoodReceiving> _GoodReceiving;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(decimal value);
        partial void OnquantityChanged();
        partial void OnVatCodeChanging(string value);
        partial void OnVatCodeChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineGoodReceiving()
        {
            this._Article = default(EntityRef<Article>);
            this._GoodReceiving = default(EntityRef<GoodReceiving>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._GoodReceiving.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string item
        {
            get
            {
                return this._item;
            }
            set
            {
                if ((this._item != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    this.OnunitChanging(value);
                    this.SendPropertyChanging();
                    this._unit = value;
                    this.SendPropertyChanged("unit");
                    this.OnunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Decimal(10,2) NOT NULL")]
        public decimal quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VatCode
        {
            get
            {
                return this._VatCode;
            }
            set
            {
                if ((this._VatCode != value))
                {
                    this.OnVatCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VatCode = value;
                    this.SendPropertyChanged("VatCode");
                    this.OnVatCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(255)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineGoodReceiving", Storage = "_Article", ThisKey = "item", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.LineGoodReceivings.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.LineGoodReceivings.Add(this);
                        this._item = value.id;
                    }
                    else
                    {
                        this._item = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "GoodReceiving_LineGoodReceiving", Storage = "_GoodReceiving", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public GoodReceiving GoodReceiving
        {
            get
            {
                return this._GoodReceiving.Entity;
            }
            set
            {
                GoodReceiving previousValue = this._GoodReceiving.Entity;
                if (((previousValue != value)
                            || (this._GoodReceiving.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._GoodReceiving.Entity = null;
                        previousValue.LineGoodReceivings.Remove(this);
                    }
                    this._GoodReceiving.Entity = value;
                    if ((value != null))
                    {
                        value.LineGoodReceivings.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("GoodReceiving");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineInventoryInvoice")]
    public partial class LineInventoryInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private decimal _price;

        private decimal _quantity;

        private string _VATCode;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<InventoryInvoice> _InventoryInvoice;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(decimal value);
        partial void OnquantityChanged();
        partial void OnVATCodeChanging(string value);
        partial void OnVATCodeChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineInventoryInvoice()
        {
            this._Article = default(EntityRef<Article>);
            this._InventoryInvoice = default(EntityRef<InventoryInvoice>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._InventoryInvoice.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string item
        {
            get
            {
                return this._item;
            }
            set
            {
                if ((this._item != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    this.OnunitChanging(value);
                    this.SendPropertyChanging();
                    this._unit = value;
                    this.SendPropertyChanged("unit");
                    this.OnunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Decimal(10,2) NOT NULL")]
        public decimal quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VATCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VATCode
        {
            get
            {
                return this._VATCode;
            }
            set
            {
                if ((this._VATCode != value))
                {
                    this.OnVATCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VATCode = value;
                    this.SendPropertyChanged("VATCode");
                    this.OnVATCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineInventoryInvoice", Storage = "_Article", ThisKey = "item", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.LineInventoryInvoices.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.LineInventoryInvoices.Add(this);
                        this._item = value.id;
                    }
                    else
                    {
                        this._item = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "InventoryInvoice_LineInventoryInvoice", Storage = "_InventoryInvoice", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public InventoryInvoice InventoryInvoice
        {
            get
            {
                return this._InventoryInvoice.Entity;
            }
            set
            {
                InventoryInvoice previousValue = this._InventoryInvoice.Entity;
                if (((previousValue != value)
                            || (this._InventoryInvoice.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._InventoryInvoice.Entity = null;
                        previousValue.LineInventoryInvoices.Remove(this);
                    }
                    this._InventoryInvoice.Entity = value;
                    if ((value != null))
                    {
                        value.LineInventoryInvoices.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("InventoryInvoice");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LinePayment")]
    public partial class LinePayment : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _account;

        private bool _side;

        private string _oaccount;

        private decimal _amount;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Payment> _Payment;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(bool value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(decimal value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LinePayment()
        {
            this._Payment = default(EntityRef<Payment>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._Payment.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "Bit NOT NULL")]
        public bool side
        {
            get
            {
                return this._side;
            }
            set
            {
                if ((this._side != value))
                {
                    this.OnsideChanging(value);
                    this.SendPropertyChanging();
                    this._side = value;
                    this.SendPropertyChanged("side");
                    this.OnsideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string oaccount
        {
            get
            {
                return this._oaccount;
            }
            set
            {
                if ((this._oaccount != value))
                {
                    this.OnoaccountChanging(value);
                    this.SendPropertyChanging();
                    this._oaccount = value;
                    this.SendPropertyChanged("oaccount");
                    this.OnoaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money NOT NULL")]
        public decimal amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if ((this._amount != value))
                {
                    this.OnamountChanging(value);
                    this.SendPropertyChanging();
                    this._amount = value;
                    this.SendPropertyChanged("amount");
                    this.OnamountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Payment_LinePayment", Storage = "_Payment", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public Payment Payment
        {
            get
            {
                return this._Payment.Entity;
            }
            set
            {
                Payment previousValue = this._Payment.Entity;
                if (((previousValue != value)
                            || (this._Payment.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Payment.Entity = null;
                        previousValue.LinePayments.Remove(this);
                    }
                    this._Payment.Entity = value;
                    if ((value != null))
                    {
                        value.LinePayments.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("Payment");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LinePurchaseOrder")]
    public partial class LinePurchaseOrder : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private decimal _price;

        private decimal _quantity;

        private string _VatCode;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<PurchaseOrder> _PurchaseOrder;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(decimal value);
        partial void OnquantityChanged();
        partial void OnVatCodeChanging(string value);
        partial void OnVatCodeChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LinePurchaseOrder()
        {
            this._Article = default(EntityRef<Article>);
            this._PurchaseOrder = default(EntityRef<PurchaseOrder>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._PurchaseOrder.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string item
        {
            get
            {
                return this._item;
            }
            set
            {
                if ((this._item != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    this.OnunitChanging(value);
                    this.SendPropertyChanging();
                    this._unit = value;
                    this.SendPropertyChanged("unit");
                    this.OnunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Decimal(10,2) NOT NULL")]
        public decimal quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VatCode
        {
            get
            {
                return this._VatCode;
            }
            set
            {
                if ((this._VatCode != value))
                {
                    this.OnVatCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VatCode = value;
                    this.SendPropertyChanged("VatCode");
                    this.OnVatCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(255)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LinePurchaseOrder", Storage = "_Article", ThisKey = "item", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.LinePurchaseOrders.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.LinePurchaseOrders.Add(this);
                        this._item = value.id;
                    }
                    else
                    {
                        this._item = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "PurchaseOrder_LinePurchaseOrder", Storage = "_PurchaseOrder", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public PurchaseOrder PurchaseOrder
        {
            get
            {
                return this._PurchaseOrder.Entity;
            }
            set
            {
                PurchaseOrder previousValue = this._PurchaseOrder.Entity;
                if (((previousValue != value)
                            || (this._PurchaseOrder.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._PurchaseOrder.Entity = null;
                        previousValue.LinePurchaseOrders.Remove(this);
                    }
                    this._PurchaseOrder.Entity = value;
                    if ((value != null))
                    {
                        value.LinePurchaseOrders.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("PurchaseOrder");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineSalesInvoice")]
    public partial class LineSalesInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private decimal _price;

        private decimal _quantity;

        private string _VATCode;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<SalesInvoice> _SalesInvoice;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(decimal value);
        partial void OnquantityChanged();
        partial void OnVATCodeChanging(string value);
        partial void OnVATCodeChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineSalesInvoice()
        {
            this._Article = default(EntityRef<Article>);
            this._SalesInvoice = default(EntityRef<SalesInvoice>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._SalesInvoice.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string item
        {
            get
            {
                return this._item;
            }
            set
            {
                if ((this._item != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    this.OnunitChanging(value);
                    this.SendPropertyChanging();
                    this._unit = value;
                    this.SendPropertyChanged("unit");
                    this.OnunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Decimal(10,2) NOT NULL")]
        public decimal quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VATCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VATCode
        {
            get
            {
                return this._VATCode;
            }
            set
            {
                if ((this._VATCode != value))
                {
                    this.OnVATCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VATCode = value;
                    this.SendPropertyChanged("VATCode");
                    this.OnVATCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineSalesInvoice", Storage = "_Article", ThisKey = "item", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.LineSalesInvoices.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.LineSalesInvoices.Add(this);
                        this._item = value.id;
                    }
                    else
                    {
                        this._item = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "SalesInvoice_LineSalesInvoice", Storage = "_SalesInvoice", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public SalesInvoice SalesInvoice
        {
            get
            {
                return this._SalesInvoice.Entity;
            }
            set
            {
                SalesInvoice previousValue = this._SalesInvoice.Entity;
                if (((previousValue != value)
                            || (this._SalesInvoice.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._SalesInvoice.Entity = null;
                        previousValue.LineSalesInvoices.Remove(this);
                    }
                    this._SalesInvoice.Entity = value;
                    if ((value != null))
                    {
                        value.LineSalesInvoices.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("SalesInvoice");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineSalesOrder")]
    public partial class LineSalesOrder : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private decimal _price;

        private decimal _quantity;

        private string _VatCode;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<SalesOrder> _SalesOrder;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(decimal value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(decimal value);
        partial void OnquantityChanged();
        partial void OnVatCodeChanging(string value);
        partial void OnVatCodeChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineSalesOrder()
        {
            this._Article = default(EntityRef<Article>);
            this._SalesOrder = default(EntityRef<SalesOrder>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._SalesOrder.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string item
        {
            get
            {
                return this._item;
            }
            set
            {
                if ((this._item != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    this.OnunitChanging(value);
                    this.SendPropertyChanging();
                    this._unit = value;
                    this.SendPropertyChanged("unit");
                    this.OnunitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money NOT NULL")]
        public decimal price
        {
            get
            {
                return this._price;
            }
            set
            {
                if ((this._price != value))
                {
                    this.OnpriceChanging(value);
                    this.SendPropertyChanging();
                    this._price = value;
                    this.SendPropertyChanged("price");
                    this.OnpriceChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Decimal(10,2) NOT NULL")]
        public decimal quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string VatCode
        {
            get
            {
                return this._VatCode;
            }
            set
            {
                if ((this._VatCode != value))
                {
                    this.OnVatCodeChanging(value);
                    this.SendPropertyChanging();
                    this._VatCode = value;
                    this.SendPropertyChanged("VatCode");
                    this.OnVatCodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(255)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_LineSalesOrder", Storage = "_Article", ThisKey = "item", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.LineSalesOrders.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.LineSalesOrders.Add(this);
                        this._item = value.id;
                    }
                    else
                    {
                        this._item = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "SalesOrder_LineSalesOrder", Storage = "_SalesOrder", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public SalesOrder SalesOrder
        {
            get
            {
                return this._SalesOrder.Entity;
            }
            set
            {
                SalesOrder previousValue = this._SalesOrder.Entity;
                if (((previousValue != value)
                            || (this._SalesOrder.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._SalesOrder.Entity = null;
                        previousValue.LineSalesOrders.Remove(this);
                    }
                    this._SalesOrder.Entity = value;
                    if ((value != null))
                    {
                        value.LineSalesOrders.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("SalesOrder");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineSettlement")]
    public partial class LineSettlement : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _account;

        private bool _side;

        private string _oaccount;

        private decimal _amount;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<Settlement> _Settlement;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(bool value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(decimal value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineSettlement()
        {
            this._Settlement = default(EntityRef<Settlement>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._Settlement.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "Bit NOT NULL")]
        public bool side
        {
            get
            {
                return this._side;
            }
            set
            {
                if ((this._side != value))
                {
                    this.OnsideChanging(value);
                    this.SendPropertyChanging();
                    this._side = value;
                    this.SendPropertyChanged("side");
                    this.OnsideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string oaccount
        {
            get
            {
                return this._oaccount;
            }
            set
            {
                if ((this._oaccount != value))
                {
                    this.OnoaccountChanging(value);
                    this.SendPropertyChanging();
                    this._oaccount = value;
                    this.SendPropertyChanged("oaccount");
                    this.OnoaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money NOT NULL")]
        public decimal amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if ((this._amount != value))
                {
                    this.OnamountChanging(value);
                    this.SendPropertyChanging();
                    this._amount = value;
                    this.SendPropertyChanged("amount");
                    this.OnamountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Settlement_LineSettlement", Storage = "_Settlement", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public Settlement Settlement
        {
            get
            {
                return this._Settlement.Entity;
            }
            set
            {
                Settlement previousValue = this._Settlement.Entity;
                if (((previousValue != value)
                            || (this._Settlement.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Settlement.Entity = null;
                        previousValue.LineSettlements.Remove(this);
                    }
                    this._Settlement.Entity = value;
                    if ((value != null))
                    {
                        value.LineSettlements.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("Settlement");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineVendorInvoice")]
    public partial class LineVendorInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private int _transid;

        private int _modelid;

        private string _account;

        private bool _side;

        private string _oaccount;

        private decimal _amount;

        private System.DateTime _duedate;

        private string _text;

        private string _Currency;

        private EntityRef<VendorInvoice> _VendorInvoice;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(int value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(bool value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(decimal value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.DateTime value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public LineVendorInvoice()
        {
            this._VendorInvoice = default(EntityRef<VendorInvoice>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int NOT NULL")]
        public int transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
                    if (this._VendorInvoice.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OntransidChanging(value);
                    this.SendPropertyChanging();
                    this._transid = value;
                    this.SendPropertyChanged("transid");
                    this.OntransidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "Bit NOT NULL")]
        public bool side
        {
            get
            {
                return this._side;
            }
            set
            {
                if ((this._side != value))
                {
                    this.OnsideChanging(value);
                    this.SendPropertyChanging();
                    this._side = value;
                    this.SendPropertyChanged("side");
                    this.OnsideChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string oaccount
        {
            get
            {
                return this._oaccount;
            }
            set
            {
                if ((this._oaccount != value))
                {
                    this.OnoaccountChanging(value);
                    this.SendPropertyChanging();
                    this._oaccount = value;
                    this.SendPropertyChanged("oaccount");
                    this.OnoaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money NOT NULL")]
        public decimal amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                if ((this._amount != value))
                {
                    this.OnamountChanging(value);
                    this.SendPropertyChanging();
                    this._amount = value;
                    this.SendPropertyChanged("amount");
                    this.OnamountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2 NOT NULL")]
        public System.DateTime duedate
        {
            get
            {
                return this._duedate;
            }
            set
            {
                if ((this._duedate != value))
                {
                    this.OnduedateChanging(value);
                    this.SendPropertyChanging();
                    this._duedate = value;
                    this.SendPropertyChanged("duedate");
                    this.OnduedateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "VendorInvoice_LineVendorInvoice", Storage = "_VendorInvoice", ThisKey = "transid", OtherKey = "id", IsForeignKey = true)]
        public VendorInvoice VendorInvoice
        {
            get
            {
                return this._VendorInvoice.Entity;
            }
            set
            {
                VendorInvoice previousValue = this._VendorInvoice.Entity;
                if (((previousValue != value)
                            || (this._VendorInvoice.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._VendorInvoice.Entity = null;
                        previousValue.LineVendorInvoices.Remove(this);
                    }
                    this._VendorInvoice.Entity = value;
                    if ((value != null))
                    {
                        value.LineVendorInvoices.Add(this);
                        this._transid = value.id;
                    }
                    else
                    {
                        this._transid = default(int);
                    }
                    this.SendPropertyChanged("VendorInvoice");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Localization")]
    public partial class Localization : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _ItemName;

        private string _UICulture;

        private string _LocalName;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnItemNameChanging(string value);
        partial void OnItemNameChanged();
        partial void OnUICultureChanging(string value);
        partial void OnUICultureChanged();
        partial void OnLocalNameChanging(string value);
        partial void OnLocalNameChanged();
        #endregion

        public Localization()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemName", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string ItemName
        {
            get
            {
                return this._ItemName;
            }
            set
            {
                if ((this._ItemName != value))
                {
                    this.OnItemNameChanging(value);
                    this.SendPropertyChanging();
                    this._ItemName = value;
                    this.SendPropertyChanged("ItemName");
                    this.OnItemNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UICulture", DbType = "Char(5) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string UICulture
        {
            get
            {
                return this._UICulture;
            }
            set
            {
                if ((this._UICulture != value))
                {
                    this.OnUICultureChanging(value);
                    this.SendPropertyChanging();
                    this._UICulture = value;
                    this.SendPropertyChanged("UICulture");
                    this.OnUICultureChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_LocalName", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string LocalName
        {
            get
            {
                return this._LocalName;
            }
            set
            {
                if ((this._LocalName != value))
                {
                    this.OnLocalNameChanging(value);
                    this.SendPropertyChanging();
                    this._LocalName = value;
                    this.SendPropertyChanged("LocalName");
                    this.OnLocalNameChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Menu")]
    public partial class Menu : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _ID;

        private string _CompanyID;

        private string _Name;

        private string _Action;

        private string _Controller;

        private string _Roles;

        private System.Nullable<bool> _Disable;

        private System.Nullable<bool> _HasAccess;

        private System.Nullable<int> _Parent;

        private System.Nullable<int> _MenuOrder;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnActionChanging(string value);
        partial void OnActionChanged();
        partial void OnControllerChanging(string value);
        partial void OnControllerChanged();
        partial void OnRolesChanging(string value);
        partial void OnRolesChanged();
        partial void OnDisableChanging(System.Nullable<bool> value);
        partial void OnDisableChanged();
        partial void OnHasAccessChanging(System.Nullable<bool> value);
        partial void OnHasAccessChanged();
        partial void OnParentChanging(System.Nullable<int> value);
        partial void OnParentChanged();
        partial void OnMenuOrderChanging(System.Nullable<int> value);
        partial void OnMenuOrderChanged();
        #endregion

        public Menu()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ID", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if ((this._ID != value))
                {
                    this.OnIDChanging(value);
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                    this.OnIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(50)")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Action", DbType = "NVarChar(50)")]
        public string Action
        {
            get
            {
                return this._Action;
            }
            set
            {
                if ((this._Action != value))
                {
                    this.OnActionChanging(value);
                    this.SendPropertyChanging();
                    this._Action = value;
                    this.SendPropertyChanged("Action");
                    this.OnActionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Controller", DbType = "NVarChar(50)")]
        public string Controller
        {
            get
            {
                return this._Controller;
            }
            set
            {
                if ((this._Controller != value))
                {
                    this.OnControllerChanging(value);
                    this.SendPropertyChanging();
                    this._Controller = value;
                    this.SendPropertyChanged("Controller");
                    this.OnControllerChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Roles", DbType = "NVarChar(150)")]
        public string Roles
        {
            get
            {
                return this._Roles;
            }
            set
            {
                if ((this._Roles != value))
                {
                    this.OnRolesChanging(value);
                    this.SendPropertyChanging();
                    this._Roles = value;
                    this.SendPropertyChanged("Roles");
                    this.OnRolesChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Disable", DbType = "Bit")]
        public System.Nullable<bool> Disable
        {
            get
            {
                return this._Disable;
            }
            set
            {
                if ((this._Disable != value))
                {
                    this.OnDisableChanging(value);
                    this.SendPropertyChanging();
                    this._Disable = value;
                    this.SendPropertyChanged("Disable");
                    this.OnDisableChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_HasAccess", DbType = "Bit")]
        public System.Nullable<bool> HasAccess
        {
            get
            {
                return this._HasAccess;
            }
            set
            {
                if ((this._HasAccess != value))
                {
                    this.OnHasAccessChanging(value);
                    this.SendPropertyChanging();
                    this._HasAccess = value;
                    this.SendPropertyChanged("HasAccess");
                    this.OnHasAccessChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Parent", DbType = "Int")]
        public System.Nullable<int> Parent
        {
            get
            {
                return this._Parent;
            }
            set
            {
                if ((this._Parent != value))
                {
                    this.OnParentChanging(value);
                    this.SendPropertyChanging();
                    this._Parent = value;
                    this.SendPropertyChanged("Parent");
                    this.OnParentChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_MenuOrder", DbType = "Int")]
        public System.Nullable<int> MenuOrder
        {
            get
            {
                return this._MenuOrder;
            }
            set
            {
                if ((this._MenuOrder != value))
                {
                    this.OnMenuOrderChanging(value);
                    this.SendPropertyChanging();
                    this._MenuOrder = value;
                    this.SendPropertyChanged("MenuOrder");
                    this.OnMenuOrderChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Payment")]
    public partial class Payment : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LinePayment> _LinePayments;

        private EntityRef<Company> _Company;

        private EntityRef<Supplier> _Supplier;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public Payment()
        {
            this._LinePayments = new EntitySet<LinePayment>(new Action<LinePayment>(this.attach_LinePayments), new Action<LinePayment>(this.detach_LinePayments));
            this._Company = default(EntityRef<Company>);
            this._Supplier = default(EntityRef<Supplier>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Supplier.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Payment_LinePayment", Storage = "_LinePayments", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LinePayment> LinePayments
        {
            get
            {
                return this._LinePayments;
            }
            set
            {
                this._LinePayments.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_Payment", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.Payments.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.Payments.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_Payment", Storage = "_Supplier", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Supplier Supplier
        {
            get
            {
                return this._Supplier.Entity;
            }
            set
            {
                Supplier previousValue = this._Supplier.Entity;
                if (((previousValue != value)
                            || (this._Supplier.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Supplier.Entity = null;
                        previousValue.Payments.Remove(this);
                    }
                    this._Supplier.Entity = value;
                    if ((value != null))
                    {
                        value.Payments.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Supplier");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LinePayments(LinePayment entity)
        {
            this.SendPropertyChanging();
            entity.Payment = this;
        }

        private void detach_LinePayments(LinePayment entity)
        {
            this.SendPropertyChanging();
            entity.Payment = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.PeriodicAccountBalance")]
    public partial class PeriodicAccountBalance : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Name;

        private int _ModelId;

        private string _Description;

        private string _AccountId;

        private string _Periode;

        private decimal _Debit;

        private decimal _Credit;

        private string _CompanyID;

        private string _Currency;

        private EntityRef<Account> _Account;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnModelIdChanging(int value);
        partial void OnModelIdChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnAccountIdChanging(string value);
        partial void OnAccountIdChanged();
        partial void OnPeriodeChanging(string value);
        partial void OnPeriodeChanged();
        partial void OnDebitChanging(decimal value);
        partial void OnDebitChanged();
        partial void OnCreditChanging(decimal value);
        partial void OnCreditChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public PeriodicAccountBalance()
        {
            this._Account = default(EntityRef<Account>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ModelId", DbType = "Int NOT NULL")]
        public int ModelId
        {
            get
            {
                return this._ModelId;
            }
            set
            {
                if ((this._ModelId != value))
                {
                    this.OnModelIdChanging(value);
                    this.SendPropertyChanging();
                    this._ModelId = value;
                    this.SendPropertyChanged("ModelId");
                    this.OnModelIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Description", DbType = "NChar(10)")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                if ((this._Description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._Description = value;
                    this.SendPropertyChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_AccountId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string AccountId
        {
            get
            {
                return this._AccountId;
            }
            set
            {
                if ((this._AccountId != value))
                {
                    if (this._Account.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnAccountIdChanging(value);
                    this.SendPropertyChanging();
                    this._AccountId = value;
                    this.SendPropertyChanged("AccountId");
                    this.OnAccountIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Periode", DbType = "NChar(6) NOT NULL", CanBeNull = false)]
        public string Periode
        {
            get
            {
                return this._Periode;
            }
            set
            {
                if ((this._Periode != value))
                {
                    this.OnPeriodeChanging(value);
                    this.SendPropertyChanging();
                    this._Periode = value;
                    this.SendPropertyChanged("Periode");
                    this.OnPeriodeChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Debit", DbType = "Decimal(18,2) NOT NULL")]
        public decimal Debit
        {
            get
            {
                return this._Debit;
            }
            set
            {
                if ((this._Debit != value))
                {
                    this.OnDebitChanging(value);
                    this.SendPropertyChanging();
                    this._Debit = value;
                    this.SendPropertyChanged("Debit");
                    this.OnDebitChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Credit", DbType = "Decimal(18,2) NOT NULL")]
        public decimal Credit
        {
            get
            {
                return this._Credit;
            }
            set
            {
                if ((this._Credit != value))
                {
                    this.OnCreditChanging(value);
                    this.SendPropertyChanging();
                    this._Credit = value;
                    this.SendPropertyChanged("Credit");
                    this.OnCreditChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Account_PeriodicAccountBalance", Storage = "_Account", ThisKey = "AccountId", OtherKey = "id", IsForeignKey = true)]
        public Account Account
        {
            get
            {
                return this._Account.Entity;
            }
            set
            {
                Account previousValue = this._Account.Entity;
                if (((previousValue != value)
                            || (this._Account.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Account.Entity = null;
                        previousValue.PeriodicAccountBalances.Remove(this);
                    }
                    this._Account.Entity = value;
                    if ((value != null))
                    {
                        value.PeriodicAccountBalances.Add(this);
                        this._AccountId = value.id;
                    }
                    else
                    {
                        this._AccountId = default(string);
                    }
                    this.SendPropertyChanged("Account");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.PurchaseOrder")]
    public partial class PurchaseOrder : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LinePurchaseOrder> _LinePurchaseOrders;

        private EntityRef<Company> _Company;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public PurchaseOrder()
        {
            this._LinePurchaseOrders = new EntitySet<LinePurchaseOrder>(new Action<LinePurchaseOrder>(this.attach_LinePurchaseOrders), new Action<LinePurchaseOrder>(this.detach_LinePurchaseOrders));
            this._Company = default(EntityRef<Company>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "PurchaseOrder_LinePurchaseOrder", Storage = "_LinePurchaseOrders", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LinePurchaseOrder> LinePurchaseOrders
        {
            get
            {
                return this._LinePurchaseOrders;
            }
            set
            {
                this._LinePurchaseOrders.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_PurchaseOrder", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.PurchaseOrders.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.PurchaseOrders.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LinePurchaseOrders(LinePurchaseOrder entity)
        {
            this.SendPropertyChanging();
            entity.PurchaseOrder = this;
        }

        private void detach_LinePurchaseOrders(LinePurchaseOrder entity)
        {
            this.SendPropertyChanging();
            entity.PurchaseOrder = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.QuantityUnit")]
    public partial class QuantityUnit : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private short _modelid;

        private string _description;

        private string _CompanyID;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(short value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public QuantityUnit()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "SmallInt NOT NULL")]
        public short modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.SalesInvoice")]
    public partial class SalesInvoice : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineSalesInvoice> _LineSalesInvoices;

        private EntityRef<Company> _Company;

        private EntityRef<Customer> _Customer;

        private EntityRef<Store> _Store1;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public SalesInvoice()
        {
            this._LineSalesInvoices = new EntitySet<LineSalesInvoice>(new Action<LineSalesInvoice>(this.attach_LineSalesInvoices), new Action<LineSalesInvoice>(this.detach_LineSalesInvoices));
            this._Company = default(EntityRef<Company>);
            this._Customer = default(EntityRef<Customer>);
            this._Store1 = default(EntityRef<Store>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    if (this._Store1.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Customer.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50)")]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50)")]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "SalesInvoice_LineSalesInvoice", Storage = "_LineSalesInvoices", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineSalesInvoice> LineSalesInvoices
        {
            get
            {
                return this._LineSalesInvoices;
            }
            set
            {
                this._LineSalesInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_SalesInvoice", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.SalesInvoices.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.SalesInvoices.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_SalesInvoice", Storage = "_Customer", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Customer Customer
        {
            get
            {
                return this._Customer.Entity;
            }
            set
            {
                Customer previousValue = this._Customer.Entity;
                if (((previousValue != value)
                            || (this._Customer.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Customer.Entity = null;
                        previousValue.SalesInvoices.Remove(this);
                    }
                    this._Customer.Entity = value;
                    if ((value != null))
                    {
                        value.SalesInvoices.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Customer");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_SalesInvoice", Storage = "_Store1", ThisKey = "store", OtherKey = "id", IsForeignKey = true)]
        public Store Store1
        {
            get
            {
                return this._Store1.Entity;
            }
            set
            {
                Store previousValue = this._Store1.Entity;
                if (((previousValue != value)
                            || (this._Store1.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Store1.Entity = null;
                        previousValue.SalesInvoices.Remove(this);
                    }
                    this._Store1.Entity = value;
                    if ((value != null))
                    {
                        value.SalesInvoices.Add(this);
                        this._store = value.id;
                    }
                    else
                    {
                        this._store = default(string);
                    }
                    this.SendPropertyChanged("Store1");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineSalesInvoices(LineSalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.SalesInvoice = this;
        }

        private void detach_LineSalesInvoices(LineSalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.SalesInvoice = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.SalesOrder")]
    public partial class SalesOrder : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineSalesOrder> _LineSalesOrders;

        private EntityRef<Company> _Company;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public SalesOrder()
        {
            this._LineSalesOrders = new EntitySet<LineSalesOrder>(new Action<LineSalesOrder>(this.attach_LineSalesOrders), new Action<LineSalesOrder>(this.detach_LineSalesOrders));
            this._Company = default(EntityRef<Company>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "SalesOrder_LineSalesOrder", Storage = "_LineSalesOrders", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineSalesOrder> LineSalesOrders
        {
            get
            {
                return this._LineSalesOrders;
            }
            set
            {
                this._LineSalesOrders.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_SalesOrder", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.SalesOrders.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.SalesOrders.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineSalesOrders(LineSalesOrder entity)
        {
            this.SendPropertyChanging();
            entity.SalesOrder = this;
        }

        private void detach_LineSalesOrders(LineSalesOrder entity)
        {
            this.SendPropertyChanging();
            entity.SalesOrder = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Settlement")]
    public partial class Settlement : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private string _text;

        private System.DateTime _ItemDate;

        private string _CompanyId;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineSettlement> _LineSettlements;

        private EntityRef<Company> _Company;

        private EntityRef<Customer> _Customer;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnoidChanging(System.Nullable<int> value);
        partial void OnoidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstoreChanging(string value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnItemDateChanging(System.DateTime value);
        partial void OnItemDateChanged();
        partial void OnCompanyIdChanging(string value);
        partial void OnCompanyIdChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public Settlement()
        {
            this._LineSettlements = new EntitySet<LineSettlement>(new Action<LineSettlement>(this.attach_LineSettlements), new Action<LineSettlement>(this.detach_LineSettlements));
            this._Company = default(EntityRef<Company>);
            this._Customer = default(EntityRef<Customer>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oid", DbType = "Int")]
        public System.Nullable<int> oid
        {
            get
            {
                return this._oid;
            }
            set
            {
                if ((this._oid != value))
                {
                    this.OnoidChanging(value);
                    this.SendPropertyChanging();
                    this._oid = value;
                    this.SendPropertyChanged("oid");
                    this.OnoidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string store
        {
            get
            {
                return this._store;
            }
            set
            {
                if ((this._store != value))
                {
                    this.OnstoreChanging(value);
                    this.SendPropertyChanging();
                    this._store = value;
                    this.SendPropertyChanged("store");
                    this.OnstoreChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if ((this._account != value))
                {
                    if (this._Customer.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnaccountChanging(value);
                    this.SendPropertyChanging();
                    this._account = value;
                    this.SendPropertyChanged("account");
                    this.OnaccountChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_text", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string text
        {
            get
            {
                return this._text;
            }
            set
            {
                if ((this._text != value))
                {
                    this.OntextChanging(value);
                    this.SendPropertyChanging();
                    this._text = value;
                    this.SendPropertyChanged("text");
                    this.OntextChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date NOT NULL")]
        public System.DateTime ItemDate
        {
            get
            {
                return this._ItemDate;
            }
            set
            {
                if ((this._ItemDate != value))
                {
                    this.OnItemDateChanging(value);
                    this.SendPropertyChanging();
                    this._ItemDate = value;
                    this.SendPropertyChanged("ItemDate");
                    this.OnItemDateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyId", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyId
        {
            get
            {
                return this._CompanyId;
            }
            set
            {
                if ((this._CompanyId != value))
                {
                    if (this._Company.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnCompanyIdChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyId = value;
                    this.SendPropertyChanged("CompanyId");
                    this.OnCompanyIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IsValidated", DbType = "Bit")]
        public System.Nullable<bool> IsValidated
        {
            get
            {
                return this._IsValidated;
            }
            set
            {
                if ((this._IsValidated != value))
                {
                    this.OnIsValidatedChanging(value);
                    this.SendPropertyChanging();
                    this._IsValidated = value;
                    this.SendPropertyChanged("IsValidated");
                    this.OnIsValidatedChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Settlement_LineSettlement", Storage = "_LineSettlements", ThisKey = "id", OtherKey = "transid")]
        public EntitySet<LineSettlement> LineSettlements
        {
            get
            {
                return this._LineSettlements;
            }
            set
            {
                this._LineSettlements.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Company_Settlement", Storage = "_Company", ThisKey = "CompanyId", OtherKey = "id", IsForeignKey = true)]
        public Company Company
        {
            get
            {
                return this._Company.Entity;
            }
            set
            {
                Company previousValue = this._Company.Entity;
                if (((previousValue != value)
                            || (this._Company.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Company.Entity = null;
                        previousValue.Settlements.Remove(this);
                    }
                    this._Company.Entity = value;
                    if ((value != null))
                    {
                        value.Settlements.Add(this);
                        this._CompanyId = value.id;
                    }
                    else
                    {
                        this._CompanyId = default(string);
                    }
                    this.SendPropertyChanged("Company");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Customer_Settlement", Storage = "_Customer", ThisKey = "account", OtherKey = "id", IsForeignKey = true)]
        public Customer Customer
        {
            get
            {
                return this._Customer.Entity;
            }
            set
            {
                Customer previousValue = this._Customer.Entity;
                if (((previousValue != value)
                            || (this._Customer.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Customer.Entity = null;
                        previousValue.Settlements.Remove(this);
                    }
                    this._Customer.Entity = value;
                    if ((value != null))
                    {
                        value.Settlements.Add(this);
                        this._account = value.id;
                    }
                    else
                    {
                        this._account = default(string);
                    }
                    this.SendPropertyChanged("Customer");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_LineSettlements(LineSettlement entity)
        {
            this.SendPropertyChanging();
            entity.Settlement = this;
        }

        private void detach_LineSettlements(LineSettlement entity)
        {
            this.SendPropertyChanging();
            entity.Settlement = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Stock")]
    public partial class Stock : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _itemid;

        private string _storeid;

        private float _quantity;

        private short _minstock;

        private string _CompanyID;

        private string _Currency;

        private EntityRef<Article> _Article;

        private EntityRef<Store> _Store;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnitemidChanging(string value);
        partial void OnitemidChanged();
        partial void OnstoreidChanging(string value);
        partial void OnstoreidChanged();
        partial void OnquantityChanging(float value);
        partial void OnquantityChanged();
        partial void OnminstockChanging(short value);
        partial void OnminstockChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        #endregion

        public Stock()
        {
            this._Article = default(EntityRef<Article>);
            this._Store = default(EntityRef<Store>);
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", AutoSync = AutoSync.OnInsert, DbType = "Int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_itemid", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string itemid
        {
            get
            {
                return this._itemid;
            }
            set
            {
                if ((this._itemid != value))
                {
                    if (this._Article.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnitemidChanging(value);
                    this.SendPropertyChanging();
                    this._itemid = value;
                    this.SendPropertyChanged("itemid");
                    this.OnitemidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_storeid", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string storeid
        {
            get
            {
                return this._storeid;
            }
            set
            {
                if ((this._storeid != value))
                {
                    if (this._Store.HasLoadedOrAssignedValue)
                    {
                        throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
                    }
                    this.OnstoreidChanging(value);
                    this.SendPropertyChanging();
                    this._storeid = value;
                    this.SendPropertyChanged("storeid");
                    this.OnstoreidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Real NOT NULL")]
        public float quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                if ((this._quantity != value))
                {
                    this.OnquantityChanging(value);
                    this.SendPropertyChanging();
                    this._quantity = value;
                    this.SendPropertyChanged("quantity");
                    this.OnquantityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_minstock", DbType = "SmallInt NOT NULL")]
        public short minstock
        {
            get
            {
                return this._minstock;
            }
            set
            {
                if ((this._minstock != value))
                {
                    this.OnminstockChanging(value);
                    this.SendPropertyChanging();
                    this._minstock = value;
                    this.SendPropertyChanged("minstock");
                    this.OnminstockChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Currency", DbType = "NVarChar(10)")]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                if ((this._Currency != value))
                {
                    this.OnCurrencyChanging(value);
                    this.SendPropertyChanging();
                    this._Currency = value;
                    this.SendPropertyChanged("Currency");
                    this.OnCurrencyChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Article_Stock", Storage = "_Article", ThisKey = "itemid", OtherKey = "id", IsForeignKey = true)]
        public Article Article
        {
            get
            {
                return this._Article.Entity;
            }
            set
            {
                Article previousValue = this._Article.Entity;
                if (((previousValue != value)
                            || (this._Article.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Article.Entity = null;
                        previousValue.Stocks.Remove(this);
                    }
                    this._Article.Entity = value;
                    if ((value != null))
                    {
                        value.Stocks.Add(this);
                        this._itemid = value.id;
                    }
                    else
                    {
                        this._itemid = default(string);
                    }
                    this.SendPropertyChanged("Article");
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_Stock", Storage = "_Store", ThisKey = "storeid", OtherKey = "id", IsForeignKey = true)]
        public Store Store
        {
            get
            {
                return this._Store.Entity;
            }
            set
            {
                Store previousValue = this._Store.Entity;
                if (((previousValue != value)
                            || (this._Store.HasLoadedOrAssignedValue == false)))
                {
                    this.SendPropertyChanging();
                    if ((previousValue != null))
                    {
                        this._Store.Entity = null;
                        previousValue.Stocks.Remove(this);
                    }
                    this._Store.Entity = value;
                    if ((value != null))
                    {
                        value.Stocks.Add(this);
                        this._storeid = value.id;
                    }
                    else
                    {
                        this._storeid = default(string);
                    }
                    this.SendPropertyChanged("Store");
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Store")]
    public partial class Store : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private string _street;

        private string _city;

        private string _state;

        private string _zip;

        private int _modelid;

        private string _accountid;

        private string _CompanyID;

        private EntitySet<VendorInvoice> _VendorInvoices;

        private EntitySet<BillOfDelivery> _BillOfDeliveries;

        private EntitySet<GoodReceiving> _GoodReceivings;

        private EntitySet<InventoryInvoice> _InventoryInvoices;

        private EntitySet<SalesInvoice> _SalesInvoices;

        private EntitySet<Stock> _Stocks;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnstreetChanging(string value);
        partial void OnstreetChanged();
        partial void OncityChanging(string value);
        partial void OncityChanged();
        partial void OnstateChanging(string value);
        partial void OnstateChanged();
        partial void OnzipChanging(string value);
        partial void OnzipChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountidChanging(string value);
        partial void OnaccountidChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public Store()
        {
            this._VendorInvoices = new EntitySet<VendorInvoice>(new Action<VendorInvoice>(this.attach_VendorInvoices), new Action<VendorInvoice>(this.detach_VendorInvoices));
            this._BillOfDeliveries = new EntitySet<BillOfDelivery>(new Action<BillOfDelivery>(this.attach_BillOfDeliveries), new Action<BillOfDelivery>(this.detach_BillOfDeliveries));
            this._GoodReceivings = new EntitySet<GoodReceiving>(new Action<GoodReceiving>(this.attach_GoodReceivings), new Action<GoodReceiving>(this.detach_GoodReceivings));
            this._InventoryInvoices = new EntitySet<InventoryInvoice>(new Action<InventoryInvoice>(this.attach_InventoryInvoices), new Action<InventoryInvoice>(this.detach_InventoryInvoices));
            this._SalesInvoices = new EntitySet<SalesInvoice>(new Action<SalesInvoice>(this.attach_SalesInvoices), new Action<SalesInvoice>(this.detach_SalesInvoices));
            this._Stocks = new EntitySet<Stock>(new Action<Stock>(this.attach_Stocks), new Action<Stock>(this.detach_Stocks));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_street", DbType = "NVarChar(50)")]
        public string street
        {
            get
            {
                return this._street;
            }
            set
            {
                if ((this._street != value))
                {
                    this.OnstreetChanging(value);
                    this.SendPropertyChanging();
                    this._street = value;
                    this.SendPropertyChanged("street");
                    this.OnstreetChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_city", DbType = "NVarChar(50)")]
        public string city
        {
            get
            {
                return this._city;
            }
            set
            {
                if ((this._city != value))
                {
                    this.OncityChanging(value);
                    this.SendPropertyChanging();
                    this._city = value;
                    this.SendPropertyChanged("city");
                    this.OncityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_state", DbType = "NVarChar(50)")]
        public string state
        {
            get
            {
                return this._state;
            }
            set
            {
                if ((this._state != value))
                {
                    this.OnstateChanging(value);
                    this.SendPropertyChanging();
                    this._state = value;
                    this.SendPropertyChanged("state");
                    this.OnstateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_zip", DbType = "NVarChar(50)")]
        public string zip
        {
            get
            {
                return this._zip;
            }
            set
            {
                if ((this._zip != value))
                {
                    this.OnzipChanging(value);
                    this.SendPropertyChanging();
                    this._zip = value;
                    this.SendPropertyChanged("zip");
                    this.OnzipChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_accountid", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string accountid
        {
            get
            {
                return this._accountid;
            }
            set
            {
                if ((this._accountid != value))
                {
                    this.OnaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._accountid = value;
                    this.SendPropertyChanged("accountid");
                    this.OnaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_VendorInvoice", Storage = "_VendorInvoices", ThisKey = "id", OtherKey = "store")]
        public EntitySet<VendorInvoice> VendorInvoices
        {
            get
            {
                return this._VendorInvoices;
            }
            set
            {
                this._VendorInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_BillOfDelivery", Storage = "_BillOfDeliveries", ThisKey = "id", OtherKey = "store")]
        public EntitySet<BillOfDelivery> BillOfDeliveries
        {
            get
            {
                return this._BillOfDeliveries;
            }
            set
            {
                this._BillOfDeliveries.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_GoodReceiving", Storage = "_GoodReceivings", ThisKey = "id", OtherKey = "store")]
        public EntitySet<GoodReceiving> GoodReceivings
        {
            get
            {
                return this._GoodReceivings;
            }
            set
            {
                this._GoodReceivings.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_InventoryInvoice", Storage = "_InventoryInvoices", ThisKey = "id", OtherKey = "store")]
        public EntitySet<InventoryInvoice> InventoryInvoices
        {
            get
            {
                return this._InventoryInvoices;
            }
            set
            {
                this._InventoryInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_SalesInvoice", Storage = "_SalesInvoices", ThisKey = "id", OtherKey = "store")]
        public EntitySet<SalesInvoice> SalesInvoices
        {
            get
            {
                return this._SalesInvoices;
            }
            set
            {
                this._SalesInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Store_Stock", Storage = "_Stocks", ThisKey = "id", OtherKey = "storeid")]
        public EntitySet<Stock> Stocks
        {
            get
            {
                return this._Stocks;
            }
            set
            {
                this._Stocks.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_VendorInvoices(VendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = this;
        }

        private void detach_VendorInvoices(VendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = null;
        }

        private void attach_BillOfDeliveries(BillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = this;
        }

        private void detach_BillOfDeliveries(BillOfDelivery entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = null;
        }

        private void attach_GoodReceivings(GoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = this;
        }

        private void detach_GoodReceivings(GoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = null;
        }

        private void attach_InventoryInvoices(InventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = this;
        }

        private void detach_InventoryInvoices(InventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = null;
        }

        private void attach_SalesInvoices(SalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = this;
        }

        private void detach_SalesInvoices(SalesInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Store1 = null;
        }

        private void attach_Stocks(Stock entity)
        {
            this.SendPropertyChanging();
            entity.Store = this;
        }

        private void detach_Stocks(Stock entity)
        {
            this.SendPropertyChanging();
            entity.Store = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Supplier")]
    public partial class Supplier : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _street;

        private string _city;

        private string _state;

        private string _zip;

        private string _accountid;

        private string _CompanyID;

        private string _IBAN;

        private EntitySet<VendorInvoice> _VendorInvoices;

        private EntitySet<GoodReceiving> _GoodReceivings;

        private EntitySet<InventoryInvoice> _InventoryInvoices;

        private EntitySet<Payment> _Payments;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnstreetChanging(string value);
        partial void OnstreetChanged();
        partial void OncityChanging(string value);
        partial void OncityChanged();
        partial void OnstateChanging(string value);
        partial void OnstateChanged();
        partial void OnzipChanging(string value);
        partial void OnzipChanged();
        partial void OnaccountidChanging(string value);
        partial void OnaccountidChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        partial void OnIBANChanging(string value);
        partial void OnIBANChanged();
        #endregion

        public Supplier()
        {
            this._VendorInvoices = new EntitySet<VendorInvoice>(new Action<VendorInvoice>(this.attach_VendorInvoices), new Action<VendorInvoice>(this.detach_VendorInvoices));
            this._GoodReceivings = new EntitySet<GoodReceiving>(new Action<GoodReceiving>(this.attach_GoodReceivings), new Action<GoodReceiving>(this.detach_GoodReceivings));
            this._InventoryInvoices = new EntitySet<InventoryInvoice>(new Action<InventoryInvoice>(this.attach_InventoryInvoices), new Action<InventoryInvoice>(this.detach_InventoryInvoices));
            this._Payments = new EntitySet<Payment>(new Action<Payment>(this.attach_Payments), new Action<Payment>(this.detach_Payments));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "Int NOT NULL")]
        public int modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_street", DbType = "NVarChar(255)")]
        public string street
        {
            get
            {
                return this._street;
            }
            set
            {
                if ((this._street != value))
                {
                    this.OnstreetChanging(value);
                    this.SendPropertyChanging();
                    this._street = value;
                    this.SendPropertyChanged("street");
                    this.OnstreetChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_city", DbType = "NVarChar(255)")]
        public string city
        {
            get
            {
                return this._city;
            }
            set
            {
                if ((this._city != value))
                {
                    this.OncityChanging(value);
                    this.SendPropertyChanging();
                    this._city = value;
                    this.SendPropertyChanged("city");
                    this.OncityChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_state", DbType = "NVarChar(255)")]
        public string state
        {
            get
            {
                return this._state;
            }
            set
            {
                if ((this._state != value))
                {
                    this.OnstateChanging(value);
                    this.SendPropertyChanging();
                    this._state = value;
                    this.SendPropertyChanged("state");
                    this.OnstateChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_zip", DbType = "NVarChar(255)")]
        public string zip
        {
            get
            {
                return this._zip;
            }
            set
            {
                if ((this._zip != value))
                {
                    this.OnzipChanging(value);
                    this.SendPropertyChanging();
                    this._zip = value;
                    this.SendPropertyChanged("zip");
                    this.OnzipChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_accountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string accountid
        {
            get
            {
                return this._accountid;
            }
            set
            {
                if ((this._accountid != value))
                {
                    this.OnaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._accountid = value;
                    this.SendPropertyChanged("accountid");
                    this.OnaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_IBAN", DbType = "NVarChar(50)")]
        public string IBAN
        {
            get
            {
                return this._IBAN;
            }
            set
            {
                if ((this._IBAN != value))
                {
                    this.OnIBANChanging(value);
                    this.SendPropertyChanging();
                    this._IBAN = value;
                    this.SendPropertyChanged("IBAN");
                    this.OnIBANChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_VendorInvoice", Storage = "_VendorInvoices", ThisKey = "id", OtherKey = "account")]
        public EntitySet<VendorInvoice> VendorInvoices
        {
            get
            {
                return this._VendorInvoices;
            }
            set
            {
                this._VendorInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_GoodReceiving", Storage = "_GoodReceivings", ThisKey = "id", OtherKey = "account")]
        public EntitySet<GoodReceiving> GoodReceivings
        {
            get
            {
                return this._GoodReceivings;
            }
            set
            {
                this._GoodReceivings.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_InventoryInvoice", Storage = "_InventoryInvoices", ThisKey = "id", OtherKey = "account")]
        public EntitySet<InventoryInvoice> InventoryInvoices
        {
            get
            {
                return this._InventoryInvoices;
            }
            set
            {
                this._InventoryInvoices.Assign(value);
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Supplier_Payment", Storage = "_Payments", ThisKey = "id", OtherKey = "account")]
        public EntitySet<Payment> Payments
        {
            get
            {
                return this._Payments;
            }
            set
            {
                this._Payments.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_VendorInvoices(VendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = this;
        }

        private void detach_VendorInvoices(VendorInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = null;
        }

        private void attach_GoodReceivings(GoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = this;
        }

        private void detach_GoodReceivings(GoodReceiving entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = null;
        }

        private void attach_InventoryInvoices(InventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = this;
        }

        private void detach_InventoryInvoices(InventoryInvoice entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = null;
        }

        private void attach_Payments(Payment entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = this;
        }

        private void detach_Payments(Payment entity)
        {
            this.SendPropertyChanging();
            entity.Supplier = null;
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Vat")]
    public partial class Vat : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private short _modelid;

        private string _description;

        private decimal _PVat;

        private string _inputvataccountid;

        private string _outputvataccountid;

        private string _revenueaccountid;

        private string _stockaccountid;

        private string _expenseaccountid;

        private string _CompanyID;

        private EntitySet<Article> _Articles;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(string value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnmodelidChanging(short value);
        partial void OnmodelidChanged();
        partial void OndescriptionChanging(string value);
        partial void OndescriptionChanged();
        partial void OnPVatChanging(decimal value);
        partial void OnPVatChanged();
        partial void OninputvataccountidChanging(string value);
        partial void OninputvataccountidChanged();
        partial void OnoutputvataccountidChanging(string value);
        partial void OnoutputvataccountidChanged();
        partial void OnrevenueaccountidChanging(string value);
        partial void OnrevenueaccountidChanged();
        partial void OnstockaccountidChanging(string value);
        partial void OnstockaccountidChanged();
        partial void OnexpenseaccountidChanging(string value);
        partial void OnexpenseaccountidChanged();
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        #endregion

        public Vat()
        {
            this._Articles = new EntitySet<Article>(new Action<Article>(this.attach_Articles), new Action<Article>(this.detach_Articles));
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_id", DbType = "NVarChar(50) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnidChanging(value);
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                    this.OnidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnnameChanging(value);
                    this.SendPropertyChanging();
                    this._name = value;
                    this.SendPropertyChanged("name");
                    this.OnnameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_modelid", DbType = "SmallInt NOT NULL")]
        public short modelid
        {
            get
            {
                return this._modelid;
            }
            set
            {
                if ((this._modelid != value))
                {
                    this.OnmodelidChanging(value);
                    this.SendPropertyChanging();
                    this._modelid = value;
                    this.SendPropertyChanged("modelid");
                    this.OnmodelidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_description", DbType = "NVarChar(255)")]
        public string description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OndescriptionChanging(value);
                    this.SendPropertyChanging();
                    this._description = value;
                    this.SendPropertyChanged("description");
                    this.OndescriptionChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_PVat", DbType = "Decimal(3,2) NOT NULL")]
        public decimal PVat
        {
            get
            {
                return this._PVat;
            }
            set
            {
                if ((this._PVat != value))
                {
                    this.OnPVatChanging(value);
                    this.SendPropertyChanging();
                    this._PVat = value;
                    this.SendPropertyChanged("PVat");
                    this.OnPVatChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_inputvataccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string inputvataccountid
        {
            get
            {
                return this._inputvataccountid;
            }
            set
            {
                if ((this._inputvataccountid != value))
                {
                    this.OninputvataccountidChanging(value);
                    this.SendPropertyChanging();
                    this._inputvataccountid = value;
                    this.SendPropertyChanged("inputvataccountid");
                    this.OninputvataccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_outputvataccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string outputvataccountid
        {
            get
            {
                return this._outputvataccountid;
            }
            set
            {
                if ((this._outputvataccountid != value))
                {
                    this.OnoutputvataccountidChanging(value);
                    this.SendPropertyChanging();
                    this._outputvataccountid = value;
                    this.SendPropertyChanged("outputvataccountid");
                    this.OnoutputvataccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_revenueaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string revenueaccountid
        {
            get
            {
                return this._revenueaccountid;
            }
            set
            {
                if ((this._revenueaccountid != value))
                {
                    this.OnrevenueaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._revenueaccountid = value;
                    this.SendPropertyChanged("revenueaccountid");
                    this.OnrevenueaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_stockaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string stockaccountid
        {
            get
            {
                return this._stockaccountid;
            }
            set
            {
                if ((this._stockaccountid != value))
                {
                    this.OnstockaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._stockaccountid = value;
                    this.SendPropertyChanged("stockaccountid");
                    this.OnstockaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_expenseaccountid", DbType = "NVarChar(255) NOT NULL", CanBeNull = false)]
        public string expenseaccountid
        {
            get
            {
                return this._expenseaccountid;
            }
            set
            {
                if ((this._expenseaccountid != value))
                {
                    this.OnexpenseaccountidChanging(value);
                    this.SendPropertyChanging();
                    this._expenseaccountid = value;
                    this.SendPropertyChanged("expenseaccountid");
                    this.OnexpenseaccountidChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CompanyID", DbType = "NVarChar(50) NOT NULL", CanBeNull = false)]
        public string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                if ((this._CompanyID != value))
                {
                    this.OnCompanyIDChanging(value);
                    this.SendPropertyChanging();
                    this._CompanyID = value;
                    this.SendPropertyChanged("CompanyID");
                    this.OnCompanyIDChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.AssociationAttribute(Name = "Vat_Article", Storage = "_Articles", ThisKey = "id", OtherKey = "VatCode")]
        public EntitySet<Article> Articles
        {
            get
            {
                return this._Articles;
            }
            set
            {
                this._Articles.Assign(value);
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void attach_Articles(Article entity)
        {
            this.SendPropertyChanging();
            entity.Vat = this;
        }

        private void detach_Articles(Article entity)
        {
            this.SendPropertyChanging();
            entity.Vat = null;
        }
    }
}