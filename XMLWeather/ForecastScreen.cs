using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        Image returnWeather;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();

            //so that the images fit in the boxes
            futureIconBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            futureIconBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            futureIconBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {
            //Inputing values
            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow + " C";
            max3.Text = Form1.days[3].tempHigh + " C";
            decidingIcon(Form1.days[3].icon);
            futureIconBox3.Image = returnWeather;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow + " C";
            max2.Text = Form1.days[2].tempHigh + " C";
            decidingIcon(Form1.days[2].icon);
            futureIconBox2.Image = returnWeather;

            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow + " C";
            max1.Text = Form1.days[1].tempHigh + " C";
            decidingIcon(Form1.days[1].icon);
            futureIconBox1.Image = returnWeather;            
        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {

        }

        public void decidingIcon(string weather)
        {
            //If it's sunny
            if (weather.Contains("sun") == true)
            {
                returnWeather = XMLWeather.Properties.Resources.Sun;
                this.BackColor = Color.Yellow;
                textColour("Dark");
            }
            //If it's night
            else if (weather.Contains("moon") == true)
            {
                returnWeather = XMLWeather.Properties.Resources.Small_Moon;
                this.BackColor = Color.Black;
                textColour("Light");
            }
            //If it's cloudy
            else if (weather.Contains("cloud") == true)
            {
                returnWeather = XMLWeather.Properties.Resources.Cloudy;
                this.BackColor = Color.Gray;
                textColour("Dark");
            }
            //If it's raining
            else if (weather.Contains("rain") == true)
            {
                returnWeather = XMLWeather.Properties.Resources.rain;
                this.BackColor = Color.LightBlue;
                textColour("Dark");
            }
            //If it's a thunderstorm
            else if (weather.Contains("thunder") == true || Form1.days[0].icon.Contains("lightning") == true)
            {
                returnWeather = XMLWeather.Properties.Resources.Thunder;
                this.BackColor = Color.DarkBlue;
                textColour("Light");
            }
            //If it's snowing
            else if (weather.Contains("snow") == true)
            {
                returnWeather = XMLWeather.Properties.Resources.Snow;
                this.BackColor = Color.White;
                textColour("Dark");
            }
            //If the weather is something other than the icons I have above
            else
            {
                //if it's warm out
                if (Convert.ToInt32(Form1.days[0].currentTemp) >= 20)
                {
                    returnWeather = XMLWeather.Properties.Resources.Hot;
                    this.BackColor = Color.OrangeRed;
                    textColour("Dark");
                }
                //if it's cold(ish) or less out
                else
                {
                    returnWeather = XMLWeather.Properties.Resources.Cold;
                    this.BackColor = Color.White;
                    textColour("Dark");
                }
            }
        }

        public void textColour(string brightness)
        {
            if (brightness == "Dark")
            {
                todayLabel.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                underscoreLabel.ForeColor = Color.Black;
                dateLabel1.ForeColor = Color.Black;
                date1.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                max1.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                min1.ForeColor = Color.Black;
                dateLabel2.ForeColor = Color.Black;
                date2.ForeColor = Color.Black;
                maxLabel2.ForeColor = Color.Black;
                max2.ForeColor = Color.Black;
                minLabel2.ForeColor = Color.Black;
                min2.ForeColor = Color.Black;
                dateLabel3.ForeColor = Color.Black;
                date3.ForeColor = Color.Black;
                maxLabel3.ForeColor = Color.Black;
                max3.ForeColor = Color.Black;
                minLabel3.ForeColor = Color.Black;
                min3.ForeColor = Color.Black;
            }
            else if (brightness == "Light")
            {
                todayLabel.ForeColor = Color.White;
                forecastLabel.ForeColor = Color.White;
                underscoreLabel.ForeColor = Color.White;
                dateLabel1.ForeColor = Color.White;
                date1.ForeColor = Color.White;
                maxLabel.ForeColor = Color.White;
                max1.ForeColor = Color.White;
                minLabel.ForeColor = Color.White;
                min1.ForeColor = Color.White;
                dateLabel2.ForeColor = Color.White;
                date2.ForeColor = Color.White;
                maxLabel2.ForeColor = Color.White;
                max2.ForeColor = Color.White;
                minLabel2.ForeColor = Color.White;
                min2.ForeColor = Color.White;
                dateLabel3.ForeColor = Color.White;
                date3.ForeColor = Color.White;
                maxLabel3.ForeColor = Color.White;
                max3.ForeColor = Color.White;
                minLabel3.ForeColor = Color.White;
                min3.ForeColor = Color.White;
            }
        }
    }
}
