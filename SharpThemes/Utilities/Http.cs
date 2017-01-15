using System;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;

namespace SharpThemes.Utilities
{
	public static class Http
	{
		public static async Task<string> DoGet(string url) {
			using (var client = new HttpClient(new NativeMessageHandler())) {
				return await client.GetStringAsync(url);	
			}
		}
	}
}

