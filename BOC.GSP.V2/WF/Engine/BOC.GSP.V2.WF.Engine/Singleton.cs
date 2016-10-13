using BOC.GSP.V2.WF.DAL.Models;
using System;
using System.Activities;
using System.Activities.DurableInstancing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BOC.GSP.V2.WF.Engine
{
    /// <summary>
    /// 单例模式的实现
    /// </summary>
    public class Singleton
    {
        // 定义一个静态变量来保存类的实例
        private static Singleton uniqueInstance;

        // 定义一个标识确保线程同步
        private static readonly object locker = new object();

        private WorkflowApplication _wfApp;
        // 定义私有构造函数，使外界不能创建该类实例
        private Singleton(Dictionary<string, object> WFArg = null)
        {
            SqlWorkflowInstanceStore _instanceStore =
  new SqlWorkflowInstanceStore("Server=.;Initial Catalog=WF;Integrated Security=SSPI");
            try
            {
                System.Activities.Activity workflow = new WFInstance();
                if (WFArg != null)
                {
                    _wfApp = new WorkflowApplication(workflow, WFArg);
                }
                else
                {
                    _wfApp = new WorkflowApplication(workflow);
                }

                //_wfApp.SynchronizationContext = SynchronizationContext.Current;
                _wfApp.OnUnhandledException = OnUnhandledException;
                _wfApp.Completed = OnWorkflowCompleted;
                _wfApp.Idle = OnWorkflowIdle;
                _wfApp.PersistableIdle = OnWorkflowPersitableIdle;
                _wfApp.InstanceStore = _instanceStore;
                _wfApp.Extensions.Add(this);
                var instanceHandle = _instanceStore.CreateInstanceHandle();
                var CreateOwnerCmd = new CreateWorkflowOwnerCommand();
                var view = _instanceStore.Execute(instanceHandle, CreateOwnerCmd, TimeSpan.FromSeconds(30));
                _instanceStore.DefaultInstanceOwner = view.InstanceOwner;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance(Dictionary<string, object> WFArg = null)
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            lock (locker)
            {
                // 如果类的实例不存在则创建，否则直接返回

                //if (uniqueInstance == null)
                //{
                uniqueInstance = new Singleton(WFArg);
                //}
            }
            return uniqueInstance;
        }
        public WorkflowApplication CreateApp()
        {
            return _wfApp;
        }

        #region private methord
        private PersistableIdleAction OnWorkflowPersitableIdle
(WorkflowApplicationIdleEventArgs ia)
        {
           return PersistableIdleAction.Unload;
             //return PersistableIdleAction.Persist;
        }
        private UnhandledExceptionAction
OnUnhandledException(WorkflowApplicationUnhandledExceptionEventArgs uh)
        {
            return UnhandledExceptionAction.Terminate;
        }
        private void OnWorkflowCompleted(WorkflowApplicationCompletedEventArgs wc)
        {
        }
        private void OnWorkflowIdle(WorkflowApplicationIdleEventArgs iw)
        {

        }
        #endregion
    }
}
