using System;

namespace ImmutableObjectGraph.CodeGeneration
{
    /// <summary>
    /// Indicates that the generated property getter corresponding to the field to which 
    /// the attribute is applied must be of a specified base type or interface of the field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class PropertyTypeAttribute : Attribute
    {
        public PropertyTypeAttribute(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            Type = type;
        }

        /// <summary>
        /// The <see cref="System.Type"/> to be used for the generated property getter corresponding
        /// to the target field. The <see cref="System.Type"/> must be a base type of, or an interface 
        /// implemented by, the type of the target field.
        /// </summary>
        public Type Type { get; }
    }
}
