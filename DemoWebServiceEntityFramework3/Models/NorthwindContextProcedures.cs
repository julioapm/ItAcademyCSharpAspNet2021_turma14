using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceEntityFramework3.Models
{
    public partial class NorthwindContext
    {

    }

    public partial class NorthwindContextProcedures
    {
        private readonly NorthwindContext _context;
        public NorthwindContextProcedures(NorthwindContext context)
        {
            _context = context;
        }
                public virtual async Task<List<CustOrdersDetailResult>> CustOrdersDetailsAsync(
            int? OrderID, OutputParameter<int> returnValue=null)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };
            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "OrderID",
                    SqlDbType = System.Data.SqlDbType.Int,
                    Value = OrderID ?? Convert.DBNull
                },
                parameterreturnValue
            };
            var result = await _context.Database.ExecuteSqlRawAsync(
                "EXEC @retunValue = [dbo].[CustOrdersDetail] @OrderID",
                sqlParameters
            );
        }

    }

        public class OutputParameter<TValue>
    {
        private bool _valueSet = false;

        public TValue _value;

        public TValue Value
        {
            get
            {
                if (!_valueSet)
                    throw new InvalidOperationException("Value not set.");

                return _value;
            }
        }

        internal void SetValue(object value)
        {
            _valueSet = true;

            _value = null == value || Convert.IsDBNull(value) ? default(TValue) : (TValue)value;
        }
    }
}