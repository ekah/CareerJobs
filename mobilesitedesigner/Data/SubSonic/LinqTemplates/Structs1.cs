


using System;
using SubSonic.Schema;
using System.Collections.Generic;
using SubSonic.DataProviders;
using System.Data;

namespace SubSonic.POCOS1.DB {
	
        /// <summary>
        /// Table: TBL_Patient_Reference
        /// Primary Key: ReferenceId
        /// </summary>

        public class TBL_Patient_ReferenceTable: DatabaseTable {
            
            public TBL_Patient_ReferenceTable(IDataProvider provider):base("TBL_Patient_Reference",provider){
                ClassName = "TBL_Patient_Reference";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ReferenceId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn ReferenceId{
                get{
                    return this.GetColumn("ReferenceId");
                }
            }
            				
   			public static string ReferenceIdColumn{
			      get{
        			return "ReferenceId";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn ReferenceNumber{
                get{
                    return this.GetColumn("ReferenceNumber");
                }
            }
            				
   			public static string ReferenceNumberColumn{
			      get{
        			return "ReferenceNumber";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_Location
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_LocationTable: DatabaseTable {
            
            public TBL_Job_LocationTable(IDataProvider provider):base("TBL_Job_Location",provider){
                ClassName = "TBL_Job_Location";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Lid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Visibility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn Lid{
                get{
                    return this.GetColumn("Lid");
                }
            }
            				
   			public static string LidColumn{
			      get{
        			return "Lid";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
      			}
		    }
           
            public IColumn Visibility{
                get{
                    return this.GetColumn("Visibility");
                }
            }
            				
   			public static string VisibilityColumn{
			      get{
        			return "Visibility";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Building
        /// Primary Key: 
        /// </summary>

        public class TBL_Master_BuildingTable: DatabaseTable {
            
            public TBL_Master_BuildingTable(IDataProvider provider):base("TBL_Master_Building",provider){
                ClassName = "TBL_Master_Building";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
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
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
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
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_SymptomGroup
        /// Primary Key: SymptomGroupId
        /// </summary>

        public class TBL_Master_SymptomGroupTable: DatabaseTable {
            
            public TBL_Master_SymptomGroupTable(IDataProvider provider):base("TBL_Master_SymptomGroup",provider){
                ClassName = "TBL_Master_SymptomGroup";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SymptomGroupId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SymptomGroup", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("RequestedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApproved", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SymptomGroupId{
                get{
                    return this.GetColumn("SymptomGroupId");
                }
            }
            				
   			public static string SymptomGroupIdColumn{
			      get{
        			return "SymptomGroupId";
      			}
		    }
           
            public IColumn SymptomGroup{
                get{
                    return this.GetColumn("SymptomGroup");
                }
            }
            				
   			public static string SymptomGroupColumn{
			      get{
        			return "SymptomGroup";
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
           
            public IColumn RequestedBy{
                get{
                    return this.GetColumn("RequestedBy");
                }
            }
            				
   			public static string RequestedByColumn{
			      get{
        			return "RequestedBy";
      			}
		    }
           
            public IColumn IsApproved{
                get{
                    return this.GetColumn("IsApproved");
                }
            }
            				
   			public static string IsApprovedColumn{
			      get{
        			return "IsApproved";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Floor
        /// Primary Key: 
        /// </summary>

        public class TBL_Master_FloorTable: DatabaseTable {
            
            public TBL_Master_FloorTable(IDataProvider provider):base("TBL_Master_Floor",provider){
                ClassName = "TBL_Master_Floor";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 256
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BuildingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
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
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn BuildingId{
                get{
                    return this.GetColumn("BuildingId");
                }
            }
            				
   			public static string BuildingIdColumn{
			      get{
        			return "BuildingId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Tbl_Master_Ward
        /// Primary Key: 
        /// </summary>

        public class Tbl_Master_WardTable: DatabaseTable {
            
            public Tbl_Master_WardTable(IDataProvider provider):base("Tbl_Master_Ward",provider){
                ClassName = "Tbl_Master_Ward";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FloorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BuildingId", this)
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
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn FloorId{
                get{
                    return this.GetColumn("FloorId");
                }
            }
            				
   			public static string FloorIdColumn{
			      get{
        			return "FloorId";
      			}
		    }
           
            public IColumn BuildingId{
                get{
                    return this.GetColumn("BuildingId");
                }
            }
            				
   			public static string BuildingIdColumn{
			      get{
        			return "BuildingId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Rating
        /// Primary Key: RatingId
        /// </summary>

        public class TBL_RatingTable: DatabaseTable {
            
            public TBL_RatingTable(IDataProvider provider):base("TBL_Rating",provider){
                ClassName = "TBL_Rating";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("RatingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Rating", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn RatingId{
                get{
                    return this.GetColumn("RatingId");
                }
            }
            				
   			public static string RatingIdColumn{
			      get{
        			return "RatingId";
      			}
		    }
           
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn Rating{
                get{
                    return this.GetColumn("Rating");
                }
            }
            				
   			public static string RatingColumn{
			      get{
        			return "Rating";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Symptom
        /// Primary Key: SymptomId
        /// </summary>

        public class TBL_Master_SymptomTable: DatabaseTable {
            
            public TBL_Master_SymptomTable(IDataProvider provider):base("TBL_Master_Symptom",provider){
                ClassName = "TBL_Master_Symptom";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SymptomId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SymptomGroupId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Symptom", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("RequestedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApproved", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsTreatment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SymptomId{
                get{
                    return this.GetColumn("SymptomId");
                }
            }
            				
   			public static string SymptomIdColumn{
			      get{
        			return "SymptomId";
      			}
		    }
           
            public IColumn SymptomGroupId{
                get{
                    return this.GetColumn("SymptomGroupId");
                }
            }
            				
   			public static string SymptomGroupIdColumn{
			      get{
        			return "SymptomGroupId";
      			}
		    }
           
            public IColumn Symptom{
                get{
                    return this.GetColumn("Symptom");
                }
            }
            				
   			public static string SymptomColumn{
			      get{
        			return "Symptom";
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
           
            public IColumn RequestedBy{
                get{
                    return this.GetColumn("RequestedBy");
                }
            }
            				
   			public static string RequestedByColumn{
			      get{
        			return "RequestedBy";
      			}
		    }
           
            public IColumn IsApproved{
                get{
                    return this.GetColumn("IsApproved");
                }
            }
            				
   			public static string IsApprovedColumn{
			      get{
        			return "IsApproved";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn IsTreatment{
                get{
                    return this.GetColumn("IsTreatment");
                }
            }
            				
   			public static string IsTreatmentColumn{
			      get{
        			return "IsTreatment";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Preferential
        /// Primary Key: PreferentialId
        /// </summary>

        public class TBL_Master_PreferentialTable: DatabaseTable {
            
            public TBL_Master_PreferentialTable(IDataProvider provider):base("TBL_Master_Preferential",provider){
                ClassName = "TBL_Master_Preferential";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PreferentialId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PreferentialName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn PreferentialId{
                get{
                    return this.GetColumn("PreferentialId");
                }
            }
            				
   			public static string PreferentialIdColumn{
			      get{
        			return "PreferentialId";
      			}
		    }
           
            public IColumn PreferentialName{
                get{
                    return this.GetColumn("PreferentialName");
                }
            }
            				
   			public static string PreferentialNameColumn{
			      get{
        			return "PreferentialName";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Diagnosis
        /// Primary Key: DiagnosisId
        /// </summary>

        public class TBL_Master_DiagnosisTable: DatabaseTable {
            
            public TBL_Master_DiagnosisTable(IDataProvider provider):base("TBL_Master_Diagnosis",provider){
                ClassName = "TBL_Master_Diagnosi";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DiagnosisId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Diagnosis", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("RequestedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApproved", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsTreatment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DiagnosisId{
                get{
                    return this.GetColumn("DiagnosisId");
                }
            }
            				
   			public static string DiagnosisIdColumn{
			      get{
        			return "DiagnosisId";
      			}
		    }
           
            public IColumn Diagnosis{
                get{
                    return this.GetColumn("Diagnosis");
                }
            }
            				
   			public static string DiagnosisColumn{
			      get{
        			return "Diagnosis";
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
           
            public IColumn RequestedBy{
                get{
                    return this.GetColumn("RequestedBy");
                }
            }
            				
   			public static string RequestedByColumn{
			      get{
        			return "RequestedBy";
      			}
		    }
           
            public IColumn IsApproved{
                get{
                    return this.GetColumn("IsApproved");
                }
            }
            				
   			public static string IsApprovedColumn{
			      get{
        			return "IsApproved";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn IsTreatment{
                get{
                    return this.GetColumn("IsTreatment");
                }
            }
            				
   			public static string IsTreatmentColumn{
			      get{
        			return "IsTreatment";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Answer
        /// Primary Key: AnswerId
        /// </summary>

        public class TBL_AnswerTable: DatabaseTable {
            
            public TBL_AnswerTable(IDataProvider provider):base("TBL_Answer",provider){
                ClassName = "TBL_Answer";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AnswerId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("QuestionId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Answer", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsPatient", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn AnswerId{
                get{
                    return this.GetColumn("AnswerId");
                }
            }
            				
   			public static string AnswerIdColumn{
			      get{
        			return "AnswerId";
      			}
		    }
           
            public IColumn QuestionId{
                get{
                    return this.GetColumn("QuestionId");
                }
            }
            				
   			public static string QuestionIdColumn{
			      get{
        			return "QuestionId";
      			}
		    }
           
            public IColumn Answer{
                get{
                    return this.GetColumn("Answer");
                }
            }
            				
   			public static string AnswerColumn{
			      get{
        			return "Answer";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn IsPatient{
                get{
                    return this.GetColumn("IsPatient");
                }
            }
            				
   			public static string IsPatientColumn{
			      get{
        			return "IsPatient";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_SMS
        /// Primary Key: Id
        /// </summary>

        public class TBL_SMSTable: DatabaseTable {
            
            public TBL_SMSTable(IDataProvider provider):base("TBL_SMS",provider){
                ClassName = "TBL_SM";
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

                Columns.Add(new DatabaseColumn("LoginId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
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

                Columns.Add(new DatabaseColumn("AccountId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SMSMessage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 200
                });

                Columns.Add(new DatabaseColumn("Action", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("EmailCount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MobileId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("ExternalId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
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
           
            public IColumn LoginId{
                get{
                    return this.GetColumn("LoginId");
                }
            }
            				
   			public static string LoginIdColumn{
			      get{
        			return "LoginId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
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
           
            public IColumn AccountId{
                get{
                    return this.GetColumn("AccountId");
                }
            }
            				
   			public static string AccountIdColumn{
			      get{
        			return "AccountId";
      			}
		    }
           
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn SMSMessage{
                get{
                    return this.GetColumn("SMSMessage");
                }
            }
            				
   			public static string SMSMessageColumn{
			      get{
        			return "SMSMessage";
      			}
		    }
           
            public IColumn Action{
                get{
                    return this.GetColumn("Action");
                }
            }
            				
   			public static string ActionColumn{
			      get{
        			return "Action";
      			}
		    }
           
            public IColumn EmailCount{
                get{
                    return this.GetColumn("EmailCount");
                }
            }
            				
   			public static string EmailCountColumn{
			      get{
        			return "EmailCount";
      			}
		    }
           
            public IColumn MobileId{
                get{
                    return this.GetColumn("MobileId");
                }
            }
            				
   			public static string MobileIdColumn{
			      get{
        			return "MobileId";
      			}
		    }
           
            public IColumn ExternalId{
                get{
                    return this.GetColumn("ExternalId");
                }
            }
            				
   			public static string ExternalIdColumn{
			      get{
        			return "ExternalId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Symptom_Diagnosis
        /// Primary Key: 
        /// </summary>

        public class TBL_Symptom_DiagnosisTable: DatabaseTable {
            
            public TBL_Symptom_DiagnosisTable(IDataProvider provider):base("TBL_Symptom_Diagnosis",provider){
                ClassName = "TBL_Symptom_Diagnosi";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SymptomId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DiagnosisId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SymptomId{
                get{
                    return this.GetColumn("SymptomId");
                }
            }
            				
   			public static string SymptomIdColumn{
			      get{
        			return "SymptomId";
      			}
		    }
           
            public IColumn DiagnosisId{
                get{
                    return this.GetColumn("DiagnosisId");
                }
            }
            				
   			public static string DiagnosisIdColumn{
			      get{
        			return "DiagnosisId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Diagnosis_Department
        /// Primary Key: 
        /// </summary>

        public class TBL_Diagnosis_DepartmentTable: DatabaseTable {
            
            public TBL_Diagnosis_DepartmentTable(IDataProvider provider):base("TBL_Diagnosis_Department",provider){
                ClassName = "TBL_Diagnosis_Department";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DiagnosisId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DepartmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DiagnosisId{
                get{
                    return this.GetColumn("DiagnosisId");
                }
            }
            				
   			public static string DiagnosisIdColumn{
			      get{
        			return "DiagnosisId";
      			}
		    }
           
            public IColumn DepartmentId{
                get{
                    return this.GetColumn("DepartmentId");
                }
            }
            				
   			public static string DepartmentIdColumn{
			      get{
        			return "DepartmentId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Question
        /// Primary Key: QuestionId
        /// </summary>

        public class TBL_QuestionTable: DatabaseTable {
            
            public TBL_QuestionTable(IDataProvider provider):base("TBL_Question",provider){
                ClassName = "TBL_Question";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("QuestionId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Question", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn QuestionId{
                get{
                    return this.GetColumn("QuestionId");
                }
            }
            				
   			public static string QuestionIdColumn{
			      get{
        			return "QuestionId";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn Question{
                get{
                    return this.GetColumn("Question");
                }
            }
            				
   			public static string QuestionColumn{
			      get{
        			return "Question";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Doctor_Diagnosis
        /// Primary Key: 
        /// </summary>

        public class TBL_Doctor_DiagnosisTable: DatabaseTable {
            
            public TBL_Doctor_DiagnosisTable(IDataProvider provider):base("TBL_Doctor_Diagnosis",provider){
                ClassName = "TBL_Doctor_Diagnosi";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DiagnosisId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn DiagnosisId{
                get{
                    return this.GetColumn("DiagnosisId");
                }
            }
            				
   			public static string DiagnosisIdColumn{
			      get{
        			return "DiagnosisId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Feedback
        /// Primary Key: FeedbackId
        /// </summary>

        public class TBL_FeedbackTable: DatabaseTable {
            
            public TBL_FeedbackTable(IDataProvider provider):base("TBL_Feedback",provider){
                ClassName = "TBL_Feedback";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FeedbackId", this)
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
	                MaxLength = 150
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

                Columns.Add(new DatabaseColumn("Feedback", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn FeedbackId{
                get{
                    return this.GetColumn("FeedbackId");
                }
            }
            				
   			public static string FeedbackIdColumn{
			      get{
        			return "FeedbackId";
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
           
            public IColumn Feedback{
                get{
                    return this.GetColumn("Feedback");
                }
            }
            				
   			public static string FeedbackColumn{
			      get{
        			return "Feedback";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_KeywordSMS
        /// Primary Key: KeywordSMSId
        /// </summary>

        public class TBL_KeywordSMSTable: DatabaseTable {
            
            public TBL_KeywordSMSTable(IDataProvider provider):base("TBL_KeywordSMS",provider){
                ClassName = "TBL_KeywordSM";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("KeywordSMSId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PhoneCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("Keyword", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Location", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Carrier", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Contents", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PhoneNo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });

                Columns.Add(new DatabaseColumn("Time", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn KeywordSMSId{
                get{
                    return this.GetColumn("KeywordSMSId");
                }
            }
            				
   			public static string KeywordSMSIdColumn{
			      get{
        			return "KeywordSMSId";
      			}
		    }
           
            public IColumn PhoneCode{
                get{
                    return this.GetColumn("PhoneCode");
                }
            }
            				
   			public static string PhoneCodeColumn{
			      get{
        			return "PhoneCode";
      			}
		    }
           
            public IColumn Keyword{
                get{
                    return this.GetColumn("Keyword");
                }
            }
            				
   			public static string KeywordColumn{
			      get{
        			return "Keyword";
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
           
            public IColumn Carrier{
                get{
                    return this.GetColumn("Carrier");
                }
            }
            				
   			public static string CarrierColumn{
			      get{
        			return "Carrier";
      			}
		    }
           
            public IColumn Contents{
                get{
                    return this.GetColumn("Contents");
                }
            }
            				
   			public static string ContentsColumn{
			      get{
        			return "Contents";
      			}
		    }
           
            public IColumn PhoneNo{
                get{
                    return this.GetColumn("PhoneNo");
                }
            }
            				
   			public static string PhoneNoColumn{
			      get{
        			return "PhoneNo";
      			}
		    }
           
            public IColumn Time{
                get{
                    return this.GetColumn("Time");
                }
            }
            				
   			public static string TimeColumn{
			      get{
        			return "Time";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_FamilyHistory
        /// Primary Key: FamilyHistoryId
        /// </summary>

        public class TBL_Master_FamilyHistoryTable: DatabaseTable {
            
            public TBL_Master_FamilyHistoryTable(IDataProvider provider):base("TBL_Master_FamilyHistory",provider){
                ClassName = "TBL_Master_FamilyHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FamilyHistoryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FamilyHistoryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn FamilyHistoryId{
                get{
                    return this.GetColumn("FamilyHistoryId");
                }
            }
            				
   			public static string FamilyHistoryIdColumn{
			      get{
        			return "FamilyHistoryId";
      			}
		    }
           
            public IColumn FamilyHistoryName{
                get{
                    return this.GetColumn("FamilyHistoryName");
                }
            }
            				
   			public static string FamilyHistoryNameColumn{
			      get{
        			return "FamilyHistoryName";
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
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Appointment_Winservice
        /// Primary Key: 
        /// </summary>

        public class TBL_Appointment_WinserviceTable: DatabaseTable {
            
            public TBL_Appointment_WinserviceTable(IDataProvider provider):base("TBL_Appointment_Winservice",provider){
                ClassName = "TBL_Appointment_Winservice";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("WinServiceId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorTimingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceTimingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EmailId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("MobileId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("AppointmentDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MessageDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsSmsSent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsEmailSent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
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

                Columns.Add(new DatabaseColumn("ExternalId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn WinServiceId{
                get{
                    return this.GetColumn("WinServiceId");
                }
            }
            				
   			public static string WinServiceIdColumn{
			      get{
        			return "WinServiceId";
      			}
		    }
           
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn DoctorTimingId{
                get{
                    return this.GetColumn("DoctorTimingId");
                }
            }
            				
   			public static string DoctorTimingIdColumn{
			      get{
        			return "DoctorTimingId";
      			}
		    }
           
            public IColumn ServiceId{
                get{
                    return this.GetColumn("ServiceId");
                }
            }
            				
   			public static string ServiceIdColumn{
			      get{
        			return "ServiceId";
      			}
		    }
           
            public IColumn ServiceTimingId{
                get{
                    return this.GetColumn("ServiceTimingId");
                }
            }
            				
   			public static string ServiceTimingIdColumn{
			      get{
        			return "ServiceTimingId";
      			}
		    }
           
            public IColumn EmailId{
                get{
                    return this.GetColumn("EmailId");
                }
            }
            				
   			public static string EmailIdColumn{
			      get{
        			return "EmailId";
      			}
		    }
           
            public IColumn MobileId{
                get{
                    return this.GetColumn("MobileId");
                }
            }
            				
   			public static string MobileIdColumn{
			      get{
        			return "MobileId";
      			}
		    }
           
            public IColumn AppointmentDate{
                get{
                    return this.GetColumn("AppointmentDate");
                }
            }
            				
   			public static string AppointmentDateColumn{
			      get{
        			return "AppointmentDate";
      			}
		    }
           
            public IColumn MessageDescription{
                get{
                    return this.GetColumn("MessageDescription");
                }
            }
            				
   			public static string MessageDescriptionColumn{
			      get{
        			return "MessageDescription";
      			}
		    }
           
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn IsSmsSent{
                get{
                    return this.GetColumn("IsSmsSent");
                }
            }
            				
   			public static string IsSmsSentColumn{
			      get{
        			return "IsSmsSent";
      			}
		    }
           
            public IColumn IsEmailSent{
                get{
                    return this.GetColumn("IsEmailSent");
                }
            }
            				
   			public static string IsEmailSentColumn{
			      get{
        			return "IsEmailSent";
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
           
            public IColumn ExternalId{
                get{
                    return this.GetColumn("ExternalId");
                }
            }
            				
   			public static string ExternalIdColumn{
			      get{
        			return "ExternalId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Relationship
        /// Primary Key: RelationshipId
        /// </summary>

        public class TBL_Master_RelationshipTable: DatabaseTable {
            
            public TBL_Master_RelationshipTable(IDataProvider provider):base("TBL_Master_Relationship",provider){
                ClassName = "TBL_Master_Relationship";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("RelationshipId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Relationship", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn RelationshipId{
                get{
                    return this.GetColumn("RelationshipId");
                }
            }
            				
   			public static string RelationshipIdColumn{
			      get{
        			return "RelationshipId";
      			}
		    }
           
            public IColumn Relationship{
                get{
                    return this.GetColumn("Relationship");
                }
            }
            				
   			public static string RelationshipColumn{
			      get{
        			return "Relationship";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Status
        /// Primary Key: StatusId
        /// </summary>

        public class TBL_Master_StatusTable: DatabaseTable {
            
            public TBL_Master_StatusTable(IDataProvider provider):base("TBL_Master_Status",provider){
                ClassName = "TBL_Master_Status";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });
                    
                
                
            }
            
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
            				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
           
            public IColumn StatusName{
                get{
                    return this.GetColumn("StatusName");
                }
            }
            				
   			public static string StatusNameColumn{
			      get{
        			return "StatusName";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Doctor_Experience
        /// Primary Key: ExperienceId
        /// </summary>

        public class TBL_Doctor_ExperienceTable: DatabaseTable {
            
            public TBL_Doctor_ExperienceTable(IDataProvider provider):base("TBL_Doctor_Experience",provider){
                ClassName = "TBL_Doctor_Experience";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ExperienceId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MedicalServiceName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("YearFrom", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MonthFrom", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("YearTo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MonthTo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ExperienceId{
                get{
                    return this.GetColumn("ExperienceId");
                }
            }
            				
   			public static string ExperienceIdColumn{
			      get{
        			return "ExperienceId";
      			}
		    }
           
            public IColumn MedicalServiceName{
                get{
                    return this.GetColumn("MedicalServiceName");
                }
            }
            				
   			public static string MedicalServiceNameColumn{
			      get{
        			return "MedicalServiceName";
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
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
      			}
		    }
           
            public IColumn YearFrom{
                get{
                    return this.GetColumn("YearFrom");
                }
            }
            				
   			public static string YearFromColumn{
			      get{
        			return "YearFrom";
      			}
		    }
           
            public IColumn MonthFrom{
                get{
                    return this.GetColumn("MonthFrom");
                }
            }
            				
   			public static string MonthFromColumn{
			      get{
        			return "MonthFrom";
      			}
		    }
           
            public IColumn YearTo{
                get{
                    return this.GetColumn("YearTo");
                }
            }
            				
   			public static string YearToColumn{
			      get{
        			return "YearTo";
      			}
		    }
           
            public IColumn MonthTo{
                get{
                    return this.GetColumn("MonthTo");
                }
            }
            				
   			public static string MonthToColumn{
			      get{
        			return "MonthTo";
      			}
		    }
           
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
            				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_PersonalHistory
        /// Primary Key: PersonalHistoryId
        /// </summary>

        public class TBL_Master_PersonalHistoryTable: DatabaseTable {
            
            public TBL_Master_PersonalHistoryTable(IDataProvider provider):base("TBL_Master_PersonalHistory",provider){
                ClassName = "TBL_Master_PersonalHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PersonalHistoryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PersonalHistoryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn PersonalHistoryId{
                get{
                    return this.GetColumn("PersonalHistoryId");
                }
            }
            				
   			public static string PersonalHistoryIdColumn{
			      get{
        			return "PersonalHistoryId";
      			}
		    }
           
            public IColumn PersonalHistoryName{
                get{
                    return this.GetColumn("PersonalHistoryName");
                }
            }
            				
   			public static string PersonalHistoryNameColumn{
			      get{
        			return "PersonalHistoryName";
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
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Patient_SearchCount
        /// Primary Key: SearchId
        /// </summary>

        public class TBL_Patient_SearchCountTable: DatabaseTable {
            
            public TBL_Patient_SearchCountTable(IDataProvider provider):base("TBL_Patient_SearchCount",provider){
                ClassName = "TBL_Patient_SearchCount";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SearchId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("StateName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("CityName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 350
                });

                Columns.Add(new DatabaseColumn("Speciality", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("SpecialityType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SearchCount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SearchType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SearchId{
                get{
                    return this.GetColumn("SearchId");
                }
            }
            				
   			public static string SearchIdColumn{
			      get{
        			return "SearchId";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn CountryName{
                get{
                    return this.GetColumn("CountryName");
                }
            }
            				
   			public static string CountryNameColumn{
			      get{
        			return "CountryName";
      			}
		    }
           
            public IColumn StateName{
                get{
                    return this.GetColumn("StateName");
                }
            }
            				
   			public static string StateNameColumn{
			      get{
        			return "StateName";
      			}
		    }
           
            public IColumn CityName{
                get{
                    return this.GetColumn("CityName");
                }
            }
            				
   			public static string CityNameColumn{
			      get{
        			return "CityName";
      			}
		    }
           
            public IColumn Speciality{
                get{
                    return this.GetColumn("Speciality");
                }
            }
            				
   			public static string SpecialityColumn{
			      get{
        			return "Speciality";
      			}
		    }
           
            public IColumn SpecialityType{
                get{
                    return this.GetColumn("SpecialityType");
                }
            }
            				
   			public static string SpecialityTypeColumn{
			      get{
        			return "SpecialityType";
      			}
		    }
           
            public IColumn SearchCount{
                get{
                    return this.GetColumn("SearchCount");
                }
            }
            				
   			public static string SearchCountColumn{
			      get{
        			return "SearchCount";
      			}
		    }
           
            public IColumn SearchType{
                get{
                    return this.GetColumn("SearchType");
                }
            }
            				
   			public static string SearchTypeColumn{
			      get{
        			return "SearchType";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Patient_FamilyHistory
        /// Primary Key: 
        /// </summary>

        public class TBL_Patient_FamilyHistoryTable: DatabaseTable {
            
            public TBL_Patient_FamilyHistoryTable(IDataProvider provider):base("TBL_Patient_FamilyHistory",provider){
                ClassName = "TBL_Patient_FamilyHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FamilyHistoryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn FamilyHistoryId{
                get{
                    return this.GetColumn("FamilyHistoryId");
                }
            }
            				
   			public static string FamilyHistoryIdColumn{
			      get{
        			return "FamilyHistoryId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_PastHistory
        /// Primary Key: PastHistoryId
        /// </summary>

        public class TBL_Master_PastHistoryTable: DatabaseTable {
            
            public TBL_Master_PastHistoryTable(IDataProvider provider):base("TBL_Master_PastHistory",provider){
                ClassName = "TBL_Master_PastHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PastHistoryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PastHistoryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });
                    
                
                
            }
            
            public IColumn PastHistoryId{
                get{
                    return this.GetColumn("PastHistoryId");
                }
            }
            				
   			public static string PastHistoryIdColumn{
			      get{
        			return "PastHistoryId";
      			}
		    }
           
            public IColumn PastHistoryName{
                get{
                    return this.GetColumn("PastHistoryName");
                }
            }
            				
   			public static string PastHistoryNameColumn{
			      get{
        			return "PastHistoryName";
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
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Patient
        /// Primary Key: PatientId
        /// </summary>

        public class TBL_PatientTable: DatabaseTable {
            
            public TBL_PatientTable(IDataProvider provider):base("TBL_Patient",provider){
                ClassName = "TBL_Patient";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("DateofBirth", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Gender", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("AddressLine1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("AddressLine2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("PostalCode", this)
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

                Columns.Add(new DatabaseColumn("Mobile", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("RelationshipId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
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

                Columns.Add(new DatabaseColumn("ReferenceToken", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("ReferedPatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActivated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn LoginId{
                get{
                    return this.GetColumn("LoginId");
                }
            }
            				
   			public static string LoginIdColumn{
			      get{
        			return "LoginId";
      			}
		    }
           
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
            				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
           
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
            				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
           
            public IColumn DateofBirth{
                get{
                    return this.GetColumn("DateofBirth");
                }
            }
            				
   			public static string DateofBirthColumn{
			      get{
        			return "DateofBirth";
      			}
		    }
           
            public IColumn Gender{
                get{
                    return this.GetColumn("Gender");
                }
            }
            				
   			public static string GenderColumn{
			      get{
        			return "Gender";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
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
           
            public IColumn AddressLine1{
                get{
                    return this.GetColumn("AddressLine1");
                }
            }
            				
   			public static string AddressLine1Column{
			      get{
        			return "AddressLine1";
      			}
		    }
           
            public IColumn AddressLine2{
                get{
                    return this.GetColumn("AddressLine2");
                }
            }
            				
   			public static string AddressLine2Column{
			      get{
        			return "AddressLine2";
      			}
		    }
           
            public IColumn PostalCode{
                get{
                    return this.GetColumn("PostalCode");
                }
            }
            				
   			public static string PostalCodeColumn{
			      get{
        			return "PostalCode";
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
           
            public IColumn RelationshipId{
                get{
                    return this.GetColumn("RelationshipId");
                }
            }
            				
   			public static string RelationshipIdColumn{
			      get{
        			return "RelationshipId";
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
           
            public IColumn ReferenceToken{
                get{
                    return this.GetColumn("ReferenceToken");
                }
            }
            				
   			public static string ReferenceTokenColumn{
			      get{
        			return "ReferenceToken";
      			}
		    }
           
            public IColumn ReferedPatientId{
                get{
                    return this.GetColumn("ReferedPatientId");
                }
            }
            				
   			public static string ReferedPatientIdColumn{
			      get{
        			return "ReferedPatientId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsActivated{
                get{
                    return this.GetColumn("IsActivated");
                }
            }
            				
   			public static string IsActivatedColumn{
			      get{
        			return "IsActivated";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_AccountType
        /// Primary Key: AccountTypeId
        /// </summary>

        public class TBL_Master_AccountTypeTable: DatabaseTable {
            
            public TBL_Master_AccountTypeTable(IDataProvider provider):base("TBL_Master_AccountType",provider){
                ClassName = "TBL_Master_AccountType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountTypeName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Prefix", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 5
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn AccountTypeName{
                get{
                    return this.GetColumn("AccountTypeName");
                }
            }
            				
   			public static string AccountTypeNameColumn{
			      get{
        			return "AccountTypeName";
      			}
		    }
           
            public IColumn Prefix{
                get{
                    return this.GetColumn("Prefix");
                }
            }
            				
   			public static string PrefixColumn{
			      get{
        			return "Prefix";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Reference
        /// Primary Key: ReferenceId
        /// </summary>

        public class TBL_ReferenceTable: DatabaseTable {
            
            public TBL_ReferenceTable(IDataProvider provider):base("TBL_Reference",provider){
                ClassName = "TBL_Reference";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ReferenceId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferedTo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Reason", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ReferenceId{
                get{
                    return this.GetColumn("ReferenceId");
                }
            }
            				
   			public static string ReferenceIdColumn{
			      get{
        			return "ReferenceId";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn ReferedBy{
                get{
                    return this.GetColumn("ReferedBy");
                }
            }
            				
   			public static string ReferedByColumn{
			      get{
        			return "ReferedBy";
      			}
		    }
           
            public IColumn ReferedTo{
                get{
                    return this.GetColumn("ReferedTo");
                }
            }
            				
   			public static string ReferedToColumn{
			      get{
        			return "ReferedTo";
      			}
		    }
           
            public IColumn Reason{
                get{
                    return this.GetColumn("Reason");
                }
            }
            				
   			public static string ReasonColumn{
			      get{
        			return "Reason";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Patient_PersonalHistory
        /// Primary Key: 
        /// </summary>

        public class TBL_Patient_PersonalHistoryTable: DatabaseTable {
            
            public TBL_Patient_PersonalHistoryTable(IDataProvider provider):base("TBL_Patient_PersonalHistory",provider){
                ClassName = "TBL_Patient_PersonalHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PersonalHistoryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn PersonalHistoryId{
                get{
                    return this.GetColumn("PersonalHistoryId");
                }
            }
            				
   			public static string PersonalHistoryIdColumn{
			      get{
        			return "PersonalHistoryId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Patient_PastHistory
        /// Primary Key: 
        /// </summary>

        public class TBL_Patient_PastHistoryTable: DatabaseTable {
            
            public TBL_Patient_PastHistoryTable(IDataProvider provider):base("TBL_Patient_PastHistory",provider){
                ClassName = "TBL_Patient_PastHistory";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PastHistoryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn PastHistoryId{
                get{
                    return this.GetColumn("PastHistoryId");
                }
            }
            				
   			public static string PastHistoryIdColumn{
			      get{
        			return "PastHistoryId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Department
        /// Primary Key: DepartmentId
        /// </summary>

        public class TBL_Master_DepartmentTable: DatabaseTable {
            
            public TBL_Master_DepartmentTable(IDataProvider provider):base("TBL_Master_Department",provider){
                ClassName = "TBL_Master_Department";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DepartmentId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DepartmentName", this)
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
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("RequestedBy", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApproved", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DepartmentId{
                get{
                    return this.GetColumn("DepartmentId");
                }
            }
            				
   			public static string DepartmentIdColumn{
			      get{
        			return "DepartmentId";
      			}
		    }
           
            public IColumn DepartmentName{
                get{
                    return this.GetColumn("DepartmentName");
                }
            }
            				
   			public static string DepartmentNameColumn{
			      get{
        			return "DepartmentName";
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
           
            public IColumn RequestedBy{
                get{
                    return this.GetColumn("RequestedBy");
                }
            }
            				
   			public static string RequestedByColumn{
			      get{
        			return "RequestedBy";
      			}
		    }
           
            public IColumn IsApproved{
                get{
                    return this.GetColumn("IsApproved");
                }
            }
            				
   			public static string IsApprovedColumn{
			      get{
        			return "IsApproved";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_City_old
        /// Primary Key: CityId
        /// </summary>

        public class TBL_Master_City_oldTable: DatabaseTable {
            
            public TBL_Master_City_oldTable(IDataProvider provider):base("TBL_Master_City_old",provider){
                ClassName = "TBL_Master_City_old";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CityName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 350
                });

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LocationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
      			}
		    }
           
            public IColumn CityName{
                get{
                    return this.GetColumn("CityName");
                }
            }
            				
   			public static string CityNameColumn{
			      get{
        			return "CityName";
      			}
		    }
           
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn LocationId{
                get{
                    return this.GetColumn("LocationId");
                }
            }
            				
   			public static string LocationIdColumn{
			      get{
        			return "LocationId";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_State_old
        /// Primary Key: StateId
        /// </summary>

        public class TBL_Master_State_oldTable: DatabaseTable {
            
            public TBL_Master_State_oldTable(IDataProvider provider):base("TBL_Master_State_old",provider){
                ClassName = "TBL_Master_State_old";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });
                    
                
                
            }
            
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn StateName{
                get{
                    return this.GetColumn("StateName");
                }
            }
            				
   			public static string StateNameColumn{
			      get{
        			return "StateName";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn StateCode{
                get{
                    return this.GetColumn("StateCode");
                }
            }
            				
   			public static string StateCodeColumn{
			      get{
        			return "StateCode";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_GeoPostcodes
        /// Primary Key: Country
        /// </summary>

        public class TBL_GeoPostcodesTable: DatabaseTable {
            
            public TBL_GeoPostcodesTable(IDataProvider provider):base("TBL_GeoPostcodes",provider){
                ClassName = "TBL_GeoPostcode";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("Language", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int64,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RegISO2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 6
                });

                Columns.Add(new DatabaseColumn("Region1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("Region2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("Region3", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("Region4", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("ZIP", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("Area1", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 80
                });

                Columns.Add(new DatabaseColumn("Area2", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 80
                });

                Columns.Add(new DatabaseColumn("Lat", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Lng", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Double,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TZ", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 30
                });

                Columns.Add(new DatabaseColumn("UTC", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("DST", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1
                });
                    
                
                
            }
            
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn Language{
                get{
                    return this.GetColumn("Language");
                }
            }
            				
   			public static string LanguageColumn{
			      get{
        			return "Language";
      			}
		    }
           
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
      			}
		    }
           
            public IColumn RegISO2{
                get{
                    return this.GetColumn("RegISO2");
                }
            }
            				
   			public static string RegISO2Column{
			      get{
        			return "RegISO2";
      			}
		    }
           
            public IColumn Region1{
                get{
                    return this.GetColumn("Region1");
                }
            }
            				
   			public static string Region1Column{
			      get{
        			return "Region1";
      			}
		    }
           
            public IColumn Region2{
                get{
                    return this.GetColumn("Region2");
                }
            }
            				
   			public static string Region2Column{
			      get{
        			return "Region2";
      			}
		    }
           
            public IColumn Region3{
                get{
                    return this.GetColumn("Region3");
                }
            }
            				
   			public static string Region3Column{
			      get{
        			return "Region3";
      			}
		    }
           
            public IColumn Region4{
                get{
                    return this.GetColumn("Region4");
                }
            }
            				
   			public static string Region4Column{
			      get{
        			return "Region4";
      			}
		    }
           
            public IColumn ZIP{
                get{
                    return this.GetColumn("ZIP");
                }
            }
            				
   			public static string ZIPColumn{
			      get{
        			return "ZIP";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Area1{
                get{
                    return this.GetColumn("Area1");
                }
            }
            				
   			public static string Area1Column{
			      get{
        			return "Area1";
      			}
		    }
           
            public IColumn Area2{
                get{
                    return this.GetColumn("Area2");
                }
            }
            				
   			public static string Area2Column{
			      get{
        			return "Area2";
      			}
		    }
           
            public IColumn Lat{
                get{
                    return this.GetColumn("Lat");
                }
            }
            				
   			public static string LatColumn{
			      get{
        			return "Lat";
      			}
		    }
           
            public IColumn Lng{
                get{
                    return this.GetColumn("Lng");
                }
            }
            				
   			public static string LngColumn{
			      get{
        			return "Lng";
      			}
		    }
           
            public IColumn TZ{
                get{
                    return this.GetColumn("TZ");
                }
            }
            				
   			public static string TZColumn{
			      get{
        			return "TZ";
      			}
		    }
           
            public IColumn UTC{
                get{
                    return this.GetColumn("UTC");
                }
            }
            				
   			public static string UTCColumn{
			      get{
        			return "UTC";
      			}
		    }
           
            public IColumn DST{
                get{
                    return this.GetColumn("DST");
                }
            }
            				
   			public static string DSTColumn{
			      get{
        			return "DST";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Country_old
        /// Primary Key: CountryId
        /// </summary>

        public class TBL_Master_Country_oldTable: DatabaseTable {
            
            public TBL_Master_Country_oldTable(IDataProvider provider):base("TBL_Master_Country_old",provider){
                ClassName = "TBL_Master_Country_old";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("CountryCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("InternationalCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn CountryName{
                get{
                    return this.GetColumn("CountryName");
                }
            }
            				
   			public static string CountryNameColumn{
			      get{
        			return "CountryName";
      			}
		    }
           
            public IColumn CountryCode{
                get{
                    return this.GetColumn("CountryCode");
                }
            }
            				
   			public static string CountryCodeColumn{
			      get{
        			return "CountryCode";
      			}
		    }
           
            public IColumn InternationalCode{
                get{
                    return this.GetColumn("InternationalCode");
                }
            }
            				
   			public static string InternationalCodeColumn{
			      get{
        			return "InternationalCode";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Mapping_Status
        /// Primary Key: 
        /// </summary>

        public class TBL_Mapping_StatusTable: DatabaseTable {
            
            public TBL_Mapping_StatusTable(IDataProvider provider):base("TBL_Mapping_Status",provider){
                ClassName = "TBL_Mapping_Status";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Type", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ParentStatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
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
           
            public IColumn Type{
                get{
                    return this.GetColumn("Type");
                }
            }
            				
   			public static string TypeColumn{
			      get{
        			return "Type";
      			}
		    }
           
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
            				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
           
            public IColumn ParentStatusId{
                get{
                    return this.GetColumn("ParentStatusId");
                }
            }
            				
   			public static string ParentStatusIdColumn{
			      get{
        			return "ParentStatusId";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_GeoPostcodes_Country
        /// Primary Key: CountryCode
        /// </summary>

        public class TBL_GeoPostcodes_CountryTable: DatabaseTable {
            
            public TBL_GeoPostcodes_CountryTable(IDataProvider provider):base("TBL_GeoPostcodes_Country",provider){
                ClassName = "TBL_GeoPostcodes_Country";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CountryCode", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });

                Columns.Add(new DatabaseColumn("CountryName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 60
                });

                Columns.Add(new DatabaseColumn("InternationalCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn CountryCode{
                get{
                    return this.GetColumn("CountryCode");
                }
            }
            				
   			public static string CountryCodeColumn{
			      get{
        			return "CountryCode";
      			}
		    }
           
            public IColumn CountryName{
                get{
                    return this.GetColumn("CountryName");
                }
            }
            				
   			public static string CountryNameColumn{
			      get{
        			return "CountryName";
      			}
		    }
           
            public IColumn InternationalCode{
                get{
                    return this.GetColumn("InternationalCode");
                }
            }
            				
   			public static string InternationalCodeColumn{
			      get{
        			return "InternationalCode";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Mapping_Bed
        /// Primary Key: 
        /// </summary>

        public class TBL_Mapping_BedTable: DatabaseTable {
            
            public TBL_Mapping_BedTable(IDataProvider provider):base("TBL_Mapping_Bed",provider){
                ClassName = "TBL_Mapping_Bed";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActionId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BedId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("EventTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsTransfer", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActionTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
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
           
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn ActionId{
                get{
                    return this.GetColumn("ActionId");
                }
            }
            				
   			public static string ActionIdColumn{
			      get{
        			return "ActionId";
      			}
		    }
           
            public IColumn BedId{
                get{
                    return this.GetColumn("BedId");
                }
            }
            				
   			public static string BedIdColumn{
			      get{
        			return "BedId";
      			}
		    }
           
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
            				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn EventTime{
                get{
                    return this.GetColumn("EventTime");
                }
            }
            				
   			public static string EventTimeColumn{
			      get{
        			return "EventTime";
      			}
		    }
           
            public IColumn IsTransfer{
                get{
                    return this.GetColumn("IsTransfer");
                }
            }
            				
   			public static string IsTransferColumn{
			      get{
        			return "IsTransfer";
      			}
		    }
           
            public IColumn ActionTypeId{
                get{
                    return this.GetColumn("ActionTypeId");
                }
            }
            				
   			public static string ActionTypeIdColumn{
			      get{
        			return "ActionTypeId";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Doctor_Timing
        /// Primary Key: DoctorTimingId
        /// </summary>

        public class TBL_Doctor_TimingTable: DatabaseTable {
            
            public TBL_Doctor_TimingTable(IDataProvider provider):base("TBL_Doctor_Timing",provider){
                ClassName = "TBL_Doctor_Timing";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DoctorTimingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ScheduleName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Sunday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Monday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Tuesday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Wednesday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Thursday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Friday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Saturday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("EndTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("PatientDuration", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApprovalSystem", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApprovalNotificationSMS", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApprovalNotificationEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaxAppointmentDays", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDefaultAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsCarParkFacility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsFCFS", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaxApps", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Conditions", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DoctorTimingId{
                get{
                    return this.GetColumn("DoctorTimingId");
                }
            }
            				
   			public static string DoctorTimingIdColumn{
			      get{
        			return "DoctorTimingId";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn ScheduleName{
                get{
                    return this.GetColumn("ScheduleName");
                }
            }
            				
   			public static string ScheduleNameColumn{
			      get{
        			return "ScheduleName";
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
           
            public IColumn Sunday{
                get{
                    return this.GetColumn("Sunday");
                }
            }
            				
   			public static string SundayColumn{
			      get{
        			return "Sunday";
      			}
		    }
           
            public IColumn Monday{
                get{
                    return this.GetColumn("Monday");
                }
            }
            				
   			public static string MondayColumn{
			      get{
        			return "Monday";
      			}
		    }
           
            public IColumn Tuesday{
                get{
                    return this.GetColumn("Tuesday");
                }
            }
            				
   			public static string TuesdayColumn{
			      get{
        			return "Tuesday";
      			}
		    }
           
            public IColumn Wednesday{
                get{
                    return this.GetColumn("Wednesday");
                }
            }
            				
   			public static string WednesdayColumn{
			      get{
        			return "Wednesday";
      			}
		    }
           
            public IColumn Thursday{
                get{
                    return this.GetColumn("Thursday");
                }
            }
            				
   			public static string ThursdayColumn{
			      get{
        			return "Thursday";
      			}
		    }
           
            public IColumn Friday{
                get{
                    return this.GetColumn("Friday");
                }
            }
            				
   			public static string FridayColumn{
			      get{
        			return "Friday";
      			}
		    }
           
            public IColumn Saturday{
                get{
                    return this.GetColumn("Saturday");
                }
            }
            				
   			public static string SaturdayColumn{
			      get{
        			return "Saturday";
      			}
		    }
           
            public IColumn StartTime{
                get{
                    return this.GetColumn("StartTime");
                }
            }
            				
   			public static string StartTimeColumn{
			      get{
        			return "StartTime";
      			}
		    }
           
            public IColumn EndTime{
                get{
                    return this.GetColumn("EndTime");
                }
            }
            				
   			public static string EndTimeColumn{
			      get{
        			return "EndTime";
      			}
		    }
           
            public IColumn PatientDuration{
                get{
                    return this.GetColumn("PatientDuration");
                }
            }
            				
   			public static string PatientDurationColumn{
			      get{
        			return "PatientDuration";
      			}
		    }
           
            public IColumn IsApprovalSystem{
                get{
                    return this.GetColumn("IsApprovalSystem");
                }
            }
            				
   			public static string IsApprovalSystemColumn{
			      get{
        			return "IsApprovalSystem";
      			}
		    }
           
            public IColumn IsApprovalNotificationSMS{
                get{
                    return this.GetColumn("IsApprovalNotificationSMS");
                }
            }
            				
   			public static string IsApprovalNotificationSMSColumn{
			      get{
        			return "IsApprovalNotificationSMS";
      			}
		    }
           
            public IColumn IsApprovalNotificationEmail{
                get{
                    return this.GetColumn("IsApprovalNotificationEmail");
                }
            }
            				
   			public static string IsApprovalNotificationEmailColumn{
			      get{
        			return "IsApprovalNotificationEmail";
      			}
		    }
           
            public IColumn MaxAppointmentDays{
                get{
                    return this.GetColumn("MaxAppointmentDays");
                }
            }
            				
   			public static string MaxAppointmentDaysColumn{
			      get{
        			return "MaxAppointmentDays";
      			}
		    }
           
            public IColumn IsDefaultAddress{
                get{
                    return this.GetColumn("IsDefaultAddress");
                }
            }
            				
   			public static string IsDefaultAddressColumn{
			      get{
        			return "IsDefaultAddress";
      			}
		    }
           
            public IColumn IsCarParkFacility{
                get{
                    return this.GetColumn("IsCarParkFacility");
                }
            }
            				
   			public static string IsCarParkFacilityColumn{
			      get{
        			return "IsCarParkFacility";
      			}
		    }
           
            public IColumn IsFCFS{
                get{
                    return this.GetColumn("IsFCFS");
                }
            }
            				
   			public static string IsFCFSColumn{
			      get{
        			return "IsFCFS";
      			}
		    }
           
            public IColumn MaxApps{
                get{
                    return this.GetColumn("MaxApps");
                }
            }
            				
   			public static string MaxAppsColumn{
			      get{
        			return "MaxApps";
      			}
		    }
           
            public IColumn AppointmentType{
                get{
                    return this.GetColumn("AppointmentType");
                }
            }
            				
   			public static string AppointmentTypeColumn{
			      get{
        			return "AppointmentType";
      			}
		    }
           
            public IColumn Conditions{
                get{
                    return this.GetColumn("Conditions");
                }
            }
            				
   			public static string ConditionsColumn{
			      get{
        			return "Conditions";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Tbl_Temp_State
        /// Primary Key: 
        /// </summary>

        public class Tbl_Temp_StateTable: DatabaseTable {
            
            public Tbl_Temp_StateTable(IDataProvider provider):base("Tbl_Temp_State",provider){
                ClassName = "Tbl_Temp_State";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StateUnionTerritory", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 256
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 256
                });
                    
                
                
            }
            
            public IColumn StateUnionTerritory{
                get{
                    return this.GetColumn("StateUnionTerritory");
                }
            }
            				
   			public static string StateUnionTerritoryColumn{
			      get{
        			return "StateUnionTerritory";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_GeoPostcodes_State
        /// Primary Key: StateId
        /// </summary>

        public class TBL_GeoPostcodes_StateTable: DatabaseTable {
            
            public TBL_GeoPostcodes_StateTable(IDataProvider provider):base("TBL_GeoPostcodes_State",provider){
                ClassName = "TBL_GeoPostcodes_State";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("StateCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 6
                });

                Columns.Add(new DatabaseColumn("CountryCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });
                    
                
                
            }
            
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn StateName{
                get{
                    return this.GetColumn("StateName");
                }
            }
            				
   			public static string StateNameColumn{
			      get{
        			return "StateName";
      			}
		    }
           
            public IColumn StateCode{
                get{
                    return this.GetColumn("StateCode");
                }
            }
            				
   			public static string StateCodeColumn{
			      get{
        			return "StateCode";
      			}
		    }
           
            public IColumn CountryCode{
                get{
                    return this.GetColumn("CountryCode");
                }
            }
            				
   			public static string CountryCodeColumn{
			      get{
        			return "CountryCode";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_SubAdminLogin
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_SubAdminLoginTable: DatabaseTable {
            
            public TBL_Job_SubAdminLoginTable(IDataProvider provider):base("TBL_Job_SubAdminLogin",provider){
                ClassName = "TBL_Job_SubAdminLogin";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Sid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn Sid{
                get{
                    return this.GetColumn("Sid");
                }
            }
            				
   			public static string SidColumn{
			      get{
        			return "Sid";
      			}
		    }
           
            public IColumn UserName{
                get{
                    return this.GetColumn("UserName");
                }
            }
            				
   			public static string UserNameColumn{
			      get{
        			return "UserName";
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
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Patient_UHID
        /// Primary Key: Id
        /// </summary>

        public class TBL_Patient_UHIDTable: DatabaseTable {
            
            public TBL_Patient_UHIDTable(IDataProvider provider):base("TBL_Patient_UHID",provider){
                ClassName = "TBL_Patient_UHID";
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

                Columns.Add(new DatabaseColumn("UHID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
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
           
            public IColumn UHID{
                get{
                    return this.GetColumn("UHID");
                }
            }
            				
   			public static string UHIDColumn{
			      get{
        			return "UHID";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_GeoPostcodes_City
        /// Primary Key: CityId
        /// </summary>

        public class TBL_GeoPostcodes_CityTable: DatabaseTable {
            
            public TBL_GeoPostcodes_CityTable(IDataProvider provider):base("TBL_GeoPostcodes_City",provider){
                ClassName = "TBL_GeoPostcodes_City";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CityName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 120
                });

                Columns.Add(new DatabaseColumn("StateCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 6
                });

                Columns.Add(new DatabaseColumn("CountryCode", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2
                });
                    
                
                
            }
            
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
      			}
		    }
           
            public IColumn CityName{
                get{
                    return this.GetColumn("CityName");
                }
            }
            				
   			public static string CityNameColumn{
			      get{
        			return "CityName";
      			}
		    }
           
            public IColumn StateCode{
                get{
                    return this.GetColumn("StateCode");
                }
            }
            				
   			public static string StateCodeColumn{
			      get{
        			return "StateCode";
      			}
		    }
           
            public IColumn CountryCode{
                get{
                    return this.GetColumn("CountryCode");
                }
            }
            				
   			public static string CountryCodeColumn{
			      get{
        			return "CountryCode";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_Speciality
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_SpecialityTable: DatabaseTable {
            
            public TBL_Job_SpecialityTable(IDataProvider provider):base("TBL_Job_Speciality",provider){
                ClassName = "TBL_Job_Speciality";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SpcId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SpecialityId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Visibility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn SpcId{
                get{
                    return this.GetColumn("SpcId");
                }
            }
            				
   			public static string SpcIdColumn{
			      get{
        			return "SpcId";
      			}
		    }
           
            public IColumn SpecialityId{
                get{
                    return this.GetColumn("SpecialityId");
                }
            }
            				
   			public static string SpecialityIdColumn{
			      get{
        			return "SpecialityId";
      			}
		    }
           
            public IColumn Visibility{
                get{
                    return this.GetColumn("Visibility");
                }
            }
            				
   			public static string VisibilityColumn{
			      get{
        			return "Visibility";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Landing_MainTab
        /// Primary Key: MainTabId
        /// </summary>

        public class TBL_Landing_MainTabTable: DatabaseTable {
            
            public TBL_Landing_MainTabTable(IDataProvider provider):base("TBL_Landing_MainTab",provider){
                ClassName = "TBL_Landing_MainTab";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("MainTabId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MainTabName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("MainTabContent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });

                Columns.Add(new DatabaseColumn("LandingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn MainTabId{
                get{
                    return this.GetColumn("MainTabId");
                }
            }
            				
   			public static string MainTabIdColumn{
			      get{
        			return "MainTabId";
      			}
		    }
           
            public IColumn MainTabName{
                get{
                    return this.GetColumn("MainTabName");
                }
            }
            				
   			public static string MainTabNameColumn{
			      get{
        			return "MainTabName";
      			}
		    }
           
            public IColumn MainTabContent{
                get{
                    return this.GetColumn("MainTabContent");
                }
            }
            				
   			public static string MainTabContentColumn{
			      get{
        			return "MainTabContent";
      			}
		    }
           
            public IColumn LandingId{
                get{
                    return this.GetColumn("LandingId");
                }
            }
            				
   			public static string LandingIdColumn{
			      get{
        			return "LandingId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_BlockCalendar
        /// Primary Key: BlockId
        /// </summary>

        public class TBL_BlockCalendarTable: DatabaseTable {
            
            public TBL_BlockCalendarTable(IDataProvider provider):base("TBL_BlockCalendar",provider){
                ClassName = "TBL_BlockCalendar";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("BlockId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BlockTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Type", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorTimingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceTimingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BlockStart", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BlockEnd", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Reason", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn BlockId{
                get{
                    return this.GetColumn("BlockId");
                }
            }
            				
   			public static string BlockIdColumn{
			      get{
        			return "BlockId";
      			}
		    }
           
            public IColumn BlockTypeId{
                get{
                    return this.GetColumn("BlockTypeId");
                }
            }
            				
   			public static string BlockTypeIdColumn{
			      get{
        			return "BlockTypeId";
      			}
		    }
           
            public IColumn Type{
                get{
                    return this.GetColumn("Type");
                }
            }
            				
   			public static string TypeColumn{
			      get{
        			return "Type";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn ServiceId{
                get{
                    return this.GetColumn("ServiceId");
                }
            }
            				
   			public static string ServiceIdColumn{
			      get{
        			return "ServiceId";
      			}
		    }
           
            public IColumn DoctorTimingId{
                get{
                    return this.GetColumn("DoctorTimingId");
                }
            }
            				
   			public static string DoctorTimingIdColumn{
			      get{
        			return "DoctorTimingId";
      			}
		    }
           
            public IColumn ServiceTimingId{
                get{
                    return this.GetColumn("ServiceTimingId");
                }
            }
            				
   			public static string ServiceTimingIdColumn{
			      get{
        			return "ServiceTimingId";
      			}
		    }
           
            public IColumn BlockStart{
                get{
                    return this.GetColumn("BlockStart");
                }
            }
            				
   			public static string BlockStartColumn{
			      get{
        			return "BlockStart";
      			}
		    }
           
            public IColumn BlockEnd{
                get{
                    return this.GetColumn("BlockEnd");
                }
            }
            				
   			public static string BlockEndColumn{
			      get{
        			return "BlockEnd";
      			}
		    }
           
            public IColumn Reason{
                get{
                    return this.GetColumn("Reason");
                }
            }
            				
   			public static string ReasonColumn{
			      get{
        			return "Reason";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_SearchWidgetColVisible
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_SearchWidgetColVisibleTable: DatabaseTable {
            
            public TBL_Job_SearchWidgetColVisibleTable(IDataProvider provider):base("TBL_Job_SearchWidgetColVisible",provider){
                ClassName = "TBL_Job_SearchWidgetColVisible";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SwId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Facility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn SwId{
                get{
                    return this.GetColumn("SwId");
                }
            }
            				
   			public static string SwIdColumn{
			      get{
        			return "SwId";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
            				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Facility{
                get{
                    return this.GetColumn("Facility");
                }
            }
            				
   			public static string FacilityColumn{
			      get{
        			return "Facility";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Service_Timing
        /// Primary Key: ServiceTimingId
        /// </summary>

        public class TBL_Service_TimingTable: DatabaseTable {
            
            public TBL_Service_TimingTable(IDataProvider provider):base("TBL_Service_Timing",provider){
                ClassName = "TBL_Service_Timing";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ServiceTimingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ScheduleName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Address", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("Sunday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Monday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Tuesday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Wednesday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Thursday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Friday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Saturday", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StartTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("EndTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("PatientDuration", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("IsApprovalSystem", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApprovalNotificationSMS", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsApprovalNotificationEmail", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaxAppointmentDays", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDefaultAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsCarParkFacility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsFCFS", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MaxApps", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Conditions", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ServiceTimingId{
                get{
                    return this.GetColumn("ServiceTimingId");
                }
            }
            				
   			public static string ServiceTimingIdColumn{
			      get{
        			return "ServiceTimingId";
      			}
		    }
           
            public IColumn ServiceId{
                get{
                    return this.GetColumn("ServiceId");
                }
            }
            				
   			public static string ServiceIdColumn{
			      get{
        			return "ServiceId";
      			}
		    }
           
            public IColumn ScheduleName{
                get{
                    return this.GetColumn("ScheduleName");
                }
            }
            				
   			public static string ScheduleNameColumn{
			      get{
        			return "ScheduleName";
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
           
            public IColumn Sunday{
                get{
                    return this.GetColumn("Sunday");
                }
            }
            				
   			public static string SundayColumn{
			      get{
        			return "Sunday";
      			}
		    }
           
            public IColumn Monday{
                get{
                    return this.GetColumn("Monday");
                }
            }
            				
   			public static string MondayColumn{
			      get{
        			return "Monday";
      			}
		    }
           
            public IColumn Tuesday{
                get{
                    return this.GetColumn("Tuesday");
                }
            }
            				
   			public static string TuesdayColumn{
			      get{
        			return "Tuesday";
      			}
		    }
           
            public IColumn Wednesday{
                get{
                    return this.GetColumn("Wednesday");
                }
            }
            				
   			public static string WednesdayColumn{
			      get{
        			return "Wednesday";
      			}
		    }
           
            public IColumn Thursday{
                get{
                    return this.GetColumn("Thursday");
                }
            }
            				
   			public static string ThursdayColumn{
			      get{
        			return "Thursday";
      			}
		    }
           
            public IColumn Friday{
                get{
                    return this.GetColumn("Friday");
                }
            }
            				
   			public static string FridayColumn{
			      get{
        			return "Friday";
      			}
		    }
           
            public IColumn Saturday{
                get{
                    return this.GetColumn("Saturday");
                }
            }
            				
   			public static string SaturdayColumn{
			      get{
        			return "Saturday";
      			}
		    }
           
            public IColumn StartTime{
                get{
                    return this.GetColumn("StartTime");
                }
            }
            				
   			public static string StartTimeColumn{
			      get{
        			return "StartTime";
      			}
		    }
           
            public IColumn EndTime{
                get{
                    return this.GetColumn("EndTime");
                }
            }
            				
   			public static string EndTimeColumn{
			      get{
        			return "EndTime";
      			}
		    }
           
            public IColumn PatientDuration{
                get{
                    return this.GetColumn("PatientDuration");
                }
            }
            				
   			public static string PatientDurationColumn{
			      get{
        			return "PatientDuration";
      			}
		    }
           
            public IColumn IsApprovalSystem{
                get{
                    return this.GetColumn("IsApprovalSystem");
                }
            }
            				
   			public static string IsApprovalSystemColumn{
			      get{
        			return "IsApprovalSystem";
      			}
		    }
           
            public IColumn IsApprovalNotificationSMS{
                get{
                    return this.GetColumn("IsApprovalNotificationSMS");
                }
            }
            				
   			public static string IsApprovalNotificationSMSColumn{
			      get{
        			return "IsApprovalNotificationSMS";
      			}
		    }
           
            public IColumn IsApprovalNotificationEmail{
                get{
                    return this.GetColumn("IsApprovalNotificationEmail");
                }
            }
            				
   			public static string IsApprovalNotificationEmailColumn{
			      get{
        			return "IsApprovalNotificationEmail";
      			}
		    }
           
            public IColumn MaxAppointmentDays{
                get{
                    return this.GetColumn("MaxAppointmentDays");
                }
            }
            				
   			public static string MaxAppointmentDaysColumn{
			      get{
        			return "MaxAppointmentDays";
      			}
		    }
           
            public IColumn IsDefaultAddress{
                get{
                    return this.GetColumn("IsDefaultAddress");
                }
            }
            				
   			public static string IsDefaultAddressColumn{
			      get{
        			return "IsDefaultAddress";
      			}
		    }
           
            public IColumn IsCarParkFacility{
                get{
                    return this.GetColumn("IsCarParkFacility");
                }
            }
            				
   			public static string IsCarParkFacilityColumn{
			      get{
        			return "IsCarParkFacility";
      			}
		    }
           
            public IColumn IsFCFS{
                get{
                    return this.GetColumn("IsFCFS");
                }
            }
            				
   			public static string IsFCFSColumn{
			      get{
        			return "IsFCFS";
      			}
		    }
           
            public IColumn MaxApps{
                get{
                    return this.GetColumn("MaxApps");
                }
            }
            				
   			public static string MaxAppsColumn{
			      get{
        			return "MaxApps";
      			}
		    }
           
            public IColumn AppointmentType{
                get{
                    return this.GetColumn("AppointmentType");
                }
            }
            				
   			public static string AppointmentTypeColumn{
			      get{
        			return "AppointmentType";
      			}
		    }
           
            public IColumn Conditions{
                get{
                    return this.GetColumn("Conditions");
                }
            }
            				
   			public static string ConditionsColumn{
			      get{
        			return "Conditions";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_SearchResultsColVisible
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_SearchResultsColVisibleTable: DatabaseTable {
            
            public TBL_Job_SearchResultsColVisibleTable(IDataProvider provider):base("TBL_Job_SearchResultsColVisible",provider){
                ClassName = "TBL_Job_SearchResultsColVisible";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SrId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Facility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Speciality", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PostDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn SrId{
                get{
                    return this.GetColumn("SrId");
                }
            }
            				
   			public static string SrIdColumn{
			      get{
        			return "SrId";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
            				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Facility{
                get{
                    return this.GetColumn("Facility");
                }
            }
            				
   			public static string FacilityColumn{
			      get{
        			return "Facility";
      			}
		    }
           
            public IColumn Speciality{
                get{
                    return this.GetColumn("Speciality");
                }
            }
            				
   			public static string SpecialityColumn{
			      get{
        			return "Speciality";
      			}
		    }
           
            public IColumn PostDate{
                get{
                    return this.GetColumn("PostDate");
                }
            }
            				
   			public static string PostDateColumn{
			      get{
        			return "PostDate";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Landing_SubTab
        /// Primary Key: SubTabId
        /// </summary>

        public class TBL_Landing_SubTabTable: DatabaseTable {
            
            public TBL_Landing_SubTabTable(IDataProvider provider):base("TBL_Landing_SubTab",provider){
                ClassName = "TBL_Landing_SubTab";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SubTabId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubTabName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("SubTabContent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2147483647
                });

                Columns.Add(new DatabaseColumn("MainTabId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SubTabId{
                get{
                    return this.GetColumn("SubTabId");
                }
            }
            				
   			public static string SubTabIdColumn{
			      get{
        			return "SubTabId";
      			}
		    }
           
            public IColumn SubTabName{
                get{
                    return this.GetColumn("SubTabName");
                }
            }
            				
   			public static string SubTabNameColumn{
			      get{
        			return "SubTabName";
      			}
		    }
           
            public IColumn SubTabContent{
                get{
                    return this.GetColumn("SubTabContent");
                }
            }
            				
   			public static string SubTabContentColumn{
			      get{
        			return "SubTabContent";
      			}
		    }
           
            public IColumn MainTabId{
                get{
                    return this.GetColumn("MainTabId");
                }
            }
            				
   			public static string MainTabIdColumn{
			      get{
        			return "MainTabId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_SearchDescriptionColVisible
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_SearchDescriptionColVisibleTable: DatabaseTable {
            
            public TBL_Job_SearchDescriptionColVisibleTable(IDataProvider provider):base("TBL_Job_SearchDescriptionColVisible",provider){
                ClassName = "TBL_Job_SearchDescriptionColVisible";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SdId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("JobId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("JobTitle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Facility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Speciality", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Description", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PostedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn SdId{
                get{
                    return this.GetColumn("SdId");
                }
            }
            				
   			public static string SdIdColumn{
			      get{
        			return "SdId";
      			}
		    }
           
            public IColumn JobId{
                get{
                    return this.GetColumn("JobId");
                }
            }
            				
   			public static string JobIdColumn{
			      get{
        			return "JobId";
      			}
		    }
           
            public IColumn JobTitle{
                get{
                    return this.GetColumn("JobTitle");
                }
            }
            				
   			public static string JobTitleColumn{
			      get{
        			return "JobTitle";
      			}
		    }
           
            public IColumn Facility{
                get{
                    return this.GetColumn("Facility");
                }
            }
            				
   			public static string FacilityColumn{
			      get{
        			return "Facility";
      			}
		    }
           
            public IColumn Speciality{
                get{
                    return this.GetColumn("Speciality");
                }
            }
            				
   			public static string SpecialityColumn{
			      get{
        			return "Speciality";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
            				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
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
           
            public IColumn PostedDate{
                get{
                    return this.GetColumn("PostedDate");
                }
            }
            				
   			public static string PostedDateColumn{
			      get{
        			return "PostedDate";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_NewsLetter
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_NewsLetterTable: DatabaseTable {
            
            public TBL_Job_NewsLetterTable(IDataProvider provider):base("TBL_Job_NewsLetter",provider){
                ClassName = "TBL_Job_NewsLetter";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Nid", this)
                {
	                IsPrimaryKey = false,
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
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PostedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn Nid{
                get{
                    return this.GetColumn("Nid");
                }
            }
            				
   			public static string NidColumn{
			      get{
        			return "Nid";
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
           
            public IColumn PostedDate{
                get{
                    return this.GetColumn("PostedDate");
                }
            }
            				
   			public static string PostedDateColumn{
			      get{
        			return "PostedDate";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Tbl_Appointment_Comments
        /// Primary Key: 
        /// </summary>

        public class Tbl_Appointment_CommentsTable: DatabaseTable {
            
            public Tbl_Appointment_CommentsTable(IDataProvider provider):base("Tbl_Appointment_Comments",provider){
                ClassName = "Tbl_Appointment_Comment";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Comment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActionTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ActionId", this)
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
           
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
            				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
           
            public IColumn LoginId{
                get{
                    return this.GetColumn("LoginId");
                }
            }
            				
   			public static string LoginIdColumn{
			      get{
        			return "LoginId";
      			}
		    }
           
            public IColumn Comment{
                get{
                    return this.GetColumn("Comment");
                }
            }
            				
   			public static string CommentColumn{
			      get{
        			return "Comment";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn ActionTypeId{
                get{
                    return this.GetColumn("ActionTypeId");
                }
            }
            				
   			public static string ActionTypeIdColumn{
			      get{
        			return "ActionTypeId";
      			}
		    }
           
            public IColumn ActionId{
                get{
                    return this.GetColumn("ActionId");
                }
            }
            				
   			public static string ActionIdColumn{
			      get{
        			return "ActionId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_Jobs
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_JobsTable: DatabaseTable {
            
            public TBL_Job_JobsTable(IDataProvider provider):base("TBL_Job_Jobs",provider){
                ClassName = "TBL_Job_Job";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Jid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("JobId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("JobTitle", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Facility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Speciality", this)
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
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visibility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn Jid{
                get{
                    return this.GetColumn("Jid");
                }
            }
            				
   			public static string JidColumn{
			      get{
        			return "Jid";
      			}
		    }
           
            public IColumn JobId{
                get{
                    return this.GetColumn("JobId");
                }
            }
            				
   			public static string JobIdColumn{
			      get{
        			return "JobId";
      			}
		    }
           
            public IColumn JobTitle{
                get{
                    return this.GetColumn("JobTitle");
                }
            }
            				
   			public static string JobTitleColumn{
			      get{
        			return "JobTitle";
      			}
		    }
           
            public IColumn Facility{
                get{
                    return this.GetColumn("Facility");
                }
            }
            				
   			public static string FacilityColumn{
			      get{
        			return "Facility";
      			}
		    }
           
            public IColumn Speciality{
                get{
                    return this.GetColumn("Speciality");
                }
            }
            				
   			public static string SpecialityColumn{
			      get{
        			return "Speciality";
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
           
            public IColumn Visibility{
                get{
                    return this.GetColumn("Visibility");
                }
            }
            				
   			public static string VisibilityColumn{
			      get{
        			return "Visibility";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Login
        /// Primary Key: LoginId
        /// </summary>

        public class TBL_LoginTable: DatabaseTable {
            
            public TBL_LoginTable(IDataProvider provider):base("TBL_Login",provider){
                ClassName = "TBL_Login";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LoginId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FirstName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("LastName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 150
                });

                Columns.Add(new DatabaseColumn("MedAppId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("MobileId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("EmailId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("IsDirect", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsActivated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsEmailActivated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TransactionToken", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("IsEmailNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsSMSNotification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LoginId{
                get{
                    return this.GetColumn("LoginId");
                }
            }
            				
   			public static string LoginIdColumn{
			      get{
        			return "LoginId";
      			}
		    }
           
            public IColumn FirstName{
                get{
                    return this.GetColumn("FirstName");
                }
            }
            				
   			public static string FirstNameColumn{
			      get{
        			return "FirstName";
      			}
		    }
           
            public IColumn LastName{
                get{
                    return this.GetColumn("LastName");
                }
            }
            				
   			public static string LastNameColumn{
			      get{
        			return "LastName";
      			}
		    }
           
            public IColumn MedAppId{
                get{
                    return this.GetColumn("MedAppId");
                }
            }
            				
   			public static string MedAppIdColumn{
			      get{
        			return "MedAppId";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn MobileId{
                get{
                    return this.GetColumn("MobileId");
                }
            }
            				
   			public static string MobileIdColumn{
			      get{
        			return "MobileId";
      			}
		    }
           
            public IColumn EmailId{
                get{
                    return this.GetColumn("EmailId");
                }
            }
            				
   			public static string EmailIdColumn{
			      get{
        			return "EmailId";
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
           
            public IColumn IsDirect{
                get{
                    return this.GetColumn("IsDirect");
                }
            }
            				
   			public static string IsDirectColumn{
			      get{
        			return "IsDirect";
      			}
		    }
           
            public IColumn IsActivated{
                get{
                    return this.GetColumn("IsActivated");
                }
            }
            				
   			public static string IsActivatedColumn{
			      get{
        			return "IsActivated";
      			}
		    }
           
            public IColumn IsEmailActivated{
                get{
                    return this.GetColumn("IsEmailActivated");
                }
            }
            				
   			public static string IsEmailActivatedColumn{
			      get{
        			return "IsEmailActivated";
      			}
		    }
           
            public IColumn TransactionToken{
                get{
                    return this.GetColumn("TransactionToken");
                }
            }
            				
   			public static string TransactionTokenColumn{
			      get{
        			return "TransactionToken";
      			}
		    }
           
            public IColumn IsEmailNotification{
                get{
                    return this.GetColumn("IsEmailNotification");
                }
            }
            				
   			public static string IsEmailNotificationColumn{
			      get{
        			return "IsEmailNotification";
      			}
		    }
           
            public IColumn IsSMSNotification{
                get{
                    return this.GetColumn("IsSMSNotification");
                }
            }
            				
   			public static string IsSMSNotificationColumn{
			      get{
        			return "IsSMSNotification";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_HrLogin
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_HrLoginTable: DatabaseTable {
            
            public TBL_Job_HrLoginTable(IDataProvider provider):base("TBL_Job_HrLogin",provider){
                ClassName = "TBL_Job_HrLogin";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Hid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UserName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Password", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn Hid{
                get{
                    return this.GetColumn("Hid");
                }
            }
            				
   			public static string HidColumn{
			      get{
        			return "Hid";
      			}
		    }
           
            public IColumn UserName{
                get{
                    return this.GetColumn("UserName");
                }
            }
            				
   			public static string UserNameColumn{
			      get{
        			return "UserName";
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
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_HotOppsColVisible
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_HotOppsColVisibleTable: DatabaseTable {
            
            public TBL_Job_HotOppsColVisibleTable(IDataProvider provider):base("TBL_Job_HotOppsColVisible",provider){
                ClassName = "TBL_Job_HotOppsColVisible";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("HId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Facility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Speciality", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PostedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn HId{
                get{
                    return this.GetColumn("HId");
                }
            }
            				
   			public static string HIdColumn{
			      get{
        			return "HId";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
            				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn Facility{
                get{
                    return this.GetColumn("Facility");
                }
            }
            				
   			public static string FacilityColumn{
			      get{
        			return "Facility";
      			}
		    }
           
            public IColumn Speciality{
                get{
                    return this.GetColumn("Speciality");
                }
            }
            				
   			public static string SpecialityColumn{
			      get{
        			return "Speciality";
      			}
		    }
           
            public IColumn PostedDate{
                get{
                    return this.GetColumn("PostedDate");
                }
            }
            				
   			public static string PostedDateColumn{
			      get{
        			return "PostedDate";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_Facility
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_FacilityTable: DatabaseTable {
            
            public TBL_Job_FacilityTable(IDataProvider provider):base("TBL_Job_Facility",provider){
                ClassName = "TBL_Job_Facility";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("FacId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Facility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Visibility", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UpdatedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WhoCreated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("WhoUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn FacId{
                get{
                    return this.GetColumn("FacId");
                }
            }
            				
   			public static string FacIdColumn{
			      get{
        			return "FacId";
      			}
		    }
           
            public IColumn Facility{
                get{
                    return this.GetColumn("Facility");
                }
            }
            				
   			public static string FacilityColumn{
			      get{
        			return "Facility";
      			}
		    }
           
            public IColumn Visibility{
                get{
                    return this.GetColumn("Visibility");
                }
            }
            				
   			public static string VisibilityColumn{
			      get{
        			return "Visibility";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
            public IColumn CreatedDate{
                get{
                    return this.GetColumn("CreatedDate");
                }
            }
            				
   			public static string CreatedDateColumn{
			      get{
        			return "CreatedDate";
      			}
		    }
           
            public IColumn UpdatedDate{
                get{
                    return this.GetColumn("UpdatedDate");
                }
            }
            				
   			public static string UpdatedDateColumn{
			      get{
        			return "UpdatedDate";
      			}
		    }
           
            public IColumn WhoCreated{
                get{
                    return this.GetColumn("WhoCreated");
                }
            }
            				
   			public static string WhoCreatedColumn{
			      get{
        			return "WhoCreated";
      			}
		    }
           
            public IColumn WhoUpdated{
                get{
                    return this.GetColumn("WhoUpdated");
                }
            }
            				
   			public static string WhoUpdatedColumn{
			      get{
        			return "WhoUpdated";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Service_Diagnosis
        /// Primary Key: 
        /// </summary>

        public class TBL_Service_DiagnosisTable: DatabaseTable {
            
            public TBL_Service_DiagnosisTable(IDataProvider provider):base("TBL_Service_Diagnosis",provider){
                ClassName = "TBL_Service_Diagnosi";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ServiceId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DiagnosisId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ServiceId{
                get{
                    return this.GetColumn("ServiceId");
                }
            }
            				
   			public static string ServiceIdColumn{
			      get{
        			return "ServiceId";
      			}
		    }
           
            public IColumn DiagnosisId{
                get{
                    return this.GetColumn("DiagnosisId");
                }
            }
            				
   			public static string DiagnosisIdColumn{
			      get{
        			return "DiagnosisId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Job_Apply
        /// Primary Key: 
        /// </summary>

        public class TBL_Job_ApplyTable: DatabaseTable {
            
            public TBL_Job_ApplyTable(IDataProvider provider):base("TBL_Job_Apply",provider){
                ClassName = "TBL_Job_Apply";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Aid", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("JobId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CandidateName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Age", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Sex", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PermanentAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Email", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("City", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("District", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("State", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Country", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("AboutUs", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ContactPhone", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ContactMobile", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("BestTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Specialization", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Experience", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HighestQualification", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HighestDegree", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CurrentEmployer", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ExistingPay", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("DesiredPay", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Willing", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("UploadResume", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("AppliedDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("HrStatus", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("HrDateUpdated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("FinalStatus", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ClientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn Aid{
                get{
                    return this.GetColumn("Aid");
                }
            }
            				
   			public static string AidColumn{
			      get{
        			return "Aid";
      			}
		    }
           
            public IColumn JobId{
                get{
                    return this.GetColumn("JobId");
                }
            }
            				
   			public static string JobIdColumn{
			      get{
        			return "JobId";
      			}
		    }
           
            public IColumn CandidateName{
                get{
                    return this.GetColumn("CandidateName");
                }
            }
            				
   			public static string CandidateNameColumn{
			      get{
        			return "CandidateName";
      			}
		    }
           
            public IColumn Age{
                get{
                    return this.GetColumn("Age");
                }
            }
            				
   			public static string AgeColumn{
			      get{
        			return "Age";
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
           
            public IColumn PermanentAddress{
                get{
                    return this.GetColumn("PermanentAddress");
                }
            }
            				
   			public static string PermanentAddressColumn{
			      get{
        			return "PermanentAddress";
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
           
            public IColumn City{
                get{
                    return this.GetColumn("City");
                }
            }
            				
   			public static string CityColumn{
			      get{
        			return "City";
      			}
		    }
           
            public IColumn District{
                get{
                    return this.GetColumn("District");
                }
            }
            				
   			public static string DistrictColumn{
			      get{
        			return "District";
      			}
		    }
           
            public IColumn State{
                get{
                    return this.GetColumn("State");
                }
            }
            				
   			public static string StateColumn{
			      get{
        			return "State";
      			}
		    }
           
            public IColumn Country{
                get{
                    return this.GetColumn("Country");
                }
            }
            				
   			public static string CountryColumn{
			      get{
        			return "Country";
      			}
		    }
           
            public IColumn AboutUs{
                get{
                    return this.GetColumn("AboutUs");
                }
            }
            				
   			public static string AboutUsColumn{
			      get{
        			return "AboutUs";
      			}
		    }
           
            public IColumn ContactPhone{
                get{
                    return this.GetColumn("ContactPhone");
                }
            }
            				
   			public static string ContactPhoneColumn{
			      get{
        			return "ContactPhone";
      			}
		    }
           
            public IColumn ContactMobile{
                get{
                    return this.GetColumn("ContactMobile");
                }
            }
            				
   			public static string ContactMobileColumn{
			      get{
        			return "ContactMobile";
      			}
		    }
           
            public IColumn BestTime{
                get{
                    return this.GetColumn("BestTime");
                }
            }
            				
   			public static string BestTimeColumn{
			      get{
        			return "BestTime";
      			}
		    }
           
            public IColumn Specialization{
                get{
                    return this.GetColumn("Specialization");
                }
            }
            				
   			public static string SpecializationColumn{
			      get{
        			return "Specialization";
      			}
		    }
           
            public IColumn Experience{
                get{
                    return this.GetColumn("Experience");
                }
            }
            				
   			public static string ExperienceColumn{
			      get{
        			return "Experience";
      			}
		    }
           
            public IColumn HighestQualification{
                get{
                    return this.GetColumn("HighestQualification");
                }
            }
            				
   			public static string HighestQualificationColumn{
			      get{
        			return "HighestQualification";
      			}
		    }
           
            public IColumn HighestDegree{
                get{
                    return this.GetColumn("HighestDegree");
                }
            }
            				
   			public static string HighestDegreeColumn{
			      get{
        			return "HighestDegree";
      			}
		    }
           
            public IColumn CurrentEmployer{
                get{
                    return this.GetColumn("CurrentEmployer");
                }
            }
            				
   			public static string CurrentEmployerColumn{
			      get{
        			return "CurrentEmployer";
      			}
		    }
           
            public IColumn ExistingPay{
                get{
                    return this.GetColumn("ExistingPay");
                }
            }
            				
   			public static string ExistingPayColumn{
			      get{
        			return "ExistingPay";
      			}
		    }
           
            public IColumn DesiredPay{
                get{
                    return this.GetColumn("DesiredPay");
                }
            }
            				
   			public static string DesiredPayColumn{
			      get{
        			return "DesiredPay";
      			}
		    }
           
            public IColumn Willing{
                get{
                    return this.GetColumn("Willing");
                }
            }
            				
   			public static string WillingColumn{
			      get{
        			return "Willing";
      			}
		    }
           
            public IColumn UploadResume{
                get{
                    return this.GetColumn("UploadResume");
                }
            }
            				
   			public static string UploadResumeColumn{
			      get{
        			return "UploadResume";
      			}
		    }
           
            public IColumn AppliedDate{
                get{
                    return this.GetColumn("AppliedDate");
                }
            }
            				
   			public static string AppliedDateColumn{
			      get{
        			return "AppliedDate";
      			}
		    }
           
            public IColumn HrStatus{
                get{
                    return this.GetColumn("HrStatus");
                }
            }
            				
   			public static string HrStatusColumn{
			      get{
        			return "HrStatus";
      			}
		    }
           
            public IColumn HrDateUpdated{
                get{
                    return this.GetColumn("HrDateUpdated");
                }
            }
            				
   			public static string HrDateUpdatedColumn{
			      get{
        			return "HrDateUpdated";
      			}
		    }
           
            public IColumn FinalStatus{
                get{
                    return this.GetColumn("FinalStatus");
                }
            }
            				
   			public static string FinalStatusColumn{
			      get{
        			return "FinalStatus";
      			}
		    }
           
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
            				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
           
            public IColumn ClientId{
                get{
                    return this.GetColumn("ClientId");
                }
            }
            				
   			public static string ClientIdColumn{
			      get{
        			return "ClientId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_GupShup
        /// Primary Key: 
        /// </summary>

        public class TBL_GupShupTable: DatabaseTable {
            
            public TBL_GupShupTable(IDataProvider provider):base("TBL_GupShup",provider){
                ClassName = "TBL_GupShup";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ExternalId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("DeliveredTS", this)
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
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("PhoneNo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("Cause", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });
                    
                
                
            }
            
            public IColumn ExternalId{
                get{
                    return this.GetColumn("ExternalId");
                }
            }
            				
   			public static string ExternalIdColumn{
			      get{
        			return "ExternalId";
      			}
		    }
           
            public IColumn DeliveredTS{
                get{
                    return this.GetColumn("DeliveredTS");
                }
            }
            				
   			public static string DeliveredTSColumn{
			      get{
        			return "DeliveredTS";
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
           
            public IColumn PhoneNo{
                get{
                    return this.GetColumn("PhoneNo");
                }
            }
            				
   			public static string PhoneNoColumn{
			      get{
        			return "PhoneNo";
      			}
		    }
           
            public IColumn Cause{
                get{
                    return this.GetColumn("Cause");
                }
            }
            				
   			public static string CauseColumn{
			      get{
        			return "Cause";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Landing_ImageGallery
        /// Primary Key: 
        /// </summary>

        public class TBL_Landing_ImageGalleryTable: DatabaseTable {
            
            public TBL_Landing_ImageGalleryTable(IDataProvider provider):base("TBL_Landing_ImageGallery",provider){
                ClassName = "TBL_Landing_ImageGallery";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ImageId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ImageName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("ImageDescription", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Images", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Binary,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Selected", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ImageId{
                get{
                    return this.GetColumn("ImageId");
                }
            }
            				
   			public static string ImageIdColumn{
			      get{
        			return "ImageId";
      			}
		    }
           
            public IColumn AccountId{
                get{
                    return this.GetColumn("AccountId");
                }
            }
            				
   			public static string AccountIdColumn{
			      get{
        			return "AccountId";
      			}
		    }
           
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn Version{
                get{
                    return this.GetColumn("Version");
                }
            }
            				
   			public static string VersionColumn{
			      get{
        			return "Version";
      			}
		    }
           
            public IColumn ImageName{
                get{
                    return this.GetColumn("ImageName");
                }
            }
            				
   			public static string ImageNameColumn{
			      get{
        			return "ImageName";
      			}
		    }
           
            public IColumn ImageDescription{
                get{
                    return this.GetColumn("ImageDescription");
                }
            }
            				
   			public static string ImageDescriptionColumn{
			      get{
        			return "ImageDescription";
      			}
		    }
           
            public IColumn Images{
                get{
                    return this.GetColumn("Images");
                }
            }
            				
   			public static string ImagesColumn{
			      get{
        			return "Images";
      			}
		    }
           
            public IColumn Selected{
                get{
                    return this.GetColumn("Selected");
                }
            }
            				
   			public static string SelectedColumn{
			      get{
        			return "Selected";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Organization
        /// Primary Key: OrganizationId
        /// </summary>

        public class TBL_OrganizationTable: DatabaseTable {
            
            public TBL_OrganizationTable(IDataProvider provider):base("TBL_Organization",provider){
                ClassName = "TBL_Organization";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 1000
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn OrganizationName{
                get{
                    return this.GetColumn("OrganizationName");
                }
            }
            				
   			public static string OrganizationNameColumn{
			      get{
        			return "OrganizationName";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Token
        /// Primary Key: TokenId
        /// </summary>

        public class TBL_TokenTable: DatabaseTable {
            
            public TBL_TokenTable(IDataProvider provider):base("TBL_Token",provider){
                ClassName = "TBL_Token";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("TokenId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("TokenNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("TokenSequence", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn TokenId{
                get{
                    return this.GetColumn("TokenId");
                }
            }
            				
   			public static string TokenIdColumn{
			      get{
        			return "TokenId";
      			}
		    }
           
            public IColumn TokenNumber{
                get{
                    return this.GetColumn("TokenNumber");
                }
            }
            				
   			public static string TokenNumberColumn{
			      get{
        			return "TokenNumber";
      			}
		    }
           
            public IColumn TokenSequence{
                get{
                    return this.GetColumn("TokenSequence");
                }
            }
            				
   			public static string TokenSequenceColumn{
			      get{
        			return "TokenSequence";
      			}
		    }
           
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Content
        /// Primary Key: ID
        /// </summary>

        public class ContentTable: DatabaseTable {
            
            public ContentTable(IDataProvider provider):base("Content",provider){
                ClassName = "Content";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Title", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 128
                });

                Columns.Add(new DatabaseColumn("ImageUrl", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("Text", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("PageID", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
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
           
            public IColumn ImageUrl{
                get{
                    return this.GetColumn("ImageUrl");
                }
            }
            				
   			public static string ImageUrlColumn{
			      get{
        			return "ImageUrl";
      			}
		    }
           
            public IColumn Text{
                get{
                    return this.GetColumn("Text");
                }
            }
            				
   			public static string TextColumn{
			      get{
        			return "Text";
      			}
		    }
           
            public IColumn PageID{
                get{
                    return this.GetColumn("PageID");
                }
            }
            				
   			public static string PageIDColumn{
			      get{
        			return "PageID";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: Page
        /// Primary Key: ID
        /// </summary>

        public class PageTable: DatabaseTable {
            
            public PageTable(IDataProvider provider):base("Page",provider){
                ClassName = "Page";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Location", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("HeaderImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("FooterImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("HeaderText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("FooterText", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("PageImage", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });

                Columns.Add(new DatabaseColumn("MainSite", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 2048
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
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
           
            public IColumn HeaderImage{
                get{
                    return this.GetColumn("HeaderImage");
                }
            }
            				
   			public static string HeaderImageColumn{
			      get{
        			return "HeaderImage";
      			}
		    }
           
            public IColumn FooterImage{
                get{
                    return this.GetColumn("FooterImage");
                }
            }
            				
   			public static string FooterImageColumn{
			      get{
        			return "FooterImage";
      			}
		    }
           
            public IColumn HeaderText{
                get{
                    return this.GetColumn("HeaderText");
                }
            }
            				
   			public static string HeaderTextColumn{
			      get{
        			return "HeaderText";
      			}
		    }
           
            public IColumn FooterText{
                get{
                    return this.GetColumn("FooterText");
                }
            }
            				
   			public static string FooterTextColumn{
			      get{
        			return "FooterText";
      			}
		    }
           
            public IColumn PageImage{
                get{
                    return this.GetColumn("PageImage");
                }
            }
            				
   			public static string PageImageColumn{
			      get{
        			return "PageImage";
      			}
		    }
           
            public IColumn MainSite{
                get{
                    return this.GetColumn("MainSite");
                }
            }
            				
   			public static string MainSiteColumn{
			      get{
        			return "MainSite";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_GupShup_FailureReason
        /// Primary Key: 
        /// </summary>

        public class TBL_GupShup_FailureReasonTable: DatabaseTable {
            
            public TBL_GupShup_FailureReasonTable(IDataProvider provider):base("TBL_GupShup_FailureReason",provider){
                ClassName = "TBL_GupShup_FailureReason";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("KeyWord", this)
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
	                MaxLength = 1000
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
           
            public IColumn KeyWord{
                get{
                    return this.GetColumn("KeyWord");
                }
            }
            				
   			public static string KeyWordColumn{
			      get{
        			return "KeyWord";
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
        /// Table: TBL_Master_Banner
        /// Primary Key: BannerId
        /// </summary>

        public class TBL_Master_BannerTable: DatabaseTable {
            
            public TBL_Master_BannerTable(IDataProvider provider):base("TBL_Master_Banner",provider){
                ClassName = "TBL_Master_Banner";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("BannerId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DepartmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BannerFilename", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });
                    
                
                
            }
            
            public IColumn BannerId{
                get{
                    return this.GetColumn("BannerId");
                }
            }
            				
   			public static string BannerIdColumn{
			      get{
        			return "BannerId";
      			}
		    }
           
            public IColumn DepartmentId{
                get{
                    return this.GetColumn("DepartmentId");
                }
            }
            				
   			public static string DepartmentIdColumn{
			      get{
        			return "DepartmentId";
      			}
		    }
           
            public IColumn BannerFilename{
                get{
                    return this.GetColumn("BannerFilename");
                }
            }
            				
   			public static string BannerFilenameColumn{
			      get{
        			return "BannerFilename";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Landing
        /// Primary Key: LandingId
        /// </summary>

        public class TBL_LandingTable: DatabaseTable {
            
            public TBL_LandingTable(IDataProvider provider):base("TBL_Landing",provider){
                ClassName = "TBL_Landing";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LandingId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PublishId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BannerPath", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("DepartmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Forms", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn LandingId{
                get{
                    return this.GetColumn("LandingId");
                }
            }
            				
   			public static string LandingIdColumn{
			      get{
        			return "LandingId";
      			}
		    }
           
            public IColumn Version{
                get{
                    return this.GetColumn("Version");
                }
            }
            				
   			public static string VersionColumn{
			      get{
        			return "Version";
      			}
		    }
           
            public IColumn PublishId{
                get{
                    return this.GetColumn("PublishId");
                }
            }
            				
   			public static string PublishIdColumn{
			      get{
        			return "PublishId";
      			}
		    }
           
            public IColumn BannerPath{
                get{
                    return this.GetColumn("BannerPath");
                }
            }
            				
   			public static string BannerPathColumn{
			      get{
        			return "BannerPath";
      			}
		    }
           
            public IColumn DepartmentId{
                get{
                    return this.GetColumn("DepartmentId");
                }
            }
            				
   			public static string DepartmentIdColumn{
			      get{
        			return "DepartmentId";
      			}
		    }
           
            public IColumn Forms{
                get{
                    return this.GetColumn("Forms");
                }
            }
            				
   			public static string FormsColumn{
			      get{
        			return "Forms";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Doctor_Education
        /// Primary Key: EducationId
        /// </summary>

        public class TBL_Doctor_EducationTable: DatabaseTable {
            
            public TBL_Doctor_EducationTable(IDataProvider provider):base("TBL_Doctor_Education",provider){
                ClassName = "TBL_Doctor_Education";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("EducationId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("University", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Degree", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("StateId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CityId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("YearFrom", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("YearTo", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn EducationId{
                get{
                    return this.GetColumn("EducationId");
                }
            }
            				
   			public static string EducationIdColumn{
			      get{
        			return "EducationId";
      			}
		    }
           
            public IColumn University{
                get{
                    return this.GetColumn("University");
                }
            }
            				
   			public static string UniversityColumn{
			      get{
        			return "University";
      			}
		    }
           
            public IColumn Degree{
                get{
                    return this.GetColumn("Degree");
                }
            }
            				
   			public static string DegreeColumn{
			      get{
        			return "Degree";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
            public IColumn StateId{
                get{
                    return this.GetColumn("StateId");
                }
            }
            				
   			public static string StateIdColumn{
			      get{
        			return "StateId";
      			}
		    }
           
            public IColumn CityId{
                get{
                    return this.GetColumn("CityId");
                }
            }
            				
   			public static string CityIdColumn{
			      get{
        			return "CityId";
      			}
		    }
           
            public IColumn YearFrom{
                get{
                    return this.GetColumn("YearFrom");
                }
            }
            				
   			public static string YearFromColumn{
			      get{
        			return "YearFrom";
      			}
		    }
           
            public IColumn YearTo{
                get{
                    return this.GetColumn("YearTo");
                }
            }
            				
   			public static string YearToColumn{
			      get{
        			return "YearTo";
      			}
		    }
           
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
            				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_University
        /// Primary Key: UniversityId
        /// </summary>

        public class TBL_Master_UniversityTable: DatabaseTable {
            
            public TBL_Master_UniversityTable(IDataProvider provider):base("TBL_Master_University",provider){
                ClassName = "TBL_Master_University";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("UniversityId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UniversityName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("CountryId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn UniversityId{
                get{
                    return this.GetColumn("UniversityId");
                }
            }
            				
   			public static string UniversityIdColumn{
			      get{
        			return "UniversityId";
      			}
		    }
           
            public IColumn UniversityName{
                get{
                    return this.GetColumn("UniversityName");
                }
            }
            				
   			public static string UniversityNameColumn{
			      get{
        			return "UniversityName";
      			}
		    }
           
            public IColumn CountryId{
                get{
                    return this.GetColumn("CountryId");
                }
            }
            				
   			public static string CountryIdColumn{
			      get{
        			return "CountryId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Landing_Publish
        /// Primary Key: PublishId
        /// </summary>

        public class TBL_Landing_PublishTable: DatabaseTable {
            
            public TBL_Landing_PublishTable(IDataProvider provider):base("TBL_Landing_Publish",provider){
                ClassName = "TBL_Landing_Publish";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("PublishId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BannerId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DefaultVersion", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn PublishId{
                get{
                    return this.GetColumn("PublishId");
                }
            }
            				
   			public static string PublishIdColumn{
			      get{
        			return "PublishId";
      			}
		    }
           
            public IColumn AccountId{
                get{
                    return this.GetColumn("AccountId");
                }
            }
            				
   			public static string AccountIdColumn{
			      get{
        			return "AccountId";
      			}
		    }
           
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn BannerId{
                get{
                    return this.GetColumn("BannerId");
                }
            }
            				
   			public static string BannerIdColumn{
			      get{
        			return "BannerId";
      			}
		    }
           
            public IColumn DefaultVersion{
                get{
                    return this.GetColumn("DefaultVersion");
                }
            }
            				
   			public static string DefaultVersionColumn{
			      get{
        			return "DefaultVersion";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Admin_LoginType
        /// Primary Key: LoginTypeId
        /// </summary>

        public class TBL_Admin_LoginTypeTable: DatabaseTable {
            
            public TBL_Admin_LoginTypeTable(IDataProvider provider):base("TBL_Admin_LoginType",provider){
                ClassName = "TBL_Admin_LoginType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("LoginTypeId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 25
                });
                    
                
                
            }
            
            public IColumn LoginTypeId{
                get{
                    return this.GetColumn("LoginTypeId");
                }
            }
            				
   			public static string LoginTypeIdColumn{
			      get{
        			return "LoginTypeId";
      			}
		    }
           
            public IColumn LoginType{
                get{
                    return this.GetColumn("LoginType");
                }
            }
            				
   			public static string LoginTypeColumn{
			      get{
        			return "LoginType";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Doctor
        /// Primary Key: DoctorId
        /// </summary>

        public class TBL_DoctorTable: DatabaseTable {
            
            public TBL_DoctorTable(IDataProvider provider):base("TBL_Doctor",provider){
                ClassName = "TBL_Doctor";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("DateofBirth", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Gender", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RegistrationYear", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("RegistrationNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("Experience", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Decimal,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Degrees", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("Certifications", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 500
                });

                Columns.Add(new DatabaseColumn("PhotoName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("Mobile", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("DepartmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PreferredName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceToken", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("IsActivated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("UniversityId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn LoginId{
                get{
                    return this.GetColumn("LoginId");
                }
            }
            				
   			public static string LoginIdColumn{
			      get{
        			return "LoginId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn DoctorName{
                get{
                    return this.GetColumn("DoctorName");
                }
            }
            				
   			public static string DoctorNameColumn{
			      get{
        			return "DoctorName";
      			}
		    }
           
            public IColumn DateofBirth{
                get{
                    return this.GetColumn("DateofBirth");
                }
            }
            				
   			public static string DateofBirthColumn{
			      get{
        			return "DateofBirth";
      			}
		    }
           
            public IColumn Gender{
                get{
                    return this.GetColumn("Gender");
                }
            }
            				
   			public static string GenderColumn{
			      get{
        			return "Gender";
      			}
		    }
           
            public IColumn RegistrationYear{
                get{
                    return this.GetColumn("RegistrationYear");
                }
            }
            				
   			public static string RegistrationYearColumn{
			      get{
        			return "RegistrationYear";
      			}
		    }
           
            public IColumn RegistrationNumber{
                get{
                    return this.GetColumn("RegistrationNumber");
                }
            }
            				
   			public static string RegistrationNumberColumn{
			      get{
        			return "RegistrationNumber";
      			}
		    }
           
            public IColumn Experience{
                get{
                    return this.GetColumn("Experience");
                }
            }
            				
   			public static string ExperienceColumn{
			      get{
        			return "Experience";
      			}
		    }
           
            public IColumn Degrees{
                get{
                    return this.GetColumn("Degrees");
                }
            }
            				
   			public static string DegreesColumn{
			      get{
        			return "Degrees";
      			}
		    }
           
            public IColumn Certifications{
                get{
                    return this.GetColumn("Certifications");
                }
            }
            				
   			public static string CertificationsColumn{
			      get{
        			return "Certifications";
      			}
		    }
           
            public IColumn PhotoName{
                get{
                    return this.GetColumn("PhotoName");
                }
            }
            				
   			public static string PhotoNameColumn{
			      get{
        			return "PhotoName";
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
           
            public IColumn DepartmentId{
                get{
                    return this.GetColumn("DepartmentId");
                }
            }
            				
   			public static string DepartmentIdColumn{
			      get{
        			return "DepartmentId";
      			}
		    }
           
            public IColumn PreferredName{
                get{
                    return this.GetColumn("PreferredName");
                }
            }
            				
   			public static string PreferredNameColumn{
			      get{
        			return "PreferredName";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn ReferenceToken{
                get{
                    return this.GetColumn("ReferenceToken");
                }
            }
            				
   			public static string ReferenceTokenColumn{
			      get{
        			return "ReferenceToken";
      			}
		    }
           
            public IColumn IsActivated{
                get{
                    return this.GetColumn("IsActivated");
                }
            }
            				
   			public static string IsActivatedColumn{
			      get{
        			return "IsActivated";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn UniversityId{
                get{
                    return this.GetColumn("UniversityId");
                }
            }
            				
   			public static string UniversityIdColumn{
			      get{
        			return "UniversityId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Landing_VideoGallery
        /// Primary Key: 
        /// </summary>

        public class TBL_Landing_VideoGalleryTable: DatabaseTable {
            
            public TBL_Landing_VideoGalleryTable(IDataProvider provider):base("TBL_Landing_VideoGallery",provider){
                ClassName = "TBL_Landing_VideoGallery";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AccountId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Version", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("VideoContent", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("Selected", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn AccountId{
                get{
                    return this.GetColumn("AccountId");
                }
            }
            				
   			public static string AccountIdColumn{
			      get{
        			return "AccountId";
      			}
		    }
           
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn Version{
                get{
                    return this.GetColumn("Version");
                }
            }
            				
   			public static string VersionColumn{
			      get{
        			return "Version";
      			}
		    }
           
            public IColumn VideoContent{
                get{
                    return this.GetColumn("VideoContent");
                }
            }
            				
   			public static string VideoContentColumn{
			      get{
        			return "VideoContent";
      			}
		    }
           
            public IColumn Selected{
                get{
                    return this.GetColumn("Selected");
                }
            }
            				
   			public static string SelectedColumn{
			      get{
        			return "Selected";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_Bed
        /// Primary Key: 
        /// </summary>

        public class TBL_Master_BedTable: DatabaseTable {
            
            public TBL_Master_BedTable(IDataProvider provider):base("TBL_Master_Bed",provider){
                ClassName = "TBL_Master_Bed";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("Id", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("WardId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Name", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.AnsiString,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 64
                });

                Columns.Add(new DatabaseColumn("FloorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("BuildingId", this)
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
           
            public IColumn WardId{
                get{
                    return this.GetColumn("WardId");
                }
            }
            				
   			public static string WardIdColumn{
			      get{
        			return "WardId";
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
           
            public IColumn FloorId{
                get{
                    return this.GetColumn("FloorId");
                }
            }
            				
   			public static string FloorIdColumn{
			      get{
        			return "FloorId";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn BuildingId{
                get{
                    return this.GetColumn("BuildingId");
                }
            }
            				
   			public static string BuildingIdColumn{
			      get{
        			return "BuildingId";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Master_SubAccountType
        /// Primary Key: 
        /// </summary>

        public class TBL_Master_SubAccountTypeTable: DatabaseTable {
            
            public TBL_Master_SubAccountTypeTable(IDataProvider provider):base("TBL_Master_SubAccountType",provider){
                ClassName = "TBL_Master_SubAccountType";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("SubAccountType", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("SubAccountName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 100
                });

                Columns.Add(new DatabaseColumn("AccountTypeId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn SubAccountType{
                get{
                    return this.GetColumn("SubAccountType");
                }
            }
            				
   			public static string SubAccountTypeColumn{
			      get{
        			return "SubAccountType";
      			}
		    }
           
            public IColumn SubAccountName{
                get{
                    return this.GetColumn("SubAccountName");
                }
            }
            				
   			public static string SubAccountNameColumn{
			      get{
        			return "SubAccountName";
      			}
		    }
           
            public IColumn AccountTypeId{
                get{
                    return this.GetColumn("AccountTypeId");
                }
            }
            				
   			public static string AccountTypeIdColumn{
			      get{
        			return "AccountTypeId";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_ActivationSMSCount
        /// Primary Key: ID
        /// </summary>

        public class TBL_ActivationSMSCountTable: DatabaseTable {
            
            public TBL_ActivationSMSCountTable(IDataProvider provider):base("TBL_ActivationSMSCount",provider){
                ClassName = "TBL_ActivationSMSCount";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ID", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = false,
	                MaxLength = 0
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

                Columns.Add(new DatabaseColumn("IPAddress", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("SMSCount", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsVerified", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ID{
                get{
                    return this.GetColumn("ID");
                }
            }
            				
   			public static string IDColumn{
			      get{
        			return "ID";
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
           
            public IColumn IPAddress{
                get{
                    return this.GetColumn("IPAddress");
                }
            }
            				
   			public static string IPAddressColumn{
			      get{
        			return "IPAddress";
      			}
		    }
           
            public IColumn SMSCount{
                get{
                    return this.GetColumn("SMSCount");
                }
            }
            				
   			public static string SMSCountColumn{
			      get{
        			return "SMSCount";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn IsVerified{
                get{
                    return this.GetColumn("IsVerified");
                }
            }
            				
   			public static string IsVerifiedColumn{
			      get{
        			return "IsVerified";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Service
        /// Primary Key: ServiceId
        /// </summary>

        public class TBL_ServiceTable: DatabaseTable {
            
            public TBL_ServiceTable(IDataProvider provider):base("TBL_Service",provider){
                ClassName = "TBL_Service";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("ServiceId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("LoginId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceName", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("InCharge", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 250
                });

                Columns.Add(new DatabaseColumn("DepartmentId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Units", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("Mobile", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ReferenceToken", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 10
                });

                Columns.Add(new DatabaseColumn("IsActivated", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn ServiceId{
                get{
                    return this.GetColumn("ServiceId");
                }
            }
            				
   			public static string ServiceIdColumn{
			      get{
        			return "ServiceId";
      			}
		    }
           
            public IColumn LoginId{
                get{
                    return this.GetColumn("LoginId");
                }
            }
            				
   			public static string LoginIdColumn{
			      get{
        			return "LoginId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn ServiceName{
                get{
                    return this.GetColumn("ServiceName");
                }
            }
            				
   			public static string ServiceNameColumn{
			      get{
        			return "ServiceName";
      			}
		    }
           
            public IColumn InCharge{
                get{
                    return this.GetColumn("InCharge");
                }
            }
            				
   			public static string InChargeColumn{
			      get{
        			return "InCharge";
      			}
		    }
           
            public IColumn DepartmentId{
                get{
                    return this.GetColumn("DepartmentId");
                }
            }
            				
   			public static string DepartmentIdColumn{
			      get{
        			return "DepartmentId";
      			}
		    }
           
            public IColumn Units{
                get{
                    return this.GetColumn("Units");
                }
            }
            				
   			public static string UnitsColumn{
			      get{
        			return "Units";
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
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn ReferenceToken{
                get{
                    return this.GetColumn("ReferenceToken");
                }
            }
            				
   			public static string ReferenceTokenColumn{
			      get{
        			return "ReferenceToken";
      			}
		    }
           
            public IColumn IsActivated{
                get{
                    return this.GetColumn("IsActivated");
                }
            }
            				
   			public static string IsActivatedColumn{
			      get{
        			return "IsActivated";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
        /// <summary>
        /// Table: TBL_Appointment
        /// Primary Key: AppointmentId
        /// </summary>

        public class TBL_AppointmentTable: DatabaseTable {
            
            public TBL_AppointmentTable(IDataProvider provider):base("TBL_Appointment",provider){
                ClassName = "TBL_Appointment";
                SchemaName = "dbo";
                

                Columns.Add(new DatabaseColumn("AppointmentId", this)
                {
	                IsPrimaryKey = true,
	                DataType = DbType.Int32,
	                IsNullable = false,
	                AutoIncrement = true,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PatientId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("OrganizationId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ServiceTimingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("DoctorTimingId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentDate", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("AppointmentTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("OnCallAppointmentTime", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 20
                });

                Columns.Add(new DatabaseColumn("Notes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("IsCarParking", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CarNumber", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 50
                });

                Columns.Add(new DatabaseColumn("PreferentialId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("PreferentialBoarding", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 15
                });

                Columns.Add(new DatabaseColumn("DoctorClosingNotes", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.String,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = -1
                });

                Columns.Add(new DatabaseColumn("StatusId", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Int32,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = true,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDirectAppointment", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("CreatedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("ModifiedOn", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.DateTime,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });

                Columns.Add(new DatabaseColumn("IsDeleted", this)
                {
	                IsPrimaryKey = false,
	                DataType = DbType.Boolean,
	                IsNullable = true,
	                AutoIncrement = false,
	                IsForeignKey = false,
	                MaxLength = 0
                });
                    
                
                
            }
            
            public IColumn AppointmentId{
                get{
                    return this.GetColumn("AppointmentId");
                }
            }
            				
   			public static string AppointmentIdColumn{
			      get{
        			return "AppointmentId";
      			}
		    }
           
            public IColumn PatientId{
                get{
                    return this.GetColumn("PatientId");
                }
            }
            				
   			public static string PatientIdColumn{
			      get{
        			return "PatientId";
      			}
		    }
           
            public IColumn OrganizationId{
                get{
                    return this.GetColumn("OrganizationId");
                }
            }
            				
   			public static string OrganizationIdColumn{
			      get{
        			return "OrganizationId";
      			}
		    }
           
            public IColumn ServiceId{
                get{
                    return this.GetColumn("ServiceId");
                }
            }
            				
   			public static string ServiceIdColumn{
			      get{
        			return "ServiceId";
      			}
		    }
           
            public IColumn ServiceTimingId{
                get{
                    return this.GetColumn("ServiceTimingId");
                }
            }
            				
   			public static string ServiceTimingIdColumn{
			      get{
        			return "ServiceTimingId";
      			}
		    }
           
            public IColumn DoctorId{
                get{
                    return this.GetColumn("DoctorId");
                }
            }
            				
   			public static string DoctorIdColumn{
			      get{
        			return "DoctorId";
      			}
		    }
           
            public IColumn DoctorTimingId{
                get{
                    return this.GetColumn("DoctorTimingId");
                }
            }
            				
   			public static string DoctorTimingIdColumn{
			      get{
        			return "DoctorTimingId";
      			}
		    }
           
            public IColumn AppointmentDate{
                get{
                    return this.GetColumn("AppointmentDate");
                }
            }
            				
   			public static string AppointmentDateColumn{
			      get{
        			return "AppointmentDate";
      			}
		    }
           
            public IColumn AppointmentTime{
                get{
                    return this.GetColumn("AppointmentTime");
                }
            }
            				
   			public static string AppointmentTimeColumn{
			      get{
        			return "AppointmentTime";
      			}
		    }
           
            public IColumn OnCallAppointmentTime{
                get{
                    return this.GetColumn("OnCallAppointmentTime");
                }
            }
            				
   			public static string OnCallAppointmentTimeColumn{
			      get{
        			return "OnCallAppointmentTime";
      			}
		    }
           
            public IColumn Notes{
                get{
                    return this.GetColumn("Notes");
                }
            }
            				
   			public static string NotesColumn{
			      get{
        			return "Notes";
      			}
		    }
           
            public IColumn IsCarParking{
                get{
                    return this.GetColumn("IsCarParking");
                }
            }
            				
   			public static string IsCarParkingColumn{
			      get{
        			return "IsCarParking";
      			}
		    }
           
            public IColumn CarNumber{
                get{
                    return this.GetColumn("CarNumber");
                }
            }
            				
   			public static string CarNumberColumn{
			      get{
        			return "CarNumber";
      			}
		    }
           
            public IColumn PreferentialId{
                get{
                    return this.GetColumn("PreferentialId");
                }
            }
            				
   			public static string PreferentialIdColumn{
			      get{
        			return "PreferentialId";
      			}
		    }
           
            public IColumn PreferentialBoarding{
                get{
                    return this.GetColumn("PreferentialBoarding");
                }
            }
            				
   			public static string PreferentialBoardingColumn{
			      get{
        			return "PreferentialBoarding";
      			}
		    }
           
            public IColumn DoctorClosingNotes{
                get{
                    return this.GetColumn("DoctorClosingNotes");
                }
            }
            				
   			public static string DoctorClosingNotesColumn{
			      get{
        			return "DoctorClosingNotes";
      			}
		    }
           
            public IColumn StatusId{
                get{
                    return this.GetColumn("StatusId");
                }
            }
            				
   			public static string StatusIdColumn{
			      get{
        			return "StatusId";
      			}
		    }
           
            public IColumn IsDirectAppointment{
                get{
                    return this.GetColumn("IsDirectAppointment");
                }
            }
            				
   			public static string IsDirectAppointmentColumn{
			      get{
        			return "IsDirectAppointment";
      			}
		    }
           
            public IColumn CreatedOn{
                get{
                    return this.GetColumn("CreatedOn");
                }
            }
            				
   			public static string CreatedOnColumn{
			      get{
        			return "CreatedOn";
      			}
		    }
           
            public IColumn ModifiedOn{
                get{
                    return this.GetColumn("ModifiedOn");
                }
            }
            				
   			public static string ModifiedOnColumn{
			      get{
        			return "ModifiedOn";
      			}
		    }
           
            public IColumn IsDeleted{
                get{
                    return this.GetColumn("IsDeleted");
                }
            }
            				
   			public static string IsDeletedColumn{
			      get{
        			return "IsDeleted";
      			}
		    }
           
                    
        }
        
}