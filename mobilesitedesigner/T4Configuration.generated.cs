﻿using System;
using System.Configuration;

namespace mobilesitedesigner
{
	public static partial class Common
	{
	
		public static string  ImagesPath
		{
			get
			{
				return    ConfigurationManager.AppSettings["ImagesPath"];
			}
		}
	
		public static string  ImagesRelPath
		{
			get
			{
				return    ConfigurationManager.AppSettings["ImagesRelPath"];
			}
		}
	
		public static string  DefaultCountryCode
		{
			get
			{
				return    ConfigurationManager.AppSettings["DefaultCountryCode"];
			}
		}
	
		public static string  DefaultStateCode
		{
			get
			{
				return    ConfigurationManager.AppSettings["DefaultStateCode"];
			}
		}
	
		public static int  PageSize
		{
			get
			{
				return    int.Parse(ConfigurationManager.AppSettings["PageSize"]);
			}
		}
		public static String DataConnectionString
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["DataConnectionString"].ConnectionString;
			}
		}
	}
}

