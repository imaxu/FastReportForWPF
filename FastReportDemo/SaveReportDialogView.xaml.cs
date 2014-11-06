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

namespace FastReportDemo
{
    /// <summary>
    /// SaveReportDialogView.xaml 的交互逻辑
    /// </summary>
    public partial class SaveReportDialogView : Window
    {
        public SaveReportDialogView()
        {
            InitializeComponent();
            txtTemplateName.Focus();
        }

        public string TemplateName
        {
            get
            {
                return txtTemplateName.Text;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.DialogResult = false;
        }
    }
}
