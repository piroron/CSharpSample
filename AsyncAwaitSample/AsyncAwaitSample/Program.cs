using System;
using static System.Console;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitSample {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Start:GetResponse");

            WebGetAccessor accessor = new WebGetAccessor();

            var waiter = accessor.GetResponseAsync("http://hatenablog.com/");
            //var waiter = accessor.GetResponseDummyAsync("http://hatenablog.com/");

            //１．非同期処理の終了を単純に待つ
            //WriteLine(waiter.Result);

            //２．後続タスクとして実行する
            waiter.ContinueWith((t) => WriteLine(t.Result));

            WriteLine("Complete:GetResponse");

            //キーを押すまで、アプリを待機させる
            WriteLine("Press key to exit.");

            ReadLine();
        }
    }
}