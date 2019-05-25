namespace WindowsFormsApp6
{
    partial class QuizPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizPage));
            this.questionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.aOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dOptionsButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.levelLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.questionLabel.Location = new System.Drawing.Point(225, 32);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(80, 37);
            this.questionLabel.TabIndex = 28;
            this.questionLabel.Text = "Hello";
            // 
            // aOptionsButton
            // 
            this.aOptionsButton.ActiveBorderThickness = 1;
            this.aOptionsButton.ActiveCornerRadius = 20;
            this.aOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.aOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.BackColor = System.Drawing.Color.White;
            this.aOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aOptionsButton.BackgroundImage")));
            this.aOptionsButton.ButtonText = "";
            this.aOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.IdleBorderThickness = 1;
            this.aOptionsButton.IdleCornerRadius = 20;
            this.aOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.aOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.aOptionsButton.Location = new System.Drawing.Point(92, 131);
            this.aOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.aOptionsButton.Name = "aOptionsButton";
            this.aOptionsButton.Size = new System.Drawing.Size(167, 47);
            this.aOptionsButton.TabIndex = 29;
            this.aOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.aOptionsButton.Click += new System.EventHandler(this.AOptionsButton_Click);
            // 
            // bOptionsButton
            // 
            this.bOptionsButton.ActiveBorderThickness = 1;
            this.bOptionsButton.ActiveCornerRadius = 20;
            this.bOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.bOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.BackColor = System.Drawing.Color.White;
            this.bOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bOptionsButton.BackgroundImage")));
            this.bOptionsButton.ButtonText = "";
            this.bOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.IdleBorderThickness = 1;
            this.bOptionsButton.IdleCornerRadius = 20;
            this.bOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.bOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bOptionsButton.Location = new System.Drawing.Point(279, 131);
            this.bOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.bOptionsButton.Name = "bOptionsButton";
            this.bOptionsButton.Size = new System.Drawing.Size(172, 47);
            this.bOptionsButton.TabIndex = 30;
            this.bOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bOptionsButton.Click += new System.EventHandler(this.BOptionsButton_Click);
            // 
            // cOptionsButton
            // 
            this.cOptionsButton.ActiveBorderThickness = 1;
            this.cOptionsButton.ActiveCornerRadius = 20;
            this.cOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.cOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.BackColor = System.Drawing.Color.White;
            this.cOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cOptionsButton.BackgroundImage")));
            this.cOptionsButton.ButtonText = "";
            this.cOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.IdleBorderThickness = 1;
            this.cOptionsButton.IdleCornerRadius = 20;
            this.cOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.cOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cOptionsButton.Location = new System.Drawing.Point(92, 210);
            this.cOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.cOptionsButton.Name = "cOptionsButton";
            this.cOptionsButton.Size = new System.Drawing.Size(167, 49);
            this.cOptionsButton.TabIndex = 31;
            this.cOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cOptionsButton.Click += new System.EventHandler(this.COptionsButton_Click);
            // 
            // dOptionsButton
            // 
            this.dOptionsButton.ActiveBorderThickness = 1;
            this.dOptionsButton.ActiveCornerRadius = 20;
            this.dOptionsButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.ActiveForecolor = System.Drawing.Color.White;
            this.dOptionsButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.BackColor = System.Drawing.Color.White;
            this.dOptionsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dOptionsButton.BackgroundImage")));
            this.dOptionsButton.ButtonText = "";
            this.dOptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dOptionsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOptionsButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.IdleBorderThickness = 1;
            this.dOptionsButton.IdleCornerRadius = 20;
            this.dOptionsButton.IdleFillColor = System.Drawing.Color.White;
            this.dOptionsButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.dOptionsButton.Location = new System.Drawing.Point(279, 210);
            this.dOptionsButton.Margin = new System.Windows.Forms.Padding(4);
            this.dOptionsButton.Name = "dOptionsButton";
            this.dOptionsButton.Size = new System.Drawing.Size(172, 49);
            this.dOptionsButton.TabIndex = 32;
            this.dOptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dOptionsButton.Click += new System.EventHandler(this.DOptionsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.label1.Location = new System.Drawing.Point(161, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 33;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelLabel.Location = new System.Drawing.Point(194, 69);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(91, 37);
            this.levelLabel.TabIndex = 34;
            this.levelLabel.Text = "Level :";
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dOptionsButton);
            this.Controls.Add(this.cOptionsButton);
            this.Controls.Add(this.bOptionsButton);
            this.Controls.Add(this.aOptionsButton);
            this.Controls.Add(this.questionLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuizPage";
            this.Size = new System.Drawing.Size(574, 396);
            this.Load += new System.EventHandler(this.QuizPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel questionLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 aOptionsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bOptionsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 cOptionsButton;
        private Bunifu.Framework.UI.BunifuThinButton2 dOptionsButton;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel levelLabel;
    }
}
