using Android.App;
using Android.Widget;
using Android.OS;

namespace final_android
{
    [Activity(Label = "final_android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            EditText etmail = FindViewById<EditText>(Resource.Id.etCorreo);
            EditText etpassword = FindViewById<EditText>(Resource.Id.etContrasena);
            Button btnIngresar = FindViewById<Button>(Resource.Id.btnLogin);
            btnIngresar.Click += delegate {

            };

        }
    }
}

