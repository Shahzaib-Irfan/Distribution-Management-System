using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMSmain.Interfaces;

namespace DMSmain.BL
{
    public class Grapher:IGrpaher
    {
        /// <summary>
        /// Plots Bar Chart. t1 is the list of strings for placement on x axis, and t2 is vertical
        /// y-axis.
        /// </summary>
        /// <param name="t1">List of strings to use as x-axis</param>
        /// <param name="t2">List of integer values on bar charts.</param>
        public static void PlotBar(List<string> t1 , List<Int32> t2)
        {
            try
            {
                string path = "parser.txt";
                StreamWriter s = new StreamWriter(path);

                for (int i = 0; i < t1.Count - 1; i++)
                {
                    s.Write(t1[i] + ",");
                    s.Flush();
                }
                s.Write(t1[t1.Count - 1]);
                s.Flush();
                s.Write('\n');
                for (int i = 0; i < t2.Count - 1; i++)
                {
                    s.Write(t2[i] + ",");
                    s.Flush();
                }
                s.Write(t2[t2.Count - 1]);
                s.Flush();
                s.Close();

                ProcessStartInfo pro = new ProcessStartInfo();
                pro.FileName = @"C://Users//Afraz Butt//AppData//Local//Programs//Python//Python310//python.exe";
                var script = @"grapher.py";

                pro.UseShellExecute = false;
                pro.CreateNoWindow = true;
                pro.RedirectStandardOutput = true;
                pro.RedirectStandardError = true;

                pro.Arguments = string.Format("{0}", script);

                using (Process process = Process.Start(pro))
                {
                    using (StreamReader f = process.StandardOutput)
                    {
                        string resilt = f.ReadToEnd();
                    }
                }
            }
            catch { }
        }
        public void plotGraph(List<string> t1, List<Int32> t2)
        {
            string path = "parser.txt";
            StreamWriter s = new StreamWriter(path);

            for (int i = 0; i < t1.Count - 1; i++)
            {
                s.Write(t1[i] + ",");
                s.Flush();
            }
            s.Write(t1[t1.Count - 1]);
            s.Flush();
            s.Write('\n');
            for (int i = 0; i < t2.Count - 1; i++)
            {
                s.Write(t2[i] + ",");
                s.Flush();
            }
            s.Write(t2[t2.Count - 1]);
            s.Flush();
            s.Close();

            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = @"C://Users//Afraz Butt//AppData//Local//Programs//Python//Python310//python.exe";
            var script = @"grapher.py";

            pro.UseShellExecute = false;
            pro.CreateNoWindow = true;
            pro.RedirectStandardOutput = true;
            pro.RedirectStandardError = true;

            pro.Arguments = string.Format("{0}", script);

            using(Process process = Process.Start(pro))
            {
                using(StreamReader f = process.StandardOutput)
                {
                    string resilt = f.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// Plots Line Chart. t1 is the list of strings for placement on x axis, and t2 is vertical
        /// y-axis. Has a seaweed-green color style background.
        /// </summary>
        /// <param name="t1">List of strings to use as x-axis</param>
        /// <param name="t2">List of integer values on line charts.</param>
        public static void PlotLine(List<string> t1, List<Int32> t2)
        {
            string path = "parser.txt";
            StreamWriter s = new StreamWriter(path);

            for (int i = 0; i < t1.Count - 1; i++)
            {
                s.Write(t1[i] + ",");
                s.Flush();
            }
            s.Write(t1[t1.Count - 1]);
            s.Flush();
            s.Write('\n');
            for (int i = 0; i < t2.Count - 1; i++)
            {
                s.Write(t2[i] + ",");
                s.Flush();
            }
            s.Write(t2[t2.Count - 1]);
            s.Flush();
            s.Close();

            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = @"C://Users//Afraz Butt//AppData//Local//Programs//Python//Python310//python.exe";
            var script = @"line.py";

            pro.UseShellExecute = false;
            pro.CreateNoWindow = true;
            pro.RedirectStandardOutput = true;
            pro.RedirectStandardError = true;

            pro.Arguments = string.Format("{0}", script);

            using (Process process = Process.Start(pro))
            {
                using (StreamReader f = process.StandardOutput)
                {
                    string resilt = f.ReadToEnd();
                }
            }
        }
        /// <summary>
        /// Plots Pie Chart. t1 is the list of strings for labels, and t2 is pie's of project.
        /// </summary>
        /// <param name="t1">List of strings to use as labels.</param>
        /// <param name="t2">List of integer values in pie charts..</param>
        public static void PlotPie(List<string> t1 , List<Int32> t2)
        {
            string path = "parser.txt";
            StreamWriter s = new StreamWriter(path);

            for (int i = 0; i < t1.Count - 1; i++)
            {
                s.Write(t1[i] + ",");
                s.Flush();
            }
            s.Write(t1[t1.Count - 1]);
            s.Flush();
            s.Write('\n');
            for (int i = 0; i < t2.Count - 1; i++)
            {
                s.Write(t2[i] + ",");
                s.Flush();
            }
            s.Write(t2[t2.Count - 1]);
            s.Flush();
            s.Close();

            ProcessStartInfo pro = new ProcessStartInfo();
            pro.FileName = @"C://Users//Afraz Butt//AppData//Local//Programs//Python//Python310//python.exe";
            var script = @"pie.py";

            pro.UseShellExecute = false;
            pro.CreateNoWindow = true;
            pro.RedirectStandardOutput = true;
            pro.RedirectStandardError = true;

            pro.Arguments = string.Format("{0}", script);

            using (Process process = Process.Start(pro))
            {
                using (StreamReader f = process.StandardOutput)
                {
                    string resilt = f.ReadToEnd();
                }
            }
        }
    }
}
