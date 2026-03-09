namespace Taller_logica_aplicada.Ejercicio36
{
    public class Caballo
    {
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public string FrutosRecogidos { get; private set; } = "";

        private Tablero _tablero;

        public Caballo(string posicionInicial, Tablero tablero)
        {
            posicionInicial = posicionInicial.Trim();
            PosX = posicionInicial[0] - 'A';
            PosY = posicionInicial[1] - '1';
            _tablero = tablero;
        }

        public void Mover(string movimiento)
        {
            switch (movimiento.ToUpper())
            {
                case "UL": PosX -= 1; PosY += 2; break;
                case "UR": PosX += 1; PosY += 2; break;
                case "LU": PosX -= 2; PosY += 1; break;
                case "LD": PosX -= 2; PosY -= 1; break;
                case "RU": PosX += 2; PosY += 1; break;
                case "RD": PosX += 2; PosY -= 1; break;
                case "DL": PosX -= 1; PosY -= 2; break;
                case "DR": PosX += 1; PosY -= 2; break;
            }

            char fruto = _tablero.Cosechar(PosX, PosY);
            FrutosRecogidos += fruto;
        }
    }
}