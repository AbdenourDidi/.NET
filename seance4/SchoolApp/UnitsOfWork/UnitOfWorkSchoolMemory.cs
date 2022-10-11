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
    internal class UnitOfWorkSchoolMemory : IUnitOfWorkSchool
    {
        private StudentRepositoryMemory _studentRepository;
        
        private SectionRepositoryMemory _sectionRepository;

        public UnitOfWorkSchoolMemory()
        {
            this._studentRepository = new StudentRepositoryMemory();

            this._sectionRepository = new SectionRepositoryMemory();
        }

        public IRepository<Section> SectionsRepository
        {
            get { return this._sectionRepository; }
        }

        public IStudentRepository StudentsRepository
        {
            get { return this._studentRepository; }
        }
    }

}
