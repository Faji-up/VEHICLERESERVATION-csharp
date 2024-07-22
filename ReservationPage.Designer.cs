namespace VehicleReservation
{
    partial class ReservationPage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.RequestDes = new System.Windows.Forms.Label();
            this.RequestPrice = new System.Windows.Forms.Label();
            this.ResquestName = new System.Windows.Forms.Label();
            this.ResquestImage = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResquestImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dateTime);
            this.panel2.Controls.Add(this.RequestDes);
            this.panel2.Controls.Add(this.RequestPrice);
            this.panel2.Controls.Add(this.ResquestName);
            this.panel2.Controls.Add(this.ResquestImage);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 540);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // RequestDes
            // 
            this.RequestDes.AutoSize = true;
            this.RequestDes.BackColor = System.Drawing.Color.Yellow;
            this.RequestDes.Location = new System.Drawing.Point(19, 230);
            this.RequestDes.MaximumSize = new System.Drawing.Size(200, 100);
            this.RequestDes.MinimumSize = new System.Drawing.Size(200, 100);
            this.RequestDes.Name = "RequestDes";
            this.RequestDes.Size = new System.Drawing.Size(200, 100);
            this.RequestDes.TabIndex = 5;
            this.RequestDes.Text = "label3";
            this.RequestDes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RequestPrice
            // 
            this.RequestPrice.AutoSize = true;
            this.RequestPrice.BackColor = System.Drawing.Color.Yellow;
            this.RequestPrice.Location = new System.Drawing.Point(19, 121);
            this.RequestPrice.MaximumSize = new System.Drawing.Size(200, 100);
            this.RequestPrice.MinimumSize = new System.Drawing.Size(200, 100);
            this.RequestPrice.Name = "RequestPrice";
            this.RequestPrice.Size = new System.Drawing.Size(200, 100);
            this.RequestPrice.TabIndex = 4;
            this.RequestPrice.Text = "label2";
            this.RequestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RequestPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResquestName
            // 
            this.ResquestName.AutoSize = true;
            this.ResquestName.BackColor = System.Drawing.Color.Yellow;
            this.ResquestName.Location = new System.Drawing.Point(19, 12);
            this.ResquestName.MaximumSize = new System.Drawing.Size(200, 100);
            this.ResquestName.MinimumSize = new System.Drawing.Size(200, 100);
            this.ResquestName.Name = "ResquestName";
            this.ResquestName.Size = new System.Drawing.Size(200, 100);
            this.ResquestName.TabIndex = 3;
            this.ResquestName.Text = "label1";
            this.ResquestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResquestName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ResquestImage
            // 
            this.ResquestImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ResquestImage.Location = new System.Drawing.Point(238, 12);
            this.ResquestImage.Name = "ResquestImage";
            this.ResquestImage.Size = new System.Drawing.Size(393, 329);
            this.ResquestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResquestImage.TabIndex = 2;
            this.ResquestImage.TabStop = false;
            this.ResquestImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F);
            this.button2.Location = new System.Drawing.Point(116, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F);
            this.button1.Location = new System.Drawing.Point(340, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Request";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(340, 442);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(207, 20);
            this.dateTime.TabIndex = 6;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 540);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationPage";
            this.Load += new System.EventHandler(this.ReservationPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResquestImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ResquestImage;
        private System.Windows.Forms.Label ResquestName;
        private System.Windows.Forms.Label RequestPrice;
        private System.Windows.Forms.Label RequestDes;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}