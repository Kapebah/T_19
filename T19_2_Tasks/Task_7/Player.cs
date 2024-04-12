using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Task_7
{
    class Player : IPlayable, IRecordable
    {
        public void Pause() => WriteLine("Пауза");

        public void Play() => WriteLine("Проигрывание");

        public void Record() => WriteLine("Запись . . .");

        public void Stop() => WriteLine("Выключено");
    }
}
