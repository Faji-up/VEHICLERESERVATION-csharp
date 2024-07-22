namespace VehicleReservation
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.RegisterBtnR = new System.Windows.Forms.Button();
            this.LoginBtnR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPasswordR = new System.Windows.Forms.TextBox();
            this.textBoxUsernameR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Registertxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterBtnR
            // 
            this.RegisterBtnR.AccessibleName = "RegisterBtnR";
            this.RegisterBtnR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtnR.Location = new System.Drawing.Point(279, 281);
            this.RegisterBtnR.Name = "RegisterBtnR";
            this.RegisterBtnR.Size = new System.Drawing.Size(95, 36);
            this.RegisterBtnR.TabIndex = 23;
            this.RegisterBtnR.Text = "Register";
            this.RegisterBtnR.UseVisualStyleBackColor = true;
            this.RegisterBtnR.Click += new System.EventHandler(this.RegisterBtnR_Click);
            // 
            // LoginBtnR
            // 
            this.LoginBtnR.AccessibleName = "LoginBtnR";
            this.LoginBtnR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtnR.Location = new System.Drawing.Point(257, 342);
            this.LoginBtnR.Name = "LoginBtnR";
            this.LoginBtnR.Size = new System.Drawing.Size(140, 36);
            this.LoginBtnR.TabIndex = 22;
            this.LoginBtnR.Text = "Log in";
            this.LoginBtnR.UseVisualStyleBackColor = true;
            this.LoginBtnR.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkEx BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Car Reservation";
            // 
            // textBoxPasswordR
            // 
            this.textBoxPasswordR.AccessibleName = "textBoxPasswordR";
            this.textBoxPasswordR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordR.Location = new System.Drawing.Point(293, 221);
            this.textBoxPasswordR.Name = "textBoxPasswordR";
            this.textBoxPasswordR.Size = new System.Drawing.Size(194, 26);
            this.textBoxPasswordR.TabIndex = 20;
            this.textBoxPasswordR.UseSystemPasswordChar = true;
            this.textBoxPasswordR.TextChanged += new System.EventHandler(this.textBoxPasswordR_TextChanged);
            // 
            // textBoxUsernameR
            // 
            this.textBoxUsernameR.AccessibleName = "textBoxUsernameR";
            this.textBoxUsernameR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameR.Location = new System.Drawing.Point(293, 164);
            this.textBoxUsernameR.Name = "textBoxUsernameR";
            this.textBoxUsernameR.Size = new System.Drawing.Size(194, 26);
            this.textBoxUsernameR.TabIndex = 19;
            this.textBoxUsernameR.TextChanged += new System.EventHandler(this.textBoxUsernameR_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username:";
            // 
            // Registertxt
            // 
            this.Registertxt.AccessibleName = "RegisterTxt";
            this.Registertxt.AutoSize = true;
            this.Registertxt.BackColor = System.Drawing.SystemColors.Control;
            this.Registertxt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registertxt.Location = new System.Drawing.Point(273, 80);
            this.Registertxt.Name = "Registertxt";
            this.Registertxt.Size = new System.Drawing.Size(124, 32);
            this.Registertxt.TabIndex = 16;
            this.Registertxt.Text = "Register";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 524);
            this.Controls.Add(this.RegisterBtnR);
            this.Controls.Add(this.LoginBtnR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPasswordR);
            this.Controls.Add(this.textBoxUsernameR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registertxt);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtnR;
        private System.Windows.Forms.Button LoginBtnR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPasswordR;
        private System.Windows.Forms.TextBox textBoxUsernameR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Registertxt;
    }
}