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
using CookComputing.XmlRpc;

namespace WebServiceAPI
{
	
	public struct getUsersBlogsResponse
	{
		public Boolean isAdmin;
		public String url;
		public String blogid;
		public String blogName;
		public String xmlrpc;
	}
		
	public struct getPageListResponse
	{
		public String page_id;
		public String page_title;
		public DateTime dateCreated;
		public DateTime date_created_gmt;
	}
	
	//Exemplo do pagelist sem alguns parâmetros
	[XmlRpcMissingMapping(MappingAction.Ignore)]
	public struct getPageListResponse2{
		public String page_id;
		public String page_title;
	}
	
	
}
