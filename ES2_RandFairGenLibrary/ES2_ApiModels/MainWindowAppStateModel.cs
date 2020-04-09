using System;
using System.Collections.Generic;
using System.Text;

namespace ES2_RandFairGenLibrary.ES2_ApiModels
{
    public class MainWindowAppStateModel
    {
		public MainWindowAppStateModel()
		{
			rightPanelState = UIElementState.Visible;
			leftPanelState = UIElementState.Invisible;
		}


		private UIElementState rightPanelState;
		private UIElementState leftPanelState;

		public UIElementState RightPanelState
		{
			get { return rightPanelState; }
			set { rightPanelState = value; }
		}

		public UIElementState LeftPanelState
		{
			get { return leftPanelState; }
			set { leftPanelState = value; }
		}

		public enum UIElementState 
		{
			Error = 0,
			Visible = 1,
			Invisible = 2,
		}
	}
}
