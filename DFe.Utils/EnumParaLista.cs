using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFe.Utils
{
    public static class EnumParaLista
    {
        public static String GetDescription(this Enum item)
        {
            Type tipo = item.GetType();
            FieldInfo fi = tipo.GetField(item.ToString());
            DescriptionAttribute[] atributos =
            fi.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    as DescriptionAttribute[];
            if (atributos.Length > 0)
                return atributos[0].Description;
            else
                return String.Empty;
        }
        public static IList<T> EnumToList<T>()
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }

            return list;
        }
        public static T GetEnumByDescription<T>(String description)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = EnumToList<T>();
            foreach (T item in list)
            {
                if (((Enum)Enum.Parse(typeof(T),
                       item.ToString())).GetDescription() == description)
                    return item;
            }

            throw new Exception("The description is invalid");
        }
    }
}
