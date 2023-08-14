using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Xml.Schema;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Reflection;
using System.Windows;

//using System.Net.Sockets;

namespace ConsoleApp1
{
    
    class Program
    {
        static int minCoins(int[] coins, int m, int V)
        {
            // base case 
            if (V == 0) return 0;
            // Initialize result 
            int res = int.MaxValue;
            // Try every coin that has 
            // smaller value than V 
            for (int i = 0; i < m; i++)
            {
                if (coins[i] <= V)
                {
                    int sub_res = minCoins(coins, m, V - coins[i]);
                    
                    if (sub_res != int.MaxValue && sub_res + 1 < res)
                        res = sub_res + 1;
                }
            }
            return res;
        }
        static int SumSquares(long k)
        {
            long a = (long)Math.Sqrt(k);
            long b = (long)Math.Ceiling(Math.Sqrt(k / 2));
            
            int c = 0;
            for (; b <= a; b++)
            {
                double d = Math.Sqrt(k - b * b);
                if (d == 0) return c + 1;
                if (d % 1 == 0) c += 2;
            }
            return c;
        }
        // Driver Code 
        public static void Main()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var db = client.GetDatabase("EcommerceSite");
            var collection = db.GetCollection<Model>("Items");
            var filter = Builders<Model>.Filter.Empty;
            var res = collection.Find(filter).FirstOrDefault();
            //var prop = res.GetElement(3).ToBsonDocument();
            Console.WriteLine(res.DetailSpecs[0].value);
        }
        static void DownloadFromAnimet()
        {
            var req = WebRequest.Create("https://cdn-3.2phimhay.com/video.mp4?hash=1d7f6960095ee1d35f08d8d833f70938286f37f2a34b5a78f9336b7eb4cfa25e425d76713e339c6341e904101608db900869eafc4f9348aa8a5921ecd150cbd3f89f7ce50e712698d3fa479dfff338f969d0e918f8fe61e179c5df3f17bfacf5816008348f93713bd7ab1c98aba44cbd59d57d98cdd5af75b034e8f53d5f0e8ff60feb1c15ad9030c9d11559f0e10dfd1b9b97d1a80b60affe446e9dc162725fdb8922f47ccbab953bbd387e80c49fd139264c23378ac504eec2a32a6cfb5434a78370f6f53431d9e88702799a1e7e6c1740d332467d3b92a76b22655e9b5f39237df8f969e9b2e3e86bf5abce4169d18cca367d0c9a3b7a83ea3795208ed39f03d0510685f88837b3fc2ef1e94c5b8225126a5bc313f910cc572f156ecf82f0347ddf982da3aa8350c316831973f2d97e4dc518528b4a1e867de79ee51a816bb7c5f07b020bcc0351c722bba1a71b1e5580ed68883d0228bbff0dbb9268b222e108a748c301f80717dcecd306baf26c191223a1ada4e02edca3560cffeac2d5d41e2e8981f190ab7e133222086e9def61e8b81026dcc2ffec1c13dbde6516caab69a2c07017b6437e9ea21cf91929988e28ba020bd5dd1b53977c5b367dc1b2a43fe03fb34d51d976bd9f09306616a6628d50f39c3aacd44ede840fd3d99929399e536ae3217da8f11faf7fd7069769c6e90bfdd8fb0e02051af911ce4c2ac87bcfe29abc0a384623739e67dd3d9ae7d347455d6bea3671ca2e323696e955199929d478e8cb88d03f7b3fd98f83622265e3ed21b82995042fc427c27b1c1a9b56bf4b3cb3e876aa17d3496eb630c4fffd3f9ae3952d1982cff9e43aa10259ebb33944503ef91fe878a19c854cb7893d08f6d919ab32e785290c1bc25b3d5b9d0760853bedf5bf9f8b218d4145de48ae6cac87b7196141f4551dd684d1787412f098245e5f76982d26a3afe1b5b04da96d33d347b249cc703f63c29e585ff2a46339bea33aac4716a99bb366c7acf86732676f276bd53ad49541b5d65214bf8808f30623a0c7dec4346ec93db3f246c973a3a76572363113e7f4f4fc19b38746ec002602d7b403852c55e3e70e34f1218c5c731635419675d6f583a6e21f39d5238bd18128eae808616a2b8658b8&cookie=BW5QfGLildQ&key=lbs.cdnproxy.xyz&exp=a9e85a0274c6af53c96ed61a18baa5a1") as HttpWebRequest;
            req.Headers["referer"] = "https://api.anime3s.com/";
            var res = req.GetResponse();
            var contentLength = res.ContentLength;
            var resStream = res.GetResponseStream();
            Console.Write(contentLength);
            var reader = new BinaryReader(resStream);
            byte b = 0;
            var bytes = new byte[contentLength];
            long byteRead = 0;
            var buffer = reader.ReadBytes(100000000);
            File.WriteAllBytes("D:/data.txt", buffer);

        }
        static async void Test()
        {
            while (true) {
                await Task.Delay(1000);
                Console.WriteLine("t");
            }
        }
        
