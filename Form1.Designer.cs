namespace Practica_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(531, 40);
            label1.TabIndex = 0;
            label1.Text = "Conversiones de temperatura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 91);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 1;
            label2.Text = "Datos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 136);
            label3.Name = "label3";
            label3.Size = new Size(235, 27);
            label3.TabIndex = 2;
            label3.Text = "Ingresa algun valor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 184);
            label4.Name = "label4";
            label4.Size = new Size(312, 29);
            label4.TabIndex = 3;
            label4.Text = "Opciones de Conversión:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(312, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 36);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(71, 249);
            button1.Name = "button1";
            button1.Size = new Size(180, 46);
            button1.TabIndex = 5;
            button1.Text = "Farenheit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(321, 249);
            button2.Name = "button2";
            button2.Size = new Size(180, 46);
            button2.TabIndex = 6;
            button2.Text = "Centigrados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(193, 326);
            button3.Name = "button3";
            button3.Size = new Size(180, 46);
            button3.TabIndex = 7;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(24, 392);
            label5.Name = "label5";
            label5.Size = new Size(131, 29);
            label5.TabIndex = 8;
            label5.Text = "Resultado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(163, 451);
            label6.Name = "label6";
            label6.Size = new Size(270, 27);
            label6.TabIndex = 9;
            label6.Text = "Equivalente en grados:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(193, 496);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 36);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(580, 658);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
    }
}