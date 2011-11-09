namespace WindowsFormsApplication9
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label_W;
            System.Windows.Forms.Button btCalc;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFlowRate = new System.Windows.Forms.TextBox();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btG = new System.Windows.Forms.Button();
            this.label_H = new System.Windows.Forms.Label();
            this.label__L = new System.Windows.Forms.Label();
            this.textBox_H = new System.Windows.Forms.TextBox();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.textBox_W = new System.Windows.Forms.TextBox();
            label_W = new System.Windows.Forms.Label();
            btCalc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_W
            // 
            label_W.AutoSize = true;
            label_W.Location = new System.Drawing.Point(173, 29);
            label_W.Name = "label_W";
            label_W.Size = new System.Drawing.Size(45, 13);
            label_W.TabIndex = 3;
            label_W.Text = "ширина";
            // 
            // btCalc
            // 
            btCalc.Location = new System.Drawing.Point(50, 246);
            btCalc.Name = "btCalc";
            btCalc.Size = new System.Drawing.Size(75, 23);
            btCalc.TabIndex = 6;
            btCalc.Text = "Расчет ";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Location = new System.Drawing.Point(478, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 331);
            this.panel1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(253, 185);
            this.maskedTextBox2.Multiline = true;
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(177, 99);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.Text = resources.GetString("maskedTextBox2.Text");
            this.maskedTextBox2.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(24, 20);
            this.maskedTextBox1.Multiline = true;
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(201, 264);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.Text = resources.GetString("maskedTextBox1.Text");
            this.maskedTextBox1.Visible = false;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbFlowRate);
            this.panel2.Controls.Add(this.textBox_S);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btG);
            this.panel2.Controls.Add(btCalc);
            this.panel2.Controls.Add(this.label_H);
            this.panel2.Controls.Add(this.label__L);
            this.panel2.Controls.Add(label_W);
            this.panel2.Controls.Add(this.textBox_H);
            this.panel2.Controls.Add(this.textBox_L);
            this.panel2.Controls.Add(this.textBox_W);
            this.panel2.Location = new System.Drawing.Point(62, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 313);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(173, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "FlowRate";
            // 
            // tbFlowRate
            // 
            this.tbFlowRate.Location = new System.Drawing.Point(50, 189);
            this.tbFlowRate.Name = "tbFlowRate";
            this.tbFlowRate.Size = new System.Drawing.Size(100, 20);
            this.tbFlowRate.TabIndex = 10;
            this.tbFlowRate.Text = "1";
            // 
            // textBox_S
            // 
            this.textBox_S.Location = new System.Drawing.Point(50, 159);
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.Size = new System.Drawing.Size(100, 20);
            this.textBox_S.TabIndex = 9;
            this.textBox_S.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "площадь вент ";
            // 
            // btG
            // 
            this.btG.Location = new System.Drawing.Point(50, 275);
            this.btG.Name = "btG";
            this.btG.Size = new System.Drawing.Size(75, 23);
            this.btG.TabIndex = 7;
            this.btG.Text = "геометрия ";
            this.btG.UseVisualStyleBackColor = true;
            this.btG.Click += new System.EventHandler(this.btG_Click);
            // 
            // label_H
            // 
            this.label_H.AutoSize = true;
            this.label_H.Location = new System.Drawing.Point(173, 121);
            this.label_H.Name = "label_H";
            this.label_H.Size = new System.Drawing.Size(44, 13);
            this.label_H.TabIndex = 5;
            this.label_H.Text = "высота";
            // 
            // label__L
            // 
            this.label__L.AutoSize = true;
            this.label__L.Location = new System.Drawing.Point(173, 73);
            this.label__L.Name = "label__L";
            this.label__L.Size = new System.Drawing.Size(37, 13);
            this.label__L.TabIndex = 4;
            this.label__L.Text = "длина";
            // 
            // textBox_H
            // 
            this.textBox_H.Location = new System.Drawing.Point(50, 114);
            this.textBox_H.Name = "textBox_H";
            this.textBox_H.Size = new System.Drawing.Size(100, 20);
            this.textBox_H.TabIndex = 2;
            this.textBox_H.Text = "5";
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(50, 66);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(100, 20);
            this.textBox_L.TabIndex = 1;
            this.textBox_L.Text = "125";
            // 
            // textBox_W
            // 
            this.textBox_W.Location = new System.Drawing.Point(50, 22);
            this.textBox_W.Name = "textBox_W";
            this.textBox_W.Size = new System.Drawing.Size(100, 20);
            this.textBox_W.TabIndex = 0;
            this.textBox_W.Text = "12";
            this.textBox_W.TextChanged += new System.EventHandler(this.textBox_W_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox maskedTextBox1;
        private System.Windows.Forms.TextBox maskedTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_H;
        private System.Windows.Forms.Label label__L;
        private System.Windows.Forms.TextBox textBox_H;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.TextBox textBox_W;
        private System.Windows.Forms.Button btG;
        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFlowRate;
    }
}

