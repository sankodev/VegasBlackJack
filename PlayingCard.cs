using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC21_KS_VegasBlackJack
{
    class PlayingCard
    {
        //feilds
        private string _faceValue;
        private string _suit;
        private Image _cardFace;
        private int _points;

        //properties
        //private string faceValue;
        //private string suit;
        //private Image cardFace;
        //private int points;

        public string FaceValue
        {
            get {return _faceValue;}
            set {_faceValue = value;}
        }

        public string Suit
        {
            get {return _suit;}
            set {_suit = value;}
        }

        public Image CardFace
        {
            get {return _cardFace;}
            set {_cardFace = value;}
        }

        public int Points
        {
            get {return _points;}
            set {_points = value;}
        }




        //methods:
        //constructor - instantiates new object
        public PlayingCard(string faceValue, string suit, Image cardFace, int points)
        {
            _faceValue = faceValue;
            _suit = suit;
            _cardFace = cardFace;
            _points = points;
        }

        //toString()
        public override string ToString()
        {
            string output = _faceValue + "of" + _suit;
            return output;
        }



    }
}
