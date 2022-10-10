namespace WarPreparations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword s = new Sword(Material.Bronze, Gemstone.Sapphire, 15, 2);

            Sword orig = new Sword(Material.Iron, Gemstone.None);

            Sword origWithGem = orig with { gemstone = Gemstone.Sapphire };

            Sword origWithAll = orig with { gemstone = Gemstone.Bitstone, crossGuardWidth = 100, swordLength = 1000 };

            Console.WriteLine(orig);
            Console.WriteLine(origWithGem);
            Console.WriteLine(origWithAll);

        }
    }

    record Sword(Material material, Gemstone gemstone, int swordLength = 0, int crossGuardWidth = 0);

    enum Material { Wood, Bronze, Iron, Steel, Binarium };
    enum Gemstone { Emerald, Amber, Sapphire, Diamond, Bitstone, None };
}