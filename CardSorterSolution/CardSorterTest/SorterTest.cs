using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardSorter;
using System.Collections.Generic;

namespace CardSorterTest
{
    [TestClass]
    public class SorterTest
    {
        /// <summary>
        /// null на вход
        /// </summary>
        [TestMethod]
        public void TestMethod_NULL()
        {
            try
            {
                Sorter s = new Sorter();
                s.Sort(null);
            }
            catch (ArgumentNullException)
            {
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Ожидалось исключение ArgumentNullException, а получили {0}", ex.ToString());
            }
            Assert.Fail("Ожидалось исключение ArgumentNullException, исклюения нет");
        }

        /// <summary>
        /// Пустой входной список
        /// </summary>
        [TestMethod]
        public void TestMethod_Count0()
        {
            Sorter s = new Sorter();
            List<Card> input = new List<Card>();
            List<Card> actual = s.Sort(input);
            CollectionAssert.AreEqual(input, actual, "Ожидался пустой входной список");
        }

        /// <summary>
        /// Входной список из 1-й карточки
        /// </summary>
        [TestMethod]
        public void TestMethod_Count1()
        {
            Sorter s = new Sorter();
            List<Card> input = new List<Card>();
            input.Add(new Card() { From="Москва", To="Берлин" });
            List<Card> actual = s.Sort(input);
            CollectionAssert.AreEqual(input, actual, "Ожидался список из одного элемента");
        }

        /// <summary>
        /// Правильность построения маршрута
        /// </summary>
        [TestMethod]
        public void TestMethod_Main()
        {
            Sorter s = new Sorter();
            List<Card> input = new List<Card>();

            Card card1 = new Card() { From = "Москва", To = "Берлин" };
            Card card2 = new Card() { From = "Берлин", To = "Варшава" };
            Card card3 = new Card() { From = "Варшава", To = "Прага" };

            input.Add(card2);
            input.Add(card3);
            input.Add(card1);

            List<Card> actual = s.Sort(input);
            Assert.AreEqual(card1, actual[0], "Карточка 1 не на своем месте");
            Assert.AreEqual(card2, actual[1], "Карточка 2 не на своем месте");
            Assert.AreEqual(card3, actual[2], "Карточка 3 не на своем месте");
        }

        /// <summary>
        /// Разрыв маршрута
        /// </summary>
        [TestMethod]
        public void TestMethod_Break()
        {
            try
            {
                Sorter s = new Sorter();
                List<Card> input = new List<Card>();

                Card card1 = new Card() { From = "Москва", To = "Берлин" };
                Card card2 = new Card() { From = "Берлин", To = "Варшава" };
                Card card3 = new Card() { From = "Варшава", To = "Прага" };
                Card card4 = new Card() { From = "Орел", To = "Владивосток" };

                input.Add(card2);
                input.Add(card3);
                input.Add(card1);
                input.Add(card4);

                List<Card> actual = s.Sort(input);
            }
            catch (CardException cex)
            {
                StringAssert.Contains(cex.Message, "Разрыв маршрута", "Не обнаружен разрыв маршрута");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Ожидалось исключение CardException, а получили {0}", ex.ToString());
            }
            Assert.Fail("Ожидалось исключение CardException, исклюения нет");
        }

        /// <summary>
        /// Разветвление маршрута (точка назначения)
        /// </summary>
        [TestMethod]
        public void TestMethod_BranchTo()
        {
            try
            {
                Sorter s = new Sorter();
                List<Card> input = new List<Card>();

                Card card1 = new Card() { From = "Москва", To = "Берлин" };
                Card card2 = new Card() { From = "Берлин", To = "Варшава" };
                Card card3 = new Card() { From = "Варшава", To = "Прага" };
                Card card4 = new Card() { From = "Орел", To = "Варшава" };

                input.Add(card2);
                input.Add(card3);
                input.Add(card1);
                input.Add(card4);

                List<Card> actual = s.Sort(input);
            }
            catch (CardException cex)
            {
                StringAssert.Contains(cex.Message, "одинаковые точки назначения", "Не обнаружены одинаковые точки назначения");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Ожидалось исключение CardException, а получили {0}", ex.ToString());
            }
            Assert.Fail("Ожидалось исключение CardException, исклюения нет");
        }

        /// <summary>
        /// Разветвление маршрута (точка отправления)
        /// </summary>
        [TestMethod]
        public void TestMethod_BranchFrom()
        {
            try
            {
                Sorter s = new Sorter();
                List<Card> input = new List<Card>();

                Card card1 = new Card() { From = "Москва", To = "Берлин" };
                Card card2 = new Card() { From = "Берлин", To = "Варшава" };
                Card card3 = new Card() { From = "Варшава", To = "Прага" };
                Card card4 = new Card() { From = "Варшава", To = "Орел" };

                input.Add(card2);
                input.Add(card3);
                input.Add(card1);
                input.Add(card4);

                List<Card> actual = s.Sort(input);
            }
            catch (CardException cex)
            {
                StringAssert.Contains(cex.Message, "одинаковые точки отправления", "Не обнаружены одинаковые точки отправления");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Ожидалось исключение CardException, а получили {0}", ex.ToString());
            }
            Assert.Fail("Ожидалось исключение CardException, исклюения нет");
        }
    }
}
