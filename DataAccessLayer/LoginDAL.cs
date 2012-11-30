using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class LoginDAL : Connection
    {
        public int SaveAccount(int loginId, string firstName, string lastName, int countryId, string mobileId, string emailId, string password, bool isDirect, bool isActivated)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Login_InsertAccount", loginId, firstName, lastName, countryId, mobileId, emailId, password, isDirect, isActivated));
        }

        public void SaveTransactionToken(int loginId, string transactionToken)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Login_InsertTransactionToken", loginId, transactionToken);
        }

        public int GetZipDailConfirmation(string transactionToken)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Login_GetZipDailConfirmation", transactionToken));
        }

        public void UpdateZipDailVerification(string transactionToken)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Login_UpdateZipDailVerification", transactionToken);
        }

        public DataSet GetAccounts(int loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetAccounts", loginId);
        }

        public DataTable GetAccount(int loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetAccount", loginId).Tables[0];
        }

        public DataTable GetAccountByPatientId(int patientId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetAccountByPatientId", patientId).Tables[0];
        }

        public DataTable GetLogin(string loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetLogin", loginId).Tables[0];
        }

        public DataTable GetLoginWithoutActivate(string loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetLoginWithoutActivate", loginId).Tables[0];
        }

        public DataTable GetLoginNew(string loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetLoginNew", loginId).Tables[0];
        }

        public void UpdateKeywordRegistration(int loginId, string firstName, string lastName, string email)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Login_UpdateKeywordRegistration", loginId, firstName, lastName, email);
        }

        public DataTable GetAccountByOrganizationId(int organizationId, int loginId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Login_GetAccountByOrganizationId", organizationId, loginId).Tables[0];
        }
    }
}
