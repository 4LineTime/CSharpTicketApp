namespace TicketForm
{
    partial class frmOptions
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
            this.lblOpMin = new System.Windows.Forms.Label();
            this.lblOpGuest = new System.Windows.Forms.Label();
            this.lblOpStart = new System.Windows.Forms.Label();
            this.lblOpEnd = new System.Windows.Forms.Label();
            this.lblOpFirst = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnOpOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpMin
            // 
            this.lblOpMin.AutoSize = true;
            this.lblOpMin.Location = new System.Drawing.Point(26, 19);
            this.lblOpMin.Name = "lblOpMin";
            this.lblOpMin.Size = new System.Drawing.Size(108, 13);
            this.lblOpMin.TabIndex = 0;
            this.lblOpMin.Text = "Minutes Per Window:";
            // 
            // lblOpGuest
            // 
            this.lblOpGuest.AutoSize = true;
            this.lblOpGuest.Location = new System.Drawing.Point(26, 60);
            this.lblOpGuest.Name = "lblOpGuest";
            this.lblOpGuest.Size = new System.Drawing.Size(104, 13);
            this.lblOpGuest.TabIndex = 1;
            this.lblOpGuest.Text = "Guests Per Window:";
            // 
            // lblOpStart
            // 
            this.lblOpStart.AutoSize = true;
            this.lblOpStart.Location = new System.Drawing.Point(72, 101);
            this.lblOpStart.Name = "lblOpStart";
            this.lblOpStart.Size = new System.Drawing.Size(58, 13);
            this.lblOpStart.TabIndex = 2;
            this.lblOpStart.Text = "Start Time:";
            // 
            // lblOpEnd
            // 
            this.lblOpEnd.AutoSize = true;
            this.lblOpEnd.Location = new System.Drawing.Point(75, 148);
            this.lblOpEnd.Name = "lblOpEnd";
            this.lblOpEnd.Size = new System.Drawing.Size(55, 13);
            this.lblOpEnd.TabIndex = 3;
            this.lblOpEnd.Text = "End Time:";
            // 
            // lblOpFirst
            // 
            this.lblOpFirst.AutoSize = true;
            this.lblOpFirst.Location = new System.Drawing.Point(32, 188);
            this.lblOpFirst.Name = "lblOpFirst";
            this.lblOpFirst.Size = new System.Drawing.Size(102, 13);
            this.lblOpFirst.TabIndex = 4;
            this.lblOpFirst.Text = "First Ticket Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(155, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(155, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(155, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnOpOk
            // 
            this.btnOpOk.Location = new System.Drawing.Point(155, 226);
            this.btnOpOk.Name = "btnOpOk";
            this.btnOpOk.Size = new System.Drawing.Size(75, 23);
            this.btnOpOk.TabIndex = 10;
            this.btnOpOk.Text = "OK";
            this.btnOpOk.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnOpOk);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOpFirst);
            this.Controls.Add(this.lblOpEnd);
            this.Controls.Add(this.lblOpStart);
            this.Controls.Add(this.lblOpGuest);
            this.Controls.Add(this.lblOpMin);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpMin;
        private System.Windows.Forms.Label lblOpGuest;
        private System.Windows.Forms.Label lblOpStart;
        private System.Windows.Forms.Label lblOpEnd;
        private System.Windows.Forms.Label lblOpFirst;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnOpOk;
    }
}