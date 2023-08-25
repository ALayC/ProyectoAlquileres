﻿using Obligatorio_LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_Aplicacion.InterfacesCasoUso
{
    public interface IBuscarPorNombre
    {
        IEnumerable<Cabana> Ejecutar(string nombre);
    }
}
