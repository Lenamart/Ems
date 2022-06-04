
namespace Ems
{
    partial class TranslateForm
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
            this.panelActiveForm = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.buttonSwap = new Guna.UI2.WinForms.Guna2ImageButton();
            this.textBoxToLang = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonTranslate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.comboBoxLang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxToTranslate = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxFromTranslate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelActiveForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.Controls.Add(this.buttonSwap);
            this.panelActiveForm.Controls.Add(this.textBoxToLang);
            this.panelActiveForm.Controls.Add(this.buttonTranslate);
            this.panelActiveForm.Controls.Add(this.comboBoxLang);
            this.panelActiveForm.Controls.Add(this.textBoxToTranslate);
            this.panelActiveForm.Controls.Add(this.textBoxFromTranslate);
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.panelActiveForm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.panelActiveForm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelActiveForm.Location = new System.Drawing.Point(0, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.ShadowDecoration.Parent = this.panelActiveForm;
            this.panelActiveForm.Size = new System.Drawing.Size(895, 524);
            this.panelActiveForm.TabIndex = 2;
            this.panelActiveForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActiveForm_Paint);
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.Transparent;
            this.buttonSwap.BackgroundImage = global::Ems.Properties.Resources.swap;
            this.buttonSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSwap.CheckedState.Parent = this.buttonSwap;
            this.buttonSwap.HoverState.Parent = this.buttonSwap;
            this.buttonSwap.Location = new System.Drawing.Point(355, 108);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.PressedState.Parent = this.buttonSwap;
            this.buttonSwap.Size = new System.Drawing.Size(59, 61);
            this.buttonSwap.TabIndex = 9;
            this.buttonSwap.UseTransparentBackground = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // textBoxToLang
            // 
            this.textBoxToLang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxToLang.DefaultText = "Английский";
            this.textBoxToLang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxToLang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxToLang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxToLang.DisabledState.Parent = this.textBoxToLang;
            this.textBoxToLang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxToLang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxToLang.FocusedState.Parent = this.textBoxToLang;
            this.textBoxToLang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxToLang.HoverState.Parent = this.textBoxToLang;
            this.textBoxToLang.Location = new System.Drawing.Point(438, 124);
            this.textBoxToLang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxToLang.Name = "textBoxToLang";
            this.textBoxToLang.PasswordChar = '\0';
            this.textBoxToLang.PlaceholderText = "";
            this.textBoxToLang.ReadOnly = true;
            this.textBoxToLang.SelectedText = "";
            this.textBoxToLang.SelectionStart = 10;
            this.textBoxToLang.ShadowDecoration.Parent = this.textBoxToLang;
            this.textBoxToLang.Size = new System.Drawing.Size(316, 44);
            this.textBoxToLang.TabIndex = 7;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.buttonTranslate.BorderRadius = 6;
            this.buttonTranslate.CheckedState.Parent = this.buttonTranslate;
            this.buttonTranslate.CustomImages.Parent = this.buttonTranslate;
            this.buttonTranslate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.buttonTranslate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.buttonTranslate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTranslate.ForeColor = System.Drawing.Color.White;
            this.buttonTranslate.HoverState.Parent = this.buttonTranslate;
            this.buttonTranslate.Location = new System.Drawing.Point(227, 48);
            this.buttonTranslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.ShadowDecoration.Parent = this.buttonTranslate;
            this.buttonTranslate.Size = new System.Drawing.Size(318, 46);
            this.buttonTranslate.TabIndex = 6;
            this.buttonTranslate.Text = "Перевести";
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // comboBoxLang
            // 
            this.comboBoxLang.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLang.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxLang.FocusedState.Parent = this.comboBoxLang;
            this.comboBoxLang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxLang.FormattingEnabled = true;
            this.comboBoxLang.HoverState.Parent = this.comboBoxLang;
            this.comboBoxLang.ItemHeight = 30;
            this.comboBoxLang.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.comboBoxLang.ItemsAppearance.Parent = this.comboBoxLang;
            this.comboBoxLang.Location = new System.Drawing.Point(18, 124);
            this.comboBoxLang.Name = "comboBoxLang";
            this.comboBoxLang.ShadowDecoration.Parent = this.comboBoxLang;
            this.comboBoxLang.Size = new System.Drawing.Size(318, 36);
            this.comboBoxLang.TabIndex = 4;
            this.comboBoxLang.SelectedIndexChanged += new System.EventHandler(this.comboBoxLang_SelectedIndexChanged);
            this.comboBoxLang.SelectedValueChanged += new System.EventHandler(this.comboBoxLang_SelectedValueChanged);
            // 
            // textBoxToTranslate
            // 
            this.textBoxToTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.textBoxToTranslate.BorderRadius = 9;
            this.textBoxToTranslate.BorderThickness = 0;
            this.textBoxToTranslate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxToTranslate.DefaultText = "";
            this.textBoxToTranslate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxToTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxToTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxToTranslate.DisabledState.Parent = this.textBoxToTranslate;
            this.textBoxToTranslate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxToTranslate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxToTranslate.FocusedState.Parent = this.textBoxToTranslate;
            this.textBoxToTranslate.ForeColor = System.Drawing.Color.Black;
            this.textBoxToTranslate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxToTranslate.HoverState.Parent = this.textBoxToTranslate;
            this.textBoxToTranslate.Location = new System.Drawing.Point(403, 183);
            this.textBoxToTranslate.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.textBoxToTranslate.Name = "textBoxToTranslate";
            this.textBoxToTranslate.PasswordChar = '\0';
            this.textBoxToTranslate.PlaceholderText = "";
            this.textBoxToTranslate.ReadOnly = true;
            this.textBoxToTranslate.SelectedText = "";
            this.textBoxToTranslate.ShadowDecoration.Parent = this.textBoxToTranslate;
            this.textBoxToTranslate.Size = new System.Drawing.Size(351, 309);
            this.textBoxToTranslate.TabIndex = 3;
            this.textBoxToTranslate.TextOffset = new System.Drawing.Point(0, -100);
            // 
            // textBoxFromTranslate
            // 
            this.textBoxFromTranslate.BackColor = System.Drawing.Color.White;
            this.textBoxFromTranslate.BorderColor = System.Drawing.Color.Transparent;
            this.textBoxFromTranslate.BorderRadius = 9;
            this.textBoxFromTranslate.BorderThickness = 0;
            this.textBoxFromTranslate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFromTranslate.DefaultText = "";
            this.textBoxFromTranslate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxFromTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxFromTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFromTranslate.DisabledState.Parent = this.textBoxFromTranslate;
            this.textBoxFromTranslate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxFromTranslate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFromTranslate.FocusedState.Parent = this.textBoxFromTranslate;
            this.textBoxFromTranslate.ForeColor = System.Drawing.Color.Black;
            this.textBoxFromTranslate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxFromTranslate.HoverState.Parent = this.textBoxFromTranslate;
            this.textBoxFromTranslate.Location = new System.Drawing.Point(18, 183);
            this.textBoxFromTranslate.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.textBoxFromTranslate.Name = "textBoxFromTranslate";
            this.textBoxFromTranslate.PasswordChar = '\0';
            this.textBoxFromTranslate.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBoxFromTranslate.PlaceholderText = "";
            this.textBoxFromTranslate.SelectedText = "";
            this.textBoxFromTranslate.ShadowDecoration.Parent = this.textBoxFromTranslate;
            this.textBoxFromTranslate.Size = new System.Drawing.Size(351, 309);
            this.textBoxFromTranslate.TabIndex = 2;
            this.textBoxFromTranslate.TextOffset = new System.Drawing.Point(0, -100);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this.textBoxFromTranslate;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.textBoxToTranslate;
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 524);
            this.Controls.Add(this.panelActiveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TranslateForm";
            this.Text = "Translate";
            this.panelActiveForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelActiveForm;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFromTranslate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxToTranslate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxLang;
        private Guna.UI2.WinForms.Guna2GradientButton buttonTranslate;
        private Guna.UI2.WinForms.Guna2TextBox textBoxToLang;
        private Guna.UI2.WinForms.Guna2ImageButton buttonSwap;
    }
}