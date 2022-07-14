
namespace me_projekt
{
    partial class Form3
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
            this.lblferst = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Button();
            this.decrement = new System.Windows.Forms.Button();
            this.incris = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.txtresolt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtferst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblferst
            // 
            this.lblferst.AutoSize = true;
            this.lblferst.Location = new System.Drawing.Point(197, 148);
            this.lblferst.Name = "lblferst";
            this.lblferst.Size = new System.Drawing.Size(43, 13);
            this.lblferst.TabIndex = 2;
            this.lblferst.Text = "chislo 1";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Location = new System.Drawing.Point(196, 208);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(43, 13);
            this.lblsecond.TabIndex = 3;
            this.lblsecond.Text = "chislo 2";
            // 
            // increment
            // 
            this.increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(199, 278);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(50, 50);
            this.increment.TabIndex = 6;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.btn_click);
            // 
            // decrement
            // 
            this.decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrement.Location = new System.Drawing.Point(315, 277);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(50, 50);
            this.decrement.TabIndex = 7;
            this.decrement.Text = "-";
            this.decrement.UseVisualStyleBackColor = true;
            this.decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // incris
            // 
            this.incris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incris.Location = new System.Drawing.Point(445, 277);
            this.incris.Name = "incris";
            this.incris.Size = new System.Drawing.Size(50, 50);
            this.incris.TabIndex = 8;
            this.incris.Text = "*";
            this.incris.UseVisualStyleBackColor = true;
            this.incris.Click += new System.EventHandler(this.btn_click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(599, 277);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 9;
            this.divide.Text = ":";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.btn_click);
            // 
            // txtresolt
            // 
            this.txtresolt.AutoSize = true;
            this.txtresolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresolt.Location = new System.Drawing.Point(197, 344);
            this.txtresolt.Name = "txtresolt";
            this.txtresolt.Size = new System.Drawing.Size(109, 39);
            this.txtresolt.TabIndex = 10;
            this.txtresolt.Text = "result:";
            this.txtresolt.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // txtferst
            // 
            this.txtferst.Location = new System.Drawing.Point(299, 140);
            this.txtferst.Name = "txtferst";
            this.txtferst.Size = new System.Drawing.Size(100, 20);
            this.txtferst.TabIndex = 12;
            this.txtferst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtferst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(299, 208);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(100, 20);
            this.txtsecond.TabIndex = 13;
            this.txtsecond.Click += new System.EventHandler(this.btn_click);
            this.txtsecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtsecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtferst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtresolt);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.incris);
            this.Controls.Add(this.decrement);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblferst);
            this.Name = "Form3";
            this.Text = "kalkylator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblferst;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Button incris;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label txtresolt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtferst;
        private System.Windows.Forms.TextBox txtsecond;
    }
}