namespace PredmetnyKruzhok
{
    partial class Registration
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.RepeatPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0D;
            this.guna2DragControl1.DragEndTransparencyValue = 0.1D;
            this.guna2DragControl1.DragMode = Guna.UI2.WinForms.Enums.DragMode.Control;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(217, 325);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(39, 17);
            this.errorLabel.TabIndex = 15;
            this.errorLabel.Text = "error";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Animated = true;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BorderColor = System.Drawing.Color.White;
            this.BackButton.BorderRadius = 20;
            this.BackButton.BorderThickness = 1;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackButton.FillColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.HoverState.BorderColor = System.Drawing.Color.White;
            this.BackButton.HoverState.FillColor = System.Drawing.Color.White;
            this.BackButton.HoverState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Location = new System.Drawing.Point(11, 11);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(129, 52);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Назад";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.RepeatPasswordTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.RepeatPasswordTextBox.BorderRadius = 20;
            this.RepeatPasswordTextBox.BorderThickness = 0;
            this.RepeatPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RepeatPasswordTextBox.DefaultText = "";
            this.RepeatPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RepeatPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RepeatPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RepeatPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RepeatPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepeatPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RepeatPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.RepeatPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(211, 264);
            this.RepeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.PasswordChar = '*';
            this.RepeatPasswordTextBox.PlaceholderText = "Повторите пароль";
            this.RepeatPasswordTextBox.SelectedText = "";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(316, 41);
            this.RepeatPasswordTextBox.TabIndex = 21;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Animated = true;
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BorderColor = System.Drawing.Color.White;
            this.SignUpButton.BorderRadius = 20;
            this.SignUpButton.BorderThickness = 1;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpButton.FillColor = System.Drawing.SystemColors.ControlText;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.HoverState.BorderColor = System.Drawing.Color.White;
            this.SignUpButton.HoverState.FillColor = System.Drawing.Color.White;
            this.SignUpButton.HoverState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SignUpButton.Location = new System.Drawing.Point(317, 325);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(135, 37);
            this.SignUpButton.TabIndex = 20;
            this.SignUpButton.Text = "Регистрация";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BorderRadius = 20;
            this.passwordTextBox.BorderThickness = 0;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Location = new System.Drawing.Point(211, 190);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(316, 41);
            this.passwordTextBox.TabIndex = 19;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BackColor = System.Drawing.Color.Transparent;
            this.loginTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.loginTextBox.BorderRadius = 20;
            this.loginTextBox.BorderThickness = 0;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Location = new System.Drawing.Point(211, 125);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "Логин";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(316, 41);
            this.loginTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(278, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Регистрация";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(613, 11);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(104, 42);
            this.guna2ControlBox1.TabIndex = 16;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PredmetnyKruzhok.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrazion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label errorLabel;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2TextBox RepeatPasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button SignUpButton;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}