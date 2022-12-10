namespace MyPets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar_eat = new System.Windows.Forms.ProgressBar();
            this.progressBar_fun = new System.Windows.Forms.ProgressBar();
            this.progressBar_health = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar_eat
            // 
            this.progressBar_eat.BackColor = System.Drawing.Color.Gold;
            this.progressBar_eat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar_eat.Location = new System.Drawing.Point(271, 72);
            this.progressBar_eat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar_eat.Name = "progressBar_eat";
            this.progressBar_eat.Size = new System.Drawing.Size(150, 27);
            this.progressBar_eat.Step = 5;
            this.progressBar_eat.TabIndex = 0;
            
            this.progressBar_eat.Click += new System.EventHandler(this.progressBar_eat_Click_1);
            // 
            // progressBar_fun
            // 
            this.progressBar_fun.BackColor = System.Drawing.Color.Gold;
            this.progressBar_fun.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar_fun.Location = new System.Drawing.Point(271, 105);
            this.progressBar_fun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar_fun.Name = "progressBar_fun";
            this.progressBar_fun.Size = new System.Drawing.Size(150, 27);
            this.progressBar_fun.Step = 5;
            this.progressBar_fun.TabIndex = 1;
            
            this.progressBar_fun.Click += new System.EventHandler(this.progressBar_fun_Click);
            // 
            // progressBar_health
            // 
            this.progressBar_health.BackColor = System.Drawing.Color.Moccasin;
            this.progressBar_health.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar_health.Location = new System.Drawing.Point(271, 138);
            this.progressBar_health.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBar_health.Name = "progressBar_health";
            this.progressBar_health.Size = new System.Drawing.Size(150, 27);
            this.progressBar_health.Step = 5;
            this.progressBar_health.TabIndex = 2;
            
            this.progressBar_health.Click += new System.EventHandler(this.progressBar_health_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(447, 72);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Покормить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(447, 105);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Поиграть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(447, 144);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Вылечить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(271, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(100, 58);
            this.label1.MinimumSize = new System.Drawing.Size(150, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(447, 265);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Главное меню";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(254, 178);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trackBar1.Maximum = 20000;
            this.trackBar1.Minimum = 250;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(167, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 7000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(264, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Скорость времени 1000 ms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "beer cat.jpg");
            this.imageList1.Images.SetKeyName(1, "cat and dog.bmp");
            this.imageList1.Images.SetKeyName(2, "cat smoke.jpg");
            this.imageList1.Images.SetKeyName(3, "cat_calm.png");
            this.imageList1.Images.SetKeyName(4, "cat_frowns.png");
            this.imageList1.Images.SetKeyName(5, "cat_grave.jpg");
            this.imageList1.Images.SetKeyName(6, "cat_overeat2.png");
            this.imageList1.Images.SetKeyName(7, "dosvidos.jpg");
            this.imageList1.Images.SetKeyName(8, "fail cat1.jpg");
            this.imageList1.Images.SetKeyName(9, "gaming cat.jpg");
            this.imageList1.Images.SetKeyName(10, "happy cat1.jpg");
            this.imageList1.Images.SetKeyName(11, "hungry cat 1.png");
            this.imageList1.Images.SetKeyName(12, "scary cat1.jpg");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(447, 217);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 27);
            this.button5.TabIndex = 13;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 236);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(583, 346);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar_health);
            this.Controls.Add(this.progressBar_fun);
            this.Controls.Add(this.progressBar_eat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(583, 346);
            this.MinimumSize = new System.Drawing.Size(583, 346);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPET\'S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ImageList imageList1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ProgressBar progressBar_eat;
        private ProgressBar progressBar_fun;
        private ProgressBar progressBar_health;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBar1;
    }


}