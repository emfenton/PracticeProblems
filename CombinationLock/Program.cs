using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboLock comboOne = new ComboLock();
            comboOne.newCombination(10, 32, 14);
            comboOne.turnKnob(11);
            comboOne.lockState();
        }
    }

        public class ComboLock
        {
            public int x;
            public int y;
            public int z;
            public int pointer;
            public bool isLocked;

            public ComboLock()
            {
                x = 0;
                y = 0;
                z = 0;
                pointer = 0;
                isLocked = true;
                
            }
            public void newCombination(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public void turnKnob(int a)
            {
                this.pointer = a;
            }
            public void turnKnobRight(int a)
            
            {
                this.pointer = this.pointer + a;
            }
            public void turnKnobLeft(int a)
            {
                this.pointer = this.pointer - a;
            }

            public void closeLock()
            {
                if (this.pointer != z)
                {
                    isLocked = true;
                }
                isLocked = false;
            }

            public bool lockState()
            {
                if (isLocked == true)
                {
                    return true;
                }
                return false;
            }

            public int currentTopNumber()
            {
                return this.pointer;
            }





        }
}
