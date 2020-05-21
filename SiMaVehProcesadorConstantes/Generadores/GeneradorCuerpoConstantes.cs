﻿using System.Collections.Generic;
using System.Text;

namespace SiMaVehProcesadorConstantes.Generadores
{
    public class GeneradorCuerpoConstantes
    {
        public string Generar(List<InfoLinea> infoLineas)
        {
            var sbConstantes = new StringBuilder();
            var indent = string.Empty.PadLeft(8);

            foreach (var linea in infoLineas)
            {
                sbConstantes.AppendLine(string.Concat(indent, "/// <summary>"));
                sbConstantes.AppendLine(string.Concat(indent, $"/// {linea.NombreOriginal}"));
                sbConstantes.AppendLine(string.Concat(indent, "/// </summary>"));
                sbConstantes.AppendLine(string.Concat(indent, $"public const string {linea.NombreConstante} = \"{linea.NombreOriginal}\";"));
                sbConstantes.AppendLine(string.Empty);
            }

            return sbConstantes.ToString().TrimEnd();
        }
    }
}
