using ApiAWSConciertos.Data;
using ApiAWSConciertos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAWSConciertos.Repository
{
    public class RepositoryConcierto
    {
        private ConciertosContext context;
        public RepositoryConcierto(ConciertosContext context)
        {
            this.context = context;
        }
        public async Task<List<CategoriaEvento>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        } 
        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        } 
        public async Task<List<Evento>> GetEventosCategoriaAsync(int idcategoria)
        {
            List<Evento> eventos = await GetEventosAsync();
            List<Evento> misEventos = new List<Evento>();
            foreach(Evento e in eventos)
            {
                if(e.IdCategoria== idcategoria)
                {
                    misEventos.Add(e);
                }
            }
            return misEventos;
        }
        private async Task<int> GetMaxIdEventoAsync()
        {
            return await this.context.Eventos.MaxAsync(x => x.IdEvento) + 1;
        }
        public async Task InsertarEvento(string nombre,string artista,int idcategoria,string imagen)
        {
            Evento evento = new Evento
            {
                IdEvento = await GetMaxIdEventoAsync(),
                Nombre = nombre,
                Artista = artista,
                IdCategoria = idcategoria,
                Imagen = imagen
            };
            this.context.Eventos.Add(evento);
            await this.context.SaveChangesAsync();
        }
    }
}
