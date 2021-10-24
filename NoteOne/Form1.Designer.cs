namespace NoteOne
{
    partial class NoteOne
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
            this.fontSizeSlct = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.boldBtn = new System.Windows.Forms.Button();
            this.italicBtn = new System.Windows.Forms.Button();
            this.submissionBox = new System.Windows.Forms.RichTextBox();
            this.fontLbl = new System.Windows.Forms.Label();
            this.wrd_cnt = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.save_drctry_txt = new System.Windows.Forms.TextBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.cntr_btn = new System.Windows.Forms.Button();
            this.ln_cnt = new System.Windows.Forms.Label();
            this.stng_btn = new System.Windows.Forms.Button();
            this.wndw_clr_slctr = new System.Windows.Forms.ComboBox();
            this.wndw_clr_lbl = new System.Windows.Forms.Label();
            this.undrln_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fontSizeSlct
            // 
            this.fontSizeSlct.AllowDrop = true;
            this.fontSizeSlct.FormattingEnabled = true;
            this.fontSizeSlct.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8",
            "16",
            "32"});
            this.fontSizeSlct.Location = new System.Drawing.Point(99, 54);
            this.fontSizeSlct.Margin = new System.Windows.Forms.Padding(4);
            this.fontSizeSlct.Name = "fontSizeSlct";
            this.fontSizeSlct.Size = new System.Drawing.Size(160, 24);
            this.fontSizeSlct.TabIndex = 1;
            this.fontSizeSlct.SelectedIndexChanged += new System.EventHandler(this.fontSizeSlct_SelectedIndexChanged);
            this.fontSizeSlct.TextChanged += new System.EventHandler(this.fontSizeSlct_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(268, 54);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // boldBtn
            // 
            this.boldBtn.Location = new System.Drawing.Point(1235, 54);
            this.boldBtn.Margin = new System.Windows.Forms.Padding(4);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(100, 28);
            this.boldBtn.TabIndex = 3;
            this.boldBtn.Text = "Bold";
            this.boldBtn.UseVisualStyleBackColor = true;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.Location = new System.Drawing.Point(1127, 54);
            this.italicBtn.Margin = new System.Windows.Forms.Padding(4);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(100, 28);
            this.italicBtn.TabIndex = 4;
            this.italicBtn.Text = "Italic";
            this.italicBtn.UseVisualStyleBackColor = true;
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // submissionBox
            // 
            this.submissionBox.AcceptsTab = true;
            this.submissionBox.EnableAutoDragDrop = true;
            this.submissionBox.Location = new System.Drawing.Point(97, 119);
            this.submissionBox.Margin = new System.Windows.Forms.Padding(4);
            this.submissionBox.Name = "submissionBox";
            this.submissionBox.Size = new System.Drawing.Size(1345, 726);
            this.submissionBox.TabIndex = 5;
            this.submissionBox.Text = "";
            this.submissionBox.TextChanged += new System.EventHandler(this.submissionBox_TextChanged);
            // 
            // fontLbl
            // 
            this.fontLbl.AutoSize = true;
            this.fontLbl.Location = new System.Drawing.Point(95, 34);
            this.fontLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fontLbl.Name = "fontLbl";
            this.fontLbl.Size = new System.Drawing.Size(67, 17);
            this.fontLbl.TabIndex = 6;
            this.fontLbl.Text = "Font Size";
            // 
            // wrd_cnt
            // 
            this.wrd_cnt.AutoSize = true;
            this.wrd_cnt.Location = new System.Drawing.Point(96, 885);
            this.wrd_cnt.Name = "wrd_cnt";
            this.wrd_cnt.Size = new System.Drawing.Size(81, 17);
            this.wrd_cnt.TabIndex = 7;
            this.wrd_cnt.Text = "word_count";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(1026, 882);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(100, 33);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // save_drctry_txt
            // 
            this.save_drctry_txt.Location = new System.Drawing.Point(1133, 882);
            this.save_drctry_txt.Multiline = true;
            this.save_drctry_txt.Name = "save_drctry_txt";
            this.save_drctry_txt.Size = new System.Drawing.Size(309, 33);
            this.save_drctry_txt.TabIndex = 9;
            this.save_drctry_txt.Visible = false;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(928, 882);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(92, 33);
            this.open_btn.TabIndex = 10;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // cntr_btn
            // 
            this.cntr_btn.Location = new System.Drawing.Point(914, 54);
            this.cntr_btn.Name = "cntr_btn";
            this.cntr_btn.Size = new System.Drawing.Size(100, 28);
            this.cntr_btn.TabIndex = 11;
            this.cntr_btn.Text = "Centre";
            this.cntr_btn.UseVisualStyleBackColor = true;
            this.cntr_btn.Click += new System.EventHandler(this.cntr_btn_Click);
            // 
            // ln_cnt
            // 
            this.ln_cnt.AutoSize = true;
            this.ln_cnt.Location = new System.Drawing.Point(240, 885);
            this.ln_cnt.Name = "ln_cnt";
            this.ln_cnt.Size = new System.Drawing.Size(73, 17);
            this.ln_cnt.TabIndex = 12;
            this.ln_cnt.Text = "line_count";
            this.ln_cnt.Visible = false;
            // 
            // stng_btn
            // 
            this.stng_btn.Location = new System.Drawing.Point(1342, 54);
            this.stng_btn.Name = "stng_btn";
            this.stng_btn.Size = new System.Drawing.Size(100, 28);
            this.stng_btn.TabIndex = 13;
            this.stng_btn.Text = "Settings";
            this.stng_btn.UseVisualStyleBackColor = true;
            this.stng_btn.Click += new System.EventHandler(this.stng_btn_Click);
            // 
            // wndw_clr_slctr
            // 
            this.wndw_clr_slctr.FormattingEnabled = true;
            this.wndw_clr_slctr.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Pink",
            "Purple",
            "Orange",
            "Gray"});
            this.wndw_clr_slctr.Location = new System.Drawing.Point(118, 172);
            this.wndw_clr_slctr.Name = "wndw_clr_slctr";
            this.wndw_clr_slctr.Size = new System.Drawing.Size(121, 24);
            this.wndw_clr_slctr.TabIndex = 14;
            this.wndw_clr_slctr.Visible = false;
            this.wndw_clr_slctr.SelectedIndexChanged += new System.EventHandler(this.wndw_clr_slctr_SelectedIndexChanged);
            // 
            // wndw_clr_lbl
            // 
            this.wndw_clr_lbl.AutoSize = true;
            this.wndw_clr_lbl.Location = new System.Drawing.Point(118, 149);
            this.wndw_clr_lbl.Name = "wndw_clr_lbl";
            this.wndw_clr_lbl.Size = new System.Drawing.Size(102, 17);
            this.wndw_clr_lbl.TabIndex = 15;
            this.wndw_clr_lbl.Text = "Window Colour";
            this.wndw_clr_lbl.Visible = false;
            // 
            // undrln_btn
            // 
            this.undrln_btn.Location = new System.Drawing.Point(1020, 54);
            this.undrln_btn.Name = "undrln_btn";
            this.undrln_btn.Size = new System.Drawing.Size(100, 28);
            this.undrln_btn.TabIndex = 16;
            this.undrln_btn.Text = "Underline";
            this.undrln_btn.UseVisualStyleBackColor = true;
            this.undrln_btn.Click += new System.EventHandler(this.Underline_Click);
            // 
            // NoteOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1555, 981);
            this.Controls.Add(this.undrln_btn);
            this.Controls.Add(this.wndw_clr_lbl);
            this.Controls.Add(this.wndw_clr_slctr);
            this.Controls.Add(this.stng_btn);
            this.Controls.Add(this.ln_cnt);
            this.Controls.Add(this.cntr_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.save_drctry_txt);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.wrd_cnt);
            this.Controls.Add(this.fontLbl);
            this.Controls.Add(this.submissionBox);
            this.Controls.Add(this.italicBtn);
            this.Controls.Add(this.boldBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.fontSizeSlct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NoteOne";
            this.Text = "Note One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox fontSizeSlct;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button italicBtn;
        private System.Windows.Forms.RichTextBox submissionBox;
        private System.Windows.Forms.Label fontLbl;
        private System.Windows.Forms.Label wrd_cnt;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox save_drctry_txt;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button cntr_btn;
        private System.Windows.Forms.Label ln_cnt;
        private System.Windows.Forms.Button stng_btn;
        private System.Windows.Forms.ComboBox wndw_clr_slctr;
        private System.Windows.Forms.Label wndw_clr_lbl;
        private System.Windows.Forms.Button undrln_btn;
    }
}

