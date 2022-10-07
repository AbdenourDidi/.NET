using School.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Repository
{
    public class Student : IRepository<Student>
    {
        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Student entity)
        {
            throw new NotImplementedException();
        }

        public bool Save(Student entity, Expression<Func<Student, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Student> SearchFor(Expression<Func<Student, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}

