using System;
namespace series

{
    public class Show : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }

        private bool isRemoved { get; set; }

        public Show()
        {

        }
    
        public Show(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = Genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.isRemoved = false;
        }

        public override string ToString()
        {
            string retorno = "";
            string removedMessage = this.isRemoved ? "Sim" : "Não";
            retorno += "Gênero: " + this.Genre + Environment.NewLine;
            retorno += "Título: " + this.Title + Environment.NewLine;
            retorno += "Descrição: " + this.Description + Environment.NewLine;
            retorno += "Ano: " + this.Year + Environment.NewLine;
            return retorno += "Excluído: " + removedMessage + Environment.NewLine;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public int getId()
        {
            return this.Id;
        }

        public void Delete()
        {
            this.isRemoved = true;
        }

        public string getIsRemoved()
        {
            return this.isRemoved ? "Sim" : "Não";
;
        }
    }
}