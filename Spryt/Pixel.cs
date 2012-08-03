using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spryt
{
    public enum Pixel : byte
    {
        Empty = 0,

        Colour1 = 8 | 0,
        Colour2 = 8 | 1,
        Colour3 = 8 | 2,
        Colour4 = 8 | 3,
        Colour5 = 8 | 4,
        Colour6 = 8 | 5,
        Colour7 = 8 | 6,
        Colour8 = 8 | 7
    }
}
