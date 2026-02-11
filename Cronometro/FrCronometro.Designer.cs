namespace Calculadora.Formularios
{
    partial class FrCronometro
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            butIniciar = new Button();
            butDetener = new Button();
            butReiniciar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // butIniciar
            // 
            butIniciar.Location = new Point(224, 257);
            butIniciar.Name = "butIniciar";
            butIniciar.Size = new Size(94, 29);
            butIniciar.TabIndex = 0;
            butIniciar.Text = "INICIAR";
            butIniciar.UseVisualStyleBackColor = true;
            butIniciar.Click += button1_Click;
            // 
            // butDetener
            // 
            butDetener.Location = new Point(353, 257);
            butDetener.Name = "butDetener";
            butDetener.Size = new Size(94, 29);
            butDetener.TabIndex = 1;
            butDetener.Text = "DETENER";
            butDetener.UseVisualStyleBackColor = true;
            butDetener.Click += button2_Click;
            // 
            // butReiniciar
            // 
            butReiniciar.Location = new Point(489, 257);
            butReiniciar.Name = "butReiniciar";
            butReiniciar.Size = new Size(94, 29);
            butReiniciar.TabIndex = 2;
            butReiniciar.Text = "REINICIAR";
            butReiniciar.UseVisualStyleBackColor = true;
            butReiniciar.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 98);
            label1.Name = "label1";
            label1.Size = new Size(451, 106);
            label1.TabIndex = 3;
            label1.Text = "00:00:00,00";
            label1.Click += label1_Click;
            // 
            // FrCronometro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(butReiniciar);
            Controls.Add(butDetener);
            Controls.Add(butIniciar);
            Name = "FrCronometro";
            Text = "FrCronometro";
            Load += FrCronometro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button butIniciar;
        private Button butDetener;
        private Button butReiniciar;
        private Label label1;
    }
}