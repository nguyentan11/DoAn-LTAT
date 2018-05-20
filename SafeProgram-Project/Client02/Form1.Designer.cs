namespace Client02
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
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtRemote = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBobPubKey = new System.Windows.Forms.TextBox();
            this.txtAlicePubKey = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.txtPadding = new System.Windows.Forms.TextBox();
            this.lblfinalText = new System.Windows.Forms.Label();
            this.txtfinalText = new System.Windows.Forms.TextBox();
            this.txtKey01 = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnEncryptNoise = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Encrypted";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(188, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 41);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(68, 455);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(82, 41);
            this.btnSend.TabIndex = 33;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(68, 392);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(185, 20);
            this.txtEncrypted.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Message";
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Location = new System.Drawing.Point(68, 353);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(185, 20);
            this.txtKey.TabIndex = 27;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 276);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(165, 54);
            this.txtMessage.TabIndex = 26;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(258, 69);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 26);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtRemote
            // 
            this.txtRemote.Location = new System.Drawing.Point(78, 92);
            this.txtRemote.Name = "txtRemote";
            this.txtRemote.Size = new System.Drawing.Size(121, 20);
            this.txtRemote.TabIndex = 23;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(78, 51);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(121, 20);
            this.txtLocal.TabIndex = 22;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(78, 11);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(121, 20);
            this.txtIp.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Remote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Local";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ip address";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Enabled = false;
            this.txtDecrypt.Location = new System.Drawing.Point(197, 276);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(158, 54);
            this.txtDecrypt.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(13, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Bob Public Key";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(13, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Alice Public key";
            this.label7.Visible = false;
            // 
            // txtBobPubKey
            // 
            this.txtBobPubKey.Enabled = false;
            this.txtBobPubKey.Location = new System.Drawing.Point(13, 661);
            this.txtBobPubKey.Multiline = true;
            this.txtBobPubKey.Name = "txtBobPubKey";
            this.txtBobPubKey.Size = new System.Drawing.Size(340, 71);
            this.txtBobPubKey.TabIndex = 45;
            this.txtBobPubKey.Visible = false;
            // 
            // txtAlicePubKey
            // 
            this.txtAlicePubKey.Enabled = false;
            this.txtAlicePubKey.Location = new System.Drawing.Point(13, 566);
            this.txtAlicePubKey.Multiline = true;
            this.txtAlicePubKey.Name = "txtAlicePubKey";
            this.txtAlicePubKey.Size = new System.Drawing.Size(340, 61);
            this.txtAlicePubKey.TabIndex = 44;
            this.txtAlicePubKey.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(258, 23);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 28);
            this.btnConfirm.TabIndex = 49;
            this.btnConfirm.Text = "Auto Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Decrypted Message";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtPadding
            // 
            this.txtPadding.Location = new System.Drawing.Point(10, 528);
            this.txtPadding.Name = "txtPadding";
            this.txtPadding.Size = new System.Drawing.Size(185, 20);
            this.txtPadding.TabIndex = 53;
            this.txtPadding.Visible = false;
            // 
            // lblfinalText
            // 
            this.lblfinalText.AutoSize = true;
            this.lblfinalText.Location = new System.Drawing.Point(9, 436);
            this.lblfinalText.Name = "lblfinalText";
            this.lblfinalText.Size = new System.Drawing.Size(53, 13);
            this.lblfinalText.TabIndex = 54;
            this.lblfinalText.Text = "Final Text";
            // 
            // txtfinalText
            // 
            this.txtfinalText.Location = new System.Drawing.Point(68, 429);
            this.txtfinalText.Name = "txtfinalText";
            this.txtfinalText.Size = new System.Drawing.Size(185, 20);
            this.txtfinalText.TabIndex = 55;
            // 
            // txtKey01
            // 
            this.txtKey01.Location = new System.Drawing.Point(213, 528);
            this.txtKey01.Name = "txtKey01";
            this.txtKey01.Size = new System.Drawing.Size(132, 20);
            this.txtKey01.TabIndex = 56;
            this.txtKey01.Visible = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(266, 344);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(89, 37);
            this.btnEncrypt.TabIndex = 57;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnEncryptNoise
            // 
            this.btnEncryptNoise.Location = new System.Drawing.Point(266, 395);
            this.btnEncryptNoise.Name = "btnEncryptNoise";
            this.btnEncryptNoise.Size = new System.Drawing.Size(89, 40);
            this.btnEncryptNoise.TabIndex = 58;
            this.btnEncryptNoise.Text = "Encrypt+Noise";
            this.btnEncryptNoise.UseVisualStyleBackColor = true;
            this.btnEncryptNoise.Click += new System.EventHandler(this.btnEncryptNoise_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Location = new System.Drawing.Point(267, 115);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(45, 13);
            this.lbTimer.TabIndex = 59;
            this.lbTimer.Text = "Timeout";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 121);
            this.richTextBox1.TabIndex = 60;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 503);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnEncryptNoise);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtKey01);
            this.Controls.Add(this.txtfinalText);
            this.Controls.Add(this.lblfinalText);
            this.Controls.Add(this.txtPadding);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBobPubKey);
            this.Controls.Add(this.txtAlicePubKey);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtRemote);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client 02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtRemote;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBobPubKey;
        private System.Windows.Forms.TextBox txtAlicePubKey;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtPadding;
        private System.Windows.Forms.Label lblfinalText;
        private System.Windows.Forms.TextBox txtfinalText;
        private System.Windows.Forms.TextBox txtKey01;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnEncryptNoise;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

