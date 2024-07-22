namespace VehicleReservation
{
    partial class UserHistory
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
            this.historyCon = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.profileBtn = new System.Windows.Forms.Button();
            this.showSearch = new System.Windows.Forms.Button();
            this.showCars = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyCon
            // 
            this.historyCon.AutoScroll = true;
            this.historyCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyCon.Location = new System.Drawing.Point(92, 15);
            this.historyCon.Name = "historyCon";
            this.historyCon.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.historyCon.Size = new System.Drawing.Size(911, 534);
            this.historyCon.TabIndex = 9;
            this.historyCon.Paint += new System.Windows.Forms.PaintEventHandler(this.historyCon_Paint);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkEx BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(350, 0, 350, 0);
            this.label1.Size = new System.Drawing.Size(913, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Car Reservation System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileBtn
            // 
            this.profileBtn.AccessibleName = "profileBtn";
            this.profileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.Location = new System.Drawing.Point(12, 513);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(57, 24);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Settings";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // showSearch
            // 
            this.showSearch.AccessibleName = "showSearch";
            this.showSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSearch.Location = new System.Drawing.Point(3, 44);
            this.showSearch.Name = "showSearch";
            this.showSearch.Size = new System.Drawing.Size(87, 29);
            this.showSearch.TabIndex = 1;
            this.showSearch.Text = "Search";
            this.showSearch.UseVisualStyleBackColor = false;
            this.showSearch.Click += new System.EventHandler(this.showSearch_Click);
            // 
            // showCars
            // 
            this.showCars.AccessibleName = "showCars";
            this.showCars.BackColor = System.Drawing.Color.Lime;
            this.showCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCars.Location = new System.Drawing.Point(3, 6);
            this.showCars.Name = "showCars";
            this.showCars.Size = new System.Drawing.Size(88, 32);
            this.showCars.TabIndex = 0;
            this.showCars.Text = "Cars";
            this.showCars.UseVisualStyleBackColor = false;
            this.showCars.Click += new System.EventHandler(this.showCars_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.profileBtn);
            this.panel1.Controls.Add(this.showSearch);
            this.panel1.Controls.Add(this.showCars);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 549);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.AccessibleName = "showSearch";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "History";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "showSearch";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reservation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 549);
            this.Controls.Add(this.historyCon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserHistory";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel historyCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Button showSearch;
        private System.Windows.Forms.Button showCars;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}