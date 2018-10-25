using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumniApp.Classes
{
    abstract class GradesHistoryTarget
    {
        /// <summary>
		/// Gets grades of the specified User.
		/// </summary>
		/// <param name="ticker">The ticker symbol of the stock to get price history for.</param>
		public abstract DataTable GetGradesByUserId(int id);

		public abstract string[] GetGradesStringFormat(int id);
    }
}
