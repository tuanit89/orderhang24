


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace MyDAL {
	
        /// <summary>
        /// Table: Product
        /// Primary Key: id
        /// </summary>

        public class ProductTable: DatabaseTable {
            
            public ProductTable(IDataProvider provider):base("Product",provider){
                ClassName = "Product";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Model", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ProductName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("tag", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("altImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("isHot", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ShowHome", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("price", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Currency,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("DateCreate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SupplierId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Content", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1073741823
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn CateId{
                get{
                    return this.GetColumn("CateId");
                }
            }
				
   			public static string CateIdColumn{
			      get{
        			return "CateId";
      			}
		    }
            
            public IColumn Model{
                get{
                    return this.GetColumn("Model");
                }
            }
				
   			public static string ModelColumn{
			      get{
        			return "Model";
      			}
		    }
            
            public IColumn ProductName{
                get{
                    return this.GetColumn("ProductName");
                }
            }
				
   			public static string ProductNameColumn{
			      get{
        			return "ProductName";
      			}
		    }
            
            public IColumn description{
                get{
                    return this.GetColumn("description");
                }
            }
				
   			public static string descriptionColumn{
			      get{
        			return "description";
      			}
		    }
            
            public IColumn tag{
                get{
                    return this.GetColumn("tag");
                }
            }
				
   			public static string tagColumn{
			      get{
        			return "tag";
      			}
		    }
            
            public IColumn image{
                get{
                    return this.GetColumn("image");
                }
            }
				
   			public static string imageColumn{
			      get{
        			return "image";
      			}
		    }
            
            public IColumn altImage{
                get{
                    return this.GetColumn("altImage");
                }
            }
				
   			public static string altImageColumn{
			      get{
        			return "altImage";
      			}
		    }
            
            public IColumn isHot{
                get{
                    return this.GetColumn("isHot");
                }
            }
				
   			public static string isHotColumn{
			      get{
        			return "isHot";
      			}
		    }
            
            public IColumn ShowHome{
                get{
                    return this.GetColumn("ShowHome");
                }
            }
				
   			public static string ShowHomeColumn{
			      get{
        			return "ShowHome";
      			}
		    }
            
            public IColumn price{
                get{
                    return this.GetColumn("price");
                }
            }
				
   			public static string priceColumn{
			      get{
        			return "price";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn DateCreate{
                get{
                    return this.GetColumn("DateCreate");
                }
            }
				
   			public static string DateCreateColumn{
			      get{
        			return "DateCreate";
      			}
		    }
            
            public IColumn SupplierId{
                get{
                    return this.GetColumn("SupplierId");
                }
            }
				
   			public static string SupplierIdColumn{
			      get{
        			return "SupplierId";
      			}
		    }
            
            public IColumn Content{
                get{
                    return this.GetColumn("Content");
                }
            }
				
   			public static string ContentColumn{
			      get{
        			return "Content";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: News
        /// Primary Key: Id
        /// </summary>

        public class NewsTable: DatabaseTable {
            
            public NewsTable(IDataProvider provider):base("News",provider){
                ClassName = "News";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Content", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1073741823
                });

                Columns.Add(new DatabaseColumn("Image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("AltImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("MetaDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("IsAttach", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Tags", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PageView", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn CateId{
                get{
                    return this.GetColumn("CateId");
                }
            }
				
   			public static string CateIdColumn{
			      get{
        			return "CateId";
      			}
		    }
            
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Content{
                get{
                    return this.GetColumn("Content");
                }
            }
				
   			public static string ContentColumn{
			      get{
        			return "Content";
      			}
		    }
            
            public IColumn Image{
                get{
                    return this.GetColumn("Image");
                }
            }
				
   			public static string ImageColumn{
			      get{
        			return "Image";
      			}
		    }
            
            public IColumn AltImage{
                get{
                    return this.GetColumn("AltImage");
                }
            }
				
   			public static string AltImageColumn{
			      get{
        			return "AltImage";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn MetaDescription{
                get{
                    return this.GetColumn("MetaDescription");
                }
            }
				
   			public static string MetaDescriptionColumn{
			      get{
        			return "MetaDescription";
      			}
		    }
            
            public IColumn IsAttach{
                get{
                    return this.GetColumn("IsAttach");
                }
            }
				
   			public static string IsAttachColumn{
			      get{
        			return "IsAttach";
      			}
		    }
            
            public IColumn Tags{
                get{
                    return this.GetColumn("Tags");
                }
            }
				
   			public static string TagsColumn{
			      get{
        			return "Tags";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn PageView{
                get{
                    return this.GetColumn("PageView");
                }
            }
				
   			public static string PageViewColumn{
			      get{
        			return "PageView";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Feature
        /// Primary Key: Id
        /// </summary>

        public class FeatureTable: DatabaseTable {
            
            public FeatureTable(IDataProvider provider):base("Feature",provider){
                ClassName = "Feature";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FuncName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ProductCateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsShare", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn FuncName{
                get{
                    return this.GetColumn("FuncName");
                }
            }
				
   			public static string FuncNameColumn{
			      get{
        			return "FuncName";
      			}
		    }
            
            public IColumn ProductCateId{
                get{
                    return this.GetColumn("ProductCateId");
                }
            }
				
   			public static string ProductCateIdColumn{
			      get{
        			return "ProductCateId";
      			}
		    }
            
            public IColumn IsShare{
                get{
                    return this.GetColumn("IsShare");
                }
            }
				
   			public static string IsShareColumn{
			      get{
        			return "IsShare";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Customer
        /// Primary Key: CustomerID
        /// </summary>

        public class CustomerTable: DatabaseTable {
            
            public CustomerTable(IDataProvider provider):base("Customer",provider){
                ClassName = "Customer";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Fullname", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Sex", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Tell", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Mobile", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Username", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("IsLock", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DateCreate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
            
            public IColumn Fullname{
                get{
                    return this.GetColumn("Fullname");
                }
            }
				
   			public static string FullnameColumn{
			      get{
        			return "Fullname";
      			}
		    }
            
            public IColumn Sex{
                get{
                    return this.GetColumn("Sex");
                }
            }
				
   			public static string SexColumn{
			      get{
        			return "Sex";
      			}
		    }
            
            public IColumn Address{
                get{
                    return this.GetColumn("Address");
                }
            }
				
   			public static string AddressColumn{
			      get{
        			return "Address";
      			}
		    }
            
            public IColumn Tell{
                get{
                    return this.GetColumn("Tell");
                }
            }
				
   			public static string TellColumn{
			      get{
        			return "Tell";
      			}
		    }
            
            public IColumn Mobile{
                get{
                    return this.GetColumn("Mobile");
                }
            }
				
   			public static string MobileColumn{
			      get{
        			return "Mobile";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn Username{
                get{
                    return this.GetColumn("Username");
                }
            }
				
   			public static string UsernameColumn{
			      get{
        			return "Username";
      			}
		    }
            
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
            
            public IColumn IsLock{
                get{
                    return this.GetColumn("IsLock");
                }
            }
				
   			public static string IsLockColumn{
			      get{
        			return "IsLock";
      			}
		    }
            
            public IColumn DateCreate{
                get{
                    return this.GetColumn("DateCreate");
                }
            }
				
   			public static string DateCreateColumn{
			      get{
        			return "DateCreate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Contact
        /// Primary Key: Id
        /// </summary>

        public class ContactTable: DatabaseTable {
            
            public ContactTable(IDataProvider provider):base("Contact",provider){
                ClassName = "Contact";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FullName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("Subject", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("Message", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn FullName{
                get{
                    return this.GetColumn("FullName");
                }
            }
				
   			public static string FullNameColumn{
			      get{
        			return "FullName";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
            public IColumn Subject{
                get{
                    return this.GetColumn("Subject");
                }
            }
				
   			public static string SubjectColumn{
			      get{
        			return "Subject";
      			}
		    }
            
            public IColumn Message{
                get{
                    return this.GetColumn("Message");
                }
            }
				
   			public static string MessageColumn{
			      get{
        			return "Message";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: BoxAd
        /// Primary Key: Id
        /// </summary>

        public class BoxAdTable: DatabaseTable {
            
            public BoxAdTable(IDataProvider provider):base("BoxAd",provider){
                ClassName = "BoxAd";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Location", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Image{
                get{
                    return this.GetColumn("Image");
                }
            }
				
   			public static string ImageColumn{
			      get{
        			return "Image";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn Location{
                get{
                    return this.GetColumn("Location");
                }
            }
				
   			public static string LocationColumn{
			      get{
        			return "Location";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Order
        /// Primary Key: OrderID
        /// </summary>

        public class OrderTable: DatabaseTable {
            
            public OrderTable(IDataProvider provider):base("Order",provider){
                ClassName = "Order";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("OrderID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CustomerID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FullnameOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("SexOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("EmailOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("PhoneOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("MobileOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FaxOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("OtherInfoOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("FullnameReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("SexReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AddressReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("EmailReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("PhoneReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("MobileReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("FaxReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("OtherInfoReceived", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Shipping", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TransitTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Payment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TotalPayment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ProductNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OnOrder", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn OrderID{
                get{
                    return this.GetColumn("OrderID");
                }
            }
				
   			public static string OrderIDColumn{
			      get{
        			return "OrderID";
      			}
		    }
            
            public IColumn CustomerID{
                get{
                    return this.GetColumn("CustomerID");
                }
            }
				
   			public static string CustomerIDColumn{
			      get{
        			return "CustomerID";
      			}
		    }
            
            public IColumn FullnameOrder{
                get{
                    return this.GetColumn("FullnameOrder");
                }
            }
				
   			public static string FullnameOrderColumn{
			      get{
        			return "FullnameOrder";
      			}
		    }
            
            public IColumn SexOrder{
                get{
                    return this.GetColumn("SexOrder");
                }
            }
				
   			public static string SexOrderColumn{
			      get{
        			return "SexOrder";
      			}
		    }
            
            public IColumn AddressOrder{
                get{
                    return this.GetColumn("AddressOrder");
                }
            }
				
   			public static string AddressOrderColumn{
			      get{
        			return "AddressOrder";
      			}
		    }
            
            public IColumn EmailOrder{
                get{
                    return this.GetColumn("EmailOrder");
                }
            }
				
   			public static string EmailOrderColumn{
			      get{
        			return "EmailOrder";
      			}
		    }
            
            public IColumn PhoneOrder{
                get{
                    return this.GetColumn("PhoneOrder");
                }
            }
				
   			public static string PhoneOrderColumn{
			      get{
        			return "PhoneOrder";
      			}
		    }
            
            public IColumn MobileOrder{
                get{
                    return this.GetColumn("MobileOrder");
                }
            }
				
   			public static string MobileOrderColumn{
			      get{
        			return "MobileOrder";
      			}
		    }
            
            public IColumn FaxOrder{
                get{
                    return this.GetColumn("FaxOrder");
                }
            }
				
   			public static string FaxOrderColumn{
			      get{
        			return "FaxOrder";
      			}
		    }
            
            public IColumn OtherInfoOrder{
                get{
                    return this.GetColumn("OtherInfoOrder");
                }
            }
				
   			public static string OtherInfoOrderColumn{
			      get{
        			return "OtherInfoOrder";
      			}
		    }
            
            public IColumn FullnameReceived{
                get{
                    return this.GetColumn("FullnameReceived");
                }
            }
				
   			public static string FullnameReceivedColumn{
			      get{
        			return "FullnameReceived";
      			}
		    }
            
            public IColumn SexReceived{
                get{
                    return this.GetColumn("SexReceived");
                }
            }
				
   			public static string SexReceivedColumn{
			      get{
        			return "SexReceived";
      			}
		    }
            
            public IColumn AddressReceived{
                get{
                    return this.GetColumn("AddressReceived");
                }
            }
				
   			public static string AddressReceivedColumn{
			      get{
        			return "AddressReceived";
      			}
		    }
            
            public IColumn EmailReceived{
                get{
                    return this.GetColumn("EmailReceived");
                }
            }
				
   			public static string EmailReceivedColumn{
			      get{
        			return "EmailReceived";
      			}
		    }
            
            public IColumn PhoneReceived{
                get{
                    return this.GetColumn("PhoneReceived");
                }
            }
				
   			public static string PhoneReceivedColumn{
			      get{
        			return "PhoneReceived";
      			}
		    }
            
            public IColumn MobileReceived{
                get{
                    return this.GetColumn("MobileReceived");
                }
            }
				
   			public static string MobileReceivedColumn{
			      get{
        			return "MobileReceived";
      			}
		    }
            
            public IColumn FaxReceived{
                get{
                    return this.GetColumn("FaxReceived");
                }
            }
				
   			public static string FaxReceivedColumn{
			      get{
        			return "FaxReceived";
      			}
		    }
            
            public IColumn OtherInfoReceived{
                get{
                    return this.GetColumn("OtherInfoReceived");
                }
            }
				
   			public static string OtherInfoReceivedColumn{
			      get{
        			return "OtherInfoReceived";
      			}
		    }
            
            public IColumn Shipping{
                get{
                    return this.GetColumn("Shipping");
                }
            }
				
   			public static string ShippingColumn{
			      get{
        			return "Shipping";
      			}
		    }
            
            public IColumn TransitTime{
                get{
                    return this.GetColumn("TransitTime");
                }
            }
				
   			public static string TransitTimeColumn{
			      get{
        			return "TransitTime";
      			}
		    }
            
            public IColumn Payment{
                get{
                    return this.GetColumn("Payment");
                }
            }
				
   			public static string PaymentColumn{
			      get{
        			return "Payment";
      			}
		    }
            
            public IColumn TotalPayment{
                get{
                    return this.GetColumn("TotalPayment");
                }
            }
				
   			public static string TotalPaymentColumn{
			      get{
        			return "TotalPayment";
      			}
		    }
            
            public IColumn ProductNumber{
                get{
                    return this.GetColumn("ProductNumber");
                }
            }
				
   			public static string ProductNumberColumn{
			      get{
        			return "ProductNumber";
      			}
		    }
            
            public IColumn StatusOrder{
                get{
                    return this.GetColumn("StatusOrder");
                }
            }
				
   			public static string StatusOrderColumn{
			      get{
        			return "StatusOrder";
      			}
		    }
            
            public IColumn OnOrder{
                get{
                    return this.GetColumn("OnOrder");
                }
            }
				
   			public static string OnOrderColumn{
			      get{
        			return "OnOrder";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Tags
        /// Primary Key: Id
        /// </summary>

        public class TagsTable: DatabaseTable {
            
            public TagsTable(IDataProvider provider):base("Tags",provider){
                ClassName = "Tag";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TagsName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn TagsName{
                get{
                    return this.GetColumn("TagsName");
                }
            }
				
   			public static string TagsNameColumn{
			      get{
        			return "TagsName";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Support
        /// Primary Key: Id
        /// </summary>

        public class SupportTable: DatabaseTable {
            
            public SupportTable(IDataProvider provider):base("Support",provider){
                ClassName = "Support";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Yahoo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Skype", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Phone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Yahoo{
                get{
                    return this.GetColumn("Yahoo");
                }
            }
				
   			public static string YahooColumn{
			      get{
        			return "Yahoo";
      			}
		    }
            
            public IColumn Skype{
                get{
                    return this.GetColumn("Skype");
                }
            }
				
   			public static string SkypeColumn{
			      get{
        			return "Skype";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Phone{
                get{
                    return this.GetColumn("Phone");
                }
            }
				
   			public static string PhoneColumn{
			      get{
        			return "Phone";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Supplier
        /// Primary Key: Id
        /// </summary>

        public class SupplierTable: DatabaseTable {
            
            public SupplierTable(IDataProvider provider):base("Supplier",provider){
                ClassName = "Supplier";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("MetaDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("ParentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HasCateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn MetaDescription{
                get{
                    return this.GetColumn("MetaDescription");
                }
            }
				
   			public static string MetaDescriptionColumn{
			      get{
        			return "MetaDescription";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn Image{
                get{
                    return this.GetColumn("Image");
                }
            }
				
   			public static string ImageColumn{
			      get{
        			return "Image";
      			}
		    }
            
            public IColumn ParentId{
                get{
                    return this.GetColumn("ParentId");
                }
            }
				
   			public static string ParentIdColumn{
			      get{
        			return "ParentId";
      			}
		    }
            
            public IColumn HasCateId{
                get{
                    return this.GetColumn("HasCateId");
                }
            }
				
   			public static string HasCateIdColumn{
			      get{
        			return "HasCateId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Slider
        /// Primary Key: id
        /// </summary>

        public class SliderTable: DatabaseTable {
            
            public SliderTable(IDataProvider provider):base("Slider",provider){
                ClassName = "Slider";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("alt", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });
                    
                
                
            }

            public IColumn id{
                get{
                    return this.GetColumn("id");
                }
            }
				
   			public static string idColumn{
			      get{
        			return "id";
      			}
		    }
            
            public IColumn name{
                get{
                    return this.GetColumn("name");
                }
            }
				
   			public static string nameColumn{
			      get{
        			return "name";
      			}
		    }
            
            public IColumn image{
                get{
                    return this.GetColumn("image");
                }
            }
				
   			public static string imageColumn{
			      get{
        			return "image";
      			}
		    }
            
            public IColumn alt{
                get{
                    return this.GetColumn("alt");
                }
            }
				
   			public static string altColumn{
			      get{
        			return "alt";
      			}
		    }
            
            public IColumn link{
                get{
                    return this.GetColumn("link");
                }
            }
				
   			public static string linkColumn{
			      get{
        			return "link";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Settings
        /// Primary Key: 
        /// </summary>

        public class SettingsTable: DatabaseTable {
            
            public SettingsTable(IDataProvider provider):base("Settings",provider){
                ClassName = "Setting";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Key", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("Value", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });
                    
                
                
            }

            public IColumn Key{
                get{
                    return this.GetColumn("Key");
                }
            }
				
   			public static string KeyColumn{
			      get{
        			return "Key";
      			}
		    }
            
            public IColumn Value{
                get{
                    return this.GetColumn("Value");
                }
            }
				
   			public static string ValueColumn{
			      get{
        			return "Value";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ProductCategory
        /// Primary Key: Id
        /// </summary>

        public class ProductCategoryTable: DatabaseTable {
            
            public ProductCategoryTable(IDataProvider provider):base("ProductCategory",provider){
                ClassName = "ProductCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 350
                });

                Columns.Add(new DatabaseColumn("MetaDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("ParentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn MetaDescription{
                get{
                    return this.GetColumn("MetaDescription");
                }
            }
				
   			public static string MetaDescriptionColumn{
			      get{
        			return "MetaDescription";
      			}
		    }
            
            public IColumn ParentId{
                get{
                    return this.GetColumn("ParentId");
                }
            }
				
   			public static string ParentIdColumn{
			      get{
        			return "ParentId";
      			}
		    }
            
            public IColumn Image{
                get{
                    return this.GetColumn("Image");
                }
            }
				
   			public static string ImageColumn{
			      get{
        			return "Image";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ProductCate_Supplier
        /// Primary Key: 
        /// </summary>

        public class ProductCate_SupplierTable: DatabaseTable {
            
            public ProductCate_SupplierTable(IDataProvider provider):base("ProductCate_Supplier",provider){
                ClassName = "ProductCate_Supplier";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductCateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SupplierId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }

            public IColumn ProductCateId{
                get{
                    return this.GetColumn("ProductCateId");
                }
            }
				
   			public static string ProductCateIdColumn{
			      get{
        			return "ProductCateId";
      			}
		    }
            
            public IColumn SupplierId{
                get{
                    return this.GetColumn("SupplierId");
                }
            }
				
   			public static string SupplierIdColumn{
			      get{
        			return "SupplierId";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: tblUser
        /// Primary Key: Id
        /// </summary>

        public class tblUserTable: DatabaseTable {
            
            public tblUserTable(IDataProvider provider):base("tblUser",provider){
                ClassName = "tblUser";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Username", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Fullname", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Status", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int16,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Username{
                get{
                    return this.GetColumn("Username");
                }
            }
				
   			public static string UsernameColumn{
			      get{
        			return "Username";
      			}
		    }
            
            public IColumn Password{
                get{
                    return this.GetColumn("Password");
                }
            }
				
   			public static string PasswordColumn{
			      get{
        			return "Password";
      			}
		    }
            
            public IColumn Fullname{
                get{
                    return this.GetColumn("Fullname");
                }
            }
				
   			public static string FullnameColumn{
			      get{
        			return "Fullname";
      			}
		    }
            
            public IColumn Status{
                get{
                    return this.GetColumn("Status");
                }
            }
				
   			public static string StatusColumn{
			      get{
        			return "Status";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Feature_Product
        /// Primary Key: Id
        /// </summary>

        public class Feature_ProductTable: DatabaseTable {
            
            public Feature_ProductTable(IDataProvider provider):base("Feature_Product",provider){
                ClassName = "Feature_Product";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FeatureId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Value", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn FeatureId{
                get{
                    return this.GetColumn("FeatureId");
                }
            }
				
   			public static string FeatureIdColumn{
			      get{
        			return "FeatureId";
      			}
		    }
            
            public IColumn Value{
                get{
                    return this.GetColumn("Value");
                }
            }
				
   			public static string ValueColumn{
			      get{
        			return "Value";
      			}
		    }
            
            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: Feature_Value
        /// Primary Key: 
        /// </summary>

        public class Feature_ValueTable: DatabaseTable {
            
            public Feature_ValueTable(IDataProvider provider):base("Feature_Value",provider){
                ClassName = "Feature_Value";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ProductId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FeatureValueId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn ProductId{
                get{
                    return this.GetColumn("ProductId");
                }
            }
				
   			public static string ProductIdColumn{
			      get{
        			return "ProductId";
      			}
		    }
            
            public IColumn FeatureValueId{
                get{
                    return this.GetColumn("FeatureValueId");
                }
            }
				
   			public static string FeatureValueIdColumn{
			      get{
        			return "FeatureValueId";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CateType
        /// Primary Key: 
        /// </summary>

        public class CateTypeTable: DatabaseTable {
            
            public CateTypeTable(IDataProvider provider):base("CateType",provider){
                ClassName = "CateType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CateTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CateType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });
                    
                
                
            }

            public IColumn CateTypeName{
                get{
                    return this.GetColumn("CateTypeName");
                }
            }
				
   			public static string CateTypeNameColumn{
			      get{
        			return "CateTypeName";
      			}
		    }
            
            public IColumn CateType{
                get{
                    return this.GetColumn("CateType");
                }
            }
				
   			public static string CateTypeColumn{
			      get{
        			return "CateType";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: NewsInfos
        /// Primary Key: Id
        /// </summary>

        public class NewsInfosTable: DatabaseTable {
            
            public NewsInfosTable(IDataProvider provider):base("NewsInfos",provider){
                ClassName = "NewsInfo";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Content", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("Image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("AltImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("CreateDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("MetaDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("IsAttach", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Tags", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 255
                });

                Columns.Add(new DatabaseColumn("PageVisitor", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn CateId{
                get{
                    return this.GetColumn("CateId");
                }
            }
				
   			public static string CateIdColumn{
			      get{
        			return "CateId";
      			}
		    }
            
            public IColumn Title{
                get{
                    return this.GetColumn("Title");
                }
            }
				
   			public static string TitleColumn{
			      get{
        			return "Title";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn Content{
                get{
                    return this.GetColumn("Content");
                }
            }
				
   			public static string ContentColumn{
			      get{
        			return "Content";
      			}
		    }
            
            public IColumn Image{
                get{
                    return this.GetColumn("Image");
                }
            }
				
   			public static string ImageColumn{
			      get{
        			return "Image";
      			}
		    }
            
            public IColumn AltImage{
                get{
                    return this.GetColumn("AltImage");
                }
            }
				
   			public static string AltImageColumn{
			      get{
        			return "AltImage";
      			}
		    }
            
            public IColumn CreateDate{
                get{
                    return this.GetColumn("CreateDate");
                }
            }
				
   			public static string CreateDateColumn{
			      get{
        			return "CreateDate";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn MetaDescription{
                get{
                    return this.GetColumn("MetaDescription");
                }
            }
				
   			public static string MetaDescriptionColumn{
			      get{
        			return "MetaDescription";
      			}
		    }
            
            public IColumn IsAttach{
                get{
                    return this.GetColumn("IsAttach");
                }
            }
				
   			public static string IsAttachColumn{
			      get{
        			return "IsAttach";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn Tags{
                get{
                    return this.GetColumn("Tags");
                }
            }
				
   			public static string TagsColumn{
			      get{
        			return "Tags";
      			}
		    }
            
            public IColumn PageVisitor{
                get{
                    return this.GetColumn("PageVisitor");
                }
            }
				
   			public static string PageVisitorColumn{
			      get{
        			return "PageVisitor";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: CustomerReview
        /// Primary Key: Id
        /// </summary>

        public class CustomerReviewTable: DatabaseTable {
            
            public CustomerReviewTable(IDataProvider provider):base("CustomerReview",provider){
                ClassName = "CustomerReview";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CustomerName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CustomerComment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 210
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn CustomerName{
                get{
                    return this.GetColumn("CustomerName");
                }
            }
				
   			public static string CustomerNameColumn{
			      get{
        			return "CustomerName";
      			}
		    }
            
            public IColumn CustomerComment{
                get{
                    return this.GetColumn("CustomerComment");
                }
            }
				
   			public static string CustomerCommentColumn{
			      get{
        			return "CustomerComment";
      			}
		    }
            
            public IColumn Email{
                get{
                    return this.GetColumn("Email");
                }
            }
				
   			public static string EmailColumn{
			      get{
        			return "Email";
      			}
		    }
            
            public IColumn Address{
                get{
                    return this.GetColumn("Address");
                }
            }
				
   			public static string AddressColumn{
			      get{
        			return "Address";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: ImageColumn
        /// Primary Key: Id
        /// </summary>

        public class ImageColumnTable: DatabaseTable {
            
            public ImageColumnTable(IDataProvider provider):base("ImageColumn",provider){
                ClassName = "ImageColumn";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageColumnName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Name1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Name2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Name3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Image", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 350
                });

                Columns.Add(new DatabaseColumn("Alternate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn ImageColumnName{
                get{
                    return this.GetColumn("ImageColumnName");
                }
            }
				
   			public static string ImageColumnNameColumn{
			      get{
        			return "ImageColumnName";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn LocationType{
                get{
                    return this.GetColumn("LocationType");
                }
            }
				
   			public static string LocationTypeColumn{
			      get{
        			return "LocationType";
      			}
		    }
            
            public IColumn Name1{
                get{
                    return this.GetColumn("Name1");
                }
            }
				
   			public static string Name1Column{
			      get{
        			return "Name1";
      			}
		    }
            
            public IColumn Name2{
                get{
                    return this.GetColumn("Name2");
                }
            }
				
   			public static string Name2Column{
			      get{
        			return "Name2";
      			}
		    }
            
            public IColumn Name3{
                get{
                    return this.GetColumn("Name3");
                }
            }
				
   			public static string Name3Column{
			      get{
        			return "Name3";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn Image{
                get{
                    return this.GetColumn("Image");
                }
            }
				
   			public static string ImageColumn{
			      get{
        			return "Image";
      			}
		    }
            
            public IColumn Alternate{
                get{
                    return this.GetColumn("Alternate");
                }
            }
				
   			public static string AlternateColumn{
			      get{
        			return "Alternate";
      			}
		    }
            
                    
        }
        
        /// <summary>
        /// Table: NewsCategory
        /// Primary Key: Id
        /// </summary>

        public class NewsCategoryTable: DatabaseTable {
            
            public NewsCategoryTable(IDataProvider provider):base("NewsCategory",provider){
                ClassName = "NewsCategory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Link", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Sort", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 350
                });

                Columns.Add(new DatabaseColumn("MetaDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("ParentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CateType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Headline", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Note", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 300
                });

                Columns.Add(new DatabaseColumn("NoteBelow", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("BelowHead", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 110
                });
                    
                
                
            }

            public IColumn Id{
                get{
                    return this.GetColumn("Id");
                }
            }
				
   			public static string IdColumn{
			      get{
        			return "Id";
      			}
		    }
            
            public IColumn Name{
                get{
                    return this.GetColumn("Name");
                }
            }
				
   			public static string NameColumn{
			      get{
        			return "Name";
      			}
		    }
            
            public IColumn Link{
                get{
                    return this.GetColumn("Link");
                }
            }
				
   			public static string LinkColumn{
			      get{
        			return "Link";
      			}
		    }
            
            public IColumn Sort{
                get{
                    return this.GetColumn("Sort");
                }
            }
				
   			public static string SortColumn{
			      get{
        			return "Sort";
      			}
		    }
            
            public IColumn Description{
                get{
                    return this.GetColumn("Description");
                }
            }
				
   			public static string DescriptionColumn{
			      get{
        			return "Description";
      			}
		    }
            
            public IColumn MetaDescription{
                get{
                    return this.GetColumn("MetaDescription");
                }
            }
				
   			public static string MetaDescriptionColumn{
			      get{
        			return "MetaDescription";
      			}
		    }
            
            public IColumn ParentId{
                get{
                    return this.GetColumn("ParentId");
                }
            }
				
   			public static string ParentIdColumn{
			      get{
        			return "ParentId";
      			}
		    }
            
            public IColumn CateType{
                get{
                    return this.GetColumn("CateType");
                }
            }
				
   			public static string CateTypeColumn{
			      get{
        			return "CateType";
      			}
		    }
            
            public IColumn Headline{
                get{
                    return this.GetColumn("Headline");
                }
            }
				
   			public static string HeadlineColumn{
			      get{
        			return "Headline";
      			}
		    }
            
            public IColumn Note{
                get{
                    return this.GetColumn("Note");
                }
            }
				
   			public static string NoteColumn{
			      get{
        			return "Note";
      			}
		    }
            
            public IColumn NoteBelow{
                get{
                    return this.GetColumn("NoteBelow");
                }
            }
				
   			public static string NoteBelowColumn{
			      get{
        			return "NoteBelow";
      			}
		    }
            
            public IColumn BelowHead{
                get{
                    return this.GetColumn("BelowHead");
                }
            }
				
   			public static string BelowHeadColumn{
			      get{
        			return "BelowHead";
      			}
		    }
            
                    
        }
        
}