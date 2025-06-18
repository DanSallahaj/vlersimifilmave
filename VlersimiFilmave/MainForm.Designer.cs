namespace VlersimiFilmave.Presentation
{
    partial class MainForm
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
            lblTitle = new MetroSet_UI.Controls.MetroSetTile();
            lvFilms = new ListView();
            ID = new ColumnHeader();
            Titulli = new ColumnHeader();
            Regjisori = new ColumnHeader();
            Zhanri = new ColumnHeader();
            Vlersimi = new ColumnHeader();
            txtSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            btnSearch = new MetroSet_UI.Controls.MetroSetButton();
            btnAddFilm = new MetroSet_UI.Controls.MetroSetButton();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lblTitle.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            lblTitle.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lblTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.HoverBorderColor = Color.FromArgb(230, 230, 230);
            lblTitle.HoverColor = Color.FromArgb(65, 177, 225);
            lblTitle.HoverTextColor = Color.White;
            lblTitle.IsDerivedStyle = true;
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.NormalBorderColor = Color.FromArgb(65, 177, 225);
            lblTitle.NormalColor = Color.FromArgb(65, 177, 225);
            lblTitle.NormalTextColor = Color.White;
            lblTitle.PressBorderColor = Color.FromArgb(65, 177, 225);
            lblTitle.PressColor = Color.FromArgb(65, 177, 225);
            lblTitle.PressTextColor = Color.White;
            lblTitle.Size = new Size(130, 23);
            lblTitle.Style = MetroSet_UI.Enums.Style.Light;
            lblTitle.StyleManager = null;
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Film Management";
            lblTitle.ThemeAuthor = "Narwin";
            lblTitle.ThemeName = "MetroLite";
            lblTitle.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            // 
            // lvFilms
            // 
            lvFilms.Columns.AddRange(new ColumnHeader[] { ID, Titulli, Regjisori, Zhanri, Vlersimi });
            lvFilms.Location = new Point(10, 40);
            lvFilms.Name = "lvFilms";
            lvFilms.Size = new Size(621, 368);
            lvFilms.TabIndex = 1;
            lvFilms.UseCompatibleStateImageBehavior = false;
            lvFilms.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 50;
            // 
            // Titulli
            // 
            Titulli.Text = "Titulli";
            Titulli.Width = 200;
            // 
            // Regjisori
            // 
            Regjisori.Text = "Regjisori";
            Regjisori.Width = 150;
            // 
            // Zhanri
            // 
            Zhanri.Text = "Zhanri";
            Zhanri.Width = 150;
            // 
            // Vlersimi
            // 
            Vlersimi.Text = "Vlersimi";
            // 
            // txtSearch
            // 
            txtSearch.AutoCompleteCustomSource = null;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtSearch.BorderColor = Color.FromArgb(155, 155, 155);
            txtSearch.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtSearch.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtSearch.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverColor = Color.FromArgb(102, 102, 102);
            txtSearch.Image = null;
            txtSearch.IsDerivedStyle = true;
            txtSearch.Lines = null;
            txtSearch.Location = new Point(12, 414);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.ReadOnly = false;
            txtSearch.Size = new Size(300, 30);
            txtSearch.Style = MetroSet_UI.Enums.Style.Light;
            txtSearch.StyleManager = null;
            txtSearch.TabIndex = 2;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.ThemeAuthor = "Narwin";
            txtSearch.ThemeName = "MetroLite";
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.WatermarkText = "Enter title to search...";
            // 
            // btnSearch
            // 
            btnSearch.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnSearch.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnSearch.DisabledForeColor = Color.Gray;
            btnSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnSearch.HoverColor = Color.FromArgb(95, 207, 255);
            btnSearch.HoverTextColor = Color.White;
            btnSearch.IsDerivedStyle = true;
            btnSearch.Location = new Point(329, 415);
            btnSearch.Name = "btnSearch";
            btnSearch.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnSearch.NormalColor = Color.FromArgb(65, 177, 225);
            btnSearch.NormalTextColor = Color.White;
            btnSearch.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnSearch.PressColor = Color.FromArgb(35, 147, 195);
            btnSearch.PressTextColor = Color.White;
            btnSearch.Size = new Size(75, 23);
            btnSearch.Style = MetroSet_UI.Enums.Style.Light;
            btnSearch.StyleManager = null;
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.ThemeAuthor = "Narwin";
            btnSearch.ThemeName = "MetroLite";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddFilm
            // 
            btnAddFilm.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnAddFilm.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnAddFilm.DisabledForeColor = Color.Gray;
            btnAddFilm.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddFilm.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnAddFilm.HoverColor = Color.FromArgb(95, 207, 255);
            btnAddFilm.HoverTextColor = Color.White;
            btnAddFilm.IsDerivedStyle = true;
            btnAddFilm.Location = new Point(656, 173);
            btnAddFilm.Name = "btnAddFilm";
            btnAddFilm.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnAddFilm.NormalColor = Color.FromArgb(65, 177, 225);
            btnAddFilm.NormalTextColor = Color.White;
            btnAddFilm.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnAddFilm.PressColor = Color.FromArgb(35, 147, 195);
            btnAddFilm.PressTextColor = Color.White;
            btnAddFilm.Size = new Size(132, 81);
            btnAddFilm.Style = MetroSet_UI.Enums.Style.Light;
            btnAddFilm.StyleManager = null;
            btnAddFilm.TabIndex = 4;
            btnAddFilm.Text = "Add Film";
            btnAddFilm.ThemeAuthor = "Narwin";
            btnAddFilm.ThemeName = "MetroLite";
            btnAddFilm.Click += btnAddFilm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddFilm);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lvFilms);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTile lblTitle;
        private ListView lvFilms;
        private ColumnHeader ID;
        private ColumnHeader Titulli;
        private ColumnHeader Regjisori;
        private ColumnHeader Zhanri;
        private ColumnHeader Vlersimi;
        private MetroSet_UI.Controls.MetroSetTextBox txtSearch;
        private MetroSet_UI.Controls.MetroSetButton btnSearch;
        private MetroSet_UI.Controls.MetroSetButton btnAddFilm;
    }
}
