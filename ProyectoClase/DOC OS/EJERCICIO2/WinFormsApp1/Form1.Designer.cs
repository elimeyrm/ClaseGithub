namespace WinFormsApp1
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
            label1 = new Label();
            cmdnumero = new ComboBox();
            btnprocesar = new Button();
            txtmes = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(259, 42);
            label1.Name = "label1";
            label1.Size = new Size(271, 36);
            label1.TabIndex = 0;
            label1.Text = "OPCION MULTIPLE";
            label1.Click += label1_Click;
            // 
            // cmdnumero
            // 
            cmdnumero.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdnumero.FormattingEnabled = true;
            cmdnumero.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmdnumero.Location = new Point(67, 135);
            cmdnumero.Name = "cmdnumero";
            cmdnumero.Size = new Size(655, 31);
            cmdnumero.TabIndex = 1;
            // 
            // btnprocesar
            // 
            btnprocesar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnprocesar.Location = new Point(324, 281);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(140, 51);
            btnprocesar.TabIndex = 2;
            btnprocesar.Text = "SELECCIONAR";
            btnprocesar.UseVisualStyleBackColor = true;
            btnprocesar.Click += btnprocesar_Click;
            // 
            // txtmes
            // 
            txtmes.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmes.Location = new Point(324, 214);
            txtmes.Name = "txtmes";
            txtmes.Size = new Size(398, 31);
            txtmes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(249, 100);
            label2.Name = "label2";
            label2.Size = new Size(298, 23);
            label2.TabIndex = 4;
            label2.Text = "SELECCIONE LA OPCION DEL MES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(84, 214);
            label3.Name = "label3";
            label3.Size = new Size(202, 23);
            label3.TabIndex = 5;
            label3.Text = "USTED SELECCIONO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtmes);
            Controls.Add(btnprocesar);
            Controls.Add(cmdnumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmdnumero;
        private Button btnprocesar;
        private TextBox txtmes;
        private Label label2;
        private Label label3;
    }
}
