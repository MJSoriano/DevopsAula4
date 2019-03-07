using System;

namespace NumeralRomano
{
    public class NumeralRomanoConversor : INumeralRomanoConversor
    {
        public string InteiroParaRomano(int numero)
        {
             if ((numero < 0) || (numero > 3000))
                throw new Exception("Só é possível inserir um valor entre 0 e 3000");
        
            throw new Exception("Erro desconhecido");
        }
    }
}
