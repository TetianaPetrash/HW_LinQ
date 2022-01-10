using System;
using System.IO;
using System.Reflection;

namespace Core.Helper
{
    public abstract class DocomentHelper
    {
        public static string GetFilePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException("File is null or empty");
            }
            return Path.Combine(Path.GetDirectoryName(Assembly.GetCallingAssembly().Location) ?? string.Empty, $"FileFolder\\{fileName}");
        }
    }
}
