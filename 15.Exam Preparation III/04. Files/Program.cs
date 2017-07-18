using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class FIle
    {
        public string Extension { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string Root { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var files = new List<FIle>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var path = Console.ReadLine();
                var pattern = @"(.+\\)*(.+.[a-zA-Z0-9]+;[0-9]+)";
                var match = Regex.Match(path, pattern);
                var fileInfo = match.Groups[2].Value.Split(';').First();
                if (fileInfo.Contains('.'))
                {
                    var fileExtension = fileInfo.Split('.').Last();
                    var fileName = fileInfo.Substring(0, fileInfo.LastIndexOf('.'));
                    var size = long.Parse(match.Groups[2].Value.Split(';').Last());
                    var root = match.Groups[1].Value.Split("\\ ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).First();

                    if (files.Any(a => a.Root == root && a.Name == fileName && a.Extension == fileExtension))
                    {
                        files.First(a => a.Root == root && a.Name == fileName && a.Extension == fileExtension).Size = size;
                    }
                    else
                    {
                        files.Add(ReadFile(fileExtension, fileName, size, root));
                    }
                }

            }

            var searchCriteria = Console.ReadLine().Split(' ').ToArray();
            var extensionToGet = searchCriteria[0];
            var rootToGet = searchCriteria[2];
            bool availability = false;
            foreach (var file in files.OrderByDescending(a => a.Size).ThenBy(a => a.Name))
            {
                if (file.Extension == extensionToGet && file.Root == rootToGet)
                {
                    Console.WriteLine($"{file.Name}.{file.Extension} - {file.Size} KB");
                    availability = true;
                }
            }
            if (!availability)
            {
                Console.WriteLine("No");
            }
        }

        private static FIle ReadFile(string fileExtension, string fileName, long size, string root)
        {
            var file = new FIle();
            file.Extension = fileExtension;
            file.Name = fileName;
            file.Size = size;
            file.Root = root;

            return file;
        }
    }
}
