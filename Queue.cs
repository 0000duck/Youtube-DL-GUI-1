﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace youtube_dl
{
    class Queue
    {
        private List<Video> videos = new List<Video>();
        private Process ytbDL = new Process();

        private ProcessStartInfo ytbDLInfo = new ProcessStartInfo
        {

            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true,
            StandardOutputEncoding = Encoding.UTF8,
            FileName = "youtube-dl.exe"
        };

        public List<Video> Videos { get => videos; set => videos = value; }

        public Dictionary<string, string> getFormats(string url)
        {
            string output = "";
            string arguments = "-F " + url;
            Dictionary<string, string> formats = new Dictionary<string, string>();

            ytbDLInfo.Arguments = arguments;

            ytbDL = Process.Start(ytbDLInfo);

            ytbDL.OutputDataReceived += new DataReceivedEventHandler(
                (s, f) =>
                {
                    output = f.Data ?? "null";

                    if(char.IsDigit(output[0]))
                    {
                        string code, desc;

                        MatchCollection values = Regex.Matches(output, @"([^\s]+)");
                        if (values.Count > 4)
                        {
                            code = values[2].ToString() == "audio" ? values[0].ToString() : values[0].ToString() + " " + values[1].ToString();
                            desc = values[1].ToString() + " (";
                            desc = values[2].ToString() == "audio" ? desc + values[2].ToString() + ' ' + values[6].ToString() + ')' : desc + values[2].ToString() + ' ' + values[3].ToString() + ')';
                        }
                        else
                        {
                            code = values[0].ToString();
                            desc = values[1].ToString();
                        }

                        formats.Add(code, desc);
                    }
                });

            ytbDL.Start();
            ytbDL.BeginOutputReadLine();
            ytbDL.WaitForExit();
            ytbDL.CancelOutputRead();

            if(formats.Count > 0)
            {
                formats.Add("default", "default (mp4)");
                formats.Add("mp3", "mp3");
                formats.Add("flac", "flac");
            }

            return formats;
        }
    }
}
