
namespace prKol_ind1_Borisov
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
            this.textBoxInfix = new System.Windows.Forms.TextBox();
            this.textBoxprefix = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInfix
            // 
            this.textBoxInfix.Location = new System.Drawing.Point(109, 116);
            this.textBoxInfix.Name = "textBoxInfix";
            this.textBoxInfix.Size = new System.Drawing.Size(100, 23);
            this.textBoxInfix.TabIndex = 0;
            // 
            // textBoxprefix
            // 
            this.textBoxprefix.Location = new System.Drawing.Point(304, 116);
            this.textBoxprefix.Name = "textBoxprefix";
            this.textBoxprefix.ReadOnly = true;
            this.textBoxprefix.Size = new System.Drawing.Size(100, 23);
            this.textBoxprefix.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Преобразовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Инфиксное выражение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Префиксное выражение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxprefix);
            this.Controls.Add(this.textBoxInfix);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfix;
        private System.Windows.Forms.TextBox textBoxprefix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

