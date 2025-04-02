using mystore.Models;

namespace mystore.Repository
{
    public interface IStudent
    {
        List<Student> student();
        List<Student> getById(int id);
    }
}
