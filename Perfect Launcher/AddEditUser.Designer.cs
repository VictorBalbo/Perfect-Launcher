
namespace Perfect_Launcher
{
    partial class AddEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUser));
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(94, 13);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 16);
            label1.TabIndex = 0;
            label1.Text = "USUÁRIO";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(23, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(210, 22);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(23, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(210, 22);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(101, 60);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 16);
            label2.TabIndex = 1;
            label2.Text = "SENHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(85, 158);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 16);
            label3.TabIndex = 2;
            label3.Text = "DESCRIÇÃO";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "GUERREIRO(A)", "MAGO(A)", "ARQUEIRO(A)", "SACERDOTE", "BÁRBARO", "FEITICEIRA", "MERCENÁRIO(A)", "ESPIRITUALISTA", "ARCANO(A)", "MÍSTICO(A)", "RETALHADOR(A)", "TORMENTADOR{A)", "ATIRADORA", "PALADINO" });
            comboBox1.Location = new System.Drawing.Point(23, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(210, 24);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(23, 271);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(210, 30);
            button1.TabIndex = 3;
            button1.Text = "ADICIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new System.Drawing.Point(23, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(210, 22);
            textBox3.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(39, 235);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(177, 20);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Descrição personalizada";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(118, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(20, 20);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(23, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(210, 22);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(77, 109);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 16);
            label4.TabIndex = 8;
            label4.Text = "PERSONAGEM";
            // 
            // AddEditUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(257, 315);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddEditUser";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ADICIONAR";
            TopMost = true;
            Load += AddEditUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
    }
}