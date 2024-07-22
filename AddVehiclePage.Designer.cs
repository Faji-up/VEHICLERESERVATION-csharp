namespace VehicleReservation
{
    partial class AddVehiclePage
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
            this.AvailableFrame = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CarDesText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.vehicleImageBox = new System.Windows.Forms.PictureBox();
            this.CarPriceText = new System.Windows.Forms.TextBox();
            this.CarNameText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTo = new System.Windows.Forms.Button();
            this.ShowAvialable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AvailableFrame.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImageBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvailableFrame
            // 
            this.AvailableFrame.Controls.Add(this.panel4);
            this.AvailableFrame.Controls.Add(this.panel3);
            this.AvailableFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableFrame.Location = new System.Drawing.Point(161, 37);
            this.AvailableFrame.Name = "AvailableFrame";
            this.AvailableFrame.Size = new System.Drawing.Size(842, 512);
            this.AvailableFrame.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.CarDesText);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btn2);
            this.panel4.Controls.Add(this.vehicleImageBox);
            this.panel4.Controls.Add(this.CarPriceText);
            this.panel4.Controls.Add(this.CarNameText);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 464);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // CarDesText
            // 
            this.CarDesText.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarDesText.Location = new System.Drawing.Point(14, 229);
            this.CarDesText.Name = "CarDesText";
            this.CarDesText.Size = new System.Drawing.Size(294, 27);
            this.CarDesText.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(441, 420);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(293, 30);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Upload Image";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleImageBox
            // 
            this.vehicleImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vehicleImageBox.Location = new System.Drawing.Point(329, 20);
            this.vehicleImageBox.Name = "vehicleImageBox";
            this.vehicleImageBox.Size = new System.Drawing.Size(501, 394);
            this.vehicleImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vehicleImageBox.TabIndex = 2;
            this.vehicleImageBox.TabStop = false;
            this.vehicleImageBox.Click += new System.EventHandler(this.vehicleImageBox_Click);
            // 
            // CarPriceText
            // 
            this.CarPriceText.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPriceText.Location = new System.Drawing.Point(14, 153);
            this.CarPriceText.Name = "CarPriceText";
            this.CarPriceText.Size = new System.Drawing.Size(294, 27);
            this.CarPriceText.TabIndex = 1;
            this.CarPriceText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CarNameText
            // 
            this.CarNameText.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameText.Location = new System.Drawing.Point(14, 77);
            this.CarNameText.Name = "CarNameText";
            this.CarNameText.Size = new System.Drawing.Size(294, 27);
            this.CarNameText.TabIndex = 0;
            this.CarNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 48);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AddTo);
            this.panel2.Controls.Add(this.ShowAvialable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 512);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(12, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Requests";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(12, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Reservation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddTo
            // 
            this.AddTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddTo.Location = new System.Drawing.Point(12, 41);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(143, 29);
            this.AddTo.TabIndex = 1;
            this.AddTo.Text = "Add";
            this.AddTo.UseVisualStyleBackColor = false;
            // 
            // ShowAvialable
            // 
            this.ShowAvialable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ShowAvialable.Location = new System.Drawing.Point(12, 6);
            this.ShowAvialable.Name = "ShowAvialable";
            this.ShowAvialable.Size = new System.Drawing.Size(143, 29);
            this.ShowAvialable.TabIndex = 0;
            this.ShowAvialable.Text = "Availables";
            this.ShowAvialable.UseVisualStyleBackColor = false;
            this.ShowAvialable.Click += new System.EventHandler(this.ShowAvialable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 37);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Location = new System.Drawing.Point(920, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 37);
            this.button5.TabIndex = 7;
            this.button5.Text = "Feedbacks";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicle Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add New Vehicle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Admin";
            // 
            // AddVehiclePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 549);
            this.Controls.Add(this.AvailableFrame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddVehiclePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVehiclePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddVehiclePage_Load);
            this.AvailableFrame.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleImageBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AvailableFrame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddTo;
        private System.Windows.Forms.Button ShowAvialable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox CarNameText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox vehicleImageBox;
        private System.Windows.Forms.TextBox CarPriceText;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CarDesText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}