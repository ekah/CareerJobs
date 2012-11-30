


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

namespace SubSonic.POCOS.DB
{
    public partial class mobilesitedesignerDB : IQuerySurface
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

        public mobilesitedesignerDB() 
        {
            if (DefaultDataProvider == null) {
                DataProvider = ProviderFactory.GetProvider("DataConnectionString");
            }
            else {
                DataProvider = DefaultDataProvider;
            }
            Init();
        }

        public mobilesitedesignerDB(string connectionStringName)
        {
            DataProvider = ProviderFactory.GetProvider(connectionStringName);
            Init();
        }

		public mobilesitedesignerDB(string connectionString, string providerName)
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
			
        public Query<TBL_Patient_Reference> TBL_Patient_References { get; set; }
        public Query<TBL_Job_Location> TBL_Job_Locations { get; set; }
        public Query<TBL_Master_Building> TBL_Master_Buildings { get; set; }
        public Query<TBL_Master_SymptomGroup> TBL_Master_SymptomGroups { get; set; }
        public Query<TBL_Master_Floor> TBL_Master_Floors { get; set; }
        public Query<Tbl_Master_Ward> Tbl_Master_Wards { get; set; }
        public Query<TBL_Rating> TBL_Ratings { get; set; }
        public Query<TBL_Master_Symptom> TBL_Master_Symptoms { get; set; }
        public Query<TBL_Master_Preferential> TBL_Master_Preferentials { get; set; }
        public Query<TBL_Master_Diagnosi> TBL_Master_Diagnosis { get; set; }
        public Query<TBL_Answer> TBL_Answers { get; set; }
        public Query<TBL_SM> TBL_SMS { get; set; }
        public Query<TBL_Symptom_Diagnosi> TBL_Symptom_Diagnosis { get; set; }
        public Query<TBL_Diagnosis_Department> TBL_Diagnosis_Departments { get; set; }
        public Query<TBL_Question> TBL_Questions { get; set; }
        public Query<TBL_Doctor_Diagnosi> TBL_Doctor_Diagnosis { get; set; }
        public Query<TBL_Feedback> TBL_Feedbacks { get; set; }
        public Query<TBL_KeywordSM> TBL_KeywordSMs { get; set; }
        public Query<TBL_Master_FamilyHistory> TBL_Master_FamilyHistories { get; set; }
        public Query<TBL_Appointment_Winservice> TBL_Appointment_Winservices { get; set; }
        public Query<TBL_Master_Relationship> TBL_Master_Relationships { get; set; }
        public Query<TBL_Master_Status> TBL_Master_Statuses { get; set; }
        public Query<TBL_Doctor_Experience> TBL_Doctor_Experiences { get; set; }
        public Query<TBL_Master_PersonalHistory> TBL_Master_PersonalHistories { get; set; }
        public Query<TBL_Patient_SearchCount> TBL_Patient_SearchCounts { get; set; }
        public Query<TBL_Patient_FamilyHistory> TBL_Patient_FamilyHistories { get; set; }
        public Query<TBL_Master_PastHistory> TBL_Master_PastHistories { get; set; }
        public Query<TBL_Patient> TBL_Patients { get; set; }
        public Query<TBL_Master_AccountType> TBL_Master_AccountTypes { get; set; }
        public Query<TBL_Reference> TBL_References { get; set; }
        public Query<TBL_Patient_PersonalHistory> TBL_Patient_PersonalHistories { get; set; }
        public Query<TBL_Patient_PastHistory> TBL_Patient_PastHistories { get; set; }
        public Query<TBL_Master_Department> TBL_Master_Departments { get; set; }
        public Query<TBL_Master_City_old> TBL_Master_City_olds { get; set; }
        public Query<TBL_Master_State_old> TBL_Master_State_olds { get; set; }
        public Query<TBL_GeoPostcode> TBL_GeoPostcodes { get; set; }
        public Query<TBL_Master_Country_old> TBL_Master_Country_olds { get; set; }
        public Query<TBL_Mapping_Status> TBL_Mapping_Statuses { get; set; }
        public Query<TBL_GeoPostcodes_Country> TBL_GeoPostcodes_Countries { get; set; }
        public Query<TBL_Mapping_Bed> TBL_Mapping_Beds { get; set; }
        public Query<TBL_Doctor_Timing> TBL_Doctor_Timings { get; set; }
        public Query<Tbl_Temp_State> Tbl_Temp_States { get; set; }
        public Query<TBL_GeoPostcodes_State> TBL_GeoPostcodes_States { get; set; }
        public Query<TBL_Job_SubAdminLogin> TBL_Job_SubAdminLogins { get; set; }
        public Query<TBL_Patient_UHID> TBL_Patient_UHIDs { get; set; }
        public Query<TBL_GeoPostcodes_City> TBL_GeoPostcodes_Cities { get; set; }
        public Query<TBL_Job_Speciality> TBL_Job_Specialities { get; set; }
        public Query<TBL_Landing_MainTab> TBL_Landing_MainTabs { get; set; }
        public Query<TBL_BlockCalendar> TBL_BlockCalendars { get; set; }
        public Query<TBL_Job_SearchWidgetColVisible> TBL_Job_SearchWidgetColVisibles { get; set; }
        public Query<TBL_Service_Timing> TBL_Service_Timings { get; set; }
        public Query<TBL_Job_SearchResultsColVisible> TBL_Job_SearchResultsColVisibles { get; set; }
        public Query<TBL_Landing_SubTab> TBL_Landing_SubTabs { get; set; }
        public Query<TBL_Job_SearchDescriptionColVisible> TBL_Job_SearchDescriptionColVisibles { get; set; }
        public Query<TBL_Job_NewsLetter> TBL_Job_NewsLetters { get; set; }
        public Query<Tbl_Appointment_Comment> Tbl_Appointment_Comments { get; set; }
        public Query<TBL_Job_Job> TBL_Job_Jobs { get; set; }
        public Query<TBL_Login> TBL_Logins { get; set; }
        public Query<TBL_Job_HrLogin> TBL_Job_HrLogins { get; set; }
        public Query<TBL_Job_HotOppsColVisible> TBL_Job_HotOppsColVisibles { get; set; }
        public Query<TBL_Job_Facility> TBL_Job_Facilities { get; set; }
        public Query<TBL_Service_Diagnosi> TBL_Service_Diagnosis { get; set; }
        public Query<TBL_Job_Apply> TBL_Job_Applies { get; set; }
        public Query<TBL_GupShup> TBL_GupShups { get; set; }
        public Query<TBL_Landing_ImageGallery> TBL_Landing_ImageGalleries { get; set; }
        public Query<TBL_Organization> TBL_Organizations { get; set; }
        public Query<TBL_Token> TBL_Tokens { get; set; }
        public Query<Content> Contents { get; set; }
        public Query<Page> Pages { get; set; }
        public Query<TBL_GupShup_FailureReason> TBL_GupShup_FailureReasons { get; set; }
        public Query<TBL_Master_Banner> TBL_Master_Banners { get; set; }
        public Query<TBL_Landing> TBL_Landings { get; set; }
        public Query<TBL_Doctor_Education> TBL_Doctor_Educations { get; set; }
        public Query<TBL_Master_University> TBL_Master_Universities { get; set; }
        public Query<TBL_Landing_Publish> TBL_Landing_Publishes { get; set; }
        public Query<TBL_Admin_LoginType> TBL_Admin_LoginTypes { get; set; }
        public Query<TBL_Doctor> TBL_Doctors { get; set; }
        public Query<TBL_Landing_VideoGallery> TBL_Landing_VideoGalleries { get; set; }
        public Query<TBL_Master_Bed> TBL_Master_Beds { get; set; }
        public Query<TBL_Master_SubAccountType> TBL_Master_SubAccountTypes { get; set; }
        public Query<TBL_ActivationSMSCount> TBL_ActivationSMSCounts { get; set; }
        public Query<TBL_Service> TBL_Services { get; set; }
        public Query<TBL_Appointment> TBL_Appointments { get; set; }

			

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
            TBL_Patient_References = new Query<TBL_Patient_Reference>(provider);
            TBL_Job_Locations = new Query<TBL_Job_Location>(provider);
            TBL_Master_Buildings = new Query<TBL_Master_Building>(provider);
            TBL_Master_SymptomGroups = new Query<TBL_Master_SymptomGroup>(provider);
            TBL_Master_Floors = new Query<TBL_Master_Floor>(provider);
            Tbl_Master_Wards = new Query<Tbl_Master_Ward>(provider);
            TBL_Ratings = new Query<TBL_Rating>(provider);
            TBL_Master_Symptoms = new Query<TBL_Master_Symptom>(provider);
            TBL_Master_Preferentials = new Query<TBL_Master_Preferential>(provider);
            TBL_Master_Diagnosis = new Query<TBL_Master_Diagnosi>(provider);
            TBL_Answers = new Query<TBL_Answer>(provider);
            TBL_SMS = new Query<TBL_SM>(provider);
            TBL_Symptom_Diagnosis = new Query<TBL_Symptom_Diagnosi>(provider);
            TBL_Diagnosis_Departments = new Query<TBL_Diagnosis_Department>(provider);
            TBL_Questions = new Query<TBL_Question>(provider);
            TBL_Doctor_Diagnosis = new Query<TBL_Doctor_Diagnosi>(provider);
            TBL_Feedbacks = new Query<TBL_Feedback>(provider);
            TBL_KeywordSMs = new Query<TBL_KeywordSM>(provider);
            TBL_Master_FamilyHistories = new Query<TBL_Master_FamilyHistory>(provider);
            TBL_Appointment_Winservices = new Query<TBL_Appointment_Winservice>(provider);
            TBL_Master_Relationships = new Query<TBL_Master_Relationship>(provider);
            TBL_Master_Statuses = new Query<TBL_Master_Status>(provider);
            TBL_Doctor_Experiences = new Query<TBL_Doctor_Experience>(provider);
            TBL_Master_PersonalHistories = new Query<TBL_Master_PersonalHistory>(provider);
            TBL_Patient_SearchCounts = new Query<TBL_Patient_SearchCount>(provider);
            TBL_Patient_FamilyHistories = new Query<TBL_Patient_FamilyHistory>(provider);
            TBL_Master_PastHistories = new Query<TBL_Master_PastHistory>(provider);
            TBL_Patients = new Query<TBL_Patient>(provider);
            TBL_Master_AccountTypes = new Query<TBL_Master_AccountType>(provider);
            TBL_References = new Query<TBL_Reference>(provider);
            TBL_Patient_PersonalHistories = new Query<TBL_Patient_PersonalHistory>(provider);
            TBL_Patient_PastHistories = new Query<TBL_Patient_PastHistory>(provider);
            TBL_Master_Departments = new Query<TBL_Master_Department>(provider);
            TBL_Master_City_olds = new Query<TBL_Master_City_old>(provider);
            TBL_Master_State_olds = new Query<TBL_Master_State_old>(provider);
            TBL_GeoPostcodes = new Query<TBL_GeoPostcode>(provider);
            TBL_Master_Country_olds = new Query<TBL_Master_Country_old>(provider);
            TBL_Mapping_Statuses = new Query<TBL_Mapping_Status>(provider);
            TBL_GeoPostcodes_Countries = new Query<TBL_GeoPostcodes_Country>(provider);
            TBL_Mapping_Beds = new Query<TBL_Mapping_Bed>(provider);
            TBL_Doctor_Timings = new Query<TBL_Doctor_Timing>(provider);
            Tbl_Temp_States = new Query<Tbl_Temp_State>(provider);
            TBL_GeoPostcodes_States = new Query<TBL_GeoPostcodes_State>(provider);
            TBL_Job_SubAdminLogins = new Query<TBL_Job_SubAdminLogin>(provider);
            TBL_Patient_UHIDs = new Query<TBL_Patient_UHID>(provider);
            TBL_GeoPostcodes_Cities = new Query<TBL_GeoPostcodes_City>(provider);
            TBL_Job_Specialities = new Query<TBL_Job_Speciality>(provider);
            TBL_Landing_MainTabs = new Query<TBL_Landing_MainTab>(provider);
            TBL_BlockCalendars = new Query<TBL_BlockCalendar>(provider);
            TBL_Job_SearchWidgetColVisibles = new Query<TBL_Job_SearchWidgetColVisible>(provider);
            TBL_Service_Timings = new Query<TBL_Service_Timing>(provider);
            TBL_Job_SearchResultsColVisibles = new Query<TBL_Job_SearchResultsColVisible>(provider);
            TBL_Landing_SubTabs = new Query<TBL_Landing_SubTab>(provider);
            TBL_Job_SearchDescriptionColVisibles = new Query<TBL_Job_SearchDescriptionColVisible>(provider);
            TBL_Job_NewsLetters = new Query<TBL_Job_NewsLetter>(provider);
            Tbl_Appointment_Comments = new Query<Tbl_Appointment_Comment>(provider);
            TBL_Job_Jobs = new Query<TBL_Job_Job>(provider);
            TBL_Logins = new Query<TBL_Login>(provider);
            TBL_Job_HrLogins = new Query<TBL_Job_HrLogin>(provider);
            TBL_Job_HotOppsColVisibles = new Query<TBL_Job_HotOppsColVisible>(provider);
            TBL_Job_Facilities = new Query<TBL_Job_Facility>(provider);
            TBL_Service_Diagnosis = new Query<TBL_Service_Diagnosi>(provider);
            TBL_Job_Applies = new Query<TBL_Job_Apply>(provider);
            TBL_GupShups = new Query<TBL_GupShup>(provider);
            TBL_Landing_ImageGalleries = new Query<TBL_Landing_ImageGallery>(provider);
            TBL_Organizations = new Query<TBL_Organization>(provider);
            TBL_Tokens = new Query<TBL_Token>(provider);
            Contents = new Query<Content>(provider);
            Pages = new Query<Page>(provider);
            TBL_GupShup_FailureReasons = new Query<TBL_GupShup_FailureReason>(provider);
            TBL_Master_Banners = new Query<TBL_Master_Banner>(provider);
            TBL_Landings = new Query<TBL_Landing>(provider);
            TBL_Doctor_Educations = new Query<TBL_Doctor_Education>(provider);
            TBL_Master_Universities = new Query<TBL_Master_University>(provider);
            TBL_Landing_Publishes = new Query<TBL_Landing_Publish>(provider);
            TBL_Admin_LoginTypes = new Query<TBL_Admin_LoginType>(provider);
            TBL_Doctors = new Query<TBL_Doctor>(provider);
            TBL_Landing_VideoGalleries = new Query<TBL_Landing_VideoGallery>(provider);
            TBL_Master_Beds = new Query<TBL_Master_Bed>(provider);
            TBL_Master_SubAccountTypes = new Query<TBL_Master_SubAccountType>(provider);
            TBL_ActivationSMSCounts = new Query<TBL_ActivationSMSCount>(provider);
            TBL_Services = new Query<TBL_Service>(provider);
            TBL_Appointments = new Query<TBL_Appointment>(provider);
            #endregion


