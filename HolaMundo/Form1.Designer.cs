namespace HolaMundo
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
            lbContrasena1 = new Label();
            lblContrasena2 = new Label();
            txtContrasena1 = new TextBox();
            txtContrasena2 = new TextBox();
            btnValidar = new Button();
            SuspendLayout();
            // 
            // lbContrasena1
            // 
            lbContrasena1.AutoSize = true;
            lbContrasena1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbContrasena1.Location = new Point(143, 120);
            lbContrasena1.Name = "lbContrasena1";
            lbContrasena1.Size = new Size(189, 25);
            lbContrasena1.TabIndex = 0;
            lbContrasena1.Text = "Ingresa Contraseña:";
            // 
            // lblContrasena2
            // 
            lblContrasena2.AutoSize = true;
            lblContrasena2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasena2.Location = new Point(143, 182);
            lblContrasena2.Name = "lblContrasena2";
            lblContrasena2.Size = new Size(179, 25);
            lblContrasena2.TabIndex = 1;
            lblContrasena2.Text = "Repite Contraseña:";
            // 
            // txtContrasena1
            // 
            txtContrasena1.Location = new Point(354, 120);
            txtContrasena1.Margin = new Padding(4);
            txtContrasena1.Name = "txtContrasena1";
            txtContrasena1.Size = new Size(208, 23);
            txtContrasena1.TabIndex = 2;
            // 
            // txtContrasena2
            // 
            txtContrasena2.Location = new Point(354, 187);
            txtContrasena2.Margin = new Padding(4);
            txtContrasena2.Name = "txtContrasena2";
            txtContrasena2.Size = new Size(208, 23);
            txtContrasena2.TabIndex = 3;
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValidar.Location = new Point(354, 286);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(208, 56);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidar);
            Controls.Add(txtContrasena2);
            Controls.Add(txtContrasena1);
            Controls.Add(lblContrasena2);
            Controls.Add(lbContrasena1);
            Name = "Form1";
            Text = "HolaMundo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbContrasena1;
        private Label lblContrasena2;
        private TextBox txtContrasena1;
        private TextBox txtContrasena2;
        private Button btnValidar;
    }
}