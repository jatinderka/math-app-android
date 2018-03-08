using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace math_app_android
{
    [Activity(Label = "GameScreenAS")]
    public class GameScreenAS : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GameScreenAS);

            // Create your application here
            //for adding value to the operator
            TextView textView = FindViewById<TextView>(Resource.Id.Num1);
            TextView textNum = FindViewById<TextView>(Resource.Id.Num2);
            Random r = new Random();
           textView.Text= r.Next(0, 100).ToString();
            textNum.Text = r.Next(0, 100).ToString();

            //back button
            Button button = FindViewById<Button>(Resource.Id.butBack);
            button.Click += delegate
            {
                StartActivity(typeof(MainActivity)); 

            };

        }
        private void Numbers()
        {
            Random r = new Random();
            r.Next(0, 100);
        }
    }
}