using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FastReport;

namespace FastReportDemo
{
    /// <summary>
    /// BlankReportDesginerView.xaml 的交互逻辑
    /// </summary>
    public partial class BlankReportDesginerView : Window
    {
        private Report m_Report = null;
        private bool m_HasSaved = false;
        public BlankReportDesginerView()
        {
            InitializeComponent();
            InitDesigner();
        }

        public BlankReportDesginerView(Report p_Report)
        {
            InitializeComponent();
            m_Report = p_Report;
            InitDesigner(CurrentReport);


        }

        private void InitDesigner(Report report)
        {
            
            designer.Report = report;
            designer.Report.Load(report.FileName);
            designer.AskSave = true;
            designer.cmdSave.CustomAction += new EventHandler(cmdSave_CustomAction);
            designer.cmdNew.CustomAction += new EventHandler(cmdNew_CustomAction);
            designer.RefreshLayout();
        }

        private void InitDesigner()
        {
            designer.Report = new Report();
            designer.AskSave = true;
            designer.cmdSave.CustomAction += new EventHandler(cmdSave_CustomAction);
            designer.cmdNew.CustomAction += new EventHandler(cmdNew_CustomAction);
            designer.RefreshLayout();
        }

        void cmdNew_CustomAction(object sender, EventArgs e)
        {
            BlankReportDesginerView newReportView = new BlankReportDesginerView() { Owner = this };
            newReportView.ShowDialog();
        }

        void cmdSave_CustomAction(object sender, EventArgs e)
        {
            try
            {
                if (!m_HasSaved)
                {
                    SaveReportDialogView saveDialog = new SaveReportDialogView() { Owner = this };
                    bool? result = saveDialog.ShowDialog();
                    if (result.HasValue && result.Value)
                    {
                        this.Title = saveDialog.TemplateName;
                        m_HasSaved = true;
                    }

                }

                designer.Report.Save(string.Format(@"{0}Reports\\{1}.frx", AppDomain.CurrentDomain.BaseDirectory, this.Title));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        protected Report CurrentReport
        {
            get
            {
                if (m_Report == null)
                {
                    m_Report = new Report();
                }
                return m_Report;
            }
        }
    }
}
