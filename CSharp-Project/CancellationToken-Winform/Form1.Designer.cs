namespace TimeTakes_Winform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.Button();
            this.pnlLight4 = new System.Windows.Forms.Panel();
            this.pnlLight3 = new System.Windows.Forms.Panel();
            this.pnlLight2 = new System.Windows.Forms.Panel();
            this.pnlLight1 = new System.Windows.Forms.Panel();
            this.btnAsyncPower = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAsyncPower);
            this.panel1.Controls.Add(this.btnPower);
            this.panel1.Controls.Add(this.pnlLight4);
            this.panel1.Controls.Add(this.pnlLight3);
            this.panel1.Controls.Add(this.pnlLight2);
            this.panel1.Controls.Add(this.pnlLight1);
            this.panel1.Location = new System.Drawing.Point(171, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 195);
            this.panel1.TabIndex = 0;
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(85, 122);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(83, 23);
            this.btnPower.TabIndex = 1;
            this.btnPower.Text = "sync power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // pnlLight4
            // 
            this.pnlLight4.BackColor = System.Drawing.Color.Gray;
            this.pnlLight4.Location = new System.Drawing.Point(238, 24);
            this.pnlLight4.Name = "pnlLight4";
            this.pnlLight4.Size = new System.Drawing.Size(47, 26);
            this.pnlLight4.TabIndex = 2;
            // 
            // pnlLight3
            // 
            this.pnlLight3.BackColor = System.Drawing.Color.Gray;
            this.pnlLight3.Location = new System.Drawing.Point(171, 24);
            this.pnlLight3.Name = "pnlLight3";
            this.pnlLight3.Size = new System.Drawing.Size(47, 26);
            this.pnlLight3.TabIndex = 2;
            // 
            // pnlLight2
            // 
            this.pnlLight2.BackColor = System.Drawing.Color.Gray;
            this.pnlLight2.Location = new System.Drawing.Point(104, 24);
            this.pnlLight2.Name = "pnlLight2";
            this.pnlLight2.Size = new System.Drawing.Size(47, 26);
            this.pnlLight2.TabIndex = 1;
            // 
            // pnlLight1
            // 
            this.pnlLight1.BackColor = System.Drawing.Color.Gray;
            this.pnlLight1.Location = new System.Drawing.Point(39, 24);
            this.pnlLight1.Name = "pnlLight1";
            this.pnlLight1.Size = new System.Drawing.Size(47, 26);
            this.pnlLight1.TabIndex = 0;
            // 
            // btnAsyncPower
            // 
            this.btnAsyncPower.Location = new System.Drawing.Point(183, 122);
            this.btnAsyncPower.Name = "btnAsyncPower";
            this.btnAsyncPower.Size = new System.Drawing.Size(83, 23);
            this.btnAsyncPower.TabIndex = 3;
            this.btnAsyncPower.Text = "async power";
            this.btnAsyncPower.UseVisualStyleBackColor = true;
            this.btnAsyncPower.Click += new System.EventHandler(this.btnAsyncPower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel pnlLight4;
        private Panel pnlLight3;
        private Panel pnlLight2;
        private Panel pnlLight1;
        private Button btnPower;
        private Button btnAsyncPower;
    }
}