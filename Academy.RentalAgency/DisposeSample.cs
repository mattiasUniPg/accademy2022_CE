using System;
using System.Collections.Generic;
using System.IO;


namespace TryCatchLegacy
{
    public class DisposeSample
    {

        public string ReadFile(string path)
        {
            var streamReader = new StreamReader(path);
            var output = streamReader.ReadToEnd();
            streamReader.Close();
            streamReader.Dispose();
            return output;
        }


        public string ReadFileUsing(string path)
        {
            using var streamReader = new StreamReader(path);

            return streamReader.ReadToEnd();

        }
    }
}