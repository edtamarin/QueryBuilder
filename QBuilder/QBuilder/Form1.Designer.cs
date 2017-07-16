namespace QBuilder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.connLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.queryTypeTC = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.selQueryTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.insQueryTB = new System.Windows.Forms.TextBox();
            this.delQueryTB = new System.Windows.Forms.TextBox();
            this.delExecuteButton = new System.Windows.Forms.Button();
            this.selExecuteButton = new System.Windows.Forms.Button();
            this.queryTypeTC.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect to the database:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1445, 2);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server:";
            // 
            // serverTB
            // 
            this.serverTB.Location = new System.Drawing.Point(181, 63);
            this.serverTB.Name = "serverTB";
            this.serverTB.Size = new System.Drawing.Size(1276, 38);
            this.serverTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database:";
            // 
            // databaseTB
            // 
            this.databaseTB.Location = new System.Drawing.Point(181, 115);
            this.databaseTB.Name = "databaseTB";
            this.databaseTB.Size = new System.Drawing.Size(1276, 38);
            this.databaseTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username:";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(181, 169);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(235, 38);
            this.userTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(586, 169);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(235, 38);
            this.passTB.TabIndex = 9;
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.Location = new System.Drawing.Point(1086, 166);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(176, 42);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconButton
            // 
            this.disconButton.AutoSize = true;
            this.disconButton.Location = new System.Drawing.Point(1281, 166);
            this.disconButton.Name = "disconButton";
            this.disconButton.Size = new System.Drawing.Size(176, 42);
            this.disconButton.TabIndex = 11;
            this.disconButton.Text = "Close";
            this.disconButton.UseVisualStyleBackColor = true;
            this.disconButton.Click += new System.EventHandler(this.disconButton_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1445, 2);
            this.label7.TabIndex = 12;
            // 
            // connLabel
            // 
            this.connLabel.AutoSize = true;
            this.connLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connLabel.Location = new System.Drawing.Point(998, 9);
            this.connLabel.Name = "connLabel";
            this.connLabel.Size = new System.Drawing.Size(0, 32);
            this.connLabel.TabIndex = 13;
            // 
            // loadButton
            // 
            this.loadButton.AutoSize = true;
            this.loadButton.Location = new System.Drawing.Point(961, 166);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(92, 42);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.saveLoadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.Location = new System.Drawing.Point(863, 166);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 42);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(245, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Construct a query:";
            // 
            // queryTypeTC
            // 
            this.queryTypeTC.Controls.Add(this.tabPage1);
            this.queryTypeTC.Controls.Add(this.tabPage2);
            this.queryTypeTC.Controls.Add(this.tabPage3);
            this.queryTypeTC.Location = new System.Drawing.Point(12, 268);
            this.queryTypeTC.Name = "queryTypeTC";
            this.queryTypeTC.SelectedIndex = 0;
            this.queryTypeTC.Size = new System.Drawing.Size(1445, 641);
            this.queryTypeTC.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.selExecuteButton);
            this.tabPage1.Controls.Add(this.selQueryTB);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1425, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Query:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.insQueryTB);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1425, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.delExecuteButton);
            this.tabPage3.Controls.Add(this.delQueryTB);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1425, 583);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DELETE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // selQueryTB
            // 
            this.selQueryTB.Location = new System.Drawing.Point(12, 38);
            this.selQueryTB.Multiline = true;
            this.selQueryTB.Name = "selQueryTB";
            this.selQueryTB.Size = new System.Drawing.Size(1407, 407);
            this.selQueryTB.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Query:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Query:";
            // 
            // insQueryTB
            // 
            this.insQueryTB.Location = new System.Drawing.Point(12, 38);
            this.insQueryTB.Multiline = true;
            this.insQueryTB.Name = "insQueryTB";
            this.insQueryTB.Size = new System.Drawing.Size(1407, 407);
            this.insQueryTB.TabIndex = 2;
            // 
            // delQueryTB
            // 
            this.delQueryTB.Location = new System.Drawing.Point(12, 38);
            this.delQueryTB.Multiline = true;
            this.delQueryTB.Name = "delQueryTB";
            this.delQueryTB.Size = new System.Drawing.Size(1407, 407);
            this.delQueryTB.TabIndex = 2;
            // 
            // delExecuteButton
            // 
            this.delExecuteButton.AutoSize = true;
            this.delExecuteButton.Location = new System.Drawing.Point(12, 451);
            this.delExecuteButton.Name = "delExecuteButton";
            this.delExecuteButton.Size = new System.Drawing.Size(206, 42);
            this.delExecuteButton.TabIndex = 18;
            this.delExecuteButton.Text = "Execute query";
            this.delExecuteButton.UseVisualStyleBackColor = true;
            // 
            // selExecuteButton
            // 
            this.selExecuteButton.AutoSize = true;
            this.selExecuteButton.Location = new System.Drawing.Point(14, 451);
            this.selExecuteButton.Name = "selExecuteButton";
            this.selExecuteButton.Size = new System.Drawing.Size(242, 42);
            this.selExecuteButton.TabIndex = 2;
            this.selExecuteButton.Text = "Execute query";
            this.selExecuteButton.UseVisualStyleBackColor = true;
            this.selExecuteButton.Click += new System.EventHandler(this.selExecuteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1469, 976);
            this.Controls.Add(this.queryTypeTC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.connLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.disconButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.databaseTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QBuilder";
            this.queryTypeTC.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databaseTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label connLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl queryTypeTC;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox selQueryTB;
        private System.Windows.Forms.TextBox insQueryTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox delQueryTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button selExecuteButton;
        private System.Windows.Forms.Button delExecuteButton;
    }
}

