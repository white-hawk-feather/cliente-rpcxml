﻿namespace WindowsFormsApplication1
{
    partial class FormCliente
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
            this.btn_PublicarLance = new System.Windows.Forms.Button();
            this.gbx_enviarDados = new System.Windows.Forms.GroupBox();
            this.edt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.edt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.edt_Nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_LeiloesAbertos = new System.Windows.Forms.RichTextBox();
            this.btnOFF = new System.Windows.Forms.Button();
            this.gbx_enviarDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PublicarLance
            // 
            this.btn_PublicarLance.Location = new System.Drawing.Point(95, 111);
            this.btn_PublicarLance.Name = "btn_PublicarLance";
            this.btn_PublicarLance.Size = new System.Drawing.Size(103, 23);
            this.btn_PublicarLance.TabIndex = 0;
            this.btn_PublicarLance.Text = "Publicar Lance";
            this.btn_PublicarLance.UseVisualStyleBackColor = true;
            this.btn_PublicarLance.Click += new System.EventHandler(this.btn_PublicarLance_Click);
            // 
            // gbx_enviarDados
            // 
            this.gbx_enviarDados.Controls.Add(this.edt_Valor);
            this.gbx_enviarDados.Controls.Add(this.btn_PublicarLance);
            this.gbx_enviarDados.Controls.Add(this.lbl_Valor);
            this.gbx_enviarDados.Controls.Add(this.edt_ID);
            this.gbx_enviarDados.Controls.Add(this.label1);
            this.gbx_enviarDados.Controls.Add(this.lbl_Nome);
            this.gbx_enviarDados.Controls.Add(this.edt_Nome);
            this.gbx_enviarDados.Location = new System.Drawing.Point(261, 12);
            this.gbx_enviarDados.Name = "gbx_enviarDados";
            this.gbx_enviarDados.Size = new System.Drawing.Size(218, 159);
            this.gbx_enviarDados.TabIndex = 2;
            this.gbx_enviarDados.TabStop = false;
            // 
            // edt_Valor
            // 
            this.edt_Valor.Location = new System.Drawing.Point(64, 71);
            this.edt_Valor.Name = "edt_Valor";
            this.edt_Valor.Size = new System.Drawing.Size(134, 20);
            this.edt_Valor.TabIndex = 7;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(12, 74);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_Valor.TabIndex = 6;
            this.lbl_Valor.Text = "Valor";
            // 
            // edt_ID
            // 
            this.edt_ID.Location = new System.Drawing.Point(64, 45);
            this.edt_ID.Name = "edt_ID";
            this.edt_ID.Size = new System.Drawing.Size(134, 20);
            this.edt_ID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 22);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome";
            // 
            // edt_Nome
            // 
            this.edt_Nome.Location = new System.Drawing.Point(64, 19);
            this.edt_Nome.Name = "edt_Nome";
            this.edt_Nome.Size = new System.Drawing.Size(134, 20);
            this.edt_Nome.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_LeiloesAbertos);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leilões Abertos";
            // 
            // edt_LeiloesAbertos
            // 
            this.edt_LeiloesAbertos.Location = new System.Drawing.Point(7, 19);
            this.edt_LeiloesAbertos.Name = "edt_LeiloesAbertos";
            this.edt_LeiloesAbertos.ReadOnly = true;
            this.edt_LeiloesAbertos.Size = new System.Drawing.Size(229, 166);
            this.edt_LeiloesAbertos.TabIndex = 0;
            this.edt_LeiloesAbertos.Text = "";
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(395, 186);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(64, 23);
            this.btnOFF.TabIndex = 8;
            this.btnOFF.Text = "off";
            this.btnOFF.UseVisualStyleBackColor = true;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 221);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_enviarDados);
            this.Name = "FormCliente";
            this.Text = "Cliente - Leilão ";
            this.gbx_enviarDados.ResumeLayout(false);
            this.gbx_enviarDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PublicarLance;
        private System.Windows.Forms.GroupBox gbx_enviarDados;
        private System.Windows.Forms.TextBox edt_Valor;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.TextBox edt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox edt_Nome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox edt_LeiloesAbertos;
        private System.Windows.Forms.Button btnOFF;
    }
}

