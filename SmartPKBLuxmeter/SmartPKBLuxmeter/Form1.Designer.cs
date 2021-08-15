
namespace SmartPKBLuxmeter
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
            this.components = new System.ComponentModel.Container();
            this.lux = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.normalLux = new System.Windows.Forms.TextBox();
            this.surfArea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lightCurOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lightOutput = new System.Windows.Forms.TextBox();
            this.lightAct = new System.Windows.Forms.TextBox();
            this.lightCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomsSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lux
            // 
            this.lux.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lux.Location = new System.Drawing.Point(12, 323);
            this.lux.Name = "lux";
            this.lux.Size = new System.Drawing.Size(521, 26);
            this.lux.TabIndex = 0;
            this.lux.Text = "люксы";
            this.lux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(402, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Остановить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.normalLux);
            this.groupBox1.Controls.Add(this.surfArea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lightCurOutput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lightOutput);
            this.groupBox1.Controls.Add(this.lightAct);
            this.groupBox1.Controls.Add(this.lightCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация по комнате";
            // 
            // normalLux
            // 
            this.normalLux.Enabled = false;
            this.normalLux.Location = new System.Drawing.Point(240, 213);
            this.normalLux.Name = "normalLux";
            this.normalLux.Size = new System.Drawing.Size(100, 23);
            this.normalLux.TabIndex = 11;
            // 
            // surfArea
            // 
            this.surfArea.Enabled = false;
            this.surfArea.Location = new System.Drawing.Point(240, 184);
            this.surfArea.Name = "surfArea";
            this.surfArea.Size = new System.Drawing.Size(100, 23);
            this.surfArea.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Норма освещенности (в люксах)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Площадь комнаты";
            // 
            // lightCurOutput
            // 
            this.lightCurOutput.Enabled = false;
            this.lightCurOutput.Location = new System.Drawing.Point(240, 105);
            this.lightCurOutput.Name = "lightCurOutput";
            this.lightCurOutput.Size = new System.Drawing.Size(100, 23);
            this.lightCurOutput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Текущая мощность светового потока";
            // 
            // lightOutput
            // 
            this.lightOutput.Enabled = false;
            this.lightOutput.Location = new System.Drawing.Point(240, 79);
            this.lightOutput.Name = "lightOutput";
            this.lightOutput.Size = new System.Drawing.Size(100, 23);
            this.lightOutput.TabIndex = 5;
            // 
            // lightAct
            // 
            this.lightAct.Enabled = false;
            this.lightAct.Location = new System.Drawing.Point(240, 53);
            this.lightAct.Name = "lightAct";
            this.lightAct.Size = new System.Drawing.Size(100, 23);
            this.lightAct.TabIndex = 4;
            // 
            // lightCount
            // 
            this.lightCount.Enabled = false;
            this.lightCount.Location = new System.Drawing.Point(240, 27);
            this.lightCount.Name = "lightCount";
            this.lightCount.Size = new System.Drawing.Size(100, 23);
            this.lightCount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Общая мощность светового потока";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Активных источников";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество источников освещения";
            // 
            // roomsSource
            // 
            this.roomsSource.FormattingEnabled = true;
            this.roomsSource.Location = new System.Drawing.Point(373, 60);
            this.roomsSource.Name = "roomsSource";
            this.roomsSource.Size = new System.Drawing.Size(160, 23);
            this.roomsSource.TabIndex = 2;
            this.roomsSource.SelectedIndexChanged += new System.EventHandler(this.roomsSource_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Комната";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(373, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Получить комнаты";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomsSource);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lux);
            this.Name = "Form1";
            this.Text = "Имитатор работы люксметра";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lux;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomsSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox lightOutput;
        private System.Windows.Forms.TextBox lightAct;
        private System.Windows.Forms.TextBox lightCount;
        private System.Windows.Forms.TextBox lightCurOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox normalLux;
        private System.Windows.Forms.TextBox surfArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

