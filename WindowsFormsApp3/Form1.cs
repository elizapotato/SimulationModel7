using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double marketing = 0.5;   //Эффективность рекламы
        const int DEL = 6;
        const int oklad = 20000;        //Оклад на 1 чел.

        int store = 3000;   //Запасы
        int staff = 1;      //Персонал
        double UKO = 0;     //Уровень качества обслуживания

        double prib = 1000000;  //Начальный капитал      
        int RSell = 0;          //Розничная продажа
        double price = 0;       //Цена товара
        double demand = 0;      //Спрос
        double ZP = 0;          //Зарплата на весь персонал
        int time = 0;

        double s1 = 0, out1 = 0, s2 = 0, out2 = 0, s3 = 0, out3 = 0;

        private void labPers_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            time++;
            Random rand = new Random();
            double ZC = (int)edZC.Value;    //Закупочная стоимость продукции
            int naim = (int)edNaim.Value;   //Найм
            int post = (int)edPost.Value;   //Поставки

            //Доставка товара в магазин
            s3 = s3 + out2 - out3;
            out3 = Math.Ceiling(s3 / (DEL / 3));
            s2 = s2 + out1 - out2;
            out2 = Math.Ceiling(s2 / (DEL / 3));
            s1 = s1 + post - out1;
            out1 = Math.Ceiling(s1 / (DEL / 3));          
            //Наем и увольнение
            int fired = rand.Next(0, (staff / 2));      //Уволенные
            staff = staff + naim - fired;               //Количество персонала
            //Экономика магазина
            price = Math.Round(ZC * 2, 2);
            demand = marketing / (price*0.0005);
            UKO = (ZP / (staff * 1000)) * staff;
            //Продажи
            RSell = (int)(Math.Round(demand) * UKO);
            if (RSell > store) RSell = store;
            store = store + (int)out3 - RSell;
            //Зарплата
            if (RSell < 200) ZP = oklad * 0.8 * staff;      //Начисление премиальных
            if (RSell > 500) ZP = oklad * 1.1 * staff;
            else ZP = oklad * 1 * staff;
            //Подсчет прибыли
            double profit = Math.Round(RSell * price,2);    //Выручка
            double rashods = Math.Round(ZC * post+ZP,2);    //Расходы
            prib = prib + profit - rashods;                 //Прибыль

            labPers.Text = "Персонал: " + staff;
            labPrib.Text = "Прибыль: " + prib;
            labStore.Text = "Запасы: " + store;
            labTime.Text = "Месяц: " + time;
        }
    }
}
