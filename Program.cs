using Calculator.Pages;
using Calculator.Operations;

//Console.WindowWidth = 70; // Largura da janela
//Console.WindowHeight = 25; // Altura da janela

int option;
do
{
    Pages.HomePageRender();

    if (int.TryParse(Console.ReadLine(), out option))
    {
        switch (option)
        {
            case 1:
                OperationServices.Addition(option);
                break;
            case 2:
                Pages.HeaderPageRender(option);
                break;
            case 3:
                Pages.HeaderPageRender(option);
                break;
            case 4:
                Pages.HeaderPageRender(option);
                break;
            default:
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid option!!.");
    }

}
while (option != 0);

Pages.ExitPageRender();
