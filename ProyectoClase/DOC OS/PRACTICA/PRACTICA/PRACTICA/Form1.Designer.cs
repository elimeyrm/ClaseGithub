namespace PRACTICA
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
            cmdcarnet = new ComboBox();
            label1 = new Label();
            txtnombre = new TextBox();
            NOMBRE = new Label();
            btnprocesar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmdcarnet
            // 
            cmdcarnet.FormattingEnabled = true;
            cmdcarnet.Location = new Point(287, 124);
            cmdcarnet.Name = "cmdcarnet";
            cmdcarnet.Size = new Size(358, 23);
            cmdcarnet.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 120);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 1;
            label1.Text = "NUMERO DE CARNET";
            label1.Click += label1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(287, 177);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(358, 23);
            txtnombre.TabIndex = 2;
            // 
            // NOMBRE
            // 
            NOMBRE.AutoSize = true;
            NOMBRE.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NOMBRE.Location = new Point(12, 173);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(258, 27);
            NOMBRE.TabIndex = 3;
            NOMBRE.Text = "NOMBRE DE ESTUDIANTE";
            // 
            // btnprocesar
            // 
            btnprocesar.Location = new Point(302, 242);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(75, 23);
            btnprocesar.TabIndex = 4;
            btnprocesar.Text = "PROCESAR";
            btnprocesar.UseVisualStyleBackColor = true;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 34);
            label2.Name = "label2";
            label2.Size = new Size(652, 60);
            label2.TabIndex = 5;
            label2.Text = "CONSULTA DE ESTUDIANTES";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(707, 305);
            Controls.Add(label2);
            Controls.Add(btnprocesar);
            Controls.Add(NOMBRE);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Controls.Add(cmdcarnet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmdcarnet;
        private Label label1;
        private TextBox txtnombre;
        private Label NOMBRE;
        private Button btnprocesar;
        private Label label2;
    }
}
