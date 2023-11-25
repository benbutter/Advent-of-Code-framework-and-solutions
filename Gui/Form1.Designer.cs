namespace Gui
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenFile = new Button();
            lstSolvers = new ListBox();
            label1 = new Label();
            lblSummary = new Label();
            btnRun = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(59, 290);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(94, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Select File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // lstSolvers
            // 
            lstSolvers.FormattingEnabled = true;
            lstSolvers.ItemHeight = 20;
            lstSolvers.Location = new Point(59, 56);
            lstSolvers.Name = "lstSolvers";
            lstSolvers.Size = new Size(362, 204);
            lstSolvers.TabIndex = 1;
            lstSolvers.SelectedValueChanged += lstSolvers_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 23);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Solver";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(61, 328);
            lblSummary.MaximumSize = new Size(400, 0);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(0, 20);
            lblSummary.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(59, 392);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 4;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(59, 442);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 466);
            Controls.Add(lblResult);
            Controls.Add(btnRun);
            Controls.Add(lblSummary);
            Controls.Add(label1);
            Controls.Add(lstSolvers);
            Controls.Add(btnOpenFile);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private ListBox lstSolvers;
        private Label label1;
        private Label lblSummary;
        private Button btnRun;
        private Label lblResult;
    }
}