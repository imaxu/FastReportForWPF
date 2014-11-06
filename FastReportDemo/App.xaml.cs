using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using FastReport.Utils;

namespace FastReportDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Localization\\Chinese (Simplified).frl";
            Res.LoadLocale(path);

            Config.DesignerSettings.Restrictions.DontCreateReport = true;
            Config.DesignerSettings.Restrictions.DontShowRecentFiles = true;
            Config.DesignerSettings.Restrictions.DontLoadReport = true;
            Config.DesignerSettings.Text = "盈加报表工具-设计器";
            

            Config.PreviewSettings.Text = "盈加报表工具-预览";

            base.OnStartup(e);
        }
    }
}
