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
using Java.Lang;
using System.Timers;
using System.Windows;


namespace math_app_android
{

    [Activity(Label = "Addition/Subtraction", WindowSoftInputMode = SoftInput.AdjustPan)]
    public class GameScreenAS : Activity
    {
        private TextView textopr;
        private TextView textView;
        private TextView textNum;
        private TextView textScrore;
      
        private EditText edResult;
        private int finalResult;
        private TextView textViewCountDown;
        private int _countSeconds;
        private Timer timer;
        private int counter = 0;




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.GameScreenAS);

            // Create your application here





             textView = FindViewById<TextView>(Resource.Id.Num1);
             textNum = FindViewById<TextView>(Resource.Id.Num2);
            textScrore = FindViewById<TextView>(Resource.Id.textScore);
            edResult = FindViewById<EditText>(Resource.Id.edResult);
            textViewCountDown = FindViewById<TextView>(Resource.Id.textViewCountDown);
            Random r = new Random();
            textView.Text = r.Next(1, 100).ToString();

            textNum.Text = r.Next(1, 100).ToString();

           




            //for adding value to the operator
            textopr = FindViewById<TextView>(Resource.Id.Opr);
            textopr.Text = r.Next(0, 20).ToString();
            int operate = Integer.ParseInt(textopr.Text);


            if (operate % 2 == 0)
            {
                textopr.Text = "+";

            }
            else if (operate % 2 == 1)
            {
                textopr.Text = "-";
                //Sub(number1, number2);
            }

            Button buttonChk = FindViewById<Button>(Resource.Id.butCheck);
            buttonChk.Click += ButtonChk_Click;
            r = new Random();
            textView.Text = r.Next(1, 100).ToString();

            textNum.Text = r.Next(1, 100).ToString();
            textopr.Text = r.Next(0, 20).ToString();
             operate = Integer.ParseInt(textopr.Text);


            if (operate % 2 == 0)
            {
                textopr.Text = "+";

            }
            else if (operate % 2 == 1)
            {
                textopr.Text = "-";
                //Sub(number1, number2);
            }
            

            //back button

            Button button = FindViewById<Button>(Resource.Id.butBack);
            button.Click += delegate
            {
                StartActivity(typeof(MainActivity));

            };
            //timer code
            timer = new Timer();
            timer.Interval = 1800;//1 milliseconds
            timer.Elapsed += Timer_Elapsed;

            _countSeconds = 60;
            timer.Enabled = true;



        }

        private void ButtonChk_Click(object sender, EventArgs e)
        {
            int number1 = Integer.ParseInt(textView.Text);
            int number2 = Integer.ParseInt(textNum.Text);
            //for add and subtract the numbers

            int result1 = number1 + number2;
            int result2 = number1 - number2;
            //to check the result
           
            string strresult = edResult.ToString();
            
            finalResult = Integer.ParseInt(edResult.Text);
            if (result1 == finalResult)
            {
                Toast.MakeText(this, "You got it!", ToastLength.Short).Show();
                counter++;
                textScrore.Text = (counter++ * 10).ToString();
                
            }
            else if (result2 == finalResult)
            {
                Toast.MakeText(this, "You got it!", ToastLength.Short).Show();
                counter++;
                textScrore.Text = (counter++ * 10).ToString();
            }
            else
            {
                Toast.MakeText(this, "You will get there!", ToastLength.Short).Show();
                counter--;
                textScrore.Text = (counter-- - 5).ToString();
            }
           string medResult=finalResult.ToString();
            medResult
            doAgain();

            
        }

            private void Timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                _countSeconds--;

                RunOnUiThread(() =>
                {
                    textViewCountDown.Text = string.Format("{00:00}", "Timer :" + _countSeconds +" secs");

                   if(_countSeconds <= 10)
                    {

                        textViewCountDown.SetTextColor(Android.Graphics.Color.Red);
                    
                    }
                    if (_countSeconds == 0)
                    {
                        timer.Stop();
                        Toast.MakeText(this, "time out", ToastLength.Long).Show();
                        Finish();
                        

                    }

                });



            }
        private void doAgain()
        {
            Random r = new Random();
            textView.Text = r.Next(1, 100).ToString();

            textNum.Text = r.Next(1, 100).ToString();
            textopr.Text = r.Next(0, 20).ToString();
            int operate = Integer.ParseInt(textopr.Text);


            if (operate % 2 == 0)
            {
                textopr.Text = "+";

            }
            else if (operate % 2 == 1)
            {
                textopr.Text = "-";
                //Sub(number1, number2);
            }
            int number1 = Integer.ParseInt(textView.Text);
            int number2 = Integer.ParseInt(textNum.Text);
            //for add and subtract the numbers
            int result1 = number1 + number2;
            int result2 = number1 - number2;
            //to check the result
            string strresult = edResult.ToString();
            finalResult = Integer.ParseInt(edResult.Text);
            if (result1 == finalResult)
            {
                Toast.MakeText(this, "You got it!", ToastLength.Short).Show();
                counter++;
                textScrore.Text = (counter++ * 10).ToString();
            }
            else if (result2 == finalResult)
            {
                Toast.MakeText(this, "You got it!", ToastLength.Short).Show();
                counter++;
                textScrore.Text = (counter++ * 10).ToString();
            }
            else
            {
                Toast.MakeText(this, "You will get there!", ToastLength.Short).Show();
                counter--;
                textScrore.Text = (counter-- - 5).ToString();
            }

        }
        }
    }
