using System;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;


namespace DataValuePass
{
    [Activity(Label = "DataValuePass", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText txtdata;
        Button btnsend;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            btnsend = FindViewById<Button>(Resource.Id.btnsend);
            txtdata = FindViewById<EditText>(Resource.Id.txtpass);
            btnsend.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {   
            var intent = new Intent(this, typeof(SecondActivity));
            intent.PutExtra("pass", txtdata.Text);
            this.StartActivity(intent);
        }
    }
}

