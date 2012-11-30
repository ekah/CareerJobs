using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MedAppointments.DataAccessLayer
{
    public class LandingDAL : Connection
    {
        public int SaveLandingPublish(int publishId, int accountId, int accountTypeId, int bannerId, int defaultVersion)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_InsertLandingPublish", publishId, accountId, accountTypeId, bannerId, defaultVersion));
        }

        public int SaveLanding(int landingId, int version, int publishId, int departmentId, string forms)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_InsertLanding", landingId, version, publishId, departmentId, forms));
        }

        public int SaveMainTab(int mainTabId, string mainTabName, string mainTabContent, int landingId)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_InsertMainTab", mainTabId, mainTabName, mainTabContent, landingId));
        }

        public void SaveSubTab(int subTabId, string subTabName, string subTabContent, int mainTabId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_InsertSubTab", subTabId, subTabName, subTabContent, mainTabId);
        }

        public void DeleteMainTab(int landingId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_DeleteMainTab", landingId);
        }

        public void DeleteSubTab(int mainTabId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_DeleteSubTab", mainTabId);
        }

        public DataTable GetLandingPublish(int accountId, int accountTypeId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetLandingPublish", accountId, accountTypeId).Tables[0];
        }

        public DataTable GetLanding(int publishId, int version)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetLanding", publishId, version).Tables[0];
        }

        public DataTable GetMainTabs(int landingId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetMainTabs", landingId).Tables[0];
        }

        public DataTable GetSubTabs(int mainTabId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetSubTabs", mainTabId).Tables[0];
        }

        public bool PublishVersion(int publishId, int version)
        {
            int iUpdated = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_PublishVersion", publishId, version));

            if (iUpdated == 0)
                return false;
            else
                return true;
        }

        public void SaveLandingImageGallery(int accountId, int accountTypeId, int version, string imageName, string imageDescription, byte[] Images, bool isSelected)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_InsertImageGallery", accountId, accountTypeId, version, imageName, imageDescription, Images, isSelected);
        }

        public void DeleteLandingImageGallery(int ImageId)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_DeleteImageGallery", ImageId);
        }

        public void UpdateImageGallery(int ImageId, string imageName, string imageDescription, byte[] Images, int imageUpload)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_UpdateImageGallery", ImageId, imageName, imageDescription, Images, imageUpload);
        }

        public DataTable GetImageGallery(int accountId, int accountTypeId, int version, bool isAll)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetImageGallery", accountId, accountTypeId, version, isAll).Tables[0];
        }

        public int GetImageGalleryCount(int accountId, int accountTypeId, int version, bool isAll)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_GetImageGalleryCount", accountId, accountTypeId, version, isAll));
        }

        public void SaveLandingVideoGallery(int accountId, int accountTypeId, int version, string videoContent, bool isSelected)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_InsertVideoGallery", accountId, accountTypeId, version, videoContent, isSelected);
        }

        public void DeleteLandingVideoGallery(int accountId, int accountTypeId, int version)
        {
            SqlHelper.ExecuteNonQuery(ConnectionString, "USP_Landing_DeleteVideoGallery", accountId, accountTypeId, version);
        }

        public DataTable GetVideoGallery(int accountId, int accountTypeId, int version, bool isAll)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetVideoGallery", accountId, accountTypeId, version, isAll).Tables[0];
        }

        public int GetVideoGalleryCount(int accountId, int accountTypeId, int version, bool isAll)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_GetVideoGalleryCount", accountId, accountTypeId, version, isAll));
        }

        public DataTable GetBanner(int departmentId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetBanner", departmentId).Tables[0];
        }

        public string GetBannerById(int bannerId)
        {
            return SqlHelper.ExecuteScalar(ConnectionString, "USP_Landing_GetBannerById", bannerId).ToString();
        }

        public DataTable GetImageById(int imageId)
        {
            return SqlHelper.ExecuteDataset(ConnectionString, "USP_Landing_GetImageById", imageId).Tables[0];
        }
    }
}
 