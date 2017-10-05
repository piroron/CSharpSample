using System;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitSample {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Start:GetResponse");

            var waiter = GetResponse();
            //var waiter = GetResponseDummy();

            //１．非同期処理の終了を単純に待つ
            //Console.WriteLine(waiter.Result);

            //２．後続タスクとして実行する
            waiter.ContinueWith((t) => Console.WriteLine(t.Result));

            Console.WriteLine("Complete:GetResponse");

            waiter.Wait();

            Console.ReadLine();
        }

        static async Task<string> GetResponse() {

            WebGetAccessor accessor = new WebGetAccessor();

            //example
            string res = await accessor.GetResponseAsync("http://hatenablog.com/");
            //string res = await accessor.GetResponseAsync("Invalid Url");

            return res;
        }

        /// <summary>
        /// ダミータスクを非同期実行
        /// </summary>
        /// <returns></returns>
        static async Task<string> GetResponseDummy() {

            WebGetAccessor accessor = new WebGetAccessor();

            //example
            string res = await accessor.GetResponseDummyAsync("http://hatenablog.com/");

            return res;
        }
    }
}