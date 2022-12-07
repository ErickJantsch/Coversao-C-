using System;
using System.Globalization;

namespace Tarefa_conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            double SalrioMedio = 2261.00;
            double DevJrBr = 3242.00;
            double Diff = .433878814683768;
            double MediaPt = 1314.00;
            double DevJrPt = 1255;
            double DevseniorUK = 5017;
            double DevSeniorCan = 9000;
            double DevSeniorUS = 10900;



            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Salrio de um desenvolvedor ao redor do mundo\n" +
               "A media salerial do brasileiro atualmente gira em torno de " + SalrioMedio.ToString("C", CultureInfo.CurrentCulture) + " reais, comparando o sario da maior parte da populacao\n" +
               "com o salario inicial de um desenvolvedor junior ja conseguindo perceber um salto imprecionante. De acordo com o site\n" +
               "glassdoor um desenvolvedor junior inicia a carreira com um salario de " + DevJrBr.ToString("C", CultureInfo.CurrentCulture) + "\n" +
               "reai por mes geralmente acompanhado de divesos beneficios com planos de saude e gympass nas ofertas menos atrativas.\n" +
               "Isso representa uma diferenca de " + Diff.ToString("P", CultureInfo.CurrentCulture) + "a mais de media nacional no comparativo\n" +
               "Podemos fazer essa mesma comparancao com paoses europeus  como Portugal onde a renda media no pais gira em torno de " + MediaPt.ToString("C", CultureInfo.CreateSpecificCulture("")) + "\n" +
               "ja um desenvolvedor junior chegam proximo de " + DevJrPt.ToString("C", CultureInfo.CreateSpecificCulture("")) + "de acordo com site glessdoor.\n" +
               "Importante avaliar que esses sao etimativas para pessoas que estao iniciando agora na carreira.\n" +
               "Pessoas com mais tempo de experiencia conseguem patamares mais altos com por exemplo no\n" +
               "Reino Unido um desenvolvedor senior pode receber em media " + DevseniorUK.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")) + "Libras Esterlinas,\n" +
               "no Canada a partir de " + DevSeniorCan.ToString("C", CultureInfo.CreateSpecificCulture("en-CAD")) + " dolares canadenses e nos Estados Unidos " + DevSeniorUS.ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + " dolares.");

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------");

        }
    }
}
