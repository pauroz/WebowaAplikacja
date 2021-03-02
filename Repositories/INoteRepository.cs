using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebowaAplikacja.Models;

namespace WebowaAplikacja.Repositories
{
    interface INoteRepository
    {
        ClassWebApp Get(int noteId);
        IQueryable<ClassWebApp> GetAllActive();
        void Add(ClassWebApp note);
        void Update(int noteId, ClassWebApp note);
        void Delete(int noteId);
    }
}
