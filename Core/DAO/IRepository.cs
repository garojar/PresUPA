using System.Collections.Generic;
using Core.Models;

namespace Core.DAO
{
    /// <summary>
    /// Patron Repository para reemplazar a DAO (mas simple).
    /// https://martinfowler.com/eaaCatalog/repository.html
    /// </summary>
    /// <typeparam name="T">Clase generica que implemente la interface IModel</typeparam>
    public interface IRepository<T> where T : IModel
    {
        /// <summary>
        /// Inicializa el repositorio para guardar las entidades. Ej. crear la tabla SQL.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Guarda una entidad en el repositorio.
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Obtiene todas las entidades en el sistema.
        /// </summary>
        /// <returns>the List of T</returns>
        IList<T> GetAll();
    }
}