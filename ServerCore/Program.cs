using System;
using System.Threading;
using System.Threading.Tasks;

namespace ServerCore
{
    class Program
    {
        // 1. 근성
        // 2. 양보
        // 3. 갑질

        static object _lock = new object();
        static SpinLock _lock2 = new SpinLock();
        static ReaderWriterLockSlim _lock3 = new ReaderWriterLockSlim();

        // 직접 만든다

        // [ ] [ ] [ ] [ ] [ ]
        class Reward
        {

        }

        // 99.999999%
        static Reward GetRewardById(int id)
        {
            _lock3.EnterReadLock();

            _lock3.ExitReadLock();

            return null;
        }

        // 0.000001%
        static void AddReward(Reward reward)
        {
            _lock3.EnterWriteLock();

            _lock3.ExitWriteLock();
        }

        static void Main(string[] args)
        {
            lock (_lock)
            {

            }
        }
    }
}
