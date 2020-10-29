namespace CalculatorOnWinForm
{
    partial class ButPanel
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
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.But7 = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.But8 = new System.Windows.Forms.Button();
            this.But9 = new System.Windows.Forms.Button();
            this.But6 = new System.Windows.Forms.Button();
            this.But3 = new System.Windows.Forms.Button();
            this.But2 = new System.Windows.Forms.Button();
            this.But5 = new System.Windows.Forms.Button();
            this.But1 = new System.Windows.Forms.Button();
            this.But4 = new System.Windows.Forms.Button();
            this.ButPercent = new System.Windows.Forms.Button();
            this.ButtonErase = new System.Windows.Forms.Button();
            this.ButMultiplication = new System.Windows.Forms.Button();
            this.BubSubtraction = new System.Windows.Forms.Button();
            this.ButAdditions = new System.Windows.Forms.Button();
            this.ButEqually = new System.Windows.Forms.Button();
            this.ButDivision = new System.Windows.Forms.Button();
            this.But0 = new System.Windows.Forms.Button();
            this.ButPoint = new System.Windows.Forms.Button();
            this.ButEraseAll = new System.Windows.Forms.Button();
            this.LinePanel = new System.Windows.Forms.PictureBox();
            this.ButChangeBG = new System.Windows.Forms.PictureBox();
            this.ButRollUp = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButChangeBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.ButChangeBG);
            this.SettingPanel.Controls.Add(this.ButRollUp);
            this.SettingPanel.Controls.Add(this.CloseButton);
            this.SettingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(367, 40);
            this.SettingPanel.TabIndex = 1;
            this.SettingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.SettingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But7
            // 
            this.But7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.But7.FlatAppearance.BorderSize = 0;
            this.But7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But7.ForeColor = System.Drawing.Color.Gray;
            this.But7.Location = new System.Drawing.Point(14, 370);
            this.But7.Name = "But7";
            this.But7.Size = new System.Drawing.Size(82, 80);
            this.But7.TabIndex = 3;
            this.But7.Text = "7";
            this.But7.UseVisualStyleBackColor = false;
            this.But7.Click += new System.EventHandler(this.But1_Click);
            this.But7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.ForeColor = System.Drawing.Color.Gray;
            this.TextBox.Location = new System.Drawing.Point(0, 48);
            this.TextBox.Margin = new System.Windows.Forms.Padding(10);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(367, 51);
            this.TextBox.TabIndex = 19;
            this.TextBox.Text = "0";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.TextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.TextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But8
            // 
            this.But8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.But8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.But8.FlatAppearance.BorderSize = 0;
            this.But8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But8.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But8.ForeColor = System.Drawing.Color.Gray;
            this.But8.Location = new System.Drawing.Point(100, 370);
            this.But8.Name = "But8";
            this.But8.Size = new System.Drawing.Size(82, 80);
            this.But8.TabIndex = 21;
            this.But8.Text = "8";
            this.But8.UseVisualStyleBackColor = false;
            this.But8.Click += new System.EventHandler(this.But1_Click);
            this.But8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But9
            // 
            this.But9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But9.FlatAppearance.BorderSize = 0;
            this.But9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But9.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But9.ForeColor = System.Drawing.Color.Gray;
            this.But9.Location = new System.Drawing.Point(186, 370);
            this.But9.Name = "But9";
            this.But9.Size = new System.Drawing.Size(82, 80);
            this.But9.TabIndex = 22;
            this.But9.Text = "9";
            this.But9.UseVisualStyleBackColor = false;
            this.But9.Click += new System.EventHandler(this.But1_Click);
            this.But9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But6
            // 
            this.But6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But6.FlatAppearance.BorderSize = 0;
            this.But6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But6.ForeColor = System.Drawing.Color.Gray;
            this.But6.Location = new System.Drawing.Point(188, 284);
            this.But6.Name = "But6";
            this.But6.Size = new System.Drawing.Size(82, 80);
            this.But6.TabIndex = 23;
            this.But6.Text = "6";
            this.But6.UseVisualStyleBackColor = false;
            this.But6.Click += new System.EventHandler(this.But1_Click);
            this.But6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But3
            // 
            this.But3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But3.FlatAppearance.BorderSize = 0;
            this.But3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But3.ForeColor = System.Drawing.Color.Gray;
            this.But3.Location = new System.Drawing.Point(186, 198);
            this.But3.Name = "But3";
            this.But3.Size = new System.Drawing.Size(82, 80);
            this.But3.TabIndex = 24;
            this.But3.Text = "3";
            this.But3.UseVisualStyleBackColor = false;
            this.But3.Click += new System.EventHandler(this.But1_Click);
            this.But3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But2
            // 
            this.But2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But2.FlatAppearance.BorderSize = 0;
            this.But2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But2.ForeColor = System.Drawing.Color.Gray;
            this.But2.Location = new System.Drawing.Point(100, 198);
            this.But2.Name = "But2";
            this.But2.Size = new System.Drawing.Size(82, 80);
            this.But2.TabIndex = 25;
            this.But2.Text = "2";
            this.But2.UseVisualStyleBackColor = false;
            this.But2.Click += new System.EventHandler(this.But1_Click);
            this.But2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But5
            // 
            this.But5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But5.FlatAppearance.BorderSize = 0;
            this.But5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But5.ForeColor = System.Drawing.Color.Gray;
            this.But5.Location = new System.Drawing.Point(100, 284);
            this.But5.Name = "But5";
            this.But5.Size = new System.Drawing.Size(82, 80);
            this.But5.TabIndex = 26;
            this.But5.Text = "5";
            this.But5.UseVisualStyleBackColor = false;
            this.But5.Click += new System.EventHandler(this.But1_Click);
            this.But5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But1
            // 
            this.But1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But1.FlatAppearance.BorderSize = 0;
            this.But1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But1.ForeColor = System.Drawing.Color.Gray;
            this.But1.Location = new System.Drawing.Point(12, 198);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(82, 80);
            this.But1.TabIndex = 27;
            this.But1.Text = "1";
            this.But1.UseVisualStyleBackColor = false;
            this.But1.Click += new System.EventHandler(this.But1_Click);
            this.But1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But4
            // 
            this.But4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But4.FlatAppearance.BorderSize = 0;
            this.But4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But4.ForeColor = System.Drawing.Color.Gray;
            this.But4.Location = new System.Drawing.Point(14, 284);
            this.But4.Name = "But4";
            this.But4.Size = new System.Drawing.Size(82, 80);
            this.But4.TabIndex = 28;
            this.But4.Text = "4";
            this.But4.UseVisualStyleBackColor = false;
            this.But4.Click += new System.EventHandler(this.But1_Click);
            this.But4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButPercent
            // 
            this.ButPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButPercent.FlatAppearance.BorderSize = 0;
            this.ButPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButPercent.ForeColor = System.Drawing.Color.Gray;
            this.ButPercent.Location = new System.Drawing.Point(190, 112);
            this.ButPercent.Name = "ButPercent";
            this.ButPercent.Size = new System.Drawing.Size(82, 80);
            this.ButPercent.TabIndex = 29;
            this.ButPercent.Text = "%";
            this.ButPercent.UseVisualStyleBackColor = false;
            this.ButPercent.Click += new System.EventHandler(this.ButDivision_Click);
            this.ButPercent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButPercent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButtonErase
            // 
            this.ButtonErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButtonErase.FlatAppearance.BorderSize = 0;
            this.ButtonErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonErase.ForeColor = System.Drawing.Color.Gray;
            this.ButtonErase.Location = new System.Drawing.Point(14, 112);
            this.ButtonErase.Name = "ButtonErase";
            this.ButtonErase.Size = new System.Drawing.Size(82, 80);
            this.ButtonErase.TabIndex = 30;
            this.ButtonErase.Text = "C";
            this.ButtonErase.UseVisualStyleBackColor = false;
            this.ButtonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            this.ButtonErase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButtonErase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButMultiplication
            // 
            this.ButMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButMultiplication.FlatAppearance.BorderSize = 0;
            this.ButMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButMultiplication.ForeColor = System.Drawing.Color.Gray;
            this.ButMultiplication.Location = new System.Drawing.Point(274, 198);
            this.ButMultiplication.Name = "ButMultiplication";
            this.ButMultiplication.Size = new System.Drawing.Size(82, 80);
            this.ButMultiplication.TabIndex = 31;
            this.ButMultiplication.Text = "*";
            this.ButMultiplication.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButMultiplication.UseVisualStyleBackColor = false;
            this.ButMultiplication.Click += new System.EventHandler(this.ButDivision_Click);
            this.ButMultiplication.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButMultiplication.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // BubSubtraction
            // 
            this.BubSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.BubSubtraction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BubSubtraction.FlatAppearance.BorderSize = 0;
            this.BubSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BubSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BubSubtraction.ForeColor = System.Drawing.Color.Gray;
            this.BubSubtraction.Location = new System.Drawing.Point(272, 284);
            this.BubSubtraction.Name = "BubSubtraction";
            this.BubSubtraction.Size = new System.Drawing.Size(82, 80);
            this.BubSubtraction.TabIndex = 32;
            this.BubSubtraction.Text = "-";
            this.BubSubtraction.UseVisualStyleBackColor = false;
            this.BubSubtraction.Click += new System.EventHandler(this.ButDivision_Click);
            this.BubSubtraction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.BubSubtraction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButAdditions
            // 
            this.ButAdditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButAdditions.FlatAppearance.BorderSize = 0;
            this.ButAdditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButAdditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButAdditions.ForeColor = System.Drawing.Color.Gray;
            this.ButAdditions.Location = new System.Drawing.Point(272, 370);
            this.ButAdditions.Name = "ButAdditions";
            this.ButAdditions.Size = new System.Drawing.Size(82, 80);
            this.ButAdditions.TabIndex = 33;
            this.ButAdditions.Text = "+";
            this.ButAdditions.UseVisualStyleBackColor = false;
            this.ButAdditions.Click += new System.EventHandler(this.ButDivision_Click);
            this.ButAdditions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButAdditions.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButEqually
            // 
            this.ButEqually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButEqually.FlatAppearance.BorderSize = 0;
            this.ButEqually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButEqually.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButEqually.ForeColor = System.Drawing.Color.Gray;
            this.ButEqually.Location = new System.Drawing.Point(272, 456);
            this.ButEqually.Name = "ButEqually";
            this.ButEqually.Size = new System.Drawing.Size(82, 80);
            this.ButEqually.TabIndex = 34;
            this.ButEqually.Text = "=";
            this.ButEqually.UseVisualStyleBackColor = false;
            this.ButEqually.Click += new System.EventHandler(this.ButEqually_Click);
            this.ButEqually.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButEqually.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButDivision
            // 
            this.ButDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButDivision.FlatAppearance.BorderSize = 0;
            this.ButDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButDivision.ForeColor = System.Drawing.Color.Gray;
            this.ButDivision.Location = new System.Drawing.Point(272, 112);
            this.ButDivision.Name = "ButDivision";
            this.ButDivision.Size = new System.Drawing.Size(82, 80);
            this.ButDivision.TabIndex = 35;
            this.ButDivision.Text = "/";
            this.ButDivision.UseVisualStyleBackColor = false;
            this.ButDivision.Click += new System.EventHandler(this.ButDivision_Click);
            this.ButDivision.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButDivision.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // But0
            // 
            this.But0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.But0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.But0.FlatAppearance.BorderSize = 0;
            this.But0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But0.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But0.ForeColor = System.Drawing.Color.Gray;
            this.But0.Location = new System.Drawing.Point(14, 456);
            this.But0.Name = "But0";
            this.But0.Size = new System.Drawing.Size(170, 80);
            this.But0.TabIndex = 37;
            this.But0.Text = "0";
            this.But0.UseVisualStyleBackColor = false;
            this.But0.Click += new System.EventHandler(this.But1_Click);
            this.But0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.But0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButPoint
            // 
            this.ButPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButPoint.FlatAppearance.BorderSize = 0;
            this.ButPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButPoint.ForeColor = System.Drawing.Color.Gray;
            this.ButPoint.Location = new System.Drawing.Point(184, 456);
            this.ButPoint.Name = "ButPoint";
            this.ButPoint.Size = new System.Drawing.Size(82, 80);
            this.ButPoint.TabIndex = 38;
            this.ButPoint.Text = ",";
            this.ButPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButPoint.UseVisualStyleBackColor = false;
            this.ButPoint.Click += new System.EventHandler(this.But1_Click);
            this.ButPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButEraseAll
            // 
            this.ButEraseAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ButEraseAll.FlatAppearance.BorderSize = 0;
            this.ButEraseAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButEraseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButEraseAll.ForeColor = System.Drawing.Color.Gray;
            this.ButEraseAll.Location = new System.Drawing.Point(102, 112);
            this.ButEraseAll.Name = "ButEraseAll";
            this.ButEraseAll.Size = new System.Drawing.Size(82, 80);
            this.ButEraseAll.TabIndex = 39;
            this.ButEraseAll.Text = "CE";
            this.ButEraseAll.UseVisualStyleBackColor = false;
            this.ButEraseAll.Click += new System.EventHandler(this.ButEraseAll_Click);
            this.ButEraseAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.ButEraseAll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // LinePanel
            // 
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LinePanel.Image = global::CalculatorOnWinForm.Properties.Resources.line;
            this.LinePanel.Location = new System.Drawing.Point(0, 40);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(367, 8);
            this.LinePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LinePanel.TabIndex = 2;
            this.LinePanel.TabStop = false;
            this.LinePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.LinePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            // 
            // ButChangeBG
            // 
            this.ButChangeBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButChangeBG.Image = global::CalculatorOnWinForm.Properties.Resources.CirclePhone;
            this.ButChangeBG.Location = new System.Drawing.Point(258, 6);
            this.ButChangeBG.Name = "ButChangeBG";
            this.ButChangeBG.Size = new System.Drawing.Size(27, 27);
            this.ButChangeBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButChangeBG.TabIndex = 2;
            this.ButChangeBG.TabStop = false;
            this.ButChangeBG.Click += new System.EventHandler(this.ButChangeBG_Click);
            // 
            // ButRollUp
            // 
            this.ButRollUp.Image = global::CalculatorOnWinForm.Properties.Resources.Circle_yellow;
            this.ButRollUp.Location = new System.Drawing.Point(291, 6);
            this.ButRollUp.Name = "ButRollUp";
            this.ButRollUp.Size = new System.Drawing.Size(27, 27);
            this.ButRollUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ButRollUp.TabIndex = 1;
            this.ButRollUp.TabStop = false;
            this.ButRollUp.Click += new System.EventHandler(this.ButRollUp_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::CalculatorOnWinForm.Properties.Resources.Circle;
            this.CloseButton.Location = new System.Drawing.Point(333, 6);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 27);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(367, 543);
            this.Controls.Add(this.ButEraseAll);
            this.Controls.Add(this.ButPoint);
            this.Controls.Add(this.But0);
            this.Controls.Add(this.ButDivision);
            this.Controls.Add(this.ButEqually);
            this.Controls.Add(this.ButAdditions);
            this.Controls.Add(this.BubSubtraction);
            this.Controls.Add(this.ButMultiplication);
            this.Controls.Add(this.ButtonErase);
            this.Controls.Add(this.ButPercent);
            this.Controls.Add(this.But4);
            this.Controls.Add(this.But1);
            this.Controls.Add(this.But5);
            this.Controls.Add(this.But2);
            this.Controls.Add(this.But3);
            this.Controls.Add(this.But6);
            this.Controls.Add(this.But9);
            this.Controls.Add(this.But8);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.But7);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.SettingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButPanel";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButEraseAll_MouseMove);
            this.SettingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LinePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButChangeBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox LinePanel;
        private System.Windows.Forms.Button But7;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button But8;
        private System.Windows.Forms.Button But9;
        private System.Windows.Forms.Button But6;
        private System.Windows.Forms.Button But3;
        private System.Windows.Forms.Button But2;
        private System.Windows.Forms.Button But5;
        private System.Windows.Forms.Button But1;
        private System.Windows.Forms.Button But4;
        private System.Windows.Forms.Button ButPercent;
        private System.Windows.Forms.Button ButtonErase;
        private System.Windows.Forms.Button ButMultiplication;
        private System.Windows.Forms.Button BubSubtraction;
        private System.Windows.Forms.Button ButAdditions;
        private System.Windows.Forms.Button ButEqually;
        private System.Windows.Forms.Button ButDivision;
        private System.Windows.Forms.PictureBox ButRollUp;
        private System.Windows.Forms.Button But0;
        private System.Windows.Forms.Button ButPoint;
        private System.Windows.Forms.Button ButEraseAll;
        private System.Windows.Forms.PictureBox ButChangeBG;
    }
}

