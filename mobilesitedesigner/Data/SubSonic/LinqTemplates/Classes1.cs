


using System;
using System.ComponentModel;
using System.Linq;

namespace SubSonic.POCOS1.DB
{
    
    
    
    
    /// <summary>
    /// A class which represents the TBL_Patient_Reference table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient_Reference 
    /// </summary>

	public partial class TBL_Patient_Reference: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient_Reference(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnReferenceIdChanging(int value);
        partial void OnReferenceIdChanged();
		
		private int _ReferenceId;
		public int ReferenceId { 
		    get{
		        return _ReferenceId;
		    } 
		    set{
		        this.OnReferenceIdChanging(value);
                this.SendPropertyChanging();
                this._ReferenceId = value;
                this.SendPropertyChanged("ReferenceId");
                this.OnReferenceIdChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnReferenceNumberChanging(string value);
        partial void OnReferenceNumberChanged();
		
		private string _ReferenceNumber;
		public string ReferenceNumber { 
		    get{
		        return _ReferenceNumber;
		    } 
		    set{
		        this.OnReferenceNumberChanging(value);
                this.SendPropertyChanging();
                this._ReferenceNumber = value;
                this.SendPropertyChanged("ReferenceNumber");
                this.OnReferenceNumberChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_Location table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_Location 
    /// </summary>

	public partial class TBL_Job_Location: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_Location(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnLidChanging(int value);
        partial void OnLidChanged();
		
		private int _Lid;
		public int Lid { 
		    get{
		        return _Lid;
		    } 
		    set{
		        this.OnLidChanging(value);
                this.SendPropertyChanging();
                this._Lid = value;
                this.SendPropertyChanged("Lid");
                this.OnLidChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnStateIdChanging(int? value);
        partial void OnStateIdChanged();
		
		private int? _StateId;
		public int? StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnCityIdChanging(int? value);
        partial void OnCityIdChanged();
		
		private int? _CityId;
		public int? CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
		    }
		}
		
        partial void OnVisibilityChanging(bool? value);
        partial void OnVisibilityChanged();
		
		private bool? _Visibility;
		public bool? Visibility { 
		    get{
		        return _Visibility;
		    } 
		    set{
		        this.OnVisibilityChanging(value);
                this.SendPropertyChanging();
                this._Visibility = value;
                this.SendPropertyChanged("Visibility");
                this.OnVisibilityChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Building table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Building 
    /// </summary>

	public partial class TBL_Master_Building: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Building(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_SymptomGroup table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_SymptomGroup 
    /// </summary>

	public partial class TBL_Master_SymptomGroup: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_SymptomGroup(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSymptomGroupIdChanging(int value);
        partial void OnSymptomGroupIdChanged();
		
		private int _SymptomGroupId;
		public int SymptomGroupId { 
		    get{
		        return _SymptomGroupId;
		    } 
		    set{
		        this.OnSymptomGroupIdChanging(value);
                this.SendPropertyChanging();
                this._SymptomGroupId = value;
                this.SendPropertyChanged("SymptomGroupId");
                this.OnSymptomGroupIdChanged();
		    }
		}
		
        partial void OnSymptomGroupChanging(string value);
        partial void OnSymptomGroupChanged();
		
		private string _SymptomGroup;
		public string SymptomGroup { 
		    get{
		        return _SymptomGroup;
		    } 
		    set{
		        this.OnSymptomGroupChanging(value);
                this.SendPropertyChanging();
                this._SymptomGroup = value;
                this.SendPropertyChanged("SymptomGroup");
                this.OnSymptomGroupChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnRequestedByChanging(int? value);
        partial void OnRequestedByChanged();
		
		private int? _RequestedBy;
		public int? RequestedBy { 
		    get{
		        return _RequestedBy;
		    } 
		    set{
		        this.OnRequestedByChanging(value);
                this.SendPropertyChanging();
                this._RequestedBy = value;
                this.SendPropertyChanged("RequestedBy");
                this.OnRequestedByChanged();
		    }
		}
		
        partial void OnIsApprovedChanging(bool? value);
        partial void OnIsApprovedChanged();
		
		private bool? _IsApproved;
		public bool? IsApproved { 
		    get{
		        return _IsApproved;
		    } 
		    set{
		        this.OnIsApprovedChanging(value);
                this.SendPropertyChanging();
                this._IsApproved = value;
                this.SendPropertyChanged("IsApproved");
                this.OnIsApprovedChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_Symptom> TBL_Master_Symptoms
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Symptoms
                       where items.SymptomGroupId == _SymptomGroupId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Floor table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Floor 
    /// </summary>

	public partial class TBL_Master_Floor: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Floor(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnBuildingIdChanging(int value);
        partial void OnBuildingIdChanged();
		
		private int _BuildingId;
		public int BuildingId { 
		    get{
		        return _BuildingId;
		    } 
		    set{
		        this.OnBuildingIdChanging(value);
                this.SendPropertyChanging();
                this._BuildingId = value;
                this.SendPropertyChanged("BuildingId");
                this.OnBuildingIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Tbl_Master_Ward table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.Tbl_Master_Ward 
    /// </summary>

	public partial class Tbl_Master_Ward: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Tbl_Master_Ward(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int value);
        partial void OnOrganizationIdChanged();
		
		private int _OrganizationId;
		public int OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnFloorIdChanging(int? value);
        partial void OnFloorIdChanged();
		
		private int? _FloorId;
		public int? FloorId { 
		    get{
		        return _FloorId;
		    } 
		    set{
		        this.OnFloorIdChanging(value);
                this.SendPropertyChanging();
                this._FloorId = value;
                this.SendPropertyChanged("FloorId");
                this.OnFloorIdChanged();
		    }
		}
		
        partial void OnBuildingIdChanging(int? value);
        partial void OnBuildingIdChanged();
		
		private int? _BuildingId;
		public int? BuildingId { 
		    get{
		        return _BuildingId;
		    } 
		    set{
		        this.OnBuildingIdChanging(value);
                this.SendPropertyChanging();
                this._BuildingId = value;
                this.SendPropertyChanged("BuildingId");
                this.OnBuildingIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Rating table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Rating 
    /// </summary>

	public partial class TBL_Rating: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Rating(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnRatingIdChanging(int value);
        partial void OnRatingIdChanged();
		
		private int _RatingId;
		public int RatingId { 
		    get{
		        return _RatingId;
		    } 
		    set{
		        this.OnRatingIdChanging(value);
                this.SendPropertyChanging();
                this._RatingId = value;
                this.SendPropertyChanged("RatingId");
                this.OnRatingIdChanged();
		    }
		}
		
        partial void OnAppointmentIdChanging(int? value);
        partial void OnAppointmentIdChanged();
		
		private int? _AppointmentId;
		public int? AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnRatingChanging(decimal? value);
        partial void OnRatingChanged();
		
		private decimal? _Rating;
		public decimal? Rating { 
		    get{
		        return _Rating;
		    } 
		    set{
		        this.OnRatingChanging(value);
                this.SendPropertyChanging();
                this._Rating = value;
                this.SendPropertyChanged("Rating");
                this.OnRatingChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.AppointmentId == _AppointmentId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Symptom table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Symptom 
    /// </summary>

	public partial class TBL_Master_Symptom: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Symptom(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSymptomIdChanging(int value);
        partial void OnSymptomIdChanged();
		
		private int _SymptomId;
		public int SymptomId { 
		    get{
		        return _SymptomId;
		    } 
		    set{
		        this.OnSymptomIdChanging(value);
                this.SendPropertyChanging();
                this._SymptomId = value;
                this.SendPropertyChanged("SymptomId");
                this.OnSymptomIdChanged();
		    }
		}
		
        partial void OnSymptomGroupIdChanging(int? value);
        partial void OnSymptomGroupIdChanged();
		
		private int? _SymptomGroupId;
		public int? SymptomGroupId { 
		    get{
		        return _SymptomGroupId;
		    } 
		    set{
		        this.OnSymptomGroupIdChanging(value);
                this.SendPropertyChanging();
                this._SymptomGroupId = value;
                this.SendPropertyChanged("SymptomGroupId");
                this.OnSymptomGroupIdChanged();
		    }
		}
		
        partial void OnSymptomChanging(string value);
        partial void OnSymptomChanged();
		
		private string _Symptom;
		public string Symptom { 
		    get{
		        return _Symptom;
		    } 
		    set{
		        this.OnSymptomChanging(value);
                this.SendPropertyChanging();
                this._Symptom = value;
                this.SendPropertyChanged("Symptom");
                this.OnSymptomChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnRequestedByChanging(int? value);
        partial void OnRequestedByChanged();
		
		private int? _RequestedBy;
		public int? RequestedBy { 
		    get{
		        return _RequestedBy;
		    } 
		    set{
		        this.OnRequestedByChanging(value);
                this.SendPropertyChanging();
                this._RequestedBy = value;
                this.SendPropertyChanged("RequestedBy");
                this.OnRequestedByChanged();
		    }
		}
		
        partial void OnIsApprovedChanging(bool? value);
        partial void OnIsApprovedChanged();
		
		private bool? _IsApproved;
		public bool? IsApproved { 
		    get{
		        return _IsApproved;
		    } 
		    set{
		        this.OnIsApprovedChanging(value);
                this.SendPropertyChanging();
                this._IsApproved = value;
                this.SendPropertyChanged("IsApproved");
                this.OnIsApprovedChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnIsTreatmentChanging(bool? value);
        partial void OnIsTreatmentChanged();
		
		private bool? _IsTreatment;
		public bool? IsTreatment { 
		    get{
		        return _IsTreatment;
		    } 
		    set{
		        this.OnIsTreatmentChanging(value);
                this.SendPropertyChanging();
                this._IsTreatment = value;
                this.SendPropertyChanged("IsTreatment");
                this.OnIsTreatmentChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_SymptomGroup> TBL_Master_SymptomGroups
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_SymptomGroups
                       where items.SymptomGroupId == _SymptomGroupId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Preferential table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Preferential 
    /// </summary>

	public partial class TBL_Master_Preferential: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Preferential(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPreferentialIdChanging(int value);
        partial void OnPreferentialIdChanged();
		
		private int _PreferentialId;
		public int PreferentialId { 
		    get{
		        return _PreferentialId;
		    } 
		    set{
		        this.OnPreferentialIdChanging(value);
                this.SendPropertyChanging();
                this._PreferentialId = value;
                this.SendPropertyChanged("PreferentialId");
                this.OnPreferentialIdChanged();
		    }
		}
		
        partial void OnPreferentialNameChanging(string value);
        partial void OnPreferentialNameChanged();
		
		private string _PreferentialName;
		public string PreferentialName { 
		    get{
		        return _PreferentialName;
		    } 
		    set{
		        this.OnPreferentialNameChanging(value);
                this.SendPropertyChanging();
                this._PreferentialName = value;
                this.SendPropertyChanged("PreferentialName");
                this.OnPreferentialNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.PreferentialId == _PreferentialId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Diagnosis table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Diagnosi 
    /// </summary>

	public partial class TBL_Master_Diagnosi: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Diagnosi(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDiagnosisIdChanging(int value);
        partial void OnDiagnosisIdChanged();
		
		private int _DiagnosisId;
		public int DiagnosisId { 
		    get{
		        return _DiagnosisId;
		    } 
		    set{
		        this.OnDiagnosisIdChanging(value);
                this.SendPropertyChanging();
                this._DiagnosisId = value;
                this.SendPropertyChanged("DiagnosisId");
                this.OnDiagnosisIdChanged();
		    }
		}
		
        partial void OnDiagnosisChanging(string value);
        partial void OnDiagnosisChanged();
		
		private string _Diagnosis;
		public string Diagnosis { 
		    get{
		        return _Diagnosis;
		    } 
		    set{
		        this.OnDiagnosisChanging(value);
                this.SendPropertyChanging();
                this._Diagnosis = value;
                this.SendPropertyChanged("Diagnosis");
                this.OnDiagnosisChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnRequestedByChanging(int? value);
        partial void OnRequestedByChanged();
		
		private int? _RequestedBy;
		public int? RequestedBy { 
		    get{
		        return _RequestedBy;
		    } 
		    set{
		        this.OnRequestedByChanging(value);
                this.SendPropertyChanging();
                this._RequestedBy = value;
                this.SendPropertyChanged("RequestedBy");
                this.OnRequestedByChanged();
		    }
		}
		
        partial void OnIsApprovedChanging(bool? value);
        partial void OnIsApprovedChanged();
		
		private bool? _IsApproved;
		public bool? IsApproved { 
		    get{
		        return _IsApproved;
		    } 
		    set{
		        this.OnIsApprovedChanging(value);
                this.SendPropertyChanging();
                this._IsApproved = value;
                this.SendPropertyChanged("IsApproved");
                this.OnIsApprovedChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnIsTreatmentChanging(bool? value);
        partial void OnIsTreatmentChanged();
		
		private bool? _IsTreatment;
		public bool? IsTreatment { 
		    get{
		        return _IsTreatment;
		    } 
		    set{
		        this.OnIsTreatmentChanging(value);
                this.SendPropertyChanging();
                this._IsTreatment = value;
                this.SendPropertyChanged("IsTreatment");
                this.OnIsTreatmentChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Answer table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Answer 
    /// </summary>

	public partial class TBL_Answer: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Answer(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAnswerIdChanging(int value);
        partial void OnAnswerIdChanged();
		
		private int _AnswerId;
		public int AnswerId { 
		    get{
		        return _AnswerId;
		    } 
		    set{
		        this.OnAnswerIdChanging(value);
                this.SendPropertyChanging();
                this._AnswerId = value;
                this.SendPropertyChanged("AnswerId");
                this.OnAnswerIdChanged();
		    }
		}
		
        partial void OnQuestionIdChanging(int? value);
        partial void OnQuestionIdChanged();
		
		private int? _QuestionId;
		public int? QuestionId { 
		    get{
		        return _QuestionId;
		    } 
		    set{
		        this.OnQuestionIdChanging(value);
                this.SendPropertyChanging();
                this._QuestionId = value;
                this.SendPropertyChanged("QuestionId");
                this.OnQuestionIdChanged();
		    }
		}
		
        partial void OnAnswerChanging(string value);
        partial void OnAnswerChanged();
		
		private string _Answer;
		public string Answer { 
		    get{
		        return _Answer;
		    } 
		    set{
		        this.OnAnswerChanging(value);
                this.SendPropertyChanging();
                this._Answer = value;
                this.SendPropertyChanged("Answer");
                this.OnAnswerChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnIsPatientChanging(bool? value);
        partial void OnIsPatientChanged();
		
		private bool? _IsPatient;
		public bool? IsPatient { 
		    get{
		        return _IsPatient;
		    } 
		    set{
		        this.OnIsPatientChanging(value);
                this.SendPropertyChanging();
                this._IsPatient = value;
                this.SendPropertyChanged("IsPatient");
                this.OnIsPatientChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Doctor> TBL_Doctors
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.DoctorId == _DoctorId
                       select items;
            }
        }

        public IQueryable<TBL_Question> TBL_Questions
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Questions
                       where items.QuestionId == _QuestionId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_SMS table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_SM 
    /// </summary>

	public partial class TBL_SM: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_SM(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnLoginIdChanging(int? value);
        partial void OnLoginIdChanged();
		
		private int? _LoginId;
		public int? LoginId { 
		    get{
		        return _LoginId;
		    } 
		    set{
		        this.OnLoginIdChanging(value);
                this.SendPropertyChanging();
                this._LoginId = value;
                this.SendPropertyChanged("LoginId");
                this.OnLoginIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnMobileChanging(string value);
        partial void OnMobileChanged();
		
		private string _Mobile;
		public string Mobile { 
		    get{
		        return _Mobile;
		    } 
		    set{
		        this.OnMobileChanging(value);
                this.SendPropertyChanging();
                this._Mobile = value;
                this.SendPropertyChanged("Mobile");
                this.OnMobileChanged();
		    }
		}
		
        partial void OnAccountIdChanging(int? value);
        partial void OnAccountIdChanged();
		
		private int? _AccountId;
		public int? AccountId { 
		    get{
		        return _AccountId;
		    } 
		    set{
		        this.OnAccountIdChanging(value);
                this.SendPropertyChanging();
                this._AccountId = value;
                this.SendPropertyChanged("AccountId");
                this.OnAccountIdChanged();
		    }
		}
		
        partial void OnAccountTypeIdChanging(int? value);
        partial void OnAccountTypeIdChanged();
		
		private int? _AccountTypeId;
		public int? AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnAppointmentIdChanging(int? value);
        partial void OnAppointmentIdChanged();
		
		private int? _AppointmentId;
		public int? AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnSMSMessageChanging(string value);
        partial void OnSMSMessageChanged();
		
		private string _SMSMessage;
		public string SMSMessage { 
		    get{
		        return _SMSMessage;
		    } 
		    set{
		        this.OnSMSMessageChanging(value);
                this.SendPropertyChanging();
                this._SMSMessage = value;
                this.SendPropertyChanged("SMSMessage");
                this.OnSMSMessageChanged();
		    }
		}
		
        partial void OnActionChanging(string value);
        partial void OnActionChanged();
		
		private string _Action;
		public string Action { 
		    get{
		        return _Action;
		    } 
		    set{
		        this.OnActionChanging(value);
                this.SendPropertyChanging();
                this._Action = value;
                this.SendPropertyChanged("Action");
                this.OnActionChanged();
		    }
		}
		
        partial void OnEmailCountChanging(int? value);
        partial void OnEmailCountChanged();
		
		private int? _EmailCount;
		public int? EmailCount { 
		    get{
		        return _EmailCount;
		    } 
		    set{
		        this.OnEmailCountChanging(value);
                this.SendPropertyChanging();
                this._EmailCount = value;
                this.SendPropertyChanged("EmailCount");
                this.OnEmailCountChanged();
		    }
		}
		
        partial void OnMobileIdChanging(string value);
        partial void OnMobileIdChanged();
		
		private string _MobileId;
		public string MobileId { 
		    get{
		        return _MobileId;
		    } 
		    set{
		        this.OnMobileIdChanging(value);
                this.SendPropertyChanging();
                this._MobileId = value;
                this.SendPropertyChanged("MobileId");
                this.OnMobileIdChanged();
		    }
		}
		
        partial void OnExternalIdChanging(string value);
        partial void OnExternalIdChanged();
		
		private string _ExternalId;
		public string ExternalId { 
		    get{
		        return _ExternalId;
		    } 
		    set{
		        this.OnExternalIdChanging(value);
                this.SendPropertyChanging();
                this._ExternalId = value;
                this.SendPropertyChanged("ExternalId");
                this.OnExternalIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Symptom_Diagnosis table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Symptom_Diagnosi 
    /// </summary>

	public partial class TBL_Symptom_Diagnosi: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Symptom_Diagnosi(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSymptomIdChanging(int? value);
        partial void OnSymptomIdChanged();
		
		private int? _SymptomId;
		public int? SymptomId { 
		    get{
		        return _SymptomId;
		    } 
		    set{
		        this.OnSymptomIdChanging(value);
                this.SendPropertyChanging();
                this._SymptomId = value;
                this.SendPropertyChanged("SymptomId");
                this.OnSymptomIdChanged();
		    }
		}
		
        partial void OnDiagnosisIdChanging(int? value);
        partial void OnDiagnosisIdChanged();
		
		private int? _DiagnosisId;
		public int? DiagnosisId { 
		    get{
		        return _DiagnosisId;
		    } 
		    set{
		        this.OnDiagnosisIdChanging(value);
                this.SendPropertyChanging();
                this._DiagnosisId = value;
                this.SendPropertyChanged("DiagnosisId");
                this.OnDiagnosisIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Diagnosis_Department table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Diagnosis_Department 
    /// </summary>

	public partial class TBL_Diagnosis_Department: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Diagnosis_Department(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDiagnosisIdChanging(int? value);
        partial void OnDiagnosisIdChanged();
		
		private int? _DiagnosisId;
		public int? DiagnosisId { 
		    get{
		        return _DiagnosisId;
		    } 
		    set{
		        this.OnDiagnosisIdChanging(value);
                this.SendPropertyChanging();
                this._DiagnosisId = value;
                this.SendPropertyChanged("DiagnosisId");
                this.OnDiagnosisIdChanged();
		    }
		}
		
        partial void OnDepartmentIdChanging(int? value);
        partial void OnDepartmentIdChanged();
		
		private int? _DepartmentId;
		public int? DepartmentId { 
		    get{
		        return _DepartmentId;
		    } 
		    set{
		        this.OnDepartmentIdChanging(value);
                this.SendPropertyChanging();
                this._DepartmentId = value;
                this.SendPropertyChanged("DepartmentId");
                this.OnDepartmentIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Question table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Question 
    /// </summary>

	public partial class TBL_Question: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Question(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnQuestionIdChanging(int value);
        partial void OnQuestionIdChanged();
		
		private int _QuestionId;
		public int QuestionId { 
		    get{
		        return _QuestionId;
		    } 
		    set{
		        this.OnQuestionIdChanging(value);
                this.SendPropertyChanging();
                this._QuestionId = value;
                this.SendPropertyChanged("QuestionId");
                this.OnQuestionIdChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnQuestionChanging(string value);
        partial void OnQuestionChanged();
		
		private string _Question;
		public string Question { 
		    get{
		        return _Question;
		    } 
		    set{
		        this.OnQuestionChanging(value);
                this.SendPropertyChanging();
                this._Question = value;
                this.SendPropertyChanged("Question");
                this.OnQuestionChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Answer> TBL_Answers
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Answers
                       where items.QuestionId == _QuestionId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients2
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Doctor_Diagnosis table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Doctor_Diagnosi 
    /// </summary>

	public partial class TBL_Doctor_Diagnosi: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Doctor_Diagnosi(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnDiagnosisIdChanging(int? value);
        partial void OnDiagnosisIdChanged();
		
		private int? _DiagnosisId;
		public int? DiagnosisId { 
		    get{
		        return _DiagnosisId;
		    } 
		    set{
		        this.OnDiagnosisIdChanging(value);
                this.SendPropertyChanging();
                this._DiagnosisId = value;
                this.SendPropertyChanged("DiagnosisId");
                this.OnDiagnosisIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Feedback table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Feedback 
    /// </summary>

	public partial class TBL_Feedback: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Feedback(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnFeedbackIdChanging(int value);
        partial void OnFeedbackIdChanged();
		
		private int _FeedbackId;
		public int FeedbackId { 
		    get{
		        return _FeedbackId;
		    } 
		    set{
		        this.OnFeedbackIdChanging(value);
                this.SendPropertyChanging();
                this._FeedbackId = value;
                this.SendPropertyChanged("FeedbackId");
                this.OnFeedbackIdChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
		
		private string _Email;
		public string Email { 
		    get{
		        return _Email;
		    } 
		    set{
		        this.OnEmailChanging(value);
                this.SendPropertyChanging();
                this._Email = value;
                this.SendPropertyChanged("Email");
                this.OnEmailChanged();
		    }
		}
		
        partial void OnFeedbackChanging(string value);
        partial void OnFeedbackChanged();
		
		private string _Feedback;
		public string Feedback { 
		    get{
		        return _Feedback;
		    } 
		    set{
		        this.OnFeedbackChanging(value);
                this.SendPropertyChanging();
                this._Feedback = value;
                this.SendPropertyChanged("Feedback");
                this.OnFeedbackChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_KeywordSMS table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_KeywordSM 
    /// </summary>

	public partial class TBL_KeywordSM: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_KeywordSM(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnKeywordSMSIdChanging(int value);
        partial void OnKeywordSMSIdChanged();
		
		private int _KeywordSMSId;
		public int KeywordSMSId { 
		    get{
		        return _KeywordSMSId;
		    } 
		    set{
		        this.OnKeywordSMSIdChanging(value);
                this.SendPropertyChanging();
                this._KeywordSMSId = value;
                this.SendPropertyChanged("KeywordSMSId");
                this.OnKeywordSMSIdChanged();
		    }
		}
		
        partial void OnPhoneCodeChanging(string value);
        partial void OnPhoneCodeChanged();
		
		private string _PhoneCode;
		public string PhoneCode { 
		    get{
		        return _PhoneCode;
		    } 
		    set{
		        this.OnPhoneCodeChanging(value);
                this.SendPropertyChanging();
                this._PhoneCode = value;
                this.SendPropertyChanged("PhoneCode");
                this.OnPhoneCodeChanged();
		    }
		}
		
        partial void OnKeywordChanging(string value);
        partial void OnKeywordChanged();
		
		private string _Keyword;
		public string Keyword { 
		    get{
		        return _Keyword;
		    } 
		    set{
		        this.OnKeywordChanging(value);
                this.SendPropertyChanging();
                this._Keyword = value;
                this.SendPropertyChanged("Keyword");
                this.OnKeywordChanged();
		    }
		}
		
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
		
		private string _Location;
		public string Location { 
		    get{
		        return _Location;
		    } 
		    set{
		        this.OnLocationChanging(value);
                this.SendPropertyChanging();
                this._Location = value;
                this.SendPropertyChanged("Location");
                this.OnLocationChanged();
		    }
		}
		
        partial void OnCarrierChanging(string value);
        partial void OnCarrierChanged();
		
		private string _Carrier;
		public string Carrier { 
		    get{
		        return _Carrier;
		    } 
		    set{
		        this.OnCarrierChanging(value);
                this.SendPropertyChanging();
                this._Carrier = value;
                this.SendPropertyChanged("Carrier");
                this.OnCarrierChanged();
		    }
		}
		
        partial void OnContentsChanging(string value);
        partial void OnContentsChanged();
		
		private string _Contents;
		public string Contents { 
		    get{
		        return _Contents;
		    } 
		    set{
		        this.OnContentsChanging(value);
                this.SendPropertyChanging();
                this._Contents = value;
                this.SendPropertyChanged("Contents");
                this.OnContentsChanged();
		    }
		}
		
        partial void OnPhoneNoChanging(string value);
        partial void OnPhoneNoChanged();
		
		private string _PhoneNo;
		public string PhoneNo { 
		    get{
		        return _PhoneNo;
		    } 
		    set{
		        this.OnPhoneNoChanging(value);
                this.SendPropertyChanging();
                this._PhoneNo = value;
                this.SendPropertyChanged("PhoneNo");
                this.OnPhoneNoChanged();
		    }
		}
		
        partial void OnTimeChanging(string value);
        partial void OnTimeChanged();
		
		private string _Time;
		public string Time { 
		    get{
		        return _Time;
		    } 
		    set{
		        this.OnTimeChanging(value);
                this.SendPropertyChanging();
                this._Time = value;
                this.SendPropertyChanged("Time");
                this.OnTimeChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_FamilyHistory table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_FamilyHistory 
    /// </summary>

	public partial class TBL_Master_FamilyHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_FamilyHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnFamilyHistoryIdChanging(int value);
        partial void OnFamilyHistoryIdChanged();
		
		private int _FamilyHistoryId;
		public int FamilyHistoryId { 
		    get{
		        return _FamilyHistoryId;
		    } 
		    set{
		        this.OnFamilyHistoryIdChanging(value);
                this.SendPropertyChanging();
                this._FamilyHistoryId = value;
                this.SendPropertyChanged("FamilyHistoryId");
                this.OnFamilyHistoryIdChanged();
		    }
		}
		
        partial void OnFamilyHistoryNameChanging(string value);
        partial void OnFamilyHistoryNameChanged();
		
		private string _FamilyHistoryName;
		public string FamilyHistoryName { 
		    get{
		        return _FamilyHistoryName;
		    } 
		    set{
		        this.OnFamilyHistoryNameChanging(value);
                this.SendPropertyChanging();
                this._FamilyHistoryName = value;
                this.SendPropertyChanged("FamilyHistoryName");
                this.OnFamilyHistoryNameChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Appointment_Winservice table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Appointment_Winservice 
    /// </summary>

	public partial class TBL_Appointment_Winservice: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Appointment_Winservice(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnWinServiceIdChanging(int value);
        partial void OnWinServiceIdChanged();
		
		private int _WinServiceId;
		public int WinServiceId { 
		    get{
		        return _WinServiceId;
		    } 
		    set{
		        this.OnWinServiceIdChanging(value);
                this.SendPropertyChanging();
                this._WinServiceId = value;
                this.SendPropertyChanged("WinServiceId");
                this.OnWinServiceIdChanged();
		    }
		}
		
        partial void OnAppointmentIdChanging(int? value);
        partial void OnAppointmentIdChanged();
		
		private int? _AppointmentId;
		public int? AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnDoctorTimingIdChanging(int? value);
        partial void OnDoctorTimingIdChanged();
		
		private int? _DoctorTimingId;
		public int? DoctorTimingId { 
		    get{
		        return _DoctorTimingId;
		    } 
		    set{
		        this.OnDoctorTimingIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorTimingId = value;
                this.SendPropertyChanged("DoctorTimingId");
                this.OnDoctorTimingIdChanged();
		    }
		}
		
        partial void OnServiceIdChanging(int? value);
        partial void OnServiceIdChanged();
		
		private int? _ServiceId;
		public int? ServiceId { 
		    get{
		        return _ServiceId;
		    } 
		    set{
		        this.OnServiceIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceId = value;
                this.SendPropertyChanged("ServiceId");
                this.OnServiceIdChanged();
		    }
		}
		
        partial void OnServiceTimingIdChanging(int? value);
        partial void OnServiceTimingIdChanged();
		
		private int? _ServiceTimingId;
		public int? ServiceTimingId { 
		    get{
		        return _ServiceTimingId;
		    } 
		    set{
		        this.OnServiceTimingIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceTimingId = value;
                this.SendPropertyChanged("ServiceTimingId");
                this.OnServiceTimingIdChanged();
		    }
		}
		
        partial void OnEmailIdChanging(string value);
        partial void OnEmailIdChanged();
		
		private string _EmailId;
		public string EmailId { 
		    get{
		        return _EmailId;
		    } 
		    set{
		        this.OnEmailIdChanging(value);
                this.SendPropertyChanging();
                this._EmailId = value;
                this.SendPropertyChanged("EmailId");
                this.OnEmailIdChanged();
		    }
		}
		
        partial void OnMobileIdChanging(string value);
        partial void OnMobileIdChanged();
		
		private string _MobileId;
		public string MobileId { 
		    get{
		        return _MobileId;
		    } 
		    set{
		        this.OnMobileIdChanging(value);
                this.SendPropertyChanging();
                this._MobileId = value;
                this.SendPropertyChanged("MobileId");
                this.OnMobileIdChanged();
		    }
		}
		
        partial void OnAppointmentDateChanging(DateTime? value);
        partial void OnAppointmentDateChanged();
		
		private DateTime? _AppointmentDate;
		public DateTime? AppointmentDate { 
		    get{
		        return _AppointmentDate;
		    } 
		    set{
		        this.OnAppointmentDateChanging(value);
                this.SendPropertyChanging();
                this._AppointmentDate = value;
                this.SendPropertyChanged("AppointmentDate");
                this.OnAppointmentDateChanged();
		    }
		}
		
        partial void OnMessageDescriptionChanging(string value);
        partial void OnMessageDescriptionChanged();
		
		private string _MessageDescription;
		public string MessageDescription { 
		    get{
		        return _MessageDescription;
		    } 
		    set{
		        this.OnMessageDescriptionChanging(value);
                this.SendPropertyChanging();
                this._MessageDescription = value;
                this.SendPropertyChanged("MessageDescription");
                this.OnMessageDescriptionChanged();
		    }
		}
		
        partial void OnAccountTypeIdChanging(int? value);
        partial void OnAccountTypeIdChanged();
		
		private int? _AccountTypeId;
		public int? AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnIsSmsSentChanging(bool? value);
        partial void OnIsSmsSentChanged();
		
		private bool? _IsSmsSent;
		public bool? IsSmsSent { 
		    get{
		        return _IsSmsSent;
		    } 
		    set{
		        this.OnIsSmsSentChanging(value);
                this.SendPropertyChanging();
                this._IsSmsSent = value;
                this.SendPropertyChanged("IsSmsSent");
                this.OnIsSmsSentChanged();
		    }
		}
		
        partial void OnIsEmailSentChanging(bool? value);
        partial void OnIsEmailSentChanged();
		
		private bool? _IsEmailSent;
		public bool? IsEmailSent { 
		    get{
		        return _IsEmailSent;
		    } 
		    set{
		        this.OnIsEmailSentChanging(value);
                this.SendPropertyChanging();
                this._IsEmailSent = value;
                this.SendPropertyChanged("IsEmailSent");
                this.OnIsEmailSentChanged();
		    }
		}
		
        partial void OnMobileChanging(string value);
        partial void OnMobileChanged();
		
		private string _Mobile;
		public string Mobile { 
		    get{
		        return _Mobile;
		    } 
		    set{
		        this.OnMobileChanging(value);
                this.SendPropertyChanging();
                this._Mobile = value;
                this.SendPropertyChanged("Mobile");
                this.OnMobileChanged();
		    }
		}
		
        partial void OnExternalIdChanging(string value);
        partial void OnExternalIdChanged();
		
		private string _ExternalId;
		public string ExternalId { 
		    get{
		        return _ExternalId;
		    } 
		    set{
		        this.OnExternalIdChanging(value);
                this.SendPropertyChanging();
                this._ExternalId = value;
                this.SendPropertyChanged("ExternalId");
                this.OnExternalIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Relationship table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Relationship 
    /// </summary>

	public partial class TBL_Master_Relationship: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Relationship(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnRelationshipIdChanging(int value);
        partial void OnRelationshipIdChanged();
		
		private int _RelationshipId;
		public int RelationshipId { 
		    get{
		        return _RelationshipId;
		    } 
		    set{
		        this.OnRelationshipIdChanging(value);
                this.SendPropertyChanging();
                this._RelationshipId = value;
                this.SendPropertyChanged("RelationshipId");
                this.OnRelationshipIdChanged();
		    }
		}
		
        partial void OnRelationshipChanging(string value);
        partial void OnRelationshipChanged();
		
		private string _Relationship;
		public string Relationship { 
		    get{
		        return _Relationship;
		    } 
		    set{
		        this.OnRelationshipChanging(value);
                this.SendPropertyChanging();
                this._Relationship = value;
                this.SendPropertyChanged("Relationship");
                this.OnRelationshipChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.RelationshipId == _RelationshipId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Status table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Status 
    /// </summary>

	public partial class TBL_Master_Status: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Status(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnStatusIdChanging(int value);
        partial void OnStatusIdChanged();
		
		private int _StatusId;
		public int StatusId { 
		    get{
		        return _StatusId;
		    } 
		    set{
		        this.OnStatusIdChanging(value);
                this.SendPropertyChanging();
                this._StatusId = value;
                this.SendPropertyChanged("StatusId");
                this.OnStatusIdChanged();
		    }
		}
		
        partial void OnStatusNameChanging(string value);
        partial void OnStatusNameChanged();
		
		private string _StatusName;
		public string StatusName { 
		    get{
		        return _StatusName;
		    } 
		    set{
		        this.OnStatusNameChanging(value);
                this.SendPropertyChanging();
                this._StatusName = value;
                this.SendPropertyChanged("StatusName");
                this.OnStatusNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.StatusId == _StatusId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Doctor_Experience table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Doctor_Experience 
    /// </summary>

	public partial class TBL_Doctor_Experience: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Doctor_Experience(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnExperienceIdChanging(int value);
        partial void OnExperienceIdChanged();
		
		private int _ExperienceId;
		public int ExperienceId { 
		    get{
		        return _ExperienceId;
		    } 
		    set{
		        this.OnExperienceIdChanging(value);
                this.SendPropertyChanging();
                this._ExperienceId = value;
                this.SendPropertyChanged("ExperienceId");
                this.OnExperienceIdChanged();
		    }
		}
		
        partial void OnMedicalServiceNameChanging(string value);
        partial void OnMedicalServiceNameChanged();
		
		private string _MedicalServiceName;
		public string MedicalServiceName { 
		    get{
		        return _MedicalServiceName;
		    } 
		    set{
		        this.OnMedicalServiceNameChanging(value);
                this.SendPropertyChanging();
                this._MedicalServiceName = value;
                this.SendPropertyChanged("MedicalServiceName");
                this.OnMedicalServiceNameChanged();
		    }
		}
		
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
		
		private string _Title;
		public string Title { 
		    get{
		        return _Title;
		    } 
		    set{
		        this.OnTitleChanging(value);
                this.SendPropertyChanging();
                this._Title = value;
                this.SendPropertyChanged("Title");
                this.OnTitleChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnStateIdChanging(int? value);
        partial void OnStateIdChanged();
		
		private int? _StateId;
		public int? StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnCityIdChanging(int? value);
        partial void OnCityIdChanged();
		
		private int? _CityId;
		public int? CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
		    }
		}
		
        partial void OnYearFromChanging(int? value);
        partial void OnYearFromChanged();
		
		private int? _YearFrom;
		public int? YearFrom { 
		    get{
		        return _YearFrom;
		    } 
		    set{
		        this.OnYearFromChanging(value);
                this.SendPropertyChanging();
                this._YearFrom = value;
                this.SendPropertyChanged("YearFrom");
                this.OnYearFromChanged();
		    }
		}
		
        partial void OnMonthFromChanging(int? value);
        partial void OnMonthFromChanged();
		
		private int? _MonthFrom;
		public int? MonthFrom { 
		    get{
		        return _MonthFrom;
		    } 
		    set{
		        this.OnMonthFromChanging(value);
                this.SendPropertyChanging();
                this._MonthFrom = value;
                this.SendPropertyChanged("MonthFrom");
                this.OnMonthFromChanged();
		    }
		}
		
        partial void OnYearToChanging(int? value);
        partial void OnYearToChanged();
		
		private int? _YearTo;
		public int? YearTo { 
		    get{
		        return _YearTo;
		    } 
		    set{
		        this.OnYearToChanging(value);
                this.SendPropertyChanging();
                this._YearTo = value;
                this.SendPropertyChanged("YearTo");
                this.OnYearToChanged();
		    }
		}
		
        partial void OnMonthToChanging(int? value);
        partial void OnMonthToChanged();
		
		private int? _MonthTo;
		public int? MonthTo { 
		    get{
		        return _MonthTo;
		    } 
		    set{
		        this.OnMonthToChanging(value);
                this.SendPropertyChanging();
                this._MonthTo = value;
                this.SendPropertyChanged("MonthTo");
                this.OnMonthToChanged();
		    }
		}
		
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
		
		private string _Notes;
		public string Notes { 
		    get{
		        return _Notes;
		    } 
		    set{
		        this.OnNotesChanging(value);
                this.SendPropertyChanging();
                this._Notes = value;
                this.SendPropertyChanged("Notes");
                this.OnNotesChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_PersonalHistory table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_PersonalHistory 
    /// </summary>

	public partial class TBL_Master_PersonalHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_PersonalHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPersonalHistoryIdChanging(int value);
        partial void OnPersonalHistoryIdChanged();
		
		private int _PersonalHistoryId;
		public int PersonalHistoryId { 
		    get{
		        return _PersonalHistoryId;
		    } 
		    set{
		        this.OnPersonalHistoryIdChanging(value);
                this.SendPropertyChanging();
                this._PersonalHistoryId = value;
                this.SendPropertyChanged("PersonalHistoryId");
                this.OnPersonalHistoryIdChanged();
		    }
		}
		
        partial void OnPersonalHistoryNameChanging(string value);
        partial void OnPersonalHistoryNameChanged();
		
		private string _PersonalHistoryName;
		public string PersonalHistoryName { 
		    get{
		        return _PersonalHistoryName;
		    } 
		    set{
		        this.OnPersonalHistoryNameChanging(value);
                this.SendPropertyChanging();
                this._PersonalHistoryName = value;
                this.SendPropertyChanged("PersonalHistoryName");
                this.OnPersonalHistoryNameChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Patient_PersonalHistory> TBL_Patient_PersonalHistories
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patient_PersonalHistories
                       where items.PersonalHistoryId == _PersonalHistoryId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Patient_SearchCount table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient_SearchCount 
    /// </summary>

	public partial class TBL_Patient_SearchCount: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient_SearchCount(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSearchIdChanging(int value);
        partial void OnSearchIdChanged();
		
		private int _SearchId;
		public int SearchId { 
		    get{
		        return _SearchId;
		    } 
		    set{
		        this.OnSearchIdChanging(value);
                this.SendPropertyChanging();
                this._SearchId = value;
                this.SendPropertyChanged("SearchId");
                this.OnSearchIdChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnCountryNameChanging(string value);
        partial void OnCountryNameChanged();
		
		private string _CountryName;
		public string CountryName { 
		    get{
		        return _CountryName;
		    } 
		    set{
		        this.OnCountryNameChanging(value);
                this.SendPropertyChanging();
                this._CountryName = value;
                this.SendPropertyChanged("CountryName");
                this.OnCountryNameChanged();
		    }
		}
		
        partial void OnStateNameChanging(string value);
        partial void OnStateNameChanged();
		
		private string _StateName;
		public string StateName { 
		    get{
		        return _StateName;
		    } 
		    set{
		        this.OnStateNameChanging(value);
                this.SendPropertyChanging();
                this._StateName = value;
                this.SendPropertyChanged("StateName");
                this.OnStateNameChanged();
		    }
		}
		
        partial void OnCityNameChanging(string value);
        partial void OnCityNameChanged();
		
		private string _CityName;
		public string CityName { 
		    get{
		        return _CityName;
		    } 
		    set{
		        this.OnCityNameChanging(value);
                this.SendPropertyChanging();
                this._CityName = value;
                this.SendPropertyChanged("CityName");
                this.OnCityNameChanged();
		    }
		}
		
        partial void OnSpecialityChanging(string value);
        partial void OnSpecialityChanged();
		
		private string _Speciality;
		public string Speciality { 
		    get{
		        return _Speciality;
		    } 
		    set{
		        this.OnSpecialityChanging(value);
                this.SendPropertyChanging();
                this._Speciality = value;
                this.SendPropertyChanged("Speciality");
                this.OnSpecialityChanged();
		    }
		}
		
        partial void OnSpecialityTypeChanging(int? value);
        partial void OnSpecialityTypeChanged();
		
		private int? _SpecialityType;
		public int? SpecialityType { 
		    get{
		        return _SpecialityType;
		    } 
		    set{
		        this.OnSpecialityTypeChanging(value);
                this.SendPropertyChanging();
                this._SpecialityType = value;
                this.SendPropertyChanged("SpecialityType");
                this.OnSpecialityTypeChanged();
		    }
		}
		
        partial void OnSearchCountChanging(int? value);
        partial void OnSearchCountChanged();
		
		private int? _SearchCount;
		public int? SearchCount { 
		    get{
		        return _SearchCount;
		    } 
		    set{
		        this.OnSearchCountChanging(value);
                this.SendPropertyChanging();
                this._SearchCount = value;
                this.SendPropertyChanged("SearchCount");
                this.OnSearchCountChanged();
		    }
		}
		
        partial void OnSearchTypeChanging(int? value);
        partial void OnSearchTypeChanged();
		
		private int? _SearchType;
		public int? SearchType { 
		    get{
		        return _SearchType;
		    } 
		    set{
		        this.OnSearchTypeChanging(value);
                this.SendPropertyChanging();
                this._SearchType = value;
                this.SendPropertyChanged("SearchType");
                this.OnSearchTypeChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Patient_FamilyHistory table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient_FamilyHistory 
    /// </summary>

	public partial class TBL_Patient_FamilyHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient_FamilyHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnFamilyHistoryIdChanging(int? value);
        partial void OnFamilyHistoryIdChanged();
		
		private int? _FamilyHistoryId;
		public int? FamilyHistoryId { 
		    get{
		        return _FamilyHistoryId;
		    } 
		    set{
		        this.OnFamilyHistoryIdChanging(value);
                this.SendPropertyChanging();
                this._FamilyHistoryId = value;
                this.SendPropertyChanged("FamilyHistoryId");
                this.OnFamilyHistoryIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_PastHistory table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_PastHistory 
    /// </summary>

	public partial class TBL_Master_PastHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_PastHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPastHistoryIdChanging(int value);
        partial void OnPastHistoryIdChanged();
		
		private int _PastHistoryId;
		public int PastHistoryId { 
		    get{
		        return _PastHistoryId;
		    } 
		    set{
		        this.OnPastHistoryIdChanging(value);
                this.SendPropertyChanging();
                this._PastHistoryId = value;
                this.SendPropertyChanged("PastHistoryId");
                this.OnPastHistoryIdChanged();
		    }
		}
		
        partial void OnPastHistoryNameChanging(string value);
        partial void OnPastHistoryNameChanged();
		
		private string _PastHistoryName;
		public string PastHistoryName { 
		    get{
		        return _PastHistoryName;
		    } 
		    set{
		        this.OnPastHistoryNameChanging(value);
                this.SendPropertyChanging();
                this._PastHistoryName = value;
                this.SendPropertyChanged("PastHistoryName");
                this.OnPastHistoryNameChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Patient_PastHistory> TBL_Patient_PastHistories
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patient_PastHistories
                       where items.PastHistoryId == _PastHistoryId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Patient table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient 
    /// </summary>

	public partial class TBL_Patient: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPatientIdChanging(int value);
        partial void OnPatientIdChanged();
		
		private int _PatientId;
		public int PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnLoginIdChanging(int? value);
        partial void OnLoginIdChanged();
		
		private int? _LoginId;
		public int? LoginId { 
		    get{
		        return _LoginId;
		    } 
		    set{
		        this.OnLoginIdChanging(value);
                this.SendPropertyChanging();
                this._LoginId = value;
                this.SendPropertyChanged("LoginId");
                this.OnLoginIdChanged();
		    }
		}
		
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
		
		private string _FirstName;
		public string FirstName { 
		    get{
		        return _FirstName;
		    } 
		    set{
		        this.OnFirstNameChanging(value);
                this.SendPropertyChanging();
                this._FirstName = value;
                this.SendPropertyChanged("FirstName");
                this.OnFirstNameChanged();
		    }
		}
		
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
		
		private string _LastName;
		public string LastName { 
		    get{
		        return _LastName;
		    } 
		    set{
		        this.OnLastNameChanging(value);
                this.SendPropertyChanging();
                this._LastName = value;
                this.SendPropertyChanged("LastName");
                this.OnLastNameChanged();
		    }
		}
		
        partial void OnDateofBirthChanging(DateTime? value);
        partial void OnDateofBirthChanged();
		
		private DateTime? _DateofBirth;
		public DateTime? DateofBirth { 
		    get{
		        return _DateofBirth;
		    } 
		    set{
		        this.OnDateofBirthChanging(value);
                this.SendPropertyChanging();
                this._DateofBirth = value;
                this.SendPropertyChanged("DateofBirth");
                this.OnDateofBirthChanged();
		    }
		}
		
        partial void OnGenderChanging(bool? value);
        partial void OnGenderChanged();
		
		private bool? _Gender;
		public bool? Gender { 
		    get{
		        return _Gender;
		    } 
		    set{
		        this.OnGenderChanging(value);
                this.SendPropertyChanging();
                this._Gender = value;
                this.SendPropertyChanged("Gender");
                this.OnGenderChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnStateIdChanging(int? value);
        partial void OnStateIdChanged();
		
		private int? _StateId;
		public int? StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnCityIdChanging(int? value);
        partial void OnCityIdChanged();
		
		private int? _CityId;
		public int? CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
		    }
		}
		
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
		
		private string _Address;
		public string Address { 
		    get{
		        return _Address;
		    } 
		    set{
		        this.OnAddressChanging(value);
                this.SendPropertyChanging();
                this._Address = value;
                this.SendPropertyChanged("Address");
                this.OnAddressChanged();
		    }
		}
		
        partial void OnAddressLine1Changing(string value);
        partial void OnAddressLine1Changed();
		
		private string _AddressLine1;
		public string AddressLine1 { 
		    get{
		        return _AddressLine1;
		    } 
		    set{
		        this.OnAddressLine1Changing(value);
                this.SendPropertyChanging();
                this._AddressLine1 = value;
                this.SendPropertyChanged("AddressLine1");
                this.OnAddressLine1Changed();
		    }
		}
		
        partial void OnAddressLine2Changing(string value);
        partial void OnAddressLine2Changed();
		
		private string _AddressLine2;
		public string AddressLine2 { 
		    get{
		        return _AddressLine2;
		    } 
		    set{
		        this.OnAddressLine2Changing(value);
                this.SendPropertyChanging();
                this._AddressLine2 = value;
                this.SendPropertyChanged("AddressLine2");
                this.OnAddressLine2Changed();
		    }
		}
		
        partial void OnPostalCodeChanging(string value);
        partial void OnPostalCodeChanged();
		
		private string _PostalCode;
		public string PostalCode { 
		    get{
		        return _PostalCode;
		    } 
		    set{
		        this.OnPostalCodeChanging(value);
                this.SendPropertyChanging();
                this._PostalCode = value;
                this.SendPropertyChanged("PostalCode");
                this.OnPostalCodeChanged();
		    }
		}
		
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
		
		private string _Phone;
		public string Phone { 
		    get{
		        return _Phone;
		    } 
		    set{
		        this.OnPhoneChanging(value);
                this.SendPropertyChanging();
                this._Phone = value;
                this.SendPropertyChanged("Phone");
                this.OnPhoneChanged();
		    }
		}
		
        partial void OnMobileChanging(string value);
        partial void OnMobileChanged();
		
		private string _Mobile;
		public string Mobile { 
		    get{
		        return _Mobile;
		    } 
		    set{
		        this.OnMobileChanging(value);
                this.SendPropertyChanging();
                this._Mobile = value;
                this.SendPropertyChanged("Mobile");
                this.OnMobileChanged();
		    }
		}
		
        partial void OnRelationshipIdChanging(int? value);
        partial void OnRelationshipIdChanged();
		
		private int? _RelationshipId;
		public int? RelationshipId { 
		    get{
		        return _RelationshipId;
		    } 
		    set{
		        this.OnRelationshipIdChanging(value);
                this.SendPropertyChanging();
                this._RelationshipId = value;
                this.SendPropertyChanged("RelationshipId");
                this.OnRelationshipIdChanged();
		    }
		}
		
        partial void OnParentIdChanging(int? value);
        partial void OnParentIdChanged();
		
		private int? _ParentId;
		public int? ParentId { 
		    get{
		        return _ParentId;
		    } 
		    set{
		        this.OnParentIdChanging(value);
                this.SendPropertyChanging();
                this._ParentId = value;
                this.SendPropertyChanged("ParentId");
                this.OnParentIdChanged();
		    }
		}
		
        partial void OnReferenceTokenChanging(string value);
        partial void OnReferenceTokenChanged();
		
		private string _ReferenceToken;
		public string ReferenceToken { 
		    get{
		        return _ReferenceToken;
		    } 
		    set{
		        this.OnReferenceTokenChanging(value);
                this.SendPropertyChanging();
                this._ReferenceToken = value;
                this.SendPropertyChanged("ReferenceToken");
                this.OnReferenceTokenChanged();
		    }
		}
		
        partial void OnReferedPatientIdChanging(int? value);
        partial void OnReferedPatientIdChanged();
		
		private int? _ReferedPatientId;
		public int? ReferedPatientId { 
		    get{
		        return _ReferedPatientId;
		    } 
		    set{
		        this.OnReferedPatientIdChanging(value);
                this.SendPropertyChanging();
                this._ReferedPatientId = value;
                this.SendPropertyChanged("ReferedPatientId");
                this.OnReferedPatientIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsActivatedChanging(bool? value);
        partial void OnIsActivatedChanged();
		
		private bool? _IsActivated;
		public bool? IsActivated { 
		    get{
		        return _IsActivated;
		    } 
		    set{
		        this.OnIsActivatedChanging(value);
                this.SendPropertyChanging();
                this._IsActivated = value;
                this.SendPropertyChanged("IsActivated");
                this.OnIsActivatedChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Patient_PastHistory> TBL_Patient_PastHistories
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patient_PastHistories
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Patient_PersonalHistory> TBL_Patient_PersonalHistories
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patient_PersonalHistories
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Login> TBL_Logins
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Logins
                       where items.LoginId == _LoginId
                       select items;
            }
        }

        public IQueryable<TBL_Master_City_old> TBL_Master_City_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_City_olds
                       where items.CityId == _CityId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Country_old> TBL_Master_Country_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Country_olds
                       where items.CountryId == _CountryId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Relationship> TBL_Master_Relationships
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Relationships
                       where items.RelationshipId == _RelationshipId
                       select items;
            }
        }

        public IQueryable<TBL_Master_State_old> TBL_Master_State_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_State_olds
                       where items.StateId == _StateId
                       select items;
            }
        }

        public IQueryable<TBL_Question> TBL_Questions
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Questions
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Question> TBL_Questions9
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Questions
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Reference> TBL_References
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_References
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_AccountType table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_AccountType 
    /// </summary>

	public partial class TBL_Master_AccountType: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_AccountType(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAccountTypeIdChanging(int value);
        partial void OnAccountTypeIdChanged();
		
		private int _AccountTypeId;
		public int AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnAccountTypeNameChanging(string value);
        partial void OnAccountTypeNameChanged();
		
		private string _AccountTypeName;
		public string AccountTypeName { 
		    get{
		        return _AccountTypeName;
		    } 
		    set{
		        this.OnAccountTypeNameChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeName = value;
                this.SendPropertyChanged("AccountTypeName");
                this.OnAccountTypeNameChanged();
		    }
		}
		
        partial void OnPrefixChanging(string value);
        partial void OnPrefixChanged();
		
		private string _Prefix;
		public string Prefix { 
		    get{
		        return _Prefix;
		    } 
		    set{
		        this.OnPrefixChanging(value);
                this.SendPropertyChanging();
                this._Prefix = value;
                this.SendPropertyChanged("Prefix");
                this.OnPrefixChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool value);
        partial void OnIsDeletedChanged();
		
		private bool _IsDeleted;
		public bool IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Reference table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Reference 
    /// </summary>

	public partial class TBL_Reference: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Reference(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnReferenceIdChanging(int value);
        partial void OnReferenceIdChanged();
		
		private int _ReferenceId;
		public int ReferenceId { 
		    get{
		        return _ReferenceId;
		    } 
		    set{
		        this.OnReferenceIdChanging(value);
                this.SendPropertyChanging();
                this._ReferenceId = value;
                this.SendPropertyChanged("ReferenceId");
                this.OnReferenceIdChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnReferedByChanging(int? value);
        partial void OnReferedByChanged();
		
		private int? _ReferedBy;
		public int? ReferedBy { 
		    get{
		        return _ReferedBy;
		    } 
		    set{
		        this.OnReferedByChanging(value);
                this.SendPropertyChanging();
                this._ReferedBy = value;
                this.SendPropertyChanged("ReferedBy");
                this.OnReferedByChanged();
		    }
		}
		
        partial void OnReferedToChanging(int? value);
        partial void OnReferedToChanged();
		
		private int? _ReferedTo;
		public int? ReferedTo { 
		    get{
		        return _ReferedTo;
		    } 
		    set{
		        this.OnReferedToChanging(value);
                this.SendPropertyChanging();
                this._ReferedTo = value;
                this.SendPropertyChanged("ReferedTo");
                this.OnReferedToChanged();
		    }
		}
		
        partial void OnReasonChanging(string value);
        partial void OnReasonChanged();
		
		private string _Reason;
		public string Reason { 
		    get{
		        return _Reason;
		    } 
		    set{
		        this.OnReasonChanging(value);
                this.SendPropertyChanging();
                this._Reason = value;
                this.SendPropertyChanged("Reason");
                this.OnReasonChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Doctor> TBL_Doctors
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.DoctorId == _ReferedBy
                       select items;
            }
        }

        public IQueryable<TBL_Doctor> TBL_Doctors1
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.DoctorId == _ReferedTo
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Patient_PersonalHistory table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient_PersonalHistory 
    /// </summary>

	public partial class TBL_Patient_PersonalHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient_PersonalHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnPersonalHistoryIdChanging(int? value);
        partial void OnPersonalHistoryIdChanged();
		
		private int? _PersonalHistoryId;
		public int? PersonalHistoryId { 
		    get{
		        return _PersonalHistoryId;
		    } 
		    set{
		        this.OnPersonalHistoryIdChanging(value);
                this.SendPropertyChanging();
                this._PersonalHistoryId = value;
                this.SendPropertyChanged("PersonalHistoryId");
                this.OnPersonalHistoryIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_PersonalHistory> TBL_Master_PersonalHistories
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_PersonalHistories
                       where items.PersonalHistoryId == _PersonalHistoryId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Patient_PastHistory table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient_PastHistory 
    /// </summary>

	public partial class TBL_Patient_PastHistory: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient_PastHistory(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnPastHistoryIdChanging(int? value);
        partial void OnPastHistoryIdChanged();
		
		private int? _PastHistoryId;
		public int? PastHistoryId { 
		    get{
		        return _PastHistoryId;
		    } 
		    set{
		        this.OnPastHistoryIdChanging(value);
                this.SendPropertyChanging();
                this._PastHistoryId = value;
                this.SendPropertyChanged("PastHistoryId");
                this.OnPastHistoryIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_PastHistory> TBL_Master_PastHistories
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_PastHistories
                       where items.PastHistoryId == _PastHistoryId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Department table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Department 
    /// </summary>

	public partial class TBL_Master_Department: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Department(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDepartmentIdChanging(int value);
        partial void OnDepartmentIdChanged();
		
		private int _DepartmentId;
		public int DepartmentId { 
		    get{
		        return _DepartmentId;
		    } 
		    set{
		        this.OnDepartmentIdChanging(value);
                this.SendPropertyChanging();
                this._DepartmentId = value;
                this.SendPropertyChanged("DepartmentId");
                this.OnDepartmentIdChanged();
		    }
		}
		
        partial void OnDepartmentNameChanging(string value);
        partial void OnDepartmentNameChanged();
		
		private string _DepartmentName;
		public string DepartmentName { 
		    get{
		        return _DepartmentName;
		    } 
		    set{
		        this.OnDepartmentNameChanging(value);
                this.SendPropertyChanging();
                this._DepartmentName = value;
                this.SendPropertyChanged("DepartmentName");
                this.OnDepartmentNameChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnRequestedByChanging(int? value);
        partial void OnRequestedByChanged();
		
		private int? _RequestedBy;
		public int? RequestedBy { 
		    get{
		        return _RequestedBy;
		    } 
		    set{
		        this.OnRequestedByChanging(value);
                this.SendPropertyChanging();
                this._RequestedBy = value;
                this.SendPropertyChanged("RequestedBy");
                this.OnRequestedByChanged();
		    }
		}
		
        partial void OnIsApprovedChanging(bool? value);
        partial void OnIsApprovedChanged();
		
		private bool? _IsApproved;
		public bool? IsApproved { 
		    get{
		        return _IsApproved;
		    } 
		    set{
		        this.OnIsApprovedChanging(value);
                this.SendPropertyChanging();
                this._IsApproved = value;
                this.SendPropertyChanged("IsApproved");
                this.OnIsApprovedChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(int? value);
        partial void OnIsDeletedChanged();
		
		private int? _IsDeleted;
		public int? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Doctor> TBL_Doctors
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.DepartmentId == _DepartmentId
                       select items;
            }
        }

        public IQueryable<TBL_Service> TBL_Services
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Services
                       where items.DepartmentId == _DepartmentId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_City_old table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_City_old 
    /// </summary>

	public partial class TBL_Master_City_old: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_City_old(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCityIdChanging(int value);
        partial void OnCityIdChanged();
		
		private int _CityId;
		public int CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
		    }
		}
		
        partial void OnCityNameChanging(string value);
        partial void OnCityNameChanged();
		
		private string _CityName;
		public string CityName { 
		    get{
		        return _CityName;
		    } 
		    set{
		        this.OnCityNameChanging(value);
                this.SendPropertyChanging();
                this._CityName = value;
                this.SendPropertyChanged("CityName");
                this.OnCityNameChanged();
		    }
		}
		
        partial void OnStateIdChanging(int? value);
        partial void OnStateIdChanged();
		
		private int? _StateId;
		public int? StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
		
		private string _LocationId;
		public string LocationId { 
		    get{
		        return _LocationId;
		    } 
		    set{
		        this.OnLocationIdChanging(value);
                this.SendPropertyChanging();
                this._LocationId = value;
                this.SendPropertyChanged("LocationId");
                this.OnLocationIdChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_State_old> TBL_Master_State_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_State_olds
                       where items.StateId == _StateId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.CityId == _CityId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_State_old table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_State_old 
    /// </summary>

	public partial class TBL_Master_State_old: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_State_old(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnStateIdChanging(int value);
        partial void OnStateIdChanged();
		
		private int _StateId;
		public int StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnStateNameChanging(string value);
        partial void OnStateNameChanged();
		
		private string _StateName;
		public string StateName { 
		    get{
		        return _StateName;
		    } 
		    set{
		        this.OnStateNameChanging(value);
                this.SendPropertyChanging();
                this._StateName = value;
                this.SendPropertyChanged("StateName");
                this.OnStateNameChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnStateCodeChanging(string value);
        partial void OnStateCodeChanged();
		
		private string _StateCode;
		public string StateCode { 
		    get{
		        return _StateCode;
		    } 
		    set{
		        this.OnStateCodeChanging(value);
                this.SendPropertyChanging();
                this._StateCode = value;
                this.SendPropertyChanged("StateCode");
                this.OnStateCodeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_City_old> TBL_Master_City_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_City_olds
                       where items.StateId == _StateId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Country_old> TBL_Master_Country_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Country_olds
                       where items.CountryId == _CountryId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.StateId == _StateId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_GeoPostcodes table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_GeoPostcode 
    /// </summary>

	public partial class TBL_GeoPostcode: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_GeoPostcode(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
		
		private string _Country;
		public string Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
		
		private string _Language;
		public string Language { 
		    get{
		        return _Language;
		    } 
		    set{
		        this.OnLanguageChanging(value);
                this.SendPropertyChanging();
                this._Language = value;
                this.SendPropertyChanged("Language");
                this.OnLanguageChanged();
		    }
		}
		
        partial void OnIDChanging(long value);
        partial void OnIDChanged();
		
		private long _ID;
		public long ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnRegISO2Changing(string value);
        partial void OnRegISO2Changed();
		
		private string _RegISO2;
		public string RegISO2 { 
		    get{
		        return _RegISO2;
		    } 
		    set{
		        this.OnRegISO2Changing(value);
                this.SendPropertyChanging();
                this._RegISO2 = value;
                this.SendPropertyChanged("RegISO2");
                this.OnRegISO2Changed();
		    }
		}
		
        partial void OnRegion1Changing(string value);
        partial void OnRegion1Changed();
		
		private string _Region1;
		public string Region1 { 
		    get{
		        return _Region1;
		    } 
		    set{
		        this.OnRegion1Changing(value);
                this.SendPropertyChanging();
                this._Region1 = value;
                this.SendPropertyChanged("Region1");
                this.OnRegion1Changed();
		    }
		}
		
        partial void OnRegion2Changing(string value);
        partial void OnRegion2Changed();
		
		private string _Region2;
		public string Region2 { 
		    get{
		        return _Region2;
		    } 
		    set{
		        this.OnRegion2Changing(value);
                this.SendPropertyChanging();
                this._Region2 = value;
                this.SendPropertyChanged("Region2");
                this.OnRegion2Changed();
		    }
		}
		
        partial void OnRegion3Changing(string value);
        partial void OnRegion3Changed();
		
		private string _Region3;
		public string Region3 { 
		    get{
		        return _Region3;
		    } 
		    set{
		        this.OnRegion3Changing(value);
                this.SendPropertyChanging();
                this._Region3 = value;
                this.SendPropertyChanged("Region3");
                this.OnRegion3Changed();
		    }
		}
		
        partial void OnRegion4Changing(string value);
        partial void OnRegion4Changed();
		
		private string _Region4;
		public string Region4 { 
		    get{
		        return _Region4;
		    } 
		    set{
		        this.OnRegion4Changing(value);
                this.SendPropertyChanging();
                this._Region4 = value;
                this.SendPropertyChanged("Region4");
                this.OnRegion4Changed();
		    }
		}
		
        partial void OnZIPChanging(string value);
        partial void OnZIPChanged();
		
		private string _ZIP;
		public string ZIP { 
		    get{
		        return _ZIP;
		    } 
		    set{
		        this.OnZIPChanging(value);
                this.SendPropertyChanging();
                this._ZIP = value;
                this.SendPropertyChanged("ZIP");
                this.OnZIPChanged();
		    }
		}
		
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
		
		private string _City;
		public string City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnArea1Changing(string value);
        partial void OnArea1Changed();
		
		private string _Area1;
		public string Area1 { 
		    get{
		        return _Area1;
		    } 
		    set{
		        this.OnArea1Changing(value);
                this.SendPropertyChanging();
                this._Area1 = value;
                this.SendPropertyChanged("Area1");
                this.OnArea1Changed();
		    }
		}
		
        partial void OnArea2Changing(string value);
        partial void OnArea2Changed();
		
		private string _Area2;
		public string Area2 { 
		    get{
		        return _Area2;
		    } 
		    set{
		        this.OnArea2Changing(value);
                this.SendPropertyChanging();
                this._Area2 = value;
                this.SendPropertyChanged("Area2");
                this.OnArea2Changed();
		    }
		}
		
        partial void OnLatChanging(double? value);
        partial void OnLatChanged();
		
		private double? _Lat;
		public double? Lat { 
		    get{
		        return _Lat;
		    } 
		    set{
		        this.OnLatChanging(value);
                this.SendPropertyChanging();
                this._Lat = value;
                this.SendPropertyChanged("Lat");
                this.OnLatChanged();
		    }
		}
		
        partial void OnLngChanging(double? value);
        partial void OnLngChanged();
		
		private double? _Lng;
		public double? Lng { 
		    get{
		        return _Lng;
		    } 
		    set{
		        this.OnLngChanging(value);
                this.SendPropertyChanging();
                this._Lng = value;
                this.SendPropertyChanged("Lng");
                this.OnLngChanged();
		    }
		}
		
        partial void OnTZChanging(string value);
        partial void OnTZChanged();
		
		private string _TZ;
		public string TZ { 
		    get{
		        return _TZ;
		    } 
		    set{
		        this.OnTZChanging(value);
                this.SendPropertyChanging();
                this._TZ = value;
                this.SendPropertyChanged("TZ");
                this.OnTZChanged();
		    }
		}
		
        partial void OnUTCChanging(string value);
        partial void OnUTCChanged();
		
		private string _UTC;
		public string UTC { 
		    get{
		        return _UTC;
		    } 
		    set{
		        this.OnUTCChanging(value);
                this.SendPropertyChanging();
                this._UTC = value;
                this.SendPropertyChanged("UTC");
                this.OnUTCChanged();
		    }
		}
		
        partial void OnDSTChanging(string value);
        partial void OnDSTChanged();
		
		private string _DST;
		public string DST { 
		    get{
		        return _DST;
		    } 
		    set{
		        this.OnDSTChanging(value);
                this.SendPropertyChanging();
                this._DST = value;
                this.SendPropertyChanged("DST");
                this.OnDSTChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Country_old table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Country_old 
    /// </summary>

	public partial class TBL_Master_Country_old: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Country_old(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCountryIdChanging(int value);
        partial void OnCountryIdChanged();
		
		private int _CountryId;
		public int CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnCountryNameChanging(string value);
        partial void OnCountryNameChanged();
		
		private string _CountryName;
		public string CountryName { 
		    get{
		        return _CountryName;
		    } 
		    set{
		        this.OnCountryNameChanging(value);
                this.SendPropertyChanging();
                this._CountryName = value;
                this.SendPropertyChanged("CountryName");
                this.OnCountryNameChanged();
		    }
		}
		
        partial void OnCountryCodeChanging(string value);
        partial void OnCountryCodeChanged();
		
		private string _CountryCode;
		public string CountryCode { 
		    get{
		        return _CountryCode;
		    } 
		    set{
		        this.OnCountryCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryCode = value;
                this.SendPropertyChanged("CountryCode");
                this.OnCountryCodeChanged();
		    }
		}
		
        partial void OnInternationalCodeChanging(int? value);
        partial void OnInternationalCodeChanged();
		
		private int? _InternationalCode;
		public int? InternationalCode { 
		    get{
		        return _InternationalCode;
		    } 
		    set{
		        this.OnInternationalCodeChanging(value);
                this.SendPropertyChanging();
                this._InternationalCode = value;
                this.SendPropertyChanged("InternationalCode");
                this.OnInternationalCodeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Master_State_old> TBL_Master_State_olds
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_State_olds
                       where items.CountryId == _CountryId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.CountryId == _CountryId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Mapping_Status table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Mapping_Status 
    /// </summary>

	public partial class TBL_Mapping_Status: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Mapping_Status(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnTypeChanging(int? value);
        partial void OnTypeChanged();
		
		private int? _Type;
		public int? Type { 
		    get{
		        return _Type;
		    } 
		    set{
		        this.OnTypeChanging(value);
                this.SendPropertyChanging();
                this._Type = value;
                this.SendPropertyChanged("Type");
                this.OnTypeChanged();
		    }
		}
		
        partial void OnStatusIdChanging(int? value);
        partial void OnStatusIdChanged();
		
		private int? _StatusId;
		public int? StatusId { 
		    get{
		        return _StatusId;
		    } 
		    set{
		        this.OnStatusIdChanging(value);
                this.SendPropertyChanging();
                this._StatusId = value;
                this.SendPropertyChanged("StatusId");
                this.OnStatusIdChanged();
		    }
		}
		
        partial void OnParentStatusIdChanging(int? value);
        partial void OnParentStatusIdChanged();
		
		private int? _ParentStatusId;
		public int? ParentStatusId { 
		    get{
		        return _ParentStatusId;
		    } 
		    set{
		        this.OnParentStatusIdChanging(value);
                this.SendPropertyChanging();
                this._ParentStatusId = value;
                this.SendPropertyChanged("ParentStatusId");
                this.OnParentStatusIdChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_GeoPostcodes_Country table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_GeoPostcodes_Country 
    /// </summary>

	public partial class TBL_GeoPostcodes_Country: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_GeoPostcodes_Country(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCountryIdChanging(int value);
        partial void OnCountryIdChanged();
		
		private int _CountryId;
		public int CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnCountryCodeChanging(string value);
        partial void OnCountryCodeChanged();
		
		private string _CountryCode;
		public string CountryCode { 
		    get{
		        return _CountryCode;
		    } 
		    set{
		        this.OnCountryCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryCode = value;
                this.SendPropertyChanged("CountryCode");
                this.OnCountryCodeChanged();
		    }
		}
		
        partial void OnCountryNameChanging(string value);
        partial void OnCountryNameChanged();
		
		private string _CountryName;
		public string CountryName { 
		    get{
		        return _CountryName;
		    } 
		    set{
		        this.OnCountryNameChanging(value);
                this.SendPropertyChanging();
                this._CountryName = value;
                this.SendPropertyChanged("CountryName");
                this.OnCountryNameChanged();
		    }
		}
		
        partial void OnInternationalCodeChanging(int? value);
        partial void OnInternationalCodeChanged();
		
		private int? _InternationalCode;
		public int? InternationalCode { 
		    get{
		        return _InternationalCode;
		    } 
		    set{
		        this.OnInternationalCodeChanging(value);
                this.SendPropertyChanging();
                this._InternationalCode = value;
                this.SendPropertyChanged("InternationalCode");
                this.OnInternationalCodeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Mapping_Bed table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Mapping_Bed 
    /// </summary>

	public partial class TBL_Mapping_Bed: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Mapping_Bed(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnAppointmentIdChanging(int? value);
        partial void OnAppointmentIdChanged();
		
		private int? _AppointmentId;
		public int? AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnActionIdChanging(int? value);
        partial void OnActionIdChanged();
		
		private int? _ActionId;
		public int? ActionId { 
		    get{
		        return _ActionId;
		    } 
		    set{
		        this.OnActionIdChanging(value);
                this.SendPropertyChanging();
                this._ActionId = value;
                this.SendPropertyChanged("ActionId");
                this.OnActionIdChanged();
		    }
		}
		
        partial void OnBedIdChanging(int? value);
        partial void OnBedIdChanged();
		
		private int? _BedId;
		public int? BedId { 
		    get{
		        return _BedId;
		    } 
		    set{
		        this.OnBedIdChanging(value);
                this.SendPropertyChanging();
                this._BedId = value;
                this.SendPropertyChanged("BedId");
                this.OnBedIdChanged();
		    }
		}
		
        partial void OnStatusIdChanging(int? value);
        partial void OnStatusIdChanged();
		
		private int? _StatusId;
		public int? StatusId { 
		    get{
		        return _StatusId;
		    } 
		    set{
		        this.OnStatusIdChanging(value);
                this.SendPropertyChanging();
                this._StatusId = value;
                this.SendPropertyChanged("StatusId");
                this.OnStatusIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnEventTimeChanging(DateTime? value);
        partial void OnEventTimeChanged();
		
		private DateTime? _EventTime;
		public DateTime? EventTime { 
		    get{
		        return _EventTime;
		    } 
		    set{
		        this.OnEventTimeChanging(value);
                this.SendPropertyChanging();
                this._EventTime = value;
                this.SendPropertyChanged("EventTime");
                this.OnEventTimeChanged();
		    }
		}
		
        partial void OnIsTransferChanging(bool? value);
        partial void OnIsTransferChanged();
		
		private bool? _IsTransfer;
		public bool? IsTransfer { 
		    get{
		        return _IsTransfer;
		    } 
		    set{
		        this.OnIsTransferChanging(value);
                this.SendPropertyChanging();
                this._IsTransfer = value;
                this.SendPropertyChanged("IsTransfer");
                this.OnIsTransferChanged();
		    }
		}
		
        partial void OnActionTypeIdChanging(int? value);
        partial void OnActionTypeIdChanged();
		
		private int? _ActionTypeId;
		public int? ActionTypeId { 
		    get{
		        return _ActionTypeId;
		    } 
		    set{
		        this.OnActionTypeIdChanging(value);
                this.SendPropertyChanging();
                this._ActionTypeId = value;
                this.SendPropertyChanged("ActionTypeId");
                this.OnActionTypeIdChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Doctor_Timing table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Doctor_Timing 
    /// </summary>

	public partial class TBL_Doctor_Timing: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Doctor_Timing(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDoctorTimingIdChanging(int value);
        partial void OnDoctorTimingIdChanged();
		
		private int _DoctorTimingId;
		public int DoctorTimingId { 
		    get{
		        return _DoctorTimingId;
		    } 
		    set{
		        this.OnDoctorTimingIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorTimingId = value;
                this.SendPropertyChanged("DoctorTimingId");
                this.OnDoctorTimingIdChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnScheduleNameChanging(string value);
        partial void OnScheduleNameChanged();
		
		private string _ScheduleName;
		public string ScheduleName { 
		    get{
		        return _ScheduleName;
		    } 
		    set{
		        this.OnScheduleNameChanging(value);
                this.SendPropertyChanging();
                this._ScheduleName = value;
                this.SendPropertyChanged("ScheduleName");
                this.OnScheduleNameChanged();
		    }
		}
		
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
		
		private string _Address;
		public string Address { 
		    get{
		        return _Address;
		    } 
		    set{
		        this.OnAddressChanging(value);
                this.SendPropertyChanging();
                this._Address = value;
                this.SendPropertyChanged("Address");
                this.OnAddressChanged();
		    }
		}
		
        partial void OnSundayChanging(bool? value);
        partial void OnSundayChanged();
		
		private bool? _Sunday;
		public bool? Sunday { 
		    get{
		        return _Sunday;
		    } 
		    set{
		        this.OnSundayChanging(value);
                this.SendPropertyChanging();
                this._Sunday = value;
                this.SendPropertyChanged("Sunday");
                this.OnSundayChanged();
		    }
		}
		
        partial void OnMondayChanging(bool? value);
        partial void OnMondayChanged();
		
		private bool? _Monday;
		public bool? Monday { 
		    get{
		        return _Monday;
		    } 
		    set{
		        this.OnMondayChanging(value);
                this.SendPropertyChanging();
                this._Monday = value;
                this.SendPropertyChanged("Monday");
                this.OnMondayChanged();
		    }
		}
		
        partial void OnTuesdayChanging(bool? value);
        partial void OnTuesdayChanged();
		
		private bool? _Tuesday;
		public bool? Tuesday { 
		    get{
		        return _Tuesday;
		    } 
		    set{
		        this.OnTuesdayChanging(value);
                this.SendPropertyChanging();
                this._Tuesday = value;
                this.SendPropertyChanged("Tuesday");
                this.OnTuesdayChanged();
		    }
		}
		
        partial void OnWednesdayChanging(bool? value);
        partial void OnWednesdayChanged();
		
		private bool? _Wednesday;
		public bool? Wednesday { 
		    get{
		        return _Wednesday;
		    } 
		    set{
		        this.OnWednesdayChanging(value);
                this.SendPropertyChanging();
                this._Wednesday = value;
                this.SendPropertyChanged("Wednesday");
                this.OnWednesdayChanged();
		    }
		}
		
        partial void OnThursdayChanging(bool? value);
        partial void OnThursdayChanged();
		
		private bool? _Thursday;
		public bool? Thursday { 
		    get{
		        return _Thursday;
		    } 
		    set{
		        this.OnThursdayChanging(value);
                this.SendPropertyChanging();
                this._Thursday = value;
                this.SendPropertyChanged("Thursday");
                this.OnThursdayChanged();
		    }
		}
		
        partial void OnFridayChanging(bool? value);
        partial void OnFridayChanged();
		
		private bool? _Friday;
		public bool? Friday { 
		    get{
		        return _Friday;
		    } 
		    set{
		        this.OnFridayChanging(value);
                this.SendPropertyChanging();
                this._Friday = value;
                this.SendPropertyChanged("Friday");
                this.OnFridayChanged();
		    }
		}
		
        partial void OnSaturdayChanging(bool? value);
        partial void OnSaturdayChanged();
		
		private bool? _Saturday;
		public bool? Saturday { 
		    get{
		        return _Saturday;
		    } 
		    set{
		        this.OnSaturdayChanging(value);
                this.SendPropertyChanging();
                this._Saturday = value;
                this.SendPropertyChanged("Saturday");
                this.OnSaturdayChanged();
		    }
		}
		
        partial void OnStartTimeChanging(string value);
        partial void OnStartTimeChanged();
		
		private string _StartTime;
		public string StartTime { 
		    get{
		        return _StartTime;
		    } 
		    set{
		        this.OnStartTimeChanging(value);
                this.SendPropertyChanging();
                this._StartTime = value;
                this.SendPropertyChanged("StartTime");
                this.OnStartTimeChanged();
		    }
		}
		
        partial void OnEndTimeChanging(string value);
        partial void OnEndTimeChanged();
		
		private string _EndTime;
		public string EndTime { 
		    get{
		        return _EndTime;
		    } 
		    set{
		        this.OnEndTimeChanging(value);
                this.SendPropertyChanging();
                this._EndTime = value;
                this.SendPropertyChanged("EndTime");
                this.OnEndTimeChanged();
		    }
		}
		
        partial void OnPatientDurationChanging(int? value);
        partial void OnPatientDurationChanged();
		
		private int? _PatientDuration;
		public int? PatientDuration { 
		    get{
		        return _PatientDuration;
		    } 
		    set{
		        this.OnPatientDurationChanging(value);
                this.SendPropertyChanging();
                this._PatientDuration = value;
                this.SendPropertyChanged("PatientDuration");
                this.OnPatientDurationChanged();
		    }
		}
		
        partial void OnIsApprovalSystemChanging(bool? value);
        partial void OnIsApprovalSystemChanged();
		
		private bool? _IsApprovalSystem;
		public bool? IsApprovalSystem { 
		    get{
		        return _IsApprovalSystem;
		    } 
		    set{
		        this.OnIsApprovalSystemChanging(value);
                this.SendPropertyChanging();
                this._IsApprovalSystem = value;
                this.SendPropertyChanged("IsApprovalSystem");
                this.OnIsApprovalSystemChanged();
		    }
		}
		
        partial void OnIsApprovalNotificationSMSChanging(bool? value);
        partial void OnIsApprovalNotificationSMSChanged();
		
		private bool? _IsApprovalNotificationSMS;
		public bool? IsApprovalNotificationSMS { 
		    get{
		        return _IsApprovalNotificationSMS;
		    } 
		    set{
		        this.OnIsApprovalNotificationSMSChanging(value);
                this.SendPropertyChanging();
                this._IsApprovalNotificationSMS = value;
                this.SendPropertyChanged("IsApprovalNotificationSMS");
                this.OnIsApprovalNotificationSMSChanged();
		    }
		}
		
        partial void OnIsApprovalNotificationEmailChanging(bool? value);
        partial void OnIsApprovalNotificationEmailChanged();
		
		private bool? _IsApprovalNotificationEmail;
		public bool? IsApprovalNotificationEmail { 
		    get{
		        return _IsApprovalNotificationEmail;
		    } 
		    set{
		        this.OnIsApprovalNotificationEmailChanging(value);
                this.SendPropertyChanging();
                this._IsApprovalNotificationEmail = value;
                this.SendPropertyChanged("IsApprovalNotificationEmail");
                this.OnIsApprovalNotificationEmailChanged();
		    }
		}
		
        partial void OnMaxAppointmentDaysChanging(int? value);
        partial void OnMaxAppointmentDaysChanged();
		
		private int? _MaxAppointmentDays;
		public int? MaxAppointmentDays { 
		    get{
		        return _MaxAppointmentDays;
		    } 
		    set{
		        this.OnMaxAppointmentDaysChanging(value);
                this.SendPropertyChanging();
                this._MaxAppointmentDays = value;
                this.SendPropertyChanged("MaxAppointmentDays");
                this.OnMaxAppointmentDaysChanged();
		    }
		}
		
        partial void OnIsDefaultAddressChanging(bool? value);
        partial void OnIsDefaultAddressChanged();
		
		private bool? _IsDefaultAddress;
		public bool? IsDefaultAddress { 
		    get{
		        return _IsDefaultAddress;
		    } 
		    set{
		        this.OnIsDefaultAddressChanging(value);
                this.SendPropertyChanging();
                this._IsDefaultAddress = value;
                this.SendPropertyChanged("IsDefaultAddress");
                this.OnIsDefaultAddressChanged();
		    }
		}
		
        partial void OnIsCarParkFacilityChanging(bool? value);
        partial void OnIsCarParkFacilityChanged();
		
		private bool? _IsCarParkFacility;
		public bool? IsCarParkFacility { 
		    get{
		        return _IsCarParkFacility;
		    } 
		    set{
		        this.OnIsCarParkFacilityChanging(value);
                this.SendPropertyChanging();
                this._IsCarParkFacility = value;
                this.SendPropertyChanged("IsCarParkFacility");
                this.OnIsCarParkFacilityChanged();
		    }
		}
		
        partial void OnIsFCFSChanging(bool? value);
        partial void OnIsFCFSChanged();
		
		private bool? _IsFCFS;
		public bool? IsFCFS { 
		    get{
		        return _IsFCFS;
		    } 
		    set{
		        this.OnIsFCFSChanging(value);
                this.SendPropertyChanging();
                this._IsFCFS = value;
                this.SendPropertyChanged("IsFCFS");
                this.OnIsFCFSChanged();
		    }
		}
		
        partial void OnMaxAppsChanging(int? value);
        partial void OnMaxAppsChanged();
		
		private int? _MaxApps;
		public int? MaxApps { 
		    get{
		        return _MaxApps;
		    } 
		    set{
		        this.OnMaxAppsChanging(value);
                this.SendPropertyChanging();
                this._MaxApps = value;
                this.SendPropertyChanged("MaxApps");
                this.OnMaxAppsChanged();
		    }
		}
		
        partial void OnAppointmentTypeChanging(int? value);
        partial void OnAppointmentTypeChanged();
		
		private int? _AppointmentType;
		public int? AppointmentType { 
		    get{
		        return _AppointmentType;
		    } 
		    set{
		        this.OnAppointmentTypeChanging(value);
                this.SendPropertyChanging();
                this._AppointmentType = value;
                this.SendPropertyChanged("AppointmentType");
                this.OnAppointmentTypeChanged();
		    }
		}
		
        partial void OnConditionsChanging(string value);
        partial void OnConditionsChanged();
		
		private string _Conditions;
		public string Conditions { 
		    get{
		        return _Conditions;
		    } 
		    set{
		        this.OnConditionsChanging(value);
                this.SendPropertyChanging();
                this._Conditions = value;
                this.SendPropertyChanged("Conditions");
                this.OnConditionsChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_BlockCalendar> TBL_BlockCalendars
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_BlockCalendars
                       where items.DoctorTimingId == _DoctorTimingId
                       select items;
            }
        }

        public IQueryable<TBL_Doctor> TBL_Doctors
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.DoctorId == _DoctorId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the sysdiagrams table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.sysdiagram 
    /// </summary>

	public partial class sysdiagram: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public sysdiagram(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
		
		private string _name;
		public string name { 
		    get{
		        return _name;
		    } 
		    set{
		        this.OnnameChanging(value);
                this.SendPropertyChanging();
                this._name = value;
                this.SendPropertyChanged("name");
                this.OnnameChanged();
		    }
		}
		
        partial void Onprincipal_idChanging(int value);
        partial void Onprincipal_idChanged();
		
		private int _principal_id;
		public int principal_id { 
		    get{
		        return _principal_id;
		    } 
		    set{
		        this.Onprincipal_idChanging(value);
                this.SendPropertyChanging();
                this._principal_id = value;
                this.SendPropertyChanged("principal_id");
                this.Onprincipal_idChanged();
		    }
		}
		
        partial void Ondiagram_idChanging(int value);
        partial void Ondiagram_idChanged();
		
		private int _diagram_id;
		public int diagram_id { 
		    get{
		        return _diagram_id;
		    } 
		    set{
		        this.Ondiagram_idChanging(value);
                this.SendPropertyChanging();
                this._diagram_id = value;
                this.SendPropertyChanged("diagram_id");
                this.Ondiagram_idChanged();
		    }
		}
		
        partial void OnversionChanging(int? value);
        partial void OnversionChanged();
		
		private int? _version;
		public int? version { 
		    get{
		        return _version;
		    } 
		    set{
		        this.OnversionChanging(value);
                this.SendPropertyChanging();
                this._version = value;
                this.SendPropertyChanged("version");
                this.OnversionChanged();
		    }
		}
		
        partial void OndefinitionChanging(byte[] value);
        partial void OndefinitionChanged();
		
		private byte[] _definition;
		public byte[] definition { 
		    get{
		        return _definition;
		    } 
		    set{
		        this.OndefinitionChanging(value);
                this.SendPropertyChanging();
                this._definition = value;
                this.SendPropertyChanged("definition");
                this.OndefinitionChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Tbl_Temp_State table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.Tbl_Temp_State 
    /// </summary>

	public partial class Tbl_Temp_State: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Tbl_Temp_State(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnStateUnionTerritoryChanging(string value);
        partial void OnStateUnionTerritoryChanged();
		
		private string _StateUnionTerritory;
		public string StateUnionTerritory { 
		    get{
		        return _StateUnionTerritory;
		    } 
		    set{
		        this.OnStateUnionTerritoryChanging(value);
                this.SendPropertyChanging();
                this._StateUnionTerritory = value;
                this.SendPropertyChanged("StateUnionTerritory");
                this.OnStateUnionTerritoryChanged();
		    }
		}
		
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
		
		private string _City;
		public string City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_GeoPostcodes_State table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_GeoPostcodes_State 
    /// </summary>

	public partial class TBL_GeoPostcodes_State: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_GeoPostcodes_State(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnStateIdChanging(int value);
        partial void OnStateIdChanged();
		
		private int _StateId;
		public int StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnStateNameChanging(string value);
        partial void OnStateNameChanged();
		
		private string _StateName;
		public string StateName { 
		    get{
		        return _StateName;
		    } 
		    set{
		        this.OnStateNameChanging(value);
                this.SendPropertyChanging();
                this._StateName = value;
                this.SendPropertyChanged("StateName");
                this.OnStateNameChanged();
		    }
		}
		
        partial void OnStateCodeChanging(string value);
        partial void OnStateCodeChanged();
		
		private string _StateCode;
		public string StateCode { 
		    get{
		        return _StateCode;
		    } 
		    set{
		        this.OnStateCodeChanging(value);
                this.SendPropertyChanging();
                this._StateCode = value;
                this.SendPropertyChanged("StateCode");
                this.OnStateCodeChanged();
		    }
		}
		
        partial void OnCountryCodeChanging(string value);
        partial void OnCountryCodeChanged();
		
		private string _CountryCode;
		public string CountryCode { 
		    get{
		        return _CountryCode;
		    } 
		    set{
		        this.OnCountryCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryCode = value;
                this.SendPropertyChanged("CountryCode");
                this.OnCountryCodeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_SubAdminLogin table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_SubAdminLogin 
    /// </summary>

	public partial class TBL_Job_SubAdminLogin: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_SubAdminLogin(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSidChanging(int value);
        partial void OnSidChanged();
		
		private int _Sid;
		public int Sid { 
		    get{
		        return _Sid;
		    } 
		    set{
		        this.OnSidChanging(value);
                this.SendPropertyChanging();
                this._Sid = value;
                this.SendPropertyChanged("Sid");
                this.OnSidChanged();
		    }
		}
		
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
		
		private string _UserName;
		public string UserName { 
		    get{
		        return _UserName;
		    } 
		    set{
		        this.OnUserNameChanging(value);
                this.SendPropertyChanging();
                this._UserName = value;
                this.SendPropertyChanged("UserName");
                this.OnUserNameChanged();
		    }
		}
		
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
		
		private string _Password;
		public string Password { 
		    get{
		        return _Password;
		    } 
		    set{
		        this.OnPasswordChanging(value);
                this.SendPropertyChanging();
                this._Password = value;
                this.SendPropertyChanged("Password");
                this.OnPasswordChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Patient_UHID table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Patient_UHID 
    /// </summary>

	public partial class TBL_Patient_UHID: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Patient_UHID(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnUHIDChanging(string value);
        partial void OnUHIDChanged();
		
		private string _UHID;
		public string UHID { 
		    get{
		        return _UHID;
		    } 
		    set{
		        this.OnUHIDChanging(value);
                this.SendPropertyChanging();
                this._UHID = value;
                this.SendPropertyChanged("UHID");
                this.OnUHIDChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_GeoPostcodes_City table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_GeoPostcodes_City 
    /// </summary>

	public partial class TBL_GeoPostcodes_City: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_GeoPostcodes_City(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnCityIdChanging(int value);
        partial void OnCityIdChanged();
		
		private int _CityId;
		public int CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
		    }
		}
		
        partial void OnCityNameChanging(string value);
        partial void OnCityNameChanged();
		
		private string _CityName;
		public string CityName { 
		    get{
		        return _CityName;
		    } 
		    set{
		        this.OnCityNameChanging(value);
                this.SendPropertyChanging();
                this._CityName = value;
                this.SendPropertyChanged("CityName");
                this.OnCityNameChanged();
		    }
		}
		
        partial void OnStateCodeChanging(string value);
        partial void OnStateCodeChanged();
		
		private string _StateCode;
		public string StateCode { 
		    get{
		        return _StateCode;
		    } 
		    set{
		        this.OnStateCodeChanging(value);
                this.SendPropertyChanging();
                this._StateCode = value;
                this.SendPropertyChanged("StateCode");
                this.OnStateCodeChanged();
		    }
		}
		
        partial void OnCountryCodeChanging(string value);
        partial void OnCountryCodeChanged();
		
		private string _CountryCode;
		public string CountryCode { 
		    get{
		        return _CountryCode;
		    } 
		    set{
		        this.OnCountryCodeChanging(value);
                this.SendPropertyChanging();
                this._CountryCode = value;
                this.SendPropertyChanged("CountryCode");
                this.OnCountryCodeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_Speciality table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_Speciality 
    /// </summary>

	public partial class TBL_Job_Speciality: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_Speciality(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSpcIdChanging(int value);
        partial void OnSpcIdChanged();
		
		private int _SpcId;
		public int SpcId { 
		    get{
		        return _SpcId;
		    } 
		    set{
		        this.OnSpcIdChanging(value);
                this.SendPropertyChanging();
                this._SpcId = value;
                this.SendPropertyChanged("SpcId");
                this.OnSpcIdChanged();
		    }
		}
		
        partial void OnSpecialityIdChanging(int? value);
        partial void OnSpecialityIdChanged();
		
		private int? _SpecialityId;
		public int? SpecialityId { 
		    get{
		        return _SpecialityId;
		    } 
		    set{
		        this.OnSpecialityIdChanging(value);
                this.SendPropertyChanging();
                this._SpecialityId = value;
                this.SendPropertyChanged("SpecialityId");
                this.OnSpecialityIdChanged();
		    }
		}
		
        partial void OnVisibilityChanging(bool? value);
        partial void OnVisibilityChanged();
		
		private bool? _Visibility;
		public bool? Visibility { 
		    get{
		        return _Visibility;
		    } 
		    set{
		        this.OnVisibilityChanging(value);
                this.SendPropertyChanging();
                this._Visibility = value;
                this.SendPropertyChanged("Visibility");
                this.OnVisibilityChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Landing_MainTab table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Landing_MainTab 
    /// </summary>

	public partial class TBL_Landing_MainTab: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Landing_MainTab(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnMainTabIdChanging(int value);
        partial void OnMainTabIdChanged();
		
		private int _MainTabId;
		public int MainTabId { 
		    get{
		        return _MainTabId;
		    } 
		    set{
		        this.OnMainTabIdChanging(value);
                this.SendPropertyChanging();
                this._MainTabId = value;
                this.SendPropertyChanged("MainTabId");
                this.OnMainTabIdChanged();
		    }
		}
		
        partial void OnMainTabNameChanging(string value);
        partial void OnMainTabNameChanged();
		
		private string _MainTabName;
		public string MainTabName { 
		    get{
		        return _MainTabName;
		    } 
		    set{
		        this.OnMainTabNameChanging(value);
                this.SendPropertyChanging();
                this._MainTabName = value;
                this.SendPropertyChanged("MainTabName");
                this.OnMainTabNameChanged();
		    }
		}
		
        partial void OnMainTabContentChanging(string value);
        partial void OnMainTabContentChanged();
		
		private string _MainTabContent;
		public string MainTabContent { 
		    get{
		        return _MainTabContent;
		    } 
		    set{
		        this.OnMainTabContentChanging(value);
                this.SendPropertyChanging();
                this._MainTabContent = value;
                this.SendPropertyChanged("MainTabContent");
                this.OnMainTabContentChanged();
		    }
		}
		
        partial void OnLandingIdChanging(int? value);
        partial void OnLandingIdChanged();
		
		private int? _LandingId;
		public int? LandingId { 
		    get{
		        return _LandingId;
		    } 
		    set{
		        this.OnLandingIdChanging(value);
                this.SendPropertyChanging();
                this._LandingId = value;
                this.SendPropertyChanged("LandingId");
                this.OnLandingIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_BlockCalendar table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_BlockCalendar 
    /// </summary>

	public partial class TBL_BlockCalendar: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_BlockCalendar(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnBlockIdChanging(int value);
        partial void OnBlockIdChanged();
		
		private int _BlockId;
		public int BlockId { 
		    get{
		        return _BlockId;
		    } 
		    set{
		        this.OnBlockIdChanging(value);
                this.SendPropertyChanging();
                this._BlockId = value;
                this.SendPropertyChanged("BlockId");
                this.OnBlockIdChanged();
		    }
		}
		
        partial void OnBlockTypeIdChanging(int? value);
        partial void OnBlockTypeIdChanged();
		
		private int? _BlockTypeId;
		public int? BlockTypeId { 
		    get{
		        return _BlockTypeId;
		    } 
		    set{
		        this.OnBlockTypeIdChanging(value);
                this.SendPropertyChanging();
                this._BlockTypeId = value;
                this.SendPropertyChanged("BlockTypeId");
                this.OnBlockTypeIdChanged();
		    }
		}
		
        partial void OnTypeChanging(bool? value);
        partial void OnTypeChanged();
		
		private bool? _Type;
		public bool? Type { 
		    get{
		        return _Type;
		    } 
		    set{
		        this.OnTypeChanging(value);
                this.SendPropertyChanging();
                this._Type = value;
                this.SendPropertyChanged("Type");
                this.OnTypeChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnServiceIdChanging(int? value);
        partial void OnServiceIdChanged();
		
		private int? _ServiceId;
		public int? ServiceId { 
		    get{
		        return _ServiceId;
		    } 
		    set{
		        this.OnServiceIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceId = value;
                this.SendPropertyChanged("ServiceId");
                this.OnServiceIdChanged();
		    }
		}
		
        partial void OnDoctorTimingIdChanging(int? value);
        partial void OnDoctorTimingIdChanged();
		
		private int? _DoctorTimingId;
		public int? DoctorTimingId { 
		    get{
		        return _DoctorTimingId;
		    } 
		    set{
		        this.OnDoctorTimingIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorTimingId = value;
                this.SendPropertyChanged("DoctorTimingId");
                this.OnDoctorTimingIdChanged();
		    }
		}
		
        partial void OnServiceTimingIdChanging(int? value);
        partial void OnServiceTimingIdChanged();
		
		private int? _ServiceTimingId;
		public int? ServiceTimingId { 
		    get{
		        return _ServiceTimingId;
		    } 
		    set{
		        this.OnServiceTimingIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceTimingId = value;
                this.SendPropertyChanged("ServiceTimingId");
                this.OnServiceTimingIdChanged();
		    }
		}
		
        partial void OnBlockStartChanging(DateTime? value);
        partial void OnBlockStartChanged();
		
		private DateTime? _BlockStart;
		public DateTime? BlockStart { 
		    get{
		        return _BlockStart;
		    } 
		    set{
		        this.OnBlockStartChanging(value);
                this.SendPropertyChanging();
                this._BlockStart = value;
                this.SendPropertyChanged("BlockStart");
                this.OnBlockStartChanged();
		    }
		}
		
        partial void OnBlockEndChanging(DateTime? value);
        partial void OnBlockEndChanged();
		
		private DateTime? _BlockEnd;
		public DateTime? BlockEnd { 
		    get{
		        return _BlockEnd;
		    } 
		    set{
		        this.OnBlockEndChanging(value);
                this.SendPropertyChanging();
                this._BlockEnd = value;
                this.SendPropertyChanged("BlockEnd");
                this.OnBlockEndChanged();
		    }
		}
		
        partial void OnReasonChanging(string value);
        partial void OnReasonChanged();
		
		private string _Reason;
		public string Reason { 
		    get{
		        return _Reason;
		    } 
		    set{
		        this.OnReasonChanging(value);
                this.SendPropertyChanging();
                this._Reason = value;
                this.SendPropertyChanged("Reason");
                this.OnReasonChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Doctor_Timing> TBL_Doctor_Timings
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctor_Timings
                       where items.DoctorTimingId == _DoctorTimingId
                       select items;
            }
        }

        public IQueryable<TBL_Service_Timing> TBL_Service_Timings
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Service_Timings
                       where items.ServiceTimingId == _ServiceTimingId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_SearchWidgetColVisible table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_SearchWidgetColVisible 
    /// </summary>

	public partial class TBL_Job_SearchWidgetColVisible: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_SearchWidgetColVisible(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSwIdChanging(int value);
        partial void OnSwIdChanged();
		
		private int _SwId;
		public int SwId { 
		    get{
		        return _SwId;
		    } 
		    set{
		        this.OnSwIdChanging(value);
                this.SendPropertyChanging();
                this._SwId = value;
                this.SendPropertyChanged("SwId");
                this.OnSwIdChanged();
		    }
		}
		
        partial void OnCountryChanging(bool? value);
        partial void OnCountryChanged();
		
		private bool? _Country;
		public bool? Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateChanging(bool? value);
        partial void OnStateChanged();
		
		private bool? _State;
		public bool? State { 
		    get{
		        return _State;
		    } 
		    set{
		        this.OnStateChanging(value);
                this.SendPropertyChanging();
                this._State = value;
                this.SendPropertyChanged("State");
                this.OnStateChanged();
		    }
		}
		
        partial void OnCityChanging(bool? value);
        partial void OnCityChanged();
		
		private bool? _City;
		public bool? City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnFacilityChanging(bool? value);
        partial void OnFacilityChanged();
		
		private bool? _Facility;
		public bool? Facility { 
		    get{
		        return _Facility;
		    } 
		    set{
		        this.OnFacilityChanging(value);
                this.SendPropertyChanging();
                this._Facility = value;
                this.SendPropertyChanged("Facility");
                this.OnFacilityChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Service_Timing table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Service_Timing 
    /// </summary>

	public partial class TBL_Service_Timing: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Service_Timing(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnServiceTimingIdChanging(int value);
        partial void OnServiceTimingIdChanged();
		
		private int _ServiceTimingId;
		public int ServiceTimingId { 
		    get{
		        return _ServiceTimingId;
		    } 
		    set{
		        this.OnServiceTimingIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceTimingId = value;
                this.SendPropertyChanged("ServiceTimingId");
                this.OnServiceTimingIdChanged();
		    }
		}
		
        partial void OnServiceIdChanging(int? value);
        partial void OnServiceIdChanged();
		
		private int? _ServiceId;
		public int? ServiceId { 
		    get{
		        return _ServiceId;
		    } 
		    set{
		        this.OnServiceIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceId = value;
                this.SendPropertyChanged("ServiceId");
                this.OnServiceIdChanged();
		    }
		}
		
        partial void OnScheduleNameChanging(string value);
        partial void OnScheduleNameChanged();
		
		private string _ScheduleName;
		public string ScheduleName { 
		    get{
		        return _ScheduleName;
		    } 
		    set{
		        this.OnScheduleNameChanging(value);
                this.SendPropertyChanging();
                this._ScheduleName = value;
                this.SendPropertyChanged("ScheduleName");
                this.OnScheduleNameChanged();
		    }
		}
		
        partial void OnAddressChanging(string value);
        partial void OnAddressChanged();
		
		private string _Address;
		public string Address { 
		    get{
		        return _Address;
		    } 
		    set{
		        this.OnAddressChanging(value);
                this.SendPropertyChanging();
                this._Address = value;
                this.SendPropertyChanged("Address");
                this.OnAddressChanged();
		    }
		}
		
        partial void OnSundayChanging(bool? value);
        partial void OnSundayChanged();
		
		private bool? _Sunday;
		public bool? Sunday { 
		    get{
		        return _Sunday;
		    } 
		    set{
		        this.OnSundayChanging(value);
                this.SendPropertyChanging();
                this._Sunday = value;
                this.SendPropertyChanged("Sunday");
                this.OnSundayChanged();
		    }
		}
		
        partial void OnMondayChanging(bool? value);
        partial void OnMondayChanged();
		
		private bool? _Monday;
		public bool? Monday { 
		    get{
		        return _Monday;
		    } 
		    set{
		        this.OnMondayChanging(value);
                this.SendPropertyChanging();
                this._Monday = value;
                this.SendPropertyChanged("Monday");
                this.OnMondayChanged();
		    }
		}
		
        partial void OnTuesdayChanging(bool? value);
        partial void OnTuesdayChanged();
		
		private bool? _Tuesday;
		public bool? Tuesday { 
		    get{
		        return _Tuesday;
		    } 
		    set{
		        this.OnTuesdayChanging(value);
                this.SendPropertyChanging();
                this._Tuesday = value;
                this.SendPropertyChanged("Tuesday");
                this.OnTuesdayChanged();
		    }
		}
		
        partial void OnWednesdayChanging(bool? value);
        partial void OnWednesdayChanged();
		
		private bool? _Wednesday;
		public bool? Wednesday { 
		    get{
		        return _Wednesday;
		    } 
		    set{
		        this.OnWednesdayChanging(value);
                this.SendPropertyChanging();
                this._Wednesday = value;
                this.SendPropertyChanged("Wednesday");
                this.OnWednesdayChanged();
		    }
		}
		
        partial void OnThursdayChanging(bool? value);
        partial void OnThursdayChanged();
		
		private bool? _Thursday;
		public bool? Thursday { 
		    get{
		        return _Thursday;
		    } 
		    set{
		        this.OnThursdayChanging(value);
                this.SendPropertyChanging();
                this._Thursday = value;
                this.SendPropertyChanged("Thursday");
                this.OnThursdayChanged();
		    }
		}
		
        partial void OnFridayChanging(bool? value);
        partial void OnFridayChanged();
		
		private bool? _Friday;
		public bool? Friday { 
		    get{
		        return _Friday;
		    } 
		    set{
		        this.OnFridayChanging(value);
                this.SendPropertyChanging();
                this._Friday = value;
                this.SendPropertyChanged("Friday");
                this.OnFridayChanged();
		    }
		}
		
        partial void OnSaturdayChanging(bool? value);
        partial void OnSaturdayChanged();
		
		private bool? _Saturday;
		public bool? Saturday { 
		    get{
		        return _Saturday;
		    } 
		    set{
		        this.OnSaturdayChanging(value);
                this.SendPropertyChanging();
                this._Saturday = value;
                this.SendPropertyChanged("Saturday");
                this.OnSaturdayChanged();
		    }
		}
		
        partial void OnStartTimeChanging(string value);
        partial void OnStartTimeChanged();
		
		private string _StartTime;
		public string StartTime { 
		    get{
		        return _StartTime;
		    } 
		    set{
		        this.OnStartTimeChanging(value);
                this.SendPropertyChanging();
                this._StartTime = value;
                this.SendPropertyChanged("StartTime");
                this.OnStartTimeChanged();
		    }
		}
		
        partial void OnEndTimeChanging(string value);
        partial void OnEndTimeChanged();
		
		private string _EndTime;
		public string EndTime { 
		    get{
		        return _EndTime;
		    } 
		    set{
		        this.OnEndTimeChanging(value);
                this.SendPropertyChanging();
                this._EndTime = value;
                this.SendPropertyChanged("EndTime");
                this.OnEndTimeChanged();
		    }
		}
		
        partial void OnPatientDurationChanging(string value);
        partial void OnPatientDurationChanged();
		
		private string _PatientDuration;
		public string PatientDuration { 
		    get{
		        return _PatientDuration;
		    } 
		    set{
		        this.OnPatientDurationChanging(value);
                this.SendPropertyChanging();
                this._PatientDuration = value;
                this.SendPropertyChanged("PatientDuration");
                this.OnPatientDurationChanged();
		    }
		}
		
        partial void OnIsApprovalSystemChanging(bool? value);
        partial void OnIsApprovalSystemChanged();
		
		private bool? _IsApprovalSystem;
		public bool? IsApprovalSystem { 
		    get{
		        return _IsApprovalSystem;
		    } 
		    set{
		        this.OnIsApprovalSystemChanging(value);
                this.SendPropertyChanging();
                this._IsApprovalSystem = value;
                this.SendPropertyChanged("IsApprovalSystem");
                this.OnIsApprovalSystemChanged();
		    }
		}
		
        partial void OnIsApprovalNotificationSMSChanging(bool? value);
        partial void OnIsApprovalNotificationSMSChanged();
		
		private bool? _IsApprovalNotificationSMS;
		public bool? IsApprovalNotificationSMS { 
		    get{
		        return _IsApprovalNotificationSMS;
		    } 
		    set{
		        this.OnIsApprovalNotificationSMSChanging(value);
                this.SendPropertyChanging();
                this._IsApprovalNotificationSMS = value;
                this.SendPropertyChanged("IsApprovalNotificationSMS");
                this.OnIsApprovalNotificationSMSChanged();
		    }
		}
		
        partial void OnIsApprovalNotificationEmailChanging(bool? value);
        partial void OnIsApprovalNotificationEmailChanged();
		
		private bool? _IsApprovalNotificationEmail;
		public bool? IsApprovalNotificationEmail { 
		    get{
		        return _IsApprovalNotificationEmail;
		    } 
		    set{
		        this.OnIsApprovalNotificationEmailChanging(value);
                this.SendPropertyChanging();
                this._IsApprovalNotificationEmail = value;
                this.SendPropertyChanged("IsApprovalNotificationEmail");
                this.OnIsApprovalNotificationEmailChanged();
		    }
		}
		
        partial void OnMaxAppointmentDaysChanging(int? value);
        partial void OnMaxAppointmentDaysChanged();
		
		private int? _MaxAppointmentDays;
		public int? MaxAppointmentDays { 
		    get{
		        return _MaxAppointmentDays;
		    } 
		    set{
		        this.OnMaxAppointmentDaysChanging(value);
                this.SendPropertyChanging();
                this._MaxAppointmentDays = value;
                this.SendPropertyChanged("MaxAppointmentDays");
                this.OnMaxAppointmentDaysChanged();
		    }
		}
		
        partial void OnIsDefaultAddressChanging(bool? value);
        partial void OnIsDefaultAddressChanged();
		
		private bool? _IsDefaultAddress;
		public bool? IsDefaultAddress { 
		    get{
		        return _IsDefaultAddress;
		    } 
		    set{
		        this.OnIsDefaultAddressChanging(value);
                this.SendPropertyChanging();
                this._IsDefaultAddress = value;
                this.SendPropertyChanged("IsDefaultAddress");
                this.OnIsDefaultAddressChanged();
		    }
		}
		
        partial void OnIsCarParkFacilityChanging(bool? value);
        partial void OnIsCarParkFacilityChanged();
		
		private bool? _IsCarParkFacility;
		public bool? IsCarParkFacility { 
		    get{
		        return _IsCarParkFacility;
		    } 
		    set{
		        this.OnIsCarParkFacilityChanging(value);
                this.SendPropertyChanging();
                this._IsCarParkFacility = value;
                this.SendPropertyChanged("IsCarParkFacility");
                this.OnIsCarParkFacilityChanged();
		    }
		}
		
        partial void OnIsFCFSChanging(bool? value);
        partial void OnIsFCFSChanged();
		
		private bool? _IsFCFS;
		public bool? IsFCFS { 
		    get{
		        return _IsFCFS;
		    } 
		    set{
		        this.OnIsFCFSChanging(value);
                this.SendPropertyChanging();
                this._IsFCFS = value;
                this.SendPropertyChanged("IsFCFS");
                this.OnIsFCFSChanged();
		    }
		}
		
        partial void OnMaxAppsChanging(int? value);
        partial void OnMaxAppsChanged();
		
		private int? _MaxApps;
		public int? MaxApps { 
		    get{
		        return _MaxApps;
		    } 
		    set{
		        this.OnMaxAppsChanging(value);
                this.SendPropertyChanging();
                this._MaxApps = value;
                this.SendPropertyChanged("MaxApps");
                this.OnMaxAppsChanged();
		    }
		}
		
        partial void OnAppointmentTypeChanging(int? value);
        partial void OnAppointmentTypeChanged();
		
		private int? _AppointmentType;
		public int? AppointmentType { 
		    get{
		        return _AppointmentType;
		    } 
		    set{
		        this.OnAppointmentTypeChanging(value);
                this.SendPropertyChanging();
                this._AppointmentType = value;
                this.SendPropertyChanged("AppointmentType");
                this.OnAppointmentTypeChanged();
		    }
		}
		
        partial void OnConditionsChanging(string value);
        partial void OnConditionsChanged();
		
		private string _Conditions;
		public string Conditions { 
		    get{
		        return _Conditions;
		    } 
		    set{
		        this.OnConditionsChanging(value);
                this.SendPropertyChanging();
                this._Conditions = value;
                this.SendPropertyChanged("Conditions");
                this.OnConditionsChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_BlockCalendar> TBL_BlockCalendars
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_BlockCalendars
                       where items.ServiceTimingId == _ServiceTimingId
                       select items;
            }
        }

        public IQueryable<TBL_Service> TBL_Services
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Services
                       where items.ServiceId == _ServiceId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_SearchResultsColVisible table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_SearchResultsColVisible 
    /// </summary>

	public partial class TBL_Job_SearchResultsColVisible: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_SearchResultsColVisible(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSrIdChanging(int value);
        partial void OnSrIdChanged();
		
		private int _SrId;
		public int SrId { 
		    get{
		        return _SrId;
		    } 
		    set{
		        this.OnSrIdChanging(value);
                this.SendPropertyChanging();
                this._SrId = value;
                this.SendPropertyChanged("SrId");
                this.OnSrIdChanged();
		    }
		}
		
        partial void OnCountryChanging(bool? value);
        partial void OnCountryChanged();
		
		private bool? _Country;
		public bool? Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateChanging(bool? value);
        partial void OnStateChanged();
		
		private bool? _State;
		public bool? State { 
		    get{
		        return _State;
		    } 
		    set{
		        this.OnStateChanging(value);
                this.SendPropertyChanging();
                this._State = value;
                this.SendPropertyChanged("State");
                this.OnStateChanged();
		    }
		}
		
        partial void OnCityChanging(bool? value);
        partial void OnCityChanged();
		
		private bool? _City;
		public bool? City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnFacilityChanging(bool? value);
        partial void OnFacilityChanged();
		
		private bool? _Facility;
		public bool? Facility { 
		    get{
		        return _Facility;
		    } 
		    set{
		        this.OnFacilityChanging(value);
                this.SendPropertyChanging();
                this._Facility = value;
                this.SendPropertyChanged("Facility");
                this.OnFacilityChanged();
		    }
		}
		
        partial void OnSpecialityChanging(bool? value);
        partial void OnSpecialityChanged();
		
		private bool? _Speciality;
		public bool? Speciality { 
		    get{
		        return _Speciality;
		    } 
		    set{
		        this.OnSpecialityChanging(value);
                this.SendPropertyChanging();
                this._Speciality = value;
                this.SendPropertyChanged("Speciality");
                this.OnSpecialityChanged();
		    }
		}
		
        partial void OnPostDateChanging(bool? value);
        partial void OnPostDateChanged();
		
		private bool? _PostDate;
		public bool? PostDate { 
		    get{
		        return _PostDate;
		    } 
		    set{
		        this.OnPostDateChanging(value);
                this.SendPropertyChanging();
                this._PostDate = value;
                this.SendPropertyChanged("PostDate");
                this.OnPostDateChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Landing_SubTab table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Landing_SubTab 
    /// </summary>

	public partial class TBL_Landing_SubTab: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Landing_SubTab(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSubTabIdChanging(int value);
        partial void OnSubTabIdChanged();
		
		private int _SubTabId;
		public int SubTabId { 
		    get{
		        return _SubTabId;
		    } 
		    set{
		        this.OnSubTabIdChanging(value);
                this.SendPropertyChanging();
                this._SubTabId = value;
                this.SendPropertyChanged("SubTabId");
                this.OnSubTabIdChanged();
		    }
		}
		
        partial void OnSubTabNameChanging(string value);
        partial void OnSubTabNameChanged();
		
		private string _SubTabName;
		public string SubTabName { 
		    get{
		        return _SubTabName;
		    } 
		    set{
		        this.OnSubTabNameChanging(value);
                this.SendPropertyChanging();
                this._SubTabName = value;
                this.SendPropertyChanged("SubTabName");
                this.OnSubTabNameChanged();
		    }
		}
		
        partial void OnSubTabContentChanging(string value);
        partial void OnSubTabContentChanged();
		
		private string _SubTabContent;
		public string SubTabContent { 
		    get{
		        return _SubTabContent;
		    } 
		    set{
		        this.OnSubTabContentChanging(value);
                this.SendPropertyChanging();
                this._SubTabContent = value;
                this.SendPropertyChanged("SubTabContent");
                this.OnSubTabContentChanged();
		    }
		}
		
        partial void OnMainTabIdChanging(int? value);
        partial void OnMainTabIdChanged();
		
		private int? _MainTabId;
		public int? MainTabId { 
		    get{
		        return _MainTabId;
		    } 
		    set{
		        this.OnMainTabIdChanging(value);
                this.SendPropertyChanging();
                this._MainTabId = value;
                this.SendPropertyChanged("MainTabId");
                this.OnMainTabIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_SearchDescriptionColVisible table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_SearchDescriptionColVisible 
    /// </summary>

	public partial class TBL_Job_SearchDescriptionColVisible: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_SearchDescriptionColVisible(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSdIdChanging(int value);
        partial void OnSdIdChanged();
		
		private int _SdId;
		public int SdId { 
		    get{
		        return _SdId;
		    } 
		    set{
		        this.OnSdIdChanging(value);
                this.SendPropertyChanging();
                this._SdId = value;
                this.SendPropertyChanged("SdId");
                this.OnSdIdChanged();
		    }
		}
		
        partial void OnJobIdChanging(bool? value);
        partial void OnJobIdChanged();
		
		private bool? _JobId;
		public bool? JobId { 
		    get{
		        return _JobId;
		    } 
		    set{
		        this.OnJobIdChanging(value);
                this.SendPropertyChanging();
                this._JobId = value;
                this.SendPropertyChanged("JobId");
                this.OnJobIdChanged();
		    }
		}
		
        partial void OnJobTitleChanging(bool? value);
        partial void OnJobTitleChanged();
		
		private bool? _JobTitle;
		public bool? JobTitle { 
		    get{
		        return _JobTitle;
		    } 
		    set{
		        this.OnJobTitleChanging(value);
                this.SendPropertyChanging();
                this._JobTitle = value;
                this.SendPropertyChanged("JobTitle");
                this.OnJobTitleChanged();
		    }
		}
		
        partial void OnFacilityChanging(bool? value);
        partial void OnFacilityChanged();
		
		private bool? _Facility;
		public bool? Facility { 
		    get{
		        return _Facility;
		    } 
		    set{
		        this.OnFacilityChanging(value);
                this.SendPropertyChanging();
                this._Facility = value;
                this.SendPropertyChanged("Facility");
                this.OnFacilityChanged();
		    }
		}
		
        partial void OnSpecialityChanging(bool? value);
        partial void OnSpecialityChanged();
		
		private bool? _Speciality;
		public bool? Speciality { 
		    get{
		        return _Speciality;
		    } 
		    set{
		        this.OnSpecialityChanging(value);
                this.SendPropertyChanging();
                this._Speciality = value;
                this.SendPropertyChanged("Speciality");
                this.OnSpecialityChanged();
		    }
		}
		
        partial void OnCountryChanging(bool? value);
        partial void OnCountryChanged();
		
		private bool? _Country;
		public bool? Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateChanging(bool? value);
        partial void OnStateChanged();
		
		private bool? _State;
		public bool? State { 
		    get{
		        return _State;
		    } 
		    set{
		        this.OnStateChanging(value);
                this.SendPropertyChanging();
                this._State = value;
                this.SendPropertyChanged("State");
                this.OnStateChanged();
		    }
		}
		
        partial void OnCityChanging(bool? value);
        partial void OnCityChanged();
		
		private bool? _City;
		public bool? City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnDescriptionChanging(bool? value);
        partial void OnDescriptionChanged();
		
		private bool? _Description;
		public bool? Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnPostedDateChanging(bool? value);
        partial void OnPostedDateChanged();
		
		private bool? _PostedDate;
		public bool? PostedDate { 
		    get{
		        return _PostedDate;
		    } 
		    set{
		        this.OnPostedDateChanging(value);
                this.SendPropertyChanging();
                this._PostedDate = value;
                this.SendPropertyChanged("PostedDate");
                this.OnPostedDateChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_NewsLetter table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_NewsLetter 
    /// </summary>

	public partial class TBL_Job_NewsLetter: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_NewsLetter(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnNidChanging(int value);
        partial void OnNidChanged();
		
		private int _Nid;
		public int Nid { 
		    get{
		        return _Nid;
		    } 
		    set{
		        this.OnNidChanging(value);
                this.SendPropertyChanging();
                this._Nid = value;
                this.SendPropertyChanged("Nid");
                this.OnNidChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
		
		private string _Email;
		public string Email { 
		    get{
		        return _Email;
		    } 
		    set{
		        this.OnEmailChanging(value);
                this.SendPropertyChanging();
                this._Email = value;
                this.SendPropertyChanged("Email");
                this.OnEmailChanged();
		    }
		}
		
        partial void OnPostedDateChanging(DateTime? value);
        partial void OnPostedDateChanged();
		
		private DateTime? _PostedDate;
		public DateTime? PostedDate { 
		    get{
		        return _PostedDate;
		    } 
		    set{
		        this.OnPostedDateChanging(value);
                this.SendPropertyChanging();
                this._PostedDate = value;
                this.SendPropertyChanged("PostedDate");
                this.OnPostedDateChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Tbl_Appointment_Comments table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.Tbl_Appointment_Comment 
    /// </summary>

	public partial class Tbl_Appointment_Comment: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Tbl_Appointment_Comment(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnAppointmentIdChanging(int? value);
        partial void OnAppointmentIdChanged();
		
		private int? _AppointmentId;
		public int? AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnStatusIdChanging(int? value);
        partial void OnStatusIdChanged();
		
		private int? _StatusId;
		public int? StatusId { 
		    get{
		        return _StatusId;
		    } 
		    set{
		        this.OnStatusIdChanging(value);
                this.SendPropertyChanging();
                this._StatusId = value;
                this.SendPropertyChanged("StatusId");
                this.OnStatusIdChanged();
		    }
		}
		
        partial void OnLoginIdChanging(int? value);
        partial void OnLoginIdChanged();
		
		private int? _LoginId;
		public int? LoginId { 
		    get{
		        return _LoginId;
		    } 
		    set{
		        this.OnLoginIdChanging(value);
                this.SendPropertyChanging();
                this._LoginId = value;
                this.SendPropertyChanged("LoginId");
                this.OnLoginIdChanged();
		    }
		}
		
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
		
		private string _Comment;
		public string Comment { 
		    get{
		        return _Comment;
		    } 
		    set{
		        this.OnCommentChanging(value);
                this.SendPropertyChanging();
                this._Comment = value;
                this.SendPropertyChanged("Comment");
                this.OnCommentChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnActionTypeIdChanging(int? value);
        partial void OnActionTypeIdChanged();
		
		private int? _ActionTypeId;
		public int? ActionTypeId { 
		    get{
		        return _ActionTypeId;
		    } 
		    set{
		        this.OnActionTypeIdChanging(value);
                this.SendPropertyChanging();
                this._ActionTypeId = value;
                this.SendPropertyChanged("ActionTypeId");
                this.OnActionTypeIdChanged();
		    }
		}
		
        partial void OnActionIdChanging(int? value);
        partial void OnActionIdChanged();
		
		private int? _ActionId;
		public int? ActionId { 
		    get{
		        return _ActionId;
		    } 
		    set{
		        this.OnActionIdChanging(value);
                this.SendPropertyChanging();
                this._ActionId = value;
                this.SendPropertyChanged("ActionId");
                this.OnActionIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_Jobs table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_Job 
    /// </summary>

	public partial class TBL_Job_Job: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_Job(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnJidChanging(int value);
        partial void OnJidChanged();
		
		private int _Jid;
		public int Jid { 
		    get{
		        return _Jid;
		    } 
		    set{
		        this.OnJidChanging(value);
                this.SendPropertyChanging();
                this._Jid = value;
                this.SendPropertyChanged("Jid");
                this.OnJidChanged();
		    }
		}
		
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
		
		private string _JobId;
		public string JobId { 
		    get{
		        return _JobId;
		    } 
		    set{
		        this.OnJobIdChanging(value);
                this.SendPropertyChanging();
                this._JobId = value;
                this.SendPropertyChanged("JobId");
                this.OnJobIdChanged();
		    }
		}
		
        partial void OnJobTitleChanging(string value);
        partial void OnJobTitleChanged();
		
		private string _JobTitle;
		public string JobTitle { 
		    get{
		        return _JobTitle;
		    } 
		    set{
		        this.OnJobTitleChanging(value);
                this.SendPropertyChanging();
                this._JobTitle = value;
                this.SendPropertyChanged("JobTitle");
                this.OnJobTitleChanged();
		    }
		}
		
        partial void OnFacilityChanging(int? value);
        partial void OnFacilityChanged();
		
		private int? _Facility;
		public int? Facility { 
		    get{
		        return _Facility;
		    } 
		    set{
		        this.OnFacilityChanging(value);
                this.SendPropertyChanging();
                this._Facility = value;
                this.SendPropertyChanged("Facility");
                this.OnFacilityChanged();
		    }
		}
		
        partial void OnSpecialityChanging(int? value);
        partial void OnSpecialityChanged();
		
		private int? _Speciality;
		public int? Speciality { 
		    get{
		        return _Speciality;
		    } 
		    set{
		        this.OnSpecialityChanging(value);
                this.SendPropertyChanging();
                this._Speciality = value;
                this.SendPropertyChanged("Speciality");
                this.OnSpecialityChanged();
		    }
		}
		
        partial void OnLocationChanging(int? value);
        partial void OnLocationChanged();
		
		private int? _Location;
		public int? Location { 
		    get{
		        return _Location;
		    } 
		    set{
		        this.OnLocationChanging(value);
                this.SendPropertyChanging();
                this._Location = value;
                this.SendPropertyChanged("Location");
                this.OnLocationChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		
        partial void OnVisibilityChanging(bool? value);
        partial void OnVisibilityChanged();
		
		private bool? _Visibility;
		public bool? Visibility { 
		    get{
		        return _Visibility;
		    } 
		    set{
		        this.OnVisibilityChanging(value);
                this.SendPropertyChanging();
                this._Visibility = value;
                this.SendPropertyChanged("Visibility");
                this.OnVisibilityChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Login table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Login 
    /// </summary>

	public partial class TBL_Login: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Login(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnLoginIdChanging(int value);
        partial void OnLoginIdChanged();
		
		private int _LoginId;
		public int LoginId { 
		    get{
		        return _LoginId;
		    } 
		    set{
		        this.OnLoginIdChanging(value);
                this.SendPropertyChanging();
                this._LoginId = value;
                this.SendPropertyChanged("LoginId");
                this.OnLoginIdChanged();
		    }
		}
		
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
		
		private string _FirstName;
		public string FirstName { 
		    get{
		        return _FirstName;
		    } 
		    set{
		        this.OnFirstNameChanging(value);
                this.SendPropertyChanging();
                this._FirstName = value;
                this.SendPropertyChanged("FirstName");
                this.OnFirstNameChanged();
		    }
		}
		
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
		
		private string _LastName;
		public string LastName { 
		    get{
		        return _LastName;
		    } 
		    set{
		        this.OnLastNameChanging(value);
                this.SendPropertyChanging();
                this._LastName = value;
                this.SendPropertyChanged("LastName");
                this.OnLastNameChanged();
		    }
		}
		
        partial void OnMedAppIdChanging(string value);
        partial void OnMedAppIdChanged();
		
		private string _MedAppId;
		public string MedAppId { 
		    get{
		        return _MedAppId;
		    } 
		    set{
		        this.OnMedAppIdChanging(value);
                this.SendPropertyChanging();
                this._MedAppId = value;
                this.SendPropertyChanged("MedAppId");
                this.OnMedAppIdChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnMobileIdChanging(string value);
        partial void OnMobileIdChanged();
		
		private string _MobileId;
		public string MobileId { 
		    get{
		        return _MobileId;
		    } 
		    set{
		        this.OnMobileIdChanging(value);
                this.SendPropertyChanging();
                this._MobileId = value;
                this.SendPropertyChanged("MobileId");
                this.OnMobileIdChanged();
		    }
		}
		
        partial void OnEmailIdChanging(string value);
        partial void OnEmailIdChanged();
		
		private string _EmailId;
		public string EmailId { 
		    get{
		        return _EmailId;
		    } 
		    set{
		        this.OnEmailIdChanging(value);
                this.SendPropertyChanging();
                this._EmailId = value;
                this.SendPropertyChanged("EmailId");
                this.OnEmailIdChanged();
		    }
		}
		
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
		
		private string _Password;
		public string Password { 
		    get{
		        return _Password;
		    } 
		    set{
		        this.OnPasswordChanging(value);
                this.SendPropertyChanging();
                this._Password = value;
                this.SendPropertyChanged("Password");
                this.OnPasswordChanged();
		    }
		}
		
        partial void OnIsDirectChanging(bool? value);
        partial void OnIsDirectChanged();
		
		private bool? _IsDirect;
		public bool? IsDirect { 
		    get{
		        return _IsDirect;
		    } 
		    set{
		        this.OnIsDirectChanging(value);
                this.SendPropertyChanging();
                this._IsDirect = value;
                this.SendPropertyChanged("IsDirect");
                this.OnIsDirectChanged();
		    }
		}
		
        partial void OnIsActivatedChanging(bool? value);
        partial void OnIsActivatedChanged();
		
		private bool? _IsActivated;
		public bool? IsActivated { 
		    get{
		        return _IsActivated;
		    } 
		    set{
		        this.OnIsActivatedChanging(value);
                this.SendPropertyChanging();
                this._IsActivated = value;
                this.SendPropertyChanged("IsActivated");
                this.OnIsActivatedChanged();
		    }
		}
		
        partial void OnIsEmailActivatedChanging(bool? value);
        partial void OnIsEmailActivatedChanged();
		
		private bool? _IsEmailActivated;
		public bool? IsEmailActivated { 
		    get{
		        return _IsEmailActivated;
		    } 
		    set{
		        this.OnIsEmailActivatedChanging(value);
                this.SendPropertyChanging();
                this._IsEmailActivated = value;
                this.SendPropertyChanged("IsEmailActivated");
                this.OnIsEmailActivatedChanged();
		    }
		}
		
        partial void OnTransactionTokenChanging(string value);
        partial void OnTransactionTokenChanged();
		
		private string _TransactionToken;
		public string TransactionToken { 
		    get{
		        return _TransactionToken;
		    } 
		    set{
		        this.OnTransactionTokenChanging(value);
                this.SendPropertyChanging();
                this._TransactionToken = value;
                this.SendPropertyChanged("TransactionToken");
                this.OnTransactionTokenChanged();
		    }
		}
		
        partial void OnIsEmailNotificationChanging(bool? value);
        partial void OnIsEmailNotificationChanged();
		
		private bool? _IsEmailNotification;
		public bool? IsEmailNotification { 
		    get{
		        return _IsEmailNotification;
		    } 
		    set{
		        this.OnIsEmailNotificationChanging(value);
                this.SendPropertyChanging();
                this._IsEmailNotification = value;
                this.SendPropertyChanged("IsEmailNotification");
                this.OnIsEmailNotificationChanged();
		    }
		}
		
        partial void OnIsSMSNotificationChanging(bool? value);
        partial void OnIsSMSNotificationChanged();
		
		private bool? _IsSMSNotification;
		public bool? IsSMSNotification { 
		    get{
		        return _IsSMSNotification;
		    } 
		    set{
		        this.OnIsSMSNotificationChanging(value);
                this.SendPropertyChanging();
                this._IsSMSNotification = value;
                this.SendPropertyChanged("IsSMSNotification");
                this.OnIsSMSNotificationChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Doctor> TBL_Doctors
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.LoginId == _LoginId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.LoginId == _LoginId
                       select items;
            }
        }

        public IQueryable<TBL_Service> TBL_Services
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Services
                       where items.LoginId == _LoginId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_HrLogin table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_HrLogin 
    /// </summary>

	public partial class TBL_Job_HrLogin: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_HrLogin(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnHidChanging(int value);
        partial void OnHidChanged();
		
		private int _Hid;
		public int Hid { 
		    get{
		        return _Hid;
		    } 
		    set{
		        this.OnHidChanging(value);
                this.SendPropertyChanging();
                this._Hid = value;
                this.SendPropertyChanged("Hid");
                this.OnHidChanged();
		    }
		}
		
        partial void OnUserNameChanging(string value);
        partial void OnUserNameChanged();
		
		private string _UserName;
		public string UserName { 
		    get{
		        return _UserName;
		    } 
		    set{
		        this.OnUserNameChanging(value);
                this.SendPropertyChanging();
                this._UserName = value;
                this.SendPropertyChanged("UserName");
                this.OnUserNameChanged();
		    }
		}
		
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
		
		private string _Password;
		public string Password { 
		    get{
		        return _Password;
		    } 
		    set{
		        this.OnPasswordChanging(value);
                this.SendPropertyChanging();
                this._Password = value;
                this.SendPropertyChanged("Password");
                this.OnPasswordChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_HotOppsColVisible table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_HotOppsColVisible 
    /// </summary>

	public partial class TBL_Job_HotOppsColVisible: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_HotOppsColVisible(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnHIdChanging(int value);
        partial void OnHIdChanged();
		
		private int _HId;
		public int HId { 
		    get{
		        return _HId;
		    } 
		    set{
		        this.OnHIdChanging(value);
                this.SendPropertyChanging();
                this._HId = value;
                this.SendPropertyChanged("HId");
                this.OnHIdChanged();
		    }
		}
		
        partial void OnCountryChanging(bool? value);
        partial void OnCountryChanged();
		
		private bool? _Country;
		public bool? Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnStateChanging(bool? value);
        partial void OnStateChanged();
		
		private bool? _State;
		public bool? State { 
		    get{
		        return _State;
		    } 
		    set{
		        this.OnStateChanging(value);
                this.SendPropertyChanging();
                this._State = value;
                this.SendPropertyChanged("State");
                this.OnStateChanged();
		    }
		}
		
        partial void OnCityChanging(bool? value);
        partial void OnCityChanged();
		
		private bool? _City;
		public bool? City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnFacilityChanging(bool? value);
        partial void OnFacilityChanged();
		
		private bool? _Facility;
		public bool? Facility { 
		    get{
		        return _Facility;
		    } 
		    set{
		        this.OnFacilityChanging(value);
                this.SendPropertyChanging();
                this._Facility = value;
                this.SendPropertyChanged("Facility");
                this.OnFacilityChanged();
		    }
		}
		
        partial void OnSpecialityChanging(bool? value);
        partial void OnSpecialityChanged();
		
		private bool? _Speciality;
		public bool? Speciality { 
		    get{
		        return _Speciality;
		    } 
		    set{
		        this.OnSpecialityChanging(value);
                this.SendPropertyChanging();
                this._Speciality = value;
                this.SendPropertyChanged("Speciality");
                this.OnSpecialityChanged();
		    }
		}
		
        partial void OnPostedDateChanging(bool? value);
        partial void OnPostedDateChanged();
		
		private bool? _PostedDate;
		public bool? PostedDate { 
		    get{
		        return _PostedDate;
		    } 
		    set{
		        this.OnPostedDateChanging(value);
                this.SendPropertyChanging();
                this._PostedDate = value;
                this.SendPropertyChanged("PostedDate");
                this.OnPostedDateChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_Facility table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_Facility 
    /// </summary>

	public partial class TBL_Job_Facility: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_Facility(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnFacIdChanging(int value);
        partial void OnFacIdChanged();
		
		private int _FacId;
		public int FacId { 
		    get{
		        return _FacId;
		    } 
		    set{
		        this.OnFacIdChanging(value);
                this.SendPropertyChanging();
                this._FacId = value;
                this.SendPropertyChanged("FacId");
                this.OnFacIdChanged();
		    }
		}
		
        partial void OnFacilityChanging(string value);
        partial void OnFacilityChanged();
		
		private string _Facility;
		public string Facility { 
		    get{
		        return _Facility;
		    } 
		    set{
		        this.OnFacilityChanging(value);
                this.SendPropertyChanging();
                this._Facility = value;
                this.SendPropertyChanged("Facility");
                this.OnFacilityChanged();
		    }
		}
		
        partial void OnVisibilityChanging(bool? value);
        partial void OnVisibilityChanged();
		
		private bool? _Visibility;
		public bool? Visibility { 
		    get{
		        return _Visibility;
		    } 
		    set{
		        this.OnVisibilityChanging(value);
                this.SendPropertyChanging();
                this._Visibility = value;
                this.SendPropertyChanged("Visibility");
                this.OnVisibilityChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		
        partial void OnCreatedDateChanging(DateTime? value);
        partial void OnCreatedDateChanged();
		
		private DateTime? _CreatedDate;
		public DateTime? CreatedDate { 
		    get{
		        return _CreatedDate;
		    } 
		    set{
		        this.OnCreatedDateChanging(value);
                this.SendPropertyChanging();
                this._CreatedDate = value;
                this.SendPropertyChanged("CreatedDate");
                this.OnCreatedDateChanged();
		    }
		}
		
        partial void OnUpdatedDateChanging(DateTime? value);
        partial void OnUpdatedDateChanged();
		
		private DateTime? _UpdatedDate;
		public DateTime? UpdatedDate { 
		    get{
		        return _UpdatedDate;
		    } 
		    set{
		        this.OnUpdatedDateChanging(value);
                this.SendPropertyChanging();
                this._UpdatedDate = value;
                this.SendPropertyChanged("UpdatedDate");
                this.OnUpdatedDateChanged();
		    }
		}
		
        partial void OnWhoCreatedChanging(string value);
        partial void OnWhoCreatedChanged();
		
		private string _WhoCreated;
		public string WhoCreated { 
		    get{
		        return _WhoCreated;
		    } 
		    set{
		        this.OnWhoCreatedChanging(value);
                this.SendPropertyChanging();
                this._WhoCreated = value;
                this.SendPropertyChanged("WhoCreated");
                this.OnWhoCreatedChanged();
		    }
		}
		
        partial void OnWhoUpdatedChanging(string value);
        partial void OnWhoUpdatedChanged();
		
		private string _WhoUpdated;
		public string WhoUpdated { 
		    get{
		        return _WhoUpdated;
		    } 
		    set{
		        this.OnWhoUpdatedChanging(value);
                this.SendPropertyChanging();
                this._WhoUpdated = value;
                this.SendPropertyChanged("WhoUpdated");
                this.OnWhoUpdatedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Service_Diagnosis table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Service_Diagnosi 
    /// </summary>

	public partial class TBL_Service_Diagnosi: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Service_Diagnosi(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnServiceIdChanging(int? value);
        partial void OnServiceIdChanged();
		
		private int? _ServiceId;
		public int? ServiceId { 
		    get{
		        return _ServiceId;
		    } 
		    set{
		        this.OnServiceIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceId = value;
                this.SendPropertyChanged("ServiceId");
                this.OnServiceIdChanged();
		    }
		}
		
        partial void OnDiagnosisIdChanging(int? value);
        partial void OnDiagnosisIdChanged();
		
		private int? _DiagnosisId;
		public int? DiagnosisId { 
		    get{
		        return _DiagnosisId;
		    } 
		    set{
		        this.OnDiagnosisIdChanging(value);
                this.SendPropertyChanging();
                this._DiagnosisId = value;
                this.SendPropertyChanged("DiagnosisId");
                this.OnDiagnosisIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Job_Apply table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Job_Apply 
    /// </summary>

	public partial class TBL_Job_Apply: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Job_Apply(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAidChanging(int value);
        partial void OnAidChanged();
		
		private int _Aid;
		public int Aid { 
		    get{
		        return _Aid;
		    } 
		    set{
		        this.OnAidChanging(value);
                this.SendPropertyChanging();
                this._Aid = value;
                this.SendPropertyChanged("Aid");
                this.OnAidChanged();
		    }
		}
		
        partial void OnJobIdChanging(string value);
        partial void OnJobIdChanged();
		
		private string _JobId;
		public string JobId { 
		    get{
		        return _JobId;
		    } 
		    set{
		        this.OnJobIdChanging(value);
                this.SendPropertyChanging();
                this._JobId = value;
                this.SendPropertyChanged("JobId");
                this.OnJobIdChanged();
		    }
		}
		
        partial void OnCandidateNameChanging(string value);
        partial void OnCandidateNameChanged();
		
		private string _CandidateName;
		public string CandidateName { 
		    get{
		        return _CandidateName;
		    } 
		    set{
		        this.OnCandidateNameChanging(value);
                this.SendPropertyChanging();
                this._CandidateName = value;
                this.SendPropertyChanged("CandidateName");
                this.OnCandidateNameChanged();
		    }
		}
		
        partial void OnAgeChanging(string value);
        partial void OnAgeChanged();
		
		private string _Age;
		public string Age { 
		    get{
		        return _Age;
		    } 
		    set{
		        this.OnAgeChanging(value);
                this.SendPropertyChanging();
                this._Age = value;
                this.SendPropertyChanged("Age");
                this.OnAgeChanged();
		    }
		}
		
        partial void OnSexChanging(string value);
        partial void OnSexChanged();
		
		private string _Sex;
		public string Sex { 
		    get{
		        return _Sex;
		    } 
		    set{
		        this.OnSexChanging(value);
                this.SendPropertyChanging();
                this._Sex = value;
                this.SendPropertyChanged("Sex");
                this.OnSexChanged();
		    }
		}
		
        partial void OnPermanentAddressChanging(string value);
        partial void OnPermanentAddressChanged();
		
		private string _PermanentAddress;
		public string PermanentAddress { 
		    get{
		        return _PermanentAddress;
		    } 
		    set{
		        this.OnPermanentAddressChanging(value);
                this.SendPropertyChanging();
                this._PermanentAddress = value;
                this.SendPropertyChanged("PermanentAddress");
                this.OnPermanentAddressChanged();
		    }
		}
		
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
		
		private string _Email;
		public string Email { 
		    get{
		        return _Email;
		    } 
		    set{
		        this.OnEmailChanging(value);
                this.SendPropertyChanging();
                this._Email = value;
                this.SendPropertyChanged("Email");
                this.OnEmailChanged();
		    }
		}
		
        partial void OnCityChanging(string value);
        partial void OnCityChanged();
		
		private string _City;
		public string City { 
		    get{
		        return _City;
		    } 
		    set{
		        this.OnCityChanging(value);
                this.SendPropertyChanging();
                this._City = value;
                this.SendPropertyChanged("City");
                this.OnCityChanged();
		    }
		}
		
        partial void OnDistrictChanging(string value);
        partial void OnDistrictChanged();
		
		private string _District;
		public string District { 
		    get{
		        return _District;
		    } 
		    set{
		        this.OnDistrictChanging(value);
                this.SendPropertyChanging();
                this._District = value;
                this.SendPropertyChanged("District");
                this.OnDistrictChanged();
		    }
		}
		
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
		
		private string _State;
		public string State { 
		    get{
		        return _State;
		    } 
		    set{
		        this.OnStateChanging(value);
                this.SendPropertyChanging();
                this._State = value;
                this.SendPropertyChanged("State");
                this.OnStateChanged();
		    }
		}
		
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
		
		private string _Country;
		public string Country { 
		    get{
		        return _Country;
		    } 
		    set{
		        this.OnCountryChanging(value);
                this.SendPropertyChanging();
                this._Country = value;
                this.SendPropertyChanged("Country");
                this.OnCountryChanged();
		    }
		}
		
        partial void OnAboutUsChanging(string value);
        partial void OnAboutUsChanged();
		
		private string _AboutUs;
		public string AboutUs { 
		    get{
		        return _AboutUs;
		    } 
		    set{
		        this.OnAboutUsChanging(value);
                this.SendPropertyChanging();
                this._AboutUs = value;
                this.SendPropertyChanged("AboutUs");
                this.OnAboutUsChanged();
		    }
		}
		
        partial void OnContactPhoneChanging(string value);
        partial void OnContactPhoneChanged();
		
		private string _ContactPhone;
		public string ContactPhone { 
		    get{
		        return _ContactPhone;
		    } 
		    set{
		        this.OnContactPhoneChanging(value);
                this.SendPropertyChanging();
                this._ContactPhone = value;
                this.SendPropertyChanged("ContactPhone");
                this.OnContactPhoneChanged();
		    }
		}
		
        partial void OnContactMobileChanging(string value);
        partial void OnContactMobileChanged();
		
		private string _ContactMobile;
		public string ContactMobile { 
		    get{
		        return _ContactMobile;
		    } 
		    set{
		        this.OnContactMobileChanging(value);
                this.SendPropertyChanging();
                this._ContactMobile = value;
                this.SendPropertyChanged("ContactMobile");
                this.OnContactMobileChanged();
		    }
		}
		
        partial void OnBestTimeChanging(string value);
        partial void OnBestTimeChanged();
		
		private string _BestTime;
		public string BestTime { 
		    get{
		        return _BestTime;
		    } 
		    set{
		        this.OnBestTimeChanging(value);
                this.SendPropertyChanging();
                this._BestTime = value;
                this.SendPropertyChanged("BestTime");
                this.OnBestTimeChanged();
		    }
		}
		
        partial void OnSpecializationChanging(string value);
        partial void OnSpecializationChanged();
		
		private string _Specialization;
		public string Specialization { 
		    get{
		        return _Specialization;
		    } 
		    set{
		        this.OnSpecializationChanging(value);
                this.SendPropertyChanging();
                this._Specialization = value;
                this.SendPropertyChanged("Specialization");
                this.OnSpecializationChanged();
		    }
		}
		
        partial void OnExperienceChanging(string value);
        partial void OnExperienceChanged();
		
		private string _Experience;
		public string Experience { 
		    get{
		        return _Experience;
		    } 
		    set{
		        this.OnExperienceChanging(value);
                this.SendPropertyChanging();
                this._Experience = value;
                this.SendPropertyChanged("Experience");
                this.OnExperienceChanged();
		    }
		}
		
        partial void OnHighestQualificationChanging(string value);
        partial void OnHighestQualificationChanged();
		
		private string _HighestQualification;
		public string HighestQualification { 
		    get{
		        return _HighestQualification;
		    } 
		    set{
		        this.OnHighestQualificationChanging(value);
                this.SendPropertyChanging();
                this._HighestQualification = value;
                this.SendPropertyChanged("HighestQualification");
                this.OnHighestQualificationChanged();
		    }
		}
		
        partial void OnHighestDegreeChanging(string value);
        partial void OnHighestDegreeChanged();
		
		private string _HighestDegree;
		public string HighestDegree { 
		    get{
		        return _HighestDegree;
		    } 
		    set{
		        this.OnHighestDegreeChanging(value);
                this.SendPropertyChanging();
                this._HighestDegree = value;
                this.SendPropertyChanged("HighestDegree");
                this.OnHighestDegreeChanged();
		    }
		}
		
        partial void OnCurrentEmployerChanging(string value);
        partial void OnCurrentEmployerChanged();
		
		private string _CurrentEmployer;
		public string CurrentEmployer { 
		    get{
		        return _CurrentEmployer;
		    } 
		    set{
		        this.OnCurrentEmployerChanging(value);
                this.SendPropertyChanging();
                this._CurrentEmployer = value;
                this.SendPropertyChanged("CurrentEmployer");
                this.OnCurrentEmployerChanged();
		    }
		}
		
        partial void OnExistingPayChanging(string value);
        partial void OnExistingPayChanged();
		
		private string _ExistingPay;
		public string ExistingPay { 
		    get{
		        return _ExistingPay;
		    } 
		    set{
		        this.OnExistingPayChanging(value);
                this.SendPropertyChanging();
                this._ExistingPay = value;
                this.SendPropertyChanged("ExistingPay");
                this.OnExistingPayChanged();
		    }
		}
		
        partial void OnDesiredPayChanging(string value);
        partial void OnDesiredPayChanged();
		
		private string _DesiredPay;
		public string DesiredPay { 
		    get{
		        return _DesiredPay;
		    } 
		    set{
		        this.OnDesiredPayChanging(value);
                this.SendPropertyChanging();
                this._DesiredPay = value;
                this.SendPropertyChanged("DesiredPay");
                this.OnDesiredPayChanged();
		    }
		}
		
        partial void OnWillingChanging(string value);
        partial void OnWillingChanged();
		
		private string _Willing;
		public string Willing { 
		    get{
		        return _Willing;
		    } 
		    set{
		        this.OnWillingChanging(value);
                this.SendPropertyChanging();
                this._Willing = value;
                this.SendPropertyChanged("Willing");
                this.OnWillingChanged();
		    }
		}
		
        partial void OnUploadResumeChanging(string value);
        partial void OnUploadResumeChanged();
		
		private string _UploadResume;
		public string UploadResume { 
		    get{
		        return _UploadResume;
		    } 
		    set{
		        this.OnUploadResumeChanging(value);
                this.SendPropertyChanging();
                this._UploadResume = value;
                this.SendPropertyChanged("UploadResume");
                this.OnUploadResumeChanged();
		    }
		}
		
        partial void OnAppliedDateChanging(DateTime? value);
        partial void OnAppliedDateChanged();
		
		private DateTime? _AppliedDate;
		public DateTime? AppliedDate { 
		    get{
		        return _AppliedDate;
		    } 
		    set{
		        this.OnAppliedDateChanging(value);
                this.SendPropertyChanging();
                this._AppliedDate = value;
                this.SendPropertyChanged("AppliedDate");
                this.OnAppliedDateChanged();
		    }
		}
		
        partial void OnHrStatusChanging(string value);
        partial void OnHrStatusChanged();
		
		private string _HrStatus;
		public string HrStatus { 
		    get{
		        return _HrStatus;
		    } 
		    set{
		        this.OnHrStatusChanging(value);
                this.SendPropertyChanging();
                this._HrStatus = value;
                this.SendPropertyChanged("HrStatus");
                this.OnHrStatusChanged();
		    }
		}
		
        partial void OnHrDateUpdatedChanging(DateTime? value);
        partial void OnHrDateUpdatedChanged();
		
		private DateTime? _HrDateUpdated;
		public DateTime? HrDateUpdated { 
		    get{
		        return _HrDateUpdated;
		    } 
		    set{
		        this.OnHrDateUpdatedChanging(value);
                this.SendPropertyChanging();
                this._HrDateUpdated = value;
                this.SendPropertyChanged("HrDateUpdated");
                this.OnHrDateUpdatedChanged();
		    }
		}
		
        partial void OnFinalStatusChanging(string value);
        partial void OnFinalStatusChanged();
		
		private string _FinalStatus;
		public string FinalStatus { 
		    get{
		        return _FinalStatus;
		    } 
		    set{
		        this.OnFinalStatusChanging(value);
                this.SendPropertyChanging();
                this._FinalStatus = value;
                this.SendPropertyChanged("FinalStatus");
                this.OnFinalStatusChanged();
		    }
		}
		
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
		
		private string _Notes;
		public string Notes { 
		    get{
		        return _Notes;
		    } 
		    set{
		        this.OnNotesChanging(value);
                this.SendPropertyChanging();
                this._Notes = value;
                this.SendPropertyChanged("Notes");
                this.OnNotesChanged();
		    }
		}
		
        partial void OnClientIdChanging(int? value);
        partial void OnClientIdChanged();
		
		private int? _ClientId;
		public int? ClientId { 
		    get{
		        return _ClientId;
		    } 
		    set{
		        this.OnClientIdChanging(value);
                this.SendPropertyChanging();
                this._ClientId = value;
                this.SendPropertyChanged("ClientId");
                this.OnClientIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_GupShup table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_GupShup 
    /// </summary>

	public partial class TBL_GupShup: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_GupShup(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnExternalIdChanging(string value);
        partial void OnExternalIdChanged();
		
		private string _ExternalId;
		public string ExternalId { 
		    get{
		        return _ExternalId;
		    } 
		    set{
		        this.OnExternalIdChanging(value);
                this.SendPropertyChanging();
                this._ExternalId = value;
                this.SendPropertyChanged("ExternalId");
                this.OnExternalIdChanged();
		    }
		}
		
        partial void OnDeliveredTSChanging(string value);
        partial void OnDeliveredTSChanged();
		
		private string _DeliveredTS;
		public string DeliveredTS { 
		    get{
		        return _DeliveredTS;
		    } 
		    set{
		        this.OnDeliveredTSChanging(value);
                this.SendPropertyChanging();
                this._DeliveredTS = value;
                this.SendPropertyChanged("DeliveredTS");
                this.OnDeliveredTSChanged();
		    }
		}
		
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
		
		private string _Status;
		public string Status { 
		    get{
		        return _Status;
		    } 
		    set{
		        this.OnStatusChanging(value);
                this.SendPropertyChanging();
                this._Status = value;
                this.SendPropertyChanged("Status");
                this.OnStatusChanged();
		    }
		}
		
        partial void OnPhoneNoChanging(string value);
        partial void OnPhoneNoChanged();
		
		private string _PhoneNo;
		public string PhoneNo { 
		    get{
		        return _PhoneNo;
		    } 
		    set{
		        this.OnPhoneNoChanging(value);
                this.SendPropertyChanging();
                this._PhoneNo = value;
                this.SendPropertyChanged("PhoneNo");
                this.OnPhoneNoChanged();
		    }
		}
		
        partial void OnCauseChanging(string value);
        partial void OnCauseChanged();
		
		private string _Cause;
		public string Cause { 
		    get{
		        return _Cause;
		    } 
		    set{
		        this.OnCauseChanging(value);
                this.SendPropertyChanging();
                this._Cause = value;
                this.SendPropertyChanged("Cause");
                this.OnCauseChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Landing_ImageGallery table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Landing_ImageGallery 
    /// </summary>

	public partial class TBL_Landing_ImageGallery: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Landing_ImageGallery(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnImageIdChanging(int value);
        partial void OnImageIdChanged();
		
		private int _ImageId;
		public int ImageId { 
		    get{
		        return _ImageId;
		    } 
		    set{
		        this.OnImageIdChanging(value);
                this.SendPropertyChanging();
                this._ImageId = value;
                this.SendPropertyChanged("ImageId");
                this.OnImageIdChanged();
		    }
		}
		
        partial void OnAccountIdChanging(int? value);
        partial void OnAccountIdChanged();
		
		private int? _AccountId;
		public int? AccountId { 
		    get{
		        return _AccountId;
		    } 
		    set{
		        this.OnAccountIdChanging(value);
                this.SendPropertyChanging();
                this._AccountId = value;
                this.SendPropertyChanged("AccountId");
                this.OnAccountIdChanged();
		    }
		}
		
        partial void OnAccountTypeIdChanging(int? value);
        partial void OnAccountTypeIdChanged();
		
		private int? _AccountTypeId;
		public int? AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnVersionChanging(int? value);
        partial void OnVersionChanged();
		
		private int? _Version;
		public int? Version { 
		    get{
		        return _Version;
		    } 
		    set{
		        this.OnVersionChanging(value);
                this.SendPropertyChanging();
                this._Version = value;
                this.SendPropertyChanged("Version");
                this.OnVersionChanged();
		    }
		}
		
        partial void OnImageNameChanging(string value);
        partial void OnImageNameChanged();
		
		private string _ImageName;
		public string ImageName { 
		    get{
		        return _ImageName;
		    } 
		    set{
		        this.OnImageNameChanging(value);
                this.SendPropertyChanging();
                this._ImageName = value;
                this.SendPropertyChanged("ImageName");
                this.OnImageNameChanged();
		    }
		}
		
        partial void OnImageDescriptionChanging(string value);
        partial void OnImageDescriptionChanged();
		
		private string _ImageDescription;
		public string ImageDescription { 
		    get{
		        return _ImageDescription;
		    } 
		    set{
		        this.OnImageDescriptionChanging(value);
                this.SendPropertyChanging();
                this._ImageDescription = value;
                this.SendPropertyChanged("ImageDescription");
                this.OnImageDescriptionChanged();
		    }
		}
		
        partial void OnImagesChanging(byte[] value);
        partial void OnImagesChanged();
		
		private byte[] _Images;
		public byte[] Images { 
		    get{
		        return _Images;
		    } 
		    set{
		        this.OnImagesChanging(value);
                this.SendPropertyChanging();
                this._Images = value;
                this.SendPropertyChanged("Images");
                this.OnImagesChanged();
		    }
		}
		
        partial void OnSelectedChanging(bool? value);
        partial void OnSelectedChanged();
		
		private bool? _Selected;
		public bool? Selected { 
		    get{
		        return _Selected;
		    } 
		    set{
		        this.OnSelectedChanging(value);
                this.SendPropertyChanging();
                this._Selected = value;
                this.SendPropertyChanged("Selected");
                this.OnSelectedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Organization table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Organization 
    /// </summary>

	public partial class TBL_Organization: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Organization(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnOrganizationIdChanging(int value);
        partial void OnOrganizationIdChanged();
		
		private int _OrganizationId;
		public int OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnOrganizationNameChanging(string value);
        partial void OnOrganizationNameChanged();
		
		private string _OrganizationName;
		public string OrganizationName { 
		    get{
		        return _OrganizationName;
		    } 
		    set{
		        this.OnOrganizationNameChanging(value);
                this.SendPropertyChanging();
                this._OrganizationName = value;
                this.SendPropertyChanged("OrganizationName");
                this.OnOrganizationNameChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Token table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Token 
    /// </summary>

	public partial class TBL_Token: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Token(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnTokenIdChanging(int value);
        partial void OnTokenIdChanged();
		
		private int _TokenId;
		public int TokenId { 
		    get{
		        return _TokenId;
		    } 
		    set{
		        this.OnTokenIdChanging(value);
                this.SendPropertyChanging();
                this._TokenId = value;
                this.SendPropertyChanged("TokenId");
                this.OnTokenIdChanged();
		    }
		}
		
        partial void OnTokenNumberChanging(string value);
        partial void OnTokenNumberChanged();
		
		private string _TokenNumber;
		public string TokenNumber { 
		    get{
		        return _TokenNumber;
		    } 
		    set{
		        this.OnTokenNumberChanging(value);
                this.SendPropertyChanging();
                this._TokenNumber = value;
                this.SendPropertyChanged("TokenNumber");
                this.OnTokenNumberChanged();
		    }
		}
		
        partial void OnTokenSequenceChanging(int? value);
        partial void OnTokenSequenceChanged();
		
		private int? _TokenSequence;
		public int? TokenSequence { 
		    get{
		        return _TokenSequence;
		    } 
		    set{
		        this.OnTokenSequenceChanging(value);
                this.SendPropertyChanging();
                this._TokenSequence = value;
                this.SendPropertyChanged("TokenSequence");
                this.OnTokenSequenceChanged();
		    }
		}
		
        partial void OnAppointmentIdChanging(int? value);
        partial void OnAppointmentIdChanged();
		
		private int? _AppointmentId;
		public int? AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.AppointmentId == _AppointmentId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Content table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.Content 
    /// </summary>

	public partial class Content: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Content(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
		
		private string _Title;
		public string Title { 
		    get{
		        return _Title;
		    } 
		    set{
		        this.OnTitleChanging(value);
                this.SendPropertyChanging();
                this._Title = value;
                this.SendPropertyChanged("Title");
                this.OnTitleChanged();
		    }
		}
		
        partial void OnImageUrlChanging(string value);
        partial void OnImageUrlChanged();
		
		private string _ImageUrl;
		public string ImageUrl { 
		    get{
		        return _ImageUrl;
		    } 
		    set{
		        this.OnImageUrlChanging(value);
                this.SendPropertyChanging();
                this._ImageUrl = value;
                this.SendPropertyChanged("ImageUrl");
                this.OnImageUrlChanged();
		    }
		}
		
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
		
		private string _Text;
		public string Text { 
		    get{
		        return _Text;
		    } 
		    set{
		        this.OnTextChanging(value);
                this.SendPropertyChanging();
                this._Text = value;
                this.SendPropertyChanged("Text");
                this.OnTextChanged();
		    }
		}
		
        partial void OnPageIDChanging(int? value);
        partial void OnPageIDChanged();
		
		private int? _PageID;
		public int? PageID { 
		    get{
		        return _PageID;
		    } 
		    set{
		        this.OnPageIDChanging(value);
                this.SendPropertyChanging();
                this._PageID = value;
                this.SendPropertyChanged("PageID");
                this.OnPageIDChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Page> Pages
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.Pages
                       where items.ID == _PageID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the Page table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.Page 
    /// </summary>

	public partial class Page: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public Page(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
		
		private string _Location;
		public string Location { 
		    get{
		        return _Location;
		    } 
		    set{
		        this.OnLocationChanging(value);
                this.SendPropertyChanging();
                this._Location = value;
                this.SendPropertyChanged("Location");
                this.OnLocationChanged();
		    }
		}
		
        partial void OnHeaderImageChanging(string value);
        partial void OnHeaderImageChanged();
		
		private string _HeaderImage;
		public string HeaderImage { 
		    get{
		        return _HeaderImage;
		    } 
		    set{
		        this.OnHeaderImageChanging(value);
                this.SendPropertyChanging();
                this._HeaderImage = value;
                this.SendPropertyChanged("HeaderImage");
                this.OnHeaderImageChanged();
		    }
		}
		
        partial void OnFooterImageChanging(string value);
        partial void OnFooterImageChanged();
		
		private string _FooterImage;
		public string FooterImage { 
		    get{
		        return _FooterImage;
		    } 
		    set{
		        this.OnFooterImageChanging(value);
                this.SendPropertyChanging();
                this._FooterImage = value;
                this.SendPropertyChanged("FooterImage");
                this.OnFooterImageChanged();
		    }
		}
		
        partial void OnHeaderTextChanging(string value);
        partial void OnHeaderTextChanged();
		
		private string _HeaderText;
		public string HeaderText { 
		    get{
		        return _HeaderText;
		    } 
		    set{
		        this.OnHeaderTextChanging(value);
                this.SendPropertyChanging();
                this._HeaderText = value;
                this.SendPropertyChanged("HeaderText");
                this.OnHeaderTextChanged();
		    }
		}
		
        partial void OnFooterTextChanging(string value);
        partial void OnFooterTextChanged();
		
		private string _FooterText;
		public string FooterText { 
		    get{
		        return _FooterText;
		    } 
		    set{
		        this.OnFooterTextChanging(value);
                this.SendPropertyChanging();
                this._FooterText = value;
                this.SendPropertyChanged("FooterText");
                this.OnFooterTextChanged();
		    }
		}
		
        partial void OnPageImageChanging(string value);
        partial void OnPageImageChanged();
		
		private string _PageImage;
		public string PageImage { 
		    get{
		        return _PageImage;
		    } 
		    set{
		        this.OnPageImageChanging(value);
                this.SendPropertyChanging();
                this._PageImage = value;
                this.SendPropertyChanged("PageImage");
                this.OnPageImageChanged();
		    }
		}
		
        partial void OnMainSiteChanging(string value);
        partial void OnMainSiteChanged();
		
		private string _MainSite;
		public string MainSite { 
		    get{
		        return _MainSite;
		    } 
		    set{
		        this.OnMainSiteChanging(value);
                this.SendPropertyChanging();
                this._MainSite = value;
                this.SendPropertyChanged("MainSite");
                this.OnMainSiteChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<Content> Contents
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.Contents
                       where items.PageID == _ID
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_GupShup_FailureReason table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_GupShup_FailureReason 
    /// </summary>

	public partial class TBL_GupShup_FailureReason: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_GupShup_FailureReason(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnKeyWordChanging(string value);
        partial void OnKeyWordChanged();
		
		private string _KeyWord;
		public string KeyWord { 
		    get{
		        return _KeyWord;
		    } 
		    set{
		        this.OnKeyWordChanging(value);
                this.SendPropertyChanging();
                this._KeyWord = value;
                this.SendPropertyChanged("KeyWord");
                this.OnKeyWordChanged();
		    }
		}
		
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
		
		private string _Description;
		public string Description { 
		    get{
		        return _Description;
		    } 
		    set{
		        this.OnDescriptionChanging(value);
                this.SendPropertyChanging();
                this._Description = value;
                this.SendPropertyChanged("Description");
                this.OnDescriptionChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Banner table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Banner 
    /// </summary>

	public partial class TBL_Master_Banner: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Banner(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnBannerIdChanging(int value);
        partial void OnBannerIdChanged();
		
		private int _BannerId;
		public int BannerId { 
		    get{
		        return _BannerId;
		    } 
		    set{
		        this.OnBannerIdChanging(value);
                this.SendPropertyChanging();
                this._BannerId = value;
                this.SendPropertyChanged("BannerId");
                this.OnBannerIdChanged();
		    }
		}
		
        partial void OnDepartmentIdChanging(int? value);
        partial void OnDepartmentIdChanged();
		
		private int? _DepartmentId;
		public int? DepartmentId { 
		    get{
		        return _DepartmentId;
		    } 
		    set{
		        this.OnDepartmentIdChanging(value);
                this.SendPropertyChanging();
                this._DepartmentId = value;
                this.SendPropertyChanged("DepartmentId");
                this.OnDepartmentIdChanged();
		    }
		}
		
        partial void OnBannerFilenameChanging(string value);
        partial void OnBannerFilenameChanged();
		
		private string _BannerFilename;
		public string BannerFilename { 
		    get{
		        return _BannerFilename;
		    } 
		    set{
		        this.OnBannerFilenameChanging(value);
                this.SendPropertyChanging();
                this._BannerFilename = value;
                this.SendPropertyChanged("BannerFilename");
                this.OnBannerFilenameChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Landing table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Landing 
    /// </summary>

	public partial class TBL_Landing: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Landing(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnLandingIdChanging(int value);
        partial void OnLandingIdChanged();
		
		private int _LandingId;
		public int LandingId { 
		    get{
		        return _LandingId;
		    } 
		    set{
		        this.OnLandingIdChanging(value);
                this.SendPropertyChanging();
                this._LandingId = value;
                this.SendPropertyChanged("LandingId");
                this.OnLandingIdChanged();
		    }
		}
		
        partial void OnVersionChanging(int? value);
        partial void OnVersionChanged();
		
		private int? _Version;
		public int? Version { 
		    get{
		        return _Version;
		    } 
		    set{
		        this.OnVersionChanging(value);
                this.SendPropertyChanging();
                this._Version = value;
                this.SendPropertyChanged("Version");
                this.OnVersionChanged();
		    }
		}
		
        partial void OnPublishIdChanging(int? value);
        partial void OnPublishIdChanged();
		
		private int? _PublishId;
		public int? PublishId { 
		    get{
		        return _PublishId;
		    } 
		    set{
		        this.OnPublishIdChanging(value);
                this.SendPropertyChanging();
                this._PublishId = value;
                this.SendPropertyChanged("PublishId");
                this.OnPublishIdChanged();
		    }
		}
		
        partial void OnBannerPathChanging(string value);
        partial void OnBannerPathChanged();
		
		private string _BannerPath;
		public string BannerPath { 
		    get{
		        return _BannerPath;
		    } 
		    set{
		        this.OnBannerPathChanging(value);
                this.SendPropertyChanging();
                this._BannerPath = value;
                this.SendPropertyChanged("BannerPath");
                this.OnBannerPathChanged();
		    }
		}
		
        partial void OnDepartmentIdChanging(int? value);
        partial void OnDepartmentIdChanged();
		
		private int? _DepartmentId;
		public int? DepartmentId { 
		    get{
		        return _DepartmentId;
		    } 
		    set{
		        this.OnDepartmentIdChanging(value);
                this.SendPropertyChanging();
                this._DepartmentId = value;
                this.SendPropertyChanged("DepartmentId");
                this.OnDepartmentIdChanged();
		    }
		}
		
        partial void OnFormsChanging(string value);
        partial void OnFormsChanged();
		
		private string _Forms;
		public string Forms { 
		    get{
		        return _Forms;
		    } 
		    set{
		        this.OnFormsChanging(value);
                this.SendPropertyChanging();
                this._Forms = value;
                this.SendPropertyChanged("Forms");
                this.OnFormsChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Doctor_Education table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Doctor_Education 
    /// </summary>

	public partial class TBL_Doctor_Education: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Doctor_Education(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnEducationIdChanging(int value);
        partial void OnEducationIdChanged();
		
		private int _EducationId;
		public int EducationId { 
		    get{
		        return _EducationId;
		    } 
		    set{
		        this.OnEducationIdChanging(value);
                this.SendPropertyChanging();
                this._EducationId = value;
                this.SendPropertyChanged("EducationId");
                this.OnEducationIdChanged();
		    }
		}
		
        partial void OnUniversityChanging(string value);
        partial void OnUniversityChanged();
		
		private string _University;
		public string University { 
		    get{
		        return _University;
		    } 
		    set{
		        this.OnUniversityChanging(value);
                this.SendPropertyChanging();
                this._University = value;
                this.SendPropertyChanged("University");
                this.OnUniversityChanged();
		    }
		}
		
        partial void OnDegreeChanging(string value);
        partial void OnDegreeChanged();
		
		private string _Degree;
		public string Degree { 
		    get{
		        return _Degree;
		    } 
		    set{
		        this.OnDegreeChanging(value);
                this.SendPropertyChanging();
                this._Degree = value;
                this.SendPropertyChanged("Degree");
                this.OnDegreeChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		
        partial void OnStateIdChanging(int? value);
        partial void OnStateIdChanged();
		
		private int? _StateId;
		public int? StateId { 
		    get{
		        return _StateId;
		    } 
		    set{
		        this.OnStateIdChanging(value);
                this.SendPropertyChanging();
                this._StateId = value;
                this.SendPropertyChanged("StateId");
                this.OnStateIdChanged();
		    }
		}
		
        partial void OnCityIdChanging(int? value);
        partial void OnCityIdChanged();
		
		private int? _CityId;
		public int? CityId { 
		    get{
		        return _CityId;
		    } 
		    set{
		        this.OnCityIdChanging(value);
                this.SendPropertyChanging();
                this._CityId = value;
                this.SendPropertyChanged("CityId");
                this.OnCityIdChanged();
		    }
		}
		
        partial void OnYearFromChanging(int? value);
        partial void OnYearFromChanged();
		
		private int? _YearFrom;
		public int? YearFrom { 
		    get{
		        return _YearFrom;
		    } 
		    set{
		        this.OnYearFromChanging(value);
                this.SendPropertyChanging();
                this._YearFrom = value;
                this.SendPropertyChanged("YearFrom");
                this.OnYearFromChanged();
		    }
		}
		
        partial void OnYearToChanging(int? value);
        partial void OnYearToChanged();
		
		private int? _YearTo;
		public int? YearTo { 
		    get{
		        return _YearTo;
		    } 
		    set{
		        this.OnYearToChanging(value);
                this.SendPropertyChanging();
                this._YearTo = value;
                this.SendPropertyChanged("YearTo");
                this.OnYearToChanged();
		    }
		}
		
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
		
		private string _Notes;
		public string Notes { 
		    get{
		        return _Notes;
		    } 
		    set{
		        this.OnNotesChanging(value);
                this.SendPropertyChanging();
                this._Notes = value;
                this.SendPropertyChanged("Notes");
                this.OnNotesChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_University table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_University 
    /// </summary>

	public partial class TBL_Master_University: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_University(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnUniversityIdChanging(int value);
        partial void OnUniversityIdChanged();
		
		private int _UniversityId;
		public int UniversityId { 
		    get{
		        return _UniversityId;
		    } 
		    set{
		        this.OnUniversityIdChanging(value);
                this.SendPropertyChanging();
                this._UniversityId = value;
                this.SendPropertyChanged("UniversityId");
                this.OnUniversityIdChanged();
		    }
		}
		
        partial void OnUniversityNameChanging(string value);
        partial void OnUniversityNameChanged();
		
		private string _UniversityName;
		public string UniversityName { 
		    get{
		        return _UniversityName;
		    } 
		    set{
		        this.OnUniversityNameChanging(value);
                this.SendPropertyChanging();
                this._UniversityName = value;
                this.SendPropertyChanged("UniversityName");
                this.OnUniversityNameChanged();
		    }
		}
		
        partial void OnCountryIdChanging(int? value);
        partial void OnCountryIdChanged();
		
		private int? _CountryId;
		public int? CountryId { 
		    get{
		        return _CountryId;
		    } 
		    set{
		        this.OnCountryIdChanging(value);
                this.SendPropertyChanging();
                this._CountryId = value;
                this.SendPropertyChanged("CountryId");
                this.OnCountryIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Landing_Publish table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Landing_Publish 
    /// </summary>

	public partial class TBL_Landing_Publish: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Landing_Publish(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnPublishIdChanging(int value);
        partial void OnPublishIdChanged();
		
		private int _PublishId;
		public int PublishId { 
		    get{
		        return _PublishId;
		    } 
		    set{
		        this.OnPublishIdChanging(value);
                this.SendPropertyChanging();
                this._PublishId = value;
                this.SendPropertyChanged("PublishId");
                this.OnPublishIdChanged();
		    }
		}
		
        partial void OnAccountIdChanging(int? value);
        partial void OnAccountIdChanged();
		
		private int? _AccountId;
		public int? AccountId { 
		    get{
		        return _AccountId;
		    } 
		    set{
		        this.OnAccountIdChanging(value);
                this.SendPropertyChanging();
                this._AccountId = value;
                this.SendPropertyChanged("AccountId");
                this.OnAccountIdChanged();
		    }
		}
		
        partial void OnAccountTypeIdChanging(int? value);
        partial void OnAccountTypeIdChanged();
		
		private int? _AccountTypeId;
		public int? AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnBannerIdChanging(int? value);
        partial void OnBannerIdChanged();
		
		private int? _BannerId;
		public int? BannerId { 
		    get{
		        return _BannerId;
		    } 
		    set{
		        this.OnBannerIdChanging(value);
                this.SendPropertyChanging();
                this._BannerId = value;
                this.SendPropertyChanged("BannerId");
                this.OnBannerIdChanged();
		    }
		}
		
        partial void OnDefaultVersionChanging(int? value);
        partial void OnDefaultVersionChanged();
		
		private int? _DefaultVersion;
		public int? DefaultVersion { 
		    get{
		        return _DefaultVersion;
		    } 
		    set{
		        this.OnDefaultVersionChanging(value);
                this.SendPropertyChanging();
                this._DefaultVersion = value;
                this.SendPropertyChanged("DefaultVersion");
                this.OnDefaultVersionChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Admin_LoginType table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Admin_LoginType 
    /// </summary>

	public partial class TBL_Admin_LoginType: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Admin_LoginType(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnLoginTypeIdChanging(int value);
        partial void OnLoginTypeIdChanged();
		
		private int _LoginTypeId;
		public int LoginTypeId { 
		    get{
		        return _LoginTypeId;
		    } 
		    set{
		        this.OnLoginTypeIdChanging(value);
                this.SendPropertyChanging();
                this._LoginTypeId = value;
                this.SendPropertyChanged("LoginTypeId");
                this.OnLoginTypeIdChanged();
		    }
		}
		
        partial void OnLoginTypeChanging(string value);
        partial void OnLoginTypeChanged();
		
		private string _LoginType;
		public string LoginType { 
		    get{
		        return _LoginType;
		    } 
		    set{
		        this.OnLoginTypeChanging(value);
                this.SendPropertyChanging();
                this._LoginType = value;
                this.SendPropertyChanged("LoginType");
                this.OnLoginTypeChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Doctor table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Doctor 
    /// </summary>

	public partial class TBL_Doctor: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Doctor(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnDoctorIdChanging(int value);
        partial void OnDoctorIdChanged();
		
		private int _DoctorId;
		public int DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnLoginIdChanging(int? value);
        partial void OnLoginIdChanged();
		
		private int? _LoginId;
		public int? LoginId { 
		    get{
		        return _LoginId;
		    } 
		    set{
		        this.OnLoginIdChanging(value);
                this.SendPropertyChanging();
                this._LoginId = value;
                this.SendPropertyChanged("LoginId");
                this.OnLoginIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnDoctorNameChanging(string value);
        partial void OnDoctorNameChanged();
		
		private string _DoctorName;
		public string DoctorName { 
		    get{
		        return _DoctorName;
		    } 
		    set{
		        this.OnDoctorNameChanging(value);
                this.SendPropertyChanging();
                this._DoctorName = value;
                this.SendPropertyChanged("DoctorName");
                this.OnDoctorNameChanged();
		    }
		}
		
        partial void OnDateofBirthChanging(DateTime? value);
        partial void OnDateofBirthChanged();
		
		private DateTime? _DateofBirth;
		public DateTime? DateofBirth { 
		    get{
		        return _DateofBirth;
		    } 
		    set{
		        this.OnDateofBirthChanging(value);
                this.SendPropertyChanging();
                this._DateofBirth = value;
                this.SendPropertyChanged("DateofBirth");
                this.OnDateofBirthChanged();
		    }
		}
		
        partial void OnGenderChanging(bool? value);
        partial void OnGenderChanged();
		
		private bool? _Gender;
		public bool? Gender { 
		    get{
		        return _Gender;
		    } 
		    set{
		        this.OnGenderChanging(value);
                this.SendPropertyChanging();
                this._Gender = value;
                this.SendPropertyChanged("Gender");
                this.OnGenderChanged();
		    }
		}
		
        partial void OnRegistrationYearChanging(int? value);
        partial void OnRegistrationYearChanged();
		
		private int? _RegistrationYear;
		public int? RegistrationYear { 
		    get{
		        return _RegistrationYear;
		    } 
		    set{
		        this.OnRegistrationYearChanging(value);
                this.SendPropertyChanging();
                this._RegistrationYear = value;
                this.SendPropertyChanged("RegistrationYear");
                this.OnRegistrationYearChanged();
		    }
		}
		
        partial void OnRegistrationNumberChanging(string value);
        partial void OnRegistrationNumberChanged();
		
		private string _RegistrationNumber;
		public string RegistrationNumber { 
		    get{
		        return _RegistrationNumber;
		    } 
		    set{
		        this.OnRegistrationNumberChanging(value);
                this.SendPropertyChanging();
                this._RegistrationNumber = value;
                this.SendPropertyChanged("RegistrationNumber");
                this.OnRegistrationNumberChanged();
		    }
		}
		
        partial void OnExperienceChanging(decimal? value);
        partial void OnExperienceChanged();
		
		private decimal? _Experience;
		public decimal? Experience { 
		    get{
		        return _Experience;
		    } 
		    set{
		        this.OnExperienceChanging(value);
                this.SendPropertyChanging();
                this._Experience = value;
                this.SendPropertyChanged("Experience");
                this.OnExperienceChanged();
		    }
		}
		
        partial void OnDegreesChanging(string value);
        partial void OnDegreesChanged();
		
		private string _Degrees;
		public string Degrees { 
		    get{
		        return _Degrees;
		    } 
		    set{
		        this.OnDegreesChanging(value);
                this.SendPropertyChanging();
                this._Degrees = value;
                this.SendPropertyChanged("Degrees");
                this.OnDegreesChanged();
		    }
		}
		
        partial void OnCertificationsChanging(string value);
        partial void OnCertificationsChanged();
		
		private string _Certifications;
		public string Certifications { 
		    get{
		        return _Certifications;
		    } 
		    set{
		        this.OnCertificationsChanging(value);
                this.SendPropertyChanging();
                this._Certifications = value;
                this.SendPropertyChanged("Certifications");
                this.OnCertificationsChanged();
		    }
		}
		
        partial void OnPhotoNameChanging(string value);
        partial void OnPhotoNameChanged();
		
		private string _PhotoName;
		public string PhotoName { 
		    get{
		        return _PhotoName;
		    } 
		    set{
		        this.OnPhotoNameChanging(value);
                this.SendPropertyChanging();
                this._PhotoName = value;
                this.SendPropertyChanged("PhotoName");
                this.OnPhotoNameChanged();
		    }
		}
		
        partial void OnMobileChanging(string value);
        partial void OnMobileChanged();
		
		private string _Mobile;
		public string Mobile { 
		    get{
		        return _Mobile;
		    } 
		    set{
		        this.OnMobileChanging(value);
                this.SendPropertyChanging();
                this._Mobile = value;
                this.SendPropertyChanged("Mobile");
                this.OnMobileChanged();
		    }
		}
		
        partial void OnDepartmentIdChanging(int? value);
        partial void OnDepartmentIdChanged();
		
		private int? _DepartmentId;
		public int? DepartmentId { 
		    get{
		        return _DepartmentId;
		    } 
		    set{
		        this.OnDepartmentIdChanging(value);
                this.SendPropertyChanging();
                this._DepartmentId = value;
                this.SendPropertyChanged("DepartmentId");
                this.OnDepartmentIdChanged();
		    }
		}
		
        partial void OnPreferredNameChanging(string value);
        partial void OnPreferredNameChanged();
		
		private string _PreferredName;
		public string PreferredName { 
		    get{
		        return _PreferredName;
		    } 
		    set{
		        this.OnPreferredNameChanging(value);
                this.SendPropertyChanging();
                this._PreferredName = value;
                this.SendPropertyChanged("PreferredName");
                this.OnPreferredNameChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnReferenceTokenChanging(string value);
        partial void OnReferenceTokenChanged();
		
		private string _ReferenceToken;
		public string ReferenceToken { 
		    get{
		        return _ReferenceToken;
		    } 
		    set{
		        this.OnReferenceTokenChanging(value);
                this.SendPropertyChanging();
                this._ReferenceToken = value;
                this.SendPropertyChanged("ReferenceToken");
                this.OnReferenceTokenChanged();
		    }
		}
		
        partial void OnIsActivatedChanging(bool? value);
        partial void OnIsActivatedChanged();
		
		private bool? _IsActivated;
		public bool? IsActivated { 
		    get{
		        return _IsActivated;
		    } 
		    set{
		        this.OnIsActivatedChanging(value);
                this.SendPropertyChanging();
                this._IsActivated = value;
                this.SendPropertyChanged("IsActivated");
                this.OnIsActivatedChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnUniversityIdChanging(int? value);
        partial void OnUniversityIdChanged();
		
		private int? _UniversityId;
		public int? UniversityId { 
		    get{
		        return _UniversityId;
		    } 
		    set{
		        this.OnUniversityIdChanging(value);
                this.SendPropertyChanging();
                this._UniversityId = value;
                this.SendPropertyChanged("UniversityId");
                this.OnUniversityIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Answer> TBL_Answers
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Answers
                       where items.DoctorId == _DoctorId
                       select items;
            }
        }

        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.DoctorId == _DoctorId
                       select items;
            }
        }

        public IQueryable<TBL_Login> TBL_Logins
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Logins
                       where items.LoginId == _LoginId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Department> TBL_Master_Departments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Departments
                       where items.DepartmentId == _DepartmentId
                       select items;
            }
        }

        public IQueryable<TBL_Doctor_Timing> TBL_Doctor_Timings
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctor_Timings
                       where items.DoctorId == _DoctorId
                       select items;
            }
        }

        public IQueryable<TBL_Reference> TBL_References
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_References
                       where items.ReferedBy == _DoctorId
                       select items;
            }
        }

        public IQueryable<TBL_Reference> TBL_References6
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_References
                       where items.ReferedTo == _DoctorId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Landing_VideoGallery table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Landing_VideoGallery 
    /// </summary>

	public partial class TBL_Landing_VideoGallery: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Landing_VideoGallery(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAccountIdChanging(int? value);
        partial void OnAccountIdChanged();
		
		private int? _AccountId;
		public int? AccountId { 
		    get{
		        return _AccountId;
		    } 
		    set{
		        this.OnAccountIdChanging(value);
                this.SendPropertyChanging();
                this._AccountId = value;
                this.SendPropertyChanged("AccountId");
                this.OnAccountIdChanged();
		    }
		}
		
        partial void OnAccountTypeIdChanging(int? value);
        partial void OnAccountTypeIdChanged();
		
		private int? _AccountTypeId;
		public int? AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnVersionChanging(int? value);
        partial void OnVersionChanged();
		
		private int? _Version;
		public int? Version { 
		    get{
		        return _Version;
		    } 
		    set{
		        this.OnVersionChanging(value);
                this.SendPropertyChanging();
                this._Version = value;
                this.SendPropertyChanged("Version");
                this.OnVersionChanged();
		    }
		}
		
        partial void OnVideoContentChanging(string value);
        partial void OnVideoContentChanged();
		
		private string _VideoContent;
		public string VideoContent { 
		    get{
		        return _VideoContent;
		    } 
		    set{
		        this.OnVideoContentChanging(value);
                this.SendPropertyChanging();
                this._VideoContent = value;
                this.SendPropertyChanged("VideoContent");
                this.OnVideoContentChanged();
		    }
		}
		
        partial void OnSelectedChanging(bool? value);
        partial void OnSelectedChanged();
		
		private bool? _Selected;
		public bool? Selected { 
		    get{
		        return _Selected;
		    } 
		    set{
		        this.OnSelectedChanging(value);
                this.SendPropertyChanging();
                this._Selected = value;
                this.SendPropertyChanged("Selected");
                this.OnSelectedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_Bed table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_Bed 
    /// </summary>

	public partial class TBL_Master_Bed: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_Bed(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
		
		private int _Id;
		public int Id { 
		    get{
		        return _Id;
		    } 
		    set{
		        this.OnIdChanging(value);
                this.SendPropertyChanging();
                this._Id = value;
                this.SendPropertyChanged("Id");
                this.OnIdChanged();
		    }
		}
		
        partial void OnWardIdChanging(int? value);
        partial void OnWardIdChanged();
		
		private int? _WardId;
		public int? WardId { 
		    get{
		        return _WardId;
		    } 
		    set{
		        this.OnWardIdChanging(value);
                this.SendPropertyChanging();
                this._WardId = value;
                this.SendPropertyChanged("WardId");
                this.OnWardIdChanged();
		    }
		}
		
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
		
		private string _Name;
		public string Name { 
		    get{
		        return _Name;
		    } 
		    set{
		        this.OnNameChanging(value);
                this.SendPropertyChanging();
                this._Name = value;
                this.SendPropertyChanged("Name");
                this.OnNameChanged();
		    }
		}
		
        partial void OnFloorIdChanging(int? value);
        partial void OnFloorIdChanged();
		
		private int? _FloorId;
		public int? FloorId { 
		    get{
		        return _FloorId;
		    } 
		    set{
		        this.OnFloorIdChanging(value);
                this.SendPropertyChanging();
                this._FloorId = value;
                this.SendPropertyChanged("FloorId");
                this.OnFloorIdChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnBuildingIdChanging(int? value);
        partial void OnBuildingIdChanged();
		
		private int? _BuildingId;
		public int? BuildingId { 
		    get{
		        return _BuildingId;
		    } 
		    set{
		        this.OnBuildingIdChanging(value);
                this.SendPropertyChanging();
                this._BuildingId = value;
                this.SendPropertyChanged("BuildingId");
                this.OnBuildingIdChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Master_SubAccountType table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Master_SubAccountType 
    /// </summary>

	public partial class TBL_Master_SubAccountType: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Master_SubAccountType(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnSubAccountTypeChanging(int value);
        partial void OnSubAccountTypeChanged();
		
		private int _SubAccountType;
		public int SubAccountType { 
		    get{
		        return _SubAccountType;
		    } 
		    set{
		        this.OnSubAccountTypeChanging(value);
                this.SendPropertyChanging();
                this._SubAccountType = value;
                this.SendPropertyChanged("SubAccountType");
                this.OnSubAccountTypeChanged();
		    }
		}
		
        partial void OnSubAccountNameChanging(string value);
        partial void OnSubAccountNameChanged();
		
		private string _SubAccountName;
		public string SubAccountName { 
		    get{
		        return _SubAccountName;
		    } 
		    set{
		        this.OnSubAccountNameChanging(value);
                this.SendPropertyChanging();
                this._SubAccountName = value;
                this.SendPropertyChanged("SubAccountName");
                this.OnSubAccountNameChanged();
		    }
		}
		
        partial void OnAccountTypeIdChanging(int? value);
        partial void OnAccountTypeIdChanged();
		
		private int? _AccountTypeId;
		public int? AccountTypeId { 
		    get{
		        return _AccountTypeId;
		    } 
		    set{
		        this.OnAccountTypeIdChanging(value);
                this.SendPropertyChanging();
                this._AccountTypeId = value;
                this.SendPropertyChanged("AccountTypeId");
                this.OnAccountTypeIdChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_ActivationSMSCount table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_ActivationSMSCount 
    /// </summary>

	public partial class TBL_ActivationSMSCount: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_ActivationSMSCount(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
		
		private int _ID;
		public int ID { 
		    get{
		        return _ID;
		    } 
		    set{
		        this.OnIDChanging(value);
                this.SendPropertyChanging();
                this._ID = value;
                this.SendPropertyChanged("ID");
                this.OnIDChanged();
		    }
		}
		
        partial void OnMobileChanging(string value);
        partial void OnMobileChanged();
		
		private string _Mobile;
		public string Mobile { 
		    get{
		        return _Mobile;
		    } 
		    set{
		        this.OnMobileChanging(value);
                this.SendPropertyChanging();
                this._Mobile = value;
                this.SendPropertyChanged("Mobile");
                this.OnMobileChanged();
		    }
		}
		
        partial void OnIPAddressChanging(string value);
        partial void OnIPAddressChanged();
		
		private string _IPAddress;
		public string IPAddress { 
		    get{
		        return _IPAddress;
		    } 
		    set{
		        this.OnIPAddressChanging(value);
                this.SendPropertyChanging();
                this._IPAddress = value;
                this.SendPropertyChanged("IPAddress");
                this.OnIPAddressChanged();
		    }
		}
		
        partial void OnSMSCountChanging(int? value);
        partial void OnSMSCountChanged();
		
		private int? _SMSCount;
		public int? SMSCount { 
		    get{
		        return _SMSCount;
		    } 
		    set{
		        this.OnSMSCountChanging(value);
                this.SendPropertyChanging();
                this._SMSCount = value;
                this.SendPropertyChanged("SMSCount");
                this.OnSMSCountChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnIsVerifiedChanging(bool? value);
        partial void OnIsVerifiedChanged();
		
		private bool? _IsVerified;
		public bool? IsVerified { 
		    get{
		        return _IsVerified;
		    } 
		    set{
		        this.OnIsVerifiedChanging(value);
                this.SendPropertyChanging();
                this._IsVerified = value;
                this.SendPropertyChanged("IsVerified");
                this.OnIsVerifiedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Service table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Service 
    /// </summary>

	public partial class TBL_Service: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Service(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnServiceIdChanging(int value);
        partial void OnServiceIdChanged();
		
		private int _ServiceId;
		public int ServiceId { 
		    get{
		        return _ServiceId;
		    } 
		    set{
		        this.OnServiceIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceId = value;
                this.SendPropertyChanged("ServiceId");
                this.OnServiceIdChanged();
		    }
		}
		
        partial void OnLoginIdChanging(int? value);
        partial void OnLoginIdChanged();
		
		private int? _LoginId;
		public int? LoginId { 
		    get{
		        return _LoginId;
		    } 
		    set{
		        this.OnLoginIdChanging(value);
                this.SendPropertyChanging();
                this._LoginId = value;
                this.SendPropertyChanged("LoginId");
                this.OnLoginIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnServiceNameChanging(string value);
        partial void OnServiceNameChanged();
		
		private string _ServiceName;
		public string ServiceName { 
		    get{
		        return _ServiceName;
		    } 
		    set{
		        this.OnServiceNameChanging(value);
                this.SendPropertyChanging();
                this._ServiceName = value;
                this.SendPropertyChanged("ServiceName");
                this.OnServiceNameChanged();
		    }
		}
		
        partial void OnInChargeChanging(string value);
        partial void OnInChargeChanged();
		
		private string _InCharge;
		public string InCharge { 
		    get{
		        return _InCharge;
		    } 
		    set{
		        this.OnInChargeChanging(value);
                this.SendPropertyChanging();
                this._InCharge = value;
                this.SendPropertyChanged("InCharge");
                this.OnInChargeChanged();
		    }
		}
		
        partial void OnDepartmentIdChanging(int? value);
        partial void OnDepartmentIdChanged();
		
		private int? _DepartmentId;
		public int? DepartmentId { 
		    get{
		        return _DepartmentId;
		    } 
		    set{
		        this.OnDepartmentIdChanging(value);
                this.SendPropertyChanging();
                this._DepartmentId = value;
                this.SendPropertyChanged("DepartmentId");
                this.OnDepartmentIdChanged();
		    }
		}
		
        partial void OnUnitsChanging(int? value);
        partial void OnUnitsChanged();
		
		private int? _Units;
		public int? Units { 
		    get{
		        return _Units;
		    } 
		    set{
		        this.OnUnitsChanging(value);
                this.SendPropertyChanging();
                this._Units = value;
                this.SendPropertyChanged("Units");
                this.OnUnitsChanged();
		    }
		}
		
        partial void OnMobileChanging(string value);
        partial void OnMobileChanged();
		
		private string _Mobile;
		public string Mobile { 
		    get{
		        return _Mobile;
		    } 
		    set{
		        this.OnMobileChanging(value);
                this.SendPropertyChanging();
                this._Mobile = value;
                this.SendPropertyChanged("Mobile");
                this.OnMobileChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnReferenceTokenChanging(string value);
        partial void OnReferenceTokenChanged();
		
		private string _ReferenceToken;
		public string ReferenceToken { 
		    get{
		        return _ReferenceToken;
		    } 
		    set{
		        this.OnReferenceTokenChanging(value);
                this.SendPropertyChanging();
                this._ReferenceToken = value;
                this.SendPropertyChanged("ReferenceToken");
                this.OnReferenceTokenChanged();
		    }
		}
		
        partial void OnIsActivatedChanging(bool? value);
        partial void OnIsActivatedChanged();
		
		private bool? _IsActivated;
		public bool? IsActivated { 
		    get{
		        return _IsActivated;
		    } 
		    set{
		        this.OnIsActivatedChanging(value);
                this.SendPropertyChanging();
                this._IsActivated = value;
                this.SendPropertyChanged("IsActivated");
                this.OnIsActivatedChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Appointment> TBL_Appointments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Appointments
                       where items.ServiceId == _ServiceId
                       select items;
            }
        }

        public IQueryable<TBL_Login> TBL_Logins
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Logins
                       where items.LoginId == _LoginId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Department> TBL_Master_Departments
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Departments
                       where items.DepartmentId == _DepartmentId
                       select items;
            }
        }

        public IQueryable<TBL_Service_Timing> TBL_Service_Timings
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Service_Timings
                       where items.ServiceId == _ServiceId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
    
    
    /// <summary>
    /// A class which represents the TBL_Appointment table in the mobilesitedesigner Database.
    /// This class is queryable through mobilesitedesignerDB.TBL_Appointment 
    /// </summary>

	public partial class TBL_Appointment: INotifyPropertyChanging, INotifyPropertyChanged
	{
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
	    
	    public TBL_Appointment(){
	        OnCreated();
	    }
	    
	    #region Properties
	    
        partial void OnAppointmentIdChanging(int value);
        partial void OnAppointmentIdChanged();
		
		private int _AppointmentId;
		public int AppointmentId { 
		    get{
		        return _AppointmentId;
		    } 
		    set{
		        this.OnAppointmentIdChanging(value);
                this.SendPropertyChanging();
                this._AppointmentId = value;
                this.SendPropertyChanged("AppointmentId");
                this.OnAppointmentIdChanged();
		    }
		}
		
        partial void OnPatientIdChanging(int? value);
        partial void OnPatientIdChanged();
		
		private int? _PatientId;
		public int? PatientId { 
		    get{
		        return _PatientId;
		    } 
		    set{
		        this.OnPatientIdChanging(value);
                this.SendPropertyChanging();
                this._PatientId = value;
                this.SendPropertyChanged("PatientId");
                this.OnPatientIdChanged();
		    }
		}
		
        partial void OnOrganizationIdChanging(int? value);
        partial void OnOrganizationIdChanged();
		
		private int? _OrganizationId;
		public int? OrganizationId { 
		    get{
		        return _OrganizationId;
		    } 
		    set{
		        this.OnOrganizationIdChanging(value);
                this.SendPropertyChanging();
                this._OrganizationId = value;
                this.SendPropertyChanged("OrganizationId");
                this.OnOrganizationIdChanged();
		    }
		}
		
        partial void OnServiceIdChanging(int? value);
        partial void OnServiceIdChanged();
		
		private int? _ServiceId;
		public int? ServiceId { 
		    get{
		        return _ServiceId;
		    } 
		    set{
		        this.OnServiceIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceId = value;
                this.SendPropertyChanged("ServiceId");
                this.OnServiceIdChanged();
		    }
		}
		
        partial void OnServiceTimingIdChanging(int? value);
        partial void OnServiceTimingIdChanged();
		
		private int? _ServiceTimingId;
		public int? ServiceTimingId { 
		    get{
		        return _ServiceTimingId;
		    } 
		    set{
		        this.OnServiceTimingIdChanging(value);
                this.SendPropertyChanging();
                this._ServiceTimingId = value;
                this.SendPropertyChanged("ServiceTimingId");
                this.OnServiceTimingIdChanged();
		    }
		}
		
        partial void OnDoctorIdChanging(int? value);
        partial void OnDoctorIdChanged();
		
		private int? _DoctorId;
		public int? DoctorId { 
		    get{
		        return _DoctorId;
		    } 
		    set{
		        this.OnDoctorIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorId = value;
                this.SendPropertyChanged("DoctorId");
                this.OnDoctorIdChanged();
		    }
		}
		
        partial void OnDoctorTimingIdChanging(int? value);
        partial void OnDoctorTimingIdChanged();
		
		private int? _DoctorTimingId;
		public int? DoctorTimingId { 
		    get{
		        return _DoctorTimingId;
		    } 
		    set{
		        this.OnDoctorTimingIdChanging(value);
                this.SendPropertyChanging();
                this._DoctorTimingId = value;
                this.SendPropertyChanged("DoctorTimingId");
                this.OnDoctorTimingIdChanged();
		    }
		}
		
        partial void OnAppointmentDateChanging(DateTime? value);
        partial void OnAppointmentDateChanged();
		
		private DateTime? _AppointmentDate;
		public DateTime? AppointmentDate { 
		    get{
		        return _AppointmentDate;
		    } 
		    set{
		        this.OnAppointmentDateChanging(value);
                this.SendPropertyChanging();
                this._AppointmentDate = value;
                this.SendPropertyChanged("AppointmentDate");
                this.OnAppointmentDateChanged();
		    }
		}
		
        partial void OnAppointmentTimeChanging(string value);
        partial void OnAppointmentTimeChanged();
		
		private string _AppointmentTime;
		public string AppointmentTime { 
		    get{
		        return _AppointmentTime;
		    } 
		    set{
		        this.OnAppointmentTimeChanging(value);
                this.SendPropertyChanging();
                this._AppointmentTime = value;
                this.SendPropertyChanged("AppointmentTime");
                this.OnAppointmentTimeChanged();
		    }
		}
		
        partial void OnOnCallAppointmentTimeChanging(string value);
        partial void OnOnCallAppointmentTimeChanged();
		
		private string _OnCallAppointmentTime;
		public string OnCallAppointmentTime { 
		    get{
		        return _OnCallAppointmentTime;
		    } 
		    set{
		        this.OnOnCallAppointmentTimeChanging(value);
                this.SendPropertyChanging();
                this._OnCallAppointmentTime = value;
                this.SendPropertyChanged("OnCallAppointmentTime");
                this.OnOnCallAppointmentTimeChanged();
		    }
		}
		
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
		
		private string _Notes;
		public string Notes { 
		    get{
		        return _Notes;
		    } 
		    set{
		        this.OnNotesChanging(value);
                this.SendPropertyChanging();
                this._Notes = value;
                this.SendPropertyChanged("Notes");
                this.OnNotesChanged();
		    }
		}
		
        partial void OnIsCarParkingChanging(bool? value);
        partial void OnIsCarParkingChanged();
		
		private bool? _IsCarParking;
		public bool? IsCarParking { 
		    get{
		        return _IsCarParking;
		    } 
		    set{
		        this.OnIsCarParkingChanging(value);
                this.SendPropertyChanging();
                this._IsCarParking = value;
                this.SendPropertyChanged("IsCarParking");
                this.OnIsCarParkingChanged();
		    }
		}
		
        partial void OnCarNumberChanging(string value);
        partial void OnCarNumberChanged();
		
		private string _CarNumber;
		public string CarNumber { 
		    get{
		        return _CarNumber;
		    } 
		    set{
		        this.OnCarNumberChanging(value);
                this.SendPropertyChanging();
                this._CarNumber = value;
                this.SendPropertyChanged("CarNumber");
                this.OnCarNumberChanged();
		    }
		}
		
        partial void OnPreferentialIdChanging(int? value);
        partial void OnPreferentialIdChanged();
		
		private int? _PreferentialId;
		public int? PreferentialId { 
		    get{
		        return _PreferentialId;
		    } 
		    set{
		        this.OnPreferentialIdChanging(value);
                this.SendPropertyChanging();
                this._PreferentialId = value;
                this.SendPropertyChanged("PreferentialId");
                this.OnPreferentialIdChanged();
		    }
		}
		
        partial void OnPreferentialBoardingChanging(string value);
        partial void OnPreferentialBoardingChanged();
		
		private string _PreferentialBoarding;
		public string PreferentialBoarding { 
		    get{
		        return _PreferentialBoarding;
		    } 
		    set{
		        this.OnPreferentialBoardingChanging(value);
                this.SendPropertyChanging();
                this._PreferentialBoarding = value;
                this.SendPropertyChanged("PreferentialBoarding");
                this.OnPreferentialBoardingChanged();
		    }
		}
		
        partial void OnDoctorClosingNotesChanging(string value);
        partial void OnDoctorClosingNotesChanged();
		
		private string _DoctorClosingNotes;
		public string DoctorClosingNotes { 
		    get{
		        return _DoctorClosingNotes;
		    } 
		    set{
		        this.OnDoctorClosingNotesChanging(value);
                this.SendPropertyChanging();
                this._DoctorClosingNotes = value;
                this.SendPropertyChanged("DoctorClosingNotes");
                this.OnDoctorClosingNotesChanged();
		    }
		}
		
        partial void OnStatusIdChanging(int? value);
        partial void OnStatusIdChanged();
		
		private int? _StatusId;
		public int? StatusId { 
		    get{
		        return _StatusId;
		    } 
		    set{
		        this.OnStatusIdChanging(value);
                this.SendPropertyChanging();
                this._StatusId = value;
                this.SendPropertyChanged("StatusId");
                this.OnStatusIdChanged();
		    }
		}
		
        partial void OnIsDirectAppointmentChanging(bool? value);
        partial void OnIsDirectAppointmentChanged();
		
		private bool? _IsDirectAppointment;
		public bool? IsDirectAppointment { 
		    get{
		        return _IsDirectAppointment;
		    } 
		    set{
		        this.OnIsDirectAppointmentChanging(value);
                this.SendPropertyChanging();
                this._IsDirectAppointment = value;
                this.SendPropertyChanged("IsDirectAppointment");
                this.OnIsDirectAppointmentChanged();
		    }
		}
		
        partial void OnCreatedOnChanging(DateTime? value);
        partial void OnCreatedOnChanged();
		
		private DateTime? _CreatedOn;
		public DateTime? CreatedOn { 
		    get{
		        return _CreatedOn;
		    } 
		    set{
		        this.OnCreatedOnChanging(value);
                this.SendPropertyChanging();
                this._CreatedOn = value;
                this.SendPropertyChanged("CreatedOn");
                this.OnCreatedOnChanged();
		    }
		}
		
        partial void OnModifiedOnChanging(DateTime? value);
        partial void OnModifiedOnChanged();
		
		private DateTime? _ModifiedOn;
		public DateTime? ModifiedOn { 
		    get{
		        return _ModifiedOn;
		    } 
		    set{
		        this.OnModifiedOnChanging(value);
                this.SendPropertyChanging();
                this._ModifiedOn = value;
                this.SendPropertyChanged("ModifiedOn");
                this.OnModifiedOnChanged();
		    }
		}
		
        partial void OnIsDeletedChanging(bool? value);
        partial void OnIsDeletedChanged();
		
		private bool? _IsDeleted;
		public bool? IsDeleted { 
		    get{
		        return _IsDeleted;
		    } 
		    set{
		        this.OnIsDeletedChanging(value);
                this.SendPropertyChanging();
                this._IsDeleted = value;
                this.SendPropertyChanged("IsDeleted");
                this.OnIsDeletedChanged();
		    }
		}
		

        #endregion

        #region Foreign Keys
        public IQueryable<TBL_Doctor> TBL_Doctors
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Doctors
                       where items.DoctorId == _DoctorId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Preferential> TBL_Master_Preferentials
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Preferentials
                       where items.PreferentialId == _PreferentialId
                       select items;
            }
        }

        public IQueryable<TBL_Master_Status> TBL_Master_Statuses
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Master_Statuses
                       where items.StatusId == _StatusId
                       select items;
            }
        }

        public IQueryable<TBL_Patient> TBL_Patients
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Patients
                       where items.PatientId == _PatientId
                       select items;
            }
        }

        public IQueryable<TBL_Service> TBL_Services
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Services
                       where items.ServiceId == _ServiceId
                       select items;
            }
        }

        public IQueryable<TBL_Rating> TBL_Ratings
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Ratings
                       where items.AppointmentId == _AppointmentId
                       select items;
            }
        }

        public IQueryable<TBL_Token> TBL_Tokens
        {
            get
            {
                  var db=new SubSonic.POCOS1.DB.mobilesitedesignerDB();
                  return from items in db.TBL_Tokens
                       where items.AppointmentId == _AppointmentId
                       select items;
            }
        }

        #endregion


        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void SendPropertyChanging()
        {
            var handler = PropertyChanging;
            if (handler != null)
               handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

	}
	
}