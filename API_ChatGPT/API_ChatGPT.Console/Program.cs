using API_ChatGPT.ClassLib;

var api = new API_Service();
Console.WriteLine(await api.RequestResult("faça uma questão de português sobre conjugação verbal no presente do indicativo. A  questão precisa ter o enunciado e 5 opções, ao final quero o gabarito."));