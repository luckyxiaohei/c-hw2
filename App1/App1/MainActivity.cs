using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Environment = Android.OS.Environment;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            // Get our button from the layout resource,  form_title
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.btn_login);
            EditText txtLoginName = FindViewById<EditText>(Resource.Id.txt_login_name);

            TextView txtMsg = FindViewById<TextView>(Resource.Id.form_title);
            button.Click += delegate {
                string loginName = txtLoginName.Text;
                
               
                if (loginName == "Mr.Zhang")
                {
                    txtMsg.Text = "正确!";
                }
            };
        }

        
    }
}