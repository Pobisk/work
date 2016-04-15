using CardSorter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardSorterWin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Построить исходный список карточек
        /// </summary>
        /// <returns></returns>
        private List<Card> CreateOriginalList()
        {
            // получим список городов
            String str = txtCities.Text;
            String[] arr = str.Split(',');
            List<String> cities = arr.Select(t => t.Trim()).Where(t => !String.IsNullOrEmpty(t)).ToList();

            // построим список карточек в том порядке, как задано в списке городов
            List<Card> list = new List<Card>();
            for (int i = 0; i < cities.Count - 1; i++)
            {
                Card card = new Card() { From = cities[i], To = cities[i + 1] };
                list.Add(card);
            }

            return list;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                List<Card> originalList = CreateOriginalList();

                // исходный список
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Исходный список");
                foreach (Card card in originalList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // перемешаем карточки
                List<Card> inputList = new List<Card>();
                // чтобы быстро перемешать - отсортируем пункты отправления по алфавиту
                inputList.AddRange(originalList.OrderBy(t => t.From));

                sb.AppendLine("Карточки перемешаны");
                foreach (Card card in inputList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // используем наш сортировщик
                Sorter s = new Sorter();
                List<Card> reult = s.Sort(inputList);

                // результат
                sb.AppendLine("Результат");
                foreach (Card card in reult)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Произошла ошибка");
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            try
            {
                List<Card> originalList = CreateOriginalList();

                // Добавим разрыв маршрута (город, которого нет в исходном списке)
                originalList.Add(new Card() { From = "Каир", To = "Багдад" });

                // исходный список
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Исходный список");
                foreach (Card card in originalList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // перемешаем карточки
                List<Card> inputList = new List<Card>();
                // чтобы быстро перемешать - отсортируем пункты отправления по алфавиту
                inputList.AddRange(originalList.OrderBy(t => t.From));

                sb.AppendLine("Карточки перемешаны");
                foreach (Card card in inputList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // используем наш сортировщик
                Sorter s = new Sorter();
                List<Card> reult = s.Sort(inputList);

                // результат
                sb.AppendLine("Результат");
                foreach (Card card in reult)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Произошла ошибка");
            }
        }

        private void btnBranchFrom_Click(object sender, EventArgs e)
        {
            try
            {
                List<Card> originalList = CreateOriginalList();

                // Добавим разветвление пункта отправления
                originalList.Add(new Card() { From = "Токио", To = "Пекин" });

                // исходный список
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Исходный список");
                foreach (Card card in originalList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // перемешаем карточки
                List<Card> inputList = new List<Card>();
                // чтобы быстро перемешать - отсортируем пункты отправления по алфавиту
                inputList.AddRange(originalList.OrderBy(t => t.From));

                sb.AppendLine("Карточки перемешаны");
                foreach (Card card in inputList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // используем наш сортировщик
                Sorter s = new Sorter();
                List<Card> reult = s.Sort(inputList);

                // результат
                sb.AppendLine("Результат");
                foreach (Card card in reult)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Произошла ошибка");
            }
        }

        private void btnBranchTo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Card> originalList = CreateOriginalList();

                // Добавим разветвление пункта назначения
                originalList.Add(new Card() { From = "Пекин", To = "Токио" });

                // исходный список
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Исходный список");
                foreach (Card card in originalList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // перемешаем карточки
                List<Card> inputList = new List<Card>();
                // чтобы быстро перемешать - отсортируем пункты отправления по алфавиту
                inputList.AddRange(originalList.OrderBy(t => t.From));

                sb.AppendLine("Карточки перемешаны");
                foreach (Card card in inputList)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                // используем наш сортировщик
                Sorter s = new Sorter();
                List<Card> reult = s.Sort(inputList);

                // результат
                sb.AppendLine("Результат");
                foreach (Card card in reult)
                    sb.AppendLine(card.ToString());
                sb.AppendLine();

                txtResult.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Произошла ошибка");
            }
        }
    }
}
