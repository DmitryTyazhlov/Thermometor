namespace Thermometor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.S1 = new System.Windows.Forms.Label();
            this.S2 = new System.Windows.Forms.Label();
            this.S3 = new System.Windows.Forms.Label();
            this.S4 = new System.Windows.Forms.Label();
            this.S5 = new System.Windows.Forms.Label();
            this.S6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(573, 17);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(121, 24);
            this.PortBox.TabIndex = 0;
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(477, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // S1
            // 
            this.S1.AutoSize = true;
            this.S1.Location = new System.Drawing.Point(12, 401);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(29, 17);
            this.S1.TabIndex = 3;
            this.S1.Text = "S1:";
            // 
            // S2
            // 
            this.S2.AutoSize = true;
            this.S2.Location = new System.Drawing.Point(123, 401);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(29, 17);
            this.S2.TabIndex = 4;
            this.S2.Text = "S2:";
            // 
            // S3
            // 
            this.S3.AutoSize = true;
            this.S3.Location = new System.Drawing.Point(244, 401);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(29, 17);
            this.S3.TabIndex = 5;
            this.S3.Text = "S3:";
            // 
            // S4
            // 
            this.S4.AutoSize = true;
            this.S4.Location = new System.Drawing.Point(375, 401);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(29, 17);
            this.S4.TabIndex = 6;
            this.S4.Text = "S4:";
            // 
            // S5
            // 
            this.S5.AutoSize = true;
            this.S5.Location = new System.Drawing.Point(507, 401);
            this.S5.Name = "S5";
            this.S5.Size = new System.Drawing.Size(29, 17);
            this.S5.TabIndex = 7;
            this.S5.Text = "S5:";
            // 
            // S6
            // 
            this.S6.AutoSize = true;
            this.S6.Location = new System.Drawing.Point(666, 401);
            this.S6.Name = "S6";
            this.S6.Size = new System.Drawing.Size(29, 17);
            this.S6.TabIndex = 8;
            this.S6.Text = "S6:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.S6);
            this.Controls.Add(this.S5);
            this.Controls.Add(this.S4);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortBox);
            this.Name = "Form1";
            this.Text = "Термометр";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label S1;
        private System.Windows.Forms.Label S2;
        private System.Windows.Forms.Label S3;
        private System.Windows.Forms.Label S4;
        private System.Windows.Forms.Label S5;
        private System.Windows.Forms.Label S6;
    }
}

