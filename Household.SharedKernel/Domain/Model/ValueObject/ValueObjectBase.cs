using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.SharedKernel.Domain.Model.ValueObject
{
    public abstract class ValueObjectBase : IComparable, IComparable<ValueObjectBase>
    {
        private int? _cachedHashCode;
        protected abstract IEnumerable<object> GetEqualityComponents();
        public int CompareTo(ValueObjectBase other)
        {
            return CompareTo(other as object);
        }
        public int CompareTo(object obj)
        {
            if (this != (ValueObjectBase)obj)
            {
                return string.Compare(this.ToString(), obj.ToString(), StringComparison.Ordinal);
            }

            var other = (ValueObjectBase)obj;
            object[] components = GetEqualityComponents().ToArray();
            object[] otherComponents = other.GetEqualityComponents().ToArray();
            for (int i = 0; i < components.Length; i++)
            {
                int comparison = CompareComponents(components[i], otherComponents[i]);
                if (comparison != 0)
                    return comparison;
            }
            return 0;
        }

        private int CompareComponents(object object1, object object2)
        {
            if (object1 is null && object2 is null)
                return 0;
            if (object1 is null)
                return -1;
            if (object2 is null)
                return 1;
            if (object1 is IComparable comparable1 && object2 is IComparable comparable2)
                return comparable1.CompareTo(comparable2);
            return object1.Equals(object2) ? 0 : 1;

        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var valueObject = (ValueObjectBase)obj;
            return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
        }
        public override int GetHashCode()
        {
            if (!_cachedHashCode.HasValue)
            {
                _cachedHashCode = GetEqualityComponents()
                    .Aggregate(1, (current, obj) =>
                    {
                        unchecked
                        {
                            return current * 23 + (obj?.GetHashCode() ?? 0);
                        }
                    });
            }
            return _cachedHashCode.Value;
        }

        public static bool operator ==(ValueObjectBase a, ValueObjectBase b)
        {
            if (a is null && b is null)
                return true;
            if (a is null || b is null)
                return true;
            return a.Equals(b);
        }

        public static bool operator !=(ValueObjectBase a, ValueObjectBase b)
        {
            return !(a == b);
        }
    }
}
