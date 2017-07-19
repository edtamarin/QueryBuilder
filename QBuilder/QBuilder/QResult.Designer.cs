namespace QBuilder
{
    partial class QResult
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
            this.queryData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.queryData)).BeginInit();
            this.SuspendLayout();
            // 
            // queryData
            // 
            this.queryData.AllowUserToAddRows = false;
            this.queryData.AllowUserToDeleteRows = false;
            this.queryData.AllowUserToResizeRows = false;
            this.queryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.queryData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.queryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryData.Location = new System.Drawing.Point(12, 12);
            this.queryData.Name = "queryData";
            this.queryData.ReadOnly = true;
            this.queryData.RowTemplate.Height = 40;
            this.queryData.Size = new System.Drawing.Size(1109, 576);
            this.queryData.TabIndex = 0;
            this.queryData.SizeChanged += new System.EventHandler(this.queryData_SizeChanged);
            // 
            // QResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1157, 605);
            this.Controls.Add(this.queryData);
            this.Name = "QResult";
            this.Text = "Query result";
            ((System.ComponentModel.ISupportInitialize)(this.queryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView queryData;
    }
}