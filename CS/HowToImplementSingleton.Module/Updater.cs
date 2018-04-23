using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

namespace HowToImplementSingleton.Module {
	public class Updater : ModuleUpdater {
		public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) {
		}
		public override void UpdateDatabaseAfterUpdateSchema() {
			base.UpdateDatabaseAfterUpdateSchema();
			//Create the Singleton object
			Singleton.GetInstance(Session);
		}
	}
}