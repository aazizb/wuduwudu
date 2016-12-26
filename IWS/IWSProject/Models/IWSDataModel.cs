﻿
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
        partial void InsertCustomer(Customer instance);
        partial void UpdateCustomer(Customer instance);
        partial void DeleteCustomer(Customer instance);
        partial void InsertGoodReceiving(GoodReceiving instance);
        partial void UpdateGoodReceiving(GoodReceiving instance);
        partial void DeleteGoodReceiving(GoodReceiving instance);
        partial void InsertInventoryInvoice(InventoryInvoice instance);
        partial void UpdateInventoryInvoice(InventoryInvoice instance);
        partial void DeleteInventoryInvoice(InventoryInvoice instance);
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
        partial void InsertLineVendorInvoice(LineVendorInvoice instance);
        partial void UpdateLineVendorInvoice(LineVendorInvoice instance);
        partial void DeleteLineVendorInvoice(LineVendorInvoice instance);
        partial void InsertMenu(Menu instance);
        partial void UpdateMenu(Menu instance);
        partial void DeleteMenu(Menu instance);
        partial void InsertPayment(Payment instance);
        partial void UpdatePayment(Payment instance);
        partial void DeletePayment(Payment instance);
        partial void InsertPeriodicAccountBalance(PeriodicAccountBalance instance);
        partial void UpdatePeriodicAccountBalance(PeriodicAccountBalance instance);
        partial void DeletePeriodicAccountBalance(PeriodicAccountBalance instance);
        partial void InsertPerson(Person instance);
        partial void UpdatePerson(Person instance);
        partial void DeletePerson(Person instance);
        partial void InsertPurchaseOrder(PurchaseOrder instance);
        partial void UpdatePurchaseOrder(PurchaseOrder instance);
        partial void DeletePurchaseOrder(PurchaseOrder instance);
        partial void InsertQuantityUnit(QuantityUnit instance);
        partial void UpdateQuantityUnit(QuantityUnit instance);
        partial void DeleteQuantityUnit(QuantityUnit instance);
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

        public System.Data.Linq.Table<Customer> Customers
        {
            get
            {
                return this.GetTable<Customer>();
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

        public System.Data.Linq.Table<LineVendorInvoice> LineVendorInvoices
        {
            get
            {
                return this.GetTable<LineVendorInvoice>();
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

        public System.Data.Linq.Table<Person> Persons
        {
            get
            {
                return this.GetTable<Person>();
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

        private System.Nullable<decimal> _balance;

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
        partial void OnbalanceChanging(System.Nullable<decimal> value);
        partial void OnbalanceChanged();
        #endregion

        public Account()
        {
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_balance", DbType = "Money")]
        public System.Nullable<decimal> balance
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

        private System.Nullable<bool> _IsValidated;

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
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public VendorInvoice()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50)")]
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Article")]
    public partial class Article : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private System.Nullable<decimal> _price;

        private System.Nullable<decimal> _avgprice;

        private System.Nullable<decimal> _salesprice;

        private string _qttyunit;

        private string _packunit;

        private string _groupid;

        private string _VatCode;

        private bool _IsService;

        private EntitySet<LineGoodReceiving> _LineGoodReceivings;

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
        partial void OnpriceChanging(System.Nullable<decimal> value);
        partial void OnpriceChanged();
        partial void OnavgpriceChanging(System.Nullable<decimal> value);
        partial void OnavgpriceChanged();
        partial void OnsalespriceChanging(System.Nullable<decimal> value);
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
        #endregion

        public Article()
        {
            this._LineGoodReceivings = new EntitySet<LineGoodReceiving>(new Action<LineGoodReceiving>(this.attach_LineGoodReceivings), new Action<LineGoodReceiving>(this.detach_LineGoodReceivings));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money")]
        public System.Nullable<decimal> price
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_avgprice", DbType = "Money")]
        public System.Nullable<decimal> avgprice
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_salesprice", DbType = "Money")]
        public System.Nullable<decimal> salesprice
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50)")]
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

        private System.Nullable<decimal> _debit;

        private System.Nullable<decimal> _credit;

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
        partial void OndebitChanging(System.Nullable<decimal> value);
        partial void OndebitChanged();
        partial void OncreditChanging(System.Nullable<decimal> value);
        partial void OncreditChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_bic", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_debit", DbType = "Money")]
        public System.Nullable<decimal> debit
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_credit", DbType = "Money")]
        public System.Nullable<decimal> credit
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Category")]
    public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

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

        private System.Nullable<int> _periode;

        private System.Nullable<int> _nextperiode;

        private string _taxcode;

        private string _vatcode;

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
        partial void OnperiodeChanging(System.Nullable<int> value);
        partial void OnperiodeChanged();
        partial void OnnextperiodeChanging(System.Nullable<int> value);
        partial void OnnextperiodeChanged();
        partial void OntaxcodeChanging(string value);
        partial void OntaxcodeChanged();
        partial void OnvatcodeChanging(string value);
        partial void OnvatcodeChanged();
        #endregion

        public Company()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_bankaccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_purchasingclearingaccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_salesclearingaccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_paymentclearingaccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_periode", DbType = "Int")]
        public System.Nullable<int> periode
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_taxcode", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_vatcode", DbType = "NVarChar(255)")]
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.CostCenter")]
    public partial class CostCenter : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

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
        #endregion

        public CostCenter()
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Country")]
    public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _code;

        private string _name;

        private System.Nullable<int> _population;

        private System.Nullable<decimal> _gnp;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OncodeChanging(string value);
        partial void OncodeChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnpopulationChanging(System.Nullable<int> value);
        partial void OnpopulationChanged();
        partial void OngnpChanging(System.Nullable<decimal> value);
        partial void OngnpChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_population", DbType = "Int")]
        public System.Nullable<int> population
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_gnp", DbType = "Money")]
        public System.Nullable<decimal> gnp
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

        private System.Nullable<int> _accountid;

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
        partial void OnaccountidChanging(System.Nullable<int> value);
        partial void OnaccountidChanged();
        #endregion

        public Customer()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_accountid", DbType = "Int")]
        public System.Nullable<int> accountid
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.GoodReceiving")]
    public partial class GoodReceiving : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _oid;

        private int _modelid;

        private string _store;

        private string _account;

        private System.Nullable<System.DateTime> _ItemDate;

        private System.Nullable<bool> _IsValidated;

        private EntitySet<LineGoodReceiving> _LineGoodReceivings;

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
        partial void OnItemDateChanging(System.Nullable<System.DateTime> value);
        partial void OnItemDateChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public GoodReceiving()
        {
            this._LineGoodReceivings = new EntitySet<LineGoodReceiving>(new Action<LineGoodReceiving>(this.attach_LineGoodReceivings), new Action<LineGoodReceiving>(this.detach_LineGoodReceivings));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_ItemDate", DbType = "Date")]
        public System.Nullable<System.DateTime> ItemDate
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

        private System.Nullable<int> _store;

        private string _account;

        private string _text;

        private System.Nullable<bool> _IsValidated;

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
        partial void OnstoreChanging(System.Nullable<int> value);
        partial void OnstoreChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public InventoryInvoice()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "Int")]
        public System.Nullable<int> store
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50)")]
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.LineGoodReceiving")]
    public partial class LineGoodReceiving : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private System.Nullable<int> _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private System.Nullable<decimal> _price;

        private System.Nullable<float> _quantity;

        private string _VatCode;

        private System.Nullable<System.DateTime> _duedate;

        private string _text;

        private EntityRef<Article> _Article;

        private EntityRef<GoodReceiving> _GoodReceiving;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(System.Nullable<int> value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(System.Nullable<decimal> value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(System.Nullable<float> value);
        partial void OnquantityChanged();
        partial void OnVatCodeChanging(string value);
        partial void OnVatCodeChanged();
        partial void OnduedateChanging(System.Nullable<System.DateTime> value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int")]
        public System.Nullable<int> transid
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money")]
        public System.Nullable<decimal> price
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Real")]
        public System.Nullable<float> quantity
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_VatCode", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> duedate
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
                        this._transid = default(Nullable<int>);
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

        private System.Nullable<int> _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private System.Nullable<decimal> _price;

        private System.Nullable<short> _quantity;

        private string _vat;

        private System.Nullable<System.DateTime> _duedate;

        private string _text;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(System.Nullable<int> value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(System.Nullable<decimal> value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(System.Nullable<short> value);
        partial void OnquantityChanged();
        partial void OnvatChanging(string value);
        partial void OnvatChanged();
        partial void OnduedateChanging(System.Nullable<System.DateTime> value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        #endregion

        public LineInventoryInvoice()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int")]
        public System.Nullable<int> transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(50)")]
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
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money")]
        public System.Nullable<decimal> price
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "SmallInt")]
        public System.Nullable<short> quantity
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_vat", DbType = "NVarChar(50)")]
        public string vat
        {
            get
            {
                return this._vat;
            }
            set
            {
                if ((this._vat != value))
                {
                    this.OnvatChanging(value);
                    this.SendPropertyChanging();
                    this._vat = value;
                    this.SendPropertyChanged("vat");
                    this.OnvatChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> duedate
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

        private System.Nullable<int> _transid;

        private int _modelid;

        private string _account;

        private string _side;

        private string _oaccount;

        private System.Nullable<decimal> _amount;

        private System.Nullable<System.DateTime> _duedate;

        private string _text;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(System.Nullable<int> value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(string value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(System.Nullable<decimal> value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.Nullable<System.DateTime> value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        #endregion

        public LinePayment()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int")]
        public System.Nullable<int> transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "NVarChar(50)")]
        public string side
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money")]
        public System.Nullable<decimal> amount
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> duedate
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

        private System.Nullable<int> _transid;

        private int _modelid;

        private string _item;

        private string _unit;

        private System.Nullable<decimal> _price;

        private System.Nullable<int> _quantity;

        private string _vat;

        private System.Nullable<System.DateTime> _duedate;

        private string _text;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(System.Nullable<int> value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnitemChanging(string value);
        partial void OnitemChanged();
        partial void OnunitChanging(string value);
        partial void OnunitChanged();
        partial void OnpriceChanging(System.Nullable<decimal> value);
        partial void OnpriceChanged();
        partial void OnquantityChanging(System.Nullable<int> value);
        partial void OnquantityChanged();
        partial void OnvatChanging(string value);
        partial void OnvatChanged();
        partial void OnduedateChanging(System.Nullable<System.DateTime> value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        #endregion

        public LinePurchaseOrder()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int")]
        public System.Nullable<int> transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_item", DbType = "NVarChar(255)")]
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
                    this.OnitemChanging(value);
                    this.SendPropertyChanging();
                    this._item = value;
                    this.SendPropertyChanged("item");
                    this.OnitemChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_unit", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_price", DbType = "Money")]
        public System.Nullable<decimal> price
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Int")]
        public System.Nullable<int> quantity
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_vat", DbType = "NVarChar(255)")]
        public string vat
        {
            get
            {
                return this._vat;
            }
            set
            {
                if ((this._vat != value))
                {
                    this.OnvatChanging(value);
                    this.SendPropertyChanging();
                    this._vat = value;
                    this.SendPropertyChanged("vat");
                    this.OnvatChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> duedate
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

        private System.Nullable<int> _transid;

        private int _modelid;

        private string _account;

        private System.Nullable<bool> _side;

        private string _oaccount;

        private System.Nullable<decimal> _amount;

        private System.Nullable<System.DateTime> _duedate;

        private string _text;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OntransidChanging(System.Nullable<int> value);
        partial void OntransidChanged();
        partial void OnmodelidChanging(int value);
        partial void OnmodelidChanged();
        partial void OnaccountChanging(string value);
        partial void OnaccountChanged();
        partial void OnsideChanging(System.Nullable<bool> value);
        partial void OnsideChanged();
        partial void OnoaccountChanging(string value);
        partial void OnoaccountChanged();
        partial void OnamountChanging(System.Nullable<decimal> value);
        partial void OnamountChanged();
        partial void OnduedateChanging(System.Nullable<System.DateTime> value);
        partial void OnduedateChanged();
        partial void OntextChanging(string value);
        partial void OntextChanged();
        #endregion

        public LineVendorInvoice()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_transid", DbType = "Int")]
        public System.Nullable<int> transid
        {
            get
            {
                return this._transid;
            }
            set
            {
                if ((this._transid != value))
                {
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_side", DbType = "Bit")]
        public System.Nullable<bool> side
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_oaccount", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_amount", DbType = "Money")]
        public System.Nullable<decimal> amount
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_duedate", DbType = "DateTime2")]
        public System.Nullable<System.DateTime> duedate
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

        private System.Nullable<bool> _IsValidated;

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
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public Payment()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_AccountId", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Periode", DbType = "NChar(6)")]
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Person")]
    public partial class Person : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _id;

        private string _name;

        private System.Nullable<short> _age;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnidChanging(int value);
        partial void OnidChanged();
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        partial void OnageChanging(System.Nullable<short> value);
        partial void OnageChanged();
        #endregion

        public Person()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_age", DbType = "SmallInt")]
        public System.Nullable<short> age
        {
            get
            {
                return this._age;
            }
            set
            {
                if ((this._age != value))
                {
                    this.OnageChanging(value);
                    this.SendPropertyChanging();
                    this._age = value;
                    this.SendPropertyChanged("age");
                    this.OnageChanged();
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

        private System.Nullable<bool> _IsValidated;

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
        partial void OnIsValidatedChanging(System.Nullable<bool> value);
        partial void OnIsValidatedChanged();
        #endregion

        public PurchaseOrder()
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_store", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_account", DbType = "NVarChar(255)")]
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.QuantityUnit")]
    public partial class QuantityUnit : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private short _modelid;

        private string _description;

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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50)")]
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

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Stock")]
    public partial class Stock : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private int _modelid;

        private string _description;

        private string _itemid;

        private string _storeid;

        private System.Nullable<float> _quantity;

        private System.Nullable<short> _minstock;

        private EntityRef<Article> _Article;

        private EntityRef<Store> _Store;

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
        partial void OnitemidChanging(string value);
        partial void OnitemidChanged();
        partial void OnstoreidChanging(string value);
        partial void OnstoreidChanged();
        partial void OnquantityChanging(System.Nullable<float> value);
        partial void OnquantityChanged();
        partial void OnminstockChanging(System.Nullable<short> value);
        partial void OnminstockChanged();
        #endregion

        public Stock()
        {
            this._Article = default(EntityRef<Article>);
            this._Store = default(EntityRef<Store>);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_itemid", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_storeid", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_quantity", DbType = "Real")]
        public System.Nullable<float> quantity
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_minstock", DbType = "SmallInt")]
        public System.Nullable<short> minstock
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

        private EntitySet<GoodReceiving> _GoodReceivings;

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
        #endregion

        public Store()
        {
            this._GoodReceivings = new EntitySet<GoodReceiving>(new Action<GoodReceiving>(this.attach_GoodReceivings), new Action<GoodReceiving>(this.detach_GoodReceivings));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_name", DbType = "NVarChar(50)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_accountid", DbType = "NVarChar(50)")]
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

        private short _modelid;

        private string _street;

        private string _city;

        private string _state;

        private string _zip;

        private string _accountid;

        private EntitySet<GoodReceiving> _GoodReceivings;

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
        #endregion

        public Supplier()
        {
            this._GoodReceivings = new EntitySet<GoodReceiving>(new Action<GoodReceiving>(this.attach_GoodReceivings), new Action<GoodReceiving>(this.detach_GoodReceivings));
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_accountid", DbType = "NVarChar(255)")]
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
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Vat")]
    public partial class Vat : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private string _id;

        private string _name;

        private short _modelid;

        private string _description;

        private System.Nullable<double> _PVat;

        private string _inputvataccountid;

        private string _outputvataccountid;

        private string _revenueaccountid;

        private string _stockaccountid;

        private string _expenseaccountid;

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
        partial void OnPVatChanging(System.Nullable<double> value);
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_PVat", DbType = "Float")]
        public System.Nullable<double> PVat
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_inputvataccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_outputvataccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_revenueaccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_stockaccountid", DbType = "NVarChar(255)")]
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

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_expenseaccountid", DbType = "NVarChar(255)")]
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

