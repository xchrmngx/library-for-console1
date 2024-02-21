using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        public static int wages(int time_spent, int salary)
        {
            int fot = salary/100 * 30;// вычисление ФОТ
            
            int bet = (salary + fot) / 168; // ставка
            
            salary  = bet * time_spent; // зарплата



            return salary ;// возвращает salary
        }

        public static int office_equipment(int T)
        {

            int Z = ((T * 95)/100) * 1 * 10;//затраты, связанные с использованием вычислительной и оргтехники
            return Z;
        }

        public static int electricity(int T, double rate)
        {
            double E = (0.094 * T * rate);//затраты на электричество
            int e = Convert.ToInt32(E);
            return e;
        }

        public static int depreciation(int initial_cost)
        {
            int A = ((initial_cost * 30 / 100)/12);
            return A;
        }

        public static int cost_calculation(int wages, int office_equipment, int electricity, int depreciation, int special_products)
        {
            special_products = 0;
            
            int cost = wages*2 + office_equipment + electricity + depreciation + special_products; // подсчёт общих затрат 
            return cost;


            
        }

    }
}
