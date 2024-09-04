﻿namespace PARCIAL1.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    }
}
