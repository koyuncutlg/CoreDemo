using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinessLayer.Concrete
{
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;
		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}
		public void WriterAdd(Writer writer)
		{
			_writerDal.Insert(writer);
		}
	}
}