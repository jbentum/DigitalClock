namespace DigitalClock
{
    partial class DigitalClock
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.RedButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.StyleButton1 = new System.Windows.Forms.Button();
            this.StyleButton3 = new System.Windows.Forms.Button();
            this.StyleButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.Color.Red;
            this.LoadingLabel.Location = new System.Drawing.Point(29, 29);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(661, 372);
            this.LoadingLabel.TabIndex = 0;
            this.LoadingLabel.Text = "Loading";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadingLabel.Click += new System.EventHandler(this.LoadingLabel_Click);
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 1000;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(12, 415);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(21, 23);
            this.RedButton.TabIndex = 1;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeButton.Location = new System.Drawing.Point(39, 415);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(21, 23);
            this.OrangeButton.TabIndex = 1;
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(66, 415);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(21, 23);
            this.YellowButton.TabIndex = 1;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Green;
            this.GreenButton.Location = new System.Drawing.Point(93, 415);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(21, 23);
            this.GreenButton.TabIndex = 1;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(120, 415);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(21, 23);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // StyleButton1
            // 
            this.StyleButton1.BackColor = System.Drawing.Color.White;
            this.StyleButton1.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton1.Location = new System.Drawing.Point(148, 414);
            this.StyleButton1.Name = "StyleButton1";
            this.StyleButton1.Size = new System.Drawing.Size(75, 23);
            this.StyleButton1.TabIndex = 2;
            this.StyleButton1.Text = "Style 1";
            this.StyleButton1.UseVisualStyleBackColor = false;
            this.StyleButton1.Click += new System.EventHandler(this.StyleButton1_Click);
            // 
            // StyleButton3
            // 
            this.StyleButton3.BackColor = System.Drawing.Color.White;
            this.StyleButton3.Font = new System.Drawing.Font("Sitka Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton3.Location = new System.Drawing.Point(310, 415);
            this.StyleButton3.Name = "StyleButton3";
            this.StyleButton3.Size = new System.Drawing.Size(75, 23);
            this.StyleButton3.TabIndex = 2;
            this.StyleButton3.Text = "Style 3";
            this.StyleButton3.UseVisualStyleBackColor = false;
            this.StyleButton3.Click += new System.EventHandler(this.StyleButton3_Click);
            // 
            // StyleButton2
            // 
            this.StyleButton2.BackColor = System.Drawing.Color.White;
            this.StyleButton2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StyleButton2.Location = new System.Drawing.Point(229, 414);
            this.StyleButton2.Name = "StyleButton2";
            this.StyleButton2.Size = new System.Drawing.Size(75, 23);
            this.StyleButton2.TabIndex = 2;
            this.StyleButton2.Text = "Style 2";
            this.StyleButton2.UseVisualStyleBackColor = false;
            this.StyleButton2.Click += new System.EventHandler(this.StyleButton2_Click);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.StyleButton2);
            this.Controls.Add(this.StyleButton3);
            this.Controls.Add(this.StyleButton1);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.OrangeButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.LoadingLabel);
            this.Name = "DigitalClock";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button StyleButton1;
        private System.Windows.Forms.Button StyleButton3;
        private System.Windows.Forms.Button StyleButton2;
    }
}

