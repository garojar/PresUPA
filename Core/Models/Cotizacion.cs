using System;
using System.Collections.Generic;

namespace Core.Models
{
    /// <summary>
    /// Clase que representa una Cotizacion en el sistema
    /// junto a sus servicios
    /// </summary>
    public class Cotizacion : BaseEntity
    {
        
        /// <summary>
        /// version del documento
        /// </summary>
        public string Version { get; set; }
        
        /// <summary>
        /// Titulo del documento
        /// </summary>
        public string Titulo { get; set; }
        
        /// <summary>
        /// Descripcion breve del contexto de la cotizacion
        /// </summary>
        public string Descripcion { get; set; }
        
        /// <summary>
        /// Estado en el cual se encuentra la cotizacion
        /// </summary>
        public estadoCotizacion Estado;
        
        /// <summary>
        /// Costo total del la cotizacion
        /// </summary>
        public int CostoTotal { get; set; }
        
        /// <summary>
        /// Ultima fecha de actualizacion de la cotizacion
        /// </summary>
        public DateTime DateTime { get; set; }
        
        
        /// <inheritdoc cref="BaseEntity.Validate"/>
        public override void Validate()
        {
            if (String.IsNullOrEmpty(Version))
            {
                throw new ModelException("Version no puede ser null");
            }
            
            if (String.IsNullOrEmpty(Titulo))
            {
                throw new ModelException("Titulo no puede ser null");
            }

            if (String.IsNullOrEmpty(Descripcion))
            {
                throw new ModelException("Descripcion no puede ser null o exceder ... caracteres");
            }

            if (String.IsNullOrEmpty(Estado.ToString()))
            {
                throw new ModelException("Estado no puede ser null");
            }
        }
    }
    
    public enum estadoCotizacion
    {
        TERMINADA,
        RECHAZADA,
        APROBADA,
        ENVIADA,
        BORRADOR
    };
    


}