using System;

namespace Design.Pattern.AbstractClassAndInterface
{
    public class AlarmDoor : Door, IAlarm
    {
        public void Alarm()
        {
            Console.WriteLine("The door is alarmed.");
        }

        public override void Close()
        {
            Console.WriteLine("The door is closed.");
        }

        
    }
}
