namespace series


{
    public class Serie : EntidadeBase
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie()
        {
            
        }
    
        public Serie(int id, Genre genre, string title, string descricao, int ano)
        {
            this.Id = id;
            this.Genre = Genre;
            this.Title = title;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            // Environment.NewLine
            string retorno = "";
            retorno += "Genre: " + this.Genre + "/n";
            retorno += "Title: " + this.Title + "/n";
            retorno += "Descricao: " + this.Descricao + "/n";
            return retorno += "Ano: " + this.Ano + "/n";
        }

        public string getTitle()
        {
            return this.Title;
        }

        public int getId()
        {
            return this.Id;
        }
    }
}