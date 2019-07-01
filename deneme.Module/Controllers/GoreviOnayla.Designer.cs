namespace deneme.Module.Controllers
{
    partial class GoreviOnayla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GorevOnayla = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.GorevTamamla = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // GorevOnayla
            // 
            this.GorevOnayla.Caption = "Seçili Görevi Başlat";
            this.GorevOnayla.ConfirmationMessage = null;
            this.GorevOnayla.Id = "GorevOnayla";
            this.GorevOnayla.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.GorevOnayla.TargetObjectType = typeof(deneme.Module.BusinessObjects.TaskDefinitions);
            this.GorevOnayla.TargetViewId = "";
            this.GorevOnayla.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.GorevOnayla.ToolTip = null;
            this.GorevOnayla.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.GorevOnayla.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.GorevOnayla_Execute);
            // 
            // GorevTamamla
            // 
            this.GorevTamamla.Caption = "Seçili Görevi Tamamla";
            this.GorevTamamla.ConfirmationMessage = null;
            this.GorevTamamla.Id = "GorevTamamla";
            this.GorevTamamla.SelectionDependencyType = DevExpress.ExpressApp.Actions.SelectionDependencyType.RequireSingleObject;
            this.GorevTamamla.TargetObjectType = typeof(deneme.Module.BusinessObjects.TaskDefinitions);
            this.GorevTamamla.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.GorevTamamla.ToolTip = null;
            this.GorevTamamla.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.GorevTamamla.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.GorevTamamla_Execute);
            // 
            // GoreviOnayla
            // 
            this.Actions.Add(this.GorevOnayla);
            this.Actions.Add(this.GorevTamamla);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction GorevOnayla;
        private DevExpress.ExpressApp.Actions.SimpleAction GorevTamamla;
    }
}
