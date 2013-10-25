namespace DatabaseFormAC
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
            this.gobtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.gototxt = new System.Windows.Forms.TextBox();
            this.updatetxt = new System.Windows.Forms.TextBox();
            this.deletetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Marina_numtxt = new System.Windows.Forms.TextBox();
            this.Marina_nametxt = new System.Windows.Forms.TextBox();
            this.Marina_addresstxt = new System.Windows.Forms.TextBox();
            this.Marina_citytxt = new System.Windows.Forms.TextBox();
            this.Marina_statetxt = new System.Windows.Forms.TextBox();
            this.Marina_ziptxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.newRecordbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gobtn
            // 
            this.gobtn.Location = new System.Drawing.Point(149, 18);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(75, 23);
            this.gobtn.TabIndex = 0;
            this.gobtn.Text = "GO";
            this.gobtn.UseVisualStyleBackColor = true;
            this.gobtn.Click += new System.EventHandler(this.gobtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(149, 47);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(120, 23);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Commit Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(149, 287);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // gototxt
            // 
            this.gototxt.Location = new System.Drawing.Point(117, 21);
            this.gototxt.Name = "gototxt";
            this.gototxt.Size = new System.Drawing.Size(26, 20);
            this.gototxt.TabIndex = 3;
            // 
            // updatetxt
            // 
            this.updatetxt.Location = new System.Drawing.Point(117, 49);
            this.updatetxt.Name = "updatetxt";
            this.updatetxt.Size = new System.Drawing.Size(26, 20);
            this.updatetxt.TabIndex = 4;
            // 
            // deletetxt
            // 
            this.deletetxt.Location = new System.Drawing.Point(117, 290);
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(26, 20);
            this.deletetxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "GOTO Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "UPDATE Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DELETE Record";
            // 
            // Marina_numtxt
            // 
            this.Marina_numtxt.Location = new System.Drawing.Point(117, 100);
            this.Marina_numtxt.Name = "Marina_numtxt";
            this.Marina_numtxt.Size = new System.Drawing.Size(152, 20);
            this.Marina_numtxt.TabIndex = 9;
            // 
            // Marina_nametxt
            // 
            this.Marina_nametxt.Location = new System.Drawing.Point(117, 127);
            this.Marina_nametxt.Name = "Marina_nametxt";
            this.Marina_nametxt.Size = new System.Drawing.Size(152, 20);
            this.Marina_nametxt.TabIndex = 10;
            // 
            // Marina_addresstxt
            // 
            this.Marina_addresstxt.Location = new System.Drawing.Point(117, 154);
            this.Marina_addresstxt.Name = "Marina_addresstxt";
            this.Marina_addresstxt.Size = new System.Drawing.Size(152, 20);
            this.Marina_addresstxt.TabIndex = 11;
            // 
            // Marina_citytxt
            // 
            this.Marina_citytxt.Location = new System.Drawing.Point(117, 181);
            this.Marina_citytxt.Name = "Marina_citytxt";
            this.Marina_citytxt.Size = new System.Drawing.Size(152, 20);
            this.Marina_citytxt.TabIndex = 12;
            // 
            // Marina_statetxt
            // 
            this.Marina_statetxt.Location = new System.Drawing.Point(117, 208);
            this.Marina_statetxt.Name = "Marina_statetxt";
            this.Marina_statetxt.Size = new System.Drawing.Size(152, 20);
            this.Marina_statetxt.TabIndex = 13;
            // 
            // Marina_ziptxt
            // 
            this.Marina_ziptxt.Location = new System.Drawing.Point(117, 235);
            this.Marina_ziptxt.Name = "Marina_ziptxt";
            this.Marina_ziptxt.Size = new System.Drawing.Size(152, 20);
            this.Marina_ziptxt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Marina_num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marina_name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Marina_address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Marina_city";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Marina_state";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Marina_zip";
            // 
            // newRecordbtn
            // 
            this.newRecordbtn.Location = new System.Drawing.Point(15, 317);
            this.newRecordbtn.Name = "newRecordbtn";
            this.newRecordbtn.Size = new System.Drawing.Size(102, 23);
            this.newRecordbtn.TabIndex = 21;
            this.newRecordbtn.Text = "New Record";
            this.newRecordbtn.UseVisualStyleBackColor = true;
            this.newRecordbtn.Click += new System.EventHandler(this.newRecordbtn_Click);
            // 
            // submitbtn
            // 
            this.submitbtn.Location = new System.Drawing.Point(149, 317);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(120, 23);
            this.submitbtn.TabIndex = 22;
            this.submitbtn.Text = "Commit New Record";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 352);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.newRecordbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Marina_ziptxt);
            this.Controls.Add(this.Marina_statetxt);
            this.Controls.Add(this.Marina_citytxt);
            this.Controls.Add(this.Marina_addresstxt);
            this.Controls.Add(this.Marina_nametxt);
            this.Controls.Add(this.Marina_numtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletetxt);
            this.Controls.Add(this.updatetxt);
            this.Controls.Add(this.gototxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.gobtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alexamara.Marina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gobtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox gototxt;
        private System.Windows.Forms.TextBox updatetxt;
        private System.Windows.Forms.TextBox deletetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Marina_numtxt;
        private System.Windows.Forms.TextBox Marina_nametxt;
        private System.Windows.Forms.TextBox Marina_addresstxt;
        private System.Windows.Forms.TextBox Marina_citytxt;
        private System.Windows.Forms.TextBox Marina_statetxt;
        private System.Windows.Forms.TextBox Marina_ziptxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button newRecordbtn;
        private System.Windows.Forms.Button submitbtn;
    }
}

