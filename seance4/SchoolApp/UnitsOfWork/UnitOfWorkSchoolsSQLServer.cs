using School.Repository;
using SchoolApp.Models;
using SchoolApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.UnitsOfWork
{
    internal class UnitOfWorkSchoolsSQLServer : IUnitOfWorkSchool
    {
        private readonly SchoolContext _context;

        private StudentRepositorySQLServer _studentRepository;

        private BaseRepositorySQL<Section> _sectionsRepository;


        public UnitOfWorkSchoolsSQLServer(SchoolContext context)
        {
            this._context = context;
            this._studentRepository = new StudentRepositorySQLServer(context);
            this._sectionsRepository = new BaseRepositorySQL<Section>(context);

        }
        public IStudentRepository StudentsRepository
        {
            get { return this._studentRepository; }
        }

        public IRepository<Section> SectionsRepository
        {
            get { return this._sectionsRepository; }
        }
    }
}

