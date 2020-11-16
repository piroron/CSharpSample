using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharp70
{
    /// <summary>
    /// Local Function practice : <see cref="https://docs.microsoft.com/ja-jp/dotnet/csharp/whats-new/csharp-7#local-functions">official link</see>
    /// </summary>
    public class LocalFunction
    {

        public Task<string> GetResponseAsync(string url)
        {
            void checkUrl()
            {
                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    throw new ArgumentException("This URL is bad format!");
                }
            }

            checkUrl();

            return get();

            async Task<string> get()
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);
                    return await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
