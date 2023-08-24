using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsletterDal;

        public NewsLetterManager(INewsLetterDal newsleterDal)
        {
            _newsletterDal = newsleterDal;
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsletterDal.Insert(newsLetter);
        }
    }
}