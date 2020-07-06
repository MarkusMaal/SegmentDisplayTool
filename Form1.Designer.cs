namespace segment_tool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.SegmentChecker = new System.Windows.Forms.Timer(this.components);
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LightColor = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.decodable = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.floatSegment = new System.Windows.Forms.PictureBox();
            this.Segment4 = new System.Windows.Forms.PictureBox();
            this.Segment7 = new System.Windows.Forms.PictureBox();
            this.Segment6 = new System.Windows.Forms.PictureBox();
            this.Segment5 = new System.Windows.Forms.PictureBox();
            this.Segment1 = new System.Windows.Forms.PictureBox();
            this.Segment3 = new System.Windows.Forms.PictureBox();
            this.Segment2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floatSegment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 196);
            this.label1.TabIndex = 0;
            // 
            // SegmentChecker
            // 
            this.SegmentChecker.Enabled = true;
            this.SegmentChecker.Interval = 500;
            this.SegmentChecker.Tick += new System.EventHandler(this.SegmentChecker_Tick);
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutPutLabel.Location = new System.Drawing.Point(3, 6);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(119, 23);
            this.OutPutLabel.TabIndex = 8;
            this.OutPutLabel.Text = "00000000";
            this.OutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(253, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "DP is the first bit";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(361, 9);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Include DP";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Copy data to clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "7/8 segment display toolkit";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(135, 35);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "<none>";
            this.textBox1.TabIndexChanged += new System.EventHandler(this.textBox1_TabIndexChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(201, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Change light color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LightColor
            // 
            this.LightColor.AnyColor = true;
            this.LightColor.Color = System.Drawing.Color.Red;
            this.LightColor.SolidColorOnly = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(311, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Decode a byte";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // decodable
            // 
            this.decodable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.decodable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decodable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decodable.Location = new System.Drawing.Point(128, 3);
            this.decodable.Name = "decodable";
            this.decodable.Size = new System.Drawing.Size(119, 23);
            this.decodable.TabIndex = 18;
            this.decodable.Visible = false;
            this.decodable.TextChanged += new System.EventHandler(this.decodable_TextChanged);
            this.decodable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.decodable_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.OutPutLabel);
            this.flowLayoutPanel1.Controls.Add(this.decodable);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 63);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ink",
            "LED-RGB"});
            this.comboBox1.Location = new System.Drawing.Point(408, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-3, 243);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(555, 98);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 20;
            // 
            // floatSegment
            // 
            this.floatSegment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.floatSegment.BackColor = System.Drawing.Color.DimGray;
            this.floatSegment.BackgroundImage = global::segment_tool.Properties.Resources.segment_point1;
            this.floatSegment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.floatSegment.Location = new System.Drawing.Point(323, 208);
            this.floatSegment.Name = "floatSegment";
            this.floatSegment.Size = new System.Drawing.Size(13, 13);
            this.floatSegment.TabIndex = 9;
            this.floatSegment.TabStop = false;
            this.floatSegment.Click += new System.EventHandler(this.floatSegment_Click);
            // 
            // Segment4
            // 
            this.Segment4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment4.BackColor = System.Drawing.Color.DimGray;
            this.Segment4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Segment4.BackgroundImage")));
            this.Segment4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment4.Location = new System.Drawing.Point(240, 141);
            this.Segment4.Name = "Segment4";
            this.Segment4.Size = new System.Drawing.Size(66, 12);
            this.Segment4.TabIndex = 2;
            this.Segment4.TabStop = false;
            this.Segment4.Click += new System.EventHandler(this.Segment4_Click);
            // 
            // Segment7
            // 
            this.Segment7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment7.BackColor = System.Drawing.Color.DimGray;
            this.Segment7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Segment7.BackgroundImage")));
            this.Segment7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment7.Location = new System.Drawing.Point(240, 211);
            this.Segment7.Name = "Segment7";
            this.Segment7.Size = new System.Drawing.Size(66, 12);
            this.Segment7.TabIndex = 3;
            this.Segment7.TabStop = false;
            this.Segment7.Click += new System.EventHandler(this.Segment7_Click);
            // 
            // Segment6
            // 
            this.Segment6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment6.BackColor = System.Drawing.Color.DimGray;
            this.Segment6.BackgroundImage = global::segment_tool.Properties.Resources.segment_vertical1;
            this.Segment6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment6.Location = new System.Drawing.Point(304, 152);
            this.Segment6.Name = "Segment6";
            this.Segment6.Size = new System.Drawing.Size(12, 66);
            this.Segment6.TabIndex = 7;
            this.Segment6.TabStop = false;
            this.Segment6.Click += new System.EventHandler(this.Segment6_Click);
            // 
            // Segment5
            // 
            this.Segment5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment5.BackColor = System.Drawing.Color.DimGray;
            this.Segment5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Segment5.BackgroundImage")));
            this.Segment5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment5.Location = new System.Drawing.Point(230, 152);
            this.Segment5.Name = "Segment5";
            this.Segment5.Size = new System.Drawing.Size(12, 66);
            this.Segment5.TabIndex = 6;
            this.Segment5.TabStop = false;
            this.Segment5.Click += new System.EventHandler(this.Segment5_Click);
            // 
            // Segment1
            // 
            this.Segment1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment1.BackColor = System.Drawing.Color.DimGray;
            this.Segment1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Segment1.BackgroundImage")));
            this.Segment1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment1.Location = new System.Drawing.Point(240, 72);
            this.Segment1.Name = "Segment1";
            this.Segment1.Size = new System.Drawing.Size(66, 12);
            this.Segment1.TabIndex = 1;
            this.Segment1.TabStop = false;
            this.Segment1.Click += new System.EventHandler(this.Segment1_Click);
            // 
            // Segment3
            // 
            this.Segment3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment3.BackColor = System.Drawing.Color.DimGray;
            this.Segment3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Segment3.BackgroundImage")));
            this.Segment3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment3.Location = new System.Drawing.Point(304, 80);
            this.Segment3.Name = "Segment3";
            this.Segment3.Size = new System.Drawing.Size(12, 66);
            this.Segment3.TabIndex = 5;
            this.Segment3.TabStop = false;
            this.Segment3.Click += new System.EventHandler(this.Segment3_Click);
            // 
            // Segment2
            // 
            this.Segment2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Segment2.BackColor = System.Drawing.Color.DimGray;
            this.Segment2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Segment2.BackgroundImage")));
            this.Segment2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Segment2.Location = new System.Drawing.Point(230, 80);
            this.Segment2.Name = "Segment2";
            this.Segment2.Size = new System.Drawing.Size(12, 66);
            this.Segment2.TabIndex = 4;
            this.Segment2.TabStop = false;
            this.Segment2.Click += new System.EventHandler(this.Segment2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 338);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.floatSegment);
            this.Controls.Add(this.Segment4);
            this.Controls.Add(this.Segment7);
            this.Controls.Add(this.Segment6);
            this.Controls.Add(this.Segment5);
            this.Controls.Add(this.Segment1);
            this.Controls.Add(this.Segment3);
            this.Controls.Add(this.Segment2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(468, 376);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Segment tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floatSegment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Segment2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Segment1;
        private System.Windows.Forms.PictureBox Segment4;
        private System.Windows.Forms.PictureBox Segment7;
        private System.Windows.Forms.PictureBox Segment2;
        private System.Windows.Forms.PictureBox Segment3;
        private System.Windows.Forms.PictureBox Segment6;
        private System.Windows.Forms.PictureBox Segment5;
        private System.Windows.Forms.Timer SegmentChecker;
        private System.Windows.Forms.Label OutPutLabel;
        private System.Windows.Forms.PictureBox floatSegment;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog LightColor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox decodable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

