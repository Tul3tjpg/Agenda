﻿namespace Agenda
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
            DgvContactos = new DataGridView();
            BtnCargarContactos = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvContactos).BeginInit();
            SuspendLayout();
            // 
            // DgvContactos
            // 
            DgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvContactos.Location = new Point(12, 21);
            DgvContactos.Name = "DgvContactos";
            DgvContactos.RowHeadersWidth = 62;
            DgvContactos.Size = new Size(776, 225);
            DgvContactos.TabIndex = 0;
            // 
            // BtnCargarContactos
            // 
            BtnCargarContactos.Location = new Point(12, 271);
            BtnCargarContactos.Name = "BtnCargarContactos";
            BtnCargarContactos.Size = new Size(214, 34);
            BtnCargarContactos.TabIndex = 1;
            BtnCargarContactos.Text = "Cargar Contactos";
            BtnCargarContactos.UseVisualStyleBackColor = true;
            BtnCargarContactos.Click += BtnCargarContactos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCargarContactos);
            Controls.Add(DgvContactos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvContactos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvContactos;
        private Button BtnCargarContactos;
    }
}
