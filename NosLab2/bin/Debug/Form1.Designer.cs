namespace NosLab2
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
            this.ButtonAES = new System.Windows.Forms.Button();
            this.Button3DES = new System.Windows.Forms.Button();
            this.ButtonRSA = new System.Windows.Forms.Button();
            this.KeySize1 = new System.Windows.Forms.Label();
            this.RadioAesKey128 = new System.Windows.Forms.RadioButton();
            this.RadioAesKey192 = new System.Windows.Forms.RadioButton();
            this.RadioAesKey256 = new System.Windows.Forms.RadioButton();
            this.RadioDesKey192 = new System.Windows.Forms.RadioButton();
            this.RadioDesKey128 = new System.Windows.Forms.RadioButton();
            this.KeySize2 = new System.Windows.Forms.Label();
            this.RadioRsaKey3072 = new System.Windows.Forms.RadioButton();
            this.RadioRsaKey2048 = new System.Windows.Forms.RadioButton();
            this.RadioRsaKey1024 = new System.Windows.Forms.RadioButton();
            this.KeySize3 = new System.Windows.Forms.Label();
            this.RadioModeCFB = new System.Windows.Forms.RadioButton();
            this.RadioModeECB = new System.Windows.Forms.RadioButton();
            this.RadioModeCBC = new System.Windows.Forms.RadioButton();
            this.LabelMode = new System.Windows.Forms.Label();
            this.groupBoxAES = new System.Windows.Forms.GroupBox();
            this.groupBox3DES = new System.Windows.Forms.GroupBox();
            this.groupBoxRSA = new System.Windows.Forms.GroupBox();
            this.TextBoxMsgToEncrypt = new System.Windows.Forms.TextBox();
            this.LabelMsgToEncrypt = new System.Windows.Forms.Label();
            this.LabelSymKey = new System.Windows.Forms.Label();
            this.SymKeyValue = new System.Windows.Forms.Label();
            this.ButtonGenSymKey = new System.Windows.Forms.Button();
            this.LabelAlgToUse = new System.Windows.Forms.Label();
            this.LabelSymAlgToUseValue = new System.Windows.Forms.Label();
            this.LabelAsymAlgToUseValue = new System.Windows.Forms.Label();
            this.LabelEncryptedMsg = new System.Windows.Forms.Label();
            this.TextBoxEncryptedMsg = new System.Windows.Forms.TextBox();
            this.ButtonEncryptMsg = new System.Windows.Forms.Button();
            this.TextBoxDecryptedMsg = new System.Windows.Forms.TextBox();
            this.LabelDecryptedMsg = new System.Windows.Forms.Label();
            this.ButtonDecryptMsg = new System.Windows.Forms.Button();
            this.LabelMode2 = new System.Windows.Forms.Label();
            this.LabelModeValue = new System.Windows.Forms.Label();
            this.TextBoxEncryptedKey = new System.Windows.Forms.TextBox();
            this.LabelEncryptedKey = new System.Windows.Forms.Label();
            this.TextBoxDecryptedKey = new System.Windows.Forms.TextBox();
            this.LabelDecryptedKey = new System.Windows.Forms.Label();
            this.ButtonGenerateEnvelope = new System.Windows.Forms.Button();
            this.LabelEnvelope = new System.Windows.Forms.Label();
            this.TextBoxEnvelope = new System.Windows.Forms.TextBox();
            this.LabelDecryptedEnvelope = new System.Windows.Forms.Label();
            this.TextBoxDecryptedEnvelope = new System.Windows.Forms.TextBox();
            this.ButtonDecryptEnvelope = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioHashSHA512 = new System.Windows.Forms.RadioButton();
            this.LabelHash = new System.Windows.Forms.Label();
            this.RadioHashSHA1 = new System.Windows.Forms.RadioButton();
            this.RadioHashSHA256 = new System.Windows.Forms.RadioButton();
            this.RadioHashSHA384 = new System.Windows.Forms.RadioButton();
            this.TextBoxHash = new System.Windows.Forms.TextBox();
            this.ButtonHash = new System.Windows.Forms.Button();
            this.LabelSignature = new System.Windows.Forms.Label();
            this.TextBoxSignature = new System.Windows.Forms.TextBox();
            this.ButtonGenerateSignature = new System.Windows.Forms.Button();
            this.ButtonCheckSignature = new System.Windows.Forms.Button();
            this.LabelSeal = new System.Windows.Forms.Label();
            this.TextBoxSeal = new System.Windows.Forms.TextBox();
            this.ButtonGenerateSeal = new System.Windows.Forms.Button();
            this.ButtonCheckSeal = new System.Windows.Forms.Button();
            this.LabelSignatureCheck = new System.Windows.Forms.Label();
            this.LabelSealCheck = new System.Windows.Forms.Label();
            this.LabelSealCheckMsg = new System.Windows.Forms.Label();
            this.LabelSealCheckKey = new System.Windows.Forms.Label();
            this.groupBoxAES.SuspendLayout();
            this.groupBox3DES.SuspendLayout();
            this.groupBoxRSA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAES
            // 
            this.ButtonAES.Location = new System.Drawing.Point(26, 13);
            this.ButtonAES.Name = "ButtonAES";
            this.ButtonAES.Size = new System.Drawing.Size(75, 23);
            this.ButtonAES.TabIndex = 0;
            this.ButtonAES.Text = "AES";
            this.ButtonAES.UseVisualStyleBackColor = true;
            this.ButtonAES.Click += new System.EventHandler(this.ButtonAES_Click);
            // 
            // Button3DES
            // 
            this.Button3DES.Location = new System.Drawing.Point(147, 12);
            this.Button3DES.Name = "Button3DES";
            this.Button3DES.Size = new System.Drawing.Size(75, 23);
            this.Button3DES.TabIndex = 1;
            this.Button3DES.Text = "3DES";
            this.Button3DES.UseVisualStyleBackColor = true;
            this.Button3DES.Click += new System.EventHandler(this.Button3DES_Click);
            // 
            // ButtonRSA
            // 
            this.ButtonRSA.Location = new System.Drawing.Point(288, 11);
            this.ButtonRSA.Name = "ButtonRSA";
            this.ButtonRSA.Size = new System.Drawing.Size(75, 23);
            this.ButtonRSA.TabIndex = 2;
            this.ButtonRSA.Text = "RSA";
            this.ButtonRSA.UseVisualStyleBackColor = true;
            this.ButtonRSA.Click += new System.EventHandler(this.ButtonRSA_Click);
            // 
            // KeySize1
            // 
            this.KeySize1.AutoSize = true;
            this.KeySize1.Location = new System.Drawing.Point(6, 16);
            this.KeySize1.Name = "KeySize1";
            this.KeySize1.Size = new System.Drawing.Size(49, 13);
            this.KeySize1.TabIndex = 5;
            this.KeySize1.Text = "Key size:";
            // 
            // RadioAesKey128
            // 
            this.RadioAesKey128.AutoSize = true;
            this.RadioAesKey128.Location = new System.Drawing.Point(21, 31);
            this.RadioAesKey128.Name = "RadioAesKey128";
            this.RadioAesKey128.Size = new System.Drawing.Size(43, 17);
            this.RadioAesKey128.TabIndex = 6;
            this.RadioAesKey128.TabStop = true;
            this.RadioAesKey128.Text = "128";
            this.RadioAesKey128.UseVisualStyleBackColor = true;
            // 
            // RadioAesKey192
            // 
            this.RadioAesKey192.AutoSize = true;
            this.RadioAesKey192.Checked = true;
            this.RadioAesKey192.Location = new System.Drawing.Point(21, 55);
            this.RadioAesKey192.Name = "RadioAesKey192";
            this.RadioAesKey192.Size = new System.Drawing.Size(43, 17);
            this.RadioAesKey192.TabIndex = 7;
            this.RadioAesKey192.TabStop = true;
            this.RadioAesKey192.Text = "192";
            this.RadioAesKey192.UseVisualStyleBackColor = true;
            // 
            // RadioAesKey256
            // 
            this.RadioAesKey256.AutoSize = true;
            this.RadioAesKey256.Location = new System.Drawing.Point(21, 79);
            this.RadioAesKey256.Name = "RadioAesKey256";
            this.RadioAesKey256.Size = new System.Drawing.Size(43, 17);
            this.RadioAesKey256.TabIndex = 8;
            this.RadioAesKey256.TabStop = true;
            this.RadioAesKey256.Text = "256";
            this.RadioAesKey256.UseVisualStyleBackColor = true;
            // 
            // RadioDesKey192
            // 
            this.RadioDesKey192.AutoSize = true;
            this.RadioDesKey192.Checked = true;
            this.RadioDesKey192.Location = new System.Drawing.Point(21, 55);
            this.RadioDesKey192.Name = "RadioDesKey192";
            this.RadioDesKey192.Size = new System.Drawing.Size(43, 17);
            this.RadioDesKey192.TabIndex = 12;
            this.RadioDesKey192.TabStop = true;
            this.RadioDesKey192.Text = "192";
            this.RadioDesKey192.UseVisualStyleBackColor = true;
            // 
            // RadioDesKey128
            // 
            this.RadioDesKey128.AutoSize = true;
            this.RadioDesKey128.Location = new System.Drawing.Point(21, 32);
            this.RadioDesKey128.Name = "RadioDesKey128";
            this.RadioDesKey128.Size = new System.Drawing.Size(43, 17);
            this.RadioDesKey128.TabIndex = 11;
            this.RadioDesKey128.TabStop = true;
            this.RadioDesKey128.Text = "128";
            this.RadioDesKey128.UseVisualStyleBackColor = true;
            // 
            // KeySize2
            // 
            this.KeySize2.AutoSize = true;
            this.KeySize2.Location = new System.Drawing.Point(6, 16);
            this.KeySize2.Name = "KeySize2";
            this.KeySize2.Size = new System.Drawing.Size(49, 13);
            this.KeySize2.TabIndex = 9;
            this.KeySize2.Text = "Key size:";
            // 
            // RadioRsaKey3072
            // 
            this.RadioRsaKey3072.AutoSize = true;
            this.RadioRsaKey3072.Location = new System.Drawing.Point(21, 79);
            this.RadioRsaKey3072.Name = "RadioRsaKey3072";
            this.RadioRsaKey3072.Size = new System.Drawing.Size(49, 17);
            this.RadioRsaKey3072.TabIndex = 16;
            this.RadioRsaKey3072.TabStop = true;
            this.RadioRsaKey3072.Text = "3072";
            this.RadioRsaKey3072.UseVisualStyleBackColor = true;
            // 
            // RadioRsaKey2048
            // 
            this.RadioRsaKey2048.AutoSize = true;
            this.RadioRsaKey2048.Checked = true;
            this.RadioRsaKey2048.Location = new System.Drawing.Point(21, 55);
            this.RadioRsaKey2048.Name = "RadioRsaKey2048";
            this.RadioRsaKey2048.Size = new System.Drawing.Size(49, 17);
            this.RadioRsaKey2048.TabIndex = 15;
            this.RadioRsaKey2048.TabStop = true;
            this.RadioRsaKey2048.Text = "2048";
            this.RadioRsaKey2048.UseVisualStyleBackColor = true;
            // 
            // RadioRsaKey1024
            // 
            this.RadioRsaKey1024.AutoSize = true;
            this.RadioRsaKey1024.Location = new System.Drawing.Point(21, 31);
            this.RadioRsaKey1024.Name = "RadioRsaKey1024";
            this.RadioRsaKey1024.Size = new System.Drawing.Size(49, 17);
            this.RadioRsaKey1024.TabIndex = 14;
            this.RadioRsaKey1024.TabStop = true;
            this.RadioRsaKey1024.Text = "1024";
            this.RadioRsaKey1024.UseVisualStyleBackColor = true;
            // 
            // KeySize3
            // 
            this.KeySize3.AutoSize = true;
            this.KeySize3.Location = new System.Drawing.Point(6, 16);
            this.KeySize3.Name = "KeySize3";
            this.KeySize3.Size = new System.Drawing.Size(49, 13);
            this.KeySize3.TabIndex = 13;
            this.KeySize3.Text = "Key size:";
            // 
            // RadioModeCFB
            // 
            this.RadioModeCFB.AutoSize = true;
            this.RadioModeCFB.Location = new System.Drawing.Point(663, 106);
            this.RadioModeCFB.Name = "RadioModeCFB";
            this.RadioModeCFB.Size = new System.Drawing.Size(45, 17);
            this.RadioModeCFB.TabIndex = 20;
            this.RadioModeCFB.Text = "CFB";
            this.RadioModeCFB.UseVisualStyleBackColor = true;
            // 
            // RadioModeECB
            // 
            this.RadioModeECB.AutoSize = true;
            this.RadioModeECB.Checked = true;
            this.RadioModeECB.Location = new System.Drawing.Point(663, 82);
            this.RadioModeECB.Name = "RadioModeECB";
            this.RadioModeECB.Size = new System.Drawing.Size(46, 17);
            this.RadioModeECB.TabIndex = 19;
            this.RadioModeECB.TabStop = true;
            this.RadioModeECB.Text = "ECB";
            this.RadioModeECB.UseVisualStyleBackColor = true;
            // 
            // RadioModeCBC
            // 
            this.RadioModeCBC.AutoSize = true;
            this.RadioModeCBC.Location = new System.Drawing.Point(663, 58);
            this.RadioModeCBC.Name = "RadioModeCBC";
            this.RadioModeCBC.Size = new System.Drawing.Size(46, 17);
            this.RadioModeCBC.TabIndex = 18;
            this.RadioModeCBC.Text = "CBC";
            this.RadioModeCBC.UseVisualStyleBackColor = true;
            // 
            // LabelMode
            // 
            this.LabelMode.AutoSize = true;
            this.LabelMode.Location = new System.Drawing.Point(648, 43);
            this.LabelMode.Name = "LabelMode";
            this.LabelMode.Size = new System.Drawing.Size(34, 13);
            this.LabelMode.TabIndex = 17;
            this.LabelMode.Text = "Mode";
            // 
            // groupBoxAES
            // 
            this.groupBoxAES.Controls.Add(this.KeySize1);
            this.groupBoxAES.Controls.Add(this.RadioAesKey128);
            this.groupBoxAES.Controls.Add(this.RadioAesKey192);
            this.groupBoxAES.Controls.Add(this.RadioAesKey256);
            this.groupBoxAES.Location = new System.Drawing.Point(26, 43);
            this.groupBoxAES.Name = "groupBoxAES";
            this.groupBoxAES.Size = new System.Drawing.Size(84, 100);
            this.groupBoxAES.TabIndex = 21;
            this.groupBoxAES.TabStop = false;
            // 
            // groupBox3DES
            // 
            this.groupBox3DES.Controls.Add(this.KeySize2);
            this.groupBox3DES.Controls.Add(this.RadioDesKey128);
            this.groupBox3DES.Controls.Add(this.RadioDesKey192);
            this.groupBox3DES.Location = new System.Drawing.Point(147, 43);
            this.groupBox3DES.Name = "groupBox3DES";
            this.groupBox3DES.Size = new System.Drawing.Size(84, 100);
            this.groupBox3DES.TabIndex = 22;
            this.groupBox3DES.TabStop = false;
            // 
            // groupBoxRSA
            // 
            this.groupBoxRSA.Controls.Add(this.KeySize3);
            this.groupBoxRSA.Controls.Add(this.RadioRsaKey1024);
            this.groupBoxRSA.Controls.Add(this.RadioRsaKey2048);
            this.groupBoxRSA.Controls.Add(this.RadioRsaKey3072);
            this.groupBoxRSA.Location = new System.Drawing.Point(288, 43);
            this.groupBoxRSA.Name = "groupBoxRSA";
            this.groupBoxRSA.Size = new System.Drawing.Size(84, 100);
            this.groupBoxRSA.TabIndex = 23;
            this.groupBoxRSA.TabStop = false;
            // 
            // TextBoxMsgToEncrypt
            // 
            this.TextBoxMsgToEncrypt.Location = new System.Drawing.Point(26, 194);
            this.TextBoxMsgToEncrypt.Multiline = true;
            this.TextBoxMsgToEncrypt.Name = "TextBoxMsgToEncrypt";
            this.TextBoxMsgToEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMsgToEncrypt.Size = new System.Drawing.Size(245, 71);
            this.TextBoxMsgToEncrypt.TabIndex = 24;
            this.TextBoxMsgToEncrypt.TextChanged += new System.EventHandler(this.TextBoxMsgToEncrypt_TextChanged);
            // 
            // LabelMsgToEncrypt
            // 
            this.LabelMsgToEncrypt.AutoSize = true;
            this.LabelMsgToEncrypt.Location = new System.Drawing.Point(26, 175);
            this.LabelMsgToEncrypt.Name = "LabelMsgToEncrypt";
            this.LabelMsgToEncrypt.Size = new System.Drawing.Size(100, 13);
            this.LabelMsgToEncrypt.TabIndex = 25;
            this.LabelMsgToEncrypt.Text = "Message to encrypt";
            // 
            // LabelSymKey
            // 
            this.LabelSymKey.AutoSize = true;
            this.LabelSymKey.Location = new System.Drawing.Point(294, 175);
            this.LabelSymKey.Name = "LabelSymKey";
            this.LabelSymKey.Size = new System.Drawing.Size(75, 13);
            this.LabelSymKey.TabIndex = 26;
            this.LabelSymKey.Text = "Symmetric key";
            // 
            // SymKeyValue
            // 
            this.SymKeyValue.AutoSize = true;
            this.SymKeyValue.Location = new System.Drawing.Point(297, 194);
            this.SymKeyValue.Name = "SymKeyValue";
            this.SymKeyValue.Size = new System.Drawing.Size(0, 13);
            this.SymKeyValue.TabIndex = 27;
            // 
            // ButtonGenSymKey
            // 
            this.ButtonGenSymKey.Location = new System.Drawing.Point(297, 220);
            this.ButtonGenSymKey.Name = "ButtonGenSymKey";
            this.ButtonGenSymKey.Size = new System.Drawing.Size(91, 23);
            this.ButtonGenSymKey.TabIndex = 28;
            this.ButtonGenSymKey.Text = "Generate key";
            this.ButtonGenSymKey.UseVisualStyleBackColor = true;
            this.ButtonGenSymKey.Click += new System.EventHandler(this.ButtonGenSymKey_Click);
            // 
            // LabelAlgToUse
            // 
            this.LabelAlgToUse.AutoSize = true;
            this.LabelAlgToUse.Location = new System.Drawing.Point(488, 175);
            this.LabelAlgToUse.Name = "LabelAlgToUse";
            this.LabelAlgToUse.Size = new System.Drawing.Size(88, 13);
            this.LabelAlgToUse.TabIndex = 29;
            this.LabelAlgToUse.Text = "Algorithm to use: ";
            // 
            // LabelSymAlgToUseValue
            // 
            this.LabelSymAlgToUseValue.AutoSize = true;
            this.LabelSymAlgToUseValue.Location = new System.Drawing.Point(582, 175);
            this.LabelSymAlgToUseValue.Name = "LabelSymAlgToUseValue";
            this.LabelSymAlgToUseValue.Size = new System.Drawing.Size(0, 13);
            this.LabelSymAlgToUseValue.TabIndex = 30;
            // 
            // LabelAsymAlgToUseValue
            // 
            this.LabelAsymAlgToUseValue.AutoSize = true;
            this.LabelAsymAlgToUseValue.Location = new System.Drawing.Point(553, 197);
            this.LabelAsymAlgToUseValue.Name = "LabelAsymAlgToUseValue";
            this.LabelAsymAlgToUseValue.Size = new System.Drawing.Size(0, 13);
            this.LabelAsymAlgToUseValue.TabIndex = 32;
            // 
            // LabelEncryptedMsg
            // 
            this.LabelEncryptedMsg.AutoSize = true;
            this.LabelEncryptedMsg.Location = new System.Drawing.Point(32, 294);
            this.LabelEncryptedMsg.Name = "LabelEncryptedMsg";
            this.LabelEncryptedMsg.Size = new System.Drawing.Size(100, 13);
            this.LabelEncryptedMsg.TabIndex = 33;
            this.LabelEncryptedMsg.Text = "Encrypted message";
            // 
            // TextBoxEncryptedMsg
            // 
            this.TextBoxEncryptedMsg.Location = new System.Drawing.Point(26, 310);
            this.TextBoxEncryptedMsg.Multiline = true;
            this.TextBoxEncryptedMsg.Name = "TextBoxEncryptedMsg";
            this.TextBoxEncryptedMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxEncryptedMsg.Size = new System.Drawing.Size(245, 71);
            this.TextBoxEncryptedMsg.TabIndex = 34;
            this.TextBoxEncryptedMsg.TextChanged += new System.EventHandler(this.TextBoxEncryptedMsg_TextChanged);
            // 
            // ButtonEncryptMsg
            // 
            this.ButtonEncryptMsg.Location = new System.Drawing.Point(297, 332);
            this.ButtonEncryptMsg.Name = "ButtonEncryptMsg";
            this.ButtonEncryptMsg.Size = new System.Drawing.Size(91, 23);
            this.ButtonEncryptMsg.TabIndex = 35;
            this.ButtonEncryptMsg.Text = "Encrypt";
            this.ButtonEncryptMsg.UseVisualStyleBackColor = true;
            this.ButtonEncryptMsg.Click += new System.EventHandler(this.ButtonEncryptMsg_Click);
            // 
            // TextBoxDecryptedMsg
            // 
            this.TextBoxDecryptedMsg.Location = new System.Drawing.Point(26, 416);
            this.TextBoxDecryptedMsg.Multiline = true;
            this.TextBoxDecryptedMsg.Name = "TextBoxDecryptedMsg";
            this.TextBoxDecryptedMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDecryptedMsg.Size = new System.Drawing.Size(245, 71);
            this.TextBoxDecryptedMsg.TabIndex = 37;
            // 
            // LabelDecryptedMsg
            // 
            this.LabelDecryptedMsg.AutoSize = true;
            this.LabelDecryptedMsg.Location = new System.Drawing.Point(32, 400);
            this.LabelDecryptedMsg.Name = "LabelDecryptedMsg";
            this.LabelDecryptedMsg.Size = new System.Drawing.Size(78, 13);
            this.LabelDecryptedMsg.TabIndex = 36;
            this.LabelDecryptedMsg.Text = "Decrypted msg";
            // 
            // ButtonDecryptMsg
            // 
            this.ButtonDecryptMsg.Location = new System.Drawing.Point(297, 438);
            this.ButtonDecryptMsg.Name = "ButtonDecryptMsg";
            this.ButtonDecryptMsg.Size = new System.Drawing.Size(91, 23);
            this.ButtonDecryptMsg.TabIndex = 38;
            this.ButtonDecryptMsg.Text = "Decrypt";
            this.ButtonDecryptMsg.UseVisualStyleBackColor = true;
            this.ButtonDecryptMsg.Click += new System.EventHandler(this.ButtonDecryptMsg_Click);
            // 
            // LabelMode2
            // 
            this.LabelMode2.AutoSize = true;
            this.LabelMode2.Location = new System.Drawing.Point(648, 174);
            this.LabelMode2.Name = "LabelMode2";
            this.LabelMode2.Size = new System.Drawing.Size(75, 13);
            this.LabelMode2.TabIndex = 40;
            this.LabelMode2.Text = "Chosen mode:";
            // 
            // LabelModeValue
            // 
            this.LabelModeValue.AutoSize = true;
            this.LabelModeValue.Location = new System.Drawing.Point(729, 175);
            this.LabelModeValue.Name = "LabelModeValue";
            this.LabelModeValue.Size = new System.Drawing.Size(0, 13);
            this.LabelModeValue.TabIndex = 41;
            // 
            // TextBoxEncryptedKey
            // 
            this.TextBoxEncryptedKey.Location = new System.Drawing.Point(26, 516);
            this.TextBoxEncryptedKey.Multiline = true;
            this.TextBoxEncryptedKey.Name = "TextBoxEncryptedKey";
            this.TextBoxEncryptedKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxEncryptedKey.Size = new System.Drawing.Size(245, 71);
            this.TextBoxEncryptedKey.TabIndex = 43;
            // 
            // LabelEncryptedKey
            // 
            this.LabelEncryptedKey.AutoSize = true;
            this.LabelEncryptedKey.Location = new System.Drawing.Point(32, 500);
            this.LabelEncryptedKey.Name = "LabelEncryptedKey";
            this.LabelEncryptedKey.Size = new System.Drawing.Size(75, 13);
            this.LabelEncryptedKey.TabIndex = 42;
            this.LabelEncryptedKey.Text = "Encrypted key";
            // 
            // TextBoxDecryptedKey
            // 
            this.TextBoxDecryptedKey.Location = new System.Drawing.Point(26, 622);
            this.TextBoxDecryptedKey.Multiline = true;
            this.TextBoxDecryptedKey.Name = "TextBoxDecryptedKey";
            this.TextBoxDecryptedKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDecryptedKey.Size = new System.Drawing.Size(245, 71);
            this.TextBoxDecryptedKey.TabIndex = 45;
            // 
            // LabelDecryptedKey
            // 
            this.LabelDecryptedKey.AutoSize = true;
            this.LabelDecryptedKey.Location = new System.Drawing.Point(32, 606);
            this.LabelDecryptedKey.Name = "LabelDecryptedKey";
            this.LabelDecryptedKey.Size = new System.Drawing.Size(76, 13);
            this.LabelDecryptedKey.TabIndex = 44;
            this.LabelDecryptedKey.Text = "Decrypted key";
            // 
            // ButtonGenerateEnvelope
            // 
            this.ButtonGenerateEnvelope.Location = new System.Drawing.Point(414, 234);
            this.ButtonGenerateEnvelope.Name = "ButtonGenerateEnvelope";
            this.ButtonGenerateEnvelope.Size = new System.Drawing.Size(120, 23);
            this.ButtonGenerateEnvelope.TabIndex = 46;
            this.ButtonGenerateEnvelope.Text = "Generate envelope";
            this.ButtonGenerateEnvelope.UseVisualStyleBackColor = true;
            this.ButtonGenerateEnvelope.Click += new System.EventHandler(this.ButtonGenerateEnvelope_Click);
            // 
            // LabelEnvelope
            // 
            this.LabelEnvelope.AutoSize = true;
            this.LabelEnvelope.Location = new System.Drawing.Point(556, 217);
            this.LabelEnvelope.Name = "LabelEnvelope";
            this.LabelEnvelope.Size = new System.Drawing.Size(52, 13);
            this.LabelEnvelope.TabIndex = 48;
            this.LabelEnvelope.Text = "Envelope";
            // 
            // TextBoxEnvelope
            // 
            this.TextBoxEnvelope.Location = new System.Drawing.Point(556, 236);
            this.TextBoxEnvelope.Multiline = true;
            this.TextBoxEnvelope.Name = "TextBoxEnvelope";
            this.TextBoxEnvelope.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxEnvelope.Size = new System.Drawing.Size(245, 71);
            this.TextBoxEnvelope.TabIndex = 47;
            // 
            // LabelDecryptedEnvelope
            // 
            this.LabelDecryptedEnvelope.AutoSize = true;
            this.LabelDecryptedEnvelope.Location = new System.Drawing.Point(556, 315);
            this.LabelDecryptedEnvelope.Name = "LabelDecryptedEnvelope";
            this.LabelDecryptedEnvelope.Size = new System.Drawing.Size(103, 13);
            this.LabelDecryptedEnvelope.TabIndex = 50;
            this.LabelDecryptedEnvelope.Text = "Decrypted envelope";
            // 
            // TextBoxDecryptedEnvelope
            // 
            this.TextBoxDecryptedEnvelope.Location = new System.Drawing.Point(556, 334);
            this.TextBoxDecryptedEnvelope.Multiline = true;
            this.TextBoxDecryptedEnvelope.Name = "TextBoxDecryptedEnvelope";
            this.TextBoxDecryptedEnvelope.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDecryptedEnvelope.Size = new System.Drawing.Size(245, 71);
            this.TextBoxDecryptedEnvelope.TabIndex = 49;
            // 
            // ButtonDecryptEnvelope
            // 
            this.ButtonDecryptEnvelope.Location = new System.Drawing.Point(414, 332);
            this.ButtonDecryptEnvelope.Name = "ButtonDecryptEnvelope";
            this.ButtonDecryptEnvelope.Size = new System.Drawing.Size(120, 23);
            this.ButtonDecryptEnvelope.TabIndex = 51;
            this.ButtonDecryptEnvelope.Text = "Decrypt envelope";
            this.ButtonDecryptEnvelope.UseVisualStyleBackColor = true;
            this.ButtonDecryptEnvelope.Click += new System.EventHandler(this.ButtonDecryptEnvelope_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioHashSHA512);
            this.groupBox1.Controls.Add(this.LabelHash);
            this.groupBox1.Controls.Add(this.RadioHashSHA1);
            this.groupBox1.Controls.Add(this.RadioHashSHA256);
            this.groupBox1.Controls.Add(this.RadioHashSHA384);
            this.groupBox1.Location = new System.Drawing.Point(547, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 126);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // RadioHashSHA512
            // 
            this.RadioHashSHA512.AutoSize = true;
            this.RadioHashSHA512.Location = new System.Drawing.Point(21, 102);
            this.RadioHashSHA512.Name = "RadioHashSHA512";
            this.RadioHashSHA512.Size = new System.Drawing.Size(65, 17);
            this.RadioHashSHA512.TabIndex = 17;
            this.RadioHashSHA512.TabStop = true;
            this.RadioHashSHA512.Text = "SHA512";
            this.RadioHashSHA512.UseVisualStyleBackColor = true;
            // 
            // LabelHash
            // 
            this.LabelHash.AutoSize = true;
            this.LabelHash.Location = new System.Drawing.Point(6, 16);
            this.LabelHash.Name = "LabelHash";
            this.LabelHash.Size = new System.Drawing.Size(32, 13);
            this.LabelHash.TabIndex = 13;
            this.LabelHash.Text = "Hash";
            // 
            // RadioHashSHA1
            // 
            this.RadioHashSHA1.AutoSize = true;
            this.RadioHashSHA1.Location = new System.Drawing.Point(21, 31);
            this.RadioHashSHA1.Name = "RadioHashSHA1";
            this.RadioHashSHA1.Size = new System.Drawing.Size(53, 17);
            this.RadioHashSHA1.TabIndex = 14;
            this.RadioHashSHA1.TabStop = true;
            this.RadioHashSHA1.Text = "SHA1";
            this.RadioHashSHA1.UseVisualStyleBackColor = true;
            // 
            // RadioHashSHA256
            // 
            this.RadioHashSHA256.AutoSize = true;
            this.RadioHashSHA256.Checked = true;
            this.RadioHashSHA256.Location = new System.Drawing.Point(21, 55);
            this.RadioHashSHA256.Name = "RadioHashSHA256";
            this.RadioHashSHA256.Size = new System.Drawing.Size(65, 17);
            this.RadioHashSHA256.TabIndex = 15;
            this.RadioHashSHA256.TabStop = true;
            this.RadioHashSHA256.Text = "SHA256";
            this.RadioHashSHA256.UseVisualStyleBackColor = true;
            // 
            // RadioHashSHA384
            // 
            this.RadioHashSHA384.AutoSize = true;
            this.RadioHashSHA384.Location = new System.Drawing.Point(21, 79);
            this.RadioHashSHA384.Name = "RadioHashSHA384";
            this.RadioHashSHA384.Size = new System.Drawing.Size(65, 17);
            this.RadioHashSHA384.TabIndex = 16;
            this.RadioHashSHA384.TabStop = true;
            this.RadioHashSHA384.Text = "SHA384";
            this.RadioHashSHA384.UseVisualStyleBackColor = true;
            // 
            // TextBoxHash
            // 
            this.TextBoxHash.Location = new System.Drawing.Point(810, 75);
            this.TextBoxHash.Multiline = true;
            this.TextBoxHash.Name = "TextBoxHash";
            this.TextBoxHash.Size = new System.Drawing.Size(150, 112);
            this.TextBoxHash.TabIndex = 53;
            // 
            // ButtonHash
            // 
            this.ButtonHash.Location = new System.Drawing.Point(827, 43);
            this.ButtonHash.Name = "ButtonHash";
            this.ButtonHash.Size = new System.Drawing.Size(75, 23);
            this.ButtonHash.TabIndex = 54;
            this.ButtonHash.Text = "Hashiraj";
            this.ButtonHash.UseVisualStyleBackColor = true;
            this.ButtonHash.Click += new System.EventHandler(this.ButtonHash_Click);
            // 
            // LabelSignature
            // 
            this.LabelSignature.AutoSize = true;
            this.LabelSignature.Location = new System.Drawing.Point(556, 423);
            this.LabelSignature.Name = "LabelSignature";
            this.LabelSignature.Size = new System.Drawing.Size(82, 13);
            this.LabelSignature.TabIndex = 57;
            this.LabelSignature.Text = "Digital signature";
            // 
            // TextBoxSignature
            // 
            this.TextBoxSignature.Location = new System.Drawing.Point(556, 442);
            this.TextBoxSignature.Multiline = true;
            this.TextBoxSignature.Name = "TextBoxSignature";
            this.TextBoxSignature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxSignature.Size = new System.Drawing.Size(245, 71);
            this.TextBoxSignature.TabIndex = 56;
            // 
            // ButtonGenerateSignature
            // 
            this.ButtonGenerateSignature.Location = new System.Drawing.Point(414, 440);
            this.ButtonGenerateSignature.Name = "ButtonGenerateSignature";
            this.ButtonGenerateSignature.Size = new System.Drawing.Size(120, 23);
            this.ButtonGenerateSignature.TabIndex = 55;
            this.ButtonGenerateSignature.Text = "Generate signature";
            this.ButtonGenerateSignature.UseVisualStyleBackColor = true;
            this.ButtonGenerateSignature.Click += new System.EventHandler(this.ButtonGenerateSignature_Click);
            // 
            // ButtonCheckSignature
            // 
            this.ButtonCheckSignature.Location = new System.Drawing.Point(414, 528);
            this.ButtonCheckSignature.Name = "ButtonCheckSignature";
            this.ButtonCheckSignature.Size = new System.Drawing.Size(120, 23);
            this.ButtonCheckSignature.TabIndex = 58;
            this.ButtonCheckSignature.Text = "Check signature";
            this.ButtonCheckSignature.UseVisualStyleBackColor = true;
            this.ButtonCheckSignature.Click += new System.EventHandler(this.ButtonCheckSignature_Click);
            // 
            // LabelSeal
            // 
            this.LabelSeal.AutoSize = true;
            this.LabelSeal.Location = new System.Drawing.Point(946, 217);
            this.LabelSeal.Name = "LabelSeal";
            this.LabelSeal.Size = new System.Drawing.Size(58, 13);
            this.LabelSeal.TabIndex = 61;
            this.LabelSeal.Text = "Digital seal";
            // 
            // TextBoxSeal
            // 
            this.TextBoxSeal.Location = new System.Drawing.Point(946, 236);
            this.TextBoxSeal.Multiline = true;
            this.TextBoxSeal.Name = "TextBoxSeal";
            this.TextBoxSeal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxSeal.Size = new System.Drawing.Size(245, 71);
            this.TextBoxSeal.TabIndex = 60;
            // 
            // ButtonGenerateSeal
            // 
            this.ButtonGenerateSeal.Location = new System.Drawing.Point(820, 236);
            this.ButtonGenerateSeal.Name = "ButtonGenerateSeal";
            this.ButtonGenerateSeal.Size = new System.Drawing.Size(120, 23);
            this.ButtonGenerateSeal.TabIndex = 59;
            this.ButtonGenerateSeal.Text = "Generate seal";
            this.ButtonGenerateSeal.UseVisualStyleBackColor = true;
            this.ButtonGenerateSeal.Click += new System.EventHandler(this.ButtonGenerateSeal_Click);
            // 
            // ButtonCheckSeal
            // 
            this.ButtonCheckSeal.Location = new System.Drawing.Point(820, 315);
            this.ButtonCheckSeal.Name = "ButtonCheckSeal";
            this.ButtonCheckSeal.Size = new System.Drawing.Size(120, 23);
            this.ButtonCheckSeal.TabIndex = 62;
            this.ButtonCheckSeal.Text = "Check Seal";
            this.ButtonCheckSeal.UseVisualStyleBackColor = true;
            this.ButtonCheckSeal.Click += new System.EventHandler(this.ButtonCheckSeal_Click);
            // 
            // LabelSignatureCheck
            // 
            this.LabelSignatureCheck.AutoSize = true;
            this.LabelSignatureCheck.Location = new System.Drawing.Point(553, 533);
            this.LabelSignatureCheck.Name = "LabelSignatureCheck";
            this.LabelSignatureCheck.Size = new System.Drawing.Size(0, 13);
            this.LabelSignatureCheck.TabIndex = 63;
            // 
            // LabelSealCheck
            // 
            this.LabelSealCheck.AutoSize = true;
            this.LabelSealCheck.Location = new System.Drawing.Point(946, 320);
            this.LabelSealCheck.Name = "LabelSealCheck";
            this.LabelSealCheck.Size = new System.Drawing.Size(0, 13);
            this.LabelSealCheck.TabIndex = 64;
            // 
            // LabelSealCheckMsg
            // 
            this.LabelSealCheckMsg.AutoSize = true;
            this.LabelSealCheckMsg.Location = new System.Drawing.Point(947, 341);
            this.LabelSealCheckMsg.Name = "LabelSealCheckMsg";
            this.LabelSealCheckMsg.Size = new System.Drawing.Size(56, 13);
            this.LabelSealCheckMsg.TabIndex = 65;
            this.LabelSealCheckMsg.Text = "Message: ";
            // 
            // LabelSealCheckKey
            // 
            this.LabelSealCheckKey.AutoSize = true;
            this.LabelSealCheckKey.Location = new System.Drawing.Point(950, 367);
            this.LabelSealCheckKey.Name = "LabelSealCheckKey";
            this.LabelSealCheckKey.Size = new System.Drawing.Size(28, 13);
            this.LabelSealCheckKey.TabIndex = 66;
            this.LabelSealCheckKey.Text = "Key:";
            this.LabelSealCheckKey.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 710);
            this.Controls.Add(this.LabelSealCheckKey);
            this.Controls.Add(this.LabelSealCheckMsg);
            this.Controls.Add(this.LabelSealCheck);
            this.Controls.Add(this.LabelSignatureCheck);
            this.Controls.Add(this.ButtonCheckSeal);
            this.Controls.Add(this.LabelSeal);
            this.Controls.Add(this.TextBoxSeal);
            this.Controls.Add(this.ButtonGenerateSeal);
            this.Controls.Add(this.ButtonCheckSignature);
            this.Controls.Add(this.LabelSignature);
            this.Controls.Add(this.TextBoxSignature);
            this.Controls.Add(this.ButtonGenerateSignature);
            this.Controls.Add(this.ButtonHash);
            this.Controls.Add(this.TextBoxHash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonDecryptEnvelope);
            this.Controls.Add(this.LabelDecryptedEnvelope);
            this.Controls.Add(this.TextBoxDecryptedEnvelope);
            this.Controls.Add(this.LabelEnvelope);
            this.Controls.Add(this.TextBoxEnvelope);
            this.Controls.Add(this.ButtonGenerateEnvelope);
            this.Controls.Add(this.TextBoxDecryptedKey);
            this.Controls.Add(this.LabelDecryptedKey);
            this.Controls.Add(this.TextBoxEncryptedKey);
            this.Controls.Add(this.LabelEncryptedKey);
            this.Controls.Add(this.LabelModeValue);
            this.Controls.Add(this.LabelMode2);
            this.Controls.Add(this.ButtonDecryptMsg);
            this.Controls.Add(this.TextBoxDecryptedMsg);
            this.Controls.Add(this.LabelDecryptedMsg);
            this.Controls.Add(this.ButtonEncryptMsg);
            this.Controls.Add(this.TextBoxEncryptedMsg);
            this.Controls.Add(this.LabelEncryptedMsg);
            this.Controls.Add(this.LabelAsymAlgToUseValue);
            this.Controls.Add(this.LabelSymAlgToUseValue);
            this.Controls.Add(this.LabelAlgToUse);
            this.Controls.Add(this.ButtonGenSymKey);
            this.Controls.Add(this.SymKeyValue);
            this.Controls.Add(this.LabelSymKey);
            this.Controls.Add(this.LabelMsgToEncrypt);
            this.Controls.Add(this.TextBoxMsgToEncrypt);
            this.Controls.Add(this.groupBoxRSA);
            this.Controls.Add(this.groupBox3DES);
            this.Controls.Add(this.groupBoxAES);
            this.Controls.Add(this.RadioModeCFB);
            this.Controls.Add(this.RadioModeECB);
            this.Controls.Add(this.RadioModeCBC);
            this.Controls.Add(this.LabelMode);
            this.Controls.Add(this.ButtonRSA);
            this.Controls.Add(this.Button3DES);
            this.Controls.Add(this.ButtonAES);
            this.Name = "Form1";
            this.Text = "Digital Envelope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAES.ResumeLayout(false);
            this.groupBoxAES.PerformLayout();
            this.groupBox3DES.ResumeLayout(false);
            this.groupBox3DES.PerformLayout();
            this.groupBoxRSA.ResumeLayout(false);
            this.groupBoxRSA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAES;
        private System.Windows.Forms.Button Button3DES;
        private System.Windows.Forms.Button ButtonRSA;
        private System.Windows.Forms.Label KeySize1;
        private System.Windows.Forms.RadioButton RadioAesKey128;
        private System.Windows.Forms.RadioButton RadioAesKey192;
        private System.Windows.Forms.RadioButton RadioAesKey256;
        private System.Windows.Forms.RadioButton RadioDesKey192;
        private System.Windows.Forms.RadioButton RadioDesKey128;
        private System.Windows.Forms.Label KeySize2;
        private System.Windows.Forms.RadioButton RadioRsaKey3072;
        private System.Windows.Forms.RadioButton RadioRsaKey2048;
        private System.Windows.Forms.RadioButton RadioRsaKey1024;
        private System.Windows.Forms.Label KeySize3;
        private System.Windows.Forms.RadioButton RadioModeCFB;
        private System.Windows.Forms.RadioButton RadioModeECB;
        private System.Windows.Forms.RadioButton RadioModeCBC;
        private System.Windows.Forms.Label LabelMode;
        private System.Windows.Forms.GroupBox groupBoxAES;
        private System.Windows.Forms.GroupBox groupBox3DES;
        private System.Windows.Forms.GroupBox groupBoxRSA;
        private System.Windows.Forms.TextBox TextBoxMsgToEncrypt;
        private System.Windows.Forms.Label LabelMsgToEncrypt;
        private System.Windows.Forms.Label LabelSymKey;
        private System.Windows.Forms.Label SymKeyValue;
        private System.Windows.Forms.Button ButtonGenSymKey;
        private System.Windows.Forms.Label LabelAlgToUse;
        private System.Windows.Forms.Label LabelSymAlgToUseValue;
        private System.Windows.Forms.Label LabelAsymAlgToUseValue;
        private System.Windows.Forms.Label LabelEncryptedMsg;
        private System.Windows.Forms.TextBox TextBoxEncryptedMsg;
        private System.Windows.Forms.Button ButtonEncryptMsg;
        private System.Windows.Forms.TextBox TextBoxDecryptedMsg;
        private System.Windows.Forms.Label LabelDecryptedMsg;
        private System.Windows.Forms.Button ButtonDecryptMsg;
        private System.Windows.Forms.Label LabelMode2;
        private System.Windows.Forms.Label LabelModeValue;
        private System.Windows.Forms.TextBox TextBoxEncryptedKey;
        private System.Windows.Forms.Label LabelEncryptedKey;
        private System.Windows.Forms.TextBox TextBoxDecryptedKey;
        private System.Windows.Forms.Label LabelDecryptedKey;
        private System.Windows.Forms.Button ButtonGenerateEnvelope;
        private System.Windows.Forms.Label LabelEnvelope;
        private System.Windows.Forms.TextBox TextBoxEnvelope;
        private System.Windows.Forms.Label LabelDecryptedEnvelope;
        private System.Windows.Forms.TextBox TextBoxDecryptedEnvelope;
        private System.Windows.Forms.Button ButtonDecryptEnvelope;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelHash;
        private System.Windows.Forms.RadioButton RadioHashSHA1;
        private System.Windows.Forms.RadioButton RadioHashSHA256;
        private System.Windows.Forms.RadioButton RadioHashSHA384;
        private System.Windows.Forms.RadioButton RadioHashSHA512;
        private System.Windows.Forms.TextBox TextBoxHash;
        private System.Windows.Forms.Button ButtonHash;
        private System.Windows.Forms.Label LabelSignature;
        private System.Windows.Forms.TextBox TextBoxSignature;
        private System.Windows.Forms.Button ButtonGenerateSignature;
        private System.Windows.Forms.Button ButtonCheckSignature;
        private System.Windows.Forms.Label LabelSeal;
        private System.Windows.Forms.TextBox TextBoxSeal;
        private System.Windows.Forms.Button ButtonGenerateSeal;
        private System.Windows.Forms.Button ButtonCheckSeal;
        private System.Windows.Forms.Label LabelSignatureCheck;
        private System.Windows.Forms.Label LabelSealCheck;
        private System.Windows.Forms.Label LabelSealCheckMsg;
        private System.Windows.Forms.Label LabelSealCheckKey;
    }
}

