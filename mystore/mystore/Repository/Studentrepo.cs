using mystore.Models;

namespace mystore.Repository
{
    public class StudentRepo : IStudent
    {
        public List<Student> getById(int id)
        {
            return datasource().Where(x => x.rollno == id).ToList();

        }

        public List<Student> student()
        {
            return datasource();
        }
        private List<Student> datasource()
        {
            return new List<Student>{
                new Student { rollno = 1, Name = "this is from repo", subject = "science" },
                new Student { rollno = 1, Name = "this is from repo", subject = "maths" },
                new Student { rollno = 13, Name = "dj2fdg3s", subject = "English" }
            };
        }

    }
}
