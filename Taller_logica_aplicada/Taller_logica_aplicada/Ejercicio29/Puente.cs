namespace Taller_logica_aplicada.Ejercicio29
{
    public class Puente
    {
        public string Estructura { 
            get; private set; 
        }

        public Puente(string estructura)
        {
            Estructura = estructura.Trim();
        }

        public bool EsValido()
        {
            if (string.IsNullOrEmpty(Estructura)) return false;

            if (!Estructura.StartsWith("*") || !Estructura.EndsWith("*")) return false;
            if (Estructura.Count(c => c == '*') != 2) return false;

            string reverso = new([.. Estructura.Reverse()]);
            if (Estructura != reverso) return false;

            string[] grupos = Estructura.Split(new char[] { '*', '+' }, StringSplitOptions.RemoveEmptyEntries);
            int contadorGruposDeTres = 0;

            foreach (string grupo in grupos)
            {
                if (grupo.Any(c => c != '=')) return false;
                if (grupo.Length > 3) return false;
                if (grupo.Length == 3) contadorGruposDeTres++;
            }

            if (contadorGruposDeTres > 1) return false;

            return true;
        }
    }
}