using System.Runtime.InteropServices;

namespace SDL2DroidSharp
{
    public delegate void Main();

    public static class SDL2Main
    {
        [DllImport("main")]
        public static extern void SetMain(Main main);
    }
}