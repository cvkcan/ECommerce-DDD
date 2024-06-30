using System.Numerics;

namespace ECommerce_DDD.Domain.SeedWorks
{
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }
            return left?.Equals(right) != false;
        }

        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !EqualOperator(left, right);
        }

        protected static bool EqualOperator(ValueObject left, ValueObject right, BigInteger[] leftValues, BigInteger[] rightValues)
        {
            if (leftValues.Length != rightValues.Length)
            {
                return false;
            }
            for (int i = 0; i < leftValues.Length; i++)
            {
                if (leftValues[i] != rightValues[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
        }
    }
}
