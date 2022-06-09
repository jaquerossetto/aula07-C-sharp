// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

string converterRealParaDolar(double valorDaCompraEmReais)
{
    
    double valorDaCompraEmDolar = valorDaCompraEmReais / cotacaoDoDolarHoje;
    string mensagem = "";
    if (valorDaCompraEmDolar < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
    {
       mensagem = $"A compra mínima permitida é de ${VALOR_MINIMO_DE_COMPRA_EM_DOLAR}";

    } else if(valorDaCompraEmDolar > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
    {
        mensagem = $"A compra máxima permitida é de ${VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}";
    }else
    {
        mensagem = $"Você pode comprar ${Math.Round(valorDaCompraEmDolar,2)}";
    }

    return mensagem;
}

// Utilize as mensagens a seguir como base do retorno esperado:
// A compra mínima permitida é de $ XXX,XX.
// A compra máxima permitida é de $ XXXX,XX.
// Você pode comprar $ XXX,XX.
Console.WriteLine("Quanto deseja converter para dolares?");
double.TryParse(Console.ReadLine(),out double valorDaCompraEmReais);
Console.WriteLine(converterRealParaDolar(valorDaCompraEmReais));

