using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
      
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() { new Proyecto
            {
                Titulo="Amazon",
                Descripcion= "E-commerce realizado con ASP.NET Core",
                Link="https://amazon.com",
                ImagenUrl="/Imagenes/amazon.png"
            },
             new Proyecto
            {
                Titulo="New york times",
                Descripcion= "Pagina de noticias en React",
                Link="https://amazon.com",
                ImagenUrl="/Imagenes/nyt.png"
            },
              new Proyecto
            {
                Titulo="Reddit",
                Descripcion= "Red social para ",
                Link="https://amazon.com",
                ImagenUrl="/Imagenes/reddit.png"
            },
               new Proyecto
            {
                Titulo="Amazon",
                Descripcion= "E-commerce realizado con ASP.NET Core",
                Link="https://amazon.com",
                ImagenUrl="/Imagenes/steam.png"
            },
            };
        }
    }
}
