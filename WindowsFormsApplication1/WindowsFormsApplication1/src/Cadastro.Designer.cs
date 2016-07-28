namespace WindowsFormsApplication1
{
    partial class Cadastro
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
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.NacBox = new System.Windows.Forms.TextBox();
            this.EndBox = new System.Windows.Forms.TextBox();
            this.ProBox = new System.Windows.Forms.TextBox();
            this.IdadeBox = new System.Windows.Forms.TextBox();
            this.BtnSlv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(123, 10);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(288, 20);
            this.NomeBox.TabIndex = 5;
            this.NomeBox.Enter += new System.EventHandler(this.Box_Enter);
            this.NomeBox.Leave += new System.EventHandler(this.Box_Leave);
            // 
            // NacBox
            // 
            this.NacBox.Location = new System.Drawing.Point(123, 39);
            this.NacBox.Name = "NacBox";
            this.NacBox.Size = new System.Drawing.Size(288, 20);
            this.NacBox.TabIndex = 6;
            this.NacBox.Enter += new System.EventHandler(this.Box_Enter);
            this.NacBox.Leave += new System.EventHandler(this.Box_Leave);
            // 
            // EndBox
            // 
            this.EndBox.Location = new System.Drawing.Point(123, 65);
            this.EndBox.Name = "EndBox";
            this.EndBox.Size = new System.Drawing.Size(288, 20);
            this.EndBox.TabIndex = 7;
            this.EndBox.Enter += new System.EventHandler(this.Box_Enter);
            this.EndBox.Leave += new System.EventHandler(this.Box_Leave);
            // 
            // ProBox
            // 
            this.ProBox.Location = new System.Drawing.Point(123, 96);
            this.ProBox.Name = "ProBox";
            this.ProBox.Size = new System.Drawing.Size(238, 20);
            this.ProBox.TabIndex = 8;
            this.ProBox.Enter += new System.EventHandler(this.Box_Enter);
            this.ProBox.Leave += new System.EventHandler(this.Box_Leave);
            // 
            // IdadeBox
            // 
            this.IdadeBox.Location = new System.Drawing.Point(123, 128);
            this.IdadeBox.Name = "IdadeBox";
            this.IdadeBox.Size = new System.Drawing.Size(65, 20);
            this.IdadeBox.TabIndex = 9;
            this.IdadeBox.Enter += new System.EventHandler(this.Box_Enter);
            this.IdadeBox.Leave += new System.EventHandler(this.Box_Leave);
            // 
            // BtnSlv
            // 
            this.BtnSlv.Location = new System.Drawing.Point(286, 198);
            this.BtnSlv.Name = "BtnSlv";
            this.BtnSlv.Size = new System.Drawing.Size(75, 23);
            this.BtnSlv.TabIndex = 10;
            this.BtnSlv.Text = "Salvar";
            this.BtnSlv.UseVisualStyleBackColor = true;
            this.BtnSlv.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Profissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nascionalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "RG";
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(123, 160);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(124, 20);
            this.rg.TabIndex = 22;
            this.rg.Enter += new System.EventHandler(this.Box_Enter);
            this.rg.Leave += new System.EventHandler(this.Box_Leave);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 242);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnSlv);
            this.Controls.Add(this.IdadeBox);
            this.Controls.Add(this.ProBox);
            this.Controls.Add(this.EndBox);
            this.Controls.Add(this.NacBox);
            this.Controls.Add(this.NomeBox);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.TextBox NacBox;
        private System.Windows.Forms.TextBox EndBox;
        private System.Windows.Forms.TextBox ProBox;
        private System.Windows.Forms.TextBox IdadeBox;
        private System.Windows.Forms.Button BtnSlv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rg;
    }
}