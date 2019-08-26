using Android.App;
using Android.Widget;
using Android.OS;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using Android.Content;

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
            Button btnReg = FindViewById<Button>(Resource.Id.btnRegistrar);
            final_android.net.azurewebsites.wsnutricion.wsDieta ws = new net.azurewebsites.wsnutricion.wsDieta();
            btnIngresar.Click += delegate {
                DataSet ds = new DataSet();
                string struser = etmail.Text;
                string strpass = etpassword.Text;
                ds = ws.consultaUsuario(struser);
                int entero = ds.Tables[0].Rows.Count;
                string str1 = ds.Tables[0].Rows[0][1].ToString();
                string str2 = ds.Tables[0].Rows[0][2].ToString();
                if (struser.Equals(str1)&&strpass.Equals(str2))
                {
                    Intent a = new Intent(this, typeof(ingresar));
                    StartActivity(a);
                }
            };

            btnReg.Click += delegate {
                Intent a = new Intent(this, typeof(registrar));
                StartActivity(a);
            };

        }
    }
}

