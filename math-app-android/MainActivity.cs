using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace math_app_android
{
    [Activity(Label = "math_app_android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private static readonly long COUNTDOWN_IN_MILLS = 60000;
        ////private CountDownTimer countdowntimer;
        private long timeLeftInMills;
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
        //private void StartDownCount()
        //{
        //    countdowntimer = new CountDownTimer(timeLeftInMills, 1000);
        //}

        //private void StartDownCount()
        //{

        //}
        //protected virtual void onTick(long millsUntilFinished)
        //{
        //    TextView textView = FindViewById<TextView>(Resource.Id.textScore);
        //    timeLeftInMills = millsUntilFinished;
        //    if (COUNTDOWN_IN_MILLS > 0)
        //    {
        //        timeLeftInMills = timeLeftInMills - 1;

        //        textView.Text = timeLeftInMills + " seconds";

        //    }
        //    else
        //    {
        //        textView.Text = "No time left";
        //    }
        //}


    }

    }




