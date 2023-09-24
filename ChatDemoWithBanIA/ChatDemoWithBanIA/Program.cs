using OpenAI_API;

var openAi = new OpenAIAPI("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");

char opt = ' ';
string prom = "";
var conversation = openAi.Chat.CreateConversation();

conversation.AppendUserInput("soy una persona que procura tener un fondo de emergencia, mis ingresos provienen de un sueldo de profesionista asalariado, destino el 25 por ciento de mis ahorros a inversiones, el dinero que invierto proviene de mi sueldo y busco ganancias a 6 meses ¿como puedo utilizar la banca movil en banorte teniendo un perfil de inversionista conservador ?  de una manera resumida, muy corta y facil de entender \n");
var respose = await conversation.GetResponseFromChatbotAsync();
Console.WriteLine(respose); 

while (true)
{
    Console.WriteLine("\n escriba un prompt");
    prom = Console.ReadLine();

    conversation = openAi.Chat.CreateConversation();

    conversation.AppendUserInput(prom + " en terminos simples y aplicados en banorte ");
    respose = await conversation.GetResponseFromChatbotAsync();
    Console.WriteLine(respose + "\n sugerencias..." + sugerencias());
}

static string sugerencias()
{
    var rand = new Random();
    int caso = rand.Next(6);
    string res = "";

    switch (caso)
    {
        case 0:
            res = "\nque fonde de banorte invertir y porque ?";
            break;
        case 1:
            res = "\nque fondos podrian convenirme más y porque ? dependiendo de mis metas y mi estilo de vida";
            break;
        case 2:
            res = "\nelaborar un caso ficticio en el que tenga que invertir y que es lo que podria pasar con sus respectivas ventajas y desventajas";
            break;
        case 3:
            res = "\nbrindar un diccionario sobre los terminos utilizados dentro de los fondos de inversión";
            break;
        case 4:
            res = "\nerrores comunes al no saber manejar tu fondo de inversión";
            break;
        default:
            res = " ";
            break;
    }

    return res;

    }



