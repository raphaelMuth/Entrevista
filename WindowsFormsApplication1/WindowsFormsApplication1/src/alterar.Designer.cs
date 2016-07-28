namespace WindowsFormsApplication1.src
{
    partial class alterar
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
            this.label6 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSlv = new System.Windows.Forms.Button();
            this.IdadeBox = new System.Windows.Forms.TextBox();
            this.ProBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.NacBox = new System.Windows.Forms.TextBox();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "RG";
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(123, 185);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(124, 20);
            this.rg.TabIndex = 36;
            this.rg.Enter += new System.EventHandler(this.Box_Enter);
            this.rg.Leave += new System.EventHandler(this.Box_leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Profissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nascionalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome";
            // 
            // BtnSlv
            // 
            this.BtnSlv.Location = new System.Drawing.Point(336, 224);
            this.BtnSlv.Name = "BtnSlv";
            this.BtnSlv.Size = new System.Drawing.Size(75, 23);
            this.BtnSlv.TabIndex = 29;
            this.BtnSlv.Text = "Atualizar";
            this.BtnSlv.UseVisualStyleBackColor = true;
            this.BtnSlv.Click += new System.EventHandler(this.BtnSlv_Click);
            // 
            // IdadeBox
            // 
            this.IdadeBox.Location = new System.Drawing.Point(123, 153);
            this.IdadeBox.Name = "IdadeBox";
            this.IdadeBox.Size = new System.Drawing.Size(65, 20);
            this.IdadeBox.TabIndex = 28;
            this.IdadeBox.Enter += new System.EventHandler(this.Box_Enter);
            this.IdadeBox.Leave += new System.EventHandler(this.Box_leave);
            // 
            // ProBox
            // 
            this.ProBox.Location = new System.Drawing.Point(123, 125);
            this.ProBox.Name = "ProBox";
            this.ProBox.Size = new System.Drawing.Size(238, 20);
            this.ProBox.TabIndex = 27;
            this.ProBox.Enter += new System.EventHandler(this.Box_Enter);
            this.ProBox.Leave += new System.EventHandler(this.Box_leave);
            // 
            // EndBox
            // 
            this.EndBox.Location = new System.Drawing.Point(123, 94);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(288, 20);
            this.EndBox.TabIndex = 26;
            this.EndBox.Enter += new System.EventHandler(this.Box_Enter);
            this.EndBox.Leave += new System.EventHandler(this.Box_leave);
            // 
            // NacBox
            // 
            this.NacBox.Location = new System.Drawing.Point(123, 64);
            this.NacBox.Name = "NacBox";
            this.NacBox.Size = new System.Drawing.Size(288, 20);
            this.NacBox.TabIndex = 25;
            this.NacBox.Enter += new System.EventHandler(this.Box_Enter);
            this.NacBox.Leave += new System.EventHandler(this.Box_leave);
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(123, 35);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(288, 20);
            this.NomeBox.TabIndex = 24;
            this.NomeBox.Enter += new System.EventHandler(this.Box_Enter);
            this.NomeBox.Leave += new System.EventHandler(this.Box_leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(460, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Valores novos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(454, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Valores antigos";
            // 
            // alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 272);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSlv);
            this.Controls.Add(this.IdadeBox);
            this.Controls.Add(this.ProBox);
            this.Controls.Add(this.EndBox);
            this.Controls.Add(this.NacBox);
            this.Controls.Add(this.NomeBox);
            this.Name = "alterar";
            this.Text = "alterar";
            this.Controls.SetChildIndex(this.NomeBox, 0);
            this.Controls.SetChildIndex(this.NacBox, 0);
            this.Controls.SetChildIndex(this.EndBox, 0);
            this.Controls.SetChildIndex(this.ProBox, 0);
            this.Controls.SetChildIndex(this.IdadeBox, 0);
            this.Controls.SetChildIndex(this.BtnSlv, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.rg, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSlv;
        private System.Windows.Forms.TextBox IdadeBox;
        private System.Windows.Forms.TextBox ProBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.TextBox NacBox;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}