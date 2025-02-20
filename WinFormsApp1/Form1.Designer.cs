namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            TextBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            TextBoxEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(12, 12);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(768, 475);
            guna2DataGridView1.TabIndex = 0;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ButtonAdd
            // 
            ButtonAdd.BorderRadius = 10;
            ButtonAdd.CustomizableEdges = customizableEdges1;
            ButtonAdd.DisabledState.BorderColor = Color.DarkGray;
            ButtonAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonAdd.Font = new Font("Segoe UI", 9F);
            ButtonAdd.ForeColor = Color.White;
            ButtonAdd.Location = new Point(852, 161);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonAdd.Size = new Size(200, 45);
            ButtonAdd.TabIndex = 1;
            ButtonAdd.Text = "Add";
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // TextBoxUsername
            // 
            TextBoxUsername.BorderRadius = 15;
            TextBoxUsername.CustomizableEdges = customizableEdges3;
            TextBoxUsername.DefaultText = "";
            TextBoxUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxUsername.Font = new Font("Segoe UI", 9F);
            TextBoxUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxUsername.Location = new Point(852, 19);
            TextBoxUsername.Name = "TextBoxUsername";
            TextBoxUsername.PlaceholderText = "";
            TextBoxUsername.SelectedText = "";
            TextBoxUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TextBoxUsername.Size = new Size(200, 36);
            TextBoxUsername.TabIndex = 2;
            // 
            // TextBoxName
            // 
            TextBoxName.BorderRadius = 15;
            TextBoxName.CustomizableEdges = customizableEdges5;
            TextBoxName.DefaultText = "";
            TextBoxName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxName.Font = new Font("Segoe UI", 9F);
            TextBoxName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxName.Location = new Point(852, 61);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.PlaceholderText = "";
            TextBoxName.SelectedText = "";
            TextBoxName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            TextBoxName.Size = new Size(200, 36);
            TextBoxName.TabIndex = 3;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BorderRadius = 15;
            TextBoxEmail.CustomizableEdges = customizableEdges7;
            TextBoxEmail.DefaultText = "";
            TextBoxEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxEmail.Font = new Font("Segoe UI", 9F);
            TextBoxEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxEmail.Location = new Point(852, 103);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.PlaceholderText = "";
            TextBoxEmail.SelectedText = "";
            TextBoxEmail.ShadowDecoration.CustomizableEdges = customizableEdges8;
            TextBoxEmail.Size = new Size(200, 36);
            TextBoxEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(786, 31);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(786, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(789, 115);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 486);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxName);
            Controls.Add(TextBoxUsername);
            Controls.Add(ButtonAdd);
            Controls.Add(guna2DataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button ButtonAdd;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
