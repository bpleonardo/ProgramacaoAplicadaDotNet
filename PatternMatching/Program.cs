namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciação dos objetos
            Desenvolvedor dev = new Desenvolvedor("Ana Luiza", 23, "C#", 3);
            Gerente ger = new Gerente("Arthur", 35, 10);
            Estagiario est = new Estagiario("Caio", 18, 22);

            VerificarFuncionario(dev);

        }

        // O objetivo desta função é identificar se o objeto passado como parâmetro
        // é do tipo Desenvolvedor. Nesta função, utilizamos casting para converter
        // o objeto para o tipo desejado.
        static void VerificarDesenvolvedor(object obj)
        {
            if (obj is Desenvolvedor)
            {
                // Aqui está sendo realizado um casting, pois obj é do tipo object.
                // Portanto, é necessário convertê-lo para o tipo desejado.
                Desenvolvedor dev = (Desenvolvedor)obj;
                Console.WriteLine("O objeto é do tipo Desenvolvedor.");
                Console.WriteLine("Dados do Desenvolvedor(a):");
                Console.WriteLine($"Nome: {dev.Nome}");
                Console.WriteLine($"Idade: {dev.Idade}");
                Console.WriteLine($"Linguagem: {dev.Linguagem}");
                Console.WriteLine($"ANos de Experiência: {dev.AnosExperiencia}");

            }
            else
            {
                Console.WriteLine("O objeto não é do tipo Desenvolvedor");
            }
        }

        // Esta função executa o mesmo código da função anterior, porém não é necessário
        // realizar o casting, pois utilizamos Pattern Matching para verificar e obter o tipo do objeto.
        static void VerificarDesenvolvedorPm(object obj)
        {
            //Aqui já é verificado e criado o objeto (dev) para acessarmos as propriedades
            if (obj is Desenvolvedor dev)
            {
                Console.WriteLine("O objeto é do tipo Desenvolvedor.");
                Console.WriteLine("Dados do Desenvolvedor(a):");
                Console.WriteLine($"Nome: {dev.Nome}");
                Console.WriteLine($"Idade: {dev.Idade}");
                Console.WriteLine($"Linguagem: {dev.Linguagem}");
                Console.WriteLine($"ANos de Experiência: {dev.AnosExperiencia}");

            }
            else
            {
                Console.WriteLine("O objeto não é do tipo Desenvolvedor");
            }
        }

        static void VerificarFuncionario(object obj)
        {
            switch (obj)
            {
                //Aqui já é verificado e criado o objeto (dev) para acessarmos as propriedades
                case Desenvolvedor dev:
                    Console.WriteLine($"{dev.Nome} é Desenvolvedor(a)");
                    Console.WriteLine($"Linguagem: {dev.Linguagem}");
                    Console.WriteLine($"Anos de Expreriência: {dev.AnosExperiencia}");
                    break;

                case Gerente ger:
                    Console.WriteLine($"{ger.Nome} é Gerente");
                    Console.WriteLine($"Tamanho da Equipe: {ger.TamanhoEquipe}");
                    break;

                case Estagiario est:
                    Console.WriteLine($"{est.Nome} é Estagiário(a)");
                    Console.WriteLine($"Horas Semanais: {est.HorasSemanais}");
                    break;
                default:
                    Console.WriteLine("Objeto não reconhecido");
                    break;
            }
        }

    }
}
