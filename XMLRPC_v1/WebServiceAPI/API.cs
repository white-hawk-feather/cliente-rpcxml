//==========================================================================================
//
//		WebServiceAPI XML-RPC
//		Copyright (C) 2011-2012, Hélvio Junior
//		E-mail: helvio_junior@hotmail.com
//
//		This library is free software; you can redistribute it and/or modify it.
//
//==========================================================================================

using System;
using System.Collections.Generic;
using CookComputing.XmlRpc;
using System.Text;

namespace WebServiceAPI
{
	
	public class APIBase
	{
		internal IStateName proxy;
		
		public APIBase(Uri uri) : this(uri, false){}
		
		public APIBase(Uri uri, Boolean ignoreCertificateErrors){
			
			if (ignoreCertificateErrors)
				System.Net.ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);
			
			proxy = (IStateName)XmlRpcProxyGen.Create(typeof(IStateName));
			proxy.Url = uri.AbsoluteUri;
		}
		
		public getUsersBlogsResponse[] UsersBlogs(String username, String password)
		{
			return proxy.getUsersBlogs(username, password);
		}
		
		public getPageListResponse[] PageList(Int32 blog_id, String username, String password)
		{
			return proxy.getPageList(blog_id, username, password);
		}
		
		public String[] ListMethods()
		{
			 return proxy.ListMethods();
		}
		
		public static String DumpVariable(Object obj){
			
			return DumpVariable(obj, "");
		}
		
		public static String DumpVariable(Object obj, String printPrefix)
		{
			StringBuilder dumpText = new StringBuilder();
			
			try {
				dumpText.AppendLine(printPrefix + "type ==> " + obj.GetType());
			} catch (Exception) { }
			
			if (obj is XmlRpcStruct)
			{
				foreach(String key in ((XmlRpcStruct)obj).Keys){
					dumpText.AppendLine(printPrefix + key);
					dumpText.AppendLine(DumpVariable(((XmlRpcStruct)obj)[key], printPrefix + "\t"));
				}
			}
			else if (obj is XmlRpcStruct[]){
				foreach(XmlRpcStruct r1 in ((XmlRpcStruct[])obj)){
					dumpText.AppendLine(DumpVariable(r1, printPrefix + "\t"));
				}
			}
			else if (obj is Object[])
			{
				foreach(Object t in ((Object[])obj)){
					dumpText.AppendLine(DumpVariable(t, printPrefix + "\t   "));
				}
			}
			else if (obj is String)
			{
				if (obj != null)
					dumpText.AppendLine(printPrefix + "\t   " +obj.ToString());
			}
			else if (obj is String[])
			{
				foreach(Object t in ((String[])obj)){
					if (t != null)
					dumpText.AppendLine(printPrefix + "\t   " +t.ToString());
				}
			}
			else
			{
				if (obj != null)
					dumpText.AppendLine(printPrefix + "\t   " + obj.ToString());
			}
		
			return dumpText.ToString();
		}
		
	}
}