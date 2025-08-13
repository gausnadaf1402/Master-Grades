using MstGrades.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MstGrades.Repositories
{
    public interface IGradeRepository
    {
        DataTable GetAll();
        void AddGrade(Grade grade);

        void UpdateGrade(Grade grade);

        void DeleteGrade(int gradeID);
    }
}
