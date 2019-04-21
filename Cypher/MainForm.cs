using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cypher
{
	public partial class MainForm : Form
	{
		private CypherMode cypherMode;
		private bool encrypt = true;

		public MainForm()
		{
			InitializeComponent();
			nud_Key.Maximum = Int32.MaxValue;
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			p_Left.Size = new Size(p_Upper.Size.Width / 2, p_Left.Size.Height);
		}

		private void Encrypt()
		{
			rtb_CypherText.TextChanged -= rtb_CipherText_TextChanged;
            rtb_CypherText.Text = String.Empty;
			try
			{
				switch (cypherMode)
				{
					case CypherMode.Base64:
						rtb_CypherText.Text = rtb_PlainText.Text.Base64Encode();
						break;
					case CypherMode.Caesar:
						rtb_CypherText.Text = rtb_PlainText.Text.CaesarEncrypt((int)nud_Key.Value);
						break;
					case CypherMode.Des:
                        if (chk_ByteArrayValues.Checked)
                        {
                            var encryptedText = new StringBuilder();
                            var encryptedBytes = Des.DesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(rtb_PlainText.Text)), Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text));
                            foreach (var encryptedByte in encryptedBytes)
                            {
                                encryptedText.AppendFormat("[{0}]", encryptedByte);
                            }
                            rtb_CypherText.Text = encryptedText.ToString();
                        }
                        else
                        {
                            rtb_CypherText.Text = rtb_PlainText.Text.DesEncrypt(tb_Password.Text, tb_IV.Text);
                        }
						break;
					case CypherMode.Rotate:
						rtb_CypherText.Text = rtb_PlainText.Text.RotateEncrypt((int)nud_Key.Value);
						break;
					case CypherMode.TripleDes:
                        if (chk_ByteArrayValues.Checked)
                        {
                            if (chk_KeyAndIVInByteArrayFormat.Checked)
                            {
                            }
                            else
                            {
                                var encryptedText = new StringBuilder();
                                var encryptedBytes = TripleDes.TripleDesEncrypt(Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes(rtb_PlainText.Text)), Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text));
                                foreach (var encryptedByte in encryptedBytes)
                                {
                                    encryptedText.AppendFormat("[{0}]", encryptedByte);
                                }
                                rtb_CypherText.Text = encryptedText.ToString();
                            }
                        }
                        else
                        {
                            if (chk_KeyAndIVInByteArrayFormat.Checked)
                            {
                            }
                            else
                            {
                                rtb_CypherText.Text = rtb_PlainText.Text.TripleDesEncrypt(tb_Password.Text, tb_IV.Text);
                            }
                        }
						break;
					case CypherMode.Xor:
						rtb_CypherText.Text = rtb_PlainText.Text.XorCrypt(tb_Password.Text);
						break;
				}
			}
			catch (Exception ex)
			{
                lbl_Error.Text = ex.Message;
			}
			finally
			{
				rtb_CypherText.TextChanged += rtb_CipherText_TextChanged;
			}
		}

		private void rtb_PlainText_TextChanged(object sender, EventArgs e)
		{
			encrypt = true;
			Encrypt();
			tb_MD5.Text = rtb_PlainText.Text.Md5();
			tb_SHA1.Text = rtb_PlainText.Text.Sha1();
			tb_SHA2.Text = rtb_PlainText.Text.Sha2();
		}

		private void Decrypt()
		{
			rtb_PlainText.TextChanged -= rtb_PlainText_TextChanged;
            rtb_PlainText.Text = String.Empty;
			try
			{
				switch (cypherMode)
				{
					case CypherMode.Base64:
						rtb_PlainText.Text = rtb_CypherText.Text.Base64Decode();
						break;
					case CypherMode.Caesar:
						rtb_PlainText.Text = rtb_CypherText.Text.CaesarDecrypt((int)nud_Key.Value);
						break;
					case CypherMode.Des:
						if (chk_ByteArrayValues.Checked)
						{
							var byteStrings = rtb_CypherText.Text.Replace("[", "").Split(']');
							var bytes = new byte[byteStrings.Length - 1];
                            for (var i = 0; i < bytes.Length; i++)
                            {
                                bytes[i] = Convert.ToByte(byteStrings[i]);
                            }
							rtb_PlainText.Text = Encoding.UTF8.GetString(Des.DesDecrypt(bytes, Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text)));
						}
						else rtb_PlainText.Text = rtb_CypherText.Text.DesDecrypt(tb_Password.Text, tb_IV.Text);
						break;
					case CypherMode.Rotate:
						rtb_PlainText.Text = rtb_CypherText.Text.RotateDecrypt((int)nud_Key.Value);
						break;
					case CypherMode.TripleDes:
						if (chk_ByteArrayValues.Checked)
						{
							var bytes = rtb_CypherText.Text.StringToByteArray();
                            if (chk_KeyAndIVInByteArrayFormat.Checked)
                            {
                                var keyBytes = tb_Password.Text.StringToByteArray();
                                var ivBytes = tb_IV.Text.StringToByteArray();
                                rtb_PlainText.Text = Encoding.UTF8.GetString(TripleDes.TripleDesDecrypt(bytes, keyBytes, ivBytes));
                            }
                            else
                            {
                                rtb_PlainText.Text = Encoding.UTF8.GetString(TripleDes.TripleDesDecrypt(bytes, Encoding.ASCII.GetBytes(tb_Password.Text), Encoding.ASCII.GetBytes(tb_IV.Text)));
                            }
						}
						else
						{
						    if (chk_KeyAndIVInByteArrayFormat.Checked)
						    {
						        var keyBytes = tb_Password.Text.StringToByteArray();
						        var ivBytes = tb_IV.Text.StringToByteArray();
                                rtb_PlainText.Text = rtb_CypherText.Text.TripleDesDecrypt(keyBytes, ivBytes);
						    }
						    else
						    {
                                rtb_PlainText.Text = rtb_CypherText.Text.TripleDesDecrypt(tb_Password.Text, tb_IV.Text);
						    }
						}
						break;
					case CypherMode.Xor:
						rtb_PlainText.Text = rtb_CypherText.Text.XorCrypt(tb_Password.Text);
						break;
				}
			}
			catch (Exception ex)
			{
				rtb_PlainText.Text = ex.Message;
			}
			finally
			{
				rtb_PlainText.TextChanged += rtb_PlainText_TextChanged;
			}
		}

		private void rtb_CipherText_TextChanged(object sender, EventArgs e)
		{
			encrypt = false;
			Decrypt();
			tb_MD5.Text = rtb_CypherText.Text.Md5();
			tb_SHA1.Text = rtb_CypherText.Text.Sha1();
			tb_SHA2.Text = rtb_CypherText.Text.Sha2();
		}

		private void rb_Caesar_CheckedChanged(object sender, EventArgs e)
		{
		    if (rb_Caesar.Checked)
            {
                SetStates(false, false, false, true, false, CypherMode.Caesar);                
            }
        }

		private void rb_Rotate_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Rotate.Checked)
            {
                SetStates(false, false, false, true, false, CypherMode.Rotate);
			}
		}

		private void rb_XOR_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_XOR.Checked)
            {
                SetStates(false, true, false, false, false, CypherMode.Xor);
			}
		}

		private void rb_DES_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_DES.Checked)
            {
                SetStates(false, true, true, false, true, CypherMode.Des);
			}
		}

		private void rb_TripleDES_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_TripleDES.Checked)
			{
                SetStates(true, true, true, false, true, CypherMode.TripleDes);
			}
		}

		private void rb_Base64_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_Base64.Checked)
			{
                SetStates(false, false, false, false, false, CypherMode.Base64);
			}
		}

        private void SetStates(bool keyAndIVInByteArrayFormatEnabled, bool passwordEnabled, bool initializationVectorEnabled, bool keyEnabled, bool byteArrayValuesEnabled, CypherMode currentCypherMode)
        {
            chk_KeyAndIVInByteArrayFormat.Enabled = keyAndIVInByteArrayFormatEnabled;
            tb_Password.Enabled = passwordEnabled;
            tb_IV.Enabled = initializationVectorEnabled;
            nud_Key.Enabled = keyEnabled;
            chk_ByteArrayValues.Enabled = byteArrayValuesEnabled;
            cypherMode = currentCypherMode;
            Changed();
        }

		private void Changed()
		{
            lbl_Error.Text = String.Empty;
		    if (encrypt)
		    {
		        Encrypt();
		    }
		    else
		    {
		        Decrypt();
		    }
		}

		private void EncryptEnvironmentChanged(object sender, EventArgs e)
		{
			Changed();
		}
	}
}
