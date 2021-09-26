﻿/*
	This file is part of TweakScalerModuleWaterfallFX, a component of TweakScaleCompanion_Visuals
	© 2021 LisiasT : http://lisias.net <support@lisias.net>

	TweakScaleCompanion_Visuals is double licensed, as follows:

	* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
	* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	TweakScaleCompanion_Visuals is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with TweakScaleCompanion_Visuals. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with TweakScaleCompanion_Visuals. If not, see <https://www.gnu.org/licenses/>.

*/
using TweakScale;

namespace TweakScaleCompanion.Visuals.Waterfall.Integrator
{
	internal class Scaler : TweakScale.IRescalable<Integrator>
	{
		private readonly TweakScale.IRescalable pm;

		public Scaler(Integrator pm)
		{
			this.pm = pm;
		}

		public void OnRescale(ScalingFactor factor)
		{
			this.pm.OnRescale(factor);
		}
	}
}
