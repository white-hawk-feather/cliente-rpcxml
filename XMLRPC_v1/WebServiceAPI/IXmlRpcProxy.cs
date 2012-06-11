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
		
	public interface IStateName : IXmlRpcProxy
	{
  
		[XmlRpcMethod("system.listMethods")]
		String[] ListMethods();
		
		[XmlRpcMethod("wp.getUsersBlogs")]
		getUsersBlogsResponse[] getUsersBlogs(String username, String password);
		
		[XmlRpcMethod("wp.getPageList")]
		getPageListResponse[] getPageList(Int32 blog_id, String username, String password);
				
	}
}
