
namespace Ems
{
    partial class DictionaryForm
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
            this.imageButtonFavorite = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageButtonEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageButtonDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageButtonStudied = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DataGridViewWords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.WordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htmlToolTipEdit = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.htmlToolTipFavorite = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.htmlToolTipStudied = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.htmlToolTipDelete = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panelActiveForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.Controls.Add(this.imageButtonFavorite);
            this.panelActiveForm.Controls.Add(this.imageButtonEdit);
            this.panelActiveForm.Controls.Add(this.imageButtonDelete);
            this.panelActiveForm.Controls.Add(this.imageButtonStudied);
            this.panelActiveForm.Controls.Add(this.DataGridViewWords);
            this.panelActiveForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActiveForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(69)))));
            this.panelActiveForm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(4)))), ((int)(((byte)(110)))));
            this.panelActiveForm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panelActiveForm.Location = new System.Drawing.Point(0, 0);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.ShadowDecoration.Parent = this.panelActiveForm;
            this.panelActiveForm.Size = new System.Drawing.Size(1030, 509);
            this.panelActiveForm.TabIndex = 1;
            // 
            // imageButtonFavorite
            // 
            this.imageButtonFavorite.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonFavorite.BackgroundImage = global::Ems.Properties.Resources.star;
            this.imageButtonFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonFavorite.CheckedState.Parent = this.imageButtonFavorite;
            this.imageButtonFavorite.HoverState.Parent = this.imageButtonFavorite;
            this.imageButtonFavorite.Location = new System.Drawing.Point(24, 12);
            this.imageButtonFavorite.Name = "imageButtonFavorite";
            this.imageButtonFavorite.PressedState.Parent = this.imageButtonFavorite;
            this.imageButtonFavorite.Size = new System.Drawing.Size(59, 61);
            this.imageButtonFavorite.TabIndex = 11;
            this.imageButtonFavorite.UseTransparentBackground = true;
            this.imageButtonFavorite.Click += new System.EventHandler(this.imageButtonFavorite_Click);
            // 
            // imageButtonEdit
            // 
            this.imageButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonEdit.BackgroundImage = global::Ems.Properties.Resources.pencil_case;
            this.imageButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonEdit.CheckedState.Parent = this.imageButtonEdit;
            this.imageButtonEdit.HoverState.Parent = this.imageButtonEdit;
            this.imageButtonEdit.Location = new System.Drawing.Point(196, 12);
            this.imageButtonEdit.Name = "imageButtonEdit";
            this.imageButtonEdit.PressedState.Parent = this.imageButtonEdit;
            this.imageButtonEdit.Size = new System.Drawing.Size(59, 61);
            this.imageButtonEdit.TabIndex = 10;
            this.imageButtonEdit.UseTransparentBackground = true;
            this.imageButtonEdit.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // imageButtonDelete
            // 
            this.imageButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonDelete.BackgroundImage = global::Ems.Properties.Resources.trash_can;
            this.imageButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonDelete.CheckedState.Parent = this.imageButtonDelete;
            this.imageButtonDelete.HoverState.Parent = this.imageButtonDelete;
            this.imageButtonDelete.Location = new System.Drawing.Point(261, 12);
            this.imageButtonDelete.Name = "imageButtonDelete";
            this.imageButtonDelete.PressedState.Parent = this.imageButtonDelete;
            this.imageButtonDelete.Size = new System.Drawing.Size(77, 61);
            this.imageButtonDelete.TabIndex = 10;
            this.imageButtonDelete.UseTransparentBackground = true;
            this.imageButtonDelete.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // imageButtonStudied
            // 
            this.imageButtonStudied.BackColor = System.Drawing.Color.Transparent;
            this.imageButtonStudied.BackgroundImage = global::Ems.Properties.Resources.diploma;
            this.imageButtonStudied.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButtonStudied.CheckedState.Parent = this.imageButtonStudied;
            this.imageButtonStudied.HoverState.Parent = this.imageButtonStudied;
            this.imageButtonStudied.Location = new System.Drawing.Point(107, 14);
            this.imageButtonStudied.Name = "imageButtonStudied";
            this.imageButtonStudied.PressedState.Parent = this.imageButtonStudied;
            this.imageButtonStudied.Size = new System.Drawing.Size(59, 61);
            this.imageButtonStudied.TabIndex = 10;
            this.imageButtonStudied.UseTransparentBackground = true;
            this.imageButtonStudied.Click += new System.EventHandler(this.buttonSwap_Click);
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
            this.DataGridViewWords.Location = new System.Drawing.Point(12, 81);
            this.DataGridViewWords.Name = "DataGridViewWords";
            this.DataGridViewWords.RowHeadersVisible = false;
            this.DataGridViewWords.RowHeadersWidth = 51;
            this.DataGridViewWords.RowTemplate.Height = 24;
            this.DataGridViewWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewWords.Size = new System.Drawing.Size(615, 403);
            this.DataGridViewWords.TabIndex = 2;
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
            this.CountColumn.HeaderText = "Перевод";
            this.CountColumn.MinimumWidth = 6;
            this.CountColumn.Name = "CountColumn";
            // 
            // htmlToolTipEdit
            // 
            this.htmlToolTipEdit.AllowLinksHandling = true;
            this.htmlToolTipEdit.AutomaticDelay = 0;
            this.htmlToolTipEdit.MaximumSize = new System.Drawing.Size(0, 0);
            this.htmlToolTipEdit.StripAmpersands = true;
            this.htmlToolTipEdit.ToolTipTitle = "Редактировать";
            // 
            // htmlToolTipFavorite
            // 
            this.htmlToolTipFavorite.AllowLinksHandling = true;
            this.htmlToolTipFavorite.AutomaticDelay = 0;
            this.htmlToolTipFavorite.MaximumSize = new System.Drawing.Size(0, 0);
            this.htmlToolTipFavorite.StripAmpersands = true;
            this.htmlToolTipFavorite.ToolTipTitle = "Добавить в избранное";
            // 
            // htmlToolTipStudied
            // 
            this.htmlToolTipStudied.AllowLinksHandling = true;
            this.htmlToolTipStudied.AutomaticDelay = 0;
            this.htmlToolTipStudied.MaximumSize = new System.Drawing.Size(0, 0);
            this.htmlToolTipStudied.StripAmpersands = true;
            this.htmlToolTipStudied.ToolTipTitle = "Изучено";
            // 
            // htmlToolTipDelete
            // 
            this.htmlToolTipDelete.AllowLinksHandling = true;
            this.htmlToolTipDelete.AutomaticDelay = 0;
            this.htmlToolTipDelete.MaximumSize = new System.Drawing.Size(0, 0);
            this.htmlToolTipDelete.StripAmpersands = true;
            this.htmlToolTipDelete.ToolTipTitle = "Удалить";
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 509);
            this.Controls.Add(this.panelActiveForm);
            this.Name = "DictionaryForm";
            this.Text = "DictionaryForm";
            this.panelActiveForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelActiveForm;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountColumn;
        private Guna.UI2.WinForms.Guna2HtmlToolTip htmlToolTipEdit;
        private Guna.UI2.WinForms.Guna2ImageButton imageButtonStudied;
        private Guna.UI2.WinForms.Guna2ImageButton imageButtonEdit;
        private Guna.UI2.WinForms.Guna2ImageButton imageButtonDelete;
        private Guna.UI2.WinForms.Guna2ImageButton imageButtonFavorite;
        private Guna.UI2.WinForms.Guna2HtmlToolTip htmlToolTipFavorite;
        private Guna.UI2.WinForms.Guna2HtmlToolTip htmlToolTipStudied;
        private Guna.UI2.WinForms.Guna2HtmlToolTip htmlToolTipDelete;
    }
}