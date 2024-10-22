using System;
using System.Collections.Generic;

namespace Quiz {
    public class Codec {

        private static readonly Dictionary<string, string> m_Map = new Dictionary<string, string>();

        public string encode(string longUrl) {
            var key = Guid.NewGuid().ToString("N");
            m_Map[key] = longUrl;
            return "http://tinyurl.com/" + key;
        }

        public string decode(string shortUrl) {
            string key = shortUrl.Replace("http://tinyurl.com/", String.Empty);
            return m_Map.TryGetValue(key, out string longUrl) ? longUrl : null;
        }
    }
}
