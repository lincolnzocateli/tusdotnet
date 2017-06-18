using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tusdotnet.Adapters
{
	internal class RequestAdapter
	{
		public string Method { get; set; }
		public Uri RequestUri { get; set; }
		public Stream Body { get; set; }
		public Dictionary<string, List<string>> Headers { get; set; }

	    public string ContentType => GetHeader("Content-Type");

	    public string GetHeader(string name)
	    {
	        return Headers?.ContainsKey(name) == true ? Headers[name].First() : null;
	    }
	}
}