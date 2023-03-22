
namespace RSA
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
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExtendedgcdD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPublicKeyN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSavePublicKey = new System.Windows.Forms.Button();
            this.btnSaveEncrypted = new System.Windows.Forms.Button();
            this.btnOpenPublicKey = new System.Windows.Forms.Button();
            this.btnOpenEncypted = new System.Windows.Forms.Button();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPublicKeyE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFindQ = new System.Windows.Forms.TextBox();
            this.txtFindP = new System.Windows.Forms.TextBox();
            this.txtNdecryption = new System.Windows.Forms.TextBox();
            this.txtDdecryption = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPhiDecryption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(13, 45);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 22);
            this.txtP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter p";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(144, 45);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 22);
            this.txtQ.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(141, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter text for encryption - x (Plain text):";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(13, 95);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(1180, 80);
            this.txtPlainText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numbers p and q need to be prime numbers! Example: 2, 3, 5, 7, 11, 13...";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(13, 182);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(12, 278);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(1180, 80);
            this.txtEncrypted.TabIndex = 8;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(48, 211);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "n =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Φ =";
            // 
            // txtPhi
            // 
            this.txtPhi.Location = new System.Drawing.Point(220, 211);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.ReadOnly = true;
            this.txtPhi.Size = new System.Drawing.Size(100, 22);
            this.txtPhi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "GCD = ";
            // 
            // txtGCD
            // 
            this.txtGCD.Location = new System.Drawing.Point(418, 212);
            this.txtGCD.Name = "txtGCD";
            this.txtGCD.ReadOnly = true;
            this.txtGCD.Size = new System.Drawing.Size(100, 22);
            this.txtGCD.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "d =";
            // 
            // txtExtendedgcdD
            // 
            this.txtExtendedgcdD.Location = new System.Drawing.Point(763, 213);
            this.txtExtendedgcdD.Name = "txtExtendedgcdD";
            this.txtExtendedgcdD.ReadOnly = true;
            this.txtExtendedgcdD.Size = new System.Drawing.Size(100, 22);
            this.txtExtendedgcdD.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(880, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Public Key (n, e) =";
            // 
            // txtPublicKeyN
            // 
            this.txtPublicKeyN.Location = new System.Drawing.Point(1010, 212);
            this.txtPublicKeyN.Name = "txtPublicKeyN";
            this.txtPublicKeyN.Size = new System.Drawing.Size(35, 22);
            this.txtPublicKeyN.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Encrypted text:";
            // 
            // btnSavePublicKey
            // 
            this.btnSavePublicKey.Location = new System.Drawing.Point(883, 249);
            this.btnSavePublicKey.Name = "btnSavePublicKey";
            this.btnSavePublicKey.Size = new System.Drawing.Size(138, 23);
            this.btnSavePublicKey.TabIndex = 20;
            this.btnSavePublicKey.Text = "Save Public Key";
            this.btnSavePublicKey.UseVisualStyleBackColor = true;
            // 
            // btnSaveEncrypted
            // 
            this.btnSaveEncrypted.Location = new System.Drawing.Point(120, 249);
            this.btnSaveEncrypted.Name = "btnSaveEncrypted";
            this.btnSaveEncrypted.Size = new System.Drawing.Size(156, 23);
            this.btnSaveEncrypted.TabIndex = 21;
            this.btnSaveEncrypted.Text = "Save Encrypted Text";
            this.btnSaveEncrypted.UseVisualStyleBackColor = true;
            // 
            // btnOpenPublicKey
            // 
            this.btnOpenPublicKey.Location = new System.Drawing.Point(1027, 249);
            this.btnOpenPublicKey.Name = "btnOpenPublicKey";
            this.btnOpenPublicKey.Size = new System.Drawing.Size(138, 23);
            this.btnOpenPublicKey.TabIndex = 22;
            this.btnOpenPublicKey.Text = "Open Public Key";
            this.btnOpenPublicKey.UseVisualStyleBackColor = true;
            // 
            // btnOpenEncypted
            // 
            this.btnOpenEncypted.Location = new System.Drawing.Point(282, 249);
            this.btnOpenEncypted.Name = "btnOpenEncypted";
            this.btnOpenEncypted.Size = new System.Drawing.Size(156, 23);
            this.btnOpenEncypted.TabIndex = 23;
            this.btnOpenEncypted.Text = "Open Encrypted Text";
            this.btnOpenEncypted.UseVisualStyleBackColor = true;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(12, 455);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(1180, 80);
            this.txtDecrypted.TabIndex = 24;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(13, 409);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 25;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Decrypted text:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Private Key (d) =";
            // 
            // txtPublicKeyE
            // 
            this.txtPublicKeyE.Location = new System.Drawing.Point(1051, 212);
            this.txtPublicKeyE.Name = "txtPublicKeyE";
            this.txtPublicKeyE.Size = new System.Drawing.Size(35, 22);
            this.txtPublicKeyE.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "p =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(471, 427);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "q =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "n =";
            // 
            // txtFindQ
            // 
            this.txtFindQ.Location = new System.Drawing.Point(505, 424);
            this.txtFindQ.Name = "txtFindQ";
            this.txtFindQ.ReadOnly = true;
            this.txtFindQ.Size = new System.Drawing.Size(100, 22);
            this.txtFindQ.TabIndex = 35;
            // 
            // txtFindP
            // 
            this.txtFindP.Location = new System.Drawing.Point(361, 424);
            this.txtFindP.Name = "txtFindP";
            this.txtFindP.ReadOnly = true;
            this.txtFindP.Size = new System.Drawing.Size(100, 22);
            this.txtFindP.TabIndex = 36;
            // 
            // txtNdecryption
            // 
            this.txtNdecryption.Location = new System.Drawing.Point(282, 389);
            this.txtNdecryption.Name = "txtNdecryption";
            this.txtNdecryption.Size = new System.Drawing.Size(100, 22);
            this.txtNdecryption.TabIndex = 37;
            // 
            // txtDdecryption
            // 
            this.txtDdecryption.Location = new System.Drawing.Point(134, 387);
            this.txtDdecryption.Name = "txtDdecryption";
            this.txtDdecryption.Size = new System.Drawing.Size(98, 22);
            this.txtDdecryption.TabIndex = 38;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(1051, 13);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(141, 54);
            this.btnClearAll.TabIndex = 39;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(345, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "e in this algorythm is:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(348, 45);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(100, 22);
            this.txtE.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.Location = new System.Drawing.Point(14, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(218, 17);
            this.label17.TabIndex = 42;
            this.label17.Text = "Enter d and n for decryption:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(633, 424);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "Φ =";
            // 
            // txtPhiDecryption
            // 
            this.txtPhiDecryption.Location = new System.Drawing.Point(667, 424);
            this.txtPhiDecryption.Name = "txtPhiDecryption";
            this.txtPhiDecryption.ReadOnly = true;
            this.txtPhiDecryption.Size = new System.Drawing.Size(100, 22);
            this.txtPhiDecryption.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 553);
            this.Controls.Add(this.txtPhiDecryption);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtDdecryption);
            this.Controls.Add(this.txtNdecryption);
            this.Controls.Add(this.txtFindP);
            this.Controls.Add(this.txtFindQ);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPublicKeyE);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnOpenEncypted);
            this.Controls.Add(this.btnOpenPublicKey);
            this.Controls.Add(this.btnSaveEncrypted);
            this.Controls.Add(this.btnSavePublicKey);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPublicKeyN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtExtendedgcdD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGCD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Name = "Form1";
            this.Text = "RSA ALGORYTHM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGCD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExtendedgcdD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPublicKeyN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSavePublicKey;
        private System.Windows.Forms.Button btnSaveEncrypted;
        private System.Windows.Forms.Button btnOpenPublicKey;
        private System.Windows.Forms.Button btnOpenEncypted;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPublicKeyE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtFindQ;
        private System.Windows.Forms.TextBox txtFindP;
        private System.Windows.Forms.TextBox txtNdecryption;
        private System.Windows.Forms.TextBox txtDdecryption;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPhiDecryption;
    }
}

