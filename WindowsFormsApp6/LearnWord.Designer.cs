namespace WindowsFormsApp6
{
    partial class LearnWord
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnWord));
            this.nextWordButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.previousWordButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.enWordLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.showWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.trWordLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statisticBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.quizPageButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.nextWordButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousWordButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextWordButton
            // 
            this.nextWordButton.BackColor = System.Drawing.Color.Transparent;
            this.nextWordButton.Image = ((System.Drawing.Image)(resources.GetObject("nextWordButton.Image")));
            this.nextWordButton.ImageActive = null;
            this.nextWordButton.Location = new System.Drawing.Point(206, 296);
            this.nextWordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextWordButton.Name = "nextWordButton";
            this.nextWordButton.Size = new System.Drawing.Size(89, 71);
            this.nextWordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextWordButton.TabIndex = 36;
            this.nextWordButton.TabStop = false;
            this.nextWordButton.Zoom = 20;
            this.nextWordButton.Click += new System.EventHandler(this.NextWordButton_Click);
            // 
            // previousWordButton
            // 
            this.previousWordButton.BackColor = System.Drawing.Color.Transparent;
            this.previousWordButton.Image = ((System.Drawing.Image)(resources.GetObject("previousWordButton.Image")));
            this.previousWordButton.ImageActive = null;
            this.previousWordButton.Location = new System.Drawing.Point(113, 296);
            this.previousWordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousWordButton.Name = "previousWordButton";
            this.previousWordButton.Size = new System.Drawing.Size(87, 71);
            this.previousWordButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previousWordButton.TabIndex = 35;
            this.previousWordButton.TabStop = false;
            this.previousWordButton.Zoom = 20;
            this.previousWordButton.Click += new System.EventHandler(this.PreviousWordButton_Click);
            // 
            // enWordLabel
            // 
            this.enWordLabel.AutoSize = true;
            this.enWordLabel.BackColor = System.Drawing.Color.Transparent;
            this.enWordLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enWordLabel.Location = new System.Drawing.Point(119, 64);
            this.enWordLabel.Name = "enWordLabel";
            this.enWordLabel.Size = new System.Drawing.Size(95, 45);
            this.enWordLabel.TabIndex = 32;
            this.enWordLabel.Text = "Hello";
            this.enWordLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showWordButton
            // 
            this.showWordButton.ActiveBorderThickness = 1;
            this.showWordButton.ActiveCornerRadius = 20;
            this.showWordButton.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.showWordButton.ActiveForecolor = System.Drawing.Color.White;
            this.showWordButton.ActiveLineColor = System.Drawing.Color.LightSkyBlue;
            this.showWordButton.BackColor = System.Drawing.Color.White;
            this.showWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showWordButton.BackgroundImage")));
            this.showWordButton.ButtonText = "Göster";
            this.showWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showWordButton.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.showWordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.showWordButton.IdleBorderThickness = 1;
            this.showWordButton.IdleCornerRadius = 25;
            this.showWordButton.IdleFillColor = System.Drawing.Color.White;
            this.showWordButton.IdleForecolor = System.Drawing.Color.Purple;
            this.showWordButton.IdleLineColor = System.Drawing.Color.Violet;
            this.showWordButton.Location = new System.Drawing.Point(127, 133);
            this.showWordButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.showWordButton.Name = "showWordButton";
            this.showWordButton.Size = new System.Drawing.Size(135, 55);
            this.showWordButton.TabIndex = 34;
            this.showWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showWordButton.Click += new System.EventHandler(this.ShowWordButton_Click);
            // 
            // trWordLabel
            // 
            this.trWordLabel.AutoSize = true;
            this.trWordLabel.BackColor = System.Drawing.Color.Transparent;
            this.trWordLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.trWordLabel.Location = new System.Drawing.Point(123, 211);
            this.trWordLabel.Name = "trWordLabel";
            this.trWordLabel.Size = new System.Drawing.Size(150, 45);
            this.trWordLabel.TabIndex = 33;
            this.trWordLabel.Text = "Merhaba";
            this.trWordLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenilen Kelimeler";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // statisticBar
            // 
            this.statisticBar.animated = true;
            this.statisticBar.animationIterval = 5;
            this.statisticBar.animationSpeed = 40;
            this.statisticBar.BackColor = System.Drawing.Color.Transparent;
            this.statisticBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statisticBar.BackgroundImage")));
            this.statisticBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.statisticBar.ForeColor = System.Drawing.Color.Lavender;
            this.statisticBar.LabelVisible = true;
            this.statisticBar.LineProgressThickness = 8;
            this.statisticBar.LineThickness = 5;
            this.statisticBar.Location = new System.Drawing.Point(1, 283);
            this.statisticBar.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.statisticBar.MaxValue = 100;
            this.statisticBar.Name = "statisticBar";
            this.statisticBar.ProgressBackColor = System.Drawing.Color.White;
            this.statisticBar.ProgressColor = System.Drawing.Color.Red;
            this.statisticBar.Size = new System.Drawing.Size(177, 177);
            this.statisticBar.TabIndex = 2;
            this.statisticBar.Value = 75;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.statisticBar);
            this.bunifuGradientPanel2.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel2.Controls.Add(this.label1);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Lavender;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Orchid;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(568, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(197, 487);
            this.bunifuGradientPanel2.TabIndex = 37;
            // 
            // quizPageButton
            // 
            this.quizPageButton.ActiveBorderThickness = 1;
            this.quizPageButton.ActiveCornerRadius = 20;
            this.quizPageButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.quizPageButton.ActiveForecolor = System.Drawing.Color.White;
            this.quizPageButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.quizPageButton.BackColor = System.Drawing.Color.White;
            this.quizPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quizPageButton.BackgroundImage")));
            this.quizPageButton.ButtonText = "Sınava Başla";
            this.quizPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quizPageButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizPageButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.quizPageButton.IdleBorderThickness = 1;
            this.quizPageButton.IdleCornerRadius = 20;
            this.quizPageButton.IdleFillColor = System.Drawing.Color.White;
            this.quizPageButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.quizPageButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.quizPageButton.Location = new System.Drawing.Point(91, 396);
            this.quizPageButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.quizPageButton.Name = "quizPageButton";
            this.quizPageButton.Size = new System.Drawing.Size(243, 46);
            this.quizPageButton.TabIndex = 38;
            this.quizPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quizPageButton.Click += new System.EventHandler(this.QuizPageButton_Click);
            // 
            // LearnWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.quizPageButton);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.nextWordButton);
            this.Controls.Add(this.previousWordButton);
            this.Controls.Add(this.enWordLabel);
            this.Controls.Add(this.showWordButton);
            this.Controls.Add(this.trWordLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LearnWord";
            this.Size = new System.Drawing.Size(765, 487);
            this.Load += new System.EventHandler(this.LearnWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nextWordButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousWordButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton nextWordButton;
        private Bunifu.Framework.UI.BunifuImageButton previousWordButton;
        private Bunifu.Framework.UI.BunifuCustomLabel enWordLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 showWordButton;
        private Bunifu.Framework.UI.BunifuCustomLabel trWordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar statisticBar;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuThinButton2 quizPageButton;
    }
}
