using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Utilities
{
    public static class ViewModelFactory
    {

        public static IEnumerable<T> ConvertDTOToViewModelWithLiveData<F, T>(IEnumerable<F> DTOs, object LiveData)
        {
            foreach (F dto in DTOs)
            {
                object[] data = { dto, null };
                yield return (T)Activator.CreateInstance(typeof(T), data);
            }
        }

        public static IEnumerable<T> ConvertDTOToViewModel<F, T>(IEnumerable<F> DTOs)
        {
            foreach(F dto in DTOs)
            {
                yield return (T)Activator.CreateInstance(typeof(T), dto);
            }
        }
    }
}
