using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace DataValuePass
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {

        Button btngetvalue;
        TextView txtgevalue;
        string txtvalues;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Secondpage);
            txtvalues = Intent.GetStringExtra("pass");
            btngetvalue = FindViewById<Button>(Resource.Id.btnget);
            txtgevalue = FindViewById<TextView>(Resource.Id.txtget);
            btngetvalue.Click += Btngetvalue_Click;
        }

        private void Btngetvalue_Click(object sender, EventArgs e)
        {
            txtgevalue.Text = txtvalues;
        }
    }
}