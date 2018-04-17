using System;
using System.ComponentModel;
using System.Reflection;

namespace Patterns
{
  public enum PatternsName
    {
        [Description("Одиночка")]
        Singleton = 1,

        [Description("Абстрактная фабрика")]
        AbstractFactory,

        [Description("Наблюдатель")]
        Observer
    }

    public static class EnumHelper
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
    }
}
