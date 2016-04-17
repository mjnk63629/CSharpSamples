using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    public class Fruit
    {
        private string _fruitName;
        private string _fruitColor;
        private string _fruitSeason;


        public string FruitName
        {
            get { return _fruitName; }
            set { _fruitName = value; }
        }

        public string FruitColor
        {
            get { return _fruitColor; }
            set { _fruitColor = value; }
        }

        public string FruitSeason
        {
            get { return _fruitSeason; }
            set { _fruitSeason = value; }
        }
    }
}
