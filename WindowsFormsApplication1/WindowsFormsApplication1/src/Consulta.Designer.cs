namespace WindowsFormsApplication1
{
    partial class Consulta
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridBD = new System.Windows.Forms.DataGridView();
            this.clienteDataSet = new WindowsFormsApplication1.ClienteDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new WindowsFormsApplication1.ClienteDataSetTableAdapters.clienteTableAdapter();
            this.clienteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Atualizar = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Consulta por nome:";
            // 
            // GridBD
            // 
            this.GridBD.AllowUserToAddRows = false;
            this.GridBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBD.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridBD.Location = new System.Drawing.Point(33, 38);
            this.GridBD.MultiSelect = false;
            this.GridBD.Name = "GridBD";
            this.GridBD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBD.Size = new System.Drawing.Size(534, 232);
            this.GridBD.TabIndex = 8;
            // 
            // clienteDataSet
            // 
            this.clienteDataSet.DataSetName = "ClienteDataSet";
            this.clienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.clienteDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteDataSetBindingSource
            // 
            this.clienteDataSetBindingSource.DataSource = this.clienteDataSet;
            this.clienteDataSetBindingSource.Position = 0;
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(403, 297);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 10;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(492, 297);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(75, 23);
            this.deletar.TabIndex = 11;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 341);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.GridBD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.GridBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridBD;
        private ClienteDataSet clienteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ClienteDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteDataSetBindingSource;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button deletar;
    }
}