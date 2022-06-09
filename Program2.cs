
string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    double IMC = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);
    string diagnostico = "";
   

    if(IMC < 18.5)
    {
        diagnostico = "Anemico";
    }else if(IMC >= 18.5 && IMC <= 24.9)
    {
        diagnostico = "Normal";
    }else if (IMC >= 25 && IMC <= 29.9)
    {
        diagnostico = "Sobrepeso";
    }else if (IMC >= 30 && IMC <= 40)
    {
        diagnostico = "Obeso";
    }
    else
    {
        diagnostico = "Obesidade grave";
    } 
    return diagnostico;
} 

    Console.WriteLine("Digite a altura do usuário:");
    double.TryParse(Console.ReadLine(), out double alturaDoUsuario);
    Console.WriteLine("Digite o peso do usuário:");
    double.TryParse(Console.ReadLine(), out double pesoDoUsuario);
    Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(alturaDoUsuario,pesoDoUsuario)}");
