namespace MathGUI
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
            this.boxA = new System.Windows.Forms.TextBox();
            this.boxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.divBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // boxA
            // 
            this.boxA.Location = new System.Drawing.Point(35, 12);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(237, 20);
            this.boxA.TabIndex = 1;
            // 
            // boxB
            // 
            this.boxB.Location = new System.Drawing.Point(35, 38);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(237, 20);
            this.boxB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B:";
            // 
            // divBtn
            // 
            this.divBtn.Location = new System.Drawing.Point(154, 120);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(118, 23);
            this.divBtn.TabIndex = 5;
            this.divBtn.Text = "Divide";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.DivClicked);
            // 
            // mulBtn
            // 
            this.mulBtn.Location = new System.Drawing.Point(12, 120);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(118, 23);
            this.mulBtn.TabIndex = 6;
            this.mulBtn.Text = "Multiply";
            this.mulBtn.UseVisualStyleBackColor = true;
            this.mulBtn.Click += new System.EventHandler(this.MulClicked);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(154, 91);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(118, 23);
            this.subBtn.TabIndex = 7;
            this.subBtn.Text = "Subtract";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.SubClicked);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(12, 91);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(118, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddClicked);
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(12, 65);
            this.ans.Name = "ans";
            this.ans.ReadOnly = true;
            this.ans.Size = new System.Drawing.Size(260, 20);
            this.ans.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.boxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Basic Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxA;
        private System.Windows.Forms.TextBox boxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox ans;
    }
}

