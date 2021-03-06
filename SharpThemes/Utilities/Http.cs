﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;
using System.Net;

namespace SharpThemes.Utilities
{
    public static class Http
    {
        public static async Task<string> DoGet(string url) {
            using (var client = new HttpClient(new NativeMessageHandler())) {
                try {
                    return WebUtility.UrlDecode(await client.GetStringAsync(url));	
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }
    }
}

