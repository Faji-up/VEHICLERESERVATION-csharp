namespace VehicleReservation
{
    partial class ReservationMainPage
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReservedTrueFrame = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddTo = new System.Windows.Forms.Button();
            this.ShowAvialable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AvailableFrame.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvailableFrame
            // 
            this.AvailableFrame.Controls.Add(this.panel4);
            this.AvailableFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableFrame.Location = new System.Drawing.Point(161, 37);
            this.AvailableFrame.Name = "AvailableFrame";
            this.AvailableFrame.Size = new System.Drawing.Size(842, 512);
            this.AvailableFrame.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 512);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ReservedTrueFrame);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 512);
            this.panel3.TabIndex = 0;
            // 
            // ReservedTrueFrame
            // 
            this.ReservedTrueFrame.AutoScroll = true;
            this.ReservedTrueFrame.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReservedTrueFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservedTrueFrame.Location = new System.Drawing.Point(0, 35);
            this.ReservedTrueFrame.Margin = new System.Windows.Forms.Padding(0);
            this.ReservedTrueFrame.Name = "ReservedTrueFrame";
            this.ReservedTrueFrame.Padding = new System.Windows.Forms.Padding(20, 10, 20, 0);
            this.ReservedTrueFrame.Size = new System.Drawing.Size(842, 477);
            this.ReservedTrueFrame.TabIndex = 1;
            this.ReservedTrueFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.ReservedTrueFrame_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LawnGreen;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(842, 35);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserved";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AddTo);
            this.panel2.Controls.Add(this.ShowAvialable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 512);
            this.panel2.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(12, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Requests";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(12, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reservation";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTo
            // 
            this.AddTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddTo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.AddTo.Location = new System.Drawing.Point(12, 41);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(143, 29);
            this.AddTo.TabIndex = 1;
            this.AddTo.Text = "Add";
            this.AddTo.UseVisualStyleBackColor = false;
            this.AddTo.Click += new System.EventHandler(this.AddTo_Click);
            // 
            // ShowAvialable
            // 
            this.ShowAvialable.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ShowAvialable.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 37);
            this.panel1.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(920, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "Feedbacks";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin";
            // 
            // ReservationMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 549);
            this.Controls.Add(this.AvailableFrame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationMainPage";
            this.Text = "ReservationMainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReservationMainPage_Load);
            this.AvailableFrame.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AvailableFrame;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddTo;
        private System.Windows.Forms.Button ShowAvialable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel ReservedTrueFrame;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}