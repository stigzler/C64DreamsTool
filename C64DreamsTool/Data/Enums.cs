using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C64DreamsTool.Data
{
    internal enum GameImageType
    {
        [Description("Clear Logo")]
        ClearLogo,

        [Description("Box - Front")]
        BoxFront,

        [Description("Box - 3D")]
        Box3D,

        [Description("Box - Back")]
        BoxRear,

        [Description("Screenshot - Game Title")]
        SnapTitle,

        [Description("Screenshot - Gameplay")]
        SnapGameplay,

        [Description("Screenshot - Game Over")]
        SnapGameover,

        [Description("Screenshot - High Scores")]
        SnapHighScores,

        [Description("Disc")]
        Disc,

        [Description("Cart - Front")]
        CartFront,

        [Description("Cart - 3D")]
        Cart3D,

        [Description("Fanart - Background")]
        FanartBackground

    }
}