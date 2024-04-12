using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Task_4
{
    internal class Human : ITalk, IReflection
    {
        public void SpeaksLoud() => WriteLine("Говорит громко - Я люблю программирование!");

        public void SpeaksNormal() => WriteLine("Говорит нормально - Меньше люблю компьютерные игры");

        public void Think() => WriteLine("Думает - А С# больше всего");
    }
}
