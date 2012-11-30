using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class LoginBAL
    {
        LoginDAL _objLoginDAL = new LoginDAL();

        public int SaveAccount(LoginNewDO l)
        {
            return _objLoginDAL.SaveAccount(l.LoginId, l.FirstName, l.LastName, l.CountryId, l.MobileId, l.EmailId, l.Password, l.IsDirect, l.IsActivated);
        }

        public void SaveTransactionToken(int loginId, string transactionToken)
        {
            _objLoginDAL.SaveTransactionToken(loginId, transactionToken);
        }

        public bool GetZipDailConfirmation(string transactionToken)
        {
            int iToken = _objLoginDAL.GetZipDailConfirmation(transactionToken);

            if (iToken > 0)
                return true;
            else
                return false;
        }

        public void UpdateZipDailVerification(string transactionToken)
        {
            _objLoginDAL.UpdateZipDailVerification(transactionToken);
        }

        public DataSet GetAccounts(int loginId)
        {
            return _objLoginDAL.GetAccounts(loginId);
        }

        public LoginNewDO GetAccount(int loginId)
        {
            DataTable dtLogin = _objLoginDAL.GetAccount(loginId);
            
            LoginNewDO l;
            if (dtLogin.Rows.Count > 0)
            {
                l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtLogin.Rows[0]["LoginId"]);
                l.FirstName = dtLogin.Rows[0]["FirstName"].ToString();
                l.LastName = dtLogin.Rows[0]["LastName"].ToString();
                l.MedAppId = dtLogin.Rows[0]["MedAppId"].ToString();
                l.CountryId = Convert.ToInt32(dtLogin.Rows[0]["CountryId"]);
                l.MobileId = dtLogin.Rows[0]["MobileId"].ToString();
                l.EmailId = dtLogin.Rows[0]["EmailId"].ToString();
                l.Password = dtLogin.Rows[0]["Password"].ToString();
                l.IsDirect = Convert.ToBoolean(dtLogin.Rows[0]["IsDirect"]);
                l.IsActivated = Convert.ToBoolean(dtLogin.Rows[0]["IsActivated"]);
                l.TransactionToken = dtLogin.Rows[0]["TransactionToken"].ToString();
                l.CreatedOn = Convert.ToDateTime(dtLogin.Rows[0]["CreatedOn"]);

                if (dtLogin.Rows[0]["ModifiedOn"].ToString() != "")
                    l.ModifiedOn = Convert.ToDateTime(dtLogin.Rows[0]["ModifiedOn"]);
                else
                    l.ModifiedOn = null;

                l.IsDeleted = Convert.ToBoolean(dtLogin.Rows[0]["IsDeleted"]);

                return l;
            }
            else
            {
                l = null;
                return l;
            }
        }

        public LoginNewDO GetAccountByPatientId(int patientid)
        {
            DataTable dtLogin = _objLoginDAL.GetAccountByPatientId(patientid);

            LoginNewDO l;
            if (dtLogin.Rows.Count > 0)
            {
                l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtLogin.Rows[0]["LoginId"]);
                l.FirstName = dtLogin.Rows[0]["FirstName"].ToString();
                l.LastName = dtLogin.Rows[0]["LastName"].ToString();
                l.MedAppId = dtLogin.Rows[0]["MedAppId"].ToString();
                l.CountryId = Convert.ToInt32(dtLogin.Rows[0]["CountryId"]);
                l.MobileId = dtLogin.Rows[0]["MobileId"].ToString();
                l.EmailId = dtLogin.Rows[0]["EmailId"].ToString();
                l.Password = dtLogin.Rows[0]["Password"].ToString();
                l.IsDirect = Convert.ToBoolean(dtLogin.Rows[0]["IsDirect"]);
                l.IsActivated = Convert.ToBoolean(dtLogin.Rows[0]["IsActivated"]);
                l.TransactionToken = dtLogin.Rows[0]["TransactionToken"].ToString();
                l.CreatedOn = Convert.ToDateTime(dtLogin.Rows[0]["CreatedOn"]);

                if (dtLogin.Rows[0]["ModifiedOn"].ToString() != "")
                    l.ModifiedOn = Convert.ToDateTime(dtLogin.Rows[0]["ModifiedOn"]);
                else
                    l.ModifiedOn = null;

                l.IsDeleted = Convert.ToBoolean(dtLogin.Rows[0]["IsDeleted"]);

                return l;
            }
            else
            {
                l = null;
                return l;
            }
        }

        public LoginNewDO GetLoginNew(string loginId)
        {
            DataTable dtLogin = _objLoginDAL.GetLoginNew(loginId);

            LoginNewDO l;
            if (dtLogin.Rows.Count > 0)
            {
                l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtLogin.Rows[0]["LoginId"]);
                l.FirstName = dtLogin.Rows[0]["FirstName"].ToString();
                l.LastName = dtLogin.Rows[0]["LastName"].ToString();
                l.MedAppId = dtLogin.Rows[0]["MedAppId"].ToString();
                l.CountryId = Convert.ToInt32(dtLogin.Rows[0]["CountryId"]);
                l.MobileId = dtLogin.Rows[0]["MobileId"].ToString();
                l.EmailId = dtLogin.Rows[0]["EmailId"].ToString();
                l.Password = "";
                l.IsDirect = Convert.ToBoolean(dtLogin.Rows[0]["IsDirect"]);
                l.IsActivated = Convert.ToBoolean(dtLogin.Rows[0]["IsActivated"]);
                l.TransactionToken = dtLogin.Rows[0]["TransactionToken"].ToString();
                l.CreatedOn = Convert.ToDateTime(dtLogin.Rows[0]["CreatedOn"]);

                if (dtLogin.Rows[0]["ModifiedOn"].ToString() != "")
                    l.ModifiedOn = Convert.ToDateTime(dtLogin.Rows[0]["ModifiedOn"]);
                else
                    l.ModifiedOn = null;

                l.IsDeleted = Convert.ToBoolean(dtLogin.Rows[0]["IsDeleted"]);

                return l;
            }
            else
            {
                l = null;
                return l;
            }
        }

        public LoginNewDO GetLogin(string loginId)
        {
            DataTable dtLogin = _objLoginDAL.GetLogin(loginId);

            LoginNewDO l;
            if (dtLogin.Rows.Count > 0)
            {
                l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtLogin.Rows[0]["LoginId"]);
                l.FirstName = dtLogin.Rows[0]["FirstName"].ToString();
                l.LastName = dtLogin.Rows[0]["LastName"].ToString();
                l.MedAppId = dtLogin.Rows[0]["MedAppId"].ToString();
                l.CountryId = Convert.ToInt32(dtLogin.Rows[0]["CountryId"]);
                l.MobileId = dtLogin.Rows[0]["MobileId"].ToString();
                l.EmailId = dtLogin.Rows[0]["EmailId"].ToString();
                l.Password = dtLogin.Rows[0]["Password"].ToString();
                l.IsDirect = Convert.ToBoolean(dtLogin.Rows[0]["IsDirect"]);
                l.IsActivated = Convert.ToBoolean(dtLogin.Rows[0]["IsActivated"]);
                l.IsEmailActivated = Convert.ToBoolean(dtLogin.Rows[0]["IsEmailActivated"]);
                l.TransactionToken = dtLogin.Rows[0]["TransactionToken"].ToString();
                l.CreatedOn = Convert.ToDateTime(dtLogin.Rows[0]["CreatedOn"]);

                if (dtLogin.Rows[0]["ModifiedOn"].ToString() != "")
                    l.ModifiedOn = Convert.ToDateTime(dtLogin.Rows[0]["ModifiedOn"]);
                else
                    l.ModifiedOn = null;

                l.IsDeleted = Convert.ToBoolean(dtLogin.Rows[0]["IsDeleted"]); 

                return l;
            }
            else
            {
                l = null;
                return l;
            }
        }

        public LoginNewDO GetLoginWithoutActivate(string loginId)
        {
            DataTable dtLogin = _objLoginDAL.GetLoginWithoutActivate(loginId);

            LoginNewDO l;
            if (dtLogin.Rows.Count > 0)
            {
                l = new LoginNewDO();
                l.LoginId = Convert.ToInt32(dtLogin.Rows[0]["LoginId"]);
                l.FirstName = dtLogin.Rows[0]["FirstName"].ToString();
                l.LastName = dtLogin.Rows[0]["LastName"].ToString();
                l.MedAppId = dtLogin.Rows[0]["MedAppId"].ToString();
                l.CountryId = Convert.ToInt32(dtLogin.Rows[0]["CountryId"]);
                l.MobileId = dtLogin.Rows[0]["MobileId"].ToString();
                l.EmailId = dtLogin.Rows[0]["EmailId"].ToString();
                l.Password = dtLogin.Rows[0]["Password"].ToString();
                l.IsDirect = Convert.ToBoolean(dtLogin.Rows[0]["IsDirect"]);
                l.IsActivated = Convert.ToBoolean(dtLogin.Rows[0]["IsActivated"]);
                l.TransactionToken = dtLogin.Rows[0]["TransactionToken"].ToString();
                l.CreatedOn = Convert.ToDateTime(dtLogin.Rows[0]["CreatedOn"]);

                if (dtLogin.Rows[0]["ModifiedOn"].ToString() != "")
                    l.ModifiedOn = Convert.ToDateTime(dtLogin.Rows[0]["ModifiedOn"]);
                else
                    l.ModifiedOn = null;

                l.IsDeleted = Convert.ToBoolean(dtLogin.Rows[0]["IsDeleted"]);

                return l;
            }
            else
            {
                l = null;
                return l;
            }
        }

        public void UpdateKeywordRegistration(int loginId, string firstName, string lastName, string email)
        {
            _objLoginDAL.UpdateKeywordRegistration(loginId, firstName, lastName, email);
        }

        public DataTable GetAccountByOrganizationId(int organizationId, int loginId)
        {
            return _objLoginDAL.GetAccountByOrganizationId(organizationId, loginId);
        }
    }
}
