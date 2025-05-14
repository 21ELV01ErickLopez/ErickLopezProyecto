namespace ErickLopezProyecto
{
    partial class Form10
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
            textBox4 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 169);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 56;
            label2.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 112);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 55;
            label1.Text = "Ecuacion de Regla de tres";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(495, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 23);
            textBox3.TabIndex = 54;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(361, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 52;
            // 
            // button1
            // 
            button1.Location = new Point(254, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 51;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 259);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}