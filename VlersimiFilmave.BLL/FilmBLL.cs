using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VlersimiFilmave.DAL;
using VlersimiFilmave.BOL;

namespace VlersimiFilmave.BLL
{
    public class FilmBLL
    {
        private readonly FilmDAL _filmDal;

        public FilmBLL()
        {
            _filmDal = new FilmDAL();
        }

        public List<Film> GetAllFilms()
        {
            return _filmDal.GetAllFilms();
        }

        public List<Film> SearchFilms(string titulli = null, string regjisori = null, string zhanri = null, int? vlersimi = null)
        {
            // Add business rule: Ensure rating is between 1 and 5
            if (vlersimi.HasValue && (vlersimi < 1 || vlersimi > 5))
                throw new ArgumentException("Rating must be between 1 and 5.");
            return _filmDal.SearchFilms(titulli, regjisori, zhanri, vlersimi);
        }

        public int AddFilm(Film film)
        {
            // Business rule: Title is required
            if (string.IsNullOrEmpty(film.Titulli))
                throw new ArgumentException("Title is required.");
            return _filmDal.AddFilm(film);
        }
    }
}