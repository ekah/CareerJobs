<%@ Page Language="C#" %>

<%@ Import Namespace="MedAppointments.BusinessAccessLayer" %>
<%@ Import Namespace="System.Linq" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Xml" %>
<%@ Import Namespace="System.Xml.XPath" %>
<%@ Import Namespace="System.IO" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    private string _inputMethod = "", _jsonOutput = "", _orgId = "", _actionTypeId = "", _actionId = "", _signInId = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        _inputMethod = Request["method"] + "";
        _orgId = Session["SignInOrganizationId"] + "";
        _actionTypeId = Session["SignInAccountTypeId"] + "";
        _actionId = Session["SignInAccountId"] + "";
        _signInId = Session["SignInId"] + "".Trim();

        _inputMethod = _inputMethod.Trim();
        _orgId = _orgId.Trim();
        _actionTypeId = _actionTypeId.Trim();
        _actionId = _actionId.Trim();

        if (_orgId.Length != 0)
        {

            if (_inputMethod == "getAvailableFloor")
            {
                try
                {
                    string selectedBuilding = Request["scAdmitDpdBuilding"] + "";
                    string resultHtml = "";
                    if (selectedBuilding != "0")
                    {
                        AppointmentBAL objAppBAL = new AppointmentBAL();
                        DataSet dsAvailableFloor = new DataSet();
                        dsAvailableFloor = objAppBAL.GetAvailableFloor(Convert.ToInt32(_orgId), Convert.ToInt32(selectedBuilding));
                        resultHtml = RenderDataSet(dsAvailableFloor, "PatientSearch.xslt", "SCPOPUP_GETFLOOR");
                        resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                        _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                        _jsonOutput += "{\"name\" : \"control\" , \"value\" : \"scAdmitDpdBuilding\"},";
                        _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";

                    }
                    else
                    {
                        _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                        _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + "sessionout" + "\"}";

                    }

                }
                catch (Exception ex)
                {
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                }
            }
            else if (_inputMethod == "getAvailableWard")
            {
                try
                {
                    string selectedBuilding = Request["scAdmitDpdBuilding"] + "";
                    string selectedFloor = Request["scAdmitDpdFloor"] + "";
                    string resultHtml = "";
                    if (selectedFloor != "0" && selectedBuilding != "0")
                    {
                        AppointmentBAL objAppBAL = new AppointmentBAL();
                        DataSet dsAvailableWard = new DataSet();
                        dsAvailableWard = objAppBAL.GetAvailableWard(Convert.ToInt32(_orgId), Convert.ToInt32(selectedBuilding), Convert.ToInt32(selectedFloor));
                        resultHtml = RenderDataSet(dsAvailableWard, "PatientSearch.xslt", "SCPOPUP_GETWARD");
                        resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                        _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                        _jsonOutput += "{\"name\" : \"control\" , \"value\" : \"scAdmitDpdFloor\"},";
                        _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";

                    }
                    else
                    {
                        _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                        _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + "sessionout" + "\"}";

                    }

                }
                catch (Exception ex)
                {
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                }

            }
            else if (_inputMethod == "getAvailableBed")
            {
                try
                {
                    string selectedBuilding = Request["scAdmitDpdBuilding"] + "";
                    string selectedFloor = Request["scAdmitDpdFloor"] + "";
                    string selectedWard = Request["scAdmitDpdWard"] + "";
                    string resultHtml = "";
                    if (selectedFloor != "0" && selectedBuilding != "0" && selectedWard != "0")
                    {
                        AppointmentBAL objAppBAL = new AppointmentBAL();
                        DataSet dsAvailableBed = new DataSet();
                        dsAvailableBed = objAppBAL.GetAvailableBed(Convert.ToInt32(_orgId), Convert.ToInt32(selectedBuilding), Convert.ToInt32(selectedFloor), Convert.ToInt32(selectedWard));
                        resultHtml = RenderDataSet(dsAvailableBed, "PatientSearch.xslt", "SCPOPUP_GETBEDS");
                        resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                        _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                        _jsonOutput += "{\"name\" : \"control\" , \"value\" : \"scAdmitDpdWard\"},";
                        _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";

                    }
                    else
                    {
                        _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                        _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + "sessionout" + "\"}";

                    }
                }
                catch (Exception ex)
                {
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                }

            }

            else if (_inputMethod == "updateschedule")
            {
                string statusId = Request["sid"] + "";
                string appIds = Request["aid"] + "";
                statusId = statusId.Trim();
                if (statusId.Length != 0)
                {
                    if (statusId == "1")
                    {
                        string result = "failure";
                        AppointmentBAL objBal = new AppointmentBAL();
                        DataTable dtStatusChangeResult = objBal.ManageStatusChange(appIds, Convert.ToInt32(statusId), Convert.ToInt32(_orgId), Convert.ToInt32(_actionTypeId), Convert.ToInt32(_actionId));

                        if (dtStatusChangeResult.Rows.Count > 0)
                        {
                            result = dtStatusChangeResult.Rows[0]["result"] + "";
                        }


                        //no sms

                        if (result == "success")
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                        else
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                    }
                    else if (statusId == "2")
                    {
                        AppointmentBAL objBal = new AppointmentBAL();
                        string result = "failure";
                        DataTable dtStatusChangeResult = objBal.ManageStatusChange(appIds, Convert.ToInt32(statusId), Convert.ToInt32(_orgId), Convert.ToInt32(_actionTypeId), Convert.ToInt32(_actionId));
                        bool isSmsSent = false;
                        if (dtStatusChangeResult.Rows.Count > 0)
                        {
                            string patientEmailId, timingId, isOnCall, tokenSequence, primaryHolder, appointmentDate, appointmentId, patientName, onCallAppointmentTime, appointmentTime, isFCFS, actionType, actionId, actionName, organizationName, hospitalAddress, FCFSStartTime, FCFSEndTime, actionMobile, patientMobile;
                            patientEmailId = timingId = isOnCall = tokenSequence = appointmentDate = primaryHolder = appointmentId = patientName = onCallAppointmentTime = appointmentTime = isFCFS = actionType = actionId = actionName = organizationName = hospitalAddress = FCFSStartTime = FCFSEndTime = actionMobile = patientMobile = "";
                            appointmentId = dtStatusChangeResult.Rows[0]["AppointmentId"] + "";
                            result = dtStatusChangeResult.Rows[0]["result"] + "";
                            patientName = dtStatusChangeResult.Rows[0]["PatientName"] + "";
                            onCallAppointmentTime = dtStatusChangeResult.Rows[0]["OnCallAppointmentTime"] + "";
                            appointmentTime = dtStatusChangeResult.Rows[0]["AppointmentTime"] + "";
                            isFCFS = dtStatusChangeResult.Rows[0]["isFCFS"] + "";
                            actionType = dtStatusChangeResult.Rows[0]["ActionType"] + "";
                            actionId = dtStatusChangeResult.Rows[0]["ActionId"] + "";
                            actionName = dtStatusChangeResult.Rows[0]["ActionName"] + "";
                            organizationName = dtStatusChangeResult.Rows[0]["OrganizationName"] + "";
                            hospitalAddress = dtStatusChangeResult.Rows[0]["HospitalAddress"] + "";
                            FCFSStartTime = dtStatusChangeResult.Rows[0]["FCFSStartTime"] + "";
                            FCFSEndTime = dtStatusChangeResult.Rows[0]["FCFSEndTime"] + "";
                            actionMobile = dtStatusChangeResult.Rows[0]["ActionMobile"] + "";
                            patientMobile = dtStatusChangeResult.Rows[0]["PatientMobile"] + "";
                            appointmentDate = dtStatusChangeResult.Rows[0]["AppointmentDate"] + "";
                            tokenSequence = dtStatusChangeResult.Rows[0]["TokenSequence"] + "";
                            primaryHolder = dtStatusChangeResult.Rows[0]["PrimaryHolder"] + "";
                            isOnCall = dtStatusChangeResult.Rows[0]["isOnCall"] + "";
                            timingId = dtStatusChangeResult.Rows[0]["TimingId"] + "";
                            patientEmailId = dtStatusChangeResult.Rows[0]["PatientEmailId"] + "";


                            if (onCallAppointmentTime.Trim().Length != 0)
                            {
                                string startTime = onCallAppointmentTime.Substring(0, onCallAppointmentTime.IndexOf("-")).Trim();
                                string endTime = onCallAppointmentTime.Substring(onCallAppointmentTime.IndexOf("-") + 1).Trim();
                                isSmsSent = SendBedMappingSMS(4, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Confirmed by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), appointmentDate, startTime, endTime, tokenSequence);
                            }

                            else if (isFCFS == "1")
                            {
                                //send email 

                                string emailBody = AppointmentScheduledEmailFormat(isOnCall, tokenSequence, primaryHolder, appointmentDate, appointmentId, patientName, onCallAppointmentTime, appointmentTime, isFCFS, actionName, organizationName, hospitalAddress, FCFSStartTime, FCFSEndTime, actionType, actionId);
                                if (patientEmailId.Trim().Length != 0)
                                    CommunicationBAL.SendEmailWithCheckingNotification(patientEmailId, "MedAppointment – Appointment Scheduled", emailBody, true);

                                isSmsSent = SendBedMappingSMS(4, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Confirmed by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), appointmentDate, FCFSStartTime, FCFSEndTime, tokenSequence);

                            }
                            else
                            {

                                isSmsSent = SendBedMappingSMS(5, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Confirmed by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), appointmentDate, appointmentTime, tokenSequence);
                                //send email
                                string emailBody = AppointmentScheduledEmailFormat(isOnCall, tokenSequence, primaryHolder, appointmentDate, appointmentId, patientName, onCallAppointmentTime, appointmentTime, isFCFS, actionName, organizationName, hospitalAddress, appointmentTime, appointmentTime, actionType, actionId);
                                if (patientEmailId.Trim().Length != 0)
                                    CommunicationBAL.SendEmailWithCheckingNotification(patientEmailId, "MedAppointment – Appointment Scheduled", emailBody, true);
                            }




                        }

                        /* SCHEDULED CASE -email and sms must be sent*/

                        if (result == "success")
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                        else
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }

                    }
                    else if (statusId == "4")
                    {
                        //completed


                        AppointmentBAL objBal = new AppointmentBAL();
                        string result = "failure";

                        DataTable dtStatusChangeResult = objBal.ManageStatusChange(appIds, Convert.ToInt32(statusId), Convert.ToInt32(_orgId), Convert.ToInt32(_actionTypeId), Convert.ToInt32(_actionId));

                        if (dtStatusChangeResult.Rows.Count > 0)
                        {
                            result = dtStatusChangeResult.Rows[0]["result"] + "";

                        }

                        if (result == "success")
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                        else
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                    }
                    else if (statusId == "5")
                    {
                        /* CANCELLED CASE
                         * WEB APPOINTMENT      - sms and email to doctor as well as patient 
                         * DIRECT APPOINTMENT   - sms and email only to patient
                         */
                        string result = "failure";
                        AppointmentBAL objBal = new AppointmentBAL();
                        DataTable dtStatusChangeResult = objBal.ManageStatusChange(appIds, Convert.ToInt32(statusId), Convert.ToInt32(_orgId), Convert.ToInt32(_actionTypeId), Convert.ToInt32(_actionId));
                        bool isSmsSent = false;

                        if (dtStatusChangeResult.Rows.Count > 0)
                        {
                            result = dtStatusChangeResult.Rows[0]["result"] + "";
                            string patientEmailId, timingId, isOnCall, tokenSequence, primaryHolder, appointmentDate, appointmentId, patientName, onCallAppointmentTime, appointmentTime, isFCFS, actionType, actionId, actionName, organizationName, hospitalAddress, FCFSStartTime, FCFSEndTime, actionMobile, patientMobile;
                            patientEmailId = timingId = isOnCall = tokenSequence = appointmentDate = primaryHolder = appointmentId = patientName = onCallAppointmentTime = appointmentTime = isFCFS = actionType = actionId = actionName = organizationName = hospitalAddress = FCFSStartTime = FCFSEndTime = actionMobile = patientMobile = "";
                            appointmentId = dtStatusChangeResult.Rows[0]["AppointmentId"] + "";
                            result = dtStatusChangeResult.Rows[0]["result"] + "";
                            patientName = dtStatusChangeResult.Rows[0]["PatientName"] + "";
                            onCallAppointmentTime = dtStatusChangeResult.Rows[0]["OnCallAppointmentTime"] + "";
                            appointmentTime = dtStatusChangeResult.Rows[0]["AppointmentTime"] + "";
                            isFCFS = dtStatusChangeResult.Rows[0]["isFCFS"] + "";
                            actionType = dtStatusChangeResult.Rows[0]["ActionType"] + "";
                            actionId = dtStatusChangeResult.Rows[0]["ActionId"] + "";
                            actionName = dtStatusChangeResult.Rows[0]["ActionName"] + "";
                            organizationName = dtStatusChangeResult.Rows[0]["OrganizationName"] + "";
                            hospitalAddress = dtStatusChangeResult.Rows[0]["HospitalAddress"] + "";
                            FCFSStartTime = dtStatusChangeResult.Rows[0]["FCFSStartTime"] + "";
                            FCFSEndTime = dtStatusChangeResult.Rows[0]["FCFSEndTime"] + "";
                            actionMobile = dtStatusChangeResult.Rows[0]["ActionMobile"] + "";
                            patientMobile = dtStatusChangeResult.Rows[0]["PatientMobile"] + "";
                            appointmentDate = dtStatusChangeResult.Rows[0]["AppointmentDate"] + "";
                            tokenSequence = dtStatusChangeResult.Rows[0]["TokenSequence"] + "";
                            primaryHolder = dtStatusChangeResult.Rows[0]["PrimaryHolder"] + "";
                            isOnCall = dtStatusChangeResult.Rows[0]["isOnCall"] + "";
                            timingId = dtStatusChangeResult.Rows[0]["TimingId"] + "";
                            patientEmailId = dtStatusChangeResult.Rows[0]["PatientEmailId"] + "";


                            string emailBody = AppointmentNotScheduledEmailFormat(isOnCall, tokenSequence, primaryHolder, appointmentDate, appointmentId, patientName, onCallAppointmentTime, appointmentTime, isFCFS, actionName, organizationName, hospitalAddress, FCFSStartTime, FCFSEndTime, actionType, actionId);
                            if (patientEmailId.Trim().Length != 0)
                                CommunicationBAL.SendEmailWithCheckingNotification(patientEmailId, "MedAppointment – Appointment Scheduled", emailBody, true);



                            if (isOnCall == "1")
                            {

                                if (onCallAppointmentTime.Trim().Length == 0)
                                {
                                    isSmsSent = SendBedMappingSMS(6, actionMobile, Convert.ToInt32(actionType), Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Cancelled by Doctor / Service", null, TrimTextForSMS(patientName), appointmentDate, appointmentTime);
                                    isSmsSent = SendBedMappingSMS(8, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Cancelled by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), appointmentTime, appointmentDate);
                                }
                                else
                                {
                                    string startTime = onCallAppointmentTime.Substring(0, onCallAppointmentTime.IndexOf("-")).Trim();
                                    string endTime = onCallAppointmentTime.Substring(onCallAppointmentTime.IndexOf("-") + 1).Trim();

                                    isSmsSent = SendBedMappingSMS(7, actionMobile, Convert.ToInt32(actionType), Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Cancelled by Doctor / Service", null, TrimTextForSMS(patientName), appointmentDate, startTime, endTime, TrimTextForSMS(organizationName));
                                    isSmsSent = SendBedMappingSMS(9, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Cancelled by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), startTime, endTime, appointmentDate);
                                }

                            }
                            else if (isFCFS == "1")
                            {
                                isSmsSent = SendBedMappingSMS(9, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Cancelled by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), FCFSStartTime, FCFSEndTime, appointmentDate);
                            }
                            else
                            {
                                isSmsSent = SendBedMappingSMS(8, patientMobile, (int)AccountType.Patient, Convert.ToInt32(appointmentId), Convert.ToInt32(_orgId), "Appointment Cancelled by Doctor / Service", null, TrimTextForSMS(patientName), TrimTextForSMS(actionName), TrimTextForSMS(organizationName), appointmentTime, appointmentDate);
                            }

                            DataTable dtUpdateAppointment = new PatientBAL().DeleteAppointmentByAppointmentIdByDoctor(Convert.ToInt32(appointmentId)); //After deleting appointment get Only Schedule appoitments with waiting list appointments 
                            if (dtUpdateAppointment.Rows.Count > 0)
                            {
                                bool IsUpdate = false;
                                int newAppointmentId = Convert.ToInt32(dtUpdateAppointment.Rows[0]["AppointmentId"].ToString());
                                string newAppoitmentTime = dtUpdateAppointment.Rows[0]["AppointmentTime"].ToString();
                                string newEmailId = dtUpdateAppointment.Rows[0]["EmailId"].ToString();
                                string newMobileId = "";
                                if (dtUpdateAppointment.Rows[0]["MobileId"].ToString() != "")
                                    newMobileId = dtUpdateAppointment.Rows[0]["MobileId"].ToString();
                                string newAppointmentDate = Convert.ToDateTime(dtUpdateAppointment.Rows[0]["AppointmentDate"]).ToString("dd MMM yyyy");
                                string newDoctorName = dtUpdateAppointment.Rows[0]["DoctorServiceName"].ToString();
                                string newTokenNumber = dtUpdateAppointment.Rows[0]["TokenNumber"].ToString();
                                string newOrganizationName = dtUpdateAppointment.Rows[0]["OrganizationName"].ToString();
                                string confirmPatientName = dtUpdateAppointment.Rows[0]["PatientName"].ToString();
                                string isApprovalSeleted = dtUpdateAppointment.Rows[0]["IsApprovalSeleted"].ToString();
                                //string organizationId = dtUpdateAppointment.Rows[0]["OrganizationId"].ToString();
                                switch (dtUpdateAppointment.Rows[0]["PatientAppointmentTime"].ToString().ToLower())
                                {
                                    case "waiting 1":   //Some times doctor cancel waiting list, so check all possiblities of waiting list
                                        IsUpdate = true;
                                        break;
                                    case "waiting 2":
                                        IsUpdate = true;
                                        break;
                                    case "waiting 3":
                                        IsUpdate = true;
                                        break;
                                    case "waiting 4":
                                        IsUpdate = true;
                                        break;
                                    case "waiting 5":
                                        IsUpdate = true;
                                        break;
                                }
                                if (IsUpdate)
                                {
                                    int status = 1;
                                    if (isApprovalSeleted == "0")
                                        status = 2;
                                    if (dtUpdateAppointment.Rows[0]["StatusName"].ToString() == "Scheduled")
                                    {
                                        //status = 2;
                                        if (!string.IsNullOrEmpty(newMobileId))
                                        {
                                            if (newMobileId.Substring(0, 2) == "91")   //email and sms for waiting list changing status
                                                CommunicationBAL.SendSMSToIndiaWithCheckingNotification(newMobileId, AppointmentTimeWaitingListSMSFormat(appointmentDate, newAppoitmentTime, newDoctorName, newTokenNumber, TrimTextForSMS(organizationName), TrimTextForSMS(confirmPatientName)), (int)AccountType.Patient, "Appointment Waiting List Confirmed by Doctor / Service", Convert.ToInt32(newAppointmentId), Convert.ToInt32(_orgId));
                                            else
                                                CommunicationBAL.SendSMSToNonIndiaWithCheckingNotification(newMobileId, AppointmentTimeWaitingListSMSFormat(appointmentDate, newAppoitmentTime, newDoctorName, newTokenNumber, TrimTextForSMS(organizationName), TrimTextForSMS(confirmPatientName)), (int)AccountType.Patient, "Appointment Waiting List Confirmed by Doctor / Service", Convert.ToInt32(newAppointmentId), Convert.ToInt32(_orgId));
                                        }

                                        if (newEmailId != string.Empty)
                                        {
                                            string newEmailBody = WaitingListAppointmentConfirmedEmailFormat(Convert.ToInt32(newAppointmentId), appointmentDate, newAppoitmentTime);
                                            CommunicationBAL.SendEmailWithCheckingNotification(newEmailId, "MedAppointment – Waiting List Appointment Confirmed", emailBody, true);
                                        }
                                    }

                                    new PatientBAL().UpdatePatientAppointmentByAppointmentTime(Convert.ToInt32(newAppointmentId), newAppoitmentTime, status);
                                }

                            }

                        }

                        if (result == "success")
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                        else
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"}";

                        }
                    }
                    else if (statusId == "7")
                    {
                        //admit
                        //string selectedBuilding = Request["scAdmitDpdBuilding"] + "";
                        //string selectedFloor = Request["scAdmitDpdFloor"] + "";
                        //string selectedWard = Request["scAdmitDpdWard"] + "";
                        string bedId = Request["scAdmitDpdBed"] + "";
                        string doctorId = Request["scAdmitDpdDoctor"] + "";
                        string aId = Request["aid"] + "";
                        string sId = Request["sid"] + "";

                        try
                        {
                            string resultHtml = "";
                            //verify he is admin and then book bed
                            DataTable dt = null;
                            AppointmentBAL objAppBAL = new AppointmentBAL();
                            dt = objAppBAL.ManageBedMappingAdmit(Convert.ToInt32(_orgId), Convert.ToInt32(doctorId), Convert.ToInt32(bedId), Convert.ToInt32(aId), Convert.ToInt32(sId), Convert.ToInt32(_actionId), Convert.ToInt32(_actionTypeId));

                            string mobileNo, appId, patName, hospital, building, ward, floor, bed, doctorName;
                            mobileNo = appId = patName = hospital = building = ward = floor = bed = doctorName = "";
                            bool isSmsSent = false;
                            if (dt.Rows.Count > 0)
                            {
                                resultHtml = dt.Rows[0]["result"].ToString();
                                if (resultHtml.ToLower() == "success")
                                {
                                    mobileNo = dt.Rows[0]["DoctorMobile"].ToString();
                                    doctorName = dt.Rows[0]["DoctorName"].ToString();
                                    appId = dt.Rows[0]["AppointmentId"].ToString();
                                    patName = dt.Rows[0]["PatientName"].ToString();
                                    hospital = dt.Rows[0]["OrganizationName"].ToString();
                                    building = dt.Rows[0]["BuildingName"].ToString();
                                    ward = dt.Rows[0]["WardName"].ToString();
                                    bed = dt.Rows[0]["BedName"].ToString();
                                    floor = dt.Rows[0]["FloorName"].ToString();

                                    if (!building.ToLower().Contains("build"))
                                        building = building + " Building";
                                    if (!floor.ToLower().Contains("floor"))
                                        floor = floor + " Floor";
                                    if (!ward.ToLower().Contains("ward"))
                                        ward = ward + " Ward";
                                    if (!bed.ToLower().Contains("bed"))
                                        bed = bed + " Bed";

                                    //isSmsSent = SendBedMappingSMS(1, mobileNo, (int)AccountType.Doctor, Convert.ToInt32(appId), Convert.ToInt32(_orgId), "ADMIT", null, TrimTextForSMS(patName), TrimTextForSMS(hospital), TrimTextForSMS(building), TrimTextForSMS(ward), TrimTextForSMS(floor), TrimTextForSMS(bed));
                                    isSmsSent = SendBedMappingSMS(1, mobileNo, (int)AccountType.Doctor, Convert.ToInt32(appId), Convert.ToInt32(_orgId), "ADMIT", null, TrimTextForSMS(patName), TrimTextForSMS(hospital), TrimTextForSMSForBuilding(building) + "->", TrimTextForSMS(ward) + "->", TrimTextForSMS(floor) + "->", TrimTextForSMS(bed));
                                }
                            }


                            resultHtml = "success";

                            resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"},";
                            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";
                        }
                        catch (Exception ex)
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                        }



                    }
                    else if (statusId == "8")
                    {
                        //transfer
                        string doctorId = Request["scAdmitDpdDoctor"] + "";
                        string fromBed = Request["hidTransFromBed"] + "";
                        string toBuilding = Request["scAdmitDpdBuilding"] + "";
                        string toFloor = Request["scAdmitDpdFloor"] + "";
                        string toWard = Request["scAdmitDpdWard"] + "";
                        string toBed = Request["scAdmitDpdBed"] + "";
                        string aId = Request["aid"] + "";
                        string sId = Request["sid"] + "";

                        try
                        {
                            string resultHtml = "";
                            AppointmentBAL objAppBAL = new AppointmentBAL();
                            DataTable dt = null;
                            dt = objAppBAL.ManageBedMappingTransfer(Convert.ToInt32(_orgId), Convert.ToInt32(doctorId), Convert.ToInt32(toBed), Convert.ToInt32(aId), Convert.ToInt32(sId), Convert.ToInt32(_actionId), Convert.ToInt32(_actionTypeId));
                            string mobileNo, appId, patName, hospital, fromBuilding, fromWard, fromFloor, fromBedName, doctorName;
                            mobileNo = appId = patName = hospital = fromBuilding = fromWard = fromFloor = fromBedName = doctorName = toBuilding = toFloor = toWard = toBed = "";
                            bool isSmsSent = false;
                            if (dt.Rows.Count > 0)
                            {
                                resultHtml = dt.Rows[0]["result"].ToString();
                                if (resultHtml.ToLower() == "success")
                                {
                                    mobileNo = dt.Rows[0]["DoctorMobile"].ToString();
                                    doctorName = dt.Rows[0]["DoctorName"].ToString();
                                    appId = dt.Rows[0]["AppointmentId"].ToString();
                                    patName = dt.Rows[0]["PatientName"].ToString();
                                    hospital = dt.Rows[0]["OrganizationName"].ToString();
                                    fromBuilding = dt.Rows[0]["FromBuilding"].ToString();
                                    fromWard = dt.Rows[0]["FromWard"].ToString();
                                    fromFloor = dt.Rows[0]["FromFloor"].ToString();
                                    fromBedName = dt.Rows[0]["FromBed"].ToString();
                                    toBuilding = dt.Rows[0]["ToBuilding"].ToString();
                                    toWard = dt.Rows[0]["ToWard"].ToString();
                                    toFloor = dt.Rows[0]["ToFloor"].ToString();
                                    toBed = dt.Rows[0]["ToBed"].ToString();

                                    if (!fromBuilding.ToLower().Contains("build"))
                                        fromBuilding = fromBuilding + " Building";
                                    if (!fromFloor.ToLower().Contains("floor"))
                                        fromFloor = fromFloor + " Floor";
                                    if (!fromWard.ToLower().Contains("ward"))
                                        fromWard = fromWard + " Ward";
                                    if (!fromBedName.ToLower().Contains("bed"))
                                        fromBedName = fromBedName + " Bed";
                                    if (!toBuilding.ToLower().Contains("build"))
                                        toBuilding = toBuilding + " Building";
                                    if (!toFloor.ToLower().Contains("floor"))
                                        toFloor = toFloor + " Floor";
                                    if (!toWard.ToLower().Contains("ward"))
                                        toWard = toWard + " Ward";
                                    if (!toBed.ToLower().Contains("bed"))
                                        toBed = toBed + " Bed";

                                    //isSmsSent = SendBedMappingSMS(2, mobileNo, (int)AccountType.Doctor, Convert.ToInt32(appId), Convert.ToInt32(_orgId), "BED TRANSFER", null, TrimTextForSMS(patName), TrimTextForSMS(hospital), TrimTextForSMS(fromBuilding), TrimTextForSMS(fromWard), TrimTextForSMS(fromFloor), TrimTextForSMS(fromBedName), TrimTextForSMS(toBuilding), TrimTextForSMS(toWard), TrimTextForSMS(toFloor), TrimTextForSMS(toBed));
                                    isSmsSent = SendBedMappingSMS(2, mobileNo, (int)AccountType.Doctor, Convert.ToInt32(appId), Convert.ToInt32(_orgId), "BED TRANSFER", null, TrimTextForSMS(patName), TrimTextForSMS(hospital), TrimTextForSMSForBuilding(fromBuilding) + "->", TrimTextForSMSForBuilding(fromWard) + "->", TrimTextForSMSForBuilding(fromFloor) + "->", TrimTextForSMS(fromBedName), TrimTextForSMSForBuilding(toBuilding) + "->", TrimTextForSMSForBuilding(toWard) + "->", TrimTextForSMSForBuilding(toFloor) + "->", TrimTextForSMS(toBed));
                                }
                            }
                            resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"},";
                            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";
                        }
                        catch (Exception ex)
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                        }
                    }
                    else if (statusId == "9")
                    {
                        string aId = Request["aid"] + "";
                        string sId = Request["sid"] + "";
                        string bedId = "0";

                        try
                        {
                            string resultHtml = "";
                            AppointmentBAL objAppBAL = new AppointmentBAL();
                            DataTable dt = null;
                            dt = objAppBAL.ManageBedMappingDischarge(Convert.ToInt32(_orgId), Convert.ToInt32(bedId), Convert.ToInt32(aId), Convert.ToInt32(sId), Convert.ToInt32(_actionId), Convert.ToInt32(_actionTypeId));
                            string mobileNo, appId, patName, hospital, doctorName;
                            mobileNo = appId = patName = hospital = doctorName = "";
                            bool isSmsSent = false;
                            if (dt.Rows.Count > 0)
                            {
                                resultHtml = dt.Rows[0]["result"].ToString();
                                if (resultHtml.ToLower() == "success")
                                {
                                    mobileNo = dt.Rows[0]["DoctorMobile"].ToString();
                                    doctorName = dt.Rows[0]["DoctorName"].ToString();
                                    appId = dt.Rows[0]["AppointmentId"].ToString();
                                    patName = dt.Rows[0]["PatientName"].ToString();
                                    hospital = dt.Rows[0]["OrganizationName"].ToString();
                                    isSmsSent = SendBedMappingSMS(3, mobileNo, (int)AccountType.Doctor, Convert.ToInt32(appId), Convert.ToInt32(_orgId), "DISCHARGE", null, TrimTextForSMS(patName), TrimTextForSMS(hospital));
                                }
                            }
                            resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                            _jsonOutput += "{\"name\" : \"sid\" , \"value\" : \"" + statusId + "\"},";
                            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";
                        }
                        catch (Exception ex)
                        {
                            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                        }
                    }
                }



            }
            else if (_inputMethod == "completeApp")
            {

                try
                {
                    string resultHtml = "";
                    //verify he is admin and then transfer bed


                    resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";
                }
                catch (Exception ex)
                {
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                }


            }
            else if (_inputMethod == "savecomment")
            {

                try
                {
                    string id = Request["aid"] + "";
                    int signInId = Convert.ToInt32(Session["SignInLoginId"]);
                    string typedComment = Request["txtAppCommentsInput"] + "";
                    string statusid = Request["sid"] + "";
                    string resultHtml = "";
                    AppointmentBAL _objAppointmentBAL = new AppointmentBAL();
                    int loginId = signInId, statusId = Convert.ToInt32(statusid), appointmentId = Convert.ToInt32(id);
                    bool isCommentSaved = false;
                    DataTable Dt = _objAppointmentBAL.ManageCommentsInsertComment(HttpUtility.HtmlEncode(typedComment), appointmentId, loginId, statusId, Convert.ToInt32(_actionTypeId), Convert.ToInt32(_actionId));

                    if (Dt.Rows.Count > 0)
                    {
                        isCommentSaved = true;
                        DataSet ds = new DataSet();
                        ds.Tables.Add(Dt.Copy());
                        resultHtml = RenderDataSet(ds, "PatientSearch.xslt", "APPOINTMENT_GETCOMMENT");
                    }

                    resultHtml = resultHtml.Replace("\r", "").Replace("\t", "").Replace("\n", "").Replace("\"", "\\\"");
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"success\"},";
                    _jsonOutput += "{\"name\" : \"isCommentSaved\" , \"value\": \"" + isCommentSaved + "\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + resultHtml + "\"}";
                }
                catch (Exception ex)
                {
                    _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
                    _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + ex.Message + "\"}";
                }


            }
        }
        else
        {
            _jsonOutput += "{\"name\" : \"result\" , \"value\" : \"error\"},";
            _jsonOutput += "{\"name\" : \"html\" , \"value\" : \"" + "sessionout" + "\"}";


        }
        Response.ContentType = "application/json";
        Response.Write("[ " + _jsonOutput + " ]");
        Response.End();
    }



    public string RenderDataSet(DataSet dsDataSet, string xsltFile, string outFormat)
    {
        return RenderDataSet(dsDataSet, xsltFile, outFormat, true);
    }


    public string RenderDataSet(DataSet dsDataSet, string xsltFile, string outFormat, bool isDatsetNameNeeded)
    {
        if (isDatsetNameNeeded)
        {
            if (dsDataSet != null)
                dsDataSet.DataSetName = "DS_" + outFormat;
            if (dsDataSet.Tables.Count > 0)
                dsDataSet.Tables[0].TableName = "RW_" + outFormat;
        }
        return XsltTransform(dsDataSet, xsltFile, outFormat);
    }

    public string XsltTransform(DataSet dsDataSet, string xsltFile, string outFormat)
    {

        string xsltOutput = "";
        if (dsDataSet != null)
        {
            XmlDocument xDocDs = GetDataSetXML(dsDataSet, outFormat);
            xsltOutput = XsltTransform(xDocDs, xsltFile, null);
        }
        else
        {
            xsltOutput = "Data not available.";
        }

        return xsltOutput;
    }


    public XmlDocument GetDataSetXML(DataSet dsObjData, string outputFormat)
    {

        XmlDocument xDocDs = null;
        outputFormat = outputFormat.ToUpper();
        //DataSet dsObjData = getDataSet(dsnName, spName, sqlParamList, outputFormat);
        if (dsObjData != null && dsObjData.Tables.Count > 0)
        {
            xDocDs = new XmlDocument();
            string lsXml = dsObjData.GetXml();
            xDocDs.LoadXml(lsXml);

            Hashtable htColNodes = new Hashtable();
            foreach (DataColumn dtCol in dsObjData.Tables[0].Columns)
            {
                if (dtCol.ColumnName.ToLower().StartsWith("xml_") == true)
                {
                    htColNodes[dtCol.ColumnName] = dtCol.ColumnName;
                }
            }

            foreach (string lsElemFilter in htColNodes.Keys)
            {
                //lsElemFilter = "//xml_feature";   "//xml_*";
                XmlNodeList xNodeLst = xDocDs.DocumentElement.SelectNodes("//" + lsElemFilter);
                foreach (XmlNode xNode in xNodeLst)
                {
                    XmlElement xElem = (XmlElement)xNode;
                    string lsNodeName = xElem.Name.ToLower();
                    string lsNodeXml = xElem.InnerText;
                    //lsNodeXml = "";
                    xElem.InnerText = "";
                    xElem.InnerXml = lsNodeXml;
                }
            }
        }

        return xDocDs;
    }


    public string XsltTransform(XmlDocument xdoc, string xsltFile, System.Xml.Xsl.XsltArgumentList lxaXsltArgs)
    {
        string xsltOutput = "";

        if (!xsltFile.Contains("\\"))
            xsltFile = Server.MapPath("~") + @"\xslt\" + xsltFile;

        if (xsltFile.Length > 0)
        {
            System.Xml.Xsl.XslCompiledTransform xsltCompTrans = null;
            xsltCompTrans = getCompiledXsltFile(xsltFile);

            if (xsltCompTrans != null)
            {
                System.IO.StringWriter strWriter = new System.IO.StringWriter();
                xsltCompTrans.Transform(xdoc, lxaXsltArgs, strWriter);
                xsltOutput = strWriter.ToString();
                strWriter.Close();
            }
        }


        return xsltOutput;
    }

    public bool SendBedMappingSMS(int templateId, string mobileNo, int accountTypeId, int appId, int orgId, string action, string formattedString = null, params object[] messageParameters)
    {
        bool isSmsSent = false;
        if (formattedString != null && formattedString.Trim().Length != 0)
        {

            if (mobileNo.Trim().Length != 0)
            {
                if (mobileNo.Substring(0, 2) == "91")
                    isSmsSent = CommunicationBAL.SendSMSToIndiaWithCheckingNotification(mobileNo, formattedString, accountTypeId, action, appId, orgId);
                else
                    isSmsSent = CommunicationBAL.SendSMSToNonIndiaWithCheckingNotification(mobileNo, formattedString, accountTypeId, action, appId, orgId);
                return isSmsSent;
            }
            else
            {
                return isSmsSent;
            }


        }
        else
        {

            if ((messageParameters != null) && (messageParameters.Length > 0))
            {
                string message = GetSMSTemplate(templateId);
                if (message.Length != 0)
                {
                    string formattedMessage = string.Format(message, messageParameters);

                    if (mobileNo.Trim().Length != 0)
                    {
                        if (mobileNo.Substring(0, 2) == "91")
                            isSmsSent = CommunicationBAL.SendSMSToIndiaWithCheckingNotification(mobileNo, formattedMessage, accountTypeId, action, appId, orgId);
                        else
                            isSmsSent = CommunicationBAL.SendSMSToNonIndiaWithCheckingNotification(mobileNo, formattedMessage, accountTypeId, action, appId, orgId);
                    }
                    return isSmsSent;
                }
                else
                {
                    return isSmsSent;
                }
            }
            else
            {

                return isSmsSent;
            }
        }
    }

    private string AppointmentTimeWaitingListSMSFormat(string appointmentDate, string newAppoitmentTime, string doctorName, string tokenNumber, string organizationName, string confirmPatientName)
    {
        string dateTime = appointmentDate + " " + newAppoitmentTime;

        if (doctorName.IndexOf('(') > 0)
            doctorName = doctorName.Substring(0, doctorName.IndexOf('(') - 1);

        if (doctorName.Length > 20)
            doctorName = doctorName.Substring(0, 20);

        if (organizationName.Length > 20)
            organizationName = organizationName.Substring(0, 20);

        if (confirmPatientName.Length > 20)
            confirmPatientName = confirmPatientName.Substring(0, 20);

        string strContent = "Appointment for " + confirmPatientName + " with " + doctorName + " at " + organizationName + " on " + appointmentDate + " at " + newAppoitmentTime + " has been Confirmed. Your appointment ID is " + tokenNumber;
        return strContent.ToString();
    }

    public string GetSMSTemplate(int id)
    {
        switch (id)
        {
            case 1:
                return "Your patient, {0} has been admitted at {1} {2} {3} {4} {5}. Details at www.MedAppointment.com";//admit sms
            case 2:
                return "Your patient, {0} at {1} has been transferred from {2} {3} {4} {5} to {6} {7} {8} {9}. Details at www.MedAppointment.com"; //transfer sms
            case 3:
                return "Your patient, {0} at {1} has been discharged. Details at www.MedAppointment.com"; //discharge sms
            case 4:
                return "Appointment for {0} with {1} at {2} on {3} btwn {4} and {5} has been Confirmed. Your appointment id is {6}"; //on schedule sms
            case 5:
                return "Appointment for {0} with {1} at {2} on {3} at {4} has been Confirmed. Your appointment ID is {5}";
            case 6:
                return "Patient:{0} has cancelled an 'on call' appointment with you dated:{1} at {2}. Please login to www.MedAppointment.com for details";
            case 7:
                return "Patient:{0} has cancelled an 'on call' appointment with you dated:{1} btwn {2} and {3} at {4}. Please login to www.MedAppointment.com for details";
            case 8:
                return "Appointment for {0} with {1} at {2} at {3} on {4} is cancelled.Thank you for using www.MedAppointment.com";
            case 9:
                return "Appointment for {0} with {1} at {2} btwn {3} and {4} on {5} is cancelled. Thank you for using www.MedAppointment.com";
            case 10:
                return "Patient:{0} has cancelled an 'on call' appointment with you dated:{1} at {2}. Please login to www.MedAppointment.com for details";
            default: return "";


        }
        //admit
        // SendBedMappingSMS(1, mobileNo, _actionTypeId, appId, _orgId, null, "patientName", "hospitalname", "building", "ward", "floor", "bed");
        //transfer
        //SendBedMappingSMS(2, mobileNo, _actionTypeId, appId, _orgId, null, "patientName", "hospitalname", "frombuilding", "fromWard", "Fromfloor", "FromBed", "Tobuilding", "ToWard", "Tofloor", "ToBed");
        //discharge
        // SendBedMappingSMS(3, mobileNo, _actionTypeId, appId, _orgId, null, "patientName", "hospitalname");
    }


    //scemail


    private string AppointmentScheduledEmailFormat(string isOnCall, string tokenSequence, string primaryHolder, string appointmentDate, string appointmentId, string patientName, string onCallAppointmentTime, string appointmentTime, string isFCFS, string actionName, string organizationName, string hospitalAddress, string FCFSStartTime, string FCFSEndTime, string actionType, string actionId)
    {
        //3 doc and 2 service
        // string type = actionType;
        StringWriter strContent = new StringWriter();
        string OncallStartEndTime = onCallAppointmentTime;
        string onCallstartTime = string.Empty;
        string onCallendTime = string.Empty;

        if (onCallAppointmentTime.Trim().Length != 0)
        {
            onCallstartTime = OncallStartEndTime.Substring(0, OncallStartEndTime.IndexOf("-")).Trim();
            onCallendTime = OncallStartEndTime.Substring(OncallStartEndTime.IndexOf("-") + 1).Trim();
        }

        try
        {
            strContent.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
            strContent.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
            strContent.WriteLine("<head>");
            strContent.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            strContent.WriteLine("<title>MedAppointment – Appointment Scheduled</title>");
            strContent.WriteLine("</head>");
            strContent.WriteLine("<body>");
            strContent.WriteLine("<table width=\"650px\" border=\"0\" cellspacing=\"5\" cellpadding=\"0\" align=\"Left\">");
            strContent.WriteLine("<tr>");
            if (primaryHolder.Trim().Length != 0)
                strContent.WriteLine("<td colspan=\"2\">Dear " + primaryHolder + ", </td></tr>");
            else
                strContent.WriteLine("<td colspan=\"2\">Dear " + patientName + ", </td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Thank you for contacting " + actionName + " through our web site. Your appointment has been confirmed.</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Appointment Details:</td></tr>");
            strContent.WriteLine("<tr><td width=\"150px\">Patient Name:</td><td width=\"450px\">" + patientName + "</td></tr>");
            strContent.WriteLine("<tr><td>Appointment Date:</td><td>" + appointmentDate + "</td></tr>");

            if (onCallAppointmentTime.Trim().Length != 0)
                strContent.WriteLine("<tr><td>Appointment Time:</td><td>Btwn " + onCallstartTime + " - " + onCallendTime + "</td></tr>");
            else if (isFCFS == "0")
                strContent.WriteLine("<tr><td>Appointment Time:</td><td>" + appointmentTime + "</td></tr>");
            else
            {
                strContent.WriteLine("<tr><td>Appointment Time:</td><td>Btwn " + FCFSStartTime + " - " + FCFSEndTime + "</td></tr>");

            }
            hospitalAddress = GetHospitalAddress(actionId, actionType, hospitalAddress).Replace("\n", "<br/>");
            strContent.WriteLine("<tr><td>Doctor/Service Name:</td><td>" + actionName + "</td></tr>");
            strContent.WriteLine("<tr><td Valign=\"Top\">Hospital Address:</td><td>" + hospitalAddress + "</td></tr>");
            strContent.WriteLine("<tr><td>Appointment ID:</td><td>" + tokenSequence + "</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Please record your Appointment ID this will be required at the hospital.</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Sincerely,</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">MedAppointment</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Notes:<br />We cannot process urgent requests through this service. If you are experiencing a medical emergency, please contact your local emergency service. We process appointment requests Monday through Friday during regular business hours and try to respond within 1 business day.</td></tr>");
            strContent.WriteLine("</table>");
            strContent.WriteLine("</body>");
            strContent.WriteLine("</html>");

            return strContent.ToString();
        }
        catch
        {
            return "";
        }

    }

    private string WaitingListAppointmentConfirmedEmailFormat(int appointmentId, string appointmentDate, string newAppoitmentTime)
    {
        DataTable dtAppointment = new PatientBAL().GetMyAppointmentByAppointmentId(appointmentId);

        StringWriter strContent = new StringWriter();
        try
        {
            strContent.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
            strContent.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
            strContent.WriteLine("<head>");
            strContent.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            strContent.WriteLine("<title>MedAppointment – Waiting List Appointment Confirmed</title>");
            strContent.WriteLine("</head>");
            strContent.WriteLine("<body>");
            strContent.WriteLine("<table>");
            strContent.WriteLine("<tr>");
            if (!string.IsNullOrEmpty(dtAppointment.Rows[0]["PrimaryHolderName"].ToString()))
                strContent.WriteLine("<td colspan=\"2\">Dear " + dtAppointment.Rows[0]["PrimaryHolderName"].ToString() + ", </td></tr>");
            else
                strContent.WriteLine("<td colspan=\"2\">Dear " + dtAppointment.Rows[0]["PatientName"].ToString() + ", </td></tr>");
            strContent.WriteLine("<tr><td>You were wait listed when you booked an appointment with " + dtAppointment.Rows[0]["DoctorServiceName"].ToString() + ". We are happy to inform you that your appointment has been confirmed on " + appointmentDate + " at " + newAppoitmentTime + ".</td></tr>");
            strContent.WriteLine("<tr><td>&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td>Sincerely,</td></tr>");
            strContent.WriteLine("<tr><td>MedAppointment</td></tr>");
            strContent.WriteLine("<tr><td >&nbsp;</td></tr>");
            strContent.WriteLine("</table>");
            strContent.WriteLine("</body>");
            strContent.WriteLine("</html>");

            return strContent.ToString();
        }
        catch
        {
            return "";
        }
    }


    private string AppointmentNotScheduledEmailFormat(string isOnCall, string tokenSequence, string primaryHolder, string appointmentDate, string appointmentId, string patientName, string onCallAppointmentTime, string appointmentTime, string isFCFS, string actionName, string organizationName, string hospitalAddress, string FCFSStartTime, string FCFSEndTime, string actionType, string actionId)
    {
        //cancel email.

        //3 doc and 2 service
        // string type = actionType;
        StringWriter strContent = new StringWriter();
        string OncallStartEndTime = onCallAppointmentTime;
        string onCallstartTime = string.Empty;
        string onCallendTime = string.Empty;

        if (onCallAppointmentTime.Trim().Length != 0)
        {
            onCallstartTime = OncallStartEndTime.Substring(0, OncallStartEndTime.IndexOf("-")).Trim();
            onCallendTime = OncallStartEndTime.Substring(OncallStartEndTime.IndexOf("-") + 1).Trim();
        }

        try
        {
            strContent.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
            strContent.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
            strContent.WriteLine("<head>");
            strContent.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            strContent.WriteLine("<title>MedAppointment – Appointment Not Scheduled</title>");
            strContent.WriteLine("</head>");
            strContent.WriteLine("<body>");
            strContent.WriteLine("<table width=\"650px\" border=\"0\" cellspacing=\"5\" cellpadding=\"0\" align=\"Left\">");
            strContent.WriteLine("<tr>");
            if (primaryHolder != "")
                strContent.WriteLine("<td colspan=\"2\">Dear " + primaryHolder + ", </td></tr>");
            else
                strContent.WriteLine("<td colspan=\"2\">Dear " + patientName + ", </td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");


            strContent.WriteLine("<tr><td colspan=\"2\">Your appointment at " + organizationName + "\n" + hospitalAddress + " has been cancelled.</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Cancelled Appointment Details:</td></tr>");
            strContent.WriteLine("<tr><td width=\"150px\">Patient Name:</td><td width=\"450px\">" + patientName + "</td></tr>");
            strContent.WriteLine("<tr><td>Appointment Date:</td><td>" + appointmentDate + "</td></tr>");


            if (onCallAppointmentTime.Trim().Length != 0)
                strContent.WriteLine("<tr><td>Appointment Time:</td><td>Btwn " + onCallstartTime + " - " + onCallendTime + "</td></tr>");
            else if (isFCFS == "0")
                strContent.WriteLine("<tr><td>Appointment Time:</td><td>" + appointmentTime + "</td></tr>");
            else
            {
                strContent.WriteLine("<tr><td>Appointment Time:</td><td>Btwn " + FCFSStartTime + " - " + FCFSEndTime + "</td></tr>");

            }
            hospitalAddress = GetHospitalAddress(actionId, actionType, hospitalAddress).Replace("\n", "<br/>"); ;

            strContent.WriteLine("<tr><td>Doctor/Service Name:</td><td>" + actionName + "</td></tr>");
            strContent.WriteLine("<tr><td valign=\"top\">Address:</td><td valign=\"top\">" + hospitalAddress + "</td></tr>");
            strContent.WriteLine("<tr><td>Appointment ID:</td><td>" + tokenSequence + "</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Sincerely,</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">MedAppointment</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">&nbsp;</td></tr>");
            strContent.WriteLine("<tr><td colspan=\"2\">Notes:<br />We cannot process urgent requests through this service. If you are experiencing a medical emergency, please contact your local emergency service. We process appointment requests Monday through Friday during regular business hours and try to respond within 1 business day.</td></tr>");
            strContent.WriteLine("</table>");
            strContent.WriteLine("</body>");
            strContent.WriteLine("</html>");

            return strContent.ToString();
        }
        catch
        {
            return "";
        }
    }

    private string GetHospitalAddress(string actionId, string actionType, string hospitalAddress)
    {

        OrganizationDO o = null;



        if (actionType == "3")
            o = new OrganizationBAL().GetOrganizationByDoctorId(Convert.ToInt32(actionId));
        else
            o = new OrganizationBAL().GetOrganizationByServiceId(Convert.ToInt32(actionId));

        hospitalAddress = o.OrganizationName;
        hospitalAddress += "\n" + o.Address;
        hospitalAddress += (!string.IsNullOrEmpty(o.CityName)) ? "\n" + o.CityName : string.Empty;
        hospitalAddress += (!string.IsNullOrEmpty(o.StateName)) ? "\n" + o.StateName : string.Empty;
        hospitalAddress += (!string.IsNullOrEmpty(o.CountryName)) ? "\n" + o.CountryName : string.Empty;
        hospitalAddress += (!string.IsNullOrEmpty(o.PostalCode)) ? "\n" + o.PostalCode : string.Empty;
        hospitalAddress += (!string.IsNullOrEmpty(o.Phone)) ? "\nPhone: " + o.Phone : string.Empty;

        return hospitalAddress;
    }


    private string AppointmentConfirmSMSFormat(string doctorServiceName, string date, string time, string token, int patientId, bool isFCFS, string StartTimeEndTime, string hospitalAddress, string onCallAppointmentTime)
    {
        string patientName = string.Empty;
        PatientDO p = new PatientBAL().GetPatientByPatientId(patientId);
        patientName = (!string.IsNullOrEmpty(p.LastName)) ? p.FirstName + " " + p.LastName : p.FirstName;

        if (patientName.Length > 20)
            patientName = patientName.Substring(0, 20);

        if (doctorServiceName.Length > 20)
            doctorServiceName = doctorServiceName.Substring(0, 20);

        if (!string.IsNullOrEmpty(hospitalAddress))
        {
            if (hospitalAddress.Contains("\n"))
                hospitalAddress = hospitalAddress.Substring(0, hospitalAddress.IndexOf("\n"));
            if (hospitalAddress.Length > 20)
                hospitalAddress = hospitalAddress.Substring(0, 20);
        }

        string strContent = " ";

        if (!string.IsNullOrEmpty(onCallAppointmentTime))
        {
            string startTime = onCallAppointmentTime.Substring(0, onCallAppointmentTime.IndexOf("-")).Trim();
            string endTime = onCallAppointmentTime.Substring(onCallAppointmentTime.IndexOf("-") + 1).Trim();
            strContent = "Appointment for " + patientName + " with " + doctorServiceName + " at " + hospitalAddress + " on " + date + " btwn " + startTime + " and " + endTime + " has been Confirmed. Your appointment id is " + token;
            return strContent.ToString();
        }

        if (!isFCFS)
            strContent = "Appointment for " + patientName + " with " + doctorServiceName + " at " + hospitalAddress + " on " + date + " at " + time + " has been Confirmed. Your appointment ID is " + token;
        else
        {
            string startTime = StartTimeEndTime.Substring(0, StartTimeEndTime.IndexOf("-")).Trim();
            string endTime = StartTimeEndTime.Substring(StartTimeEndTime.IndexOf("-") + 1).Trim();
            strContent = "Appointment for " + patientName + " with " + doctorServiceName + " at " + hospitalAddress + " on " + date + " btwn " + startTime + " and " + endTime + " has been Confirmed. Your appointment id is " + token;
        }
        return strContent.ToString();
    }

    public string TrimTextForSMS(string inputString)
    {
        if (inputString.Length >= 20)
            return inputString.Substring(0, 20);
        else
            return inputString;
    }

    public string TrimTextForSMSForBuilding(string inputString)
    {
        if (inputString.Length >= 18)
            return inputString.Substring(0, 18);
        else
            return inputString;
    }



    public System.Xml.Xsl.XslCompiledTransform getCompiledXsltFile(string FileName)
    {
        string lsXsltFile = "";

        lsXsltFile = FileName;
        lsXsltFile = lsXsltFile.ToLower();
        System.Xml.Xsl.XslCompiledTransform oXslt = (System.Xml.Xsl.XslCompiledTransform)HttpContext.Current.Cache.Get(lsXsltFile);

        if (oXslt == null)
        {
            // not in cache so add it 
            oXslt = new System.Xml.Xsl.XslCompiledTransform();
            XmlUrlResolver resolver = new XmlUrlResolver();
            resolver.Credentials = System.Net.CredentialCache.DefaultCredentials;

            // Create the XsltSettings object with script enabled.
            System.Xml.Xsl.XsltSettings settings = new System.Xml.Xsl.XsltSettings();
            settings.EnableDocumentFunction = true;
            settings.EnableScript = true;

            if (System.IO.File.Exists(lsXsltFile) == true)
            {
                oXslt.Load(lsXsltFile, settings, resolver);
                // Add it to the cache 
                HttpContext.Current.Cache.Add(lsXsltFile, oXslt, new System.Web.Caching.CacheDependency(lsXsltFile), System.DateTime.MaxValue, TimeSpan.Zero, System.Web.Caching.CacheItemPriority.NotRemovable, null);
            }
            else
            {
                oXslt = null;
            }

        }
        return oXslt;
    }


    public class AppointmentDetails
    {

        int _tokenSequence;
        public int TokenSequence
        {
            get
            {
                return this._tokenSequence;
            }
            set
            {
                this._tokenSequence = value;
            }
        }

        int _appointmentId;
        public int AppointmentId
        {
            get
            {
                return this._appointmentId;
            }
            set
            {
                this._appointmentId = value;
            }
        }

        int _actionId;
        public int ActionId
        {
            get
            {
                return this._actionId;
            }
            set
            {
                this._actionId = value;
            }
        }

        int _isFCFS;
        public int IsFCFS
        {
            get
            {
                return this._isFCFS;
            }
            set
            {
                this._isFCFS = value;
            }
        }

        string _appointmentDate;
        public string AppointmentDate
        {
            get
            {
                return this._appointmentDate;
            }
            set
            {
                this._appointmentDate = value;
            }
        }

        string _patientName;
        public string PatientName
        {
            get
            {
                return this._patientName;
            }
            set
            {
                this._patientName = value;
            }
        }

        string _onCallAppointmentTime;
        public string OnCallAppointmentTime
        {
            get
            {
                return this._onCallAppointmentTime;
            }
            set
            {
                this._onCallAppointmentTime = value;
            }
        }


        string _actionType;
        public string ActionType
        {
            get
            {
                return this._actionType;
            }
            set
            {
                this._actionType = value;
            }
        }

        string _actionName;
        public string ActionName
        {
            get
            {
                return this._actionName;
            }
            set
            {
                this._actionName = value;
            }
        }

        string _organizationName;
        public string OrganizationName
        {
            get
            {
                return this._organizationName;
            }
            set
            {
                this._organizationName = value;
            }
        }

        string _hospitalAddress;
        public string HospitalAddress
        {
            get
            {
                return this._hospitalAddress;
            }
            set
            {
                this._hospitalAddress = value;
            }
        }

        string _FCFSStartTime;
        public string FCFSStartTime
        {
            get
            {
                return this._FCFSStartTime;
            }
            set
            {
                this._FCFSStartTime = value;
            }
        }

        string _FCFSEndTime;
        public string FCFSEndTime
        {
            get
            {
                return this._FCFSEndTime;
            }
            set
            {
                this._FCFSEndTime = value;
            }
        }

        string _actionMobile;
        public string ActionMobile
        {
            get
            {
                return this._actionMobile;
            }
            set
            {
                this._actionMobile = value;
            }
        }

        string _patientMobile;
        public string PatientMobile
        {
            get
            {
                return this._patientMobile;
            }
            set
            {
                this._patientMobile = value;
            }
        }
        // tokenSequence = appointmentDate = appointmentId = patientName = onCallAppointmentTime = appointmentTime = isFCFS = actionType = actionId = actionName = organizationName = hospitalAddress = FCFSStartTime = FCFSEndTime = actionMobile = patientMobile = "";
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
</body>
</html>
