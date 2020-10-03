using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 5. Начальный вклад в банке равен 1000 руб
//Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы.
//По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., и
//вывести  найденное количество месяцев K и итоговый размер вклада S.

//#include <iostream.h>
//#include<conio.h>
//main()
//{
//    double k, p, s, m;
//    long l;
//    int l1, rub;
//    clrscr();
//    cout << "komersant imeet startovii kapital k , kotor.kajdii mesyac uvelichivaetsya na p- procentof ejemesya4no, sobiraet summu s. Vivesti ejemesya4noe zna4enie kapitala poka ne budet dostignuta summa s";

//m1: cout << "\nVV. k,p,s\n"; cin >> k >> p >> s;
//    m = 0;
//    while (k < s)
//    {
//        m++;
//        k = k + k * p / 100;
//        rub = k;
//        l = (k - rub) * 100;

//        l1 = l;
//        cout << m << " m_ " << rub << " rub " << l1 << " kop\n";
//    }
//    cout << "\nkapital dostignet nujnoy summi cherez " << m << " mes";

//    cout << "\nOne More? (1/0)"; cin >> k;
//    if (k == 1) { goto m1; }
//    return 0;
//}
//#include <iostream.h>
//#include <conio.h>
//#include <locale.h>
//#include <math.h>

//main()
//{
//    setlocale(0, "");
//    double x, s, k, p, kopc; long rub, kop, m;

//    do
//    {
//    m1: cout << "FMF SPSU 103 gr., Lysenco\n";
//        cout << "Коммерсант считает прибыль\nИтак, у него есть стартовый капитал, в рублях ПМР: ";
//        cin >> k;
//        cout << "Капитал будет ежемесячно увеличиваться на, процентов: ";
//        cin >> p;
//        cout << "Капитал должен достигнуть суммы: ";
//        cin >> s; m = 0;
//        if (k == s && k != 0 && s != 0) { cout << "\nКапитал равен необходимой сумме, жизнь удалась!"; }
//        if (k > s) { cout << "\nКапитал больше необходимой суммы, банкомат в шоке!"; getch(); clrscr(); goto m1; }
//        if (k <= 0 || p <= 0 || s < 0) { cout << "\nОкей, поигрались, а теперь давай реальные данные!"; getch(); clrscr(); goto m1; }
//        while (k < s)
//        {
//            m++;
//            k = k + k * p / 100;
//            rub = k;
//            kopc = (k - rub) * 100;
//            kop = kopc;
//            cout << "\n" << m;
//            if (m % 100 > 10 && m % 100 < 15) cout << " месяцев";
//            else
//            {
//                switch (m % 10)
//                {
//                    case 0: case 5: case 6: case 7: case 8: case 9: cout << " месяцев"; break;
//                    case 1: cout << " месяц  "; break;
//                    case 2: case 3: case 4: cout << " месяца "; break;
//                }
//            }
//            cout << " = " << rub;
//            if (rub % 100 > 10 && rub % 100 < 15) cout << " рублей";
//            else
//            {
//                switch (rub % 10)
//                {
//                    case 0: case 5: case 6: case 7: case 8: case 9: cout << " рублей"; break;
//                    case 1: cout << " рубль "; break;
//                    case 2: case 3: case 4: cout << " рубля "; break;
//                }
//            }
//            cout << " " << kop;
//            if (kop % 100 > 10 && kop % 100 < 15) cout << " копеек";
//            else
//            {
//                switch (kop % 10)
//                {
//                    case 0: case 5: case 6: case 7: case 8: case 9: cout << " копеек"; break;
//                    case 1: cout << " копейкa"; break;
//                    case 2: case 3: case 4: cout << " копейки"; break;
//                }
//            }


//        }
//        cout << "\n\nТекущая сумма будет достигнута через " << m;
//        if (m % 100 > 10 && m % 100 < 15) cout << " месяцев";
//        else
//        {
//            switch (m % 10)
//            {
//                case 0: case 5: case 6: case 7: case 8: case 9: cout << " месяцев"; break;
//                case 1: cout << " месяц"; break;
//                case 2: case 3: case 4: cout << " месяца"; break;
//            }
//        }

//        cout << "\n\nПрограмма была успешно выполнена. Желаете перезапустить?\n(1/0)";
//        cin >> x; clrscr();
//    }
//    while (x == 1);
//    return 0;
//}
namespace ConsoleAppTask5
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
