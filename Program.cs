using dot_net_study.Services;
using Microsoft.Extensions.Configuration;



while (true)
{
    try
    {
        Console.Write("Insira um número: \n 1 - Calculadora \n 2 - Consulta \n 3 - Compras \n 4 - Compare \n");
        int option = Convert.ToInt32(Console.ReadLine());
        Calcutator calculator = new ();
        Consulta consulta = new();
        Buy buy = new();
        Compare compare = new();

        switch (option){
            case 1:
                calculator.View();
                break;
            case 2:
                consulta.View();
                break;
            case 3:
                buy.View();
                break;
            case 4:
                compare.View();
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro durante a execução: {message}", ex.Message);
    }
}
