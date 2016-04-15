using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSorter
{
    /// <summary>
    /// Исключение, сигнализирующее о нарушении маршрута (разрывы, циклы, разветвления)
    /// </summary>
    public class CardException: Exception
    {
        /// <summary>
        /// ctor
        /// </summary>
        public CardException() : base() { }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="message">сообщение об ошибке</param>
        public CardException(String message) : base(message) { }
    }
}
