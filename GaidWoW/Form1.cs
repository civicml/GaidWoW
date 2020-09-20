using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace GaidWoW
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; //запрет на ввод
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) //катаклизм
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Разбойник"):
                        switch (comboBox2.Text)
                        {
                            case ("Ликвидация"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-razbojniku-likvidacii-patch-4-2");
                                break;
                            case ("Бой"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-combat-roge-4-3");
                                break;
                            case ("Скрытность"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/gajd-po-shd-roge-4-3");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
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
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Вы что-то не так сделали в выборе класса...");
                        break;
                }
            }

            if (checkBox2.Checked == true) //легион
            {
                switch (comboBox1.Text)
                {
                    case ("Друид"):
                        switch (comboBox2.Text)
                        {
                            case ("Баланс"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/balans-druid-7-2-legion-pve-gajd");
                                break;
                            case ("Сила зверя"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/feral-druid-pve-gajd-wow-legion");
                                break;
                            case ("Исцеление"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/restor-druid-pve-gajd-legion");
                                break;
                            case ("Страж"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/druid-tank-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Воин"):
                        switch (comboBox2.Text)
                        {
                            case ("Оружие"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/arms-var-7-1-pve-gajd");
                                break;
                            case ("Неистовство"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/furi-var-pve-gajd-legion");
                                break;
                            case ("Защита"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/voin-tank-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Жрец"):
                        switch (comboBox2.Text)
                        {
                            case ("Послушание"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/dc-priest-pve-gajd-legion");
                                break;
                            case ("Свет"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/holy-priest-pve-gajd-wow-legion");
                                break;
                            case ("Тьма"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/shp-priest-pve-gajd-wow-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Чернокнижник"):
                        switch (comboBox2.Text)
                        {
                            case ("Колдовство"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/afli-lok-pve-gajd-wow-legion");
                                break;
                            case ("Демонология"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/chernoknizhnik-demonolog-pve-gajd-legion");
                                break;
                            case ("Разрушение"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/destro-lok-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Разбойник"):
                        switch (comboBox2.Text)
                        {
                            case ("Ликвидация"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/muti-roga-7-2-pve-gajd-wow-legion");
                                break;
                            case ("Головорез"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/razbojnik-golovorez-7-2-pve-gajd");
                                break;
                            case ("Скрытность"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/shd-roga-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Шаман"):
                        switch (comboBox2.Text)
                        {
                            case ("Стихии"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/elem-shaman-pve-gajd-legion");
                                break;
                            case ("Совершенствование"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/enh-shaman-pve-gajd-wow-legion");
                                break;
                            case ("Исцеление"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/restor-shaman-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Паладин"):
                        switch (comboBox2.Text)
                        {
                            case ("Свет"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/holy-paladin-pve-gajd-legion");
                                break;
                            case ("Защита"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/prot-paladin-tank-7-2-pve-gajd");
                                break;
                            case ("Воздаяние"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/retri-paladin-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Охотник"):
                        switch (comboBox2.Text)
                        {
                            case ("Повелитель зверей"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/bm-hant-7-1-pve-gajd-legion");
                                break;
                            case ("Стрельба"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/mm-hant-7-1-pve-gajd-wow-legion");
                                break;
                            case ("Выживание"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/surv-hant-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Рыцарь смерти"):
                        switch (comboBox2.Text)
                        {
                            case ("Кровь"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/blad-dk-tank-pve-gajd-legion");
                                break;
                            case ("Лед"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/frost-dk-pve-gajd-wow-legion");
                                break;
                            case ("Нечестивость"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/unholy-dk-pve-gajd-wow-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Маг"):
                        switch (comboBox2.Text)
                        {
                            case ("Лед"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/frost-mag-pve-gajd-wow-legion");
                                break;
                            case ("Огонь"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/faer-mag-pve-gajd-wow-legion");
                                break;
                            case ("Тайная магия"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/arkan-mag-pve-gajd-wow-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Вы что-то не так сделали в выборе класса...");
                        break;
                    case ("Охотник на демонов"):
                        switch (comboBox2.Text)
                        {
                            case ("Месть"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/dh-tank-pve-gajd-ohotnik-na-demonov");
                                break;
                            case ("Истребление"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/ohotnik-na-demonov-istreblenie-pve-gajd");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                    case ("Монах"):
                        switch (comboBox2.Text)
                        {
                            case ("Хмелевар"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/monah-hmelevar-tank-pve-gajd-legion");
                                break;
                            case ("Танцующий с ветром"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/monah-tancuyushhij-s-vetrom-pve-gajd-wow-legion");
                                break;
                            case ("Ткач туманов"):
                                System.Diagnostics.Process.Start("http://wowgaid.ru/class/monah-tkach-tumanov-pve-gajd-legion");
                                break;
                            default:
                                MessageBox.Show("Вы что-то не так сделали в выборе специализации...");
                                break;
                        }
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) //заполнение спеков катаклизма
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
                        comboBox2.Items.AddRange(new string[] { "Ликвидация", "Бой", "Скрытность" });
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

            if (checkBox2.Checked == true) //заполнение спеков легиона
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
                    case ("Охотник на демонов"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Месть", "Истребление" });
                        break;
                    case ("Монах"):
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(new string[] { "Танцующий с ветром", "Ткач туманов", "Хмелевар" });
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
            if (checkBox1.Checked == false)
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
            }
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                comboBox1.Items.AddRange(new string[] { "Воин", "Друид", "Жрец", "Маг", "Охотник", "Паладин"
                    , "Разбойник", "Рыцарь смерти", "Чернокнижник", "Шаман" }); //заполнение классов катаклизм
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
            }
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                comboBox1.Items.AddRange(new string[] { "Воин", "Друид", "Жрец", "Маг", "Монах",
                    "Охотник", "Охотник на демонов", "Паладин", "Разбойник", 
                    "Рыцарь смерти", "Чернокнижник", "Шаман" }); //заполнение классов легион
            }
        }
    }
}
