using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Komis
{
    public class Brand
    {
        public class Model
        {
            public class ColorImg
            {
                public string Color { get; }
                public Image Img { get; }
                
                public ColorImg(string color, Image img)
                {
                    Color = color;
                    Img = img;
                }
            }
            public string Name { get; }
            public string[] Engines { get; }
            public ColorImg[] Cars { get; }
            public Model(string name, string[] engines, ColorImg[] cars)
            {
                Name = name;
                Engines = engines;
                Cars = cars;
            }
        }
        
        public string Name { get; }
        public Model[] Models { get; }

        public Brand(string name, Model[] models)
        {
            Name = name;
            Models = models;
        }
    }
}