        static string test()
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
            }
            return "complete";
        }
        static int SumOfOddNumbers(int a, int b)
        {
            if (b - a == 1) return 0;
            if (b - a == 2 && b % 2 != 0) return 0;
            a += 2;
            b -= 2;
            if (a % 2 == 0) a--;
            if (b % 2 == 0) b++;
            int count = (b - a) / 2 + 1;
            int sum = (b + a) * count / 2;
            long div = 10000007;
            return (sum % 10000007);
        }
        static long met(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++)
            {
                res += (i * 2 + i - 2);
            }
            return res;
        }
        static string Combination(int n, int k)
        {
            long one = 1; long minusOne = -1;
            if (n == k) return one.ToString();
            if (n < k) return minusOne.ToString();
            long a = 1; long b = 1;
            for (long i = k + 1; i <= n; i++)
            {
                a *= i;
            }
            for (long i = 2; i <= n - k; i++)
            {
                b *= i;
                Console.WriteLine(b);
            }
            
            //return (a / b).ToString();
            return "-";
        }

        static string Reverse(string s)
        {
            string res = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                res += s[i];
            }
            return res;
        }
        static int Max(string[] s)
        {
            int res = 0;
            foreach (var i in s)
            {
                if (i.Length <= res) continue;
                res = i.Length;
            }
            return res;
        }

        static int MinimumSquares1(int n, int m)
        {
            if (n == 0 || m == 0) return 0;
            int a = m;
            int b = n;
            if (n > m) { n = a; m = b; }
            if (n == 1) return m;
            int st = m / n;
            return st + MinimumSquares1(m % n, n);
        }

        static int MaxPrice(int index, int length, int[] lengthList, int[] priceList)
        {
            if (index < 0) return 0;
            int b = MaxPrice(index - 1, length, lengthList, priceList);
            if (lengthList[index] > length) return b;
            int a = priceList[index] + MaxPrice(index - 1, length - lengthList[index], lengthList, priceList);
            
            return Math.Max(a, b);
        }

        static string MinNumber(string n, int a, int b)
        {
            if (a == b) return "empty";
            List<int> li = new List<int>();
            foreach (var i in n)
            {
                li.Add(int.Parse(i.ToString()));
            }
            li.Sort();
            li.Reverse();

            List<int> newLi = li.GetRange(0, b);
            newLi.ForEach(n => Console.WriteLine(n));
            //for (int i = 0; i < n.Length; i++)
            //{
            //    if (newLi.Count == 0) break;
            //    int cur = int.Parse(n[i].ToString());
            //    if (newLi.Contains(cur))
            //    {
            //        n = n.Remove(i, i);
            //        newLi.Remove(cur);
            //    }
            //}
            return n.TrimStart('0');
        }
        static long MigratoryBirds(long[] input)
        {
            SortedDictionary<long, long> dict = new SortedDictionary<long, long>();
            long maxKey = 0;
            long maxVal = 0;
            foreach (long i in input)
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, 1);
                    continue;
                }
                dict[i]++;

            }

            foreach (long key in dict.Keys)
            {
                if (dict[key] <= maxVal) continue;
                maxKey = key;
                maxVal = dict[key];
            }
            return maxKey;
        }
        static long[] Square(long n)
        {
            long []o = { -1 };
            List<long> li = new List<long>();
            int[] lasts = { 0, 1, 4, 9, 5, 6 };
            List<int> lastList = lasts.ToList();
            if (n < 10) return o ;
            for (long i = 10; i <= n; i ++)
            {
                string q = i.ToString();
                int first = int.Parse(q[0].ToString());
                int last = int.Parse(q[q.Length - 1].ToString());
                if (first < last) continue;
                if (!lastList.Contains(10 + last - first)) continue;
                long reverse = long.Parse(Reverse(q));
                long res = i - reverse;
                string a = Math.Sqrt(res).ToString();
                if (a.Contains(".")) continue;
                //Console.WriteLine(a);
                li.Add(i);
            }
            if (li.Count == 0) return o;
            return li.ToArray();
        }
        
        static float Median(int[] arr)
        {
            Array.Sort(arr);
            if (arr.Length % 2 == 1) return (float)arr[arr.Length / 2];
            else
            {
                float res = (float)(arr[arr.Length / 2] + arr[arr.Length / 2 - 1]) / 2;
                return res;
            }
        }
        static void Work(string input)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            
            for (int i = 1; i <= input.Length; i++)
            {
                for (int j = 0; j <= input.Length - i; j++)
                {
                    string sub = input.Substring(j, i);
                    //Console.WriteLine(sub);
                    bool cango = false;
                    List<string> keys = new List<string>();
                    foreach (string n in dic.Keys)
                    {
                        //if (Check(n, sub))
                        //{
                        //    cango = true;
                        //    dic[n]++;
                        //}
                        keys.Add(n);
                    }
                    foreach (string n in keys)
                    {
                        if (Check(n, sub))
                        {
                            cango = true;
                            dic[n]++;
                        }
                    }
                    if (cango) continue;
                    dic[sub] = 1;
                }
            }

            foreach (string i in dic.Keys)
            {
                Console.WriteLine(i + " " + dic[i]);
            }
        }

        static bool Check(string a, string b)
        {
            Dictionary<string, int> adic = new Dictionary<string, int>();
            Dictionary<string, int> bdic = new Dictionary<string, int>();

            foreach (char n in a)
            {
                string i = n.ToString();
                if (adic.ContainsKey(i))
                {
                    adic[i]++;
                    continue;
                }
                adic[i] = 1;
            }
            foreach (char n in b)
            {
                string i = n.ToString();
                if (bdic.ContainsKey(i))
                {
                    bdic[i]++;
                    continue;
                }
                bdic[i] = 1;
            }
            if (adic.Count != bdic.Count) return false;
            foreach (string key in adic.Keys)
            {
                if (!bdic.ContainsKey(key)) return false;
                if (bdic[key] != adic[key]) return false;
                
            }
            return true;
        }

    }
}
