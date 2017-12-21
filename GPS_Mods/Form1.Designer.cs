namespace GPS_Mods
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTimerInterv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNumPort = new System.Windows.Forms.ComboBox();
            this.cbSpeedPort = new System.Windows.Forms.ComboBox();
            this.btCleanList = new System.Windows.Forms.Button();
            this.btStartScan = new System.Windows.Forms.Button();
            this.lbDUMP = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbLon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbXm = new System.Windows.Forms.Label();
            this.lbYm = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbNumSp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbColSp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbDirectSp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbAzimutSp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btCleanList);
            this.tabPage1.Controls.Add(this.btStartScan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поток данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 88);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(502, 241);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTimerInterv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbNumPort);
            this.groupBox1.Controls.Add(this.cbSpeedPort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1218, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // cbTimerInterv
            // 
            this.cbTimerInterv.FormattingEnabled = true;
            this.cbTimerInterv.Items.AddRange(new object[] {
            "100",
            "1000"});
            this.cbTimerInterv.Location = new System.Drawing.Point(481, 19);
            this.cbTimerInterv.Name = "cbTimerInterv";
            this.cbTimerInterv.Size = new System.Drawing.Size(121, 21);
            this.cbTimerInterv.TabIndex = 5;
            this.cbTimerInterv.SelectedIndexChanged += new System.EventHandler(this.cbTimerInterv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Интервал опроса порта (мс)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Скорость порта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер порта";
            // 
            // cbNumPort
            // 
            this.cbNumPort.FormattingEnabled = true;
            this.cbNumPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.cbNumPort.Location = new System.Drawing.Point(95, 50);
            this.cbNumPort.Name = "cbNumPort";
            this.cbNumPort.Size = new System.Drawing.Size(121, 21);
            this.cbNumPort.TabIndex = 1;
            this.cbNumPort.SelectedIndexChanged += new System.EventHandler(this.cbNumPort_SelectedIndexChanged);
            // 
            // cbSpeedPort
            // 
            this.cbSpeedPort.FormattingEnabled = true;
            this.cbSpeedPort.Items.AddRange(new object[] {
            "4800",
            "9600"});
            this.cbSpeedPort.Location = new System.Drawing.Point(95, 19);
            this.cbSpeedPort.Name = "cbSpeedPort";
            this.cbSpeedPort.Size = new System.Drawing.Size(121, 21);
            this.cbSpeedPort.TabIndex = 0;
            this.cbSpeedPort.SelectedIndexChanged += new System.EventHandler(this.cbSpeedPort_SelectedIndexChanged);
            // 
            // btCleanList
            // 
            this.btCleanList.Location = new System.Drawing.Point(376, 622);
            this.btCleanList.Name = "btCleanList";
            this.btCleanList.Size = new System.Drawing.Size(132, 23);
            this.btCleanList.TabIndex = 2;
            this.btCleanList.Text = "ОТЧИСТИТЬ";
            this.btCleanList.UseVisualStyleBackColor = true;
            this.btCleanList.Click += new System.EventHandler(this.btCleanList_Click);
            // 
            // btStartScan
            // 
            this.btStartScan.Location = new System.Drawing.Point(3, 622);
            this.btStartScan.Name = "btStartScan";
            this.btStartScan.Size = new System.Drawing.Size(110, 23);
            this.btStartScan.TabIndex = 1;
            this.btStartScan.Text = "СТАРТ";
            this.btStartScan.UseVisualStyleBackColor = true;
            this.btStartScan.Click += new System.EventHandler(this.btStartScan_Click);
            // 
            // lbDUMP
            // 
            this.lbDUMP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDUMP.FormattingEnabled = true;
            this.lbDUMP.Location = new System.Drawing.Point(3, 41);
            this.lbDUMP.Name = "lbDUMP";
            this.lbDUMP.Size = new System.Drawing.Size(704, 537);
            this.lbDUMP.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отображение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnect,
            this.tsslPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1232, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslConnect
            // 
            this.tsslConnect.Name = "tsslConnect";
            this.tsslConnect.Size = new System.Drawing.Size(86, 17);
            this.tsslConnect.Text = "No connection";
            // 
            // tsslPort
            // 
            this.tsslPort.Name = "tsslPort";
            this.tsslPort.Size = new System.Drawing.Size(41, 17);
            this.tsslPort.Text = "COM1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 24);
            this.label10.TabIndex = 11;
            this.label10.Text = "Поток данных из устройства";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbDUMP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(511, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 581);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(502, 281);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbTime);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbDate);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 66);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дата и время";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(53, 16);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(61, 13);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "00.00.0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbYm);
            this.groupBox5.Controls.Add(this.lbXm);
            this.groupBox5.Controls.Add(this.lbLon);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.lbLat);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(6, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 65);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Текущие координаты";
            // 
            // lbLon
            // 
            this.lbLon.AutoSize = true;
            this.lbLon.Location = new System.Drawing.Point(67, 41);
            this.lbLon.Name = "lbLon";
            this.lbLon.Size = new System.Drawing.Size(61, 13);
            this.lbLon.TabIndex = 14;
            this.lbLon.Text = "00.00.0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Долгота:";
            // 
            // lbLat
            // 
            this.lbLat.AutoSize = true;
            this.lbLat.Location = new System.Drawing.Point(67, 21);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(61, 13);
            this.lbLat.TabIndex = 12;
            this.lbLat.Text = "00.00.0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Широта:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(53, 38);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(61, 13);
            this.lbTime.TabIndex = 10;
            this.lbTime.Text = "00.00.0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Время:";
            // 
            // lbXm
            // 
            this.lbXm.AutoSize = true;
            this.lbXm.Location = new System.Drawing.Point(172, 21);
            this.lbXm.Name = "lbXm";
            this.lbXm.Size = new System.Drawing.Size(61, 13);
            this.lbXm.TabIndex = 15;
            this.lbXm.Text = "00.00.0000";
            // 
            // lbYm
            // 
            this.lbYm.AutoSize = true;
            this.lbYm.Location = new System.Drawing.Point(172, 41);
            this.lbYm.Name = "lbYm";
            this.lbYm.Size = new System.Drawing.Size(61, 13);
            this.lbYm.TabIndex = 16;
            this.lbYm.Text = "00.00.0000";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbAzimutSp);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.lbDirectSp);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.lbNumSp);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.lbColSp);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(131, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 66);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Спутники";
            // 
            // lbNumSp
            // 
            this.lbNumSp.AutoSize = true;
            this.lbNumSp.Location = new System.Drawing.Point(122, 38);
            this.lbNumSp.Name = "lbNumSp";
            this.lbNumSp.Size = new System.Drawing.Size(47, 13);
            this.lbNumSp.TabIndex = 10;
            this.lbNumSp.Text = "0 / 0 / 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Номер активных:";
            // 
            // lbColSp
            // 
            this.lbColSp.AutoSize = true;
            this.lbColSp.Location = new System.Drawing.Point(122, 16);
            this.lbColSp.Name = "lbColSp";
            this.lbColSp.Size = new System.Drawing.Size(13, 13);
            this.lbColSp.TabIndex = 8;
            this.lbColSp.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Количество:";
            // 
            // lbDirectSp
            // 
            this.lbDirectSp.AutoSize = true;
            this.lbDirectSp.Location = new System.Drawing.Point(294, 16);
            this.lbDirectSp.Name = "lbDirectSp";
            this.lbDirectSp.Size = new System.Drawing.Size(13, 13);
            this.lbDirectSp.TabIndex = 12;
            this.lbDirectSp.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(178, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Угол места:";
            // 
            // lbAzimutSp
            // 
            this.lbAzimutSp.AutoSize = true;
            this.lbAzimutSp.Location = new System.Drawing.Point(294, 38);
            this.lbAzimutSp.Name = "lbAzimutSp";
            this.lbAzimutSp.Size = new System.Drawing.Size(13, 13);
            this.lbAzimutSp.TabIndex = 14;
            this.lbAzimutSp.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(178, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Азимут:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GPS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lbDUMP;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnect;
        private System.Windows.Forms.Button btStartScan;
        private System.Windows.Forms.Button btCleanList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNumPort;
        private System.Windows.Forms.ComboBox cbSpeedPort;
        private System.Windows.Forms.ToolStripStatusLabel tsslPort;
        private System.Windows.Forms.ComboBox cbTimerInterv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbLon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbLat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbYm;
        private System.Windows.Forms.Label lbXm;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbNumSp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbColSp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbDirectSp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbAzimutSp;
        private System.Windows.Forms.Label label5;
    }
}

