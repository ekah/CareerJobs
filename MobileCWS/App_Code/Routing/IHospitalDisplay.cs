using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Implements IHttpHandlers and contains uniqueName
/// </summary>
public interface IHospitalDisplay : IHttpHandler
{
    string fdoctorname { get; set; }
}
