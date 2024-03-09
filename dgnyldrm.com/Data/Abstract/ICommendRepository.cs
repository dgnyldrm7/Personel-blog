using dgnyldrm.com.Entity;


namespace dgnyldrm.com.Data.Abstract
{
    public interface ICommendRepository
    {

        IQueryable<Comments> _yorumlar {  get; }  // set ile çekmeye gerek yok
        void CreateComment (Comments comment);
    }
}
