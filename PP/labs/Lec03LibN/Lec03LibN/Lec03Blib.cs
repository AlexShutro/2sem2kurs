// Интерфейс для вычисления вознаграждения
using Lec03LibN.Factory;
using Lec03LibN.Bonus;

namespace Lec03LibN
{
    public class FactoryL1 : IFactory
    {

        public float A { get; set; }

        public IBonus getA(float cost1hour, float a)
        {
            return new BonusA(a, cost1hour);
        }

        public IBonus getA(float cost1hour)
        {
            throw new NotImplementedException();
        }

        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB(cost1hour, x);

        }
        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC(cost1hour, x, y);

        }

    }
    public class FactoryL2 : IFactory
    {
        public FactoryL2(float a)
        {
            A = a;
        }

        public float A { get; set; }
        public IBonus getA(float cost1hour)
        {
            return new BonusA(cost1hour, A);
        }
        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB(cost1hour, x, A);
        }
        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC(cost1hour, x, y, A);
        }

    }
    public class FactoryL3 : IFactory
    {
        public float A { get; set; }
        public float B { get; set; }
        public IBonus getA(float cost1hour)
        {
            return new BonusA(cost1hour + B, A);
        }
        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB(cost1hour + B, x, A);
        }
        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC(cost1hour + B, x, y, A);
        }
        public FactoryL3(float a, float b)
        {
            A = a;
            B = b;
        }
    }
    // Уровни вознаграждения
    // Реализация методов фабрик уровней вознаграждения
    static public partial class Lec03BLib
    {
        static public IFactory getL1()
        {
            return new FactoryL1();
        }
        static public IFactory getL2(float a)
        {
            return new FactoryL2(a);
        }
        static public IFactory getL3(float a, float b)
        {
            return new FactoryL3(a, b);
        }
    }

}