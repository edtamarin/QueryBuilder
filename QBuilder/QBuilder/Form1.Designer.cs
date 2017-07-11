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
            this.disconButton.Text = "Disconnect";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1469, 750);
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
    }
}

