using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Exito.CompanyApp.Droid.MVP.Referentials;

namespace Exito.CompanyApp.App.Container
{
    public class AndroidNavigationManager : INavigationManager
    {
        private Context _context;
        private static Type[] TypesCache = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public AndroidNavigationManager(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TView"></typeparam>
        /// <returns></returns>
        private Type GetActivityType<TView>()
        {
            if (TypesCache == null)
            {
                TypesCache = Assembly.GetExecutingAssembly().GetTypes();
            }
            return TypesCache.FirstOrDefault(type => typeof(TView).IsAssignableFrom(type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TView"></typeparam>
        /// <param name="newStack"></param>
        /// <param name="parameters"></param>
        public void Navigate<TView>(bool newStack = false, params ViewParameter[] parameters) where TView : IView
        {
            var activityType = GetActivityType<TView>();

            Intent intent = new Intent(_context, activityType);
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    intent.PutExtra(parameter.ParameterName, parameter.Value);
                }
            }

            intent.AddFlags(ActivityFlags.NewTask);
            if (newStack)
            {
                intent.AddFlags(ActivityFlags.ClearTop);
            }

            _context.StartActivity(intent);
        }

        public void Navigate<TView>() where TView : IView
        {
            var activityType = GetActivityType<TView>();
            Intent intent = new Intent(_context, activityType);
            _context.StartActivity(intent);
        }
    }
}