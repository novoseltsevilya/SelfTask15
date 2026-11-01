using System;
namespace Task1
{
    public class ArithProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;

        public int StartValue
        {
            get
            {
                return startValue;
            }

            set
            {
                startValue = value;
            }
        }

        public int CurrentValue
        {
            get
            {
                return currentValue;
            }

            set
            {
                currentValue = value;
            }
        }

        public int Step
        {
            get
            {
                return step;
            }

            set
            {
                step = value;
            }
        }

        public int GetNext()
        {
            return CurrentValue += Step;
        }

        public void Reset()
        {
            CurrentValue = StartValue;
        }

        public void SetStart(int x)
        {
            StartValue = x;
            CurrentValue = StartValue;
        }

        public void SetStep(int s)
        {
            Step = s;
        }
    }
}