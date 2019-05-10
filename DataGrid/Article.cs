using System;

namespace DataGrid
{

    public class Article
    {
        private string articleNumber;
        public string ArticleNumber
        {
            //get{ return articleNumber;}
            get{ return articleNumber;}
            set
            {
                if(value.Length == 6)
                    articleNumber = value;
                else
                {
                    throw new ArgumentException(
                        $"ArticleNumber must be 6 digits long: {value}"
                    );
                }
            }
        }

        public string GS
        {get; set;}

        public int ID
        {get; set;}

        public DateTime LastEdit
        {get; set;}

        public override String ToString()
        {
            return $"{this.ArticleNumber}:{this.GS}:{this.ID}";
        }

        public string ValidateArticle(string articleNumber)
        {
            if (articleNumber.Length < 3)
                return "ArticleNumber to small";
            else
            {
                this.ArticleNumber = articleNumber;
                return "ok";
            }
        }

        public string ValidateGS(string gs)
        {
            if(gs.Length != 2)
                return "GS value too law."
            else
        {
            GS = gs;
                return "GS ok";
            }
        }

        public string ValidateID(int id)
        {
            if (id < 0)
                return "id has to be >= 0."
            else
            {
                ID = id;
                return "ID set ok";
            }

        }
    }
}
