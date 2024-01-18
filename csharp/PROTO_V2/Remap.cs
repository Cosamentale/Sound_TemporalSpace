///For examples, see:
///https://thegraybook.vvvv.org/reference/extending/writing-nodes.html#examples

namespace PROTO_V2;

public static class Remap
{
    public static float RemapValue(float value, float a1, float a2, float b1, float b2)
    {       
            return b1 + (value - a1) * (b2 - b1) / (a2 - a1);
    }
}