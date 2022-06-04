
namespace Ems
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.buttonLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.labelRegistration = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBoxLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2Panel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-12, -14);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(541, 358);
            this.guna2Panel1.TabIndex = 2;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(487, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 9;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.buttonLogin.BorderRadius = 6;
            this.buttonLogin.CheckedState.Parent = this.buttonLogin;
            this.buttonLogin.CustomImages.Parent = this.buttonLogin;
            this.buttonLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(73)))), ((int)(((byte)(211)))));
            this.buttonLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.buttonLogin.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.HoverState.Parent = this.buttonLogin;
            this.buttonLogin.Location = new System.Drawing.Point(108, 272);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.ShadowDecoration.Parent = this.buttonLogin;
            this.buttonLogin.Size = new System.Drawing.Size(277, 55);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Вход";
            this.buttonLogin.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(143, 5);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(299, 42);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Авторизация";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.labelRegistration);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.buttonLogin);
            this.guna2GradientPanel1.Controls.Add(this.textBoxLogin);
            this.guna2GradientPanel1.Controls.Add(this.textBoxPassword);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(4)))), ((int)(((byte)(93)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(2)))), ((int)(((byte)(74)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 324);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(520, 459);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = false;
            this.labelRegistration.AutoSizeHeightOnly = true;
            this.labelRegistration.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistration.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.labelRegistration.Location = new System.Drawing.Point(171, 356);
            this.labelRegistration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(337, 25);
            this.labelRegistration.TabIndex = 8;
            this.labelRegistration.Text = "Создать аккаунт";
            this.labelRegistration.Click += new System.EventHandler(this.labelRegistration_Click);
            this.labelRegistration.MouseEnter += new System.EventHandler(this.labelRegistration_MouseEnter);
            this.labelRegistration.MouseLeave += new System.EventHandler(this.labelRegistration_MouseLeave);
            this.labelRegistration.MouseHover += new System.EventHandler(this.labelRegistration_MouseHover);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(3)))), ((int)(((byte)(174)))));
            this.textBoxLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.textBoxLogin.BorderRadius = 6;
            this.textBoxLogin.BorderThickness = 4;
            this.textBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxLogin.DefaultText = "";
            this.textBoxLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogin.DisabledState.Parent = this.textBoxLogin;
            this.textBoxLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(4)))), ((int)(((byte)(84)))));
            this.textBoxLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogin.FocusedState.Parent = this.textBoxLogin;
            this.textBoxLogin.ForeColor = System.Drawing.Color.White;
            this.textBoxLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxLogin.HoverState.Parent = this.textBoxLogin;
            this.textBoxLogin.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxLogin.IconLeft")));
            this.textBoxLogin.IconLeftSize = new System.Drawing.Size(40, 40);
            this.textBoxLogin.Location = new System.Drawing.Point(108, 81);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.PasswordChar = '\0';
            this.textBoxLogin.PlaceholderForeColor = System.Drawing.Color.White;
            this.textBoxLogin.PlaceholderText = "Логин";
            this.textBoxLogin.SelectedText = "";
            this.textBoxLogin.ShadowDecoration.Parent = this.textBoxLogin;
            this.textBoxLogin.Size = new System.Drawing.Size(277, 55);
            this.textBoxLogin.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(3)))), ((int)(((byte)(174)))));
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.textBoxPassword.BorderRadius = 6;
            this.textBoxPassword.BorderThickness = 4;
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(4)))), ((int)(((byte)(84)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.IconLeft = global::Ems.Properties.Resources.password;
            this.textBoxPassword.IconLeftSize = new System.Drawing.Size(40, 40);
            this.textBoxPassword.Location = new System.Drawing.Point(108, 176);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.textBoxPassword.PlaceholderText = "Пароль";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(277, 55);
            this.textBoxPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(520, 783);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Text = "z";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textBoxLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton buttonLogin;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelRegistration;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}