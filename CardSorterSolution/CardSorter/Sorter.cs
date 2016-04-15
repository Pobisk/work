using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorter
{
    /// <summary>
    /// Класс, выполняющий сортировку
    /// </summary>
    public class Sorter
    {
        /// <summary>
        /// Сортировать карточки так, чтобы пункт отправления в следующей карточке совпадал с пунктом назначения в предыдущей
        /// </summary>
        /// <param name="input">входной список неупорядоченных карточек</param>
        /// <returns>выходной список, в котором карточки упорядочены</returns>
        public List<Card> Sort(List<Card> input)
        {
            if (input == null)
                throw new ArgumentNullException("input", "Задайте входной список");

            List<Card> result = new List<Card>(input.Count);
            // если во входном списоке менее 2 карточек, то сортировать нечего - возвращаем как есть
            if (input.Count <= 1)
            {
                result.AddRange(input);
            }
            else
            {
                // поместим все входные карточки в словарь, чтобы быстро искать их по пункту назначения (поиск в словаре самый быстрый)
                // ключ словаря - пунк назначения
                Dictionary<String, Card> inner = new Dictionary<String, Card>(input.Count);
                foreach (Card card in input)
                {
                    if (inner.ContainsKey(card.To))
                        throw new CardException(String.Format("Разветвление маршрута одинаковые точки назначения: {0} и {1}", inner[card.To], card));
                    inner.Add(card.To, card);
                }

                // отправная точка путешествия - это 1-я карточка маршрута
                Card first = null;
                foreach (Card card in input)
                {
                    // анализируем каждую карточку - ищем в словаре карточку пункт назначения которой совпадает с пунктом отправления текущей
                    if (!inner.ContainsKey(card.From))
                    {
                        // если в словаре нет такой карточки, то значит текущая карточка - это начало маршрута
                        if (first != null)
                            // при этом если начало уже есть - ошибка
                            throw new CardException(String.Format("Разрыв маршрута: более 1-й точки отправления {0} и {1}", first, card));
                        first = card;
                    }
                    else
                    {
                        // в найденной карточке пункт назначения совпадает с пунктом отправления текущей, 
                        // значит текщая карточка является следующей в маршруте по отношению к найденной
                        if (inner[card.From].Next != null)
                            // при этом если в найденной карточке уже есть следующая - ошибка
                            throw new CardException(String.Format("Разветвление маршрута одинаковые точки отправления: {0} и {1}", inner[card.From].Next, card));

                        inner[card.From].Next = card;
                    }
                }

                // маршрут построен - осталось вывести его в выходной список
                Card current = first;
                while (current != null)
                {
                    result.Add(current);
                    current = current.Next;
                }
            }

            return result;
        }
    }
}
