namespace Start_HD_SDT_1._3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialResolutionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialAffinityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList2;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 29);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(844, 483);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Enter += new System.EventHandler(this.materialTabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialCheckbox1);
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.materialResolutionComboBox);
            this.tabPage1.Controls.Add(this.materialAffinityComboBox);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.ImageKey = "Asset 1@4x.png";
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.tabPage1.Size = new System.Drawing.Size(828, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(597, 137);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(122, 37);
            this.materialCheckbox1.TabIndex = 4;
            this.materialCheckbox1.Text = "High Priority";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(677, 218);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(69, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Resize";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialResolutionComboBox
            // 
            this.materialResolutionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialResolutionComboBox.AutoResize = false;
            this.materialResolutionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialResolutionComboBox.Depth = 0;
            this.materialResolutionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialResolutionComboBox.DropDownHeight = 118;
            this.materialResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialResolutionComboBox.DropDownWidth = 121;
            this.materialResolutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialResolutionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialResolutionComboBox.FormattingEnabled = true;
            this.materialResolutionComboBox.Hint = "Resolution";
            this.materialResolutionComboBox.IntegralHeight = false;
            this.materialResolutionComboBox.ItemHeight = 29;
            this.materialResolutionComboBox.Items.AddRange(new object[] {
            "7:6 | 700x600",
            "7:6 | 1400x1200",
            "16:9 | 1024×576",
            "16:9 | 1152×648",
            "16:9 | 1280×720",
            "16:9 | 1366×768",
            "16:9 | 1600×900",
            "16:9 | 1920×1080",
            "16:9 | 2560x1440"});
            this.materialResolutionComboBox.Location = new System.Drawing.Point(8, 205);
            this.materialResolutionComboBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.materialResolutionComboBox.MaxDropDownItems = 4;
            this.materialResolutionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.materialResolutionComboBox.Name = "materialResolutionComboBox";
            this.materialResolutionComboBox.Size = new System.Drawing.Size(328, 35);
            this.materialResolutionComboBox.StartIndex = 0;
            this.materialResolutionComboBox.TabIndex = 2;
            this.materialResolutionComboBox.UseTallSize = false;
            this.materialResolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.materialResolutionComboBox_SelectedIndexChanged);
            // 
            // materialAffinityComboBox
            // 
            this.materialAffinityComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialAffinityComboBox.AutoResize = false;
            this.materialAffinityComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialAffinityComboBox.Depth = 0;
            this.materialAffinityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialAffinityComboBox.DropDownHeight = 118;
            this.materialAffinityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialAffinityComboBox.DropDownWidth = 121;
            this.materialAffinityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialAffinityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialAffinityComboBox.FormattingEnabled = true;
            this.materialAffinityComboBox.Hint = "Processors";
            this.materialAffinityComboBox.IntegralHeight = false;
            this.materialAffinityComboBox.ItemHeight = 29;
            this.materialAffinityComboBox.Items.AddRange(new object[] {
            "CPU 0",
            "CPU 1",
            "CPU 2",
            "CPU 3",
            "CPU 4",
            "CPU 5",
            "CPU 6",
            "CPU 7",
            "CPU 8",
            "CPU 9",
            "CPU 10",
            "CPU 11",
            "CPU 12",
            "CPU 13",
            "CPU 14",
            "CPU 15",
            "CPU 16",
            "CPU 17",
            "CPU 18",
            "CPU 19",
            "CPU 20",
            "CPU 21",
            "CPU 22",
            "CPU 23",
            "CPU 24",
            "CPU 25",
            "CPU 26",
            "CPU 27",
            "CPU 28",
            "CPU 29",
            "CPU 30",
            "CPU 31",
            "CPU 32"});
            this.materialAffinityComboBox.Location = new System.Drawing.Point(8, 115);
            this.materialAffinityComboBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.materialAffinityComboBox.MaxDropDownItems = 4;
            this.materialAffinityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.materialAffinityComboBox.Name = "materialAffinityComboBox";
            this.materialAffinityComboBox.Size = new System.Drawing.Size(328, 35);
            this.materialAffinityComboBox.StartIndex = 0;
            this.materialAffinityComboBox.TabIndex = 1;
            this.materialAffinityComboBox.UseTallSize = false;
            this.materialAffinityComboBox.SelectedIndexChanged += new System.EventHandler(this.materialAffinityComboBox_SelectedIndexChanged);
            this.materialAffinityComboBox.TextChanged += new System.EventHandler(this.materialAffinityComboBox_TextChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1, 389);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(826, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Play HD SDT";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialButton6);
            this.tabPage2.Controls.Add(this.materialButton5);
            this.tabPage2.Controls.Add(this.materialButton4);
            this.tabPage2.Controls.Add(this.materialButton3);
            this.tabPage2.ImageKey = "Asset 2@4x.png";
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.tabPage2.Size = new System.Drawing.Size(828, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialButton6
            // 
            this.materialButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton6.Depth = 0;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = null;
            this.materialButton6.Location = new System.Drawing.Point(285, 228);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton6.Size = new System.Drawing.Size(167, 36);
            this.materialButton6.TabIndex = 3;
            this.materialButton6.Text = "Reset All Settings";
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            this.materialButton6.Click += new System.EventHandler(this.materialButton6_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(286, 137);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(164, 36);
            this.materialButton5.TabIndex = 2;
            this.materialButton5.Text = "Set Loader Folder";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(291, 41);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(154, 36);
            this.materialButton4.TabIndex = 1;
            this.materialButton4.Text = "Set Flash Player";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(1, 389);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(826, 36);
            this.materialButton3.TabIndex = 0;
            this.materialButton3.Text = "View Settings";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialMultiLineTextBox1);
            this.tabPage3.ImageKey = "Asset 4@4x.png";
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(828, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(0, 0);
            this.materialMultiLineTextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.ReadOnly = true;
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(828, 429);
            this.materialMultiLineTextBox1.TabIndex = 0;
            this.materialMultiLineTextBox1.Text = resources.GetString("materialMultiLineTextBox1.Text");
            this.materialMultiLineTextBox1.ZoomFactor = 0.5F;
            this.materialMultiLineTextBox1.TextChanged += new System.EventHandler(this.materialMultiLineTextBox1_TextChanged);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Asset 1@4x.png");
            this.imageList2.Images.SetKeyName(1, "Asset 2@4x.png");
            this.imageList2.Images.SetKeyName(2, "Asset 3@4x.png");
            this.imageList2.Images.SetKeyName(3, "Asset 4@4x.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 516);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 6;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerUseColors = true;
            this.DrawerWidth = 120;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 29, 1, 4);
            this.Sizable = false;
            this.Text = "Start HD SDT 1.3";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.Form1_DpiChanged);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.DpiChangedAfterParent += new System.EventHandler(this.Form1_DpiChangedAfterParent);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox materialResolutionComboBox;
        private MaterialSkin.Controls.MaterialComboBox materialAffinityComboBox;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private ImageList imageList2;
    }
}