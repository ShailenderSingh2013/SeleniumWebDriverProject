using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomationHelper.Reporter
{
    public class Reporter
    {
        public static ExtentTest test;
        private static bool IsExtenetReportStarted = false;
        private static string ApplicationDebuggingFolder => @"C:\Data\report";
        private static string HtmlReportFullPath { get; set; }
        public static string LatestResultsReportFolder { get; set; }
        public static ExtentReports ReportManager { get; set; }
        private static void CreateReportDirectory()
        {
            var filePath = Path.GetFullPath(ApplicationDebuggingFolder);
            LatestResultsReportFolder = Path.Combine(filePath, DateTime.Now.ToString("MMdd_HHmm"));
            Directory.CreateDirectory(LatestResultsReportFolder);

            HtmlReportFullPath = $"{LatestResultsReportFolder}\\TestResults.html";
        }
        public static void StartReporter()
        {
            CreateReportDirectory();
            var htmlReporter = new ExtentHtmlReporter(HtmlReportFullPath);
            ReportManager = new ExtentReports();
            ReportManager.AttachReporter(htmlReporter);
        }
        public static void GetReportManager()
        {
            if (!IsExtenetReportStarted)
            {
                IsExtenetReportStarted = true;
                StartReporter();
            }
        }

        public static void ReportFlush()
        {
            ReportManager.Flush();
        }

    }
}
