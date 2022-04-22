using System.Collections.Generic;

namespace Komis
{
    public static class BrandsBuilder
    {
        public static readonly List<Brand> Brands = new List<Brand>();

        static BrandsBuilder()
        {
            var engines = new[] { "V2","V3"};
            
            Brands.Add(new Brand("Audi", new[]
            {
                new Brand.Model("E-tron", new []
                    {
                        "e-tron 50 quattro",
                        "e-tron advanced 50 quattro",
                        "e-tron S line 50 quattro"
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Black", Properties.Resources.e_tron_black),
                        new Brand.Model.ColorImg("Blue", Properties.Resources.e_tron_blue),
                        new Brand.Model.ColorImg("Grey", Properties.Resources.e_tron_grey)
                    }),
                new Brand.Model("A8", new []
                    {
                        "A8 L 50 TDI quattro tiptronic",
                        "A8 L 55 TFSI quattro tiptronic",
                        "A8 L 60 TFSI quattro tiptronic"
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Black", Properties.Resources.a8_black),
                        new Brand.Model.ColorImg("Blue", Properties.Resources.a8_blue),
                        new Brand.Model.ColorImg("White", Properties.Resources.a8_white)
                    }),

            }));

            Brands.Add(new Brand("Porsche",new[]
            {
                new Brand.Model("718",new []
                    {
                        "GTS 4.0",
                        "GT4 RS"
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Black", Properties.Resources._718_black),
                        new Brand.Model.ColorImg("Red", Properties.Resources._718_red),
                        new Brand.Model.ColorImg("Yellow", Properties.Resources._718_yellow),
                        new Brand.Model.ColorImg("White", Properties.Resources._718_white),
                    }),
                new Brand.Model("911 cabriolet",new []
                    {
                        "3.0 480KM",
                        "3.0 385KM",
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Black", Properties.Resources.p911_black),
                        new Brand.Model.ColorImg("Green", Properties.Resources.p911_green),
                        new Brand.Model.ColorImg("White", Properties.Resources.p911_white),
                        new Brand.Model.ColorImg("Orange", Properties.Resources.p911_orange),
                    }),
            }));
            
            Brands.Add(new Brand("BMW", new[]
            {
                new Brand.Model("Z4 Roadster", new []
                    {
                        "Z4 sDrive20i",
                        "Z4 sDrive30i",
                        "Z4 M40i"
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Black", Properties.Resources.z4_black),
                        new Brand.Model.ColorImg("Red", Properties.Resources.z4_red),
                        new Brand.Model.ColorImg("White", Properties.Resources.z4_white)
                    }),
                new Brand.Model("M240i", new []
                    {
                        "220i Coupe",
                        "230i Coupe",
                        "220d Coupe"
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Black", Properties.Resources.m240_black),
                        new Brand.Model.ColorImg("Purple", Properties.Resources.m240_purple),
                        new Brand.Model.ColorImg("White", Properties.Resources.m240_white)
                    }),
                new Brand.Model("X1", new []
                    {
                        "X1 xDrive25e",
                        "X1 sDrive18i",
                        "X1 sDrive20i",
                        "X1 sDrive16d"
                    },
                    new[]
                    {
                        new Brand.Model.ColorImg("Blue", Properties.Resources.x1_blue),
                        new Brand.Model.ColorImg("Orange", Properties.Resources.x1_orange),
                        new Brand.Model.ColorImg("White", Properties.Resources.x1_white)
                    }),
            }));
        }

    }
}