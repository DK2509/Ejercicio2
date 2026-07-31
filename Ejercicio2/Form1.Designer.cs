namespace Ejercicio2
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
            bottonBox1 = new Button();
            checkBox1 = new CheckBox();
            listBox1 = new ListBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 51);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // bottonBox1
            // 
            bottonBox1.Location = new Point(566, 138);
            bottonBox1.Name = "bottonBox1";
            bottonBox1.Size = new Size(75, 23);
            bottonBox1.TabIndex = 1;
            bottonBox1.Text = "comprobar";
            bottonBox1.UseVisualStyleBackColor = true;
            bottonBox1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(147, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Presente";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(129, 244);
            listBox1.TabIndex = 3;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(147, 76);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(71, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Presente";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(147, 101);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(71, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Presente";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(147, 126);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(71, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Presente";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(listBox1);
            Controls.Add(checkBox1);
            Controls.Add(bottonBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bottonBox1;
        private CheckBox checkBox1;
        private ListBox listBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
