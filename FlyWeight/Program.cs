using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program

    {

        static void Main(string[] args)

        {

            const int ONE_MILLION = 10000; // <--- Suppose this is one million :)

            int[] currencyDenominations = new[] { 1, 5, 10, 20, 50, 100 };

            MoneyFactory moneyFactory = new MoneyFactory();

            int sum = 0;

            while (sum <= ONE_MILLION)

            {

                IMoney graphicalMoneyObj = null;

                Random rand = new Random();

                int currencyDisplayValue = currencyDenominations[rand.Next(0, currencyDenominations

                .Length)];

                if (currencyDisplayValue == 1 || currencyDisplayValue == 5)

                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(EnMoneyType.Metallic);

                else

                    graphicalMoneyObj = moneyFactory.GetMoneyToDisplay(EnMoneyType.Paper);

                graphicalMoneyObj.GetDisplayOfMoneyFalling(currencyDisplayValue);

                sum = sum + currencyDisplayValue;

            }

            Console.WriteLine("Total Objects created=" + MoneyFactory.ObjectsCount.ToString());

            Console.ReadLine();

        }

    }

    public enum EnMoneyType

    {

        Metallic,

        Paper

    }

    public interface IMoney

    {

        EnMoneyType MoneyType { get; } //IntrinsicState()

        void GetDisplayOfMoneyFalling(int moneyValue); //GetExtrinsicSate()

    }

    public class MetallicMoney : IMoney

    {

        public EnMoneyType MoneyType

        {

            get { return EnMoneyType.Metallic; }

        }

        public void GetDisplayOfMoneyFalling(int moneyValue)

        {

            //This method would display graphical representation of a metallic currency like a

            Console.WriteLine("");

        }

    }

    class PaperMoney : IMoney

    {

        public EnMoneyType MoneyType

        {

            get { return EnMoneyType.Paper; }

        }

        public void GetDisplayOfMoneyFalling(int moneyValue) //GetExtrinsicState()

        {

            // This method would display a graphical representation of a paper currency.

            Console.WriteLine(string.Format("Displaying a graphical object of {0} currency of value ${1} falling from sky."

            , MoneyType.ToString(), moneyValue));

        }

    }

    public class MoneyFactory

    {

        public static int ObjectsCount = 0;

        private Dictionary<EnMoneyType, IMoney> _moneyObjects;

        public IMoney GetMoneyToDisplay(EnMoneyType form) // Same as GetFlyWeight()

        {

            if (_moneyObjects == null)

                _moneyObjects = new Dictionary<EnMoneyType, IMoney>();

            if (_moneyObjects.ContainsKey(form))

                return _moneyObjects[form];

            switch (form)

            {

                case EnMoneyType.Metallic:

                    _moneyObjects.Add(form, new MetallicMoney());

                    ObjectsCount++;

                    break;

                case EnMoneyType.Paper:

                    _moneyObjects.Add(form, new PaperMoney());

                    ObjectsCount++;

                    break;

                default:

                    break;

            }

            return _moneyObjects[form];

        }

    }
}
