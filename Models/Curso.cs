
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace CursosApi.Models
{
    public class Curso
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Nome")]
        public string CursoNome { get; set; }

        public string Ementa { get; set; }

        public int Duracao { get; set; }

        public decimal Valor { get; set; }

        public string Inicio { get; set; }

    }
}
