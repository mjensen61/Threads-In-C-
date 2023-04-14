namespace Threads_In_CSharp
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
            this.buttonThread1 = new System.Windows.Forms.Button();
            this.buttonThread2 = new System.Windows.Forms.Button();
            this.buttonThread3 = new System.Windows.Forms.Button();
            this.buttonThread4 = new System.Windows.Forms.Button();
            this.textBoxThread1 = new System.Windows.Forms.TextBox();
            this.textBoxThread2 = new System.Windows.Forms.TextBox();
            this.textBoxThread3 = new System.Windows.Forms.TextBox();
            this.textBoxThread4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonThread1
            // 
            this.buttonThread1.BackColor = System.Drawing.Color.Green;
            this.buttonThread1.Location = new System.Drawing.Point(42, 35);
            this.buttonThread1.Name = "buttonThread1";
            this.buttonThread1.Size = new System.Drawing.Size(122, 36);
            this.buttonThread1.TabIndex = 0;
            this.buttonThread1.Text = "Thread 1 Start";
            this.buttonThread1.UseVisualStyleBackColor = false;
            this.buttonThread1.Click += new System.EventHandler(this.buttonThread1_Click);
            // 
            // buttonThread2
            // 
            this.buttonThread2.BackColor = System.Drawing.Color.Green;
            this.buttonThread2.Location = new System.Drawing.Point(42, 77);
            this.buttonThread2.Name = "buttonThread2";
            this.buttonThread2.Size = new System.Drawing.Size(122, 36);
            this.buttonThread2.TabIndex = 1;
            this.buttonThread2.Text = "Thread 2 Start";
            this.buttonThread2.UseVisualStyleBackColor = false;
            this.buttonThread2.Click += new System.EventHandler(this.buttonThread2_Click);
            // 
            // buttonThread3
            // 
            this.buttonThread3.BackColor = System.Drawing.Color.Green;
            this.buttonThread3.Location = new System.Drawing.Point(42, 119);
            this.buttonThread3.Name = "buttonThread3";
            this.buttonThread3.Size = new System.Drawing.Size(122, 36);
            this.buttonThread3.TabIndex = 2;
            this.buttonThread3.Text = "Thread 3 Start";
            this.buttonThread3.UseVisualStyleBackColor = false;
            this.buttonThread3.Click += new System.EventHandler(this.buttonThread3_Click);
            // 
            // buttonThread4
            // 
            this.buttonThread4.BackColor = System.Drawing.Color.Green;
            this.buttonThread4.Location = new System.Drawing.Point(42, 161);
            this.buttonThread4.Name = "buttonThread4";
            this.buttonThread4.Size = new System.Drawing.Size(122, 36);
            this.buttonThread4.TabIndex = 3;
            this.buttonThread4.Text = "Thread 4 Start";
            this.buttonThread4.UseVisualStyleBackColor = false;
            this.buttonThread4.Click += new System.EventHandler(this.buttonThread4_Click);
            // 
            // textBoxThread1
            // 
            this.textBoxThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThread1.Location = new System.Drawing.Point(197, 36);
            this.textBoxThread1.Name = "textBoxThread1";
            this.textBoxThread1.Size = new System.Drawing.Size(204, 29);
            this.textBoxThread1.TabIndex = 4;
            // 
            // textBoxThread2
            // 
            this.textBoxThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThread2.Location = new System.Drawing.Point(197, 78);
            this.textBoxThread2.Name = "textBoxThread2";
            this.textBoxThread2.Size = new System.Drawing.Size(204, 29);
            this.textBoxThread2.TabIndex = 5;
            // 
            // textBoxThread3
            // 
            this.textBoxThread3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThread3.Location = new System.Drawing.Point(197, 120);
            this.textBoxThread3.Name = "textBoxThread3";
            this.textBoxThread3.Size = new System.Drawing.Size(204, 29);
            this.textBoxThread3.TabIndex = 6;
            // 
            // textBoxThread4
            // 
            this.textBoxThread4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThread4.Location = new System.Drawing.Point(197, 162);
            this.textBoxThread4.Name = "textBoxThread4";
            this.textBoxThread4.Size = new System.Drawing.Size(204, 29);
            this.textBoxThread4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxThread4);
            this.Controls.Add(this.textBoxThread3);
            this.Controls.Add(this.textBoxThread2);
            this.Controls.Add(this.textBoxThread1);
            this.Controls.Add(this.buttonThread4);
            this.Controls.Add(this.buttonThread3);
            this.Controls.Add(this.buttonThread2);
            this.Controls.Add(this.buttonThread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThread1;
        private System.Windows.Forms.Button buttonThread2;
        private System.Windows.Forms.Button buttonThread3;
        private System.Windows.Forms.Button buttonThread4;
        private System.Windows.Forms.TextBox textBoxThread1;
        private System.Windows.Forms.TextBox textBoxThread2;
        private System.Windows.Forms.TextBox textBoxThread3;
        private System.Windows.Forms.TextBox textBoxThread4;
        private System.Windows.Forms.Button button1;
    }
}

