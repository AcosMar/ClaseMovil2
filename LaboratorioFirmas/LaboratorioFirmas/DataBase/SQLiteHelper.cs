using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using LaboratorioFirmas.Models;
using System.Threading.Tasks;

namespace LaboratorioFirmas.DataBase
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Persona>().Wait();
        }

        public Task<int> SavePersona(Persona person)
        {
            if (person.Idpersona != 0)
            {
                return db.UpdateAsync(person);
                ;
            }
            else
            {
                return db.InsertAsync(person);
            }
        }

        public Task<List<Persona>> GetPersonasAync()
        {
            return db.Table<Persona>().ToListAsync();
        }

        public Task<Persona> GetPersonaByIdAsync(String nomb)
        {
            return db.Table<Persona>().Where(a => a.nombre == nomb).FirstOrDefaultAsync();
        }

        public Task<int> DropPersonaAsync(Persona person)
        {
            return db.DeleteAsync(person);
        }
    }
}
