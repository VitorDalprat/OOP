using OOP.ContentContext;
using OOP.Subscription;

//Adicionando Artigos
var articles = new List<Article>();
articles.Add(new Article("Artigo Sobre OOP", "Orientação Objetos"));
articles.Add(new Article("Artigo Sobre C#", "C#"));
articles.Add(new Article("Artigo Sobre BancoDeDados", "SQLServer"));


//Listando Artigos na Tela
foreach (var article in articles)
{
    Console.WriteLine(article.Id);
   Console.WriteLine("--------------------------------------------------");
   Console.WriteLine(article.Title);
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine(article.Url);
    Console.WriteLine("--------------------------------------------------");
}

//Cursos Adicionados
var curse = new List<Curse>();
var curseOOP = new Curse("Aprendendo OOP", "OOP Fundamentos");
var curseNET = new Curse("Aprendendo .NET", ".NET Funcionalidades");
curse.Add(curseOOP);
curse.Add(curseNET);

//Carreiras e Itens Adicionados
var carrers = new List<Carrer>();
var carrerEnzo = new Carrer("Balta.IO", "Fundamentos C#");
var carrerItem = new CarrerItem(1, "Aprenda OOP", "",curseOOP );
var carrerItem1 = new CarrerItem(2, "Aprenda .NET", "", null);
carrers.Add(carrerEnzo);
carrerEnzo.Item.Add(carrerItem1);
carrerEnzo.Item.Add(carrerItem);

//Listagens de Carreiras e Itens na Tela
foreach (var carrerCont in carrers)
{
    Console.WriteLine(carrerCont.Title);
    Console.WriteLine(carrerCont.Url);

    foreach (var item in carrerCont.Item.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Curse?.Title);
        Console.WriteLine(item.Curse?.Url);

        //Caso curso seja nulo
        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }

    var paypalsubscription = new PaypalSubscription();
    var pagarmesubscription = new PagarmeSubscription();
    var student = new Student();
    var subscriptions = new List<Subscription>();
    student.CreateSubscription(paypalsubscription);
    student.CreateSubscription(pagarmesubscription);



}
