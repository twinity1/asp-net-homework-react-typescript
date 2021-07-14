using System;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace AspHomework2.FileSystem
{
    public class FileWriter
    {
        private readonly IHostEnvironment _hostEnvironment;

        public FileWriter(IHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }
        
        //returns file name
        public string SaveBase64File(string fileName, string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);

            var timestampMs = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            var resultFileName = $"{timestampMs}_{fileName}";

            var filePath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot/files", resultFileName);
            
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileStream.Write(bytes);
                fileStream.Close();
            }
            
            return resultFileName;
        }
    }
}