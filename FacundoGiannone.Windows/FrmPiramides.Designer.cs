namespace FacundoGiannone.Windows
{
    partial class FrmPiramides
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
            components = new System.ComponentModel.Container();
            LadoBaseTxt = new TextBox();
            AlturaTxt = new TextBox();
            LadoBaseLbl = new Label();
            AlturaLbl = new Label();
            OkBtn = new Button();
            CancelarBtn = new Button();
            PiramidesList = new ListBox();
            PiramidesIngresadasLbl = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // LadoBaseTxt
            // 
            LadoBaseTxt.Location = new Point(132, 50);
            LadoBaseTxt.Name = "LadoBaseTxt";
            LadoBaseTxt.Size = new Size(125, 27);
            LadoBaseTxt.TabIndex = 1;
            // 
            // AlturaTxt
            // 
            AlturaTxt.Location = new Point(132, 94);
            AlturaTxt.Name = "AlturaTxt";
            AlturaTxt.Size = new Size(125, 27);
            AlturaTxt.TabIndex = 2;
            // 
            // LadoBaseLbl
            // 
            LadoBaseLbl.AutoSize = true;
            LadoBaseLbl.Location = new Point(12, 53);
            LadoBaseLbl.Name = "LadoBaseLbl";
            LadoBaseLbl.Size = new Size(117, 20);
            LadoBaseLbl.TabIndex = 1;
            LadoBaseLbl.Text = "Lado de la base:";
            // 
            // AlturaLbl
            // 
            AlturaLbl.AutoSize = true;
            AlturaLbl.Location = new Point(74, 97);
            AlturaLbl.Name = "AlturaLbl";
            AlturaLbl.Size = new Size(52, 20);
            AlturaLbl.TabIndex = 2;
            AlturaLbl.Text = "Altura:";
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(37, 182);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(94, 67);
            OkBtn.TabIndex = 3;
            OkBtn.Text = "OK";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(193, 182);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(94, 67);
            CancelarBtn.TabIndex = 4;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // PiramidesList
            // 
            PiramidesList.FormattingEnabled = true;
            PiramidesList.Location = new Point(342, 65);
            PiramidesList.Name = "PiramidesList";
            PiramidesList.Size = new Size(272, 184);
            PiramidesList.TabIndex = 5;
            // 
            // PiramidesIngresadasLbl
            // 
            PiramidesIngresadasLbl.AutoSize = true;
            PiramidesIngresadasLbl.Location = new Point(396, 42);
            PiramidesIngresadasLbl.Name = "PiramidesIngresadasLbl";
            PiramidesIngresadasLbl.Size = new Size(149, 20);
            PiramidesIngresadasLbl.TabIndex = 6;
            PiramidesIngresadasLbl.Text = "Piramides Ingresadas";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmPiramides
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 308);
            Controls.Add(PiramidesIngresadasLbl);
            Controls.Add(PiramidesList);
            Controls.Add(CancelarBtn);
            Controls.Add(OkBtn);
            Controls.Add(AlturaLbl);
            Controls.Add(LadoBaseLbl);
            Controls.Add(AlturaTxt);
            Controls.Add(LadoBaseTxt);
            Name = "FrmPiramides";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LadoBaseTxt;
        private TextBox AlturaTxt;
        private Label LadoBaseLbl;
        private Label AlturaLbl;
        private Button OkBtn;
        private Button CancelarBtn;
        private ListBox PiramidesList;
        private Label PiramidesIngresadasLbl;
        private ErrorProvider errorProvider1;
    }
}
