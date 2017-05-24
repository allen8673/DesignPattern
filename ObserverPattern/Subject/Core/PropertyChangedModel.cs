using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Subject.Core
{
    public abstract class PropertyChangedModel<TModel>
    {
        private event EventHandler PropertyChangedEventHandler;

        public void Register(Action<object, EventArgs> act)
        {
            PropertyChangedEventHandler += new EventHandler(act);
        }

        /// <summary>
        /// 設定Property Value，順便觸發PropertyChangedEvent
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="newValue"></param>
        /// <param name="callerName"></param>
        /// <returns></returns>
        public bool SetValue<TValue>(TValue newValue, [CallerMemberName] string callerName = "")
        {
            PropertyInfo prop = typeof(TModel).GetProperty(callerName);
            if (!EqualityComparer<TValue>.Default.Equals((TValue)prop.GetValue(this), newValue))
            {
                var field = typeof(TModel).GetField($"_{callerName}", BindingFlags.NonPublic | BindingFlags.Instance);
                field.SetValue(this, newValue);
                this.PropertyOnChange();
                return true;
            }

            return false;
        }

        /// <summary>
        /// 取得Property Value
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="callerName"></param>
        /// <returns></returns>
        public TValue GetValue<TValue>([CallerMemberName] string callerName = "")
        {
            var field = typeof(TModel).GetField($"_{callerName}", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field == null) throw new Exception($"Please Set Field Named '_{callerName}'");

            return (TValue)field.GetValue(this);

        }

        /// <summary>
        /// Property改變要觸發的Event
        /// </summary>
        /// <param name="propertyName"></param>
        private void PropertyOnChange()
        {
            if (this.PropertyChangedEventHandler != null)
            {
                PropertyChangedEventHandler(this, new EventArgs());
            }

        }
    }
}
