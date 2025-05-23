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
        [Description("Box - Rear")]
        BoxRear,
        [Description("Screenshot - Game Title")]
        SnapTitle,
        [Description("Screenshot - Game Over")]
        SnapGameplay,
        [Description("Disc")]
        Disc,
        [Description("Cart - Front")]
        CartFront
    }

}
