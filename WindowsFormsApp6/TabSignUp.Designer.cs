namespace WindowsFormsApp6
{
    partial class TabSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSignUp));
            this.userNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mailText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.registerButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TabSignPageButton = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
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
            this.userNameText.Location = new System.Drawing.Point(51, 44);
            this.userNameText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(333, 48);
            this.userNameText.TabIndex = 8;
            this.userNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameText
            // 
            this.nameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.nameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameText.HintForeColor = System.Drawing.Color.Empty;
            this.nameText.HintText = "Adınızı Giriniz";
            this.nameText.isPassword = false;
            this.nameText.LineFocusedColor = System.Drawing.Color.Blue;
            this.nameText.LineIdleColor = System.Drawing.Color.Gray;
            this.nameText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.nameText.LineThickness = 3;
            this.nameText.Location = new System.Drawing.Point(51, 127);
            this.nameText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(333, 48);
            this.nameText.TabIndex = 9;
            this.nameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mailText
            // 
            this.mailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.mailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mailText.HintForeColor = System.Drawing.Color.Empty;
            this.mailText.HintText = "Mail\'inizi Giriniz";
            this.mailText.isPassword = false;
            this.mailText.LineFocusedColor = System.Drawing.Color.Blue;
            this.mailText.LineIdleColor = System.Drawing.Color.Gray;
            this.mailText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mailText.LineThickness = 3;
            this.mailText.Location = new System.Drawing.Point(51, 210);
            this.mailText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(333, 48);
            this.mailText.TabIndex = 10;
            this.mailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.passText.Location = new System.Drawing.Point(51, 293);
            this.passText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(333, 48);
            this.passText.TabIndex = 11;
            this.passText.Text = "sifre";
            this.passText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passText.OnValueChanged += new System.EventHandler(this.PassText_OnValueChanged);
            // 
            // registerButton
            // 
            this.registerButton.ActiveBorderThickness = 1;
            this.registerButton.ActiveCornerRadius = 20;
            this.registerButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.registerButton.ActiveForecolor = System.Drawing.Color.White;
            this.registerButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.registerButton.BackColor = System.Drawing.Color.White;
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
            this.registerButton.ButtonText = "Kayıt Ol";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.registerButton.IdleBorderThickness = 1;
            this.registerButton.IdleCornerRadius = 20;
            this.registerButton.IdleFillColor = System.Drawing.Color.White;
            this.registerButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.registerButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.registerButton.Location = new System.Drawing.Point(13, 385);
            this.registerButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(371, 55);
            this.registerButton.TabIndex = 12;
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(13, 66);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(13, 150);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(29, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 14;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(13, 233);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(29, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 15;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(13, 316);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(29, 25);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 16;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(473, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hesabınız var mı ?";
            // 
            // TabSignPageButton
            // 
            this.TabSignPageButton.ActiveBorderThickness = 1;
            this.TabSignPageButton.ActiveCornerRadius = 20;
            this.TabSignPageButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.TabSignPageButton.ActiveForecolor = System.Drawing.Color.White;
            this.TabSignPageButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.TabSignPageButton.BackColor = System.Drawing.Color.White;
            this.TabSignPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabSignPageButton.BackgroundImage")));
            this.TabSignPageButton.ButtonText = "Giriş Yapın";
            this.TabSignPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabSignPageButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSignPageButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.TabSignPageButton.IdleBorderThickness = 1;
            this.TabSignPageButton.IdleCornerRadius = 20;
            this.TabSignPageButton.IdleFillColor = System.Drawing.Color.White;
            this.TabSignPageButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.TabSignPageButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.TabSignPageButton.Location = new System.Drawing.Point(471, 194);
            this.TabSignPageButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TabSignPageButton.Name = "TabSignPageButton";
            this.TabSignPageButton.Size = new System.Drawing.Size(236, 46);
            this.TabSignPageButton.TabIndex = 20;
            this.TabSignPageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TabSignPageButton.Click += new System.EventHandler(this.TabSignPageButton_Click);
            // 
            // TabSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabSignPageButton);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.userNameText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TabSignUp";
            this.Size = new System.Drawing.Size(765, 487);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox userNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mailText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passText;
        private Bunifu.Framework.UI.BunifuThinButton2 registerButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 TabSignPageButton;
    }
}
