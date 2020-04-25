namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.underScoreLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.conditionsLabel = new System.Windows.Forms.Label();
            this.conditionsOutput = new System.Windows.Forms.Label();
            this.weatherIconBox = new System.Windows.Forms.PictureBox();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.updateOutput = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(117, 63);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(70, 17);
            this.cityOutput.TabIndex = 22;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(118, 145);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(113, 13);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(22, 145);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max:";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(118, 167);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(113, 13);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(22, 167);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(27, 13);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min:";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(118, 123);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(42, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(22, 123);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(74, 13);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temp:";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(21, 15);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(82, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(141, 15);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(82, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // underScoreLabel
            // 
            this.underScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.underScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underScoreLabel.ForeColor = System.Drawing.Color.White;
            this.underScoreLabel.Location = new System.Drawing.Point(20, 25);
            this.underScoreLabel.Name = "underScoreLabel";
            this.underScoreLabel.Size = new System.Drawing.Size(115, 27);
            this.underScoreLabel.TabIndex = 42;
            this.underScoreLabel.Text = "____________________________";
            this.underScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityLabel
            // 
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(21, 63);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(70, 17);
            this.cityLabel.TabIndex = 43;
            this.cityLabel.Text = "City:";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(21, 94);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 17);
            this.dateLabel.TabIndex = 44;
            this.dateLabel.Text = "Date:";
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.ForeColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(117, 94);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(113, 13);
            this.dateOutput.TabIndex = 45;
            // 
            // conditionsLabel
            // 
            this.conditionsLabel.AutoSize = true;
            this.conditionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionsLabel.ForeColor = System.Drawing.Color.White;
            this.conditionsLabel.Location = new System.Drawing.Point(23, 199);
            this.conditionsLabel.Name = "conditionsLabel";
            this.conditionsLabel.Size = new System.Drawing.Size(96, 13);
            this.conditionsLabel.TabIndex = 46;
            this.conditionsLabel.Text = "Current Conditions:";
            // 
            // conditionsOutput
            // 
            this.conditionsOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionsOutput.ForeColor = System.Drawing.Color.White;
            this.conditionsOutput.Location = new System.Drawing.Point(118, 199);
            this.conditionsOutput.Name = "conditionsOutput";
            this.conditionsOutput.Size = new System.Drawing.Size(113, 13);
            this.conditionsOutput.TabIndex = 47;
            // 
            // weatherIconBox
            // 
            this.weatherIconBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherIconBox.Location = new System.Drawing.Point(120, 215);
            this.weatherIconBox.Name = "weatherIconBox";
            this.weatherIconBox.Size = new System.Drawing.Size(100, 90);
            this.weatherIconBox.TabIndex = 48;
            this.weatherIconBox.TabStop = false;
            // 
            // humidityOutput
            // 
            this.humidityOutput.BackColor = System.Drawing.Color.Transparent;
            this.humidityOutput.ForeColor = System.Drawing.Color.White;
            this.humidityOutput.Location = new System.Drawing.Point(116, 320);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(113, 13);
            this.humidityOutput.TabIndex = 50;
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(21, 320);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(50, 13);
            this.humidityLabel.TabIndex = 49;
            this.humidityLabel.Text = "Humidity:";
            // 
            // updateOutput
            // 
            this.updateOutput.BackColor = System.Drawing.Color.Transparent;
            this.updateOutput.ForeColor = System.Drawing.Color.White;
            this.updateOutput.Location = new System.Drawing.Point(118, 348);
            this.updateOutput.Name = "updateOutput";
            this.updateOutput.Size = new System.Drawing.Size(113, 13);
            this.updateOutput.TabIndex = 52;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.Color.Transparent;
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(23, 348);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(68, 13);
            this.updateLabel.TabIndex = 51;
            this.updateLabel.Text = "Last Update:";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.updateOutput);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.weatherIconBox);
            this.Controls.Add(this.conditionsOutput);
            this.Controls.Add(this.conditionsLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.underScoreLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label underScoreLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label conditionsLabel;
        private System.Windows.Forms.Label conditionsOutput;
        private System.Windows.Forms.PictureBox weatherIconBox;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label updateOutput;
        private System.Windows.Forms.Label updateLabel;
    }
}
