﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALE.Http;
using System.Web;

namespace ALE.Web
{
	public class AleRequest : IRequest
	{
		public readonly HttpRequest InnerRequest;
		public AleRequest(HttpRequest innerRequest, IContext context)
		{
			InnerRequest = innerRequest;
			Context = context;
		}

		public IContext Context { get; private set; }

		public IEnumerable<string> AcceptTypes
		{
			get { return InnerRequest.AcceptTypes; }
		}

		public Encoding ContentEncoding
		{
			get { return InnerRequest.ContentEncoding; }
		}

		public long ContentLength
		{
			get { return InnerRequest.ContentLength; }
		}

		public string ContentType
		{
			get { return InnerRequest.ContentType; }
		}

		public System.Net.CookieCollection Cookies
		{
			get { throw new NotImplementedException("Sorry, I'm working on this."); }
		}

		public System.IO.Stream InputStream
		{
			get { return InnerRequest.InputStream; }
		}

		public string Method
		{
			get { return InnerRequest.HttpMethod; }
		}

		public System.Collections.Specialized.NameValueCollection Headers
		{
			get { return InnerRequest.Headers; }
		}

		public bool IsAuthenticated
		{
			get { return InnerRequest.IsAuthenticated; }
		}

		public bool IsLocal
		{
			get { return InnerRequest.IsLocal; }
		}

		public Uri Url
		{
			get { return InnerRequest.Url; }
		}

		public Uri UrlReferer
		{
			get { return InnerRequest.UrlReferrer; }
		}

		public string UserAgent
		{
			get { return InnerRequest.UserAgent; }
		}

		public IEnumerable<string> UserLanguages
		{
			get { return InnerRequest.UserLanguages; }
		}
	}
}