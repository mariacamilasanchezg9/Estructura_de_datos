namespace Taller_logica_aplicada.Ejercicio36
{
    public class Tablero
    {
        private char[,] _casillas = new char[8, 8];

        public Tablero()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    _casillas[i, j] = ' ';
        }

        public void SembrarFruto(string ubicacion)
        {
            ubicacion = ubicacion.Trim();
            if (ubicacion.Length >= 3)
            {
                int x = ubicacion[0] - 'A';
                int y = ubicacion[1] - '1';
                char fruto = ubicacion[2];
                _casillas[x, y] = fruto;
            }
        }

        public char Cosechar(int x, int y)
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                char fruto = _casillas[x, y];
                _casillas[x, y] = ' ';
                return fruto;
            }
            return ' ';
        }
    }
}