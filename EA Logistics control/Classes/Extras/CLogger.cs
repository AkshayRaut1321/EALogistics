using System;
using System.IO;

namespace ExtraFunctions
{
    class CLogger
    {
        static FileStream fs;
        static StreamWriter sw;
        static string Err;

        /// <summary>
        /// Accumulates all exceptions raised and caught from this application to a log file (*.txt) for later viewing.
        /// </summary>
        /// <param name="msg">A string parameter containing exception information.</param>
        public static string setErrorLog(int ErrId, string msg)
        {
            try
            {
                msg = "Log starts\t" + DateTime.Now.ToString() + "\t" + ErrId + "\t" + msg + "\n";
                FileInfo fi = new FileInfo(Directory.GetCurrentDirectory().Replace(@"bin\Debug", @"Logs\error_log.txt"));
                if (!fi.Exists)
                    msg = "Log starts\tDate and Time\t\tErrorID\tException\n\n" + msg;
                fs = new FileStream(fi.FullName, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(msg);
                Err = "";
            }
            catch (Exception Ex)
            {
                Err = Ex.Message;
            }
            if (sw != null)
            {
                sw.Close();
                sw = null;
            }
            if (fs != null)
            {
                fs.Close();
                fs = null;
            }
            msg = null;
            return Err;
        }
    }
}
