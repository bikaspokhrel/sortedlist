namespace sortedlist
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
            this.lbxRunnerList = new System.Windows.Forms.ListBox();
            this.btnLoadRunners = new System.Windows.Forms.Button();
            this.btnAddRunner = new System.Windows.Forms.Button();
            this.txtRunnerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxRunnerList
            // 
            this.lbxRunnerList.FormattingEnabled = true;
            this.lbxRunnerList.ItemHeight = 16;
            this.lbxRunnerList.Location = new System.Drawing.Point(67, 79);
            this.lbxRunnerList.Name = "lbxRunnerList";
            this.lbxRunnerList.Size = new System.Drawing.Size(189, 260);
            this.lbxRunnerList.TabIndex = 0;
            // 
            // btnLoadRunners
            // 
            this.btnLoadRunners.Location = new System.Drawing.Point(536, 106);
            this.btnLoadRunners.Name = "btnLoadRunners";
            this.btnLoadRunners.Size = new System.Drawing.Size(132, 36);
            this.btnLoadRunners.TabIndex = 1;
            this.btnLoadRunners.Text = "Load Runners";
            this.btnLoadRunners.UseVisualStyleBackColor = true;
            this.btnLoadRunners.Click += new System.EventHandler(this.BtnLoadRunners_Click);
            // 
            // btnAddRunner
            // 
            this.btnAddRunner.Location = new System.Drawing.Point(536, 189);
            this.btnAddRunner.Name = "btnAddRunner";
            this.btnAddRunner.Size = new System.Drawing.Size(139, 36);
            this.btnAddRunner.TabIndex = 2;
            this.btnAddRunner.Text = "Add New Runner";
            this.btnAddRunner.UseVisualStyleBackColor = true;
            this.btnAddRunner.Click += new System.EventHandler(this.BtnAddRunner_Click);
            // 
            // txtRunnerName
            // 
            this.txtRunnerName.Location = new System.Drawing.Point(536, 148);
            this.txtRunnerName.Name = "txtRunnerName";
            this.txtRunnerName.Size = new System.Drawing.Size(197, 22);
            this.txtRunnerName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRunnerName);
            this.Controls.Add(this.btnAddRunner);
            this.Controls.Add(this.btnLoadRunners);
            this.Controls.Add(this.lbxRunnerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRunnerList;
        private System.Windows.Forms.Button btnLoadRunners;
        private System.Windows.Forms.Button btnAddRunner;
        private System.Windows.Forms.TextBox txtRunnerName;
    }
}

