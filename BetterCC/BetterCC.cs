using Dalamud.Plugin;

using BetterCC.Interface;

namespace BetterCC {
	public sealed class Gaze : IDalamudPlugin {
		public string Name => "BetterCC";
		public string CommandName = "/bettercc";

		public Gaze(DalamudPluginInterface dalamud) {
			Services.Init(dalamud);

			Services.Interface.UiBuilder.DisableGposeUiHide = true;
			Services.Interface.UiBuilder.Draw += PluginGui.Windows.Draw;
		}

		public void Dispose() {
		}
	}
}