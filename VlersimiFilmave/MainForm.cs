using VlersimiFilmave.BLL;
using VlersimiFilmave.BOL;

namespace VlersimiFilmave.Presentation
{
    public partial class MainForm : Form
    {
        private readonly FilmBLL _filmBll;

        public MainForm()
        {
            InitializeComponent();
            _filmBll = new FilmBLL();
            LoadFilms();
        }

        private void LoadFilms()
        {
            lvFilms.Items.Clear();
            var films = _filmBll.GetAllFilms();
            foreach (var film in films)
            {
                var item = new ListViewItem(film.ID.ToString());
                item.SubItems.Add(film.Titulli ?? string.Empty);
                item.SubItems.Add(film.Regjisori ?? string.Empty);
                item.SubItems.Add(film.Zhanri ?? string.Empty);
                item.SubItems.Add(film.Vlersimi?.ToString() ?? string.Empty);
                lvFilms.Items.Add(item);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var films = _filmBll.SearchFilms(txtSearch.Text);
                lvFilms.Items.Clear();
                foreach (var film in films)
                {
                    var item = new ListViewItem(film.ID.ToString());
                    item.SubItems.Add(film.Titulli ?? string.Empty);
                    item.SubItems.Add(film.Regjisori ?? string.Empty);
                    item.SubItems.Add(film.Zhanri ?? string.Empty);
                    item.SubItems.Add(film.Vlersimi?.ToString() ?? string.Empty);
                    lvFilms.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddFilmForm())
            {
                addForm.ShowDialog();
                LoadFilms(); // Refresh the film list
            }
        }
    }
}
