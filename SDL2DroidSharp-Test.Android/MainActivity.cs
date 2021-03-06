using Android.App;
using Android.Widget;
using Android.OS;
using Org.Libsdl.App;
using Android.Views;

namespace SDL2DroidSharp_Test.Android
{
    [Activity(
        Label = "SDL2Droid CS",
        MainLauncher = true,
        HardwareAccelerated = true,
        ScreenOrientation = global::Android.Content.PM.ScreenOrientation.Landscape
    )]
    public class MainActivity : SDLActivity
    {
        public static MainActivity SDL2DCS_Instance { get; protected set; }

        public static bool SDL2DCS_Fullscreen = true;

        public override void LoadLibraries() {
            base.LoadLibraries();
            SDL2DCS_Instance = this;
            Bootstrap.SetupMain();
        }

        public override void OnWindowFocusChanged(bool hasFocus) {
            base.OnWindowFocusChanged(hasFocus);
            if (hasFocus && SDL2DCS_Fullscreen) {
                Window.DecorView.SystemUiVisibility = (StatusBarVisibility) (
                    SystemUiFlags.LayoutStable |
                    SystemUiFlags.LayoutHideNavigation |
                    SystemUiFlags.LayoutFullscreen |
                    SystemUiFlags.HideNavigation |
                    SystemUiFlags.Fullscreen |
                    SystemUiFlags.ImmersiveSticky
                );
            }
        }
    }
}