            #region ' Schemas '
        	if(DataProvider.Schema.Tables.Count == 0)
			{
            	DataProvider.Schema.Tables.Add(new TBL_Patient_ReferenceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_LocationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_BuildingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_SymptomGroupTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_FloorTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Tbl_Master_WardTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_RatingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_SymptomTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_PreferentialTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_DiagnosisTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_AnswerTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_SMSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Symptom_DiagnosisTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Diagnosis_DepartmentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_QuestionTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Doctor_DiagnosisTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_FeedbackTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_KeywordSMSTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_FamilyHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Appointment_WinserviceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_RelationshipTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_StatusTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Doctor_ExperienceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_PersonalHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Patient_SearchCountTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Patient_FamilyHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_PastHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_PatientTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_AccountTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_ReferenceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Patient_PersonalHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Patient_PastHistoryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_DepartmentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_City_oldTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_State_oldTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_GeoPostcodesTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_Country_oldTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Mapping_StatusTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_GeoPostcodes_CountryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Mapping_BedTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Doctor_TimingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Tbl_Temp_StateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_GeoPostcodes_StateTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_SubAdminLoginTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Patient_UHIDTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_GeoPostcodes_CityTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_SpecialityTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Landing_MainTabTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_BlockCalendarTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_SearchWidgetColVisibleTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Service_TimingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_SearchResultsColVisibleTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Landing_SubTabTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_SearchDescriptionColVisibleTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_NewsLetterTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new Tbl_Appointment_CommentsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_JobsTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_LoginTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_HrLoginTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_HotOppsColVisibleTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_FacilityTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Service_DiagnosisTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Job_ApplyTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_GupShupTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Landing_ImageGalleryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_OrganizationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_TokenTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new ContentTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new PageTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_GupShup_FailureReasonTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_BannerTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_LandingTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Doctor_EducationTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_UniversityTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Landing_PublishTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Admin_LoginTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_DoctorTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Landing_VideoGalleryTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_BedTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_Master_SubAccountTypeTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_ActivationSMSCountTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_ServiceTable(DataProvider));
            	DataProvider.Schema.Tables.Add(new TBL_AppointmentTable(DataProvider));
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