using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceSolver._1._1._1
{
    public partial class PhysicExchangeUnits : Form
    {
        public PhysicExchangeUnits()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            if (comboBox1.Text == "inch - cetimeter")
                textBox2.Text = Physics_Exchange.inch_exchange_cm(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "cetimeter - inch")
                textBox2.Text = Physics_Exchange.cm_exchange_inch(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "ft - meter")
                textBox2.Text = Physics_Exchange.ft_exchange_meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "meter - ft")
                textBox2.Text = Physics_Exchange.meter_exchange_ft(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "yard - meter")
                textBox2.Text = Physics_Exchange.yard_exchange_meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "meter - yard")
                textBox2.Text = Physics_Exchange.meter_exchange_yard(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "mile - km")
                textBox2.Text = Physics_Exchange.mile_exchange_km(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "km - mile")
                textBox2.Text = Physics_Exchange.km_exchange_mile(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "n mile - meter")
                textBox2.Text = Physics_Exchange.n_mile_exchange_meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "meter - n mile")
                textBox2.Text = Physics_Exchange.meter_exchange_n_mile(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "arce - m^2")
                textBox2.Text = Physics_Exchange.acre_exchange_square_meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "m^2 - arce")
                textBox2.Text = Physics_Exchange.square_meter_exchange_acre(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "gallon(US) - liter")
                textBox2.Text = Physics_Exchange.gallon_US_exchange_liter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "liter - gallon(US)")
                textBox2.Text = Physics_Exchange.liter_exchange_gallon_US(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "gallon(UK) - liter")
                textBox2.Text = Physics_Exchange.gallon_UK_exchange_liter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "liter - gallon(UK)")
                textBox2.Text = Physics_Exchange.liter_exchange_gallon_UK(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "pc - km")
                textBox2.Text = Physics_Exchange.pc_exchange_km(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "km - pc")
                textBox2.Text = Physics_Exchange.km_exchange_pc(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "km/h - m/s")
                textBox2.Text = Physics_Exchange.kmhour_exchange_metersecond(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "m/s - km/s")
                textBox2.Text = Physics_Exchange.msecond_exchange_kmhour(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "oz - gram")
                textBox2.Text = Physics_Exchange.oz_exchange_gram(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "gram - oz")
                textBox2.Text = Physics_Exchange.gram_exchange_oz(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "lb - kg")
                textBox2.Text = Physics_Exchange.lb_exchange_kilogram(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "kg - lb")
                textBox2.Text = Physics_Exchange.kilogram_exchange_lb(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "atm - Pascan")
                textBox2.Text = Physics_Exchange.atmosphere_exchange_Pascan(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Pascan - atm")
                textBox2.Text = Physics_Exchange.Pascan_exchange_atmosphere(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "mmHg - Pascan")
                textBox2.Text = Physics_Exchange.Millimetre_of_mercury_exchange_Pascan(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Pascan - mmHg")
                textBox2.Text = Physics_Exchange.Pascan_exchange_Millimetre_of_mercury(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "hp - KW")
                textBox2.Text = Physics_Exchange.hp_exchange_KW(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "KW - hp")
                textBox2.Text = Physics_Exchange.KW_exchange_hp(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "kgF/cm^2 - Pascan")
                textBox2.Text = Physics_Exchange.kilogramF_CetimeterSquare_exchange_Pascan(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Pascan - kgF/cm^2")
                textBox2.Text = Physics_Exchange.Pascan_exchange_kilogramF_CetimeterSquare(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "kgF/m - Jun")
                textBox2.Text = Physics_Exchange.KilogramF_Meter_exchange_Jun(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Jun - kgF/m")
                textBox2.Text = Physics_Exchange.Jun_exchange_KilogramF_Meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "lbf/inch^2 - kPa")
                textBox2.Text = Physics_Exchange.lbf_inch_square_exchange_kPa(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "kPa - lbf/inch^2")
                textBox2.Text = Physics_Exchange.kPa_exchange_square_lbf_inch_square(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Kelvin - Celcius")
                textBox2.Text = Physics_Exchange.Kelvin_exchange_Celsius(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Celcius - Kelvin")
                textBox2.Text = Physics_Exchange.Celsius_exchange_Kelvin(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Celcius - Fahrenhit")
                textBox2.Text = Physics_Exchange.Celsius_exchange_fahrenheit(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Fahrenhit - Celcius")
                textBox2.Text = Physics_Exchange.fahrenheit_exchange_Celsius(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Fahrenhit - Kelvin")
                textBox2.Text = Physics_Exchange.fahrenheit_exchange_Kelvin(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Kelvin - Fahrenhit")
                textBox2.Text = Physics_Exchange.Kelvin_exchange_fahrenheit(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Jun - Calo")
                textBox2.Text = Physics_Exchange.Jun_exchange_Calo(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Calo - Jun")
                textBox2.Text = Physics_Exchange.Calo_exchange_Jun(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Radian - C")
                textBox2.Text = Physics_Exchange.Radian_to_C(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "C - Radian")
                textBox2.Text = Physics_Exchange.C_to_Radian(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "tons - kg")
                textBox2.Text = Physics_Exchange.tons_to_kg(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "kg - tons")
                textBox2.Text = Physics_Exchange.kg_to_tons(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "neutrial miles - meter")
                textBox1.Text = Physics_Exchange.nautical_miles_to_meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "meter - neutrial miles")
                textBox1.Text = Physics_Exchange.meter_to_nautical_miles(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "seconds - timeofcasesium")
                textBox2.Text = Physics_Exchange.seconds_to_timeOfCasesium(long.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "timeofcasesium - seconds")
                textBox2.Text = Physics_Exchange.timeOfCasesium_to_second(long.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Ae - kilometer")
                textBox2.Text = Physics_Exchange.Ae_to_kilometer(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "kilometer - Ae")
                textBox2.Text = Physics_Exchange.kilometer_to_Ae(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "meter - Amstrong")
                textBox2.Text = Physics_Exchange.meter_to_Angstrong(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "Amstrong - meter")
                textBox2.Text = Physics_Exchange.Angstrong_to_meter(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text == "YearLight - km")
                textBox2.Text = Physics_Exchange.yearLight_to_km(double.Parse(textBox1.Text)).ToString();
            else if (comboBox1.Text== "kg - Slug")
                textBox2.Text=Physics_Exchange.Kg_to_Slug(double.Parse(textBox1.Text)).ToString();
            else if(comboBox1.Text=="Curie - GBq")
                textBox2.Text=Physics_Exchange.Curie_to_GBq(double.Parse(textBox1.Text)).ToString();
            else if(comboBox1.Text=="GBq - Curie")
                textBox2.Text=Physics_Exchange.GBq_to_Curie(double.Parse(textBox1.Text)).ToString();
            else textBox2.Text = "ERROR";
        }
    }
}
