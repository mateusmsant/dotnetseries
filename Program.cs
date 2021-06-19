using System;

namespace series
{
    class Program
    {

        static ShowRepository showRepository = new ShowRepository();
        static void Main(string[] args)
        {
            string userChoice = GetUserChoice();
            while (userChoice.ToUpper() != "X")
            {
                switch (userChoice)
                {
                    case "1":
                        ListShows();
                        break;
                    case "2":
                        PutShow();
                        break;
                    case "3":
                        UpdateShow();
                        break;
                    case "4":
                        DeleteShow();
                        break;
                    case "5":
                        ShowDetail();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userChoice = GetUserChoice();
            }
            Console.WriteLine("Obrigado por usar =)");
            Console.ReadLine();
       }

       private static void ListShows()
       {
           Console.WriteLine("Listando séries");
           var showList = showRepository.List();

           if (showList.Count == 0)
           {
               Console.WriteLine("Nenhuma série cadastrada");
               return;
           }
           foreach (var show in showList)
           {
               Console.WriteLine($"ID: {show.getId()} - Título: {show.getTitle()} - Excluído: {show.getIsRemoved()}");
           }
       }

       private static void PutShow()
       {
           Console.WriteLine("Inserir nova série");
           foreach (int i in Enum.GetValues(typeof(Genre)))
           {
               Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
           }
           
            Show newShow = getShowData();

            showRepository.Put(newShow);
       }

       private static void ShowDetail()
       {
           Console.WriteLine("Qual ID da série que você quer visualizar?");
           int showId = int.Parse(Console.ReadLine());
           var show = showRepository.ReturnById(showId);
           Console.WriteLine(show);
       }

       private static void DeleteShow()
       {
           Console.WriteLine("Qual ID da série que você quer excluir?");
           int deleteId = int.Parse(Console.ReadLine());
           showRepository.Delete(deleteId);
       }

       private static void UpdateShow()
       {

           Console.WriteLine("Qual ID da série que você quer atualizar?");
           int updateId = int.Parse(Console.ReadLine());
           foreach (int i in Enum.GetValues(typeof(Genre)))
           {
               Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
           }
           
            Show updatedShow = getShowData();

            showRepository.Update(updateId, updatedShow);
       }

       private static Show getShowData()
       {
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int genreInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o título: ");
            string titleInput = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento da série: ");
            int yearInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição: ");
            string descriptionInput = Console.ReadLine();

            return new Show(id: showRepository.NextId(), 
            genre: (Genre) genreInput, 
            title: titleInput, 
            description: descriptionInput, 
            year: yearInput);
       }

        private static string GetUserChoice()
        {
            Console.WriteLine();
            Console.WriteLine("Séries!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            return Console.ReadLine().ToUpper();
        }
    }
}
