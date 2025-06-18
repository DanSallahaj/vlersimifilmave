using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VlersimiFilmave.BOL;
using VlersimiFilmave.BLL;

namespace VlersimiFilmave.Presentation
{
    public partial class AddFilmForm : Form
    {
        private readonly FilmBLL _filmBll;

        public AddFilmForm()
        {
            InitializeComponent();
            _filmBll = new FilmBLL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var film = new Film
                {
                    Titulli = txtTitulli.Text,
                    Regjisori = string.IsNullOrEmpty(txtRegjisori.Text) ? null : txtRegjisori.Text,
                    Data_e_Publikimit = dtpData.Value,
                    Zhanri = string.IsNullOrEmpty(txtZhanri.Text) ? null : txtZhanri.Text,
                    Vlersimi = (int?)nudVlersimi.Value
                };

                int newFilmId = _filmBll.AddFilm(film);
                MessageBox.Show($"Film added successfully with ID: {newFilmId}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding film: {ex.Message}");
            }
        }
    }
}

