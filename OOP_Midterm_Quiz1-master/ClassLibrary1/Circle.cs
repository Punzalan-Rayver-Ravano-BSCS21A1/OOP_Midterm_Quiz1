using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IColorable
    {

    }
    public class Circle
    {
        public float _area;
        public string _paint;
        public float Radius { get; set; }
       
        public Circle(float rad) 
        {
            Radius = rad;
        }

        public float Area(float area)
        {
            _area = area;
            return _area;
        }
        public string Paint(string _paint) 
        {
            this._paint = _paint;   
            return _paint;
        }

    }
    public class Rectangle : Circle
    {
        public int _width { get; set; }
        public int _height;
        public Rectangle(int wid, int het, int rad1): base(rad1)
        {
            _width = wid;
            _height = het;
        }
    }
}
