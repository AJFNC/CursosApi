using CursosApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;


namespace CursosApi.Services
{
    public class CursoService
    {
        private readonly IMongoCollection<Curso> _cursos;

        public CursoService(ICursostoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cursos = database.GetCollection<Curso>(settings.CursosCollectionName);
        }

        public List<Curso> Get() =>
            _cursos.Find(curso => true).ToList();

        public Curso Get(string id) =>
            _cursos.Find<Curso>(curso => curso.Id == id).FirstOrDefault();

        public Curso Create(Curso curso)
        {
            _cursos.InsertOne(curso);
            return curso;
        }

        public void Update(string id, Curso cursoIn) =>
            _cursos.ReplaceOne(curso => curso.Id == id, cursoIn);

        public void Remove(Curso cursoIn) =>
            _cursos.DeleteOne(curso => curso.Id == cursoIn.Id);

        public void Remove(string id) =>
            _cursos.DeleteOne(curso => curso.Id == id);
    }
}
