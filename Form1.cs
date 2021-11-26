using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4_2oop
{
    public partial class Form1 : Form
    {
        Model model; //объект модели      
        public Form1()
        {
            InitializeComponent();            
            model = new Model();  //создание модели         
            model.observers += new System.EventHandler(this.UpdateFromModel); //метод для обработки событий
        }        
        private void UpdateFromModel(object sender, EventArgs e) //метод для изменения значений в форме
        {
            //для А и С
            tb1.Text = model.getValueA().ToString();
            nud1.Value = model.getValueA();
            tbar1.Value = model.getValueA();
            tb3.Text = model.getValueC().ToString();
            nud3.Value = model.getValueC();
            tbar3.Value = model.getValueC();
            //для B
            tb2.Text = model.getValueB().ToString();
            nud2.Value = model.getValueB();
            tbar2.Value = model.getValueB();
        }
        private void nud1_ValueChanged(object sender, EventArgs e) //далее идут обработчики событий для компонентов
        {
            model.setValueA(Decimal.ToInt32(nud1.Value));
        }

        private void tbar1_Scroll(object sender, EventArgs e)
        {
            model.setValueA(tbar1.Value);
        }

        private void tb1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                model.setValueA(Int32.Parse(tb1.Text));
        }

        private void tb3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueC(Int32.Parse(tb3.Text));
        }

        private void nud3_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(nud3.Value));
        }

        private void tbar3_Scroll(object sender, EventArgs e)
        {
            model.setValueC(tbar3.Value);
        }

        private void nud2_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(nud2.Value));
        }

        private void tb2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setValueB(Int32.Parse(tb2.Text));
        }

        private void tbar2_Scroll(object sender, EventArgs e)
        {
            model.setValueB(tbar2.Value);
        }
        protected override void OnClosing(CancelEventArgs e) //сохранение данных при выключении программы
        {
            Properties.Settings.Default.valueA = model.getValueA();
            Properties.Settings.Default.valueB = model.getValueB();
            Properties.Settings.Default.valueC = model.getValueC();
            Properties.Settings.Default.Save();
        }
        private void LoadSettings() //выгрузка данных из Settings
        {
            tb1.Text = Properties.Settings.Default.valueA.ToString();
            nud1.Value = Properties.Settings.Default.valueA;
            tbar1.Value = Properties.Settings.Default.valueA;            
            tb3.Text = Properties.Settings.Default.valueC.ToString();                    
            nud3.Value = Properties.Settings.Default.valueC;                  
            tbar3.Value = Properties.Settings.Default.valueC;
            tb2.Text = Properties.Settings.Default.valueB.ToString();
            nud2.Value = Properties.Settings.Default.valueB;
            tbar2.Value = Properties.Settings.Default.valueB;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings(); //выгрузка происходит при загрузке программы
        }
    }
    public class Model //собственно модель
    {
        private int valueA; //три нужных числа
        private int valueB;
        private int valueC;
        public System.EventHandler observers;
        public int getValueA() //методы для получения чисел
        {
            return valueA;
        }
        public int getValueB()
        {
            return valueB;
        }
        public int getValueC()
        {
            return valueC;
        }
        public void setValueA(int _value) //изменение числа А
        {
            if (_value > 0 && _value < 100) //если _value от нуля до ста
            {
                if (_value <= valueC) //и меньше или равно C
                {
                    valueA = _value; //тогда А равно _value
                    if (valueB < _value) //если В меньше _value
                    {
                        valueB = _value; //тогда В равно _value
                    }
                }
                else //если _value больше С
                {
                    valueA = _value; //тогда A равно _value
                    valueC = _value; // и С
                    valueB = _value; // и B
                }
            } 
            else if (_value >= 100) //если же _value больше ста
            {

                valueA = 100; //тогда наверное так
                valueC = 100;
                valueB = 100;
            }
            else if (_value <= 0) //если меньше нуля
            {
                valueA = 0; //тогда А = 0
            }
            observers.Invoke(this,null);
        }
        public void setValueC(int _value) //изменение числа C
        {
            if (_value > 0 && _value < 100) //если от нуля до ста
            {
                if (_value >= valueA) //и если больше А
                {
                    valueC = _value; //тогда равно
                    if (valueB > _value) //если В больше _value
                    {
                        valueB = _value; //тогда В равно _value
                    }
                }
                else //если меньше А
                {
                    valueC = _value; //тогда равно
                    valueA = _value; // и это
                    valueB = _value; // и это
                }
                
            }
            else if (_value >= 100)
            {
                valueC = 100;
            }
            else if (_value <= 0)
            {
                valueC = 0;
                valueB = 0;
                valueA = 0;
            }
            observers.Invoke(this, null);
        }
        public void setValueB(int _value) //изменение числа B
        {
            if (_value >= valueA && _value <= valueC) //если больше или равно А и меньше или равно С
            {
                valueB = _value; //тогда все норм 
            }
            else if (_value > valueC) //если больше С
            {
                //valueB = valueC;
            }
            else if (_value < valueA) //если меньше А
            {
                //valueB = valueA;
            }         
            observers.Invoke(this, null);
        }
    }
}
