using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MedAppointments.DataAccessLayer;

namespace MedAppointments.BusinessAccessLayer
{
    public class LandingBAL
    {
        LandingDAL _objLandingDAL = new LandingDAL();

        public bool SaveLanding(LandingPublishDO lp)
        {
            try
            {
                //int publishId = 0;

                //if (lp.PublishId == 0)
                 int publishId = _objLandingDAL.SaveLandingPublish(lp.PublishId, lp.AccountId, lp.AccountTypeId, lp.BannerId, lp.DefaultVersion);
                //else
                    //publishId = lp.PublishId;

                if (publishId > 0)
                {
                    lp.PublishId = publishId;

                    int landingId = _objLandingDAL.SaveLanding(lp.Landing.LandingId, lp.Landing.Version, lp.PublishId, lp.Landing.DepartmentId, lp.Landing.Forms);

                    if (landingId > 0)
                    {
                        lp.Landing.LandingId = landingId;

                        _objLandingDAL.DeleteMainTab(lp.Landing.LandingId);

                        foreach (MainTabDO item in lp.Landing.MainTabs)
                        {
                            item.LandingId = landingId;

                            int mainTabId = _objLandingDAL.SaveMainTab(item.MainTabId, item.MainTabName, item.MainTabContent, item.LandingId);

                            if (mainTabId > 0)
                            {
                                item.MainTabId = mainTabId;

                                foreach (SubTabDO subitem in item.SubTabs)
                                {
                                    subitem.MainTabId = mainTabId;

                                    _objLandingDAL.SaveSubTab(subitem.SubTabId, subitem.SubTabName, subitem.SubTabContent, subitem.MainTabId);
                                }
                            }
                        }
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetLandingPublish(int accountId, int accountTypeId)
        {
            return _objLandingDAL.GetLandingPublish(accountId, accountTypeId);
        }

        public LandingPublishDO GetLandingPublish(int accountId, int accountTypeId, int version)
        {
            LandingPublishDO lp = null;

            DataTable dtLandingPublish = _objLandingDAL.GetLandingPublish(accountId, accountTypeId);
            if (dtLandingPublish.Rows.Count > 0)
            {
                lp = new LandingPublishDO();
                lp.PublishId = Convert.ToInt32(dtLandingPublish.Rows[0]["PublishId"]);
                lp.AccountId = Convert.ToInt32(dtLandingPublish.Rows[0]["AccountId"]);
                lp.AccountTypeId = Convert.ToInt32(dtLandingPublish.Rows[0]["AccountTypeId"]);
                lp.BannerId = Convert.ToInt32(dtLandingPublish.Rows[0]["BannerId"]);
                lp.DefaultVersion = Convert.ToInt32(dtLandingPublish.Rows[0]["DefaultVersion"]);

                if (version == 0)
                    version = 1; //lp.DefaultVersion;

                DataTable dtLanding = _objLandingDAL.GetLanding(lp.PublishId, version);
                LandingDO l = new LandingDO();

                if (dtLanding.Rows.Count > 0)
                {
                    l.LandingId = Convert.ToInt32(dtLanding.Rows[0]["LandingId"]);
                    l.PublishId = Convert.ToInt32(dtLanding.Rows[0]["PublishId"]);
                    l.DepartmentId = (String.IsNullOrEmpty(dtLanding.Rows[0]["DepartmentId"].ToString())) ? 0 : Convert.ToInt32(dtLanding.Rows[0]["DepartmentId"]);
                    l.Forms = dtLanding.Rows[0]["Forms"].ToString();
                    //l.CreatedOn = Convert.ToDateTime(dtLanding.Rows[0]["CreatedOn"]);
                    //l.ModifiedOn = Convert.ToDateTime(dtLanding.Rows[0]["ModifiedOn"]);
                    l.Version = Convert.ToInt32(dtLanding.Rows[0]["Version"]);
                    l.MainTabs = new List<MainTabDO>();

                    lp.Landing = l;

                    DataTable dtMainTabs = _objLandingDAL.GetMainTabs(l.LandingId);
                    MainTabDO m;
                    foreach (DataRow dr in dtMainTabs.Rows)
                    {
                        m = new MainTabDO();
                        m.MainTabId = Convert.ToInt32(dr["MainTabId"]);
                        m.MainTabName = dr["MainTabName"].ToString();
                        m.MainTabContent = dr["MainTabContent"].ToString();
                        m.LandingId = Convert.ToInt32(dr["LandingId"]);
                        m.SubTabs = new List<SubTabDO>();

                        DataTable dtSubTabs = _objLandingDAL.GetSubTabs(m.MainTabId);
                        SubTabDO s;
                        foreach (DataRow subdr in dtSubTabs.Rows)
                        {
                            s = new SubTabDO();
                            s.SubTabId = Convert.ToInt32(subdr["SubTabId"]);
                            s.SubTabName = subdr["SubTabName"].ToString();
                            s.SubTabContent = subdr["SubTabContent"].ToString();
                            s.MainTabId = Convert.ToInt32(subdr["MainTabId"]);
                            m.SubTabs.Add(s);
                        }

                        l.MainTabs.Add(m);
                    }
                }
                else
                {
                    lp.Landing = null;
                }
            }

            return lp;
        }

        public bool PublishVersion(int publishId, int version)
        {
            return _objLandingDAL.PublishVersion(publishId, version);
        }

        public void SaveLandingImageGallery(int accountId, int accountTypeId, int version, string imageName, string imageDescription, byte[] Images, bool isSelected)
        {
            _objLandingDAL.SaveLandingImageGallery(accountId, accountTypeId, version, imageName, imageDescription, Images, isSelected);
        }

        public void DeleteLandingImageGallery(int ImageId)
        {
            _objLandingDAL.DeleteLandingImageGallery(ImageId);
        }

        public void UpdateImageGallery(int ImageId, string imageName, string imageDescription, byte[] Images, int imageUpload)
        {
            _objLandingDAL.UpdateImageGallery(ImageId, imageName, imageDescription, Images, imageUpload);
        }

        public DataTable GetImageGallery(int accountId, int accountTypeId, int version, bool isAll)
        {
            return _objLandingDAL.GetImageGallery(accountId, accountTypeId, version, isAll);
        }

        public int GetImageGalleryCount(int accountId, int accountTypeId, int version, bool isAll)
        {
            return _objLandingDAL.GetImageGalleryCount(accountId, accountTypeId, version, isAll);
        }

        public void SaveLandingVideoGallery(int accountId, int accountTypeId, int version, string videoContent, bool isSelected)
        {
            _objLandingDAL.SaveLandingVideoGallery(accountId, accountTypeId, version, videoContent, isSelected);
        }

        public void DeleteLandingVideoGallery(int accountId, int accountTypeId, int version)
        {
            _objLandingDAL.DeleteLandingVideoGallery(accountId, accountTypeId, version);
        }

        public DataTable GetVideoGallery(int accountId, int accountTypeId, int version, bool isAll)
        {
            return _objLandingDAL.GetVideoGallery(accountId, accountTypeId, version, isAll);
        }

        public int GetVideoGalleryCount(int accountId, int accountTypeId, int version, bool isAll)
        {
            return _objLandingDAL.GetVideoGalleryCount(accountId, accountTypeId, version, isAll);
        }

        public DataTable GetBanner(int departmentId)
        {
            return _objLandingDAL.GetBanner(departmentId);
        }

        public string GetBannerById(int bannerId)
        {
            return _objLandingDAL.GetBannerById(bannerId);
        }

        public DataTable GetImageById(int imageId)
        {
            return _objLandingDAL.GetImageById(imageId);
        }
    }
}
