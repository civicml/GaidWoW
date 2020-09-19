using System;
using System.Windows.Forms;

namespace GaidWoW
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                switch (comboBox1.Text)
                {
                    case ("Друид"):
                        switch (comboBox2.Text)
                        {
                            case ("Баланс"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-balans-druidu-4-3");
                                break;
                            case ("Сила зверя"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-feral-druidu-4-3");
                                break;
                            case ("Исцеление"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-restor-druidu-4-3");
                                break;
                            case ("Страж"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-druidu-tanku-4-3");
                                break;
                        }
                        break;
                    case ("Воин"):
                        switch (comboBox2.Text)
                        {
                            case ("Оружие"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-arms-varu-4-3");
                                break;
                            case ("Неистовство"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-furi-varu-4-3");
                                break;
                            case ("Защита"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-varu-tanku-4-3");
                                break;
                        }
                        break;
                    case ("Жрец"):
                        switch (comboBox2.Text)
                        {
                            case ("Послушание"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-dc-pristu-4-3");
                                break;
                            case ("Свет"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-holi-pristu-4-3");
                                break;
                            case ("Тьма"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-shp-pristu-4-3");
                                break;
                        }
                        break;
                    case ("Чернокнижник"):
                        switch (comboBox2.Text)
                        {
                            case ("Колдовство"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-afli-loku-4-3");
                                break;
                            case ("Демонология"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-loku-demonologu-4-3");
                                break;
                            case ("Разрушение"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-destro-loku-4-3");
                                break;
                        }
                        break;
                    case ("Разбойник"):
                        switch (comboBox2.Text)
                        {
                            case ("Ликвидация"):
                                System.Diagnostics.Process.Start("https://www.noob-club.ru/index.php?topic=15460.0");
                                break;
                            case ("Головорез"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-combat-roge-4-3");
                                break;
                            case ("Скрытность"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-shd-roge-4-3");
                                break;
                        }
                        break;
                    case ("Шаман"):
                        switch (comboBox2.Text)
                        {
                            case ("Стихии"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-elem-shamanu-4-3");
                                break;
                            case ("Совершенствование"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-enh-shamanu-4-3");
                                break;
                            case ("Исцеление"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-restor-shamanu-4-3");
                                break;
                        }
                        break;
                    case ("Паладин"):
                        switch (comboBox2.Text)
                        {
                            case ("Свет"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-holi-paladinu-4-3");
                                break;
                            case ("Защита"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-paladinu-tanku-4-3");
                                break;
                            case ("Воздаяние"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-retri-paladinu-4-3-wow");
                                break;
                        }
                        break;
                    case ("Охотник"):
                        switch (comboBox2.Text)
                        {
                            case ("Повелитель зверей"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-bm-xantu-4-3");
                                break;
                            case ("Стрельба"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-mm-hantu-4-3");
                                break;
                            case ("Выживание"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-surv-hantu-4-3");
                                break;
                        }
                        break;
                    case ("Рыцарь смерти"):
                        switch (comboBox2.Text)
                        {
                            case ("Кровь"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-dk-tanku-4-3");
                                break;
                            case ("Лед"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-frost-dk-4-3");
                                break;
                            case ("Нечестивость"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-anholi-dk-4-3");
                                break;
                        }
                        break;
                    case ("Маг"):
                        switch (comboBox2.Text)
                        {
                            case ("Лед"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-frost-magu-4-3");
                                break;
                            case ("Огонь"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-faer-magu-4-3");
                                break;
                            case ("Тайная магия"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-arkan-magu-4-3");
                                break;
                        }
                        break;

                }
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                switch (comboBox1.Text)
                {
                    case ("Друид"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Баланс", "Сила зверя", "Исцеление", "Страж" });
                        break;
                    case ("Воин"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Оружие", "Неистовство", "Защита" });
                        break;
                    case ("Жрец"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Послушание", "Свет", "Тьма" });
                        break;
                    case ("Чернокнижник"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Колдовство", "Демонология", "Разрушение" });
                        break;
                    case ("Разбойник"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Ликвидация", "Головорез", "Скрытность" });
                        break;
                    case ("Шаман"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Стихии", "Совершенствование", "Исцеление" });
                        break;
                    case ("Паладин"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Свет", "Защита", "Воздаяние" });
                        break;
                    case ("Охотник"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Повелитель зверей", "Стрельба", "Выживание" });
                        break;
                    case ("Рыцарь смерти"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Кровь", "Лед", "Нечестивость" });
                        break;
                    case ("Маг"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Лед", "Огонь", "Тайная магия" });
                        break;
              
                }
            }
            if (checkBox2.Checked == true)
            {
                switch (comboBox1.Text)
                {
                    case ("Друид"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Баланс", "Сила зверя", "Исцеление", "Страж" });
                        break;
                    case ("Воин"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Оружие", "Неистовство", "Защита" });
                        break;
                    case ("Жрец"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Послушание", "Свет", "Тьма" });
                        break;
                    case ("Чернокнижник"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Колдовство", "Демонология", "Разрушение" });
                        break;
                    case ("Разбойник"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Ликвидация", "Головорез", "Скрытность" });
                        break;
                    case ("Шаман"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Стихии", "Совершенствование", "Исцеление" });
                        break;
                    case ("Паладин"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Свет", "Защита", "Воздаяние" });
                        break;
                    case ("Охотник"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Повелитель зверей", "Стрельба", "Выживание" });
                        break;
                    case ("Рыцарь смерти"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Кровь", "Лед", "Нечестивость" });
                        break;
                    case ("Маг"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Лед", "Огонь", "Тайная магия" });
                        break;
                    case ("Монах"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Хмелевар", "Ткач туманов", "Танцующий с ветром" });
                        break;
                    case ("Охотник на демонов"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Истребление", "Месть" });
                        break;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ничего не скажу!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                comboBox1.Items.AddRange(new string[] { "Воин", "Друид", "Жрец", "Маг", "Охотник", "Паладин", "Разбойник", "Рыцарь смерти", "Чернокнижник", "Шаман" });
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                checkBox2.Checked = false;
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Text = ""; 
                comboBox2.Items.Clear();
                comboBox2.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                comboBox1.Items.AddRange(new string[] { "Воин", "Друид", "Жрец", "Маг", "Монах", "Охотник", "Охотник на демонов", "Паладин", "Разбойник", "Рыцарь смерти", "Чернокнижник", "Шаман" });
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                checkBox1.Checked = false;
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                comboBox2.Items.Clear();
                comboBox2.Text = "";
            }
        }
        
    }
}
