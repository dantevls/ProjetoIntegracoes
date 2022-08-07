// See https://aka.ms/new-console-template for more information
using static System.Decimal;
using static System.String;


//Console.WriteLine(Justify("loreaabccde\nsafdasdffsdasfaasdfasdfasdfasdfasdfsadf\nasdasdas", 30));
Console.WriteLine(Justify("123  45\n6", 7));

string Justify(string str, int len)
{
 var contadorPalavras = str.Replace("\n", " ");
 var arrayContador = contadorPalavras.ToCharArray();
 var frases = FormadorFrase(arrayContador, len);

 return frases;
}

string FormadorFrase(char[] array, int limite)
{
 var fraseFormada = Empty;

 for (int i = 0; i <= array.Length - 1; i++)
 {
  fraseFormada = Concat(fraseFormada, array[i]);
  
  if (limite - 1 % fraseFormada.Length == Zero)
   fraseFormada = Concat(fraseFormada + " \r\n");
 }
 return fraseFormada.Replace("  ", " ");
}
