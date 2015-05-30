using ColossalFramework.UI;
using ICities;
using UnityEngine;

namespace ImprovedBuildPanel
{

	public class Mod : IUserMod
	{

		public string Name
		{
			get
			{
				return "Enhanced Build Panel";
			}
		}

		public string Description
		{
			get { return "Enhanced In Game Asset Panel"; }
		}

	}

	public class ModLoad : LoadingExtensionBase
	{

		private ImprovedBuildPanel improvedBuildPanel;

		public override void OnLevelLoaded(LoadMode mode)
		{
			Debug.Log("Now Monitoring Panels ... ");
			var uiView = GameObject.FindObjectOfType<UIView>();
			improvedBuildPanel = uiView.gameObject.AddComponent<ImprovedBuildPanel>();
		}

		public override void OnLevelUnloading()
		{
			Debug.Log("Monitoring shutting down ... ");
			GameObject.Destroy(improvedBuildPanel);
		}
	}

}
