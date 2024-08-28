namespace Buscador_Telefonos
{
    partial class Formulario_Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario_Busqueda));
            this.lbl_documento = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.toolTip_buscar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbl_documento
            // 
            this.lbl_documento.AutoSize = true;
            this.lbl_documento.Location = new System.Drawing.Point(40, 16);
            this.lbl_documento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(77, 13);
            this.lbl_documento.TabIndex = 0;
            this.lbl_documento.Text = "DOCUMENTO";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(224, 16);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(39, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "EMAIL";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(40, 40);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(115, 20);
            this.txt_documento.TabIndex = 1;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Enter);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(224, 40);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(115, 20);
            this.txt_email.TabIndex = 2;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Enter);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(40, 96);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(104, 32);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.toolTip_buscar.SetToolTip(this.btn_buscar, "Enter");
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            this.btn_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(40, 160);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(104, 32);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            this.btn_limpiar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(232, 160);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(104, 32);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.toolTip_buscar.SetToolTip(this.btn_salir, "Salir (Esc)");
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            this.btn_salir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            // 
            // Formulario_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 224);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_documento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Formulario_Busqueda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de Emails";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress_Escape);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_documento;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ToolTip toolTip_buscar;
    }
}

