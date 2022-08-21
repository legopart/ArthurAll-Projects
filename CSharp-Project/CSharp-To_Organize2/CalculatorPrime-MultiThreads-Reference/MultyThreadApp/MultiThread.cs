using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MultyThreadLibrary;
using MultyThreadApp;
using System.Reflection;
namespace MultyThreadApp
{
    public partial class MultiThread
    {
        public static async Task MultiThread_SetListBox_Async<T1>(T1 _thisLock, ListBox ResultsListBox_Class, long start, long end)
        {

            /*TODO*/
            /*Add multithread Parralel tasking list */
            
            //Dont do .Result inside a task, only await
            Thread mainThread = Thread.CurrentThread;
            int mainThreadId = mainThread.ManagedThreadId;
            mainThread.Name = "Main Thread";


            /* ThreadPool with tsk.Result *
            var tsk1 = new TaskCompletionSource<List<long>>();
            object _o = new object();
            bool thread1 = ThreadPool.QueueUserWorkItem(   //faster
                  (_o) => { lock (_thisLock) { tsk1.TrySetResult(Prime.GetPrimesList(start, end)); } }
                  );
            // tsk result
            ResultsListBox_Class.DataSource = tsk1.Task.Result;
            /* */

            /* new Thread with tsk.Result *
            var tsk2 = new TaskCompletionSource<List<long>>();
            Thread thread2 = new Thread(
                () => { lock (_thisLock) { tsk2.TrySetResult(Prime.GetPrimesList(start, end)); } }
                );
            thread2.Start();     //start only thread1 or thread2
            //thread2.Join(); //Wait and not continue, until the code complete
            // tsk result
            ResultsListBox_Class.DataSource = tsk2.Task.Result;
            /* */


            /* new Thread with Invoke */
            Thread thread3 = new Thread(
                  () => {
                      lock (_thisLock)
                      {
                          ResultsListBox_Class.Invoke( //thread when the button created  //WPF using Dispatcher.Invoke()
                              () => { ResultsListBox_Class.DataSource = Prime.GetPrimesList(start, end); }
                              );
                      }
                  }
                  );
            thread3.Start();     //start only thread1 or thread2 or thread3 or Task
            //thread3.Join(); //Wait and not continue, until the code complete
            /* */


            /* Task.Run with tsk.Result *
            var tsk3 = new TaskCompletionSource<List<long>>();
            await Task.Run(async () => { await Task.Delay(100); tsk3.TrySetResult(Prime.GetPrimesList(start, end)); }).ConfigureAwait(true); //false == do the work without original Task issue, may cause dead lock // Wait and not continue, until the code complete
            /* */


            /* Regular rurnning without threads *
            //main thread run
            ResultsListBox_Class.DataSource = Prime.GetPrimesList(start, end);
            /* */

        }

    }
}