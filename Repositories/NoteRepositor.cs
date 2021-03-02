using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebowaAplikacja.Models;

namespace WebowaAplikacja.Repositories
{

    public class NoteRepositor : INoteRepository
    {
        private readonly NoteManagerContext _context;
        public NoteRepositor(NoteManagerContext context)
        {
            _context = context;
        }
        public ClassWebApp Get(int noteId)
        => _context.Notes.SingleOrDefault(x => x.NoteId == noteId);

        public IQueryable<ClassWebApp> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public void Add(ClassWebApp note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges(); 
        }
        public void Update(int noteId, ClassWebApp note)
        {
            var result = _context.Notes.SingleOrDefault(x => x.NoteId == noteId);
            if (result != null)
            {
                result.Name = note.Name;
                result.Tresc = note.Tresc;
                _context.SaveChanges();
            }
        }
        public void Delete(int noteId)
        {
            var result = _context.Notes.SingleOrDefault(x => x.NoteId == noteId);
            if (result != null)
            {
                _context.Notes.Remove(result);
                _context.SaveChanges();
            }
            _context.SaveChanges();
        }
    }
}