using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tarea3_veterinaria.Models
{
    public class Mascota
    {
        public int id { get; set; }
        public string? nombre { get; set; }
        public int? edad { get; set; }
        public string? especie { get; set; }
    }
}