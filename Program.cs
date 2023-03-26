//  Exiba a palavra como se fosse soletrada.

String Palavra;
String PalavraSoletrada;

Console.WriteLine("----Soletrar----\n");

Console.Write("Digite uma palavra:");
Palavra = Console.ReadLine()!;

var caracteres = Palavra.ToCharArray();
PalavraSoletrada = String.Join('-', caracteres).ToUpper();

Console.WriteLine($"\nSoletrando \"{Palavra.ToUpper()}\": {PalavraSoletrada}");
