using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVaXLS
{
    public class Helpers
    {
        public static string HumanReadableSize(long byteLength)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            int order = 0;
            while (byteLength >= 1024 && order < sizes.Length - 1)
            {
                order++;
                byteLength = byteLength / 1024;
            }
            string result = string.Format("{0:0.##} {1}", byteLength, sizes[order]);
            return result;
        }
    }
}
