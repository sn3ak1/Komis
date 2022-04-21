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
                new Brand.Model("a1", engines,
                    new[]
                    {
                        new Brand.Model.Car("red", Properties.Resources.test),
                        new Brand.Model.Car("white", Properties.Resources._20221)
                    }),
                new Brand.Model("a2", engines,
                    new[]
                    {
                        new Brand.Model.Car("red", Properties.Resources.test),
                        new Brand.Model.Car("white", Properties.Resources._20221)
                    }),

            }));
            Brands.Add(new Brand("BMW",new[]
            {
                new Brand.Model("b1",engines,
                    new[]
                    {
                        new Brand.Model.Car("red", Properties.Resources.test),
                        new Brand.Model.Car("white", Properties.Resources._20221)
                    }),
                new Brand.Model("b2",engines,
                    new[]
                    {
                        new Brand.Model.Car("red", Properties.Resources.test),
                        new Brand.Model.Car("white", Properties.Resources._20221)
                    }),
            }));
        }

    }
}