﻿namespace View
{
    partial class QueryConfigurationControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxKeywords = new System.Windows.Forms.ComboBox();
            this.btnAddKeyword = new System.Windows.Forms.Button();
            this.btnRemoveKeyword = new System.Windows.Forms.Button();
            this.gbxKeywords = new System.Windows.Forms.GroupBox();
            this.gbxLocation = new System.Windows.Forms.GroupBox();
            this.rdbUsa = new System.Windows.Forms.RadioButton();
            this.rdbColombia = new System.Windows.Forms.RadioButton();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.rdbHashtag = new System.Windows.Forms.RadioButton();
            this.rdbNews = new System.Windows.Forms.RadioButton();
            this.rdbImage = new System.Windows.Forms.RadioButton();
            this.rdbVideo = new System.Windows.Forms.RadioButton();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.rdbMixed = new System.Windows.Forms.RadioButton();
            this.rdbRecent = new System.Windows.Forms.RadioButton();
            this.rdbPopular = new System.Windows.Forms.RadioButton();
            this.gbxSearchTypes = new System.Windows.Forms.GroupBox();
            this.gbxLanguages = new System.Windows.Forms.GroupBox();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.rdbSpanish = new System.Windows.Forms.RadioButton();
            this.gbxSinceDate = new System.Windows.Forms.GroupBox();
            this.dtpSinceDate = new System.Windows.Forms.DateTimePicker();
            this.gbxUntilDate = new System.Windows.Forms.GroupBox();
            this.dtpUntilDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalPublications = new System.Windows.Forms.Label();
            this.nmudTotalPublications = new System.Windows.Forms.NumericUpDown();
            this.gbxKeywords.SuspendLayout();
            this.gbxLocation.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.gbxSearchTypes.SuspendLayout();
            this.gbxLanguages.SuspendLayout();
            this.gbxSinceDate.SuspendLayout();
            this.gbxUntilDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudTotalPublications)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxKeywords
            // 
            this.cbxKeywords.FormattingEnabled = true;
            this.cbxKeywords.Location = new System.Drawing.Point(66, 19);
            this.cbxKeywords.Name = "cbxKeywords";
            this.cbxKeywords.Size = new System.Drawing.Size(232, 21);
            this.cbxKeywords.TabIndex = 0;
            // 
            // btnAddKeyword
            // 
            this.btnAddKeyword.Location = new System.Drawing.Point(18, 46);
            this.btnAddKeyword.Name = "btnAddKeyword";
            this.btnAddKeyword.Size = new System.Drawing.Size(130, 23);
            this.btnAddKeyword.TabIndex = 1;
            this.btnAddKeyword.Text = "Añadir palabra clave";
            this.btnAddKeyword.UseVisualStyleBackColor = true;
            this.btnAddKeyword.Click += new System.EventHandler(this.BtnAddKeyword_Click);
            // 
            // btnRemoveKeyword
            // 
            this.btnRemoveKeyword.Location = new System.Drawing.Point(199, 46);
            this.btnRemoveKeyword.Name = "btnRemoveKeyword";
            this.btnRemoveKeyword.Size = new System.Drawing.Size(157, 23);
            this.btnRemoveKeyword.TabIndex = 2;
            this.btnRemoveKeyword.Text = "Eliminar palabra clave";
            this.btnRemoveKeyword.UseVisualStyleBackColor = true;
            this.btnRemoveKeyword.Click += new System.EventHandler(this.BtnRemoveKeyword_Click);
            // 
            // gbxKeywords
            // 
            this.gbxKeywords.Controls.Add(this.cbxKeywords);
            this.gbxKeywords.Controls.Add(this.btnAddKeyword);
            this.gbxKeywords.Controls.Add(this.btnRemoveKeyword);
            this.gbxKeywords.Location = new System.Drawing.Point(48, 21);
            this.gbxKeywords.Name = "gbxKeywords";
            this.gbxKeywords.Size = new System.Drawing.Size(377, 85);
            this.gbxKeywords.TabIndex = 4;
            this.gbxKeywords.TabStop = false;
            this.gbxKeywords.Text = "Palabras clave";
            // 
            // gbxLocation
            // 
            this.gbxLocation.Controls.Add(this.rdbUsa);
            this.gbxLocation.Controls.Add(this.rdbColombia);
            this.gbxLocation.Location = new System.Drawing.Point(48, 112);
            this.gbxLocation.Name = "gbxLocation";
            this.gbxLocation.Size = new System.Drawing.Size(377, 53);
            this.gbxLocation.TabIndex = 5;
            this.gbxLocation.TabStop = false;
            this.gbxLocation.Text = "Localización";
            // 
            // rdbUsa
            // 
            this.rdbUsa.AutoSize = true;
            this.rdbUsa.Location = new System.Drawing.Point(224, 19);
            this.rdbUsa.Name = "rdbUsa";
            this.rdbUsa.Size = new System.Drawing.Size(53, 17);
            this.rdbUsa.TabIndex = 0;
            this.rdbUsa.Text = "U.S.A";
            this.rdbUsa.UseVisualStyleBackColor = true;
            // 
            // rdbColombia
            // 
            this.rdbColombia.AutoSize = true;
            this.rdbColombia.Checked = true;
            this.rdbColombia.Location = new System.Drawing.Point(87, 19);
            this.rdbColombia.Name = "rdbColombia";
            this.rdbColombia.Size = new System.Drawing.Size(68, 17);
            this.rdbColombia.TabIndex = 0;
            this.rdbColombia.TabStop = true;
            this.rdbColombia.Text = "Colombia";
            this.rdbColombia.UseVisualStyleBackColor = true;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.rdbHashtag);
            this.gbxFilter.Controls.Add(this.rdbNews);
            this.gbxFilter.Controls.Add(this.rdbImage);
            this.gbxFilter.Controls.Add(this.rdbVideo);
            this.gbxFilter.Controls.Add(this.rdbNone);
            this.gbxFilter.Location = new System.Drawing.Point(48, 289);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(377, 48);
            this.gbxFilter.TabIndex = 6;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filtro";
            // 
            // rdbHashtag
            // 
            this.rdbHashtag.AutoSize = true;
            this.rdbHashtag.Location = new System.Drawing.Point(301, 19);
            this.rdbHashtag.Name = "rdbHashtag";
            this.rdbHashtag.Size = new System.Drawing.Size(70, 17);
            this.rdbHashtag.TabIndex = 4;
            this.rdbHashtag.TabStop = true;
            this.rdbHashtag.Text = "Hashtags";
            this.rdbHashtag.UseVisualStyleBackColor = true;
            // 
            // rdbNews
            // 
            this.rdbNews.AutoSize = true;
            this.rdbNews.Location = new System.Drawing.Point(232, 19);
            this.rdbNews.Name = "rdbNews";
            this.rdbNews.Size = new System.Drawing.Size(63, 17);
            this.rdbNews.TabIndex = 3;
            this.rdbNews.TabStop = true;
            this.rdbNews.Text = "Noticias";
            this.rdbNews.UseVisualStyleBackColor = true;
            // 
            // rdbImage
            // 
            this.rdbImage.AutoSize = true;
            this.rdbImage.Location = new System.Drawing.Point(146, 19);
            this.rdbImage.Name = "rdbImage";
            this.rdbImage.Size = new System.Drawing.Size(71, 17);
            this.rdbImage.TabIndex = 2;
            this.rdbImage.TabStop = true;
            this.rdbImage.Text = "Imagenes";
            this.rdbImage.UseVisualStyleBackColor = true;
            // 
            // rdbVideo
            // 
            this.rdbVideo.AutoSize = true;
            this.rdbVideo.Location = new System.Drawing.Point(74, 19);
            this.rdbVideo.Name = "rdbVideo";
            this.rdbVideo.Size = new System.Drawing.Size(57, 17);
            this.rdbVideo.TabIndex = 1;
            this.rdbVideo.TabStop = true;
            this.rdbVideo.Text = "Videos";
            this.rdbVideo.UseVisualStyleBackColor = true;
            // 
            // rdbNone
            // 
            this.rdbNone.AutoSize = true;
            this.rdbNone.Checked = true;
            this.rdbNone.Location = new System.Drawing.Point(12, 19);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(56, 17);
            this.rdbNone.TabIndex = 0;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "NONE";
            this.rdbNone.UseVisualStyleBackColor = true;
            // 
            // rdbMixed
            // 
            this.rdbMixed.AutoSize = true;
            this.rdbMixed.Location = new System.Drawing.Point(6, 79);
            this.rdbMixed.Name = "rdbMixed";
            this.rdbMixed.Size = new System.Drawing.Size(57, 17);
            this.rdbMixed.TabIndex = 0;
            this.rdbMixed.TabStop = true;
            this.rdbMixed.Text = "Ambos";
            this.rdbMixed.UseVisualStyleBackColor = true;
            // 
            // rdbRecent
            // 
            this.rdbRecent.AutoSize = true;
            this.rdbRecent.Location = new System.Drawing.Point(6, 56);
            this.rdbRecent.Name = "rdbRecent";
            this.rdbRecent.Size = new System.Drawing.Size(68, 17);
            this.rdbRecent.TabIndex = 0;
            this.rdbRecent.TabStop = true;
            this.rdbRecent.Text = "Reciente";
            this.rdbRecent.UseVisualStyleBackColor = true;
            // 
            // rdbPopular
            // 
            this.rdbPopular.AutoSize = true;
            this.rdbPopular.Location = new System.Drawing.Point(6, 33);
            this.rdbPopular.Name = "rdbPopular";
            this.rdbPopular.Size = new System.Drawing.Size(61, 17);
            this.rdbPopular.TabIndex = 0;
            this.rdbPopular.TabStop = true;
            this.rdbPopular.Text = "Popular";
            this.rdbPopular.UseVisualStyleBackColor = true;
            // 
            // gbxSearchTypes
            // 
            this.gbxSearchTypes.Controls.Add(this.rdbMixed);
            this.gbxSearchTypes.Controls.Add(this.rdbRecent);
            this.gbxSearchTypes.Controls.Add(this.rdbPopular);
            this.gbxSearchTypes.Location = new System.Drawing.Point(54, 172);
            this.gbxSearchTypes.Name = "gbxSearchTypes";
            this.gbxSearchTypes.Size = new System.Drawing.Size(149, 111);
            this.gbxSearchTypes.TabIndex = 7;
            this.gbxSearchTypes.TabStop = false;
            this.gbxSearchTypes.Text = "Tipo de busqueda";
            // 
            // gbxLanguages
            // 
            this.gbxLanguages.Controls.Add(this.rdbEnglish);
            this.gbxLanguages.Controls.Add(this.rdbSpanish);
            this.gbxLanguages.Location = new System.Drawing.Point(255, 172);
            this.gbxLanguages.Name = "gbxLanguages";
            this.gbxLanguages.Size = new System.Drawing.Size(170, 111);
            this.gbxLanguages.TabIndex = 8;
            this.gbxLanguages.TabStop = false;
            this.gbxLanguages.Text = "Lenguajes";
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.AutoSize = true;
            this.rdbEnglish.Location = new System.Drawing.Point(6, 79);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rdbEnglish.TabIndex = 1;
            this.rdbEnglish.TabStop = true;
            this.rdbEnglish.Text = "English";
            this.rdbEnglish.UseVisualStyleBackColor = true;
            // 
            // rdbSpanish
            // 
            this.rdbSpanish.AutoSize = true;
            this.rdbSpanish.Location = new System.Drawing.Point(6, 33);
            this.rdbSpanish.Name = "rdbSpanish";
            this.rdbSpanish.Size = new System.Drawing.Size(63, 17);
            this.rdbSpanish.TabIndex = 0;
            this.rdbSpanish.TabStop = true;
            this.rdbSpanish.Text = "Español";
            this.rdbSpanish.UseVisualStyleBackColor = true;
            // 
            // gbxSinceDate
            // 
            this.gbxSinceDate.Controls.Add(this.dtpSinceDate);
            this.gbxSinceDate.Location = new System.Drawing.Point(48, 344);
            this.gbxSinceDate.Name = "gbxSinceDate";
            this.gbxSinceDate.Size = new System.Drawing.Size(377, 53);
            this.gbxSinceDate.TabIndex = 9;
            this.gbxSinceDate.TabStop = false;
            this.gbxSinceDate.Text = "Fecha inicial";
            // 
            // dtpSinceDate
            // 
            this.dtpSinceDate.Location = new System.Drawing.Point(6, 19);
            this.dtpSinceDate.Name = "dtpSinceDate";
            this.dtpSinceDate.Size = new System.Drawing.Size(365, 20);
            this.dtpSinceDate.TabIndex = 0;
            this.dtpSinceDate.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // gbxUntilDate
            // 
            this.gbxUntilDate.Controls.Add(this.dtpUntilDate);
            this.gbxUntilDate.Location = new System.Drawing.Point(48, 403);
            this.gbxUntilDate.Name = "gbxUntilDate";
            this.gbxUntilDate.Size = new System.Drawing.Size(377, 44);
            this.gbxUntilDate.TabIndex = 9;
            this.gbxUntilDate.TabStop = false;
            this.gbxUntilDate.Text = "Fecha final";
            // 
            // dtpUntilDate
            // 
            this.dtpUntilDate.Location = new System.Drawing.Point(6, 18);
            this.dtpUntilDate.Name = "dtpUntilDate";
            this.dtpUntilDate.Size = new System.Drawing.Size(365, 20);
            this.dtpUntilDate.TabIndex = 0;
            this.dtpUntilDate.Value = new System.DateTime(2018, 3, 19, 0, 0, 0, 0);
            // 
            // lblTotalPublications
            // 
            this.lblTotalPublications.AutoSize = true;
            this.lblTotalPublications.Location = new System.Drawing.Point(87, 464);
            this.lblTotalPublications.Name = "lblTotalPublications";
            this.lblTotalPublications.Size = new System.Drawing.Size(161, 13);
            this.lblTotalPublications.TabIndex = 10;
            this.lblTotalPublications.Text = "Total de publicaciones  a buscar";
            this.lblTotalPublications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmudTotalPublications
            // 
            this.nmudTotalPublications.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmudTotalPublications.Location = new System.Drawing.Point(272, 462);
            this.nmudTotalPublications.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmudTotalPublications.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudTotalPublications.Name = "nmudTotalPublications";
            this.nmudTotalPublications.Size = new System.Drawing.Size(120, 20);
            this.nmudTotalPublications.TabIndex = 11;
            this.nmudTotalPublications.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmudTotalPublications.ThousandsSeparator = true;
            this.nmudTotalPublications.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // QueryConfigurationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nmudTotalPublications);
            this.Controls.Add(this.lblTotalPublications);
            this.Controls.Add(this.gbxUntilDate);
            this.Controls.Add(this.gbxSinceDate);
            this.Controls.Add(this.gbxLanguages);
            this.Controls.Add(this.gbxSearchTypes);
            this.Controls.Add(this.gbxFilter);
            this.Controls.Add(this.gbxLocation);
            this.Controls.Add(this.gbxKeywords);
            this.Name = "QueryConfigurationControl";
            this.Size = new System.Drawing.Size(462, 507);
            this.gbxKeywords.ResumeLayout(false);
            this.gbxLocation.ResumeLayout(false);
            this.gbxLocation.PerformLayout();
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.gbxSearchTypes.ResumeLayout(false);
            this.gbxSearchTypes.PerformLayout();
            this.gbxLanguages.ResumeLayout(false);
            this.gbxLanguages.PerformLayout();
            this.gbxSinceDate.ResumeLayout(false);
            this.gbxUntilDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmudTotalPublications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxKeywords;
        private System.Windows.Forms.Button btnAddKeyword;
        private System.Windows.Forms.Button btnRemoveKeyword;
        private System.Windows.Forms.GroupBox gbxKeywords;
        private System.Windows.Forms.GroupBox gbxLocation;
        private System.Windows.Forms.RadioButton rdbUsa;
        private System.Windows.Forms.RadioButton rdbColombia;
        private System.Windows.Forms.GroupBox gbxFilter;
        private System.Windows.Forms.RadioButton rdbMixed;
        private System.Windows.Forms.RadioButton rdbRecent;
        private System.Windows.Forms.RadioButton rdbPopular;
        private System.Windows.Forms.GroupBox gbxSearchTypes;
        private System.Windows.Forms.GroupBox gbxLanguages;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.RadioButton rdbSpanish;
        private System.Windows.Forms.RadioButton rdbVideo;
        private System.Windows.Forms.RadioButton rdbNews;
        private System.Windows.Forms.RadioButton rdbImage;
        private System.Windows.Forms.RadioButton rdbHashtag;
        private System.Windows.Forms.GroupBox gbxSinceDate;
        private System.Windows.Forms.DateTimePicker dtpSinceDate;
        private System.Windows.Forms.GroupBox gbxUntilDate;
        private System.Windows.Forms.DateTimePicker dtpUntilDate;
        private System.Windows.Forms.Label lblTotalPublications;
        private System.Windows.Forms.NumericUpDown nmudTotalPublications;
        private SocialNetworkConnection.IQueryConfiguration queryConfiguration;
    }
}