namespace PruebaForms.Interfaz
{
    partial class VentanaVentas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnCargarXml = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Venta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 25);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 193);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 3;
            label3.Text = "Producto";
            // 
            // button1
            // 
            button1.Location = new Point(194, 148);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 5;
            button1.Text = "Crear cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCargarXml
            // 
            btnCargarXml.Location = new Point(22, 148);
            btnCargarXml.Name = "btnCargarXml";
            btnCargarXml.Size = new Size(156, 23);
            btnCargarXml.TabIndex = 6;
            btnCargarXml.Text = "Cargar cliente";
            btnCargarXml.UseVisualStyleBackColor = true;
            btnCargarXml.Click += btnCargarXml_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 349);
            button3.Name = "button3";
            button3.Size = new Size(156, 23);
            button3.TabIndex = 7;
            button3.Text = "Cargar producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(451, 390);
            button4.Name = "button4";
            button4.Size = new Size(112, 48);
            button4.TabIndex = 8;
            button4.Text = "Cancelar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(587, 390);
            button5.Name = "button5";
            button5.Size = new Size(112, 48);
            button5.TabIndex = 9;
            button5.Text = "Guardar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(22, 43);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(605, 94);
            checkedListBox1.TabIndex = 10;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(26, 219);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(601, 112);
            checkedListBox2.TabIndex = 11;
            // 
            // VentanaVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnCargarXml);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaVentas";
            Text = "VentanaVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btnCargarXml;
        private Button button3;
        private Button button4;
        private Button button5;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
    }
}