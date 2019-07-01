using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using deneme.Module.Helpers;
namespace deneme.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class TaskDefinitions : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public TaskDefinitions(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            CreatedUser = Session.GetObjectByKey<Users>(SecuritySystem.CurrentUserId);
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}

        Users workingUser;
        Users createdUser;
        TaskStatus taskStatus;
        TaskGroups taskGroups;
        DateTime finishTime;
        DateTime startTime;
        string taskDefinition;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string TaskDefinition
        {
            get
            {
                return taskDefinition;
            }
            set
            {
                SetPropertyValue(nameof(TaskDefinition), ref taskDefinition, value);
            }
        }


        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                SetPropertyValue(nameof(StartTime), ref startTime, value);
            }
        }


        public DateTime FinishTime
        {
            get
            {
                return finishTime;
            }
            set
            {
                SetPropertyValue(nameof(FinishTime), ref finishTime, value);
            }
        }

        public TaskGroups TaskGroups
        {
            get
            {
                return taskGroups;
            }
            set
            {
                SetPropertyValue(nameof(TaskGroups), ref taskGroups, value);
            }
        }

        public TaskStatus TaskStatus
        {
            get
            {
                return taskStatus;
            }
            set
            {
                SetPropertyValue(nameof(TaskStatus), ref taskStatus, value);
            }
        }

        public Users CreatedUser
        {
            get
            {
                return createdUser;
            }
            set
            {
                SetPropertyValue(nameof(CreatedUser), ref createdUser, value);
            }
        }

        public Users WorkingUser
        {
            get
            {
                return workingUser;
            }
            set
            {
                SetPropertyValue(nameof(WorkingUser), ref workingUser, value);
            }
        }
    }
}