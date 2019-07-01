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
using DevExpress.Xpo;
using deneme.Module.BusinessObjects;
using System.Data;
using System.Data.SqlClient;

namespace deneme.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class GoreviAl : ViewController
    {
        public GoreviAl()
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

        private void GorevAl_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var SelectedObject= e.SelectedObjects[0];
            string sSelectedObject = SelectedObject.ToString();
            string sSelectedObjectId = sSelectedObject.Substring(46, 36);
            var oCurrentUser = ObjectSpace.GetObjectByKey<Users>(SecuritySystem.CurrentUserId);
            string sCurrentUser = oCurrentUser.ToString();
            string sConnectionString = @"Data Source=TOSHIBA-L850\SQLEXPRESS;Initial Catalog=deneme2;User ID=sa;Password=1;";
            string sCommandText = "SELECT oid FROM PermissionPolicyUser WHERE UserName= '" + sCurrentUser + "'";
            DataTable dtable = new DataTable("tbl");
            SqlConnection connection = new SqlConnection(sConnectionString);
            SqlCommand command = new SqlCommand(sCommandText, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            connection.Open();
            adap.Fill(dtable);
            connection.Close();
            DataRow drow = dtable.Rows[0];
            string sCurrentUserID = drow["Oid"].ToString();
            //sCurentUserID, sSelectedObjectId
            string sUpdateText = "UPDATE TaskDefinitions SET WorkingUser=CONVERT(uniqueidentifier,'" + sCurrentUserID + "')" 
                +"where Oid=CONVERT(uniqueidentifier,'"+sSelectedObjectId+"')";
            SqlCommand UpdateCommand = new SqlCommand(sUpdateText, connection);
            connection.Open();
            UpdateCommand.ExecuteNonQuery();
            connection.Close();
            View.ObjectSpace.Refresh(); //verileri yenile
        }
    }
}
