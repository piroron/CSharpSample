using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitSample {
    /// <summary>
    /// Getリクエストを実行する
    /// </summary>
    class WebGetAccessor {

        #region Task<T>を返す非同期メソッド
        /// <summary>
        /// Request Get Response
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns>Response Body</returns>
        public async Task<string> GetResponseAsync(string url) {

            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) {
                return "This URL is bad format!";
            }

            using (var client = new HttpClient()) {

                var response = await client.GetAsync(url, HttpCompletionOption.ResponseContentRead);

                return await response.Content.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// Request Get Response(Dummy Method)
        /// </summary>
        /// <param name="url">URL</param>
        /// <returns></returns>
        public async Task<string> GetResponseDummyAsync(string url) {

            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) {
                return "This URL is bad format!";
            }

            //別スレッドで待つ。リクエストを投げた状態と同様になる
            await Task.Run(async () => await Task.Delay(1000));
            //これだと、現在のスレッドで待つ
            //await Task.Delay(1000);

            return "complete!";
        }

        #endregion

        /// <summary>
        /// Post Request
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public async Task PostAsync(string url, string value) {
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute)) {
                return;
            }

            var client = new HttpClient();
            var content = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("value", value)
            });


            var response = await client.PostAsync(url, content);

            if (!response.IsSuccessStatusCode) {
                throw new HttpRequestException("Request Failed!");
            }
        }

        public async Task FireAsync() {

        }
    }
}
