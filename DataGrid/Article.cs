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
    }
}
