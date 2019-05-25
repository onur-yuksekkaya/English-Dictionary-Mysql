namespace WindowsFormsApp6
{
    partial class TabSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSign));
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.passText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.userNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TabSignUpPageButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 1;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "Giriş Yapın";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleBorderThickness = 1;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.White;
            this.loginButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.loginButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.loginButton.Location = new System.Drawing.Point(21, 278);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(357, 50);
            this.loginButton.TabIndex = 15;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passText
            // 
            this.passText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.passText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passText.HintForeColor = System.Drawing.Color.Empty;
            this.passText.HintText = "";
            this.passText.isPassword = true;
            this.passText.LineFocusedColor = System.Drawing.Color.Blue;
            this.passText.LineIdleColor = System.Drawing.Color.Gray;
            this.passText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passText.LineThickness = 3;
            this.passText.Location = new System.Drawing.Point(57, 204);
            this.passText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(321, 39);
            this.passText.TabIndex = 14;
            this.passText.Text = "aa";
            this.passText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passText.OnValueChanged += new System.EventHandler(this.PassText_OnValueChanged);
            // 
            // userNameText
            // 
            this.userNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameText.HintForeColor = System.Drawing.Color.Empty;
            this.userNameText.HintText = "Kullanıcı Adınızı Giriniz";
            this.userNameText.isPassword = false;
            this.userNameText.LineFocusedColor = System.Drawing.Color.Blue;
            this.userNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.userNameText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userNameText.LineThickness = 3;
            this.userNameText.Location = new System.Drawing.Point(57, 126);
            this.userNameText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(321, 39);
            this.userNameText.TabIndex = 13;
            this.userNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(21, 217);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(28, 27);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 18;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(21, 138);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(485, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hesabınız yok mu ?";
            // 
            // TabSignUpPageButton
            // 
            this.TabSignUpPageButton.ActiveBorderThickness = 1;
            this.TabSignUpPageButton.ActiveCornerRadius = 20;
            this.TabSignUpPageButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.TabSignUpPageButton.ActiveForecolor = System.Drawing.Color.White;
            this.TabSignUpPageButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.TabSignUpPageButton.BackColor = System.Drawing.Color.White;
            this.TabSignUpPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabSignUpPageButton.BackgroundImage")));
            this.TabSignUpPageButton.ButtonText = "Kayıt Olun";
            this.TabSignUpPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabSignUpPageButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSignUpPageButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.TabSignUpPageButton.IdleBorderThickness = 1;
            this.TabSignUpPageButton.IdleCornerRadius = 20;
            this.TabSignUpPageButton.IdleFillColor = System.Drawing.Color.White;
            this.TabSignUpPageButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.TabSignUpPageButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.TabSignUpPageButton.Location = new System.Drawing.Point(492, 217);
            this.TabSignUpPageButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabSignUpPageButton.Name = "TabSignUpPageButton";
            this.TabSignUpPageButton.Size = new System.Drawing.Size(243, 46);
            this.TabSignUpPageButton.TabIndex = 20;
            this.TabSignUpPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabSignUpPageButton.Click += new System.EventHandler(this.TabSignUpPageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Şifrenizi Giriniz";
            // 
            // TabSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TabSignUpPageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userNameText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TabSign";
            this.Size = new System.Drawing.Size(765, 487);
            this.Load += new System.EventHandler(this.TabSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameText;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 TabSignUpPageButton;
        private System.Windows.Forms.Label label2;
    }
}
