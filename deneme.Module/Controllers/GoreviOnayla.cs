using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System.Data;
using System.Data.SqlClient;

namespace deneme.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class GoreviOnayla : ViewController
    {
        public GoreviOnayla()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void GorevOnayla_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SelectedObject = e.SelectedObjects[0];
            string sSelectedObject = SelectedObject.ToString();
            string sSelectedObjectId = sSelectedObject.Substring(46, 36); //obje stringini parçalayıp 36 haneli id'yi elde ediyorum.
            string sConnectionString = @"Data Source=TOSHIBA-L850\SQLEXPRESS;Initial Catalog=deneme2;User ID=sa;Password=1;";
            SqlConnection connection = new SqlConnection(sConnectionString);
            string sUpdateText = "UPDATE TaskDefinitions SET TaskStatus=1"
                + "where Oid=CONVERT(uniqueidentifier,'" + sSelectedObjectId + "')";
            SqlCommand UpdateCommand = new SqlCommand(sUpdateText, connection);
            connection.Open();
            UpdateCommand.ExecuteNonQuery();
            connection.Close();
            View.ObjectSpace.Refresh(); //verileri yenile
        }

        private void GorevTamamla_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SelectedObject = e.SelectedObjects[0];
            string sSelectedObject = SelectedObject.ToString();
            string sSelectedObjectId = sSelectedObject.Substring(46, 36); //obje stringini parçalayıp 36 haneli id'yi elde ediyorum.
            string sConnectionString = @"Data Source=TOSHIBA-L850\SQLEXPRESS;Initial Catalog=deneme2;User ID=sa;Password=1;";
            SqlConnection connection = new SqlConnection(sConnectionString);
            string sUpdateText = "UPDATE TaskDefinitions SET TaskStatus=2"
                + "where Oid=CONVERT(uniqueidentifier,'" + sSelectedObjectId + "')";
            SqlCommand UpdateCommand = new SqlCommand(sUpdateText, connection);
            connection.Open();
            UpdateCommand.ExecuteNonQuery();
            connection.Close();
            View.ObjectSpace.Refresh(); //verileri yenile
        }
    }
}
