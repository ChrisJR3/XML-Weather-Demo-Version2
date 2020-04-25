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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();

            

        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp + " C";            
            maxOutput.Text = Form1.days[0].tempHigh + " C";
            minOutput.Text = Form1.days[0].tempLow + " C";
            dateOutput.Text = Form1.days[0].date;
            conditionsOutput.Text = Form1.days[0].icon;
            humidityOutput.Text = Form1.days[0].humidity + "%";
            updateOutput.Text = Convert.ToDateTime(Form1.days[0].update).ToString("hh : mm"); ;

            //Deciding the icon and the background image
            //So that the images fin in the picture box
            weatherIconBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //If it's sunny
            if (Form1.days[0].icon.Contains("sun") == true)
            {
                weatherIconBox.Image = XMLWeather.Properties.Resources.Sun;
                this.BackColor = Color.Yellow;
                textColour("Dark");
            }
            //If it's night
            else if (Form1.days[0].icon.Contains("moon") == true)
            {
                weatherIconBox.Image = XMLWeather.Properties.Resources.Small_Moon;
                this.BackColor = Color.Black;
                textColour("Light");
            }
            //If it's cloudy
            else if (Form1.days[0].icon.Contains("cloud") == true)
            {
                weatherIconBox.Image = XMLWeather.Properties.Resources.Cloudy;
                this.BackColor = Color.Gray;
                textColour("Dark");
            }
            //If it's raining
            else if (Form1.days[0].icon.Contains("rain") == true)
            {
                weatherIconBox.Image = XMLWeather.Properties.Resources.rain;
                this.BackColor = Color.LightBlue;
                textColour("Dark");
            }            
            //If it's a thunderstorm
            else if (Form1.days[0].icon.Contains("thunder") == true || Form1.days[0].icon.Contains("lightning") == true)
            {
                weatherIconBox.Image = XMLWeather.Properties.Resources.Thunder;
                this.BackColor = Color.DarkBlue;
                textColour("Light");
            }
            //If it's snowing
            else if (Form1.days[0].icon.Contains("snow") == true)
            {
                weatherIconBox.Image = XMLWeather.Properties.Resources.Snow;
                this.BackColor = Color.White;
                textColour("Dark");
            }            
            //If the weather is something other than the icons I have above
            else
            {
                //if it's warm out
                if (Convert.ToInt32(Form1.days[0].currentTemp) >= 20)
                {
                    weatherIconBox.Image = XMLWeather.Properties.Resources.Hot;
                    this.BackColor = Color.OrangeRed;
                    textColour("Dark");
                }
                //if it's cold(ish) or less out
                else
                {
                    weatherIconBox.Image = XMLWeather.Properties.Resources.Cold;
                    this.BackColor = Color.White;
                    textColour("Dark");
                }
            }
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {
            
        }

        public void textColour(string brightness)
        {
            if (brightness == "Dark")
            {
                todayLabel.ForeColor = Color.Black;
                underScoreLabel.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
                cityLabel.ForeColor = Color.Black;
                cityOutput.ForeColor = Color.Black;
                dateLabel.ForeColor = Color.Black;
                dateOutput.ForeColor = Color.Black;
                tempLabel.ForeColor = Color.Black;
                currentOutput.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                maxOutput.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                minOutput.ForeColor = Color.Black;
                conditionsLabel.ForeColor = Color.Black;
                conditionsOutput.ForeColor = Color.Black;
                humidityLabel.ForeColor = Color.Black;
                humidityOutput.ForeColor = Color.Black;

                updateLabel.ForeColor = Color.Black;
                updateOutput.ForeColor = Color.Black;
            }
            else if (brightness == "Light")
            {
                todayLabel.ForeColor = Color.White;
                underScoreLabel.ForeColor = Color.White;
                forecastLabel.ForeColor = Color.White;
                cityLabel.ForeColor = Color.White;
                cityOutput.ForeColor = Color.White;
                dateLabel.ForeColor = Color.White;
                dateOutput.ForeColor = Color.White;
                tempLabel.ForeColor = Color.White;
                currentOutput.ForeColor = Color.White;
                maxLabel.ForeColor = Color.White;
                maxOutput.ForeColor = Color.White;
                minLabel.ForeColor = Color.White;
                minOutput.ForeColor = Color.White;
                conditionsLabel.ForeColor = Color.White;
                conditionsOutput.ForeColor = Color.White;
                humidityLabel.ForeColor = Color.White;
                humidityOutput.ForeColor = Color.White;
            }
        }
    }
}
