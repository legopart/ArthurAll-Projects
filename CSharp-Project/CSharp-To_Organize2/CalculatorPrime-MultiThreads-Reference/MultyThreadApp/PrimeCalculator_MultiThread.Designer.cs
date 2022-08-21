namespace MultyThreadApp
{
    partial class PrimeCalculator_MultiThread
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
            this.txtRangeStart = new System.Windows.Forms.TextBox();
            this.txtRangeEnd = new System.Windows.Forms.TextBox();
            this.lbxRangeResults = new System.Windows.Forms.ListBox();
            this.btnCalculateRange = new System.Windows.Forms.Button();
            this.lblRangeStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRangeStart
            // 
            this.txtRangeStart.Location = new System.Drawing.Point(190, 122);
            this.txtRangeStart.Name = "txtRangeStart";
            this.txtRangeStart.Size = new System.Drawing.Size(125, 27);
            this.txtRangeStart.TabIndex = 0;
            // 
            // txtRangeEnd
            // 
            this.txtRangeEnd.Location = new System.Drawing.Point(190, 174);
            this.txtRangeEnd.Name = "txtRangeEnd";
            this.txtRangeEnd.Size = new System.Drawing.Size(125, 27);
            this.txtRangeEnd.TabIndex = 1;
            // 
            // lbxRangeResults
            // 
            this.lbxRangeResults.FormattingEnabled = true;
            this.lbxRangeResults.ItemHeight = 20;
            this.lbxRangeResults.Location = new System.Drawing.Point(353, 82);
            this.lbxRangeResults.Name = "lbxRangeResults";
            this.lbxRangeResults.Size = new System.Drawing.Size(150, 204);
            this.lbxRangeResults.TabIndex = 2;
            // 
            // btnCalculateRange
            // 
            this.btnCalculateRange.Location = new System.Drawing.Point(208, 219);
            this.btnCalculateRange.Name = "btnCalculateRange";
            this.btnCalculateRange.Size = new System.Drawing.Size(94, 29);
            this.btnCalculateRange.TabIndex = 3;
            this.btnCalculateRange.Text = "Calculate";
            this.btnCalculateRange.UseVisualStyleBackColor = true;
            this.btnCalculateRange.Click += new System.EventHandler(this.btnCalculateRange_Click);
            // 
            // lblRangeStart
            // 
            this.lblRangeStart.AutoSize = true;
            this.lblRangeStart.Location = new System.Drawing.Point(190, 99);
            this.lblRangeStart.Name = "lblRangeStart";
            this.lblRangeStart.Size = new System.Drawing.Size(40, 20);
            this.lblRangeStart.TabIndex = 4;
            this.lblRangeStart.Text = "Start";
            // 
            // PrimeCalculator_MultiThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRangeStart);
            this.Controls.Add(this.btnCalculateRange);
            this.Controls.Add(this.lbxRangeResults);
            this.Controls.Add(this.txtRangeEnd);
            this.Controls.Add(this.txtRangeStart);
            this.Name = "PrimeCalculator_MultiThread";
            this.Text = "PrimeCalculatur MultyThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRangeStart;
        private TextBox txtRangeEnd;
        private ListBox lbxRangeResults;
        private Button btnCalculateRange;
        private Label lblRangeStart;
    }
}