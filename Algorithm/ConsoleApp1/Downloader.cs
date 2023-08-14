using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace ConsoleApp1
{
    class Downloader
    {
        public static void DownloadImage()
        {
            var req = WebRequest.Create("https://youcantdownloadthisimage.online/lisa.jpg");
            var res = req.GetResponse();
            var resStream = res.GetResponseStream();
            var contentLength = res.ContentLength;
            var reader = new BinaryReader(resStream);
            //Console.Write(contentLength);
            var buffer = reader.ReadBytes(10000000);
            File.WriteAllBytes("D:/lisa.jpg", buffer);
        }
    }
}
