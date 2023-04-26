
namespace exercicio_25._04
{
    public class Celular
    {
        //propriedades 

        public string cor;

        public string modelo;

        public string tamanho;

        public bool ligado;

        //métodos

        public void Ligar()
        {
            if(ligado == false)
            {
                Console.WriteLine($"O celular esta ligando !");
                
            }
        }

        public void Deslisgar()
        {
            if(ligado)
            {
                Console.WriteLine($"O celular esta desligando");
                
            }
        }

        public void FazerLigacao()
        {
            if(ligado)
            {
                Console.WriteLine($"O celular esta fazendo uma ligação !");
                
            }
            else
            {
                Console.WriteLine($"Não é possível pois o celular esta desligado ! ");
                
            }
        }

        public void EnviarMensagem()
        {
            if(ligado)
            {
                Console.WriteLine($"O celular esta enviando uma mensagem !");
                
            }
            else
            {
                Console.WriteLine($"Não é possível pois o celular esta desligado !");
                
            }
        }
    }
}