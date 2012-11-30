using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MedAppointments.DataAccessLayer
{
    public class SearchDAL : Connection
    {
        public DataSet GetSpeciality(int stateId, int cityId, int departmentId, string postalcode, int signLoginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetSpeciality", stateId, cityId, departmentId, postalcode, signLoginId);
        }

        public DataSet GetSpecialityByHospital(int stateID, int cityId, int departmentId, string postalcode)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetSpecialityByHospital",stateID, cityId, departmentId, postalcode);
        }

        public string GetSymptomIdBySymptom(string likeSymptom)
        {
            DataTable dtSymptom = SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetSymptomIdBySymptom", likeSymptom).Tables[0];

            StringBuilder symptom = new StringBuilder();
            for (int i = 0; i < dtSymptom.Rows.Count; i++)
            {
                if (symptom.Length != 0)
                    symptom.Append(",");

                symptom.Append(dtSymptom.Rows[i]["SymptomId"].ToString());
            }

            return symptom.ToString();
        }

        public DataSet GetSymptom(int stateId, int cityId, string symptomIds, string postalcode, int signLoginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetSymptom", stateId, cityId, symptomIds, postalcode, signLoginId);
        }

        public DataSet GetSymptomByHospital(int stateId, int cityId, string symptomIds, string postalcode)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetSymptomByHospital", stateId, cityId, symptomIds, postalcode);
        }

        public DataTable GetCountry()
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetCountry").Tables[0];
        }

        public DataTable GetState(int countryId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetState", countryId).Tables[0];
        }

        public DataTable GetCity(int stateId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetCity", stateId).Tables[0];
        }

        public DataTable GetPostalcode(int cityId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetPostalcode", cityId).Tables[0];
        }

        #region "SQL Methords"
        public DataSet GetIPBasedInformation(string UserIP)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlParameter[] arrConfig =
                {
                    new SqlParameter("@ipAddress",SqlDbType.NVarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,UserIP),
                };
                ds = SqlHelper.ExecuteDataset(System.Configuration.ConfigurationManager.ConnectionStrings["IPConn"].ToString(), "USP_GetIPInformation_IPAddress", arrConfig);
            }
            catch (Exception ex)
            {
                string strException = ex.Message;
            }
            return ds;
        }


        public DataSet GetCategoryByLanguage(string LanguageID)
        {
            return (DataSet)SqlHelper.ExecuteDataset(System.Configuration.ConfigurationManager.ConnectionStrings["MediaConn"].ToString(), "USP_GetCategory", LanguageID);
        }

        //public DataSet GetGMapData(string ZipCode, string categoryId, string Country, string Region, string City)
        //{
        //    SqlParameter[] arrConfig = 
        //        {
        //            new SqlParameter("@category",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,Convert.ToString(categoryId)),
        //            new SqlParameter("@Zipcode",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,ZipCode),
        //            new SqlParameter("@Country",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,Country),
        //            new SqlParameter("@Region",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,Region),
        //            new SqlParameter("@City",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,City),
        //        };
        //    return SqlHelper.ExecuteDataset(ConnectionString, "USP_GetZIPcodeResults", arrConfig);
        //}


        public DataSet GETLagitudeandLatitudebyIP(string strCountry, string strRegion, string strCity, string strDomain, string strORGIDS)
        {
            SqlParameter[] arrConfig = 
                {
                    new SqlParameter("@in_country",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,strCountry),
                    new SqlParameter("@in_Region",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,strRegion),
                    new SqlParameter("@in_City",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,strCity),
                    new SqlParameter("@Domain",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,strDomain),
                    new SqlParameter("@ORGIDS",SqlDbType.VarChar,1000,ParameterDirection.Input,false,0,0,"",DataRowVersion.Proposed,strORGIDS),
                    
                };
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_GETLagitudeandLatitudebyIP", arrConfig);
        }

        #endregion

        public DataTable GetCountryByAccountTypeId(int id, int accountTypeId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetCountryByAccountTypeId", id, accountTypeId).Tables[0];
        }

        public DataSet GetServiceSpecialityByOrganizationId(int departmentId, int organizationId, int signLoginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Search_GetServiceSpecialityByOrganizationId", departmentId, organizationId, signLoginId);
        }
    }
}
