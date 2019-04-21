namespace Cypher
{
	partial class MainForm
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
			this.p_Main = new System.Windows.Forms.Panel();
			this.p_Upper = new System.Windows.Forms.Panel();
			this.p_Right = new System.Windows.Forms.Panel();
			this.gb_CypherText = new System.Windows.Forms.GroupBox();
			this.rtb_CypherText = new System.Windows.Forms.RichTextBox();
			this.p_Left = new System.Windows.Forms.Panel();
			this.gb_PlainText = new System.Windows.Forms.GroupBox();
			this.rtb_PlainText = new System.Windows.Forms.RichTextBox();
			this.p_Lower = new System.Windows.Forms.Panel();
			this.p_Hash = new System.Windows.Forms.Panel();
			this.gb_Hashes = new System.Windows.Forms.GroupBox();
			this.tb_SHA2 = new System.Windows.Forms.TextBox();
			this.tb_SHA1 = new System.Windows.Forms.TextBox();
			this.tb_MD5 = new System.Windows.Forms.TextBox();
			this.lbl_SHA2 = new System.Windows.Forms.Label();
			this.lbl_SHA1 = new System.Windows.Forms.Label();
			this.lbl_MD5 = new System.Windows.Forms.Label();
			this.p_CypherMethod = new System.Windows.Forms.Panel();
			this.gb_CypherMethod = new System.Windows.Forms.GroupBox();
			this.chk_ByteArrayValues = new System.Windows.Forms.CheckBox();
			this.rb_Base64 = new System.Windows.Forms.RadioButton();
			this.rb_TripleDES = new System.Windows.Forms.RadioButton();
			this.rb_DES = new System.Windows.Forms.RadioButton();
			this.rb_XOR = new System.Windows.Forms.RadioButton();
			this.rb_Rotate = new System.Windows.Forms.RadioButton();
			this.rb_Caesar = new System.Windows.Forms.RadioButton();
            this.lbl_Key = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
			this.nud_Key = new System.Windows.Forms.NumericUpDown();
			this.tb_IV = new System.Windows.Forms.TextBox();
			this.lbl_IV = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.chk_KeyAndIVInByteArrayFormat = new System.Windows.Forms.CheckBox();
			this.p_Main.SuspendLayout();
			this.p_Upper.SuspendLayout();
			this.p_Right.SuspendLayout();
			this.gb_CypherText.SuspendLayout();
			this.p_Left.SuspendLayout();
			this.gb_PlainText.SuspendLayout();
			this.p_Lower.SuspendLayout();
			this.p_Hash.SuspendLayout();
			this.gb_Hashes.SuspendLayout();
			this.p_CypherMethod.SuspendLayout();
			this.gb_CypherMethod.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Key)).BeginInit();
			this.SuspendLayout();
			// 
			// p_Main
			// 
			this.p_Main.Controls.Add(this.p_Upper);
			this.p_Main.Controls.Add(this.p_Lower);
			this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Main.Location = new System.Drawing.Point(0, 0);
			this.p_Main.Name = "p_Main";
			this.p_Main.Size = new System.Drawing.Size(693, 524);
			this.p_Main.TabIndex = 0;
			// 
			// p_Upper
			// 
			this.p_Upper.Controls.Add(this.p_Right);
			this.p_Upper.Controls.Add(this.p_Left);
			this.p_Upper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Upper.Location = new System.Drawing.Point(0, 0);
			this.p_Upper.Name = "p_Upper";
			this.p_Upper.Size = new System.Drawing.Size(693, 266);
			this.p_Upper.TabIndex = 1;
			// 
			// p_Right
			// 
			this.p_Right.Controls.Add(this.gb_CypherText);
			this.p_Right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Right.Location = new System.Drawing.Point(342, 0);
			this.p_Right.Name = "p_Right";
			this.p_Right.Size = new System.Drawing.Size(351, 266);
			this.p_Right.TabIndex = 1;
			// 
			// gb_CypherText
			// 
			this.gb_CypherText.Controls.Add(this.rtb_CypherText);
			this.gb_CypherText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_CypherText.Location = new System.Drawing.Point(0, 0);
			this.gb_CypherText.Name = "gb_CypherText";
			this.gb_CypherText.Size = new System.Drawing.Size(351, 266);
			this.gb_CypherText.TabIndex = 1;
			this.gb_CypherText.TabStop = false;
			this.gb_CypherText.Text = "Cypher text";
			// 
			// rtb_CypherText
			// 
			this.rtb_CypherText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_CypherText.Location = new System.Drawing.Point(3, 16);
			this.rtb_CypherText.Name = "rtb_CypherText";
			this.rtb_CypherText.Size = new System.Drawing.Size(345, 247);
			this.rtb_CypherText.TabIndex = 1;
			this.rtb_CypherText.Text = "";
			this.rtb_CypherText.TextChanged += new System.EventHandler(this.rtb_CipherText_TextChanged);
			// 
			// p_Left
			// 
			this.p_Left.BackColor = System.Drawing.SystemColors.Control;
			this.p_Left.Controls.Add(this.gb_PlainText);
			this.p_Left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_Left.Location = new System.Drawing.Point(0, 0);
			this.p_Left.Name = "p_Left";
			this.p_Left.Size = new System.Drawing.Size(342, 266);
			this.p_Left.TabIndex = 0;
			// 
			// gb_PlainText
			// 
			this.gb_PlainText.Controls.Add(this.rtb_PlainText);
			this.gb_PlainText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_PlainText.Location = new System.Drawing.Point(0, 0);
			this.gb_PlainText.Name = "gb_PlainText";
			this.gb_PlainText.Size = new System.Drawing.Size(342, 266);
			this.gb_PlainText.TabIndex = 0;
			this.gb_PlainText.TabStop = false;
			this.gb_PlainText.Text = "Plain text";
			// 
			// rtb_PlainText
			// 
			this.rtb_PlainText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_PlainText.Location = new System.Drawing.Point(3, 16);
			this.rtb_PlainText.Name = "rtb_PlainText";
			this.rtb_PlainText.Size = new System.Drawing.Size(336, 247);
			this.rtb_PlainText.TabIndex = 0;
			this.rtb_PlainText.Text = "";
			this.rtb_PlainText.TextChanged += new System.EventHandler(this.rtb_PlainText_TextChanged);
			// 
			// p_Lower
			// 
			this.p_Lower.Controls.Add(this.p_Hash);
			this.p_Lower.Controls.Add(this.p_CypherMethod);
			this.p_Lower.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p_Lower.Location = new System.Drawing.Point(0, 266);
			this.p_Lower.Name = "p_Lower";
			this.p_Lower.Size = new System.Drawing.Size(693, 258);
			this.p_Lower.TabIndex = 0;
			// 
			// p_Hash
			// 
			this.p_Hash.Controls.Add(this.gb_Hashes);
			this.p_Hash.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_Hash.Location = new System.Drawing.Point(0, 135);
			this.p_Hash.Name = "p_Hash";
			this.p_Hash.Size = new System.Drawing.Size(693, 123);
			this.p_Hash.TabIndex = 1;
			// 
			// gb_Hashes
			// 
			this.gb_Hashes.Controls.Add(this.tb_SHA2);
			this.gb_Hashes.Controls.Add(this.tb_SHA1);
			this.gb_Hashes.Controls.Add(this.tb_MD5);
			this.gb_Hashes.Controls.Add(this.lbl_SHA2);
			this.gb_Hashes.Controls.Add(this.lbl_SHA1);
			this.gb_Hashes.Controls.Add(this.lbl_MD5);
			this.gb_Hashes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_Hashes.Location = new System.Drawing.Point(0, 0);
			this.gb_Hashes.Name = "gb_Hashes";
			this.gb_Hashes.Size = new System.Drawing.Size(693, 123);
			this.gb_Hashes.TabIndex = 0;
			this.gb_Hashes.TabStop = false;
			this.gb_Hashes.Text = "Hashes";
			// 
			// tb_SHA2
			// 
			this.tb_SHA2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SHA2.Location = new System.Drawing.Point(15, 59);
			this.tb_SHA2.Multiline = true;
			this.tb_SHA2.Name = "tb_SHA2";
			this.tb_SHA2.ReadOnly = true;
			this.tb_SHA2.Size = new System.Drawing.Size(657, 52);
			this.tb_SHA2.TabIndex = 5;
			// 
			// tb_SHA1
			// 
			this.tb_SHA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SHA1.Location = new System.Drawing.Point(398, 13);
			this.tb_SHA1.Name = "tb_SHA1";
			this.tb_SHA1.ReadOnly = true;
			this.tb_SHA1.Size = new System.Drawing.Size(274, 20);
			this.tb_SHA1.TabIndex = 4;
			// 
			// tb_MD5
			// 
			this.tb_MD5.Location = new System.Drawing.Point(59, 13);
			this.tb_MD5.Name = "tb_MD5";
			this.tb_MD5.ReadOnly = true;
			this.tb_MD5.Size = new System.Drawing.Size(262, 20);
			this.tb_MD5.TabIndex = 3;
			// 
			// lbl_SHA2
			// 
			this.lbl_SHA2.AutoSize = true;
			this.lbl_SHA2.Location = new System.Drawing.Point(12, 43);
			this.lbl_SHA2.Name = "lbl_SHA2";
			this.lbl_SHA2.Size = new System.Drawing.Size(38, 13);
			this.lbl_SHA2.TabIndex = 2;
			this.lbl_SHA2.Text = "SHA-2";
			// 
			// lbl_SHA1
			// 
			this.lbl_SHA1.AutoSize = true;
			this.lbl_SHA1.Location = new System.Drawing.Point(354, 16);
			this.lbl_SHA1.Name = "lbl_SHA1";
			this.lbl_SHA1.Size = new System.Drawing.Size(38, 13);
			this.lbl_SHA1.TabIndex = 1;
			this.lbl_SHA1.Text = "SHA-1";
			// 
			// lbl_MD5
			// 
			this.lbl_MD5.AutoSize = true;
			this.lbl_MD5.Location = new System.Drawing.Point(12, 16);
			this.lbl_MD5.Name = "lbl_MD5";
			this.lbl_MD5.Size = new System.Drawing.Size(30, 13);
			this.lbl_MD5.TabIndex = 0;
			this.lbl_MD5.Text = "MD5";
			// 
			// p_CypherMethod
			// 
			this.p_CypherMethod.Controls.Add(this.gb_CypherMethod);
			this.p_CypherMethod.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_CypherMethod.Location = new System.Drawing.Point(0, 0);
			this.p_CypherMethod.Name = "p_CypherMethod";
			this.p_CypherMethod.Size = new System.Drawing.Size(693, 135);
			this.p_CypherMethod.TabIndex = 0;
			// 
			// gb_CypherMethod
			// 
			this.gb_CypherMethod.Controls.Add(this.chk_KeyAndIVInByteArrayFormat);
			this.gb_CypherMethod.Controls.Add(this.chk_ByteArrayValues);
			this.gb_CypherMethod.Controls.Add(this.rb_Base64);
			this.gb_CypherMethod.Controls.Add(this.rb_TripleDES);
			this.gb_CypherMethod.Controls.Add(this.rb_DES);
			this.gb_CypherMethod.Controls.Add(this.rb_XOR);
			this.gb_CypherMethod.Controls.Add(this.rb_Rotate);
			this.gb_CypherMethod.Controls.Add(this.rb_Caesar);
			this.gb_CypherMethod.Controls.Add(this.lbl_Key);
            this.gb_CypherMethod.Controls.Add(this.lbl_Error);
			this.gb_CypherMethod.Controls.Add(this.nud_Key);
			this.gb_CypherMethod.Controls.Add(this.tb_IV);
			this.gb_CypherMethod.Controls.Add(this.lbl_IV);
			this.gb_CypherMethod.Controls.Add(this.tb_Password);
			this.gb_CypherMethod.Controls.Add(this.lbl_Password);
			this.gb_CypherMethod.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_CypherMethod.Location = new System.Drawing.Point(0, 0);
			this.gb_CypherMethod.Name = "gb_CypherMethod";
			this.gb_CypherMethod.Size = new System.Drawing.Size(693, 135);
			this.gb_CypherMethod.TabIndex = 1;
			this.gb_CypherMethod.TabStop = false;
			this.gb_CypherMethod.Text = "Chiper method";
			// 
			// chk_ByteArrayValues
			// 
			this.chk_ByteArrayValues.AutoSize = true;
			this.chk_ByteArrayValues.Location = new System.Drawing.Point(520, 81);
			this.chk_ByteArrayValues.Name = "chk_ByteArrayValues";
			this.chk_ByteArrayValues.Size = new System.Drawing.Size(107, 17);
			this.chk_ByteArrayValues.TabIndex = 12;
			this.chk_ByteArrayValues.Text = "Byte array values";
			this.chk_ByteArrayValues.UseVisualStyleBackColor = true;
			this.chk_ByteArrayValues.CheckedChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// rb_Base64
			// 
			this.rb_Base64.AutoSize = true;
			this.rb_Base64.Location = new System.Drawing.Point(15, 80);
			this.rb_Base64.Name = "rb_Base64";
			this.rb_Base64.Size = new System.Drawing.Size(61, 17);
			this.rb_Base64.TabIndex = 11;
			this.rb_Base64.Text = "Base64";
			this.rb_Base64.UseVisualStyleBackColor = true;
			this.rb_Base64.CheckedChanged += new System.EventHandler(this.rb_Base64_CheckedChanged);
            this.rb_Base64.Checked = true;
			// 
			// rb_TripleDES
			// 
			this.rb_TripleDES.AutoSize = true;
			this.rb_TripleDES.Location = new System.Drawing.Point(398, 80);
			this.rb_TripleDES.Name = "rb_TripleDES";
			this.rb_TripleDES.Size = new System.Drawing.Size(76, 17);
			this.rb_TripleDES.TabIndex = 10;
			this.rb_TripleDES.Text = "Triple DES";
			this.rb_TripleDES.UseVisualStyleBackColor = true;
			this.rb_TripleDES.CheckedChanged += new System.EventHandler(this.rb_TripleDES_CheckedChanged);
			// 
			// rb_DES
			// 
			this.rb_DES.AutoSize = true;
			this.rb_DES.Location = new System.Drawing.Point(398, 48);
			this.rb_DES.Name = "rb_DES";
			this.rb_DES.Size = new System.Drawing.Size(47, 17);
			this.rb_DES.TabIndex = 9;
			this.rb_DES.Text = "DES";
			this.rb_DES.UseVisualStyleBackColor = true;
			this.rb_DES.CheckedChanged += new System.EventHandler(this.rb_DES_CheckedChanged);
			// 
			// rb_XOR
			// 
			this.rb_XOR.AutoSize = true;
			this.rb_XOR.Location = new System.Drawing.Point(264, 48);
			this.rb_XOR.Name = "rb_XOR";
			this.rb_XOR.Size = new System.Drawing.Size(48, 17);
			this.rb_XOR.TabIndex = 8;
			this.rb_XOR.Text = "XOR";
			this.rb_XOR.UseVisualStyleBackColor = true;
			this.rb_XOR.CheckedChanged += new System.EventHandler(this.rb_XOR_CheckedChanged);
			// 
			// rb_Rotate
			// 
			this.rb_Rotate.AutoSize = true;
			this.rb_Rotate.Location = new System.Drawing.Point(139, 48);
			this.rb_Rotate.Name = "rb_Rotate";
			this.rb_Rotate.Size = new System.Drawing.Size(57, 17);
			this.rb_Rotate.TabIndex = 7;
			this.rb_Rotate.Text = "Rotate";
			this.rb_Rotate.UseVisualStyleBackColor = true;
			this.rb_Rotate.CheckedChanged += new System.EventHandler(this.rb_Rotate_CheckedChanged);
			// 
			// rb_Caesar
			// 
			this.rb_Caesar.AutoSize = true;
			this.rb_Caesar.Location = new System.Drawing.Point(15, 48);
			this.rb_Caesar.Name = "rb_Caesar";
			this.rb_Caesar.Size = new System.Drawing.Size(58, 17);
			this.rb_Caesar.TabIndex = 6;
			this.rb_Caesar.Text = "Caesar";
			this.rb_Caesar.UseVisualStyleBackColor = true;
			this.rb_Caesar.CheckedChanged += new System.EventHandler(this.rb_Caesar_CheckedChanged);
            // 
            // lbl_Key
            // 
            this.lbl_Key.AutoSize = true;
            this.lbl_Key.Location = new System.Drawing.Point(545, 25);
            this.lbl_Key.Name = "lbl_Key";
            this.lbl_Key.Size = new System.Drawing.Size(25, 13);
            this.lbl_Key.TabIndex = 5;
            this.lbl_Key.Text = "Key";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(12, 104);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(25, 13);
            this.lbl_Error.TabIndex = 5;
            this.lbl_Error.Text = "";
            this.lbl_Error.ForeColor = System.Drawing.Color.IndianRed;
			// 
			// nud_Key
			// 
			this.nud_Key.Location = new System.Drawing.Point(576, 22);
			this.nud_Key.Name = "nud_Key";
			this.nud_Key.Size = new System.Drawing.Size(99, 20);
			this.nud_Key.TabIndex = 4;
			this.nud_Key.ValueChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// tb_IV
			// 
			this.tb_IV.Location = new System.Drawing.Point(368, 22);
			this.tb_IV.Name = "tb_IV";
			this.tb_IV.Size = new System.Drawing.Size(171, 20);
			this.tb_IV.TabIndex = 3;
			this.tb_IV.TextChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// lbl_IV
			// 
			this.lbl_IV.AutoSize = true;
			this.lbl_IV.Location = new System.Drawing.Point(342, 25);
			this.lbl_IV.Name = "lbl_IV";
			this.lbl_IV.Size = new System.Drawing.Size(17, 13);
			this.lbl_IV.TabIndex = 2;
			this.lbl_IV.Text = "IV";
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(71, 22);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.Size = new System.Drawing.Size(268, 20);
			this.tb_Password.TabIndex = 1;
			this.tb_Password.TextChanged += new System.EventHandler(this.EncryptEnvironmentChanged);
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(12, 25);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(53, 13);
			this.lbl_Password.TabIndex = 0;
			this.lbl_Password.Text = "Password";
			// 
			// chk_KeyAndIVInByteArrayFormat
			// 
			this.chk_KeyAndIVInByteArrayFormat.AutoSize = true;
			this.chk_KeyAndIVInByteArrayFormat.Location = new System.Drawing.Point(520, 104);
			this.chk_KeyAndIVInByteArrayFormat.Name = "chk_KeyAndIVInByteArrayFormat";
			this.chk_KeyAndIVInByteArrayFormat.Size = new System.Drawing.Size(170, 17);
			this.chk_KeyAndIVInByteArrayFormat.TabIndex = 15;
			this.chk_KeyAndIVInByteArrayFormat.Text = "Key and IV in byte array format";
			this.chk_KeyAndIVInByteArrayFormat.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 524);
			this.Controls.Add(this.p_Main);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cypher";
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.ResizeEnd += new System.EventHandler(this.MainForm_Resize);
			this.p_Main.ResumeLayout(false);
			this.p_Upper.ResumeLayout(false);
			this.p_Right.ResumeLayout(false);
			this.gb_CypherText.ResumeLayout(false);
			this.p_Left.ResumeLayout(false);
			this.gb_PlainText.ResumeLayout(false);
			this.p_Lower.ResumeLayout(false);
			this.p_Hash.ResumeLayout(false);
			this.gb_Hashes.ResumeLayout(false);
			this.gb_Hashes.PerformLayout();
			this.p_CypherMethod.ResumeLayout(false);
			this.gb_CypherMethod.ResumeLayout(false);
			this.gb_CypherMethod.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Key)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel p_Main;
		private System.Windows.Forms.Panel p_Upper;
		private System.Windows.Forms.Panel p_Lower;
		private System.Windows.Forms.Panel p_Right;
		private System.Windows.Forms.Panel p_Left;
		private System.Windows.Forms.GroupBox gb_CypherText;
		private System.Windows.Forms.GroupBox gb_PlainText;
		private System.Windows.Forms.RichTextBox rtb_CypherText;
		private System.Windows.Forms.RichTextBox rtb_PlainText;
		private System.Windows.Forms.Panel p_CypherMethod;
		private System.Windows.Forms.Panel p_Hash;
		private System.Windows.Forms.GroupBox gb_Hashes;
		private System.Windows.Forms.GroupBox gb_CypherMethod;
		private System.Windows.Forms.Label lbl_MD5;
		private System.Windows.Forms.Label lbl_SHA1;
		private System.Windows.Forms.Label lbl_SHA2;
		private System.Windows.Forms.TextBox tb_SHA2;
		private System.Windows.Forms.TextBox tb_SHA1;
		private System.Windows.Forms.TextBox tb_MD5;
        private System.Windows.Forms.Label lbl_Key;
        private System.Windows.Forms.Label lbl_Error;
		private System.Windows.Forms.NumericUpDown nud_Key;
		private System.Windows.Forms.TextBox tb_IV;
		private System.Windows.Forms.Label lbl_IV;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.RadioButton rb_Caesar;
		private System.Windows.Forms.RadioButton rb_Rotate;
		private System.Windows.Forms.RadioButton rb_TripleDES;
		private System.Windows.Forms.RadioButton rb_DES;
		private System.Windows.Forms.RadioButton rb_XOR;
		private System.Windows.Forms.RadioButton rb_Base64;
		private System.Windows.Forms.CheckBox chk_ByteArrayValues;
		private System.Windows.Forms.CheckBox chk_KeyAndIVInByteArrayFormat;
	}
}

