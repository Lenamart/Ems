
namespace Ems
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelActiveForm = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.buttonAddWord = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textBoxWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.addWordButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DataGridViewWords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.WordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageButtonDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.htmlToolTipDelete = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.htmlToolTipAddWord = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panelActiveForm.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.Controls.Add(this.buttonAddWord);
            this.panelActiveForm.Controls.Add(this.textBoxWord);
            this.panelActiveForm.Controls.Add(this.mainPanel);
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.panelActiveForm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.panelActiveForm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelActiveForm.Location = new System.Drawing.Point(0, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.ShadowDecoration.Parent = this.panelActiveForm;
            this.panelActiveForm.Size = new System.Drawing.Size(801, 524);
            this.panelActiveForm.TabIndex = 1;
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.buttonAddWord.BorderRadius = 6;
            this.buttonAddWord.CheckedState.Parent = this.buttonAddWord;
            this.buttonAddWord.CustomImages.Parent = this.buttonAddWord;
            this.buttonAddWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.buttonAddWord.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.buttonAddWord.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddWord.ForeColor = System.Drawing.Color.White;
            this.buttonAddWord.HoverState.Parent = this.buttonAddWord;
            this.buttonAddWord.Location = new System.Drawing.Point(569, 5);
            this.buttonAddWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.ShadowDecoration.Parent = this.buttonAddWord;
            this.buttonAddWord.Size = new System.Drawing.Size(161, 55);
            this.buttonAddWord.TabIndex = 5;
            this.buttonAddWord.Text = "Добавить";
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.BackColor = System.Drawing.Color.Transparent;
            this.textBoxWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.textBoxWord.BorderRadius = 6;
            this.textBoxWord.BorderThickness = 4;
            this.textBoxWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxWord.DefaultText = "";
            this.textBoxWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxWord.DisabledState.Parent = this.textBoxWord;
            this.textBoxWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.textBoxWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxWord.FocusedState.Parent = this.textBoxWord;
            this.textBoxWord.ForeColor = System.Drawing.Color.White;
            this.textBoxWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxWord.HoverState.Parent = this.textBoxWord;
            this.textBoxWord.IconLeftSize = new System.Drawing.Size(40, 40);
            this.textBoxWord.Location = new System.Drawing.Point(47, 5);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxWord.PasswordChar = '\0';
            this.textBoxWord.PlaceholderForeColor = System.Drawing.Color.White;
            this.textBoxWord.PlaceholderText = "Введите слово";
            this.textBoxWord.SelectedText = "";
            this.textBoxWord.ShadowDecoration.Parent = this.textBoxWord;
            this.textBoxWord.Size = new System.Drawing.Size(495, 55);
            this.textBoxWord.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxWord.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(3)))), ((int)(((byte)(120)))));
            this.mainPanel.Controls.Add(this.imageButtonDelete);
            this.mainPanel.Controls.Add(this.addWordButton);
            this.mainPanel.Controls.Add(this.DataGridViewWords);
            this.mainPanel.Location = new System.Drawing.Point(32, 92);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(740, 420);
            this.mainPanel.TabIndex = 1;
            // 
            // addWordButton
            // 
            this.addWordButton.BackColor = System.Drawing.Color.Transparent;
            this.addWordButton.BackgroundImage = global::Ems.Properties.Resources.plus;
            this.addWordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addWordButton.CheckedState.Parent = this.addWordButton;
            this.addWordButton.HoverState.Parent = this.addWordButton;
            this.addWordButton.Location = new System.Drawing.Point(661, 3);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.PressedState.Parent = this.addWordButton;
            this.addWordButton.Size = new System.Drawing.Size(59, 61);
            this.addWordButton.TabIndex = 12;
            this.addWordButton.UseTransparentBackground = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // DataGridViewWords
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewWords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewWords.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewWords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewWords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewWords.ColumnHeadersHeight = 35;
            this.DataGridViewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordColumn,
            this.CountColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewWords.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewWords.EnableHeadersVisualStyles = false;
            this.DataGridViewWords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewWords.Location = new System.Drawing.Point(15, 68);
            this.DataGridViewWords.Name = "DataGridViewWords";
            this.DataGridViewWords.RowHeadersVisible = false;
            this.DataGridViewWords.RowHeadersWidth = 51;
            this.DataGridViewWords.RowTemplate.Height = 24;
            this.DataGridViewWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewWords.Size = new System.Drawing.Size(705, 339);
            this.DataGridViewWords.TabIndex = 0;
            this.DataGridViewWords.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewWords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewWords.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewWords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewWords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewWords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewWords.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewWords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewWords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(11)))), ((int)(((byte)(234)))));
            this.DataGridViewWords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewWords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewWords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewWords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewWords.ThemeStyle.HeaderStyle.Height = 35;
            this.DataGridViewWords.ThemeStyle.ReadOnly = false;
            this.DataGridViewWords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewWords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewWords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewWords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewWords.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewWords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewWords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // WordColumn
            // 
            this.WordColumn.HeaderText = "Слово";
            this.WordColumn.MinimumWidth = 6;
            this.WordColumn.Name = "WordColumn";
            // 
            // CountColumn
            // 
            this.CountColumn.HeaderText = "Кол-во";
            this.CountColumn.MinimumWidth = 6;
            this.CountColumn.Name = "CountColumn";
            // 
            // imageButtonDelete
            // 
            this.imageButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonDelete.BackgroundImage = global::Ems.Properties.Resources.trash_can;
            this.imageButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonDelete.CheckedState.Parent = this.imageButtonDelete;
            this.imageButtonDelete.HoverState.Parent = this.imageButtonDelete;
            this.imageButtonDelete.Location = new System.Drawing.Point(578, 3);
            this.imageButtonDelete.Name = "imageButtonDelete";
            this.imageButtonDelete.PressedState.Parent = this.imageButtonDelete;
            this.imageButtonDelete.Size = new System.Drawing.Size(77, 61);
            this.imageButtonDelete.TabIndex = 13;
            this.imageButtonDelete.UseTransparentBackground = true;
            this.imageButtonDelete.Click += new System.EventHandler(this.imageButtonDelete_Click);
            // 
            // htmlToolTipDelete
            // 
            this.htmlToolTipDelete.AllowLinksHandling = true;
            this.htmlToolTipDelete.AutomaticDelay = 0;
            this.htmlToolTipDelete.MaximumSize = new System.Drawing.Size(0, 0);
            this.htmlToolTipDelete.StripAmpersands = true;
            this.htmlToolTipDelete.ToolTipTitle = "Удалить";
            // 
            // htmlToolTipAddWord
            // 
            this.htmlToolTipAddWord.AllowLinksHandling = true;
            this.htmlToolTipAddWord.AutomaticDelay = 0;
            this.htmlToolTipAddWord.MaximumSize = new System.Drawing.Size(0, 0);
            this.htmlToolTipAddWord.StripAmpersands = true;
            this.htmlToolTipAddWord.ToolTipTitle = "Добавить в словарь";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 524);
            this.Controls.Add(this.panelActiveForm);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panelActiveForm.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelActiveForm;
        private Guna.UI2.WinForms.Guna2GradientButton buttonAddWord;
        private Guna.UI2.WinForms.Guna2TextBox textBoxWord;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private Guna.UI2.WinForms.Guna2ImageButton addWordButton;
        private Guna.UI2.WinForms.Guna2ImageButton imageButtonDelete;
        private Guna.UI2.WinForms.Guna2HtmlToolTip htmlToolTipDelete;
        private Guna.UI2.WinForms.Guna2HtmlToolTip htmlToolTipAddWord;
    }
}