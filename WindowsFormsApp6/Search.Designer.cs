namespace WindowsFormsApp6
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.searchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.searchText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.searchListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addListButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateWordButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddWordPageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.randomButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.myListButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.wordIDLabel = new System.Windows.Forms.Label();
            this.updateCloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateWordButton2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.trWordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.enWordTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.AddWordPageButton)).BeginInit();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.ActiveBorderThickness = 1;
            this.searchButton.ActiveCornerRadius = 20;
            this.searchButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.searchButton.ActiveForecolor = System.Drawing.Color.White;
            this.searchButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.ButtonText = "Ara";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleCornerRadius = 20;
            this.searchButton.IdleFillColor = System.Drawing.Color.White;
            this.searchButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.searchButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.searchButton.Location = new System.Drawing.Point(518, 15);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 55);
            this.searchButton.TabIndex = 14;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchText.HintForeColor = System.Drawing.Color.Empty;
            this.searchText.HintText = "Aradığınız kelimenin Türkçe veya İngilizcesini giriniz";
            this.searchText.isPassword = false;
            this.searchText.LineFocusedColor = System.Drawing.Color.Blue;
            this.searchText.LineIdleColor = System.Drawing.Color.Gray;
            this.searchText.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.searchText.LineThickness = 3;
            this.searchText.Location = new System.Drawing.Point(5, 15);
            this.searchText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(503, 48);
            this.searchText.TabIndex = 13;
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // searchListView
            // 
            this.searchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.searchListView.FullRowSelect = true;
            this.searchListView.Location = new System.Drawing.Point(15, 82);
            this.searchListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(744, 319);
            this.searchListView.TabIndex = 15;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.Details;
            this.searchListView.SelectedIndexChanged += new System.EventHandler(this.SearchListView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 44;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Türkçe";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İngilizce";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sahibi";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Liste Durumu";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Liste Seviye";
            this.columnHeader5.Width = 70;
            // 
            // addListButton
            // 
            this.addListButton.ActiveBorderThickness = 1;
            this.addListButton.ActiveCornerRadius = 20;
            this.addListButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addListButton.ActiveForecolor = System.Drawing.Color.White;
            this.addListButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addListButton.BackColor = System.Drawing.Color.White;
            this.addListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addListButton.BackgroundImage")));
            this.addListButton.ButtonText = "Listeme ...";
            this.addListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addListButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addListButton.IdleBorderThickness = 1;
            this.addListButton.IdleCornerRadius = 20;
            this.addListButton.IdleFillColor = System.Drawing.Color.White;
            this.addListButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addListButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addListButton.Location = new System.Drawing.Point(5, 405);
            this.addListButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(226, 53);
            this.addListButton.TabIndex = 16;
            this.addListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // deleteWordButton
            // 
            this.deleteWordButton.ActiveBorderThickness = 1;
            this.deleteWordButton.ActiveCornerRadius = 20;
            this.deleteWordButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteWordButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.BackColor = System.Drawing.Color.White;
            this.deleteWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteWordButton.BackgroundImage")));
            this.deleteWordButton.ButtonText = "Kelimeyi Sil";
            this.deleteWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteWordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.IdleBorderThickness = 1;
            this.deleteWordButton.IdleCornerRadius = 20;
            this.deleteWordButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteWordButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.deleteWordButton.Location = new System.Drawing.Point(233, 405);
            this.deleteWordButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deleteWordButton.Name = "deleteWordButton";
            this.deleteWordButton.Size = new System.Drawing.Size(140, 55);
            this.deleteWordButton.TabIndex = 17;
            this.deleteWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteWordButton.Click += new System.EventHandler(this.DeleteWordButton_Click);
            // 
            // updateWordButton
            // 
            this.updateWordButton.ActiveBorderThickness = 1;
            this.updateWordButton.ActiveCornerRadius = 20;
            this.updateWordButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.ActiveForecolor = System.Drawing.Color.White;
            this.updateWordButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.BackColor = System.Drawing.Color.White;
            this.updateWordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateWordButton.BackgroundImage")));
            this.updateWordButton.ButtonText = "Kelimeyi Güncelle";
            this.updateWordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateWordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateWordButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.IdleBorderThickness = 1;
            this.updateWordButton.IdleCornerRadius = 20;
            this.updateWordButton.IdleFillColor = System.Drawing.Color.White;
            this.updateWordButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton.Location = new System.Drawing.Point(381, 405);
            this.updateWordButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.updateWordButton.Name = "updateWordButton";
            this.updateWordButton.Size = new System.Drawing.Size(208, 55);
            this.updateWordButton.TabIndex = 18;
            this.updateWordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateWordButton.Click += new System.EventHandler(this.UpdateWordButton_Click);
            // 
            // AddWordPageButton
            // 
            this.AddWordPageButton.BackColor = System.Drawing.Color.Transparent;
            this.AddWordPageButton.Image = ((System.Drawing.Image)(resources.GetObject("AddWordPageButton.Image")));
            this.AddWordPageButton.ImageActive = null;
            this.AddWordPageButton.Location = new System.Drawing.Point(706, 407);
            this.AddWordPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddWordPageButton.Name = "AddWordPageButton";
            this.AddWordPageButton.Size = new System.Drawing.Size(59, 53);
            this.AddWordPageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddWordPageButton.TabIndex = 19;
            this.AddWordPageButton.TabStop = false;
            this.AddWordPageButton.Zoom = 20;
            this.AddWordPageButton.Click += new System.EventHandler(this.AddWordPageButton_Click);
            // 
            // randomButton
            // 
            this.randomButton.ActiveBorderThickness = 1;
            this.randomButton.ActiveCornerRadius = 20;
            this.randomButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.randomButton.ActiveForecolor = System.Drawing.Color.White;
            this.randomButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.randomButton.BackColor = System.Drawing.Color.White;
            this.randomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("randomButton.BackgroundImage")));
            this.randomButton.ButtonText = "Random";
            this.randomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randomButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.randomButton.IdleBorderThickness = 1;
            this.randomButton.IdleCornerRadius = 20;
            this.randomButton.IdleFillColor = System.Drawing.Color.White;
            this.randomButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.randomButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.randomButton.Location = new System.Drawing.Point(594, 405);
            this.randomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(105, 55);
            this.randomButton.TabIndex = 20;
            this.randomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // myListButton
            // 
            this.myListButton.ActiveBorderThickness = 1;
            this.myListButton.ActiveCornerRadius = 20;
            this.myListButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.myListButton.ActiveForecolor = System.Drawing.Color.White;
            this.myListButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.myListButton.BackColor = System.Drawing.Color.White;
            this.myListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myListButton.BackgroundImage")));
            this.myListButton.ButtonText = "Benim Listem";
            this.myListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myListButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myListButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.myListButton.IdleBorderThickness = 1;
            this.myListButton.IdleCornerRadius = 20;
            this.myListButton.IdleFillColor = System.Drawing.Color.White;
            this.myListButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.myListButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.myListButton.Location = new System.Drawing.Point(601, 14);
            this.myListButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.myListButton.Name = "myListButton";
            this.myListButton.Size = new System.Drawing.Size(159, 55);
            this.myListButton.TabIndex = 21;
            this.myListButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myListButton.Click += new System.EventHandler(this.MyListButton_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePanel.Controls.Add(this.wordIDLabel);
            this.updatePanel.Controls.Add(this.updateCloseButton);
            this.updatePanel.Controls.Add(this.pictureBox2);
            this.updatePanel.Controls.Add(this.pictureBox1);
            this.updatePanel.Controls.Add(this.updateWordButton2);
            this.updatePanel.Controls.Add(this.trWordTextBox);
            this.updatePanel.Controls.Add(this.enWordTextBox);
            this.updatePanel.Location = new System.Drawing.Point(53, 38);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(655, 380);
            this.updatePanel.TabIndex = 22;
            this.updatePanel.Visible = false;
            // 
            // wordIDLabel
            // 
            this.wordIDLabel.AutoSize = true;
            this.wordIDLabel.Location = new System.Drawing.Point(299, 37);
            this.wordIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordIDLabel.Name = "wordIDLabel";
            this.wordIDLabel.Size = new System.Drawing.Size(59, 17);
            this.wordIDLabel.TabIndex = 28;
            this.wordIDLabel.Text = "Word ID";
            this.wordIDLabel.Visible = false;
            // 
            // updateCloseButton
            // 
            this.updateCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.updateCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("updateCloseButton.Image")));
            this.updateCloseButton.ImageActive = null;
            this.updateCloseButton.Location = new System.Drawing.Point(624, 2);
            this.updateCloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateCloseButton.Name = "updateCloseButton";
            this.updateCloseButton.Size = new System.Drawing.Size(29, 30);
            this.updateCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.updateCloseButton.TabIndex = 27;
            this.updateCloseButton.TabStop = false;
            this.updateCloseButton.Zoom = 20;
            this.updateCloseButton.Click += new System.EventHandler(this.UpdateCloseButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 158);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // updateWordButton2
            // 
            this.updateWordButton2.ActiveBorderThickness = 1;
            this.updateWordButton2.ActiveCornerRadius = 20;
            this.updateWordButton2.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton2.ActiveForecolor = System.Drawing.Color.White;
            this.updateWordButton2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton2.BackColor = System.Drawing.Color.White;
            this.updateWordButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateWordButton2.BackgroundImage")));
            this.updateWordButton2.ButtonText = "Kelimeyi Güncelle";
            this.updateWordButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateWordButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateWordButton2.ForeColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton2.IdleBorderThickness = 1;
            this.updateWordButton2.IdleCornerRadius = 20;
            this.updateWordButton2.IdleFillColor = System.Drawing.Color.White;
            this.updateWordButton2.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.updateWordButton2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updateWordButton2.Location = new System.Drawing.Point(189, 230);
            this.updateWordButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.updateWordButton2.Name = "updateWordButton2";
            this.updateWordButton2.Size = new System.Drawing.Size(321, 55);
            this.updateWordButton2.TabIndex = 24;
            this.updateWordButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateWordButton2.Click += new System.EventHandler(this.UpdateWordButton2_Click);
            // 
            // trWordTextBox
            // 
            this.trWordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trWordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trWordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trWordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.trWordTextBox.HintText = "Türkçe kelimeyi giriniz";
            this.trWordTextBox.isPassword = false;
            this.trWordTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.trWordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.trWordTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.trWordTextBox.LineThickness = 3;
            this.trWordTextBox.Location = new System.Drawing.Point(189, 160);
            this.trWordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.trWordTextBox.Name = "trWordTextBox";
            this.trWordTextBox.Size = new System.Drawing.Size(321, 39);
            this.trWordTextBox.TabIndex = 23;
            this.trWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // enWordTextBox
            // 
            this.enWordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enWordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enWordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enWordTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.enWordTextBox.HintText = "İngilizce kelimeyi giriniz";
            this.enWordTextBox.isPassword = false;
            this.enWordTextBox.LineFocusedColor = System.Drawing.Color.Blue;
            this.enWordTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.enWordTextBox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.enWordTextBox.LineThickness = 3;
            this.enWordTextBox.Location = new System.Drawing.Point(189, 96);
            this.enWordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.enWordTextBox.Name = "enWordTextBox";
            this.enWordTextBox.Size = new System.Drawing.Size(321, 39);
            this.enWordTextBox.TabIndex = 22;
            this.enWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.myListButton);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.AddWordPageButton);
            this.Controls.Add(this.updateWordButton);
            this.Controls.Add(this.deleteWordButton);
            this.Controls.Add(this.addListButton);
            this.Controls.Add(this.searchListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(765, 487);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddWordPageButton)).EndInit();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 searchButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchText;
        private System.Windows.Forms.ListView searchListView;
        private Bunifu.Framework.UI.BunifuThinButton2 addListButton;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteWordButton;
        private Bunifu.Framework.UI.BunifuThinButton2 updateWordButton;
        private Bunifu.Framework.UI.BunifuImageButton AddWordPageButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Bunifu.Framework.UI.BunifuThinButton2 randomButton;
        private Bunifu.Framework.UI.BunifuThinButton2 myListButton;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 updateWordButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox trWordTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox enWordTextBox;
        private Bunifu.Framework.UI.BunifuImageButton updateCloseButton;
        private System.Windows.Forms.Label wordIDLabel;
    }
}
