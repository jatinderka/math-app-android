using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace math_app_android
{
    [Activity(Label = "math_app_android", MainLauncher = true)]
    public class MainActivity : Activity
    {
      
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            //to set different screens 
            Button button = FindViewById<Button>(Resource.Id.butAS);

            button.Click += delegate
            {
                StartActivity(typeof(GameScreenAS));
              
            };


        }
        

    }

    }




