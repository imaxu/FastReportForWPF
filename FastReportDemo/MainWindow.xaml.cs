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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using FastReport;
using FastReport.Utils;
using System.Data;
using System.Data.SqlClient;
using Enjoy.MS.Entities;
using Enjoy.MS.EntityFactory;

namespace FastReportDemo
{

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Report m_FReport = null;
        private DataSet m_FDataSet = null;
        private List<Category> m_FBusinessObject = null;
        private List<MemberInfoEntity> m_MemberInfos = new List<MemberInfoEntity> ();
        private bool m_IsReportReading = false;


        public MainWindow()
        {

            InitializeComponent();

            m_FReport = new Report();

            CurrentReport.Preview = frPreviewControl;
            Config.ReportSettings.ShowPerformance = true;
            Config.ReportSettings.StartProgress += new EventHandler(ReportSettings_StartProgress);
            Config.ReportSettings.Progress += new ProgressEventHandler(ReportSettings_Progress);
            Config.ReportSettings.FinishProgress += new EventHandler(ReportSettings_FinishProgress);

            LoadReportNames();


        }

        private void ReportSettings_StartProgress(object sender, EventArgs e)
        {
        }

        private void ReportSettings_Progress(object sender, ProgressEventArgs e)
        {
            CurrentReport.Preview.ShowStatus(e.Message);
        }

        private void ReportSettings_FinishProgress(object sender, EventArgs e)
        {
        }

        private void CreateDataSources()
        {
            m_FDataSet = new DataSet();
            m_FDataSet.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"Reports\\nwind.xml");

            m_FBusinessObject = new List<Category>();

            Category category = new Category("Beverages", "Soft drinks, coffees, teas, beers");
            category.Products.Add(new Product("Chai", 18m));
            category.Products.Add(new Product("Chang", 19m));
            category.Products.Add(new Product("Ipoh coffee", 46m));
            m_FBusinessObject.Add(category);

            category = new Category("Confections", "Desserts, candies, and sweet breads");
            category.Products.Add(new Product("Chocolade", 12.75m));
            category.Products.Add(new Product("Scottish Longbreads", 12.5m));
            category.Products.Add(new Product("Tarte au sucre", 49.3m));
            m_FBusinessObject.Add(category);

            category = new Category("Seafood", "Seaweed and fish");
            category.Products.Add(new Product("Boston Crab Meat", 18.4m));
            category.Products.Add(new Product("Red caviar", 15m));
            m_FBusinessObject.Add(category);
        }


        private void CreateMemberInfoDataSources()
        {
            m_MemberInfos.Clear();
            string conn = "Server=192.168.0.16;User Id=sa;Password=ABc@#61^$&@3*(#2Ce>X;Initial Catalog=IcGameDB";
            DataSet dsDataSet = null;
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(@"SELECT Top 1000 * FROM T_Account", sqlConnection);
                dsDataSet = new DataSet();
                sqlDataAdapter1.Fill(dsDataSet, "Members");
            }
            foreach (DataRow row in dsDataSet.Tables[0].Rows)
            {
                m_MemberInfos.Add(LoadByDataRow(row));
            }
        }

        private MemberInfoEntity LoadByDataRow(DataRow p_DataRow)
        {
            return MemberInfoEntityFactory.fill(p_DataRow);
        }

        private void RegisterData()
        {
            CurrentReport.RegisterData(m_FDataSet, "NorthWind");
            CurrentReport.RegisterData(m_FBusinessObject, "CategoriesBO");
            CurrentReport.RegisterData(m_MemberInfos, "MemberInfo");
        }


        protected Report CurrentReport
        {
            get
            {
                return m_FReport;
            }
        }

        protected bool IsReportReading
        {
            set { m_IsReportReading = value; }
            get { return m_IsReportReading; }
        }

        private void LoadReportNames()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Reports\\";

            string[] filenames = System.IO.Directory.GetFiles(path, "*.frx");

            lvReportItems.Items.Clear();
            foreach (string item in filenames)
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Content = new FileInfo(item).Name;
                lvItem.Tag = item;
                lvReportItems.Items.Add(lvItem);
            }
        }

        private void lvReportItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is ListViewItem && !IsReportReading)
            {
                IsReportReading = true;
                try
                {
                    btnRunDesigner.IsEnabled = true;
                    ListViewItem lvItem = e.AddedItems[0] as ListViewItem;
                    CurrentReport.Load(lvItem.Tag.ToString());
                    LoadDescription(lvItem);
                    LoadPreview(lvItem);
                }
                finally { IsReportReading = false; }
            }
        }

        private void LoadPreview(ListViewItem lvItem)
        {
            CreateMemberInfoDataSources();
            CreateDataSources();
            RegisterData();
            CurrentReport.Show();
        }

        private void LoadDescription(ListViewItem lvItem)
        {
            txtDescription.Text = CurrentReport.ReportInfo.Description;
        }

        private void btnRunDesigner_Click(object sender, RoutedEventArgs e)
        {

            if (CurrentReport.Design())
            {
                CurrentReport.Show();
            }
        }

        void cmdNew_CustomAction(object sender, EventArgs e)
        {
            BlankReportDesginerView newReportView = new BlankReportDesginerView() { Owner = this };
            newReportView.ShowDialog();
        }

        private void btnCreateNew_Click(object sender, RoutedEventArgs e)
        {
            BlankReportDesginerView blankDesigner = new BlankReportDesginerView() { Owner = this };
            blankDesigner.ShowDialog();

            LoadReportNames();
        }
    }


    public class Category
    {
        private string FName;
        private string FDescription;
        private List<Product> FProducts;

        public string Name
        {
            get { return FName; }
        }

        public string Description
        {
            get { return FDescription; }
        }

        public List<Product> Products
        {
            get { return FProducts; }
        }

        public Category(string name, string description)
        {
            FName = name;
            FDescription = description;
            FProducts = new List<Product>();
        }
    }

    public class Product
    {
        private string FName;
        private decimal FUnitPrice;

        public string Name
        {
            get { return FName; }
        }

        public decimal UnitPrice
        {
            get { return FUnitPrice; }
        }

        public Product(string name, decimal unitPrice)
        {
            FName = name;
            FUnitPrice = unitPrice;
        }
    }
}
