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
            this.connLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.selExecuteButton = new System.Windows.Forms.Button();
            this.selQueryTB = new System.Windows.Forms.TextBox();
            this.connectionGB = new System.Windows.Forms.GroupBox();
            this.queryGB = new System.Windows.Forms.GroupBox();
            this.connectionGB.SuspendLayout();
            this.queryGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server:";
            // 
            // serverTB
            // 
            this.serverTB.Location = new System.Drawing.Point(157, 45);
            this.serverTB.Name = "serverTB";
            this.serverTB.Size = new System.Drawing.Size(1276, 38);
            this.serverTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database:";
            // 
            // databaseTB
            // 
            this.databaseTB.Location = new System.Drawing.Point(157, 103);
            this.databaseTB.Name = "databaseTB";
            this.databaseTB.Size = new System.Drawing.Size(1276, 38);
            this.databaseTB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username:";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(157, 157);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(235, 38);
            this.userTB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(551, 157);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(235, 38);
            this.passTB.TabIndex = 9;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.Location = new System.Drawing.Point(1067, 154);
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
            this.disconButton.Location = new System.Drawing.Point(1257, 154);
            this.disconButton.Name = "disconButton";
            this.disconButton.Size = new System.Drawing.Size(176, 42);
            this.disconButton.TabIndex = 11;
            this.disconButton.Text = "Close";
            this.disconButton.UseVisualStyleBackColor = true;
            this.disconButton.Click += new System.EventHandler(this.disconButton_Click);
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
            this.loadButton.Location = new System.Drawing.Point(939, 154);
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
            this.saveButton.Location = new System.Drawing.Point(810, 154);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 42);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // selExecuteButton
            // 
            this.selExecuteButton.AutoSize = true;
            this.selExecuteButton.Location = new System.Drawing.Point(6, 450);
            this.selExecuteButton.Name = "selExecuteButton";
            this.selExecuteButton.Size = new System.Drawing.Size(242, 42);
            this.selExecuteButton.TabIndex = 2;
            this.selExecuteButton.Text = "Execute query";
            this.selExecuteButton.UseVisualStyleBackColor = true;
            this.selExecuteButton.Click += new System.EventHandler(this.selExecuteButton_Click);
            // 
            // selQueryTB
            // 
            this.selQueryTB.Location = new System.Drawing.Point(6, 37);
            this.selQueryTB.Multiline = true;
            this.selQueryTB.Name = "selQueryTB";
            this.selQueryTB.Size = new System.Drawing.Size(1407, 407);
            this.selQueryTB.TabIndex = 1;
            // 
            // connectionGB
            // 
            this.connectionGB.Controls.Add(this.disconButton);
            this.connectionGB.Controls.Add(this.loadButton);
            this.connectionGB.Controls.Add(this.saveButton);
            this.connectionGB.Controls.Add(this.connectButton);
            this.connectionGB.Controls.Add(this.serverTB);
            this.connectionGB.Controls.Add(this.label4);
            this.connectionGB.Controls.Add(this.label3);
            this.connectionGB.Controls.Add(this.label5);
            this.connectionGB.Controls.Add(this.databaseTB);
            this.connectionGB.Controls.Add(this.passTB);
            this.connectionGB.Controls.Add(this.userTB);
            this.connectionGB.Controls.Add(this.label6);
            this.connectionGB.Location = new System.Drawing.Point(18, 12);
            this.connectionGB.Name = "connectionGB";
            this.connectionGB.Size = new System.Drawing.Size(1439, 218);
            this.connectionGB.TabIndex = 17;
            this.connectionGB.TabStop = false;
            this.connectionGB.Text = "Connect to the database:";
            // 
            // queryGB
            // 
            this.queryGB.Controls.Add(this.selQueryTB);
            this.queryGB.Controls.Add(this.selExecuteButton);
            this.queryGB.Location = new System.Drawing.Point(18, 237);
            this.queryGB.Name = "queryGB";
            this.queryGB.Size = new System.Drawing.Size(1439, 517);
            this.queryGB.TabIndex = 18;
            this.queryGB.TabStop = false;
            this.queryGB.Text = "Construst a query";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1469, 765);
            this.Controls.Add(this.connLabel);
            this.Controls.Add(this.queryGB);
            this.Controls.Add(this.connectionGB);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QBuilder";
            this.connectionGB.ResumeLayout(false);
            this.connectionGB.PerformLayout();
            this.queryGB.ResumeLayout(false);
            this.queryGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label connLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox selQueryTB;
        private System.Windows.Forms.Button selExecuteButton;
        private System.Windows.Forms.GroupBox connectionGB;
        private System.Windows.Forms.GroupBox queryGB;
    }
}

