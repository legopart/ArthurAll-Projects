namespace SuperWinForms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEventReset = new System.Windows.Forms.Button();
            this.btnRunEvent = new System.Windows.Forms.Button();
            this.btnEventDecrese = new System.Windows.Forms.Button();
            this.btnEventMult = new System.Windows.Forms.Button();
            this.lblEventInited = new System.Windows.Forms.Label();
            this.btnEventAdd = new System.Windows.Forms.Button();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDeligate = new System.Windows.Forms.Label();
            this.btnMult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEventActions = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEventActions);
            this.tabPage1.Controls.Add(this.btnEventReset);
            this.tabPage1.Controls.Add(this.btnRunEvent);
            this.tabPage1.Controls.Add(this.btnEventDecrese);
            this.tabPage1.Controls.Add(this.btnEventMult);
            this.tabPage1.Controls.Add(this.lblEventInited);
            this.tabPage1.Controls.Add(this.btnEventAdd);
            this.tabPage1.Controls.Add(this.lblEvent);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.txtCount);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.lblDeligate);
            this.tabPage1.Controls.Add(this.btnMult);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEventReset
            // 
            this.btnEventReset.Location = new System.Drawing.Point(281, 89);
            this.btnEventReset.Name = "btnEventReset";
            this.btnEventReset.Size = new System.Drawing.Size(44, 23);
            this.btnEventReset.TabIndex = 13;
            this.btnEventReset.Text = "Reset";
            this.btnEventReset.UseVisualStyleBackColor = true;
            this.btnEventReset.Click += new System.EventHandler(this.btnEventReset_Click);
            // 
            // btnRunEvent
            // 
            this.btnRunEvent.Location = new System.Drawing.Point(222, 89);
            this.btnRunEvent.Name = "btnRunEvent";
            this.btnRunEvent.Size = new System.Drawing.Size(44, 23);
            this.btnRunEvent.TabIndex = 12;
            this.btnRunEvent.Text = "Run";
            this.btnRunEvent.UseVisualStyleBackColor = true;
            this.btnRunEvent.Click += new System.EventHandler(this.btnRunEvent_Click);
            // 
            // btnEventDecrese
            // 
            this.btnEventDecrese.Location = new System.Drawing.Point(158, 89);
            this.btnEventDecrese.Name = "btnEventDecrese";
            this.btnEventDecrese.Size = new System.Drawing.Size(44, 23);
            this.btnEventDecrese.TabIndex = 11;
            this.btnEventDecrese.Text = "-2";
            this.btnEventDecrese.UseVisualStyleBackColor = true;
            this.btnEventDecrese.Click += new System.EventHandler(this.btnEventDecrese_Click);
            // 
            // btnEventMult
            // 
            this.btnEventMult.Location = new System.Drawing.Point(92, 89);
            this.btnEventMult.Name = "btnEventMult";
            this.btnEventMult.Size = new System.Drawing.Size(44, 23);
            this.btnEventMult.TabIndex = 10;
            this.btnEventMult.Text = "*2";
            this.btnEventMult.UseVisualStyleBackColor = true;
            this.btnEventMult.Click += new System.EventHandler(this.btnEventMult_Click);
            // 
            // lblEventInited
            // 
            this.lblEventInited.AutoSize = true;
            this.lblEventInited.Location = new System.Drawing.Point(79, 62);
            this.lblEventInited.Name = "lblEventInited";
            this.lblEventInited.Size = new System.Drawing.Size(57, 15);
            this.lblEventInited.TabIndex = 9;
            this.lblEventInited.Text = "Inited = 1";
            // 
            // btnEventAdd
            // 
            this.btnEventAdd.Location = new System.Drawing.Point(27, 89);
            this.btnEventAdd.Name = "btnEventAdd";
            this.btnEventAdd.Size = new System.Drawing.Size(44, 23);
            this.btnEventAdd.TabIndex = 8;
            this.btnEventAdd.Text = "+2";
            this.btnEventAdd.UseVisualStyleBackColor = true;
            this.btnEventAdd.Click += new System.EventHandler(this.btnEventAdd_Click);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(27, 62);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(36, 15);
            this.lblEvent.TabIndex = 7;
            this.lblEvent.Text = "Event";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(504, 8);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(40, 15);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Count";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(504, 27);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(57, 23);
            this.txtCount.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(330, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 15);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // lblDeligate
            // 
            this.lblDeligate.AutoSize = true;
            this.lblDeligate.Location = new System.Drawing.Point(32, 5);
            this.lblDeligate.Name = "lblDeligate";
            this.lblDeligate.Size = new System.Drawing.Size(50, 15);
            this.lblDeligate.TabIndex = 3;
            this.lblDeligate.Text = "Deligate";
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(127, 26);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 2;
            this.btnMult.Text = "Mult 5*6";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(330, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(168, 23);
            this.txtResult.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add5+6";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblEventActions
            // 
            this.lblEventActions.AutoSize = true;
            this.lblEventActions.Location = new System.Drawing.Point(344, 93);
            this.lblEventActions.Name = "lblEventActions";
            this.lblEventActions.Size = new System.Drawing.Size(10, 15);
            this.lblEventActions.TabIndex = 14;
            this.lblEventActions.Text = "|";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnAdd;
        private TabPage tabPage2;
        private TextBox txtResult;
        private Button btnMult;
        private Label lblDeligate;
        private Label lblEvent;
        private Label lblCount;
        private TextBox txtCount;
        private Label lblResult;
        private Button btnEventAdd;
        private Label lblEventInited;
        private Button btnEventMult;
        private Button btnRunEvent;
        private Button btnEventDecrese;
        private Button btnEventReset;
        private Label lblEventActions;
    }
}