


using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using SubSonic.DataProviders;
using SubSonic.Extensions;
using SubSonic.Linq.Structure;
using SubSonic.Query;
using SubSonic.Schema;
using System.Data.Common;
using System.Collections.Generic;

namespace MyDAL
{
    public partial class trathainguyenDB : IQuerySurface
    {

        public IDataProvider DataProvider;
        public DbQueryProvider provider;
        
        public static IDataProvider DefaultDataProvider { get; set; }

        public bool TestMode
		{
            get
			{
                return DataProvider.ConnectionString.Equals("test", StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public trathainguyenDB() 
        {
            if (DefaultDataProvider == null) {
                DataProvider = ProviderFactory.GetProvider("tuanit89");
            }
            else {
                DataProvider = DefaultDataProvider;
            }
            Init();
        }

        public trathainguyenDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public trathainguyenDB(string connectionString, string providerName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionString,providerName);
            Init();
        }

		public ITable FindByPrimaryKey(string pkName)
        {
            return DataProvider.Schema.Tables.SingleOrDefault(x => x.PrimaryKey.Name.Equals(pkName, StringComparison.InvariantCultureIgnoreCase));
        }

        public Query<T> GetQuery<T>()
        {
            return new Query<T>(provider);
        }
        
        public ITable FindTable(string tableName)
        {
            return DataProvider.FindTable(tableName);
        }
               
        public IDataProvider Provider
        {
            get { return DataProvider; }
            set {DataProvider=value;}
        }
        
        public DbQueryProvider QueryProvider
        {
            get { return provider; }
        }
        
        BatchQuery _batch = null;
        public void Queue<T>(IQueryable<T> qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void Queue(ISqlQuery qry)
        {
            if (_batch == null)
                _batch = new BatchQuery(Provider, QueryProvider);
            _batch.Queue(qry);
        }

        public void ExecuteTransaction(IList<DbCommand> commands)
		{
            if(!TestMode)
			{
                using(var connection = commands[0].Connection)
				{
                   if (connection.State == ConnectionState.Closed)
                        connection.Open();
                   
                   using (var trans = connection.BeginTransaction()) 
				   {
                        foreach (var cmd in commands) 
						{
                            cmd.Transaction = trans;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }
                        trans.Commit();
                    }
                    connection.Close();
                }
            }
        }

        public IDataReader ExecuteBatch()
        {
            if (_batch == null)
                throw new InvalidOperationException("There's nothing in the queue");
            if(!TestMode)
                return _batch.ExecuteReader();
            return null;
        }
			
        public Query<Product> Products { get; set; }
        public Query<News> News { get; set; }
        public Query<Feature> Features { get; set; }
        public Query<Customer> Customers { get; set; }
        public Query<Contact> Contacts { get; set; }
        public Query<BoxAd> BoxAds { get; set; }
        public Query<Order> Orders { get; set; }
        public Query<Tag> Tags { get; set; }
        public Query<Support> Supports { get; set; }
        public Query<Supplier> Suppliers { get; set; }
        public Query<Slider> Sliders { get; set; }
        public Query<Setting> Settings { get; set; }
        public Query<ProductCategory> ProductCategories { get; set; }
        public Query<ProductCate_Supplier> ProductCate_Suppliers { get; set; }
        public Query<tblUser> tblUsers { get; set; }
        public Query<Feature_Product> Feature_Products { get; set; }
        public Query<Feature_Value> Feature_Values { get; set; }
        public Query<CateType> CateTypes { get; set; }
        public Query<NewsInfo> NewsInfos { get; set; }
        public Query<CustomerReview> CustomerReviews { get; set; }
        public Query<ImageColumn> ImageColumns { get; set; }
        public Query<NewsCategory> NewsCategories { get; set; }

			

        #region ' Aggregates and SubSonic Queries '
        public Select SelectColumns(params string[] columns)
        {
            return new Select(DataProvider, columns);
        }

        public Select Select
        {
            get { return new Select(this.Provider); }
        }

        public Insert Insert
		{
            get { return new Insert(this.Provider); }
        }

        public Update<T> Update<T>() where T:new()
		{
            return new Update<T>(this.Provider);
        }

        public SqlQuery Delete<T>(Expression<Func<T,bool>> column) where T:new()
        {
            LambdaExpression lamda = column;
            SqlQuery result = new Delete<T>(this.Provider);
            result = result.From<T>();
            result.Constraints=lamda.ParseConstraints().ToList();
            return result;
        }

        public SqlQuery Max<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = DataProvider.FindTable(objectName).Name;
            return new Select(DataProvider, new Aggregate(colName, AggregateFunction.Max)).From(tableName);
        }

        public SqlQuery Min<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Min)).From(tableName);
        }

        public SqlQuery Sum<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Sum)).From(tableName);
        }

        public SqlQuery Avg<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Avg)).From(tableName);
        }

        public SqlQuery Count<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Count)).From(tableName);
        }

        public SqlQuery Variance<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.Var)).From(tableName);
        }

        public SqlQuery StandardDeviation<T>(Expression<Func<T,object>> column)
        {
            LambdaExpression lamda = column;
            string colName = lamda.ParseObjectValue();
            string objectName = typeof(T).Name;
            string tableName = this.Provider.FindTable(objectName).Name;
            return new Select(this.Provider, new Aggregate(colName, AggregateFunction.StDev)).From(tableName);
        }

        #endregion

        void Init()
        {
            provider = new DbQueryProvider(this.Provider);

            #region ' Query Defs '
            Products = new Query<Product>(provider);
            News = new Query<News>(provider);
            Features = new Query<Feature>(provider);
            Customers = new Query<Customer>(provider);
            Contacts = new Query<Contact>(provider);
            BoxAds = new Query<BoxAd>(provider);
            Orders = new Query<Order>(provider);
            Tags = new Query<Tag>(provider);
            Supports = new Query<Support>(provider);
            Suppliers = new Query<Supplier>(provider);
            Sliders = new Query<Slider>(provider);
            Settings = new Query<Setting>(provider);
            ProductCategories = new Query<ProductCategory>(provider);
            ProductCate_Suppliers = new Query<ProductCate_Supplier>(provider);
            tblUsers = new Query<tblUser>(provider);
            Feature_Products = new Query<Feature_Product>(provider);
            Feature_Values = new Query<Feature_Value>(provider);
            CateTypes = new Query<CateType>(provider);
            NewsInfos = new Query<NewsInfo>(provider);
            CustomerReviews = new Query<CustomerReview>(provider);
            ImageColumns = new Query<ImageColumn>(provider);
            NewsCategories = new Query<NewsCategory>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new ProductTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new NewsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new FeatureTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CustomerTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContactTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new BoxAdTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new OrderTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TagsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SupportTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SupplierTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SliderTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new SettingsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductCategoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ProductCate_SupplierTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new tblUserTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Feature_ProductTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Feature_ValueTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CateTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new NewsInfosTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new CustomerReviewTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ImageColumnTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new NewsCategoryTable(DataProvider));
            }
            #endregion
        }
        

        #region ' Helpers '
            
        internal static DateTime DateTimeNowTruncatedDownToSecond() {
            var now = DateTime.Now;
            return now.AddTicks(-now.Ticks % TimeSpan.TicksPerSecond);
        }

        #endregion

    }
}