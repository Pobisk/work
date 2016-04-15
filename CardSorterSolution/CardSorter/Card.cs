using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorter
{
    /// <summary>
    /// Карточка маршрута
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Пункт отправления
        /// </summary>
        public String From { get; set; }
        /// <summary>
        /// Пункт назначения
        /// </summary>
        public String To { get; set; }
        /// <summary>
        /// Ссылка на следующую карточку маршрута
        /// </summary>
        public Card Next { get; set; }
        /// <summary>
        /// Строчное представление карточки в виде Берлин -> Кельн
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} -> {1}", From, To);
        }
    }
}
