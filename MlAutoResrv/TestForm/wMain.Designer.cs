namespace TestForm
{
    partial class wMain
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
            this.ocmSend = new System.Windows.Forms.Button();
            this.otbResult = new System.Windows.Forms.RichTextBox();
            this.otbURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ocmSetHead = new System.Windows.Forms.Button();
            this.otbEANUpc = new System.Windows.Forms.TextBox();
            this.otbPlant = new System.Windows.Forms.TextBox();
            this.otbEntryUom = new System.Windows.Forms.TextBox();
            this.otbEntryQnt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.otbMoveType = new System.Windows.Forms.TextBox();
            this.otbMovePlant = new System.Windows.Forms.TextBox();
            this.otbStgrLoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ocmAddItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otbStore = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.otbPosTransId = new System.Windows.Forms.TextBox();
            this.otbPstngDate = new System.Windows.Forms.TextBox();
            this.otbDocDate = new System.Windows.Forms.TextBox();
            this.ocbAction = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ocmAddSerial = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.otbSerialNo = new System.Windows.Forms.TextBox();
            this.otbMatDocItm = new System.Windows.Forms.TextBox();
            this.olbPostItem = new System.Windows.Forms.TreeView();
            this.label17 = new System.Windows.Forms.Label();
            this.ocmDelete = new System.Windows.Forms.Button();
            this.otbUsername = new System.Windows.Forms.TextBox();
            this.otbPassword = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ocmSend
            // 
            this.ocmSend.Location = new System.Drawing.Point(559, 296);
            this.ocmSend.Name = "ocmSend";
            this.ocmSend.Size = new System.Drawing.Size(75, 23);
            this.ocmSend.TabIndex = 0;
            this.ocmSend.Text = "Send";
            this.ocmSend.UseVisualStyleBackColor = true;
            this.ocmSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // otbResult
            // 
            this.otbResult.Location = new System.Drawing.Point(344, 345);
            this.otbResult.Name = "otbResult";
            this.otbResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.otbResult.Size = new System.Drawing.Size(290, 79);
            this.otbResult.TabIndex = 1;
            this.otbResult.Text = "";
            // 
            // otbURL
            // 
            this.otbURL.Location = new System.Drawing.Point(8, 21);
            this.otbURL.Name = "otbURL";
            this.otbURL.Size = new System.Drawing.Size(330, 20);
            this.otbURL.TabIndex = 2;
            this.otbURL.Text = "http://wdipid.themall.co.th:8080/RESTAdapter/TMGPOS/v1/ReceiveReservation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // ocmSetHead
            // 
            this.ocmSetHead.Location = new System.Drawing.Point(267, 25);
            this.ocmSetHead.Name = "ocmSetHead";
            this.ocmSetHead.Size = new System.Drawing.Size(54, 23);
            this.ocmSetHead.TabIndex = 15;
            this.ocmSetHead.Text = "Set";
            this.ocmSetHead.UseVisualStyleBackColor = true;
            this.ocmSetHead.Click += new System.EventHandler(this.ocmSetHead_Click);
            // 
            // otbEANUpc
            // 
            this.otbEANUpc.Location = new System.Drawing.Point(49, 32);
            this.otbEANUpc.Name = "otbEANUpc";
            this.otbEANUpc.Size = new System.Drawing.Size(101, 20);
            this.otbEANUpc.TabIndex = 16;
            // 
            // otbPlant
            // 
            this.otbPlant.Location = new System.Drawing.Point(161, 32);
            this.otbPlant.Name = "otbPlant";
            this.otbPlant.Size = new System.Drawing.Size(100, 20);
            this.otbPlant.TabIndex = 17;
            // 
            // otbEntryUom
            // 
            this.otbEntryUom.Location = new System.Drawing.Point(50, 73);
            this.otbEntryUom.Name = "otbEntryUom";
            this.otbEntryUom.Size = new System.Drawing.Size(100, 20);
            this.otbEntryUom.TabIndex = 18;
            // 
            // otbEntryQnt
            // 
            this.otbEntryQnt.Location = new System.Drawing.Point(161, 73);
            this.otbEntryQnt.Name = "otbEntryQnt";
            this.otbEntryQnt.Size = new System.Drawing.Size(100, 20);
            this.otbEntryQnt.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "EAN_UPC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "PLANT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "ENTRY_UOM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "ENTRY_QNT";
            // 
            // otbMoveType
            // 
            this.otbMoveType.Location = new System.Drawing.Point(50, 115);
            this.otbMoveType.Name = "otbMoveType";
            this.otbMoveType.Size = new System.Drawing.Size(99, 20);
            this.otbMoveType.TabIndex = 25;
            // 
            // otbMovePlant
            // 
            this.otbMovePlant.Location = new System.Drawing.Point(161, 115);
            this.otbMovePlant.Name = "otbMovePlant";
            this.otbMovePlant.Size = new System.Drawing.Size(100, 20);
            this.otbMovePlant.TabIndex = 26;
            // 
            // otbStgrLoc
            // 
            this.otbStgrLoc.Location = new System.Drawing.Point(50, 154);
            this.otbStgrLoc.Name = "otbStgrLoc";
            this.otbStgrLoc.Size = new System.Drawing.Size(100, 20);
            this.otbStgrLoc.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "MOVE_TYPE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "MOVE_PLANT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "STGR_LOC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ocmAddItem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.otbEANUpc);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.otbPlant);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.otbEntryUom);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.otbEntryQnt);
            this.groupBox1.Controls.Add(this.otbStgrLoc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.otbMovePlant);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.otbMoveType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(8, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 183);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // ocmAddItem
            // 
            this.ocmAddItem.Enabled = false;
            this.ocmAddItem.Location = new System.Drawing.Point(163, 151);
            this.ocmAddItem.Name = "ocmAddItem";
            this.ocmAddItem.Size = new System.Drawing.Size(95, 23);
            this.ocmAddItem.TabIndex = 31;
            this.ocmAddItem.Text = "Add Item";
            this.ocmAddItem.UseVisualStyleBackColor = true;
            this.ocmAddItem.Click += new System.EventHandler(this.ocmAddItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otbStore);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.otbPosTransId);
            this.groupBox2.Controls.Add(this.otbPstngDate);
            this.groupBox2.Controls.Add(this.ocmSetHead);
            this.groupBox2.Controls.Add(this.otbDocDate);
            this.groupBox2.Controls.Add(this.ocbAction);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 130);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Header";
            // 
            // otbStore
            // 
            this.otbStore.Location = new System.Drawing.Point(47, 106);
            this.otbStore.Name = "otbStore";
            this.otbStore.Size = new System.Drawing.Size(100, 20);
            this.otbStore.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(45, 90);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "STORE";
            // 
            // otbPosTransId
            // 
            this.otbPosTransId.Location = new System.Drawing.Point(49, 66);
            this.otbPosTransId.Name = "otbPosTransId";
            this.otbPosTransId.Size = new System.Drawing.Size(100, 20);
            this.otbPosTransId.TabIndex = 7;
            // 
            // otbPstngDate
            // 
            this.otbPstngDate.Location = new System.Drawing.Point(50, 27);
            this.otbPstngDate.Name = "otbPstngDate";
            this.otbPstngDate.Size = new System.Drawing.Size(99, 20);
            this.otbPstngDate.TabIndex = 5;
            // 
            // otbDocDate
            // 
            this.otbDocDate.Location = new System.Drawing.Point(161, 27);
            this.otbDocDate.Name = "otbDocDate";
            this.otbDocDate.Size = new System.Drawing.Size(100, 20);
            this.otbDocDate.TabIndex = 6;
            // 
            // ocbAction
            // 
            this.ocbAction.FormattingEnabled = true;
            this.ocbAction.Items.AddRange(new object[] {
            "CREATE",
            "CHECK",
            "CANCEL"});
            this.ocbAction.Location = new System.Drawing.Point(161, 66);
            this.ocbAction.Name = "ocbAction";
            this.ocbAction.Size = new System.Drawing.Size(100, 21);
            this.ocbAction.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PSTNG_DATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ACTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "DOC_DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "POS_TRANSID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ocmAddSerial);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.otbSerialNo);
            this.groupBox3.Controls.Add(this.otbMatDocItm);
            this.groupBox3.Location = new System.Drawing.Point(8, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 90);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial";
            // 
            // ocmAddSerial
            // 
            this.ocmAddSerial.Enabled = false;
            this.ocmAddSerial.Location = new System.Drawing.Point(49, 56);
            this.ocmAddSerial.Name = "ocmAddSerial";
            this.ocmAddSerial.Size = new System.Drawing.Size(95, 23);
            this.ocmAddSerial.TabIndex = 37;
            this.ocmAddSerial.Text = "Add Serial";
            this.ocmAddSerial.UseVisualStyleBackColor = true;
            this.ocmAddSerial.Click += new System.EventHandler(this.ocmAddSerial_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "SERIALNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "MATDOC_ITM";
            // 
            // otbSerialNo
            // 
            this.otbSerialNo.Location = new System.Drawing.Point(161, 30);
            this.otbSerialNo.Name = "otbSerialNo";
            this.otbSerialNo.Size = new System.Drawing.Size(100, 20);
            this.otbSerialNo.TabIndex = 1;
            // 
            // otbMatDocItm
            // 
            this.otbMatDocItm.Location = new System.Drawing.Point(49, 30);
            this.otbMatDocItm.Name = "otbMatDocItm";
            this.otbMatDocItm.Size = new System.Drawing.Size(99, 20);
            this.otbMatDocItm.TabIndex = 0;
            // 
            // olbPostItem
            // 
            this.olbPostItem.Location = new System.Drawing.Point(344, 60);
            this.olbPostItem.Name = "olbPostItem";
            this.olbPostItem.Size = new System.Drawing.Size(290, 226);
            this.olbPostItem.TabIndex = 35;
            this.olbPostItem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.olbPostItem_AfterSelect);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(341, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Post Item";
            // 
            // ocmDelete
            // 
            this.ocmDelete.Enabled = false;
            this.ocmDelete.Location = new System.Drawing.Point(344, 296);
            this.ocmDelete.Name = "ocmDelete";
            this.ocmDelete.Size = new System.Drawing.Size(75, 23);
            this.ocmDelete.TabIndex = 37;
            this.ocmDelete.Text = "Delete";
            this.ocmDelete.UseVisualStyleBackColor = true;
            this.ocmDelete.Click += new System.EventHandler(this.ocmDelete_Click);
            // 
            // otbUsername
            // 
            this.otbUsername.Location = new System.Drawing.Point(344, 21);
            this.otbUsername.Name = "otbUsername";
            this.otbUsername.Size = new System.Drawing.Size(147, 20);
            this.otbUsername.TabIndex = 38;
            this.otbUsername.Text = "devposctr";
            // 
            // otbPassword
            // 
            this.otbPassword.Location = new System.Drawing.Point(497, 21);
            this.otbPassword.Name = "otbPassword";
            this.otbPassword.Size = new System.Drawing.Size(134, 20);
            this.otbPassword.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(341, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "User Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(494, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 457);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.otbPassword);
            this.Controls.Add(this.otbUsername);
            this.Controls.Add(this.ocmDelete);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.olbPostItem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otbURL);
            this.Controls.Add(this.otbResult);
            this.Controls.Add(this.ocmSend);
            this.Name = "Form1";
            this.Text = "Auto Reserve Stock";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ocmSend;
        private System.Windows.Forms.RichTextBox otbResult;
        private System.Windows.Forms.TextBox otbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ocmSetHead;
        private System.Windows.Forms.TextBox otbEANUpc;
        private System.Windows.Forms.TextBox otbPlant;
        private System.Windows.Forms.TextBox otbEntryUom;
        private System.Windows.Forms.TextBox otbEntryQnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox otbMoveType;
        private System.Windows.Forms.TextBox otbMovePlant;
        private System.Windows.Forms.TextBox otbStgrLoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ocmAddItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox otbPosTransId;
        private System.Windows.Forms.TextBox otbPstngDate;
        private System.Windows.Forms.TextBox otbDocDate;
        private System.Windows.Forms.ComboBox ocbAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ocmAddSerial;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox otbSerialNo;
        private System.Windows.Forms.TextBox otbMatDocItm;
        private System.Windows.Forms.TreeView olbPostItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ocmDelete;
        private System.Windows.Forms.TextBox otbUsername;
        private System.Windows.Forms.TextBox otbPassword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox otbStore;
        private System.Windows.Forms.Label label20;
    }
}

