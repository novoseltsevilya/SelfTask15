using System;
namespace Task1
{
	interface ISeries
	{
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
}