
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
            this.components = new System.ComponentModel.Container();
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
            this.btnSaveEncrypted = new System.Windows.Forms.Button();
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
            this.label16 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPhiDecryption = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEdecryption = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.rSAtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rSADataSet = new RSA.RSADataSet();
            this.rSAtableTableAdapter = new RSA.RSADataSetTableAdapters.RSAtableTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rSAtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(10, 37);
            this.txtP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(76, 20);
            this.txtP.TabIndex = 0;
            this.txtP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter p";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(108, 37);
            this.txtQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(76, 20);
            this.txtQ.TabIndex = 2;
            this.txtQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQ_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(106, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter text for encryption - x (Plain text):";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(10, 77);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(886, 66);
            this.txtPlainText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numbers p and q need to be prime numbers starting with 11! Example: 11, 13...";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEncrypt.Location = new System.Drawing.Point(10, 147);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(77, 20);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(9, 226);
            this.txtEncrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(886, 66);
            this.txtEncrypted.TabIndex = 8;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(36, 171);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN.Name = "txtN";
            this.txtN.ReadOnly = true;
            this.txtN.Size = new System.Drawing.Size(76, 20);
            this.txtN.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "n =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 174);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Φ =";
            // 
            // txtPhi
            // 
            this.txtPhi.Location = new System.Drawing.Point(165, 171);
            this.txtPhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.ReadOnly = true;
            this.txtPhi.Size = new System.Drawing.Size(76, 20);
            this.txtPhi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "GCD (Φ, e) = ";
            // 
            // txtGCD
            // 
            this.txtGCD.Location = new System.Drawing.Point(322, 171);
            this.txtGCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGCD.Name = "txtGCD";
            this.txtGCD.ReadOnly = true;
            this.txtGCD.Size = new System.Drawing.Size(76, 20);
            this.txtGCD.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "d =";
            // 
            // txtExtendedgcdD
            // 
            this.txtExtendedgcdD.Location = new System.Drawing.Point(572, 173);
            this.txtExtendedgcdD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExtendedgcdD.Name = "txtExtendedgcdD";
            this.txtExtendedgcdD.ReadOnly = true;
            this.txtExtendedgcdD.Size = new System.Drawing.Size(76, 20);
            this.txtExtendedgcdD.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(660, 176);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Public Key (n, e) =";
            // 
            // txtPublicKeyN
            // 
            this.txtPublicKeyN.Location = new System.Drawing.Point(758, 172);
            this.txtPublicKeyN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPublicKeyN.Name = "txtPublicKeyN";
            this.txtPublicKeyN.ReadOnly = true;
            this.txtPublicKeyN.Size = new System.Drawing.Size(27, 20);
            this.txtPublicKeyN.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Encrypted text:";
            // 
            // btnSaveEncrypted
            // 
            this.btnSaveEncrypted.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveEncrypted.Location = new System.Drawing.Point(90, 202);
            this.btnSaveEncrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveEncrypted.Name = "btnSaveEncrypted";
            this.btnSaveEncrypted.Size = new System.Drawing.Size(117, 19);
            this.btnSaveEncrypted.TabIndex = 21;
            this.btnSaveEncrypted.Text = "Save Encrypted ";
            this.btnSaveEncrypted.UseVisualStyleBackColor = false;
            this.btnSaveEncrypted.Click += new System.EventHandler(this.btnSaveEncrypted_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(9, 482);
            this.txtDecrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(886, 66);
            this.txtDecrypted.TabIndex = 24;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDecrypt.Location = new System.Drawing.Point(9, 444);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(78, 20);
            this.btnDecrypt.TabIndex = 25;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 466);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Decrypted text:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 462);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Private Key (d) =";
            // 
            // txtPublicKeyE
            // 
            this.txtPublicKeyE.Location = new System.Drawing.Point(788, 172);
            this.txtPublicKeyE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPublicKeyE.Name = "txtPublicKeyE";
            this.txtPublicKeyE.ReadOnly = true;
            this.txtPublicKeyE.Size = new System.Drawing.Size(27, 20);
            this.txtPublicKeyE.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 459);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "p =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 462);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "q =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 317);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "n =";
            // 
            // txtFindQ
            // 
            this.txtFindQ.Location = new System.Drawing.Point(239, 459);
            this.txtFindQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFindQ.Name = "txtFindQ";
            this.txtFindQ.ReadOnly = true;
            this.txtFindQ.Size = new System.Drawing.Size(76, 20);
            this.txtFindQ.TabIndex = 35;
            // 
            // txtFindP
            // 
            this.txtFindP.Location = new System.Drawing.Point(132, 459);
            this.txtFindP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFindP.Name = "txtFindP";
            this.txtFindP.ReadOnly = true;
            this.txtFindP.Size = new System.Drawing.Size(76, 20);
            this.txtFindP.TabIndex = 36;
            // 
            // txtNdecryption
            // 
            this.txtNdecryption.Location = new System.Drawing.Point(212, 316);
            this.txtNdecryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNdecryption.Name = "txtNdecryption";
            this.txtNdecryption.Size = new System.Drawing.Size(76, 20);
            this.txtNdecryption.TabIndex = 37;
            this.txtNdecryption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNdecryption_KeyPress);
            // 
            // txtDdecryption
            // 
            this.txtDdecryption.Location = new System.Drawing.Point(524, 459);
            this.txtDdecryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDdecryption.Name = "txtDdecryption";
            this.txtDdecryption.ReadOnly = true;
            this.txtDdecryption.Size = new System.Drawing.Size(74, 20);
            this.txtDdecryption.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 20);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "e in this algorythm is:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(261, 37);
            this.txtE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(76, 20);
            this.txtE.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.Location = new System.Drawing.Point(10, 298);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(170, 13);
            this.label17.TabIndex = 42;
            this.label17.Text = "Enter e and n for decryption:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(319, 462);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Φ =";
            // 
            // txtPhiDecryption
            // 
            this.txtPhiDecryption.Location = new System.Drawing.Point(346, 459);
            this.txtPhiDecryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhiDecryption.Name = "txtPhiDecryption";
            this.txtPhiDecryption.ReadOnly = true;
            this.txtPhiDecryption.Size = new System.Drawing.Size(76, 20);
            this.txtPhiDecryption.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(80, 317);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "e =";
            // 
            // txtEdecryption
            // 
            this.txtEdecryption.Location = new System.Drawing.Point(106, 316);
            this.txtEdecryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEdecryption.Name = "txtEdecryption";
            this.txtEdecryption.Size = new System.Drawing.Size(76, 20);
            this.txtEdecryption.TabIndex = 46;
            this.txtEdecryption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdecryption_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label20.Location = new System.Drawing.Point(319, 320);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(209, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Open and select file from database:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(291, 318);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "OR";
            // 
            // rSAtableBindingSource
            // 
            this.rSAtableBindingSource.DataMember = "RSAtable";
            this.rSAtableBindingSource.DataSource = this.rSADataSet;
            // 
            // rSADataSet
            // 
            this.rSADataSet.DataSetName = "RSADataSet";
            this.rSADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rSAtableTableAdapter
            // 
            this.rSAtableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(322, 336);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(573, 118);
            this.dataGridView2.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtEdecryption);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtPhiDecryption);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label16);
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
            this.Controls.Add(this.btnSaveEncrypted);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "RSA ALGORYTHM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rSAtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.Button btnSaveEncrypted;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPhiDecryption;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtEdecryption;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private RSADataSet rSADataSet;
        private System.Windows.Forms.BindingSource rSAtableBindingSource;
        private RSADataSetTableAdapters.RSAtableTableAdapter rSAtableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

